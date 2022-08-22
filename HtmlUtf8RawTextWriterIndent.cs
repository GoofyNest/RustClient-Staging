internal class HtmlUtf8RawTextWriterIndent : HtmlUtf8RawTextWriter // TypeDefIndex: 1843
{	// Fields
	private int indentLevel; // 0xC0
	private int endBlockPos; // 0xC4
	private string indentChars; // 0xC8
	private bool newLineOnAttributes; // 0xD0

	// Methods

	// RVA: 0xF5FF30 Offset: 0xF5E530 VA: 0x180F5FF30
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0xF5FB00 Offset: 0xF5E100 VA: 0x180F5FB00 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xF5FD00 Offset: 0xF5E300 VA: 0x180F5FD00 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0xF5FA40 Offset: 0xF5E040 VA: 0x180F5FA40 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0xF5FB30 Offset: 0xF5E130 VA: 0x180F5FB30 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0xF5FC40 Offset: 0xF5E240 VA: 0x180F5FC40 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0xF5F9D0 Offset: 0xF5DFD0 VA: 0x180F5F9D0 Slot: 48
	protected override void FlushBuffer() { }

	// RVA: 0xF5F9F0 Offset: 0xF5DFF0 VA: 0x180F5F9F0
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0xF5FBF0 Offset: 0xF5E1F0 VA: 0x180F5FBF0
	private void WriteIndent() { }

}

