using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    string objTag = "";
    bool isLift=false;
    Rigidbody rigid;
    //スコアオブジェクトを取得
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
        //当たり判定の条件分岐
        if (objTag == "tumayozi")
        {
            
            isLift = true;
        }

    }
    //当たり判定
    private void OnCollisionEnter(Collision collision)
    {
        objTag = collision.gameObject.tag;
    }
}
