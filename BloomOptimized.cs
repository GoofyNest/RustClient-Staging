public class BloomOptimized : PostEffectsBase // TypeDefIndex: 8162
{	[RangeAttribute] // RVA: 0x97A20 Offset: 0x96E20 VA: 0x180097A20
	public float threshold; // 0x28
	[RangeAttribute] // RVA: 0x97A80 Offset: 0x96E80 VA: 0x180097A80
	public float intensity; // 0x2C
	[RangeAttribute] // RVA: 0x97D00 Offset: 0x97100 VA: 0x180097D00
	public float blurSize; // 0x30
	private BloomOptimized.Resolution resolution; // 0x34
	[RangeAttribute] // RVA: 0x97DA0 Offset: 0x971A0 VA: 0x180097DA0
	public int blurIterations; // 0x38
	public BloomOptimized.BlurType blurType; // 0x3C
	public Shader fastBloomShader; // 0x40
	private Material fastBloomMaterial; // 0x48


	public override bool CheckResources() { }

	private void OnDisable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public enum BloomOptimized.Resolution // TypeDefIndex: 8163
{	public int value__; // 0x0
	public const BloomOptimized.Resolution Low = 0;
	public const BloomOptimized.Resolution High = 1;

}

public enum BloomOptimized.BlurType // TypeDefIndex: 8164
{	public int value__; // 0x0
	public const BloomOptimized.BlurType Standard = 0;
	public const BloomOptimized.BlurType Sgx = 1;

}

