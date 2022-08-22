public struct TransformAccessArray : IDisposable // TypeDefIndex: 3590
{	// Fields
	private IntPtr m_TransformArray; // 0x0

	// Properties
	public bool isCreated { get; }

	// Methods

	// RVA: 0x218660 Offset: 0x217A60 VA: 0x180218660
	public void .ctor(int capacity, int desiredJobCount = -1) { }

	// RVA: 0x1900EB0 Offset: 0x18FF4B0 VA: 0x181900EB0
	public static void Allocate(int capacity, int desiredJobCount, out TransformAccessArray array) { }

	// RVA: 0x2186B0 Offset: 0x217AB0 VA: 0x1802186B0
	public bool get_isCreated() { }

	// RVA: 0x2185F0 Offset: 0x2179F0 VA: 0x1802185F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1FBAB0 Offset: 0x1FAEB0 VA: 0x1801FBAB0
	internal IntPtr GetTransformAccessArrayForSchedule() { }

	// RVA: 0x2185A0 Offset: 0x2179A0 VA: 0x1802185A0
	public void Add(Transform transform) { }

	[NativeMethodAttribute] // RVA: 0xD9400 Offset: 0xD8800 VA: 0x1800D9400
	// RVA: 0x1900F00 Offset: 0x18FF500 VA: 0x181900F00
	private static IntPtr Create(int capacity, int desiredJobCount) { }

	[NativeMethodAttribute] // RVA: 0xD95B0 Offset: 0xD89B0 VA: 0x1800D95B0
	// RVA: 0x1900F40 Offset: 0x18FF540 VA: 0x181900F40
	private static void DestroyTransformAccessArray(IntPtr transformArray) { }

	[NativeMethodAttribute] // RVA: 0xD96C0 Offset: 0xD8AC0 VA: 0x1800D96C0
	// RVA: 0x1900E10 Offset: 0x18FF410 VA: 0x181900E10
	private static void Add(IntPtr transformArrayIntPtr, Transform transform) { }

	[NativeMethodAttribute] // RVA: 0xD97B0 Offset: 0xD8BB0 VA: 0x1800D97B0
	// RVA: 0x1901030 Offset: 0x18FF630 VA: 0x181901030
	internal static IntPtr GetSortedTransformAccess(IntPtr transformArrayIntPtr) { }

	[NativeMethodAttribute] // RVA: 0xD9A20 Offset: 0xD8E20 VA: 0x1800D9A20
	// RVA: 0x1900FF0 Offset: 0x18FF5F0 VA: 0x181900FF0
	internal static IntPtr GetSortedToUserIndex(IntPtr transformArrayIntPtr) { }

}

