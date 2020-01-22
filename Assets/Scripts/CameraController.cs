using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject frisbee;

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.frisbee.transform.position;  //フリスビーの位置の取得
        transform.position = new Vector3(
            playerPos.x, transform.position.y, transform.position.z);  //カメラのx軸方向の位置のみfrisbeeを追いかけるように変更
    }
}
