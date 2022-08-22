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

	// RVA: 0xF5EC70 Offset: 0xF5D270 VA: 0x180F5EC70
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchema schemaForSchema, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0xF56650 Offset: 0xF54C50 VA: 0x180F56650
	public bool Execute(XmlSchemaSet schemaSet, SchemaInfo schemaCompiledInfo) { }

	// RVA: 0xF5BE50 Offset: 0xF5A450 VA: 0x180F5BE50
	internal void Prepare(XmlSchema schema, bool cleanup) { }

	// RVA: 0xF5EAF0 Offset: 0xF5D0F0 VA: 0x180F5EAF0
	private void UpdateSForSSimpleTypes() { }

	// RVA: 0xF5B0E0 Offset: 0xF596E0 VA: 0x180F5B0E0
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0xF56B90 Offset: 0xF55190 VA: 0x180F56B90
	internal void ImportAllCompiledSchemas(XmlSchemaSet schemaSet) { }

	// RVA: 0xF54720 Offset: 0xF52D20 VA: 0x180F54720
	internal bool Compile() { }

	// RVA: 0xF4C2D0 Offset: 0xF4A8D0 VA: 0x180F4C2D0
	private void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0xF4C250 Offset: 0xF4A850 VA: 0x180F4C250
	private void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xF4C560 Offset: 0xF4AB60 VA: 0x180F4C560
	private void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0xF4D1E0 Offset: 0xF4B7E0 VA: 0x180F4D1E0
	private void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0xF4CAB0 Offset: 0xF4B0B0 VA: 0x180F4CAB0
	private void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0xF4C3C0 Offset: 0xF4A9C0 VA: 0x180F4C3C0
	private void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0xF4CD50 Offset: 0xF4B350 VA: 0x180F4CD50
	private void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0xF4CDB0 Offset: 0xF4B3B0 VA: 0x180F4CDB0
	private void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0xF5E090 Offset: 0xF5C690 VA: 0x180F5E090
	private void ProcessSubstitutionGroups() { }

	// RVA: 0xF54210 Offset: 0xF52810 VA: 0x180F54210
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0xF5E7D0 Offset: 0xF5CDD0 VA: 0x180F5E7D0
	private void RecursivelyCheckRedefinedGroups(XmlSchemaGroup redefinedGroup, XmlSchemaGroup baseGroup) { }

	// RVA: 0xF5E740 Offset: 0xF5CD40 VA: 0x180F5E740
	private void RecursivelyCheckRedefinedAttributeGroups(XmlSchemaAttributeGroup attributeGroup, XmlSchemaAttributeGroup baseAttributeGroup) { }

	// RVA: 0xF514C0 Offset: 0xF4FAC0 VA: 0x180F514C0
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0xF53960 Offset: 0xF51F60 VA: 0x180F53960
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0xF4E2A0 Offset: 0xF4C8A0 VA: 0x180F4E2A0
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0xF4C120 Offset: 0xF4A720 VA: 0x180F4C120
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0xF4FCE0 Offset: 0xF4E2E0 VA: 0x180F4FCE0
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0xF532E0 Offset: 0xF518E0 VA: 0x180F532E0
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0xF53570 Offset: 0xF51B70 VA: 0x180F53570
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0xF4E730 Offset: 0xF4CD30 VA: 0x180F4E730
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0xF4EB10 Offset: 0xF4D110 VA: 0x180F4EB10
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0xF4BBC0 Offset: 0xF4A1C0 VA: 0x180F4BBC0
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0xF4C050 Offset: 0xF4A650 VA: 0x180F4C050
	private void CheckParticleDerivation(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0xF505F0 Offset: 0xF4EBF0 VA: 0x180F505F0
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle) { }

	// RVA: 0xF4A5A0 Offset: 0xF48BA0 VA: 0x180F4A5A0
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root) { }

	// RVA: 0xF49CA0 Offset: 0xF482A0 VA: 0x180F49CA0
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element) { }

	// RVA: 0xF49F30 Offset: 0xF48530 VA: 0x180F49F30
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root) { }

	// RVA: 0xF49300 Offset: 0xF47900 VA: 0x180F49300
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root) { }

	// RVA: 0xF495E0 Offset: 0xF47BE0 VA: 0x180F495E0
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root) { }

	// RVA: 0xF4AE20 Offset: 0xF49420 VA: 0x180F4AE20
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root) { }

	// RVA: 0xF4A900 Offset: 0xF48F00 VA: 0x180F4A900
	private XmlSchemaParticle CannonicalizePointlessRoot(XmlSchemaParticle particle) { }

	// RVA: 0xF59410 Offset: 0xF57A10 VA: 0x180F59410
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0xF57120 Offset: 0xF55720 VA: 0x180F57120
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0xF56F30 Offset: 0xF55530 VA: 0x180F56F30
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0xF56CA0 Offset: 0xF552A0 VA: 0x180F56CA0
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0xF58050 Offset: 0xF56650 VA: 0x180F58050
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0xF57390 Offset: 0xF55990 VA: 0x180F57390
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase) { }

	// RVA: 0xF56D80 Offset: 0xF55380 VA: 0x180F56D80
	private bool IsChoiceFromChoiceSubstGroup(XmlSchemaChoice derivedChoice, XmlSchemaChoice baseChoice) { }

	// RVA: 0xF58550 Offset: 0xF56B50 VA: 0x180F58550
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0xF58A40 Offset: 0xF57040 VA: 0x180F58A40
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0xF58DC0 Offset: 0xF573C0 VA: 0x180F58DC0
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0xF592F0 Offset: 0xF578F0 VA: 0x180F592F0
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0xF59210 Offset: 0xF57810 VA: 0x180F59210
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0xF56990 Offset: 0xF54F90 VA: 0x180F56990
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0xF58880 Offset: 0xF56E80 VA: 0x180F58880
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0xF48A90 Offset: 0xF47090 VA: 0x180F48A90
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0xF5E710 Offset: 0xF5CD10 VA: 0x180F5E710
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0xB387F0 Offset: 0xB36DF0 VA: 0x180B387F0
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0xF4D3E0 Offset: 0xF4B9E0 VA: 0x180F4D3E0
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xF51B60 Offset: 0xF50160 VA: 0x180F51B60
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0xF4B440 Offset: 0xF49A40 VA: 0x180F4B440
	private void CheckAtrributeGroupRestriction(XmlSchemaAttributeGroup baseAttributeGroup, XmlSchemaAttributeGroup derivedAttributeGroup) { }

	// RVA: 0xF58940 Offset: 0xF56F40 VA: 0x180F58940
	private bool IsProcessContentsRestricted(XmlSchemaComplexType baseType, XmlSchemaAnyAttribute derivedAttributeWildcard, XmlSchemaAnyAttribute baseAttributeWildcard) { }

	// RVA: 0xF4D340 Offset: 0xF4B940 VA: 0x180F4D340
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0xF4D2A0 Offset: 0xF4B8A0 VA: 0x180F4D2A0
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0xF4DB50 Offset: 0xF4C150 VA: 0x180F4DB50
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0xF5E950 Offset: 0xF5CF50 VA: 0x180F5E950
	private void SetDefaultFixed(XmlSchemaAttribute xa, SchemaAttDef decl) { }

	// RVA: 0xF515B0 Offset: 0xF4FBB0 VA: 0x180F515B0
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0xF50790 Offset: 0xF4ED90 VA: 0x180F50790
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0xF4EE10 Offset: 0xF4D410 VA: 0x180F4EE10
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0xF48360 Offset: 0xF46960 VA: 0x180F48360
	private bool BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0xF52CD0 Offset: 0xF512D0 VA: 0x180F52CD0
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0xF53060 Offset: 0xF51660 VA: 0x180F53060
	private void CompileParticleElements(XmlSchemaParticle particle) { }

	// RVA: 0xF4FBB0 Offset: 0xF4E1B0 VA: 0x180F4FBB0
	private void CompileComplexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0xF56AA0 Offset: 0xF550A0 VA: 0x180F56AA0
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0xF568D0 Offset: 0xF54ED0 VA: 0x180F568D0
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0xF56700 Offset: 0xF54D00 VA: 0x180F56700
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

	// RVA: 0xF565C0 Offset: 0xF54BC0 VA: 0x180F565C0
	private void CopyPosition(XmlSchemaAnnotated to, XmlSchemaAnnotated from, bool copyParent) { }

	// RVA: 0xF57ED0 Offset: 0xF564D0 VA: 0x180F57ED0
	private bool IsFixedEqual(SchemaDeclBase baseDecl, SchemaDeclBase derivedDecl) { }

}

