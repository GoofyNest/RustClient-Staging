internal class Numeric10FacetsChecker : FacetsChecker // TypeDefIndex: 2248
{	// Fields
	private static readonly char[] signs; // 0x0
	private Decimal maxValue; // 0x10
	private Decimal minValue; // 0x20

	// Methods

	// RVA: 0xB14640 Offset: 0xB12C40 VA: 0x180B14640
	internal void .ctor(Decimal minVal, Decimal maxVal) { }

	// RVA: 0xB14270 Offset: 0xB12870 VA: 0x180B14270 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0xB13B10 Offset: 0xB12110 VA: 0x180B13B10 Slot: 6
	internal override Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0xB13A70 Offset: 0xB12070 VA: 0x180B13A70 Slot: 7
	internal override Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

	// RVA: 0xB141D0 Offset: 0xB127D0 VA: 0x180B141D0 Slot: 8
	internal override Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0xB14130 Offset: 0xB12730 VA: 0x180B14130 Slot: 9
	internal override Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

	// RVA: 0xB14420 Offset: 0xB12A20 VA: 0x180B14420 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xB14300 Offset: 0xB12900 VA: 0x180B14300
	internal bool MatchEnumeration(Decimal value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0xB137B0 Offset: 0xB11DB0 VA: 0x180B137B0
	internal Exception CheckTotalAndFractionDigits(Decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction) { }

	// RVA: 0xB145A0 Offset: 0xB12BA0 VA: 0x180B145A0
	private static void .cctor() { }

}

