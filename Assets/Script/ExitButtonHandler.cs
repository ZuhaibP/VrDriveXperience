using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ExitButtonHandler : MonoBehaviour
{
    public void OnExitButtonClick()
    {
        // Exit play mode
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}

