using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;

public class PlayerInventory : MonoBehaviour
{
    private int keyCount;
    private int rawImageOpenCount;
    public TextMeshProUGUI keyCountText;
    public RawImage level1RawImage; // Reference to the RawImage for level 1 wall
    public RawImage level2RawImage; // Reference to the RawImage for level 2 wall
    public RawImage level3RawImage; // Reference to the RawImage for level 3 wall
    public GameObject level1WallWithCollider; // Reference to the GameObject with the Box Collider for level 1 wall
    public GameObject level2WallWithCollider; // Reference to the GameObject with the Box Collider for level 2 wall
    public GameObject level3WallWithCollider; // Reference to the GameObject with the Box Collider for level 3 wall

    public float rawImageDisplayDuration = 10f; // Duration in seconds for which the raw image is displayed

    private void Start()
    {
        keyCount = 0;
        rawImageOpenCount = 0;
        UpdateKeyCountText();
    }

    public void CollectKey()
    {
        keyCount++;
        UpdateKeyCountText();

        if (keyCount == 10 && rawImageOpenCount < 1)
        {
            DisableLevel1Wall();
            rawImageOpenCount++;
        }
        else if (keyCount == 25 && rawImageOpenCount < 2)
        {
            DisableLevel2Wall();
            rawImageOpenCount++;
        }
        else if (keyCount == 35 && rawImageOpenCount < 3)
        {
            DisableLevel3Wall();
            rawImageOpenCount++;
        }
    }

    private void UpdateKeyCountText()
    {
        keyCountText.text = "Keys: " + keyCount.ToString();
    }

    private void DisableLevel1Wall()
    {
        Destroy(level1WallWithCollider);
        StartCoroutine(DisplayRawImageUI(level1RawImage, rawImageDisplayDuration));
    }

    private void DisableLevel2Wall()
    {
        Destroy(level2WallWithCollider);
        StartCoroutine(DisplayRawImageUI(level2RawImage, rawImageDisplayDuration));
    }

    private void DisableLevel3Wall()
    {
        Destroy(level3WallWithCollider);
        StartCoroutine(DisplayRawImageUI(level3RawImage, rawImageDisplayDuration));
    }

    private IEnumerator DisplayRawImageUI(RawImage rawImage, float duration)
    {
        rawImage.gameObject.SetActive(true);
        yield return new WaitForSeconds(duration);
        rawImage.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Car") && collision.collider.CompareTag("Animal"))
        {
            keyCount -= 2;
            UpdateKeyCountText();
        }
    }
}
