using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speedX = 0.1f;
        float speedZ = 0.1f;
       
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speedZ);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speedX, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speedZ);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speedX, 0, 0);
        }
    }
}
