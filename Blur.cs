public class Blur : MonoBehaviour, IImageEffect // TypeDefIndex: 8165
{	// Fields
	public int iterations; // 0x18
	public float blurSpread; // 0x1C
	public Shader blurShader; // 0x20
	private static Material m_Material; // 0x0

	// Properties
	protected Material material { get; }

	// Methods

	// RVA: 0x12C7C40 Offset: 0x12C6240 VA: 0x1812C7C40
	protected Material get_material() { }

	// RVA: 0x12C7910 Offset: 0x12C5F10 VA: 0x1812C7910
	protected void OnDisable() { }

	// RVA: 0x12C7B60 Offset: 0x12C6160 VA: 0x1812C7B60
	protected void Start() { }

	// RVA: 0x12C76F0 Offset: 0x12C5CF0 VA: 0x1812C76F0
	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration) { }

	// RVA: 0x12C74E0 Offset: 0x12C5AE0 VA: 0x1812C74E0
	private void DownSample4x(RenderTexture source, RenderTexture dest) { }

	// RVA: 0x8D60F0 Offset: 0x8D46F0 VA: 0x1808D60F0 Slot: 4
	public bool IsActive() { }

	// RVA: 0x12C7A00 Offset: 0x12C6000 VA: 0x1812C7A00 Slot: 5
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12C7C20 Offset: 0x12C6220 VA: 0x1812C7C20
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

