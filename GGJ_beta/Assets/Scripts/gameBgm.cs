using UnityEngine;
using System.Collections;

public class gameBgm : MonoBehaviour {

	// play flag
	bool isPlayed = false;

	// Use this for initialization
	void Start () {
		isPlayed = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(GameObject.Find("gameManager").GetComponent<GameManager>().WorldTimeInt >= 3){//カウントダウン後の移動開始
			if (isPlayed == false) {
				//鳴らすBGMを入れる
				SoundManager.PlayBGM (BGM_NAME.GAMEPLAY);	
				isPlayed = true;
			}
		}	
	}
}
