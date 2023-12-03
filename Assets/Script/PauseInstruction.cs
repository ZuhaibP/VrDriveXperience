using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseInstruction : MonoBehaviour
{
    public GameObject pauseInstructionRawImage; // Reference to the Pause Instruction Raw Image GameObject

    void Start()
    {
        pauseInstructionRawImage.SetActive(false); // Hide the Pause Instruction Raw Image GameObject initially
    }

    public void OpenPauseInstruction()
    {
        pauseInstructionRawImage.SetActive(true); // Show the Pause Instruction Raw Image GameObject
    }
}


