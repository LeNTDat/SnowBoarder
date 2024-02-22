using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float torqueAmount = 10f;
    [SerializeField] float defaultSpeed = 12f;
    [SerializeField] float boostsSpeed = 10f;

    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    bool canMove = true;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindAnyObjectByType<SurfaceEffector2D>();
    }

    void Update()
    {
        if (canMove)
        {
            rotatePlayer();
            BootsPlayer();
        }
    }

    public void DisableControls()
    {
        canMove = false;
    }

    void BootsPlayer ()
    {
        surfaceEffector2D.speed = defaultSpeed ;
        if (Input.GetKey(KeyCode.UpArrow))
        {
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
