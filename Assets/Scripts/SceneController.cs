using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            //今回はインデックス数を利用してシーンの切り替えを行う
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;  //現在のシーンのインデックスを取得
            int nextSceneIndex = currentSceneIndex + 1;  //取得したシーンのインデックス数に1を加えて、nextSceneIndexに代入

            if(nextSceneIndex == SceneManager.GetActiveScene().buildIndex)
            {
                nextSceneIndex = 0;
            }

            SceneManager.LoadScene(nextSceneIndex);
        }


    
    }
}
