public class Blur : MonoBehaviour, IImageEffect // TypeDefIndex: 8165
{	// Fields
	public int iterations; // 0x18
	public float blurSpread; // 0x1C
	public Shader blurShader; // 0x20
	private static Material m_Material; // 0x0

	// Properties
	protected Material material { get; }

	// Methods

	// RVA: 0x12CE3B0 Offset: 0x12CC9B0 VA: 0x1812CE3B0
	protected Material get_material() { }

	// RVA: 0x12CE080 Offset: 0x12CC680 VA: 0x1812CE080
	protected void OnDisable() { }

	// RVA: 0x12CE2D0 Offset: 0x12CC8D0 VA: 0x1812CE2D0
	protected void Start() { }

	// RVA: 0x12CDE60 Offset: 0x12CC460 VA: 0x1812CDE60
	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration) { }

	// RVA: 0x12CDC50 Offset: 0x12CC250 VA: 0x1812CDC50
	private void DownSample4x(RenderTexture source, RenderTexture dest) { }

	// RVA: 0x8D6710 Offset: 0x8D4D10 VA: 0x1808D6710 Slot: 4
	public bool IsActive() { }

	// RVA: 0x12CE170 Offset: 0x12CC770 VA: 0x1812CE170 Slot: 5
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12CE390 Offset: 0x12CC990 VA: 0x1812CE390
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

