public class ColorCorrectionLookup : PostEffectsBase // TypeDefIndex: 8172
{	// Fields
	public Shader shader; // 0x28
	private Material material; // 0x30
	public Texture3D converted3DLut; // 0x38
	public string basedOnTempTex; // 0x40

	// Methods

	// RVA: 0x12CB7F0 Offset: 0x12C9DF0 VA: 0x1812CB7F0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x12CBD10 Offset: 0x12CA310 VA: 0x1812CBD10
	private void OnDisable() { }

	// RVA: 0x12CBC60 Offset: 0x12CA260 VA: 0x1812CBC60
	private void OnDestroy() { }

	// RVA: 0x12CBFC0 Offset: 0x12CA5C0 VA: 0x1812CBFC0
	public void SetIdentityLut() { }

	// RVA: 0x12CC220 Offset: 0x12CA820 VA: 0x1812CC220
	public bool ValidDimensions(Texture2D tex2d) { }

	// RVA: 0x12CB860 Offset: 0x12C9E60 VA: 0x1812CB860
	public void Convert(Texture2D temp2DTex, string path) { }

	// RVA: 0x12CBDC0 Offset: 0x12CA3C0 VA: 0x1812CBDC0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12CC300 Offset: 0x12CA900 VA: 0x1812CC300
	public void .ctor() { }

}

