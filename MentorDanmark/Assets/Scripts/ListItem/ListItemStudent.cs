using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


public class ListItemStudent : ListItem2 {

	[Header("Student")]
	public GameObject viewPanel;
	public GameObject underContainer;
	public GameObject container;

	[Header("Headlines")]
	public Text SubTitleThinkingStyle;
	public Text SubTitlePreferences;
	public Text SubTitleEnvironment;
	
	[Header("Images")]
	public Image holistiskImage;
	public Image analytikImage;
	public Image visuelImage;
	public Image auditivImage;
	public Image taktilImage;
	public Image kineastetiskImage;
	public Image NullImage;

	
	[Header("Text")]
	public Text holistiskHeadline;
	public Text holistiskText;
	public Text analytikHeadline;
	public Text analytikText;
	public Text visuelHeadline;
	public Text visuelText;
	public Text auditivHeadline;
	public Text auditivText;
	public Text taktilHeadline;
	public Text taktilText;
	public Text kineastetiskHeadline;
	public Text kineastetiskText;
	public Text buttonText;

	public bool tempFoldout = true;
	private int valueUserID;
	private string valueUserType;
	public ResultObject resultobjecValue;
	public bool testTaken;
	private int envirCount = 0;


	[Header ("HiglightPanels")]
	public GameObject analytiskHighlightPanel;
	public GameObject holistiskHighlightPanel;
	public GameObject visuelHighlightPanel;
	public GameObject auditivHighlightPanel;
	public GameObject taktilHighlightPanel;
	public GameObject kinæstetiskHighlightPanel;
	public GameObject læringsstilsmiljøHighlightContainer;

	[Header ("Prefabs")]
	public GameObject Highlight;

	// Use this for initialization
	public override void Start () {
		base.Start();
		onHeadlineClick ();
		setImagesToFalse ();
	
	}
	
	// Update is called once per frame
	public override void Update () {
		base.Update ();
	}

	// SetupPage lavet et ListItem object, og tilføjere den til containern.
	public void SetupPage(ResultObject resultObject){

			resultobjecValue = resultObject;
			GameObject container = GameObject.Find ("Container");
			DanishStrings ds = new DanishStrings ();
		print (resultObject.ToString());
			
		valueUserID = resultObject.UserID;
		valueUserType = resultObject.UserType;
		headlineText.text = resultObject.StudentName;


		if ((resultObject.TestTaken == false) && (!PlayerPrefs.HasKey ("TestToSave_" + resultObject.UserID))) {
			buttonText.text = ds.BtnTxtTagTest;
			underContainer.SetActive (false);
			ResetHeight ();
		} else if (resultObject.TestTaken == true && (!PlayerPrefs.HasKey ("TestToSave_" + resultObject.UserID))) {
			SetupPageSwitch (resultObject, ds, true);
		} else if (resultObject.TestTaken == false && (PlayerPrefs.HasKey ("TestToSave_" + resultObject.UserID))) {
			buttonText.text = "Fortsæt Test";
			underContainer.SetActive (false);
			ResetHeight ();

		} else if (resultObject.TestTaken == true && (PlayerPrefs.HasKey ("TestToSave_" + resultObject.UserID) != null)) {
			SetupPageSwitch(resultObject, ds,false);
		}


			setHAImage ();
			setVATKImage ();


		this.transform.SetParent (container.transform);
		this.transform.localScale = new Vector3 (1, 1, 1);
		ResetHeight ();
	
	}


	void SetupPageSwitch(ResultObject resultObject, DanishStrings ds, bool buttonBool){

		if( resultObject.Analystisk > resultObject.Holistisk){
			analytikHeadline.text = ds.TitleAnalyst + " (" + resultObject.Analystisk + "%)"; 
			holistiskHeadline.text = ds.TitleHolistic2Part1 + resultObject.Holistisk + ds.TitleHolistic2Part2;		
		}else if(resultObject.Holistisk > resultObject.Analystisk){
			holistiskHeadline.text = ds.TitleHolistic1 + " (" + resultObject.Holistisk + "%)"; 
			analytikHeadline.text = ds.TitleAnalyst2Part1 + resultObject.Analystisk + ds.TitleAnalyst2Part2;
		}else if(resultObject.Analystisk.ToString().Equals(resultObject.Holistisk.ToString())){
			holistiskHeadline.text = ds.TitleHolistic2Part1 + resultObject.Holistisk + ds.TitleHolistic2Part2;	
			analytikHeadline.text = ds.TitleAnalyst2Part1 + resultObject.Analystisk + ds.TitleAnalyst2Part2;
		}
		
		double [] sortArray = {resultObject.Auditiv, resultObject.Taktil, resultObject.Kinaestisk, resultObject.Visuel};
		double max = sortArray.Max();
		if(resultObject.Auditiv == max){
			auditivHeadline.text = ds.TitleAuditory1 + " (" + resultObject.Auditiv + "%)"; 
			taktilHeadline.text = ds.TitleTactile2Part1 + resultObject.Taktil + ds.TitleTactile2Part2;
			kineastetiskHeadline.text = ds.TitleKinesthetic2Part1 + resultObject.Kinaestisk + ds.TitleKinesthetic2Part2;
			visuelHeadline.text = ds.TitleVisual2Part1 + resultObject.Visuel + ds.TitleVisual2Part2;
		}
		else if(resultObject.Taktil ==max){
			taktilHeadline.text = ds.TitleTactile1 + " (" + resultObject.Taktil + "%)"; 
			auditivHeadline.text = ds.TitleAuditory2Part1 + resultObject.Auditiv + ds.TitleAuditory2Part2;
			kineastetiskHeadline.text = ds.TitleKinesthetic2Part1 + resultObject.Kinaestisk + ds.TitleKinesthetic2Part2;
			visuelHeadline.text = ds.TitleVisual2Part1 + resultObject.Visuel + ds.TitleVisual2Part2;
		}
		else if(resultObject.Kinaestisk== max){
			kineastetiskHeadline.text = ds.TitleKinesthetic1 + " (" + resultObject.Kinaestisk + "%)";
			auditivHeadline.text = ds.TitleAuditory2Part1 + resultObject.Auditiv + ds.TitleAuditory2Part2;
			taktilHeadline.text = ds.TitleTactile2Part1 + resultObject.Taktil + ds.TitleTactile2Part2;
			visuelHeadline.text = ds.TitleVisual2Part1 + resultObject.Visuel + ds.TitleVisual2Part2;
		}
		else if(resultObject.Visuel == max){
			visuelHeadline.text = ds.TitleVisual1 + " (" + resultObject.Visuel + "%)"; 
			auditivHeadline.text = ds.TitleAuditory2Part1 + resultObject.Auditiv + ds.TitleAuditory2Part2;
			taktilHeadline.text = ds.TitleTactile2Part1 + resultObject.Taktil + ds.TitleTactile2Part2;
			kineastetiskHeadline.text = ds.TitleKinesthetic2Part1 + resultObject.Kinaestisk + ds.TitleKinesthetic2Part2;
		}
		else if(resultObject.Auditiv == max &&resultObject.Taktil== max && resultObject.Kinaestisk ==max && resultObject.Visuel == max){
			print(max);
			auditivHeadline.text = ds.TitleAuditory2Part1 + resultObject.Auditiv + ds.TitleAuditory2Part2;
			taktilHeadline.text = ds.TitleTactile2Part1 + resultObject.Taktil + ds.TitleTactile2Part2;
			kineastetiskHeadline.text = ds.TitleKinesthetic2Part1 + resultObject.Kinaestisk + ds.TitleKinesthetic2Part2;
			visuelHeadline.text = ds.TitleVisual2Part1 + resultObject.Visuel + ds.TitleVisual2Part2;
		}


		
		SubTitleThinkingStyle.text = ds.SubTitleThinkingStyle;
		analytikText.text = ds.DescpriptionAnalyst;
		string[] descriptionAnalyst2 = ds.DescpriptionAnalystPart2;



		envirCount = 0;
		for(int q=0; q< 4; q++){
			envirCount++;
			addHighlights(ds.DescpriptionAnalystPart2[q], analytiskHighlightPanel);
			addHighlights(ds.DescpriptionHolisticPart2[q], holistiskHighlightPanel);
			addHighlights(ds.DescpriptionVisualPart2[q], visuelHighlightPanel);
			addHighlights(ds.descpriptionKinestheticPart2[q], kinæstetiskHighlightPanel);
			addHighlights(ds.DescpriptionAuditoryPart2[q], auditivHighlightPanel);
			addHighlights(ds.descpriptionTactilePart2[q], taktilHighlightPanel);
		}

			
		holistiskText.text = ds.DescpriptionHolistic; 
		SubTitlePreferences.text = ds.SubTitlePreferences;
		visuelText.text = ds.DescpriptionVisual; 
		auditivText.text = ds.DescpriptionAuditory; 
		taktilText.text = ds.DescpriptionTactile; 
		kineastetiskText.text = ds.DescpriptionKinesthetic; 
		SubTitleEnvironment.text = ds.SubTitleEnvironment;

	
		envirCount = 0;
		switch(resultObject.Lys){
		case 1:
			envirCount++;
			addHighlights(ds.EnvirLightOn, læringsstilsmiljøHighlightContainer);
			break;
		case 2:
			envirCount++;
			addHighlights(ds.EnvirLightOff, læringsstilsmiljøHighlightContainer);
			break;
		};

		switch(resultObject.Lyd){
		case 1:
			envirCount++;
			addHighlights(ds.EnvirSoundOff, læringsstilsmiljøHighlightContainer);
			break;
		case 2:
			envirCount++;
			addHighlights(ds.EnvirSoundOn, læringsstilsmiljøHighlightContainer);
			break;
		};

		switch(resultObject.Temperatur){
		case 1:
			envirCount++;
			addHighlights(ds.EnvirTempHot, læringsstilsmiljøHighlightContainer);
			break;
		case 2:
			envirCount++;
			addHighlights(ds.EnvirTempCold,læringsstilsmiljøHighlightContainer);
			break;
		};

		switch(resultObject.Design){
		case 1:
			envirCount++;
			addHighlights(ds.EnvirConfertTable, læringsstilsmiljøHighlightContainer);
			break;
		case 2:
			envirCount++;
			addHighlights(ds.EnvirConfertSofa, læringsstilsmiljøHighlightContainer);
			break;
		};

		switch(resultObject.Bevaeglse){
		case 1:
			envirCount++;
			addHighlights(ds.EnvirMovment, læringsstilsmiljøHighlightContainer);
			break;
		};

		switch (envirCount) {
		case 0:
			addHighlights("Du har ikke valgt noget i læringsmiljø", læringsstilsmiljøHighlightContainer);
			break;
		};
			
		if (buttonBool) {
			buttonText.text = ds.BtnTxtTagOm;
		} else if (!buttonBool) {
			buttonText.text = "Fortsæt Test";
		}
	}
	// Insætter string highlight som er det man ønsker at insætte, og highLightContainer er det panel som det ønskes at tiljøjeres til.
	// envirCount er en int det bliver ++ når den skal tilføjes, så de bliver 1 2 3 osv.
	public void addHighlights(string highlight, GameObject highLightContainer){
		GameObject tempHighlight = Instantiate (Highlight) as GameObject;
		Text[] temp = tempHighlight.GetComponentsInChildren<Text>();
		temp[0].text = envirCount.ToString() + ".";
		temp[1].text = highlight;
		tempHighlight.transform.SetParent (highLightContainer.transform);
		tempHighlight.transform.localScale = new Vector3 (1, 1, 1);
	}

	public void onHeadlineClick( ){

		if (tempFoldout == false) {
			setImagesToTrue ();
			tempFoldout = true;
			Fold ();
		} else {
			setImagesToFalse ();
			tempFoldout = false;
			Fold ();
		}

	}

	//sætter billederne/diagramerne til false, da de ellers ville blive vist selv sammefoldet.
	public void setImagesToFalse(){
		holistiskImage.gameObject.SetActive (false);
		analytikImage.gameObject.SetActive (false);
		visuelImage.gameObject.SetActive (false);
		auditivImage.gameObject.SetActive (false);
		taktilImage.gameObject.SetActive (false);
		kineastetiskImage.gameObject.SetActive (false);
		NullImage.gameObject.SetActive (false);
	}
	
	public void setImagesToTrue(){
		holistiskImage.gameObject.SetActive (true);
		analytikImage.gameObject.SetActive (true);
		visuelImage.gameObject.SetActive (true);
		auditivImage.gameObject.SetActive (true);
		taktilImage.gameObject.SetActive (true);
		kineastetiskImage.gameObject.SetActive (true);
		NullImage.gameObject.SetActive (true);
	}

	// de næste to juster fillAmount på billederne/diagramerne.
	public void setHAImage(){
		float analytikFloat = float.Parse(resultobjecValue.Analystisk.ToString());
		analytikFloat = analytikFloat / 100;
		analytikImage.fillAmount = analytikFloat;
	}

	 public void setVATKImage(){
		float auditivFloat = float.Parse (resultobjecValue.Auditiv.ToString ());
		auditivFloat = auditivFloat / 100;
		float taktilFloat = float.Parse (resultobjecValue.Taktil.ToString());
		taktilFloat = taktilFloat / 100;
		float kineastetiskFloat = float.Parse(resultobjecValue.Kinaestisk.ToString());
		kineastetiskFloat = kineastetiskFloat / 100;
		float visuelFloat = float.Parse(resultobjecValue.Visuel.ToString());
		visuelFloat = visuelFloat / 100;
		visuelImage.fillAmount = visuelFloat + taktilFloat + auditivFloat + kineastetiskFloat;
		auditivImage.fillAmount = kineastetiskFloat + taktilFloat + auditivFloat;
		taktilImage.fillAmount = kineastetiskFloat + taktilFloat;
		kineastetiskImage.fillAmount = kineastetiskFloat;
	}

	//loader TestSceen
	public void GoToTest(){
		PlayerPrefs.SetInt ("UserIDforTest", resultobjecValue.UserID);
		PlayerPrefs.SetString ("UserTypeforTest", resultobjecValue.UserType);
		Application.LoadLevel ("TestScene");
	}

}
