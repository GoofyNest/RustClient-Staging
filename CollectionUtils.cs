internal static class CollectionUtils // TypeDefIndex: 5961
{
	public static bool IsNullOrEmpty<T>(ICollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D350 Offset: 0x125B950 VA: 0x18125D350
	|-CollectionUtils.IsNullOrEmpty<IXmlNode>
	|-CollectionUtils.IsNullOrEmpty<JsonConverter>
	|-CollectionUtils.IsNullOrEmpty<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void AddRange<T>(IList<T> initial, IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF3140 Offset: 0xCF1740 VA: 0x180CF3140
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
	|-RVA: 0xCF30C0 Offset: 0xCF16C0 VA: 0x180CF30C0
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
	|-RVA: 0x11798A0 Offset: 0x1177EA0 VA: 0x1811798A0
	|-CollectionUtils.IndexOf<object>
	|-CollectionUtils.IndexOf<PropertyInfo>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool Contains<T>(List<T> list, T value, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D3A0 Offset: 0x125B9A0 VA: 0x18125D3A0
	|-CollectionUtils.Contains<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static int IndexOfReference<T>(List<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1179810 Offset: 0x1177E10 VA: 0x181179810
	|-CollectionUtils.IndexOfReference<JToken>
	|-CollectionUtils.IndexOfReference<object>
	*/

	private static IList<int> GetDimensions(IList values, int dimensionsCount) { }

	private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices) { }

	private static object JaggedArrayGetValue(IList values, int[] indices) { }

	public static Array ToMultidimensionalArray(IList values, Type type, int rank) { }

}

