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

	// RVA: 0x21E4290 Offset: 0x21E2890 VA: 0x1821E4290
	public Camera get_Camera() { }

	// RVA: 0x21E3640 Offset: 0x21E1C40 VA: 0x1821E3640
	protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create) { }

	// RVA: 0x21E3FC0 Offset: 0x21E25C0 VA: 0x1821E3FC0
	protected Material CreateMaterial(Shader s, Material m2Create) { }

	// RVA: 0x21E41E0 Offset: 0x21E27E0 VA: 0x1821E41E0
	private void OnEnable() { }

	// RVA: 0x21E3F40 Offset: 0x21E2540 VA: 0x1821E3F40
	protected bool CheckSupport() { }

	// RVA: 0x21E35B0 Offset: 0x21E1BB0 VA: 0x1821E35B0 Slot: 4
	public virtual bool CheckResources() { }

	// RVA: 0x4D3FB0 Offset: 0x4D25B0 VA: 0x1804D3FB0
	protected void Start() { }

	// RVA: 0x21E3DF0 Offset: 0x21E23F0 VA: 0x1821E3DF0
	protected bool CheckSupport(bool needDepth) { }

	// RVA: 0x21E3D90 Offset: 0x21E2390 VA: 0x1821E3D90
	protected bool CheckSupport(bool needDepth, bool needHdr) { }

	// RVA: 0x21E41B0 Offset: 0x21E27B0 VA: 0x1821E41B0
	public bool Dx11Support() { }

	// RVA: 0x21E41F0 Offset: 0x21E27F0 VA: 0x1821E41F0
	protected void ReportAutoDisable() { }

	// RVA: 0x21E3AB0 Offset: 0x21E20B0 VA: 0x1821E3AB0
	private bool CheckShader(Shader s) { }

	// RVA: 0x21E41C0 Offset: 0x21E27C0 VA: 0x1821E41C0
	protected void NotSupported() { }

	// RVA: 0x8D5C80 Offset: 0x8D4280 VA: 0x1808D5C80
	protected void DrawBorder(RenderTexture dest, Material material) { }

	// RVA: 0x21E4270 Offset: 0x21E2870 VA: 0x1821E4270
	public void .ctor() { }

}

