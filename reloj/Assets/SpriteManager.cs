using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteManager : MonoBehaviour
{
    public List<Sprite> all;
    public Image image; 
    public Clock clock;

    void Start()
    {
        clock.Init();
    }
    float lastSecond = 13;
    void Update()
    {
        float segundo = clock.seg;
        if (lastSecond != segundo)
        {
            Tick();
            lastSecond = segundo;
        }
    }
    void Tick()
    {
        //muestra una imagen u otra
        print("dibuja la imagen del segundo " + clock.seg);
        image.sprite = all[ (int)clock.seg ];
    }
}
