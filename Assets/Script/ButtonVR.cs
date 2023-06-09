using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    public GameObject carObject; // Reference to the car object
    public VehicleControl vehicleControlComponent; // Reference to the Vehicle Control Component of the car
    public float pressDuration = 2f; // Duration to hold the button in seconds
    public float enableDelay = 4f; // Delay to enable vehicle control component in seconds
    GameObject presser;
    AudioSource sound;
    bool isPressed;
    bool hasStarted;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
        isPressed = false;
        hasStarted = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed && !hasStarted)
        {
            StartCoroutine(StartVehicleCoroutine());
            button.transform.localPosition = new Vector3(0, 0.003f, 0);
            presser = other.gameObject;
            onPress.Invoke();
            sound.Play();
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == presser)
        {
            button.transform.localPosition = new Vector3(0, 0.015f, 0);
            onRelease.Invoke();
            isPressed = false;
        }
    }

    IEnumerator StartVehicleCoroutine()
    {
        yield return new WaitForSeconds(pressDuration);

        // Enable the Vehicle Control Component of the car after the press duration
        vehicleControlComponent = carObject.GetComponent<VehicleControl>();
        vehicleControlComponent.enabled = true;

        yield return new WaitForSeconds(enableDelay - pressDuration);

        // Deactivate the button after the enable delay
        hasStarted = true;
        button.SetActive(false);
    }

    public void SpawnSphere()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = new Vector3(0, 0, 0);
        sphere.transform.localPosition = new Vector3(0, 0, 0);
        sphere.AddComponent<Rigidbody>();
    }
}
