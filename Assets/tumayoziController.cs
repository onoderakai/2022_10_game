using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tumayoziController : MonoBehaviour
{
    float gravity = 0.0f;
    float velocityY = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        velocityY -= gravity;
        transform.Translate(0, velocityY, 0);
        

    }
   
}
