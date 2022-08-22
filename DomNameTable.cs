internal class DomNameTable // TypeDefIndex: 1946
{	// Fields
	private XmlName[] entries; // 0x10
	private int count; // 0x18
	private int mask; // 0x1C
	private XmlDocument ownerDocument; // 0x20
	private XmlNameTable nameTable; // 0x28

	// Methods

	// RVA: 0x12E4510 Offset: 0x12E2B10 VA: 0x1812E4510
	public void .ctor(XmlDocument document) { }

	// RVA: 0x12E4250 Offset: 0x12E2850 VA: 0x1812E4250
	public XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x12E3E20 Offset: 0x12E2420 VA: 0x1812E3E20
	public XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x12E43B0 Offset: 0x12E29B0 VA: 0x1812E43B0
	private void Grow() { }

}

