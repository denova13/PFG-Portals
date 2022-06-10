using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primera_Persona : MonoBehaviour
{
    public float velocidadEjeH;
    public float velocidadEjeV;

    private float helper1;
    private float helper2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         helper1 += velocidadEjeH * Input.GetAxis("Mouse X");
         helper2 -= velocidadEjeV * Input.GetAxis("Mouse Y");

         transform.eulerAngles = new Vector3(helper2,helper1,0.0f);
    }
}
