//Un refugio de animales rescatados nos pide que le programemos una calculadora de alimento para saber qué costo tendrán 
//que afrontar para darle de comer a sus animales.
//Los datos que tenemos son:
//. Los gatos comen 300 g de alimento por día, y su código es G.
//.Los perros comen 400 g de alimento por día, y su código es PP.
//.Los perros grandes comen 700 g de alimento por día, y su código es PG.
//Realizar el programa que permita ingresar por inspector el código de la categoría del animal y cuántos días va a quedarse.

//El programa debe cumplir los siguientes requerimientos:

//Debe devolver el mensaje “Para ese período se necesitan  ” + [peso en gramos del alimento] + “ gramos de alimento”.

//Sabiendo que el precio del alimento es de $80 por 100g, agregar un mensaje que 
//    muestre el costo de la cantidad de alimento calculada.

//Debe mostrar mensajes de error(y no realizar el cálculo) 
//    si se ingresa un código no válido o si se ingresa una cantidad de días menor a 3.




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio : MonoBehaviour
{
    public string codigo;
    public int dias;
    
    void Start()
    {
        int gramos;
        int Precio = 80;
        if (dias < 3)
        {
            Debug.Log("La cantidad de dias es muy bajo, intente de nuevo");
            Debug.Log("El costo de todos estos alimentos es un total de " + Precio + " pesos");
        }

        else if (codigo == "G")
        {
            gramos = 300 * (dias);
            Precio = 80 * (gramos / 100);
          
            Debug.Log("Para ese período se necesitan " + gramos + " gramos de alimento");
            Debug.Log("El costo de todos estos alimentos es un total de " + Precio + " pesos");
        }

        else if (codigo == "PP")
        {
            gramos = 400 * (dias);
            Precio = 80 * (gramos / 100);
            Debug.Log("Para ese período se necesitan " + gramos + " gramos de alimento");
            Debug.Log("El costo de todos estos alimentos es un total de " + Precio + " pesos");
        }

        else if (codigo == "PG")
        {
            gramos = 400 * (dias);
            Precio = 80 * (gramos / 100);
            Debug.Log("Para ese período se necesitan " + gramos + " gramos de alimento");
            Debug.Log("El costo de todos estos alimentos es un total de " + Precio + " pesos");
        }
        else
        {
            Debug.Log("El codigo ingresado no existe");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
