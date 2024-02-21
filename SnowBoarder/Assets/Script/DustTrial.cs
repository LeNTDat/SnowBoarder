using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrial : MonoBehaviour
{

    [SerializeField] ParticleSystem dustTrialBack;
    [SerializeField] ParticleSystem dustTrialFront;
    [SerializeField] ParticleSystem boostSpeedBack;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            dustTrialBack.Play();
            dustTrialFront.Play();
            boostSpeedBack.Play();

        }

    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Ground")
        {
            dustTrialFront.Stop();  
            dustTrialBack.Stop();
            boostSpeedBack.Stop();
        }
    }
}
