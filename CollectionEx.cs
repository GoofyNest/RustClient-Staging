public static class CollectionEx // TypeDefIndex: 11348
{
	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool IsNullOrEmpty<T>(ICollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-CollectionEx.IsNullOrEmpty<BaseEntity>
	|-CollectionEx.IsNullOrEmpty<object>
	|-CollectionEx.IsNullOrEmpty<GameObject>
	|-CollectionEx.IsNullOrEmpty<LOD>
	|-CollectionEx.IsNullOrEmpty<Material>
	*/

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool IsEmpty<T>(ICollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-CollectionEx.IsEmpty<object>
	*/

}

