using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonesVelocidad : MonoBehaviour
{
    public void lento()
    {
        Time.timeScale = 0.7f;
    }

    public void Rapido()
    {
        Time.timeScale = 6;
    }


    public void Normal()
    {
        Time.timeScale = 1;
    }
}
