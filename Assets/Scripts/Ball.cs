using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SlotTrigger"))
        {
            Destroy(gameObject);
        }
    }
}
