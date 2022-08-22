public abstract class BaseFootstepEffect : MonoBehaviour, IClientComponent // TypeDefIndex: 9327
{	// Fields
	public LayerMask validImpactLayers; // 0x18
	private const float minTimeBetweenSteps = 0,05;
	private float lastFootstepTime; // 0x1C
	private const float minDistanceBetweenSteps = 0,5;
	private const float minDistanceBetweenStepsSqr = 0,25;
	protected Vector3 lastFootstepPos; // 0x20
	private const float maxDistanceToCamera = 75;

	// Methods

	// RVA: 0xA3B810 Offset: 0xA39E10 VA: 0x180A3B810
	protected BaseFootstepEffect.GroundInfo GetGroundInfo(Vector3 position, Vector3 forward, bool bIgnoreDistanceCheck = False) { }

	// RVA: 0xA3BC40 Offset: 0xA3A240 VA: 0x180A3BC40
	protected void .ctor() { }

}

