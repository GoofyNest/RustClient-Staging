public static class CollectionExtensions // TypeDefIndex: 1442
{
// Namespace: System.Collections.Generic
[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
public static class CollectionExtensions // TypeDefIndex: 1442
	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static TValue GetValueOrDefault<TKey, TValue>(IReadOnlyDictionary<TKey, TValue> dictionary, TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF1310 Offset: 0xBEF910 VA: 0x180BF1310
	|-CollectionExtensions.GetValueOrDefault<object, object>
	|-CollectionExtensions.GetValueOrDefault<string, LocalDataStoreSlot>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static TValue GetValueOrDefault<TKey, TValue>(IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159E980 Offset: 0x159CF80 VA: 0x18159E980
	|-CollectionExtensions.GetValueOrDefault<object, object>
	*/

}

internal static class CollectionExtensions // TypeDefIndex: 5760
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static bool SequenceEqual<TSource>(List<TSource> first, List<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEE8B0 Offset: 0xBECEB0 VA: 0x180BEE8B0
	|-CollectionExtensions.SequenceEqual<NameValueHeaderValue>
	|-CollectionExtensions.SequenceEqual<RangeItemHeaderValue>
	|-CollectionExtensions.SequenceEqual<object>
	|-CollectionExtensions.SequenceEqual<string>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1086930 Offset: 0x1084F30 VA: 0x181086930
	public static void SetValue(List<NameValueHeaderValue> parameters, string key, string value) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static string ToString<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED1790 Offset: 0xECFD90 VA: 0x180ED1790
	|-CollectionExtensions.ToString<NameValueHeaderValue>
	|-CollectionExtensions.ToString<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static void ToStringBuilder<T>(List<T> list, StringBuilder sb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDFFBF0 Offset: 0xDFE1F0 VA: 0x180DFFBF0
	|-CollectionExtensions.ToStringBuilder<NameValueHeaderValue>
	|-CollectionExtensions.ToStringBuilder<object>
	|-CollectionExtensions.ToStringBuilder<string>
	*/

}

