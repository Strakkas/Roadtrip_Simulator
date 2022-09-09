using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTurning : MonoBehaviour
{
    private float turnAngle = 12;

    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        gameObject.transform.eulerAngles = new Vector3(
            gameObject.transform.eulerAngles.x,
            turnAngle * horizontalInput,
            gameObject.transform.eulerAngles.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("player collided with an obstacle");
            //dorzucic kawalek kodu ktory zatrzymuje gre
        }
        if (collision.gameObject.CompareTag("Powerup"))
        {
            Debug.Log("player got a powerup");
            Destroy(collision.gameObject);
        }
    }
}
