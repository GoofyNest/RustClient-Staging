internal class HtmlUtf8RawTextWriterIndent : HtmlUtf8RawTextWriter // TypeDefIndex: 1843
{	// Fields
	private int indentLevel; // 0xC0
	private int endBlockPos; // 0xC4
	private string indentChars; // 0xC8
	private bool newLineOnAttributes; // 0xD0

	// Methods

	// RVA: 0xF5F490 Offset: 0xF5DA90 VA: 0x180F5F490
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0xF5F060 Offset: 0xF5D660 VA: 0x180F5F060 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xF5F260 Offset: 0xF5D860 VA: 0x180F5F260 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0xF5EFA0 Offset: 0xF5D5A0 VA: 0x180F5EFA0 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0xF5F090 Offset: 0xF5D690 VA: 0x180F5F090 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0xF5F1A0 Offset: 0xF5D7A0 VA: 0x180F5F1A0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0xF5EF30 Offset: 0xF5D530 VA: 0x180F5EF30 Slot: 48
	protected override void FlushBuffer() { }

	// RVA: 0xF5EF50 Offset: 0xF5D550 VA: 0x180F5EF50
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0xF5F150 Offset: 0xF5D750 VA: 0x180F5F150
	private void WriteIndent() { }

}

