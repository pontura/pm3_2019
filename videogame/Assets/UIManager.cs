using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text counter;
    public Text levelField;
    public float counterValue;

    void Start()
    {
        Events.OnGrab += OnGrab;
        Events.OnDoorActive += OnDoorActive;
    }
    void OnDestroy()
    {
        Events.OnGrab -= OnGrab;
        Events.OnDoorActive -= OnDoorActive;
    }
    void OnGrab(GameObject gameObject)
    {
        float value = gameObject.GetComponent<Coin>().value;
        counterValue = counterValue + value;
        counter.text = counterValue.ToString();
    }
    void OnDoorActive()
    {
        levelField.text = "Level 2";
    }
}
