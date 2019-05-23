using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Image backgroundImage;
    public Color color;
    public GameObject ui;
    public bool isUIOpened;

    void Start()
    {
        ui.SetActive(false);
    }
    void Update()
    {
        backgroundImage.color = color;
    }
    public void OnButtonClick()
    {
        if(isUIOpened)
        {
            ui.SetActive(false);
            isUIOpened = false;
        }
        else
        {            
            ui.SetActive(true);
            isUIOpened = true;
        }
    }
}
