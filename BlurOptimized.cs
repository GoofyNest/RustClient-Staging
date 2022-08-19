public class BlurOptimized : PostEffectsBase, IImageEffect // TypeDefIndex: 8166
{	// Fields
	[RangeAttribute] // RVA: 0x711F0 Offset: 0x705F0 VA: 0x1800711F0
	public int downsample; // 0x28
	[RangeAttribute] // RVA: 0x981E0 Offset: 0x975E0 VA: 0x1800981E0
	public float blurSize; // 0x2C
	[RangeAttribute] // RVA: 0x97BC0 Offset: 0x96FC0 VA: 0x180097BC0
	public int blurIterations; // 0x30
	public float fadeToBlurDistance; // 0x34
	public BlurOptimized.BlurType blurType; // 0x38
	public Shader blurShader; // 0x40
	private Material blurMaterial; // 0x48

	// Methods

	// RVA: 0x1073E20 Offset: 0x1072420 VA: 0x181073E20 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x12C6F00 Offset: 0x12C5500 VA: 0x1812C6F00
	public void OnDisable() { }

	// RVA: 0x1073E80 Offset: 0x1072480 VA: 0x181073E80 Slot: 5
	public bool IsActive() { }

	// RVA: 0x12C6F90 Offset: 0x12C5590 VA: 0x1812C6F90 Slot: 6
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12C74C0 Offset: 0x12C5AC0 VA: 0x1812C74C0
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
	[RangeAttribute] // RVA: 0x711F0 Offset: 0x705F0 VA: 0x1800711F0
	public FixedIntParameter downsample; // 0x30
	[RangeAttribute] // RVA: 0x97BC0 Offset: 0x96FC0 VA: 0x180097BC0
	public FixedIntParameter blurIterations; // 0x38
	[RangeAttribute] // RVA: 0x981E0 Offset: 0x975E0 VA: 0x1800981E0
	public FloatParameter blurSize; // 0x40
	public FloatParameter fadeToBlurDistance; // 0x48
	public BlurTypeParameter blurType; // 0x50

	// Methods

	// RVA: 0x516940 Offset: 0x514F40 VA: 0x180516940
	public void .ctor() { }

}

