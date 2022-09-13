using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildCrate : ParentObstacles // INHERITANCE
{
    private GameObject playerController;

    private Rigidbody obstacleRb;

    private GameObject mainCamera;
    [SerializeField]
    private AudioClip crashSound;

    private void Awake()
    {
        obstacleRb = gameObject.GetComponent<Rigidbody>();
        InitialImpulse(30, obstacleRb);

        playerController = GameObject.Find("Player");

        mainCamera = GameObject.Find("Main Camera");
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
            mainCamera.GetComponent<AudioSource>().PlayOneShot(crashSound);
            playerController.GetComponent<PlayerController>().gameOver = true;
        }
    }


}
