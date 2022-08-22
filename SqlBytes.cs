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

	// RVA: 0xE9EB30 Offset: 0xE9D130 VA: 0x180E9EB30
	public void .ctor() { }

	// RVA: 0xE9EA20 Offset: 0xE9D020 VA: 0x180E9EA20
	public void .ctor(byte[] buffer) { }

	// RVA: 0xE9EAA0 Offset: 0xE9D0A0 VA: 0x180E9EAA0
	public void .ctor(SqlBinary value) { }

	// RVA: 0xE9ECE0 Offset: 0xE9D2E0 VA: 0x180E9ECE0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0xE9EB70 Offset: 0xE9D170 VA: 0x180E9EB70
	public byte[] get_Buffer() { }

	// RVA: 0xE9ECF0 Offset: 0xE9D2F0 VA: 0x180E9ECF0
	public long get_Length() { }

	// RVA: 0xE9EDD0 Offset: 0xE9D3D0 VA: 0x180E9EDD0
	public byte[] get_Value() { }

	// RVA: 0xE9E560 Offset: 0xE9CB60 VA: 0x180E9E560
	public void SetNull() { }

	// RVA: 0xE9E310 Offset: 0xE9C910 VA: 0x180E9E310
	private void CopyStreamToBuffer() { }

	// RVA: 0xE9E480 Offset: 0xE9CA80 VA: 0x180E9E480
	internal bool FStream() { }

	// RVA: 0xE9E4F0 Offset: 0xE9CAF0 VA: 0x180E9E4F0
	private void SetBuffer(byte[] buffer) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xE9E5E0 Offset: 0xE9CBE0 VA: 0x180E9E5E0 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0xE9E770 Offset: 0xE9CD70 VA: 0x180E9E770 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xE9E490 Offset: 0xE9CA90 VA: 0x180E9E490
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xE9E590 Offset: 0xE9CB90 VA: 0x180E9E590 Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE9ED80 Offset: 0xE9D380 VA: 0x180E9ED80
	public static SqlBytes get_Null() { }

}

