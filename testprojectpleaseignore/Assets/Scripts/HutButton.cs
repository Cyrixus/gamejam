using UnityEngine;
using System.Collections;

public class HutButton : MonoBehaviour {

	// Use this for initialization
	void Start() {

	}
	
	// Update is called once per frame
	void Update() {
		
	}
	
	void OnMouseDown() {
		// Increment counter
		BuildingTracker.instance.buyBuilding(0);
	}
}
