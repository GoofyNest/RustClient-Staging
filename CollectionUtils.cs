internal static class CollectionUtils // TypeDefIndex: 5961
{	// Methods

	// RVA: -1 Offset: -1
	public static bool IsNullOrEmpty<T>(ICollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125C9B0 Offset: 0x125AFB0 VA: 0x18125C9B0
	|-CollectionUtils.IsNullOrEmpty<IXmlNode>
	|-CollectionUtils.IsNullOrEmpty<JsonConverter>
	|-CollectionUtils.IsNullOrEmpty<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static void AddRange<T>(IList<T> initial, IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF28A0 Offset: 0xCF0EA0 VA: 0x180CF28A0
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
	|-RVA: 0xCF2820 Offset: 0xCF0E20 VA: 0x180CF2820
	|-CollectionUtils.AddRange<object>
	|-CollectionUtils.AddRange<MemberInfo>
	*/

	// RVA: 0x17FE9B0 Offset: 0x17FCFB0 VA: 0x1817FE9B0
	public static bool IsDictionaryType(Type type) { }

	// RVA: 0x17FEEC0 Offset: 0x17FD4C0 VA: 0x1817FEEC0
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType) { }

	// RVA: 0x17FEC80 Offset: 0x17FD280 VA: 0x1817FEC80
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static int IndexOf<T>(IEnumerable<T> collection, Func<T, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1178B30 Offset: 0x1177130 VA: 0x181178B30
	|-CollectionUtils.IndexOf<object>
	|-CollectionUtils.IndexOf<PropertyInfo>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static bool Contains<T>(List<T> list, T value, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125CA00 Offset: 0x125B000 VA: 0x18125CA00
	|-CollectionUtils.Contains<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static int IndexOfReference<T>(List<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1178AA0 Offset: 0x11770A0 VA: 0x181178AA0
	|-CollectionUtils.IndexOfReference<JToken>
	|-CollectionUtils.IndexOfReference<object>
	*/

	// RVA: 0x17FE650 Offset: 0x17FCC50 VA: 0x1817FE650
	private static IList<int> GetDimensions(IList values, int dimensionsCount) { }

	// RVA: 0x17FE430 Offset: 0x17FCA30 VA: 0x1817FE430
	private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices) { }

	// RVA: 0x17FEB70 Offset: 0x17FD170 VA: 0x1817FEB70
	private static object JaggedArrayGetValue(IList values, int[] indices) { }

	// RVA: 0x17FEFE0 Offset: 0x17FD5E0 VA: 0x1817FEFE0
	public static Array ToMultidimensionalArray(IList values, Type type, int rank) { }

}

