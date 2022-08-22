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

	// RVA: 0xA3BD00 Offset: 0xA3A300 VA: 0x180A3BD00
	protected BaseFootstepEffect.GroundInfo GetGroundInfo(Vector3 position, Vector3 forward, bool bIgnoreDistanceCheck = False) { }

	// RVA: 0xA3C130 Offset: 0xA3A730 VA: 0x180A3C130
	protected void .ctor() { }

}

