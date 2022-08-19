public class StringInfo // TypeDefIndex: 716
{	// Fields
	[OptionalFieldAttribute] // RVA: 0x92F70 Offset: 0x92370 VA: 0x180092F70
	private string m_str; // 0x10
	private int[] m_indexes; // 0x18

	// Properties
	public string String { set; }

	// Methods

	// RVA: 0x1386E00 Offset: 0x1385400 VA: 0x181386E00
	public void .ctor() { }

	// RVA: 0x1386ED0 Offset: 0x13854D0 VA: 0x181386ED0
	public void .ctor(string value) { }

	[OnDeserializingAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1386DB0 Offset: 0x13853B0 VA: 0x181386DB0
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1386D70 Offset: 0x1385370 VA: 0x181386D70
	private void OnDeserialized(StreamingContext ctx) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x1386840 Offset: 0x1384E40 VA: 0x181386840 Slot: 0
	public override bool Equals(object value) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0xDE1FA0 Offset: 0xDE05A0 VA: 0x180DE1FA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1386F80 Offset: 0x1385580 VA: 0x181386F80
	public void set_String(string value) { }

	// RVA: 0x13868E0 Offset: 0x1384EE0 VA: 0x1813868E0
	internal static int GetCurrentTextElementLen(string str, int index, int len, ref UnicodeCategory ucCurrent, ref int currentCharCount) { }

	// RVA: 0x1386A80 Offset: 0x1385080 VA: 0x181386A80
	public static TextElementEnumerator GetTextElementEnumerator(string str) { }

	// RVA: 0x1386BF0 Offset: 0x13851F0 VA: 0x181386BF0
	public static TextElementEnumerator GetTextElementEnumerator(string str, int index) { }

}

