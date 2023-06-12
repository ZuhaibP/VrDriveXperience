using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficCone : MonoBehaviour
{
    private PlayerInventory playerInventory; // Reference to the PlayerInventory script

    private void Start()
    {
        playerInventory = FindObjectOfType<PlayerInventory>();
        if (playerInventory == null)
        {
            Debug.LogError("PlayerInventory script not found in the scene!");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Car") && playerInventory != null)
        {
            playerInventory.CollectKey();
        }
    }
}

