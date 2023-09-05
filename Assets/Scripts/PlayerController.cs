using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 100f;

    private Rigidbody rb;

    private void Start()
    {
        // link rigid body component from the editor
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float x = 0.0f;
        float y = 0.0f;

        if( Input.GetKey( KeyCode.A ) )
        {
            y = rotationSpeed * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.D))
        {
            y = -rotationSpeed * Time.deltaTime; ;
        }

        if (Input.GetKey(KeyCode.W))
        {
            x = rotationSpeed * Time.deltaTime; ;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            x = -rotationSpeed * Time.deltaTime; ;
        }

        rb.AddTorque(x, 0, y);

    }

}
