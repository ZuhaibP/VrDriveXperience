using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClosePauseInstructionButton : MonoBehaviour
{
    public GameObject pauseInstructionPanel; // Reference to the Pause Instruction Panel GameObject

    public void ClosePauseInstruction()
    {
        pauseInstructionPanel.SetActive(false); // Hide the Pause Instruction Panel GameObject
    }
}


