using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoMovimiento1 : MonoBehaviour{
    
    
    private float Speed = 2f;
    Vector2 FondoPos;
    
    // Start is called before the first frame update
    void Start()  {
        
    }

    // Update is called once per frame
    void Update() {
    
        
    }
     void MoveFondo ()  {

        FondoPos = new Vector2 (Time.time * Speed, 0);
        
        GetComponent<Renderer>().material.mainTextureOffset = FondoPos;
    }
}
 