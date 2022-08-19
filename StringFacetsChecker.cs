internal class StringFacetsChecker : FacetsChecker // TypeDefIndex: 2252
{	// Fields
	private static Regex languagePattern; // 0x14304

	// Properties
	private static Regex LanguagePattern { get; }

	// Methods

	// RVA: 0xEF01A0 Offset: 0xEEE7A0 VA: 0x180EF01A0
	private static Regex get_LanguagePattern() { }

	// RVA: 0xEEFE80 Offset: 0xEEE480 VA: 0x180EEFE80 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0xEEFC40 Offset: 0xEEE240 VA: 0x180EEFC40 Slot: 13
	internal override Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0xEEFC60 Offset: 0xEEE260 VA: 0x180EEFC60
	internal Exception CheckValueFacets(string value, XmlSchemaDatatype datatype, bool verifyUri) { }

	// RVA: 0xEF0110 Offset: 0xEEE710 VA: 0x180EF0110 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xEEFF00 Offset: 0xEEE500 VA: 0x180EEFF00
	private bool MatchEnumeration(string value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xEEF960 Offset: 0xEEDF60 VA: 0x180EEF960
	private Exception CheckBuiltInFacets(string s, XmlTypeCode typeCode, bool verifyUri) { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

}

