using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

public class HuntCountLabel : MonoBehaviour {
	// Public Text Field for use with editor.
	public Text huntCount;
	
	
	// Use this for initialization
	void Start () {
		if(huntCount != null) {
			huntCount.text = "0";
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(huntCount != null) {
			huntCount.text = String.Format("{0,5:N1}", BuildingTracker.instance.getCount(1));
		}
	}
}