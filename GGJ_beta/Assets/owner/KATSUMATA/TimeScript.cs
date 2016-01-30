﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeScript : MonoBehaviour {
    public GameObject manager;
    public Text text;
    //カウント用
    public float StartTime;
    //配列
    public string[] TimerBuf = new string[4];

	void Start () {
        //初期化：カウント
        StartTime = 4;
        

	}
	
	
	void Update () {
        //一秒ずつ減らすよ
        StartTime -= Time.deltaTime;
        //マイナスは表示されない
        if (StartTime < 0) StartTime = 0;
        //テキスト表示
        GetComponent<Text>().text = TimerBuf[((int)StartTime)].ToString();

        if(StartTime == 0){
            //プレイヤーが動けるようにする
            manager.GetComponent<GameManager>().SetMove(true);
        }
	}


        

        

     
}
