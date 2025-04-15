using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class ColoniaDeVacaciones : MonoBehaviour
{
    int cantidadCoordinadores;
    public int cantidadInfantiles;
    int profesInfantiles;
    public int cantidadJuveniles;
    int profesJuveniles;
    int cantidadDeJuvenilesPorProfesor = 20;
    int cantidadDeInfantilesPorProfesor = 10;
    int cantidadDeProfesoresPorCoordinador = 5;
    int listaDeEspera;
    int coordinadores;

    // Start is called before the first frame update
    void Start()
    {
        if(cantidadJuveniles < 0 || cantidadInfantiles < 0 || cantidadInfantiles > 100 || cantidadJuveniles > 100)
        {
            Debug.Log("Ingrese cantidades validas");
            return;
        }
        profesInfantiles = cantidadInfantiles / cantidadDeInfantilesPorProfesor;
        listaDeEspera = cantidadInfantiles % cantidadDeInfantilesPorProfesor;
        profesJuveniles = cantidadJuveniles / cantidadDeJuvenilesPorProfesor;
        listaDeEspera += cantidadJuveniles % cantidadDeJuvenilesPorProfesor;
        coordinadores = (profesJuveniles + profesInfantiles) / (cantidadDeProfesoresPorCoordinador);
        if((profesJuveniles + profesInfantiles) % (cantidadDeProfesoresPorCoordinador) != 0)
        {
            coordinadores += 1;
        }
        Debug.Log("Se necesitan " + profesJuveniles + " profesores para los inscriptos juveniles");
        Debug.Log("Se necesitan " + profesInfantiles + " profesores para los inscriptos infantiles");
        Debug.Log("Se necesitan " + coordinadores + " para la cantidad de profesores");
        Debug.Log("Hay " + listaDeEspera + " chicos en lista de espera");





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
