public class WaterCullingVolume : MonoBehaviour // TypeDefIndex: 10601
{	// Fields
	public bool isDynamic; // 0x18
	private Bounds worldBounds; // 0x1C
	private Vector4[] worldToLocal; // 0x38
	private bool isVisible; // 0x40
	private float distanceToCamera; // 0x44
	private static HashSet<WaterCullingVolume> volumes; // 0x0

	// Properties
	public Bounds WorldBounds { get; }
	public Vector4[] WorldToLocal { get; }
	public bool IsVisible { get; }
	public float DistanceToCamera { get; }
	public static HashSet<WaterCullingVolume> Volumes { get; }

	// Methods

	// RVA: 0x805670 Offset: 0x803C70 VA: 0x180805670
	public Bounds get_WorldBounds() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public Vector4[] get_WorldToLocal() { }

	// RVA: 0x805600 Offset: 0x803C00 VA: 0x180805600
	public bool get_IsVisible() { }

	// RVA: 0x8055F0 Offset: 0x803BF0 VA: 0x1808055F0
	public float get_DistanceToCamera() { }

	// RVA: 0x805610 Offset: 0x803C10 VA: 0x180805610
	public static HashSet<WaterCullingVolume> get_Volumes() { }

	// RVA: 0x805090 Offset: 0x803690 VA: 0x180805090
	private void UpdateTransformInfo() { }

	// RVA: 0x805010 Offset: 0x803610 VA: 0x180805010
	private void OnEnable() { }

	// RVA: 0x804F40 Offset: 0x803540 VA: 0x180804F40
	private void OnDisable() { }

	// RVA: 0x8054F0 Offset: 0x803AF0 VA: 0x1808054F0
	private void Update() { }

	// RVA: 0x8053C0 Offset: 0x8039C0 VA: 0x1808053C0
	public bool UpdateVisibility(Plane[] frustumPlanes, Vector3 cameraWorldPos) { }

	// RVA: 0x805000 Offset: 0x803600 VA: 0x180805000
	protected void OnDrawGizmos() { }

	// RVA: 0x804FF0 Offset: 0x8035F0 VA: 0x180804FF0
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x804DC0 Offset: 0x8033C0 VA: 0x180804DC0
	private void DrawGizmos(float alpha) { }

	// RVA: 0x805590 Offset: 0x803B90 VA: 0x180805590
	public void .ctor() { }

	// RVA: 0x805530 Offset: 0x803B30 VA: 0x180805530
	private static void .cctor() { }

}

