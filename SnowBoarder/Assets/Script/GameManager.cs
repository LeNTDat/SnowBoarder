using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    float delayTime = 1.8f;

    public bool isStart { get; set; }
    public bool isStop { get; set; }


    void Start()
    {
        isStart = true;
    }

    void Update()
    {
        
    }



    void ReloadScene()
    {
        Invoke("ReloadScene", delayTime);
        SceneManager.LoadScene(0);
    }
}
