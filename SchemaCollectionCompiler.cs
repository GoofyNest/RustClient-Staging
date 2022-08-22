internal sealed class SchemaCollectionCompiler : BaseProcessor // TypeDefIndex: 2272
{	// Fields
	private bool compileContentModel; // 0x40
	private XmlSchemaObjectTable examplars; // 0x48
	private Stack complexTypeStack; // 0x50
	private XmlSchema schema; // 0x58

	// Methods

	// RVA: 0xB3BEC0 Offset: 0xB3A4C0 VA: 0x180B3BEC0
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler) { }

	// RVA: 0xB38880 Offset: 0xB36E80 VA: 0x180B38880
	public bool Execute(XmlSchema schema, SchemaInfo schemaInfo, bool compileContentModel) { }

	// RVA: 0xB3BB60 Offset: 0xB3A160 VA: 0x180B3BB60
	private void Prepare() { }

	// RVA: 0xB2D9B0 Offset: 0xB2BFB0 VA: 0x180B2D9B0
	private void Cleanup() { }

	// RVA: 0xB2E660 Offset: 0xB2CC60 VA: 0x180B2E660
	internal static void Cleanup(XmlSchema schema) { }

	// RVA: 0xB36410 Offset: 0xB34A10 VA: 0x180B36410
	private void Compile() { }

	// RVA: 0xB3AF10 Offset: 0xB39510 VA: 0x180B3AF10
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0xB2CEE0 Offset: 0xB2B4E0 VA: 0x180B2CEE0
	private static void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0xB2CE80 Offset: 0xB2B480 VA: 0x180B2CE80
	private static void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xB2D030 Offset: 0xB2B630 VA: 0x180B2D030
	private static void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0xB2D990 Offset: 0xB2BF90 VA: 0x180B2D990
	private static void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0xB2D4F0 Offset: 0xB2BAF0 VA: 0x180B2D4F0
	private static void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0xB2CF30 Offset: 0xB2B530 VA: 0x180B2CF30
	private static void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0xB2D700 Offset: 0xB2BD00 VA: 0x180B2D700
	private static void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0xB2D740 Offset: 0xB2BD40 VA: 0x180B2D740
	private static void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0xB35ED0 Offset: 0xB344D0 VA: 0x180B35ED0
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroupV1Compat substitutionGroup) { }

	// RVA: 0xB2CB10 Offset: 0xB2B110 VA: 0x180B2CB10
	private void CheckSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0xB33490 Offset: 0xB31A90 VA: 0x180B33490
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0xB35650 Offset: 0xB33C50 VA: 0x180B35650
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0xB30030 Offset: 0xB2E630 VA: 0x180B30030
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0xB2CD50 Offset: 0xB2B350 VA: 0x180B2CD50
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0xB31B40 Offset: 0xB30140 VA: 0x180B31B40
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0xB34FD0 Offset: 0xB335D0 VA: 0x180B34FD0
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0xB35260 Offset: 0xB33860 VA: 0x180B35260
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0xB30590 Offset: 0xB2EB90 VA: 0x180B30590
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0xB30A30 Offset: 0xB2F030 VA: 0x180B30A30
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0xB2C9C0 Offset: 0xB2AFC0 VA: 0x180B2C9C0
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0xB32640 Offset: 0xB30C40 VA: 0x180B32640
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle, bool substitution) { }

	// RVA: 0xB2BFE0 Offset: 0xB2A5E0 VA: 0x180B2BFE0
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root, bool substitution) { }

	// RVA: 0xB2B790 Offset: 0xB29D90 VA: 0x180B2B790
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element, bool substitution) { }

	// RVA: 0xB2B950 Offset: 0xB29F50 VA: 0x180B2B950
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root, bool substitution) { }

	// RVA: 0xB2AB60 Offset: 0xB29160 VA: 0x180B2AB60
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root, bool substitution) { }

	// RVA: 0xB2B0F0 Offset: 0xB296F0 VA: 0x180B2B0F0
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root, bool substitution) { }

	// RVA: 0xB2C390 Offset: 0xB2A990 VA: 0x180B2C390
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root, bool substitution) { }

	// RVA: 0xB3A2E0 Offset: 0xB388E0 VA: 0x180B3A2E0
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0xB38F90 Offset: 0xB37590 VA: 0x180B38F90
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0xB38F20 Offset: 0xB37520 VA: 0x180B38F20
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0xB38EC0 Offset: 0xB374C0 VA: 0x180B38EC0
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0xB39460 Offset: 0xB37A60 VA: 0x180B39460
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0xB390C0 Offset: 0xB376C0 VA: 0x180B390C0
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0xB39730 Offset: 0xB37D30 VA: 0x180B39730
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0xB39AC0 Offset: 0xB380C0 VA: 0x180B39AC0
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0xB39E10 Offset: 0xB38410 VA: 0x180B39E10
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0xB2A710 Offset: 0xB28D10 VA: 0x180B2A710
	private void CalculateSequenceRange(XmlSchemaSequence sequence, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0xB3A0E0 Offset: 0xB386E0 VA: 0x180B3A0E0
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0xB3A200 Offset: 0xB38800 VA: 0x180B3A200
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0xB38BB0 Offset: 0xB371B0 VA: 0x180B38BB0
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0xB39A00 Offset: 0xB38000 VA: 0x180B39A00
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0xB29DF0 Offset: 0xB283F0 VA: 0x180B29DF0
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0xB3BE90 Offset: 0xB3A490 VA: 0x180B3BE90
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0xB38CC0 Offset: 0xB372C0 VA: 0x180B38CC0
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0xB2EFC0 Offset: 0xB2D5C0 VA: 0x180B2EFC0
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xB33B40 Offset: 0xB32140 VA: 0x180B33B40
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0xB2EF20 Offset: 0xB2D520 VA: 0x180B2EF20
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0xB2EE80 Offset: 0xB2D480 VA: 0x180B2EE80
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0xB2F6B0 Offset: 0xB2DCB0 VA: 0x180B2F6B0
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0xB33580 Offset: 0xB31B80 VA: 0x180B33580
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0xB327F0 Offset: 0xB30DF0 VA: 0x180B327F0
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0xB30D50 Offset: 0xB2F350 VA: 0x180B30D50
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0xB294B0 Offset: 0xB27AB0 VA: 0x180B294B0
	private void BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0xB34C40 Offset: 0xB33240 VA: 0x180B34C40
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0xB304C0 Offset: 0xB2EAC0 VA: 0x180B304C0
	private void CompileCompexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0xB38D40 Offset: 0xB37340 VA: 0x180B38D40
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0xB38AE0 Offset: 0xB370E0 VA: 0x180B38AE0
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0xB38900 Offset: 0xB36F00 VA: 0x180B38900
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

}

