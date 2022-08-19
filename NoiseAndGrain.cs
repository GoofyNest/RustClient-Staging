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

	// RVA: 0x21E1850 Offset: 0x21DFE50 VA: 0x1821E1850 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21E1D50 Offset: 0x21E0350 VA: 0x1821E1D50 Slot: 5
	public bool IsActive() { }

	// RVA: 0x21E1DE0 Offset: 0x21E03E0 VA: 0x1821E1DE0 Slot: 6
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21E1940 Offset: 0x21DFF40 VA: 0x1821E1940
	private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr) { }

	// RVA: 0x21E28C0 Offset: 0x21E0EC0 VA: 0x1821E28C0
	public void .ctor() { }

	// RVA: 0x21E2880 Offset: 0x21E0E80 VA: 0x1821E2880
	private static void .cctor() { }

}

