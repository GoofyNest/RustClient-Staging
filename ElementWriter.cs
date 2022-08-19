internal struct ElementWriter // TypeDefIndex: 5838
{	// Fields
	private XmlWriter writer; // 0x0
	private NamespaceResolver resolver; // 0x8

	// Methods

	// RVA: 0x237600 Offset: 0x236A00 VA: 0x180237600
	public void .ctor(XmlWriter writer) { }

	// RVA: 0x237560 Offset: 0x236960 VA: 0x180237560
	public void WriteElement(XElement e) { }

	// RVA: 0x237530 Offset: 0x236930 VA: 0x180237530
	private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

	// RVA: 0x237540 Offset: 0x236940 VA: 0x180237540
	private void PushAncestors(XElement e) { }

	// RVA: 0x237550 Offset: 0x236950 VA: 0x180237550
	private void PushElement(XElement e) { }

	// RVA: 0x237570 Offset: 0x236970 VA: 0x180237570
	private void WriteEndElement() { }

	// RVA: 0x2375B0 Offset: 0x2369B0 VA: 0x1802375B0
	private void WriteFullEndElement() { }

	// RVA: 0x2375F0 Offset: 0x2369F0 VA: 0x1802375F0
	private void WriteStartElement(XElement e) { }

}

