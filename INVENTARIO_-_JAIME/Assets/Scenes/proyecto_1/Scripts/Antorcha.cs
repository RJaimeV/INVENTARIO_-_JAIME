using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Antorcha : Item_base
{
    private void Start()
    {
        SetUp("Antorcha", "Ilumina tu camino");
    }

    private Tipo tipo;
    private Habilidad habilidad;
    private Rareza rareza;

    public void setTipo(string _tipo)
    {
        tipo.tipo = "madera";
    }

    public void setHabilidad(string _habilidad)
    {
        habilidad.habilidad = "Luz";
    }

    public void setRareza(string _rareza)
    {
        rareza.rareza = 1;
    }
}





