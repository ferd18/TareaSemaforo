using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro4 : MonoBehaviour
{
    public GameObject Semaforo;
    public float Velocidad = 4f;
    public bool Control;
    // Start is called before the first frame update
    void Start()
    {
        Control = false;
        transform.position = new Vector2(12.24f, 0.12f);
        transform.Rotate(0, 0, 90, Space.Self);
        Semaforo = GameObject.Find("Semaforo2");
    }

    // Update is called once per frame
    void Update()
    {
        if (Semaforo.GetComponent<Semaforo2>().Semaforo_2y4_Verde || Control)
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
