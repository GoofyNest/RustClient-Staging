internal class Numeric10FacetsChecker : FacetsChecker // TypeDefIndex: 2248
{	// Fields
	private static readonly char[] signs; // 0x0
	private Decimal maxValue; // 0x10
	private Decimal minValue; // 0x20

	// Methods

	// RVA: 0xB14DD0 Offset: 0xB133D0 VA: 0x180B14DD0
	internal void .ctor(Decimal minVal, Decimal maxVal) { }

	// RVA: 0xB14A00 Offset: 0xB13000 VA: 0x180B14A00 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0xB142A0 Offset: 0xB128A0 VA: 0x180B142A0 Slot: 6
	internal override Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0xB14200 Offset: 0xB12800 VA: 0x180B14200 Slot: 7
	internal override Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

	// RVA: 0xB14960 Offset: 0xB12F60 VA: 0x180B14960 Slot: 8
	internal override Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0xB148C0 Offset: 0xB12EC0 VA: 0x180B148C0 Slot: 9
	internal override Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

	// RVA: 0xB14BB0 Offset: 0xB131B0 VA: 0x180B14BB0 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xB14A90 Offset: 0xB13090 VA: 0x180B14A90
	internal bool MatchEnumeration(Decimal value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0xB13F40 Offset: 0xB12540 VA: 0x180B13F40
	internal Exception CheckTotalAndFractionDigits(Decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction) { }

	// RVA: 0xB14D30 Offset: 0xB13330 VA: 0x180B14D30
	private static void .cctor() { }

}

