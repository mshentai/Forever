using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Lunar.Core
{
    public static class LLog
    {
        #region 配置
        private static LogLevel currentLogLevel = LogLevel.Verbose;
        private static bool enableUnityConsole = true;
        private static bool enableFileLogging = false;
        private static string logFilePath;
        private static readonly object fileLock = new object();
        #endregion

        #region 初始化
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Initialize()
        {
            // 读取配置
            LoadConfig();

            // 初始化文件日志
            if (enableFileLogging)
            {
                InitializeFileLogging();
            }

            // 注册异常处理
            Application.logMessageReceived += OnUnityLogMessageReceived;

            Info("Logger系统初始化完成", "Logger");
        }

        private static void LoadConfig()
        {
            // 从配置读取或设置默认值
#if DEVELOPMENT_BUILD || UNITY_EDITOR
            currentLogLevel = LogLevel.Verbose;
            enableUnityConsole = true;
            enableFileLogging = true;
#else
            currentLogLevel = LogLevel.Info;
            enableUnityConsole = false;
            enableFileLogging = true;
#endif
        }

        private static void InitializeFileLogging()
        {
            // 平台检测
            RuntimePlatform platform = Application.platform;

            switch (platform)
            {
                case RuntimePlatform.WebGLPlayer:
                    enableFileLogging = false;
                    Warning("WebGL平台禁用文件日志");
                    return;

                case RuntimePlatform.Android:
                case RuntimePlatform.IPhonePlayer:
                    // 移动平台检查存储空间
                    if (!HasEnoughStorage())
                    {
                        enableFileLogging = false;
                        Warning("存储空间不足，禁用文件日志");
                        return;
                    }
                    break;

                case RuntimePlatform.WindowsPlayer:
                case RuntimePlatform.OSXPlayer:
                case RuntimePlatform.LinuxPlayer:
                case RuntimePlatform.WindowsEditor:
                case RuntimePlatform.OSXEditor:
                case RuntimePlatform.LinuxEditor:
                    // 这些平台完全支持
                    break;

                default:
                    // 未知平台默认禁用
                    enableFileLogging = false;
                    Warning($"未知平台 {platform}，禁用文件日志");
                    return;
            }

            try
            {
                string logDir = Path.Combine(Application.persistentDataPath, "Logs");

                // 安全创建目录
                if (!Directory.Exists(logDir))
                {
                    Directory.CreateDirectory(logDir);
                }

                // 生成日志文件路径
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                logFilePath = Path.Combine(logDir, $"game_{timestamp}.log");

                // 写入初始信息
                string header = $"=== Game Log Started at {DateTime.Now} ===\n";
                header += $"Platform: {Application.platform}\n";
                header += $"Version: {Application.version}\n";
                header += $"Unity: {Application.unityVersion}\n";
                header += "===================================\n";

                File.AppendAllText(logFilePath, header);

                Info($"文件日志初始化成功: {logFilePath}");
            }
            catch (System.UnauthorizedAccessException)
            {
                enableFileLogging = false;
                Error("文件日志权限不足");
            }
            catch (System.IO.IOException ioEx)
            {
                enableFileLogging = false;
                Error($"文件日志IO错误: {ioEx.Message}");
            }
            catch (System.Exception e)
            {
                enableFileLogging = false;
                Error($"文件日志初始化异常: {e.Message}");
            }
        }

        private static bool HasEnoughStorage()
        {
#if UNITY_ANDROID || UNITY_IOS
            try
            {
                // 简单的存储空间检查
                string testPath = Path.Combine(Application.persistentDataPath, "storage_test.tmp");
                File.WriteAllText(testPath, "test");
                File.Delete(testPath);
                return true;
            }
            catch
            {
                return false;
            }
#else
            return true;
#endif
        }
        #endregion

        #region 核心日志方法
        public static void Verbose(string message, string tag = "", UnityEngine.Object context = null)
        {
            LogInternal(LogLevel.Verbose, message, tag, context);
        }

        public static void Debug(string message, string tag = "", UnityEngine.Object context = null)
        {
            LogInternal(LogLevel.Debug, message, tag, context);
        }

        public static void Info(string message, string tag = "", UnityEngine.Object context = null)
        {
            LogInternal(LogLevel.Info, message, tag, context);
        }

        public static void Warning(string message, string tag = "", UnityEngine.Object context = null)
        {
            LogInternal(LogLevel.Warning, message, tag, context);
        }

        public static void Error(string message, string tag = "", UnityEngine.Object context = null)
        {
            LogInternal(LogLevel.Error, message, tag, context);
        }

        public static void Critical(string message, string tag = "", UnityEngine.Object context = null)
        {
            LogInternal(LogLevel.Critical, message, tag, context);
        }

        public static void Assert(bool condition, string message, UnityEngine.Object context = null)
        {
            if (!condition)
            {
                Error($"Assertion failed: {message}", "Assert", context);
            }
        }
        #endregion

        #region 内部实现
        private static void LogInternal(LogLevel level, string message, string tag, UnityEngine.Object context)
        {
            // 级别过滤
            if (level < currentLogLevel) return;

            string formattedMessage = FormatMessage(level, message, tag);

            // 输出到Unity控制台
            if (enableUnityConsole)
            {
                LogToUnityConsole(level, formattedMessage, context);
            }

            // 输出到文件
            if (enableFileLogging)
            {
                LogToFile(level, formattedMessage);
            }

            // 触发日志事件
            OnLog?.Invoke(level, message, tag);
        }

        private static string FormatMessage(LogLevel level, string message, string tag)
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss.fff");
            string levelStr = GetLevelString(level);
            string tagStr = string.IsNullOrEmpty(tag) ? "" : $"[{tag}]";

            return $"{timestamp} {levelStr}{tagStr} {message}";
        }

        private static string GetLevelString(LogLevel level)
        {
            return level switch
            {
                LogLevel.Verbose => "[VERBOSE]",
                LogLevel.Debug => "[DEBUG]",
                LogLevel.Info => "[INFO]",
                LogLevel.Warning => "[WARNING]",
                LogLevel.Error => "[ERROR]",
                LogLevel.Critical => "[CRITICAL]",
                _ => "[UNKNOWN]"
            };
        }

        private static void LogToUnityConsole(LogLevel level, string message, UnityEngine.Object context)
        {
            switch (level)
            {
                case LogLevel.Warning:
                    UnityEngine.Debug.LogWarning(message, context);
                    break;
                case LogLevel.Error:
                case LogLevel.Critical:
                    UnityEngine.Debug.LogError(message, context);
                    break;
                default:
                    UnityEngine.Debug.Log(message, context);
                    break;
            }
        }

        private static void LogToFile(LogLevel level, string message)
        {
            if (string.IsNullOrEmpty(logFilePath)) return;

            lock (fileLock)
            {
                try
                {
                    File.AppendAllText(logFilePath, message + "\n");
                }
                catch (Exception e)
                {
                    UnityEngine.Debug.LogError($"写入日志文件失败: {e.Message}");
                }
            }
        }
        #endregion

        #region 高级功能
        // 性能监控
        public static IDisposable MeasureTime(string operationName, string tag = "")
        {
            return new TimeMeasurement(operationName, tag);
        }

        private class TimeMeasurement : IDisposable
        {
            private string operationName;
            private string tag;
            private System.Diagnostics.Stopwatch stopwatch;

            public TimeMeasurement(string name, string logTag)
            {
                operationName = name;
                tag = logTag;
                stopwatch = System.Diagnostics.Stopwatch.StartNew();
            }

            public void Dispose()
            {
                stopwatch.Stop();
                Debug($"{operationName} 耗时: {stopwatch.ElapsedMilliseconds}ms", tag);
            }
        }

        // 关键事件标记
        public static void MarkEvent(string eventName, Dictionary<string, object> data = null)
        {
            string dataStr = data != null ? $" Data: {SerializeData(data)}" : "";
            Info($"🔖 {eventName}{dataStr}", "Event");
        }

        private static string SerializeData(Dictionary<string, object> data)
        {
            return JsonHelper.ToJson(data);
        }
        #endregion

        #region 事件和回调
        public static event Action<LogLevel, string, string> OnLog;

        private static void OnUnityLogMessageReceived(string condition, string stackTrace, LogType type)
        {
            // 可以在这里捕获Unity自身的日志并统一处理
            if (type == LogType.Exception)
            {
                Error($"Unity异常: {condition}\n{stackTrace}", "Unity");
            }
        }
        #endregion

        #region 配置管理
        public static void SetLogLevel(LogLevel level)
        {
            currentLogLevel = level;
            Info($"日志级别设置为: {level}", "Logger");
        }

        public static void EnableFileLogging(bool enable)
        {
            enableFileLogging = enable;
            if (enable && string.IsNullOrEmpty(logFilePath))
            {
                InitializeFileLogging();
            }
        }

        public static string GetLogFilePath()
        {
            return logFilePath;
        }
        #endregion
    }
}