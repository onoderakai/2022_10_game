using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tumayoziController : MonoBehaviour
{
    Rigidbody rb;
    bool isLift = false;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isLift)
        {
            rb.isKinematic = true;
            transform.Translate(0, 0.05f, 0);
        }
        if(transform.position.y >= 10.0f ||
           transform.position.y <= -10.0f)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.collider.tag == "takoyaki" ||
            collision.collider.tag == "player")
        {
            isLift = true;
        }
    }
}
