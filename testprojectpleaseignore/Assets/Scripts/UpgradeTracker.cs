using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UpgradeTracker : MonoBehaviour {

	private List<Upgrade> _upgrades = new List<Upgrade>();
	
	// Singleton instance
	public static UpgradeTracker instance {get; private set;}

	// Use this for initialization
	void Start () {
		_upgrades.Add (new Upgrade("More clicking powah!", 2.0f, new UpgradeEffect(new Object(), 2.0f)));
		_upgrades.Add (new Upgrade("SUPER TIPIS", 4.0f, new UpgradeEffect(new Object(), 1.5f)));
	}
	
	void Awake() {
		// Update our singleton to the current active instance
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public string getName(int index) {
		return _upgrades[index].Name;
	}

	public float getCost(int index) {
		return _upgrades [index].Cost;
	}

	public UpgradeEffect getEffect(int index) {
		return _upgrades[index].Effect;
	}

	public bool buyUpgrade(int index) {
		if (ResourceTracker.instance.applyPopulationImpulse(0 - getCost(index))) {
			_upgrades[index].IsActive = true;
			return true;
		}

		return false;
	}
}
