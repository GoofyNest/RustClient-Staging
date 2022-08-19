internal class DurationFacetsChecker : FacetsChecker // TypeDefIndex: 2250
{	// Methods

	// RVA: 0x1519B70 Offset: 0x1518170 VA: 0x181519B70 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1519C80 Offset: 0x1518280 VA: 0x181519C80 Slot: 15
	internal override Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x151A030 Offset: 0x1518630 VA: 0x18151A030 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x151A0C0 Offset: 0x15186C0 VA: 0x18151A0C0
	private bool MatchEnumeration(TimeSpan value, ArrayList enumeration) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

