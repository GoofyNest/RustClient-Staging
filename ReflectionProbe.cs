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

	// RVA: 0x199B9C0 Offset: 0x1999FC0 VA: 0x18199B9C0
	public void set_size(Vector3 value) { }

	// RVA: 0x199B450 Offset: 0x1999A50 VA: 0x18199B450
	public float get_nearClipPlane() { }

	// RVA: 0x199B8A0 Offset: 0x1999EA0 VA: 0x18199B8A0
	public void set_nearClipPlane(float value) { }

	// RVA: 0x199B350 Offset: 0x1999950 VA: 0x18199B350
	public float get_farClipPlane() { }

	// RVA: 0x199B780 Offset: 0x1999D80 VA: 0x18199B780
	public void set_farClipPlane(float value) { }

	// RVA: 0x199B3D0 Offset: 0x19999D0 VA: 0x18199B3D0
	public float get_intensity() { }

	// RVA: 0x199B810 Offset: 0x1999E10 VA: 0x18199B810
	public void set_intensity(float value) { }

	// RVA: 0x199B390 Offset: 0x1999990 VA: 0x18199B390
	public bool get_hdr() { }

	// RVA: 0x199B550 Offset: 0x1999B50 VA: 0x18199B550
	public float get_shadowDistance() { }

	// RVA: 0x199B510 Offset: 0x1999B10 VA: 0x18199B510
	public int get_resolution() { }

	// RVA: 0x199B930 Offset: 0x1999F30 VA: 0x18199B930
	public void set_resolution(int value) { }

	// RVA: 0x199B6F0 Offset: 0x1999CF0 VA: 0x18199B6F0
	public void set_cullingMask(int value) { }

	// RVA: 0x199B2D0 Offset: 0x19998D0 VA: 0x18199B2D0
	public ReflectionProbeClearFlags get_clearFlags() { }

	// RVA: 0x199B6B0 Offset: 0x1999CB0 VA: 0x18199B6B0
	public void set_clearFlags(ReflectionProbeClearFlags value) { }

	// RVA: 0x199B280 Offset: 0x1999880 VA: 0x18199B280
	public Color get_backgroundColor() { }

	// RVA: 0x199B660 Offset: 0x1999C60 VA: 0x18199B660
	public void set_backgroundColor(Color value) { }

	// RVA: 0x199B410 Offset: 0x1999A10 VA: 0x18199B410
	public ReflectionProbeMode get_mode() { }

	// RVA: 0x199B860 Offset: 0x1999E60 VA: 0x18199B860
	public void set_mode(ReflectionProbeMode value) { }

	// RVA: 0x199B7D0 Offset: 0x1999DD0 VA: 0x18199B7D0
	public void set_importance(int value) { }

	// RVA: 0x199B4D0 Offset: 0x1999AD0 VA: 0x18199B4D0
	public ReflectionProbeRefreshMode get_refreshMode() { }

	// RVA: 0x199B8F0 Offset: 0x1999EF0 VA: 0x18199B8F0
	public void set_refreshMode(ReflectionProbeRefreshMode value) { }

	// RVA: 0x199B5D0 Offset: 0x1999BD0 VA: 0x18199B5D0
	public ReflectionProbeTimeSlicingMode get_timeSlicingMode() { }

	// RVA: 0x199BA10 Offset: 0x199A010 VA: 0x18199BA10
	public void set_timeSlicingMode(ReflectionProbeTimeSlicingMode value) { }

	// RVA: 0x199B310 Offset: 0x1999910 VA: 0x18199B310
	public Texture get_customBakedTexture() { }

	// RVA: 0x199B730 Offset: 0x1999D30 VA: 0x18199B730
	public void set_customBakedTexture(Texture value) { }

	// RVA: 0x199B490 Offset: 0x1999A90 VA: 0x18199B490
	public RenderTexture get_realtimeTexture() { }

	// RVA: 0x199B590 Offset: 0x1999B90 VA: 0x18199B590
	public Texture get_texture() { }

	// RVA: 0x199B170 Offset: 0x1999770 VA: 0x18199B170
	public int RenderProbe() { }

	// RVA: 0x199B0F0 Offset: 0x19996F0 VA: 0x18199B0F0
	public int RenderProbe(RenderTexture targetTexture) { }

	// RVA: 0x199B0B0 Offset: 0x19996B0 VA: 0x18199B0B0
	public bool IsFinishedRendering(int renderId) { }

	// RVA: 0x199B1E0 Offset: 0x19997E0 VA: 0x18199B1E0
	private int ScheduleRender(ReflectionProbeTimeSlicingMode timeSlicingMode, RenderTexture targetTexture) { }

	[NativeHeaderAttribute] // RVA: 0x7AAC0 Offset: 0x79EC0 VA: 0x18007AAC0
	[FreeFunctionAttribute] // RVA: 0x7AAC0 Offset: 0x79EC0 VA: 0x18007AAC0
	// RVA: 0x199AF80 Offset: 0x1999580 VA: 0x18199AF80
	public static bool BlendCubemap(Texture src, Texture dst, float blend, RenderTexture target) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x199AFF0 Offset: 0x19995F0 VA: 0x18199AFF0
	private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbe.ReflectionProbeEvent probeEvent) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x199B050 Offset: 0x1999650 VA: 0x18199B050
	private static void CallSetDefaultReflection(Cubemap defaultReflectionCubemap) { }

	// RVA: 0x199B970 Offset: 0x1999F70 VA: 0x18199B970
	private void set_size_Injected(ref Vector3 value) { }

	// RVA: 0x199B230 Offset: 0x1999830 VA: 0x18199B230
	private void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x199B610 Offset: 0x1999C10 VA: 0x18199B610
	private void set_backgroundColor_Injected(ref Color value) { }

}

public enum ReflectionProbe.ReflectionProbeEvent // TypeDefIndex: 3369
{	// Fields
	public int value__; // 0x0
	public const ReflectionProbe.ReflectionProbeEvent ReflectionProbeAdded = 0;
	public const ReflectionProbe.ReflectionProbeEvent ReflectionProbeRemoved = 1;

}

