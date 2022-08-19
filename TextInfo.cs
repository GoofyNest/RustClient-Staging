public class TextInfo : ICloneable, IDeserializationCallback // TypeDefIndex: 719
{	// Fields
	[OptionalFieldAttribute] // RVA: 0x92F70 Offset: 0x92370 VA: 0x180092F70
	private string m_listSeparator; // 0x10
	[OptionalFieldAttribute] // RVA: 0x92F70 Offset: 0x92370 VA: 0x180092F70
	private bool m_isReadOnly; // 0x18
	[OptionalFieldAttribute] // RVA: 0xA9B30 Offset: 0xA8F30 VA: 0x1800A9B30
	private string m_cultureName; // 0x20
	private CultureData m_cultureData; // 0x28
	private string m_textInfoName; // 0x30
	private Nullable<bool> m_IsAsciiCasingSameAsInvariant; // 0x38
	internal static TextInfo s_Invariant; // 0x0
	[OptionalFieldAttribute] // RVA: 0x92F70 Offset: 0x92370 VA: 0x180092F70
	private string customCultureName; // 0x40
	[OptionalFieldAttribute] // RVA: 0x96510 Offset: 0x95910 VA: 0x180096510
	internal int m_nDataItem; // 0x48
	[OptionalFieldAttribute] // RVA: 0x96510 Offset: 0x95910 VA: 0x180096510
	internal bool m_useUserOverride; // 0x4C
	[OptionalFieldAttribute] // RVA: 0x96510 Offset: 0x95910 VA: 0x180096510
	internal int m_win32LangID; // 0x50
	private const int wordSeparatorMask = 536672256;

	// Properties
	internal static TextInfo Invariant { get; }
	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	public string CultureName { get; }
	private bool IsAsciiCasingSameAsInvariant { get; }

	// Methods

	// RVA: 0x1389FE0 Offset: 0x13885E0 VA: 0x181389FE0
	internal static TextInfo get_Invariant() { }

	// RVA: 0x1389F30 Offset: 0x1388530 VA: 0x181389F30
	internal void .ctor(CultureData cultureData) { }

	[OnDeserializingAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1388B60 Offset: 0x1387160 VA: 0x181388B60
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x1388A20 Offset: 0x1387020 VA: 0x181388A20
	private void OnDeserialized() { }

	[OnDeserializedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1388B50 Offset: 0x1387150 VA: 0x181388B50
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1388BA0 Offset: 0x13871A0 VA: 0x181388BA0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x1388470 Offset: 0x1386A70 VA: 0x181388470
	internal static int GetHashCodeOrdinalIgnoreCase(string s) { }

	// RVA: 0x1388330 Offset: 0x1386930 VA: 0x181388330
	internal static int GetHashCodeOrdinalIgnoreCase(string s, bool forceRandomizedHashing, long additionalEntropy) { }

	// RVA: 0x1388060 Offset: 0x1386660 VA: 0x181388060
	internal static int CompareOrdinalIgnoreCase(string str1, string str2) { }

	// RVA: 0x1388050 Offset: 0x1386650 VA: 0x181388050
	internal static int CompareOrdinalIgnoreCaseEx(string strA, int indexA, string strB, int indexB, int lengthA, int lengthB) { }

	// RVA: 0x13886C0 Offset: 0x1386CC0 VA: 0x1813886C0
	internal static int IndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count) { }

	// RVA: 0x1388960 Offset: 0x1386F60 VA: 0x181388960
	internal static int LastIndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_CultureName() { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x1387F80 Offset: 0x1386580 VA: 0x181387F80 Slot: 6
	public virtual object Clone() { }

	// RVA: 0x95FA00 Offset: 0x95E000 VA: 0x18095FA00
	internal void SetReadOnlyState(bool readOnly) { }

	// RVA: 0x13893A0 Offset: 0x13879A0 VA: 0x1813893A0 Slot: 7
	public virtual char ToLower(char c) { }

	// RVA: 0x1389400 Offset: 0x1387A00 VA: 0x181389400 Slot: 8
	public virtual string ToLower(string str) { }

	// RVA: 0x1388C40 Offset: 0x1387240 VA: 0x181388C40
	private static char ToLowerAsciiInvariant(char c) { }

	// RVA: 0x1389ED0 Offset: 0x13884D0 VA: 0x181389ED0 Slot: 9
	public virtual char ToUpper(char c) { }

	// RVA: 0x1389DA0 Offset: 0x13883A0 VA: 0x181389DA0 Slot: 10
	public virtual string ToUpper(string str) { }

	// RVA: 0x1389580 Offset: 0x1387B80 VA: 0x181389580
	private static char ToUpperAsciiInvariant(char c) { }

	// RVA: 0x1388950 Offset: 0x1386F50 VA: 0x181388950
	private static bool IsAscii(char c) { }

	// RVA: 0x138A0E0 Offset: 0x13886E0 VA: 0x18138A0E0
	private bool get_IsAsciiCasingSameAsInvariant() { }

	// RVA: 0x13880A0 Offset: 0x13866A0 VA: 0x1813880A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xE6B5D0 Offset: 0xE69BD0 VA: 0x180E6B5D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1389530 Offset: 0x1387B30 VA: 0x181389530 Slot: 3
	public override string ToString() { }

	// RVA: 0x1388B50 Offset: 0x1387150 VA: 0x181388B50 Slot: 5
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x1388310 Offset: 0x1386910 VA: 0x181388310
	internal int GetCaseInsensitiveHashCode(string str) { }

	// RVA: 0x1388140 Offset: 0x1386740 VA: 0x181388140
	internal int GetCaseInsensitiveHashCode(string str, bool forceRandomizedHashing, long additionalEntropy) { }

	// RVA: 0x13885A0 Offset: 0x1386BA0 VA: 0x1813885A0
	private int GetInvariantCaseInsensitiveHashCode(string str) { }

	// RVA: 0x1389CB0 Offset: 0x13882B0 VA: 0x181389CB0
	private string ToUpperInternal(string str) { }

	// RVA: 0x1388C60 Offset: 0x1387260 VA: 0x181388C60
	private string ToLowerInternal(string str) { }

	// RVA: 0x13895A0 Offset: 0x1387BA0 VA: 0x1813895A0
	private char ToUpperInternal(char c) { }

	// RVA: 0x1388D50 Offset: 0x1387350 VA: 0x181388D50
	private char ToLowerInternal(char c) { }

	// RVA: 0x1388790 Offset: 0x1386D90 VA: 0x181388790
	private static int InternalCompareStringOrdinalIgnoreCase(string strA, int indexA, string strB, int indexB, int lenA, int lenB) { }

	// RVA: 0x1389FB0 Offset: 0x13885B0 VA: 0x181389FB0
	internal void .ctor() { }

}

