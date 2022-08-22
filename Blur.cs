public class Blur : MonoBehaviour, IImageEffect // TypeDefIndex: 8165
{	// Fields
	public int iterations; // 0x18
	public float blurSpread; // 0x1C
	public Shader blurShader; // 0x20
	private static Material m_Material; // 0x0

	// Properties
	protected Material material { get; }

	// Methods

	// RVA: 0x12C7F00 Offset: 0x12C6500 VA: 0x1812C7F00
	protected Material get_material() { }

	// RVA: 0x12C7BD0 Offset: 0x12C61D0 VA: 0x1812C7BD0
	protected void OnDisable() { }

	// RVA: 0x12C7E20 Offset: 0x12C6420 VA: 0x1812C7E20
	protected void Start() { }

	// RVA: 0x12C79B0 Offset: 0x12C5FB0 VA: 0x1812C79B0
	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration) { }

	// RVA: 0x12C77A0 Offset: 0x12C5DA0 VA: 0x1812C77A0
	private void DownSample4x(RenderTexture source, RenderTexture dest) { }

	// RVA: 0x8D6200 Offset: 0x8D4800 VA: 0x1808D6200 Slot: 4
	public bool IsActive() { }

	// RVA: 0x12C7CC0 Offset: 0x12C62C0 VA: 0x1812C7CC0 Slot: 5
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12C7EE0 Offset: 0x12C64E0 VA: 0x1812C7EE0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

