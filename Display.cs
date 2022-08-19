public class Display // TypeDefIndex: 3383
{	// Fields
	internal IntPtr nativeDisplay; // 0x10
	public static Display[] displays; // 0x0
	private static Display _mainDisplay; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private static Display.DisplaysUpdatedDelegate onDisplaysUpdated; // 0x10

	// Properties
	public int renderingWidth { get; }
	public int renderingHeight { get; }
	public int systemWidth { get; }
	public int systemHeight { get; }
	public RenderBuffer colorBuffer { get; }
	public static Display main { get; }

	// Methods

	// RVA: 0x1829EC0 Offset: 0x18284C0 VA: 0x181829EC0
	internal void .ctor() { }

	// RVA: 0x1829F00 Offset: 0x1828500 VA: 0x181829F00
	internal void .ctor(IntPtr nativeDisplay) { }

	// RVA: 0x182A0D0 Offset: 0x18286D0 VA: 0x18182A0D0
	public int get_renderingWidth() { }

	// RVA: 0x182A040 Offset: 0x1828640 VA: 0x18182A040
	public int get_renderingHeight() { }

	// RVA: 0x182A1F0 Offset: 0x18287F0 VA: 0x18182A1F0
	public int get_systemWidth() { }

	// RVA: 0x182A160 Offset: 0x1828760 VA: 0x18182A160
	public int get_systemHeight() { }

	// RVA: 0x1829F30 Offset: 0x1828530 VA: 0x181829F30
	public RenderBuffer get_colorBuffer() { }

	// RVA: 0x1829C80 Offset: 0x1828280 VA: 0x181829C80
	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) { }

	// RVA: 0x1829FE0 Offset: 0x18285E0 VA: 0x181829FE0
	public static Display get_main() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1829A40 Offset: 0x1828040 VA: 0x181829A40
	private static void RecreateDisplayList(IntPtr[] nativeDisplay) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x18296F0 Offset: 0x1827CF0 VA: 0x1818296F0
	private static void FireDisplaysUpdated() { }

	[FreeFunctionAttribute] // RVA: 0x831C0 Offset: 0x825C0 VA: 0x1800831C0
	// RVA: 0x18299E0 Offset: 0x1827FE0 VA: 0x1818299E0
	private static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunctionAttribute] // RVA: 0x83340 Offset: 0x82740 VA: 0x180083340
	// RVA: 0x1829980 Offset: 0x1827F80 VA: 0x181829980
	private static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunctionAttribute] // RVA: 0x834A0 Offset: 0x828A0 VA: 0x1800834A0
	// RVA: 0x1829920 Offset: 0x1827F20 VA: 0x181829920
	private static void GetRenderingBuffersImpl(IntPtr nativeDisplay, out RenderBuffer color, out RenderBuffer depth) { }

	[FreeFunctionAttribute] // RVA: 0x834D0 Offset: 0x828D0 VA: 0x1800834D0
	// RVA: 0x1829C20 Offset: 0x1828220 VA: 0x181829C20
	private static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry) { }

	// RVA: 0x1829D60 Offset: 0x1828360 VA: 0x181829D60
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

