public class Bloom : PostEffectsBase // TypeDefIndex: 8151
{	// Fields
	public Bloom.TweakMode tweakMode; // 0x28
	public Bloom.BloomScreenBlendMode screenBlendMode; // 0x2C
	public Bloom.HDRBloomMode hdr; // 0x30
	private bool doHdr; // 0x34
	public float sepBlurSpread; // 0x38
	public Bloom.BloomQuality quality; // 0x3C
	public float bloomIntensity; // 0x40
	public float bloomThreshold; // 0x44
	public Color bloomThresholdColor; // 0x48
	public int bloomBlurIterations; // 0x58
	public int hollywoodFlareBlurIterations; // 0x5C
	public float flareRotation; // 0x60
	public Bloom.LensFlareStyle lensflareMode; // 0x64
	public float hollyStretchWidth; // 0x68
	public float lensflareIntensity; // 0x6C
	public float lensflareThreshold; // 0x70
	public float lensFlareSaturation; // 0x74
	public Color flareColorA; // 0x78
	public Color flareColorB; // 0x88
	public Color flareColorC; // 0x98
	public Color flareColorD; // 0xA8
	public Texture2D lensFlareVignetteMask; // 0xB8
	public Shader lensFlareShader; // 0xC0
	private Material lensFlareMaterial; // 0xC8
	public Shader screenBlendShader; // 0xD0
	private Material screenBlend; // 0xD8
	public Shader blurAndFlaresShader; // 0xE0
	private Material blurAndFlaresMaterial; // 0xE8
	public Shader brightPassFilterShader; // 0xF0
	private Material brightPassFilterMaterial; // 0xF8

	// Methods

	// RVA: 0x12C5B30 Offset: 0x12C4130 VA: 0x1812C5B30 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x12C5C30 Offset: 0x12C4230 VA: 0x1812C5C30
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12C5580 Offset: 0x12C3B80 VA: 0x1812C5580
	private void AddTo(float intensity_, RenderTexture from, RenderTexture to) { }

	// RVA: 0x12C5650 Offset: 0x12C3C50 VA: 0x1812C5650
	private void BlendFlares(RenderTexture from, RenderTexture to) { }

	// RVA: 0x12C5A30 Offset: 0x12C4030 VA: 0x1812C5A30
	private void BrightFilter(float thresh, RenderTexture from, RenderTexture to) { }

	// RVA: 0x12C5940 Offset: 0x12C3F40 VA: 0x1812C5940
	private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to) { }

	// RVA: 0x12C6E20 Offset: 0x12C5420 VA: 0x1812C6E20
	private void Vignette(float amount, RenderTexture from, RenderTexture to) { }

	// RVA: 0x12C7030 Offset: 0x12C5630 VA: 0x1812C7030
	public void .ctor() { }

}

public enum Bloom.LensFlareStyle // TypeDefIndex: 8152
{	// Fields
	public int value__; // 0x0
	public const Bloom.LensFlareStyle Ghosting = 0;
	public const Bloom.LensFlareStyle Anamorphic = 1;
	public const Bloom.LensFlareStyle Combined = 2;

}

public enum Bloom.TweakMode // TypeDefIndex: 8153
{	// Fields
	public int value__; // 0x0
	public const Bloom.TweakMode Basic = 0;
	public const Bloom.TweakMode Complex = 1;

}

public enum Bloom.HDRBloomMode // TypeDefIndex: 8154
{	// Fields
	public int value__; // 0x0
	public const Bloom.HDRBloomMode Auto = 0;
	public const Bloom.HDRBloomMode On = 1;
	public const Bloom.HDRBloomMode Off = 2;

}

public enum Bloom.BloomScreenBlendMode // TypeDefIndex: 8155
{	// Fields
	public int value__; // 0x0
	public const Bloom.BloomScreenBlendMode Screen = 0;
	public const Bloom.BloomScreenBlendMode Add = 1;

}

public enum Bloom.BloomQuality // TypeDefIndex: 8156
{	// Fields
	public int value__; // 0x0
	public const Bloom.BloomQuality Cheap = 0;
	public const Bloom.BloomQuality High = 1;

}

public sealed class Bloom : PostProcessEffectSettings // TypeDefIndex: 11767
{	// Fields
	[MinAttribute] // RVA: 0xEC200 Offset: 0xEB600 VA: 0x1800EC200
	[TooltipAttribute] // RVA: 0xEC200 Offset: 0xEB600 VA: 0x1800EC200
	public FloatParameter intensity; // 0x30
	[MinAttribute] // RVA: 0xEC2E0 Offset: 0xEB6E0 VA: 0x1800EC2E0
	[TooltipAttribute] // RVA: 0xEC2E0 Offset: 0xEB6E0 VA: 0x1800EC2E0
	public FloatParameter threshold; // 0x38
	[RangeAttribute] // RVA: 0xEC330 Offset: 0xEB730 VA: 0x1800EC330
	[TooltipAttribute] // RVA: 0xEC330 Offset: 0xEB730 VA: 0x1800EC330
	public FloatParameter softKnee; // 0x40
	[TooltipAttribute] // RVA: 0xEC3B0 Offset: 0xEB7B0 VA: 0x1800EC3B0
	public FloatParameter clamp; // 0x48
	[RangeAttribute] // RVA: 0xEC430 Offset: 0xEB830 VA: 0x1800EC430
	[TooltipAttribute] // RVA: 0xEC430 Offset: 0xEB830 VA: 0x1800EC430
	public FloatParameter diffusion; // 0x50
	[RangeAttribute] // RVA: 0xEC530 Offset: 0xEB930 VA: 0x1800EC530
	[TooltipAttribute] // RVA: 0xEC530 Offset: 0xEB930 VA: 0x1800EC530
	public FloatParameter anamorphicRatio; // 0x58
	[ColorUsageAttribute] // RVA: 0xEC620 Offset: 0xEBA20 VA: 0x1800EC620
	[TooltipAttribute] // RVA: 0xEC620 Offset: 0xEBA20 VA: 0x1800EC620
	public ColorParameter color; // 0x60
	[FormerlySerializedAsAttribute] // RVA: 0xEC780 Offset: 0xEBB80 VA: 0x1800EC780
	[TooltipAttribute] // RVA: 0xEC780 Offset: 0xEBB80 VA: 0x1800EC780
	public BoolParameter fastMode; // 0x68
	[TooltipAttribute] // RVA: 0xEC890 Offset: 0xEBC90 VA: 0x1800EC890
	[DisplayNameAttribute] // RVA: 0xEC890 Offset: 0xEBC90 VA: 0x1800EC890
	public TextureParameter dirtTexture; // 0x70
	[MinAttribute] // RVA: 0xEC8F0 Offset: 0xEBCF0 VA: 0x1800EC8F0
	[TooltipAttribute] // RVA: 0xEC8F0 Offset: 0xEBCF0 VA: 0x1800EC8F0
	[DisplayNameAttribute] // RVA: 0xEC8F0 Offset: 0xEBCF0 VA: 0x1800EC8F0
	public FloatParameter dirtIntensity; // 0x78

	// Methods

	// RVA: 0x9F06D0 Offset: 0x9EECD0 VA: 0x1809F06D0 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x9F0710 Offset: 0x9EED10 VA: 0x1809F0710
	public void .ctor() { }

}

