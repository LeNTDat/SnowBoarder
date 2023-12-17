using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishCheck : MonoBehaviour
{
    float delayTime = 1f;
    [SerializeField] ParticleSystem finishParticle;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            finishParticle.Play();
            Invoke("ReloadScene", delayTime);

        }
    }

    void ReloadScene()
    {
       // SceneManager.LoadScene(0);
    }

}
