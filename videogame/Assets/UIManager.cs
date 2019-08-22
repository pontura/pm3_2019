using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text counter;
    public float counterValue;

    void Start()
    {
        Events.OnGrab += OnGrab;
    }
    void OnDestroy()
    {
        Events.OnGrab -= OnGrab;
    }
    void OnGrab(GameObject gameObject)
    {
        float value = gameObject.GetComponent<Coin>().value;
        counterValue = counterValue + value;
        counter.text = counterValue.ToString();
    }
}
