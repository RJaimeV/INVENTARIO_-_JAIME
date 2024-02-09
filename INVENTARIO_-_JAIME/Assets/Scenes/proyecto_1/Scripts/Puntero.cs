using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Puntero : MonoBehaviour
{
   
    void Update()
    {
        //Esta variable define el movimiento del objeto Puntero para que siga la posición del mouse.
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePosition;
    }

    //Este método define que aparecerá el nombre del objeto con el que colisione el puntero en trigger.
    private void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("Colisionó con: " + coll.gameObject.name);

        
    }

}


