using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class test : MonoBehaviour
{
    public int valor = 20;
    public test()
    {
    }
    public void extraerValor()
    {
        Debug.Log("El valor es: " + valor);
    }

    public class Clasederivada : test
    {
        public Clasederivada()
        {
        }

        public virtual void extraerValor()
        {
            Debug.Log("El valor es: " + (valor * 2));
        }
    }
    public void Start()
    {
        test baseClass = new test();
        baseClass.extraerValor();

        Clasederivada derivadaClass = new Clasederivada();
        derivadaClass.extraerValor();
    }
}
