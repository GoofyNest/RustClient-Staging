internal static class CollectionUtils // TypeDefIndex: 5961
{
	public static bool IsNullOrEmpty<T>(ICollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D410 Offset: 0x125BA10 VA: 0x18125D410
	|-CollectionUtils.IsNullOrEmpty<IXmlNode>
	|-CollectionUtils.IsNullOrEmpty<JsonConverter>
	|-CollectionUtils.IsNullOrEmpty<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void AddRange<T>(IList<T> initial, IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF3100 Offset: 0xCF1700 VA: 0x180CF3100
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
	|-RVA: 0xCF3080 Offset: 0xCF1680 VA: 0x180CF3080
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
	|-RVA: 0x1179960 Offset: 0x1177F60 VA: 0x181179960
	|-CollectionUtils.IndexOf<object>
	|-CollectionUtils.IndexOf<PropertyInfo>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool Contains<T>(List<T> list, T value, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D460 Offset: 0x125BA60 VA: 0x18125D460
	|-CollectionUtils.Contains<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static int IndexOfReference<T>(List<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11798D0 Offset: 0x1177ED0 VA: 0x1811798D0
	|-CollectionUtils.IndexOfReference<JToken>
	|-CollectionUtils.IndexOfReference<object>
	*/

	private static IList<int> GetDimensions(IList values, int dimensionsCount) { }

	private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices) { }

	private static object JaggedArrayGetValue(IList values, int[] indices) { }

	public static Array ToMultidimensionalArray(IList values, Type type, int rank) { }

}

