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

	// RVA: 0xE9DDC0 Offset: 0xE9C3C0 VA: 0x180E9DDC0
	public void .ctor() { }

	// RVA: 0xE9DCB0 Offset: 0xE9C2B0 VA: 0x180E9DCB0
	public void .ctor(char[] buffer) { }

	// RVA: 0xE9E850 Offset: 0xE9CE50 VA: 0x180E9E850
	public void .ctor(SqlString value) { }

	// RVA: 0xE9DF70 Offset: 0xE9C570 VA: 0x180E9DF70 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0xE9E8B0 Offset: 0xE9CEB0 VA: 0x180E9E8B0
	public char[] get_Buffer() { }

	// RVA: 0xE9EA20 Offset: 0xE9D020 VA: 0x180E9EA20
	public long get_Length() { }

	// RVA: 0xE9EB00 Offset: 0xE9D100 VA: 0x180E9EB00
	public char[] get_Value() { }

	// RVA: 0xE9D7F0 Offset: 0xE9BDF0 VA: 0x180E9D7F0
	public void SetNull() { }

	// RVA: 0xE9D710 Offset: 0xE9BD10 VA: 0x180E9D710
	internal bool FStream() { }

	// RVA: 0xE9E250 Offset: 0xE9C850 VA: 0x180E9E250
	private void CopyStreamToBuffer() { }

	// RVA: 0xE9D780 Offset: 0xE9BD80 VA: 0x180E9D780
	private void SetBuffer(char[] buffer) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xE9E470 Offset: 0xE9CA70 VA: 0x180E9E470 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0xE9E5C0 Offset: 0xE9CBC0 VA: 0x180E9E5C0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xE9E3C0 Offset: 0xE9C9C0 VA: 0x180E9E3C0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xE9E420 Offset: 0xE9CA20 VA: 0x180E9E420 Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE9EAB0 Offset: 0xE9D0B0 VA: 0x180E9EAB0
	public static SqlChars get_Null() { }

}

