using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    //Esta lista define los Slots que se utilizan en el inventario.
    public List<GameObject> invList = new List<GameObject>();
    //Este GameObject es el inventario.
    public GameObject inv;
    //Este bool define si est� activo el inventario.
    public bool Activarinv;

    //Define la visi�n de posici�n en el inventario.
    public GameObject selector;
    //Objeto que detecta la imagen para eliminar.
    public GameObject opcionEliminar;
    //Casilla en el inventario.
    public int ID = 0;

    //Este m�todo define que sucede cuando el puntero colisiona con otro objeto con el Tag "Item".
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.CompareTag("Item"))       
        { 
            //Esta parte va realizando un conteo seg�n hayamos definido en la capacidad de Slots para habilitar las imagenes de los objetos colisionados.
            for (int i = 0; i < invList.Count; i++)
            {
                if (invList[i].GetComponent<Image>().enabled == false)
                {
                    invList[i].GetComponent<Image>().enabled = true;
                    invList[i].GetComponent<Image>().sprite = coll.GetComponent<SpriteRenderer>().sprite;
                    break;
                }
            }
        }
    }

    //Esta parte define como podemos movernos en el inventario calculando con la variable ID y el n�mero de la lista del inventario el lugar en el que nos encontramos.
    public void Navegar()
    {
        if (Input.GetKeyDown(KeyCode.W) && ID < invList.Count - 1)
        {
            ID++;
        }
        if (Input.GetKeyDown(KeyCode.S) && ID > 0)
        {
            ID--;
        }


        selector.transform.position = invList[ID].transform.position;
    }
    void Update()
    {
       //Aqu� se selecciona si el inventario est� activo o no. 
        if (Activarinv)
        {
            inv.SetActive(true);
            //Define que se activa la opci�n de eliminar la imagen en la que se encuentra posicionado el selector.
            opcionEliminar.SetActive(true);
            opcionEliminar.transform.position = invList[ID].transform.position;

        }
        else
        {
            inv.SetActive(false);
        }

        //Aqu� se define con qu� letra se accionar� o des-accionar� el inventario.
        if(Input.GetKeyDown(KeyCode.E)) 
        {
            Activarinv = !Activarinv;
        }

        //Aqu� se menciona que si la imagen en el inventario est� habilitada puede el usuario con la letra F eliminar el sprite y volver a inabilitar la imagen del Slot.
        if (invList[ID].GetComponent<Image>().enabled == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                invList[ID].GetComponent<Image>().sprite = null;
                invList[ID].GetComponent<Image>().enabled = false;
            }
        }
        //Cargar el m�todo Navegar en Update.
        Navegar();
    } 
}
