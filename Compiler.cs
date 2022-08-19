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

	// RVA: 0xF5E9B0 Offset: 0xF5CFB0 VA: 0x180F5E9B0
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchema schemaForSchema, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0xF56390 Offset: 0xF54990 VA: 0x180F56390
	public bool Execute(XmlSchemaSet schemaSet, SchemaInfo schemaCompiledInfo) { }

	// RVA: 0xF5BB90 Offset: 0xF5A190 VA: 0x180F5BB90
	internal void Prepare(XmlSchema schema, bool cleanup) { }

	// RVA: 0xF5E830 Offset: 0xF5CE30 VA: 0x180F5E830
	private void UpdateSForSSimpleTypes() { }

	// RVA: 0xF5AE20 Offset: 0xF59420 VA: 0x180F5AE20
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0xF568D0 Offset: 0xF54ED0 VA: 0x180F568D0
	internal void ImportAllCompiledSchemas(XmlSchemaSet schemaSet) { }

	// RVA: 0xF54460 Offset: 0xF52A60 VA: 0x180F54460
	internal bool Compile() { }

	// RVA: 0xF4C010 Offset: 0xF4A610 VA: 0x180F4C010
	private void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0xF4BF90 Offset: 0xF4A590 VA: 0x180F4BF90
	private void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xF4C2A0 Offset: 0xF4A8A0 VA: 0x180F4C2A0
	private void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0xF4CF20 Offset: 0xF4B520 VA: 0x180F4CF20
	private void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0xF4C7F0 Offset: 0xF4ADF0 VA: 0x180F4C7F0
	private void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0xF4C100 Offset: 0xF4A700 VA: 0x180F4C100
	private void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0xF4CA90 Offset: 0xF4B090 VA: 0x180F4CA90
	private void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0xF4CAF0 Offset: 0xF4B0F0 VA: 0x180F4CAF0
	private void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0xF5DDD0 Offset: 0xF5C3D0 VA: 0x180F5DDD0
	private void ProcessSubstitutionGroups() { }

	// RVA: 0xF53F50 Offset: 0xF52550 VA: 0x180F53F50
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0xF5E510 Offset: 0xF5CB10 VA: 0x180F5E510
	private void RecursivelyCheckRedefinedGroups(XmlSchemaGroup redefinedGroup, XmlSchemaGroup baseGroup) { }

	// RVA: 0xF5E480 Offset: 0xF5CA80 VA: 0x180F5E480
	private void RecursivelyCheckRedefinedAttributeGroups(XmlSchemaAttributeGroup attributeGroup, XmlSchemaAttributeGroup baseAttributeGroup) { }

	// RVA: 0xF51200 Offset: 0xF4F800 VA: 0x180F51200
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0xF536A0 Offset: 0xF51CA0 VA: 0x180F536A0
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0xF4DFE0 Offset: 0xF4C5E0 VA: 0x180F4DFE0
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0xF4BE60 Offset: 0xF4A460 VA: 0x180F4BE60
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0xF4FA20 Offset: 0xF4E020 VA: 0x180F4FA20
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0xF53020 Offset: 0xF51620 VA: 0x180F53020
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0xF532B0 Offset: 0xF518B0 VA: 0x180F532B0
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0xF4E470 Offset: 0xF4CA70 VA: 0x180F4E470
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0xF4E850 Offset: 0xF4CE50 VA: 0x180F4E850
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0xF4B900 Offset: 0xF49F00 VA: 0x180F4B900
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0xF4BD90 Offset: 0xF4A390 VA: 0x180F4BD90
	private void CheckParticleDerivation(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0xF50330 Offset: 0xF4E930 VA: 0x180F50330
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle) { }

	// RVA: 0xF4A2E0 Offset: 0xF488E0 VA: 0x180F4A2E0
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root) { }

	// RVA: 0xF499E0 Offset: 0xF47FE0 VA: 0x180F499E0
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element) { }

	// RVA: 0xF49C70 Offset: 0xF48270 VA: 0x180F49C70
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root) { }

	// RVA: 0xF49040 Offset: 0xF47640 VA: 0x180F49040
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root) { }

	// RVA: 0xF49320 Offset: 0xF47920 VA: 0x180F49320
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root) { }

	// RVA: 0xF4AB60 Offset: 0xF49160 VA: 0x180F4AB60
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root) { }

	// RVA: 0xF4A640 Offset: 0xF48C40 VA: 0x180F4A640
	private XmlSchemaParticle CannonicalizePointlessRoot(XmlSchemaParticle particle) { }

	// RVA: 0xF59150 Offset: 0xF57750 VA: 0x180F59150
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0xF56E60 Offset: 0xF55460 VA: 0x180F56E60
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0xF56C70 Offset: 0xF55270 VA: 0x180F56C70
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0xF569E0 Offset: 0xF54FE0 VA: 0x180F569E0
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0xF57D90 Offset: 0xF56390 VA: 0x180F57D90
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0xF570D0 Offset: 0xF556D0 VA: 0x180F570D0
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase) { }

	// RVA: 0xF56AC0 Offset: 0xF550C0 VA: 0x180F56AC0
	private bool IsChoiceFromChoiceSubstGroup(XmlSchemaChoice derivedChoice, XmlSchemaChoice baseChoice) { }

	// RVA: 0xF58290 Offset: 0xF56890 VA: 0x180F58290
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0xF58780 Offset: 0xF56D80 VA: 0x180F58780
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0xF58B00 Offset: 0xF57100 VA: 0x180F58B00
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0xF59030 Offset: 0xF57630 VA: 0x180F59030
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0xF58F50 Offset: 0xF57550 VA: 0x180F58F50
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0xF566D0 Offset: 0xF54CD0 VA: 0x180F566D0
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0xF585C0 Offset: 0xF56BC0 VA: 0x180F585C0
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0xF487D0 Offset: 0xF46DD0 VA: 0x180F487D0
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0xF5E450 Offset: 0xF5CA50 VA: 0x180F5E450
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0xB38530 Offset: 0xB36B30 VA: 0x180B38530
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0xF4D120 Offset: 0xF4B720 VA: 0x180F4D120
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xF518A0 Offset: 0xF4FEA0 VA: 0x180F518A0
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0xF4B180 Offset: 0xF49780 VA: 0x180F4B180
	private void CheckAtrributeGroupRestriction(XmlSchemaAttributeGroup baseAttributeGroup, XmlSchemaAttributeGroup derivedAttributeGroup) { }

	// RVA: 0xF58680 Offset: 0xF56C80 VA: 0x180F58680
	private bool IsProcessContentsRestricted(XmlSchemaComplexType baseType, XmlSchemaAnyAttribute derivedAttributeWildcard, XmlSchemaAnyAttribute baseAttributeWildcard) { }

	// RVA: 0xF4D080 Offset: 0xF4B680 VA: 0x180F4D080
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0xF4CFE0 Offset: 0xF4B5E0 VA: 0x180F4CFE0
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0xF4D890 Offset: 0xF4BE90 VA: 0x180F4D890
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0xF5E690 Offset: 0xF5CC90 VA: 0x180F5E690
	private void SetDefaultFixed(XmlSchemaAttribute xa, SchemaAttDef decl) { }

	// RVA: 0xF512F0 Offset: 0xF4F8F0 VA: 0x180F512F0
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0xF504D0 Offset: 0xF4EAD0 VA: 0x180F504D0
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0xF4EB50 Offset: 0xF4D150 VA: 0x180F4EB50
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0xF480A0 Offset: 0xF466A0 VA: 0x180F480A0
	private bool BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0xF52A10 Offset: 0xF51010 VA: 0x180F52A10
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0xF52DA0 Offset: 0xF513A0 VA: 0x180F52DA0
	private void CompileParticleElements(XmlSchemaParticle particle) { }

	// RVA: 0xF4F8F0 Offset: 0xF4DEF0 VA: 0x180F4F8F0
	private void CompileComplexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0xF567E0 Offset: 0xF54DE0 VA: 0x180F567E0
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0xF56610 Offset: 0xF54C10 VA: 0x180F56610
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0xF56440 Offset: 0xF54A40 VA: 0x180F56440
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

	// RVA: 0xF56300 Offset: 0xF54900 VA: 0x180F56300
	private void CopyPosition(XmlSchemaAnnotated to, XmlSchemaAnnotated from, bool copyParent) { }

	// RVA: 0xF57C10 Offset: 0xF56210 VA: 0x180F57C10
	private bool IsFixedEqual(SchemaDeclBase baseDecl, SchemaDeclBase derivedDecl) { }

}

