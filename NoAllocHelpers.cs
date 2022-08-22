internal sealed class NoAllocHelpers // TypeDefIndex: 3519
{	// Methods

	// RVA: -1 Offset: -1
	public static void ResizeList<T>(List<T> list, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2CF0 Offset: 0x5D12F0 VA: 0x1805D2CF0
	|-NoAllocHelpers.ResizeList<object>
	*/

	// RVA: -1 Offset: -1
	public static void EnsureListElemCount<T>(List<T> list, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2C70 Offset: 0x5D1270 VA: 0x1805D2C70
	|-NoAllocHelpers.EnsureListElemCount<object>
	|-NoAllocHelpers.EnsureListElemCount<Material>
	*/

	// RVA: 0x18F74B0 Offset: 0x18F5AB0 VA: 0x1818F74B0
	public static int SafeLength(Array values) { }

	// RVA: -1 Offset: -1
	public static int SafeLength<T>(List<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED7580 Offset: 0xED5B80 VA: 0x180ED7580
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
	|-RVA: 0x1A3AF50 Offset: 0x1A39550 VA: 0x181A3AF50
	|-NoAllocHelpers.ExtractArrayFromListT<object>
	|-NoAllocHelpers.ExtractArrayFromListT<Material>
	*/

	[FreeFunctionAttribute] // RVA: 0xC20F0 Offset: 0xC14F0 VA: 0x1800C20F0
	// RVA: 0x18F7470 Offset: 0x18F5A70 VA: 0x1818F7470
	internal static void Internal_ResizeList(object list, int size) { }

	[FreeFunctionAttribute] // RVA: 0xC21C0 Offset: 0xC15C0 VA: 0x1800C21C0
	// RVA: 0x18F7430 Offset: 0x18F5A30 VA: 0x1818F7430
	public static Array ExtractArrayFromList(object list) { }

}

