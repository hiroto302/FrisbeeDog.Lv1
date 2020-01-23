using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X_obstacleController : MonoBehaviour
{
    [SerializeField] float power = 5.0f;  //移動させる力
    Vector3 objPoti;

    void Start()
    {
        objPoti = this.transform.position;  //ゲーム実行時のオブジェクトの位置を保存
    }

    void Update()
    {
        //Mathf.Sin(Time.time)は「-1から1]の間を往復的に変化  ここでは、powerをかけることにより-5から5の間を変化
        this.transform.position = new Vector3(
            Mathf.Sin(Time.time) * power + objPoti.x, objPoti.y, objPoti.z);
    }
}
