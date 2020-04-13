using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento_veihculo2 : MonoBehaviour
{
    public Transform frontLeftWheel;
    public Transform frontRightWheel;

    private float motorForce = 0;
    public float speed = 50;
    public float maxSteerAngle = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        motorForce = Input.GetAxis("Vertical") * speed;

        rigidbody.AddForce(0, 0, motorForce);

        float rotation = Input.GetAxis("Horizontal") * maxSteerAngle;

        frontLeftWheel.localEulerAngles = new Vector3(0, rotation, 0);
        frontRightWheel.localEulerAngles = new Vector3(0, rotation, 0);
        
        WheelCollider wh = GetComponent<WheelCollider>();

        /*
        if (Input.GetKey("r"))
        {
            wh.transform.Rotate(0, -0.5f, 0);

        }
        */

    }
}
