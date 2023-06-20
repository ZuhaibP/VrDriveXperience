using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    private int keyCount;
    public TextMeshProUGUI keyCountText;
    public GameObject level1WallWithCollider; // Reference to the GameObject with the Box Collider for level 1 wall
    public GameObject level2WallWithCollider; // Reference to the GameObject with the Box Collider for level 2 wall
    public GameObject level3WallWithCollider; // Reference to the GameObject with the Box Collider for level 3 wall

    private void Start()
    {
        keyCount = 0;
        UpdateKeyCountText();
    }

    public void CollectKey()
    {
        keyCount++;
        UpdateKeyCountText();

        if (keyCount >= 10 && keyCount < 25)
        {
            DisableLevel1Wall();
        }
        else if (keyCount >= 25 && keyCount < 35)
        {
            DisableLevel2Wall();
        }
        else if (keyCount >= 35)
        {
            DisableLevel3Wall();
        }
    }

    private void UpdateKeyCountText()
    {
        keyCountText.text = "Keys: " + keyCount.ToString();
    }

    private void DisableLevel1Wall()
    {
        Destroy(level1WallWithCollider);
    }

    private void DisableLevel2Wall()
    {
        Destroy(level2WallWithCollider);
    }

    private void DisableLevel3Wall()
    {
        Destroy(level3WallWithCollider);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Car") && collision.collider.CompareTag("TrafficCone"))
        {
            keyCount--;
            UpdateKeyCountText();
        }
    }
}
