using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class TestStartBehaviorScript : MonoBehaviour {


	GameObject startPanel;



	// Use this for initialization
	void Start () {
		startPanel = GameObject.Find("IntroSide");

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartTest(){
	
		//startPanel.SetActive (false);
		startPanel.gameObject.SetActive (false);
		Debug.Log ("Hello World!!");




	}
}
