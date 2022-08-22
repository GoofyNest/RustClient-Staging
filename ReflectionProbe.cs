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

	// RVA: 0x19AE5C0 Offset: 0x19ACBC0 VA: 0x1819AE5C0
	public void set_size(Vector3 value) { }

	// RVA: 0x19AE050 Offset: 0x19AC650 VA: 0x1819AE050
	public float get_nearClipPlane() { }

	// RVA: 0x19AE4A0 Offset: 0x19ACAA0 VA: 0x1819AE4A0
	public void set_nearClipPlane(float value) { }

	// RVA: 0x19ADF50 Offset: 0x19AC550 VA: 0x1819ADF50
	public float get_farClipPlane() { }

	// RVA: 0x19AE380 Offset: 0x19AC980 VA: 0x1819AE380
	public void set_farClipPlane(float value) { }

	// RVA: 0x19ADFD0 Offset: 0x19AC5D0 VA: 0x1819ADFD0
	public float get_intensity() { }

	// RVA: 0x19AE410 Offset: 0x19ACA10 VA: 0x1819AE410
	public void set_intensity(float value) { }

	// RVA: 0x19ADF90 Offset: 0x19AC590 VA: 0x1819ADF90
	public bool get_hdr() { }

	// RVA: 0x19AE150 Offset: 0x19AC750 VA: 0x1819AE150
	public float get_shadowDistance() { }

	// RVA: 0x19AE110 Offset: 0x19AC710 VA: 0x1819AE110
	public int get_resolution() { }

	// RVA: 0x19AE530 Offset: 0x19ACB30 VA: 0x1819AE530
	public void set_resolution(int value) { }

	// RVA: 0x19AE2F0 Offset: 0x19AC8F0 VA: 0x1819AE2F0
	public void set_cullingMask(int value) { }

	// RVA: 0x19ADED0 Offset: 0x19AC4D0 VA: 0x1819ADED0
	public ReflectionProbeClearFlags get_clearFlags() { }

	// RVA: 0x19AE2B0 Offset: 0x19AC8B0 VA: 0x1819AE2B0
	public void set_clearFlags(ReflectionProbeClearFlags value) { }

	// RVA: 0x19ADE80 Offset: 0x19AC480 VA: 0x1819ADE80
	public Color get_backgroundColor() { }

	// RVA: 0x19AE260 Offset: 0x19AC860 VA: 0x1819AE260
	public void set_backgroundColor(Color value) { }

	// RVA: 0x19AE010 Offset: 0x19AC610 VA: 0x1819AE010
	public ReflectionProbeMode get_mode() { }

	// RVA: 0x19AE460 Offset: 0x19ACA60 VA: 0x1819AE460
	public void set_mode(ReflectionProbeMode value) { }

	// RVA: 0x19AE3D0 Offset: 0x19AC9D0 VA: 0x1819AE3D0
	public void set_importance(int value) { }

	// RVA: 0x19AE0D0 Offset: 0x19AC6D0 VA: 0x1819AE0D0
	public ReflectionProbeRefreshMode get_refreshMode() { }

	// RVA: 0x19AE4F0 Offset: 0x19ACAF0 VA: 0x1819AE4F0
	public void set_refreshMode(ReflectionProbeRefreshMode value) { }

	// RVA: 0x19AE1D0 Offset: 0x19AC7D0 VA: 0x1819AE1D0
	public ReflectionProbeTimeSlicingMode get_timeSlicingMode() { }

	// RVA: 0x19AE610 Offset: 0x19ACC10 VA: 0x1819AE610
	public void set_timeSlicingMode(ReflectionProbeTimeSlicingMode value) { }

	// RVA: 0x19ADF10 Offset: 0x19AC510 VA: 0x1819ADF10
	public Texture get_customBakedTexture() { }

	// RVA: 0x19AE330 Offset: 0x19AC930 VA: 0x1819AE330
	public void set_customBakedTexture(Texture value) { }

	// RVA: 0x19AE090 Offset: 0x19AC690 VA: 0x1819AE090
	public RenderTexture get_realtimeTexture() { }

	// RVA: 0x19AE190 Offset: 0x19AC790 VA: 0x1819AE190
	public Texture get_texture() { }

	// RVA: 0x19ADD70 Offset: 0x19AC370 VA: 0x1819ADD70
	public int RenderProbe() { }

	// RVA: 0x19ADCF0 Offset: 0x19AC2F0 VA: 0x1819ADCF0
	public int RenderProbe(RenderTexture targetTexture) { }

	// RVA: 0x19ADCB0 Offset: 0x19AC2B0 VA: 0x1819ADCB0
	public bool IsFinishedRendering(int renderId) { }

	// RVA: 0x19ADDE0 Offset: 0x19AC3E0 VA: 0x1819ADDE0
	private int ScheduleRender(ReflectionProbeTimeSlicingMode timeSlicingMode, RenderTexture targetTexture) { }

	[NativeHeaderAttribute] // RVA: 0x7AAC0 Offset: 0x79EC0 VA: 0x18007AAC0
	[FreeFunctionAttribute] // RVA: 0x7AAC0 Offset: 0x79EC0 VA: 0x18007AAC0
	// RVA: 0x19ADB80 Offset: 0x19AC180 VA: 0x1819ADB80
	public static bool BlendCubemap(Texture src, Texture dst, float blend, RenderTexture target) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19ADBF0 Offset: 0x19AC1F0 VA: 0x1819ADBF0
	private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbe.ReflectionProbeEvent probeEvent) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19ADC50 Offset: 0x19AC250 VA: 0x1819ADC50
	private static void CallSetDefaultReflection(Cubemap defaultReflectionCubemap) { }

	// RVA: 0x19AE570 Offset: 0x19ACB70 VA: 0x1819AE570
	private void set_size_Injected(ref Vector3 value) { }

	// RVA: 0x19ADE30 Offset: 0x19AC430 VA: 0x1819ADE30
	private void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x19AE210 Offset: 0x19AC810 VA: 0x1819AE210
	private void set_backgroundColor_Injected(ref Color value) { }

}

public enum ReflectionProbe.ReflectionProbeEvent // TypeDefIndex: 3369
{	// Fields
	public int value__; // 0x0
	public const ReflectionProbe.ReflectionProbeEvent ReflectionProbeAdded = 0;
	public const ReflectionProbe.ReflectionProbeEvent ReflectionProbeRemoved = 1;

}

