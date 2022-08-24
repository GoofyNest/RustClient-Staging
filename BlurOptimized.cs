public class BlurOptimized : PostEffectsBase, IImageEffect // TypeDefIndex: 8166
{	[RangeAttribute] // RVA: 0x70E10 Offset: 0x70210 VA: 0x180070E10
	public int downsample; // 0x28
	[RangeAttribute] // RVA: 0x98410 Offset: 0x97810 VA: 0x180098410
	public float blurSize; // 0x2C
	[RangeAttribute] // RVA: 0x97E20 Offset: 0x97220 VA: 0x180097E20
	public int blurIterations; // 0x30
	public float fadeToBlurDistance; // 0x34
	public BlurOptimized.BlurType blurType; // 0x38
	public Shader blurShader; // 0x40
	private Material blurMaterial; // 0x48


	public override bool CheckResources() { }

	public void OnDisable() { }

	public bool IsActive() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public enum BlurOptimized.BlurType // TypeDefIndex: 8167
{	public int value__; // 0x0
	public const BlurOptimized.BlurType StandardGauss = 0;
	public const BlurOptimized.BlurType SgxGauss = 1;

}

public class BlurOptimized : PostProcessEffectSettings // TypeDefIndex: 10243
{	[RangeAttribute] // RVA: 0x70E10 Offset: 0x70210 VA: 0x180070E10
	public FixedIntParameter downsample; // 0x30
	[RangeAttribute] // RVA: 0x97E20 Offset: 0x97220 VA: 0x180097E20
	public FixedIntParameter blurIterations; // 0x38
	[RangeAttribute] // RVA: 0x98410 Offset: 0x97810 VA: 0x180098410
	public FloatParameter blurSize; // 0x40
	public FloatParameter fadeToBlurDistance; // 0x48
	public BlurTypeParameter blurType; // 0x50


	public void .ctor() { }

}

