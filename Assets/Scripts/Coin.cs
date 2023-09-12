using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball"))
        {
            Debug.Log("Get score!!");
            gameObject.SetActive(false);

            PlayerController player = GameObject.FindFirstObjectByType<PlayerController>();
            player.AddScore();

        }
    }
}
