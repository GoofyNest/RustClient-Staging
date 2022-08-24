public class BloomOptimized : PostEffectsBase // TypeDefIndex: 8162
{	[RangeAttribute] // RVA: 0x97A40 Offset: 0x96E40 VA: 0x180097A40
	public float threshold; // 0x28
	[RangeAttribute] // RVA: 0x97B10 Offset: 0x96F10 VA: 0x180097B10
	public float intensity; // 0x2C
	[RangeAttribute] // RVA: 0x97DA0 Offset: 0x971A0 VA: 0x180097DA0
	public float blurSize; // 0x30
	private BloomOptimized.Resolution resolution; // 0x34
	[RangeAttribute] // RVA: 0x97E20 Offset: 0x97220 VA: 0x180097E20
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

