using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetect : MonoBehaviour
{
    float delayTime = 1.8f;
    [SerializeField] ParticleSystem crashParticle;
    [SerializeField] AudioClip crashSfx;
    bool isCrashed = false;
    Player player;


    void Start()
    {
        player = FindAnyObjectByType<Player>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.name == "Level Sprite Shape")
        {
            player.DisableControls();
            CrashEffect();
            collision.gameObject.GetComponent<SurfaceEffector2D>().speed = 0;
            Invoke("ReloadScene", delayTime);   
        }
    }

    void CrashEffect()
    {
        if (!isCrashed)
        {
            crashParticle.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSfx);
            isCrashed = true;
        }

    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
