public class ColorCorrectionLookup : PostEffectsBase // TypeDefIndex: 8172
{	// Fields
	public Shader shader; // 0x28
	private Material material; // 0x30
	public Texture3D converted3DLut; // 0x38
	public string basedOnTempTex; // 0x40

	// Methods

	// RVA: 0x12D1F60 Offset: 0x12D0560 VA: 0x1812D1F60 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x12D2480 Offset: 0x12D0A80 VA: 0x1812D2480
	private void OnDisable() { }

	// RVA: 0x12D23D0 Offset: 0x12D09D0 VA: 0x1812D23D0
	private void OnDestroy() { }

	// RVA: 0x12D2730 Offset: 0x12D0D30 VA: 0x1812D2730
	public void SetIdentityLut() { }

	// RVA: 0x12D2990 Offset: 0x12D0F90 VA: 0x1812D2990
	public bool ValidDimensions(Texture2D tex2d) { }

	// RVA: 0x12D1FD0 Offset: 0x12D05D0 VA: 0x1812D1FD0
	public void Convert(Texture2D temp2DTex, string path) { }

	// RVA: 0x12D2530 Offset: 0x12D0B30 VA: 0x1812D2530
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12D2A70 Offset: 0x12D1070 VA: 0x1812D2A70
	public void .ctor() { }

}

