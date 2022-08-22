public class SpecialPurposeCamera // TypeDefIndex: 10697
{	// Fields
	public bool dirty; // 0x10
	public string name; // 0x18
	public Camera camera; // 0x20
	public RenderTexture texture; // 0x28
	public CommandBuffer commands; // 0x30
	internal Vector3 position; // 0x38
	internal Quaternion rotation; // 0x44
	internal float orthographicSize; // 0x54
	internal float nearClipPlane; // 0x58
	internal float farClipPlane; // 0x5C
	internal bool created; // 0x60
	private ListHashSet<SpecialPurposeCamera.RenderEntry> dynamicEntries; // 0x68
	private InstancingContainer dynamicBuffer; // 0x70
	private ListHashSet<SpecialPurposeCamera.RenderEntry> staticEntries; // 0x78
	private InstancingContainer staticBuffer; // 0x80
	private CameraEvent cameraEvent; // 0x88
	private MaterialPropertyBlock block; // 0x90

	// Methods

	// RVA: 0xA7F550 Offset: 0xA7DB50 VA: 0x180A7F550
	public void .ctor(string name) { }

	// RVA: 0xA7E7C0 Offset: 0xA7CDC0 VA: 0x180A7E7C0
	public void Create(int width, int height, int depth, RenderTextureFormat format) { }

	// RVA: 0xA7E920 Offset: 0xA7CF20 VA: 0x180A7E920
	public void Destroy() { }

	// RVA: 0xA7E670 Offset: 0xA7CC70 VA: 0x180A7E670
	public void Add(Transform transform, Mesh mesh, Material material, bool isDynamic, bool isBillboard) { }

	// RVA: 0xA7F020 Offset: 0xA7D620 VA: 0x180A7F020
	public void Remove(Transform transform, Mesh mesh, Material material, bool isDynamic, bool isBillboard) { }

	// RVA: 0xA7F170 Offset: 0xA7D770 VA: 0x180A7F170
	private Matrix4x4 ViewMatrix() { }

	// RVA: 0xA7EA50 Offset: 0xA7D050 VA: 0x180A7EA50
	private Matrix4x4 ProjMatrix() { }

	// RVA: 0xA7EB40 Offset: 0xA7D140 VA: 0x180A7EB40
	public void Refresh() { }

}

private struct SpecialPurposeCamera.RenderEntry : IEquatable<SpecialPurposeCamera.RenderEntry> // TypeDefIndex: 10698
{	// Fields
	public Transform transform; // 0x0
	public Mesh mesh; // 0x8
	public Material material; // 0x10
	public bool billboard; // 0x18

	// Properties
	public Matrix4x4 matrix { get; }

	// Methods

	// RVA: 0xFC360 Offset: 0xFB760 VA: 0x1800FC360
	public void .ctor(Transform transform, Mesh mesh, Material material, bool billboard) { }

	// RVA: 0xFC3C0 Offset: 0xFB7C0 VA: 0x1800FC3C0
	public Matrix4x4 get_matrix() { }

	// RVA: 0xF2C90 Offset: 0xF2090 VA: 0x1800F2C90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFC2C0 Offset: 0xFB6C0 VA: 0x1800FC2C0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xFC290 Offset: 0xFB690 VA: 0x1800FC290 Slot: 4
	public bool Equals(SpecialPurposeCamera.RenderEntry other) { }

	// RVA: 0xA75070 Offset: 0xA73670 VA: 0x180A75070
	public static bool op_Equality(SpecialPurposeCamera.RenderEntry a, SpecialPurposeCamera.RenderEntry b) { }

	// RVA: 0xA750A0 Offset: 0xA736A0 VA: 0x180A750A0
	public static bool op_Inequality(SpecialPurposeCamera.RenderEntry a, SpecialPurposeCamera.RenderEntry b) { }

}

