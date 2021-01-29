using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int puntuacion=0;
    public Text textoPunt;
    public Text textoMax;
    public Text textoComenzar;
    public Text textoPausa;
    private int maximo;
    private void Awake()
    {
        //Pausamos el juego
        Time.timeScale = 0;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Time.timeScale == 0 && Input.GetKeyDown(KeyCode.X))
        {
            Time.timeScale = 1;
            textoComenzar.enabled = false;
            textoPausa.enabled = false;
        }
        if (Time.timeScale == 1 && Input.GetKeyDown(KeyCode.P))
        {
            Time.timeScale = 0;
            textoPausa.enabled = true;
        }
    }
    private void Start()
    {
        //Leer el máximo almacenado (si no existe se le asigna 0)
        maximo = PlayerPrefs.GetInt("Maximo", 0);
        //Mostrar en el campo del UI el texto
        textoMax.text = "Max.:" + maximo;
    }
    public void AgregarPunto()
    {
        puntuacion++;
        textoPunt.text = puntuacion.ToString();
    }
    public void GuardarPuntuacionMaxima()
    {
        if (puntuacion > maximo)
        {
            PlayerPrefs.SetInt("Maximo", puntuacion);
            PlayerPrefs.Save();
        }
    }
}
