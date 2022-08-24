public struct TransformAccessArray : IDisposable // TypeDefIndex: 3590
{	private IntPtr m_TransformArray; // 0x0

	public bool isCreated { get; }


	public void .ctor(int capacity, int desiredJobCount = -1) { }

	public static void Allocate(int capacity, int desiredJobCount, out TransformAccessArray array) { }

	public bool get_isCreated() { }

	public void Dispose() { }

	internal IntPtr GetTransformAccessArrayForSchedule() { }

	public void Add(Transform transform) { }

	[NativeMethodAttribute] // RVA: 0xD9530 Offset: 0xD8930 VA: 0x1800D9530
	private static IntPtr Create(int capacity, int desiredJobCount) { }

	[NativeMethodAttribute] // RVA: 0xD96E0 Offset: 0xD8AE0 VA: 0x1800D96E0
	private static void DestroyTransformAccessArray(IntPtr transformArray) { }

	[NativeMethodAttribute] // RVA: 0xD97C0 Offset: 0xD8BC0 VA: 0x1800D97C0
	private static void Add(IntPtr transformArrayIntPtr, Transform transform) { }

	[NativeMethodAttribute] // RVA: 0xD9880 Offset: 0xD8C80 VA: 0x1800D9880
	internal static IntPtr GetSortedTransformAccess(IntPtr transformArrayIntPtr) { }

	[NativeMethodAttribute] // RVA: 0xD9B20 Offset: 0xD8F20 VA: 0x1800D9B20
	internal static IntPtr GetSortedToUserIndex(IntPtr transformArrayIntPtr) { }

}

