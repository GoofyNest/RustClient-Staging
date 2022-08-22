public class ColorCorrectionLookup : PostEffectsBase // TypeDefIndex: 8172
{	// Fields
	public Shader shader; // 0x28
	private Material material; // 0x30
	public Texture3D converted3DLut; // 0x38
	public string basedOnTempTex; // 0x40

	// Methods

	// RVA: 0x12CBAB0 Offset: 0x12CA0B0 VA: 0x1812CBAB0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x12CBFD0 Offset: 0x12CA5D0 VA: 0x1812CBFD0
	private void OnDisable() { }

	// RVA: 0x12CBF20 Offset: 0x12CA520 VA: 0x1812CBF20
	private void OnDestroy() { }

	// RVA: 0x12CC280 Offset: 0x12CA880 VA: 0x1812CC280
	public void SetIdentityLut() { }

	// RVA: 0x12CC4E0 Offset: 0x12CAAE0 VA: 0x1812CC4E0
	public bool ValidDimensions(Texture2D tex2d) { }

	// RVA: 0x12CBB20 Offset: 0x12CA120 VA: 0x1812CBB20
	public void Convert(Texture2D temp2DTex, string path) { }

	// RVA: 0x12CC080 Offset: 0x12CA680 VA: 0x1812CC080
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12CC5C0 Offset: 0x12CABC0 VA: 0x1812CC5C0
	public void .ctor() { }

}

