using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comida : MonoBehaviour
{
    
    private void Update()
    {
        TodaComida();
    }

    public void TodaComida()
    {
        if (transform.childCount == 0)
        {
            Debug.Log("Victoria");
        }
    }
}
