using UnityEngine;
using System.IO;
using System.Text;
using System.Collections;

public class credit : MonoBehaviour {
	[SerializeField]
	string txtLink;
	[SerializeField]
	string[] member = new string[8];
	

	// Use this for initialization
	void Start () {
		//teamMemberファイル読み込み
		FileStream f = new FileStream(txtLink, FileMode.Open, FileAccess.Read);
		//Encoding utf8Enc = Encoding.GetEncoding("UTF-8");
		StreamReader reader = new StreamReader(f);
		if (reader != null) {
			int count = 0;
			while (!reader.EndOfStream)
			{
				member[count] = reader.ReadLine ();
				count++;
			}
			reader.Close ();
		}

		//役職+英名に変更
		for(int i = 0;i<member.Length;i++)
		{
			string[] details = member[i].Split (',');
			member [i] = "";//空に
			member[i] = details[0] +":"+ details[2];
			Debug.Log (member [i]);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
