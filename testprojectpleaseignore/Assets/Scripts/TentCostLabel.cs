using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

public class TentCostLabel : MonoBehaviour {
	// Public Text Field for use with editor.
	public Text tentCost;
	
	
	// Use this for initialization
	void Start () {
		if(tentCost != null) {
			tentCost.text = "0";
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(tentCost != null) {
			tentCost.text = String.Format("{0,5:N1}", BuildingTracker.instance.getCost(0));
		}
	}
}