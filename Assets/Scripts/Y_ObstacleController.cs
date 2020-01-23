using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Y_ObstacleController : MonoBehaviour
{
    [SerializeField] float power = 5.0f;  //移動させる力
    Vector3 objPoti;

    void Start()
    {
        objPoti = this.transform.position;  //ゲーム実行時のオブジェクトの位置を保存
    }

    void Update()
    {
        this.transform.position = new Vector3(
            objPoti.x, Mathf.Sin(Time.time) * power + objPoti.y, objPoti.z);
    }
}
