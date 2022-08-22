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

	// RVA: 0x111F440 Offset: 0x111DA40 VA: 0x18111F440
	private void OnValidate() { }

	// RVA: 0x111F3A0 Offset: 0x111D9A0 VA: 0x18111F3A0
	private void OnEnable() { }

	// RVA: 0x111F380 Offset: 0x111D980 VA: 0x18111F380
	private void OnDisable() { }

	// RVA: 0x111FEE0 Offset: 0x111E4E0 VA: 0x18111FEE0
	private void Start() { }

	// RVA: 0x111F350 Offset: 0x111D950 VA: 0x18111F350
	private void LateUpdate() { }

	// RVA: 0x111F0C0 Offset: 0x111D6C0 VA: 0x18111F0C0
	private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff) { }

	// RVA: 0x111EC00 Offset: 0x111D200 VA: 0x18111EC00
	private RaycastHit GetBestHit(Vector3 rayPos, Vector3 rayDir) { }

	// RVA: 0x111EEC0 Offset: 0x111D4C0 VA: 0x18111EEC0
	private Vector3 GetDirection(uint dirInt) { }

	// RVA: 0x111F1F0 Offset: 0x111D7F0 VA: 0x18111F1F0
	private bool IsHitValid(RaycastHit hit) { }

	// RVA: 0x111F4C0 Offset: 0x111DAC0 VA: 0x18111F4C0
	private void ProcessRaycasts() { }

	// RVA: 0x111FD60 Offset: 0x111E360 VA: 0x18111FD60
	private void SetHit(RaycastHit hit) { }

	// RVA: 0x111F380 Offset: 0x111D980 VA: 0x18111F380
	private void SetHitNull() { }

	// RVA: 0x111FC20 Offset: 0x111E220 VA: 0x18111FC20
	private void SetClippingPlane(Plane planeWS) { }

	// RVA: 0x111F380 Offset: 0x111D980 VA: 0x18111F380
	private void SetClippingPlaneOff() { }

	// RVA: 0x111FFC0 Offset: 0x111E5C0 VA: 0x18111FFC0
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

