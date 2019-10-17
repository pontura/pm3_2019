using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersManager : MonoBehaviour
{
    public Character character_to_instantiate;
    public Character character;

    private void Start()
    {
        Events.OnDoorActive += OnDoorActive;
    }
    void OnDoorActive()
    {
        character.OnPositionate(new Vector3(0, 0, 0));
    }
    public void Init()
    {
        character = Instantiate(character_to_instantiate);
        character.OnPositionate(new Vector3(-4,0,0));
    }
}
