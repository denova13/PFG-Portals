using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraPortal : MonoBehaviour
{
    public Transform camaraPrincipal;
    public Transform camaraPortal;
    public Transform portal;
    public Player_Move player;

    Rigidbody rbPlayer;
    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*Quaternion direccion = Quaternion.Inverse(transform.rotation) * camaraPrincipal.rotation;

        camaraPortal.transform.localEulerAngles = new Vector3 (direccion.localEulerAngles.x, direccion.localEulerAngles.y + 180, direccion.localEulerAngles.z);*/
    }

    private void OnTriggerStay(Collider other){
        if(other.tag == "Player"){
            Vector3 tpJugador = transform.InverseTransformPoint(player.transform.position);

            if(tpJugador.z <= 0.02){
                //player.transform.position = OtherPortal.position
            }
        }
    }
}
