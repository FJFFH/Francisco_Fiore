using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Van2 : MonoBehaviour
{
    
    public float velocidad = 0;
    public float velocidadr = 30;
    //public Vector3 Masa = Vector3.zero;

    //public Transform Izquierda;
    //public Transform Derecha;

    // Start is called before the first frame update
    void Start()
    {
        WheelCollider wc = GetComponent<WheelCollider>();

        Rigidbody rb = GetComponent<Rigidbody>();
        // rb.centerOfMass = Masa;

        if (Input.GetKey("a"))
        {

            wc.transform.Rotate(0, -0.5f, 0);
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(0, 0, velocidad);


        if (Input.GetKey("w"))
        {
            velocidad = velocidad + 0.2f;


        }
      //  float rotation = Input.GetAxis("Vertical") * velocidadr;
       // Izquierda.localEulerAngles = new Vector3(0, rotation, 0);
       // Derecha.localEulerAngles = new Vector3(0, rotation, 0);


    }/*
    private void Update()
    {
        if (Input.GetKey("w"))
        {
            velocidad = velocidad + 0.2f;


        }
    }*/
}