using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UIの表示に必要

public class ScoreManager : MonoBehaviour
{
    public GameObject scoreManager;
    public static int scoreCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Textコンポーネントを取得
        Text scoreText = scoreManager.GetComponent<Text>();
        //表示を入れ替える
        scoreText.text = "" + scoreCount;
    }
}
