public class FXAAPostEffectsBase : MonoBehaviour // TypeDefIndex: 11489
{	// Fields
	protected bool supportHDRTextures; // 0x18
	protected bool isSupported; // 0x19

	// Methods

	// RVA: 0x8D56B0 Offset: 0x8D3CB0 VA: 0x1808D56B0
	public Material CheckShaderAndCreateMaterial(Shader s, Material m2Create) { }

	// RVA: 0x8D5FA0 Offset: 0x8D45A0 VA: 0x1808D5FA0
	private Material CreateMaterial(Shader s, Material m2Create) { }

	// RVA: 0x8D6550 Offset: 0x8D4B50 VA: 0x1808D6550
	private void OnEnable() { }

	// RVA: 0x8D5ED0 Offset: 0x8D44D0 VA: 0x1808D5ED0
	private bool CheckSupport() { }

	// RVA: 0x8D5620 Offset: 0x8D3C20 VA: 0x1808D5620
	private bool CheckResources() { }

	// RVA: 0x8D65E0 Offset: 0x8D4BE0 VA: 0x1808D65E0
	private void Start() { }

	// RVA: 0x8D5E00 Offset: 0x8D4400 VA: 0x1808D5E00
	public bool CheckSupport(bool needDepth) { }

	// RVA: 0x8D5F40 Offset: 0x8D4540 VA: 0x1808D5F40
	private bool CheckSupport(bool needDepth, bool needHdr) { }

	// RVA: 0x8D6560 Offset: 0x8D4B60 VA: 0x1808D6560
	private void ReportAutoDisable() { }

	// RVA: 0x8D5B20 Offset: 0x8D4120 VA: 0x1808D5B20
	private bool CheckShader(Shader s) { }

	// RVA: 0x8D6530 Offset: 0x8D4B30 VA: 0x1808D6530
	private void NotSupported() { }

	// RVA: 0x8D6190 Offset: 0x8D4790 VA: 0x1808D6190
	private void DrawBorder(RenderTexture dest, Material material) { }

	// RVA: 0x8D6660 Offset: 0x8D4C60 VA: 0x1808D6660
	public void .ctor() { }

}

