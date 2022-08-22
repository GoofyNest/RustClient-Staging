public class BlurOptimized : PostEffectsBase, IImageEffect // TypeDefIndex: 8166
{	// Fields
	[RangeAttribute] // RVA: 0x71350 Offset: 0x70750 VA: 0x180071350
	public int downsample; // 0x28
	[RangeAttribute] // RVA: 0x98320 Offset: 0x97720 VA: 0x180098320
	public float blurSize; // 0x2C
	[RangeAttribute] // RVA: 0x97CA0 Offset: 0x970A0 VA: 0x180097CA0
	public int blurIterations; // 0x30
	public float fadeToBlurDistance; // 0x34
	public BlurOptimized.BlurType blurType; // 0x38
	public Shader blurShader; // 0x40
	private Material blurMaterial; // 0x48

	// Methods

	// RVA: 0x1074B50 Offset: 0x1073150 VA: 0x181074B50 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x12CD670 Offset: 0x12CBC70 VA: 0x1812CD670
	public void OnDisable() { }

	// RVA: 0x1074BB0 Offset: 0x10731B0 VA: 0x181074BB0 Slot: 5
	public bool IsActive() { }

	// RVA: 0x12CD700 Offset: 0x12CBD00 VA: 0x1812CD700 Slot: 6
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12CDC30 Offset: 0x12CC230 VA: 0x1812CDC30
	public void .ctor() { }

}

public enum BlurOptimized.BlurType // TypeDefIndex: 8167
{	// Fields
	public int value__; // 0x0
	public const BlurOptimized.BlurType StandardGauss = 0;
	public const BlurOptimized.BlurType SgxGauss = 1;

}

public class BlurOptimized : PostProcessEffectSettings // TypeDefIndex: 10243
{	// Fields
	[RangeAttribute] // RVA: 0x71350 Offset: 0x70750 VA: 0x180071350
	public FixedIntParameter downsample; // 0x30
	[RangeAttribute] // RVA: 0x97CA0 Offset: 0x970A0 VA: 0x180097CA0
	public FixedIntParameter blurIterations; // 0x38
	[RangeAttribute] // RVA: 0x98320 Offset: 0x97720 VA: 0x180098320
	public FloatParameter blurSize; // 0x40
	public FloatParameter fadeToBlurDistance; // 0x48
	public BlurTypeParameter blurType; // 0x50

	// Methods

	// RVA: 0x5168D0 Offset: 0x514ED0 VA: 0x1805168D0
	public void .ctor() { }

}

