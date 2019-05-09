using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnalogClock : MonoBehaviour
{
    public Clock clock;

    public GameObject aguja_segundos;
    public GameObject aguja_minutos;
    public GameObject aguja_horas;
    //float _z_rotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        clock.Init();
    }

    // Update is called once per frame
    void Update()
    {
        // _z_rotation--;
        float value = clock.seg * 360 / 60 *-1;
        aguja_segundos.transform.localEulerAngles = new Vector3(0, 0, value);
        float valuemin = clock.min * 360 / 60 * -1;
        aguja_minutos.transform.localEulerAngles = new Vector3(0, 0, valuemin);
        float valuehr = clock.hr * 360 / 12 * -1;
        aguja_horas.transform.localEulerAngles = new Vector3(0, 0, valuehr);
    }
}
