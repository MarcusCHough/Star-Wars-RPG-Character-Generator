using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SessionManager : MonoBehaviour
{
    private static SessionManager _instance;

    private const string _SpeciesFile = @"D:\Project Files\Unity Projects\Star-Wars-RPG-Character-Generator\Star Wars RPG Character Generator\Assets\Species.json";
    private static List<Species> speciesList { get; }

    public static SessionManager Instance { get { return _instance; } }
    

    private void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    private void Start()
    {
        SpeciesManager specMang = new SpeciesManager();
        string list = specMang.LoadSpecies(_SpeciesFile);
    }

}
