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
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public ComputeBuffer get_data() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	private void set_data(ComputeBuffer value) { }

	// RVA: 0x1018C50 Offset: 0x1017250 VA: 0x181018C50
	public void Generate(PostProcessRenderContext context) { }

	// RVA: 0x1019000 Offset: 0x1017600 VA: 0x181019000
	public Vector4 GetHistogramScaleOffsetRes(PostProcessRenderContext context) { }

	// RVA: 0x1019070 Offset: 0x1017670 VA: 0x181019070
	public void Release() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

