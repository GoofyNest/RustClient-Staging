public class WaterMesh // TypeDefIndex: 10617
{	// Fields
	private Mesh borderMesh; // 0x10
	private Mesh centerPatch; // 0x18
	private int borderRingCount; // 0x20
	private float borderRingSpacingFalloff; // 0x24
	private int resolution; // 0x28
	private Vector3[] borderVerticesLocal; // 0x30
	private Vector3[] borderVerticesWorld; // 0x38
	private bool initialized; // 0x40

	// Properties
	public Mesh BorderMesh { get; }
	public Mesh CenterPatch { get; }
	public bool IsInitialized { get; }

	// Methods

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public Mesh get_BorderMesh() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Mesh get_CenterPatch() { }

	// RVA: 0x805B90 Offset: 0x804190 VA: 0x180805B90
	public bool get_IsInitialized() { }

	// RVA: 0xC19420 Offset: 0xC17A20 VA: 0x180C19420
	public void Initialize(int patchResolution, float patchSizeInWorld, int borderRingCount, float borderRingSpacingFalloff) { }

	// RVA: 0xC193A0 Offset: 0xC179A0 VA: 0x180C193A0
	public void Destroy() { }

	// RVA: 0xC195E0 Offset: 0xC17BE0 VA: 0x180C195E0
	public void UpdateBorderMesh(Matrix4x4 centerLocalToWorld, Matrix4x4 borderLocalToWorld, bool collapseCenter) { }

	// RVA: 0xC17D60 Offset: 0xC16360 VA: 0x180C17D60
	private Mesh CreateSortedBorderPatch(int resolution, int ringCount, float sizeInWorld) { }

	// RVA: 0xC18650 Offset: 0xC16C50 VA: 0x180C18650
	private Mesh CreateSortedCenterPatch(int resolution, float sizeInWorld, bool borderOnly) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

