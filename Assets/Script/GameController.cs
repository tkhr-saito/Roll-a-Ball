using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text scoreLabel;
    public GameObject winnerLabelObject;

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
	}
}
