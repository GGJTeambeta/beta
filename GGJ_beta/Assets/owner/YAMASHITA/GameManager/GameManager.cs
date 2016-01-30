using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public float WorldTime = 0f;		//全体の経過時間
	public int WorldTimeInt = 0;		//全体の経過時間(int型)

	public bool Move;					//Playerたちが動けるかどうか
	public bool GameFinish;				//Game終了時

	// Use this for initialization
	void Awake () {
		Move = false;
		GameFinish = false;
	}
	
	// Update is called once per frame
	void Update () {
		WorldTime += Time.deltaTime;
		WorldTimeInt = (int)WorldTime;
	}

	public bool ReturnMove(){
		return Move;
	}

	public bool ReturnGameFinish(){
		return GameFinish;
	}

	/**************必要か悩んだので追加(不要なら後で削除)*************/
	public bool SetMove(bool set){
		return Move = set;
	}

	public bool SetGameFinish(bool set){
		return GameFinish = set;
	}
	/****************************************************************/
}
