public class BloomOptimized : PostEffectsBase // TypeDefIndex: 8162
{	// Fields
	[RangeAttribute] // RVA: 0x97920 Offset: 0x96D20 VA: 0x180097920
	public float threshold; // 0x28
	[RangeAttribute] // RVA: 0x979B0 Offset: 0x96DB0 VA: 0x1800979B0
	public float intensity; // 0x2C
	[RangeAttribute] // RVA: 0x97C30 Offset: 0x97030 VA: 0x180097C30
	public float blurSize; // 0x30
	private BloomOptimized.Resolution resolution; // 0x34
	[RangeAttribute] // RVA: 0x97CA0 Offset: 0x970A0 VA: 0x180097CA0
	public int blurIterations; // 0x38
	public BloomOptimized.BlurType blurType; // 0x3C
	public Shader fastBloomShader; // 0x40
	private Material fastBloomMaterial; // 0x48

	// Methods

	// RVA: 0x1074B50 Offset: 0x1073150 VA: 0x181074B50 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x12CB520 Offset: 0x12C9B20 VA: 0x1812CB520
	private void OnDisable() { }

	// RVA: 0x12CB5B0 Offset: 0x12C9BB0 VA: 0x1812CB5B0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12CBA00 Offset: 0x12CA000 VA: 0x1812CBA00
	public void .ctor() { }

}

public enum BloomOptimized.Resolution // TypeDefIndex: 8163
{	// Fields
	public int value__; // 0x0
	public const BloomOptimized.Resolution Low = 0;
	public const BloomOptimized.Resolution High = 1;

}

public enum BloomOptimized.BlurType // TypeDefIndex: 8164
{	// Fields
	public int value__; // 0x0
	public const BloomOptimized.BlurType Standard = 0;
	public const BloomOptimized.BlurType Sgx = 1;

}

