using UnityEngine;
using UnityEngine.UI;

public class GearInstruction : MonoBehaviour
{
    public Button startButton; // Reference to the start button
    public RawImage rawImage; // Reference to the raw image

    private bool startButtonClicked = false; // Flag to track if the start button has been clicked

    private Vector3 originalPosition; // Original position of the raw image
    private float jumpHeight = 10f; // Height of the jump
    private float jumpSpeed = 5f; // Speed of the jump

    private void Start()
    {
        // Make sure the raw image is hidden at the start
        rawImage.gameObject.SetActive(false);

        // Store the original position of the raw image
        originalPosition = rawImage.transform.position;

        // Add a click listener to the start button
        startButton.onClick.AddListener(OnStartButtonClicked);
    }

    private void Update()
    {
        if (!startButtonClicked)
        {
            // Perform a jumping animation while the start button has not been clicked
            float yOffset = Mathf.Sin(Time.time * jumpSpeed) * jumpHeight;
            Vector3 newPosition = originalPosition + new Vector3(0f, yOffset, 0f);
            rawImage.transform.position = newPosition;
        }
    }

    private void OnStartButtonClicked()
    {
        // Enable the raw image and set the flag to true when the start button is clicked
        rawImage.gameObject.SetActive(true);
        startButtonClicked = true;
    }
}
