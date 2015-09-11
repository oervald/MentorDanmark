using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class POSTAnswersController : MonoBehaviour {

	List<Toggle[]> toggles;

	public List<QuizPartModel> options;

	[Header("RectTranforms")]
	public RectTransform holistiskPanel;
	public RectTransform analytiskPanel;
	public RectTransform visuelPanel;
	public RectTransform auditivPanel;
	public RectTransform taktilPanel;
	public RectTransform kiaestestiskPanel;
	public RectTransform lysPanel;
	public RectTransform lydPanel;
	public RectTransform temperaturPanel;
	public RectTransform designPanel;
	public RectTransform bevaegelsePanel;

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("UserID", 664);
		PlayerPrefs.SetString ("UserType", "Teacher");
		toggles = new List<Toggle[]> ();



		toggles.Add(holistiskPanel.GetComponentsInChildren<Toggle> ());
		toggles.Add(analytiskPanel.GetComponentsInChildren<Toggle> ());
		toggles.Add(visuelPanel.GetComponentsInChildren<Toggle> ());
		toggles.Add(auditivPanel.GetComponentsInChildren<Toggle> ());
		toggles.Add(taktilPanel.GetComponentsInChildren<Toggle> ());
		toggles.Add(kiaestestiskPanel.GetComponentsInChildren<Toggle> ());
		toggles.Add(lysPanel.GetComponentsInChildren<Toggle> ());
		toggles.Add(lydPanel.GetComponentsInChildren<Toggle> ());
		toggles.Add(temperaturPanel.GetComponentsInChildren<Toggle> ());
		toggles.Add(designPanel.GetComponentsInChildren<Toggle> ());
		toggles.Add( bevaegelsePanel.GetComponentsInChildren<Toggle> ());


	

		options = new List<QuizPartModel> ();

	}
	
	// Update is called once per frame
	void Update () {


	}

	public void SaveAnswers(){
		if (options != null) {
			print(options);
		}

		ResultModel rm = new ResultModel ();
		rm.UserID = PlayerPrefs.GetInt ("UserID");
		rm.UserType = PlayerPrefs.GetString ("UserType");

		foreach (QuizPartModel qpm in options) {
				print(options.Count);
			foreach(QuizOptionModel qom in qpm.Options){
					print (qpm.Options.Count);
				rm.Options.Add(qom);
			}
		}

		for (int i=0; i<=toggles.Count-1; i++) {
				int limit = toggles[i].Length-1;
				for(int x =0; x<limit; x++){

			if(toggles[i][x].isOn == true){
				rm.Options[i].Selected = true;
			}else{
				rm.Options[i].Selected = false;
			}

				}
	}

			POSTResultCalculator cal = gameObject.GetComponent<POSTResultCalculator>();

			cal.ParseToJsonResult(rm);
	
		
		}

}
