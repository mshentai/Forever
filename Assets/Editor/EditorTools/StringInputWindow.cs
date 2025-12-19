using UnityEditor;
using UnityEngine;
using System;

public class StringInputWindow : EditorWindow
{
    private string inputText = "";
    private string message = "请输入:";
    private string confirmButtonText = "确定";
    private string cancelButtonText = "取消";

    private Action<string> onConfirm;
    private Action onCancel;

    private bool shouldClose = false;
    private bool initializedPosition = false;

    public static void Show(
        string message,
        string defaultValue,
        Action<string> onConfirm,
        Action onCancel = null,
        string title = "输入",
        string confirmText = "确定",
        string cancelText = "取消")
    {
        var window = ShowWindow(message, defaultValue, onConfirm, onCancel, title, confirmText, cancelText);
        window.Show();
    }

    public static void ShowModal(
        string message,
        string defaultValue,
        Action<string> onConfirm,
        Action onCancel = null,
        string title = "输入",
        string confirmText = "确定",
        string cancelText = "取消")
    {
        var window = ShowWindow(message, defaultValue, onConfirm, onCancel, title, confirmText, cancelText);
        window.ShowModal();
    }

    private static StringInputWindow ShowWindow(
        string message,
        string defaultValue,
        Action<string> onConfirm,
        Action onCancel = null,
        string title = "提示",
        string confirmText = "确定",
        string cancelText = "取消")
    {
        var window = CreateInstance<StringInputWindow>();
        window.titleContent = new GUIContent(title);
        window.inputText = defaultValue;
        window.message = message;
        window.onConfirm = onConfirm;
        window.onCancel = onCancel;
        window.confirmButtonText = confirmText;
        window.cancelButtonText = cancelText;

        // 计算窗口大小
        float width = 400;
        float height = 140;

        // 居中显示
        Rect mainWindowRect = EditorGUIUtility.GetMainWindowPosition();
        Rect centerRect = new(
            mainWindowRect.x + (mainWindowRect.width - width) * 0.5f,
            mainWindowRect.y + (mainWindowRect.height - height) * 0.5f,
            width,
            height
        );

        window.position = centerRect;
        window.Focus();
        window.shouldClose = false;
        return window;
    }

    private void OnGUI()
    {
        if (shouldClose)
        {
            Close();
            return;
        }

        // 消息文本
        EditorGUILayout.LabelField(message, EditorStyles.wordWrappedLabel);
        EditorGUILayout.Space(10);

        // 输入框
        GUI.SetNextControlName("TextField");
        inputText = EditorGUILayout.TextField(inputText);

        EditorGUILayout.Space(20);

        // 按钮区域
        EditorGUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();

        // 取消按钮
        if (GUILayout.Button(cancelButtonText, GUILayout.Width(80)))
        {
            onCancel?.Invoke();
            shouldClose = true;
        }

        // 确认按钮
        if (GUILayout.Button(confirmButtonText, GUILayout.Width(80)))
        {
            Debug.LogError($"onConfirm: {inputText} {onConfirm}");
            onConfirm?.Invoke(inputText);
            shouldClose = true;
        }

        EditorGUILayout.EndHorizontal();

        // 初始化时聚焦到输入框
        if (!initializedPosition)
        {
            initializedPosition = true;
            EditorGUI.FocusTextInControl("TextField");
        }

        // 处理回车和ESC键
        if (Event.current.isKey)
        {
            switch (Event.current.keyCode)
            {
                case KeyCode.Return:
                case KeyCode.KeypadEnter:
                    onConfirm?.Invoke(inputText);
                    shouldClose = true;
                    Event.current.Use();
                    break;

                case KeyCode.Escape:
                    onCancel?.Invoke();
                    shouldClose = true;
                    Event.current.Use();
                    break;
            }
        }
    }
}