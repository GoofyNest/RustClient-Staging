internal class TiltShift : PostEffectsBase // TypeDefIndex: 8208
{	// Fields
	public TiltShift.TiltShiftMode mode; // 0x28
	public TiltShift.TiltShiftQuality quality; // 0x2C
	[RangeAttribute] // RVA: 0x9E8C0 Offset: 0x9DCC0 VA: 0x18009E8C0
	public float blurArea; // 0x30
	[RangeAttribute] // RVA: 0x9E9B0 Offset: 0x9DDB0 VA: 0x18009E9B0
	public float maxBlurSize; // 0x34
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public int downsample; // 0x38
	public Shader tiltShiftShader; // 0x40
	private Material tiltShiftMaterial; // 0x48

	// Methods

	// RVA: 0x21E7A50 Offset: 0x21E6050 VA: 0x1821E7A50 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21E7AB0 Offset: 0x21E60B0 VA: 0x1821E7AB0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21E7D60 Offset: 0x21E6360 VA: 0x1821E7D60
	public void .ctor() { }

}

public enum TiltShift.TiltShiftMode // TypeDefIndex: 8209
{	// Fields
	public int value__; // 0x0
	public const TiltShift.TiltShiftMode TiltShiftMode = 0;
	public const TiltShift.TiltShiftMode IrisMode = 1;

}

public enum TiltShift.TiltShiftQuality // TypeDefIndex: 8210
{	// Fields
	public int value__; // 0x0
	public const TiltShift.TiltShiftQuality Preview = 0;
	public const TiltShift.TiltShiftQuality Normal = 1;
	public const TiltShift.TiltShiftQuality High = 2;

}

