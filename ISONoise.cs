public class ISONoise : PostEffectsBase // TypeDefIndex: 8028
{	// Fields
	public float monochromeTiling; // 0x28
	public FilterMode filterMode; // 0x2C
	public Texture2D noiseTexture; // 0x30
	public Shader noiseShader; // 0x38
	private Material noiseMaterial; // 0x40

	// Methods

	// RVA: 0x106CDD0 Offset: 0x106B3D0 VA: 0x18106CDD0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x106D180 Offset: 0x106B780 VA: 0x18106D180
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106CE30 Offset: 0x106B430 VA: 0x18106CE30
	private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr) { }

	// RVA: 0x106D440 Offset: 0x106BA40 VA: 0x18106D440
	public void .ctor() { }

}

