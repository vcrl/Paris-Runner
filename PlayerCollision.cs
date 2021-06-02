using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public ParticleSystem hitFX;
    public int playerLives = 3;
    public Rigidbody rb;
    private void OnCollisionEnter(Collision other)
    {
        // .collider to access other data
        if (other.collider.tag == "Obstacle")
        {
            //movement.enabled = false;
            playerLives -= 1;
            PlayHitFX();
        }
    }

    void PlayHitFX()
    {
        hitFX.transform.position = this.transform.position;
        hitFX.Play();
    }

    private void Update()
    {
        if (playerLives <= 0)
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
