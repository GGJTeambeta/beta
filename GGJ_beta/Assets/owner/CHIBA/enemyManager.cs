using UnityEngine;
using System.Collections;

public class enemyManager : MonoBehaviour {
	private bool isPlayer;
	public GameObject pos1;
	public GameObject pos2;
	public float speed;
	// Use this for initialization
	void Start () {
		isPlayer = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (GameObject.Find ("gameManager").GetComponent<GameManager> ().WorldTimeInt >= 3 && GameObject.Find ("gameManager").GetComponent<GameManager> ().GameFinish == false) {//カウントダウン後の移動開始
			GameObject.Find ("Enemy").GetComponent<Animator> ().SetBool ("isStart", true);
		} else {
			GameObject.Find ("Enemy").GetComponent<Animator> ().SetBool ("isStart", false);
		}

		if(playerOut.outP1){
			GameObject.Find ("Enemy").GetComponent<Animator> ().Stop();
			// ターゲット方向のベクトルを求める
			Vector3 vec = pos1.transform.position - transform.position;
			// ターゲットの方向を向く
			transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(new Vector3(vec.x, 0, vec.z)), 10);
			transform.Translate(Vector3.forward * speed); // 正面方向に移動
		}
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.name == "Player1"){
			GameObject.Find ("gameManager").GetComponent<GameManager>().SetGameFinish(col.gameObject.name);
			Destroy (col.gameObject);
		}
		if(col.gameObject.name == "Player2"){
			GameObject.Find ("gameManager").GetComponent<GameManager>().SetGameFinish(col.gameObject.name);
			Destroy (col.gameObject);
		}
	}
}
