using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody rigid;
    float walkForce = 30.0f;
    float maxWalkForce = 5.0f;
    string objTag = "";

    int dir = 0;
    bool isLift = false;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーの速度
        float speedX = Mathf.Abs(this.rigid.velocity.x);
        float speedZ = Mathf.Abs(this.rigid.velocity.z);

        if (!isLift)
        {
            Vector3 speed;
            if (!Input.anyKey)
            {
                
                speed.x = 0.0f;
                speed.z = 0.0f;
                speed.y = rigid.velocity.y;
                this.rigid.velocity = speed;
            }
            if (Input.GetKey(KeyCode.W) && speedZ < maxWalkForce)
            {
                dir = -1;
                if (!Input.GetKey(KeyCode.A) &&
                    !Input.GetKey(KeyCode.D))
                {
                    speed.x = 0.0f;
                    speed.z = rigid.velocity.z;
                    speed.y = rigid.velocity.y;
                    this.rigid.velocity = speed;
                }
                this.rigid.AddForce(transform.forward * dir * this.walkForce);
            }
            if (Input.GetKey(KeyCode.A) && speedX < maxWalkForce)
            {
                dir = 1;
                if (!Input.GetKey(KeyCode.W) &&
                    !Input.GetKey(KeyCode.S))
                {
                    speed.x = rigid.velocity.x;
                    speed.z = 0.0f;
                    speed.y = rigid.velocity.y;
                    this.rigid.velocity = speed;
                }
                this.rigid.AddForce(transform.right * dir * this.walkForce);
            }
            if (Input.GetKey(KeyCode.S) && speedZ < maxWalkForce)
            {
                dir = 1;
                if (!Input.GetKey(KeyCode.A) &&
                    !Input.GetKey(KeyCode.D))
                {
                    speed.x = 0.0f;
                    speed.z = rigid.velocity.z;
                    speed.y = rigid.velocity.y;
                    this.rigid.velocity = speed;
                }
                this.rigid.AddForce(transform.forward * dir * this.walkForce);
            }
            if (Input.GetKey(KeyCode.D) && speedX < maxWalkForce)
            {
                dir = -1;
                if (!Input.GetKey(KeyCode.W) &&
                    !Input.GetKey(KeyCode.S))
                {
                    speed.x = rigid.velocity.x;
                    speed.z = 0.0f;
                    speed.y = rigid.velocity.y;
                    this.rigid.velocity = speed;
                }
                this.rigid.AddForce(transform.right * dir * this.walkForce);
            }
            if (transform.position.y <= -10.0f)
            {
                SceneManager.LoadScene("2GameOver");
            }
        }
        else
        {
            transform.Translate(0, 0.05f, 0);
            rigid.isKinematic = true;
            if(transform.position.y >= 5.0f)
            {
                SceneManager.LoadScene("2GameOver");
            }
        }
        //衝突したオブジェクトの条件分岐
        if(objTag == "takoyaki")
        {
            
        }
        else if (objTag == "tumayozi")
        {
            isLift = true;
        }

        dir = 0;
    }
    private void OnCollisionEnter(Collision collision)
    {
        objTag = collision.gameObject.tag;
    }
}
