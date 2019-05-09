using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    // Start is called before the first frame update
   // public Text horas;
   // public Text minutos;
   // public Text segundos;

    public float seg = 0;
    public float min = 0;
    public float hr = 0;

    //public float num = 0;
    public float speed;

    public void Init(bool _InitLocalTime = true)
    {
        Tick();
        if (_InitLocalTime)
            InitLocalTime();
    }
    public void SetTime(float _hr, float _min, float _seg)
    {
        hr = _hr;
        min = _min;
        seg = _seg;

    }

     void InitLocalTime()
    {

        //par poner hora actual
        seg = System.DateTime.Now.Second;
        //  segundos.text = seg.ToString();
        min = System.DateTime.Now.Minute;
        //  minutos.text = min.ToString();
        hr = System.DateTime.Now.Hour;
        //  horas.text = hr.ToString();

    }
    // Update is called once per frame
    void Tick(){  
           // num += 1;
        Tiempo();
            Invoke("Tick", speed);
   
        }
    void Tiempo()
    {
        seg++;
        if (seg >= 59)
        {
            seg = 0;
            min++;
            if (min >= 59)
            {
                min = 0;
                hr++;
                if (hr > 24)
                {
                    hr++;

                }
            }
        }

    }

   public void ChangeSpeed(float value)
    {
        if (value < 0)
            speed = 0;
        
        else if (value > 1)
            speed = 1;

        speed = value;
    }

    void Update()
    {
        //      num += Time.deltaTime;
        //        field.text = num.ToString();
      //  segundos.text = seg.ToString();
        // minutos.text = min.ToString();
        // horas.text = hr.ToString();

    }
}
