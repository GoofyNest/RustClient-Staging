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

	// RVA: 0x18F7B10 Offset: 0x18F6110 VA: 0x1818F7B10
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
	|-RVA: 0x1A3B5B0 Offset: 0x1A39BB0 VA: 0x181A3B5B0
	|-NoAllocHelpers.ExtractArrayFromListT<object>
	|-NoAllocHelpers.ExtractArrayFromListT<Material>
	*/

	[FreeFunctionAttribute] // RVA: 0xC2050 Offset: 0xC1450 VA: 0x1800C2050
	// RVA: 0x18F7AD0 Offset: 0x18F60D0 VA: 0x1818F7AD0
	internal static void Internal_ResizeList(object list, int size) { }

	[FreeFunctionAttribute] // RVA: 0xC2150 Offset: 0xC1550 VA: 0x1800C2150
	// RVA: 0x18F7A90 Offset: 0x18F6090 VA: 0x1818F7A90
	public static Array ExtractArrayFromList(object list) { }

}

