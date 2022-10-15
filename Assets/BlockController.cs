using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //“–‚½‚è”»’è
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "tumayozi")
        {
            Destroy(gameObject);
        }
       
    }
}
