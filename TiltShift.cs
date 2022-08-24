internal class TiltShift : PostEffectsBase // TypeDefIndex: 8208
{	public TiltShift.TiltShiftMode mode; // 0x28
	public TiltShift.TiltShiftQuality quality; // 0x2C
	[RangeAttribute] // RVA: 0x9E930 Offset: 0x9DD30 VA: 0x18009E930
	public float blurArea; // 0x30
	[RangeAttribute] // RVA: 0x9EA20 Offset: 0x9DE20 VA: 0x18009EA20
	public float maxBlurSize; // 0x34
	[RangeAttribute] // RVA: 0x70FE0 Offset: 0x703E0 VA: 0x180070FE0
	public int downsample; // 0x38
	public Shader tiltShiftShader; // 0x40
	private Material tiltShiftMaterial; // 0x48


	public override bool CheckResources() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public enum TiltShift.TiltShiftMode // TypeDefIndex: 8209
{	public int value__; // 0x0
	public const TiltShift.TiltShiftMode TiltShiftMode = 0;
	public const TiltShift.TiltShiftMode IrisMode = 1;

}

public enum TiltShift.TiltShiftQuality // TypeDefIndex: 8210
{	public int value__; // 0x0
	public const TiltShift.TiltShiftQuality Preview = 0;
	public const TiltShift.TiltShiftQuality Normal = 1;
	public const TiltShift.TiltShiftQuality High = 2;

}

