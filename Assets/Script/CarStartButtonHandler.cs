using UnityEngine;

public class CarStartButtonHandler : MonoBehaviour
{
    public VehicleControl vehicleControlComponent; // Reference to the Vehicle Control Component
    public AudioSource engineStartSound; // Reference to the audio source for the engine start sound

    private bool buttonPressed = false; // Flag to track if the button is currently pressed

    private void OnTriggerEnter(Collider other)
    {
        // Check if the finger collider enters the button collider
        if (other.CompareTag("FingerCollider"))
        {
            // Set the button pressed flag to true
            buttonPressed = true;

            // Play the engine start sound
            engineStartSound.Play();

            // Invoke the method to enable the vehicle control component after 5 seconds
            Invoke("EnableVehicleControlComponent", 5f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the finger collider exits the button collider
        if (other.CompareTag("FingerCollider"))
        {
            // Set the button pressed flag to false
            buttonPressed = false;
        }
    }

    private void EnableVehicleControlComponent()
    {
        // Check if the button is still pressed
        if (buttonPressed)
        {
            // Enable the vehicle control component
            vehicleControlComponent.enabled = true;
        }
    }
}
