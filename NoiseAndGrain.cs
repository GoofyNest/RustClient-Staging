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

	// RVA: 0x21E1950 Offset: 0x21DFF50 VA: 0x1821E1950 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21E1E50 Offset: 0x21E0450 VA: 0x1821E1E50 Slot: 5
	public bool IsActive() { }

	// RVA: 0x21E1EE0 Offset: 0x21E04E0 VA: 0x1821E1EE0 Slot: 6
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21E1A40 Offset: 0x21E0040 VA: 0x1821E1A40
	private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr) { }

	// RVA: 0x21E29C0 Offset: 0x21E0FC0 VA: 0x1821E29C0
	public void .ctor() { }

	// RVA: 0x21E2980 Offset: 0x21E0F80 VA: 0x1821E2980
	private static void .cctor() { }

}

