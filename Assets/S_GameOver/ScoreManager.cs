using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI�̕\���ɕK�v

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
        //Text�R���|�[�l���g���擾
        Text scoreText = scoreManager.GetComponent<Text>();
        //�\�������ւ���
        scoreText.text = "" + scoreCount;
    }
}
