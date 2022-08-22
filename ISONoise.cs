public class ISONoise : PostEffectsBase // TypeDefIndex: 8028
{	// Fields
	public float monochromeTiling; // 0x28
	public FilterMode filterMode; // 0x2C
	public Texture2D noiseTexture; // 0x30
	public Shader noiseShader; // 0x38
	private Material noiseMaterial; // 0x40

	// Methods

	// RVA: 0x106D840 Offset: 0x106BE40 VA: 0x18106D840 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x106DBF0 Offset: 0x106C1F0 VA: 0x18106DBF0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106D8A0 Offset: 0x106BEA0 VA: 0x18106D8A0
	private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr) { }

	// RVA: 0x106DEB0 Offset: 0x106C4B0 VA: 0x18106DEB0
	public void .ctor() { }

}

