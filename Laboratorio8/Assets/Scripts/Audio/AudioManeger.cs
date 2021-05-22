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
/// <class> Audio Maneger </class>
/// <summary>
/// Script del Audio de Maneger
/// </summary>
///#########################################################################################

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManeger : MonoBehaviour
{
    static bool initialized = false;
    static AudioSource audioSource;
    static Dictionary<AudioClipName, AudioClip> audioClips =
        new Dictionary<AudioClipName, AudioClip>();

    /// <summary>
    /// Obtniene si es un audio o no
    /// </summary>
    public static bool Initialized
    {
        get { return initialized; }
    }

    /// <summary>
    /// Inicializar el Audio Maneger con los audios disponibles
    /// </summary>
    /// <param name="name">nombre del audio que se ejecutará</param>
    public static void Initialize(AudioSource source)
    {
        initialized = true;
        audioSource = source;

        // Sonido de apagar
        audioClips.Add(AudioClipName.OffSound,
             Resources.Load<AudioClip>("OffSound"));        

        // Sonido de encender
        audioClips.Add(AudioClipName.OnSound,
             Resources.Load<AudioClip>("OnSound"));        
    }

    /// <summary>
    /// Ejecuta el audio con el clip y nombre incluido
    /// </summary>
    /// <param name="name">nombre del audio que se ejecutará</param>
    public static void Play(AudioClipName name)
    {
        audioSource.PlayOneShot(audioClips[name]);
    }
}
