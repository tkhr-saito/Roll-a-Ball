using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    Rigidbody rgbody;

    //speed係数
    public float speed = 10;
    


    private void Start()
    {
        //GameObjectが持つRigidbodyコンポーネントを取得
        rgbody = GetComponent<Rigidbody>();

    }
    void Update()
    {
        //座標取得
        Transform player_transform = this.transform;
        Vector3 player_position = player_transform.position;

        //playerのyが0より低いなら＝フィールド外に落下したらゲームリセット（なんかスマートな方法があったかも）
        if (player_position.y<0)
        {
            //現在のシーン番号を取得
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;

            //現在のシーンを再読込する
            SceneManager.LoadScene(sceneIndex);

        }
    }   

    private void FixedUpdate()
    {
        //x軸・z軸取得
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        //spaceキーでジャンプ
        float jump = Input.GetAxis("Jump");

        //rigidbodyのx・y・zに力を加える
        rgbody.AddForce(moveH*speed, jump*50, moveV*speed);

    }
}
