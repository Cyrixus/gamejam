public class UpgradeEffect {

	private object _target;
	public object Target {
		get {
			return _target;
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
