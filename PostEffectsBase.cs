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

	// RVA: 0x21E4190 Offset: 0x21E2790 VA: 0x1821E4190
	public Camera get_Camera() { }

	// RVA: 0x21E3540 Offset: 0x21E1B40 VA: 0x1821E3540
	protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create) { }

	// RVA: 0x21E3EC0 Offset: 0x21E24C0 VA: 0x1821E3EC0
	protected Material CreateMaterial(Shader s, Material m2Create) { }

	// RVA: 0x21E40E0 Offset: 0x21E26E0 VA: 0x1821E40E0
	private void OnEnable() { }

	// RVA: 0x21E3E40 Offset: 0x21E2440 VA: 0x1821E3E40
	protected bool CheckSupport() { }

	// RVA: 0x21E34B0 Offset: 0x21E1AB0 VA: 0x1821E34B0 Slot: 4
	public virtual bool CheckResources() { }

	// RVA: 0x4D3FB0 Offset: 0x4D25B0 VA: 0x1804D3FB0
	protected void Start() { }

	// RVA: 0x21E3CF0 Offset: 0x21E22F0 VA: 0x1821E3CF0
	protected bool CheckSupport(bool needDepth) { }

	// RVA: 0x21E3C90 Offset: 0x21E2290 VA: 0x1821E3C90
	protected bool CheckSupport(bool needDepth, bool needHdr) { }

	// RVA: 0x21E40B0 Offset: 0x21E26B0 VA: 0x1821E40B0
	public bool Dx11Support() { }

	// RVA: 0x21E40F0 Offset: 0x21E26F0 VA: 0x1821E40F0
	protected void ReportAutoDisable() { }

	// RVA: 0x21E39B0 Offset: 0x21E1FB0 VA: 0x1821E39B0
	private bool CheckShader(Shader s) { }

	// RVA: 0x21E40C0 Offset: 0x21E26C0 VA: 0x1821E40C0
	protected void NotSupported() { }

	// RVA: 0x8D5B70 Offset: 0x8D4170 VA: 0x1808D5B70
	protected void DrawBorder(RenderTexture dest, Material material) { }

	// RVA: 0x21E4170 Offset: 0x21E2770 VA: 0x1821E4170
	public void .ctor() { }

}

