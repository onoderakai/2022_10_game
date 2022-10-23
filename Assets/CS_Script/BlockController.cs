using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    string objTag = "";
    bool isLift=false;
    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid = GetComponent<Rigidbody>();
        ScoreManager.scoreCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isLift)
        {
            transform.Translate(0, 0.05f, 0);
            if(transform.position.y >= 10.0f)
            {
                ScoreManager.scoreCount++;
                Destroy(gameObject);
            }
        }
        //�����蔻��̏�������
        if (objTag == "tumayozi")
        {
            
            isLift = true;
        }

    }
    //�����蔻��
    private void OnCollisionEnter(Collision collision)
    {
        objTag = collision.gameObject.tag;
    }
}
