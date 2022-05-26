using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public Rigidbody rb;
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d")){
           rb.velocity = transform.right * 5;
        }
        if(Input.GetKey("a")){
           rb.velocity = -transform.right * 5;
        }
    }
}
