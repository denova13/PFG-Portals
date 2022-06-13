using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PensamientoCogerArmaController : MonoBehaviour
{
    public GameObject pensamiento;
    public bool auxEliminarCanvas = false;

    // Start is called before the first frame update
    void Start()
    {
        pensamiento.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
     if(auxEliminarCanvas){
        StartCoroutine(EliminarCanvasCogerArma());
     }   
    }

    IEnumerator EliminarCanvasCogerArma(){
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
