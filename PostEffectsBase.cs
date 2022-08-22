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

	// RVA: 0x21E4AB0 Offset: 0x21E30B0 VA: 0x1821E4AB0
	public Camera get_Camera() { }

	// RVA: 0x21E3E60 Offset: 0x21E2460 VA: 0x1821E3E60
	protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create) { }

	// RVA: 0x21E47E0 Offset: 0x21E2DE0 VA: 0x1821E47E0
	protected Material CreateMaterial(Shader s, Material m2Create) { }

	// RVA: 0x21E4A00 Offset: 0x21E3000 VA: 0x1821E4A00
	private void OnEnable() { }

	// RVA: 0x21E4760 Offset: 0x21E2D60 VA: 0x1821E4760
	protected bool CheckSupport() { }

	// RVA: 0x21E3DD0 Offset: 0x21E23D0 VA: 0x1821E3DD0 Slot: 4
	public virtual bool CheckResources() { }

	// RVA: 0x4D3F40 Offset: 0x4D2540 VA: 0x1804D3F40
	protected void Start() { }

	// RVA: 0x21E4610 Offset: 0x21E2C10 VA: 0x1821E4610
	protected bool CheckSupport(bool needDepth) { }

	// RVA: 0x21E45B0 Offset: 0x21E2BB0 VA: 0x1821E45B0
	protected bool CheckSupport(bool needDepth, bool needHdr) { }

	// RVA: 0x21E49D0 Offset: 0x21E2FD0 VA: 0x1821E49D0
	public bool Dx11Support() { }

	// RVA: 0x21E4A10 Offset: 0x21E3010 VA: 0x1821E4A10
	protected void ReportAutoDisable() { }

	// RVA: 0x21E42D0 Offset: 0x21E28D0 VA: 0x1821E42D0
	private bool CheckShader(Shader s) { }

	// RVA: 0x21E49E0 Offset: 0x21E2FE0 VA: 0x1821E49E0
	protected void NotSupported() { }

	// RVA: 0x8D6190 Offset: 0x8D4790 VA: 0x1808D6190
	protected void DrawBorder(RenderTexture dest, Material material) { }

	// RVA: 0x21E4A90 Offset: 0x21E3090 VA: 0x1821E4A90
	public void .ctor() { }

}

