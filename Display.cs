public class Display // TypeDefIndex: 3383
{	internal IntPtr nativeDisplay; // 0x10
	public static Display[] displays; // 0x0
	private static Display _mainDisplay; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static Display.DisplaysUpdatedDelegate onDisplaysUpdated; // 0x10

	public int renderingWidth { get; }
	public int renderingHeight { get; }
	public int systemWidth { get; }
	public int systemHeight { get; }
	public RenderBuffer colorBuffer { get; }
	public static Display main { get; }


	internal void .ctor() { }

	internal void .ctor(IntPtr nativeDisplay) { }

	public int get_renderingWidth() { }

	public int get_renderingHeight() { }

	public int get_systemWidth() { }

	public int get_systemHeight() { }

	public RenderBuffer get_colorBuffer() { }

	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) { }

	public static Display get_main() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void RecreateDisplayList(IntPtr[] nativeDisplay) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void FireDisplaysUpdated() { }

	[FreeFunctionAttribute] // RVA: 0x83280 Offset: 0x82680 VA: 0x180083280
	private static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunctionAttribute] // RVA: 0x833B0 Offset: 0x827B0 VA: 0x1800833B0
	private static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunctionAttribute] // RVA: 0x83510 Offset: 0x82910 VA: 0x180083510
	private static void GetRenderingBuffersImpl(IntPtr nativeDisplay, out RenderBuffer color, out RenderBuffer depth) { }

	[FreeFunctionAttribute] // RVA: 0x83540 Offset: 0x82940 VA: 0x180083540
	private static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry) { }

	private static void .cctor() { }

}

public sealed class Display.DisplaysUpdatedDelegate : MulticastDelegate // TypeDefIndex: 3384
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

