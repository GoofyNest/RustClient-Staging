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
	// RVA: 0x4BB6E0 Offset: 0x4B9CE0 VA: 0x1804BB6E0
	private void ClearCoverPoints() { }

	// RVA: 0x4BB830 Offset: 0x4B9E30 VA: 0x1804BB830
	public Bounds GetBounds() { }

	// RVA: 0x4BB4B0 Offset: 0x4B9AB0 VA: 0x1804BB4B0
	private CoverPoint CalculateCoverPoint(NavMeshHit info) { }

	// RVA: 0x4BB9C0 Offset: 0x4B9FC0 VA: 0x1804BB9C0
	internal CoverPointVolume.CoverType ProvidesCoverInDir(Ray ray, float maxDistance, out RaycastHit rayHit) { }

	// RVA: 0x4BB740 Offset: 0x4B9D40 VA: 0x1804BB740
	public bool Contains(Vector3 point) { }

	// RVA: 0x4BBDE0 Offset: 0x4BA3E0 VA: 0x1804BBDE0
	public void .ctor() { }

	// RVA: 0x4BBD90 Offset: 0x4BA390 VA: 0x1804BBD90
	private static void .cctor() { }

}

internal enum CoverPointVolume.CoverType // TypeDefIndex: 12131
{	// Fields
	public int value__; // 0x0
	public const CoverPointVolume.CoverType None = 0;
	public const CoverPointVolume.CoverType Partial = 1;
	public const CoverPointVolume.CoverType Full = 2;

}

