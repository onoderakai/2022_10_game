using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockGenerator : MonoBehaviour
{
    public GameObject blockPrefab;

    // Start is called before the first frame update
    void Start()
    {
        const int maxX = 20;
        const int maxZ = 20;

        for(int z = 0; z < maxZ; z++)
        {
            for(int x = 0; x < maxX; x++)
            {
                GameObject create = Instantiate(blockPrefab) as GameObject;

                create.transform.position = new Vector3(x * 0.8f, 0, z * 0.8f);
            }
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
