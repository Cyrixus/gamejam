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
		_buildingTracker.Add (new BuildingType(1, "Hut", 2.0f, 1.2f, 1.0f));
		_buildingTracker.Add (new BuildingType(2, "Hunters", 2.0f, 1.2f, 3.0f));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Awake() {
		// Update our singleton to the current active instance
		instance = this;
	}

	// HUTS
	// Accessors
	//Placeholders until stuff's sorted
	public float getCount(int index) {
		return _buildingTracker[index].Count;
	}

	public float getCost(int index) {
		return _buildingTracker[index].CurrentCost;
	}

	public float getGen(int index) {
		return _buildingTracker[index].GenerationRate;
	}

	public bool buyBuilding(int index) {
		// Check to see if subtracting hutsCost is OK against current pop and if so, do it
		if (ResourceTracker.instance.applyPopulationImpulse(0 - getCost(index))) {
			_buildingTracker[index].AddBuilding();
			return true;
		}
		return false;
	}

	public float getFoodProduction() {
		BuildingType hunters = _buildingTracker[1];
		return hunters.Count * hunters.GenerationRate;
	}

	public float getPopulationProduction() {
		BuildingType huts = _buildingTracker[0];
		return huts.Count * huts.GenerationRate;
	}
}
