using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelperDetectarArma : MonoBehaviour
{
    //Canvas coger pistola
    public PensamientoCogerArmaController helperCanvas;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
      if(other.tag == "Player"){
         helperCanvas.pensamiento.SetActive(true);
      }
    }
}
