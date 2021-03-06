using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class POSTAnswersController : MonoBehaviour {

	List<Toggle[]> toggles;
	public Toggle lys1;
	public Toggle lys2;

	public Toggle lyd1;
	public Toggle lyd2;

	public Toggle temp1;
	public Toggle temp2;

	public Toggle des1;
	public Toggle des2;

	public Toggle bev1;

	public List<QuizPartModel> options;

	[Header("RectTranforms")]
	public RectTransform holistiskPanel;
	public RectTransform analytiskPanel;
	public RectTransform visuelPanel;
	public RectTransform auditivPanel;
	public RectTransform taktilPanel;
	public RectTransform kinaestestiskPanel;


	// Use this for initialization
	void Start () {
	
		toggles = new List<Toggle[]> ();

		Toggle[] lys = new Toggle[]{lys1,lys2};
		Toggle[] lyd = new Toggle[]{lyd1,lyd2};
		Toggle[] temp = new Toggle[]{temp1,temp2};
		Toggle[] des = new Toggle[]{des1,des2};
		Toggle[] bev = new Toggle[]{bev1};

		toggles.Add(analytiskPanel.GetComponentsInChildren<Toggle> ());
		toggles.Add(holistiskPanel.GetComponentsInChildren<Toggle> ());
		toggles.Add(visuelPanel.GetComponentsInChildren<Toggle> ());
		toggles.Add(auditivPanel.GetComponentsInChildren<Toggle> ());
		toggles.Add(taktilPanel.GetComponentsInChildren<Toggle> ());
		toggles.Add(kinaestestiskPanel.GetComponentsInChildren<Toggle> ());
	
		toggles.Add(lys);
		toggles.Add(lyd);
		toggles.Add(temp);
		toggles.Add (des);
		toggles.Add(bev);

		options = new List<QuizPartModel> ();
		if (PlayerPrefs.HasKey ("TestToSave_" + PlayerPrefs.GetInt ("UserIDforTest"))) {
			LoadAnswersFromPlayerPrefs(PlayerPrefs.GetString("TestToSave_"+PlayerPrefs.GetInt("UserIDforTest")));
		}
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void SaveAnswers(string command){

		ResultModel rm = new ResultModel ();
		rm.UserID = PlayerPrefs.GetInt ("UserIDforTest");
		rm.UserType = PlayerPrefs.GetString ("UserTypeforTest").Replace('"',' ').Trim();

		foreach (QuizPartModel qpm in options) {
			foreach(QuizOptionModel qom in qpm.Options){
				rm.Options.Add(qom);
			}
		}
	
		int counter = 0;
		for (int i=0; i<=toggles.Count-1; i++) {
				int limit = toggles[i].Length;
				for(int x =0; x<limit; x++){

			if(toggles[i][x].isOn == true){
				rm.Options[counter].Selected = true;
					counter++;
			}else if(toggles[i][x].isOn ==false){
				rm.Options[counter].Selected = false;
					counter++;	
				}
			}
		}
			POSTResultCalculator cal = gameObject.GetComponent<POSTResultCalculator>();
			cal.ParseToJsonResult(rm, command);
	}
	public void LoadAnswersFromPlayerPrefs(string encryptedJSON){
		
		JSONObject json = new JSONObject (encryptedJSON);
		print (json.ToString ());
		JSONObject arr = json.GetField("Answers");
		print (arr.ToString ());
		int count = 0;
		for (int i=0; i<=toggles.Count-1; i++) {
			int limit = toggles[i].Length;
			for(int x =0; x<limit; x++){
				bool b = Convert.ToBoolean(arr[count].GetField("Selected").ToString());
				if(b){

					toggles[i][x].isOn = true;
					count++;
				}else if(!b){
					toggles[i][x].isOn =false;
			
					count++;	
				}
			}
		}
	
		}
		


		
	}




