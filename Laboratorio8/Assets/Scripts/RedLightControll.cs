///#########################################################################################
/// <author> Cristian Fernando Laynez Bachez </author>
/// <copyright> Copyright 2020, © Cristian Laynez Productions </copyright>
/// <maintainer> Cristian Laynez Productions </maintainer>
/// <email> lay201281@uvg.edu.gt </email>
/// <status> Student of Computer Science </status>
/// 
/// <proyect> Laboratorio #8 </proyect>
/// <p> El objetivo de este laboratorio es aprender a usar las luces en Unity UwU </p>
/// 
/// <class> Red Light Controlll </class>
/// <summary>
/// Script para controlar la luz roja.
/// </summary>
///#########################################################################################

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLightControll : MonoBehaviour
{    
    [SerializeField] private Light redLight;
    [SerializeField] private float speed = 3.0f;
    [SerializeField] private float amplitude = 10.0f;
   
    private float startIntensity;
   
    // Start is called before the first frame update
    void Start()
    {
        startIntensity = 1;
    }

    /// <summary>
    /// OnTriggerExit es llamado cuando el collier se matiene tocando el trigger.
    /// </summary>
    /// <param name="other">El otro collider involucrado con esta  colision.</param>
    private void OnTriggerStay(Collider other)
    {
        // Detectar al jugador
        if(other.gameObject.CompareTag("Player"))
        {            
            redLight.intensity = startIntensity + (amplitude * Mathf.Sin(Time.time * speed));
        }
    }
    
    /// <summary>
    /// OnTriggerExit es llamado cuando el collier detiene de tocar.
    /// </summary>
    /// <param name="other">El otro collider involucrado con esta  colision.</param>
    private void OnTriggerExit(Collider other)
    {
        redLight.intensity = 0;
    }
}
