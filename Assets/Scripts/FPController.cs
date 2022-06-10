using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPController : MonoBehaviour
{
    public Vector2 sensibilidad;
    private new Transform camara;

    // Start is called before the first frame update
    void Start()
    {
        camara = transform.Find("MainCamera");
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Mouse X");
        float vertical = Input.GetAxis("Mouse Y");

        if (horizontal != 0){
            transform.Rotate(Vector3.up * horizontal * sensibilidad.x);
        }

        if (vertical != 0){
            
            float angulo = (camara.localEulerAngles.x - vertical * sensibilidad.y + 360) % 360;
            if (angulo > 180){
                angulo -= 360;
            }
            angulo = Mathf.Clamp(angulo, -80, 60);

            camara.localEulerAngles = Vector3.right * angulo;
        }
    }
}
