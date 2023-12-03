using BNG;
using UnityEngine;

public class StartButtonHandler : MonoBehaviour
{
    public BNGPlayerController playerController; // Reference to the XR Controller component
    public Canvas mainMenuCanvas; // Reference to the Main Menu canvas
    private CharacterController characterController; // Reference to the Character Controller component

    private void Start()
    {
        // Get the Character Controller component from the PlayerController
        characterController = playerController.GetComponent<CharacterController>();
    }

    public void OnStartButtonClick()
    {
        // Disable the Main Menu canvas
        mainMenuCanvas.gameObject.SetActive(false);

        // Enable the Character Controller component on the XR Rig
        characterController.enabled = true;
    }
}
