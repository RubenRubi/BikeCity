using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FoodManager2 : MonoBehaviour
{

    private void Update()
    {
        AllFood();
    }
    public void AllFood()
    {
        if (transform.childCount == 0)
        {
            SceneManager.LoadScene("Final");
        }
    }


}
