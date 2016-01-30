using UnityEngine;
using System.Collections;

public class TimeScript : MonoBehaviour {

    public float StartTime;
   

	void Start () {
        //初期化
        StartTime = 4;
        

	}
	
	
	void Update () {
        //一秒ずつ減らすよ
        StartTime -= Time.deltaTime;
        if (StartTime < 0) StartTime = 0;

        if(StartTime == 4){

        }

	}
    
}
