using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    Rigidbody rgbody;

    //speed係数
    public float speed = 10;


    private void Start()
    {
        //GameObjectが持つRigidbodyコンポーネントを取得
        rgbody = GetComponent<Rigidbody>();

    }

    private void FixedUpdate()
    {
        //x軸・z軸取得
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        //rigidbodyのx・yに力を加える
        rgbody.AddForce(moveH*speed, 0, moveV*speed);
        
    }
}
