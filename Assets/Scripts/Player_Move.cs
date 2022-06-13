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
    
    //Daño bala
    public LogicaBarraVida logicaBarraVidaJugador;

    //Portales
    public GameObject portal1;
    public GameObject portal2;
    public bool poderDisparar = false;

   [SerializeField] private AudioSource musicaSuspense;

   //portalSoundEffect.Play();

    // Start is called before the first frame update
    void Start()
    {
       musicaSuspense.Play();
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

      if(Input.GetMouseButtonDown(0) && poderDisparar){
         RaycastHit hit;
         if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 150)){
            if(hit.collider.transform.tag != "Lava"){
               portal1.transform.position = hit.point;
               portal1.transform.rotation = Quaternion.FromToRotation(portal1.transform.forward, hit.normal) * portal1.transform.rotation;
               //portal1.transform.RotateAround(portal1.transform.position, Vector3.back, 180);
               portal1.transform.Rotate(0f, 180f, 180f);
               portal1.SetActive(true);
            }
         }
      }
      if(Input.GetMouseButtonDown(1) && poderDisparar){
         RaycastHit hit;
         if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 150)){
            if(hit.collider.transform.tag != "Lava"){
               portal2.transform.position = hit.point;
               portal2.transform.rotation = Quaternion.FromToRotation(portal2.transform.forward, hit.normal) * portal2.transform.rotation;
               //portal2.transform.RotateAround(portal2.transform.position, Vector3.back, 180);
               portal2.transform.Rotate(0f, 180f, 180f);
               portal2.SetActive(true);
            }
         }
      }
    }

   void caer(){
         anim.SetBool("tocarSuelo",false);
         anim.SetBool("saltar",false);
   }
    
   void OnTriggerEnter(Collider other) {
      if(other.tag == "Bala"){
         logicaBarraVidaJugador.vidaActual -= 20;
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
