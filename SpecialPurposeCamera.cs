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

	// RVA: 0xA7EDC0 Offset: 0xA7D3C0 VA: 0x180A7EDC0
	public void .ctor(string name) { }

	// RVA: 0xA7E030 Offset: 0xA7C630 VA: 0x180A7E030
	public void Create(int width, int height, int depth, RenderTextureFormat format) { }

	// RVA: 0xA7E190 Offset: 0xA7C790 VA: 0x180A7E190
	public void Destroy() { }

	// RVA: 0xA7DEE0 Offset: 0xA7C4E0 VA: 0x180A7DEE0
	public void Add(Transform transform, Mesh mesh, Material material, bool isDynamic, bool isBillboard) { }

	// RVA: 0xA7E890 Offset: 0xA7CE90 VA: 0x180A7E890
	public void Remove(Transform transform, Mesh mesh, Material material, bool isDynamic, bool isBillboard) { }

	// RVA: 0xA7E9E0 Offset: 0xA7CFE0 VA: 0x180A7E9E0
	private Matrix4x4 ViewMatrix() { }

	// RVA: 0xA7E2C0 Offset: 0xA7C8C0 VA: 0x180A7E2C0
	private Matrix4x4 ProjMatrix() { }

	// RVA: 0xA7E3B0 Offset: 0xA7C9B0 VA: 0x180A7E3B0
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

	// RVA: 0xFC3E0 Offset: 0xFB7E0 VA: 0x1800FC3E0
	public void .ctor(Transform transform, Mesh mesh, Material material, bool billboard) { }

	// RVA: 0xFC440 Offset: 0xFB840 VA: 0x1800FC440
	public Matrix4x4 get_matrix() { }

	// RVA: 0xF2D10 Offset: 0xF2110 VA: 0x1800F2D10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFC340 Offset: 0xFB740 VA: 0x1800FC340 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xFC310 Offset: 0xFB710 VA: 0x1800FC310 Slot: 4
	public bool Equals(SpecialPurposeCamera.RenderEntry other) { }

	// RVA: 0xA748E0 Offset: 0xA72EE0 VA: 0x180A748E0
	public static bool op_Equality(SpecialPurposeCamera.RenderEntry a, SpecialPurposeCamera.RenderEntry b) { }

	// RVA: 0xA74910 Offset: 0xA72F10 VA: 0x180A74910
	public static bool op_Inequality(SpecialPurposeCamera.RenderEntry a, SpecialPurposeCamera.RenderEntry b) { }

}

