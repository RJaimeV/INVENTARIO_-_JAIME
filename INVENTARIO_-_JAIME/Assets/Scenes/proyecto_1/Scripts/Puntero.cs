using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Puntero : MonoBehaviour
{
   
    void Update()
    {
        //Esta variable define el movimiento del objeto Puntero para que siga la posici�n del mouse.
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePosition;
    }

    //Este m�todo define que aparecer� el nombre del objeto con el que colisione el puntero en trigger.
    private void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("Colision� con: " + coll.gameObject.name);

        
    }

}


