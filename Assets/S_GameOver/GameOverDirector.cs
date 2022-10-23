using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//LoadScene‚ðŽg‚¤‚½‚ß‚É•K—v

public class GameOverDirector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("GameScene");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("GameTitle");
        }
    }
}
