using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentObstacles : MonoBehaviour
{
    public void InitialImpulse(float speed, Rigidbody ObstacleRb)
    {
        ObstacleRb.AddForce(Vector3.back * speed, ForceMode.Impulse);
    }

    public void CheckBounds()
    {
        if (transform.position.z < -5)
        {
            Destroy(gameObject);
        }
    }

    public virtual void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("player collided with an something");
            Destroy(gameObject);
        }
    }
}
