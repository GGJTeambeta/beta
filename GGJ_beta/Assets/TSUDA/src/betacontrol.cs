using UnityEngine;
using System.Collections;
//ベタをコントロールする

public class betacontrol : MonoBehaviour {
	Rigidbody betarb;

	[SerializeField]
	float speed = 10.0f;
	[SerializeField]
	bool should_to_face_left;

	// Use this for initialization
	void Start () {
		betarb = this.GetComponent<Rigidbody> ();
		should_to_face_left = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A))
		{
			should_to_face_left = true;
			betarb.AddForce (Vector3.left *speed);
		}
		if (Input.GetKey (KeyCode.W))
		{
			betarb.AddForce (Vector3.up *speed);
		}
		if (Input.GetKey (KeyCode.S))
		{
			betarb.AddForce (Vector3.down *speed);
		}
		if (Input.GetKey (KeyCode.D))
		{
			should_to_face_left = false;
			betarb.AddForce (Vector3.right *speed);
		}
		DrawfaceOrientation ();
	}

	void DrawfaceOrientation()
	{
		if (should_to_face_left)
		{
			//左向き
			transform.localRotation = new Quaternion(0,0,0,0);
		}
		else
		{
			//右向き
			transform.localRotation = new Quaternion(0,90,0,0);
		}
	}

}
