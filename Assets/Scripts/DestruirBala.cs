using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirBala : MonoBehaviour
{
    public float segundosDesaparecerBala = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Destroy());
    }

    IEnumerator Destroy(){
        yield return new WaitForSeconds(segundosDesaparecerBala);
        Destroy(gameObject);
    }
}
