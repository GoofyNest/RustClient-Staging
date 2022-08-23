public static class CollectionExtensions // TypeDefIndex: 1442
{
[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
public static class CollectionExtensions // TypeDefIndex: 1442

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TValue GetValueOrDefault<TKey, TValue>(IReadOnlyDictionary<TKey, TValue> dictionary, TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF1920 Offset: 0xBEFF20 VA: 0x180BF1920
	|-CollectionExtensions.GetValueOrDefault<object, object>
	|-CollectionExtensions.GetValueOrDefault<string, LocalDataStoreSlot>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TValue GetValueOrDefault<TKey, TValue>(IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159DB90 Offset: 0x159C190 VA: 0x18159DB90
	|-CollectionExtensions.GetValueOrDefault<object, object>
	*/

}

internal static class CollectionExtensions // TypeDefIndex: 5760
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool SequenceEqual<TSource>(List<TSource> first, List<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEEEC0 Offset: 0xBED4C0 VA: 0x180BEEEC0
	|-CollectionExtensions.SequenceEqual<NameValueHeaderValue>
	|-CollectionExtensions.SequenceEqual<RangeItemHeaderValue>
	|-CollectionExtensions.SequenceEqual<object>
	|-CollectionExtensions.SequenceEqual<string>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void SetValue(List<NameValueHeaderValue> parameters, string key, string value) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static string ToString<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED2380 Offset: 0xED0980 VA: 0x180ED2380
	|-CollectionExtensions.ToString<NameValueHeaderValue>
	|-CollectionExtensions.ToString<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void ToStringBuilder<T>(List<T> list, StringBuilder sb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE007E0 Offset: 0xDFEDE0 VA: 0x180E007E0
	|-CollectionExtensions.ToStringBuilder<NameValueHeaderValue>
	|-CollectionExtensions.ToStringBuilder<object>
	|-CollectionExtensions.ToStringBuilder<string>
	*/

}

