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

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public Mesh get_BorderMesh() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Mesh get_CenterPatch() { }

	// RVA: 0x8054F0 Offset: 0x803AF0 VA: 0x1808054F0
	public bool get_IsInitialized() { }

	// RVA: 0xC18C90 Offset: 0xC17290 VA: 0x180C18C90
	public void Initialize(int patchResolution, float patchSizeInWorld, int borderRingCount, float borderRingSpacingFalloff) { }

	// RVA: 0xC18C10 Offset: 0xC17210 VA: 0x180C18C10
	public void Destroy() { }

	// RVA: 0xC18E50 Offset: 0xC17450 VA: 0x180C18E50
	public void UpdateBorderMesh(Matrix4x4 centerLocalToWorld, Matrix4x4 borderLocalToWorld, bool collapseCenter) { }

	// RVA: 0xC175D0 Offset: 0xC15BD0 VA: 0x180C175D0
	private Mesh CreateSortedBorderPatch(int resolution, int ringCount, float sizeInWorld) { }

	// RVA: 0xC17EC0 Offset: 0xC164C0 VA: 0x180C17EC0
	private Mesh CreateSortedCenterPatch(int resolution, float sizeInWorld, bool borderOnly) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

