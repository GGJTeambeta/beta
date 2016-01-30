using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Result : MonoBehaviour {
	private GameManager manager;

	public Image resultImage;
	[SerializeField] private Sprite[] winner = new Sprite[2]; 

	//public float alpha;

	void Start () {
		manager = GameObject.Find ("gameManager").GetComponent<GameManager> ();
	}

	void Update () {
		if (manager.ReturnGameFinish() == true) {
			if (manager.loserName == "Player1") {
				resultImage.sprite = winner [0];
				resultImage.enabled = true;
			}else {
				resultImage.sprite = winner [1];
				resultImage.enabled = true;
			}
		}
	}
}
