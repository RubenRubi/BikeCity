using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Siguiente : MonoBehaviour
{
    public void AbrirScene1()
    {
        SceneManager.LoadScene("Scene1");
    }
}
