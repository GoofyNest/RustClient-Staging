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

	// RVA: 0x805C00 Offset: 0x804200 VA: 0x180805C00
	public Bounds get_WorldBounds() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public Vector4[] get_WorldToLocal() { }

	// RVA: 0x805B90 Offset: 0x804190 VA: 0x180805B90
	public bool get_IsVisible() { }

	// RVA: 0x805B80 Offset: 0x804180 VA: 0x180805B80
	public float get_DistanceToCamera() { }

	// RVA: 0x805BA0 Offset: 0x8041A0 VA: 0x180805BA0
	public static HashSet<WaterCullingVolume> get_Volumes() { }

	// RVA: 0x805620 Offset: 0x803C20 VA: 0x180805620
	private void UpdateTransformInfo() { }

	// RVA: 0x8055A0 Offset: 0x803BA0 VA: 0x1808055A0
	private void OnEnable() { }

	// RVA: 0x8054D0 Offset: 0x803AD0 VA: 0x1808054D0
	private void OnDisable() { }

	// RVA: 0x805A80 Offset: 0x804080 VA: 0x180805A80
	private void Update() { }

	// RVA: 0x805950 Offset: 0x803F50 VA: 0x180805950
	public bool UpdateVisibility(Plane[] frustumPlanes, Vector3 cameraWorldPos) { }

	// RVA: 0x805590 Offset: 0x803B90 VA: 0x180805590
	protected void OnDrawGizmos() { }

	// RVA: 0x805580 Offset: 0x803B80 VA: 0x180805580
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x805350 Offset: 0x803950 VA: 0x180805350
	private void DrawGizmos(float alpha) { }

	// RVA: 0x805B20 Offset: 0x804120 VA: 0x180805B20
	public void .ctor() { }

	// RVA: 0x805AC0 Offset: 0x8040C0 VA: 0x180805AC0
	private static void .cctor() { }

}

