internal sealed class NoAllocHelpers // TypeDefIndex: 3519
{	// Methods

	// RVA: -1 Offset: -1
	public static void ResizeList<T>(List<T> list, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2D60 Offset: 0x5D1360 VA: 0x1805D2D60
	|-NoAllocHelpers.ResizeList<object>
	*/

	// RVA: -1 Offset: -1
	public static void EnsureListElemCount<T>(List<T> list, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2CE0 Offset: 0x5D12E0 VA: 0x1805D2CE0
	|-NoAllocHelpers.EnsureListElemCount<object>
	|-NoAllocHelpers.EnsureListElemCount<Material>
	*/

	// RVA: 0x18F7AD0 Offset: 0x18F60D0 VA: 0x1818F7AD0
	public static int SafeLength(Array values) { }

	// RVA: -1 Offset: -1
	public static int SafeLength<T>(List<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED6810 Offset: 0xED4E10 VA: 0x180ED6810
	|-NoAllocHelpers.SafeLength<int>
	|-NoAllocHelpers.SafeLength<object>
	|-NoAllocHelpers.SafeLength<Color32>
	|-NoAllocHelpers.SafeLength<Color>
	|-NoAllocHelpers.SafeLength<Vector2>
	|-NoAllocHelpers.SafeLength<Vector3>
	|-NoAllocHelpers.SafeLength<Vector4>
	*/

	// RVA: -1 Offset: -1
	public static T[] ExtractArrayFromListT<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B570 Offset: 0x1A39B70 VA: 0x181A3B570
	|-NoAllocHelpers.ExtractArrayFromListT<object>
	|-NoAllocHelpers.ExtractArrayFromListT<Material>
	*/

	[FreeFunctionAttribute] // RVA: 0xC20F0 Offset: 0xC14F0 VA: 0x1800C20F0
	// RVA: 0x18F7A90 Offset: 0x18F6090 VA: 0x1818F7A90
	internal static void Internal_ResizeList(object list, int size) { }

	[FreeFunctionAttribute] // RVA: 0xC21C0 Offset: 0xC15C0 VA: 0x1800C21C0
	// RVA: 0x18F7A50 Offset: 0x18F6050 VA: 0x1818F7A50
	public static Array ExtractArrayFromList(object list) { }

}

