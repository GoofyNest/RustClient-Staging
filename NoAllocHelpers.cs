internal sealed class NoAllocHelpers // TypeDefIndex: 3519
{
	public static void ResizeList<T>(List<T> list, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2DC0 Offset: 0x5D13C0 VA: 0x1805D2DC0
	|-NoAllocHelpers.ResizeList<object>
	*/

	public static void EnsureListElemCount<T>(List<T> list, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2D40 Offset: 0x5D1340 VA: 0x1805D2D40
	|-NoAllocHelpers.EnsureListElemCount<object>
	|-NoAllocHelpers.EnsureListElemCount<Material>
	*/

	public static int SafeLength(Array values) { }

	public static int SafeLength<T>(List<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED7680 Offset: 0xED5C80 VA: 0x180ED7680
	|-NoAllocHelpers.SafeLength<int>
	|-NoAllocHelpers.SafeLength<object>
	|-NoAllocHelpers.SafeLength<Color32>
	|-NoAllocHelpers.SafeLength<Color>
	|-NoAllocHelpers.SafeLength<Vector2>
	|-NoAllocHelpers.SafeLength<Vector3>
	|-NoAllocHelpers.SafeLength<Vector4>
	*/

	public static T[] ExtractArrayFromListT<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B050 Offset: 0x1A39650 VA: 0x181A3B050
	|-NoAllocHelpers.ExtractArrayFromListT<object>
	|-NoAllocHelpers.ExtractArrayFromListT<Material>
	*/

	[FreeFunctionAttribute] // RVA: 0xC20F0 Offset: 0xC14F0 VA: 0x1800C20F0
	internal static void Internal_ResizeList(object list, int size) { }

	[FreeFunctionAttribute] // RVA: 0xC21C0 Offset: 0xC15C0 VA: 0x1800C21C0
	public static Array ExtractArrayFromList(object list) { }

}

