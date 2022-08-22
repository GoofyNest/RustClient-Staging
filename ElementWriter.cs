internal struct ElementWriter // TypeDefIndex: 5838
{	// Fields
	private XmlWriter writer; // 0x0
	private NamespaceResolver resolver; // 0x8

	// Methods

	// RVA: 0x237580 Offset: 0x236980 VA: 0x180237580
	public void .ctor(XmlWriter writer) { }

	// RVA: 0x2374E0 Offset: 0x2368E0 VA: 0x1802374E0
	public void WriteElement(XElement e) { }

	// RVA: 0x2374B0 Offset: 0x2368B0 VA: 0x1802374B0
	private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

	// RVA: 0x2374C0 Offset: 0x2368C0 VA: 0x1802374C0
	private void PushAncestors(XElement e) { }

	// RVA: 0x2374D0 Offset: 0x2368D0 VA: 0x1802374D0
	private void PushElement(XElement e) { }

	// RVA: 0x2374F0 Offset: 0x2368F0 VA: 0x1802374F0
	private void WriteEndElement() { }

	// RVA: 0x237530 Offset: 0x236930 VA: 0x180237530
	private void WriteFullEndElement() { }

	// RVA: 0x237570 Offset: 0x236970 VA: 0x180237570
	private void WriteStartElement(XElement e) { }

}

