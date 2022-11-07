using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;




public class Player : MonoBehaviour
{
    public Controller controller;

    public float slideSpeed = 1;
    public float speed = 1f;

    public float xLimit = 2;

    public bool dead = false;

    void Update()
    {
        if (dead)
        {
            return;
        }

        transform.Translate(slideSpeed * controller.moveX * Time.deltaTime, 0, -(Time.deltaTime *2* speed));
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -xLimit, xLimit), transform.position.y, transform.position.z);
    }
}
