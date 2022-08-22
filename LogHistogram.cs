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

	// RVA: 0x1018990 Offset: 0x1016F90 VA: 0x181018990
	public void Generate(PostProcessRenderContext context) { }

	// RVA: 0x1018D40 Offset: 0x1017340 VA: 0x181018D40
	public Vector4 GetHistogramScaleOffsetRes(PostProcessRenderContext context) { }

	// RVA: 0x1018DB0 Offset: 0x10173B0 VA: 0x181018DB0
	public void Release() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

