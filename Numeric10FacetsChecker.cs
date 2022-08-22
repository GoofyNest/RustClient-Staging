internal class Numeric10FacetsChecker : FacetsChecker // TypeDefIndex: 2248
{	// Fields
	private static readonly char[] signs; // 0x0
	private Decimal maxValue; // 0x10
	private Decimal minValue; // 0x20

	// Methods

	// RVA: 0xB14900 Offset: 0xB12F00 VA: 0x180B14900
	internal void .ctor(Decimal minVal, Decimal maxVal) { }

	// RVA: 0xB14530 Offset: 0xB12B30 VA: 0x180B14530 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0xB13DD0 Offset: 0xB123D0 VA: 0x180B13DD0 Slot: 6
	internal override Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0xB13D30 Offset: 0xB12330 VA: 0x180B13D30 Slot: 7
	internal override Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

	// RVA: 0xB14490 Offset: 0xB12A90 VA: 0x180B14490 Slot: 8
	internal override Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0xB143F0 Offset: 0xB129F0 VA: 0x180B143F0 Slot: 9
	internal override Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

	// RVA: 0xB146E0 Offset: 0xB12CE0 VA: 0x180B146E0 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xB145C0 Offset: 0xB12BC0 VA: 0x180B145C0
	internal bool MatchEnumeration(Decimal value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0xB13A70 Offset: 0xB12070 VA: 0x180B13A70
	internal Exception CheckTotalAndFractionDigits(Decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction) { }

	// RVA: 0xB14860 Offset: 0xB12E60 VA: 0x180B14860
	private static void .cctor() { }

}

