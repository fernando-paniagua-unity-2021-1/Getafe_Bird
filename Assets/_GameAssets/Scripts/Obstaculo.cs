using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    public float speed;
    void Update()
    {
        //Time.deltaTime Tiempo que ha transcurrido desde el último frame
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
