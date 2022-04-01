using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class salir : MonoBehaviour
{
  void Update()
    {
      if (Input.GetKey("escape"))
      {
        SceneManager.LoadScene("MenuInicio");
        }
    }
}