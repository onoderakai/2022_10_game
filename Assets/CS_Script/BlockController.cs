using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    bool isLift=false;
    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isLift)
        {
            transform.Translate(0, 0.05f, 0);
            if(transform.position.y >= 10.0f)
            {
                Destroy(gameObject);
            }
        }
    }
    //“–‚½‚è”»’è
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "tumayozi")
        {
            isLift= true;
        }
       
    }
}
