internal sealed class LogHistogram // TypeDefIndex: 11863
{	public const int rangeMin = -9;
	public const int rangeMax = 9;
	private const int k_Bins = 128;
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ComputeBuffer <data>k__BackingField; // 0x10

	public ComputeBuffer data { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public ComputeBuffer get_data() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_data(ComputeBuffer value) { }

	public void Generate(PostProcessRenderContext context) { }

	public Vector4 GetHistogramScaleOffsetRes(PostProcessRenderContext context) { }

	public void Release() { }

	public void .ctor() { }

}

