using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButtonHandler : MonoBehaviour
{
    public GameObject mainMenuCanvas; // Reference to the main menu canvas GameObject
    public GameObject instructionPanel; // Reference to the instruction panel GameObject

    public void OnMainMenuButtonClick()
    {
        // Enable or show the main menu canvas
        mainMenuCanvas.SetActive(true);

        // Disable or hide the instruction panel
        instructionPanel.SetActive(false);
    }
}

