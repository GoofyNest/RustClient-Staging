internal class StringFacetsChecker : FacetsChecker // TypeDefIndex: 2252
{	// Fields
	private static Regex languagePattern; // 0x14304

	// Properties
	private static Regex LanguagePattern { get; }

	// Methods

	// RVA: 0xEF0460 Offset: 0xEEEA60 VA: 0x180EF0460
	private static Regex get_LanguagePattern() { }

	// RVA: 0xEF0140 Offset: 0xEEE740 VA: 0x180EF0140 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0xEEFF00 Offset: 0xEEE500 VA: 0x180EEFF00 Slot: 13
	internal override Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0xEEFF20 Offset: 0xEEE520 VA: 0x180EEFF20
	internal Exception CheckValueFacets(string value, XmlSchemaDatatype datatype, bool verifyUri) { }

	// RVA: 0xEF03D0 Offset: 0xEEE9D0 VA: 0x180EF03D0 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xEF01C0 Offset: 0xEEE7C0 VA: 0x180EF01C0
	private bool MatchEnumeration(string value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xEEFC20 Offset: 0xEEE220 VA: 0x180EEFC20
	private Exception CheckBuiltInFacets(string s, XmlTypeCode typeCode, bool verifyUri) { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

}

