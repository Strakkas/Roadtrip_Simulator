using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildPowerup : ParentObstacles // INHERITANCE
{
    private GameObject playerController;
    private Rigidbody obstacleRb;

    private void Awake()
    {
        playerController = GameObject.Find("Player");
        obstacleRb = gameObject.GetComponent<Rigidbody>();

        InitialImpulse(40, obstacleRb);
    }

    void Update()
    {
        CheckBounds();
    }

    // POLYMORPHISM
    override public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerController.GetComponent<PlayerController>().PlayerGotPowerup();
            Destroy(gameObject);
        }
    }
}
