using UnityEngine;
using System.Collections;

public class HuntButton : MonoBehaviour {
	
	// Use this for initialization
	void Start() {
		
	}
	
	// Update is called once per frame
	void Update() {
		
	}
	
	void OnMouseDown() {
		// Increment counter
		BuildingTracker.instance.buyBuilding(1);
	}
}
