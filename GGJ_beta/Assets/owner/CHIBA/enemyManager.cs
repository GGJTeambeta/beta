using UnityEngine;
using System.Collections;

public class enemyManager : MonoBehaviour {
	private bool isPlayer;

	// Use this for initialization
	void Start () {
		isPlayer = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(GameObject.Find("gameManager").GetComponent<GameManager>().WorldTimeInt >= 3){//カウントダウン後の移動開始
			GameObject.Find("Enemy").GetComponent<Animator>().SetBool("isStart", true);
		}
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.name == "Player1"){
			Destroy (col.gameObject);
		}
		if(col.gameObject.name == "Player2"){
			Destroy (col.gameObject);
		}
	}
}
