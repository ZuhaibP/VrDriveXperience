using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    private int keyCount;
    public TextMeshProUGUI keyCountText;
    public GameObject wallWithCollider; // Reference to the GameObject with the Box Collider

    private void Start()
    {
        keyCount = 0;
        UpdateKeyCountText();
    }

    public void CollectKey()
    {
        keyCount++;
        UpdateKeyCountText();

        if (keyCount >= 10)
        {
            DisableWall();
        }
    }

    private void UpdateKeyCountText()
    {
        keyCountText.text = "Keys: " + keyCount.ToString();
    }

    private void DisableWall()
    {
        Destroy(wallWithCollider);
    }
}
