internal class HtmlUtf8RawTextWriterIndent : HtmlUtf8RawTextWriter // TypeDefIndex: 1843
{	// Fields
	private int indentLevel; // 0xC0
	private int endBlockPos; // 0xC4
	private string indentChars; // 0xC8
	private bool newLineOnAttributes; // 0xD0

	// Methods

	// RVA: 0xF5F1D0 Offset: 0xF5D7D0 VA: 0x180F5F1D0
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0xF5EDA0 Offset: 0xF5D3A0 VA: 0x180F5EDA0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xF5EFA0 Offset: 0xF5D5A0 VA: 0x180F5EFA0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0xF5ECE0 Offset: 0xF5D2E0 VA: 0x180F5ECE0 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0xF5EDD0 Offset: 0xF5D3D0 VA: 0x180F5EDD0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0xF5EEE0 Offset: 0xF5D4E0 VA: 0x180F5EEE0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0xF5EC70 Offset: 0xF5D270 VA: 0x180F5EC70 Slot: 48
	protected override void FlushBuffer() { }

	// RVA: 0xF5EC90 Offset: 0xF5D290 VA: 0x180F5EC90
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0xF5EE90 Offset: 0xF5D490 VA: 0x180F5EE90
	private void WriteIndent() { }

}

