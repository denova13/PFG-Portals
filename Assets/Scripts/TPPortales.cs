using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPPortales : MonoBehaviour
{
    public Transform posicionSalida;
    public Vector3 teleportSalida;
    public Vector3 longitud;
    public float velocidadEntrada;
    public Transform posicionEntrada;
    public Rigidbody rbPlayer;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //longitud = Vector3.Normalize(transform.position-posicionEntrada.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other) {
        Rigidbody rbEntrada = other.GetComponent<Rigidbody>();
        /*velocidadEntrada = Vector3.Magnitude(rbEntrada.velocity);*/
        

        teleportSalida = posicionSalida.position;
        //teleportSalida.y -= 180; //teleportSalida + new Vector3(0, 180, 0)
        if(other.tag == "Player"){
            Vector3 jugadorPortal = transform.InverseTransformPoint(player.transform.position);
            
            player.transform.position = posicionSalida.position;// new Vector3(-jugadorPortal.x, +jugadorPortal.y, -jugadorPortal.z);

            Quaternion ttt = Quaternion.Inverse(transform.rotation) * player.transform.rotation;
            player.transform.eulerAngles = Vector3.up * (posicionSalida.eulerAngles.y - (transform.eulerAngles.y - player.transform.eulerAngles.y) + 180);

            Vector3 velocidadLocalPlayer = transform.InverseTransformPoint(rbPlayer.velocity);
            rbPlayer.velocity = - posicionSalida.forward * rbPlayer.velocity.y * 20;//( + ); //*velocidadLocalPlayer.z*/
            
               
           
            /*other.transform.position = (teleportSalida);
            other.transform.Rotate(new Vector3(0f, 180f, 0f));*/

            /*Rigidbody rbSalida = other.GetComponent<Rigidbody>();
            rbSalida.velocity = longitud * velocidadEntrada;*/
        }
    }
}
