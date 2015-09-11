using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

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
	public RectTransform kiaestestiskPanel;


	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("UserID", 664);
		PlayerPrefs.SetString ("UserType", "Teacher");
		toggles = new List<Toggle[]> ();

		Toggle[] lys = new Toggle[]{lys1,lys2};
		Toggle[] lyd = new Toggle[]{lyd1,lyd2};
		Toggle[] temp = new Toggle[]{temp1,temp2};
		Toggle[] des = new Toggle[]{des1,des2};
		Toggle[] bev = new Toggle[]{bev1};


		toggles.Add(holistiskPanel.GetComponentsInChildren<Toggle> ());
		toggles.Add(analytiskPanel.GetComponentsInChildren<Toggle> ());
		toggles.Add(visuelPanel.GetComponentsInChildren<Toggle> ());
		toggles.Add(auditivPanel.GetComponentsInChildren<Toggle> ());
		toggles.Add(taktilPanel.GetComponentsInChildren<Toggle> ());
		toggles.Add(kiaestestiskPanel.GetComponentsInChildren<Toggle> ());
	
		print(holistiskPanel.GetComponentsInChildren<Toggle> ().Length);
		print(analytiskPanel.GetComponentsInChildren<Toggle> ().Length);
		print(visuelPanel.GetComponentsInChildren<Toggle>().Length);
		print(auditivPanel.GetComponentsInChildren<Toggle> ().Length);
		print(taktilPanel.GetComponentsInChildren<Toggle> ().Length);
		print(kiaestestiskPanel.GetComponentsInChildren<Toggle> ().Length);
		toggles.Add(lys);
		toggles.Add(lyd);
		toggles.Add(temp);
		toggles.Add (des);
		toggles.Add(bev);


	

		options = new List<QuizPartModel> ();

	}

	public Toggle[] removeNotNeededToggles( Toggle[] tempToggles){
		List<Toggle> teemo = new List<Toggle> ();

		Toggle[] returnToggles = new Toggle[2];
		foreach (Toggle t in tempToggles) {
			teemo.Add(t);
		}
		int p = teemo.Count - 1;
		print (p);
		teemo.RemoveAt (p);
		for (int i = 0; i<teemo.Count; i++) {
			returnToggles[i] = teemo[i];
		}
		return returnToggles;
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
		print (rm.Options.Count);
		print (toggles.Count);
		int counter = 0;
		for (int i=0; i<=toggles.Count-1; i++) {
			print ("i : " + i);
				int limit = toggles[i].Length;
				for(int x =0; x<limit; x++){
				print ("x : " + x);
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

			cal.ParseToJsonResult(rm);
	
		
	}

}
