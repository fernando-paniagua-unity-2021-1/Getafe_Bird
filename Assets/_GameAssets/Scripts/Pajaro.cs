using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pajaro : MonoBehaviour
{
    public Rigidbody parteFisica;//Declaración del componente rigidbody

    [Range(1,10)]
    public float velocidad;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X)){
            //parteFisica.AddForce(Vector3.up * 500);
            parteFisica.velocity = new Vector3(0, velocidad, 0);
        }
    }
}
