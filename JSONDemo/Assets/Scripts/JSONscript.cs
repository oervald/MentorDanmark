using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class JSONscript : MonoBehaviour {

	public Text text;
 	

	// Use this for initialization
	IEnumerator Start () {


		Debug.Log ("Hello World");
		WWW json = new WWW ("http://jsonplaceholder.typicode.com/posts");
		yield return json;


		var N = JSON.Parse(json.text);
		

		
		System.IO.BinaryReader reader = new System.IO.BinaryReader (json);
	Object[] jsonObject = JSONNode.Deserialize(reader);

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

[System.Serializable]
public class Query {

	int userid;
	int id;
	string title;
	string body;

	public Query(){
	}
	public Query(int _userid, int _id, string _title, string _body){
		this.userid = _userid;
		this.id = _id;
		this.title = _title;
		this.body = _body;
	}


}

