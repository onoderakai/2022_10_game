using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    string objTag = "";
    bool isLift=false;
    Rigidbody rigid;
    //�X�R�A�I�u�W�F�N�g���擾
    //private GameObject scoreManager;
    //ScoreManager scoreScript;

    // Start is called before the first frame update
    void Start()
    {
        //this.scoreManager = GameObject.Find("ScoreManager");
        //this.scoreScript=scoreManager.GetComponent<ScoreManager>();
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
