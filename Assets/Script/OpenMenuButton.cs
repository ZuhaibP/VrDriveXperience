using UnityEngine;
using UnityEngine.UI;

public class OpenMenuButton : MonoBehaviour
{
    public GameObject menuRawImage; // Reference to the menu Raw Image GameObject
    public GameObject car; // Reference to the VR car game object with the Vehicle Control component

    private VehicleControl vehicleControl; // Reference to the Vehicle Control component

    void Start()
    {
        vehicleControl = car.GetComponent<VehicleControl>(); // Get the Vehicle Control component
    }

    public void OpenMenu()
    {
        menuRawImage.SetActive(true); // Show the menu Raw Image GameObject

        if (vehicleControl != null)
        {
            vehicleControl.enabled = false; // Disable the Vehicle Control component to prevent car movement
        }
    }
}
