using UnityEngine;
using UnityEngine.UI;

public class GearInstruction : MonoBehaviour
{
    public Button startButton; // Reference to the start button
    public RawImage rawImage; // Reference to the raw image

    private bool startButtonClicked = false; // Flag to track if the start button has been clicked
    private float openDuration = 8f; // Duration in seconds for which the raw image stays open
    private float currentTimer = 0f; // Timer to track the open duration

    private void Start()
    {
        // Make sure the raw image is hidden at the start
        rawImage.gameObject.SetActive(false);

        // Add a click listener to the start button
        startButton.onClick.AddListener(OnStartButtonClicked);
    }

    private void Update()
    {
        if (startButtonClicked)
        {
            currentTimer += Time.deltaTime;

            if (currentTimer >= openDuration)
            {
                // Close the raw image after the open duration is reached
                rawImage.gameObject.SetActive(false);
                currentTimer = 0f;
                startButtonClicked = false;
            }
        }
    }

    private void OnStartButtonClicked()
    {
        // Enable the raw image and set the flag to true when the start button is clicked
        rawImage.gameObject.SetActive(true);
        startButtonClicked = true;
    }
}
