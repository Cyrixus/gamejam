using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

public class PopulationLabel : MonoBehaviour {
	// Public Text Field for use with editor.
	public Text foodLabel;
	
	
	// Use this for initialization
	void Start () {
		if(foodLabel != null) {
			foodLabel.text = "0";
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(foodLabel != null) {
			foodLabel.text = String.Format("{0,5:N1}", ResourceTracker.instance.getPopulation());
		}
	}
}
