using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rigidbody;
    float walkForce = 30.0f;
    float maxWalkForce = 5.0f;

    int dir = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.rigidbody=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーの速度
        float speedX = Mathf.Abs(this.rigidbody.velocity.x);
        float speedZ = Mathf.Abs(this.rigidbody.velocity.z);
        
        if (Input.GetKey(KeyCode.W) && speedZ < maxWalkForce)
        {
            dir = 1;
            this.rigidbody.AddForce(transform.forward * dir * this.walkForce);
        }
        if (Input.GetKey(KeyCode.A) && speedX < maxWalkForce)
        {
            dir = -1;
            this.rigidbody.AddForce(transform.right * dir * this.walkForce);
        }
        if (Input.GetKey(KeyCode.S) && speedZ < maxWalkForce)
        {
            dir = -1;
            this.rigidbody.AddForce(transform.forward * dir * this.walkForce);
        }
        if (Input.GetKey(KeyCode.D) && speedX < maxWalkForce)
        {
            dir = 1;
            this.rigidbody.AddForce(transform.right * dir * this.walkForce);
        }
        dir = 0;
    }
}
