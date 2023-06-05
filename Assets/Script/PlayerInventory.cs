using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    private int keyCount;
    public TextMeshProUGUI keyCountText;

    private void Start()
    {
        keyCount = 0;
        UpdateKeyCountText();
    }

    public void CollectKey()
    {
        keyCount++;
        UpdateKeyCountText();
    }

    private void UpdateKeyCountText()
    {
        keyCountText.text = "Keys: " + keyCount.ToString();
    }
}
