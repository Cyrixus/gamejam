using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BuildingTracker : MonoBehaviour {
	//Num of each building
	//Base Costs
	//Next Cost
	// Gameplay Constants

	private List<BuildingType> _buildingTracker = new List<BuildingType>();

	// Singleton instance
	public static BuildingTracker instance {get; private set;}
		
	private float population; // Current total population

	// Use this for initialization
	void Start () {
		// Add all types of buildings with their ID, Name, Base Cost, Cost Increase, Rate
		_buildingTracker.Add (new BuildingType(1, "Hut", 4.0f, 1.5f, 1.0f));
		_buildingTracker.Add (new BuildingType(2, "Farm", 10.0f, 2.0f, 3.0f));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
