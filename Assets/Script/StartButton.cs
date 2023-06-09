using UnityEngine;
using UnityEngine.XR;

public class StartButton : MonoBehaviour
{
    // Define a reference to the car or any other object you want to control
    public GameObject car;

    // Set a flag to track if the button is currently being pressed
    private bool isButtonPressed = false;

    // Reference to the vehicle control component
    private VehicleControl vehicleControl;

    // Sound effect to play when starting the car
    public AudioClip startSound;

    // Audio source to play the sound effect
    private AudioSource audioSource;

    private void Start()
    {
        // Get the VehicleControl component from the car object
        vehicleControl = car.GetComponent<VehicleControl>();

        // Get or add an AudioSource component to the button object
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
            audioSource = gameObject.AddComponent<AudioSource>();

        // Set the start sound clip
        audioSource.clip = startSound;
    }

    // Update is called once per frame
    void Update()
    {
        // Check for button press input
        if (isButtonPressed == false && Input.GetButtonDown("Fire1")) // Modify "Fire1" to the appropriate button name for your XR input system
        {
            // Start the car or trigger your desired action
            vehicleControl.enabled = true;

            // Play the start sound effect
            audioSource.Play();

            // Set the button as pressed
            isButtonPressed = true;
        }
    }

    // Detect finger or controller collision with the button
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finger") && isButtonPressed == false)
        {
            // Start the car or trigger your desired action
            vehicleControl.enabled = true;

            // Play the start sound effect
            audioSource.Play();

            // Set the button as pressed
            isButtonPressed = true;
        }
    }

    // Reset the button state when the finger or controller leaves the button collider
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Finger"))
        {
            // Reset the button state
            isButtonPressed = false;
        }
    }
}
