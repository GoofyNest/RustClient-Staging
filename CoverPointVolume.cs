public class CoverPointVolume : MonoBehaviour, IServerComponent // TypeDefIndex: 12130
{	// Fields
	public float DefaultCoverPointScore; // 0x18
	public float CoverPointRayLength; // 0x1C
	public LayerMask CoverLayerMask; // 0x20
	public Transform BlockerGroup; // 0x28
	public Transform ManualCoverPointGroup; // 0x30
	[ServerVar] // RVA: 0xDFF90 Offset: 0xDF390 VA: 0x1800DFF90
	public static float cover_point_sample_step_size; // 0x0
	[ServerVar] // RVA: 0xE0130 Offset: 0xDF530 VA: 0x1800E0130
	public static float cover_point_sample_step_height; // 0x4
	public readonly List<CoverPoint> CoverPoints; // 0x38
	private readonly List<CoverPointBlockerVolume> _coverPointBlockers; // 0x40
	private Bounds bounds; // 0x48

	// Methods

	[ContextMenu] // RVA: 0xE0270 Offset: 0xDF670 VA: 0x1800E0270
	// RVA: 0x4BB670 Offset: 0x4B9C70 VA: 0x1804BB670
	private void ClearCoverPoints() { }

	// RVA: 0x4BB7C0 Offset: 0x4B9DC0 VA: 0x1804BB7C0
	public Bounds GetBounds() { }

	// RVA: 0x4BB440 Offset: 0x4B9A40 VA: 0x1804BB440
	private CoverPoint CalculateCoverPoint(NavMeshHit info) { }

	// RVA: 0x4BB950 Offset: 0x4B9F50 VA: 0x1804BB950
	internal CoverPointVolume.CoverType ProvidesCoverInDir(Ray ray, float maxDistance, out RaycastHit rayHit) { }

	// RVA: 0x4BB6D0 Offset: 0x4B9CD0 VA: 0x1804BB6D0
	public bool Contains(Vector3 point) { }

	// RVA: 0x4BBD70 Offset: 0x4BA370 VA: 0x1804BBD70
	public void .ctor() { }

	// RVA: 0x4BBD20 Offset: 0x4BA320 VA: 0x1804BBD20
	private static void .cctor() { }

}

internal enum CoverPointVolume.CoverType // TypeDefIndex: 12131
{	// Fields
	public int value__; // 0x0
	public const CoverPointVolume.CoverType None = 0;
	public const CoverPointVolume.CoverType Partial = 1;
	public const CoverPointVolume.CoverType Full = 2;

}

