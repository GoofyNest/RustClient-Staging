public class StringInfo // TypeDefIndex: 716
{	// Fields
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	private string m_str; // 0x10
	private int[] m_indexes; // 0x18

	// Properties
	public string String { set; }

	// Methods

	// RVA: 0x13861C0 Offset: 0x13847C0 VA: 0x1813861C0
	public void .ctor() { }

	// RVA: 0x1386290 Offset: 0x1384890 VA: 0x181386290
	public void .ctor(string value) { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1386170 Offset: 0x1384770 VA: 0x181386170
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1386130 Offset: 0x1384730 VA: 0x181386130
	private void OnDeserialized(StreamingContext ctx) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1385C00 Offset: 0x1384200 VA: 0x181385C00 Slot: 0
	public override bool Equals(object value) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0xDE2D10 Offset: 0xDE1310 VA: 0x180DE2D10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1386340 Offset: 0x1384940 VA: 0x181386340
	public void set_String(string value) { }

	// RVA: 0x1385CA0 Offset: 0x13842A0 VA: 0x181385CA0
	internal static int GetCurrentTextElementLen(string str, int index, int len, ref UnicodeCategory ucCurrent, ref int currentCharCount) { }

	// RVA: 0x1385E40 Offset: 0x1384440 VA: 0x181385E40
	public static TextElementEnumerator GetTextElementEnumerator(string str) { }

	// RVA: 0x1385FB0 Offset: 0x13845B0 VA: 0x181385FB0
	public static TextElementEnumerator GetTextElementEnumerator(string str, int index) { }

}

