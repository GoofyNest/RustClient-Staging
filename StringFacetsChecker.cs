internal class StringFacetsChecker : FacetsChecker // TypeDefIndex: 2252
{	// Fields
	private static Regex languagePattern; // 0x14070

	// Properties
	private static Regex LanguagePattern { get; }

	// Methods

	// RVA: 0xEF0F10 Offset: 0xEEF510 VA: 0x180EF0F10
	private static Regex get_LanguagePattern() { }

	// RVA: 0xEF0BF0 Offset: 0xEEF1F0 VA: 0x180EF0BF0 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0xEF09B0 Offset: 0xEEEFB0 VA: 0x180EF09B0 Slot: 13
	internal override Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0xEF09D0 Offset: 0xEEEFD0 VA: 0x180EF09D0
	internal Exception CheckValueFacets(string value, XmlSchemaDatatype datatype, bool verifyUri) { }

	// RVA: 0xEF0E80 Offset: 0xEEF480 VA: 0x180EF0E80 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xEF0C70 Offset: 0xEEF270 VA: 0x180EF0C70
	private bool MatchEnumeration(string value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xEF06D0 Offset: 0xEEECD0 VA: 0x180EF06D0
	private Exception CheckBuiltInFacets(string s, XmlTypeCode typeCode, bool verifyUri) { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

}

