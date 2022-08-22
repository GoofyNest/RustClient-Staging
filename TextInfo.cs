public class TextInfo : ICloneable, IDeserializationCallback // TypeDefIndex: 719
{	// Fields
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	private string m_listSeparator; // 0x10
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	private bool m_isReadOnly; // 0x18
	[OptionalFieldAttribute] // RVA: 0xA9AF0 Offset: 0xA8EF0 VA: 0x1800A9AF0
	private string m_cultureName; // 0x20
	private CultureData m_cultureData; // 0x28
	private string m_textInfoName; // 0x30
	private Nullable<bool> m_IsAsciiCasingSameAsInvariant; // 0x38
	internal static TextInfo s_Invariant; // 0x0
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	private string customCultureName; // 0x40
	[OptionalFieldAttribute] // RVA: 0x96550 Offset: 0x95950 VA: 0x180096550
	internal int m_nDataItem; // 0x48
	[OptionalFieldAttribute] // RVA: 0x96550 Offset: 0x95950 VA: 0x180096550
	internal bool m_useUserOverride; // 0x4C
	[OptionalFieldAttribute] // RVA: 0x96550 Offset: 0x95950 VA: 0x180096550
	internal int m_win32LangID; // 0x50
	private const int wordSeparatorMask = 536672256;

	// Properties
	internal static TextInfo Invariant { get; }
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public string CultureName { get; }
	private bool IsAsciiCasingSameAsInvariant { get; }

	// Methods

	// RVA: 0x138A2A0 Offset: 0x13888A0 VA: 0x18138A2A0
	internal static TextInfo get_Invariant() { }

	// RVA: 0x138A1F0 Offset: 0x13887F0 VA: 0x18138A1F0
	internal void .ctor(CultureData cultureData) { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1388E20 Offset: 0x1387420 VA: 0x181388E20
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x1388CE0 Offset: 0x13872E0 VA: 0x181388CE0
	private void OnDeserialized() { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1388E10 Offset: 0x1387410 VA: 0x181388E10
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1388E60 Offset: 0x1387460 VA: 0x181388E60
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x1388730 Offset: 0x1386D30 VA: 0x181388730
	internal static int GetHashCodeOrdinalIgnoreCase(string s) { }

	// RVA: 0x13885F0 Offset: 0x1386BF0 VA: 0x1813885F0
	internal static int GetHashCodeOrdinalIgnoreCase(string s, bool forceRandomizedHashing, long additionalEntropy) { }

	// RVA: 0x1388320 Offset: 0x1386920 VA: 0x181388320
	internal static int CompareOrdinalIgnoreCase(string str1, string str2) { }

	// RVA: 0x1388310 Offset: 0x1386910 VA: 0x181388310
	internal static int CompareOrdinalIgnoreCaseEx(string strA, int indexA, string strB, int indexB, int lengthA, int lengthB) { }

	// RVA: 0x1388980 Offset: 0x1386F80 VA: 0x181388980
	internal static int IndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count) { }

	// RVA: 0x1388C20 Offset: 0x1387220 VA: 0x181388C20
	internal static int LastIndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_CultureName() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1388240 Offset: 0x1386840 VA: 0x181388240 Slot: 6
	public virtual object Clone() { }

	// RVA: 0x95FB10 Offset: 0x95E110 VA: 0x18095FB10
	internal void SetReadOnlyState(bool readOnly) { }

	// RVA: 0x1389660 Offset: 0x1387C60 VA: 0x181389660 Slot: 7
	public virtual char ToLower(char c) { }

	// RVA: 0x13896C0 Offset: 0x1387CC0 VA: 0x1813896C0 Slot: 8
	public virtual string ToLower(string str) { }

	// RVA: 0x1388F00 Offset: 0x1387500 VA: 0x181388F00
	private static char ToLowerAsciiInvariant(char c) { }

	// RVA: 0x138A190 Offset: 0x1388790 VA: 0x18138A190 Slot: 9
	public virtual char ToUpper(char c) { }

	// RVA: 0x138A060 Offset: 0x1388660 VA: 0x18138A060 Slot: 10
	public virtual string ToUpper(string str) { }

	// RVA: 0x1389840 Offset: 0x1387E40 VA: 0x181389840
	private static char ToUpperAsciiInvariant(char c) { }

	// RVA: 0x1388C10 Offset: 0x1387210 VA: 0x181388C10
	private static bool IsAscii(char c) { }

	// RVA: 0x138A3A0 Offset: 0x13889A0 VA: 0x18138A3A0
	private bool get_IsAsciiCasingSameAsInvariant() { }

	// RVA: 0x1388360 Offset: 0x1386960 VA: 0x181388360 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xE6B890 Offset: 0xE69E90 VA: 0x180E6B890 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13897F0 Offset: 0x1387DF0 VA: 0x1813897F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1388E10 Offset: 0x1387410 VA: 0x181388E10 Slot: 5
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x13885D0 Offset: 0x1386BD0 VA: 0x1813885D0
	internal int GetCaseInsensitiveHashCode(string str) { }

	// RVA: 0x1388400 Offset: 0x1386A00 VA: 0x181388400
	internal int GetCaseInsensitiveHashCode(string str, bool forceRandomizedHashing, long additionalEntropy) { }

	// RVA: 0x1388860 Offset: 0x1386E60 VA: 0x181388860
	private int GetInvariantCaseInsensitiveHashCode(string str) { }

	// RVA: 0x1389F70 Offset: 0x1388570 VA: 0x181389F70
	private string ToUpperInternal(string str) { }

	// RVA: 0x1388F20 Offset: 0x1387520 VA: 0x181388F20
	private string ToLowerInternal(string str) { }

	// RVA: 0x1389860 Offset: 0x1387E60 VA: 0x181389860
	private char ToUpperInternal(char c) { }

	// RVA: 0x1389010 Offset: 0x1387610 VA: 0x181389010
	private char ToLowerInternal(char c) { }

	// RVA: 0x1388A50 Offset: 0x1387050 VA: 0x181388A50
	private static int InternalCompareStringOrdinalIgnoreCase(string strA, int indexA, string strB, int indexB, int lenA, int lenB) { }

	// RVA: 0x138A270 Offset: 0x1388870 VA: 0x18138A270
	internal void .ctor() { }

}

