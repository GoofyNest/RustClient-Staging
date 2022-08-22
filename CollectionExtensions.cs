public static class CollectionExtensions // TypeDefIndex: 1442
{
[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
public static class CollectionExtensions // TypeDefIndex: 1442

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TValue GetValueOrDefault<TKey, TValue>(IReadOnlyDictionary<TKey, TValue> dictionary, TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF17E0 Offset: 0xBEFDE0 VA: 0x180BF17E0
	|-CollectionExtensions.GetValueOrDefault<object, object>
	|-CollectionExtensions.GetValueOrDefault<string, LocalDataStoreSlot>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TValue GetValueOrDefault<TKey, TValue>(IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159DA50 Offset: 0x159C050 VA: 0x18159DA50
	|-CollectionExtensions.GetValueOrDefault<object, object>
	*/

}

internal static class CollectionExtensions // TypeDefIndex: 5760
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool SequenceEqual<TSource>(List<TSource> first, List<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEED80 Offset: 0xBED380 VA: 0x180BEED80
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
	|-RVA: 0xED2240 Offset: 0xED0840 VA: 0x180ED2240
	|-CollectionExtensions.ToString<NameValueHeaderValue>
	|-CollectionExtensions.ToString<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void ToStringBuilder<T>(List<T> list, StringBuilder sb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE006A0 Offset: 0xDFECA0 VA: 0x180E006A0
	|-CollectionExtensions.ToStringBuilder<NameValueHeaderValue>
	|-CollectionExtensions.ToStringBuilder<object>
	|-CollectionExtensions.ToStringBuilder<string>
	*/

}

