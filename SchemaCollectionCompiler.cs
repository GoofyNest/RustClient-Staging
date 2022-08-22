internal sealed class SchemaCollectionCompiler : BaseProcessor // TypeDefIndex: 2272
{	// Fields
	private bool compileContentModel; // 0x40
	private XmlSchemaObjectTable examplars; // 0x48
	private Stack complexTypeStack; // 0x50
	private XmlSchema schema; // 0x58

	// Methods

	// RVA: 0xB3B9F0 Offset: 0xB39FF0 VA: 0x180B3B9F0
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler) { }

	// RVA: 0xB383B0 Offset: 0xB369B0 VA: 0x180B383B0
	public bool Execute(XmlSchema schema, SchemaInfo schemaInfo, bool compileContentModel) { }

	// RVA: 0xB3B690 Offset: 0xB39C90 VA: 0x180B3B690
	private void Prepare() { }

	// RVA: 0xB2D4E0 Offset: 0xB2BAE0 VA: 0x180B2D4E0
	private void Cleanup() { }

	// RVA: 0xB2E190 Offset: 0xB2C790 VA: 0x180B2E190
	internal static void Cleanup(XmlSchema schema) { }

	// RVA: 0xB35F40 Offset: 0xB34540 VA: 0x180B35F40
	private void Compile() { }

	// RVA: 0xB3AA40 Offset: 0xB39040 VA: 0x180B3AA40
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0xB2CA10 Offset: 0xB2B010 VA: 0x180B2CA10
	private static void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0xB2C9B0 Offset: 0xB2AFB0 VA: 0x180B2C9B0
	private static void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xB2CB60 Offset: 0xB2B160 VA: 0x180B2CB60
	private static void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0xB2D4C0 Offset: 0xB2BAC0 VA: 0x180B2D4C0
	private static void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0xB2D020 Offset: 0xB2B620 VA: 0x180B2D020
	private static void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0xB2CA60 Offset: 0xB2B060 VA: 0x180B2CA60
	private static void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0xB2D230 Offset: 0xB2B830 VA: 0x180B2D230
	private static void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0xB2D270 Offset: 0xB2B870 VA: 0x180B2D270
	private static void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0xB35A00 Offset: 0xB34000 VA: 0x180B35A00
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroupV1Compat substitutionGroup) { }

	// RVA: 0xB2C640 Offset: 0xB2AC40 VA: 0x180B2C640
	private void CheckSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0xB32FC0 Offset: 0xB315C0 VA: 0x180B32FC0
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0xB35180 Offset: 0xB33780 VA: 0x180B35180
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0xB2FB60 Offset: 0xB2E160 VA: 0x180B2FB60
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0xB2C880 Offset: 0xB2AE80 VA: 0x180B2C880
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0xB31670 Offset: 0xB2FC70 VA: 0x180B31670
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0xB34B00 Offset: 0xB33100 VA: 0x180B34B00
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0xB34D90 Offset: 0xB33390 VA: 0x180B34D90
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0xB300C0 Offset: 0xB2E6C0 VA: 0x180B300C0
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0xB30560 Offset: 0xB2EB60 VA: 0x180B30560
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0xB2C4F0 Offset: 0xB2AAF0 VA: 0x180B2C4F0
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0xB32170 Offset: 0xB30770 VA: 0x180B32170
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle, bool substitution) { }

	// RVA: 0xB2BB10 Offset: 0xB2A110 VA: 0x180B2BB10
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root, bool substitution) { }

	// RVA: 0xB2B2C0 Offset: 0xB298C0 VA: 0x180B2B2C0
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element, bool substitution) { }

	// RVA: 0xB2B480 Offset: 0xB29A80 VA: 0x180B2B480
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root, bool substitution) { }

	// RVA: 0xB2A690 Offset: 0xB28C90 VA: 0x180B2A690
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root, bool substitution) { }

	// RVA: 0xB2AC20 Offset: 0xB29220 VA: 0x180B2AC20
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root, bool substitution) { }

	// RVA: 0xB2BEC0 Offset: 0xB2A4C0 VA: 0x180B2BEC0
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root, bool substitution) { }

	// RVA: 0xB39E10 Offset: 0xB38410 VA: 0x180B39E10
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0xB38AC0 Offset: 0xB370C0 VA: 0x180B38AC0
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0xB38A50 Offset: 0xB37050 VA: 0x180B38A50
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0xB389F0 Offset: 0xB36FF0 VA: 0x180B389F0
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0xB38F90 Offset: 0xB37590 VA: 0x180B38F90
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0xB38BF0 Offset: 0xB371F0 VA: 0x180B38BF0
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0xB39260 Offset: 0xB37860 VA: 0x180B39260
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0xB395F0 Offset: 0xB37BF0 VA: 0x180B395F0
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0xB39940 Offset: 0xB37F40 VA: 0x180B39940
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0xB2A240 Offset: 0xB28840 VA: 0x180B2A240
	private void CalculateSequenceRange(XmlSchemaSequence sequence, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0xB39C10 Offset: 0xB38210 VA: 0x180B39C10
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0xB39D30 Offset: 0xB38330 VA: 0x180B39D30
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0xB386E0 Offset: 0xB36CE0 VA: 0x180B386E0
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0xB39530 Offset: 0xB37B30 VA: 0x180B39530
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0xB29920 Offset: 0xB27F20 VA: 0x180B29920
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0xB3B9C0 Offset: 0xB39FC0 VA: 0x180B3B9C0
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0xB387F0 Offset: 0xB36DF0 VA: 0x180B387F0
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0xB2EAF0 Offset: 0xB2D0F0 VA: 0x180B2EAF0
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xB33670 Offset: 0xB31C70 VA: 0x180B33670
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0xB2EA50 Offset: 0xB2D050 VA: 0x180B2EA50
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0xB2E9B0 Offset: 0xB2CFB0 VA: 0x180B2E9B0
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0xB2F1E0 Offset: 0xB2D7E0 VA: 0x180B2F1E0
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0xB330B0 Offset: 0xB316B0 VA: 0x180B330B0
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0xB32320 Offset: 0xB30920 VA: 0x180B32320
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0xB30880 Offset: 0xB2EE80 VA: 0x180B30880
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0xB28FE0 Offset: 0xB275E0 VA: 0x180B28FE0
	private void BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0xB34770 Offset: 0xB32D70 VA: 0x180B34770
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0xB2FFF0 Offset: 0xB2E5F0 VA: 0x180B2FFF0
	private void CompileCompexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0xB38870 Offset: 0xB36E70 VA: 0x180B38870
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0xB38610 Offset: 0xB36C10 VA: 0x180B38610
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0xB38430 Offset: 0xB36A30 VA: 0x180B38430
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

}

