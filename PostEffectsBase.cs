public class PostEffectsBase : MonoBehaviour // TypeDefIndex: 8196
{	// Fields
	protected bool supportImageEffects; // 0x18
	protected bool supportHDRTextures; // 0x19
	protected bool supportDepthTextures; // 0x1A
	protected bool supportDX11; // 0x1B
	private bool checkedSystemInfo; // 0x1C
	protected bool isSupported; // 0x1D
	private Camera camera; // 0x20

	// Properties
	public Camera Camera { get; }

	// Methods

	// RVA: 0x21E3FD0 Offset: 0x21E25D0 VA: 0x1821E3FD0
	public Camera get_Camera() { }

	// RVA: 0x21E3380 Offset: 0x21E1980 VA: 0x1821E3380
	protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create) { }

	// RVA: 0x21E3D00 Offset: 0x21E2300 VA: 0x1821E3D00
	protected Material CreateMaterial(Shader s, Material m2Create) { }

	// RVA: 0x21E3F20 Offset: 0x21E2520 VA: 0x1821E3F20
	private void OnEnable() { }

	// RVA: 0x21E3C80 Offset: 0x21E2280 VA: 0x1821E3C80
	protected bool CheckSupport() { }

	// RVA: 0x21E32F0 Offset: 0x21E18F0 VA: 0x1821E32F0 Slot: 4
	public virtual bool CheckResources() { }

	// RVA: 0x4D3FB0 Offset: 0x4D25B0 VA: 0x1804D3FB0
	protected void Start() { }

	// RVA: 0x21E3B30 Offset: 0x21E2130 VA: 0x1821E3B30
	protected bool CheckSupport(bool needDepth) { }

	// RVA: 0x21E3AD0 Offset: 0x21E20D0 VA: 0x1821E3AD0
	protected bool CheckSupport(bool needDepth, bool needHdr) { }

	// RVA: 0x21E3EF0 Offset: 0x21E24F0 VA: 0x1821E3EF0
	public bool Dx11Support() { }

	// RVA: 0x21E3F30 Offset: 0x21E2530 VA: 0x1821E3F30
	protected void ReportAutoDisable() { }

	// RVA: 0x21E37F0 Offset: 0x21E1DF0 VA: 0x1821E37F0
	private bool CheckShader(Shader s) { }

	// RVA: 0x21E3F00 Offset: 0x21E2500 VA: 0x1821E3F00
	protected void NotSupported() { }

	// RVA: 0x8D5B70 Offset: 0x8D4170 VA: 0x1808D5B70
	protected void DrawBorder(RenderTexture dest, Material material) { }

	// RVA: 0x21E3FB0 Offset: 0x21E25B0 VA: 0x1821E3FB0
	public void .ctor() { }

}

