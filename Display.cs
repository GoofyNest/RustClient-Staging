public class Display // TypeDefIndex: 3383
{	internal IntPtr nativeDisplay; // 0x10
	public static Display[] displays; // 0x0
	private static Display _mainDisplay; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	[CompilerGeneratedAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
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

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void RecreateDisplayList(IntPtr[] nativeDisplay) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void FireDisplaysUpdated() { }

	[FreeFunctionAttribute] // RVA: 0x83310 Offset: 0x82710 VA: 0x180083310
	private static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunctionAttribute] // RVA: 0x83440 Offset: 0x82840 VA: 0x180083440
	private static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunctionAttribute] // RVA: 0x835A0 Offset: 0x829A0 VA: 0x1800835A0
	private static void GetRenderingBuffersImpl(IntPtr nativeDisplay, out RenderBuffer color, out RenderBuffer depth) { }

	[FreeFunctionAttribute] // RVA: 0x83610 Offset: 0x82A10 VA: 0x180083610
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

