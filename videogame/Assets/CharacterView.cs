using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterView : MonoBehaviour
{
    public void Flip(int value)
    {
        transform.localScale = new Vector3(value, 1, 1);
    }
}
