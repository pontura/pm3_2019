using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersManager : MonoBehaviour
{
    public Character character_to_instantiate;
    public Character character;

    public void Init()
    {
        character = Instantiate(character_to_instantiate);
        character.OnPositionate(new Vector3(-4,0,0));
    }
}
