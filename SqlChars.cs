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

	// RVA: 0xE9E080 Offset: 0xE9C680 VA: 0x180E9E080
	public void .ctor() { }

	// RVA: 0xE9DF70 Offset: 0xE9C570 VA: 0x180E9DF70
	public void .ctor(char[] buffer) { }

	// RVA: 0xE9EB10 Offset: 0xE9D110 VA: 0x180E9EB10
	public void .ctor(SqlString value) { }

	// RVA: 0xE9E230 Offset: 0xE9C830 VA: 0x180E9E230 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0xE9EB70 Offset: 0xE9D170 VA: 0x180E9EB70
	public char[] get_Buffer() { }

	// RVA: 0xE9ECE0 Offset: 0xE9D2E0 VA: 0x180E9ECE0
	public long get_Length() { }

	// RVA: 0xE9EDC0 Offset: 0xE9D3C0 VA: 0x180E9EDC0
	public char[] get_Value() { }

	// RVA: 0xE9DAB0 Offset: 0xE9C0B0 VA: 0x180E9DAB0
	public void SetNull() { }

	// RVA: 0xE9D9D0 Offset: 0xE9BFD0 VA: 0x180E9D9D0
	internal bool FStream() { }

	// RVA: 0xE9E510 Offset: 0xE9CB10 VA: 0x180E9E510
	private void CopyStreamToBuffer() { }

	// RVA: 0xE9DA40 Offset: 0xE9C040 VA: 0x180E9DA40
	private void SetBuffer(char[] buffer) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xE9E730 Offset: 0xE9CD30 VA: 0x180E9E730 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0xE9E880 Offset: 0xE9CE80 VA: 0x180E9E880 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xE9E680 Offset: 0xE9CC80 VA: 0x180E9E680
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xE9E6E0 Offset: 0xE9CCE0 VA: 0x180E9E6E0 Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE9ED70 Offset: 0xE9D370 VA: 0x180E9ED70
	public static SqlChars get_Null() { }

}

