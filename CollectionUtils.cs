internal static class CollectionUtils // TypeDefIndex: 5961
{	// Methods

	// RVA: -1 Offset: -1
	public static bool IsNullOrEmpty<T>(ICollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D310 Offset: 0x125B910 VA: 0x18125D310
	|-CollectionUtils.IsNullOrEmpty<IXmlNode>
	|-CollectionUtils.IsNullOrEmpty<JsonConverter>
	|-CollectionUtils.IsNullOrEmpty<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static void AddRange<T>(IList<T> initial, IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF3000 Offset: 0xCF1600 VA: 0x180CF3000
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
	|-RVA: 0xCF2F80 Offset: 0xCF1580 VA: 0x180CF2F80
	|-CollectionUtils.AddRange<object>
	|-CollectionUtils.AddRange<MemberInfo>
	*/

	// RVA: 0x17EC0B0 Offset: 0x17EA6B0 VA: 0x1817EC0B0
	public static bool IsDictionaryType(Type type) { }

	// RVA: 0x17EC5C0 Offset: 0x17EABC0 VA: 0x1817EC5C0
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType) { }

	// RVA: 0x17EC380 Offset: 0x17EA980 VA: 0x1817EC380
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static int IndexOf<T>(IEnumerable<T> collection, Func<T, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1179860 Offset: 0x1177E60 VA: 0x181179860
	|-CollectionUtils.IndexOf<object>
	|-CollectionUtils.IndexOf<PropertyInfo>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static bool Contains<T>(List<T> list, T value, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D360 Offset: 0x125B960 VA: 0x18125D360
	|-CollectionUtils.Contains<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static int IndexOfReference<T>(List<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11797D0 Offset: 0x1177DD0 VA: 0x1811797D0
	|-CollectionUtils.IndexOfReference<JToken>
	|-CollectionUtils.IndexOfReference<object>
	*/

	// RVA: 0x17EBD50 Offset: 0x17EA350 VA: 0x1817EBD50
	private static IList<int> GetDimensions(IList values, int dimensionsCount) { }

	// RVA: 0x17EBB30 Offset: 0x17EA130 VA: 0x1817EBB30
	private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices) { }

	// RVA: 0x17EC270 Offset: 0x17EA870 VA: 0x1817EC270
	private static object JaggedArrayGetValue(IList values, int[] indices) { }

	// RVA: 0x17EC6E0 Offset: 0x17EACE0 VA: 0x1817EC6E0
	public static Array ToMultidimensionalArray(IList values, Type type, int rank) { }

}

