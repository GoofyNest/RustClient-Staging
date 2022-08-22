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

	// RVA: 0x13893A0 Offset: 0x13879A0 VA: 0x1813893A0
	internal static TextInfo get_Invariant() { }

	// RVA: 0x13892F0 Offset: 0x13878F0 VA: 0x1813892F0
	internal void .ctor(CultureData cultureData) { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1387F20 Offset: 0x1386520 VA: 0x181387F20
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x1387DE0 Offset: 0x13863E0 VA: 0x181387DE0
	private void OnDeserialized() { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1387F10 Offset: 0x1386510 VA: 0x181387F10
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1387F60 Offset: 0x1386560 VA: 0x181387F60
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x1387830 Offset: 0x1385E30 VA: 0x181387830
	internal static int GetHashCodeOrdinalIgnoreCase(string s) { }

	// RVA: 0x13876F0 Offset: 0x1385CF0 VA: 0x1813876F0
	internal static int GetHashCodeOrdinalIgnoreCase(string s, bool forceRandomizedHashing, long additionalEntropy) { }

	// RVA: 0x1387420 Offset: 0x1385A20 VA: 0x181387420
	internal static int CompareOrdinalIgnoreCase(string str1, string str2) { }

	// RVA: 0x1387410 Offset: 0x1385A10 VA: 0x181387410
	internal static int CompareOrdinalIgnoreCaseEx(string strA, int indexA, string strB, int indexB, int lengthA, int lengthB) { }

	// RVA: 0x1387A80 Offset: 0x1386080 VA: 0x181387A80
	internal static int IndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count) { }

	// RVA: 0x1387D20 Offset: 0x1386320 VA: 0x181387D20
	internal static int LastIndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_CultureName() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1387340 Offset: 0x1385940 VA: 0x181387340 Slot: 6
	public virtual object Clone() { }

	// RVA: 0x960010 Offset: 0x95E610 VA: 0x180960010
	internal void SetReadOnlyState(bool readOnly) { }

	// RVA: 0x1388760 Offset: 0x1386D60 VA: 0x181388760 Slot: 7
	public virtual char ToLower(char c) { }

	// RVA: 0x13887C0 Offset: 0x1386DC0 VA: 0x1813887C0 Slot: 8
	public virtual string ToLower(string str) { }

	// RVA: 0x1388000 Offset: 0x1386600 VA: 0x181388000
	private static char ToLowerAsciiInvariant(char c) { }

	// RVA: 0x1389290 Offset: 0x1387890 VA: 0x181389290 Slot: 9
	public virtual char ToUpper(char c) { }

	// RVA: 0x1389160 Offset: 0x1387760 VA: 0x181389160 Slot: 10
	public virtual string ToUpper(string str) { }

	// RVA: 0x1388940 Offset: 0x1386F40 VA: 0x181388940
	private static char ToUpperAsciiInvariant(char c) { }

	// RVA: 0x1387D10 Offset: 0x1386310 VA: 0x181387D10
	private static bool IsAscii(char c) { }

	// RVA: 0x13894A0 Offset: 0x1387AA0 VA: 0x1813894A0
	private bool get_IsAsciiCasingSameAsInvariant() { }

	// RVA: 0x1387460 Offset: 0x1385A60 VA: 0x181387460 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xE6C340 Offset: 0xE6A940 VA: 0x180E6C340 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13888F0 Offset: 0x1386EF0 VA: 0x1813888F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1387F10 Offset: 0x1386510 VA: 0x181387F10 Slot: 5
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x13876D0 Offset: 0x1385CD0 VA: 0x1813876D0
	internal int GetCaseInsensitiveHashCode(string str) { }

	// RVA: 0x1387500 Offset: 0x1385B00 VA: 0x181387500
	internal int GetCaseInsensitiveHashCode(string str, bool forceRandomizedHashing, long additionalEntropy) { }

	// RVA: 0x1387960 Offset: 0x1385F60 VA: 0x181387960
	private int GetInvariantCaseInsensitiveHashCode(string str) { }

	// RVA: 0x1389070 Offset: 0x1387670 VA: 0x181389070
	private string ToUpperInternal(string str) { }

	// RVA: 0x1388020 Offset: 0x1386620 VA: 0x181388020
	private string ToLowerInternal(string str) { }

	// RVA: 0x1388960 Offset: 0x1386F60 VA: 0x181388960
	private char ToUpperInternal(char c) { }

	// RVA: 0x1388110 Offset: 0x1386710 VA: 0x181388110
	private char ToLowerInternal(char c) { }

	// RVA: 0x1387B50 Offset: 0x1386150 VA: 0x181387B50
	private static int InternalCompareStringOrdinalIgnoreCase(string strA, int indexA, string strB, int indexB, int lenA, int lenB) { }

	// RVA: 0x1389370 Offset: 0x1387970 VA: 0x181389370
	internal void .ctor() { }

}

