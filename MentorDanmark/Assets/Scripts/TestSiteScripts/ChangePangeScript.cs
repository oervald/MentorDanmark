using UnityEngine;
using System.Collections;

public class ChangePangeScript : MonoBehaviour {

	public RectTransform Analytisk;
	public RectTransform Holistisk;
	public RectTransform Visuel;
	public RectTransform Audiotiv;
	public RectTransform Taktil;
	public RectTransform Kinaetisk;
	public RectTransform Lys;
	public RectTransform Lyd;
	public RectTransform Temperatur;
	public RectTransform Design;
	public RectTransform Bevaegelse;

	private int pageNumber;
	POSTAnswersController pac;
	ArrayList siteList;

	void OnShow(){
		Analytisk.transform.SetAsLastSibling ();


	}
	// Use this for initialization
	void Start () {
		pac = gameObject.GetComponent<POSTAnswersController> ();
		siteList = new ArrayList ();
		siteList.Add (Holistisk);
		siteList.Add (Analytisk);
		siteList.Add (Visuel);
		siteList.Add (Audiotiv);
		siteList.Add (Taktil);

		siteList.Add (Kinaetisk);
		siteList.Add (Lys);
		siteList.Add (Lyd);
		siteList.Add (Temperatur);
		siteList.Add (Design);
		siteList.Add (Bevaegelse);

		pageNumber = 0;
		Holistisk.transform.SetAsLastSibling ();

		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void ChangePage(){
		saveLocal ();
		RectTransform active = new RectTransform ();
		pageNumber++;
		active = (RectTransform) siteList[pageNumber];
		active.transform.SetAsLastSibling();

	
		
	}

	public void ChangePageBack(){
		saveLocal ();
		RectTransform active = new RectTransform ();
		pageNumber--;
		active = (RectTransform)siteList [pageNumber];
		active.transform.SetAsLastSibling ();

	}

	public void saveLocal(){
		pac.SaveAnswers ("SaveLocal");
}
	public void ChangeToMentorAndSave(){
		pac.SaveAnswers ("SaveToServer");
	}
}

