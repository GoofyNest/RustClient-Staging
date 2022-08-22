public sealed class ReflectionProbe : Behaviour // TypeDefIndex: 3368
{	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static Action<Cubemap> defaultReflectionSet; // 0x8

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


	public void set_size(Vector3 value) { }

	public float get_nearClipPlane() { }

	public void set_nearClipPlane(float value) { }

	public float get_farClipPlane() { }

	public void set_farClipPlane(float value) { }

	public float get_intensity() { }

	public void set_intensity(float value) { }

	public bool get_hdr() { }

	public float get_shadowDistance() { }

	public int get_resolution() { }

	public void set_resolution(int value) { }

	public void set_cullingMask(int value) { }

	public ReflectionProbeClearFlags get_clearFlags() { }

	public void set_clearFlags(ReflectionProbeClearFlags value) { }

	public Color get_backgroundColor() { }

	public void set_backgroundColor(Color value) { }

	public ReflectionProbeMode get_mode() { }

	public void set_mode(ReflectionProbeMode value) { }

	public void set_importance(int value) { }

	public ReflectionProbeRefreshMode get_refreshMode() { }

	public void set_refreshMode(ReflectionProbeRefreshMode value) { }

	public ReflectionProbeTimeSlicingMode get_timeSlicingMode() { }

	public void set_timeSlicingMode(ReflectionProbeTimeSlicingMode value) { }

	public Texture get_customBakedTexture() { }

	public void set_customBakedTexture(Texture value) { }

	public RenderTexture get_realtimeTexture() { }

	public Texture get_texture() { }

	public int RenderProbe() { }

	public int RenderProbe(RenderTexture targetTexture) { }

	public bool IsFinishedRendering(int renderId) { }

	private int ScheduleRender(ReflectionProbeTimeSlicingMode timeSlicingMode, RenderTexture targetTexture) { }

	[NativeHeaderAttribute] // RVA: 0x7AAC0 Offset: 0x79EC0 VA: 0x18007AAC0
	[FreeFunctionAttribute] // RVA: 0x7AAC0 Offset: 0x79EC0 VA: 0x18007AAC0
	public static bool BlendCubemap(Texture src, Texture dst, float blend, RenderTexture target) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbe.ReflectionProbeEvent probeEvent) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void CallSetDefaultReflection(Cubemap defaultReflectionCubemap) { }

	private void set_size_Injected(ref Vector3 value) { }

	private void get_backgroundColor_Injected(out Color ret) { }

	private void set_backgroundColor_Injected(ref Color value) { }

}

public enum ReflectionProbe.ReflectionProbeEvent // TypeDefIndex: 3369
{	public int value__; // 0x0
	public const ReflectionProbe.ReflectionProbeEvent ReflectionProbeAdded = 0;
	public const ReflectionProbe.ReflectionProbeEvent ReflectionProbeRemoved = 1;

}

