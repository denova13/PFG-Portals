using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    //Andar
    public float velocidadInicial = 7.0f;
    public float velocidadMovimiento;
    private Animator anim;
    public float x, y;

      //Saltar
    public Rigidbody rb;
    public float fuerzaSalto = 5f;
    public bool puedoSaltar;

    //Correr
    public int velocidadCorrer;

    //Realentizar con daño lava
    public float tiempoRealentizar = 2f;
    

    // Start is called before the first frame update
    void Start()
    {
       puedoSaltar = false;
       anim = GetComponent<Animator>();
    }

   void FixedUpdate()
   {
      //transform.Rotate(0,x*Time.deltaTime*velocidadRotacion, 0);
      transform.Translate(0,0,y*Time.deltaTime*velocidadMovimiento);
   }

    // Update is called once per frame
    void Update()
    {
      //x = Input.GetAxis("Horizontal");
      y = Input.GetAxis("Vertical");

      //anim.SetFloat("VelX", x);
      anim.SetFloat("VelY", y);
      
      if(puedoSaltar){
         if(Input.GetKeyDown(KeyCode.Space)){
            anim.SetBool("saltar",true);
            rb.AddForce(new Vector3(0, fuerzaSalto,0), ForceMode.Impulse);
         }
         anim.SetBool("tocarSuelo",true);
      }else{
         caer();
      }

      if(Input.GetKey(KeyCode.LeftShift) && puedoSaltar){
         velocidadMovimiento = velocidadCorrer;
         if(y > 0){
            anim.SetBool("correr", true);
         }else{
            anim.SetBool("correr", false);
         }
      }else{
         anim.SetBool("correr", false);
         if(puedoSaltar){
            velocidadMovimiento = velocidadInicial;
         }
      }

      void caer(){
         anim.SetBool("tocarSuelo",false);
         anim.SetBool("saltar",false);
      }
    }

    
    
   




    /*public void helperRutina(){
       StartCoroutine(RealentizarJugador());
    }

    IEnumerator RealentizarJugador(){
        var velocidadActual = velocidadMovimiento;
        velocidadMovimiento = 0;
        yield return new WaitForSeconds(tiempoRealentizar);
        velocidadMovimiento = velocidadActual;
    }*/
}
