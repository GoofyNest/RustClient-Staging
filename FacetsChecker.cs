internal abstract class FacetsChecker // TypeDefIndex: 2245
{	// Methods

	// RVA: 0x1519550 Offset: 0x1517B50 VA: 0x181519550 Slot: 4
	internal virtual Exception CheckLexicalFacets(ref string parseString, XmlSchemaDatatype datatype) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 5
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 6
	internal virtual Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 7
	internal virtual Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 8
	internal virtual Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 9
	internal virtual Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 10
	internal virtual Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 11
	internal virtual Exception CheckValueFacets(double value, XmlSchemaDatatype datatype) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 12
	internal virtual Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 13
	internal virtual Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 14
	internal virtual Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 15
	internal virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 16
	internal virtual Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1519750 Offset: 0x1517D50 VA: 0x181519750
	internal void CheckWhitespaceFacets(ref string s, XmlSchemaDatatype datatype) { }

	// RVA: 0x15195B0 Offset: 0x1517BB0 VA: 0x1815195B0
	internal Exception CheckPatternFacets(RestrictionFacets restriction, string value) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 17
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1519840 Offset: 0x1517E40 VA: 0x181519840 Slot: 18
	internal virtual RestrictionFacets ConstructRestriction(DatatypeImplementation datatype, XmlSchemaObjectCollection facets, XmlNameTable nameTable) { }

	// RVA: 0x1519FD0 Offset: 0x15185D0 VA: 0x181519FD0
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

	// RVA: 0x1F20B0 Offset: 0x1F14B0 VA: 0x1801F20B0
	public void .ctor(DatatypeImplementation baseDatatype, RestrictionFacets restriction) { }

	// RVA: 0x1F1F50 Offset: 0x1F1350 VA: 0x1801F1F50
	internal void CompileLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1FB0 Offset: 0x1F13B0 VA: 0x1801F1FB0
	internal void CompileMinLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1F80 Offset: 0x1F1380 VA: 0x1801F1F80
	internal void CompileMaxLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1FC0 Offset: 0x1F13C0 VA: 0x1801F1FC0
	internal void CompilePatternFacet(XmlSchemaPatternFacet facet) { }

	// RVA: 0x1F1F20 Offset: 0x1F1320 VA: 0x1801F1F20
	internal void CompileEnumerationFacet(XmlSchemaFacet facet, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	// RVA: 0x1F1FE0 Offset: 0x1F13E0 VA: 0x1801F1FE0
	internal void CompileWhitespaceFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1F70 Offset: 0x1F1370 VA: 0x1801F1F70
	internal void CompileMaxInclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1F60 Offset: 0x1F1360 VA: 0x1801F1F60
	internal void CompileMaxExclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1FA0 Offset: 0x1F13A0 VA: 0x1801F1FA0
	internal void CompileMinInclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1F90 Offset: 0x1F1390 VA: 0x1801F1F90
	internal void CompileMinExclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1FD0 Offset: 0x1F13D0 VA: 0x1801F1FD0
	internal void CompileTotalDigitsFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1F40 Offset: 0x1F1340 VA: 0x1801F1F40
	internal void CompileFractionDigitsFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F2000 Offset: 0x1F1400 VA: 0x1801F2000
	internal void FinishFacetCompile() { }

	// RVA: 0x1F1F10 Offset: 0x1F1310 VA: 0x1801F1F10
	private void CheckValue(object value, XmlSchemaFacet facet) { }

	// RVA: 0x1F1F30 Offset: 0x1F1330 VA: 0x1801F1F30
	internal void CompileFacetCombinations() { }

	// RVA: 0x1F1FF0 Offset: 0x1F13F0 VA: 0x1801F1FF0
	private void CopyFacetsFromBaseType() { }

	// RVA: 0x1F2010 Offset: 0x1F1410 VA: 0x1801F2010
	private object ParseFacetValue(XmlSchemaDatatype datatype, XmlSchemaFacet facet, string code, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	// RVA: 0x151D240 Offset: 0x151B840 VA: 0x18151D240
	private static string Preprocess(string pattern) { }

	// RVA: 0x1F1F00 Offset: 0x1F1300 VA: 0x1801F1F00
	private void CheckProhibitedFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	// RVA: 0x1F1EF0 Offset: 0x1F12F0 VA: 0x1801F1EF0
	private void CheckDupFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	// RVA: 0x1F2020 Offset: 0x1F1420 VA: 0x1801F2020
	private void SetFlag(XmlSchemaFacet facet, RestrictionFlags flag) { }

	// RVA: 0x1F2080 Offset: 0x1F1480 VA: 0x1801F2080
	private void SetFlag(RestrictionFlags flag) { }

	// RVA: 0x151D510 Offset: 0x151BB10 VA: 0x18151D510
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

