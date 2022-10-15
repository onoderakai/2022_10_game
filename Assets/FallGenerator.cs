using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallGenerator : MonoBehaviour
{
    GameObject player;
    public GameObject fallPrefab;
    float span = 3.0f;
    float delta = 0.0f;

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
            delta = 0.0f;
            GameObject go =Instantiate(fallPrefab) as GameObject;
            Vector3 pos = player.transform.position;
            go.transform.position = new Vector3(pos.x, 10, pos.z);
        }
    }
}
