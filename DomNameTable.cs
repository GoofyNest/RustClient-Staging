internal class DomNameTable // TypeDefIndex: 1946
{	// Fields
	private XmlName[] entries; // 0x10
	private int count; // 0x18
	private int mask; // 0x1C
	private XmlDocument ownerDocument; // 0x20
	private XmlNameTable nameTable; // 0x28

	// Methods

	// RVA: 0x12E4250 Offset: 0x12E2850 VA: 0x1812E4250
	public void .ctor(XmlDocument document) { }

	// RVA: 0x12E3F90 Offset: 0x12E2590 VA: 0x1812E3F90
	public XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x12E3B60 Offset: 0x12E2160 VA: 0x1812E3B60
	public XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x12E40F0 Offset: 0x12E26F0 VA: 0x1812E40F0
	private void Grow() { }

}

