using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarta : MonoBehaviour
{

    private bool pickUpAllowed;
    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.M))
            PickUp();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Cycling1"))
        {
            pickUpAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Cycling1"))
        {
            pickUpAllowed = false;
        }
    }
    private void PickUp()
    {
        Destroy(gameObject);
    }

}
