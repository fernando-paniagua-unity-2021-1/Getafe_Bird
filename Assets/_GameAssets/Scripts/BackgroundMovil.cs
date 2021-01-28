using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovil : MonoBehaviour
{
    [Header("Velocidad del scroll")]
    [Range(0,0.5f)]
    public float speed;
    [Header("Componente MeshRenderer")]
    public Renderer renderer;

    private Material materialBG;

    void Start()
    {
        materialBG = renderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = materialBG.mainTextureOffset;
        float x = offset.x + (speed * Time.deltaTime);
        materialBG.mainTextureOffset = new Vector2(x, offset.y);
    }
}
