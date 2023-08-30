using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class test2 : MonoBehaviour
{
    public string nombre;

    public test2(string nombre)
    {
        this.nombre = nombre;
    }

    public abstract void HaceSonido();
}

public class test2chevere : test2
{

    public test2chevere(string nombre) : base(nombre)
    {
    }

    public override void HaceSonido()
    {
        Debug.Log("sonidochevere");
    }
}
