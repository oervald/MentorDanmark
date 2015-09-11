using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResultController : MonoBehaviour {

	[Header("Headlines")]
	public Text headlineText;
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

	bool foldout = false;
	private string holistisk; 
	private string analytisk;
	private string visuel; 
	private string auditiv;
	private string taktil; 
	private string kineatetisk; 

	public ResultObject resultobjec;

	// Use this for initialization
	void Start () {
		resultobjec = new ResultObject ();
		setImagesToFalse ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetupPage(){
		DanishStrings ds = new DanishStrings ();
		SubTitleTitel.text = ds.SubTitleResult;
		SubTitleThinkingStyle.text = ds.SubTitleThinkingStyle;
		analytikHeadline.text = ds.TitleAnalyst + " (" + resultobjec.Analystisk + "%)" ; 
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

	}

	// Holistisk er altid 100% og i bagrunden, ændre analytik til og fylde de % den skal
	public void setHAImage(){
		float analytikFloat = float.Parse(resultobjec.Analystisk.ToString());
		analytikFloat = analytikFloat / 100;
		analytikImage.fillAmount = analytikFloat;
	}
	//Visuel er altid 100% og i bagrunden, ændre de 3 andre til at fylde de % de skal
	public void setVATKImage(){
		float auditivFloat = float.Parse (resultobjec.Auditiv.ToString ());
		auditivFloat = auditivFloat / 100;
		float taktilFloat = float.Parse (resultobjec.Taktil.ToString());
		taktilFloat = taktilFloat / 100;
		float kineastetiskFloat = float.Parse(resultobjec.Kinaestisk.ToString());
		kineastetiskFloat = kineastetiskFloat / 100;
		auditivImage.fillAmount = kineastetiskFloat + taktilFloat + auditivFloat;
		taktilImage.fillAmount = kineastetiskFloat + taktilFloat;
		kineastetiskImage.fillAmount = kineastetiskFloat;
	}

	// sætter diagramerne i toppen, til falsk og true, da ellers ville ListItem ikke virke, kan måske slettes når ListItem er ændret.
	public void onHeadlineClick(){
		if (foldout == false) {
			setImagesToTrue ();
			foldout = true;
		} else {
			setImagesToFalse();
			foldout = false;
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

 public void setPrimaryThinkingStyle(){

		float holistisk = 0f; 
		float analystisk = 0f; 

		if (holistisk > analystisk) {

			// set holistisk primary 

		}
			else if (holistisk == analystisk){

				// sætter begge to primary 
			}
				else {

					// analytisk 

				}
}

	public void setLearningPreferences(){

		



	}

}