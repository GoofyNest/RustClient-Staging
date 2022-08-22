internal class DomNameTable // TypeDefIndex: 1946
{	// Fields
	private XmlName[] entries; // 0x10
	private int count; // 0x18
	private int mask; // 0x1C
	private XmlDocument ownerDocument; // 0x20
	private XmlNameTable nameTable; // 0x28

	// Methods

	// RVA: 0x12EA9C0 Offset: 0x12E8FC0 VA: 0x1812EA9C0
	public void .ctor(XmlDocument document) { }

	// RVA: 0x12EA700 Offset: 0x12E8D00 VA: 0x1812EA700
	public XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x12EA2D0 Offset: 0x12E88D0 VA: 0x1812EA2D0
	public XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x12EA860 Offset: 0x12E8E60 VA: 0x1812EA860
	private void Grow() { }

}

