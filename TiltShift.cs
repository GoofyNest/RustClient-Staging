internal class TiltShift : PostEffectsBase // TypeDefIndex: 8208
{	// Fields
	public TiltShift.TiltShiftMode mode; // 0x28
	public TiltShift.TiltShiftQuality quality; // 0x2C
	[RangeAttribute] // RVA: 0x9E830 Offset: 0x9DC30 VA: 0x18009E830
	public float blurArea; // 0x30
	[RangeAttribute] // RVA: 0x9E8A0 Offset: 0x9DCA0 VA: 0x18009E8A0
	public float maxBlurSize; // 0x34
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public int downsample; // 0x38
	public Shader tiltShiftShader; // 0x40
	private Material tiltShiftMaterial; // 0x48

	// Methods

	// RVA: 0x21E7C10 Offset: 0x21E6210 VA: 0x1821E7C10 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21E7C70 Offset: 0x21E6270 VA: 0x1821E7C70
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21E7F20 Offset: 0x21E6520 VA: 0x1821E7F20
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

