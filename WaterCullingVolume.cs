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

	// RVA: 0x805560 Offset: 0x803B60 VA: 0x180805560
	public Bounds get_WorldBounds() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public Vector4[] get_WorldToLocal() { }

	// RVA: 0x8054F0 Offset: 0x803AF0 VA: 0x1808054F0
	public bool get_IsVisible() { }

	// RVA: 0x8054E0 Offset: 0x803AE0 VA: 0x1808054E0
	public float get_DistanceToCamera() { }

	// RVA: 0x805500 Offset: 0x803B00 VA: 0x180805500
	public static HashSet<WaterCullingVolume> get_Volumes() { }

	// RVA: 0x804F80 Offset: 0x803580 VA: 0x180804F80
	private void UpdateTransformInfo() { }

	// RVA: 0x804F00 Offset: 0x803500 VA: 0x180804F00
	private void OnEnable() { }

	// RVA: 0x804E30 Offset: 0x803430 VA: 0x180804E30
	private void OnDisable() { }

	// RVA: 0x8053E0 Offset: 0x8039E0 VA: 0x1808053E0
	private void Update() { }

	// RVA: 0x8052B0 Offset: 0x8038B0 VA: 0x1808052B0
	public bool UpdateVisibility(Plane[] frustumPlanes, Vector3 cameraWorldPos) { }

	// RVA: 0x804EF0 Offset: 0x8034F0 VA: 0x180804EF0
	protected void OnDrawGizmos() { }

	// RVA: 0x804EE0 Offset: 0x8034E0 VA: 0x180804EE0
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x804CB0 Offset: 0x8032B0 VA: 0x180804CB0
	private void DrawGizmos(float alpha) { }

	// RVA: 0x805480 Offset: 0x803A80 VA: 0x180805480
	public void .ctor() { }

	// RVA: 0x805420 Offset: 0x803A20 VA: 0x180805420
	private static void .cctor() { }

}

