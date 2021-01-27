using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pajaro : MonoBehaviour
{
    public AudioSource audioSource;
    public Rigidbody parteFisica;//Declaración del componente rigidbody
    public GameObject prefabSangre;
    [Range(1,10)]
    public float velocidad;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X)){
            //parteFisica.AddForce(Vector3.up * 500);
            parteFisica.velocity = new Vector3(0, velocidad, 0);
            audioSource.Play();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Crea una copia del prefab de la explosión en la posición y con la rotación del Pajaro
        Instantiate(prefabSangre, transform.position, transform.rotation);
        //Destruye el pájaro
        Destroy(gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        GameManager gameManager = GameObject.Find("GameManagerObjeto").GetComponent<GameManager>();
        gameManager.AgregarPunto();
    }
}
