using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verde : MonoBehaviour
{

    public float Velocidad = 0.5f;
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
