using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasInicial : MonoBehaviour
{
    public GameObject canvasInicial;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EliminarCanvasInicial());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    IEnumerator EliminarCanvasInicial(){
        yield return new WaitForSeconds(5);
        canvasInicial.SetActive(false);
    }
}
