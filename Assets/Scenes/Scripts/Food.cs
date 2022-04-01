using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    
    private void Update()
    {
        TodaComida();
    }

    public void TodaComida()
    {
        if (transform.childCount == 1)
        {
            Debug.Log("Victoria");
        }
    }
}
