using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Portales : MonoBehaviour
{
    //public bool movingRing;
    public Portales otherPortal;
    //public float fuerzaSalida=1f;
    
    public Transform bottom;
    //public GameObject teleportingParticles;

    float velocidadEntrada;
    GameObject objetoEntrando;
    Rigidbody rbEntrante;
    Vector3 posicionSalida;
    Vector3 direccion;

    public bool tpEnProceso;

    void Start()
    {
        posicionSalida = transform.position;
        direccion = Vector3.Normalize(transform.position-bottom.position);
    }


    void Update()
    {


    }

    public void ColliderEntersDetector(Collider c)
    {

        Rigidbody r = c.GetComponent<Rigidbody>();
        if (r != null)
        {
            TeleportIn(c.gameObject,r);
        }
    }

    public void TeleportIn(GameObject g,Rigidbody r)
    {

        objetoEntrando = g;
        rbEntrante = r;
        velocidadEntrada = Vector3.Magnitude(rbEntrante.velocity);
        objetoEntrando.SetActive(false);
        /*teleportingParticles.transform.position = objetoEntrando.transform.position;
        teleportingParticles.SetActive(true);*/
        otherPortal.TeleportOut(objetoEntrando,rbEntrante, velocidadEntrada);

    }
    public void TeleportOut(GameObject g, Rigidbody r,float velocidadEntrada)
    {
        tpEnProceso = true;
        r.velocity = direccion * velocidadEntrada /* fuerzaSalida*/;
        g.SetActive(true);
        g.transform.position = posicionSalida;
    }

    public void TelefortFinished()
    {
        tpEnProceso = false;
    }
}
