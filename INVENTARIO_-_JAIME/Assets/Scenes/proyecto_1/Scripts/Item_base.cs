using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Item_base : MonoBehaviour
{
    //Aquí se define que cualquier objeto que colisione con otro será destruido.
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }

    public string nombre;
    public Sprite sprite;
    public float vida;
    public string descripcion;
   
    public void Start()
    {
        GetComponent<SpriteRenderer>().sprite = sprite;       

        Antorcha antrocha = GetComponent<Antorcha>();
    }

    public virtual void SetUp(string _nombre,  string _descripcion)
    {
        nombre = _nombre; 
        descripcion = _descripcion;
        GetComponent<SpriteRenderer>().sprite = sprite;
    }

}

public class Tipo
{
    public string tipo;
}

public class Habilidad
{
    public string habilidad;
}

public class Rareza
{
    public int rareza;

}



