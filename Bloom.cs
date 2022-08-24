public class Bloom : PostEffectsBase // TypeDefIndex: 8151
{	public Bloom.TweakMode tweakMode; // 0x28
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


	public override bool CheckResources() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void AddTo(float intensity_, RenderTexture from, RenderTexture to) { }

	private void BlendFlares(RenderTexture from, RenderTexture to) { }

	private void BrightFilter(float thresh, RenderTexture from, RenderTexture to) { }

	private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to) { }

	private void Vignette(float amount, RenderTexture from, RenderTexture to) { }

	public void .ctor() { }

}

public enum Bloom.LensFlareStyle // TypeDefIndex: 8152
{	public int value__; // 0x0
	public const Bloom.LensFlareStyle Ghosting = 0;
	public const Bloom.LensFlareStyle Anamorphic = 1;
	public const Bloom.LensFlareStyle Combined = 2;

}

public enum Bloom.TweakMode // TypeDefIndex: 8153
{	public int value__; // 0x0
	public const Bloom.TweakMode Basic = 0;
	public const Bloom.TweakMode Complex = 1;

}

public enum Bloom.HDRBloomMode // TypeDefIndex: 8154
{	public int value__; // 0x0
	public const Bloom.HDRBloomMode Auto = 0;
	public const Bloom.HDRBloomMode On = 1;
	public const Bloom.HDRBloomMode Off = 2;

}

public enum Bloom.BloomScreenBlendMode // TypeDefIndex: 8155
{	public int value__; // 0x0
	public const Bloom.BloomScreenBlendMode Screen = 0;
	public const Bloom.BloomScreenBlendMode Add = 1;

}

public enum Bloom.BloomQuality // TypeDefIndex: 8156
{	public int value__; // 0x0
	public const Bloom.BloomQuality Cheap = 0;
	public const Bloom.BloomQuality High = 1;

}

public sealed class Bloom : PostProcessEffectSettings // TypeDefIndex: 11771
{	[MinAttribute] // RVA: 0xEAAB0 Offset: 0xE9EB0 VA: 0x1800EAAB0
	[TooltipAttribute] // RVA: 0xEAAB0 Offset: 0xE9EB0 VA: 0x1800EAAB0
	public FloatParameter intensity; // 0x30
	[MinAttribute] // RVA: 0xEAC10 Offset: 0xEA010 VA: 0x1800EAC10
	[TooltipAttribute] // RVA: 0xEAC10 Offset: 0xEA010 VA: 0x1800EAC10
	public FloatParameter threshold; // 0x38
	[RangeAttribute] // RVA: 0xEAD30 Offset: 0xEA130 VA: 0x1800EAD30
	[TooltipAttribute] // RVA: 0xEAD30 Offset: 0xEA130 VA: 0x1800EAD30
	public FloatParameter softKnee; // 0x40
	[TooltipAttribute] // RVA: 0xEC200 Offset: 0xEB600 VA: 0x1800EC200
	public FloatParameter clamp; // 0x48
	[RangeAttribute] // RVA: 0xEC310 Offset: 0xEB710 VA: 0x1800EC310
	[TooltipAttribute] // RVA: 0xEC310 Offset: 0xEB710 VA: 0x1800EC310
	public FloatParameter diffusion; // 0x50
	[RangeAttribute] // RVA: 0xEC3B0 Offset: 0xEB7B0 VA: 0x1800EC3B0
	[TooltipAttribute] // RVA: 0xEC3B0 Offset: 0xEB7B0 VA: 0x1800EC3B0
	public FloatParameter anamorphicRatio; // 0x58
	[ColorUsageAttribute] // RVA: 0xEC400 Offset: 0xEB800 VA: 0x1800EC400
	[TooltipAttribute] // RVA: 0xEC400 Offset: 0xEB800 VA: 0x1800EC400
	public ColorParameter color; // 0x60
	[FormerlySerializedAsAttribute] // RVA: 0xEC450 Offset: 0xEB850 VA: 0x1800EC450
	[TooltipAttribute] // RVA: 0xEC450 Offset: 0xEB850 VA: 0x1800EC450
	public BoolParameter fastMode; // 0x68
	[TooltipAttribute] // RVA: 0xEC530 Offset: 0xEB930 VA: 0x1800EC530
	[DisplayNameAttribute] // RVA: 0xEC530 Offset: 0xEB930 VA: 0x1800EC530
	public TextureParameter dirtTexture; // 0x70
	[MinAttribute] // RVA: 0xEC640 Offset: 0xEBA40 VA: 0x1800EC640
	[TooltipAttribute] // RVA: 0xEC640 Offset: 0xEBA40 VA: 0x1800EC640
	[DisplayNameAttribute] // RVA: 0xEC640 Offset: 0xEBA40 VA: 0x1800EC640
	public FloatParameter dirtIntensity; // 0x78


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

