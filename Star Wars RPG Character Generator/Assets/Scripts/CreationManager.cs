using Assets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationManager : MonoBehaviour
{
    private static CreationManager _instance;
    private Character character;
    private CharacterManager characterManager;

    public static CreationManager Instance { get { return _instance; } }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    public void CreateNewCharacter()
    {
        character = new Character();
        characterManager = new CharacterManager();
    }
}
