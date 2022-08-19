public class BloomOptimized : PostEffectsBase // TypeDefIndex: 8162
{	// Fields
	[RangeAttribute] // RVA: 0x97890 Offset: 0x96C90 VA: 0x180097890
	public float threshold; // 0x28
	[RangeAttribute] // RVA: 0x97920 Offset: 0x96D20 VA: 0x180097920
	public float intensity; // 0x2C
	[RangeAttribute] // RVA: 0x97A60 Offset: 0x96E60 VA: 0x180097A60
	public float blurSize; // 0x30
	private BloomOptimized.Resolution resolution; // 0x34
	[RangeAttribute] // RVA: 0x97BC0 Offset: 0x96FC0 VA: 0x180097BC0
	public int blurIterations; // 0x38
	public BloomOptimized.BlurType blurType; // 0x3C
	public Shader fastBloomShader; // 0x40
	private Material fastBloomMaterial; // 0x48

	// Methods

	// RVA: 0x1073E20 Offset: 0x1072420 VA: 0x181073E20 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x12C4DB0 Offset: 0x12C33B0 VA: 0x1812C4DB0
	private void OnDisable() { }

	// RVA: 0x12C4E40 Offset: 0x12C3440 VA: 0x1812C4E40
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12C5290 Offset: 0x12C3890 VA: 0x1812C5290
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

