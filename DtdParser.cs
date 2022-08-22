internal class DtdParser : IDtdParser // TypeDefIndex: 1993
{	// Fields
	private IDtdParserAdapter readerAdapter; // 0x10
	private IDtdParserAdapterWithValidation readerAdapterWithValidation; // 0x18
	private XmlNameTable nameTable; // 0x20
	private SchemaInfo schemaInfo; // 0x28
	private XmlCharType xmlCharType; // 0x30
	private string systemId; // 0x38
	private string publicId; // 0x40
	private bool normalize; // 0x48
	private bool validate; // 0x49
	private bool supportNamespaces; // 0x4A
	private bool v1Compat; // 0x4B
	private char[] chars; // 0x50
	private int charsUsed; // 0x58
	private int curPos; // 0x5C
	private DtdParser.ScanningFunction scanningFunction; // 0x60
	private DtdParser.ScanningFunction nextScaningFunction; // 0x64
	private DtdParser.ScanningFunction savedScanningFunction; // 0x68
	private bool whitespaceSeen; // 0x6C
	private int tokenStartPos; // 0x70
	private int colonPos; // 0x74
	private StringBuilder internalSubsetValueSb; // 0x78
	private int externalEntitiesDepth; // 0x80
	private int currentEntityId; // 0x84
	private bool freeFloatingDtd; // 0x88
	private bool hasFreeFloatingInternalSubset; // 0x89
	private StringBuilder stringBuilder; // 0x90
	private int condSectionDepth; // 0x98
	private LineInfo literalLineInfo; // 0x9C
	private char literalQuoteChar; // 0xA4
	private string documentBaseUri; // 0xA8
	private string externalDtdBaseUri; // 0xB0
	private Dictionary<string, DtdParser.UndeclaredNotation> undeclaredNotations; // 0xB8
	private int[] condSectionEntityIds; // 0xC0

	// Properties
	private bool ParsingInternalSubset { get; }
	private bool IgnoreEntityReferences { get; }
	private bool SaveInternalSubsetValue { get; }
	private bool ParsingTopLevelMarkup { get; }
	private bool SupportNamespaces { get; }
	private bool Normalize { get; }
	private int LineNo { get; }
	private int LinePos { get; }
	private string BaseUriStr { get; }

	// Methods

	// RVA: 0x12F0340 Offset: 0x12EE940 VA: 0x1812F0340
	private void .ctor() { }

	// RVA: 0x12E47A0 Offset: 0x12E2DA0 VA: 0x1812E47A0
	internal static IDtdParser Create() { }

	// RVA: 0x12E69B0 Offset: 0x12E4FB0 VA: 0x1812E69B0
	private void Initialize(IDtdParserAdapter readerAdapter) { }

	// RVA: 0x12E65F0 Offset: 0x12E4BF0 VA: 0x1812E65F0
	private void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x12EF840 Offset: 0x12EDE40 VA: 0x1812EF840 Slot: 4
	private IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset) { }

	// RVA: 0x12EF7F0 Offset: 0x12EDDF0 VA: 0x1812EF7F0 Slot: 5
	private IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x12F05C0 Offset: 0x12EEBC0 VA: 0x1812F05C0
	private bool get_ParsingInternalSubset() { }

	// RVA: 0x12F0500 Offset: 0x12EEB00 VA: 0x1812F0500
	private bool get_IgnoreEntityReferences() { }

	// RVA: 0x12F05F0 Offset: 0x12EEBF0 VA: 0x1812F05F0
	private bool get_SaveInternalSubsetValue() { }

	// RVA: 0x12F05D0 Offset: 0x12EEBD0 VA: 0x1812F05D0
	private bool get_ParsingTopLevelMarkup() { }

	// RVA: 0xBA1D50 Offset: 0xBA0350 VA: 0x180BA1D50
	private bool get_SupportNamespaces() { }

	// RVA: 0x4BC3E0 Offset: 0x4BA9E0 VA: 0x1804BC3E0
	private bool get_Normalize() { }

	// RVA: 0x12EA090 Offset: 0x12E8690 VA: 0x1812EA090
	private void Parse(bool saveInternalSubset) { }

	// RVA: 0x12E9640 Offset: 0x12E7C40 VA: 0x1812E9640
	private void ParseInDocumentDtd(bool saveInternalSubset) { }

	// RVA: 0x12E9570 Offset: 0x12E7B70 VA: 0x1812E9570
	private void ParseFreeFloatingDtd() { }

	// RVA: 0x12E97B0 Offset: 0x12E7DB0 VA: 0x1812E97B0
	private void ParseInternalSubset() { }

	// RVA: 0x12E93F0 Offset: 0x12E79F0 VA: 0x1812E93F0
	private void ParseExternalSubset() { }

	// RVA: 0x12E9AC0 Offset: 0x12E80C0 VA: 0x1812E9AC0
	private void ParseSubset() { }

	// RVA: 0x12E6DD0 Offset: 0x12E53D0 VA: 0x1812E6DD0
	private void ParseAttlistDecl() { }

	// RVA: 0x12E7560 Offset: 0x12E5B60 VA: 0x1812E7560
	private void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors) { }

	// RVA: 0x12E7330 Offset: 0x12E5930 VA: 0x1812E7330
	private void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors) { }

	// RVA: 0x12E8030 Offset: 0x12E6630 VA: 0x1812E8030
	private void ParseElementDecl() { }

	// RVA: 0x12E8700 Offset: 0x12E6D00 VA: 0x1812E8700
	private void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x12E95D0 Offset: 0x12E7BD0 VA: 0x1812E95D0
	private void ParseHowMany(ParticleContentValidator pcv) { }

	// RVA: 0x12E8410 Offset: 0x12E6A10 VA: 0x1812E8410
	private void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x12E8B10 Offset: 0x12E7110 VA: 0x1812E8B10
	private void ParseEntityDecl() { }

	// RVA: 0x12E97C0 Offset: 0x12E7DC0 VA: 0x1812E97C0
	private void ParseNotationDecl() { }

	// RVA: 0x12E45B0 Offset: 0x12E2BB0 VA: 0x1812E45B0
	private void AddUndeclaredNotation(string notationName) { }

	// RVA: 0x12E7BF0 Offset: 0x12E61F0 VA: 0x1812E7BF0
	private void ParseComment() { }

	// RVA: 0x12E99C0 Offset: 0x12E7FC0 VA: 0x1812E99C0
	private void ParsePI() { }

	// RVA: 0x12E7D80 Offset: 0x12E6380 VA: 0x1812E7D80
	private void ParseCondSection() { }

	// RVA: 0x12E8E80 Offset: 0x12E7480 VA: 0x1812E8E80
	private void ParseExternalId(DtdParser.Token idTokenType, DtdParser.Token declType, out string publicId, out string systemId) { }

	// RVA: 0x12E4CD0 Offset: 0x12E32D0 VA: 0x1812E4CD0
	private DtdParser.Token GetToken(bool needWhiteSpace) { }

	// RVA: 0x12EE890 Offset: 0x12ECE90 VA: 0x1812EE890
	private DtdParser.Token ScanSubsetContent() { }

	// RVA: 0x12EE090 Offset: 0x12EC690 VA: 0x1812EE090
	private DtdParser.Token ScanNameExpected() { }

	// RVA: 0x12EE500 Offset: 0x12ECB00 VA: 0x1812EE500
	private DtdParser.Token ScanQNameExpected() { }

	// RVA: 0x12EE0D0 Offset: 0x12EC6D0 VA: 0x1812EE0D0
	private DtdParser.Token ScanNmtokenExpected() { }

	// RVA: 0x12EC310 Offset: 0x12EA910 VA: 0x1812EC310
	private DtdParser.Token ScanDoctype1() { }

	// RVA: 0x12EC450 Offset: 0x12EAA50 VA: 0x1812EC450
	private DtdParser.Token ScanDoctype2() { }

	// RVA: 0x12EB780 Offset: 0x12E9D80 VA: 0x1812EB780
	private DtdParser.Token ScanClosingTag() { }

	// RVA: 0x12EC500 Offset: 0x12EAB00 VA: 0x1812EC500
	private DtdParser.Token ScanElement1() { }

	// RVA: 0x12EC810 Offset: 0x12EAE10 VA: 0x1812EC810
	private DtdParser.Token ScanElement2() { }

	// RVA: 0x12ECA90 Offset: 0x12EB090 VA: 0x1812ECA90
	private DtdParser.Token ScanElement3() { }

	// RVA: 0x12ECB20 Offset: 0x12EB120 VA: 0x1812ECB20
	private DtdParser.Token ScanElement4() { }

	// RVA: 0x12ECC40 Offset: 0x12EB240 VA: 0x1812ECC40
	private DtdParser.Token ScanElement5() { }

	// RVA: 0x12ECD40 Offset: 0x12EB340 VA: 0x1812ECD40
	private DtdParser.Token ScanElement6() { }

	// RVA: 0x12ECE10 Offset: 0x12EB410 VA: 0x1812ECE10
	private DtdParser.Token ScanElement7() { }

	// RVA: 0x12EA590 Offset: 0x12E8B90 VA: 0x1812EA590
	private DtdParser.Token ScanAttlist1() { }

	// RVA: 0x12EA670 Offset: 0x12E8C70 VA: 0x1812EA670
	private DtdParser.Token ScanAttlist2() { }

	// RVA: 0x12EAF40 Offset: 0x12E9540 VA: 0x1812EAF40
	private DtdParser.Token ScanAttlist3() { }

	// RVA: 0x12EAFE0 Offset: 0x12E95E0 VA: 0x1812EAFE0
	private DtdParser.Token ScanAttlist4() { }

	// RVA: 0x12EB0B0 Offset: 0x12E96B0 VA: 0x1812EB0B0
	private DtdParser.Token ScanAttlist5() { }

	// RVA: 0x12EB180 Offset: 0x12E9780 VA: 0x1812EB180
	private DtdParser.Token ScanAttlist6() { }

	// RVA: 0x12EB6D0 Offset: 0x12E9CD0 VA: 0x1812EB6D0
	private DtdParser.Token ScanAttlist7() { }

	// RVA: 0x12ED280 Offset: 0x12EB880 VA: 0x1812ED280
	private DtdParser.Token ScanLiteral(DtdParser.LiteralType literalType) { }

	// RVA: 0x12ED180 Offset: 0x12EB780 VA: 0x1812ED180
	private XmlQualifiedName ScanEntityName() { }

	// RVA: 0x12EE2E0 Offset: 0x12EC8E0 VA: 0x1812EE2E0
	private DtdParser.Token ScanNotation1() { }

	// RVA: 0x12EF1D0 Offset: 0x12ED7D0 VA: 0x1812EF1D0
	private DtdParser.Token ScanSystemId() { }

	// RVA: 0x12ECE70 Offset: 0x12EB470 VA: 0x1812ECE70
	private DtdParser.Token ScanEntity1() { }

	// RVA: 0x12ECEF0 Offset: 0x12EB4F0 VA: 0x1812ECEF0
	private DtdParser.Token ScanEntity2() { }

	// RVA: 0x12ED030 Offset: 0x12EB630 VA: 0x1812ED030
	private DtdParser.Token ScanEntity3() { }

	// RVA: 0x12EE3E0 Offset: 0x12EC9E0 VA: 0x1812EE3E0
	private DtdParser.Token ScanPublicId1() { }

	// RVA: 0x12EE480 Offset: 0x12ECA80 VA: 0x1812EE480
	private DtdParser.Token ScanPublicId2() { }

	// RVA: 0x12EB810 Offset: 0x12E9E10 VA: 0x1812EB810
	private DtdParser.Token ScanCondSection1() { }

	// RVA: 0x12EBC30 Offset: 0x12EA230 VA: 0x1812EBC30
	private DtdParser.Token ScanCondSection2() { }

	// RVA: 0x12EBCC0 Offset: 0x12EA2C0 VA: 0x1812EBCC0
	private DtdParser.Token ScanCondSection3() { }

	// RVA: 0x12EE0C0 Offset: 0x12EC6C0 VA: 0x1812EE0C0
	private void ScanName() { }

	// RVA: 0x12EE880 Offset: 0x12ECE80 VA: 0x1812EE880
	private void ScanQName() { }

	// RVA: 0x12EE530 Offset: 0x12ECB30 VA: 0x1812EE530
	private void ScanQName(bool isQName) { }

	// RVA: 0x12EA3E0 Offset: 0x12E89E0 VA: 0x1812EA3E0
	private bool ReadDataInName() { }

	// RVA: 0x12EE100 Offset: 0x12EC700 VA: 0x1812EE100
	private void ScanNmtoken() { }

	// RVA: 0x12E48E0 Offset: 0x12E2EE0 VA: 0x1812E48E0
	private bool EatPublicKeyword() { }

	// RVA: 0x12E49F0 Offset: 0x12E2FF0 VA: 0x1812E49F0
	private bool EatSystemKeyword() { }

	// RVA: 0x12E4B00 Offset: 0x12E3100 VA: 0x1812E4B00
	private XmlQualifiedName GetNameQualified(bool canHavePrefix) { }

	// RVA: 0x12E4CA0 Offset: 0x12E32A0 VA: 0x1812E4CA0
	private string GetNameString() { }

	// RVA: 0x12E4CA0 Offset: 0x12E32A0 VA: 0x1812E4CA0
	private string GetNmtokenString() { }

	// RVA: 0x12E6170 Offset: 0x12E4770 VA: 0x1812E6170
	private string GetValue() { }

	// RVA: 0x12E60E0 Offset: 0x12E46E0 VA: 0x1812E60E0
	private string GetValueWithStrippedSpaces() { }

	// RVA: 0x12EA430 Offset: 0x12E8A30 VA: 0x1812EA430
	private int ReadData() { }

	// RVA: 0x12E6C30 Offset: 0x12E5230 VA: 0x1812E6C30
	private void LoadParsingBuffer() { }

	// RVA: 0x12EA4A0 Offset: 0x12E8AA0 VA: 0x1812EA4A0
	private void SaveParsingBuffer() { }

	// RVA: 0x12EA4B0 Offset: 0x12E8AB0 VA: 0x1812EA4B0
	private void SaveParsingBuffer(int internalSubsetValueEndPos) { }

	// RVA: 0x12E6330 Offset: 0x12E4930 VA: 0x1812E6330
	private bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x12E63A0 Offset: 0x12E49A0 VA: 0x1812E63A0
	private bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x12E61E0 Offset: 0x12E47E0 VA: 0x1812E61E0
	private bool HandleEntityEnd(bool inLiteral) { }

	// RVA: 0x12F0130 Offset: 0x12EE730 VA: 0x1812F0130
	private SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute) { }

	// RVA: 0x12EF270 Offset: 0x12ED870 VA: 0x1812EF270
	private void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x12EF4C0 Offset: 0x12EDAC0 VA: 0x1812EF4C0
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x12EF3D0 Offset: 0x12ED9D0 VA: 0x1812EF3D0
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e) { }

	// RVA: 0x12E6C20 Offset: 0x12E5220 VA: 0x1812E6C20
	private bool IsAttributeValueType(DtdParser.Token token) { }

	// RVA: 0x12F0510 Offset: 0x12EEB10 VA: 0x1812F0510
	private int get_LineNo() { }

	// RVA: 0x12F0560 Offset: 0x12EEB60 VA: 0x1812F0560
	private int get_LinePos() { }

	// RVA: 0x12F0450 Offset: 0x12EEA50 VA: 0x1812F0450
	private string get_BaseUriStr() { }

	// RVA: 0x12E6D40 Offset: 0x12E5340 VA: 0x1812E6D40
	private void OnUnexpectedError() { }

	// RVA: 0x12EFDE0 Offset: 0x12EE3E0 VA: 0x1812EFDE0
	private void Throw(int curPos, string res) { }

	// RVA: 0x12EFF80 Offset: 0x12EE580 VA: 0x1812EFF80
	private void Throw(int curPos, string res, string arg) { }

	// RVA: 0x12EFC30 Offset: 0x12EE230 VA: 0x1812EFC30
	private void Throw(int curPos, string res, string[] args) { }

	// RVA: 0x12EFE50 Offset: 0x12EE450 VA: 0x1812EFE50
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x12EF880 Offset: 0x12EDE80 VA: 0x1812EF880
	private void ThrowInvalidChar(int pos, string data, int invCharPos) { }

	// RVA: 0x12EF900 Offset: 0x12EDF00 VA: 0x1812EF900
	private void ThrowInvalidChar(char[] data, int length, int invCharPos) { }

	// RVA: 0x12EF980 Offset: 0x12EDF80 VA: 0x1812EF980
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x12EF9A0 Offset: 0x12EDFA0 VA: 0x1812EF9A0
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x12E9FA0 Offset: 0x12E85A0 VA: 0x1812E9FA0
	private string ParseUnexpectedToken(int startPos) { }

	// RVA: 0x12EF610 Offset: 0x12EDC10 VA: 0x1812EF610
	internal static string StripSpaces(string value) { }

}

private enum DtdParser.Token // TypeDefIndex: 1994
{	// Fields
	public int value__; // 0x0
	public const DtdParser.Token CDATA = 0;
	public const DtdParser.Token ID = 1;
	public const DtdParser.Token IDREF = 2;
	public const DtdParser.Token IDREFS = 3;
	public const DtdParser.Token ENTITY = 4;
	public const DtdParser.Token ENTITIES = 5;
	public const DtdParser.Token NMTOKEN = 6;
	public const DtdParser.Token NMTOKENS = 7;
	public const DtdParser.Token NOTATION = 8;
	public const DtdParser.Token None = 9;
	public const DtdParser.Token PERef = 10;
	public const DtdParser.Token AttlistDecl = 11;
	public const DtdParser.Token ElementDecl = 12;
	public const DtdParser.Token EntityDecl = 13;
	public const DtdParser.Token NotationDecl = 14;
	public const DtdParser.Token Comment = 15;
	public const DtdParser.Token PI = 16;
	public const DtdParser.Token CondSectionStart = 17;
	public const DtdParser.Token CondSectionEnd = 18;
	public const DtdParser.Token Eof = 19;
	public const DtdParser.Token REQUIRED = 20;
	public const DtdParser.Token IMPLIED = 21;
	public const DtdParser.Token FIXED = 22;
	public const DtdParser.Token QName = 23;
	public const DtdParser.Token Name = 24;
	public const DtdParser.Token Nmtoken = 25;
	public const DtdParser.Token Quote = 26;
	public const DtdParser.Token LeftParen = 27;
	public const DtdParser.Token RightParen = 28;
	public const DtdParser.Token GreaterThan = 29;
	public const DtdParser.Token Or = 30;
	public const DtdParser.Token LeftBracket = 31;
	public const DtdParser.Token RightBracket = 32;
	public const DtdParser.Token PUBLIC = 33;
	public const DtdParser.Token SYSTEM = 34;
	public const DtdParser.Token Literal = 35;
	public const DtdParser.Token DOCTYPE = 36;
	public const DtdParser.Token NData = 37;
	public const DtdParser.Token Percent = 38;
	public const DtdParser.Token Star = 39;
	public const DtdParser.Token QMark = 40;
	public const DtdParser.Token Plus = 41;
	public const DtdParser.Token PCDATA = 42;
	public const DtdParser.Token Comma = 43;
	public const DtdParser.Token ANY = 44;
	public const DtdParser.Token EMPTY = 45;
	public const DtdParser.Token IGNORE = 46;
	public const DtdParser.Token INCLUDE = 47;

}

private enum DtdParser.ScanningFunction // TypeDefIndex: 1995
{	// Fields
	public int value__; // 0x0
	public const DtdParser.ScanningFunction SubsetContent = 0;
	public const DtdParser.ScanningFunction Name = 1;
	public const DtdParser.ScanningFunction QName = 2;
	public const DtdParser.ScanningFunction Nmtoken = 3;
	public const DtdParser.ScanningFunction Doctype1 = 4;
	public const DtdParser.ScanningFunction Doctype2 = 5;
	public const DtdParser.ScanningFunction Element1 = 6;
	public const DtdParser.ScanningFunction Element2 = 7;
	public const DtdParser.ScanningFunction Element3 = 8;
	public const DtdParser.ScanningFunction Element4 = 9;
	public const DtdParser.ScanningFunction Element5 = 10;
	public const DtdParser.ScanningFunction Element6 = 11;
	public const DtdParser.ScanningFunction Element7 = 12;
	public const DtdParser.ScanningFunction Attlist1 = 13;
	public const DtdParser.ScanningFunction Attlist2 = 14;
	public const DtdParser.ScanningFunction Attlist3 = 15;
	public const DtdParser.ScanningFunction Attlist4 = 16;
	public const DtdParser.ScanningFunction Attlist5 = 17;
	public const DtdParser.ScanningFunction Attlist6 = 18;
	public const DtdParser.ScanningFunction Attlist7 = 19;
	public const DtdParser.ScanningFunction Entity1 = 20;
	public const DtdParser.ScanningFunction Entity2 = 21;
	public const DtdParser.ScanningFunction Entity3 = 22;
	public const DtdParser.ScanningFunction Notation1 = 23;
	public const DtdParser.ScanningFunction CondSection1 = 24;
	public const DtdParser.ScanningFunction CondSection2 = 25;
	public const DtdParser.ScanningFunction CondSection3 = 26;
	public const DtdParser.ScanningFunction Literal = 27;
	public const DtdParser.ScanningFunction SystemId = 28;
	public const DtdParser.ScanningFunction PublicId1 = 29;
	public const DtdParser.ScanningFunction PublicId2 = 30;
	public const DtdParser.ScanningFunction ClosingTag = 31;
	public const DtdParser.ScanningFunction ParamEntitySpace = 32;
	public const DtdParser.ScanningFunction None = 33;

}

private enum DtdParser.LiteralType // TypeDefIndex: 1996
{	// Fields
	public int value__; // 0x0
	public const DtdParser.LiteralType AttributeValue = 0;
	public const DtdParser.LiteralType EntityReplText = 1;
	public const DtdParser.LiteralType SystemOrPublicID = 2;

}

private class DtdParser.UndeclaredNotation // TypeDefIndex: 1997
{	// Fields
	internal string name; // 0x10
	internal int lineNo; // 0x18
	internal int linePos; // 0x1C
	internal DtdParser.UndeclaredNotation next; // 0x20

	// Methods

	// RVA: 0x12F4AC0 Offset: 0x12F30C0 VA: 0x1812F4AC0
	internal void .ctor(string name, int lineNo, int linePos) { }

}

private class DtdParser.ParseElementOnlyContent_LocalFrame // TypeDefIndex: 1998
{	// Fields
	public int startParenEntityId; // 0x10
	public DtdParser.Token parsingSchema; // 0x14

	// Methods

	// RVA: 0x12F4A10 Offset: 0x12F3010 VA: 0x1812F4A10
	public void .ctor(int startParentEntityIdParam) { }

}

