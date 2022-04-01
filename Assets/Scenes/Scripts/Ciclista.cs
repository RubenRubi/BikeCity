using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciclista : MonoBehaviour
{

    public float speed;

    public float dirX;

    public float dirY;

    public SpriteRenderer spr;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        dirX = Input.GetAxis("Horizontal");
        dirY = Input.GetAxis("Vertical");

        //transform.position += newVector3(dirC * speed, 0, 0);
        transform.Translate(Vector3.right * dirX * speed);

        transform.Translate(Vector3.up * dirY * speed);


        if (dirX > 0)
        {
            spr.flipX = false;
        }

        if (dirX < 0)
        {
            spr.flipX = true;
        }


        
    }
}
