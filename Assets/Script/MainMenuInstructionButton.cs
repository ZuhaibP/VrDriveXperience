using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuInstructionButton : MonoBehaviour
{
    public GameObject mainMenuRawImage; // Reference to the Main Menu Raw Image GameObject
    public GameObject instructionMenuRawImage; // Reference to the Instruction Menu Raw Image GameObject

    public void OpenInstructionMenu()
    {
        mainMenuRawImage.SetActive(false); // Hide the Main Menu Raw Image GameObject
        instructionMenuRawImage.SetActive(true); // Show the Instruction Menu Raw Image GameObject
    }
}


