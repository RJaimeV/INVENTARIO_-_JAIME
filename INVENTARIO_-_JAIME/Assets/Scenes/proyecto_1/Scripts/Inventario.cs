using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public List<GameObject> invList = new List<GameObject>();
    public GameObject inv;
    public bool Activarinv;

    public GameObject selector;
    public GameObject opcionEliminar;
    //casilla en el inventario
    public int ID = 0;

    public GameObject descripcionObject;
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.CompareTag("Item"))       
        { 
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
        
        if (Activarinv)
        {
            inv.SetActive(true);
            opcionEliminar.SetActive(true);
            opcionEliminar.transform.position = invList[ID].transform.position;

        }
        else
        {
            inv.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.E)) 
        {
            Activarinv = !Activarinv;
        }

        if (invList[ID].GetComponent<Image>().enabled == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                invList[ID].GetComponent<Image>().sprite = null;
                invList[ID].GetComponent<Image>().enabled = false;
            }
        }

        Navegar();
    } 
}
