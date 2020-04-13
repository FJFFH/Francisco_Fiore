using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_veihculo : MonoBehaviour
{
    public float velocidad;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey("w") && velocidad < 10)
        {
            velocidad = velocidad + 0.2f;
           // transform.position = transform.position + Vector3.forward * Time.deltaTime * velocidad;
            //transform.position = transform.position * velocidad;

        }
        else 
        {
            if (velocidad >= 0)
            {
                velocidad = velocidad - 0.3f;
            }
        }


        if (velocidad > 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
        }




        if (Input.GetKey("d"))
        {

            transform.Rotate(0, 0.2f, 0);
        }

        if (Input.GetKey("a"))
        {

            transform.Rotate(0, -0.2f, 0);
        }






        if (Input.GetKey("s") && velocidad > -5)
        {
            velocidad = velocidad - 0.2f;
            
         
        }

        else
        {
            if (velocidad <= 0)
            {
                velocidad = velocidad + 0.3f;
            }
        }


        if (velocidad < 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
        }


        // transform.position = transform.position - Vector3.forward * Time.deltaTime;
        //rb.AddForce(Vector3.forward * velocidad);
    }
}
