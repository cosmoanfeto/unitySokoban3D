using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{

    public Text UITexto;
    // Update se llama una vez por frame
    void Update()
    {
        TimeSpan t = TimeSpan.FromSeconds(Time.time);
        UITexto.text = string.Format("{0:D2}:{1:D2}:{2:D2}", t.Minutes, t.Seconds, t.Milliseconds);
    }
}
