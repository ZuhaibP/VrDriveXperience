using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionButtonHandler : MonoBehaviour
{
    public GameObject instructionPanel; // Reference to the InstructionPanel GameObject
    public GameObject mainMenuCanvas; // Reference to the Main Menu canvas GameObject

    public void OnInstructionButtonClick()
    {
        // Disable the Main Menu canvas
        mainMenuCanvas.SetActive(false);

        // Show the InstructionPanel
        instructionPanel.SetActive(true);
    }
}


