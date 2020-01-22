﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrisbeeController : MonoBehaviour
{
    [SerializeField] float risePower = 50f;  //SerializeFieldとすることでインスペクター上でも変数の値を変更することが出来る
    [SerializeField] float rotatePower = 80f;
    Rigidbody rigidBody;

    [SerializeField] ParticleSystem successParticle;  //パーティクルシステムの導入
    [SerializeField] ParticleSystem outParticle;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        RiseObjInput();
        RotaObjInput();
    }

    //フリスビーの上下方向操作
    //フリスビーが逆さまになると直感的な操作できないから改善する必要がある
    private void RiseObjInput()
    {
        if(Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow))
        {
            rigidBody.AddRelativeForce(Vector3.up * risePower);
        }
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            rigidBody.AddRelativeForce(Vector3.down * risePower);
        }
    }

    //フリスビー傾き操作
    private void RotaObjInput()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * rotatePower * Time.deltaTime);  //左傾き
        }
        else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(-Vector3.forward * rotatePower * Time.deltaTime);  //右傾き
        }
    }

    //タグを追加したオブジェクトとの接触時の処理
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Safety")
        {
            Debug.Log("何もしない");
        }
        else if(collision.gameObject.tag == "Success")
        {
            Debug.Log("クリア");
            SuccessProcessing();
        }
        else
        {
            Debug.Log("アウト");
            OutProcessing();
        }
    }

    //パーティクルシステム実行
    private void SuccessProcessing()
    {
        successParticle.Play();
    }
    private void OutProcessing()
    {
        outParticle.Play();
    }


}
