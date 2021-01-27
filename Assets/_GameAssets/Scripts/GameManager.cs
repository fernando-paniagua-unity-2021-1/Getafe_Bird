using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int puntuacion=0;
    public Text textoPunt;

    public void AgregarPunto()
    {
        puntuacion++;
        textoPunt.text = puntuacion.ToString();
    }
}
