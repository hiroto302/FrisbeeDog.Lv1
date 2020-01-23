using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    //スタート画面からplay画面へ遷移した時、スタート画面で設定したBGMが流れたままにする
    private void Awake()
    {
        int numMusicPlayers = FindObjectsOfType<MusicPlayer>().Length;
        //クリア画面から再度スタート画面に戻った場合、音が重ならないようにBGM削除
        if(numMusicPlayers > 1)
        {
            Destroy(gameObject);
        }
        else
        {
         //他のシーンに遷移してもオブジェクトを破壊しない指定
            DontDestroyOnLoad(gameObject);
        }
    }
}
