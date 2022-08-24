public class StringInfo // TypeDefIndex: 716
{	[OptionalFieldAttribute] // RVA: 0x92F80 Offset: 0x92380 VA: 0x180092F80
	private string m_str; // 0x10
	private int[] m_indexes; // 0x18

	public string String { set; }


	public void .ctor() { }

	public void .ctor(string value) { }

	[OnDeserializingAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void OnDeserialized(StreamingContext ctx) { }

	[ComVisibleAttribute] // RVA: 0x75DF0 Offset: 0x751F0 VA: 0x180075DF0
	public override bool Equals(object value) { }

	[ComVisibleAttribute] // RVA: 0x75DF0 Offset: 0x751F0 VA: 0x180075DF0
	public override int GetHashCode() { }

	public void set_String(string value) { }

	internal static int GetCurrentTextElementLen(string str, int index, int len, ref UnicodeCategory ucCurrent, ref int currentCharCount) { }

	public static TextElementEnumerator GetTextElementEnumerator(string str) { }

	public static TextElementEnumerator GetTextElementEnumerator(string str, int index) { }

}

