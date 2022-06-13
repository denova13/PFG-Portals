using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOver;
    public LogicaBarraVida helperVida;

    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(helperVida.vidaActual <= 0){
            //funcion para terminar el juego
            CallGameOver();
            
            //Debug.Log("Game Over");
        }
    }

    public void CallGameOver(){
        gameOver.SetActive(true);
        StartCoroutine(ExitGame());
    }

    IEnumerator ExitGame(){
        yield return new WaitForSeconds(2);
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
