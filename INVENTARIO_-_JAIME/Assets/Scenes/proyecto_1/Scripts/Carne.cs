using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carne : Item_base
{
    private void Start()
    {
        SetUp("Carne", "Alimento de dioses");
    }

    private Tipo tipo;
    private Habilidad habilidad;
    private Rareza rareza;

    public void setTipo(string _tipo)
    {
        tipo.tipo = "comida";
    }

    public void setHabilidad(string _habilidad)
    {
        habilidad.habilidad = "alimento";
    }

    public void setRareza(string _rareza)
    {
        rareza.rareza = 1;
    }
}
