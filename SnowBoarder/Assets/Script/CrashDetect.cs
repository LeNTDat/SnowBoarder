using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetect : MonoBehaviour
{
    float delayTime = 1.2f;
    [SerializeField] ParticleSystem crashParticle;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.name == "Level Sprite Shape")
        {
            crashParticle.Play();
            Invoke("ReloadScene", delayTime);   
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
