using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody rigid;
    float walkForce = 30.0f;
    float maxWalkForce = 5.0f;

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
            if (!Input.anyKey)
            {
                Vector3 speed;
                speed.x = 0.0f;
                speed.z = 0.0f;
                speed.y = rigid.velocity.y;
                this.rigid.velocity = speed;
            }
            if (Input.GetKey(KeyCode.W) && speedZ < maxWalkForce)
            {
                dir = 1;
                this.rigid.AddForce(transform.forward * dir * this.walkForce);
                //transform.Translate(0, 0, speedZ * dir);
            }
            if (Input.GetKey(KeyCode.A) && speedX < maxWalkForce)
            {
                dir = -1;
                this.rigid.AddForce(transform.right * dir * this.walkForce);
                //transform.Translate(speedX * dir, 0, 0);
            }
            if (Input.GetKey(KeyCode.S) && speedZ < maxWalkForce)
            {
                dir = -1;
                this.rigid.AddForce(transform.forward * dir * this.walkForce);
                //transform.Translate(0, 0, speedZ * dir);
            }
            if (Input.GetKey(KeyCode.D) && speedX < maxWalkForce)
            {
                dir = 1;
                this.rigid.AddForce(transform.right * dir * this.walkForce);
                //transform.Translate(speedX * dir, 0, 0);
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
       
        dir = 0;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "tumayozi")
        {
            isLift = true;
            //Destroy(GetComponent<Rigidbody>());
            //Destroy(gameObject);
        }
    }
}
