using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestorParticulas : MonoBehaviour
{
    private void OnParticleSystemStopped()
    {
        SceneManager.LoadScene("MainScene");
        //SceneManager.LoadScene(0);
    }
}
