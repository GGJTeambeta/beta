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
