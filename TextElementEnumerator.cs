public class TextElementEnumerator : IEnumerator // TypeDefIndex: 718
{	// Fields
	private string str; // 0x10
	private int index; // 0x18
	private int startIndex; // 0x1C
	private int strLen; // 0x20
	private int currTextElementLen; // 0x24
	[OptionalFieldAttribute] // RVA: 0x92F70 Offset: 0x92370 VA: 0x180092F70
	private UnicodeCategory uc; // 0x28
	[OptionalFieldAttribute] // RVA: 0x92F70 Offset: 0x92370 VA: 0x180092F70
	private int charLen; // 0x2C
	private int endIndex; // 0x30
	private int nextTextElementLen; // 0x34

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x1387A00 Offset: 0x1386000 VA: 0x181387A00
	internal void .ctor(string str, int startIndex, int strLen) { }

	[OnDeserializingAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1387920 Offset: 0x1385F20 VA: 0x181387920
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1387880 Offset: 0x1385E80 VA: 0x181387880
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1387930 Offset: 0x1385F30 VA: 0x181387930
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x13876E0 Offset: 0x1385CE0 VA: 0x1813876E0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1387600 Offset: 0x1385C00 VA: 0x181387600 Slot: 5
	public object get_Current() { }

	// RVA: 0x1387600 Offset: 0x1385C00 VA: 0x181387600
	public string GetTextElement() { }

	// RVA: 0x1387940 Offset: 0x1385F40 VA: 0x181387940 Slot: 6
	public void Reset() { }

	// RVA: 0x13879D0 Offset: 0x1385FD0 VA: 0x1813879D0
	internal void .ctor() { }

}

