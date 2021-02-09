using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro2 : MonoBehaviour
{
    public GameObject Semaforo;
    public float Velocidad = 2f;
    public bool Control;

    void Start()
    {
        Control = false;
        transform.position = new Vector2(-0.94f, 6.09f);
        transform.Rotate(0, 0, -180, Space.Self);
        Semaforo = GameObject.Find("Semaforo1");
    }


    void Update()
    {
        if (Semaforo.GetComponent<Semaforo1>().Semaforo_1y3_Verde || Control)
        {
            transform.Translate(new Vector2(0, 2f) * Velocidad * Time.deltaTime);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Destroyer")
        {
            Destroy(this.gameObject);
        }

        if (collision.tag == "Control")
        {
            Control = true;
        }
    }
}
