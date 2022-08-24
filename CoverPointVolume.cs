public class CoverPointVolume : MonoBehaviour, IServerComponent // TypeDefIndex: 12134
{	public float DefaultCoverPointScore; // 0x18
	public float CoverPointRayLength; // 0x1C
	public LayerMask CoverLayerMask; // 0x20
	public Transform BlockerGroup; // 0x28
	public Transform ManualCoverPointGroup; // 0x30
	[ServerVar] // RVA: 0xDFB70 Offset: 0xDEF70 VA: 0x1800DFB70
	public static float cover_point_sample_step_size; // 0x0
	[ServerVar] // RVA: 0xDFD50 Offset: 0xDF150 VA: 0x1800DFD50
	public static float cover_point_sample_step_height; // 0x4
	public readonly List<CoverPoint> CoverPoints; // 0x38
	private readonly List<CoverPointBlockerVolume> _coverPointBlockers; // 0x40
	private Bounds bounds; // 0x48


	[ContextMenu] // RVA: 0xDFDE0 Offset: 0xDF1E0 VA: 0x1800DFDE0
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

