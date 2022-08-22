public class FXAAPostEffectsBase : MonoBehaviour // TypeDefIndex: 11489
{	// Fields
	protected bool supportHDRTextures; // 0x18
	protected bool isSupported; // 0x19

	// Methods

	// RVA: 0x8D51A0 Offset: 0x8D37A0 VA: 0x1808D51A0
	public Material CheckShaderAndCreateMaterial(Shader s, Material m2Create) { }

	// RVA: 0x8D5A90 Offset: 0x8D4090 VA: 0x1808D5A90
	private Material CreateMaterial(Shader s, Material m2Create) { }

	// RVA: 0x8D6040 Offset: 0x8D4640 VA: 0x1808D6040
	private void OnEnable() { }

	// RVA: 0x8D59C0 Offset: 0x8D3FC0 VA: 0x1808D59C0
	private bool CheckSupport() { }

	// RVA: 0x8D5110 Offset: 0x8D3710 VA: 0x1808D5110
	private bool CheckResources() { }

	// RVA: 0x8D60D0 Offset: 0x8D46D0 VA: 0x1808D60D0
	private void Start() { }

	// RVA: 0x8D58F0 Offset: 0x8D3EF0 VA: 0x1808D58F0
	public bool CheckSupport(bool needDepth) { }

	// RVA: 0x8D5A30 Offset: 0x8D4030 VA: 0x1808D5A30
	private bool CheckSupport(bool needDepth, bool needHdr) { }

	// RVA: 0x8D6050 Offset: 0x8D4650 VA: 0x1808D6050
	private void ReportAutoDisable() { }

	// RVA: 0x8D5610 Offset: 0x8D3C10 VA: 0x1808D5610
	private bool CheckShader(Shader s) { }

	// RVA: 0x8D6020 Offset: 0x8D4620 VA: 0x1808D6020
	private void NotSupported() { }

	// RVA: 0x8D5C80 Offset: 0x8D4280 VA: 0x1808D5C80
	private void DrawBorder(RenderTexture dest, Material material) { }

	// RVA: 0x8D6150 Offset: 0x8D4750 VA: 0x1808D6150
	public void .ctor() { }

}

