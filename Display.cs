public class Display // TypeDefIndex: 3383
{	// Fields
	internal IntPtr nativeDisplay; // 0x10
	public static Display[] displays; // 0x0
	private static Display _mainDisplay; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static Display.DisplaysUpdatedDelegate onDisplaysUpdated; // 0x10

	// Properties
	public int renderingWidth { get; }
	public int renderingHeight { get; }
	public int systemWidth { get; }
	public int systemHeight { get; }
	public RenderBuffer colorBuffer { get; }
	public static Display main { get; }

	// Methods

	// RVA: 0x1817580 Offset: 0x1815B80 VA: 0x181817580
	internal void .ctor() { }

	// RVA: 0x18175C0 Offset: 0x1815BC0 VA: 0x1818175C0
	internal void .ctor(IntPtr nativeDisplay) { }

	// RVA: 0x1817790 Offset: 0x1815D90 VA: 0x181817790
	public int get_renderingWidth() { }

	// RVA: 0x1817700 Offset: 0x1815D00 VA: 0x181817700
	public int get_renderingHeight() { }

	// RVA: 0x18178B0 Offset: 0x1815EB0 VA: 0x1818178B0
	public int get_systemWidth() { }

	// RVA: 0x1817820 Offset: 0x1815E20 VA: 0x181817820
	public int get_systemHeight() { }

	// RVA: 0x18175F0 Offset: 0x1815BF0 VA: 0x1818175F0
	public RenderBuffer get_colorBuffer() { }

	// RVA: 0x1817340 Offset: 0x1815940 VA: 0x181817340
	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) { }

	// RVA: 0x18176A0 Offset: 0x1815CA0 VA: 0x1818176A0
	public static Display get_main() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1817100 Offset: 0x1815700 VA: 0x181817100
	private static void RecreateDisplayList(IntPtr[] nativeDisplay) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1816DB0 Offset: 0x18153B0 VA: 0x181816DB0
	private static void FireDisplaysUpdated() { }

	[FreeFunctionAttribute] // RVA: 0x83280 Offset: 0x82680 VA: 0x180083280
	// RVA: 0x18170A0 Offset: 0x18156A0 VA: 0x1818170A0
	private static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunctionAttribute] // RVA: 0x833B0 Offset: 0x827B0 VA: 0x1800833B0
	// RVA: 0x1817040 Offset: 0x1815640 VA: 0x181817040
	private static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunctionAttribute] // RVA: 0x83510 Offset: 0x82910 VA: 0x180083510
	// RVA: 0x1816FE0 Offset: 0x18155E0 VA: 0x181816FE0
	private static void GetRenderingBuffersImpl(IntPtr nativeDisplay, out RenderBuffer color, out RenderBuffer depth) { }

	[FreeFunctionAttribute] // RVA: 0x83540 Offset: 0x82940 VA: 0x180083540
	// RVA: 0x18172E0 Offset: 0x18158E0 VA: 0x1818172E0
	private static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry) { }

	// RVA: 0x1817420 Offset: 0x1815A20 VA: 0x181817420
	private static void .cctor() { }

}

public sealed class Display.DisplaysUpdatedDelegate : MulticastDelegate // TypeDefIndex: 3384
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x49A1D0 Offset: 0x4987D0 VA: 0x18049A1D0 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

