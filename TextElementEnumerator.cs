public class TextElementEnumerator : IEnumerator // TypeDefIndex: 718
{	private string str; // 0x10
	private int index; // 0x18
	private int startIndex; // 0x1C
	private int strLen; // 0x20
	private int currTextElementLen; // 0x24
	[OptionalFieldAttribute] // RVA: 0x92FF0 Offset: 0x923F0 VA: 0x180092FF0
	private UnicodeCategory uc; // 0x28
	[OptionalFieldAttribute] // RVA: 0x92FF0 Offset: 0x923F0 VA: 0x180092FF0
	private int charLen; // 0x2C
	private int endIndex; // 0x30
	private int nextTextElementLen; // 0x34

	public object Current { get; }


	internal void .ctor(string str, int startIndex, int strLen) { }

	[OnDeserializingAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void OnSerializing(StreamingContext ctx) { }

	public bool MoveNext() { }

	public object get_Current() { }

	public string GetTextElement() { }

	public void Reset() { }

	internal void .ctor() { }

}

