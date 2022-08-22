internal static class BufferManager // TypeDefIndex: 5175
{	// Fields
	private static readonly Stack<BufferManager.ReferenceCounter> ReferenceCounterPool; // 0x0
	private static readonly Dictionary<int, Stack<IntPtr>> BufferPools; // 0x8
	private static readonly Dictionary<IntPtr, BufferManager.ReferenceCounter> ReferenceCounters; // 0x10
	private static readonly BufferManager.FreeFn FreeFunctionPin; // 0x18
	public static readonly IntPtr FreeFunctionPointer; // 0x20

	// Methods

	// RVA: 0x136B280 Offset: 0x1369880 VA: 0x18136B280
	public static IntPtr Get(int size, int referenceCount) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x136AEE0 Offset: 0x13694E0 VA: 0x18136AEE0
	private static void Free(NetMsg* msg) { }

	// RVA: 0x136A700 Offset: 0x1368D00 VA: 0x18136A700
	private static BufferManager.ReferenceCounter AllocateReferenceCounter(IntPtr ptr, int size, int referenceCount) { }

	// RVA: 0x136AD20 Offset: 0x1369320 VA: 0x18136AD20
	private static void FreeReferenceCounter(BufferManager.ReferenceCounter counter) { }

	// RVA: 0x136A4A0 Offset: 0x1368AA0 VA: 0x18136A4A0
	private static void AllocateBuffer(int minimumSize, out IntPtr ptr, out int size) { }

	// RVA: 0x136A9C0 Offset: 0x1368FC0 VA: 0x18136A9C0
	private static void FreeBuffer(IntPtr ptr, int size) { }

	// RVA: 0x136B220 Offset: 0x1369820 VA: 0x18136B220
	private static int GetBucketSize(int size) { }

	// RVA: 0x136B1C0 Offset: 0x13697C0 VA: 0x18136B1C0
	private static int GetBucketLimit(int size) { }

	// RVA: 0x136B480 Offset: 0x1369A80 VA: 0x18136B480
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
	// RVA: 0x8C16A0 Offset: 0x8BFCA0 VA: 0x1808C16A0
	private void set_Pointer(IntPtr value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public int get_Size() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C6B0 Offset: 0x79ACB0 VA: 0x18079C6B0
	private void set_Size(int value) { }

	// RVA: 0x1374C30 Offset: 0x1373230 VA: 0x181374C30
	public void Set(IntPtr ptr, int size, int referenceCount) { }

	// RVA: 0x1374BB0 Offset: 0x13731B0 VA: 0x181374BB0
	public bool Decrement() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class BufferManager.FreeFn : MulticastDelegate // TypeDefIndex: 5177
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1221A70 Offset: 0x1220070 VA: 0x181221A70 Slot: 12
	public virtual void Invoke(NetMsg* msg) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(NetMsg* msg, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

