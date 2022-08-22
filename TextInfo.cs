public class TextInfo : ICloneable, IDeserializationCallback // TypeDefIndex: 719
{	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
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

	internal static TextInfo Invariant { get; }
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public string CultureName { get; }
	private bool IsAsciiCasingSameAsInvariant { get; }


	internal static TextInfo get_Invariant() { }

	internal void .ctor(CultureData cultureData) { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void OnDeserializing(StreamingContext ctx) { }

	private void OnDeserialized() { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void OnSerializing(StreamingContext ctx) { }

	internal static int GetHashCodeOrdinalIgnoreCase(string s) { }

	internal static int GetHashCodeOrdinalIgnoreCase(string s, bool forceRandomizedHashing, long additionalEntropy) { }

	internal static int CompareOrdinalIgnoreCase(string str1, string str2) { }

	internal static int CompareOrdinalIgnoreCaseEx(string strA, int indexA, string strB, int indexB, int lengthA, int lengthB) { }

	internal static int IndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count) { }

	internal static int LastIndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count) { }

	public string get_CultureName() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public virtual object Clone() { }

	internal void SetReadOnlyState(bool readOnly) { }

	public virtual char ToLower(char c) { }

	public virtual string ToLower(string str) { }

	private static char ToLowerAsciiInvariant(char c) { }

	public virtual char ToUpper(char c) { }

	public virtual string ToUpper(string str) { }

	private static char ToUpperAsciiInvariant(char c) { }

	private static bool IsAscii(char c) { }

	private bool get_IsAsciiCasingSameAsInvariant() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	internal int GetCaseInsensitiveHashCode(string str) { }

	internal int GetCaseInsensitiveHashCode(string str, bool forceRandomizedHashing, long additionalEntropy) { }

	private int GetInvariantCaseInsensitiveHashCode(string str) { }

	private string ToUpperInternal(string str) { }

	private string ToLowerInternal(string str) { }

	private char ToUpperInternal(char c) { }

	private char ToLowerInternal(char c) { }

	private static int InternalCompareStringOrdinalIgnoreCase(string strA, int indexA, string strB, int indexB, int lenA, int lenB) { }

	internal void .ctor() { }

}

