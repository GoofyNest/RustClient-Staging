internal class SecurityParser : SmallXmlParser, SmallXmlParser.IContentHandler // TypeDefIndex: 23
{	// Fields
	private SecurityElement root; // 0x68
	private SecurityElement current; // 0x70
	private Stack stack; // 0x78

	// Methods

	// RVA: 0x1564D00 Offset: 0x1563300 VA: 0x181564D00
	public void .ctor() { }

	// RVA: 0x1564990 Offset: 0x1562F90 VA: 0x181564990
	public void LoadXml(string xml) { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public SecurityElement ToXml() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	public void OnStartParsing(SmallXmlParser parser) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public void OnProcessingInstruction(string name, string text) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	public void OnIgnorableWhitespace(string s) { }

	// RVA: 0x1564B30 Offset: 0x1563130 VA: 0x181564B30 Slot: 6
	public void OnStartElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1564AB0 Offset: 0x15630B0 VA: 0x181564AB0 Slot: 7
	public void OnEndElement(string name) { }

	// RVA: 0x1564A30 Offset: 0x1563030 VA: 0x181564A30 Slot: 9
	public void OnChars(string ch) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void OnEndParsing(SmallXmlParser parser) { }

}

