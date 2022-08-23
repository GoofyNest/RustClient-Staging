public static class CollectionEx // TypeDefIndex: 11344
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool IsNullOrEmpty<T>(ICollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D410 Offset: 0x125BA10 VA: 0x18125D410
	|-CollectionEx.IsNullOrEmpty<BaseEntity>
	|-CollectionEx.IsNullOrEmpty<object>
	|-CollectionEx.IsNullOrEmpty<GameObject>
	|-CollectionEx.IsNullOrEmpty<LOD>
	|-CollectionEx.IsNullOrEmpty<Material>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool IsEmpty<T>(ICollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D3C0 Offset: 0x125B9C0 VA: 0x18125D3C0
	|-CollectionEx.IsEmpty<object>
	*/

}

