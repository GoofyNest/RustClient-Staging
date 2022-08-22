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

	// RVA: 0x1386DC0 Offset: 0x13853C0 VA: 0x181386DC0
	internal void .ctor(string str, int startIndex, int strLen) { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1386CE0 Offset: 0x13852E0 VA: 0x181386CE0
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1386C40 Offset: 0x1385240 VA: 0x181386C40
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1386CF0 Offset: 0x13852F0 VA: 0x181386CF0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x1386AA0 Offset: 0x13850A0 VA: 0x181386AA0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x13869C0 Offset: 0x1384FC0 VA: 0x1813869C0 Slot: 5
	public object get_Current() { }

	// RVA: 0x13869C0 Offset: 0x1384FC0 VA: 0x1813869C0
	public string GetTextElement() { }

	// RVA: 0x1386D00 Offset: 0x1385300 VA: 0x181386D00 Slot: 6
	public void Reset() { }

	// RVA: 0x1386D90 Offset: 0x1385390 VA: 0x181386D90
	internal void .ctor() { }

}

