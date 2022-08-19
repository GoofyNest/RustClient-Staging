public sealed class ReflectionProbe : Behaviour // TypeDefIndex: 3368
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private static Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private static Action<Cubemap> defaultReflectionSet; // 0x8

	// Properties
	[NativeNameAttribute] // RVA: 0x7B230 Offset: 0x7A630 VA: 0x18007B230
	public Vector3 size { set; }
	[NativeNameAttribute] // RVA: 0x7B2E0 Offset: 0x7A6E0 VA: 0x18007B2E0
	public float nearClipPlane { get; set; }
	[NativeNameAttribute] // RVA: 0x7B410 Offset: 0x7A810 VA: 0x18007B410
	public float farClipPlane { get; set; }
	[NativeNameAttribute] // RVA: 0x7B5D0 Offset: 0x7A9D0 VA: 0x18007B5D0
	public float intensity { get; set; }
	[NativeNameAttribute] // RVA: 0x7B660 Offset: 0x7AA60 VA: 0x18007B660
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

	// RVA: 0x19AE340 Offset: 0x19AC940 VA: 0x1819AE340
	public void set_size(Vector3 value) { }

	// RVA: 0x19ADDD0 Offset: 0x19AC3D0 VA: 0x1819ADDD0
	public float get_nearClipPlane() { }

	// RVA: 0x19AE220 Offset: 0x19AC820 VA: 0x1819AE220
	public void set_nearClipPlane(float value) { }

	// RVA: 0x19ADCD0 Offset: 0x19AC2D0 VA: 0x1819ADCD0
	public float get_farClipPlane() { }

	// RVA: 0x19AE100 Offset: 0x19AC700 VA: 0x1819AE100
	public void set_farClipPlane(float value) { }

	// RVA: 0x19ADD50 Offset: 0x19AC350 VA: 0x1819ADD50
	public float get_intensity() { }

	// RVA: 0x19AE190 Offset: 0x19AC790 VA: 0x1819AE190
	public void set_intensity(float value) { }

	// RVA: 0x19ADD10 Offset: 0x19AC310 VA: 0x1819ADD10
	public bool get_hdr() { }

	// RVA: 0x19ADED0 Offset: 0x19AC4D0 VA: 0x1819ADED0
	public float get_shadowDistance() { }

	// RVA: 0x19ADE90 Offset: 0x19AC490 VA: 0x1819ADE90
	public int get_resolution() { }

	// RVA: 0x19AE2B0 Offset: 0x19AC8B0 VA: 0x1819AE2B0
	public void set_resolution(int value) { }

	// RVA: 0x19AE070 Offset: 0x19AC670 VA: 0x1819AE070
	public void set_cullingMask(int value) { }

	// RVA: 0x19ADC50 Offset: 0x19AC250 VA: 0x1819ADC50
	public ReflectionProbeClearFlags get_clearFlags() { }

	// RVA: 0x19AE030 Offset: 0x19AC630 VA: 0x1819AE030
	public void set_clearFlags(ReflectionProbeClearFlags value) { }

	// RVA: 0x19ADC00 Offset: 0x19AC200 VA: 0x1819ADC00
	public Color get_backgroundColor() { }

	// RVA: 0x19ADFE0 Offset: 0x19AC5E0 VA: 0x1819ADFE0
	public void set_backgroundColor(Color value) { }

	// RVA: 0x19ADD90 Offset: 0x19AC390 VA: 0x1819ADD90
	public ReflectionProbeMode get_mode() { }

	// RVA: 0x19AE1E0 Offset: 0x19AC7E0 VA: 0x1819AE1E0
	public void set_mode(ReflectionProbeMode value) { }

	// RVA: 0x19AE150 Offset: 0x19AC750 VA: 0x1819AE150
	public void set_importance(int value) { }

	// RVA: 0x19ADE50 Offset: 0x19AC450 VA: 0x1819ADE50
	public ReflectionProbeRefreshMode get_refreshMode() { }

	// RVA: 0x19AE270 Offset: 0x19AC870 VA: 0x1819AE270
	public void set_refreshMode(ReflectionProbeRefreshMode value) { }

	// RVA: 0x19ADF50 Offset: 0x19AC550 VA: 0x1819ADF50
	public ReflectionProbeTimeSlicingMode get_timeSlicingMode() { }

	// RVA: 0x19AE390 Offset: 0x19AC990 VA: 0x1819AE390
	public void set_timeSlicingMode(ReflectionProbeTimeSlicingMode value) { }

	// RVA: 0x19ADC90 Offset: 0x19AC290 VA: 0x1819ADC90
	public Texture get_customBakedTexture() { }

	// RVA: 0x19AE0B0 Offset: 0x19AC6B0 VA: 0x1819AE0B0
	public void set_customBakedTexture(Texture value) { }

	// RVA: 0x19ADE10 Offset: 0x19AC410 VA: 0x1819ADE10
	public RenderTexture get_realtimeTexture() { }

	// RVA: 0x19ADF10 Offset: 0x19AC510 VA: 0x1819ADF10
	public Texture get_texture() { }

	// RVA: 0x19ADAF0 Offset: 0x19AC0F0 VA: 0x1819ADAF0
	public int RenderProbe() { }

	// RVA: 0x19ADA70 Offset: 0x19AC070 VA: 0x1819ADA70
	public int RenderProbe(RenderTexture targetTexture) { }

	// RVA: 0x19ADA30 Offset: 0x19AC030 VA: 0x1819ADA30
	public bool IsFinishedRendering(int renderId) { }

	// RVA: 0x19ADB60 Offset: 0x19AC160 VA: 0x1819ADB60
	private int ScheduleRender(ReflectionProbeTimeSlicingMode timeSlicingMode, RenderTexture targetTexture) { }

	[FreeFunctionAttribute] // RVA: 0x7AB80 Offset: 0x79F80 VA: 0x18007AB80
	[NativeHeaderAttribute] // RVA: 0x7AB80 Offset: 0x79F80 VA: 0x18007AB80
	// RVA: 0x19AD900 Offset: 0x19ABF00 VA: 0x1819AD900
	public static bool BlendCubemap(Texture src, Texture dst, float blend, RenderTexture target) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19AD970 Offset: 0x19ABF70 VA: 0x1819AD970
	private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbe.ReflectionProbeEvent probeEvent) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19AD9D0 Offset: 0x19ABFD0 VA: 0x1819AD9D0
	private static void CallSetDefaultReflection(Cubemap defaultReflectionCubemap) { }

	// RVA: 0x19AE2F0 Offset: 0x19AC8F0 VA: 0x1819AE2F0
	private void set_size_Injected(ref Vector3 value) { }

	// RVA: 0x19ADBB0 Offset: 0x19AC1B0 VA: 0x1819ADBB0
	private void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x19ADF90 Offset: 0x19AC590 VA: 0x1819ADF90
	private void set_backgroundColor_Injected(ref Color value) { }

}

public enum ReflectionProbe.ReflectionProbeEvent // TypeDefIndex: 3369
{	// Fields
	public int value__; // 0x0
	public const ReflectionProbe.ReflectionProbeEvent ReflectionProbeAdded = 0;
	public const ReflectionProbe.ReflectionProbeEvent ReflectionProbeRemoved = 1;

}

