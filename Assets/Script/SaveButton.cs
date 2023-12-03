using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveButton : MonoBehaviour
{
    public void SaveExperience()
    {
        // Save necessary data or game state using PlayerPrefs
        PlayerPrefs.SetInt("ExperienceSaved", 1);
        PlayerPrefs.Save();

        Debug.Log("Experience saved!");
    }
}

