using UnityEngine;
using UnityEngine.UI;

public class InstructionPanel : MonoBehaviour
{
    public Button startButton; // Reference to the start button
    public RectTransform instructionPanel; // Reference to the instruction panel RectTransform

    private bool startButtonClicked = false; // Flag to track if the start button has been clicked

    private Vector3 originalPosition; // Original position of the instruction panel
    private float jumpHeight = 10f; // Height of the jump
    private float jumpSpeed = 5f; // Speed of the jump

    private void Start()
    {
        // Make sure the instruction panel is visible at the start
        instructionPanel.gameObject.SetActive(true);

        // Store the original position of the instruction panel
        originalPosition = instructionPanel.anchoredPosition3D;

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
            instructionPanel.anchoredPosition3D = newPosition;
        }
    }

    private void OnStartButtonClicked()
    {
        // Disable the instruction panel and set the flag to true when the start button is clicked
        instructionPanel.gameObject.SetActive(false);
        startButtonClicked = true;
    }
}
