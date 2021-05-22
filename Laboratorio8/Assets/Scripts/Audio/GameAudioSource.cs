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
/// Script para levantar el Audio Source
/// </summary>
///#########################################################################################

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAudioSource : MonoBehaviour
{
    /// <summary>
    /// Awake es llamado cuando el script es cargado
    /// </summary>
    private void Awake()
    {
        // Tenemos que asegurarnos que solo tengas uno de estos
        // en el game object
        if(!AudioManeger.Initialized)
        {
            // Inicializar el audio maneger y persistir el audio source
            AudioSource audioSource = gameObject.AddComponent<AudioSource>();
            AudioManeger.Initialize(audioSource);
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Duplicaremos el game object, así que lo destruiremos
            Destroy(gameObject);
        }
    }
}
