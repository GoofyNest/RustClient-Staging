internal class DurationFacetsChecker : FacetsChecker // TypeDefIndex: 2250
{	// Methods

	// RVA: 0x1518F00 Offset: 0x1517500 VA: 0x181518F00 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1519010 Offset: 0x1517610 VA: 0x181519010 Slot: 15
	internal override Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x15193C0 Offset: 0x15179C0 VA: 0x1815193C0 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1519450 Offset: 0x1517A50 VA: 0x181519450
	private bool MatchEnumeration(TimeSpan value, ArrayList enumeration) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

