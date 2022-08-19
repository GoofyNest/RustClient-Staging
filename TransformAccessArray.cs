public struct TransformAccessArray : IDisposable // TypeDefIndex: 3590
{	// Fields
	private IntPtr m_TransformArray; // 0x0

	// Properties
	public bool isCreated { get; }

	// Methods

	// RVA: 0x2186E0 Offset: 0x217AE0 VA: 0x1802186E0
	public void .ctor(int capacity, int desiredJobCount = -1) { }

	// RVA: 0x1900EF0 Offset: 0x18FF4F0 VA: 0x181900EF0
	public static void Allocate(int capacity, int desiredJobCount, out TransformAccessArray array) { }

	// RVA: 0x218730 Offset: 0x217B30 VA: 0x180218730
	public bool get_isCreated() { }

	// RVA: 0x218670 Offset: 0x217A70 VA: 0x180218670 Slot: 4
	public void Dispose() { }

	// RVA: 0x1FBB30 Offset: 0x1FAF30 VA: 0x1801FBB30
	internal IntPtr GetTransformAccessArrayForSchedule() { }

	// RVA: 0x218620 Offset: 0x217A20 VA: 0x180218620
	public void Add(Transform transform) { }

	[NativeMethodAttribute] // RVA: 0xD9390 Offset: 0xD8790 VA: 0x1800D9390
	// RVA: 0x1900F40 Offset: 0x18FF540 VA: 0x181900F40
	private static IntPtr Create(int capacity, int desiredJobCount) { }

	[NativeMethodAttribute] // RVA: 0xD9540 Offset: 0xD8940 VA: 0x1800D9540
	// RVA: 0x1900F80 Offset: 0x18FF580 VA: 0x181900F80
	private static void DestroyTransformAccessArray(IntPtr transformArray) { }

	[NativeMethodAttribute] // RVA: 0xD9660 Offset: 0xD8A60 VA: 0x1800D9660
	// RVA: 0x1900E50 Offset: 0x18FF450 VA: 0x181900E50
	private static void Add(IntPtr transformArrayIntPtr, Transform transform) { }

	[NativeMethodAttribute] // RVA: 0xD9770 Offset: 0xD8B70 VA: 0x1800D9770
	// RVA: 0x1901070 Offset: 0x18FF670 VA: 0x181901070
	internal static IntPtr GetSortedTransformAccess(IntPtr transformArrayIntPtr) { }

	[NativeMethodAttribute] // RVA: 0xD99D0 Offset: 0xD8DD0 VA: 0x1800D99D0
	// RVA: 0x1901030 Offset: 0x18FF630 VA: 0x181901030
	internal static IntPtr GetSortedToUserIndex(IntPtr transformArrayIntPtr) { }

}

