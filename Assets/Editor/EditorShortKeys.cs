using UnityEngine;
using UnityEditor;
using System.Collections;

public class EditorShortKeys : ScriptableObject
{
    [MenuItem("HotKey/Run _F5")]
    static void PlayGame()
    {
        EditorApplication.ExecuteMenuItem("Edit/Play");
    }

    [MenuItem("HotKey/Run _F9")]
    static void PauseGame()
    {
        EditorApplication.ExecuteMenuItem("Edit/Pause");
    }

    [MenuItem("HotKey/Run _F10")]
    static void StepGame()
    {
        EditorApplication.ExecuteMenuItem("Edit/Step");
    }
}