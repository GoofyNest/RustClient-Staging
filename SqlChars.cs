public sealed class SqlChars : INullable, IXmlSerializable, ISerializable // TypeDefIndex: 4342
{	// Fields
	internal char[] _rgchBuf; // 0x10
	private long _lCurLen; // 0x18
	internal SqlStreamChars _stream; // 0x20
	private SqlBytesCharsState _state; // 0x28
	private char[] _rgchWorkBuf; // 0x30

	// Properties
	public bool IsNull { get; }
	public char[] Buffer { get; }
	public long Length { get; }
	public char[] Value { get; }
	public static SqlChars Null { get; }

	// Methods

	// RVA: 0xE9EB30 Offset: 0xE9D130 VA: 0x180E9EB30
	public void .ctor() { }

	// RVA: 0xE9EA20 Offset: 0xE9D020 VA: 0x180E9EA20
	public void .ctor(char[] buffer) { }

	// RVA: 0xE9F5C0 Offset: 0xE9DBC0 VA: 0x180E9F5C0
	public void .ctor(SqlString value) { }

	// RVA: 0xE9ECE0 Offset: 0xE9D2E0 VA: 0x180E9ECE0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0xE9F620 Offset: 0xE9DC20 VA: 0x180E9F620
	public char[] get_Buffer() { }

	// RVA: 0xE9F790 Offset: 0xE9DD90 VA: 0x180E9F790
	public long get_Length() { }

	// RVA: 0xE9F870 Offset: 0xE9DE70 VA: 0x180E9F870
	public char[] get_Value() { }

	// RVA: 0xE9E560 Offset: 0xE9CB60 VA: 0x180E9E560
	public void SetNull() { }

	// RVA: 0xE9E480 Offset: 0xE9CA80 VA: 0x180E9E480
	internal bool FStream() { }

	// RVA: 0xE9EFC0 Offset: 0xE9D5C0 VA: 0x180E9EFC0
	private void CopyStreamToBuffer() { }

	// RVA: 0xE9E4F0 Offset: 0xE9CAF0 VA: 0x180E9E4F0
	private void SetBuffer(char[] buffer) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xE9F1E0 Offset: 0xE9D7E0 VA: 0x180E9F1E0 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0xE9F330 Offset: 0xE9D930 VA: 0x180E9F330 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xE9F130 Offset: 0xE9D730 VA: 0x180E9F130
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xE9F190 Offset: 0xE9D790 VA: 0x180E9F190 Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE9F820 Offset: 0xE9DE20 VA: 0x180E9F820
	public static SqlChars get_Null() { }

}

