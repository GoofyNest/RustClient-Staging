public class DynamicOcclusion : MonoBehaviour // TypeDefIndex: 11540
{	// Fields
	public LayerMask layerMask; // 0x18
	public float minOccluderArea; // 0x1C
	public int waitFrameCount; // 0x20
	public float minSurfaceRatio; // 0x24
	public float maxSurfaceDot; // 0x28
	public PlaneAlignment planeAlignment; // 0x2C
	public float planeOffset; // 0x30
	private VolumetricLightBeam m_Master; // 0x38
	private int m_FrameCountToWait; // 0x40
	private float m_RangeMultiplier; // 0x44
	private uint m_PrevNonSubHitDirectionId; // 0x48

	// Methods

	// RVA: 0x111E710 Offset: 0x111CD10 VA: 0x18111E710
	private void OnValidate() { }

	// RVA: 0x111E670 Offset: 0x111CC70 VA: 0x18111E670
	private void OnEnable() { }

	// RVA: 0x111E650 Offset: 0x111CC50 VA: 0x18111E650
	private void OnDisable() { }

	// RVA: 0x111F1B0 Offset: 0x111D7B0 VA: 0x18111F1B0
	private void Start() { }

	// RVA: 0x111E620 Offset: 0x111CC20 VA: 0x18111E620
	private void LateUpdate() { }

	// RVA: 0x111E390 Offset: 0x111C990 VA: 0x18111E390
	private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff) { }

	// RVA: 0x111DED0 Offset: 0x111C4D0 VA: 0x18111DED0
	private RaycastHit GetBestHit(Vector3 rayPos, Vector3 rayDir) { }

	// RVA: 0x111E190 Offset: 0x111C790 VA: 0x18111E190
	private Vector3 GetDirection(uint dirInt) { }

	// RVA: 0x111E4C0 Offset: 0x111CAC0 VA: 0x18111E4C0
	private bool IsHitValid(RaycastHit hit) { }

	// RVA: 0x111E790 Offset: 0x111CD90 VA: 0x18111E790
	private void ProcessRaycasts() { }

	// RVA: 0x111F030 Offset: 0x111D630 VA: 0x18111F030
	private void SetHit(RaycastHit hit) { }

	// RVA: 0x111E650 Offset: 0x111CC50 VA: 0x18111E650
	private void SetHitNull() { }

	// RVA: 0x111EEF0 Offset: 0x111D4F0 VA: 0x18111EEF0
	private void SetClippingPlane(Plane planeWS) { }

	// RVA: 0x111E650 Offset: 0x111CC50 VA: 0x18111E650
	private void SetClippingPlaneOff() { }

	// RVA: 0x111F290 Offset: 0x111D890 VA: 0x18111F290
	public void .ctor() { }

}

private enum DynamicOcclusion.Direction // TypeDefIndex: 11541
{	// Fields
	public int value__; // 0x0
	public const DynamicOcclusion.Direction Up = 0;
	public const DynamicOcclusion.Direction Right = 1;
	public const DynamicOcclusion.Direction Down = 2;
	public const DynamicOcclusion.Direction Left = 3;

}

