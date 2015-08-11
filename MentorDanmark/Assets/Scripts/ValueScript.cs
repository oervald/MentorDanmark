using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ValueScript : MonoBehaviour {

	Dictionary<int,bool> dictionary;


	// Use this for initialization
	void Start () {
		dictionary = new Dictionary<int,bool>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddResult(int id, bool value){
		dictionary.Add (id, value);
	}

	public void PrintAllResults(){
		print(dictionary);
	}
}
