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

	// RVA: 0x12F0080 Offset: 0x12EE680 VA: 0x1812F0080
	private void .ctor() { }

	// RVA: 0x12E44E0 Offset: 0x12E2AE0 VA: 0x1812E44E0
	internal static IDtdParser Create() { }

	// RVA: 0x12E66F0 Offset: 0x12E4CF0 VA: 0x1812E66F0
	private void Initialize(IDtdParserAdapter readerAdapter) { }

	// RVA: 0x12E6330 Offset: 0x12E4930 VA: 0x1812E6330
	private void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x12EF580 Offset: 0x12EDB80 VA: 0x1812EF580 Slot: 4
	private IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset) { }

	// RVA: 0x12EF530 Offset: 0x12EDB30 VA: 0x1812EF530 Slot: 5
	private IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x12F0300 Offset: 0x12EE900 VA: 0x1812F0300
	private bool get_ParsingInternalSubset() { }

	// RVA: 0x12F0240 Offset: 0x12EE840 VA: 0x1812F0240
	private bool get_IgnoreEntityReferences() { }

	// RVA: 0x12F0330 Offset: 0x12EE930 VA: 0x1812F0330
	private bool get_SaveInternalSubsetValue() { }

	// RVA: 0x12F0310 Offset: 0x12EE910 VA: 0x1812F0310
	private bool get_ParsingTopLevelMarkup() { }

	// RVA: 0xBA1A90 Offset: 0xBA0090 VA: 0x180BA1A90
	private bool get_SupportNamespaces() { }

	// RVA: 0x4BC3E0 Offset: 0x4BA9E0 VA: 0x1804BC3E0
	private bool get_Normalize() { }

	// RVA: 0x12E9DD0 Offset: 0x12E83D0 VA: 0x1812E9DD0
	private void Parse(bool saveInternalSubset) { }

	// RVA: 0x12E9380 Offset: 0x12E7980 VA: 0x1812E9380
	private void ParseInDocumentDtd(bool saveInternalSubset) { }

	// RVA: 0x12E92B0 Offset: 0x12E78B0 VA: 0x1812E92B0
	private void ParseFreeFloatingDtd() { }

	// RVA: 0x12E94F0 Offset: 0x12E7AF0 VA: 0x1812E94F0
	private void ParseInternalSubset() { }

	// RVA: 0x12E9130 Offset: 0x12E7730 VA: 0x1812E9130
	private void ParseExternalSubset() { }

	// RVA: 0x12E9800 Offset: 0x12E7E00 VA: 0x1812E9800
	private void ParseSubset() { }

	// RVA: 0x12E6B10 Offset: 0x12E5110 VA: 0x1812E6B10
	private void ParseAttlistDecl() { }

	// RVA: 0x12E72A0 Offset: 0x12E58A0 VA: 0x1812E72A0
	private void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors) { }

	// RVA: 0x12E7070 Offset: 0x12E5670 VA: 0x1812E7070
	private void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors) { }

	// RVA: 0x12E7D70 Offset: 0x12E6370 VA: 0x1812E7D70
	private void ParseElementDecl() { }

	// RVA: 0x12E8440 Offset: 0x12E6A40 VA: 0x1812E8440
	private void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x12E9310 Offset: 0x12E7910 VA: 0x1812E9310
	private void ParseHowMany(ParticleContentValidator pcv) { }

	// RVA: 0x12E8150 Offset: 0x12E6750 VA: 0x1812E8150
	private void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x12E8850 Offset: 0x12E6E50 VA: 0x1812E8850
	private void ParseEntityDecl() { }

	// RVA: 0x12E9500 Offset: 0x12E7B00 VA: 0x1812E9500
	private void ParseNotationDecl() { }

	// RVA: 0x12E42F0 Offset: 0x12E28F0 VA: 0x1812E42F0
	private void AddUndeclaredNotation(string notationName) { }

	// RVA: 0x12E7930 Offset: 0x12E5F30 VA: 0x1812E7930
	private void ParseComment() { }

	// RVA: 0x12E9700 Offset: 0x12E7D00 VA: 0x1812E9700
	private void ParsePI() { }

	// RVA: 0x12E7AC0 Offset: 0x12E60C0 VA: 0x1812E7AC0
	private void ParseCondSection() { }

	// RVA: 0x12E8BC0 Offset: 0x12E71C0 VA: 0x1812E8BC0
	private void ParseExternalId(DtdParser.Token idTokenType, DtdParser.Token declType, out string publicId, out string systemId) { }

	// RVA: 0x12E4A10 Offset: 0x12E3010 VA: 0x1812E4A10
	private DtdParser.Token GetToken(bool needWhiteSpace) { }

	// RVA: 0x12EE5D0 Offset: 0x12ECBD0 VA: 0x1812EE5D0
	private DtdParser.Token ScanSubsetContent() { }

	// RVA: 0x12EDDD0 Offset: 0x12EC3D0 VA: 0x1812EDDD0
	private DtdParser.Token ScanNameExpected() { }

	// RVA: 0x12EE240 Offset: 0x12EC840 VA: 0x1812EE240
	private DtdParser.Token ScanQNameExpected() { }

	// RVA: 0x12EDE10 Offset: 0x12EC410 VA: 0x1812EDE10
	private DtdParser.Token ScanNmtokenExpected() { }

	// RVA: 0x12EC050 Offset: 0x12EA650 VA: 0x1812EC050
	private DtdParser.Token ScanDoctype1() { }

	// RVA: 0x12EC190 Offset: 0x12EA790 VA: 0x1812EC190
	private DtdParser.Token ScanDoctype2() { }

	// RVA: 0x12EB4C0 Offset: 0x12E9AC0 VA: 0x1812EB4C0
	private DtdParser.Token ScanClosingTag() { }

	// RVA: 0x12EC240 Offset: 0x12EA840 VA: 0x1812EC240
	private DtdParser.Token ScanElement1() { }

	// RVA: 0x12EC550 Offset: 0x12EAB50 VA: 0x1812EC550
	private DtdParser.Token ScanElement2() { }

	// RVA: 0x12EC7D0 Offset: 0x12EADD0 VA: 0x1812EC7D0
	private DtdParser.Token ScanElement3() { }

	// RVA: 0x12EC860 Offset: 0x12EAE60 VA: 0x1812EC860
	private DtdParser.Token ScanElement4() { }

	// RVA: 0x12EC980 Offset: 0x12EAF80 VA: 0x1812EC980
	private DtdParser.Token ScanElement5() { }

	// RVA: 0x12ECA80 Offset: 0x12EB080 VA: 0x1812ECA80
	private DtdParser.Token ScanElement6() { }

	// RVA: 0x12ECB50 Offset: 0x12EB150 VA: 0x1812ECB50
	private DtdParser.Token ScanElement7() { }

	// RVA: 0x12EA2D0 Offset: 0x12E88D0 VA: 0x1812EA2D0
	private DtdParser.Token ScanAttlist1() { }

	// RVA: 0x12EA3B0 Offset: 0x12E89B0 VA: 0x1812EA3B0
	private DtdParser.Token ScanAttlist2() { }

	// RVA: 0x12EAC80 Offset: 0x12E9280 VA: 0x1812EAC80
	private DtdParser.Token ScanAttlist3() { }

	// RVA: 0x12EAD20 Offset: 0x12E9320 VA: 0x1812EAD20
	private DtdParser.Token ScanAttlist4() { }

	// RVA: 0x12EADF0 Offset: 0x12E93F0 VA: 0x1812EADF0
	private DtdParser.Token ScanAttlist5() { }

	// RVA: 0x12EAEC0 Offset: 0x12E94C0 VA: 0x1812EAEC0
	private DtdParser.Token ScanAttlist6() { }

	// RVA: 0x12EB410 Offset: 0x12E9A10 VA: 0x1812EB410
	private DtdParser.Token ScanAttlist7() { }

	// RVA: 0x12ECFC0 Offset: 0x12EB5C0 VA: 0x1812ECFC0
	private DtdParser.Token ScanLiteral(DtdParser.LiteralType literalType) { }

	// RVA: 0x12ECEC0 Offset: 0x12EB4C0 VA: 0x1812ECEC0
	private XmlQualifiedName ScanEntityName() { }

	// RVA: 0x12EE020 Offset: 0x12EC620 VA: 0x1812EE020
	private DtdParser.Token ScanNotation1() { }

	// RVA: 0x12EEF10 Offset: 0x12ED510 VA: 0x1812EEF10
	private DtdParser.Token ScanSystemId() { }

	// RVA: 0x12ECBB0 Offset: 0x12EB1B0 VA: 0x1812ECBB0
	private DtdParser.Token ScanEntity1() { }

	// RVA: 0x12ECC30 Offset: 0x12EB230 VA: 0x1812ECC30
	private DtdParser.Token ScanEntity2() { }

	// RVA: 0x12ECD70 Offset: 0x12EB370 VA: 0x1812ECD70
	private DtdParser.Token ScanEntity3() { }

	// RVA: 0x12EE120 Offset: 0x12EC720 VA: 0x1812EE120
	private DtdParser.Token ScanPublicId1() { }

	// RVA: 0x12EE1C0 Offset: 0x12EC7C0 VA: 0x1812EE1C0
	private DtdParser.Token ScanPublicId2() { }

	// RVA: 0x12EB550 Offset: 0x12E9B50 VA: 0x1812EB550
	private DtdParser.Token ScanCondSection1() { }

	// RVA: 0x12EB970 Offset: 0x12E9F70 VA: 0x1812EB970
	private DtdParser.Token ScanCondSection2() { }

	// RVA: 0x12EBA00 Offset: 0x12EA000 VA: 0x1812EBA00
	private DtdParser.Token ScanCondSection3() { }

	// RVA: 0x12EDE00 Offset: 0x12EC400 VA: 0x1812EDE00
	private void ScanName() { }

	// RVA: 0x12EE5C0 Offset: 0x12ECBC0 VA: 0x1812EE5C0
	private void ScanQName() { }

	// RVA: 0x12EE270 Offset: 0x12EC870 VA: 0x1812EE270
	private void ScanQName(bool isQName) { }

	// RVA: 0x12EA120 Offset: 0x12E8720 VA: 0x1812EA120
	private bool ReadDataInName() { }

	// RVA: 0x12EDE40 Offset: 0x12EC440 VA: 0x1812EDE40
	private void ScanNmtoken() { }

	// RVA: 0x12E4620 Offset: 0x12E2C20 VA: 0x1812E4620
	private bool EatPublicKeyword() { }

	// RVA: 0x12E4730 Offset: 0x12E2D30 VA: 0x1812E4730
	private bool EatSystemKeyword() { }

	// RVA: 0x12E4840 Offset: 0x12E2E40 VA: 0x1812E4840
	private XmlQualifiedName GetNameQualified(bool canHavePrefix) { }

	// RVA: 0x12E49E0 Offset: 0x12E2FE0 VA: 0x1812E49E0
	private string GetNameString() { }

	// RVA: 0x12E49E0 Offset: 0x12E2FE0 VA: 0x1812E49E0
	private string GetNmtokenString() { }

	// RVA: 0x12E5EB0 Offset: 0x12E44B0 VA: 0x1812E5EB0
	private string GetValue() { }

	// RVA: 0x12E5E20 Offset: 0x12E4420 VA: 0x1812E5E20
	private string GetValueWithStrippedSpaces() { }

	// RVA: 0x12EA170 Offset: 0x12E8770 VA: 0x1812EA170
	private int ReadData() { }

	// RVA: 0x12E6970 Offset: 0x12E4F70 VA: 0x1812E6970
	private void LoadParsingBuffer() { }

	// RVA: 0x12EA1E0 Offset: 0x12E87E0 VA: 0x1812EA1E0
	private void SaveParsingBuffer() { }

	// RVA: 0x12EA1F0 Offset: 0x12E87F0 VA: 0x1812EA1F0
	private void SaveParsingBuffer(int internalSubsetValueEndPos) { }

	// RVA: 0x12E6070 Offset: 0x12E4670 VA: 0x1812E6070
	private bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x12E60E0 Offset: 0x12E46E0 VA: 0x1812E60E0
	private bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x12E5F20 Offset: 0x12E4520 VA: 0x1812E5F20
	private bool HandleEntityEnd(bool inLiteral) { }

	// RVA: 0x12EFE70 Offset: 0x12EE470 VA: 0x1812EFE70
	private SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute) { }

	// RVA: 0x12EEFB0 Offset: 0x12ED5B0 VA: 0x1812EEFB0
	private void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x12EF200 Offset: 0x12ED800 VA: 0x1812EF200
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x12EF110 Offset: 0x12ED710 VA: 0x1812EF110
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e) { }

	// RVA: 0x12E6960 Offset: 0x12E4F60 VA: 0x1812E6960
	private bool IsAttributeValueType(DtdParser.Token token) { }

	// RVA: 0x12F0250 Offset: 0x12EE850 VA: 0x1812F0250
	private int get_LineNo() { }

	// RVA: 0x12F02A0 Offset: 0x12EE8A0 VA: 0x1812F02A0
	private int get_LinePos() { }

	// RVA: 0x12F0190 Offset: 0x12EE790 VA: 0x1812F0190
	private string get_BaseUriStr() { }

	// RVA: 0x12E6A80 Offset: 0x12E5080 VA: 0x1812E6A80
	private void OnUnexpectedError() { }

	// RVA: 0x12EFB20 Offset: 0x12EE120 VA: 0x1812EFB20
	private void Throw(int curPos, string res) { }

	// RVA: 0x12EFCC0 Offset: 0x12EE2C0 VA: 0x1812EFCC0
	private void Throw(int curPos, string res, string arg) { }

	// RVA: 0x12EF970 Offset: 0x12EDF70 VA: 0x1812EF970
	private void Throw(int curPos, string res, string[] args) { }

	// RVA: 0x12EFB90 Offset: 0x12EE190 VA: 0x1812EFB90
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x12EF5C0 Offset: 0x12EDBC0 VA: 0x1812EF5C0
	private void ThrowInvalidChar(int pos, string data, int invCharPos) { }

	// RVA: 0x12EF640 Offset: 0x12EDC40 VA: 0x1812EF640
	private void ThrowInvalidChar(char[] data, int length, int invCharPos) { }

	// RVA: 0x12EF6C0 Offset: 0x12EDCC0 VA: 0x1812EF6C0
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x12EF6E0 Offset: 0x12EDCE0 VA: 0x1812EF6E0
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x12E9CE0 Offset: 0x12E82E0 VA: 0x1812E9CE0
	private string ParseUnexpectedToken(int startPos) { }

	// RVA: 0x12EF350 Offset: 0x12ED950 VA: 0x1812EF350
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

	// RVA: 0x12F4800 Offset: 0x12F2E00 VA: 0x1812F4800
	internal void .ctor(string name, int lineNo, int linePos) { }

}

private class DtdParser.ParseElementOnlyContent_LocalFrame // TypeDefIndex: 1998
{	// Fields
	public int startParenEntityId; // 0x10
	public DtdParser.Token parsingSchema; // 0x14

	// Methods

	// RVA: 0x12F4750 Offset: 0x12F2D50 VA: 0x1812F4750
	public void .ctor(int startParentEntityIdParam) { }

}

