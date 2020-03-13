using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// スマートフォンの加速度センサーによるオブジェクトの回転の実装
public class AccelerationRotation : MonoBehaviour
{
    private Vector3 acceleration;
    private Quaternion new_acceleration;
    private float a;
    // public GameObject player;
    // Start is called before the first frame update
    //　スタイダーセッティングのセンサー感度値の反映
    void Start()
    {
        a = SliderSetting.getSens();
        // player = transform.parent.gameObject;
    }

    // Update is called once per frame
    //加速度センサーの値と感度の値から回転の処理
    void FixedUpdate()
    {
        a = SliderSetting.getSens();

        this.acceleration = Input.acceleration;

        this.new_acceleration = Quaternion.Euler(this.acceleration.y * a, /*player.transform.eulerAngles.y */0f, this.acceleration.x * -a);

        transform.rotation = this.new_acceleration;

    }
}