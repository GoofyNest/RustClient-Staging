internal static class CollectionUtils // TypeDefIndex: 5961
{	// Methods

	// RVA: -1 Offset: -1
	public static bool IsNullOrEmpty<T>(ICollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125CC70 Offset: 0x125B270 VA: 0x18125CC70
	|-CollectionUtils.IsNullOrEmpty<IXmlNode>
	|-CollectionUtils.IsNullOrEmpty<JsonConverter>
	|-CollectionUtils.IsNullOrEmpty<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static void AddRange<T>(IList<T> initial, IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF2B60 Offset: 0xCF1160 VA: 0x180CF2B60
	|-CollectionUtils.AddRange<JsonProperty>
	|-CollectionUtils.AddRange<SerializationCallback>
	|-CollectionUtils.AddRange<SerializationErrorCallback>
	|-CollectionUtils.AddRange<object>
	|-CollectionUtils.AddRange<MemberInfo>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static void AddRange<T>(IList<T> initial, IEnumerable collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF2AE0 Offset: 0xCF10E0 VA: 0x180CF2AE0
	|-CollectionUtils.AddRange<object>
	|-CollectionUtils.AddRange<MemberInfo>
	*/

	// RVA: 0x17FEC70 Offset: 0x17FD270 VA: 0x1817FEC70
	public static bool IsDictionaryType(Type type) { }

	// RVA: 0x17FF180 Offset: 0x17FD780 VA: 0x1817FF180
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType) { }

	// RVA: 0x17FEF40 Offset: 0x17FD540 VA: 0x1817FEF40
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static int IndexOf<T>(IEnumerable<T> collection, Func<T, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1178DF0 Offset: 0x11773F0 VA: 0x181178DF0
	|-CollectionUtils.IndexOf<object>
	|-CollectionUtils.IndexOf<PropertyInfo>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static bool Contains<T>(List<T> list, T value, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125CCC0 Offset: 0x125B2C0 VA: 0x18125CCC0
	|-CollectionUtils.Contains<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static int IndexOfReference<T>(List<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1178D60 Offset: 0x1177360 VA: 0x181178D60
	|-CollectionUtils.IndexOfReference<JToken>
	|-CollectionUtils.IndexOfReference<object>
	*/

	// RVA: 0x17FE910 Offset: 0x17FCF10 VA: 0x1817FE910
	private static IList<int> GetDimensions(IList values, int dimensionsCount) { }

	// RVA: 0x17FE6F0 Offset: 0x17FCCF0 VA: 0x1817FE6F0
	private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices) { }

	// RVA: 0x17FEE30 Offset: 0x17FD430 VA: 0x1817FEE30
	private static object JaggedArrayGetValue(IList values, int[] indices) { }

	// RVA: 0x17FF2A0 Offset: 0x17FD8A0 VA: 0x1817FF2A0
	public static Array ToMultidimensionalArray(IList values, Type type, int rank) { }

}

