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

	// RVA: 0xA7F080 Offset: 0xA7D680 VA: 0x180A7F080
	public void .ctor(string name) { }

	// RVA: 0xA7E2F0 Offset: 0xA7C8F0 VA: 0x180A7E2F0
	public void Create(int width, int height, int depth, RenderTextureFormat format) { }

	// RVA: 0xA7E450 Offset: 0xA7CA50 VA: 0x180A7E450
	public void Destroy() { }

	// RVA: 0xA7E1A0 Offset: 0xA7C7A0 VA: 0x180A7E1A0
	public void Add(Transform transform, Mesh mesh, Material material, bool isDynamic, bool isBillboard) { }

	// RVA: 0xA7EB50 Offset: 0xA7D150 VA: 0x180A7EB50
	public void Remove(Transform transform, Mesh mesh, Material material, bool isDynamic, bool isBillboard) { }

	// RVA: 0xA7ECA0 Offset: 0xA7D2A0 VA: 0x180A7ECA0
	private Matrix4x4 ViewMatrix() { }

	// RVA: 0xA7E580 Offset: 0xA7CB80 VA: 0x180A7E580
	private Matrix4x4 ProjMatrix() { }

	// RVA: 0xA7E670 Offset: 0xA7CC70 VA: 0x180A7E670
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

	// RVA: 0xA74BA0 Offset: 0xA731A0 VA: 0x180A74BA0
	public static bool op_Equality(SpecialPurposeCamera.RenderEntry a, SpecialPurposeCamera.RenderEntry b) { }

	// RVA: 0xA74BD0 Offset: 0xA731D0 VA: 0x180A74BD0
	public static bool op_Inequality(SpecialPurposeCamera.RenderEntry a, SpecialPurposeCamera.RenderEntry b) { }

}

