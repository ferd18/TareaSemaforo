using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorDeCarros : MonoBehaviour
{
    public float Randomizer;
    public GameObject Carro1;
    public GameObject Carro2;
    
    public Semaforo1 semaforo1;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarCarro1y3", 0, 1f);
        
    }

    // Update is called once per frame
    void Update()
    {
        print(Randomizer);
    }


    void GenerarCarro1y3()
    {

        if (semaforo1.Semaforo_1y3_Verde)
        {
            Instantiate(Carro1, transform.position, Quaternion.identity);
            Instantiate(Carro2, transform.position, Quaternion.identity);
        }
       
    }

    
}
