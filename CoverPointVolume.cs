public class CoverPointVolume : MonoBehaviour, IServerComponent // TypeDefIndex: 12134
{	public float DefaultCoverPointScore; // 0x18
	public float CoverPointRayLength; // 0x1C
	public LayerMask CoverLayerMask; // 0x20
	public Transform BlockerGroup; // 0x28
	public Transform ManualCoverPointGroup; // 0x30
	[ServerVar] // RVA: 0xE02C0 Offset: 0xDF6C0 VA: 0x1800E02C0
	public static float cover_point_sample_step_size; // 0x0
	[ServerVar] // RVA: 0xE0380 Offset: 0xDF780 VA: 0x1800E0380
	public static float cover_point_sample_step_height; // 0x4
	public readonly List<CoverPoint> CoverPoints; // 0x38
	private readonly List<CoverPointBlockerVolume> _coverPointBlockers; // 0x40
	private Bounds bounds; // 0x48


	[ContextMenu] // RVA: 0xE0400 Offset: 0xDF800 VA: 0x1800E0400
	private void ClearCoverPoints() { }

	public Bounds GetBounds() { }

	private CoverPoint CalculateCoverPoint(NavMeshHit info) { }

	internal CoverPointVolume.CoverType ProvidesCoverInDir(Ray ray, float maxDistance, out RaycastHit rayHit) { }

	public bool Contains(Vector3 point) { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal enum CoverPointVolume.CoverType // TypeDefIndex: 12135
{	public int value__; // 0x0
	public const CoverPointVolume.CoverType None = 0;
	public const CoverPointVolume.CoverType Partial = 1;
	public const CoverPointVolume.CoverType Full = 2;

}

