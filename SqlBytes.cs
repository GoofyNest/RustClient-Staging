public sealed class SqlBytes : INullable, IXmlSerializable, ISerializable // TypeDefIndex: 4341
{	// Fields
	internal byte[] _rgbBuf; // 0x10
	private long _lCurLen; // 0x18
	internal Stream _stream; // 0x20
	private SqlBytesCharsState _state; // 0x28
	private byte[] _rgbWorkBuf; // 0x30

	// Properties
	public bool IsNull { get; }
	public byte[] Buffer { get; }
	public long Length { get; }
	public byte[] Value { get; }
	public static SqlBytes Null { get; }

	// Methods

	// RVA: 0xE9E080 Offset: 0xE9C680 VA: 0x180E9E080
	public void .ctor() { }

	// RVA: 0xE9DF70 Offset: 0xE9C570 VA: 0x180E9DF70
	public void .ctor(byte[] buffer) { }

	// RVA: 0xE9DFF0 Offset: 0xE9C5F0 VA: 0x180E9DFF0
	public void .ctor(SqlBinary value) { }

	// RVA: 0xE9E230 Offset: 0xE9C830 VA: 0x180E9E230 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0xE9E0C0 Offset: 0xE9C6C0 VA: 0x180E9E0C0
	public byte[] get_Buffer() { }

	// RVA: 0xE9E240 Offset: 0xE9C840 VA: 0x180E9E240
	public long get_Length() { }

	// RVA: 0xE9E320 Offset: 0xE9C920 VA: 0x180E9E320
	public byte[] get_Value() { }

	// RVA: 0xE9DAB0 Offset: 0xE9C0B0 VA: 0x180E9DAB0
	public void SetNull() { }

	// RVA: 0xE9D860 Offset: 0xE9BE60 VA: 0x180E9D860
	private void CopyStreamToBuffer() { }

	// RVA: 0xE9D9D0 Offset: 0xE9BFD0 VA: 0x180E9D9D0
	internal bool FStream() { }

	// RVA: 0xE9DA40 Offset: 0xE9C040 VA: 0x180E9DA40
	private void SetBuffer(byte[] buffer) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xE9DB30 Offset: 0xE9C130 VA: 0x180E9DB30 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0xE9DCC0 Offset: 0xE9C2C0 VA: 0x180E9DCC0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xE9D9E0 Offset: 0xE9BFE0 VA: 0x180E9D9E0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xE9DAE0 Offset: 0xE9C0E0 VA: 0x180E9DAE0 Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE9E2D0 Offset: 0xE9C8D0 VA: 0x180E9E2D0
	public static SqlBytes get_Null() { }

}

