public class CompareInfo : IDeserializationCallback // TypeDefIndex: 690
{	// Fields
	private const CompareOptions ValidIndexMaskOffFlags = -32;
	private const CompareOptions ValidCompareMaskOffFlags = -536870944;
	private const CompareOptions ValidHashCodeOfStringMaskOffFlags = -32;
	[OptionalFieldAttribute] // RVA: 0x92F70 Offset: 0x92370 VA: 0x180092F70
	private string m_name; // 0x10
	private string m_sortName; // 0x18
	[OptionalFieldAttribute] // RVA: 0x96510 Offset: 0x95910 VA: 0x180096510
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
	[OptionalFieldAttribute] // RVA: 0xA9B30 Offset: 0xA8F30 VA: 0x1800A9B30
	private SortVersion m_SortVersion; // 0x28
	private SimpleCollator collator; // 0x30
	private static Dictionary<string, SimpleCollator> collators; // 0x0
	private static bool managedCollation; // 0x8
	private static bool managedCollationChecked; // 0x9

	// Properties
	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	public virtual string Name { get; }
	private static bool UseManagedCollation { get; }

	// Methods

	// RVA: 0x16D7E50 Offset: 0x16D6450 VA: 0x1816D7E50
	internal void .ctor(CultureInfo culture) { }

	// RVA: 0x16D6F80 Offset: 0x16D5580 VA: 0x1816D6F80
	public static CompareInfo GetCompareInfo(string name) { }

	[OnDeserializingAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xE36CA0 Offset: 0xE352A0 VA: 0x180E36CA0
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x16D7C80 Offset: 0x16D6280 VA: 0x1816D7C80
	private void OnDeserialized() { }

	[OnDeserializedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x16D7D50 Offset: 0x16D6350 VA: 0x1816D7D50
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x16D7D60 Offset: 0x16D6360 VA: 0x1816D7D60
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x16D7D50 Offset: 0x16D6350 VA: 0x1816D7D50 Slot: 4
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x16D7EE0 Offset: 0x16D64E0 VA: 0x1816D7EE0 Slot: 5
	public virtual string get_Name() { }

	// RVA: 0x16D64A0 Offset: 0x16D4AA0 VA: 0x1816D64A0 Slot: 6
	public virtual int Compare(string string1, string string2) { }

	// RVA: 0x16D64D0 Offset: 0x16D4AD0 VA: 0x1816D64D0 Slot: 7
	public virtual int Compare(string string1, string string2, CompareOptions options) { }

	// RVA: 0x16D6640 Offset: 0x16D4C40 VA: 0x1816D6640 Slot: 8
	public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x16D6440 Offset: 0x16D4A40 VA: 0x1816D6440
	private static int CompareOrdinal(string string1, int offset1, int length1, string string2, int offset2, int length2) { }

	// RVA: 0x16D7660 Offset: 0x16D5C60 VA: 0x1816D7660 Slot: 9
	public virtual bool IsPrefix(string source, string prefix, CompareOptions options) { }

	// RVA: 0x16D7830 Offset: 0x16D5E30 VA: 0x1816D7830 Slot: 10
	public virtual bool IsSuffix(string source, string suffix, CompareOptions options) { }

	// RVA: 0x16D7320 Offset: 0x16D5920 VA: 0x1816D7320 Slot: 11
	public virtual int IndexOf(string source, string value, CompareOptions options) { }

	// RVA: 0x16D73E0 Offset: 0x16D59E0 VA: 0x1816D73E0 Slot: 12
	public virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x16D7A00 Offset: 0x16D6000 VA: 0x1816D7A00 Slot: 13
	public virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x16D7190 Offset: 0x16D5790 VA: 0x1816D7190 Slot: 14
	public virtual SortKey GetSortKey(string source, CompareOptions options) { }

	// RVA: 0x16D6A90 Offset: 0x16D5090 VA: 0x1816D6A90
	private SortKey CreateSortKey(string source, CompareOptions options) { }

	// RVA: 0x16D6C20 Offset: 0x16D5220 VA: 0x1816D6C20 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x16D7150 Offset: 0x16D5750 VA: 0x1816D7150 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x16D7030 Offset: 0x16D5630 VA: 0x1816D7030
	internal int GetHashCodeOfString(string source, CompareOptions options) { }

	// RVA: 0x16D7030 Offset: 0x16D5630 VA: 0x1816D7030
	internal int GetHashCodeOfString(string source, CompareOptions options, bool forceRandomizedHashing, long additionalEntropy) { }

	// RVA: 0x16D7E00 Offset: 0x16D6400 VA: 0x1816D7E00 Slot: 3
	public override string ToString() { }

	// RVA: 0x16D7F50 Offset: 0x16D6550 VA: 0x1816D7F50
	private static bool get_UseManagedCollation() { }

	// RVA: 0x16D6CF0 Offset: 0x16D52F0 VA: 0x1816D6CF0
	private SimpleCollator GetCollator() { }

	// RVA: 0x16D69B0 Offset: 0x16D4FB0 VA: 0x1816D69B0
	private SortKey CreateSortKeyCore(string source, CompareOptions options) { }

	// RVA: 0x16D8270 Offset: 0x16D6870 VA: 0x1816D8270
	private int internal_index_switch(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	// RVA: 0x16D80E0 Offset: 0x16D66E0 VA: 0x1816D80E0
	private int internal_compare_switch(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x16D8080 Offset: 0x16D6680 VA: 0x1816D8080
	private int internal_compare_managed(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x16D81D0 Offset: 0x16D67D0 VA: 0x1816D81D0
	private int internal_index_managed(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	// RVA: 0x16D7ED0 Offset: 0x16D64D0 VA: 0x1816D7ED0
	private void assign_sortkey(object key, string source, CompareOptions options) { }

	// RVA: 0x16D8070 Offset: 0x16D6670 VA: 0x1816D8070
	private int internal_compare(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x16D81C0 Offset: 0x16D67C0 VA: 0x1816D81C0
	private int internal_index(string source, int sindex, int count, string value, CompareOptions options, bool first) { }

	// RVA: 0x16D7EA0 Offset: 0x16D64A0 VA: 0x1816D7EA0
	internal void .ctor() { }

}
