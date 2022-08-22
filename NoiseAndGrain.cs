public class NoiseAndGrain : PostEffectsBase, IImageEffect // TypeDefIndex: 8194
{	// Fields
	public float intensityMultiplier; // 0x28
	public float generalIntensity; // 0x2C
	public float blackIntensity; // 0x30
	public float whiteIntensity; // 0x34
	public float midGrey; // 0x38
	public bool dx11Grain; // 0x3C
	public float softness; // 0x40
	public bool monochrome; // 0x44
	public Vector3 intensities; // 0x48
	public Vector3 tiling; // 0x54
	public float monochromeTiling; // 0x60
	public FilterMode filterMode; // 0x64
	public Texture2D noiseTexture; // 0x68
	public Shader noiseShader; // 0x70
	private Material noiseMaterial; // 0x78
	public Shader dx11NoiseShader; // 0x80
	private Material dx11NoiseMaterial; // 0x88
	private static float TILE_AMOUNT; // 0x0

	// Methods

	// RVA: 0x21E2170 Offset: 0x21E0770 VA: 0x1821E2170 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21E2670 Offset: 0x21E0C70 VA: 0x1821E2670 Slot: 5
	public bool IsActive() { }

	// RVA: 0x21E2700 Offset: 0x21E0D00 VA: 0x1821E2700 Slot: 6
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21E2260 Offset: 0x21E0860 VA: 0x1821E2260
	private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr) { }

	// RVA: 0x21E31E0 Offset: 0x21E17E0 VA: 0x1821E31E0
	public void .ctor() { }

	// RVA: 0x21E31A0 Offset: 0x21E17A0 VA: 0x1821E31A0
	private static void .cctor() { }

}

