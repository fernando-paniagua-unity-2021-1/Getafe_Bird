using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    public float speed;
    private void Start()
    {
        //Calcular un aleatorio entre -2 y 2
        float offsetY = Random.Range(-2, 2);
        //Calcular la nueva posición del obstaculo en base a sus X y Z, y offsetY como valor Y
        Vector3 nuevaPosicion = new Vector3(
            transform.position.x,
            transform.position.y + offsetY,
            transform.position.z);
        //Asigna la nueva posición al objeto.
        transform.position = nuevaPosicion;
    }
    void Update()
    {
        //Time.deltaTime Tiempo que ha transcurrido desde el último frame
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject,1);
    }
}
