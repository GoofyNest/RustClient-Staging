internal abstract class FacetsChecker // TypeDefIndex: 2245
{	// Methods

	// RVA: 0x151A1C0 Offset: 0x15187C0 VA: 0x18151A1C0 Slot: 4
	internal virtual Exception CheckLexicalFacets(ref string parseString, XmlSchemaDatatype datatype) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 6
	internal virtual Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 7
	internal virtual Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 8
	internal virtual Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 9
	internal virtual Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 10
	internal virtual Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 11
	internal virtual Exception CheckValueFacets(double value, XmlSchemaDatatype datatype) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 12
	internal virtual Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 13
	internal virtual Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 14
	internal virtual Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 15
	internal virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 16
	internal virtual Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	// RVA: 0x151A3C0 Offset: 0x15189C0 VA: 0x18151A3C0
	internal void CheckWhitespaceFacets(ref string s, XmlSchemaDatatype datatype) { }

	// RVA: 0x151A220 Offset: 0x1518820 VA: 0x18151A220
	internal Exception CheckPatternFacets(RestrictionFacets restriction, string value) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 17
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x151A4B0 Offset: 0x1518AB0 VA: 0x18151A4B0 Slot: 18
	internal virtual RestrictionFacets ConstructRestriction(DatatypeImplementation datatype, XmlSchemaObjectCollection facets, XmlNameTable nameTable) { }

	// RVA: 0x151AC40 Offset: 0x1519240 VA: 0x18151AC40
	internal static Decimal Power(int x, int y) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

private struct FacetsChecker.FacetsCompiler // TypeDefIndex: 2246
{	// Fields
	private DatatypeImplementation datatype; // 0x0
	private RestrictionFacets derivedRestriction; // 0x8
	private RestrictionFlags baseFlags; // 0x10
	private RestrictionFlags baseFixedFlags; // 0x14
	private RestrictionFlags validRestrictionFlags; // 0x18
	private XmlSchemaDatatype nonNegativeInt; // 0x20
	private XmlSchemaDatatype builtInType; // 0x28
	private XmlTypeCode builtInEnum; // 0x30
	private bool firstPattern; // 0x34
	private StringBuilder regStr; // 0x38
	private XmlSchemaPatternFacet pattern_facet; // 0x40
	private static readonly FacetsChecker.FacetsCompiler.Map[] c_map; // 0x0

	// Methods

	// RVA: 0x1F1C90 Offset: 0x1F1090 VA: 0x1801F1C90
	public void .ctor(DatatypeImplementation baseDatatype, RestrictionFacets restriction) { }

	// RVA: 0x1F1B30 Offset: 0x1F0F30 VA: 0x1801F1B30
	internal void CompileLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1B90 Offset: 0x1F0F90 VA: 0x1801F1B90
	internal void CompileMinLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1B60 Offset: 0x1F0F60 VA: 0x1801F1B60
	internal void CompileMaxLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1BA0 Offset: 0x1F0FA0 VA: 0x1801F1BA0
	internal void CompilePatternFacet(XmlSchemaPatternFacet facet) { }

	// RVA: 0x1F1B00 Offset: 0x1F0F00 VA: 0x1801F1B00
	internal void CompileEnumerationFacet(XmlSchemaFacet facet, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	// RVA: 0x1F1BC0 Offset: 0x1F0FC0 VA: 0x1801F1BC0
	internal void CompileWhitespaceFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1B50 Offset: 0x1F0F50 VA: 0x1801F1B50
	internal void CompileMaxInclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1B40 Offset: 0x1F0F40 VA: 0x1801F1B40
	internal void CompileMaxExclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1B80 Offset: 0x1F0F80 VA: 0x1801F1B80
	internal void CompileMinInclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1B70 Offset: 0x1F0F70 VA: 0x1801F1B70
	internal void CompileMinExclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1BB0 Offset: 0x1F0FB0 VA: 0x1801F1BB0
	internal void CompileTotalDigitsFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1B20 Offset: 0x1F0F20 VA: 0x1801F1B20
	internal void CompileFractionDigitsFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1BE0 Offset: 0x1F0FE0 VA: 0x1801F1BE0
	internal void FinishFacetCompile() { }

	// RVA: 0x1F1AF0 Offset: 0x1F0EF0 VA: 0x1801F1AF0
	private void CheckValue(object value, XmlSchemaFacet facet) { }

	// RVA: 0x1F1B10 Offset: 0x1F0F10 VA: 0x1801F1B10
	internal void CompileFacetCombinations() { }

	// RVA: 0x1F1BD0 Offset: 0x1F0FD0 VA: 0x1801F1BD0
	private void CopyFacetsFromBaseType() { }

	// RVA: 0x1F1BF0 Offset: 0x1F0FF0 VA: 0x1801F1BF0
	private object ParseFacetValue(XmlSchemaDatatype datatype, XmlSchemaFacet facet, string code, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	// RVA: 0x151DEB0 Offset: 0x151C4B0 VA: 0x18151DEB0
	private static string Preprocess(string pattern) { }

	// RVA: 0x1F1AE0 Offset: 0x1F0EE0 VA: 0x1801F1AE0
	private void CheckProhibitedFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	// RVA: 0x1F1AD0 Offset: 0x1F0ED0 VA: 0x1801F1AD0
	private void CheckDupFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	// RVA: 0x1F1C00 Offset: 0x1F1000 VA: 0x1801F1C00
	private void SetFlag(XmlSchemaFacet facet, RestrictionFlags flag) { }

	// RVA: 0x1F1C60 Offset: 0x1F1060 VA: 0x1801F1C60
	private void SetFlag(RestrictionFlags flag) { }

	// RVA: 0x151E180 Offset: 0x151C780 VA: 0x18151E180
	private static void .cctor() { }

}

private struct FacetsChecker.FacetsCompiler.Map // TypeDefIndex: 2247
{	// Fields
	internal char match; // 0x0
	internal string replacement; // 0x8

	// Methods

	// RVA: 0xFCA60 Offset: 0xFBE60 VA: 0x1800FCA60
	internal void .ctor(char m, string r) { }

}

