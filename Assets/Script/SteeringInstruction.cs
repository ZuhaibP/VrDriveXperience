using UnityEngine;
using UnityEngine.UI;

public class SteeringInstruction : MonoBehaviour
{
    public Button startButton; // Reference to the start button
    public RawImage rawImage; // Reference to the raw image

    private bool startButtonClicked = false; // Flag to track if the start button has been clicked

    private void Start()
    {
        // Add a click listener to the start button
        startButton.onClick.AddListener(OnStartButtonClicked);
    }

    private void Update()
    {
        if (!startButtonClicked)
        {
            // Perform any desired animation or behavior while waiting for the start button to be clicked
        }
    }

    private void OnStartButtonClicked()
    {
        // Disable the start button when it is clicked
        startButton.interactable = false;

        // Start the coroutine to open and close the raw image after a delay
        StartCoroutine(OpenAndCloseRawImage());
    }

    private System.Collections.IEnumerator OpenAndCloseRawImage()
    {
        yield return new WaitForSeconds(10f); // Wait for 10 seconds

        rawImage.gameObject.SetActive(true); // Open the raw image

        yield return new WaitForSeconds(6f); // Keep the raw image open for 6 seconds

        rawImage.gameObject.SetActive(false); // Close the raw image

        // Re-enable the start button after the raw image is closed
        startButton.interactable = true;
    }
}
