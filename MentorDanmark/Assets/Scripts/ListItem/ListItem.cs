using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class ListItem : MonoBehaviour
{
	[Header("ListItem")]


	// Child vars
	public Image headlineIcon;
	public Text foldoutText;

	// Fold vars
	public float foldoutSpeed = 10;
	public bool foldout = true;

	// Layout vars
	public float headlineHeight = 100;
	public float height;
	public float curHeight;
	public float padding = 40;

	// Other vars
	float actualHeight;
	RectTransform rt;

	
	// Use this for initialization
	public virtual void Start ()
	{
		rt = (RectTransform)gameObject.transform;

		transform.Find ("Headline").GetComponent<LayoutElement> ().preferredHeight = headlineHeight;
		transform.Find ("Headline").GetComponent<LayoutElement> ().minHeight = headlineHeight;

		if(foldoutText == null){
			foldoutText = transform.Find("Headline/Icon").GetComponent<Text>();
		}

		height = GetComponent<LayoutElement> ().preferredHeight;
		if (!foldout) {
			GetComponent<LayoutElement> ().preferredHeight = headlineHeight;

			foldoutText.text = "+";
		} 
		else {
			foldoutText.text = "-";
		}
		curHeight = GetComponent<LayoutElement> ().preferredHeight;
		height = LayoutUtility.GetPreferredHeight (GetComponent<RectTransform> ());

		
		ResetHeight ();
	}

	// Update is called once per frame
	public virtual void Update ()
	{
	
		return;
		// Foldout uses DOTween now.

		curHeight = GetComponent<LayoutElement> ().preferredHeight;
//		curHeight = GetComponent<Transform> ().transform.h;
		if (foldout && curHeight != -1) {
			//print ("Cur + height" + curHeight + " " + height);
			if (curHeight > height - 1) {
				GetComponent<LayoutElement> ().preferredHeight = height;
				curHeight = -1;
				//print ("done");

			} else {
				GetComponent<LayoutElement> ().preferredHeight = iTween.FloatUpdate (curHeight, height, foldoutSpeed);
//				GetComponent<LayoutElement> ().preferredHeight = height;
				//print ("tweening out");
				
			}
			foldoutText.text = "-";
		}
		if (!foldout && curHeight != headlineHeight) {
			if (curHeight == -1) {
				curHeight = height;
			}

			float newHeight = iTween.FloatUpdate (curHeight, headlineHeight, foldoutSpeed);
			GetComponent<LayoutElement> ().preferredHeight = newHeight;
//			GetComponent<LayoutElement> ().preferredHeight = 100;
			foldoutText.text = "+";
			if(newHeight < headlineHeight + 1){
				//print("should stop now");
				newHeight = headlineHeight;
				curHeight = headlineHeight;
				GetComponent<LayoutElement> ().preferredHeight = newHeight;
			}
			//print ("still folding with: " + newHeight);
			
		}



//		actualHeight = rt.rect.height;
//		print ("Update");
//		print (actualHeight);
	}

	// Calculates the total height of the ListItem by checking every child LayoutElement's preferredHeight.
	public void ResetHeight ()
	{

		height = LayoutUtility.GetPreferredHeight (GetComponent<RectTransform> ());

		height = 0;
		foreach (LayoutElement le in GetComponentsInChildren<LayoutElement>()) {
			if(le != GetComponent<LayoutElement>() && le.gameObject.activeInHierarchy){
				if(le.transform.parent.GetComponent<LayoutElement>() != null && le.transform.parent.GetComponent<LayoutElement>().preferredHeight > 0){

				}
				if(le.transform.parent == transform)
					height += LayoutUtility.GetPreferredHeight(le.GetComponent<RectTransform>());
				
				if(transform.GetSiblingIndex() == 3){
					print ("name = " + le.name + " " + LayoutUtility.GetPreferredHeight(le.GetComponent<RectTransform>()));
					print (transform.GetSiblingIndex() + " new height: " + height);
				}
			}
		}
		height += padding;

		//print ("Total height is?: " + height);


		//GetComponent<LayoutElement> ().preferredHeight = height;
//		print ("Changed internal height to: " + height);
	}

	// Should update this to include a change in the headline +/-
	public void Fold (){
		foldout = !foldout;
		ResetHeight ();
		if (foldout) {
			foldoutText.GetComponentInChildren<Text> ().text = "-";
			GetComponent<LayoutElement>().DOPreferredSize(Vector2.up*height + Vector2.left, foldoutSpeed, false);
		} 
		else {
			foldoutText.GetComponentInChildren<Text> ().text = "+";
			GetComponent<LayoutElement>().DOPreferredSize(Vector2.up*headlineHeight + Vector2.left, foldoutSpeed, false);
		}

	}



}
	

