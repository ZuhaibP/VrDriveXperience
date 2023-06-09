using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class StartButtonHandler : MonoBehaviour
{
    public XRController xrController; // Reference to the XR Controller component
    public Canvas mainMenuCanvas; // Reference to the Main Menu canvas

    public void OnStartButtonClick()
    {
        // Disable the Main Menu canvas
        mainMenuCanvas.gameObject.SetActive(false);

        // Enable the XR Controller component on the XR Rig
        xrController.enabled = true;
    }
}
