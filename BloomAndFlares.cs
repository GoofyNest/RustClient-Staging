public class BloomAndFlares : PostEffectsBase // TypeDefIndex: 8161
{	// Fields
	public TweakMode34 tweakMode; // 0x28
	public BloomScreenBlendMode screenBlendMode; // 0x2C
	public HDRBloomMode hdr; // 0x30
	private bool doHdr; // 0x34
	public float sepBlurSpread; // 0x38
	public float useSrcAlphaAsMask; // 0x3C
	public float bloomIntensity; // 0x40
	public float bloomThreshold; // 0x44
	public int bloomBlurIterations; // 0x48
	public bool lensflares; // 0x4C
	public int hollywoodFlareBlurIterations; // 0x50
	public LensflareStyle34 lensflareMode; // 0x54
	public float hollyStretchWidth; // 0x58
	public float lensflareIntensity; // 0x5C
	public float lensflareThreshold; // 0x60
	public Color flareColorA; // 0x64
	public Color flareColorB; // 0x74
	public Color flareColorC; // 0x84
	public Color flareColorD; // 0x94
	public Texture2D lensFlareVignetteMask; // 0xA8
	public Shader lensFlareShader; // 0xB0
	private Material lensFlareMaterial; // 0xB8
	public Shader vignetteShader; // 0xC0
	private Material vignetteMaterial; // 0xC8
	public Shader separableBlurShader; // 0xD0
	private Material separableBlurMaterial; // 0xD8
	public Shader addBrightStuffOneOneShader; // 0xE0
	private Material addBrightStuffBlendOneOneMaterial; // 0xE8
	public Shader screenBlendShader; // 0xF0
	private Material screenBlend; // 0xF8
	public Shader hollywoodFlaresShader; // 0x100
	private Material hollywoodFlaresMaterial; // 0x108
	public Shader brightPassFilterShader; // 0x110
	private Material brightPassFilterMaterial; // 0x118

	// Methods

	// RVA: 0x12C3F30 Offset: 0x12C2530 VA: 0x1812C3F30 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x12C40C0 Offset: 0x12C26C0 VA: 0x1812C40C0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12C3A60 Offset: 0x12C2060 VA: 0x1812C3A60
	private void AddTo(float intensity_, RenderTexture from, RenderTexture to) { }

	// RVA: 0x12C3B10 Offset: 0x12C2110 VA: 0x1812C3B10
	private void BlendFlares(RenderTexture from, RenderTexture to) { }

	// RVA: 0x12C3DE0 Offset: 0x12C23E0 VA: 0x1812C3DE0
	private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to) { }

	// RVA: 0x12C4D90 Offset: 0x12C3390 VA: 0x1812C4D90
	private void Vignette(float amount, RenderTexture from, RenderTexture to) { }

	// RVA: 0x12C4EF0 Offset: 0x12C34F0 VA: 0x1812C4EF0
	public void .ctor() { }

}

