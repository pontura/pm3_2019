using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class HoursManager : MonoBehaviour
{
    public Clock clock;
    public Slider slider;
    public VideoPlayer videoPlayer;

    void Start()
    {
    }
    void Update()
    {
        float totalSegundos = 86400;
        float segReal = (clock.seg) + (clock.min * 60) + (clock.hr*60*60);
        float actualFrame = segReal * 55 / totalSegundos;
        print("segReal " + segReal + " fr " + actualFrame);
        videoPlayer.frame = (int)(actualFrame * 27.5f);
        videoPlayer.Pause();
    }
    public void OnSliderChange()
    {
        float newHour = slider.value * 24 / 1;
        clock.ChangeHour(newHour);
    }

}
