using UnityEngine;

public class UpgradeEffect {

	private object _target;
	public object Target {
		get {
			if (_target is BuildingType)
			{
				Debug.Log ("its a building type!");
				return _target;
			}
			else
			{
				Debug.Log ("it ain't no building type...");
				return _target;
			}
		}
	}

	private static float _multiplier;
	public float Multiplier {
		get {
			return _multiplier;
		}
	}

	public UpgradeEffect (object target, float multiplier) {
		_multiplier = multiplier;
		_target = target;
	}
}
