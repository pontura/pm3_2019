using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textos : MonoBehaviour
{
    public Image imageToFill;
    public Sprite[] numeros;
    public Clock clock;
    private void Start()
    {
        clock.Init();
    }
    void Update()
    {
        for (int a = 0; a < 60; a++)
        {
            if(a== clock.seg)
                imageToFill.sprite = numeros[a];
        }
        
    }
}
