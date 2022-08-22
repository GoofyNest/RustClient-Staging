public struct TransformAccessArray : IDisposable // TypeDefIndex: 3590
{	// Fields
	private IntPtr m_TransformArray; // 0x0

	// Properties
	public bool isCreated { get; }

	// Methods

	// RVA: 0x218D30 Offset: 0x218130 VA: 0x180218D30
	public void .ctor(int capacity, int desiredJobCount = -1) { }

	// RVA: 0x1900890 Offset: 0x18FEE90 VA: 0x181900890
	public static void Allocate(int capacity, int desiredJobCount, out TransformAccessArray array) { }

	// RVA: 0x218D80 Offset: 0x218180 VA: 0x180218D80
	public bool get_isCreated() { }

	// RVA: 0x218CC0 Offset: 0x2180C0 VA: 0x180218CC0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1FB6E0 Offset: 0x1FAAE0 VA: 0x1801FB6E0
	internal IntPtr GetTransformAccessArrayForSchedule() { }

	// RVA: 0x218C70 Offset: 0x218070 VA: 0x180218C70
	public void Add(Transform transform) { }

	[NativeMethodAttribute] // RVA: 0xD9400 Offset: 0xD8800 VA: 0x1800D9400
	// RVA: 0x19008E0 Offset: 0x18FEEE0 VA: 0x1819008E0
	private static IntPtr Create(int capacity, int desiredJobCount) { }

	[NativeMethodAttribute] // RVA: 0xD95B0 Offset: 0xD89B0 VA: 0x1800D95B0
	// RVA: 0x1900920 Offset: 0x18FEF20 VA: 0x181900920
	private static void DestroyTransformAccessArray(IntPtr transformArray) { }

	[NativeMethodAttribute] // RVA: 0xD96C0 Offset: 0xD8AC0 VA: 0x1800D96C0
	// RVA: 0x19007F0 Offset: 0x18FEDF0 VA: 0x1819007F0
	private static void Add(IntPtr transformArrayIntPtr, Transform transform) { }

	[NativeMethodAttribute] // RVA: 0xD97B0 Offset: 0xD8BB0 VA: 0x1800D97B0
	// RVA: 0x1900A10 Offset: 0x18FF010 VA: 0x181900A10
	internal static IntPtr GetSortedTransformAccess(IntPtr transformArrayIntPtr) { }

	[NativeMethodAttribute] // RVA: 0xD9A20 Offset: 0xD8E20 VA: 0x1800D9A20
	// RVA: 0x19009D0 Offset: 0x18FEFD0 VA: 0x1819009D0
	internal static IntPtr GetSortedToUserIndex(IntPtr transformArrayIntPtr) { }

}

