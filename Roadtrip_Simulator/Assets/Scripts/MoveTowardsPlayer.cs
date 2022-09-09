using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour
{
    public float speed;
    private Rigidbody crateRb;

    // Start is called before the first frame update
    void Start()
    {
        crateRb = gameObject.GetComponent<Rigidbody>();

        crateRb.AddForce(Vector3.back * speed, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.z < -5)
        {
            Destroy(gameObject);
        }
    }
}
