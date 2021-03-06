﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pajaro : MonoBehaviour
{
    public AudioClip sonidoAlas;
    public AudioClip sonidoPuntos;
    public AudioSource audioSource;
    public Rigidbody parteFisica;//Declaración del componente rigidbody
    public GameObject prefabSangre;
    [Range(1,10)]
    public float velocidad;
    [Range(1, 10)]
    public float velocidadRotacion;

    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, parteFisica.velocity.y * velocidadRotacion);

        if (Input.GetKeyDown(KeyCode.X)){
            //parteFisica.AddForce(Vector3.up * 500);
            parteFisica.velocity = new Vector3(0, velocidad, 0);
            audioSource.PlayOneShot(sonidoAlas);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Guarda la puntuación máxima
        GameManager gameManager = GameObject.Find("GameManagerObjeto").GetComponent<GameManager>();
        gameManager.GuardarPuntuacionMaxima();
        //Crea una copia del prefab de la explosión en la posición y con la rotación del Pajaro
        Instantiate(prefabSangre, transform.position, transform.rotation);
        //Destruye el pájaro
        Destroy(gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        GameManager gameManager = GameObject.Find("GameManagerObjeto").GetComponent<GameManager>();
        gameManager.AgregarPunto();
        audioSource.PlayOneShot(sonidoPuntos);
    }
}
