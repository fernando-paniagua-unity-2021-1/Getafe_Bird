using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefabObstaculo;
    public float pausaEntreSpawn;

    void Start()
    {
        InvokeRepeating("CrearObstaculo", 0, pausaEntreSpawn);
    }

    public void CrearObstaculo()
    {
        Instantiate(prefabObstaculo, transform);
    }
}
