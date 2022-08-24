internal class Numeric10FacetsChecker : FacetsChecker // TypeDefIndex: 2248
{
	private static readonly char[] signs; 
	private Decimal maxValue; 
	private Decimal minValue; 


internal void .ctor(Decimal minVal, Decimal maxVal) { }

internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

internal override Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

internal override Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

internal override Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

internal override Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

internal bool MatchEnumeration(Decimal value, ArrayList enumeration, XmlValueConverter valueConverter) { }

internal Exception CheckTotalAndFractionDigits(Decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction) { }

private static void .cctor() { }

}

