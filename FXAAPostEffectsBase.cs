public class FXAAPostEffectsBase : MonoBehaviour // TypeDefIndex: 11489
{	// Fields
	protected bool supportHDRTextures; // 0x18
	protected bool isSupported; // 0x19

	// Methods

	// RVA: 0x8D5090 Offset: 0x8D3690 VA: 0x1808D5090
	public Material CheckShaderAndCreateMaterial(Shader s, Material m2Create) { }

	// RVA: 0x8D5980 Offset: 0x8D3F80 VA: 0x1808D5980
	private Material CreateMaterial(Shader s, Material m2Create) { }

	// RVA: 0x8D5F30 Offset: 0x8D4530 VA: 0x1808D5F30
	private void OnEnable() { }

	// RVA: 0x8D58B0 Offset: 0x8D3EB0 VA: 0x1808D58B0
	private bool CheckSupport() { }

	// RVA: 0x8D5000 Offset: 0x8D3600 VA: 0x1808D5000
	private bool CheckResources() { }

	// RVA: 0x8D5FC0 Offset: 0x8D45C0 VA: 0x1808D5FC0
	private void Start() { }

	// RVA: 0x8D57E0 Offset: 0x8D3DE0 VA: 0x1808D57E0
	public bool CheckSupport(bool needDepth) { }

	// RVA: 0x8D5920 Offset: 0x8D3F20 VA: 0x1808D5920
	private bool CheckSupport(bool needDepth, bool needHdr) { }

	// RVA: 0x8D5F40 Offset: 0x8D4540 VA: 0x1808D5F40
	private void ReportAutoDisable() { }

	// RVA: 0x8D5500 Offset: 0x8D3B00 VA: 0x1808D5500
	private bool CheckShader(Shader s) { }

	// RVA: 0x8D5F10 Offset: 0x8D4510 VA: 0x1808D5F10
	private void NotSupported() { }

	// RVA: 0x8D5B70 Offset: 0x8D4170 VA: 0x1808D5B70
	private void DrawBorder(RenderTexture dest, Material material) { }

	// RVA: 0x8D6040 Offset: 0x8D4640 VA: 0x1808D6040
	public void .ctor() { }

}

