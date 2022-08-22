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

	// RVA: 0x111E9D0 Offset: 0x111CFD0 VA: 0x18111E9D0
	private void OnValidate() { }

	// RVA: 0x111E930 Offset: 0x111CF30 VA: 0x18111E930
	private void OnEnable() { }

	// RVA: 0x111E910 Offset: 0x111CF10 VA: 0x18111E910
	private void OnDisable() { }

	// RVA: 0x111F470 Offset: 0x111DA70 VA: 0x18111F470
	private void Start() { }

	// RVA: 0x111E8E0 Offset: 0x111CEE0 VA: 0x18111E8E0
	private void LateUpdate() { }

	// RVA: 0x111E650 Offset: 0x111CC50 VA: 0x18111E650
	private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff) { }

	// RVA: 0x111E190 Offset: 0x111C790 VA: 0x18111E190
	private RaycastHit GetBestHit(Vector3 rayPos, Vector3 rayDir) { }

	// RVA: 0x111E450 Offset: 0x111CA50 VA: 0x18111E450
	private Vector3 GetDirection(uint dirInt) { }

	// RVA: 0x111E780 Offset: 0x111CD80 VA: 0x18111E780
	private bool IsHitValid(RaycastHit hit) { }

	// RVA: 0x111EA50 Offset: 0x111D050 VA: 0x18111EA50
	private void ProcessRaycasts() { }

	// RVA: 0x111F2F0 Offset: 0x111D8F0 VA: 0x18111F2F0
	private void SetHit(RaycastHit hit) { }

	// RVA: 0x111E910 Offset: 0x111CF10 VA: 0x18111E910
	private void SetHitNull() { }

	// RVA: 0x111F1B0 Offset: 0x111D7B0 VA: 0x18111F1B0
	private void SetClippingPlane(Plane planeWS) { }

	// RVA: 0x111E910 Offset: 0x111CF10 VA: 0x18111E910
	private void SetClippingPlaneOff() { }

	// RVA: 0x111F550 Offset: 0x111DB50 VA: 0x18111F550
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

