public struct TransformAccessArray : IDisposable // TypeDefIndex: 3590
{	private IntPtr m_TransformArray; // 0x0

	public bool isCreated { get; }


	public void .ctor(int capacity, int desiredJobCount = -1) { }

	public static void Allocate(int capacity, int desiredJobCount, out TransformAccessArray array) { }

	public bool get_isCreated() { }

	public void Dispose() { }

	internal IntPtr GetTransformAccessArrayForSchedule() { }

	public void Add(Transform transform) { }

	[NativeMethodAttribute] // RVA: 0xD94F0 Offset: 0xD88F0 VA: 0x1800D94F0
	private static IntPtr Create(int capacity, int desiredJobCount) { }

	[NativeMethodAttribute] // RVA: 0xD9700 Offset: 0xD8B00 VA: 0x1800D9700
	private static void DestroyTransformAccessArray(IntPtr transformArray) { }

	[NativeMethodAttribute] // RVA: 0xD9840 Offset: 0xD8C40 VA: 0x1800D9840
	private static void Add(IntPtr transformArrayIntPtr, Transform transform) { }

	[NativeMethodAttribute] // RVA: 0xD9960 Offset: 0xD8D60 VA: 0x1800D9960
	internal static IntPtr GetSortedTransformAccess(IntPtr transformArrayIntPtr) { }

	[NativeMethodAttribute] // RVA: 0xD9BA0 Offset: 0xD8FA0 VA: 0x1800D9BA0
	internal static IntPtr GetSortedToUserIndex(IntPtr transformArrayIntPtr) { }

}

