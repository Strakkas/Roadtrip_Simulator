using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float turnSpeed;
    public float turnAngle;
    public float sideBounds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        ConstrainPlayerPosition();

        // make the car model turn around Y axis while its turning
        // propably make an empty that will move side to side and
        // make a child that is the model and it would only turn on a sort
        // of a turntable
        // camera will also be connected to the empty
        // collisisons will be handeled by the model and car
    }

    // thats for moving the player
    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * turnSpeed * horizontalInput * Time.deltaTime);

        // this part succesfully turns the vehicle around Y axis
        // now i just have to detatch it so that the car doesnt go backwards
        // or find a way to use global coordinate system to use

        
    }

    // this is to not let them crash into bariers
    void ConstrainPlayerPosition()
    {
        if (transform.position.x < -sideBounds)
        {
            transform.position = new Vector3(-sideBounds, transform.position.y, transform.position.z);
        }
        if (transform.position.x > sideBounds)
        {
            transform.position = new Vector3(sideBounds, transform.position.y, transform.position.z);
        }
    }
}
