using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetect : MonoBehaviour
{
    float delayTime = 0.6f;
    [SerializeField] ParticleSystem crashParticle;
    [SerializeField] AudioClip crashSfx;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.name == "Level Sprite Shape")
        {
            crashParticle.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSfx);
            Invoke("ReloadScene", delayTime);   
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
