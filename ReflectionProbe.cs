public sealed class ReflectionProbe : Behaviour // TypeDefIndex: 3368
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static Action<Cubemap> defaultReflectionSet; // 0x8

	// Properties
	[NativeNameAttribute] // RVA: 0x7AF90 Offset: 0x7A390 VA: 0x18007AF90
	public Vector3 size { set; }
	[NativeNameAttribute] // RVA: 0x7B330 Offset: 0x7A730 VA: 0x18007B330
	public float nearClipPlane { get; set; }
	[NativeNameAttribute] // RVA: 0x7B460 Offset: 0x7A860 VA: 0x18007B460
	public float farClipPlane { get; set; }
	[NativeNameAttribute] // RVA: 0x7B510 Offset: 0x7A910 VA: 0x18007B510
	public float intensity { get; set; }
	[NativeNameAttribute] // RVA: 0x7B6E0 Offset: 0x7AAE0 VA: 0x18007B6E0
	public bool hdr { get; }
	public float shadowDistance { get; }
	public int resolution { get; set; }
	public int cullingMask { set; }
	public ReflectionProbeClearFlags clearFlags { get; set; }
	public Color backgroundColor { get; set; }
	public ReflectionProbeMode mode { get; set; }
	public int importance { set; }
	public ReflectionProbeRefreshMode refreshMode { get; set; }
	public ReflectionProbeTimeSlicingMode timeSlicingMode { get; set; }
	public Texture customBakedTexture { get; set; }
	public RenderTexture realtimeTexture { get; }
	public Texture texture { get; }

	// Methods

	// RVA: 0x19AE300 Offset: 0x19AC900 VA: 0x1819AE300
	public void set_size(Vector3 value) { }

	// RVA: 0x19ADD90 Offset: 0x19AC390 VA: 0x1819ADD90
	public float get_nearClipPlane() { }

	// RVA: 0x19AE1E0 Offset: 0x19AC7E0 VA: 0x1819AE1E0
	public void set_nearClipPlane(float value) { }

	// RVA: 0x19ADC90 Offset: 0x19AC290 VA: 0x1819ADC90
	public float get_farClipPlane() { }

	// RVA: 0x19AE0C0 Offset: 0x19AC6C0 VA: 0x1819AE0C0
	public void set_farClipPlane(float value) { }

	// RVA: 0x19ADD10 Offset: 0x19AC310 VA: 0x1819ADD10
	public float get_intensity() { }

	// RVA: 0x19AE150 Offset: 0x19AC750 VA: 0x1819AE150
	public void set_intensity(float value) { }

	// RVA: 0x19ADCD0 Offset: 0x19AC2D0 VA: 0x1819ADCD0
	public bool get_hdr() { }

	// RVA: 0x19ADE90 Offset: 0x19AC490 VA: 0x1819ADE90
	public float get_shadowDistance() { }

	// RVA: 0x19ADE50 Offset: 0x19AC450 VA: 0x1819ADE50
	public int get_resolution() { }

	// RVA: 0x19AE270 Offset: 0x19AC870 VA: 0x1819AE270
	public void set_resolution(int value) { }

	// RVA: 0x19AE030 Offset: 0x19AC630 VA: 0x1819AE030
	public void set_cullingMask(int value) { }

	// RVA: 0x19ADC10 Offset: 0x19AC210 VA: 0x1819ADC10
	public ReflectionProbeClearFlags get_clearFlags() { }

	// RVA: 0x19ADFF0 Offset: 0x19AC5F0 VA: 0x1819ADFF0
	public void set_clearFlags(ReflectionProbeClearFlags value) { }

	// RVA: 0x19ADBC0 Offset: 0x19AC1C0 VA: 0x1819ADBC0
	public Color get_backgroundColor() { }

	// RVA: 0x19ADFA0 Offset: 0x19AC5A0 VA: 0x1819ADFA0
	public void set_backgroundColor(Color value) { }

	// RVA: 0x19ADD50 Offset: 0x19AC350 VA: 0x1819ADD50
	public ReflectionProbeMode get_mode() { }

	// RVA: 0x19AE1A0 Offset: 0x19AC7A0 VA: 0x1819AE1A0
	public void set_mode(ReflectionProbeMode value) { }

	// RVA: 0x19AE110 Offset: 0x19AC710 VA: 0x1819AE110
	public void set_importance(int value) { }

	// RVA: 0x19ADE10 Offset: 0x19AC410 VA: 0x1819ADE10
	public ReflectionProbeRefreshMode get_refreshMode() { }

	// RVA: 0x19AE230 Offset: 0x19AC830 VA: 0x1819AE230
	public void set_refreshMode(ReflectionProbeRefreshMode value) { }

	// RVA: 0x19ADF10 Offset: 0x19AC510 VA: 0x1819ADF10
	public ReflectionProbeTimeSlicingMode get_timeSlicingMode() { }

	// RVA: 0x19AE350 Offset: 0x19AC950 VA: 0x1819AE350
	public void set_timeSlicingMode(ReflectionProbeTimeSlicingMode value) { }

	// RVA: 0x19ADC50 Offset: 0x19AC250 VA: 0x1819ADC50
	public Texture get_customBakedTexture() { }

	// RVA: 0x19AE070 Offset: 0x19AC670 VA: 0x1819AE070
	public void set_customBakedTexture(Texture value) { }

	// RVA: 0x19ADDD0 Offset: 0x19AC3D0 VA: 0x1819ADDD0
	public RenderTexture get_realtimeTexture() { }

	// RVA: 0x19ADED0 Offset: 0x19AC4D0 VA: 0x1819ADED0
	public Texture get_texture() { }

	// RVA: 0x19ADAB0 Offset: 0x19AC0B0 VA: 0x1819ADAB0
	public int RenderProbe() { }

	// RVA: 0x19ADA30 Offset: 0x19AC030 VA: 0x1819ADA30
	public int RenderProbe(RenderTexture targetTexture) { }

	// RVA: 0x19AD9F0 Offset: 0x19ABFF0 VA: 0x1819AD9F0
	public bool IsFinishedRendering(int renderId) { }

	// RVA: 0x19ADB20 Offset: 0x19AC120 VA: 0x1819ADB20
	private int ScheduleRender(ReflectionProbeTimeSlicingMode timeSlicingMode, RenderTexture targetTexture) { }

	[NativeHeaderAttribute] // RVA: 0x7AAC0 Offset: 0x79EC0 VA: 0x18007AAC0
	[FreeFunctionAttribute] // RVA: 0x7AAC0 Offset: 0x79EC0 VA: 0x18007AAC0
	// RVA: 0x19AD8C0 Offset: 0x19ABEC0 VA: 0x1819AD8C0
	public static bool BlendCubemap(Texture src, Texture dst, float blend, RenderTexture target) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19AD930 Offset: 0x19ABF30 VA: 0x1819AD930
	private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbe.ReflectionProbeEvent probeEvent) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19AD990 Offset: 0x19ABF90 VA: 0x1819AD990
	private static void CallSetDefaultReflection(Cubemap defaultReflectionCubemap) { }

	// RVA: 0x19AE2B0 Offset: 0x19AC8B0 VA: 0x1819AE2B0
	private void set_size_Injected(ref Vector3 value) { }

	// RVA: 0x19ADB70 Offset: 0x19AC170 VA: 0x1819ADB70
	private void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x19ADF50 Offset: 0x19AC550 VA: 0x1819ADF50
	private void set_backgroundColor_Injected(ref Color value) { }

}

public enum ReflectionProbe.ReflectionProbeEvent // TypeDefIndex: 3369
{	// Fields
	public int value__; // 0x0
	public const ReflectionProbe.ReflectionProbeEvent ReflectionProbeAdded = 0;
	public const ReflectionProbe.ReflectionProbeEvent ReflectionProbeRemoved = 1;

}

