using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public LevelsManager levelsManager;
    public CharactersManager charactersManager;

    void Start()
    {
        levelsManager.Init();
        charactersManager.Init();
    }
}
