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

	// RVA: 0x182A140 Offset: 0x1828740 VA: 0x18182A140
	internal void .ctor() { }

	// RVA: 0x182A180 Offset: 0x1828780 VA: 0x18182A180
	internal void .ctor(IntPtr nativeDisplay) { }

	// RVA: 0x182A350 Offset: 0x1828950 VA: 0x18182A350
	public int get_renderingWidth() { }

	// RVA: 0x182A2C0 Offset: 0x18288C0 VA: 0x18182A2C0
	public int get_renderingHeight() { }

	// RVA: 0x182A470 Offset: 0x1828A70 VA: 0x18182A470
	public int get_systemWidth() { }

	// RVA: 0x182A3E0 Offset: 0x18289E0 VA: 0x18182A3E0
	public int get_systemHeight() { }

	// RVA: 0x182A1B0 Offset: 0x18287B0 VA: 0x18182A1B0
	public RenderBuffer get_colorBuffer() { }

	// RVA: 0x1829F00 Offset: 0x1828500 VA: 0x181829F00
	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) { }

	// RVA: 0x182A260 Offset: 0x1828860 VA: 0x18182A260
	public static Display get_main() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1829CC0 Offset: 0x18282C0 VA: 0x181829CC0
	private static void RecreateDisplayList(IntPtr[] nativeDisplay) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1829970 Offset: 0x1827F70 VA: 0x181829970
	private static void FireDisplaysUpdated() { }

	[FreeFunctionAttribute] // RVA: 0x83280 Offset: 0x82680 VA: 0x180083280
	// RVA: 0x1829C60 Offset: 0x1828260 VA: 0x181829C60
	private static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunctionAttribute] // RVA: 0x833B0 Offset: 0x827B0 VA: 0x1800833B0
	// RVA: 0x1829C00 Offset: 0x1828200 VA: 0x181829C00
	private static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunctionAttribute] // RVA: 0x83510 Offset: 0x82910 VA: 0x180083510
	// RVA: 0x1829BA0 Offset: 0x18281A0 VA: 0x181829BA0
	private static void GetRenderingBuffersImpl(IntPtr nativeDisplay, out RenderBuffer color, out RenderBuffer depth) { }

	[FreeFunctionAttribute] // RVA: 0x83540 Offset: 0x82940 VA: 0x180083540
	// RVA: 0x1829EA0 Offset: 0x18284A0 VA: 0x181829EA0
	private static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry) { }

	// RVA: 0x1829FE0 Offset: 0x18285E0 VA: 0x181829FE0
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

