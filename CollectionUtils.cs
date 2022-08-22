internal static class CollectionUtils // TypeDefIndex: 5961
{
	public static bool IsNullOrEmpty<T>(ICollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D310 Offset: 0x125B910 VA: 0x18125D310
	|-CollectionUtils.IsNullOrEmpty<IXmlNode>
	|-CollectionUtils.IsNullOrEmpty<JsonConverter>
	|-CollectionUtils.IsNullOrEmpty<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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
	public static void AddRange<T>(IList<T> initial, IEnumerable collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF2F80 Offset: 0xCF1580 VA: 0x180CF2F80
	|-CollectionUtils.AddRange<object>
	|-CollectionUtils.AddRange<MemberInfo>
	*/

	public static bool IsDictionaryType(Type type) { }

	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType) { }

	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static int IndexOf<T>(IEnumerable<T> collection, Func<T, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1179860 Offset: 0x1177E60 VA: 0x181179860
	|-CollectionUtils.IndexOf<object>
	|-CollectionUtils.IndexOf<PropertyInfo>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool Contains<T>(List<T> list, T value, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D360 Offset: 0x125B960 VA: 0x18125D360
	|-CollectionUtils.Contains<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static int IndexOfReference<T>(List<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11797D0 Offset: 0x1177DD0 VA: 0x1811797D0
	|-CollectionUtils.IndexOfReference<JToken>
	|-CollectionUtils.IndexOfReference<object>
	*/

	private static IList<int> GetDimensions(IList values, int dimensionsCount) { }

	private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices) { }

	private static object JaggedArrayGetValue(IList values, int[] indices) { }

	public static Array ToMultidimensionalArray(IList values, Type type, int rank) { }

}

