internal class SecurityParser : SmallXmlParser, SmallXmlParser.IContentHandler // TypeDefIndex: 23
{	// Fields
	private SecurityElement root; // 0x68
	private SecurityElement current; // 0x70
	private Stack stack; // 0x78

	// Methods

	// RVA: 0x1563DD0 Offset: 0x15623D0 VA: 0x181563DD0
	public void .ctor() { }

	// RVA: 0x1563A60 Offset: 0x1562060 VA: 0x181563A60
	public void LoadXml(string xml) { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public SecurityElement ToXml() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	public void OnStartParsing(SmallXmlParser parser) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public void OnProcessingInstruction(string name, string text) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	public void OnIgnorableWhitespace(string s) { }

	// RVA: 0x1563C00 Offset: 0x1562200 VA: 0x181563C00 Slot: 6
	public void OnStartElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1563B80 Offset: 0x1562180 VA: 0x181563B80 Slot: 7
	public void OnEndElement(string name) { }

	// RVA: 0x1563B00 Offset: 0x1562100 VA: 0x181563B00 Slot: 9
	public void OnChars(string ch) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void OnEndParsing(SmallXmlParser parser) { }

}

