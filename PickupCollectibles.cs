using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCollectibles : MonoBehaviour
{
    public Rigidbody rb;
    public AudioSource soundFX;
    public int playerScore;
    public PlayerMovement playerMovement;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Collectible")
        {
            Destroy(other.gameObject);
            playerScore += 1;
            playerMovement.maxSpeed += 1;
            soundFX.Play();
        }
    }
}
