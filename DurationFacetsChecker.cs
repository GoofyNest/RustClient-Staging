internal class DurationFacetsChecker : FacetsChecker // TypeDefIndex: 2250
{	// Methods

	// RVA: 0x1519E30 Offset: 0x1518430 VA: 0x181519E30 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1519F40 Offset: 0x1518540 VA: 0x181519F40 Slot: 15
	internal override Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x151A2F0 Offset: 0x15188F0 VA: 0x18151A2F0 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x151A380 Offset: 0x1518980 VA: 0x18151A380
	private bool MatchEnumeration(TimeSpan value, ArrayList enumeration) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

