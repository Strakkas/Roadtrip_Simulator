using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTurning : MonoBehaviour
{
    private float turnAngle = 12;
    [SerializeField]
    private GameObject playerController;
    private Rigidbody carRigidbody;

    private void Start()
    {
        carRigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    { 
        if (playerController.GetComponent<PlayerController>().gameOver == false)
        {
            float horizontalInput = Input.GetAxis("Horizontal");

            gameObject.transform.eulerAngles = new Vector3(
                gameObject.transform.eulerAngles.x,
                turnAngle * horizontalInput,
                gameObject.transform.eulerAngles.z);
        } else
        {
            carRigidbody.constraints = RigidbodyConstraints.None;
        }
    }
}
