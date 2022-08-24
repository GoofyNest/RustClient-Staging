internal sealed class NoAllocHelpers // TypeDefIndex: 3519
{
	public static void ResizeList<T>(List<T> list, int size) { }
	/* GenericInstMethod :
	|
	|-NoAllocHelpers.ResizeList<object>
	*/

	public static void EnsureListElemCount<T>(List<T> list, int count) { }
	/* GenericInstMethod :
	|
	|-NoAllocHelpers.EnsureListElemCount<object>
	|-NoAllocHelpers.EnsureListElemCount<Material>
	*/

	public static int SafeLength(Array values) { }

	public static int SafeLength<T>(List<T> values) { }
	/* GenericInstMethod :
	|
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
	|-NoAllocHelpers.ExtractArrayFromListT<object>
	|-NoAllocHelpers.ExtractArrayFromListT<Material>
	*/

	[FreeFunctionAttribute] // RVA: 0xC23D0 Offset: 0xC17D0 VA: 0x1800C23D0
	internal static void Internal_ResizeList(object list, int size) { }

	[FreeFunctionAttribute] // RVA: 0xC2540 Offset: 0xC1940 VA: 0x1800C2540
	public static Array ExtractArrayFromList(object list) { }

}

