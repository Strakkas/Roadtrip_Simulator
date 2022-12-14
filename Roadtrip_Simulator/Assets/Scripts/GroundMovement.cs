using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    private float speed = 30;

    private Vector3 startPos;
    
    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);

        if(gameObject.transform.position.z < 0)
        {
            transform.position = startPos;
        }
    }
}
