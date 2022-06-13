using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTorreta : MonoBehaviour
{
    public Transform objetivo;
    public Transform torreta;
    public Transform bala;
    public Transform zonaSalidaBala;
    public double tiempo;
   // public Transform helper;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other) {
        tiempo += Time.deltaTime;
        if(other.transform == objetivo)
        {
            torreta.transform.LookAt(objetivo);

            if(tiempo>1400)
            {Instantiate(bala, zonaSalidaBala.position, zonaSalidaBala.rotation);
            tiempo = 0.0;
                //StartCoroutine(MoverBala());
            }

         }
    }

    IEnumerator MoverBala(){
        yield return new WaitForSeconds(1);
        bala.Translate(0,10, 0);
        
    }
}
