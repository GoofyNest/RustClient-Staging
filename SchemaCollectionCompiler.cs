internal sealed class SchemaCollectionCompiler : BaseProcessor // TypeDefIndex: 2272
{	// Fields
	private bool compileContentModel; // 0x40
	private XmlSchemaObjectTable examplars; // 0x48
	private Stack complexTypeStack; // 0x50
	private XmlSchema schema; // 0x58

	// Methods

	// RVA: 0xB3B730 Offset: 0xB39D30 VA: 0x180B3B730
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler) { }

	// RVA: 0xB380F0 Offset: 0xB366F0 VA: 0x180B380F0
	public bool Execute(XmlSchema schema, SchemaInfo schemaInfo, bool compileContentModel) { }

	// RVA: 0xB3B3D0 Offset: 0xB399D0 VA: 0x180B3B3D0
	private void Prepare() { }

	// RVA: 0xB2D220 Offset: 0xB2B820 VA: 0x180B2D220
	private void Cleanup() { }

	// RVA: 0xB2DED0 Offset: 0xB2C4D0 VA: 0x180B2DED0
	internal static void Cleanup(XmlSchema schema) { }

	// RVA: 0xB35C80 Offset: 0xB34280 VA: 0x180B35C80
	private void Compile() { }

	// RVA: 0xB3A780 Offset: 0xB38D80 VA: 0x180B3A780
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0xB2C750 Offset: 0xB2AD50 VA: 0x180B2C750
	private static void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0xB2C6F0 Offset: 0xB2ACF0 VA: 0x180B2C6F0
	private static void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xB2C8A0 Offset: 0xB2AEA0 VA: 0x180B2C8A0
	private static void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0xB2D200 Offset: 0xB2B800 VA: 0x180B2D200
	private static void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0xB2CD60 Offset: 0xB2B360 VA: 0x180B2CD60
	private static void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0xB2C7A0 Offset: 0xB2ADA0 VA: 0x180B2C7A0
	private static void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0xB2CF70 Offset: 0xB2B570 VA: 0x180B2CF70
	private static void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0xB2CFB0 Offset: 0xB2B5B0 VA: 0x180B2CFB0
	private static void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0xB35740 Offset: 0xB33D40 VA: 0x180B35740
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroupV1Compat substitutionGroup) { }

	// RVA: 0xB2C380 Offset: 0xB2A980 VA: 0x180B2C380
	private void CheckSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0xB32D00 Offset: 0xB31300 VA: 0x180B32D00
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0xB34EC0 Offset: 0xB334C0 VA: 0x180B34EC0
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0xB2F8A0 Offset: 0xB2DEA0 VA: 0x180B2F8A0
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0xB2C5C0 Offset: 0xB2ABC0 VA: 0x180B2C5C0
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0xB313B0 Offset: 0xB2F9B0 VA: 0x180B313B0
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0xB34840 Offset: 0xB32E40 VA: 0x180B34840
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0xB34AD0 Offset: 0xB330D0 VA: 0x180B34AD0
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0xB2FE00 Offset: 0xB2E400 VA: 0x180B2FE00
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0xB302A0 Offset: 0xB2E8A0 VA: 0x180B302A0
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0xB2C230 Offset: 0xB2A830 VA: 0x180B2C230
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0xB31EB0 Offset: 0xB304B0 VA: 0x180B31EB0
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle, bool substitution) { }

	// RVA: 0xB2B850 Offset: 0xB29E50 VA: 0x180B2B850
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root, bool substitution) { }

	// RVA: 0xB2B000 Offset: 0xB29600 VA: 0x180B2B000
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element, bool substitution) { }

	// RVA: 0xB2B1C0 Offset: 0xB297C0 VA: 0x180B2B1C0
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root, bool substitution) { }

	// RVA: 0xB2A3D0 Offset: 0xB289D0 VA: 0x180B2A3D0
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root, bool substitution) { }

	// RVA: 0xB2A960 Offset: 0xB28F60 VA: 0x180B2A960
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root, bool substitution) { }

	// RVA: 0xB2BC00 Offset: 0xB2A200 VA: 0x180B2BC00
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root, bool substitution) { }

	// RVA: 0xB39B50 Offset: 0xB38150 VA: 0x180B39B50
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0xB38800 Offset: 0xB36E00 VA: 0x180B38800
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0xB38790 Offset: 0xB36D90 VA: 0x180B38790
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0xB38730 Offset: 0xB36D30 VA: 0x180B38730
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0xB38CD0 Offset: 0xB372D0 VA: 0x180B38CD0
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0xB38930 Offset: 0xB36F30 VA: 0x180B38930
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0xB38FA0 Offset: 0xB375A0 VA: 0x180B38FA0
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0xB39330 Offset: 0xB37930 VA: 0x180B39330
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0xB39680 Offset: 0xB37C80 VA: 0x180B39680
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0xB29F80 Offset: 0xB28580 VA: 0x180B29F80
	private void CalculateSequenceRange(XmlSchemaSequence sequence, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0xB39950 Offset: 0xB37F50 VA: 0x180B39950
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0xB39A70 Offset: 0xB38070 VA: 0x180B39A70
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0xB38420 Offset: 0xB36A20 VA: 0x180B38420
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0xB39270 Offset: 0xB37870 VA: 0x180B39270
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0xB29660 Offset: 0xB27C60 VA: 0x180B29660
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0xB3B700 Offset: 0xB39D00 VA: 0x180B3B700
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0xB38530 Offset: 0xB36B30 VA: 0x180B38530
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0xB2E830 Offset: 0xB2CE30 VA: 0x180B2E830
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xB333B0 Offset: 0xB319B0 VA: 0x180B333B0
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0xB2E790 Offset: 0xB2CD90 VA: 0x180B2E790
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0xB2E6F0 Offset: 0xB2CCF0 VA: 0x180B2E6F0
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0xB2EF20 Offset: 0xB2D520 VA: 0x180B2EF20
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0xB32DF0 Offset: 0xB313F0 VA: 0x180B32DF0
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0xB32060 Offset: 0xB30660 VA: 0x180B32060
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0xB305C0 Offset: 0xB2EBC0 VA: 0x180B305C0
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0xB28D20 Offset: 0xB27320 VA: 0x180B28D20
	private void BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0xB344B0 Offset: 0xB32AB0 VA: 0x180B344B0
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0xB2FD30 Offset: 0xB2E330 VA: 0x180B2FD30
	private void CompileCompexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0xB385B0 Offset: 0xB36BB0 VA: 0x180B385B0
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0xB38350 Offset: 0xB36950 VA: 0x180B38350
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0xB38170 Offset: 0xB36770 VA: 0x180B38170
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

}

