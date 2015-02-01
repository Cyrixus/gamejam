using UnityEngine;
using System.Collections;

public class BuildingTracker : MonoBehaviour {
	//Num of each building
	//Base Costs
	//Next Cost
	// Gameplay Constants
	private static float STARTING_HUT_COST = 4.0f;
	private static float BASE_HUT_GEN = 1.0f;
	private static float COST_INC_MOD = 1.5f;

	// Singleton instance
	public static BuildingTracker instance {get; private set;}
	
	private float huts;      // Current total huts
	private float hutsCost;  // Current hut cost
	private float hutsGen;   // Current hut resource gen rate
	
	private float population; // Current total population

	// Use this for initialization
	void Start () {
		huts = 0.0f;
		hutsCost = STARTING_HUT_COST;
		hutsGen = BASE_HUT_GEN;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// HUTS
	// Accessors
	public float getHuts() {
		return huts;
	}

	public float getHutsCost() {
		return hutsCost;
	}

	public float getHutsGen() {
		return hutsGen;
	}

	public bool buyHut() {
		if (ResourceTracker.instance.applyPopulationImpulse(0 - hutsCost)) {
			if (ResourceTracker.instance.applyPopulationImpulse(hutsGen)) return true;
		}
		return false;
	}

}
