using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Choque : MonoBehaviour
{
    private bool chocar;
    
    private void Start()
    {
    }

    
    private void Update()
    {
        if (chocar)
            PickUp();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Lee")){
            chocar = true;
       
        }
        if (collision.gameObject.name.Equals("Lambo")){
            chocar = true;
       
        }
        if (collision.gameObject.name.Equals("Escarabajo")){
            chocar = true;
        }
       
        if (collision.gameObject.name.Equals("Ferrari")){
            chocar = true;
        }

        if (collision.gameObject.name.Equals("Verde"))
        {
            chocar = true;
        }

        if (collision.gameObject.name.Equals("Amarillo"))
        {
            chocar = true;
        }

        if (collision.gameObject.name.Equals("Naranja"))
        {
            chocar = true;
        }

        if (collision.gameObject.name.Equals("Ferrari2"))
        {
            chocar = true;
        }
        if (collision.gameObject.name.Equals("Classic"))
        {
            chocar = true;
        }
    }

    private void PickUp()
    {
        //Destroy(gameObject);
        SceneManager.LoadScene("Scene1");
    }
}