using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResumeButton : MonoBehaviour
{
    public GameObject menuRawImage; // Reference to the menu Raw Image GameObject
    public GameObject car; // Reference to the VR car game object with the Vehicle Control component

    private VehicleControl vehicleControl; // Reference to the Vehicle Control component

    void Start()
    {
        vehicleControl = car.GetComponent<VehicleControl>(); // Get the Vehicle Control component
    }

    public void Resume()
    {
        menuRawImage.SetActive(false); // Hide the menu Raw Image GameObject

        if (vehicleControl != null)
        {
            vehicleControl.enabled = true; // Enable the Vehicle Control component to allow car movement
        }
    }
}

