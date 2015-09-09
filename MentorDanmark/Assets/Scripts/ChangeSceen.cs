using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeSceen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GoToMenu(){
		Application.LoadLevel("MentorScene");
	}
	public void GoToTest(){
		Application.LoadLevel ("TestScene");
	}
}
