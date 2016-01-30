using UnityEngine;
using System.Collections;
//ベタをコントロールする

public class betacontrol : MonoBehaviour {
	Rigidbody betarb;

	//select input
	[SerializeField]
	KeyCode bettaup;
	[SerializeField]
	KeyCode bettadown;
	[SerializeField]
	KeyCode bettaleft;
	[SerializeField]
	KeyCode bettaright;

	[SerializeField]
	float speed = 10.0f;

	// Use this for initialization
	void Start () {
		betarb = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(GameObject.Find("gameManager").GetComponent<GameManager>().WorldTimeInt >= 3){//カウントダウン後の移動開始
			if (Input.GetKey (bettaleft))
			{
				transform.rotation = new Quaternion (0, 180, 0, 0);
				betarb.AddForce (Vector3.left *speed);
			}
			if (Input.GetKey (bettaup))
			{
				betarb.AddForce (Vector3.up *speed);
			}
			if (Input.GetKey (bettadown))
			{
				betarb.AddForce (Vector3.down *speed);
			}
			if (Input.GetKey (bettaright))
			{
				transform.rotation = new Quaternion (0, 0, 0, 0);
				betarb.AddForce (Vector3.right *speed);
			}
		}
	}
}
