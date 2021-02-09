using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo1 : MonoBehaviour
{
    public GameObject semaforo1y3_verde;
    public GameObject semaforo1y3_amarillo;
    public GameObject semaforo1y3_rojo;
    public bool Semaforo_1y3_Verde;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Semaforo());
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Semaforo1y3Verde()
    {
        semaforo1y3_verde.SetActive(true);
        semaforo1y3_rojo.SetActive(false);
        semaforo1y3_amarillo.SetActive(false);
        Semaforo_1y3_Verde = true;
    }
    void Semaforo1y3Amarillo()
    {
        semaforo1y3_verde.SetActive(false);
        semaforo1y3_rojo.SetActive(false);
        semaforo1y3_amarillo.SetActive(true);
        Semaforo_1y3_Verde = true;
    }
    void Semaforo1y3Rojo()
    {
        semaforo1y3_verde.SetActive(false);
        semaforo1y3_rojo.SetActive(true);
        semaforo1y3_amarillo.SetActive(false);
        Semaforo_1y3_Verde = false;
    }

    IEnumerator Semaforo()
    {
        while (true)
        {
            Semaforo1y3Verde();
            yield return new WaitForSeconds(1);
            Semaforo1y3Amarillo();
            yield return new WaitForSeconds(1);
            Semaforo1y3Rojo();
            yield return new WaitForSeconds(2);
        }
    }
}
