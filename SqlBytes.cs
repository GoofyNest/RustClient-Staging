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

	// RVA: 0xE9DDC0 Offset: 0xE9C3C0 VA: 0x180E9DDC0
	public void .ctor() { }

	// RVA: 0xE9DCB0 Offset: 0xE9C2B0 VA: 0x180E9DCB0
	public void .ctor(byte[] buffer) { }

	// RVA: 0xE9DD30 Offset: 0xE9C330 VA: 0x180E9DD30
	public void .ctor(SqlBinary value) { }

	// RVA: 0xE9DF70 Offset: 0xE9C570 VA: 0x180E9DF70 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0xE9DE00 Offset: 0xE9C400 VA: 0x180E9DE00
	public byte[] get_Buffer() { }

	// RVA: 0xE9DF80 Offset: 0xE9C580 VA: 0x180E9DF80
	public long get_Length() { }

	// RVA: 0xE9E060 Offset: 0xE9C660 VA: 0x180E9E060
	public byte[] get_Value() { }

	// RVA: 0xE9D7F0 Offset: 0xE9BDF0 VA: 0x180E9D7F0
	public void SetNull() { }

	// RVA: 0xE9D5A0 Offset: 0xE9BBA0 VA: 0x180E9D5A0
	private void CopyStreamToBuffer() { }

	// RVA: 0xE9D710 Offset: 0xE9BD10 VA: 0x180E9D710
	internal bool FStream() { }

	// RVA: 0xE9D780 Offset: 0xE9BD80 VA: 0x180E9D780
	private void SetBuffer(byte[] buffer) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xE9D870 Offset: 0xE9BE70 VA: 0x180E9D870 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0xE9DA00 Offset: 0xE9C000 VA: 0x180E9DA00 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xE9D720 Offset: 0xE9BD20 VA: 0x180E9D720
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xE9D820 Offset: 0xE9BE20 VA: 0x180E9D820 Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE9E010 Offset: 0xE9C610 VA: 0x180E9E010
	public static SqlBytes get_Null() { }

}

