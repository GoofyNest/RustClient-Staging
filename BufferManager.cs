internal static class BufferManager // TypeDefIndex: 5175
{	// Fields
	private static readonly Stack<BufferManager.ReferenceCounter> ReferenceCounterPool; // 0x0
	private static readonly Dictionary<int, Stack<IntPtr>> BufferPools; // 0x8
	private static readonly Dictionary<IntPtr, BufferManager.ReferenceCounter> ReferenceCounters; // 0x10
	private static readonly BufferManager.FreeFn FreeFunctionPin; // 0x18
	public static readonly IntPtr FreeFunctionPointer; // 0x20

	// Methods

	// RVA: 0x136BEC0 Offset: 0x136A4C0 VA: 0x18136BEC0
	public static IntPtr Get(int size, int referenceCount) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x136BB20 Offset: 0x136A120 VA: 0x18136BB20
	private static void Free(NetMsg* msg) { }

	// RVA: 0x136B340 Offset: 0x1369940 VA: 0x18136B340
	private static BufferManager.ReferenceCounter AllocateReferenceCounter(IntPtr ptr, int size, int referenceCount) { }

	// RVA: 0x136B960 Offset: 0x1369F60 VA: 0x18136B960
	private static void FreeReferenceCounter(BufferManager.ReferenceCounter counter) { }

	// RVA: 0x136B0E0 Offset: 0x13696E0 VA: 0x18136B0E0
	private static void AllocateBuffer(int minimumSize, out IntPtr ptr, out int size) { }

	// RVA: 0x136B600 Offset: 0x1369C00 VA: 0x18136B600
	private static void FreeBuffer(IntPtr ptr, int size) { }

	// RVA: 0x136BE60 Offset: 0x136A460 VA: 0x18136BE60
	private static int GetBucketSize(int size) { }

	// RVA: 0x136BE00 Offset: 0x136A400 VA: 0x18136BE00
	private static int GetBucketLimit(int size) { }

	// RVA: 0x136C0C0 Offset: 0x136A6C0 VA: 0x18136C0C0
	private static void .cctor() { }

}

private sealed class BufferManager.ReferenceCounter // TypeDefIndex: 5176
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IntPtr <Pointer>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <Size>k__BackingField; // 0x18
	private int _count; // 0x1C

	// Properties
	private IntPtr Pointer { set; }
	public int Size { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1080 Offset: 0x8BF680 VA: 0x1808C1080
	private void set_Pointer(IntPtr value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_Size() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0C80 Offset: 0x7CF280 VA: 0x1807D0C80
	private void set_Size(int value) { }

	// RVA: 0x1375870 Offset: 0x1373E70 VA: 0x181375870
	public void Set(IntPtr ptr, int size, int referenceCount) { }

	// RVA: 0x13757F0 Offset: 0x1373DF0 VA: 0x1813757F0
	public bool Decrement() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class BufferManager.FreeFn : MulticastDelegate // TypeDefIndex: 5177
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1221110 Offset: 0x121F710 VA: 0x181221110 Slot: 12
	public virtual void Invoke(NetMsg* msg) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(NetMsg* msg, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

