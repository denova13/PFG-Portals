using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOver;
    public static GameOverManager gameOverManager;
    public LogicaBarraVida helperVida;

    // Start is called before the first frame update
    void Start()
    {
        //gameOverManager = this;
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(helperVida.vidaActual <= 0){
            //funcion para terminar el juego o regresar a cheackpoint
            CallGameOver();
            
            //Debug.Log("Game Over");
            //Time.timeScale = 0;
        }
    }

    public void CallGameOver(){
        gameOver.SetActive(true);
        StartCoroutine(ExitGame());
        //ExitGame();
    }


   /* public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }*/
    IEnumerator ExitGame(){
        yield return new WaitForSeconds(2);
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
