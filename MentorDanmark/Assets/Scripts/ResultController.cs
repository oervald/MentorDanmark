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


	bool foldout = false;

	// Use this for initialization
	void Start () {
		setImagesToFalse ();
		DanishStrings danishStrings = new DanishStrings ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setHAImage(float analytikFloat){

		analytikImage.fillAmount = analytikFloat;
	}

	public void setVATKImage(float auditivFloat, float taktilFloat, float kineastetiskFloat){
		auditivImage.fillAmount = kineastetiskFloat + taktilFloat + auditivFloat;
		taktilImage.fillAmount = kineastetiskFloat + taktilFloat;
		kineastetiskImage.fillAmount = kineastetiskFloat;
	}

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


}
