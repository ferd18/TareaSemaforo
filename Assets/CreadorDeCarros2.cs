using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorDeCarros2 : MonoBehaviour
{
    public float Randomizer;
    public GameObject Carro3;
    public GameObject Carro4;
    public Semaforo2 semaforo2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarCarro2y4", 0, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        print(Randomizer);
    }
    void GenerarCarro2y4()
    {
        if (semaforo2.Semaforo_2y4_Verde)
        {
            Instantiate(Carro3, transform.position, Quaternion.identity);
            Instantiate(Carro4, transform.position, Quaternion.identity);
        }
    }
}
