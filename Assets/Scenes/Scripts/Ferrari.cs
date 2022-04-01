using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ferrari : MonoBehaviour
{
    public float patrolSpeed = 1f;
    public float mMovementSpeed = 2.0f;
    public bool derecha = true;





    private SpriteRenderer _mSpriteRenderer;


    void Start()
    {
        _mSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        _mSpriteRenderer.flipX = derecha;
    }


    void Update()
    {




        Vector3 directionTranslation = (derecha) ? transform.right : -transform.right;
        directionTranslation *= Time.deltaTime * mMovementSpeed;

        transform.Translate(directionTranslation);


    }
}
