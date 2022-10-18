using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallGenerator : MonoBehaviour
{
    GameObject player;
    public GameObject fallPrefab;
    //スクリプトを取得
    public blockGenerator blockGenerator;
    float span = 3.0f;
    float delta = 0.0f;
    int count = 0;
    Vector3 pos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("takoyaki");

    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > span)
        {
            count++;
            delta = 0.0f;
            GameObject go =Instantiate(fallPrefab) as GameObject;
            pos = player.transform.position;
            go.transform.position = new Vector3(pos.x, 5, pos.z);
        }
        if (count > 1)
        {
            for(int i = 0; i < 3; i++)
            {
                count = 0;
                GameObject go = Instantiate(fallPrefab) as GameObject;
                pos.x = Random.Range(0, blockGenerator.maxRangeX);
                pos.z = Random.Range(0, blockGenerator.maxRangeZ);
                go.transform.position = new Vector3(pos.x, 5, pos.z);
            }
        }
    }
}
