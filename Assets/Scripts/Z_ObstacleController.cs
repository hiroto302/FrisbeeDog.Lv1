using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z_ObstacleController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float power = 5.0f;  //移動させる力
    Vector3 objPoti;

    void Start()
    {
        objPoti = this.transform.position;  //ゲーム実行時のオブジェクトの位置を保存
    }

    void Update()
    {
        this.transform.position = new Vector3(
            objPoti.x, objPoti.y, Mathf.Sin(Time.time) * power + objPoti.z);
    }
}
