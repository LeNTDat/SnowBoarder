using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float torqueAmount = 10f;
    [SerializeField] float defaultSpeed = 9f;
    [SerializeField] float boostsSpeed = 3f;
    [SerializeField] ParticleSystem boostDrip; 

    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindAnyObjectByType<SurfaceEffector2D>();
    }

    void Update()
    {
        rotatePlayer();
        BootsPlayer();
    }

    void BootsPlayer ()
    {
        surfaceEffector2D.speed = defaultSpeed ;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            boostDrip.Play();
            surfaceEffector2D.speed = defaultSpeed + boostsSpeed;
        }

    }

    void rotatePlayer()
    {
        if(Input.GetKey(KeyCode.LeftArrow)) 
        {
            rb2d.AddTorque(torqueAmount);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }


}
