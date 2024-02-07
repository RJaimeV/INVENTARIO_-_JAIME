using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espada : Item_base
{
    private void Start()
    {
        SetUp("Espada", "Corta bichos");
    }

    private Tipo tipo;
    private Habilidad habilidad;
    private Rareza rareza;

    public void setTipo(string _tipo)
    {
        tipo.tipo = "diamante";
    }

    public void setHabilidad(string _habilidad)
    {
        habilidad.habilidad = "ataque";
    }

    public void setRareza(string _rareza)
    {
        rareza.rareza = 2;
    }
}
