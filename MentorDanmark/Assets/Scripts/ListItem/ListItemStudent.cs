using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ListItemStudent : ListItem2 {

	[Header("Student")]
	public GameObject viewPanel;

	[Header("Headlines")]
	public Text SubTitleTitel;
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
	public Text buttomText;
	public Text envir;

	bool tempFoldout = true;
	private int valueUserID;
	private string valueUserType;
	public ResultObject resultobjecValue;
	public bool testTaken;
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

	public void SetupPage(ResultObject resultobjec){

			resultobjecValue = resultobjec;
		setTestNotTakenBool ();
			GameObject container = GameObject.Find ("Container");
			DanishStrings ds = new DanishStrings ();
			
		// headline skal sættes dynamisk
			
			valueUserID = resultobjec.UserID;
			valueUserType = resultobjec.UserType;
			headlineText.text = resultobjec.UserID.ToString () + "( " + resultobjec.UserType + ")";
		if (testTaken) {
			SubTitleTitel.text = ds.SubTitleResult;
			SubTitleThinkingStyle.text = ds.SubTitleThinkingStyle;
			analytikHeadline.text = ds.TitleAnalyst + " (" + resultobjec.Analystisk + "%)"; 
			analytikText.text = ds.DescpriptionAnalyst; 
			holistiskHeadline.text = ds.TitleHolistic1 + " (" + resultobjec.Holistisk + "%)"; 
			holistiskText.text = ds.DescpriptionHolistic; 
			SubTitlePreferences.text = ds.SubTitlePreferences; 
			visuelHeadline.text = ds.TitleVisual1 + " (" + resultobjec.Visuel + "%)"; 
			visuelText.text = ds.DescpriptionVisual; 
			auditivHeadline.text = ds.TitleAuditory1 + " (" + resultobjec.Auditiv + "%)"; 
			auditivText.text = ds.DescpriptionAuditory; 
			taktilHeadline.text = ds.TitleTactile1 + " (" + resultobjec.Taktil + "%)"; 
			taktilText.text = ds.DescpriptionTactile; 
			kineastetiskHeadline.text = ds.TitleKinesthetic1 + " (" + resultobjec.Kinaestisk + "%)"; 
			kineastetiskText.text = ds.DescpriptionKinesthetic; 
			SubTitleEnvironment.text = ds.SubTitleEnvironment;
		
			setHAImage ();
			setVATKImage ();
			this.transform.SetParent (container.transform);
			this.transform.localScale = new Vector3 (1, 1, 1);
			ResetHeight ();
		} else {

			this.transform.SetParent (container.transform);
			this.transform.localScale = new Vector3 (1, 1, 1);
		
			ResetHeight ();
			setImagesToFalse();

		}
		
	}

	// sætter diagramerne i toppen, til falsk og true, da ellers ville ListItem ikke virke, kan måske slettes når ListItem er ændret.
	public void onHeadlineClick(){
		if (tempFoldout == false) {
			if(testTaken){
			setImagesToTrue ();
			}
			tempFoldout = true;
			PlayerPrefs.SetInt("UserID", valueUserID);
			PlayerPrefs.SetString("UserType", valueUserType);
			Fold();
		} else {
			setImagesToFalse();
			tempFoldout = false;
			Fold();
		}
	}

	public void setTestNotTakenBool(){
		if (resultobjecValue.Analystisk != 0 && resultobjecValue.Holistisk != 0 && resultobjecValue.Auditiv != 0 && resultobjecValue.Visuel != 0 && resultobjecValue.Kinaestisk != 0 && resultobjecValue.Taktil != 0) {
			testTaken = true;
		} else {
			testTaken = false;
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

}
