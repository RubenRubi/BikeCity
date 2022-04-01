using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escarabajo : MonoBehaviour
{

    public float Velocidad = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += transform.right * Velocidad * Time.deltaTime;
    }
}
