using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AccelerationRotation : MonoBehaviour
{
    private Vector3 acceleration;
    float x, y, z;
    private Quaternion new_acceleration;
    private float a;
    // public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        a = SliderSetting.getSens();
        // player = transform.parent.gameObject;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        a = SliderSetting.getSens();
        this.acceleration = Input.acceleration;

        this.new_acceleration = Quaternion.Euler(this.acceleration.y*a, /*player.transform.eulerAngles.y */0f,this.acceleration.x*-a);

        transform.rotation = this.new_acceleration; 

    }
}