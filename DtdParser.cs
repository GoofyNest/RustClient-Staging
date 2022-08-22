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

	// RVA: 0x12F67F0 Offset: 0x12F4DF0 VA: 0x1812F67F0
	private void .ctor() { }

	// RVA: 0x12EAC50 Offset: 0x12E9250 VA: 0x1812EAC50
	internal static IDtdParser Create() { }

	// RVA: 0x12ECE60 Offset: 0x12EB460 VA: 0x1812ECE60
	private void Initialize(IDtdParserAdapter readerAdapter) { }

	// RVA: 0x12ECAA0 Offset: 0x12EB0A0 VA: 0x1812ECAA0
	private void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x12F5CF0 Offset: 0x12F42F0 VA: 0x1812F5CF0 Slot: 4
	private IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset) { }

	// RVA: 0x12F5CA0 Offset: 0x12F42A0 VA: 0x1812F5CA0 Slot: 5
	private IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x12F6A70 Offset: 0x12F5070 VA: 0x1812F6A70
	private bool get_ParsingInternalSubset() { }

	// RVA: 0x12F69B0 Offset: 0x12F4FB0 VA: 0x1812F69B0
	private bool get_IgnoreEntityReferences() { }

	// RVA: 0x12F6AA0 Offset: 0x12F50A0 VA: 0x1812F6AA0
	private bool get_SaveInternalSubsetValue() { }

	// RVA: 0x12F6A80 Offset: 0x12F5080 VA: 0x1812F6A80
	private bool get_ParsingTopLevelMarkup() { }

	// RVA: 0xBA2220 Offset: 0xBA0820 VA: 0x180BA2220
	private bool get_SupportNamespaces() { }

	// RVA: 0x4BC370 Offset: 0x4BA970 VA: 0x1804BC370
	private bool get_Normalize() { }

	// RVA: 0x12F0540 Offset: 0x12EEB40 VA: 0x1812F0540
	private void Parse(bool saveInternalSubset) { }

	// RVA: 0x12EFAF0 Offset: 0x12EE0F0 VA: 0x1812EFAF0
	private void ParseInDocumentDtd(bool saveInternalSubset) { }

	// RVA: 0x12EFA20 Offset: 0x12EE020 VA: 0x1812EFA20
	private void ParseFreeFloatingDtd() { }

	// RVA: 0x12EFC60 Offset: 0x12EE260 VA: 0x1812EFC60
	private void ParseInternalSubset() { }

	// RVA: 0x12EF8A0 Offset: 0x12EDEA0 VA: 0x1812EF8A0
	private void ParseExternalSubset() { }

	// RVA: 0x12EFF70 Offset: 0x12EE570 VA: 0x1812EFF70
	private void ParseSubset() { }

	// RVA: 0x12ED280 Offset: 0x12EB880 VA: 0x1812ED280
	private void ParseAttlistDecl() { }

	// RVA: 0x12EDA10 Offset: 0x12EC010 VA: 0x1812EDA10
	private void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors) { }

	// RVA: 0x12ED7E0 Offset: 0x12EBDE0 VA: 0x1812ED7E0
	private void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors) { }

	// RVA: 0x12EE4E0 Offset: 0x12ECAE0 VA: 0x1812EE4E0
	private void ParseElementDecl() { }

	// RVA: 0x12EEBB0 Offset: 0x12ED1B0 VA: 0x1812EEBB0
	private void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x12EFA80 Offset: 0x12EE080 VA: 0x1812EFA80
	private void ParseHowMany(ParticleContentValidator pcv) { }

	// RVA: 0x12EE8C0 Offset: 0x12ECEC0 VA: 0x1812EE8C0
	private void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x12EEFC0 Offset: 0x12ED5C0 VA: 0x1812EEFC0
	private void ParseEntityDecl() { }

	// RVA: 0x12EFC70 Offset: 0x12EE270 VA: 0x1812EFC70
	private void ParseNotationDecl() { }

	// RVA: 0x12EAA60 Offset: 0x12E9060 VA: 0x1812EAA60
	private void AddUndeclaredNotation(string notationName) { }

	// RVA: 0x12EE0A0 Offset: 0x12EC6A0 VA: 0x1812EE0A0
	private void ParseComment() { }

	// RVA: 0x12EFE70 Offset: 0x12EE470 VA: 0x1812EFE70
	private void ParsePI() { }

	// RVA: 0x12EE230 Offset: 0x12EC830 VA: 0x1812EE230
	private void ParseCondSection() { }

	// RVA: 0x12EF330 Offset: 0x12ED930 VA: 0x1812EF330
	private void ParseExternalId(DtdParser.Token idTokenType, DtdParser.Token declType, out string publicId, out string systemId) { }

	// RVA: 0x12EB180 Offset: 0x12E9780 VA: 0x1812EB180
	private DtdParser.Token GetToken(bool needWhiteSpace) { }

	// RVA: 0x12F4D40 Offset: 0x12F3340 VA: 0x1812F4D40
	private DtdParser.Token ScanSubsetContent() { }

	// RVA: 0x12F4540 Offset: 0x12F2B40 VA: 0x1812F4540
	private DtdParser.Token ScanNameExpected() { }

	// RVA: 0x12F49B0 Offset: 0x12F2FB0 VA: 0x1812F49B0
	private DtdParser.Token ScanQNameExpected() { }

	// RVA: 0x12F4580 Offset: 0x12F2B80 VA: 0x1812F4580
	private DtdParser.Token ScanNmtokenExpected() { }

	// RVA: 0x12F27C0 Offset: 0x12F0DC0 VA: 0x1812F27C0
	private DtdParser.Token ScanDoctype1() { }

	// RVA: 0x12F2900 Offset: 0x12F0F00 VA: 0x1812F2900
	private DtdParser.Token ScanDoctype2() { }

	// RVA: 0x12F1C30 Offset: 0x12F0230 VA: 0x1812F1C30
	private DtdParser.Token ScanClosingTag() { }

	// RVA: 0x12F29B0 Offset: 0x12F0FB0 VA: 0x1812F29B0
	private DtdParser.Token ScanElement1() { }

	// RVA: 0x12F2CC0 Offset: 0x12F12C0 VA: 0x1812F2CC0
	private DtdParser.Token ScanElement2() { }

	// RVA: 0x12F2F40 Offset: 0x12F1540 VA: 0x1812F2F40
	private DtdParser.Token ScanElement3() { }

	// RVA: 0x12F2FD0 Offset: 0x12F15D0 VA: 0x1812F2FD0
	private DtdParser.Token ScanElement4() { }

	// RVA: 0x12F30F0 Offset: 0x12F16F0 VA: 0x1812F30F0
	private DtdParser.Token ScanElement5() { }

	// RVA: 0x12F31F0 Offset: 0x12F17F0 VA: 0x1812F31F0
	private DtdParser.Token ScanElement6() { }

	// RVA: 0x12F32C0 Offset: 0x12F18C0 VA: 0x1812F32C0
	private DtdParser.Token ScanElement7() { }

	// RVA: 0x12F0A40 Offset: 0x12EF040 VA: 0x1812F0A40
	private DtdParser.Token ScanAttlist1() { }

	// RVA: 0x12F0B20 Offset: 0x12EF120 VA: 0x1812F0B20
	private DtdParser.Token ScanAttlist2() { }

	// RVA: 0x12F13F0 Offset: 0x12EF9F0 VA: 0x1812F13F0
	private DtdParser.Token ScanAttlist3() { }

	// RVA: 0x12F1490 Offset: 0x12EFA90 VA: 0x1812F1490
	private DtdParser.Token ScanAttlist4() { }

	// RVA: 0x12F1560 Offset: 0x12EFB60 VA: 0x1812F1560
	private DtdParser.Token ScanAttlist5() { }

	// RVA: 0x12F1630 Offset: 0x12EFC30 VA: 0x1812F1630
	private DtdParser.Token ScanAttlist6() { }

	// RVA: 0x12F1B80 Offset: 0x12F0180 VA: 0x1812F1B80
	private DtdParser.Token ScanAttlist7() { }

	// RVA: 0x12F3730 Offset: 0x12F1D30 VA: 0x1812F3730
	private DtdParser.Token ScanLiteral(DtdParser.LiteralType literalType) { }

	// RVA: 0x12F3630 Offset: 0x12F1C30 VA: 0x1812F3630
	private XmlQualifiedName ScanEntityName() { }

	// RVA: 0x12F4790 Offset: 0x12F2D90 VA: 0x1812F4790
	private DtdParser.Token ScanNotation1() { }

	// RVA: 0x12F5680 Offset: 0x12F3C80 VA: 0x1812F5680
	private DtdParser.Token ScanSystemId() { }

	// RVA: 0x12F3320 Offset: 0x12F1920 VA: 0x1812F3320
	private DtdParser.Token ScanEntity1() { }

	// RVA: 0x12F33A0 Offset: 0x12F19A0 VA: 0x1812F33A0
	private DtdParser.Token ScanEntity2() { }

	// RVA: 0x12F34E0 Offset: 0x12F1AE0 VA: 0x1812F34E0
	private DtdParser.Token ScanEntity3() { }

	// RVA: 0x12F4890 Offset: 0x12F2E90 VA: 0x1812F4890
	private DtdParser.Token ScanPublicId1() { }

	// RVA: 0x12F4930 Offset: 0x12F2F30 VA: 0x1812F4930
	private DtdParser.Token ScanPublicId2() { }

	// RVA: 0x12F1CC0 Offset: 0x12F02C0 VA: 0x1812F1CC0
	private DtdParser.Token ScanCondSection1() { }

	// RVA: 0x12F20E0 Offset: 0x12F06E0 VA: 0x1812F20E0
	private DtdParser.Token ScanCondSection2() { }

	// RVA: 0x12F2170 Offset: 0x12F0770 VA: 0x1812F2170
	private DtdParser.Token ScanCondSection3() { }

	// RVA: 0x12F4570 Offset: 0x12F2B70 VA: 0x1812F4570
	private void ScanName() { }

	// RVA: 0x12F4D30 Offset: 0x12F3330 VA: 0x1812F4D30
	private void ScanQName() { }

	// RVA: 0x12F49E0 Offset: 0x12F2FE0 VA: 0x1812F49E0
	private void ScanQName(bool isQName) { }

	// RVA: 0x12F0890 Offset: 0x12EEE90 VA: 0x1812F0890
	private bool ReadDataInName() { }

	// RVA: 0x12F45B0 Offset: 0x12F2BB0 VA: 0x1812F45B0
	private void ScanNmtoken() { }

	// RVA: 0x12EAD90 Offset: 0x12E9390 VA: 0x1812EAD90
	private bool EatPublicKeyword() { }

	// RVA: 0x12EAEA0 Offset: 0x12E94A0 VA: 0x1812EAEA0
	private bool EatSystemKeyword() { }

	// RVA: 0x12EAFB0 Offset: 0x12E95B0 VA: 0x1812EAFB0
	private XmlQualifiedName GetNameQualified(bool canHavePrefix) { }

	// RVA: 0x12EB150 Offset: 0x12E9750 VA: 0x1812EB150
	private string GetNameString() { }

	// RVA: 0x12EB150 Offset: 0x12E9750 VA: 0x1812EB150
	private string GetNmtokenString() { }

	// RVA: 0x12EC620 Offset: 0x12EAC20 VA: 0x1812EC620
	private string GetValue() { }

	// RVA: 0x12EC590 Offset: 0x12EAB90 VA: 0x1812EC590
	private string GetValueWithStrippedSpaces() { }

	// RVA: 0x12F08E0 Offset: 0x12EEEE0 VA: 0x1812F08E0
	private int ReadData() { }

	// RVA: 0x12ED0E0 Offset: 0x12EB6E0 VA: 0x1812ED0E0
	private void LoadParsingBuffer() { }

	// RVA: 0x12F0950 Offset: 0x12EEF50 VA: 0x1812F0950
	private void SaveParsingBuffer() { }

	// RVA: 0x12F0960 Offset: 0x12EEF60 VA: 0x1812F0960
	private void SaveParsingBuffer(int internalSubsetValueEndPos) { }

	// RVA: 0x12EC7E0 Offset: 0x12EADE0 VA: 0x1812EC7E0
	private bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x12EC850 Offset: 0x12EAE50 VA: 0x1812EC850
	private bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x12EC690 Offset: 0x12EAC90 VA: 0x1812EC690
	private bool HandleEntityEnd(bool inLiteral) { }

	// RVA: 0x12F65E0 Offset: 0x12F4BE0 VA: 0x1812F65E0
	private SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute) { }

	// RVA: 0x12F5720 Offset: 0x12F3D20 VA: 0x1812F5720
	private void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x12F5970 Offset: 0x12F3F70 VA: 0x1812F5970
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x12F5880 Offset: 0x12F3E80 VA: 0x1812F5880
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e) { }

	// RVA: 0x12ED0D0 Offset: 0x12EB6D0 VA: 0x1812ED0D0
	private bool IsAttributeValueType(DtdParser.Token token) { }

	// RVA: 0x12F69C0 Offset: 0x12F4FC0 VA: 0x1812F69C0
	private int get_LineNo() { }

	// RVA: 0x12F6A10 Offset: 0x12F5010 VA: 0x1812F6A10
	private int get_LinePos() { }

	// RVA: 0x12F6900 Offset: 0x12F4F00 VA: 0x1812F6900
	private string get_BaseUriStr() { }

	// RVA: 0x12ED1F0 Offset: 0x12EB7F0 VA: 0x1812ED1F0
	private void OnUnexpectedError() { }

	// RVA: 0x12F6290 Offset: 0x12F4890 VA: 0x1812F6290
	private void Throw(int curPos, string res) { }

	// RVA: 0x12F6430 Offset: 0x12F4A30 VA: 0x1812F6430
	private void Throw(int curPos, string res, string arg) { }

	// RVA: 0x12F60E0 Offset: 0x12F46E0 VA: 0x1812F60E0
	private void Throw(int curPos, string res, string[] args) { }

	// RVA: 0x12F6300 Offset: 0x12F4900 VA: 0x1812F6300
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x12F5D30 Offset: 0x12F4330 VA: 0x1812F5D30
	private void ThrowInvalidChar(int pos, string data, int invCharPos) { }

	// RVA: 0x12F5DB0 Offset: 0x12F43B0 VA: 0x1812F5DB0
	private void ThrowInvalidChar(char[] data, int length, int invCharPos) { }

	// RVA: 0x12F5E30 Offset: 0x12F4430 VA: 0x1812F5E30
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x12F5E50 Offset: 0x12F4450 VA: 0x1812F5E50
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x12F0450 Offset: 0x12EEA50 VA: 0x1812F0450
	private string ParseUnexpectedToken(int startPos) { }

	// RVA: 0x12F5AC0 Offset: 0x12F40C0 VA: 0x1812F5AC0
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

	// RVA: 0x12FAF70 Offset: 0x12F9570 VA: 0x1812FAF70
	internal void .ctor(string name, int lineNo, int linePos) { }

}

private class DtdParser.ParseElementOnlyContent_LocalFrame // TypeDefIndex: 1998
{	// Fields
	public int startParenEntityId; // 0x10
	public DtdParser.Token parsingSchema; // 0x14

	// Methods

	// RVA: 0x12FAEC0 Offset: 0x12F94C0 VA: 0x1812FAEC0
	public void .ctor(int startParentEntityIdParam) { }

}

