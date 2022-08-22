public class StringInfo // TypeDefIndex: 716
{	// Fields
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	private string m_str; // 0x10
	private int[] m_indexes; // 0x18

	// Properties
	public string String { set; }

	// Methods

	// RVA: 0x13870C0 Offset: 0x13856C0 VA: 0x1813870C0
	public void .ctor() { }

	// RVA: 0x1387190 Offset: 0x1385790 VA: 0x181387190
	public void .ctor(string value) { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1387070 Offset: 0x1385670 VA: 0x181387070
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1387030 Offset: 0x1385630 VA: 0x181387030
	private void OnDeserialized(StreamingContext ctx) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1386B00 Offset: 0x1385100 VA: 0x181386B00 Slot: 0
	public override bool Equals(object value) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0xDE2260 Offset: 0xDE0860 VA: 0x180DE2260 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1387240 Offset: 0x1385840 VA: 0x181387240
	public void set_String(string value) { }

	// RVA: 0x1386BA0 Offset: 0x13851A0 VA: 0x181386BA0
	internal static int GetCurrentTextElementLen(string str, int index, int len, ref UnicodeCategory ucCurrent, ref int currentCharCount) { }

	// RVA: 0x1386D40 Offset: 0x1385340 VA: 0x181386D40
	public static TextElementEnumerator GetTextElementEnumerator(string str) { }

	// RVA: 0x1386EB0 Offset: 0x13854B0 VA: 0x181386EB0
	public static TextElementEnumerator GetTextElementEnumerator(string str, int index) { }

}

