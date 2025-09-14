using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using System.IO;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

[InitializeOnLoadAttribute]
public static class TSCMD
{
    public static string cmdIntanceIdPath = System.Environment.CurrentDirectory + "/TSProject/cmd.temp";
    static TSCMD()
    {
        EditorApplication.playModeStateChanged += OnPlayModeChange;
    }

    public static void OnPlayModeChange(PlayModeStateChange playMode)
    {
        if (playMode == PlayModeStateChange.EnteredEditMode || playMode == PlayModeStateChange.EnteredPlayMode)
        {
            Start();
        }
    }

    [MenuItem("Tools/open tsc")]
    public static void Start()
    {
        int instanceId = GetInstanceId();
        try
        {
            var process = Process.GetProcessById(instanceId);
            if (!process.ProcessName.Contains("cmd")) {
                ExecuteTSC();
            }
        } 
        catch
        {
            ExecuteTSC();
        }
    }

    private static void ExecuteTSC()
    {
        var path = System.Environment.CurrentDirectory + "/TSProject/";
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = path + "Atsc.cmd", // 指定要启动的程序
            WorkingDirectory = path,
            UseShellExecute = true, // 不使用shell执行，直接创建进程
        };
        using (var process = Process.Start(startInfo))
        {
            SaveInstanceId(process.Id);
        }
    }

    private static int GetInstanceId()
    {
        if (File.Exists(cmdIntanceIdPath))
        {
            var bytes = File.ReadAllBytes(cmdIntanceIdPath);
            return System.BitConverter.ToInt32(bytes);
        }
        return -1;
    }

    private static void SaveInstanceId(int instanceId)
    {
        var bytes = System.BitConverter.GetBytes(instanceId);
        if (!File.Exists(cmdIntanceIdPath))
        {
            var s = File.Create(cmdIntanceIdPath);
            s.Write(bytes);
            s.Dispose();
        } else
        {
            File.WriteAllBytes(cmdIntanceIdPath, bytes);
        }
    }
}
