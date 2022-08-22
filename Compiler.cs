internal sealed class Compiler : BaseProcessor // TypeDefIndex: 2285
{	// Fields
	private string restrictionErrorMsg; // 0x40
	private XmlSchemaObjectTable attributes; // 0x48
	private XmlSchemaObjectTable attributeGroups; // 0x50
	private XmlSchemaObjectTable elements; // 0x58
	private XmlSchemaObjectTable schemaTypes; // 0x60
	private XmlSchemaObjectTable groups; // 0x68
	private XmlSchemaObjectTable notations; // 0x70
	private XmlSchemaObjectTable examplars; // 0x78
	private XmlSchemaObjectTable identityConstraints; // 0x80
	private Stack complexTypeStack; // 0x88
	private Hashtable schemasToCompile; // 0x90
	private Hashtable importedSchemas; // 0x98
	private XmlSchema schemaForSchema; // 0xA0

	// Methods

	// RVA: 0xF5F710 Offset: 0xF5DD10 VA: 0x180F5F710
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchema schemaForSchema, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0xF570F0 Offset: 0xF556F0 VA: 0x180F570F0
	public bool Execute(XmlSchemaSet schemaSet, SchemaInfo schemaCompiledInfo) { }

	// RVA: 0xF5C8F0 Offset: 0xF5AEF0 VA: 0x180F5C8F0
	internal void Prepare(XmlSchema schema, bool cleanup) { }

	// RVA: 0xF5F590 Offset: 0xF5DB90 VA: 0x180F5F590
	private void UpdateSForSSimpleTypes() { }

	// RVA: 0xF5BB80 Offset: 0xF5A180 VA: 0x180F5BB80
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0xF57630 Offset: 0xF55C30 VA: 0x180F57630
	internal void ImportAllCompiledSchemas(XmlSchemaSet schemaSet) { }

	// RVA: 0xF551C0 Offset: 0xF537C0 VA: 0x180F551C0
	internal bool Compile() { }

	// RVA: 0xF4CD70 Offset: 0xF4B370 VA: 0x180F4CD70
	private void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0xF4CCF0 Offset: 0xF4B2F0 VA: 0x180F4CCF0
	private void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xF4D000 Offset: 0xF4B600 VA: 0x180F4D000
	private void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0xF4DC80 Offset: 0xF4C280 VA: 0x180F4DC80
	private void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0xF4D550 Offset: 0xF4BB50 VA: 0x180F4D550
	private void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0xF4CE60 Offset: 0xF4B460 VA: 0x180F4CE60
	private void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0xF4D7F0 Offset: 0xF4BDF0 VA: 0x180F4D7F0
	private void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0xF4D850 Offset: 0xF4BE50 VA: 0x180F4D850
	private void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0xF5EB30 Offset: 0xF5D130 VA: 0x180F5EB30
	private void ProcessSubstitutionGroups() { }

	// RVA: 0xF54CB0 Offset: 0xF532B0 VA: 0x180F54CB0
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0xF5F270 Offset: 0xF5D870 VA: 0x180F5F270
	private void RecursivelyCheckRedefinedGroups(XmlSchemaGroup redefinedGroup, XmlSchemaGroup baseGroup) { }

	// RVA: 0xF5F1E0 Offset: 0xF5D7E0 VA: 0x180F5F1E0
	private void RecursivelyCheckRedefinedAttributeGroups(XmlSchemaAttributeGroup attributeGroup, XmlSchemaAttributeGroup baseAttributeGroup) { }

	// RVA: 0xF51F60 Offset: 0xF50560 VA: 0x180F51F60
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0xF54400 Offset: 0xF52A00 VA: 0x180F54400
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0xF4ED40 Offset: 0xF4D340 VA: 0x180F4ED40
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0xF4CBC0 Offset: 0xF4B1C0 VA: 0x180F4CBC0
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0xF50780 Offset: 0xF4ED80 VA: 0x180F50780
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0xF53D80 Offset: 0xF52380 VA: 0x180F53D80
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0xF54010 Offset: 0xF52610 VA: 0x180F54010
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0xF4F1D0 Offset: 0xF4D7D0 VA: 0x180F4F1D0
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0xF4F5B0 Offset: 0xF4DBB0 VA: 0x180F4F5B0
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0xF4C660 Offset: 0xF4AC60 VA: 0x180F4C660
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0xF4CAF0 Offset: 0xF4B0F0 VA: 0x180F4CAF0
	private void CheckParticleDerivation(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0xF51090 Offset: 0xF4F690 VA: 0x180F51090
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle) { }

	// RVA: 0xF4B040 Offset: 0xF49640 VA: 0x180F4B040
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root) { }

	// RVA: 0xF4A740 Offset: 0xF48D40 VA: 0x180F4A740
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element) { }

	// RVA: 0xF4A9D0 Offset: 0xF48FD0 VA: 0x180F4A9D0
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root) { }

	// RVA: 0xF49DA0 Offset: 0xF483A0 VA: 0x180F49DA0
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root) { }

	// RVA: 0xF4A080 Offset: 0xF48680 VA: 0x180F4A080
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root) { }

	// RVA: 0xF4B8C0 Offset: 0xF49EC0 VA: 0x180F4B8C0
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root) { }

	// RVA: 0xF4B3A0 Offset: 0xF499A0 VA: 0x180F4B3A0
	private XmlSchemaParticle CannonicalizePointlessRoot(XmlSchemaParticle particle) { }

	// RVA: 0xF59EB0 Offset: 0xF584B0 VA: 0x180F59EB0
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0xF57BC0 Offset: 0xF561C0 VA: 0x180F57BC0
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0xF579D0 Offset: 0xF55FD0 VA: 0x180F579D0
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0xF57740 Offset: 0xF55D40 VA: 0x180F57740
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0xF58AF0 Offset: 0xF570F0 VA: 0x180F58AF0
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0xF57E30 Offset: 0xF56430 VA: 0x180F57E30
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase) { }

	// RVA: 0xF57820 Offset: 0xF55E20 VA: 0x180F57820
	private bool IsChoiceFromChoiceSubstGroup(XmlSchemaChoice derivedChoice, XmlSchemaChoice baseChoice) { }

	// RVA: 0xF58FF0 Offset: 0xF575F0 VA: 0x180F58FF0
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0xF594E0 Offset: 0xF57AE0 VA: 0x180F594E0
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0xF59860 Offset: 0xF57E60 VA: 0x180F59860
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0xF59D90 Offset: 0xF58390 VA: 0x180F59D90
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0xF59CB0 Offset: 0xF582B0 VA: 0x180F59CB0
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0xF57430 Offset: 0xF55A30 VA: 0x180F57430
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0xF59320 Offset: 0xF57920 VA: 0x180F59320
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0xF49530 Offset: 0xF47B30 VA: 0x180F49530
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0xF5F1B0 Offset: 0xF5D7B0 VA: 0x180F5F1B0
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0xB38CC0 Offset: 0xB372C0 VA: 0x180B38CC0
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0xF4DE80 Offset: 0xF4C480 VA: 0x180F4DE80
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xF52600 Offset: 0xF50C00 VA: 0x180F52600
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0xF4BEE0 Offset: 0xF4A4E0 VA: 0x180F4BEE0
	private void CheckAtrributeGroupRestriction(XmlSchemaAttributeGroup baseAttributeGroup, XmlSchemaAttributeGroup derivedAttributeGroup) { }

	// RVA: 0xF593E0 Offset: 0xF579E0 VA: 0x180F593E0
	private bool IsProcessContentsRestricted(XmlSchemaComplexType baseType, XmlSchemaAnyAttribute derivedAttributeWildcard, XmlSchemaAnyAttribute baseAttributeWildcard) { }

	// RVA: 0xF4DDE0 Offset: 0xF4C3E0 VA: 0x180F4DDE0
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0xF4DD40 Offset: 0xF4C340 VA: 0x180F4DD40
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0xF4E5F0 Offset: 0xF4CBF0 VA: 0x180F4E5F0
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0xF5F3F0 Offset: 0xF5D9F0 VA: 0x180F5F3F0
	private void SetDefaultFixed(XmlSchemaAttribute xa, SchemaAttDef decl) { }

	// RVA: 0xF52050 Offset: 0xF50650 VA: 0x180F52050
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0xF51230 Offset: 0xF4F830 VA: 0x180F51230
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0xF4F8B0 Offset: 0xF4DEB0 VA: 0x180F4F8B0
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0xF48E00 Offset: 0xF47400 VA: 0x180F48E00
	private bool BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0xF53770 Offset: 0xF51D70 VA: 0x180F53770
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0xF53B00 Offset: 0xF52100 VA: 0x180F53B00
	private void CompileParticleElements(XmlSchemaParticle particle) { }

	// RVA: 0xF50650 Offset: 0xF4EC50 VA: 0x180F50650
	private void CompileComplexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0xF57540 Offset: 0xF55B40 VA: 0x180F57540
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0xF57370 Offset: 0xF55970 VA: 0x180F57370
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0xF571A0 Offset: 0xF557A0 VA: 0x180F571A0
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

	// RVA: 0xF57060 Offset: 0xF55660 VA: 0x180F57060
	private void CopyPosition(XmlSchemaAnnotated to, XmlSchemaAnnotated from, bool copyParent) { }

	// RVA: 0xF58970 Offset: 0xF56F70 VA: 0x180F58970
	private bool IsFixedEqual(SchemaDeclBase baseDecl, SchemaDeclBase derivedDecl) { }

}

