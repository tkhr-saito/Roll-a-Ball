using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text scoreLabel;
    public Text timeLabel;
    public GameObject winnerLabelObject;
    public GameObject loserLabelObject;
    public GameObject player;

    //持ち時間の初期値はとりあえず60で（GameControllerで指定するっぽい？）
    public float time = 60;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void Update () {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        scoreLabel.text = count.ToString();

        //オブジェクトがすべてなくなる＝クリア時の処理
        if (count == 0)
        {
            //オブジェクトをアクティブにする
            winnerLabelObject.SetActive(true);
        }


        //timeが0になったらGAMEOVER表示
        if (time < 0.0)
        {
            //オブジェクトをアクティブにして、ボールを消して、カウントを止める
            loserLabelObject.SetActive(true);
            Destroy(player);
            time = 0;
        }
        else
        {
            //毎秒持ち時間表示減らす
            timeLabel.text = time.ToString();
            time = time - Time.deltaTime;
        }
    }
}
