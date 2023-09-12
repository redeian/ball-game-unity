using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            PlayerController player = GameObject.FindFirstObjectByType<PlayerController>();
            player.AddKey();

            gameObject.SetActive(false);

        }
    }
}
