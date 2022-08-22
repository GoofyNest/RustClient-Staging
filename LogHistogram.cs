internal sealed class LogHistogram // TypeDefIndex: 11863
{	// Fields
	public const int rangeMin = -9;
	public const int rangeMax = 9;
	private const int k_Bins = 128;
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ComputeBuffer <data>k__BackingField; // 0x10

	// Properties
	public ComputeBuffer data { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public ComputeBuffer get_data() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	private void set_data(ComputeBuffer value) { }

	// RVA: 0x10196F0 Offset: 0x1017CF0 VA: 0x1810196F0
	public void Generate(PostProcessRenderContext context) { }

	// RVA: 0x1019AA0 Offset: 0x10180A0 VA: 0x181019AA0
	public Vector4 GetHistogramScaleOffsetRes(PostProcessRenderContext context) { }

	// RVA: 0x1019B10 Offset: 0x1018110 VA: 0x181019B10
	public void Release() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

