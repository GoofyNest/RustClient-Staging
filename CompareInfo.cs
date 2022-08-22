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

	// RVA: 0x16D5D00 Offset: 0x16D4300 VA: 0x1816D5D00
	internal void .ctor(CultureInfo culture) { }

	// RVA: 0x16D4E30 Offset: 0x16D3430 VA: 0x1816D4E30
	public static CompareInfo GetCompareInfo(string name) { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE37A10 Offset: 0xE36010 VA: 0x180E37A10
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x16D5B30 Offset: 0x16D4130 VA: 0x1816D5B30
	private void OnDeserialized() { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x16D5C00 Offset: 0x16D4200 VA: 0x1816D5C00
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x16D5C10 Offset: 0x16D4210 VA: 0x1816D5C10
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x16D5C00 Offset: 0x16D4200 VA: 0x1816D5C00 Slot: 4
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x16D5D90 Offset: 0x16D4390 VA: 0x1816D5D90 Slot: 5
	public virtual string get_Name() { }

	// RVA: 0x16D4350 Offset: 0x16D2950 VA: 0x1816D4350 Slot: 6
	public virtual int Compare(string string1, string string2) { }

	// RVA: 0x16D4380 Offset: 0x16D2980 VA: 0x1816D4380 Slot: 7
	public virtual int Compare(string string1, string string2, CompareOptions options) { }

	// RVA: 0x16D44F0 Offset: 0x16D2AF0 VA: 0x1816D44F0 Slot: 8
	public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x16D42F0 Offset: 0x16D28F0 VA: 0x1816D42F0
	private static int CompareOrdinal(string string1, int offset1, int length1, string string2, int offset2, int length2) { }

	// RVA: 0x16D5510 Offset: 0x16D3B10 VA: 0x1816D5510 Slot: 9
	public virtual bool IsPrefix(string source, string prefix, CompareOptions options) { }

	// RVA: 0x16D56E0 Offset: 0x16D3CE0 VA: 0x1816D56E0 Slot: 10
	public virtual bool IsSuffix(string source, string suffix, CompareOptions options) { }

	// RVA: 0x16D51D0 Offset: 0x16D37D0 VA: 0x1816D51D0 Slot: 11
	public virtual int IndexOf(string source, string value, CompareOptions options) { }

	// RVA: 0x16D5290 Offset: 0x16D3890 VA: 0x1816D5290 Slot: 12
	public virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x16D58B0 Offset: 0x16D3EB0 VA: 0x1816D58B0 Slot: 13
	public virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x16D5040 Offset: 0x16D3640 VA: 0x1816D5040 Slot: 14
	public virtual SortKey GetSortKey(string source, CompareOptions options) { }

	// RVA: 0x16D4940 Offset: 0x16D2F40 VA: 0x1816D4940
	private SortKey CreateSortKey(string source, CompareOptions options) { }

	// RVA: 0x16D4AD0 Offset: 0x16D30D0 VA: 0x1816D4AD0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x16D5000 Offset: 0x16D3600 VA: 0x1816D5000 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x16D4EE0 Offset: 0x16D34E0 VA: 0x1816D4EE0
	internal int GetHashCodeOfString(string source, CompareOptions options) { }

	// RVA: 0x16D4EE0 Offset: 0x16D34E0 VA: 0x1816D4EE0
	internal int GetHashCodeOfString(string source, CompareOptions options, bool forceRandomizedHashing, long additionalEntropy) { }

	// RVA: 0x16D5CB0 Offset: 0x16D42B0 VA: 0x1816D5CB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x16D5E00 Offset: 0x16D4400 VA: 0x1816D5E00
	private static bool get_UseManagedCollation() { }

	// RVA: 0x16D4BA0 Offset: 0x16D31A0 VA: 0x1816D4BA0
	private SimpleCollator GetCollator() { }

	// RVA: 0x16D4860 Offset: 0x16D2E60 VA: 0x1816D4860
	private SortKey CreateSortKeyCore(string source, CompareOptions options) { }

	// RVA: 0x16D6120 Offset: 0x16D4720 VA: 0x1816D6120
	private int internal_index_switch(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	// RVA: 0x16D5F90 Offset: 0x16D4590 VA: 0x1816D5F90
	private int internal_compare_switch(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x16D5F30 Offset: 0x16D4530 VA: 0x1816D5F30
	private int internal_compare_managed(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x16D6080 Offset: 0x16D4680 VA: 0x1816D6080
	private int internal_index_managed(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	// RVA: 0x16D5D80 Offset: 0x16D4380 VA: 0x1816D5D80
	private void assign_sortkey(object key, string source, CompareOptions options) { }

	// RVA: 0x16D5F20 Offset: 0x16D4520 VA: 0x1816D5F20
	private int internal_compare(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x16D6070 Offset: 0x16D4670 VA: 0x1816D6070
	private int internal_index(string source, int sindex, int count, string value, CompareOptions options, bool first) { }

	// RVA: 0x16D5D50 Offset: 0x16D4350 VA: 0x1816D5D50
	internal void .ctor() { }

}

