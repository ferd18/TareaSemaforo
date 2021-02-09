using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo2 : MonoBehaviour
{
    public GameObject semaforo2y4_verde;
    public GameObject semaforo2y4_amarillo;
    public GameObject semaforo2y4_rojo;
    public bool Semaforo_2y4_Verde;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Semaforo());
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Semaforo2y4Verde()
    {
        semaforo2y4_verde.SetActive(true);
        semaforo2y4_rojo.SetActive(false);
        semaforo2y4_amarillo.SetActive(false);
        Semaforo_2y4_Verde = true;
    }
    void Semaforo2y4Amarillo()
    {
        semaforo2y4_verde.SetActive(false);
        semaforo2y4_rojo.SetActive(false);
        semaforo2y4_amarillo.SetActive(true);
        Semaforo_2y4_Verde = true;
    }
    void Semaforo2y4Rojo()
    {
        semaforo2y4_verde.SetActive(false);
        semaforo2y4_rojo.SetActive(true);
        semaforo2y4_amarillo.SetActive(false);
        Semaforo_2y4_Verde = false;
    }

    IEnumerator Semaforo()
    {
        while (true)
        {

            Semaforo2y4Rojo();
            yield return new WaitForSeconds(2);
            Semaforo2y4Verde();
            yield return new WaitForSeconds(1);
            Semaforo2y4Amarillo();
            yield return new WaitForSeconds(1);
            
        }
    }
}
