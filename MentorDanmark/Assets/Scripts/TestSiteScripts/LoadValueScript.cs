using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class LoadValueScript : MonoBehaviour {
	QuizzOptionHandler quizHandler;
	// Use this for initialization

	public Text Title;
	List<QuizPartModel> qms;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetTextsHolistic(List<QuizPartModel> quizList){
		print (quizList.Count);
		Title.text.Equals(quizList [1].Title);
	}
}
