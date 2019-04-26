using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    //トリガーとの接触時に呼ばれるコールバック 
    void OnTriggerEnter(Collider hit)
    {
        //playerタグと接触したか
        if (hit.CompareTag("Player"))
        {
            //このコンポーネントを持つGameObjectを破棄する
            Destroy(gameObject);
        }
    }
}
