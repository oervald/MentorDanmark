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
	
	[Header("Text")]
	public Text holistiskHeadline;
	public Text holistiskText;
	public Text holistiskHighText;
	public Text analytikHeadline;
	public Text analytikText;
	public Text analyiskHighText;
	public Text visuelHeadline;
	public Text visuelText;
	public Text visuelHighText;
	public Text auditivHeadline;
	public Text auditivText;
	public Text taktilHeadline;
	public Text taktilText;
	public Text kineastetiskHeadline;
	public Text kineastetiskText;
	public Text buttonText;
	public Text envir;

	public bool tempFoldout = true;
	private int valueUserID;
	private string valueUserType;
	public ResultObject resultobjecValue;
	public bool testTaken;


	[Header ("HiglightPanels")]
	public GameObject analytiskHighlightPanel;
	public GameObject holistiskHighlightPanel;
	public GameObject visuelHighlightPanel;
	public GameObject auditivHighlightPanel;
	public GameObject taktilHighlightPanel;
	public GameObject kinæstetiskHighlightPanel;
	public GameObject læringsstilsmiljøHighlightPanel;

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
		
		Text[] arrAnalytisk = analytiskHighlightPanel.GetComponentsInChildren<Text>();
		Text[] arrHolistisk = holistiskHighlightPanel.GetComponentsInChildren<Text>();
		Text[] arrVisuel = visuelHighlightPanel.GetComponentsInChildren<Text>();
		Text[] arrKinaestetisk = kinæstetiskHighlightPanel.GetComponentsInChildren<Text>();
		Text[] arrAuditiv = auditivHighlightPanel.GetComponentsInChildren<Text>();
		Text[] arrTaktil = taktilHighlightPanel.GetComponentsInChildren<Text>();
		
		
		
		for(int q=0; q< 5; q++){
			arrAnalytisk[q].text =ds.DescpriptionAnalystPart2[q];
			arrHolistisk[q].text = ds.DescpriptionHolisticPart2[q];
			arrVisuel[q].text = ds.DescpriptionVisualPart2[q];
			arrKinaestetisk[q].text = ds.descpriptionKinestheticPart2[q];
			arrAuditiv[q].text = ds.DescpriptionAuditoryPart2[q];
			arrTaktil[q].text = ds.descpriptionTactilePart2[q];
			
		}
		
		holistiskText.text = ds.DescpriptionHolistic; 
		SubTitlePreferences.text = ds.SubTitlePreferences;
		visuelText.text = ds.DescpriptionVisual; 
		auditivText.text = ds.DescpriptionAuditory; 
		taktilText.text = ds.DescpriptionTactile; 
		kineastetiskText.text = ds.DescpriptionKinesthetic; 
		SubTitleEnvironment.text = ds.SubTitleEnvironment;
		
		Text[] arrLaeringsMiljoe = læringsstilsmiljøHighlightPanel.GetComponentsInChildren<Text>();
		
		
		switch(resultObject.Lyd){
		case 1:
			arrLaeringsMiljoe[0].text = ds.EnvirSoundOff;
			break;
		case 2:
			arrLaeringsMiljoe[0].text = ds.EnvirSoundOn;
			break;
		};
		switch(resultObject.Lys){
		case 1:
			arrLaeringsMiljoe[1].text = ds.EnvirLightOn;
			break;
		case 2:
			arrLaeringsMiljoe[1].text = ds.EnvirLightOff;
			break;
		};
		switch(resultObject.Temperatur){
		case 1:
			arrLaeringsMiljoe[2].text = ds.EnvirTempHot;
			break;
		case 2:
			arrLaeringsMiljoe[2].text = ds.EnvirTempCold;
			break;
		};
		
		switch(resultObject.Design){
		case 1:
			arrLaeringsMiljoe[3].text = ds.EnvirConfertTable;
			break;
		case 2:
			arrLaeringsMiljoe[3].text= ds.EnvirConfertSofa;
			break;
		};
		
		if(resultObject.Bevaeglse.Equals(1)){
			arrLaeringsMiljoe[4].text= ds.EnvirMovment;};

		if (buttonBool) {
			buttonText.text = ds.BtnTxtTagOm;
		} else if (!buttonBool) {
			buttonText.text = "Fortsæt Test";
		}
	}
	// sætter diagramerne i toppen, til falsk og true, da ellers ville ListItem ikke virke, kan måske slettes når ListItem er ændret.
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

	
	public void setImagesToFalse(){
		holistiskImage.gameObject.SetActive (false);
		analytikImage.gameObject.SetActive (false);
		visuelImage.gameObject.SetActive (false);
		auditivImage.gameObject.SetActive (false);
		taktilImage.gameObject.SetActive (false);
		kineastetiskImage.gameObject.SetActive (false);
	}
	
	public void setImagesToTrue(){
		holistiskImage.gameObject.SetActive (true);
		analytikImage.gameObject.SetActive (true);
		visuelImage.gameObject.SetActive (true);
		auditivImage.gameObject.SetActive (true);
		taktilImage.gameObject.SetActive (true);
		kineastetiskImage.gameObject.SetActive (true);
	}

	// Holistisk er altid 100% og i bagrunden, ændre analytik til og fylde de % den skal
	public void setHAImage(){
		float analytikFloat = float.Parse(resultobjecValue.Analystisk.ToString());
		analytikFloat = analytikFloat / 100;
		analytikImage.fillAmount = analytikFloat;
	}

	//Visuel er altid 100% og i bagrunden, ændre de 3 andre til at fylde de % de skal
	 public void setVATKImage(){
		float auditivFloat = float.Parse (resultobjecValue.Auditiv.ToString ());
		auditivFloat = auditivFloat / 100;
		float taktilFloat = float.Parse (resultobjecValue.Taktil.ToString());
		taktilFloat = taktilFloat / 100;
		float kineastetiskFloat = float.Parse(resultobjecValue.Kinaestisk.ToString());
		kineastetiskFloat = kineastetiskFloat / 100;
		auditivImage.fillAmount = kineastetiskFloat + taktilFloat + auditivFloat;
		taktilImage.fillAmount = kineastetiskFloat + taktilFloat;
		kineastetiskImage.fillAmount = kineastetiskFloat;
	}
	public void GoToTest(){
		PlayerPrefs.SetInt ("UserIDforTest", resultobjecValue.UserID);
		PlayerPrefs.SetString ("UserTypeforTest", resultobjecValue.UserType);
		Application.LoadLevel ("TestScene");
	}

}
