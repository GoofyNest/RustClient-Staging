public class TextElementEnumerator : IEnumerator // TypeDefIndex: 718
{	// Fields
	private string str; // 0x10
	private int index; // 0x18
	private int startIndex; // 0x1C
	private int strLen; // 0x20
	private int currTextElementLen; // 0x24
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	private UnicodeCategory uc; // 0x28
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	private int charLen; // 0x2C
	private int endIndex; // 0x30
	private int nextTextElementLen; // 0x34

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x1387CC0 Offset: 0x13862C0 VA: 0x181387CC0
	internal void .ctor(string str, int startIndex, int strLen) { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1387BE0 Offset: 0x13861E0 VA: 0x181387BE0
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1387B40 Offset: 0x1386140 VA: 0x181387B40
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1387BF0 Offset: 0x13861F0 VA: 0x181387BF0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x13879A0 Offset: 0x1385FA0 VA: 0x1813879A0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x13878C0 Offset: 0x1385EC0 VA: 0x1813878C0 Slot: 5
	public object get_Current() { }

	// RVA: 0x13878C0 Offset: 0x1385EC0 VA: 0x1813878C0
	public string GetTextElement() { }

	// RVA: 0x1387C00 Offset: 0x1386200 VA: 0x181387C00 Slot: 6
	public void Reset() { }

	// RVA: 0x1387C90 Offset: 0x1386290 VA: 0x181387C90
	internal void .ctor() { }

}

