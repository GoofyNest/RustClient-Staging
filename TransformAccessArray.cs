public struct TransformAccessArray : IDisposable // TypeDefIndex: 3590
{	private IntPtr m_TransformArray; // 0x0

	public bool isCreated { get; }


	public void .ctor(int capacity, int desiredJobCount = -1) { }

	public static void Allocate(int capacity, int desiredJobCount, out TransformAccessArray array) { }

	public bool get_isCreated() { }

	public void Dispose() { }

	internal IntPtr GetTransformAccessArrayForSchedule() { }

	public void Add(Transform transform) { }

	[NativeMethodAttribute] // RVA: 0xD9400 Offset: 0xD8800 VA: 0x1800D9400
	private static IntPtr Create(int capacity, int desiredJobCount) { }

	[NativeMethodAttribute] // RVA: 0xD95B0 Offset: 0xD89B0 VA: 0x1800D95B0
	private static void DestroyTransformAccessArray(IntPtr transformArray) { }

	[NativeMethodAttribute] // RVA: 0xD96C0 Offset: 0xD8AC0 VA: 0x1800D96C0
	private static void Add(IntPtr transformArrayIntPtr, Transform transform) { }

	[NativeMethodAttribute] // RVA: 0xD97B0 Offset: 0xD8BB0 VA: 0x1800D97B0
	internal static IntPtr GetSortedTransformAccess(IntPtr transformArrayIntPtr) { }

	[NativeMethodAttribute] // RVA: 0xD9A20 Offset: 0xD8E20 VA: 0x1800D9A20
	internal static IntPtr GetSortedToUserIndex(IntPtr transformArrayIntPtr) { }

}

