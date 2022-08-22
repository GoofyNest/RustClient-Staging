public class CompareInfo : IDeserializationCallback // TypeDefIndex: 690
{	// Fields
	private const CompareOptions ValidIndexMaskOffFlags = -32;
	private const CompareOptions ValidCompareMaskOffFlags = -536870944;
	private const CompareOptions ValidHashCodeOfStringMaskOffFlags = -32;
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	private string m_name; // 0x10
	private string m_sortName; // 0x18
	[OptionalFieldAttribute] // RVA: 0x96550 Offset: 0x95950 VA: 0x180096550
	private int win32LCID; // 0x20
	private int culture; // 0x24
	private const int LINGUISTIC_IGNORECASE = 16;
	private const int NORM_IGNORECASE = 1;
	private const int NORM_IGNOREKANATYPE = 65536;
	private const int LINGUISTIC_IGNOREDIACRITIC = 32;
	private const int NORM_IGNORENONSPACE = 2;
	private const int NORM_IGNORESYMBOLS = 4;
	private const int NORM_IGNOREWIDTH = 131072;
	private const int SORT_STRINGSORT = 4096;
	private const int COMPARE_OPTIONS_ORDINAL = 1073741824;
	internal const int NORM_LINGUISTIC_CASING = 134217728;
	private const int RESERVED_FIND_ASCII_STRING = 536870912;
	private const int SORT_VERSION_WHIDBEY = 4096;
	private const int SORT_VERSION_V4 = 393473;
	[OptionalFieldAttribute] // RVA: 0xA9AF0 Offset: 0xA8EF0 VA: 0x1800A9AF0
	private SortVersion m_SortVersion; // 0x28
	private SimpleCollator collator; // 0x30
	private static Dictionary<string, SimpleCollator> collators; // 0x0
	private static bool managedCollation; // 0x8
	private static bool managedCollationChecked; // 0x9

	// Properties
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public virtual string Name { get; }
	private static bool UseManagedCollation { get; }

	// Methods

	// RVA: 0x16D8110 Offset: 0x16D6710 VA: 0x1816D8110
	internal void .ctor(CultureInfo culture) { }

	// RVA: 0x16D7240 Offset: 0x16D5840 VA: 0x1816D7240
	public static CompareInfo GetCompareInfo(string name) { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE36F60 Offset: 0xE35560 VA: 0x180E36F60
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x16D7F40 Offset: 0x16D6540 VA: 0x1816D7F40
	private void OnDeserialized() { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x16D8010 Offset: 0x16D6610 VA: 0x1816D8010
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x16D8020 Offset: 0x16D6620 VA: 0x1816D8020
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x16D8010 Offset: 0x16D6610 VA: 0x1816D8010 Slot: 4
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x16D81A0 Offset: 0x16D67A0 VA: 0x1816D81A0 Slot: 5
	public virtual string get_Name() { }

	// RVA: 0x16D6760 Offset: 0x16D4D60 VA: 0x1816D6760 Slot: 6
	public virtual int Compare(string string1, string string2) { }

	// RVA: 0x16D6790 Offset: 0x16D4D90 VA: 0x1816D6790 Slot: 7
	public virtual int Compare(string string1, string string2, CompareOptions options) { }

	// RVA: 0x16D6900 Offset: 0x16D4F00 VA: 0x1816D6900 Slot: 8
	public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x16D6700 Offset: 0x16D4D00 VA: 0x1816D6700
	private static int CompareOrdinal(string string1, int offset1, int length1, string string2, int offset2, int length2) { }

	// RVA: 0x16D7920 Offset: 0x16D5F20 VA: 0x1816D7920 Slot: 9
	public virtual bool IsPrefix(string source, string prefix, CompareOptions options) { }

	// RVA: 0x16D7AF0 Offset: 0x16D60F0 VA: 0x1816D7AF0 Slot: 10
	public virtual bool IsSuffix(string source, string suffix, CompareOptions options) { }

	// RVA: 0x16D75E0 Offset: 0x16D5BE0 VA: 0x1816D75E0 Slot: 11
	public virtual int IndexOf(string source, string value, CompareOptions options) { }

	// RVA: 0x16D76A0 Offset: 0x16D5CA0 VA: 0x1816D76A0 Slot: 12
	public virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x16D7CC0 Offset: 0x16D62C0 VA: 0x1816D7CC0 Slot: 13
	public virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x16D7450 Offset: 0x16D5A50 VA: 0x1816D7450 Slot: 14
	public virtual SortKey GetSortKey(string source, CompareOptions options) { }

	// RVA: 0x16D6D50 Offset: 0x16D5350 VA: 0x1816D6D50
	private SortKey CreateSortKey(string source, CompareOptions options) { }

	// RVA: 0x16D6EE0 Offset: 0x16D54E0 VA: 0x1816D6EE0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x16D7410 Offset: 0x16D5A10 VA: 0x1816D7410 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x16D72F0 Offset: 0x16D58F0 VA: 0x1816D72F0
	internal int GetHashCodeOfString(string source, CompareOptions options) { }

	// RVA: 0x16D72F0 Offset: 0x16D58F0 VA: 0x1816D72F0
	internal int GetHashCodeOfString(string source, CompareOptions options, bool forceRandomizedHashing, long additionalEntropy) { }

	// RVA: 0x16D80C0 Offset: 0x16D66C0 VA: 0x1816D80C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x16D8210 Offset: 0x16D6810 VA: 0x1816D8210
	private static bool get_UseManagedCollation() { }

	// RVA: 0x16D6FB0 Offset: 0x16D55B0 VA: 0x1816D6FB0
	private SimpleCollator GetCollator() { }

	// RVA: 0x16D6C70 Offset: 0x16D5270 VA: 0x1816D6C70
	private SortKey CreateSortKeyCore(string source, CompareOptions options) { }

	// RVA: 0x16D8530 Offset: 0x16D6B30 VA: 0x1816D8530
	private int internal_index_switch(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	// RVA: 0x16D83A0 Offset: 0x16D69A0 VA: 0x1816D83A0
	private int internal_compare_switch(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x16D8340 Offset: 0x16D6940 VA: 0x1816D8340
	private int internal_compare_managed(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x16D8490 Offset: 0x16D6A90 VA: 0x1816D8490
	private int internal_index_managed(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	// RVA: 0x16D8190 Offset: 0x16D6790 VA: 0x1816D8190
	private void assign_sortkey(object key, string source, CompareOptions options) { }

	// RVA: 0x16D8330 Offset: 0x16D6930 VA: 0x1816D8330
	private int internal_compare(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x16D8480 Offset: 0x16D6A80 VA: 0x1816D8480
	private int internal_index(string source, int sindex, int count, string value, CompareOptions options, bool first) { }

	// RVA: 0x16D8160 Offset: 0x16D6760 VA: 0x1816D8160
	internal void .ctor() { }

}

