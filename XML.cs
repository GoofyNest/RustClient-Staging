internal class SmallXmlParser // TypeDefIndex: 24
{	// Fields
	private SmallXmlParser.IContentHandler handler; // 0x10
	private TextReader reader; // 0x18
	private Stack elementNames; // 0x20
	private Stack xmlSpaces; // 0x28
	private string xmlSpace; // 0x30
	private StringBuilder buffer; // 0x38
	private char[] nameBuffer; // 0x40
	private bool isWhitespace; // 0x48
	private SmallXmlParser.AttrListImpl attributes; // 0x50
	private int line; // 0x58
	private int column; // 0x5C
	private bool resetColumn; // 0x60

	// Methods

	// RVA: 0x1566340 Offset: 0x1564940 VA: 0x181566340
	public void .ctor() { }

	// RVA: 0x1564160 Offset: 0x1562760 VA: 0x181564160
	private Exception Error(string msg) { }

	// RVA: 0x1566280 Offset: 0x1564880 VA: 0x181566280
	private Exception UnexpectedEndError() { }

	// RVA: 0x1564540 Offset: 0x1562B40 VA: 0x181564540
	private bool IsNameChar(char c, bool start) { }

	// RVA: 0x15646E0 Offset: 0x1562CE0 VA: 0x1815646E0
	private bool IsWhitespace(int c) { }

	// RVA: 0x1566270 Offset: 0x1564870 VA: 0x181566270
	public void SkipWhitespaces() { }

	// RVA: 0x1564430 Offset: 0x1562A30 VA: 0x181564430
	private void HandleWhitespaces() { }

	// RVA: 0x1566180 Offset: 0x1564780 VA: 0x181566180
	public void SkipWhitespaces(bool expected) { }

	// RVA: 0x1564960 Offset: 0x1562F60 VA: 0x181564960
	private int Peek() { }

	// RVA: 0x1566120 Offset: 0x1564720 VA: 0x181566120
	private int Read() { }

	// RVA: 0x1564240 Offset: 0x1562840 VA: 0x181564240
	public void Expect(int c) { }

	// RVA: 0x1565FC0 Offset: 0x15645C0 VA: 0x181565FC0
	private string ReadUntil(char until, bool handleReferences) { }

	// RVA: 0x1565AC0 Offset: 0x15640C0 VA: 0x181565AC0
	public string ReadName() { }

	// RVA: 0x1564700 Offset: 0x1562D00 VA: 0x181564700
	public void Parse(TextReader input, SmallXmlParser.IContentHandler handler) { }

	// RVA: 0x1564060 Offset: 0x1562660 VA: 0x181564060
	private void Cleanup() { }

	// RVA: 0x15650F0 Offset: 0x15636F0 VA: 0x1815650F0
	public void ReadContent() { }

	// RVA: 0x1564360 Offset: 0x1562960 VA: 0x181564360
	private void HandleBufferedContent() { }

	// RVA: 0x1564E70 Offset: 0x1563470 VA: 0x181564E70
	private void ReadCharacters() { }

	// RVA: 0x1565DA0 Offset: 0x15643A0 VA: 0x181565DA0
	private void ReadReference() { }

	// RVA: 0x1564CC0 Offset: 0x15632C0 VA: 0x181564CC0
	private int ReadCharacterReference() { }

	// RVA: 0x1564990 Offset: 0x1562F90 VA: 0x181564990
	private void ReadAttribute(SmallXmlParser.AttrListImpl a) { }

	// RVA: 0x1564B40 Offset: 0x1563140 VA: 0x181564B40
	private void ReadCDATASection() { }

	// RVA: 0x1564F90 Offset: 0x1563590 VA: 0x181564F90
	private void ReadComment() { }

}

private class SmallXmlParser.AttrListImpl : SmallXmlParser.IAttrList // TypeDefIndex: 27
{	// Fields
	private List<string> attrNames; // 0x10
	private List<string> attrValues; // 0x18

	// Properties
	public int Length { get; }
	public string[] Names { get; }
	public string[] Values { get; }

	// Methods

	// RVA: 0x155B0E0 Offset: 0x15596E0 VA: 0x18155B0E0 Slot: 4
	public int get_Length() { }

	// RVA: 0x155AEA0 Offset: 0x15594A0 VA: 0x18155AEA0 Slot: 5
	public string GetName(int i) { }

	// RVA: 0x155AF00 Offset: 0x1559500 VA: 0x18155AF00 Slot: 6
	public string GetValue(int i) { }

	// RVA: 0x155AF60 Offset: 0x1559560 VA: 0x18155AF60 Slot: 7
	public string GetValue(string name) { }

	// RVA: 0x155B120 Offset: 0x1559720 VA: 0x18155B120 Slot: 8
	public string[] get_Names() { }

	// RVA: 0x155B170 Offset: 0x1559770 VA: 0x18155B170 Slot: 9
	public string[] get_Values() { }

	// RVA: 0x155AE40 Offset: 0x1559440 VA: 0x18155AE40
	internal void Clear() { }

	// RVA: 0x155ADC0 Offset: 0x15593C0 VA: 0x18155ADC0
	internal void Add(string name, string value) { }

	// RVA: 0x155B040 Offset: 0x1559640 VA: 0x18155B040
	public void .ctor() { }

}

internal class SmallXmlParserException : SystemException // TypeDefIndex: 28
{	// Fields
	private int line; // 0x88
	private int column; // 0x8C

	// Methods

	// RVA: 0x1563FA0 Offset: 0x15625A0 VA: 0x181563FA0
	public void .ctor(string msg, int line, int column) { }

}

public sealed class XmlSyntaxException : SystemException // TypeDefIndex: 909
{	// Methods

	// RVA: 0x18BB8A0 Offset: 0x18B9EA0 VA: 0x1818BB8A0
	public void .ctor() { }

	// RVA: 0x18C2EE0 Offset: 0x18C14E0 VA: 0x1818C2EE0
	public void .ctor(int lineNumber) { }

	// RVA: 0x18C2D60 Offset: 0x18C1360 VA: 0x1818C2D60
	public void .ctor(int lineNumber, string message) { }

	// RVA: 0x1485BE0 Offset: 0x14841E0 VA: 0x181485BE0
	public void .ctor(string message) { }

	// RVA: 0x18BB810 Offset: 0x18B9E10 VA: 0x1818BB810
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x18AF7E0 Offset: 0x18ADDE0 VA: 0x1818AF7E0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

}

internal class XPathParser // TypeDefIndex: 1800
{	// Fields
	private XPathScanner scanner; // 0x10
	private int parseDepth; // 0x18
	private static readonly XPathResultType[] temparray1; // 0x0
	private static readonly XPathResultType[] temparray2; // 0x8
	private static readonly XPathResultType[] temparray3; // 0x10
	private static readonly XPathResultType[] temparray4; // 0x18
	private static readonly XPathResultType[] temparray5; // 0x20
	private static readonly XPathResultType[] temparray6; // 0x28
	private static readonly XPathResultType[] temparray7; // 0x30
	private static readonly XPathResultType[] temparray8; // 0x38
	private static readonly XPathResultType[] temparray9; // 0x40
	private static Hashtable functionTable; // 0x48
	private static Hashtable AxesTable; // 0x50

	// Methods

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	private void .ctor(XPathScanner scanner) { }

	// RVA: 0x12FFC40 Offset: 0x12FE240 VA: 0x1812FFC40
	public static AstNode ParseXPathExpresion(string xpathExpresion) { }

	// RVA: 0x12FDB20 Offset: 0x12FC120 VA: 0x1812FDB20
	private AstNode ParseExpresion(AstNode qyInput) { }

	// RVA: 0x12FEC80 Offset: 0x12FD280 VA: 0x1812FEC80
	private AstNode ParseOrExpr(AstNode qyInput) { }

	// RVA: 0x12FD8B0 Offset: 0x12FBEB0 VA: 0x1812FD8B0
	private AstNode ParseAndExpr(AstNode qyInput) { }

	// RVA: 0x12FDA00 Offset: 0x12FC000 VA: 0x1812FDA00
	private AstNode ParseEqualityExpr(AstNode qyInput) { }

	// RVA: 0x12FF2F0 Offset: 0x12FD8F0 VA: 0x1812FF2F0
	private AstNode ParseRelationalExpr(AstNode qyInput) { }

	// RVA: 0x12FD790 Offset: 0x12FBD90 VA: 0x1812FD790
	private AstNode ParseAdditiveExpr(AstNode qyInput) { }

	// RVA: 0x12FE7E0 Offset: 0x12FCDE0 VA: 0x1812FE7E0
	private AstNode ParseMultiplicativeExpr(AstNode qyInput) { }

	// RVA: 0x12FF8E0 Offset: 0x12FDEE0 VA: 0x1812FF8E0
	private AstNode ParseUnaryExpr(AstNode qyInput) { }

	// RVA: 0x12FFA30 Offset: 0x12FE030 VA: 0x1812FFA30
	private AstNode ParseUnionExpr(AstNode qyInput) { }

	// RVA: 0x12FD5F0 Offset: 0x12FBBF0 VA: 0x1812FD5F0
	private static bool IsNodeType(XPathScanner scaner) { }

	// RVA: 0x12FEDD0 Offset: 0x12FD3D0 VA: 0x1812FEDD0
	private AstNode ParsePathExpr(AstNode qyInput) { }

	// RVA: 0x12FDCC0 Offset: 0x12FC2C0 VA: 0x1812FDCC0
	private AstNode ParseFilterExpr(AstNode qyInput) { }

	// RVA: 0x12FF020 Offset: 0x12FD620 VA: 0x1812FF020
	private AstNode ParsePredicate(AstNode qyInput) { }

	// RVA: 0x12FDF10 Offset: 0x12FC510 VA: 0x1812FDF10
	private AstNode ParseLocationPath(AstNode qyInput) { }

	// RVA: 0x12FF420 Offset: 0x12FDA20 VA: 0x1812FF420
	private AstNode ParseRelativeLocationPath(AstNode qyInput) { }

	// RVA: 0x12FD740 Offset: 0x12FBD40 VA: 0x1812FD740
	private static bool IsStep(XPathScanner.LexKind lexKind) { }

	// RVA: 0x12FF500 Offset: 0x12FDB00 VA: 0x1812FF500
	private AstNode ParseStep(AstNode qyInput) { }

	// RVA: 0x12FE990 Offset: 0x12FCF90 VA: 0x1812FE990
	private AstNode ParseNodeTest(AstNode qyInput, Axis.AxisType axisType, XPathNodeType nodeType) { }

	// RVA: 0x12FD6A0 Offset: 0x12FBCA0 VA: 0x1812FD6A0
	private static bool IsPrimaryExpr(XPathScanner scanner) { }

	// RVA: 0x12FF0C0 Offset: 0x12FD6C0 VA: 0x1812FF0C0
	private AstNode ParsePrimaryExpr(AstNode qyInput) { }

	// RVA: 0x12FE050 Offset: 0x12FC650 VA: 0x1812FE050
	private AstNode ParseMethod(AstNode qyInput) { }

	// RVA: 0x12FC580 Offset: 0x12FAB80 VA: 0x1812FC580
	private void CheckToken(XPathScanner.LexKind t) { }

	// RVA: 0x12FFDD0 Offset: 0x12FE3D0 VA: 0x1812FFDD0
	private void PassToken(XPathScanner.LexKind t) { }

	// RVA: 0x12FD770 Offset: 0x12FBD70 VA: 0x1812FD770
	private void NextLex() { }

	// RVA: 0x12FFE00 Offset: 0x12FE400 VA: 0x1812FFE00
	private bool TestOp(string op) { }

	// RVA: 0x12FC500 Offset: 0x12FAB00 VA: 0x1812FC500
	private void CheckNodeSet(XPathResultType t) { }

	// RVA: 0x12FC930 Offset: 0x12FAF30 VA: 0x1812FC930
	private static Hashtable CreateFunctionTable() { }

	// RVA: 0x12FC610 Offset: 0x12FAC10 VA: 0x1812FC610
	private static Hashtable CreateAxesTable() { }

	// RVA: 0x12FD4F0 Offset: 0x12FBAF0 VA: 0x1812FD4F0
	private Axis.AxisType GetAxis(XPathScanner scaner) { }

	// RVA: 0x12FFE50 Offset: 0x12FE450 VA: 0x1812FFE50
	private static void .cctor() { }

}

private class XPathParser.ParamInfo // TypeDefIndex: 1801
{	// Fields
	private Function.FunctionType ftype; // 0x10
	private int minargs; // 0x14
	private int maxargs; // 0x18
	private XPathResultType[] argTypes; // 0x20

	// Properties
	public Function.FunctionType FType { get; }
	public int Minargs { get; }
	public int Maxargs { get; }
	public XPathResultType[] ArgTypes { get; }

	// Methods

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public Function.FunctionType get_FType() { }

	// RVA: 0x57C960 Offset: 0x57AF60 VA: 0x18057C960
	public int get_Minargs() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public int get_Maxargs() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public XPathResultType[] get_ArgTypes() { }

	// RVA: 0x12FAE60 Offset: 0x12F9460 VA: 0x1812FAE60
	internal void .ctor(Function.FunctionType ftype, int minargs, int maxargs, XPathResultType[] argTypes) { }

}

internal sealed class XPathScanner // TypeDefIndex: 1802
{	// Fields
	private string xpathExpr; // 0x10
	private int xpathExprIndex; // 0x18
	private XPathScanner.LexKind kind; // 0x1C
	private char currentChar; // 0x20
	private string name; // 0x28
	private string prefix; // 0x30
	private string stringValue; // 0x38
	private double numberValue; // 0x40
	private bool canBeFunction; // 0x48
	private XmlCharType xmlCharType; // 0x50

	// Properties
	public string SourceText { get; }
	private char CurerntChar { get; }
	public XPathScanner.LexKind Kind { get; }
	public string Name { get; }
	public string Prefix { get; }
	public string StringValue { get; }
	public double NumberValue { get; }
	public bool CanBeFunction { get; }

	// Methods

	// RVA: 0x1300C70 Offset: 0x12FF270 VA: 0x181300C70
	public void .ctor(string xpathExpr) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_SourceText() { }

	// RVA: 0x1300D60 Offset: 0x12FF360 VA: 0x181300D60
	private char get_CurerntChar() { }

	// RVA: 0x13001A0 Offset: 0x12FE7A0 VA: 0x1813001A0
	private bool NextChar() { }

	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0
	public XPathScanner.LexKind get_Kind() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public string get_Name() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_Prefix() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public string get_StringValue() { }

	// RVA: 0x1300D70 Offset: 0x12FF370 VA: 0x181300D70
	public double get_NumberValue() { }

	// RVA: 0x4BC370 Offset: 0x4BA970 VA: 0x1804BC370
	public bool get_CanBeFunction() { }

	// RVA: 0x1300BD0 Offset: 0x12FF1D0 VA: 0x181300BD0
	private void SkipSpace() { }

	// RVA: 0x13001F0 Offset: 0x12FE7F0 VA: 0x1813001F0
	public bool NextLex() { }

	// RVA: 0x1300920 Offset: 0x12FEF20 VA: 0x181300920
	private double ScanNumber() { }

	// RVA: 0x1300770 Offset: 0x12FED70 VA: 0x181300770
	private double ScanFraction() { }

	// RVA: 0x1300A90 Offset: 0x12FF090 VA: 0x181300A90
	private string ScanString() { }

	// RVA: 0x1300860 Offset: 0x12FEE60 VA: 0x181300860
	private string ScanName() { }

}

public enum XPathScanner.LexKind // TypeDefIndex: 1803
{	// Fields
	public int value__; // 0x0
	public const XPathScanner.LexKind Comma = 44;
	public const XPathScanner.LexKind Slash = 47;
	public const XPathScanner.LexKind At = 64;
	public const XPathScanner.LexKind Dot = 46;
	public const XPathScanner.LexKind LParens = 40;
	public const XPathScanner.LexKind RParens = 41;
	public const XPathScanner.LexKind LBracket = 91;
	public const XPathScanner.LexKind RBracket = 93;
	public const XPathScanner.LexKind Star = 42;
	public const XPathScanner.LexKind Plus = 43;
	public const XPathScanner.LexKind Minus = 45;
	public const XPathScanner.LexKind Eq = 61;
	public const XPathScanner.LexKind Lt = 60;
	public const XPathScanner.LexKind Gt = 62;
	public const XPathScanner.LexKind Bang = 33;
	public const XPathScanner.LexKind Dollar = 36;
	public const XPathScanner.LexKind Apos = 39;
	public const XPathScanner.LexKind Quote = 34;
	public const XPathScanner.LexKind Union = 124;
	public const XPathScanner.LexKind Ne = 78;
	public const XPathScanner.LexKind Le = 76;
	public const XPathScanner.LexKind Ge = 71;
	public const XPathScanner.LexKind And = 65;
	public const XPathScanner.LexKind Or = 79;
	public const XPathScanner.LexKind DotDot = 68;
	public const XPathScanner.LexKind SlashSlash = 83;
	public const XPathScanner.LexKind Name = 110;
	public const XPathScanner.LexKind String = 115;
	public const XPathScanner.LexKind Number = 100;
	public const XPathScanner.LexKind Axe = 97;
	public const XPathScanner.LexKind Eof = 69;

}

internal sealed class XPathDocumentNavigator : XPathNavigator, IXmlLineInfo // TypeDefIndex: 1804
{	// Fields
	private XPathNode[] pageCurrent; // 0x10
	private XPathNode[] pageParent; // 0x18
	private int idxCurrent; // 0x20
	private int idxParent; // 0x24

	// Properties
	public override string Value { get; }
	public override XPathNodeType NodeType { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override XmlNameTable NameTable { get; }
	public override object UnderlyingObject { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }

	// Methods

	// RVA: 0x12FB760 Offset: 0x12F9D60 VA: 0x1812FB760
	public void .ctor(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent) { }

	// RVA: 0x12FBAE0 Offset: 0x12FA0E0 VA: 0x1812FBAE0 Slot: 5
	public override string get_Value() { }

	// RVA: 0x12FAFE0 Offset: 0x12F95E0 VA: 0x1812FAFE0 Slot: 23
	public override XPathNavigator Clone() { }

	// RVA: 0x12FBA50 Offset: 0x12FA050 VA: 0x1812FBA50 Slot: 24
	public override XPathNodeType get_NodeType() { }

	// RVA: 0x12FB960 Offset: 0x12F9F60 VA: 0x1812FB960 Slot: 25
	public override string get_LocalName() { }

	// RVA: 0x12FBA00 Offset: 0x12FA000 VA: 0x1812FBA00 Slot: 26
	public override string get_NamespaceURI() { }

	// RVA: 0x12FBA90 Offset: 0x12FA090 VA: 0x1812FBA90 Slot: 27
	public override string get_Prefix() { }

	// RVA: 0x12FB9B0 Offset: 0x12F9FB0 VA: 0x1812FB9B0 Slot: 19
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x12FB1B0 Offset: 0x12F97B0 VA: 0x1812FB1B0 Slot: 30
	public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: 0x12FB450 Offset: 0x12F9A50 VA: 0x1812FB450 Slot: 31
	public override bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x12FB660 Offset: 0x12F9C60 VA: 0x1812FB660 Slot: 32
	public override bool MoveToParent() { }

	// RVA: 0x12FB120 Offset: 0x12F9720 VA: 0x1812FB120 Slot: 33
	public override bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0xE524B0 Offset: 0xE50AB0 VA: 0x180E524B0 Slot: 28
	public override object get_UnderlyingObject() { }

	// RVA: 0x12FB0D0 Offset: 0x12F96D0 VA: 0x1812FB0D0 Slot: 35
	public bool HasLineInfo() { }

	// RVA: 0x12FB800 Offset: 0x12F9E00 VA: 0x1812FB800 Slot: 36
	public int get_LineNumber() { }

	// RVA: 0x12FB8A0 Offset: 0x12F9EA0 VA: 0x1812FB8A0 Slot: 37
	public int get_LinePosition() { }

	// RVA: 0x12FB0C0 Offset: 0x12F96C0 VA: 0x1812FB0C0
	public int GetPositionHashCode() { }

}

internal struct XPathNode // TypeDefIndex: 1805
{	// Fields
	private XPathNodeInfoAtom info; // 0x0
	private ushort idxSibling; // 0x8
	private ushort idxParent; // 0xA
	private ushort idxSimilar; // 0xC
	private ushort posOffset; // 0xE
	private uint props; // 0x10
	private string value; // 0x18

	// Properties
	public XPathNodeType NodeType { get; }
	public string Prefix { get; }
	public string LocalName { get; }
	public string NamespaceUri { get; }
	public XPathDocument Document { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	public int CollapsedLinePosition { get; }
	public XPathNodePageInfo PageInfo { get; }
	public bool IsXmlNamespaceNode { get; }
	public bool HasSibling { get; }
	public bool HasCollapsedText { get; }
	public bool IsText { get; }
	public bool HasNamespaceDecls { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x1E0AE0 Offset: 0x1DFEE0 VA: 0x1801E0AE0
	public XPathNodeType get_NodeType() { }

	// RVA: 0x1E0B10 Offset: 0x1DFF10 VA: 0x1801E0B10
	public string get_Prefix() { }

	// RVA: 0x1E0AA0 Offset: 0x1DFEA0 VA: 0x1801E0AA0
	public string get_LocalName() { }

	// RVA: 0x1E0AC0 Offset: 0x1DFEC0 VA: 0x1801E0AC0
	public string get_NamespaceUri() { }

	// RVA: 0x1E0930 Offset: 0x1DFD30 VA: 0x1801E0930
	public XPathDocument get_Document() { }

	// RVA: 0x1E0A50 Offset: 0x1DFE50 VA: 0x1801E0A50
	public int get_LineNumber() { }

	// RVA: 0x1E0A80 Offset: 0x1DFE80 VA: 0x1801E0A80
	public int get_LinePosition() { }

	// RVA: 0x1E0900 Offset: 0x1DFD00 VA: 0x1801E0900
	public int get_CollapsedLinePosition() { }

	// RVA: 0x1E0AF0 Offset: 0x1DFEF0 VA: 0x1801E0AF0
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x1E0880 Offset: 0x1DFC80 VA: 0x1801E0880
	public int GetParent(out XPathNode[] pageNode) { }

	// RVA: 0x1E08C0 Offset: 0x1DFCC0 VA: 0x1801E08C0
	public int GetSibling(out XPathNode[] pageNode) { }

	// RVA: 0x1E09E0 Offset: 0x1DFDE0 VA: 0x1801E09E0
	public bool get_IsXmlNamespaceNode() { }

	// RVA: 0x1E0970 Offset: 0x1DFD70 VA: 0x1801E0970
	public bool get_HasSibling() { }

	// RVA: 0x1E0950 Offset: 0x1DFD50 VA: 0x1801E0950
	public bool get_HasCollapsedText() { }

	// RVA: 0x1E0980 Offset: 0x1DFD80 VA: 0x1801E0980
	public bool get_IsText() { }

	// RVA: 0x1E0960 Offset: 0x1DFD60 VA: 0x1801E0960
	public bool get_HasNamespaceDecls() { }

	// RVA: 0xF3EF0 Offset: 0xF32F0 VA: 0x1800F3EF0
	public string get_Value() { }

}

internal struct XPathNodeRef // TypeDefIndex: 1806
{	// Fields
	private XPathNode[] page; // 0x0
	private int idx; // 0x8

	// Properties
	public XPathNode[] Page { get; }
	public int Index { get; }

	// Methods

	// RVA: 0xF9160 Offset: 0xF8560 VA: 0x1800F9160
	public void .ctor(XPathNode[] page, int idx) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public XPathNode[] get_Page() { }

	// RVA: 0x122C30 Offset: 0x122030 VA: 0x180122C30
	public int get_Index() { }

	// RVA: 0x1E0810 Offset: 0x1DFC10 VA: 0x1801E0810 Slot: 2
	public override int GetHashCode() { }

}

internal abstract class XPathNodeHelper // TypeDefIndex: 1807
{	// Methods

	// RVA: 0x12FBF60 Offset: 0x12FA560 VA: 0x1812FBF60
	public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0x12FBE20 Offset: 0x12FA420 VA: 0x1812FBE20
	public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0x12FC130 Offset: 0x12FA730 VA: 0x1812FC130
	public static bool GetParent(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x12FBFE0 Offset: 0x12FA5E0 VA: 0x1812FBFE0
	public static int GetLocation(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x12FC1D0 Offset: 0x12FA7D0 VA: 0x1812FC1D0
	public static bool GetTextFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd) { }

	// RVA: 0x12FC030 Offset: 0x12FA630 VA: 0x1812FC030
	public static bool GetNonDescendant(ref XPathNode[] pageNode, ref int idxNode) { }

}

internal sealed class XPathNodePageInfo // TypeDefIndex: 1808
{	// Fields
	private int pageNum; // 0x10
	private int nodeCount; // 0x14
	private XPathNode[] pageNext; // 0x18

	// Properties
	public int PageNumber { get; }
	public int NodeCount { get; }
	public XPathNode[] NextPage { get; }

	// Methods

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_PageNumber() { }

	// RVA: 0x57C960 Offset: 0x57AF60 VA: 0x18057C960
	public int get_NodeCount() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public XPathNode[] get_NextPage() { }

}

internal sealed class XPathNodeInfoAtom // TypeDefIndex: 1809
{	// Fields
	private string localName; // 0x10
	private string namespaceUri; // 0x18
	private string prefix; // 0x20
	private XPathNode[] pageParent; // 0x28
	private XPathNode[] pageSibling; // 0x30
	private XPathDocument doc; // 0x38
	private int lineNumBase; // 0x40
	private int linePosBase; // 0x44
	private XPathNodePageInfo pageInfo; // 0x48

	// Properties
	public XPathNodePageInfo PageInfo { get; }
	public string LocalName { get; }
	public string NamespaceUri { get; }
	public string Prefix { get; }
	public XPathNode[] SiblingPage { get; }
	public XPathNode[] ParentPage { get; }
	public XPathDocument Document { get; }
	public int LineNumberBase { get; }
	public int LinePositionBase { get; }

	// Methods

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_LocalName() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_NamespaceUri() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Prefix() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public XPathNode[] get_SiblingPage() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public XPathNode[] get_ParentPage() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public XPathDocument get_Document() { }

	// RVA: 0x5DE3D0 Offset: 0x5DC9D0 VA: 0x1805DE3D0
	public int get_LineNumberBase() { }

	// RVA: 0x5DE3E0 Offset: 0x5DC9E0 VA: 0x1805DE3E0
	public int get_LinePositionBase() { }

}

internal class XmlRawWriterBase64Encoder : Base64Encoder // TypeDefIndex: 1814
{	// Fields
	private XmlRawWriter rawWriter; // 0x28

	// Methods

	// RVA: 0xBA1070 Offset: 0xB9F670 VA: 0x180BA1070
	internal void .ctor(XmlRawWriter rawWriter) { }

	// RVA: 0xBA1040 Offset: 0xB9F640 VA: 0x180BA1040 Slot: 4
	internal override void WriteChars(char[] chars, int index, int count) { }

}

internal class XmlTextWriterBase64Encoder : Base64Encoder // TypeDefIndex: 1815
{	// Fields
	private XmlTextEncoder xmlTextEncoder; // 0x28

	// Methods

	// RVA: 0xBA1070 Offset: 0xB9F670 VA: 0x180BA1070
	internal void .ctor(XmlTextEncoder xmlTextEncoder) { }

	// RVA: 0x1318D90 Offset: 0x1317390 VA: 0x181318D90 Slot: 4
	internal override void WriteChars(char[] chars, int index, int count) { }

}

internal enum BinXmlToken // TypeDefIndex: 1818
{	// Fields
	public int value__; // 0x0
	public const BinXmlToken Error = 0;
	public const BinXmlToken NotImpl = -2;
	public const BinXmlToken EOF = -1;
	public const BinXmlToken XmlDecl = 254;
	public const BinXmlToken Encoding = 253;
	public const BinXmlToken DocType = 252;
	public const BinXmlToken System = 251;
	public const BinXmlToken Public = 250;
	public const BinXmlToken Subset = 249;
	public const BinXmlToken Element = 248;
	public const BinXmlToken EndElem = 247;
	public const BinXmlToken Attr = 246;
	public const BinXmlToken EndAttrs = 245;
	public const BinXmlToken PI = 244;
	public const BinXmlToken Comment = 243;
	public const BinXmlToken CData = 242;
	public const BinXmlToken EndCData = 241;
	public const BinXmlToken Name = 240;
	public const BinXmlToken QName = 239;
	public const BinXmlToken XmlText = 237;
	public const BinXmlToken Nest = 236;
	public const BinXmlToken EndNest = 235;
	public const BinXmlToken Extn = 234;
	public const BinXmlToken NmFlush = 233;
	public const BinXmlToken SQL_BIT = 6;
	public const BinXmlToken SQL_TINYINT = 7;
	public const BinXmlToken SQL_SMALLINT = 1;
	public const BinXmlToken SQL_INT = 2;
	public const BinXmlToken SQL_BIGINT = 8;
	public const BinXmlToken SQL_REAL = 3;
	public const BinXmlToken SQL_FLOAT = 4;
	public const BinXmlToken SQL_MONEY = 5;
	public const BinXmlToken SQL_SMALLMONEY = 20;
	public const BinXmlToken SQL_DATETIME = 18;
	public const BinXmlToken SQL_SMALLDATETIME = 19;
	public const BinXmlToken SQL_DECIMAL = 10;
	public const BinXmlToken SQL_NUMERIC = 11;
	public const BinXmlToken SQL_UUID = 9;
	public const BinXmlToken SQL_VARBINARY = 15;
	public const BinXmlToken SQL_BINARY = 12;
	public const BinXmlToken SQL_IMAGE = 23;
	public const BinXmlToken SQL_CHAR = 13;
	public const BinXmlToken SQL_VARCHAR = 16;
	public const BinXmlToken SQL_TEXT = 22;
	public const BinXmlToken SQL_NVARCHAR = 17;
	public const BinXmlToken SQL_NCHAR = 14;
	public const BinXmlToken SQL_NTEXT = 24;
	public const BinXmlToken SQL_UDT = 27;
	public const BinXmlToken XSD_KATMAI_DATE = 127;
	public const BinXmlToken XSD_KATMAI_DATETIME = 126;
	public const BinXmlToken XSD_KATMAI_TIME = 125;
	public const BinXmlToken XSD_KATMAI_DATEOFFSET = 124;
	public const BinXmlToken XSD_KATMAI_DATETIMEOFFSET = 123;
	public const BinXmlToken XSD_KATMAI_TIMEOFFSET = 122;
	public const BinXmlToken XSD_BOOLEAN = 134;
	public const BinXmlToken XSD_TIME = 129;
	public const BinXmlToken XSD_DATETIME = 130;
	public const BinXmlToken XSD_DATE = 131;
	public const BinXmlToken XSD_BINHEX = 132;
	public const BinXmlToken XSD_BASE64 = 133;
	public const BinXmlToken XSD_DECIMAL = 135;
	public const BinXmlToken XSD_BYTE = 136;
	public const BinXmlToken XSD_UNSIGNEDSHORT = 137;
	public const BinXmlToken XSD_UNSIGNEDINT = 138;
	public const BinXmlToken XSD_UNSIGNEDLONG = 139;
	public const BinXmlToken XSD_QNAME = 140;

}

internal struct BinXmlSqlDecimal // TypeDefIndex: 1819
{	// Fields
	internal byte m_bLen; // 0x0
	internal byte m_bPrec; // 0x1
	internal byte m_bScale; // 0x2
	internal byte m_bSign; // 0x3
	internal uint m_data1; // 0x4
	internal uint m_data2; // 0x8
	internal uint m_data3; // 0xC
	internal uint m_data4; // 0x10
	private static readonly byte NUMERIC_MAX_PRECISION; // 0x0
	private static readonly byte MaxPrecision; // 0x1
	private static readonly byte MaxScale; // 0x2
	private static readonly int x_cNumeMax; // 0x4
	private static readonly long x_lInt32Base; // 0x8
	private static readonly ulong x_ulInt32Base; // 0x10
	private static readonly ulong x_ulInt32BaseForMod; // 0x18
	internal static readonly ulong x_llMax; // 0x20
	private static readonly double DUINT_BASE; // 0x28
	private static readonly double DUINT_BASE2; // 0x30
	private static readonly double DUINT_BASE3; // 0x38
	private static readonly uint[] x_rgulShiftBase; // 0x40
	private static readonly byte[] rgCLenFromPrec; // 0x48

	// Properties
	public bool IsPositive { get; }

	// Methods

	// RVA: 0x1E06E0 Offset: 0x1DFAE0 VA: 0x1801E06E0
	public bool get_IsPositive() { }

	// RVA: 0x1E06D0 Offset: 0x1DFAD0 VA: 0x1801E06D0
	public void .ctor(byte[] data, int offset, bool trim) { }

	// RVA: 0x12033B0 Offset: 0x12019B0 VA: 0x1812033B0
	private static uint UIntFromByteArray(byte[] data, int offset) { }

	// RVA: 0x12E7BF0 Offset: 0x12E61F0 VA: 0x1812E7BF0
	private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	// RVA: 0xEA44E0 Offset: 0xEA2AE0 VA: 0x180EA44E0
	private static void MpNormalize(uint[] rgulU, ref int ciulU) { }

	// RVA: 0xEA2330 Offset: 0xEA0930 VA: 0x180EA2330
	private static char ChFromDigit(uint uiDigit) { }

	// RVA: 0x1E05F0 Offset: 0x1DF9F0 VA: 0x1801E05F0
	public Decimal ToDecimal() { }

	// RVA: 0x1E06C0 Offset: 0x1DFAC0 VA: 0x1801E06C0
	private void TrimTrailingZeros() { }

	// RVA: 0x1E06B0 Offset: 0x1DFAB0 VA: 0x1801E06B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x12E8590 Offset: 0x12E6B90 VA: 0x1812E8590
	private static void .cctor() { }

}

internal struct BinXmlSqlMoney // TypeDefIndex: 1820
{	// Fields
	private long data; // 0x0

	// Methods

	// RVA: 0x1E0800 Offset: 0x1DFC00 VA: 0x1801E0800
	public void .ctor(int v) { }

	// RVA: 0x1D3520 Offset: 0x1D2920 VA: 0x1801D3520
	public void .ctor(long v) { }

	// RVA: 0x1E06F0 Offset: 0x1DFAF0 VA: 0x1801E06F0
	public Decimal ToDecimal() { }

	// RVA: 0x1E0740 Offset: 0x1DFB40 VA: 0x1801E0740 Slot: 3
	public override string ToString() { }

}

internal abstract class BinXmlDateTime // TypeDefIndex: 1821
{	// Fields
	internal static int[] KatmaiTimeScaleMultiplicator; // 0x0
	private static readonly double SQLTicksPerMillisecond; // 0x8
	public static readonly int SQLTicksPerSecond; // 0x10
	public static readonly int SQLTicksPerMinute; // 0x14
	public static readonly int SQLTicksPerHour; // 0x18
	private static readonly int SQLTicksPerDay; // 0x1C

	// Methods

	// RVA: 0x12E5B30 Offset: 0x12E4130 VA: 0x1812E5B30
	private static void Write2Dig(StringBuilder sb, int val) { }

	// RVA: 0x12E5C60 Offset: 0x12E4260 VA: 0x1812E5C60
	private static void Write4DigNeg(StringBuilder sb, int val) { }

	// RVA: 0x12E5BA0 Offset: 0x12E41A0 VA: 0x1812E5BA0
	private static void Write3Dec(StringBuilder sb, int val) { }

	// RVA: 0x12E5D90 Offset: 0x12E4390 VA: 0x1812E5D90
	private static void WriteDate(StringBuilder sb, int yr, int mnth, int day) { }

	// RVA: 0x12E6410 Offset: 0x12E4A10 VA: 0x1812E6410
	private static void WriteTime(StringBuilder sb, int hr, int min, int sec, int ms) { }

	// RVA: 0x12E5FC0 Offset: 0x12E45C0 VA: 0x1812E5FC0
	private static void WriteTimeFullPrecision(StringBuilder sb, int hr, int min, int sec, int fraction) { }

	// RVA: 0x12E6210 Offset: 0x12E4810 VA: 0x1812E6210
	private static void WriteTimeZone(StringBuilder sb, TimeSpan zone) { }

	// RVA: 0x12E62D0 Offset: 0x12E48D0 VA: 0x1812E62D0
	private static void WriteTimeZone(StringBuilder sb, bool negTimeZone, int hr, int min) { }

	// RVA: 0x12E4E00 Offset: 0x12E3400 VA: 0x1812E4E00
	private static void BreakDownXsdDateTime(long val, out int yr, out int mnth, out int day, out int hr, out int min, out int sec, out int ms) { }

	// RVA: 0x12E4FC0 Offset: 0x12E35C0 VA: 0x1812E4FC0
	private static void BreakDownXsdDate(long val, out int yr, out int mnth, out int day, out bool negTimeZone, out int hr, out int min) { }

	// RVA: 0x12E5120 Offset: 0x12E3720 VA: 0x1812E5120
	private static void BreakDownXsdTime(long val, out int hr, out int min, out int sec, out int ms) { }

	// RVA: 0x12E6630 Offset: 0x12E4C30 VA: 0x1812E6630
	public static string XsdDateTimeToString(long val) { }

	// RVA: 0x12E68B0 Offset: 0x12E4EB0 VA: 0x1812E68B0
	public static string XsdDateToString(long val) { }

	// RVA: 0x12E7960 Offset: 0x12E5F60 VA: 0x1812E7960
	public static string XsdTimeToString(long val) { }

	// RVA: 0x12E58F0 Offset: 0x12E3EF0 VA: 0x1812E58F0
	public static string SqlDateTimeToString(int dateticks, uint timeticks) { }

	// RVA: 0x12E5830 Offset: 0x12E3E30 VA: 0x1812E5830
	public static DateTime SqlDateTimeToDateTime(int dateticks, uint timeticks) { }

	// RVA: 0x12E5A30 Offset: 0x12E4030 VA: 0x1812E5A30
	public static string SqlSmallDateTimeToString(short dateticks, ushort timeticks) { }

	// RVA: 0x12E59B0 Offset: 0x12E3FB0 VA: 0x1812E59B0
	public static DateTime SqlSmallDateTimeToDateTime(short dateticks, ushort timeticks) { }

	// RVA: 0x12E72E0 Offset: 0x12E58E0 VA: 0x1812E72E0
	public static DateTime XsdKatmaiDateToDateTime(byte[] data, int offset) { }

	// RVA: 0x12E7070 Offset: 0x12E5670 VA: 0x1812E7070
	public static DateTime XsdKatmaiDateTimeToDateTime(byte[] data, int offset) { }

	// RVA: 0x12E77B0 Offset: 0x12E5DB0 VA: 0x1812E77B0
	public static DateTime XsdKatmaiTimeToDateTime(byte[] data, int offset) { }

	// RVA: 0x12E6B90 Offset: 0x12E5190 VA: 0x1812E6B90
	public static DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x12E6D60 Offset: 0x12E5360 VA: 0x1812E6D60
	public static DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x12E75B0 Offset: 0x12E5BB0 VA: 0x1812E75B0
	public static DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x12E73E0 Offset: 0x12E59E0 VA: 0x1812E73E0
	public static string XsdKatmaiDateToString(byte[] data, int offset) { }

	// RVA: 0x12E7180 Offset: 0x12E5780 VA: 0x1812E7180
	public static string XsdKatmaiDateTimeToString(byte[] data, int offset) { }

	// RVA: 0x12E7810 Offset: 0x12E5E10 VA: 0x1812E7810
	public static string XsdKatmaiTimeToString(byte[] data, int offset) { }

	// RVA: 0x12E6C10 Offset: 0x12E5210 VA: 0x1812E6C10
	public static string XsdKatmaiDateOffsetToString(byte[] data, int offset) { }

	// RVA: 0x12E6EE0 Offset: 0x12E54E0 VA: 0x1812E6EE0
	public static string XsdKatmaiDateTimeOffsetToString(byte[] data, int offset) { }

	// RVA: 0x12E7630 Offset: 0x12E5C30 VA: 0x1812E7630
	public static string XsdKatmaiTimeOffsetToString(byte[] data, int offset) { }

	// RVA: 0x12E5400 Offset: 0x12E3A00 VA: 0x1812E5400
	private static long GetKatmaiDateTicks(byte[] data, ref int pos) { }

	// RVA: 0x12E54A0 Offset: 0x12E3AA0 VA: 0x1812E54A0
	private static long GetKatmaiTimeTicks(byte[] data, ref int pos) { }

	// RVA: 0x12E57C0 Offset: 0x12E3DC0 VA: 0x1812E57C0
	private static long GetKatmaiTimeZoneTicks(byte[] data, int pos) { }

	// RVA: 0x12E5320 Offset: 0x12E3920 VA: 0x1812E5320
	private static int GetFractions(DateTime dt) { }

	// RVA: 0x12E5240 Offset: 0x12E3840 VA: 0x1812E5240
	private static int GetFractions(DateTimeOffset dt) { }

	// RVA: 0x12E7B10 Offset: 0x12E6110 VA: 0x1812E7B10
	private static void .cctor() { }

}

internal sealed class XmlSqlBinaryReader : XmlReader, IXmlNamespaceResolver // TypeDefIndex: 1822
{	// Fields
	internal static readonly Type TypeOfObject; // 0x0
	internal static readonly Type TypeOfString; // 0x8
	private static Type[] TokenTypeMap; // 0x10
	private static byte[] XsdKatmaiTimeScaleToValueLengthMap; // 0x18
	private static ReadState[] ScanState2ReadState; // 0x20
	private Stream inStrm; // 0x10
	private byte[] data; // 0x18
	private int pos; // 0x20
	private int mark; // 0x24
	private int end; // 0x28
	private long offset; // 0x30
	private bool eof; // 0x38
	private bool sniffed; // 0x39
	private bool isEmpty; // 0x3A
	private int docState; // 0x3C
	private XmlSqlBinaryReader.SymbolTables symbolTables; // 0x40
	private XmlNameTable xnt; // 0x60
	private bool xntFromSettings; // 0x68
	private string xml; // 0x70
	private string xmlns; // 0x78
	private string nsxmlns; // 0x80
	private string baseUri; // 0x88
	private XmlSqlBinaryReader.ScanState state; // 0x90
	private XmlNodeType nodetype; // 0x94
	private BinXmlToken token; // 0x98
	private int attrIndex; // 0x9C
	private XmlSqlBinaryReader.QName qnameOther; // 0xA0
	private XmlSqlBinaryReader.QName qnameElement; // 0xB8
	private XmlNodeType parentNodeType; // 0xD0
	private XmlSqlBinaryReader.ElemInfo[] elementStack; // 0xD8
	private int elemDepth; // 0xE0
	private XmlSqlBinaryReader.AttrInfo[] attributes; // 0xE8
	private int[] attrHashTbl; // 0xF0
	private int attrCount; // 0xF8
	private int posAfterAttrs; // 0xFC
	private bool xmlspacePreserve; // 0x100
	private int tokLen; // 0x104
	private int tokDataPos; // 0x108
	private bool hasTypedValue; // 0x10C
	private Type valueType; // 0x110
	private string stringValue; // 0x118
	private Dictionary<string, XmlSqlBinaryReader.NamespaceDecl> namespaces; // 0x120
	private XmlSqlBinaryReader.NestedBinXml prevNameInfo; // 0x128
	private XmlReader textXmlReader; // 0x130
	private bool closeInput; // 0x138
	private bool checkCharacters; // 0x139
	private bool ignoreWhitespace; // 0x13A
	private bool ignorePIs; // 0x13B
	private bool ignoreComments; // 0x13C
	private DtdProcessing dtdProcessing; // 0x140
	private SecureStringHasher hasher; // 0x148
	private XmlCharType xmlCharType; // 0x150
	private Encoding unicode; // 0x158
	private byte version; // 0x160

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override Type ValueType { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override XmlNameTable NameTable { get; }
	public override ReadState ReadState { get; }

	// Methods

	// RVA: 0xBB03D0 Offset: 0xBAE9D0 VA: 0x180BB03D0
	public void .ctor(Stream stream, byte[] data, int len, string baseUri, bool closeInput, XmlReaderSettings settings) { }

	// RVA: 0xBB0B70 Offset: 0xBAF170 VA: 0x180BB0B70 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0xBB0AD0 Offset: 0xBAF0D0 VA: 0x180BB0AD0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x79BDE0 Offset: 0x79A3E0 VA: 0x18079BDE0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x79BDB0 Offset: 0x79A3B0 VA: 0x18079BDB0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x5742F0 Offset: 0x5728F0 VA: 0x1805742F0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xBB0E00 Offset: 0xBAF400 VA: 0x180BB0E00 Slot: 11
	public override string get_Value() { }

	// RVA: 0xBB09D0 Offset: 0xBAEFD0 VA: 0x180BB09D0 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x574300 Offset: 0x572900 VA: 0x180574300 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBB0AB0 Offset: 0xBAF0B0 VA: 0x180BB0AB0 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xBB11D0 Offset: 0xBAF7D0 VA: 0x180BB11D0 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBB1120 Offset: 0xBAF720 VA: 0x180BB1120 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x88D560 Offset: 0x88BB60 VA: 0x18088D560 Slot: 20
	public override Type get_ValueType() { }

	// RVA: 0xBB0970 Offset: 0xBAEF70 VA: 0x180BB0970 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xBA7ED0 Offset: 0xBA64D0 VA: 0x180BA7ED0 Slot: 23
	public override string GetAttribute(string name, string ns) { }

	// RVA: 0xBA7DA0 Offset: 0xBA63A0 VA: 0x180BA7DA0 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xBA7E10 Offset: 0xBA6410 VA: 0x180BA7E10 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xBAA2D0 Offset: 0xBA88D0 VA: 0x180BAA2D0 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xBAA360 Offset: 0xBA8960 VA: 0x180BAA360 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0xBAA540 Offset: 0xBA8B40 VA: 0x180BAA540 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xBAA5C0 Offset: 0xBA8BC0 VA: 0x180BAA5C0 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0xBAA430 Offset: 0xBA8A30 VA: 0x180BAA430 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0xBB0AA0 Offset: 0xBAF0A0 VA: 0x180BB0AA0 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0xBAB5F0 Offset: 0xBA9BF0 VA: 0x180BAB5F0 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0xBA62B0 Offset: 0xBA48B0 VA: 0x180BA62B0 Slot: 33
	public override void Close() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xBAA210 Offset: 0xBA8810 VA: 0x180BAA210 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0xBACF20 Offset: 0xBAB520 VA: 0x180BACF20 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0xBB0AE0 Offset: 0xBAF0E0 VA: 0x180BB0AE0 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xBACA60 Offset: 0xBAB060 VA: 0x180BACA60 Slot: 31
	public override bool Read() { }

	// RVA: 0xBAE090 Offset: 0xBAC690 VA: 0x180BAE090 Slot: 53
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xBAE3E0 Offset: 0xBAC9E0 VA: 0x180BAE3E0 Slot: 55
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0xBAFFF0 Offset: 0xBAE5F0 VA: 0x180BAFFF0
	private void VerifyVersion(int requiredVersion, BinXmlToken token) { }

	// RVA: 0xBA57E0 Offset: 0xBA3DE0 VA: 0x180BA57E0
	private void AddInitNamespace(string prefix, string uri) { }

	// RVA: 0xBA5920 Offset: 0xBA3F20 VA: 0x180BA5920
	private void AddName() { }

	// RVA: 0xBA5A80 Offset: 0xBA4080 VA: 0x180BA5A80
	private void AddQName() { }

	// RVA: 0xBAA660 Offset: 0xBA8C60 VA: 0x180BAA660
	private void NameFlush() { }

	// RVA: 0xBADF60 Offset: 0xBAC560 VA: 0x180BADF60
	private void SkipExtn() { }

	// RVA: 0xBAC880 Offset: 0xBAAE80 VA: 0x180BAC880
	private int ReadQNameRef() { }

	// RVA: 0xBAC7A0 Offset: 0xBAADA0 VA: 0x180BAC7A0
	private int ReadNameRef() { }

	// RVA: 0xBA6360 Offset: 0xBA4960 VA: 0x180BA6360
	private bool FillAllowEOF() { }

	// RVA: 0xBA65A0 Offset: 0xBA4BA0 VA: 0x180BA65A0
	private void Fill_(int require) { }

	// RVA: 0xBA6620 Offset: 0xBA4C20 VA: 0x180BA6620
	private void Fill(int require) { }

	// RVA: 0xBAB7C0 Offset: 0xBA9DC0 VA: 0x180BAB7C0
	private byte ReadByte() { }

	// RVA: 0xBAC9E0 Offset: 0xBAAFE0 VA: 0x180BAC9E0
	private ushort ReadUShort() { }

	// RVA: 0xBAAE00 Offset: 0xBA9400 VA: 0x180BAAE00
	private int ParseMB32() { }

	// RVA: 0xBAAC50 Offset: 0xBA9250 VA: 0x180BAAC50
	private int ParseMB32_(byte b) { }

	// RVA: 0xBAAE70 Offset: 0xBA9470 VA: 0x180BAAE70
	private int ParseMB32(int pos) { }

	// RVA: 0xBAAE00 Offset: 0xBA9400 VA: 0x180BAAE00
	private int ParseMB64() { }

	// RVA: 0xBAB0C0 Offset: 0xBA96C0 VA: 0x180BAB0C0
	private BinXmlToken PeekToken() { }

	// RVA: 0xBAC960 Offset: 0xBAAF60 VA: 0x180BAC960
	private BinXmlToken ReadToken() { }

	// RVA: 0xBAA790 Offset: 0xBA8D90 VA: 0x180BAA790
	private BinXmlToken NextToken2(BinXmlToken token) { }

	// RVA: 0xBAA6C0 Offset: 0xBA8CC0 VA: 0x180BAA6C0
	private BinXmlToken NextToken1() { }

	// RVA: 0xBAAB40 Offset: 0xBA9140 VA: 0x180BAAB40
	private BinXmlToken NextToken() { }

	// RVA: 0xBAB0A0 Offset: 0xBA96A0 VA: 0x180BAB0A0
	private BinXmlToken PeekNextToken() { }

	// RVA: 0xBACBE0 Offset: 0xBAB1E0 VA: 0x180BACBE0
	private BinXmlToken RescanNextToken() { }

	// RVA: 0xBAAFD0 Offset: 0xBA95D0 VA: 0x180BAAFD0
	private string ParseText() { }

	// RVA: 0xBADC50 Offset: 0xBAC250 VA: 0x180BADC50
	private int ScanText(out int start) { }

	// RVA: 0xBA8580 Offset: 0xBA6B80 VA: 0x180BA8580
	private string GetString(int pos, int cch) { }

	// RVA: 0xBA8550 Offset: 0xBA6B50 VA: 0x180BA8550
	private string GetStringAligned(byte[] data, int offset, int cch) { }

	// RVA: 0xBA7C00 Offset: 0xBA6200 VA: 0x180BA7C00
	private string GetAttributeText(int i) { }

	// RVA: 0xBAA050 Offset: 0xBA8650 VA: 0x180BAA050
	private int LocateAttribute(string name, string ns) { }

	// RVA: 0xBAA110 Offset: 0xBA8710 VA: 0x180BAA110
	private int LocateAttribute(string name) { }

	// RVA: 0xBAB210 Offset: 0xBA9810 VA: 0x180BAB210
	private void PositionOnAttribute(int i) { }

	// RVA: 0xBA8A40 Offset: 0xBA7040 VA: 0x180BA8A40
	private void GrowElements() { }

	// RVA: 0xBA89A0 Offset: 0xBA6FA0 VA: 0x180BA89A0
	private void GrowAttributes() { }

	// RVA: 0xBA6290 Offset: 0xBA4890 VA: 0x180BA6290
	private void ClearAttributes() { }

	// RVA: 0xBAB340 Offset: 0xBA9940 VA: 0x180BAB340
	private void PushNamespace(string prefix, string ns, bool implied) { }

	// RVA: 0xBAB130 Offset: 0xBA9730 VA: 0x180BAB130
	private void PopNamespaces(XmlSqlBinaryReader.NamespaceDecl firstInScopeChain) { }

	// RVA: 0xBA68D0 Offset: 0xBA4ED0 VA: 0x180BA68D0
	private void GenerateImpliedXmlnsAttrs() { }

	// RVA: 0xBAC190 Offset: 0xBAA790 VA: 0x180BAC190
	private bool ReadInit(bool skipXmlDecl) { }

	// RVA: 0xBACF70 Offset: 0xBAB570 VA: 0x180BACF70
	private void ScanAttributes() { }

	// RVA: 0xBADD90 Offset: 0xBAC390 VA: 0x180BADD90
	private void SimpleCheckForDuplicateAttributes() { }

	// RVA: 0xBA8AE0 Offset: 0xBA70E0 VA: 0x180BA8AE0
	private void HashCheckForDuplicateAttributes() { }

	// RVA: 0xBB0060 Offset: 0xBAE660 VA: 0x180BB0060
	private string XmlDeclValue() { }

	// RVA: 0xBA5D50 Offset: 0xBA4350 VA: 0x180BA5D50
	private string CDATAValue() { }

	// RVA: 0xBA66C0 Offset: 0xBA4CC0 VA: 0x180BA66C0
	private void FinishCDATA() { }

	// RVA: 0xBA67B0 Offset: 0xBA4DB0 VA: 0x180BA67B0
	private void FinishEndElement() { }

	// RVA: 0xBAB810 Offset: 0xBA9E10 VA: 0x180BAB810
	private bool ReadDoc() { }

	// RVA: 0xBA8F00 Offset: 0xBA7500 VA: 0x180BA8F00
	private void ImplReadData(BinXmlToken tokenType) { }

	// RVA: 0xBA9440 Offset: 0xBA7A40 VA: 0x180BA9440
	private void ImplReadElement() { }

	// RVA: 0xBA97F0 Offset: 0xBA7DF0 VA: 0x180BA97F0
	private void ImplReadEndElement() { }

	// RVA: 0xBA9090 Offset: 0xBA7690 VA: 0x180BA9090
	private void ImplReadDoctype() { }

	// RVA: 0xBA9AD0 Offset: 0xBA80D0 VA: 0x180BA9AD0
	private void ImplReadPI() { }

	// RVA: 0xBA8EC0 Offset: 0xBA74C0 VA: 0x180BA8EC0
	private void ImplReadComment() { }

	// RVA: 0xBA8E30 Offset: 0xBA7430 VA: 0x180BA8E30
	private void ImplReadCDATA() { }

	// RVA: 0xBA9970 Offset: 0xBA7F70 VA: 0x180BA9970
	private void ImplReadNest() { }

	// RVA: 0xBA9900 Offset: 0xBA7F00 VA: 0x180BA9900
	private void ImplReadEndNest() { }

	// RVA: 0xBA9B60 Offset: 0xBA8160 VA: 0x180BA9B60
	private void ImplReadXmlText() { }

	// RVA: 0xBAE830 Offset: 0xBACE30 VA: 0x180BAE830
	private void UpdateFromTextReader() { }

	// RVA: 0xBAE810 Offset: 0xBACE10 VA: 0x180BAE810
	private bool UpdateFromTextReader(bool needUpdate) { }

	// RVA: 0xBA5EB0 Offset: 0xBA44B0 VA: 0x180BA5EB0
	private void CheckAllowContent() { }

	// RVA: 0xBA6AE0 Offset: 0xBA50E0 VA: 0x180BA6AE0
	private void GenerateTokenTypeMap() { }

	// RVA: 0xBA8700 Offset: 0xBA6D00 VA: 0x180BA8700
	private Type GetValueType(BinXmlToken token) { }

	// RVA: 0xBAB5D0 Offset: 0xBA9BD0 VA: 0x180BAB5D0
	private void ReScanOverValue(BinXmlToken token) { }

	// RVA: 0xBADA30 Offset: 0xBAC030 VA: 0x180BADA30
	private XmlNodeType ScanOverValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0xBAD500 Offset: 0xBABB00 VA: 0x180BAD500
	private XmlNodeType ScanOverAnyValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0xBA5FD0 Offset: 0xBA45D0 VA: 0x180BA5FD0
	private XmlNodeType CheckText(bool attr) { }

	// RVA: 0xBA5F20 Offset: 0xBA4520 VA: 0x180BA5F20
	private XmlNodeType CheckTextIsWS() { }

	// RVA: 0xBA6230 Offset: 0xBA4830 VA: 0x180BA6230
	private void CheckValueTokenBounds() { }

	// RVA: 0xBA87F0 Offset: 0xBA6DF0 VA: 0x180BA87F0
	private int GetXsdKatmaiTokenLength(BinXmlToken token) { }

	// RVA: 0xBB01C0 Offset: 0xBAE7C0 VA: 0x180BB01C0
	private int XsdKatmaiTimeScaleToValueLength(byte scale) { }

	// RVA: 0xBAF240 Offset: 0xBAD840 VA: 0x180BAF240
	private long ValueAsLong() { }

	// RVA: 0xBAFF40 Offset: 0xBAE540 VA: 0x180BAFF40
	private ulong ValueAsULong() { }

	// RVA: 0xBAED90 Offset: 0xBAD390 VA: 0x180BAED90
	private Decimal ValueAsDecimal() { }

	// RVA: 0xBAF040 Offset: 0xBAD640 VA: 0x180BAF040
	private double ValueAsDouble() { }

	// RVA: 0xBAE930 Offset: 0xBACF30 VA: 0x180BAE930
	private string ValueAsDateTimeString() { }

	// RVA: 0xBAF770 Offset: 0xBADD70 VA: 0x180BAF770
	private string ValueAsString(BinXmlToken token) { }

	// RVA: 0xBA81F0 Offset: 0xBA67F0 VA: 0x180BA81F0
	private short GetInt16(int pos) { }

	// RVA: 0xBA81F0 Offset: 0xBA67F0 VA: 0x180BA81F0
	private ushort GetUInt16(int pos) { }

	// RVA: 0xBA8250 Offset: 0xBA6850 VA: 0x180BA8250
	private int GetInt32(int pos) { }

	// RVA: 0xBA8250 Offset: 0xBA6850 VA: 0x180BA8250
	private uint GetUInt32(int pos) { }

	// RVA: 0xBA8300 Offset: 0xBA6900 VA: 0x180BA8300
	private long GetInt64(int pos) { }

	// RVA: 0xBA8300 Offset: 0xBA6900 VA: 0x180BA8300
	private ulong GetUInt64(int pos) { }

	// RVA: 0xBA84A0 Offset: 0xBA6AA0 VA: 0x180BA84A0
	private float GetSingle(int offset) { }

	// RVA: 0xBA8050 Offset: 0xBA6650 VA: 0x180BA8050
	private double GetDouble(int offset) { }

	// RVA: 0xBAE5C0 Offset: 0xBACBC0 VA: 0x180BAE5C0
	private Exception ThrowUnexpectedToken(BinXmlToken token) { }

	// RVA: 0xBAE7A0 Offset: 0xBACDA0 VA: 0x180BAE7A0
	private Exception ThrowXmlException(string res) { }

	// RVA: 0xBAE650 Offset: 0xBACC50 VA: 0x180BAE650
	private Exception ThrowXmlException(string res, string arg1, string arg2) { }

	// RVA: 0xBAE550 Offset: 0xBACB50 VA: 0x180BAE550
	private Exception ThrowNotSupported(string res) { }

	// RVA: 0xBB0280 Offset: 0xBAE880 VA: 0x180BB0280
	private static void .cctor() { }

}

private enum XmlSqlBinaryReader.ScanState // TypeDefIndex: 1823
{	// Fields
	public int value__; // 0x0
	public const XmlSqlBinaryReader.ScanState Doc = 0;
	public const XmlSqlBinaryReader.ScanState XmlText = 1;
	public const XmlSqlBinaryReader.ScanState Attr = 2;
	public const XmlSqlBinaryReader.ScanState AttrVal = 3;
	public const XmlSqlBinaryReader.ScanState AttrValPseudoValue = 4;
	public const XmlSqlBinaryReader.ScanState Init = 5;
	public const XmlSqlBinaryReader.ScanState Error = 6;
	public const XmlSqlBinaryReader.ScanState EOF = 7;
	public const XmlSqlBinaryReader.ScanState Closed = 8;

}

internal struct XmlSqlBinaryReader.QName // TypeDefIndex: 1824
{	// Fields
	public string prefix; // 0x0
	public string localname; // 0x8
	public string namespaceUri; // 0x10

	// Methods

	// RVA: 0xF5FD0 Offset: 0xF53D0 VA: 0x1800F5FD0
	public void .ctor(string prefix, string lname, string nsUri) { }

	// RVA: 0xF5FD0 Offset: 0xF53D0 VA: 0x1800F5FD0
	public void Set(string prefix, string lname, string nsUri) { }

	// RVA: 0xFD990 Offset: 0xFCD90 VA: 0x1800FD990
	public void Clear() { }

	// RVA: 0xFD5E0 Offset: 0xFC9E0 VA: 0x1800FD5E0
	public bool MatchNs(string lname, string nsUri) { }

	// RVA: 0xFDB00 Offset: 0xFCF00 VA: 0x1800FDB00
	public bool MatchPrefix(string prefix, string lname) { }

	// RVA: 0xFD980 Offset: 0xFCD80 VA: 0x1800FD980
	public void CheckPrefixNS(string prefix, string namespaceUri) { }

	// RVA: 0xF5D50 Offset: 0xF5150 VA: 0x1800F5D50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFDAA0 Offset: 0xFCEA0 VA: 0x1800FDAA0
	public int GetNSHashCode(SecureStringHasher hasher) { }

	// RVA: 0xFD9A0 Offset: 0xFCDA0 VA: 0x1800FD9A0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xFDB50 Offset: 0xFCF50 VA: 0x1800FDB50 Slot: 3
	public override string ToString() { }

	// RVA: 0xB9B860 Offset: 0xB99E60 VA: 0x180B9B860
	public static bool op_Equality(XmlSqlBinaryReader.QName a, XmlSqlBinaryReader.QName b) { }

}

private struct XmlSqlBinaryReader.ElemInfo // TypeDefIndex: 1825
{	// Fields
	public XmlSqlBinaryReader.QName name; // 0x0
	public string xmlLang; // 0x18
	public XmlSpace xmlSpace; // 0x20
	public bool xmlspacePreserve; // 0x24
	public XmlSqlBinaryReader.NamespaceDecl nsdecls; // 0x28

	// Methods

	// RVA: 0xFD900 Offset: 0xFCD00 VA: 0x1800FD900
	public void Set(XmlSqlBinaryReader.QName name, bool xmlspacePreserve) { }

	// RVA: 0xFD8D0 Offset: 0xFCCD0 VA: 0x1800FD8D0
	public XmlSqlBinaryReader.NamespaceDecl Clear() { }

}

private struct XmlSqlBinaryReader.AttrInfo // TypeDefIndex: 1826
{	// Fields
	public XmlSqlBinaryReader.QName name; // 0x0
	public string val; // 0x18
	public int contentPos; // 0x20
	public int hashCode; // 0x24
	public int prevHash; // 0x28

	// Methods

	// RVA: 0xFD630 Offset: 0xFCA30 VA: 0x1800FD630
	public void Set(XmlSqlBinaryReader.QName n, string v) { }

	// RVA: 0xFD680 Offset: 0xFCA80 VA: 0x1800FD680
	public void Set(XmlSqlBinaryReader.QName n, int pos) { }

	// RVA: 0xFD540 Offset: 0xFC940 VA: 0x1800FD540
	public void GetLocalnameAndNamespaceUri(out string localname, out string namespaceUri) { }

	// RVA: 0xFD4C0 Offset: 0xFC8C0 VA: 0x1800FD4C0
	public int GetLocalnameAndNamespaceUriAndHash(SecureStringHasher hasher, out string localname, out string namespaceUri) { }

	// RVA: 0xFD5E0 Offset: 0xFC9E0 VA: 0x1800FD5E0
	public bool MatchNS(string localname, string namespaceUri) { }

	// RVA: 0xFD580 Offset: 0xFC980 VA: 0x1800FD580
	public bool MatchHashNS(int hash, string localname, string namespaceUri) { }

	// RVA: 0xFD4B0 Offset: 0xFC8B0 VA: 0x1800FD4B0
	public void AdjustPosition(int adj) { }

}

private class XmlSqlBinaryReader.NamespaceDecl // TypeDefIndex: 1827
{	// Fields
	public string prefix; // 0x10
	public string uri; // 0x18
	public XmlSqlBinaryReader.NamespaceDecl scopeLink; // 0x20
	public XmlSqlBinaryReader.NamespaceDecl prevLink; // 0x28
	public int scope; // 0x30
	public bool implied; // 0x34

	// Methods

	// RVA: 0xB9B460 Offset: 0xB99A60 VA: 0x180B9B460
	public void .ctor(string prefix, string nsuri, XmlSqlBinaryReader.NamespaceDecl nextInScope, XmlSqlBinaryReader.NamespaceDecl prevDecl, int scope, bool implied) { }

}

private struct XmlSqlBinaryReader.SymbolTables // TypeDefIndex: 1828
{	// Fields
	public string[] symtable; // 0x0
	public int symCount; // 0x8
	public XmlSqlBinaryReader.QName[] qnametable; // 0x10
	public int qnameCount; // 0x18

	// Methods

	// RVA: 0xFDBB0 Offset: 0xFCFB0 VA: 0x1800FDBB0
	public void Init() { }

}

private class XmlSqlBinaryReader.NestedBinXml // TypeDefIndex: 1829
{	// Fields
	public XmlSqlBinaryReader.SymbolTables symbolTables; // 0x10
	public int docState; // 0x30
	public XmlSqlBinaryReader.NestedBinXml next; // 0x38

	// Methods

	// RVA: 0xB9B4F0 Offset: 0xB99AF0 VA: 0x180B9B4F0
	public void .ctor(XmlSqlBinaryReader.SymbolTables symbolTables, int docState, XmlSqlBinaryReader.NestedBinXml next) { }

}

internal class XmlAsyncCheckReader : XmlReader // TypeDefIndex: 1873
{	// Fields
	private readonly XmlReader coreReader; // 0x10
	private Task lastTask; // 0x18

	// Properties
	internal XmlReader CoreReader { get; }
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override Type ValueType { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	public override bool CanReadValueChunk { get; }
	public override bool HasAttributes { get; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal XmlReader get_CoreReader() { }

	// RVA: 0xE53EE0 Offset: 0xE524E0 VA: 0x180E53EE0
	public static XmlAsyncCheckReader CreateAsyncCheckWrapper(XmlReader reader) { }

	// RVA: 0xE54750 Offset: 0xE52D50 VA: 0x180E54750
	public void .ctor(XmlReader reader) { }

	// RVA: 0xE53E10 Offset: 0xE52410 VA: 0x180E53E10
	private void CheckAsync() { }

	// RVA: 0xE54D00 Offset: 0xE53300 VA: 0x180E54D00 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0xE54BC0 Offset: 0xE531C0 VA: 0x180E54BC0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xE54B00 Offset: 0xE53100 VA: 0x180E54B00 Slot: 7
	public override string get_Name() { }

	// RVA: 0xE54A80 Offset: 0xE53080 VA: 0x180E54A80 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0xE54B80 Offset: 0xE53180 VA: 0x180E54B80 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0xE54C00 Offset: 0xE53200 VA: 0x180E54C00 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xE54DD0 Offset: 0xE533D0 VA: 0x180E54DD0 Slot: 11
	public override string get_Value() { }

	// RVA: 0xE54900 Offset: 0xE52F00 VA: 0x180E54900 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xE54840 Offset: 0xE52E40 VA: 0x180E54840 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xE54A40 Offset: 0xE53040 VA: 0x180E54A40 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xE54A00 Offset: 0xE53000 VA: 0x180E54A00 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xE54C40 Offset: 0xE53240 VA: 0x180E54C40 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xE54E50 Offset: 0xE53450 VA: 0x180E54E50 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xE54E10 Offset: 0xE53410 VA: 0x180E54E10 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0xE54CC0 Offset: 0xE532C0 VA: 0x180E54CC0 Slot: 19
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xE54D90 Offset: 0xE53390 VA: 0x180E54D90 Slot: 20
	public override Type get_ValueType() { }

	// RVA: 0xE54800 Offset: 0xE52E00 VA: 0x180E54800 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xE54150 Offset: 0xE52750 VA: 0x180E54150 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xE541A0 Offset: 0xE527A0 VA: 0x180E541A0 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0xE54200 Offset: 0xE52800 VA: 0x180E54200 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xE54350 Offset: 0xE52950 VA: 0x180E54350 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xE54300 Offset: 0xE52900 VA: 0x180E54300 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0xE54420 Offset: 0xE52A20 VA: 0x180E54420 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xE54460 Offset: 0xE52A60 VA: 0x180E54460 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0xE543E0 Offset: 0xE529E0 VA: 0x180E543E0 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0xE544A0 Offset: 0xE52AA0 VA: 0x180E544A0 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0xE54690 Offset: 0xE52C90 VA: 0x180E54690 Slot: 31
	public override bool Read() { }

	// RVA: 0xE54980 Offset: 0xE52F80 VA: 0x180E54980 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0xE53EA0 Offset: 0xE524A0 VA: 0x180E53EA0 Slot: 33
	public override void Close() { }

	// RVA: 0xE54C80 Offset: 0xE53280 VA: 0x180E54C80 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xE54710 Offset: 0xE52D10 VA: 0x180E54710 Slot: 35
	public override void Skip() { }

	// RVA: 0xE54AC0 Offset: 0xE530C0 VA: 0x180E54AC0 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xE542B0 Offset: 0xE528B0 VA: 0x180E542B0 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0xE548C0 Offset: 0xE52EC0 VA: 0x180E548C0 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0xE546D0 Offset: 0xE52CD0 VA: 0x180E546D0 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0xE54880 Offset: 0xE52E80 VA: 0x180E54880 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0xE54620 Offset: 0xE52C20 VA: 0x180E54620 Slot: 41
	public override int ReadValueChunk(char[] buffer, int index, int count) { }

	// RVA: 0xE545E0 Offset: 0xE52BE0 VA: 0x180E545E0 Slot: 42
	public override string ReadString() { }

	// RVA: 0xE543A0 Offset: 0xE529A0 VA: 0x180E543A0 Slot: 43
	public override XmlNodeType MoveToContent() { }

	// RVA: 0xE545A0 Offset: 0xE52BA0 VA: 0x180E545A0 Slot: 44
	public override void ReadStartElement() { }

	// RVA: 0xE544E0 Offset: 0xE52AE0 VA: 0x180E544E0 Slot: 45
	public override string ReadElementString() { }

	// RVA: 0xE54520 Offset: 0xE52B20 VA: 0x180E54520 Slot: 46
	public override void ReadEndElement() { }

	// RVA: 0xE54250 Offset: 0xE52850 VA: 0x180E54250 Slot: 47
	public override bool IsStartElement(string localname, string ns) { }

	// RVA: 0xE54560 Offset: 0xE52B60 VA: 0x180E54560 Slot: 48
	public override string ReadInnerXml() { }

	// RVA: 0xE549C0 Offset: 0xE52FC0 VA: 0x180E549C0 Slot: 49
	public override bool get_HasAttributes() { }

	// RVA: 0xE54120 Offset: 0xE52720 VA: 0x180E54120 Slot: 50
	protected override void Dispose(bool disposing) { }

	// RVA: 0xE54B40 Offset: 0xE53140 VA: 0x180E54B40 Slot: 51
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0xE54940 Offset: 0xE52F40 VA: 0x180E54940 Slot: 52
	internal override IDtdInfo get_DtdInfo() { }

}

internal class XmlAsyncCheckReaderWithNS : XmlAsyncCheckReader, IXmlNamespaceResolver // TypeDefIndex: 1874
{	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x20

	// Methods

	// RVA: 0xE53D80 Offset: 0xE52380 VA: 0x180E53D80
	public void .ctor(XmlReader reader) { }

	// RVA: 0xE53C60 Offset: 0xE52260 VA: 0x180E53C60 Slot: 53
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xE53CC0 Offset: 0xE522C0 VA: 0x180E53CC0 Slot: 54
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0xE53D20 Offset: 0xE52320 VA: 0x180E53D20 Slot: 55
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

internal class XmlAsyncCheckReaderWithLineInfo : XmlAsyncCheckReader, IXmlLineInfo // TypeDefIndex: 1875
{	// Fields
	private readonly IXmlLineInfo readerAsIXmlLineInfo; // 0x20

	// Properties
	public virtual int LineNumber { get; }
	public virtual int LinePosition { get; }

	// Methods

	// RVA: 0xE53B30 Offset: 0xE52130 VA: 0x180E53B30
	public void .ctor(XmlReader reader) { }

	// RVA: 0xE53AE0 Offset: 0xE520E0 VA: 0x180E53AE0 Slot: 56
	public virtual bool HasLineInfo() { }

	// RVA: 0xE53BC0 Offset: 0xE521C0 VA: 0x180E53BC0 Slot: 57
	public virtual int get_LineNumber() { }

	// RVA: 0xE53C10 Offset: 0xE52210 VA: 0x180E53C10 Slot: 58
	public virtual int get_LinePosition() { }

}

internal class XmlAsyncCheckReaderWithLineInfoNS : XmlAsyncCheckReaderWithLineInfo, IXmlNamespaceResolver // TypeDefIndex: 1876
{	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x28

	// Methods

	// RVA: 0xE539F0 Offset: 0xE51FF0 VA: 0x180E539F0
	public void .ctor(XmlReader reader) { }

	// RVA: 0xE538D0 Offset: 0xE51ED0 VA: 0x180E538D0 Slot: 59
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xE53930 Offset: 0xE51F30 VA: 0x180E53930 Slot: 60
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0xE53990 Offset: 0xE51F90 VA: 0x180E53990 Slot: 61
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

internal class XmlAsyncCheckReaderWithLineInfoNSSchema : XmlAsyncCheckReaderWithLineInfoNS, IXmlSchemaInfo // TypeDefIndex: 1877
{	// Fields
	private readonly IXmlSchemaInfo readerAsIXmlSchemaInfo; // 0x30

	// Properties
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.Validity { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsDefault { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsNil { get; }
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.MemberType { get; }
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.SchemaType { get; }
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.SchemaElement { get; }
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.SchemaAttribute { get; }

	// Methods

	// RVA: 0xE53840 Offset: 0xE51E40 VA: 0x180E53840
	public void .ctor(XmlReader reader) { }

	// RVA: 0xE537F0 Offset: 0xE51DF0 VA: 0x180E537F0 Slot: 62
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0xE53530 Offset: 0xE51B30 VA: 0x180E53530 Slot: 63
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0xE53580 Offset: 0xE51B80 VA: 0x180E53580 Slot: 64
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0xE535D0 Offset: 0xE51BD0 VA: 0x180E535D0 Slot: 65
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0xE537A0 Offset: 0xE51DA0 VA: 0x180E537A0 Slot: 66
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0xE536E0 Offset: 0xE51CE0 VA: 0x180E536E0 Slot: 67
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0xE53620 Offset: 0xE51C20 VA: 0x180E53620 Slot: 68
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

}

internal class XmlAsyncCheckWriter : XmlWriter // TypeDefIndex: 1878
{	// Fields
	private readonly XmlWriter coreWriter; // 0x18
	private Task lastTask; // 0x20

	// Properties
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0xE558C0 Offset: 0xE53EC0 VA: 0x180E558C0
	public void .ctor(XmlWriter writer) { }

	// RVA: 0xE54E90 Offset: 0xE53490 VA: 0x180E54E90
	private void CheckAsync() { }

	// RVA: 0xE55670 Offset: 0xE53C70 VA: 0x180E55670 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0xE556B0 Offset: 0xE53CB0 VA: 0x180E556B0 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0xE55370 Offset: 0xE53970 VA: 0x180E55370 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0xE552C0 Offset: 0xE538C0 VA: 0x180E552C0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xE55700 Offset: 0xE53D00 VA: 0x180E55700 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0xE553B0 Offset: 0xE539B0 VA: 0x180E553B0 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0xE55440 Offset: 0xE53A40 VA: 0x180E55440 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0xE55600 Offset: 0xE53C00 VA: 0x180E55600 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0xE55330 Offset: 0xE53930 VA: 0x180E55330 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0xE55160 Offset: 0xE53760 VA: 0x180E55160 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0xE55270 Offset: 0xE53870 VA: 0x180E55270 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0xE554E0 Offset: 0xE53AE0 VA: 0x180E554E0 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0xE553F0 Offset: 0xE539F0 VA: 0x180E553F0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0xE551B0 Offset: 0xE537B0 VA: 0x180E551B0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0xE55870 Offset: 0xE53E70 VA: 0x180E55870 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0xE55770 Offset: 0xE53D70 VA: 0x180E55770 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0xE557C0 Offset: 0xE53DC0 VA: 0x180E557C0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0xE55200 Offset: 0xE53800 VA: 0x180E55200 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0xE55540 Offset: 0xE53B40 VA: 0x180E55540 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0xE555B0 Offset: 0xE53BB0 VA: 0x180E555B0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0xE55080 Offset: 0xE53680 VA: 0x180E55080 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0xE550F0 Offset: 0xE536F0 VA: 0x180E550F0 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0xE55950 Offset: 0xE53F50 VA: 0x180E55950 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0xE54F20 Offset: 0xE53520 VA: 0x180E54F20 Slot: 28
	public override void Close() { }

	// RVA: 0xE54F90 Offset: 0xE53590 VA: 0x180E54F90 Slot: 29
	public override void Flush() { }

	// RVA: 0xE54FD0 Offset: 0xE535D0 VA: 0x180E54FD0 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0xE55820 Offset: 0xE53E20 VA: 0x180E55820 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0xE55020 Offset: 0xE53620 VA: 0x180E55020 Slot: 32
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0xE55480 Offset: 0xE53A80 VA: 0x180E55480 Slot: 33
	public override void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0xE54F60 Offset: 0xE53560 VA: 0x180E54F60 Slot: 34
	protected override void Dispose(bool disposing) { }

}

internal class XmlAutoDetectWriter : XmlRawWriter // TypeDefIndex: 1879
{	// Fields
	private XmlRawWriter wrapped; // 0x28
	private OnRemoveWriter onRemove; // 0x30
	private XmlWriterSettings writerSettings; // 0x38
	private XmlEventCache eventCache; // 0x40
	private TextWriter textWriter; // 0x48
	private Stream strm; // 0x50

	// Properties
	internal override IXmlNamespaceResolver NamespaceResolver { set; }
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0xE58FD0 Offset: 0xE575D0 VA: 0x180E58FD0
	private void .ctor(XmlWriterSettings writerSettings) { }

	// RVA: 0xE58F50 Offset: 0xE57550 VA: 0x180E58F50
	public void .ctor(TextWriter textWriter, XmlWriterSettings writerSettings) { }

	// RVA: 0xE58F90 Offset: 0xE57590 VA: 0x180E58F90
	public void .ctor(Stream strm, XmlWriterSettings writerSettings) { }

	// RVA: 0xE587F0 Offset: 0xE56DF0 VA: 0x180E587F0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xE58B60 Offset: 0xE57160 VA: 0x180E58B60 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0xE58AE0 Offset: 0xE570E0 VA: 0x180E58AE0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0xE58870 Offset: 0xE56E70 VA: 0x180E58870 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0xE586F0 Offset: 0xE56CF0 VA: 0x180E586F0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0xE587A0 Offset: 0xE56DA0 VA: 0x180E587A0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0xE58A00 Offset: 0xE57000 VA: 0x180E58A00 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0xE58E40 Offset: 0xE57440 VA: 0x180E58E40 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0xE58D20 Offset: 0xE57320 VA: 0x180E58D20 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0xBA12F0 Offset: 0xB9F8F0 VA: 0x180BA12F0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0xE58AA0 Offset: 0xE570A0 VA: 0x180E58AA0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0xE58A50 Offset: 0xE57050 VA: 0x180E58A50 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0xE58900 Offset: 0xE56F00 VA: 0x180E58900 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0xE58740 Offset: 0xE56D40 VA: 0x180E58740 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0xE58D70 Offset: 0xE57370 VA: 0x180E58D70 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0xE585F0 Offset: 0xE56BF0 VA: 0x180E585F0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0xE58670 Offset: 0xE56C70 VA: 0x180E58670 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0xE58150 Offset: 0xE56750 VA: 0x180E58150 Slot: 28
	public override void Close() { }

	// RVA: 0xE583E0 Offset: 0xE569E0 VA: 0x180E583E0 Slot: 29
	public override void Flush() { }

	// RVA: 0xE58DE0 Offset: 0xE573E0 VA: 0x180E58DE0 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0xE590C0 Offset: 0xE576C0 VA: 0x180E590C0 Slot: 35
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0xE58EF0 Offset: 0xE574F0 VA: 0x180E58EF0 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0xE58E90 Offset: 0xE57490 VA: 0x180E58E90 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0xE58510 Offset: 0xE56B10 VA: 0x180E58510 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0xE588A0 Offset: 0xE56EA0 VA: 0x180E588A0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0xE58960 Offset: 0xE56F60 VA: 0x180E58960 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0xE58990 Offset: 0xE56F90 VA: 0x180E58990 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0xE59090 Offset: 0xE57690 VA: 0x180E59090 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0xE58CC0 Offset: 0xE572C0 VA: 0x180E58CC0 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0xE588D0 Offset: 0xE56ED0 VA: 0x180E588D0 Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0xE58430 Offset: 0xE56A30 VA: 0x180E58430
	private static bool IsHtmlTag(string tagName) { }

	// RVA: 0xE583D0 Offset: 0xE569D0 VA: 0x180E583D0
	private void EnsureWrappedWriter(XmlOutputMethod outMethod) { }

	// RVA: 0xE58540 Offset: 0xE56B40 VA: 0x180E58540
	private bool TextBlockCreatesWriter(string textBlock) { }

	// RVA: 0xE581A0 Offset: 0xE567A0 VA: 0x180E581A0
	private void CreateWrappedWriter(XmlOutputMethod outMethod) { }

}

internal class XmlEncodedRawTextWriter : XmlRawWriter // TypeDefIndex: 1880
{	// Fields
	private readonly bool useAsync; // 0x28
	protected byte[] bufBytes; // 0x30
	protected Stream stream; // 0x38
	protected Encoding encoding; // 0x40
	protected XmlCharType xmlCharType; // 0x48
	protected int bufPos; // 0x50
	protected int textPos; // 0x54
	protected int contentPos; // 0x58
	protected int cdataPos; // 0x5C
	protected int attrEndPos; // 0x60
	protected int bufLen; // 0x64
	protected bool writeToNull; // 0x68
	protected bool hadDoubleBracket; // 0x69
	protected bool inAttributeValue; // 0x6A
	protected int bufBytesUsed; // 0x6C
	protected char[] bufChars; // 0x70
	protected Encoder encoder; // 0x78
	protected TextWriter writer; // 0x80
	protected bool trackTextContent; // 0x88
	protected bool inTextContent; // 0x89
	private int lastMarkPos; // 0x8C
	private int[] textContentMarks; // 0x90
	private CharEntityEncoderFallback charEntityFallback; // 0x98
	protected NewLineHandling newLineHandling; // 0xA0
	protected bool closeOutput; // 0xA4
	protected bool omitXmlDeclaration; // 0xA5
	protected string newLineChars; // 0xA8
	protected bool checkCharacters; // 0xB0
	protected XmlStandalone standalone; // 0xB4
	protected XmlOutputMethod outputMethod; // 0xB8
	protected bool autoXmlDeclaration; // 0xBC
	protected bool mergeCDataSections; // 0xBD

	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x11C3630 Offset: 0x11C1C30 VA: 0x1811C3630
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x11C3220 Offset: 0x11C1820 VA: 0x1811C3220
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x11C3320 Offset: 0x11C1920 VA: 0x1811C3320
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x11C2FB0 Offset: 0x11C15B0 VA: 0x1811C2FB0 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x11C31B0 Offset: 0x11C17B0 VA: 0x1811C31B0 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x11C1600 Offset: 0x11BFC00 VA: 0x1811C1600 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x11C2A40 Offset: 0x11C1040 VA: 0x1811C2A40 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11BFFA0 Offset: 0x11BE5A0 VA: 0x1811BFFA0 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x11C1D10 Offset: 0x11C0310 VA: 0x1811C1D10 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11C20B0 Offset: 0x11C06B0 VA: 0x1811C20B0 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11C28B0 Offset: 0x11C0EB0 VA: 0x1811C28B0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x11C1CA0 Offset: 0x11C02A0 VA: 0x1811C1CA0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x11C2240 Offset: 0x11C0840 VA: 0x1811C2240 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x11C2B60 Offset: 0x11C1160 VA: 0x1811C2B60 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x11C1F40 Offset: 0x11C0540 VA: 0x1811C1F40 Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x11C0A50 Offset: 0x11BF050 VA: 0x1811C0A50 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x11C1420 Offset: 0x11BFA20 VA: 0x1811C1420 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x11C2330 Offset: 0x11C0930 VA: 0x1811C2330 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x11C1FB0 Offset: 0x11C05B0 VA: 0x1811C1FB0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x11C0D70 Offset: 0x11BF370 VA: 0x1811C0D70 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x11C2F30 Offset: 0x11C1530 VA: 0x1811C2F30 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x11C2CF0 Offset: 0x11C12F0 VA: 0x1811C2CF0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x11C2D70 Offset: 0x11C1370 VA: 0x1811C2D70 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x11C0FA0 Offset: 0x11BF5A0 VA: 0x1811C0FA0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x11C2820 Offset: 0x11C0E20 VA: 0x1811C2820 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x11C27B0 Offset: 0x11C0DB0 VA: 0x1811C27B0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x11BEF90 Offset: 0x11BD590 VA: 0x1811BEF90 Slot: 28
	public override void Close() { }

	// RVA: 0x11BFA90 Offset: 0x11BE090 VA: 0x1811BFA90 Slot: 29
	public override void Flush() { }

	// RVA: 0x11BF610 Offset: 0x11BDC10 VA: 0x1811BF610 Slot: 48
	protected virtual void FlushBuffer() { }

	// RVA: 0x11BF330 Offset: 0x11BD930 VA: 0x1811BF330
	private void EncodeChars(int startOffset, int endOffset, bool writeAllToStream) { }

	// RVA: 0x11BF9C0 Offset: 0x11BDFC0 VA: 0x1811BF9C0
	private void FlushEncoder() { }

	// RVA: 0x11C0370 Offset: 0x11BE970 VA: 0x1811C0370
	protected void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x11C1960 Offset: 0x11BFF60 VA: 0x1811C1960
	protected void WriteElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x11BFDA0 Offset: 0x11BE3A0 VA: 0x1811BFDA0
	protected void RawText(string s) { }

	// RVA: 0x11BFDF0 Offset: 0x11BE3F0 VA: 0x1811BFDF0
	protected void RawText(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x11C24E0 Offset: 0x11C0AE0 VA: 0x1811C24E0
	protected void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x11C1040 Offset: 0x11BF640 VA: 0x1811C1040
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x11C0680 Offset: 0x11BEC80 VA: 0x1811C0680
	protected void WriteCDataSection(string text) { }

	// RVA: 0x11BF4B0 Offset: 0x11BDAB0 VA: 0x1811BF4B0
	private static char* EncodeSurrogate(char* pSrc, char* pSrcEnd, char* pDst) { }

	// RVA: 0x11BFBB0 Offset: 0x11BE1B0 VA: 0x1811BFBB0
	private char* InvalidXmlChar(int ch, char* pDst, bool entitize) { }

	// RVA: 0x11BF230 Offset: 0x11BD830 VA: 0x1811BF230
	internal void EncodeChar(ref char* pSrc, char* pSrcEnd, ref char* pDst) { }

	// RVA: 0x11BEDF0 Offset: 0x11BD3F0 VA: 0x1811BEDF0
	protected void ChangeTextContentMark(bool value) { }

	// RVA: 0x11BFB00 Offset: 0x11BE100 VA: 0x1811BFB00
	private void GrowTextContentMarks() { }

	// RVA: 0x11C22A0 Offset: 0x11C08A0 VA: 0x1811C22A0
	protected char* WriteNewLine(char* pDst) { }

	// RVA: 0x11BFD10 Offset: 0x11BE310 VA: 0x1811BFD10
	protected static char* LtEntity(char* pDst) { }

	// RVA: 0x11BFB90 Offset: 0x11BE190 VA: 0x1811BFB90
	protected static char* GtEntity(char* pDst) { }

	// RVA: 0x11BEDB0 Offset: 0x11BD3B0 VA: 0x1811BEDB0
	protected static char* AmpEntity(char* pDst) { }

	// RVA: 0x11BFD30 Offset: 0x11BE330 VA: 0x1811BFD30
	protected static char* QuoteEntity(char* pDst) { }

	// RVA: 0x11BFFF0 Offset: 0x11BE5F0 VA: 0x1811BFFF0
	protected static char* TabEntity(char* pDst) { }

	// RVA: 0x11BFCF0 Offset: 0x11BE2F0 VA: 0x1811BFCF0
	protected static char* LineFeedEntity(char* pDst) { }

	// RVA: 0x11BEDD0 Offset: 0x11BD3D0 VA: 0x1811BEDD0
	protected static char* CarriageReturnEntity(char* pDst) { }

	// RVA: 0x11BEEE0 Offset: 0x11BD4E0 VA: 0x1811BEEE0
	private static char* CharEntity(char* pDst, char ch) { }

	// RVA: 0x11BFD70 Offset: 0x11BE370 VA: 0x1811BFD70
	protected static char* RawStartCData(char* pDst) { }

	// RVA: 0x11BFD50 Offset: 0x11BE350 VA: 0x1811BFD50
	protected static char* RawEndCData(char* pDst) { }

	// RVA: 0x11C0010 Offset: 0x11BE610 VA: 0x1811C0010
	protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }

}

internal class XmlEncodedRawTextWriterIndent : XmlEncodedRawTextWriter // TypeDefIndex: 1881
{	// Fields
	protected int indentLevel; // 0xC0
	protected bool newLineOnAttributes; // 0xC4
	protected string indentChars; // 0xC8
	protected bool mixedContent; // 0xD0
	private BitStack mixedContentStack; // 0xD8
	protected ConformanceLevel conformanceLevel; // 0xE0

	// Methods

	// RVA: 0x11BECB0 Offset: 0x11BD2B0 VA: 0x1811BECB0
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x11BEC80 Offset: 0x11BD280 VA: 0x1811BEC80
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x11BE520 Offset: 0x11BCB20 VA: 0x1811BE520 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x11BEA10 Offset: 0x11BD010 VA: 0x1811BEA10 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11BE380 Offset: 0x11BC980 VA: 0x1811BE380 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x88D9E0 Offset: 0x88BFE0 VA: 0x18088D9E0 Slot: 39
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x11BE590 Offset: 0x11BCB90 VA: 0x1811BE590 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11BE720 Offset: 0x11BCD20 VA: 0x1811BE720 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11BE9B0 Offset: 0x11BCFB0 VA: 0x1811BE9B0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x11BE420 Offset: 0x11BCA20 VA: 0x1811BE420 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x11BE4E0 Offset: 0x11BCAE0 VA: 0x1811BE4E0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x11BE850 Offset: 0x11BCE50 VA: 0x1811BE850 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x11BE620 Offset: 0x11BCC20 VA: 0x1811BE620 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x11BE430 Offset: 0x11BCA30 VA: 0x1811BE430 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x11BEBF0 Offset: 0x11BD1F0 VA: 0x1811BEBF0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x11BEC00 Offset: 0x11BD200 VA: 0x1811BEC00 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x11BEB70 Offset: 0x11BD170 VA: 0x1811BEB70 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x11BE440 Offset: 0x11BCA40 VA: 0x1811BE440 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x11BE8A0 Offset: 0x11BCEA0 VA: 0x1811BE8A0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x11BE940 Offset: 0x11BCF40 VA: 0x1811BE940 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x11BE400 Offset: 0x11BCA00 VA: 0x1811BE400 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x11BE270 Offset: 0x11BC870 VA: 0x1811BE270
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x11BE7B0 Offset: 0x11BCDB0 VA: 0x1811BE7B0
	private void WriteIndent() { }

}

internal sealed class XmlEventCache : XmlRawWriter // TypeDefIndex: 1882
{	// Fields
	private List<XmlEventCache.XmlEvent[]> pages; // 0x28
	private XmlEventCache.XmlEvent[] pageCurr; // 0x30
	private int pageSize; // 0x38
	private bool hasRootNode; // 0x3C
	private StringConcat singleText; // 0x40
	private string baseUri; // 0x78

	// Methods

	// RVA: 0x11C5D80 Offset: 0x11C4380 VA: 0x1811C5D80
	public void .ctor(string baseUri, bool hasRootNode) { }

	// RVA: 0x11C4790 Offset: 0x11C2D90 VA: 0x1811C4790
	public void EndEvents() { }

	// RVA: 0x11C47E0 Offset: 0x11C2DE0 VA: 0x1811C47E0
	public void EventsToWriter(XmlWriter writer) { }

	// RVA: 0x11C5730 Offset: 0x11C3D30 VA: 0x1811C5730 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x11C5A50 Offset: 0x11C4050 VA: 0x1811C5A50 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11C5A20 Offset: 0x11C4020 VA: 0x1811C5A20 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x11C57E0 Offset: 0x11C3DE0 VA: 0x1811C57E0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x11C55B0 Offset: 0x11C3BB0 VA: 0x1811C55B0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x11C56C0 Offset: 0x11C3CC0 VA: 0x1811C56C0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x11C5980 Offset: 0x11C3F80 VA: 0x1811C5980 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x11C5C00 Offset: 0x11C4200 VA: 0x1811C5C00 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x11C5A80 Offset: 0x11C4080 VA: 0x1811C5A80 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0xBA12F0 Offset: 0xB9F8F0 VA: 0x180BA12F0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0xE58AA0 Offset: 0xE570A0 VA: 0x180E58AA0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x11C59B0 Offset: 0x11C3FB0 VA: 0x1811C59B0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x11C58B0 Offset: 0x11C3EB0 VA: 0x1811C58B0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x11C5620 Offset: 0x11C3C20 VA: 0x1811C5620 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x11C5B10 Offset: 0x11C4110 VA: 0x1811C5B10 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x11C5390 Offset: 0x11C3990 VA: 0x1811C5390 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x11C54A0 Offset: 0x11C3AA0 VA: 0x1811C54A0 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x11C4650 Offset: 0x11C2C50 VA: 0x1811C4650 Slot: 28
	public override void Close() { }

	// RVA: 0x11C50B0 Offset: 0x11C36B0 VA: 0x1811C50B0 Slot: 29
	public override void Flush() { }

	// RVA: 0xAEF3F0 Offset: 0xAED9F0 VA: 0x180AEF3F0 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0x11C46A0 Offset: 0x11C2CA0 VA: 0x1811C46A0 Slot: 34
	protected override void Dispose(bool disposing) { }

	// RVA: 0x11C5CE0 Offset: 0x11C42E0 VA: 0x1811C5CE0 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x11C5C70 Offset: 0x11C4270 VA: 0x1811C5C70 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x11C5280 Offset: 0x11C3880 VA: 0x1811C5280 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x11C5880 Offset: 0x11C3E80 VA: 0x1811C5880 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11C5920 Offset: 0x11C3F20 VA: 0x1811C5920 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11C5950 Offset: 0x11C3F50 VA: 0x1811C5950 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x11C5830 Offset: 0x11C3E30 VA: 0x1811C5830 Slot: 46
	internal override void WriteEndBase64() { }

	// RVA: 0x11C4500 Offset: 0x11C2B00 VA: 0x1811C4500
	private void AddEvent(XmlEventCache.XmlEventType eventType) { }

	// RVA: 0x11C45E0 Offset: 0x11C2BE0 VA: 0x1811C45E0
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1) { }

	// RVA: 0x11C4550 Offset: 0x11C2B50 VA: 0x1811C4550
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2) { }

	// RVA: 0x11C43B0 Offset: 0x11C29B0 VA: 0x1811C43B0
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3) { }

	// RVA: 0x11C4450 Offset: 0x11C2A50 VA: 0x1811C4450
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o) { }

	// RVA: 0x11C4340 Offset: 0x11C2940 VA: 0x1811C4340
	private void AddEvent(XmlEventCache.XmlEventType eventType, object o) { }

	// RVA: 0x11C5100 Offset: 0x11C3700 VA: 0x1811C5100
	private int NewEvent() { }

	// RVA: 0x11C52D0 Offset: 0x11C38D0 VA: 0x1811C52D0
	private static byte[] ToBytes(byte[] buffer, int index, int count) { }

}

private enum XmlEventCache.XmlEventType // TypeDefIndex: 1883
{	// Fields
	public int value__; // 0x0
	public const XmlEventCache.XmlEventType Unknown = 0;
	public const XmlEventCache.XmlEventType DocType = 1;
	public const XmlEventCache.XmlEventType StartElem = 2;
	public const XmlEventCache.XmlEventType StartAttr = 3;
	public const XmlEventCache.XmlEventType EndAttr = 4;
	public const XmlEventCache.XmlEventType CData = 5;
	public const XmlEventCache.XmlEventType Comment = 6;
	public const XmlEventCache.XmlEventType PI = 7;
	public const XmlEventCache.XmlEventType Whitespace = 8;
	public const XmlEventCache.XmlEventType String = 9;
	public const XmlEventCache.XmlEventType Raw = 10;
	public const XmlEventCache.XmlEventType EntRef = 11;
	public const XmlEventCache.XmlEventType CharEnt = 12;
	public const XmlEventCache.XmlEventType SurrCharEnt = 13;
	public const XmlEventCache.XmlEventType Base64 = 14;
	public const XmlEventCache.XmlEventType BinHex = 15;
	public const XmlEventCache.XmlEventType XmlDecl1 = 16;
	public const XmlEventCache.XmlEventType XmlDecl2 = 17;
	public const XmlEventCache.XmlEventType StartContent = 18;
	public const XmlEventCache.XmlEventType EndElem = 19;
	public const XmlEventCache.XmlEventType FullEndElem = 20;
	public const XmlEventCache.XmlEventType Nmsp = 21;
	public const XmlEventCache.XmlEventType EndBase64 = 22;
	public const XmlEventCache.XmlEventType Close = 23;
	public const XmlEventCache.XmlEventType Flush = 24;
	public const XmlEventCache.XmlEventType Dispose = 25;

}

private struct XmlEventCache.XmlEvent // TypeDefIndex: 1884
{	// Fields
	private XmlEventCache.XmlEventType eventType; // 0x0
	private string s1; // 0x8
	private string s2; // 0x10
	private string s3; // 0x18
	private object o; // 0x20

	// Properties
	public XmlEventCache.XmlEventType EventType { get; }
	public string String1 { get; }
	public string String2 { get; }
	public string String3 { get; }
	public object Object { get; }

	// Methods

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public void InitEvent(XmlEventCache.XmlEventType eventType) { }

	// RVA: 0xFCAE0 Offset: 0xFBEE0 VA: 0x1800FCAE0
	public void InitEvent(XmlEventCache.XmlEventType eventType, string s1) { }

	// RVA: 0x1D1460 Offset: 0x1D0860 VA: 0x1801D1460
	public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2) { }

	// RVA: 0xF2890 Offset: 0xF1C90 VA: 0x1800F2890
	public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3) { }

	// RVA: 0x1D13E0 Offset: 0x1D07E0 VA: 0x1801D13E0
	public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o) { }

	// RVA: 0x1D1440 Offset: 0x1D0840 VA: 0x1801D1440
	public void InitEvent(XmlEventCache.XmlEventType eventType, object o) { }

	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720
	public XmlEventCache.XmlEventType get_EventType() { }

	// RVA: 0xF3EC0 Offset: 0xF32C0 VA: 0x1800F3EC0
	public string get_String1() { }

	// RVA: 0xF3EE0 Offset: 0xF32E0 VA: 0x1800F3EE0
	public string get_String2() { }

	// RVA: 0xF3EF0 Offset: 0xF32F0 VA: 0x1800F3EF0
	public string get_String3() { }

	// RVA: 0xF3730 Offset: 0xF2B30 VA: 0x1800F3730
	public object get_Object() { }

}

public class XmlParserContext // TypeDefIndex: 1885
{	// Fields
	private XmlNameTable _nt; // 0x10
	private XmlNamespaceManager _nsMgr; // 0x18
	private string _docTypeName; // 0x20
	private string _pubId; // 0x28
	private string _sysId; // 0x30
	private string _internalSubset; // 0x38
	private string _xmlLang; // 0x40
	private XmlSpace _xmlSpace; // 0x48
	private string _baseURI; // 0x50
	private Encoding _encoding; // 0x58

	// Properties
	public XmlNameTable NameTable { get; }
	public XmlNamespaceManager NamespaceManager { get; }
	public string DocTypeName { get; }
	public string PublicId { get; }
	public string SystemId { get; }
	public string BaseURI { get; }
	public string InternalSubset { get; }
	public string XmlLang { get; }
	public XmlSpace XmlSpace { get; }
	public Encoding Encoding { get; }
	internal bool HasDtdInfo { get; }

	// Methods

	// RVA: 0xB9FB70 Offset: 0xB9E170 VA: 0x180B9FB70
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0xB9FEF0 Offset: 0xB9E4F0 VA: 0x180B9FEF0
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0xB9FC20 Offset: 0xB9E220 VA: 0x180B9FC20
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public XmlNameTable get_NameTable() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_DocTypeName() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public string get_PublicId() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_SystemId() { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public string get_BaseURI() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public string get_InternalSubset() { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public string get_XmlLang() { }

	// RVA: 0x5983B0 Offset: 0x5969B0 VA: 0x1805983B0
	public XmlSpace get_XmlSpace() { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public Encoding get_Encoding() { }

	// RVA: 0xB9FF60 Offset: 0xB9E560 VA: 0x180B9FF60
	internal bool get_HasDtdInfo() { }

}

internal abstract class XmlRawWriter : XmlWriter // TypeDefIndex: 1886
{	// Fields
	protected XmlRawWriterBase64Encoder base64Encoder; // 0x18
	protected IXmlNamespaceResolver resolver; // 0x20

	// Properties
	public override WriteState WriteState { get; }
	internal virtual IXmlNamespaceResolver NamespaceResolver { set; }
	internal virtual bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0xBA15F0 Offset: 0xB9FBF0 VA: 0x180BA15F0 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0xBA1580 Offset: 0xB9FB80 VA: 0x180BA1580 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0xBA1350 Offset: 0xB9F950 VA: 0x180BA1350 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xBA13C0 Offset: 0xB9F9C0 VA: 0x180BA13C0 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0xBA1480 Offset: 0xB9FA80 VA: 0x180BA1480 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0xBA11A0 Offset: 0xB9F7A0 VA: 0x180BA11A0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0xBA10C0 Offset: 0xB9F6C0 VA: 0x180BA10C0 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0xBA1770 Offset: 0xB9FD70 VA: 0x180BA1770 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0xAEF3F0 Offset: 0xAED9F0 VA: 0x180AEF3F0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0xBA1260 Offset: 0xB9F860 VA: 0x180BA1260 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0xBA16B0 Offset: 0xB9FCB0 VA: 0x180BA16B0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0xAEF3F0 Offset: 0xAED9F0 VA: 0x180AEF3F0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0xBA12F0 Offset: 0xB9F8F0 VA: 0x180BA12F0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0xBA12F0 Offset: 0xB9F8F0 VA: 0x180BA12F0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0xAEF3F0 Offset: 0xAED9F0 VA: 0x180AEF3F0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0xAEF3F0 Offset: 0xAED9F0 VA: 0x180AEF3F0 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0xBA1130 Offset: 0xB9F730 VA: 0x180BA1130 Slot: 32
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0xBA1510 Offset: 0xB9FB10 VA: 0x180BA1510 Slot: 33
	public override void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0 Slot: 35
	internal virtual void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 36
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 37
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

	// RVA: -1 Offset: -1 Slot: 38
	internal abstract void StartElementContent();

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 39
	internal virtual void OnRootElement(ConformanceLevel conformanceLevel) { }

	// RVA: -1 Offset: -1 Slot: 40
	internal abstract void WriteEndElement(string prefix, string localName, string ns);

	// RVA: 0xBA14F0 Offset: 0xB9FAF0 VA: 0x180BA14F0 Slot: 41
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: -1 Offset: -1 Slot: 42
	internal abstract void WriteNamespaceDeclaration(string prefix, string ns);

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 43
	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0xBA1660 Offset: 0xB9FC60 VA: 0x180BA1660 Slot: 44
	internal virtual void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0xBA1430 Offset: 0xB9FA30 VA: 0x180BA1430 Slot: 45
	internal virtual void WriteEndNamespaceDeclaration() { }

	// RVA: 0xBA1330 Offset: 0xB9F930 VA: 0x180BA1330 Slot: 46
	internal virtual void WriteEndBase64() { }

	// RVA: 0xBA10A0 Offset: 0xB9F6A0 VA: 0x180BA10A0 Slot: 47
	internal virtual void Close(WriteState currentState) { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	protected void .ctor() { }

}

public abstract class XmlReader : IDisposable // TypeDefIndex: 1887
{	// Fields
	private static uint IsTextualNodeBitmap; // 0x0
	private static uint CanReadContentAsBitmap; // 0x4
	private static uint HasValueBitmap; // 0x8

	// Properties
	public virtual XmlReaderSettings Settings { get; }
	public abstract XmlNodeType NodeType { get; }
	public virtual string Name { get; }
	public abstract string LocalName { get; }
	public abstract string NamespaceURI { get; }
	public abstract string Prefix { get; }
	public abstract string Value { get; }
	public abstract int Depth { get; }
	public abstract string BaseURI { get; }
	public abstract bool IsEmptyElement { get; }
	public virtual bool IsDefault { get; }
	public virtual char QuoteChar { get; }
	public virtual XmlSpace XmlSpace { get; }
	public virtual string XmlLang { get; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }
	public virtual Type ValueType { get; }
	public abstract int AttributeCount { get; }
	public abstract bool EOF { get; }
	public abstract ReadState ReadState { get; }
	public abstract XmlNameTable NameTable { get; }
	public virtual bool CanResolveEntity { get; }
	public virtual bool CanReadValueChunk { get; }
	public virtual bool HasAttributes { get; }
	internal virtual XmlNamespaceManager NamespaceManager { get; }
	internal bool IsDefaultInternal { get; }
	internal virtual IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 5
	public virtual XmlReaderSettings get_Settings() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract XmlNodeType get_NodeType();

	// RVA: 0xBA49D0 Offset: 0xBA2FD0 VA: 0x180BA49D0 Slot: 7
	public virtual string get_Name() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_LocalName();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_NamespaceURI();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract string get_Prefix();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract string get_Value();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int get_Depth();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract string get_BaseURI();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool get_IsEmptyElement();

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 15
	public virtual bool get_IsDefault() { }

	// RVA: 0xBA4AD0 Offset: 0xBA30D0 VA: 0x180BA4AD0 Slot: 16
	public virtual char get_QuoteChar() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 17
	public virtual XmlSpace get_XmlSpace() { }

	// RVA: 0xBA4B80 Offset: 0xBA3180 VA: 0x180BA4B80 Slot: 18
	public virtual string get_XmlLang() { }

	// RVA: 0xBA4AE0 Offset: 0xBA30E0 VA: 0x180BA4AE0 Slot: 19
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xBA4B20 Offset: 0xBA3120 VA: 0x180BA4B20 Slot: 20
	public virtual Type get_ValueType() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract int get_AttributeCount();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract string GetAttribute(string name);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract string GetAttribute(string name, string namespaceURI);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract string GetAttribute(int i);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract bool MoveToAttribute(string name);

	// RVA: 0xBA32D0 Offset: 0xBA18D0 VA: 0x180BA32D0 Slot: 26
	public virtual void MoveToAttribute(int i) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract bool MoveToFirstAttribute();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract bool MoveToNextAttribute();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract bool MoveToElement();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool ReadAttributeValue();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool Read();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract bool get_EOF();

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 33
	public virtual void Close() { }

	// RVA: -1 Offset: -1 Slot: 34
	public abstract ReadState get_ReadState();

	// RVA: 0xBA4190 Offset: 0xBA2790 VA: 0x180BA4190 Slot: 35
	public virtual void Skip() { }

	// RVA: -1 Offset: -1 Slot: 36
	public abstract XmlNameTable get_NameTable();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract string LookupNamespace(string prefix);

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 38
	public virtual bool get_CanResolveEntity() { }

	// RVA: -1 Offset: -1 Slot: 39
	public abstract void ResolveEntity();

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 40
	public virtual bool get_CanReadValueChunk() { }

	// RVA: 0xBA3F30 Offset: 0xBA2530 VA: 0x180BA3F30 Slot: 41
	public virtual int ReadValueChunk(char[] buffer, int index, int count) { }

	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	// RVA: 0xBA3D10 Offset: 0xBA2310 VA: 0x180BA3D10 Slot: 42
	public virtual string ReadString() { }

	// RVA: 0xBA33A0 Offset: 0xBA19A0 VA: 0x180BA33A0 Slot: 43
	public virtual XmlNodeType MoveToContent() { }

	// RVA: 0xBA3C10 Offset: 0xBA2210 VA: 0x180BA3C10 Slot: 44
	public virtual void ReadStartElement() { }

	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	// RVA: 0xBA3430 Offset: 0xBA1A30 VA: 0x180BA3430 Slot: 45
	public virtual string ReadElementString() { }

	// RVA: 0xBA36B0 Offset: 0xBA1CB0 VA: 0x180BA36B0 Slot: 46
	public virtual void ReadEndElement() { }

	// RVA: 0xBA31B0 Offset: 0xBA17B0 VA: 0x180BA31B0 Slot: 47
	public virtual bool IsStartElement(string localname, string ns) { }

	// RVA: 0xBA37B0 Offset: 0xBA1DB0 VA: 0x180BA37B0 Slot: 48
	public virtual string ReadInnerXml() { }

	// RVA: 0xBA4390 Offset: 0xBA2990 VA: 0x180BA4390
	private void WriteNode(XmlWriter xtw, bool defattr) { }

	// RVA: 0xBA4280 Offset: 0xBA2880 VA: 0x180BA4280
	private void WriteAttributeValue(XmlWriter xtw) { }

	// RVA: 0xBA2D60 Offset: 0xBA1360 VA: 0x180BA2D60
	private XmlWriter CreateWriterForInnerOuterXml(StringWriter sw) { }

	// RVA: 0xBA3FA0 Offset: 0xBA25A0 VA: 0x180BA3FA0
	private void SetNamespacesFlag(XmlTextWriter xtw) { }

	// RVA: 0xBA4930 Offset: 0xBA2F30 VA: 0x180BA4930 Slot: 49
	public virtual bool get_HasAttributes() { }

	// RVA: 0xBA30D0 Offset: 0xBA16D0 VA: 0x180BA30D0 Slot: 4
	public void Dispose() { }

	// RVA: 0xBA30F0 Offset: 0xBA16F0 VA: 0x180BA30F0 Slot: 50
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 51
	internal virtual XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0xBA3250 Offset: 0xBA1850 VA: 0x180BA3250
	internal static bool IsTextualNode(XmlNodeType nodeType) { }

	// RVA: 0xBA3130 Offset: 0xBA1730 VA: 0x180BA3130
	internal static bool HasValueInternal(XmlNodeType nodeType) { }

	// RVA: 0xBA40B0 Offset: 0xBA26B0 VA: 0x180BA40B0
	private bool SkipSubtree() { }

	// RVA: 0xBA4950 Offset: 0xBA2F50 VA: 0x180BA4950
	internal bool get_IsDefaultInternal() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 52
	internal virtual IDtdInfo get_DtdInfo() { }

	// RVA: 0xBA2EA0 Offset: 0xBA14A0 VA: 0x180BA2EA0
	public static XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0xBA3040 Offset: 0xBA1640 VA: 0x180BA3040
	public static XmlReader Create(TextReader input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0xBA2A30 Offset: 0xBA1030 VA: 0x180BA2A30
	internal static XmlReader CreateSqlReader(Stream input, XmlReaderSettings settings, XmlParserContext inputContext) { }

	// RVA: 0xBA29A0 Offset: 0xBA0FA0 VA: 0x180BA29A0
	internal static int CalcBufferSize(Stream input) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0xBA48C0 Offset: 0xBA2EC0 VA: 0x180BA48C0
	private static void .cctor() { }

}

public sealed class XmlReaderSettings // TypeDefIndex: 1888
{	// Fields
	private bool useAsync; // 0x10
	private XmlNameTable nameTable; // 0x18
	private XmlResolver xmlResolver; // 0x20
	private int lineNumberOffset; // 0x28
	private int linePositionOffset; // 0x2C
	private ConformanceLevel conformanceLevel; // 0x30
	private bool checkCharacters; // 0x34
	private long maxCharactersInDocument; // 0x38
	private long maxCharactersFromEntities; // 0x40
	private bool ignoreWhitespace; // 0x48
	private bool ignorePIs; // 0x49
	private bool ignoreComments; // 0x4A
	private DtdProcessing dtdProcessing; // 0x4C
	private ValidationType validationType; // 0x50
	private XmlSchemaValidationFlags validationFlags; // 0x54
	private XmlSchemaSet schemas; // 0x58
	private ValidationEventHandler valEventHandler; // 0x60
	private bool closeInput; // 0x68
	private bool isReadOnly; // 0x69
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsXmlResolverSet>k__BackingField; // 0x6A
	private static Nullable<bool> s_enableLegacyXmlSettings; // 0x0

	// Properties
	public bool Async { get; set; }
	public XmlNameTable NameTable { get; set; }
	internal bool IsXmlResolverSet { get; set; }
	public XmlResolver XmlResolver { set; }
	public int LineNumberOffset { get; set; }
	public int LinePositionOffset { get; set; }
	public ConformanceLevel ConformanceLevel { get; set; }
	public bool CheckCharacters { get; set; }
	public long MaxCharactersInDocument { get; set; }
	public long MaxCharactersFromEntities { get; set; }
	public bool IgnoreWhitespace { get; set; }
	public bool IgnoreProcessingInstructions { get; set; }
	public bool IgnoreComments { get; set; }
	public DtdProcessing DtdProcessing { get; set; }
	public bool CloseInput { get; set; }
	public ValidationType ValidationType { get; set; }
	public XmlSchemaValidationFlags ValidationFlags { get; set; }
	public XmlSchemaSet Schemas { get; set; }
	internal bool ReadOnly { set; }

	// Methods

	// RVA: 0xBA2140 Offset: 0xBA0740 VA: 0x180BA2140
	public void .ctor() { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_Async() { }

	// RVA: 0xBA22C0 Offset: 0xBA08C0 VA: 0x180BA22C0
	public void set_Async(bool value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public XmlNameTable get_NameTable() { }

	// RVA: 0xBA2770 Offset: 0xBA0D70 VA: 0x180BA2770
	public void set_NameTable(XmlNameTable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xBA2240 Offset: 0xBA0840 VA: 0x180BA2240
	internal bool get_IsXmlResolverSet() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xBA25A0 Offset: 0xBA0BA0 VA: 0x180BA25A0
	internal void set_IsXmlResolverSet(bool value) { }

	// RVA: 0xBA2940 Offset: 0xBA0F40 VA: 0x180BA2940
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal XmlResolver GetXmlResolver() { }

	// RVA: 0xBA1F80 Offset: 0xBA0580 VA: 0x180BA1F80
	internal XmlResolver GetXmlResolver_CheckConfig() { }

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
	public int get_LineNumberOffset() { }

	// RVA: 0xBA25B0 Offset: 0xBA0BB0 VA: 0x180BA25B0
	public void set_LineNumberOffset(int value) { }

	// RVA: 0x5DE340 Offset: 0x5DC940 VA: 0x1805DE340
	public int get_LinePositionOffset() { }

	// RVA: 0xBA2600 Offset: 0xBA0C00 VA: 0x180BA2600
	public void set_LinePositionOffset(int value) { }

	// RVA: 0xA39490 Offset: 0xA37A90 VA: 0x180A39490
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0xBA23B0 Offset: 0xBA09B0 VA: 0x180BA23B0
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0xBA2210 Offset: 0xBA0810 VA: 0x180BA2210
	public bool get_CheckCharacters() { }

	// RVA: 0xBA2310 Offset: 0xBA0910 VA: 0x180BA2310
	public void set_CheckCharacters(bool value) { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public long get_MaxCharactersInDocument() { }

	// RVA: 0xBA26E0 Offset: 0xBA0CE0 VA: 0x180BA26E0
	public void set_MaxCharactersInDocument(long value) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public long get_MaxCharactersFromEntities() { }

	// RVA: 0xBA2650 Offset: 0xBA0C50 VA: 0x180BA2650
	public void set_MaxCharactersFromEntities(long value) { }

	// RVA: 0x4BC370 Offset: 0x4BA970 VA: 0x1804BC370
	public bool get_IgnoreWhitespace() { }

	// RVA: 0xBA2550 Offset: 0xBA0B50 VA: 0x180BA2550
	public void set_IgnoreWhitespace(bool value) { }

	// RVA: 0xBA2230 Offset: 0xBA0830 VA: 0x180BA2230
	public bool get_IgnoreProcessingInstructions() { }

	// RVA: 0xBA2500 Offset: 0xBA0B00 VA: 0x180BA2500
	public void set_IgnoreProcessingInstructions(bool value) { }

	// RVA: 0xBA2220 Offset: 0xBA0820 VA: 0x180BA2220
	public bool get_IgnoreComments() { }

	// RVA: 0xBA24B0 Offset: 0xBA0AB0 VA: 0x180BA24B0
	public void set_IgnoreComments(bool value) { }

	// RVA: 0x599CD0 Offset: 0x5982D0 VA: 0x180599CD0
	public DtdProcessing get_DtdProcessing() { }

	// RVA: 0xBA2430 Offset: 0xBA0A30 VA: 0x180BA2430
	public void set_DtdProcessing(DtdProcessing value) { }

	// RVA: 0x82D060 Offset: 0x82B660 VA: 0x18082D060
	public bool get_CloseInput() { }

	// RVA: 0xBA2360 Offset: 0xBA0960 VA: 0x180BA2360
	public void set_CloseInput(bool value) { }

	// RVA: 0x8D9520 Offset: 0x8D7B20 VA: 0x1808D9520
	public ValidationType get_ValidationType() { }

	// RVA: 0xBA28C0 Offset: 0xBA0EC0 VA: 0x180BA28C0
	public void set_ValidationType(ValidationType value) { }

	// RVA: 0x5DE8B0 Offset: 0x5DCEB0 VA: 0x1805DE8B0
	public XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0xBA2840 Offset: 0xBA0E40 VA: 0x180BA2840
	public void set_ValidationFlags(XmlSchemaValidationFlags value) { }

	// RVA: 0xBA2250 Offset: 0xBA0850 VA: 0x180BA2250
	public XmlSchemaSet get_Schemas() { }

	// RVA: 0xBA27E0 Offset: 0xBA0DE0 VA: 0x180BA27E0
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0xBA19C0 Offset: 0xB9FFC0 VA: 0x180BA19C0
	public XmlReaderSettings Clone() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0xBA1B00 Offset: 0xBA0100 VA: 0x180BA1B00
	internal XmlReader CreateReader(Stream input, Uri baseUri, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0xBA1C80 Offset: 0xBA0280 VA: 0x180BA1C80
	internal XmlReader CreateReader(TextReader input, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0xBA27D0 Offset: 0xBA0DD0 VA: 0x180BA27D0
	internal void set_ReadOnly(bool value) { }

	// RVA: 0xBA1910 Offset: 0xB9FF10 VA: 0x180BA1910
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0xBA2080 Offset: 0xBA0680 VA: 0x180BA2080
	private void Initialize() { }

	// RVA: 0xBA1FB0 Offset: 0xBA05B0 VA: 0x180BA1FB0
	private void Initialize(XmlResolver resolver) { }

	// RVA: 0xBA1A20 Offset: 0xBA0020 VA: 0x180BA1A20
	private static XmlResolver CreateDefaultResolver() { }

	// RVA: 0xBA17E0 Offset: 0xB9FDE0 VA: 0x180BA17E0
	internal XmlReader AddValidation(XmlReader reader) { }

	// RVA: 0xBA1A70 Offset: 0xBA0070 VA: 0x180BA1A70
	private XmlValidatingReaderImpl CreateDtdValidatingReader(XmlReader baseReader) { }

	// RVA: 0xBA1E70 Offset: 0xBA0470 VA: 0x180BA1E70
	internal static bool EnableLegacyXmlSettings() { }

}

public enum XmlSpace // TypeDefIndex: 1889
{	// Fields
	public int value__; // 0x0
	public const XmlSpace None = 0;
	public const XmlSpace Default = 1;
	public const XmlSpace Preserve = 2;

}

internal class XmlTextEncoder // TypeDefIndex: 1890
{	// Fields
	private TextWriter textWriter; // 0x10
	private bool inAttribute; // 0x18
	private char quoteChar; // 0x1A
	private StringBuilder attrValue; // 0x20
	private bool cacheAttrValue; // 0x28
	private XmlCharType xmlCharType; // 0x30

	// Properties
	internal char QuoteChar { set; }
	internal string AttributeValue { get; }

	// Methods

	// RVA: 0xBB2850 Offset: 0xBB0E50 VA: 0x180BB2850
	internal void .ctor(TextWriter textWriter) { }

	// RVA: 0xBB2910 Offset: 0xBB0F10 VA: 0x180BB2910
	internal void set_QuoteChar(char value) { }

	// RVA: 0xBB1290 Offset: 0xBAF890 VA: 0x180BB1290
	internal void StartAttribute(bool cacheAttrValue) { }

	// RVA: 0xBB1250 Offset: 0xBAF850 VA: 0x180BB1250
	internal void EndAttribute() { }

	// RVA: 0xBB28A0 Offset: 0xBB0EA0 VA: 0x180BB28A0
	internal string get_AttributeValue() { }

	// RVA: 0xBB1C40 Offset: 0xBB0240 VA: 0x180BB1C40
	internal void WriteSurrogateChar(char lowChar, char highChar) { }

	// RVA: 0xBB1D20 Offset: 0xBB0320 VA: 0x180BB1D20
	internal void Write(char[] array, int offset, int count) { }

	// RVA: 0xBB1AC0 Offset: 0xBB00C0 VA: 0x180BB1AC0
	internal void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0xBB2220 Offset: 0xBB0820 VA: 0x180BB2220
	internal void Write(string text) { }

	// RVA: 0xBB1640 Offset: 0xBAFC40 VA: 0x180BB1640
	internal void WriteRawWithSurrogateChecking(string text) { }

	// RVA: 0xBB1860 Offset: 0xBAFE60 VA: 0x180BB1860
	internal void WriteRaw(char[] array, int offset, int count) { }

	// RVA: 0xBB1430 Offset: 0xBAFA30 VA: 0x180BB1430
	internal void WriteCharEntity(char ch) { }

	// RVA: 0xBB15C0 Offset: 0xBAFBC0 VA: 0x180BB15C0
	internal void WriteEntityRef(string name) { }

	// RVA: 0xBB1A00 Offset: 0xBB0000 VA: 0x180BB1A00
	private void WriteStringFragment(string str, int offset, int count, char[] helperBuffer) { }

	// RVA: 0xBB13C0 Offset: 0xBAF9C0 VA: 0x180BB13C0
	private void WriteCharEntityImpl(char ch) { }

	// RVA: 0xBB1320 Offset: 0xBAF920 VA: 0x180BB1320
	private void WriteCharEntityImpl(string strVal) { }

	// RVA: 0xBB1540 Offset: 0xBAFB40 VA: 0x180BB1540
	private void WriteEntityRefImpl(string name) { }

}

public class XmlTextReader : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 1891
{	// Fields
	private XmlTextReaderImpl impl; // 0x10

	// Properties
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	public override bool CanReadValueChunk { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	public bool Namespaces { get; }
	public bool Normalization { get; set; }
	public WhitespaceHandling WhitespaceHandling { set; }
	public EntityHandling EntityHandling { set; }
	public XmlResolver XmlResolver { set; }
	internal XmlTextReaderImpl Impl { get; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal bool XmlValidatingReaderCompatibilityMode { set; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0xBC8F80 Offset: 0xBC7580 VA: 0x180BC8F80
	public void .ctor(Stream input) { }

	// RVA: 0xBC8DA0 Offset: 0xBC73A0 VA: 0x180BC8DA0
	public void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0xBC8C80 Offset: 0xBC7280 VA: 0x180BC8C80
	public void .ctor(TextReader input) { }

	// RVA: 0xBC8E80 Offset: 0xBC7480 VA: 0x180BC8E80
	public void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0xB19680 Offset: 0xB17C80 VA: 0x180B19680 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC9280 Offset: 0xBC7880 VA: 0x180BC9280 Slot: 7
	public override string get_Name() { }

	// RVA: 0xBC9220 Offset: 0xBC7820 VA: 0x180BC9220 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0xBC92E0 Offset: 0xBC78E0 VA: 0x180BC92E0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0xBC9350 Offset: 0xBC7950 VA: 0x180BC9350 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xBC93B0 Offset: 0xBC79B0 VA: 0x180BC93B0 Slot: 11
	public override string get_Value() { }

	// RVA: 0xBC90D0 Offset: 0xBC76D0 VA: 0x180BC90D0 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xBC90A0 Offset: 0xBC76A0 VA: 0x180BC90A0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBC9190 Offset: 0xBC7790 VA: 0x180BC9190 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xBC9160 Offset: 0xBC7760 VA: 0x180BC9160 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xBC9380 Offset: 0xBC7980 VA: 0x180BC9380 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xBC9410 Offset: 0xBC7A10 VA: 0x180BC9410 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBC93E0 Offset: 0xBC79E0 VA: 0x180BC93E0 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0xB197D0 Offset: 0xB17DD0 VA: 0x180B197D0 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xBC8920 Offset: 0xBC6F20 VA: 0x180BC8920 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xBC8950 Offset: 0xBC6F50 VA: 0x180BC8950 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0xBC8980 Offset: 0xBC6F80 VA: 0x180BC8980 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xBC8A20 Offset: 0xBC7020 VA: 0x180BC8A20 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xBC89F0 Offset: 0xBC6FF0 VA: 0x180BC89F0 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0xBC8A80 Offset: 0xBC7080 VA: 0x180BC8A80 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xBC8AB0 Offset: 0xBC70B0 VA: 0x180BC8AB0 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0xBC8A50 Offset: 0xBC7050 VA: 0x180BC8A50 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0xBC8AE0 Offset: 0xBC70E0 VA: 0x180BC8AE0 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0xBC8B40 Offset: 0xBC7140 VA: 0x180BC8B40 Slot: 31
	public override bool Read() { }

	// RVA: 0xBC9130 Offset: 0xBC7730 VA: 0x180BC9130 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0xB9F5D0 Offset: 0xB9DBD0 VA: 0x180B9F5D0 Slot: 33
	public override void Close() { }

	// RVA: 0xB9F640 Offset: 0xB9DC40 VA: 0x180B9F640 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xBC8BA0 Offset: 0xBC71A0 VA: 0x180BC8BA0 Slot: 35
	public override void Skip() { }

	// RVA: 0xBC9250 Offset: 0xBC7850 VA: 0x180BC9250 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xBC89B0 Offset: 0xBC6FB0 VA: 0x180BC89B0 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0xBC8B70 Offset: 0xBC7170 VA: 0x180BC8B70 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0xBC8B10 Offset: 0xBC7110 VA: 0x180BC8B10 Slot: 42
	public override string ReadString() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 53
	public bool HasLineInfo() { }

	// RVA: 0xBC91C0 Offset: 0xBC77C0 VA: 0x180BC91C0 Slot: 54
	public int get_LineNumber() { }

	// RVA: 0xBC91F0 Offset: 0xBC77F0 VA: 0x180BC91F0 Slot: 55
	public int get_LinePosition() { }

	// RVA: 0xBC8BD0 Offset: 0xBC71D0 VA: 0x180BC8BD0 Slot: 56
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xBC8C10 Offset: 0xBC7210 VA: 0x180BC8C10 Slot: 57
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0xBC8C40 Offset: 0xBC7240 VA: 0x180BC8C40 Slot: 58
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0xBC9310 Offset: 0xBC7910 VA: 0x180BC9310
	public bool get_Namespaces() { }

	// RVA: 0xBC9330 Offset: 0xBC7930 VA: 0x180BC9330
	public bool get_Normalization() { }

	// RVA: 0xBC94E0 Offset: 0xBC7AE0 VA: 0x180BC94E0
	public void set_Normalization(bool value) { }

	// RVA: 0xBC95A0 Offset: 0xBC7BA0 VA: 0x180BC95A0
	public void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0xBC9440 Offset: 0xBC7A40 VA: 0x180BC9440
	public void set_EntityHandling(EntityHandling value) { }

	// RVA: 0xBC9680 Offset: 0xBC7C80 VA: 0x180BC9680
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal XmlTextReaderImpl get_Impl() { }

	// RVA: 0xBC92B0 Offset: 0xBC78B0 VA: 0x180BC92B0 Slot: 51
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0xBC9730 Offset: 0xBC7D30 VA: 0x180BC9730
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0xBC9100 Offset: 0xBC7700 VA: 0x180BC9100 Slot: 52
	internal override IDtdInfo get_DtdInfo() { }

}

internal class XmlTextReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 1892
{	// Fields
	private readonly bool useAsync; // 0x10
	private XmlTextReaderImpl.LaterInitParam laterInitParam; // 0x18
	private XmlCharType xmlCharType; // 0x20
	private XmlTextReaderImpl.ParsingState ps; // 0x28
	private XmlTextReaderImpl.ParsingFunction parsingFunction; // 0xA0
	private XmlTextReaderImpl.ParsingFunction nextParsingFunction; // 0xA4
	private XmlTextReaderImpl.ParsingFunction nextNextParsingFunction; // 0xA8
	private XmlTextReaderImpl.NodeData[] nodes; // 0xB0
	private XmlTextReaderImpl.NodeData curNode; // 0xB8
	private int index; // 0xC0
	private int curAttrIndex; // 0xC4
	private int attrCount; // 0xC8
	private int attrHashtable; // 0xCC
	private int attrDuplWalkCount; // 0xD0
	private bool attrNeedNamespaceLookup; // 0xD4
	private bool fullAttrCleanup; // 0xD5
	private XmlTextReaderImpl.NodeData[] attrDuplSortingArray; // 0xD8
	private XmlNameTable nameTable; // 0xE0
	private bool nameTableFromSettings; // 0xE8
	private XmlResolver xmlResolver; // 0xF0
	private string url; // 0xF8
	private bool normalize; // 0x100
	private bool supportNamespaces; // 0x101
	private WhitespaceHandling whitespaceHandling; // 0x104
	private DtdProcessing dtdProcessing; // 0x108
	private EntityHandling entityHandling; // 0x10C
	private bool ignorePIs; // 0x110
	private bool ignoreComments; // 0x111
	private bool checkCharacters; // 0x112
	private int lineNumberOffset; // 0x114
	private int linePositionOffset; // 0x118
	private bool closeInput; // 0x11C
	private long maxCharactersInDocument; // 0x120
	private long maxCharactersFromEntities; // 0x128
	private bool v1Compat; // 0x130
	private XmlNamespaceManager namespaceManager; // 0x138
	private string lastPrefix; // 0x140
	private XmlTextReaderImpl.XmlContext xmlContext; // 0x148
	private XmlTextReaderImpl.ParsingState[] parsingStatesStack; // 0x150
	private int parsingStatesStackTop; // 0x158
	private string reportedBaseUri; // 0x160
	private Encoding reportedEncoding; // 0x168
	private IDtdInfo dtdInfo; // 0x170
	private XmlNodeType fragmentType; // 0x178
	private XmlParserContext fragmentParserContext; // 0x180
	private bool fragment; // 0x188
	private IncrementalReadDecoder incReadDecoder; // 0x190
	private XmlTextReaderImpl.IncrementalReadState incReadState; // 0x198
	private LineInfo incReadLineInfo; // 0x19C
	private int incReadDepth; // 0x1A4
	private int incReadLeftStartPos; // 0x1A8
	private int incReadLeftEndPos; // 0x1AC
	private int attributeValueBaseEntityId; // 0x1B0
	private bool emptyEntityInAttributeResolved; // 0x1B4
	private IValidationEventHandling validationEventHandling; // 0x1B8
	private XmlTextReaderImpl.OnDefaultAttributeUseDelegate onDefaultAttributeUse; // 0x1C0
	private bool validatingReaderCompatFlag; // 0x1C8
	private bool addDefaultAttributesAndNormalize; // 0x1C9
	private StringBuilder stringBuilder; // 0x1D0
	private bool rootElementParsed; // 0x1D8
	private bool standalone; // 0x1D9
	private int nextEntityId; // 0x1DC
	private XmlTextReaderImpl.ParsingMode parsingMode; // 0x1E0
	private ReadState readState; // 0x1E4
	private IDtdEntityInfo lastEntity; // 0x1E8
	private bool afterResetState; // 0x1F0
	private int documentStartBytePos; // 0x1F4
	private int readValueOffset; // 0x1F8
	private long charactersInDocument; // 0x200
	private long charactersFromEntities; // 0x208
	private Dictionary<IDtdEntityInfo, IDtdEntityInfo> currentEntities; // 0x210
	private bool disableUndeclaredEntityCheck; // 0x218
	private XmlReader outerReader; // 0x220
	private bool xmlResolverIsSet; // 0x228
	private string Xml; // 0x230
	private string XmlNs; // 0x238
	private Task<Tuple<int, int, int, bool>> parseText_dummyTask; // 0x240

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override ReadState ReadState { get; }
	public override bool EOF { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	public override int AttributeCount { get; }
	internal XmlReader OuterReader { set; }
	public override bool CanReadValueChunk { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	internal bool Namespaces { get; set; }
	internal bool Normalization { get; set; }
	internal WhitespaceHandling WhitespaceHandling { set; }
	internal EntityHandling EntityHandling { set; }
	internal bool IsResolverSet { get; }
	internal XmlResolver XmlResolver { set; }
	internal XmlNameTable DtdParserProxy_NameTable { get; }
	internal IXmlNamespaceResolver DtdParserProxy_NamespaceResolver { get; }
	internal bool DtdParserProxy_DtdValidation { get; }
	internal bool DtdParserProxy_Normalization { get; }
	internal bool DtdParserProxy_Namespaces { get; }
	internal bool DtdParserProxy_V1CompatibilityMode { get; }
	internal Uri DtdParserProxy_BaseUri { get; }
	internal bool DtdParserProxy_IsEof { get; }
	internal char[] DtdParserProxy_ParsingBuffer { get; }
	internal int DtdParserProxy_ParsingBufferLength { get; }
	internal int DtdParserProxy_CurrentPosition { get; set; }
	internal int DtdParserProxy_EntityStackLength { get; }
	internal bool DtdParserProxy_IsEntityEolNormalized { get; }
	internal IValidationEventHandling DtdParserProxy_ValidationEventHandling { get; }
	internal int DtdParserProxy_LineNo { get; }
	internal int DtdParserProxy_LineStartPosition { get; }
	private bool IsResolverNull { get; }
	private bool InAttributeValueIterator { get; }
	private bool DtdValidation { get; }
	private bool InEntity { get; }
	internal override IDtdInfo DtdInfo { get; }
	internal IValidationEventHandling ValidationEventHandling { set; }
	internal XmlTextReaderImpl.OnDefaultAttributeUseDelegate OnDefaultAttributeUse { set; }
	internal bool XmlValidatingReaderCompatibilityMode { set; }
	internal XmlNodeType FragmentType { get; }
	internal object InternalSchemaType { set; }
	internal object InternalTypedValue { get; set; }
	internal bool StandAlone { get; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal bool V1Compat { get; }
	internal bool DisableUndeclaredEntityCheck { set; }

	// Methods

	// RVA: 0xBC6500 Offset: 0xBC4B00 VA: 0x180BC6500
	internal void .ctor(XmlNameTable nt) { }

	// RVA: 0xBC6ED0 Offset: 0xBC54D0 VA: 0x180BC6ED0
	private void .ctor(XmlResolver resolver, XmlReaderSettings settings, XmlParserContext context) { }

	// RVA: 0xBC6AD0 Offset: 0xBC50D0 VA: 0x180BC6AD0
	internal void .ctor(Stream input) { }

	// RVA: 0xBC6CA0 Offset: 0xBC52A0 VA: 0x180BC6CA0
	internal void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0xBC6A40 Offset: 0xBC5040 VA: 0x180BC6A40
	internal void .ctor(TextReader input) { }

	// RVA: 0xBC7400 Offset: 0xBC5A00 VA: 0x180BC7400
	internal void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0xBC7820 Offset: 0xBC5E20 VA: 0x180BC7820
	internal void .ctor(string url, TextReader input, XmlNameTable nt) { }

	// RVA: 0xBC6910 Offset: 0xBC4F10 VA: 0x180BC6910
	internal void .ctor(string xmlFragment, XmlNodeType fragType, XmlParserContext context) { }

	// RVA: 0xBC6DC0 Offset: 0xBC53C0 VA: 0x180BC6DC0
	internal void .ctor(string xmlFragment, XmlParserContext context) { }

	// RVA: 0xBB5D80 Offset: 0xBB4380 VA: 0x180BB5D80
	private void FinishInitUriString() { }

	// RVA: 0xBC7470 Offset: 0xBC5A70 VA: 0x180BC7470
	internal void .ctor(Stream stream, byte[] bytes, int byteCount, XmlReaderSettings settings, Uri baseUri, string baseUriStr, XmlParserContext context, bool closeInput) { }

	// RVA: 0xBB5C00 Offset: 0xBB4200 VA: 0x180BB5C00
	private void FinishInitStream() { }

	// RVA: 0xBC6B60 Offset: 0xBC5160 VA: 0x180BC6B60
	internal void .ctor(TextReader input, XmlReaderSettings settings, string baseUriStr, XmlParserContext context) { }

	// RVA: 0xBB5CD0 Offset: 0xBB42D0 VA: 0x180BB5CD0
	private void FinishInitTextReader() { }

	// RVA: 0xBC7760 Offset: 0xBC5D60 VA: 0x180BC7760
	internal void .ctor(string xmlFragment, XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0xBC7CF0 Offset: 0xBC62F0 VA: 0x180BC7CF0 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0xBC7C70 Offset: 0xBC6270 VA: 0x180BC7C70 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC7C20 Offset: 0xBC6220 VA: 0x180BC7C20 Slot: 7
	public override string get_Name() { }

	// RVA: 0xBC7C00 Offset: 0xBC6200 VA: 0x180BC7C00 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0xBC7C50 Offset: 0xBC6250 VA: 0x180BC7C50 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0xBC7C90 Offset: 0xBC6290 VA: 0x180BC7C90 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xBC8120 Offset: 0xBC6720 VA: 0x180BC8120 Slot: 11
	public override string get_Value() { }

	// RVA: 0xBC7920 Offset: 0xBC5F20 VA: 0x180BC7920 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x7B27D0 Offset: 0x7B0DD0 VA: 0x1807B27D0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBC7B20 Offset: 0xBC6120 VA: 0x180BC7B20 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xBC7AF0 Offset: 0xBC60F0 VA: 0x180BC7AF0 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xBC7CB0 Offset: 0xBC62B0 VA: 0x180BC7CB0 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xBC82B0 Offset: 0xBC68B0 VA: 0x180BC82B0 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBC8290 Offset: 0xBC6890 VA: 0x180BC8290 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0xBC7CE0 Offset: 0xBC62E0 VA: 0x180BC7CE0 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xBC7A80 Offset: 0xBC6080 VA: 0x180BC7A80 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x4EF330 Offset: 0x4ED930 VA: 0x1804EF330 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0xAE31D0 Offset: 0xAE17D0 VA: 0x180AE31D0 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xBB6940 Offset: 0xBB4F40 VA: 0x180BB6940 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xBB6780 Offset: 0xBB4D80 VA: 0x180BB6780 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0xBB66C0 Offset: 0xBB4CC0 VA: 0x180BB66C0 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xBB8F80 Offset: 0xBB7580 VA: 0x180BB8F80 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xBB9050 Offset: 0xBB7650 VA: 0x180BB9050 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0xBB91D0 Offset: 0xBB77D0 VA: 0x180BB91D0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xBB9260 Offset: 0xBB7860 VA: 0x180BB9260 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0xBB9130 Offset: 0xBB7730 VA: 0x180BB9130 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0xBB60D0 Offset: 0xBB46D0 VA: 0x180BB60D0
	private void FinishInit() { }

	// RVA: 0xBC2DA0 Offset: 0xBC13A0 VA: 0x180BC2DA0 Slot: 31
	public override bool Read() { }

	// RVA: 0xBB49E0 Offset: 0xBB2FE0 VA: 0x180BB49E0 Slot: 33
	public override void Close() { }

	// RVA: 0xBC4C40 Offset: 0xBC3240 VA: 0x180BC4C40 Slot: 35
	public override void Skip() { }

	// RVA: 0xBB8E40 Offset: 0xBB7440 VA: 0x180BB8E40 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0xBC2070 Offset: 0xBC0670 VA: 0x180BC2070 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0xBC3750 Offset: 0xBC1D50 VA: 0x180BC3750 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0xBC86B0 Offset: 0xBC6CB0 VA: 0x180BC86B0
	internal void set_OuterReader(XmlReader value) { }

	// RVA: 0xBB8EB0 Offset: 0xBB74B0 VA: 0x180BB8EB0
	internal void MoveOffEntityReference() { }

	// RVA: 0xBC2870 Offset: 0xBC0E70 VA: 0x180BC2870 Slot: 42
	public override string ReadString() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0xBC2890 Offset: 0xBC0E90 VA: 0x180BC2890 Slot: 41
	public override int ReadValueChunk(char[] buffer, int index, int count) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 53
	public bool HasLineInfo() { }

	// RVA: 0xBC7BA0 Offset: 0xBC61A0 VA: 0x180BC7BA0 Slot: 54
	public int get_LineNumber() { }

	// RVA: 0xBC7BD0 Offset: 0xBC61D0 VA: 0x180BC7BD0 Slot: 55
	public int get_LinePosition() { }

	// RVA: 0xBB6CF0 Offset: 0xBB52F0 VA: 0x180BB6CF0 Slot: 56
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xBC5370 Offset: 0xBC3970 VA: 0x180BC5370 Slot: 57
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0xBB8E80 Offset: 0xBB7480 VA: 0x180BB8E80 Slot: 58
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0xBB6CF0 Offset: 0xBB52F0 VA: 0x180BB6CF0
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xBB8E80 Offset: 0xBB7480 VA: 0x180BB8E80
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0xBC7A50 Offset: 0xBC6050 VA: 0x180BC7A50
	internal bool get_Namespaces() { }

	// RVA: 0xBC83D0 Offset: 0xBC69D0 VA: 0x180BC83D0
	internal void set_Namespaces(bool value) { }

	// RVA: 0xBC7A60 Offset: 0xBC6060 VA: 0x180BC7A60
	internal bool get_Normalization() { }

	// RVA: 0xBC85F0 Offset: 0xBC6BF0 VA: 0x180BC85F0
	internal void set_Normalization(bool value) { }

	// RVA: 0xBC86D0 Offset: 0xBC6CD0 VA: 0x180BC86D0
	internal void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0xBC82E0 Offset: 0xBC68E0 VA: 0x180BC82E0
	internal void set_EntityHandling(EntityHandling value) { }

	// RVA: 0xBC7B90 Offset: 0xBC6190 VA: 0x180BC7B90
	internal bool get_IsResolverSet() { }

	// RVA: 0xBC87B0 Offset: 0xBC6DB0 VA: 0x180BC87B0
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x4EF330 Offset: 0x4ED930 VA: 0x1804EF330
	internal XmlNameTable get_DtdParserProxy_NameTable() { }

	// RVA: 0xBC7A40 Offset: 0xBC6040 VA: 0x180BC7A40
	internal IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver() { }

	// RVA: 0xBC7A10 Offset: 0xBC6010 VA: 0x180BC7A10
	internal bool get_DtdParserProxy_DtdValidation() { }

	// RVA: 0xBC7A60 Offset: 0xBC6060 VA: 0x180BC7A60
	internal bool get_DtdParserProxy_Normalization() { }

	// RVA: 0xBC7A50 Offset: 0xBC6050 VA: 0x180BC7A50
	internal bool get_DtdParserProxy_Namespaces() { }

	// RVA: 0xBC7A70 Offset: 0xBC6070 VA: 0x180BC7A70
	internal bool get_DtdParserProxy_V1CompatibilityMode() { }

	// RVA: 0xBC7940 Offset: 0xBC5F40 VA: 0x180BC7940
	internal Uri get_DtdParserProxy_BaseUri() { }

	// RVA: 0x69D6A0 Offset: 0x69BCA0 VA: 0x18069D6A0
	internal bool get_DtdParserProxy_IsEof() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	internal char[] get_DtdParserProxy_ParsingBuffer() { }

	// RVA: 0x5E2ED0 Offset: 0x5E14D0 VA: 0x1805E2ED0
	internal int get_DtdParserProxy_ParsingBufferLength() { }

	// RVA: 0xA39490 Offset: 0xA37A90 VA: 0x180A39490
	internal int get_DtdParserProxy_CurrentPosition() { }

	// RVA: 0xA39A50 Offset: 0xA38050 VA: 0x180A39A50
	internal void set_DtdParserProxy_CurrentPosition(int value) { }

	// RVA: 0xBC7A20 Offset: 0xBC6020 VA: 0x180BC7A20
	internal int get_DtdParserProxy_EntityStackLength() { }

	// RVA: 0xBC7A30 Offset: 0xBC6030 VA: 0x180BC7A30
	internal bool get_DtdParserProxy_IsEntityEolNormalized() { }

	// RVA: 0x737F10 Offset: 0x736510 VA: 0x180737F10
	internal IValidationEventHandling get_DtdParserProxy_ValidationEventHandling() { }

	// RVA: 0xBB4DF0 Offset: 0xBB33F0 VA: 0x180BB4DF0
	internal void DtdParserProxy_OnNewLine(int pos) { }

	// RVA: 0x804110 Offset: 0x802710 VA: 0x180804110
	internal int get_DtdParserProxy_LineNo() { }

	// RVA: 0xB29340 Offset: 0xB27940 VA: 0x180B29340
	internal int get_DtdParserProxy_LineStartPosition() { }

	// RVA: 0xBB5620 Offset: 0xBB3C20 VA: 0x180BB5620
	internal int DtdParserProxy_ReadData() { }

	// RVA: 0xBB5140 Offset: 0xBB3740 VA: 0x180BB5140
	internal int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0xBB5130 Offset: 0xBB3730 VA: 0x180BB5130
	internal int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0xBB51F0 Offset: 0xBB37F0 VA: 0x180BB51F0
	internal void DtdParserProxy_ParsePI(StringBuilder sb) { }

	// RVA: 0xBB4FC0 Offset: 0xBB35C0 VA: 0x180BB4FC0
	internal void DtdParserProxy_ParseComment(StringBuilder sb) { }

	// RVA: 0xBC7B50 Offset: 0xBC6150 VA: 0x180BC7B50
	private bool get_IsResolverNull() { }

	// RVA: 0xBB6D60 Offset: 0xBB5360 VA: 0x180BB6D60
	private XmlResolver GetTempResolver() { }

	// RVA: 0xBB5330 Offset: 0xBB3930 VA: 0x180BB5330
	internal bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, out int entityId) { }

	// RVA: 0xBB5240 Offset: 0xBB3840 VA: 0x180BB5240
	internal bool DtdParserProxy_PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	// RVA: 0xBB5400 Offset: 0xBB3A00 VA: 0x180BB5400
	internal bool DtdParserProxy_PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0xBB5580 Offset: 0xBB3B80 VA: 0x180BB5580
	internal void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0xBB5630 Offset: 0xBB3C30 VA: 0x180BB5630
	internal void DtdParserProxy_Throw(Exception e) { }

	// RVA: 0xBB4EE0 Offset: 0xBB34E0 VA: 0x180BB4EE0
	internal void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0xBB4E00 Offset: 0xBB3400 VA: 0x180BB4E00
	internal void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0xBC5DC0 Offset: 0xBC43C0 VA: 0x180BC5DC0
	private void Throw(int pos, string res, string arg) { }

	// RVA: 0xBC6180 Offset: 0xBC4780 VA: 0x180BC6180
	private void Throw(int pos, string res, string[] args) { }

	// RVA: 0xBC5E00 Offset: 0xBC4400 VA: 0x180BC5E00
	private void Throw(int pos, string res) { }

	// RVA: 0xBC5F10 Offset: 0xBC4510 VA: 0x180BC5F10
	private void Throw(string res) { }

	// RVA: 0xBC61C0 Offset: 0xBC47C0 VA: 0x180BC61C0
	private void Throw(string res, int lineNo, int linePos) { }

	// RVA: 0xBC6030 Offset: 0xBC4630 VA: 0x180BC6030
	private void Throw(string res, string arg) { }

	// RVA: 0xBC5E70 Offset: 0xBC4470 VA: 0x180BC5E70
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0xBC5F70 Offset: 0xBC4570 VA: 0x180BC5F70
	private void Throw(string res, string[] args) { }

	// RVA: 0xBC60F0 Offset: 0xBC46F0 VA: 0x180BC60F0
	private void Throw(string res, string arg, Exception innerException) { }

	// RVA: 0xBC5D00 Offset: 0xBC4300 VA: 0x180BC5D00
	private void Throw(string res, string[] args, Exception innerException) { }

	// RVA: 0xBC5C40 Offset: 0xBC4240 VA: 0x180BC5C40
	private void Throw(Exception e) { }

	// RVA: 0xBC1FC0 Offset: 0xBC05C0 VA: 0x180BC1FC0
	private void ReThrow(Exception e, int lineNo, int linePos) { }

	// RVA: 0xBC5A70 Offset: 0xBC4070 VA: 0x180BC5A70
	private void ThrowWithoutLineInfo(string res) { }

	// RVA: 0xBC5B10 Offset: 0xBC4110 VA: 0x180BC5B10
	private void ThrowWithoutLineInfo(string res, string arg) { }

	// RVA: 0xBC5BA0 Offset: 0xBC41A0 VA: 0x180BC5BA0
	private void ThrowWithoutLineInfo(string res, string[] args, Exception innerException) { }

	// RVA: 0xBC5400 Offset: 0xBC3A00 VA: 0x180BC5400
	private void ThrowInvalidChar(char[] data, int length, int invCharPos) { }

	// RVA: 0xBC3C70 Offset: 0xBC2270 VA: 0x180BC3C70
	private void SetErrorState() { }

	// RVA: 0xBC39B0 Offset: 0xBC1FB0 VA: 0x180BC39B0
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos) { }

	// RVA: 0xBC3AF0 Offset: 0xBC20F0 VA: 0x180BC3AF0
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception) { }

	// RVA: 0xBC7A90 Offset: 0xBC6090 VA: 0x180BC7A90
	private bool get_InAttributeValueIterator() { }

	// RVA: 0xBB5920 Offset: 0xBB3F20 VA: 0x180BB5920
	private void FinishAttributeValueIterator() { }

	// RVA: 0xBC7A10 Offset: 0xBC6010 VA: 0x180BC7A10
	private bool get_DtdValidation() { }

	// RVA: 0xBB8590 Offset: 0xBB6B90 VA: 0x180BB8590
	private void InitStreamInput(Stream stream, Encoding encoding) { }

	// RVA: 0xBB89A0 Offset: 0xBB6FA0 VA: 0x180BB89A0
	private void InitStreamInput(string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0xBB8920 Offset: 0xBB6F20 VA: 0x180BB8920
	private void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding) { }

	// RVA: 0xBB8560 Offset: 0xBB6B60 VA: 0x180BB8560
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0xBB8610 Offset: 0xBB6C10 VA: 0x180BB8610
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, byte[] bytes, int byteCount, Encoding encoding) { }

	// RVA: 0xBB8AF0 Offset: 0xBB70F0 VA: 0x180BB8AF0
	private void InitTextReaderInput(string baseUriStr, TextReader input) { }

	// RVA: 0xBB8B10 Offset: 0xBB7110 VA: 0x180BB8B10
	private void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input) { }

	// RVA: 0xBB89D0 Offset: 0xBB6FD0 VA: 0x180BB89D0
	private void InitStringInput(string baseUriStr, Encoding originalEncoding, string str) { }

	// RVA: 0xBB82C0 Offset: 0xBB68C0 VA: 0x180BB82C0
	private void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment) { }

	// RVA: 0xBC16E0 Offset: 0xBBFCE0 VA: 0x180BC16E0
	private void ProcessDtdFromParserContext(XmlParserContext context) { }

	// RVA: 0xBB9D50 Offset: 0xBB8350 VA: 0x180BB9D50
	private void OpenUrl() { }

	// RVA: 0xBB9C00 Offset: 0xBB8200 VA: 0x180BB9C00
	private void OpenUrlDelegate(object xmlResolver) { }

	// RVA: 0xBB4BD0 Offset: 0xBB31D0 VA: 0x180BB4BD0
	private Encoding DetectEncoding() { }

	// RVA: 0xBC3C90 Offset: 0xBC2290 VA: 0x180BC3C90
	private void SetupEncoding(Encoding encoding) { }

	// RVA: 0xBC51D0 Offset: 0xBC37D0 VA: 0x180BC51D0
	private void SwitchEncoding(Encoding newEncoding) { }

	// RVA: 0xBB4740 Offset: 0xBB2D40 VA: 0x180BB4740
	private Encoding CheckEncoding(string newEncodingName) { }

	// RVA: 0xBC6280 Offset: 0xBC4880 VA: 0x180BC6280
	private void UnDecodeChars() { }

	// RVA: 0xBC5160 Offset: 0xBC3760 VA: 0x180BC5160
	private void SwitchEncodingToUTF8() { }

	// RVA: 0xBC23E0 Offset: 0xBC09E0 VA: 0x180BC23E0
	private int ReadData() { }

	// RVA: 0xBB69E0 Offset: 0xBB4FE0 VA: 0x180BB69E0
	private int GetChars(int maxCharsCount) { }

	// RVA: 0xBB8C00 Offset: 0xBB7200 VA: 0x180BB8C00
	private void InvalidCharRecovery(ref int bytesCount, out int charsCount) { }

	// RVA: 0xBB4AE0 Offset: 0xBB30E0 VA: 0x180BB4AE0
	internal void Close(bool closeInput) { }

	// RVA: 0xBC4230 Offset: 0xBC2830 VA: 0x180BC4230
	private void ShiftBuffer(int sourcePos, int destPos, int count) { }

	// RVA: 0xBC0450 Offset: 0xBBEA50 VA: 0x180BC0450
	private bool ParseXmlDeclaration(bool isTextDecl) { }

	// RVA: 0xBBC260 Offset: 0xBBA860 VA: 0x180BBC260
	private bool ParseDocumentContent() { }

	// RVA: 0xBBCC00 Offset: 0xBBB200 VA: 0x180BBCC00
	private bool ParseElementContent() { }

	// RVA: 0xBC56A0 Offset: 0xBC3CA0 VA: 0x180BC56A0
	private void ThrowUnclosedElements() { }

	// RVA: 0xBBCFA0 Offset: 0xBBB5A0 VA: 0x180BBCFA0
	private void ParseElement() { }

	// RVA: 0xBB3650 Offset: 0xBB1C50 VA: 0x180BB3650
	private void AddDefaultAttributesAndNormalize() { }

	// RVA: 0xBBD560 Offset: 0xBBBB60 VA: 0x180BBD560
	private void ParseEndElement() { }

	// RVA: 0xBC5470 Offset: 0xBC3A70 VA: 0x180BC5470
	private void ThrowTagMismatch(XmlTextReaderImpl.NodeData startTag) { }

	// RVA: 0xBBB1E0 Offset: 0xBB97E0 VA: 0x180BBB1E0
	private void ParseAttributes() { }

	// RVA: 0xBB58B0 Offset: 0xBB3EB0 VA: 0x180BB58B0
	private void ElementNamespaceLookup() { }

	// RVA: 0xBB4630 Offset: 0xBB2C30 VA: 0x180BB4630
	private void AttributeNamespaceLookup() { }

	// RVA: 0xBB4200 Offset: 0xBB2800 VA: 0x180BB4200
	private void AttributeDuplCheck() { }

	// RVA: 0xBB9420 Offset: 0xBB7A20 VA: 0x180BB9420
	private void OnDefaultNamespaceDecl(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0xBB9630 Offset: 0xBB7C30 VA: 0x180BB9630
	private void OnNamespaceDecl(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0xBB9740 Offset: 0xBB7D40 VA: 0x180BB9740
	private void OnXmlReservedAttribute(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0xBBA710 Offset: 0xBB8D10 VA: 0x180BBA710
	private void ParseAttributeValueSlow(int curPos, char quoteChar, XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0xBB2920 Offset: 0xBB0F20 VA: 0x180BB2920
	private void AddAttributeChunkToList(XmlTextReaderImpl.NodeData attr, XmlTextReaderImpl.NodeData chunk, ref XmlTextReaderImpl.NodeData lastChunk) { }

	// RVA: 0xBBFE40 Offset: 0xBBE440 VA: 0x180BBFE40
	private bool ParseText() { }

	// RVA: 0xBBF680 Offset: 0xBBDC80 VA: 0x180BBF680
	private bool ParseText(out int startPos, out int endPos, ref int outOrChars) { }

	// RVA: 0xBB6260 Offset: 0xBB4860 VA: 0x180BB6260
	private void FinishPartialValue() { }

	// RVA: 0xBB6120 Offset: 0xBB4720 VA: 0x180BB6120
	private void FinishOtherValueIterator() { }

	// RVA: 0xBC4610 Offset: 0xBC2C10 VA: 0x180BC4610
	private void SkipPartialTextValue() { }

	// RVA: 0xBB65D0 Offset: 0xBB4BD0 VA: 0x180BB65D0
	private void FinishReadValueChunk() { }

	// RVA: 0xBB6390 Offset: 0xBB4990 VA: 0x180BB6390
	private void FinishReadContentAsBinary() { }

	// RVA: 0xBB64E0 Offset: 0xBB4AE0 VA: 0x180BB64E0
	private void FinishReadElementContentAsBinary() { }

	// RVA: 0xBBF390 Offset: 0xBBD990 VA: 0x180BBF390
	private bool ParseRootLevelWhitespace() { }

	// RVA: 0xBBDAF0 Offset: 0xBBC0F0 VA: 0x180BBDAF0
	private void ParseEntityReference() { }

	// RVA: 0xBB7010 Offset: 0xBB5610 VA: 0x180BB7010
	private XmlTextReaderImpl.EntityType HandleEntityReference(bool isInAttributeValue, XmlTextReaderImpl.EntityExpandType expandType, out int charRefEndPos) { }

	// RVA: 0xBB72B0 Offset: 0xBB58B0 VA: 0x180BB72B0
	private XmlTextReaderImpl.EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos) { }

	// RVA: 0xBC7AB0 Offset: 0xBC60B0 VA: 0x180BC7AB0
	private bool get_InEntity() { }

	// RVA: 0xBB6E70 Offset: 0xBB5470 VA: 0x180BB6E70
	private bool HandleEntityEnd(bool checkEntityNesting) { }

	// RVA: 0xBC3E80 Offset: 0xBC2480 VA: 0x180BC3E80
	private void SetupEndEntityNodeInContent() { }

	// RVA: 0xBC3DF0 Offset: 0xBC23F0 VA: 0x180BC3DF0
	private void SetupEndEntityNodeInAttribute() { }

	// RVA: 0xBBECA0 Offset: 0xBBD2A0 VA: 0x180BBECA0
	private bool ParsePI() { }

	// RVA: 0xBBECB0 Offset: 0xBBD2B0 VA: 0x180BBECB0
	private bool ParsePI(StringBuilder piInDtdStringBuilder) { }

	// RVA: 0xBBE8D0 Offset: 0xBBCED0 VA: 0x180BBE8D0
	private bool ParsePIValue(out int outStartPos, out int outEndPos) { }

	// RVA: 0xBBBF40 Offset: 0xBBA540 VA: 0x180BBBF40
	private bool ParseComment() { }

	// RVA: 0xBBBEA0 Offset: 0xBBA4A0 VA: 0x180BBBEA0
	private void ParseCData() { }

	// RVA: 0xBBB860 Offset: 0xBB9E60 VA: 0x180BBB860
	private void ParseCDataOrComment(XmlNodeType type) { }

	// RVA: 0xBBBA40 Offset: 0xBBA040 VA: 0x180BBBA40
	private bool ParseCDataOrComment(XmlNodeType type, out int outStartPos, out int outEndPos) { }

	// RVA: 0xBBBFA0 Offset: 0xBBA5A0 VA: 0x180BBBFA0
	private bool ParseDoctypeDecl() { }

	// RVA: 0xBBC980 Offset: 0xBBAF80 VA: 0x180BBC980
	private void ParseDtd() { }

	// RVA: 0xBC4260 Offset: 0xBC2860 VA: 0x180BC4260
	private void SkipDtd() { }

	// RVA: 0xBC4670 Offset: 0xBC2C70 VA: 0x180BC4670
	private void SkipPublicOrSystemIdLiteral() { }

	// RVA: 0xBC4710 Offset: 0xBC2D10 VA: 0x180BC4710
	private void SkipUntil(char stopChar, bool recognizeLiterals) { }

	// RVA: 0xBB5640 Offset: 0xBB3C40 VA: 0x180BB5640
	private int EatWhitespaces(StringBuilder sb) { }

	// RVA: 0xBBBEB0 Offset: 0xBBA4B0 VA: 0x180BBBEB0
	private int ParseCharRefInline(int startPos, out int charCount, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0xBBE800 Offset: 0xBBCE00 VA: 0x180BBE800
	private int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0xBBE090 Offset: 0xBBC690 VA: 0x180BBE090
	private int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, out int charCount, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0xBBE010 Offset: 0xBBC610 VA: 0x180BBE010
	private int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0xBBDC30 Offset: 0xBBC230 VA: 0x180BBDC30
	private int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0xBBDC00 Offset: 0xBBC200 VA: 0x180BBDC00
	private int ParseName() { }

	// RVA: 0xBBF0C0 Offset: 0xBBD6C0 VA: 0x180BBF0C0
	private int ParseQName(out int colonPos) { }

	// RVA: 0xBBF0E0 Offset: 0xBBD6E0 VA: 0x180BBF0E0
	private int ParseQName(bool isQName, int startOffset, out int colonPos) { }

	// RVA: 0xBC2390 Offset: 0xBC0990 VA: 0x180BC2390
	private bool ReadDataInName(ref int pos) { }

	// RVA: 0xBBD9F0 Offset: 0xBBBFF0 VA: 0x180BBD9F0
	private string ParseEntityName() { }

	// RVA: 0xBB3ED0 Offset: 0xBB24D0 VA: 0x180BB3ED0
	private XmlTextReaderImpl.NodeData AddNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0xBB4080 Offset: 0xBB2680 VA: 0x180BB4080
	private XmlTextReaderImpl.NodeData AllocNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0xBB2990 Offset: 0xBB0F90 VA: 0x180BB2990
	private XmlTextReaderImpl.NodeData AddAttributeNoChecks(string name, int attrDepth) { }

	// RVA: 0xBB2A20 Offset: 0xBB1020 VA: 0x180BB2A20
	private XmlTextReaderImpl.NodeData AddAttribute(int endNamePos, int colonPos) { }

	// RVA: 0xBB2C50 Offset: 0xBB1250 VA: 0x180BB2C50
	private XmlTextReaderImpl.NodeData AddAttribute(string localName, string prefix, string nameWPrefix) { }

	// RVA: 0xBC14D0 Offset: 0xBBFAD0 VA: 0x180BC14D0
	private void PopElementContext() { }

	// RVA: 0xBB4DF0 Offset: 0xBB33F0 VA: 0x180BB4DF0
	private void OnNewLine(int pos) { }

	// RVA: 0xBB9550 Offset: 0xBB7B50 VA: 0x180BB9550
	private void OnEof() { }

	// RVA: 0xBB8D60 Offset: 0xBB7360 VA: 0x180BB8D60
	private string LookupNamespace(XmlTextReaderImpl.NodeData node) { }

	// RVA: 0xBB3C30 Offset: 0xBB2230 VA: 0x180BB3C30
	private void AddNamespace(string prefix, string uri, XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0xBC3680 Offset: 0xBC1C80 VA: 0x180BC3680
	private void ResetAttributes() { }

	// RVA: 0xBB6610 Offset: 0xBB4C10 VA: 0x180BB6610
	private void FullAttributeCleanup() { }

	// RVA: 0xBC1F20 Offset: 0xBC0520 VA: 0x180BC1F20
	private void PushXmlContext() { }

	// RVA: 0xBC16A0 Offset: 0xBBFCA0 VA: 0x180BC16A0
	private void PopXmlContext() { }

	// RVA: 0xBB6E20 Offset: 0xBB5420 VA: 0x180BB6E20
	private XmlNodeType GetWhitespaceType() { }

	// RVA: 0xBB6DC0 Offset: 0xBB53C0 VA: 0x180BB6DC0
	private XmlNodeType GetTextNodeType(int orChars) { }

	// RVA: 0xBC1740 Offset: 0xBBFD40 VA: 0x180BC1740
	private void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName) { }

	// RVA: 0xBB9960 Offset: 0xBB7F60 VA: 0x180BB9960
	private bool OpenAndPush(Uri uri) { }

	// RVA: 0xBC1A50 Offset: 0xBC0050 VA: 0x180BC1A50
	private bool PushExternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0xBC1C50 Offset: 0xBC0250 VA: 0x180BC1C50
	private void PushInternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0xBC1540 Offset: 0xBBFB40 VA: 0x180BC1540
	private void PopEntity() { }

	// RVA: 0xBC34A0 Offset: 0xBC1AA0 VA: 0x180BC34A0
	private void RegisterEntity(IDtdEntityInfo entity) { }

	// RVA: 0xBC6330 Offset: 0xBC4930 VA: 0x180BC6330
	private void UnregisterEntity() { }

	// RVA: 0xBC1DC0 Offset: 0xBC03C0 VA: 0x180BC1DC0
	private void PushParsingState() { }

	// RVA: 0xBC15D0 Offset: 0xBBFBD0 VA: 0x180BC15D0
	private void PopParsingState() { }

	// RVA: 0xBB7790 Offset: 0xBB5D90 VA: 0x180BB7790
	private int IncrementalRead() { }

	// RVA: 0xBB5B70 Offset: 0xBB4170 VA: 0x180BB5B70
	private void FinishIncrementalRead() { }

	// RVA: 0xBBDB70 Offset: 0xBBC170 VA: 0x180BBDB70
	private bool ParseFragmentAttribute() { }

	// RVA: 0xBBA030 Offset: 0xBB8630 VA: 0x180BBA030
	private bool ParseAttributeValueChunk() { }

	// RVA: 0xBC03A0 Offset: 0xBBE9A0 VA: 0x180BC03A0
	private void ParseXmlDeclarationFragment() { }

	// RVA: 0xBC5A50 Offset: 0xBC4050 VA: 0x180BC5A50
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0xBC5A40 Offset: 0xBC4040 VA: 0x180BC5A40
	private void ThrowUnexpectedToken(string expectedToken1) { }

	// RVA: 0xBC58A0 Offset: 0xBC3EA0 VA: 0x180BC58A0
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0xBC58E0 Offset: 0xBC3EE0 VA: 0x180BC58E0
	private void ThrowUnexpectedToken(string expectedToken1, string expectedToken2) { }

	// RVA: 0xBC02A0 Offset: 0xBBE8A0 VA: 0x180BC02A0
	private string ParseUnexpectedToken(int pos) { }

	// RVA: 0xBC02B0 Offset: 0xBBE8B0 VA: 0x180BC02B0
	private string ParseUnexpectedToken() { }

	// RVA: 0xBC5390 Offset: 0xBC3990 VA: 0x180BC5390
	private void ThrowExpectingWhitespace(int pos) { }

	// RVA: 0xBB6BD0 Offset: 0xBB51D0 VA: 0x180BB6BD0
	private int GetIndexOfAttributeWithoutPrefix(string name) { }

	// RVA: 0xBB6AF0 Offset: 0xBB50F0 VA: 0x180BB6AF0
	private int GetIndexOfAttributeWithPrefix(string name) { }

	// RVA: 0xBC6480 Offset: 0xBC4A80 VA: 0x180BC6480
	private bool ZeroEndingStream(int pos) { }

	// RVA: 0xBBC7B0 Offset: 0xBBADB0 VA: 0x180BBC7B0
	private void ParseDtdFromParserContext() { }

	// RVA: 0xBB9310 Offset: 0xBB7910 VA: 0x180BB9310
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

	// RVA: 0xBC3FC0 Offset: 0xBC25C0 VA: 0x180BC3FC0
	private void SetupFromParserContext(XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0x900630 Offset: 0x8FEC30 VA: 0x180900630 Slot: 52
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0xBC3BB0 Offset: 0xBC21B0 VA: 0x180BC3BB0
	internal void SetDtdInfo(IDtdInfo newDtdInfo) { }

	// RVA: 0xBC86C0 Offset: 0xBC6CC0 VA: 0x180BC86C0
	internal void set_ValidationEventHandling(IValidationEventHandling value) { }

	// RVA: 0xBC86A0 Offset: 0xBC6CA0 VA: 0x180BC86A0
	internal void set_OnDefaultAttributeUse(XmlTextReaderImpl.OnDefaultAttributeUseDelegate value) { }

	// RVA: 0xBC8860 Offset: 0xBC6E60 VA: 0x180BC8860
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x907650 Offset: 0x905C50 VA: 0x180907650
	internal XmlNodeType get_FragmentType() { }

	// RVA: 0xBB4720 Offset: 0xBB2D20 VA: 0x180BB4720
	internal void ChangeCurrentNodeType(XmlNodeType newNodeType) { }

	// RVA: 0xBB6D20 Offset: 0xBB5320 VA: 0x180BB6D20
	internal XmlResolver GetResolver() { }

	// RVA: 0xBC8370 Offset: 0xBC6970 VA: 0x180BC8370
	internal void set_InternalSchemaType(object value) { }

	// RVA: 0xBC7AC0 Offset: 0xBC60C0 VA: 0x180BC7AC0
	internal object get_InternalTypedValue() { }

	// RVA: 0xBC83A0 Offset: 0xBC69A0 VA: 0x180BC83A0
	internal void set_InternalTypedValue(object value) { }

	// RVA: 0xBC8110 Offset: 0xBC6710 VA: 0x180BC8110
	internal bool get_StandAlone() { }

	// RVA: 0xBC7A40 Offset: 0xBC6040 VA: 0x180BC7A40 Slot: 51
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0xBC7A70 Offset: 0xBC6070 VA: 0x180BC7A70
	internal bool get_V1Compat() { }

	// RVA: 0xBB2DC0 Offset: 0xBB13C0 VA: 0x180BB2DC0
	private bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, XmlTextReaderImpl.NodeData[] nameSortedNodeData) { }

	// RVA: 0xBB33D0 Offset: 0xBB19D0 VA: 0x180BB33D0
	internal bool AddDefaultAttributeNonDtd(SchemaAttDef attrDef) { }

	// RVA: 0xBB3100 Offset: 0xBB1700 VA: 0x180BB3100
	private XmlTextReaderImpl.NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute) { }

	// RVA: 0xBC82D0 Offset: 0xBC68D0 VA: 0x180BC82D0
	internal void set_DisableUndeclaredEntityCheck(bool value) { }

	// RVA: 0xBC6390 Offset: 0xBC4990 VA: 0x180BC6390
	private bool UriEqual(Uri uri1, string uri1Str, string uri2Str, XmlResolver resolver) { }

	// RVA: 0xBC3390 Offset: 0xBC1990 VA: 0x180BC3390
	private void RegisterConsumedCharacters(long characters, bool inEntityReference) { }

	// RVA: 0xBC4F80 Offset: 0xBC3580 VA: 0x180BC4F80
	internal static string StripSpaces(string value) { }

	// RVA: 0xBC4E20 Offset: 0xBC3420 VA: 0x180BC4E20
	internal static void StripSpaces(char[] value, int index, ref int len) { }

	// RVA: 0xBB46F0 Offset: 0xBB2CF0 VA: 0x180BB46F0
	internal static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count) { }

	// RVA: 0xBB4710 Offset: 0xBB2D10 VA: 0x180BB4710
	internal static void BlockCopy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count) { }

}

private enum XmlTextReaderImpl.ParsingFunction // TypeDefIndex: 1893
{	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.ParsingFunction ElementContent = 0;
	public const XmlTextReaderImpl.ParsingFunction NoData = 1;
	public const XmlTextReaderImpl.ParsingFunction OpenUrl = 2;
	public const XmlTextReaderImpl.ParsingFunction SwitchToInteractive = 3;
	public const XmlTextReaderImpl.ParsingFunction SwitchToInteractiveXmlDecl = 4;
	public const XmlTextReaderImpl.ParsingFunction DocumentContent = 5;
	public const XmlTextReaderImpl.ParsingFunction MoveToElementContent = 6;
	public const XmlTextReaderImpl.ParsingFunction PopElementContext = 7;
	public const XmlTextReaderImpl.ParsingFunction PopEmptyElementContext = 8;
	public const XmlTextReaderImpl.ParsingFunction ResetAttributesRootLevel = 9;
	public const XmlTextReaderImpl.ParsingFunction Error = 10;
	public const XmlTextReaderImpl.ParsingFunction Eof = 11;
	public const XmlTextReaderImpl.ParsingFunction ReaderClosed = 12;
	public const XmlTextReaderImpl.ParsingFunction EntityReference = 13;
	public const XmlTextReaderImpl.ParsingFunction InIncrementalRead = 14;
	public const XmlTextReaderImpl.ParsingFunction FragmentAttribute = 15;
	public const XmlTextReaderImpl.ParsingFunction ReportEndEntity = 16;
	public const XmlTextReaderImpl.ParsingFunction AfterResolveEntityInContent = 17;
	public const XmlTextReaderImpl.ParsingFunction AfterResolveEmptyEntityInContent = 18;
	public const XmlTextReaderImpl.ParsingFunction XmlDeclarationFragment = 19;
	public const XmlTextReaderImpl.ParsingFunction GoToEof = 20;
	public const XmlTextReaderImpl.ParsingFunction PartialTextValue = 21;
	public const XmlTextReaderImpl.ParsingFunction InReadAttributeValue = 22;
	public const XmlTextReaderImpl.ParsingFunction InReadValueChunk = 23;
	public const XmlTextReaderImpl.ParsingFunction InReadContentAsBinary = 24;
	public const XmlTextReaderImpl.ParsingFunction InReadElementContentAsBinary = 25;

}

private enum XmlTextReaderImpl.ParsingMode // TypeDefIndex: 1894
{	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.ParsingMode Full = 0;
	public const XmlTextReaderImpl.ParsingMode SkipNode = 1;
	public const XmlTextReaderImpl.ParsingMode SkipContent = 2;

}

private enum XmlTextReaderImpl.EntityType // TypeDefIndex: 1895
{	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.EntityType CharacterDec = 0;
	public const XmlTextReaderImpl.EntityType CharacterHex = 1;
	public const XmlTextReaderImpl.EntityType CharacterNamed = 2;
	public const XmlTextReaderImpl.EntityType Expanded = 3;
	public const XmlTextReaderImpl.EntityType Skipped = 4;
	public const XmlTextReaderImpl.EntityType FakeExpanded = 5;
	public const XmlTextReaderImpl.EntityType Unexpanded = 6;
	public const XmlTextReaderImpl.EntityType ExpandedInAttribute = 7;

}

private enum XmlTextReaderImpl.EntityExpandType // TypeDefIndex: 1896
{	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.EntityExpandType All = 0;
	public const XmlTextReaderImpl.EntityExpandType OnlyGeneral = 1;
	public const XmlTextReaderImpl.EntityExpandType OnlyCharacter = 2;

}

private enum XmlTextReaderImpl.IncrementalReadState // TypeDefIndex: 1897
{	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.IncrementalReadState Text = 0;
	public const XmlTextReaderImpl.IncrementalReadState StartTag = 1;
	public const XmlTextReaderImpl.IncrementalReadState PI = 2;
	public const XmlTextReaderImpl.IncrementalReadState CDATA = 3;
	public const XmlTextReaderImpl.IncrementalReadState Comment = 4;
	public const XmlTextReaderImpl.IncrementalReadState Attributes = 5;
	public const XmlTextReaderImpl.IncrementalReadState AttributeValue = 6;
	public const XmlTextReaderImpl.IncrementalReadState ReadData = 7;
	public const XmlTextReaderImpl.IncrementalReadState EndElement = 8;
	public const XmlTextReaderImpl.IncrementalReadState End = 9;
	public const XmlTextReaderImpl.IncrementalReadState ReadValueChunk_OnCachedValue = 10;
	public const XmlTextReaderImpl.IncrementalReadState ReadValueChunk_OnPartialValue = 11;
	public const XmlTextReaderImpl.IncrementalReadState ReadContentAsBinary_OnCachedValue = 12;
	public const XmlTextReaderImpl.IncrementalReadState ReadContentAsBinary_OnPartialValue = 13;
	public const XmlTextReaderImpl.IncrementalReadState ReadContentAsBinary_End = 14;

}

private class XmlTextReaderImpl.LaterInitParam // TypeDefIndex: 1898
{	// Fields
	public bool useAsync; // 0x10
	public Stream inputStream; // 0x18
	public byte[] inputBytes; // 0x20
	public int inputByteCount; // 0x28
	public Uri inputbaseUri; // 0x30
	public string inputUriStr; // 0x38
	public XmlResolver inputUriResolver; // 0x40
	public XmlParserContext inputContext; // 0x48
	public TextReader inputTextReader; // 0x50
	public XmlTextReaderImpl.InitInputType initType; // 0x58

	// Methods

	// RVA: 0x1317A90 Offset: 0x1316090 VA: 0x181317A90
	public void .ctor() { }

}

private enum XmlTextReaderImpl.InitInputType // TypeDefIndex: 1899
{	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.InitInputType UriString = 0;
	public const XmlTextReaderImpl.InitInputType Stream = 1;
	public const XmlTextReaderImpl.InitInputType TextReader = 2;
	public const XmlTextReaderImpl.InitInputType Invalid = 3;

}

private struct XmlTextReaderImpl.ParsingState // TypeDefIndex: 1900
{	// Fields
	internal char[] chars; // 0x0
	internal int charPos; // 0x8
	internal int charsUsed; // 0xC
	internal Encoding encoding; // 0x10
	internal bool appendMode; // 0x18
	internal Stream stream; // 0x20
	internal Decoder decoder; // 0x28
	internal byte[] bytes; // 0x30
	internal int bytePos; // 0x38
	internal int bytesUsed; // 0x3C
	internal TextReader textReader; // 0x40
	internal int lineNo; // 0x48
	internal int lineStartPos; // 0x4C
	internal string baseUriStr; // 0x50
	internal Uri baseUri; // 0x58
	internal bool isEof; // 0x60
	internal bool isStreamEof; // 0x61
	internal IDtdEntityInfo entity; // 0x68
	internal int entityId; // 0x70
	internal bool eolNormalized; // 0x74
	internal bool entityResolvedManually; // 0x75

	// Properties
	internal int LineNo { get; }
	internal int LinePos { get; }

	// Methods

	// RVA: 0x1E1440 Offset: 0x1E0840 VA: 0x1801E1440
	internal void Clear() { }

	// RVA: 0x1E1520 Offset: 0x1E0920 VA: 0x1801E1520
	internal void Close(bool closeInput) { }

	// RVA: 0x1E0F10 Offset: 0x1E0310 VA: 0x1801E0F10
	internal int get_LineNo() { }

	// RVA: 0x1E1560 Offset: 0x1E0960 VA: 0x1801E1560
	internal int get_LinePos() { }

}

private class XmlTextReaderImpl.XmlContext // TypeDefIndex: 1901
{	// Fields
	internal XmlSpace xmlSpace; // 0x10
	internal string xmlLang; // 0x18
	internal string defaultNamespace; // 0x20
	internal XmlTextReaderImpl.XmlContext previousContext; // 0x28

	// Methods

	// RVA: 0x1318C90 Offset: 0x1317290 VA: 0x181318C90
	internal void .ctor() { }

	// RVA: 0x1318D20 Offset: 0x1317320 VA: 0x181318D20
	internal void .ctor(XmlTextReaderImpl.XmlContext previousContext) { }

}

private class XmlTextReaderImpl.NoNamespaceManager : XmlNamespaceManager // TypeDefIndex: 1902
{	// Properties
	public override string DefaultNamespace { get; }

	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0x1317B80 Offset: 0x1316180 VA: 0x181317B80 Slot: 9
	public override string get_DefaultNamespace() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	public override void PushScope() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 11
	public override bool PopScope() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	public override void AddNamespace(string prefix, string uri) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 13
	public override void RemoveNamespace(string prefix, string uri) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 14
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 15
	public override IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1317B40 Offset: 0x1316140 VA: 0x181317B40 Slot: 16
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 17
	public override string LookupPrefix(string uri) { }

}

internal class XmlTextReaderImpl.DtdParserProxy : IDtdParserAdapterV1, IDtdParserAdapterWithValidation, IDtdParserAdapter // TypeDefIndex: 1903
{	// Fields
	private XmlTextReaderImpl reader; // 0x10

	// Properties
	private XmlNameTable System.Xml.IDtdParserAdapter.NameTable { get; }
	private IXmlNamespaceResolver System.Xml.IDtdParserAdapter.NamespaceResolver { get; }
	private Uri System.Xml.IDtdParserAdapter.BaseUri { get; }
	private bool System.Xml.IDtdParserAdapter.IsEof { get; }
	private char[] System.Xml.IDtdParserAdapter.ParsingBuffer { get; }
	private int System.Xml.IDtdParserAdapter.ParsingBufferLength { get; }
	private int System.Xml.IDtdParserAdapter.CurrentPosition { get; set; }
	private int System.Xml.IDtdParserAdapter.EntityStackLength { get; }
	private bool System.Xml.IDtdParserAdapter.IsEntityEolNormalized { get; }
	private int System.Xml.IDtdParserAdapter.LineNo { get; }
	private int System.Xml.IDtdParserAdapter.LineStartPosition { get; }
	private bool System.Xml.IDtdParserAdapterWithValidation.DtdValidation { get; }
	private IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.ValidationEventHandling { get; }
	private bool System.Xml.IDtdParserAdapterV1.Normalization { get; }
	private bool System.Xml.IDtdParserAdapterV1.Namespaces { get; }
	private bool System.Xml.IDtdParserAdapterV1.V1CompatibilityMode { get; }

	// Methods

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	internal void .ctor(XmlTextReaderImpl reader) { }

	// RVA: 0x1317980 Offset: 0x1315F80 VA: 0x181317980 Slot: 9
	private XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable() { }

	// RVA: 0x13179A0 Offset: 0x1315FA0 VA: 0x1813179A0 Slot: 10
	private IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver() { }

	// RVA: 0x13178A0 Offset: 0x1315EA0 VA: 0x1813178A0 Slot: 11
	private Uri System.Xml.IDtdParserAdapter.get_BaseUri() { }

	// RVA: 0x1317920 Offset: 0x1315F20 VA: 0x181317920 Slot: 18
	private bool System.Xml.IDtdParserAdapter.get_IsEof() { }

	// RVA: 0x13179E0 Offset: 0x1315FE0 VA: 0x1813179E0 Slot: 12
	private char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer() { }

	// RVA: 0x13179C0 Offset: 0x1315FC0 VA: 0x1813179C0 Slot: 13
	private int System.Xml.IDtdParserAdapter.get_ParsingBufferLength() { }

	// RVA: 0x13178C0 Offset: 0x1315EC0 VA: 0x1813178C0 Slot: 14
	private int System.Xml.IDtdParserAdapter.get_CurrentPosition() { }

	// RVA: 0x1317A00 Offset: 0x1316000 VA: 0x181317A00 Slot: 15
	private void System.Xml.IDtdParserAdapter.set_CurrentPosition(int value) { }

	// RVA: 0x13178E0 Offset: 0x1315EE0 VA: 0x1813178E0 Slot: 19
	private int System.Xml.IDtdParserAdapter.get_EntityStackLength() { }

	// RVA: 0x1317900 Offset: 0x1315F00 VA: 0x181317900 Slot: 20
	private bool System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized() { }

	// RVA: 0x13176E0 Offset: 0x1315CE0 VA: 0x1813176E0 Slot: 22
	private void System.Xml.IDtdParserAdapter.OnNewLine(int pos) { }

	// RVA: 0x1317940 Offset: 0x1315F40 VA: 0x181317940 Slot: 16
	private int System.Xml.IDtdParserAdapter.get_LineNo() { }

	// RVA: 0x1317960 Offset: 0x1315F60 VA: 0x181317960 Slot: 17
	private int System.Xml.IDtdParserAdapter.get_LineStartPosition() { }

	// RVA: 0x1317860 Offset: 0x1315E60 VA: 0x181317860 Slot: 21
	private int System.Xml.IDtdParserAdapter.ReadData() { }

	// RVA: 0x13177A0 Offset: 0x1315DA0 VA: 0x1813177A0 Slot: 23
	private int System.Xml.IDtdParserAdapter.ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1317780 Offset: 0x1315D80 VA: 0x181317780 Slot: 24
	private int System.Xml.IDtdParserAdapter.ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x13177C0 Offset: 0x1315DC0 VA: 0x1813177C0 Slot: 25
	private void System.Xml.IDtdParserAdapter.ParsePI(StringBuilder sb) { }

	// RVA: 0x1317760 Offset: 0x1315D60 VA: 0x181317760 Slot: 26
	private void System.Xml.IDtdParserAdapter.ParseComment(StringBuilder sb) { }

	// RVA: 0x1317800 Offset: 0x1315E00 VA: 0x181317800 Slot: 27
	private bool System.Xml.IDtdParserAdapter.PushEntity(IDtdEntityInfo entity, out int entityId) { }

	// RVA: 0x13177E0 Offset: 0x1315DE0 VA: 0x1813177E0 Slot: 28
	private bool System.Xml.IDtdParserAdapter.PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	// RVA: 0x1317820 Offset: 0x1315E20 VA: 0x181317820 Slot: 29
	private bool System.Xml.IDtdParserAdapter.PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0x1317840 Offset: 0x1315E40 VA: 0x181317840 Slot: 30
	private void System.Xml.IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0x1317880 Offset: 0x1315E80 VA: 0x181317880 Slot: 33
	private void System.Xml.IDtdParserAdapter.Throw(Exception e) { }

	// RVA: 0x1317730 Offset: 0x1315D30 VA: 0x181317730 Slot: 31
	private void System.Xml.IDtdParserAdapter.OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0x1317700 Offset: 0x1315D00 VA: 0x181317700 Slot: 32
	private void System.Xml.IDtdParserAdapter.OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0x13176A0 Offset: 0x1315CA0 VA: 0x1813176A0 Slot: 7
	private bool System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation() { }

	// RVA: 0x13176C0 Offset: 0x1315CC0 VA: 0x1813176C0 Slot: 8
	private IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling() { }

	// RVA: 0xBC9330 Offset: 0xBC7930 VA: 0x180BC9330 Slot: 5
	private bool System.Xml.IDtdParserAdapterV1.get_Normalization() { }

	// RVA: 0xBC9310 Offset: 0xBC7910 VA: 0x180BC9310 Slot: 6
	private bool System.Xml.IDtdParserAdapterV1.get_Namespaces() { }

	// RVA: 0x1317680 Offset: 0x1315C80 VA: 0x181317680 Slot: 4
	private bool System.Xml.IDtdParserAdapterV1.get_V1CompatibilityMode() { }

}

private class XmlTextReaderImpl.NodeData : IComparable // TypeDefIndex: 1904
{	// Fields
	private static XmlTextReaderImpl.NodeData s_None; // 0x0
	internal XmlNodeType type; // 0x10
	internal string localName; // 0x18
	internal string prefix; // 0x20
	internal string ns; // 0x28
	internal string nameWPrefix; // 0x30
	private string value; // 0x38
	private char[] chars; // 0x40
	private int valueStartPos; // 0x48
	private int valueLength; // 0x4C
	internal LineInfo lineInfo; // 0x50
	internal LineInfo lineInfo2; // 0x58
	internal char quoteChar; // 0x60
	internal int depth; // 0x64
	private bool isEmptyOrDefault; // 0x68
	internal int entityId; // 0x6C
	internal bool xmlContextPushed; // 0x70
	internal XmlTextReaderImpl.NodeData nextAttrValueChunk; // 0x78
	internal object schemaType; // 0x80
	internal object typedValue; // 0x88

	// Properties
	internal static XmlTextReaderImpl.NodeData None { get; }
	internal int LineNo { get; }
	internal int LinePos { get; }
	internal bool IsEmptyElement { get; set; }
	internal bool IsDefaultAttribute { get; set; }
	internal bool ValueBuffered { get; }
	internal string StringValue { get; }

	// Methods

	// RVA: 0x13184F0 Offset: 0x1316AF0 VA: 0x1813184F0
	internal static XmlTextReaderImpl.NodeData get_None() { }

	// RVA: 0x1318410 Offset: 0x1316A10 VA: 0x181318410
	internal void .ctor() { }

	// RVA: 0x8D9520 Offset: 0x8D7B20 VA: 0x1808D9520
	internal int get_LineNo() { }

	// RVA: 0x5DE8B0 Offset: 0x5DCEB0 VA: 0x1805DE8B0
	internal int get_LinePos() { }

	// RVA: 0x13184E0 Offset: 0x1316AE0 VA: 0x1813184E0
	internal bool get_IsEmptyElement() { }

	// RVA: 0xE6A680 Offset: 0xE68C80 VA: 0x180E6A680
	internal void set_IsEmptyElement(bool value) { }

	// RVA: 0x13184D0 Offset: 0x1316AD0 VA: 0x1813184D0
	internal bool get_IsDefaultAttribute() { }

	// RVA: 0xE6A680 Offset: 0xE68C80 VA: 0x180E6A680
	internal void set_IsDefaultAttribute(bool value) { }

	// RVA: 0x1318680 Offset: 0x1316C80 VA: 0x181318680
	internal bool get_ValueBuffered() { }

	// RVA: 0x1318630 Offset: 0x1316C30 VA: 0x181318630
	internal string get_StringValue() { }

	// RVA: 0x13183C0 Offset: 0x13169C0 VA: 0x1813183C0
	internal void TrimSpacesInValue() { }

	// RVA: 0x1317C60 Offset: 0x1316260 VA: 0x181317C60
	internal void Clear(XmlNodeType type) { }

	// RVA: 0x1317BC0 Offset: 0x13161C0 VA: 0x181317BC0
	internal void ClearName() { }

	// RVA: 0x1317FD0 Offset: 0x13165D0 VA: 0x181317FD0
	internal void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0x1317FC0 Offset: 0x13165C0 VA: 0x181317FC0
	internal void SetLineInfo2(int lineNo, int linePos) { }

	// RVA: 0x13181A0 Offset: 0x13167A0 VA: 0x1813181A0
	internal void SetValueNode(XmlNodeType type, string value) { }

	// RVA: 0x13181E0 Offset: 0x13167E0 VA: 0x1813181E0
	internal void SetValueNode(XmlNodeType type, char[] chars, int startPos, int len) { }

	// RVA: 0x1317FE0 Offset: 0x13165E0 VA: 0x181317FE0
	internal void SetNamedNode(XmlNodeType type, string localName) { }

	// RVA: 0x13180D0 Offset: 0x13166D0 VA: 0x1813180D0
	internal void SetNamedNode(XmlNodeType type, string localName, string prefix, string nameWPrefix) { }

	// RVA: 0x13182A0 Offset: 0x13168A0 VA: 0x1813182A0
	internal void SetValue(string value) { }

	// RVA: 0x1318240 Offset: 0x1316840 VA: 0x181318240
	internal void SetValue(char[] chars, int startPos, int len) { }

	// RVA: 0x1317F50 Offset: 0x1316550 VA: 0x181317F50
	internal void OnBufferInvalidated() { }

	// RVA: 0x1317D70 Offset: 0x1316370 VA: 0x181317D70
	internal void CopyTo(int valueOffset, StringBuilder sb) { }

	// RVA: 0x1317D10 Offset: 0x1316310 VA: 0x181317D10
	internal int CopyTo(int valueOffset, char[] buffer, int offset, int length) { }

	// RVA: 0x1317EA0 Offset: 0x13164A0 VA: 0x181317EA0
	internal string GetNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x1317E00 Offset: 0x1316400 VA: 0x181317E00
	internal string CreateNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x13182C0 Offset: 0x13168C0 VA: 0x1813182C0 Slot: 4
	private int System.IComparable.CompareTo(object obj) { }

}

private class XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer : IComparer<object> // TypeDefIndex: 1905
{	// Fields
	private static IComparer<object> s_instance; // 0x13F50

	// Properties
	internal static IComparer<object> Instance { get; }

	// Methods

	// RVA: 0x1317620 Offset: 0x1315C20 VA: 0x181317620
	internal static IComparer<object> get_Instance() { }

	// RVA: 0x1317360 Offset: 0x1315960 VA: 0x181317360 Slot: 4
	public int Compare(object x, object y) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13175C0 Offset: 0x1315BC0 VA: 0x1813175C0
	private static void .cctor() { }

}

internal sealed class XmlTextReaderImpl.OnDefaultAttributeUseDelegate : MulticastDelegate // TypeDefIndex: 1906
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4D50 Offset: 0xAE3350 VA: 0x180AE4D50 Slot: 12
	public virtual void Invoke(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public class XmlTextWriter : XmlWriter // TypeDefIndex: 1908
{	// Fields
	private TextWriter textWriter; // 0x18
	private XmlTextEncoder xmlEncoder; // 0x20
	private Encoding encoding; // 0x28
	private Formatting formatting; // 0x30
	private bool indented; // 0x34
	private int indentation; // 0x38
	private char indentChar; // 0x3C
	private XmlTextWriter.TagInfo[] stack; // 0x40
	private int top; // 0x48
	private XmlTextWriter.State[] stateTable; // 0x50
	private XmlTextWriter.State currentState; // 0x58
	private XmlTextWriter.Token lastToken; // 0x5C
	private XmlTextWriterBase64Encoder base64Encoder; // 0x60
	private char quoteChar; // 0x68
	private char curQuoteChar; // 0x6A
	private bool namespaces; // 0x6C
	private XmlTextWriter.SpecialAttr specialAttr; // 0x70
	private string prefixForXmlNs; // 0x78
	private bool flush; // 0x80
	private XmlTextWriter.Namespace[] nsStack; // 0x88
	private int nsTop; // 0x90
	private Dictionary<string, int> nsHashtable; // 0x98
	private bool useNsHashtable; // 0xA0
	private XmlCharType xmlCharType; // 0xA8
	private static string[] stateName; // 0x0
	private static string[] tokenName; // 0x8
	private static readonly XmlTextWriter.State[] stateTableDefault; // 0x10
	private static readonly XmlTextWriter.State[] stateTableDocument; // 0x18

	// Properties
	public Stream BaseStream { get; }
	public bool Namespaces { set; }
	public Formatting Formatting { set; }
	public char QuoteChar { set; }
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0x131E470 Offset: 0x131CA70 VA: 0x18131E470
	internal void .ctor() { }

	// RVA: 0x131E370 Offset: 0x131C970 VA: 0x18131E370
	public void .ctor(Stream w, Encoding encoding) { }

	// RVA: 0x131E220 Offset: 0x131C820 VA: 0x18131E220
	public void .ctor(string filename, Encoding encoding) { }

	// RVA: 0x131E150 Offset: 0x131C750 VA: 0x18131E150
	public void .ctor(TextWriter w) { }

	// RVA: 0x131E5D0 Offset: 0x131CBD0 VA: 0x18131E5D0
	public Stream get_BaseStream() { }

	// RVA: 0x131E6E0 Offset: 0x131CCE0 VA: 0x18131E6E0
	public void set_Namespaces(bool value) { }

	// RVA: 0x131E6D0 Offset: 0x131CCD0 VA: 0x18131E6D0
	public void set_Formatting(Formatting value) { }

	// RVA: 0x131E760 Offset: 0x131CD60 VA: 0x18131E760
	public void set_QuoteChar(char value) { }

	// RVA: 0x131CB90 Offset: 0x131B190 VA: 0x18131CB90 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x131CB70 Offset: 0x131B170 VA: 0x18131CB70 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x131BA90 Offset: 0x131A090 VA: 0x18131BA90 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x131B680 Offset: 0x1319C80 VA: 0x18131B680 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x131CBA0 Offset: 0x131B1A0 VA: 0x18131CBA0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x131BC10 Offset: 0x131A210 VA: 0x18131BC10 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x131C120 Offset: 0x131A720 VA: 0x18131C120 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x131C420 Offset: 0x131AA20 VA: 0x18131C420 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x131BA10 Offset: 0x131A010 VA: 0x18131BA10 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x131B260 Offset: 0x1319860 VA: 0x18131B260 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x131B510 Offset: 0x1319B10 VA: 0x18131B510 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x131C130 Offset: 0x131A730 VA: 0x18131C130 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x131C070 Offset: 0x131A670 VA: 0x18131C070 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x131B3B0 Offset: 0x13199B0 VA: 0x18131B3B0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x131D270 Offset: 0x131B870 VA: 0x18131D270 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x131D110 Offset: 0x131B710 VA: 0x18131D110 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x131D1C0 Offset: 0x131B7C0 VA: 0x18131D1C0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x131B450 Offset: 0x1319A50 VA: 0x18131B450 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x131C360 Offset: 0x131A960 VA: 0x18131C360 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x131C2C0 Offset: 0x131A8C0 VA: 0x18131C2C0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x131B0A0 Offset: 0x13196A0 VA: 0x18131B0A0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x131B1B0 Offset: 0x13197B0 VA: 0x18131B1B0 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x131E660 Offset: 0x131CC60 VA: 0x18131E660 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x13196B0 Offset: 0x1317CB0 VA: 0x1813196B0 Slot: 28
	public override void Close() { }

	// RVA: 0x1319910 Offset: 0x1317F10 VA: 0x181319910 Slot: 29
	public override void Flush() { }

	// RVA: 0x131A440 Offset: 0x1318A40 VA: 0x18131A440 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x131AB20 Offset: 0x1319120 VA: 0x18131AB20
	private void StartDocument(int standalone) { }

	// RVA: 0x13190D0 Offset: 0x13176D0 VA: 0x1813190D0
	private void AutoComplete(XmlTextWriter.Token token) { }

	// RVA: 0x1319080 Offset: 0x1317680 VA: 0x181319080
	private void AutoCompleteAll() { }

	// RVA: 0x1319D50 Offset: 0x1318350 VA: 0x181319D50
	private void InternalWriteEndElement(bool longFormat) { }

	// RVA: 0x131BC20 Offset: 0x131A220 VA: 0x18131BC20
	private void WriteEndStartTag(bool empty) { }

	// RVA: 0x131B9C0 Offset: 0x1319FC0 VA: 0x18131B9C0
	private void WriteEndAttributeQuote() { }

	// RVA: 0x1319C60 Offset: 0x1318260 VA: 0x181319C60
	private void Indent(bool beforeEndElement) { }

	// RVA: 0x131A610 Offset: 0x1318C10 VA: 0x18131A610
	private void PushNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x1318DC0 Offset: 0x13173C0 VA: 0x181318DC0
	private void AddNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x1318F80 Offset: 0x1317580 VA: 0x181318F80
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x131A540 Offset: 0x1318B40 VA: 0x18131A540
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x1319940 Offset: 0x1317F40 VA: 0x181319940
	private string GeneratePrefix() { }

	// RVA: 0x131A0C0 Offset: 0x13186C0 VA: 0x18131A0C0
	private void InternalWriteProcessingInstruction(string name, string text) { }

	// RVA: 0x131A320 Offset: 0x1318920 VA: 0x18131A320
	private int LookupNamespace(string prefix) { }

	// RVA: 0x131A1C0 Offset: 0x13187C0 VA: 0x18131A1C0
	private int LookupNamespaceInCurrentScope(string prefix) { }

	// RVA: 0x13197D0 Offset: 0x1317DD0 VA: 0x1813197D0
	private string FindPrefix(string ns) { }

	// RVA: 0x131AD80 Offset: 0x1319380 VA: 0x18131AD80
	private void ValidateName(string name, bool isNCName) { }

	// RVA: 0x1319A30 Offset: 0x1318030 VA: 0x181319A30
	private void HandleSpecialAttribute() { }

	// RVA: 0x131AF80 Offset: 0x1319580 VA: 0x18131AF80
	private void VerifyPrefixXml(string prefix, string ns) { }

	// RVA: 0x131AA40 Offset: 0x1319040 VA: 0x18131AA40
	private void PushStack() { }

	// RVA: 0x13198E0 Offset: 0x1317EE0 VA: 0x1813198E0
	private void FlushEncoders() { }

	// RVA: 0x131D6C0 Offset: 0x131BCC0 VA: 0x18131D6C0
	private static void .cctor() { }

}

private enum XmlTextWriter.NamespaceState // TypeDefIndex: 1909
{	// Fields
	public int value__; // 0x0
	public const XmlTextWriter.NamespaceState Uninitialized = 0;
	public const XmlTextWriter.NamespaceState NotDeclaredButInScope = 1;
	public const XmlTextWriter.NamespaceState DeclaredButNotWrittenOut = 2;
	public const XmlTextWriter.NamespaceState DeclaredAndWrittenOut = 3;

}

private struct XmlTextWriter.TagInfo // TypeDefIndex: 1910
{	// Fields
	internal string name; // 0x0
	internal string prefix; // 0x8
	internal string defaultNs; // 0x10
	internal XmlTextWriter.NamespaceState defaultNsState; // 0x18
	internal XmlSpace xmlSpace; // 0x1C
	internal string xmlLang; // 0x20
	internal int prevNsTop; // 0x28
	internal int prefixCount; // 0x2C
	internal bool mixed; // 0x30

	// Methods

	// RVA: 0x1E1590 Offset: 0x1E0990 VA: 0x1801E1590
	internal void Init(int nsTop) { }

}

private struct XmlTextWriter.Namespace // TypeDefIndex: 1911
{	// Fields
	internal string prefix; // 0x0
	internal string ns; // 0x8
	internal bool declared; // 0x10
	internal int prevNsIndex; // 0x14

	// Methods

	// RVA: 0x1E1240 Offset: 0x1E0640 VA: 0x1801E1240
	internal void Set(string prefix, string ns, bool declared) { }

}

private enum XmlTextWriter.SpecialAttr // TypeDefIndex: 1912
{	// Fields
	public int value__; // 0x0
	public const XmlTextWriter.SpecialAttr None = 0;
	public const XmlTextWriter.SpecialAttr XmlSpace = 1;
	public const XmlTextWriter.SpecialAttr XmlLang = 2;
	public const XmlTextWriter.SpecialAttr XmlNs = 3;

}

private enum XmlTextWriter.State // TypeDefIndex: 1913
{	// Fields
	public int value__; // 0x0
	public const XmlTextWriter.State Start = 0;
	public const XmlTextWriter.State Prolog = 1;
	public const XmlTextWriter.State PostDTD = 2;
	public const XmlTextWriter.State Element = 3;
	public const XmlTextWriter.State Attribute = 4;
	public const XmlTextWriter.State Content = 5;
	public const XmlTextWriter.State AttrOnly = 6;
	public const XmlTextWriter.State Epilog = 7;
	public const XmlTextWriter.State Error = 8;
	public const XmlTextWriter.State Closed = 9;

}

private enum XmlTextWriter.Token // TypeDefIndex: 1914
{	// Fields
	public int value__; // 0x0
	public const XmlTextWriter.Token PI = 0;
	public const XmlTextWriter.Token Doctype = 1;
	public const XmlTextWriter.Token Comment = 2;
	public const XmlTextWriter.Token CData = 3;
	public const XmlTextWriter.Token StartElement = 4;
	public const XmlTextWriter.Token EndElement = 5;
	public const XmlTextWriter.Token LongEndElement = 6;
	public const XmlTextWriter.Token StartAttribute = 7;
	public const XmlTextWriter.Token EndAttribute = 8;
	public const XmlTextWriter.Token Content = 9;
	public const XmlTextWriter.Token Base64 = 10;
	public const XmlTextWriter.Token RawData = 11;
	public const XmlTextWriter.Token Whitespace = 12;
	public const XmlTextWriter.Token Empty = 13;

}

internal class XmlUtf8RawTextWriter : XmlRawWriter // TypeDefIndex: 1915
{	// Fields
	private readonly bool useAsync; // 0x28
	protected byte[] bufBytes; // 0x30
	protected Stream stream; // 0x38
	protected Encoding encoding; // 0x40
	protected XmlCharType xmlCharType; // 0x48
	protected int bufPos; // 0x50
	protected int textPos; // 0x54
	protected int contentPos; // 0x58
	protected int cdataPos; // 0x5C
	protected int attrEndPos; // 0x60
	protected int bufLen; // 0x64
	protected bool writeToNull; // 0x68
	protected bool hadDoubleBracket; // 0x69
	protected bool inAttributeValue; // 0x6A
	protected NewLineHandling newLineHandling; // 0x6C
	protected bool closeOutput; // 0x70
	protected bool omitXmlDeclaration; // 0x71
	protected string newLineChars; // 0x78
	protected bool checkCharacters; // 0x80
	protected XmlStandalone standalone; // 0x84
	protected XmlOutputMethod outputMethod; // 0x88
	protected bool autoXmlDeclaration; // 0x8C
	protected bool mergeCDataSections; // 0x8D

	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x1323270 Offset: 0x1321870 VA: 0x181323270
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x1323020 Offset: 0x1321620 VA: 0x181323020
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1322E40 Offset: 0x1321440 VA: 0x181322E40 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1322DD0 Offset: 0x13213D0 VA: 0x181322DD0 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x13217D0 Offset: 0x131FDD0 VA: 0x1813217D0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x13229C0 Offset: 0x1320FC0 VA: 0x1813229C0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1320480 Offset: 0x131EA80 VA: 0x181320480 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x1321E30 Offset: 0x1320430 VA: 0x181321E30 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1322140 Offset: 0x1320740 VA: 0x181322140 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1322870 Offset: 0x1320E70 VA: 0x181322870 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1321DE0 Offset: 0x13203E0 VA: 0x181321DE0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x11C2240 Offset: 0x11C0840 VA: 0x1811C2240 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1322AB0 Offset: 0x13210B0 VA: 0x181322AB0 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1322020 Offset: 0x1320620 VA: 0x181322020 Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1320E40 Offset: 0x131F440 VA: 0x181320E40 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1321640 Offset: 0x131FC40 VA: 0x181321640 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1322310 Offset: 0x1320910 VA: 0x181322310 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1322070 Offset: 0x1320670 VA: 0x181322070 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x13210F0 Offset: 0x131F6F0 VA: 0x1813210F0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1322BF0 Offset: 0x13211F0 VA: 0x181322BF0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1322BF0 Offset: 0x13211F0 VA: 0x181322BF0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1322C50 Offset: 0x1321250 VA: 0x181322C50 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x12F9820 Offset: 0x12F7E20 VA: 0x1812F9820 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x13227D0 Offset: 0x1320DD0 VA: 0x1813227D0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1322820 Offset: 0x1320E20 VA: 0x181322820 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x131F8E0 Offset: 0x131DEE0 VA: 0x18131F8E0 Slot: 28
	public override void Close() { }

	// RVA: 0x131FFC0 Offset: 0x131E5C0 VA: 0x18131FFC0 Slot: 29
	public override void Flush() { }

	// RVA: 0x131FD20 Offset: 0x131E320 VA: 0x18131FD20 Slot: 48
	protected virtual void FlushBuffer() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void FlushEncoder() { }

	// RVA: 0x1320840 Offset: 0x131EE40 VA: 0x181320840
	protected void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1321AF0 Offset: 0x13200F0 VA: 0x181321AF0
	protected void WriteElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1320430 Offset: 0x131EA30 VA: 0x181320430
	protected void RawText(string s) { }

	// RVA: 0x1320200 Offset: 0x131E800 VA: 0x181320200
	protected void RawText(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x1322480 Offset: 0x1320A80 VA: 0x181322480
	protected void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x13212E0 Offset: 0x131F8E0 VA: 0x1813212E0
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x1320B10 Offset: 0x131F110 VA: 0x181320B10
	protected void WriteCDataSection(string text) { }

	// RVA: 0x1320180 Offset: 0x131E780 VA: 0x181320180
	private static bool IsSurrogateByte(byte b) { }

	// RVA: 0x131FB90 Offset: 0x131E190 VA: 0x18131FB90
	private static byte* EncodeSurrogate(char* pSrc, char* pSrcEnd, byte* pDst) { }

	// RVA: 0x1320010 Offset: 0x131E610 VA: 0x181320010
	private byte* InvalidXmlChar(int ch, byte* pDst, bool entitize) { }

	// RVA: 0x131FA60 Offset: 0x131E060 VA: 0x18131FA60
	internal void EncodeChar(ref char* pSrc, char* pSrcEnd, ref byte* pDst) { }

	// RVA: 0x131FB40 Offset: 0x131E140 VA: 0x18131FB40
	internal static byte* EncodeMultibyteUTF8(int ch, byte* pDst) { }

	// RVA: 0x131F830 Offset: 0x131DE30 VA: 0x18131F830
	internal static void CharToUTF8(ref char* pSrc, char* pSrcEnd, ref byte* pDst) { }

	// RVA: 0x1322290 Offset: 0x1320890 VA: 0x181322290
	protected byte* WriteNewLine(byte* pDst) { }

	// RVA: 0x13201A0 Offset: 0x131E7A0 VA: 0x1813201A0
	protected static byte* LtEntity(byte* pDst) { }

	// RVA: 0x1320000 Offset: 0x131E600 VA: 0x181320000
	protected static byte* GtEntity(byte* pDst) { }

	// RVA: 0x131F770 Offset: 0x131DD70 VA: 0x18131F770
	protected static byte* AmpEntity(byte* pDst) { }

	// RVA: 0x13201B0 Offset: 0x131E7B0 VA: 0x1813201B0
	protected static byte* QuoteEntity(byte* pDst) { }

	// RVA: 0x13204D0 Offset: 0x131EAD0 VA: 0x1813204D0
	protected static byte* TabEntity(byte* pDst) { }

	// RVA: 0x1320190 Offset: 0x131E790 VA: 0x181320190
	protected static byte* LineFeedEntity(byte* pDst) { }

	// RVA: 0x131F780 Offset: 0x131DD80 VA: 0x18131F780
	protected static byte* CarriageReturnEntity(byte* pDst) { }

	// RVA: 0x131F790 Offset: 0x131DD90 VA: 0x18131F790
	private static byte* CharEntity(byte* pDst, char ch) { }

	// RVA: 0x13201E0 Offset: 0x131E7E0 VA: 0x1813201E0
	protected static byte* RawStartCData(byte* pDst) { }

	// RVA: 0x13201D0 Offset: 0x131E7D0 VA: 0x1813201D0
	protected static byte* RawEndCData(byte* pDst) { }

	// RVA: 0x13204E0 Offset: 0x131EAE0 VA: 0x1813204E0
	protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }

}

internal class XmlUtf8RawTextWriterIndent : XmlUtf8RawTextWriter // TypeDefIndex: 1916
{	// Fields
	protected int indentLevel; // 0x90
	protected bool newLineOnAttributes; // 0x94
	protected string indentChars; // 0x98
	protected bool mixedContent; // 0xA0
	private BitStack mixedContentStack; // 0xA8
	protected ConformanceLevel conformanceLevel; // 0xB0

	// Methods

	// RVA: 0x131F650 Offset: 0x131DC50 VA: 0x18131F650
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x131F030 Offset: 0x131D630 VA: 0x18131F030 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x131F4A0 Offset: 0x131DAA0 VA: 0x18131F4A0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x131EED0 Offset: 0x131D4D0 VA: 0x18131EED0 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x2FA5C0 Offset: 0x2F8BC0 VA: 0x1802FA5C0 Slot: 39
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x131F0A0 Offset: 0x131D6A0 VA: 0x18131F0A0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x131F200 Offset: 0x131D800 VA: 0x18131F200 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x131F440 Offset: 0x131DA40 VA: 0x18131F440 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x131EF70 Offset: 0x131D570 VA: 0x18131EF70 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x131EFF0 Offset: 0x131D5F0 VA: 0x18131EFF0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x131F330 Offset: 0x131D930 VA: 0x18131F330 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x131F130 Offset: 0x131D730 VA: 0x18131F130 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x131EF80 Offset: 0x131D580 VA: 0x18131EF80 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x131F640 Offset: 0x131DC40 VA: 0x18131F640 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x131F5D0 Offset: 0x131DBD0 VA: 0x18131F5D0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x131F5D0 Offset: 0x131DBD0 VA: 0x18131F5D0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x131EF90 Offset: 0x131D590 VA: 0x18131EF90 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x131F3E0 Offset: 0x131D9E0 VA: 0x18131F3E0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x131F380 Offset: 0x131D980 VA: 0x18131F380 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x131EF50 Offset: 0x131D550 VA: 0x18131EF50 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x131EDC0 Offset: 0x131D3C0 VA: 0x18131EDC0
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x131F290 Offset: 0x131D890 VA: 0x18131F290
	private void WriteIndent() { }

}

public class XmlValidatingReader : XmlReader // TypeDefIndex: 1917
{	// Fields
	private XmlValidatingReaderImpl impl; // 0x10

	// Properties
	public override XmlNodeType NodeType { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public bool Namespaces { get; }

	// Methods

	// RVA: 0xB19680 Offset: 0xB17C80 VA: 0x180B19680 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC9220 Offset: 0xBC7820 VA: 0x180BC9220 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0xBC92E0 Offset: 0xBC78E0 VA: 0x180BC92E0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0xBC9350 Offset: 0xBC7950 VA: 0x180BC9350 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xBC93B0 Offset: 0xBC79B0 VA: 0x180BC93B0 Slot: 11
	public override string get_Value() { }

	// RVA: 0xBC90D0 Offset: 0xBC76D0 VA: 0x180BC90D0 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xBC90A0 Offset: 0xBC76A0 VA: 0x180BC90A0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBC9190 Offset: 0xBC7790 VA: 0x180BC9190 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xB197D0 Offset: 0xB17DD0 VA: 0x180B197D0 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xBC8920 Offset: 0xBC6F20 VA: 0x180BC8920 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xBC8950 Offset: 0xBC6F50 VA: 0x180BC8950 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0xBC8980 Offset: 0xBC6F80 VA: 0x180BC8980 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xBC8A20 Offset: 0xBC7020 VA: 0x180BC8A20 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xBC8A80 Offset: 0xBC7080 VA: 0x180BC8A80 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xBC8AB0 Offset: 0xBC70B0 VA: 0x180BC8AB0 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0xBC8A50 Offset: 0xBC7050 VA: 0x180BC8A50 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0xBC8AE0 Offset: 0xBC70E0 VA: 0x180BC8AE0 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0xBC8B40 Offset: 0xBC7140 VA: 0x180BC8B40 Slot: 31
	public override bool Read() { }

	// RVA: 0xBC9130 Offset: 0xBC7730 VA: 0x180BC9130 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0xB9F640 Offset: 0xB9DC40 VA: 0x180B9F640 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xBC9250 Offset: 0xBC7850 VA: 0x180BC9250 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xBC89B0 Offset: 0xBC6FB0 VA: 0x180BC89B0 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0xBC8B70 Offset: 0xBC7170 VA: 0x180BC8B70 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x1324940 Offset: 0x1322F40 VA: 0x181324940
	public bool get_Namespaces() { }

}

internal sealed class XmlValidatingReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 1918
{	// Fields
	private XmlReader coreReader; // 0x10
	private XmlTextReaderImpl coreReaderImpl; // 0x18
	private IXmlNamespaceResolver coreReaderNSResolver; // 0x20
	private ValidationType validationType; // 0x28
	private BaseValidator validator; // 0x30
	private XmlSchemaCollection schemaCollection; // 0x38
	private bool processIdentityConstraints; // 0x40
	private XmlValidatingReaderImpl.ParsingFunction parsingFunction; // 0x44
	private XmlValidatingReaderImpl.ValidationEventHandling eventHandling; // 0x48
	private XmlParserContext parserContext; // 0x50
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x58
	private XmlReader outerReader; // 0x60
	private static XmlResolver s_tempResolver; // 0x0

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override ReadState ReadState { get; }
	public override bool EOF { get; }
	public override XmlNameTable NameTable { get; }
	public override int AttributeCount { get; }
	public override bool CanResolveEntity { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	internal ValidationType ValidationType { get; }
	internal XmlSchemaCollection Schemas { get; }
	internal bool Namespaces { get; }
	internal BaseValidator Validator { get; set; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal bool StandAlone { get; }
	internal object SchemaTypeObject { set; }
	internal object TypedValueObject { get; set; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x1324200 Offset: 0x1322800 VA: 0x181324200
	internal void .ctor(XmlReader reader, ValidationEventHandler settingsEventHandler, bool processIdentityConstraints) { }

	// RVA: 0x13247F0 Offset: 0x1322DF0 VA: 0x1813247F0 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0xB19680 Offset: 0xB17C80 VA: 0x180B19680 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC9280 Offset: 0xBC7880 VA: 0x180BC9280 Slot: 7
	public override string get_Name() { }

	// RVA: 0xBC9220 Offset: 0xBC7820 VA: 0x180BC9220 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0xBC92E0 Offset: 0xBC78E0 VA: 0x180BC92E0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0xBC9350 Offset: 0xBC7950 VA: 0x180BC9350 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xBC93B0 Offset: 0xBC79B0 VA: 0x180BC93B0 Slot: 11
	public override string get_Value() { }

	// RVA: 0xBC90D0 Offset: 0xBC76D0 VA: 0x180BC90D0 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xBC90A0 Offset: 0xBC76A0 VA: 0x180BC90A0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBC9190 Offset: 0xBC7790 VA: 0x180BC9190 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xBC9160 Offset: 0xBC7760 VA: 0x180BC9160 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xBC9380 Offset: 0xBC7980 VA: 0x180BC9380 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xBC9410 Offset: 0xBC7A10 VA: 0x180BC9410 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBC93E0 Offset: 0xBC79E0 VA: 0x180BC93E0 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x13247B0 Offset: 0x1322DB0 VA: 0x1813247B0 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xBC9130 Offset: 0xBC7730 VA: 0x180BC9130 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0xBC9250 Offset: 0xBC7850 VA: 0x180BC9250 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xB197D0 Offset: 0xB17DD0 VA: 0x180B197D0 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xBC8920 Offset: 0xBC6F20 VA: 0x180BC8920 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xBC8950 Offset: 0xBC6F50 VA: 0x180BC8950 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0xBC8980 Offset: 0xBC6F80 VA: 0x180BC8980 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x13236D0 Offset: 0x1321CD0 VA: 0x1813236D0 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1323720 Offset: 0x1321D20 VA: 0x181323720 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x13237B0 Offset: 0x1321DB0 VA: 0x1813237B0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1323800 Offset: 0x1321E00 VA: 0x181323800 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1323760 Offset: 0x1321D60 VA: 0x181323760 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x1323C40 Offset: 0x1322240 VA: 0x181323C40 Slot: 31
	public override bool Read() { }

	// RVA: 0x13233A0 Offset: 0x13219A0 VA: 0x1813233A0 Slot: 33
	public override void Close() { }

	// RVA: 0x1323580 Offset: 0x1321B80 VA: 0x181323580 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1323B10 Offset: 0x1322110 VA: 0x181323B10 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1323E60 Offset: 0x1322460 VA: 0x181323E60 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x1323610 Offset: 0x1321C10 VA: 0x181323610
	internal void MoveOffEntityReference() { }

	// RVA: 0x1323B70 Offset: 0x1322170 VA: 0x181323B70 Slot: 42
	public override string ReadString() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 53
	public bool HasLineInfo() { }

	// RVA: 0x1324620 Offset: 0x1322C20 VA: 0x181324620 Slot: 54
	public int get_LineNumber() { }

	// RVA: 0x13246C0 Offset: 0x1322CC0 VA: 0x1813246C0 Slot: 55
	public int get_LinePosition() { }

	// RVA: 0x13233E0 Offset: 0x13219E0 VA: 0x1813233E0 Slot: 56
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xBC5370 Offset: 0xBC3970 VA: 0x180BC5370 Slot: 57
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x13235B0 Offset: 0x1321BB0 VA: 0x1813235B0 Slot: 58
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x13233E0 Offset: 0x13219E0 VA: 0x1813233E0
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x13235B0 Offset: 0x1321BB0 VA: 0x1813235B0
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
	internal ValidationType get_ValidationType() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	internal XmlSchemaCollection get_Schemas() { }

	// RVA: 0x1324790 Offset: 0x1322D90 VA: 0x181324790
	internal bool get_Namespaces() { }

	// RVA: 0x1323850 Offset: 0x1321E50 VA: 0x181323850
	private void ParseDtdFromParserContext() { }

	// RVA: 0x1324180 Offset: 0x1322780 VA: 0x181324180
	private void ValidateDtd() { }

	// RVA: 0x1323DD0 Offset: 0x13223D0 VA: 0x181323DD0
	private void ResolveEntityInternally() { }

	// RVA: 0x1323EA0 Offset: 0x13224A0 VA: 0x181323EA0
	private void SetupValidation(ValidationType valType) { }

	// RVA: 0x13234A0 Offset: 0x1321AA0 VA: 0x1813234A0
	private XmlResolver GetResolver() { }

	// RVA: 0x1323A00 Offset: 0x1322000 VA: 0x181323A00
	private void ProcessCoreReaderEvent() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	internal BaseValidator get_Validator() { }

	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	internal void set_Validator(BaseValidator value) { }

	// RVA: 0x1324760 Offset: 0x1322D60 VA: 0x181324760 Slot: 51
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x13248C0 Offset: 0x1322EC0 VA: 0x1813248C0
	internal bool get_StandAlone() { }

	// RVA: 0x1324900 Offset: 0x1322F00 VA: 0x181324900
	internal void set_SchemaTypeObject(object value) { }

	// RVA: 0x13248E0 Offset: 0x1322EE0 VA: 0x1813248E0
	internal object get_TypedValueObject() { }

	// RVA: 0x1324920 Offset: 0x1322F20 VA: 0x181324920
	internal void set_TypedValueObject(object value) { }

	// RVA: 0x1323380 Offset: 0x1321980 VA: 0x181323380
	internal bool AddDefaultAttribute(SchemaAttDef attdef) { }

	// RVA: 0x13245F0 Offset: 0x1322BF0 VA: 0x1813245F0 Slot: 52
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0x1324040 Offset: 0x1322640 VA: 0x181324040
	internal void ValidateDefaultAttributeOnUse(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }

}

private enum XmlValidatingReaderImpl.ParsingFunction // TypeDefIndex: 1919
{	// Fields
	public int value__; // 0x0
	public const XmlValidatingReaderImpl.ParsingFunction Read = 0;
	public const XmlValidatingReaderImpl.ParsingFunction Init = 1;
	public const XmlValidatingReaderImpl.ParsingFunction ParseDtdFromContext = 2;
	public const XmlValidatingReaderImpl.ParsingFunction ResolveEntityInternally = 3;
	public const XmlValidatingReaderImpl.ParsingFunction InReadBinaryContent = 4;
	public const XmlValidatingReaderImpl.ParsingFunction ReaderClosed = 5;
	public const XmlValidatingReaderImpl.ParsingFunction Error = 6;
	public const XmlValidatingReaderImpl.ParsingFunction None = 7;

}

internal class XmlValidatingReaderImpl.ValidationEventHandling : IValidationEventHandling // TypeDefIndex: 1920
{	// Fields
	private XmlValidatingReaderImpl reader; // 0x10
	private ValidationEventHandler eventHandler; // 0x18

	// Properties
	private object System.Xml.IValidationEventHandling.EventHandler { get; }

	// Methods

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	internal void .ctor(XmlValidatingReaderImpl reader) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Xml.IValidationEventHandling.get_EventHandler() { }

	// RVA: 0x1318B70 Offset: 0x1317170 VA: 0x181318B70 Slot: 5
	private void System.Xml.IValidationEventHandling.SendEvent(Exception exception, XmlSeverityType severity) { }

	// RVA: 0x1318AF0 Offset: 0x13170F0 VA: 0x181318AF0
	internal void AddHandler(ValidationEventHandler handler) { }

}

internal class XmlWellFormedWriter : XmlWriter // TypeDefIndex: 1921
{	// Fields
	private XmlWriter writer; // 0x18
	private XmlRawWriter rawWriter; // 0x20
	private IXmlNamespaceResolver predefinedNamespaces; // 0x28
	private XmlWellFormedWriter.Namespace[] nsStack; // 0x30
	private int nsTop; // 0x38
	private Dictionary<string, int> nsHashtable; // 0x40
	private bool useNsHashtable; // 0x48
	private XmlWellFormedWriter.ElementScope[] elemScopeStack; // 0x50
	private int elemTop; // 0x58
	private XmlWellFormedWriter.AttrName[] attrStack; // 0x60
	private int attrCount; // 0x68
	private Dictionary<string, int> attrHashTable; // 0x70
	private XmlWellFormedWriter.SpecialAttribute specAttr; // 0x78
	private XmlWellFormedWriter.AttributeValueCache attrValueCache; // 0x80
	private string curDeclPrefix; // 0x88
	private XmlWellFormedWriter.State[] stateTable; // 0x90
	private XmlWellFormedWriter.State currentState; // 0x98
	private bool checkCharacters; // 0x9C
	private bool omitDuplNamespaces; // 0x9D
	private bool writeEndDocumentOnClose; // 0x9E
	private ConformanceLevel conformanceLevel; // 0xA0
	private bool dtdWritten; // 0xA4
	private bool xmlDeclFollows; // 0xA5
	private XmlCharType xmlCharType; // 0xA8
	private SecureStringHasher hasher; // 0xB0
	internal static readonly string[] stateName; // 0x0
	internal static readonly string[] tokenName; // 0x8
	private static WriteState[] state2WriteState; // 0x10
	private static readonly XmlWellFormedWriter.State[] StateTableDocument; // 0x18
	private static readonly XmlWellFormedWriter.State[] StateTableAuto; // 0x20

	// Properties
	public override WriteState WriteState { get; }
	internal XmlRawWriter RawWriter { get; }
	private bool SaveAttrValue { get; }
	private bool InBase64 { get; }
	private bool IsClosedOrErrorState { get; }

	// Methods

	// RVA: 0x132B110 Offset: 0x1329710 VA: 0x18132B110
	internal void .ctor(XmlWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x132B650 Offset: 0x1329C50 VA: 0x18132B650 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x1329910 Offset: 0x1327F10 VA: 0x181329910 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x1329920 Offset: 0x1327F20 VA: 0x181329920 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x13285E0 Offset: 0x1326BE0 VA: 0x1813285E0 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x1327990 Offset: 0x1325F90 VA: 0x181327990 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1329950 Offset: 0x1327F50 VA: 0x181329950 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x13286F0 Offset: 0x1326CF0 VA: 0x1813286F0 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x13289E0 Offset: 0x1326FE0 VA: 0x1813289E0 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x1329180 Offset: 0x1327780 VA: 0x181329180 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x1327D40 Offset: 0x1326340 VA: 0x181327D40 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1327390 Offset: 0x1325990 VA: 0x181327390 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x13278D0 Offset: 0x1325ED0 VA: 0x1813278D0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1328BB0 Offset: 0x13271B0 VA: 0x181328BB0 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x13288C0 Offset: 0x1326EC0 VA: 0x1813288C0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1327450 Offset: 0x1325A50 VA: 0x181327450 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1329DC0 Offset: 0x13283C0 VA: 0x181329DC0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x132A160 Offset: 0x1328760 VA: 0x18132A160 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1329C60 Offset: 0x1328260 VA: 0x181329C60 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1327630 Offset: 0x1325C30 VA: 0x181327630 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1328DA0 Offset: 0x13273A0 VA: 0x181328DA0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1329040 Offset: 0x1327640 VA: 0x181329040 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1327100 Offset: 0x1325700 VA: 0x181327100 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1325600 Offset: 0x1323C00 VA: 0x181325600 Slot: 28
	public override void Close() { }

	// RVA: 0x1325910 Offset: 0x1323F10 VA: 0x181325910 Slot: 29
	public override void Flush() { }

	// RVA: 0x1326050 Offset: 0x1324650 VA: 0x181326050 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x132A010 Offset: 0x1328610 VA: 0x18132A010 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0x13272A0 Offset: 0x13258A0 VA: 0x1813272A0 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal XmlRawWriter get_RawWriter() { }

	// RVA: 0xB292B0 Offset: 0xB278B0 VA: 0x180B292B0
	private bool get_SaveAttrValue() { }

	// RVA: 0x132B620 Offset: 0x1329C20 VA: 0x18132B620
	private bool get_InBase64() { }

	// RVA: 0x1326C30 Offset: 0x1325230 VA: 0x181326C30
	private void SetSpecialAttribute(XmlWellFormedWriter.SpecialAttribute special) { }

	// RVA: 0x13297B0 Offset: 0x1327DB0 VA: 0x1813297B0
	private void WriteStartDocumentImpl(XmlStandalone standalone) { }

	// RVA: 0x1326EE0 Offset: 0x13254E0 VA: 0x181326EE0
	private void StartFragment() { }

	// RVA: 0x13267F0 Offset: 0x1324DF0 VA: 0x1813267F0
	private void PushNamespaceImplicit(string prefix, string ns) { }

	// RVA: 0x13262D0 Offset: 0x13248D0 VA: 0x1813262D0
	private bool PushNamespaceExplicit(string prefix, string ns) { }

	// RVA: 0x1324CB0 Offset: 0x13232B0 VA: 0x181324CB0
	private void AddNamespace(string prefix, string ns, XmlWellFormedWriter.NamespaceKind kind) { }

	// RVA: 0x1324F90 Offset: 0x1323590 VA: 0x181324F90
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x1325E50 Offset: 0x1324450 VA: 0x181325E50
	private int LookupNamespaceIndex(string prefix) { }

	// RVA: 0x1326210 Offset: 0x1324810 VA: 0x181326210
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x1325820 Offset: 0x1323E20 VA: 0x181325820
	private static XmlException DupAttrException(string prefix, string localName) { }

	// RVA: 0x1325090 Offset: 0x1323690 VA: 0x181325090
	private void AdvanceState(XmlWellFormedWriter.Token token) { }

	// RVA: 0x1326D20 Offset: 0x1325320 VA: 0x181326D20
	private void StartElementContent() { }

	// RVA: 0x1325AD0 Offset: 0x13240D0 VA: 0x181325AD0
	private static string GetStateName(XmlWellFormedWriter.State state) { }

	// RVA: 0x1325F60 Offset: 0x1324560 VA: 0x181325F60
	internal string LookupNamespace(string prefix) { }

	// RVA: 0x1325D60 Offset: 0x1324360 VA: 0x181325D60
	private string LookupLocalNamespace(string prefix) { }

	// RVA: 0x13259A0 Offset: 0x1323FA0 VA: 0x1813259A0
	private string GeneratePrefix() { }

	// RVA: 0x1325490 Offset: 0x1323A90 VA: 0x181325490
	private void CheckNCName(string ncname) { }

	// RVA: 0x1325B70 Offset: 0x1324170 VA: 0x181325B70
	private static Exception InvalidCharsException(string name, int badCharIndex) { }

	// RVA: 0x1326EF0 Offset: 0x13254F0 VA: 0x181326EF0
	private void ThrowInvalidStateTransition(XmlWellFormedWriter.Token token, XmlWellFormedWriter.State currentState) { }

	// RVA: 0x132B640 Offset: 0x1329C40 VA: 0x18132B640
	private bool get_IsClosedOrErrorState() { }

	// RVA: 0x1324970 Offset: 0x1322F70 VA: 0x181324970
	private void AddAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x1324E40 Offset: 0x1323440 VA: 0x181324E40
	private void AddToAttrHashTable(int attributeIndex) { }

	// RVA: 0x132A310 Offset: 0x1328910 VA: 0x18132A310
	private static void .cctor() { }

}

private enum XmlWellFormedWriter.State // TypeDefIndex: 1922
{	// Fields
	public int value__; // 0x0
	public const XmlWellFormedWriter.State Start = 0;
	public const XmlWellFormedWriter.State TopLevel = 1;
	public const XmlWellFormedWriter.State Document = 2;
	public const XmlWellFormedWriter.State Element = 3;
	public const XmlWellFormedWriter.State Content = 4;
	public const XmlWellFormedWriter.State B64Content = 5;
	public const XmlWellFormedWriter.State B64Attribute = 6;
	public const XmlWellFormedWriter.State AfterRootEle = 7;
	public const XmlWellFormedWriter.State Attribute = 8;
	public const XmlWellFormedWriter.State SpecialAttr = 9;
	public const XmlWellFormedWriter.State EndDocument = 10;
	public const XmlWellFormedWriter.State RootLevelAttr = 11;
	public const XmlWellFormedWriter.State RootLevelSpecAttr = 12;
	public const XmlWellFormedWriter.State RootLevelB64Attr = 13;
	public const XmlWellFormedWriter.State AfterRootLevelAttr = 14;
	public const XmlWellFormedWriter.State Closed = 15;
	public const XmlWellFormedWriter.State Error = 16;
	public const XmlWellFormedWriter.State StartContent = 101;
	public const XmlWellFormedWriter.State StartContentEle = 102;
	public const XmlWellFormedWriter.State StartContentB64 = 103;
	public const XmlWellFormedWriter.State StartDoc = 104;
	public const XmlWellFormedWriter.State StartDocEle = 106;
	public const XmlWellFormedWriter.State EndAttrSEle = 107;
	public const XmlWellFormedWriter.State EndAttrEEle = 108;
	public const XmlWellFormedWriter.State EndAttrSCont = 109;
	public const XmlWellFormedWriter.State EndAttrSAttr = 111;
	public const XmlWellFormedWriter.State PostB64Cont = 112;
	public const XmlWellFormedWriter.State PostB64Attr = 113;
	public const XmlWellFormedWriter.State PostB64RootAttr = 114;
	public const XmlWellFormedWriter.State StartFragEle = 115;
	public const XmlWellFormedWriter.State StartFragCont = 116;
	public const XmlWellFormedWriter.State StartFragB64 = 117;
	public const XmlWellFormedWriter.State StartRootLevelAttr = 118;

}

private enum XmlWellFormedWriter.Token // TypeDefIndex: 1923
{	// Fields
	public int value__; // 0x0
	public const XmlWellFormedWriter.Token StartDocument = 0;
	public const XmlWellFormedWriter.Token EndDocument = 1;
	public const XmlWellFormedWriter.Token PI = 2;
	public const XmlWellFormedWriter.Token Comment = 3;
	public const XmlWellFormedWriter.Token Dtd = 4;
	public const XmlWellFormedWriter.Token StartElement = 5;
	public const XmlWellFormedWriter.Token EndElement = 6;
	public const XmlWellFormedWriter.Token StartAttribute = 7;
	public const XmlWellFormedWriter.Token EndAttribute = 8;
	public const XmlWellFormedWriter.Token Text = 9;
	public const XmlWellFormedWriter.Token CData = 10;
	public const XmlWellFormedWriter.Token AtomicValue = 11;
	public const XmlWellFormedWriter.Token Base64 = 12;
	public const XmlWellFormedWriter.Token RawData = 13;
	public const XmlWellFormedWriter.Token Whitespace = 14;

}

private class XmlWellFormedWriter.NamespaceResolverProxy : IXmlNamespaceResolver // TypeDefIndex: 1924
{	// Fields
	private XmlWellFormedWriter wfWriter; // 0x10

	// Methods

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	internal void .ctor(XmlWellFormedWriter wfWriter) { }

	// RVA: 0x1317AA0 Offset: 0x13160A0 VA: 0x181317AA0 Slot: 4
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1317AF0 Offset: 0x13160F0 VA: 0x181317AF0 Slot: 5
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1317B10 Offset: 0x1316110 VA: 0x181317B10 Slot: 6
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

private struct XmlWellFormedWriter.ElementScope // TypeDefIndex: 1925
{	// Fields
	internal int prevNSTop; // 0x0
	internal string prefix; // 0x8
	internal string localName; // 0x10
	internal string namespaceUri; // 0x18
	internal XmlSpace xmlSpace; // 0x20
	internal string xmlLang; // 0x28

	// Methods

	// RVA: 0x1E0FB0 Offset: 0x1E03B0 VA: 0x1801E0FB0
	internal void Set(string prefix, string localName, string namespaceUri, int prevNSTop) { }

	// RVA: 0x1E1030 Offset: 0x1E0430 VA: 0x1801E1030
	internal void WriteEndElement(XmlRawWriter rawWriter) { }

	// RVA: 0x1E1070 Offset: 0x1E0470 VA: 0x1801E1070
	internal void WriteFullEndElement(XmlRawWriter rawWriter) { }

}

private enum XmlWellFormedWriter.NamespaceKind // TypeDefIndex: 1926
{	// Fields
	public int value__; // 0x0
	public const XmlWellFormedWriter.NamespaceKind Written = 0;
	public const XmlWellFormedWriter.NamespaceKind NeedToWrite = 1;
	public const XmlWellFormedWriter.NamespaceKind Implied = 2;
	public const XmlWellFormedWriter.NamespaceKind Special = 3;

}

private struct XmlWellFormedWriter.Namespace // TypeDefIndex: 1927
{	// Fields
	internal string prefix; // 0x0
	internal string namespaceUri; // 0x8
	internal XmlWellFormedWriter.NamespaceKind kind; // 0x10
	internal int prevNsIndex; // 0x14

	// Methods

	// RVA: 0x1E11F0 Offset: 0x1E05F0 VA: 0x1801E11F0
	internal void Set(string prefix, string namespaceUri, XmlWellFormedWriter.NamespaceKind kind) { }

	// RVA: 0x1E1290 Offset: 0x1E0690 VA: 0x1801E1290
	internal void WriteDecl(XmlWriter writer, XmlRawWriter rawWriter) { }

}

private struct XmlWellFormedWriter.AttrName // TypeDefIndex: 1928
{	// Fields
	internal string prefix; // 0x0
	internal string namespaceUri; // 0x8
	internal string localName; // 0x10
	internal int prev; // 0x18

	// Methods

	// RVA: 0x1E0F50 Offset: 0x1E0350 VA: 0x1801E0F50
	internal void Set(string prefix, string localName, string namespaceUri) { }

	// RVA: 0x1E0F40 Offset: 0x1E0340 VA: 0x1801E0F40
	internal bool IsDuplicate(string prefix, string localName, string namespaceUri) { }

}

private enum XmlWellFormedWriter.SpecialAttribute // TypeDefIndex: 1929
{	// Fields
	public int value__; // 0x0
	public const XmlWellFormedWriter.SpecialAttribute No = 0;
	public const XmlWellFormedWriter.SpecialAttribute DefaultXmlns = 1;
	public const XmlWellFormedWriter.SpecialAttribute PrefixedXmlns = 2;
	public const XmlWellFormedWriter.SpecialAttribute XmlSpace = 3;
	public const XmlWellFormedWriter.SpecialAttribute XmlLang = 4;

}

private class XmlWellFormedWriter.AttributeValueCache // TypeDefIndex: 1930
{	// Fields
	private StringBuilder stringValue; // 0x10
	private string singleStringValue; // 0x18
	private XmlWellFormedWriter.AttributeValueCache.Item[] items; // 0x20
	private int firstItem; // 0x28
	private int lastItem; // 0x2C

	// Properties
	internal string StringValue { get; }

	// Methods

	// RVA: 0x1317320 Offset: 0x1315920 VA: 0x181317320
	internal string get_StringValue() { }

	// RVA: 0x1316C60 Offset: 0x1315260 VA: 0x181316C60
	internal void WriteEntityRef(string name) { }

	// RVA: 0x1316A80 Offset: 0x1315080 VA: 0x181316A80
	internal void WriteCharEntity(char ch) { }

	// RVA: 0x1317070 Offset: 0x1315670 VA: 0x181317070
	internal void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1317220 Offset: 0x1315820 VA: 0x181317220
	internal void WriteWhitespace(string ws) { }

	// RVA: 0x1316FB0 Offset: 0x13155B0 VA: 0x181316FB0
	internal void WriteString(string text) { }

	// RVA: 0x1316B50 Offset: 0x1315150 VA: 0x181316B50
	internal void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1316E10 Offset: 0x1315410 VA: 0x181316E10
	internal void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1316F20 Offset: 0x1315520 VA: 0x181316F20
	internal void WriteRaw(string data) { }

	// RVA: 0x1317190 Offset: 0x1315790 VA: 0x181317190
	internal void WriteValue(string value) { }

	// RVA: 0x13160B0 Offset: 0x13146B0 VA: 0x1813160B0
	internal void Replay(XmlWriter writer) { }

	// RVA: 0x1316570 Offset: 0x1314B70 VA: 0x181316570
	internal void Trim() { }

	// RVA: 0x1316060 Offset: 0x1314660 VA: 0x181316060
	internal void Clear() { }

	// RVA: 0x1316510 Offset: 0x1314B10 VA: 0x181316510
	private void StartComplexValue() { }

	// RVA: 0x1315EB0 Offset: 0x13144B0 VA: 0x181315EB0
	private void AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType type, object data) { }

	// RVA: 0x13172B0 Offset: 0x13158B0 VA: 0x1813172B0
	public void .ctor() { }

}

private enum XmlWellFormedWriter.AttributeValueCache.ItemType // TypeDefIndex: 1931
{	// Fields
	public int value__; // 0x0
	public const XmlWellFormedWriter.AttributeValueCache.ItemType EntityRef = 0;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType CharEntity = 1;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType SurrogateCharEntity = 2;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType Whitespace = 3;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType String = 4;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType StringChars = 5;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType Raw = 6;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType RawChars = 7;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType ValueString = 8;

}

private class XmlWellFormedWriter.AttributeValueCache.Item // TypeDefIndex: 1932
{	// Fields
	internal XmlWellFormedWriter.AttributeValueCache.ItemType type; // 0x10
	internal object data; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x11ED220 Offset: 0x11EB820 VA: 0x1811ED220
	internal void Set(XmlWellFormedWriter.AttributeValueCache.ItemType type, object data) { }

}

private class XmlWellFormedWriter.AttributeValueCache.BufferChunk // TypeDefIndex: 1933
{	// Fields
	internal char[] buffer; // 0x10
	internal int index; // 0x18
	internal int count; // 0x1C

	// Methods

	// RVA: 0xB7BE20 Offset: 0xB7A420 VA: 0x180B7BE20
	internal void .ctor(char[] buffer, int index, int count) { }

}

public abstract class XmlWriter : IDisposable // TypeDefIndex: 1935
{	// Fields
	private char[] writeNodeBuffer; // 0x10

	// Properties
	public abstract WriteState WriteState { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void WriteStartDocument();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void WriteStartDocument(bool standalone);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void WriteEndDocument();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void WriteDocType(string name, string pubid, string sysid, string subset);

	// RVA: 0x132D090 Offset: 0x132B690 VA: 0x18132D090
	public void WriteStartElement(string localName, string ns) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void WriteStartElement(string prefix, string localName, string ns);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void WriteEndElement();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void WriteFullEndElement();

	// RVA: 0x132C790 Offset: 0x132AD90 VA: 0x18132C790
	public void WriteAttributeString(string localName, string ns, string value) { }

	// RVA: 0x132C720 Offset: 0x132AD20 VA: 0x18132C720
	public void WriteAttributeString(string localName, string value) { }

	// RVA: 0x132C800 Offset: 0x132AE00 VA: 0x18132C800
	public void WriteAttributeString(string prefix, string localName, string ns, string value) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void WriteStartAttribute(string prefix, string localName, string ns);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void WriteEndAttribute();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void WriteCData(string text);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void WriteComment(string text);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void WriteProcessingInstruction(string name, string text);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void WriteEntityRef(string name);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void WriteCharEntity(char ch);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void WriteWhitespace(string ws);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void WriteString(string text);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void WriteSurrogateCharEntity(char lowChar, char highChar);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void WriteChars(char[] buffer, int index, int count);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void WriteRaw(char[] buffer, int index, int count);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void WriteRaw(string data);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void WriteBase64(byte[] buffer, int index, int count);

	// RVA: 0x132CB10 Offset: 0x132B110 VA: 0x18132CB10 Slot: 26
	public virtual void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract WriteState get_WriteState();

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 28
	public virtual void Close() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void Flush();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract string LookupPrefix(string ns);

	// RVA: 0x132D0C0 Offset: 0x132B6C0 VA: 0x18132D0C0 Slot: 31
	public virtual void WriteValue(string value) { }

	// RVA: 0x132C850 Offset: 0x132AE50 VA: 0x18132C850 Slot: 32
	public virtual void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x132CBB0 Offset: 0x132B1B0 VA: 0x18132CBB0 Slot: 33
	public virtual void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x132CB40 Offset: 0x132B140 VA: 0x18132CB40
	public void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x132C6C0 Offset: 0x132ACC0 VA: 0x18132C6C0 Slot: 4
	public void Dispose() { }

	// RVA: 0x132C6E0 Offset: 0x132ACE0 VA: 0x18132C6E0 Slot: 34
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x132C5E0 Offset: 0x132ABE0 VA: 0x18132C5E0
	public static XmlWriter Create(Stream output, XmlWriterSettings settings) { }

	// RVA: 0x132C650 Offset: 0x132AC50 VA: 0x18132C650
	public static XmlWriter Create(TextWriter output, XmlWriterSettings settings) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

public enum XmlOutputMethod // TypeDefIndex: 1936
{	// Fields
	public int value__; // 0x0
	public const XmlOutputMethod Xml = 0;
	public const XmlOutputMethod Html = 1;
	public const XmlOutputMethod Text = 2;
	public const XmlOutputMethod AutoDetect = 3;

}

internal enum XmlStandalone // TypeDefIndex: 1938
{	// Fields
	public int value__; // 0x0
	public const XmlStandalone Omit = 0;
	public const XmlStandalone Yes = 1;
	public const XmlStandalone No = 2;

}

public sealed class XmlWriterSettings // TypeDefIndex: 1939
{	// Fields
	private bool useAsync; // 0x10
	private Encoding encoding; // 0x18
	private bool omitXmlDecl; // 0x20
	private NewLineHandling newLineHandling; // 0x24
	private string newLineChars; // 0x28
	private TriState indent; // 0x30
	private string indentChars; // 0x38
	private bool newLineOnAttributes; // 0x40
	private bool closeOutput; // 0x41
	private NamespaceHandling namespaceHandling; // 0x44
	private ConformanceLevel conformanceLevel; // 0x48
	private bool checkCharacters; // 0x4C
	private bool writeEndDocumentOnClose; // 0x4D
	private XmlOutputMethod outputMethod; // 0x50
	private List<XmlQualifiedName> cdataSections; // 0x58
	private bool doNotEscapeUriAttributes; // 0x60
	private bool mergeCDataSections; // 0x61
	private string mediaType; // 0x68
	private string docTypeSystem; // 0x70
	private string docTypePublic; // 0x78
	private XmlStandalone standalone; // 0x80
	private bool autoXmlDecl; // 0x84
	private bool isReadOnly; // 0x85

	// Properties
	public bool Async { get; }
	public Encoding Encoding { get; }
	public bool OmitXmlDeclaration { get; set; }
	public NewLineHandling NewLineHandling { get; }
	public string NewLineChars { get; }
	public bool Indent { get; set; }
	public string IndentChars { get; }
	public bool NewLineOnAttributes { get; }
	public bool CloseOutput { get; }
	public ConformanceLevel ConformanceLevel { get; set; }
	public bool CheckCharacters { get; }
	public NamespaceHandling NamespaceHandling { get; set; }
	public bool WriteEndDocumentOnClose { get; }
	public XmlOutputMethod OutputMethod { get; set; }
	internal List<XmlQualifiedName> CDataSectionElements { get; }
	public bool DoNotEscapeUriAttributes { get; }
	internal bool MergeCDataSections { get; }
	internal string MediaType { get; }
	internal string DocTypeSystem { get; }
	internal string DocTypePublic { get; }
	internal XmlStandalone Standalone { get; }
	internal bool AutoXmlDeclaration { get; }
	internal TriState IndentInternal { get; }
	internal bool IsQuerySpecific { get; }
	internal bool ReadOnly { set; }

	// Methods

	// RVA: 0x132C240 Offset: 0x132A840 VA: 0x18132C240
	public void .ctor() { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_Async() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Encoding get_Encoding() { }

	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80
	public bool get_OmitXmlDeclaration() { }

	// RVA: 0x132C580 Offset: 0x132AB80 VA: 0x18132C580
	public void set_OmitXmlDeclaration(bool value) { }

	// RVA: 0x79C630 Offset: 0x79AC30 VA: 0x18079C630
	public NewLineHandling get_NewLineHandling() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public string get_NewLineChars() { }

	// RVA: 0x132C3A0 Offset: 0x132A9A0 VA: 0x18132C3A0
	public bool get_Indent() { }

	// RVA: 0x132C4A0 Offset: 0x132AAA0 VA: 0x18132C4A0
	public void set_Indent(bool value) { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public string get_IndentChars() { }

	// RVA: 0x805B90 Offset: 0x804190 VA: 0x180805B90
	public bool get_NewLineOnAttributes() { }

	// RVA: 0xEE7C00 Offset: 0xEE6200 VA: 0x180EE7C00
	public bool get_CloseOutput() { }

	// RVA: 0x5983B0 Offset: 0x5969B0 VA: 0x1805983B0
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0x132C420 Offset: 0x132AA20 VA: 0x18132C420
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0xC21200 Offset: 0xC1F800 VA: 0x180C21200
	public bool get_CheckCharacters() { }

	// RVA: 0x5DE3E0 Offset: 0x5DC9E0 VA: 0x1805DE3E0
	public NamespaceHandling get_NamespaceHandling() { }

	// RVA: 0x132C500 Offset: 0x132AB00 VA: 0x18132C500
	public void set_NamespaceHandling(NamespaceHandling value) { }

	// RVA: 0x132C410 Offset: 0x132AA10 VA: 0x18132C410
	public bool get_WriteEndDocumentOnClose() { }

	// RVA: 0x8D9520 Offset: 0x8D7B20 VA: 0x1808D9520
	public XmlOutputMethod get_OutputMethod() { }

	// RVA: 0x8D9560 Offset: 0x8D7B60 VA: 0x1808D9560
	internal void set_OutputMethod(XmlOutputMethod value) { }

	// RVA: 0x132B9E0 Offset: 0x1329FE0 VA: 0x18132B9E0
	public XmlWriterSettings Clone() { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	internal List<XmlQualifiedName> get_CDataSectionElements() { }

	// RVA: 0xA4F780 Offset: 0xA4DD80 VA: 0x180A4F780
	public bool get_DoNotEscapeUriAttributes() { }

	// RVA: 0x1087220 Offset: 0x1085820 VA: 0x181087220
	internal bool get_MergeCDataSections() { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	internal string get_MediaType() { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	internal string get_DocTypeSystem() { }

	// RVA: 0x4E84B0 Offset: 0x4E6AB0 VA: 0x1804E84B0
	internal string get_DocTypePublic() { }

	// RVA: 0x5828D0 Offset: 0x580ED0 VA: 0x1805828D0
	internal XmlStandalone get_Standalone() { }

	// RVA: 0x132C390 Offset: 0x132A990 VA: 0x18132C390
	internal bool get_AutoXmlDeclaration() { }

	// RVA: 0xA39490 Offset: 0xA37A90 VA: 0x180A39490
	internal TriState get_IndentInternal() { }

	// RVA: 0x132C3B0 Offset: 0x132A9B0 VA: 0x18132C3B0
	internal bool get_IsQuerySpecific() { }

	// RVA: 0x132BCF0 Offset: 0x132A2F0 VA: 0x18132BCF0
	internal XmlWriter CreateWriter(Stream output) { }

	// RVA: 0x132BA90 Offset: 0x132A090 VA: 0x18132BA90
	internal XmlWriter CreateWriter(TextWriter output) { }

	// RVA: 0x132C5D0 Offset: 0x132ABD0 VA: 0x18132C5D0
	internal void set_ReadOnly(bool value) { }

	// RVA: 0x132B930 Offset: 0x1329F30 VA: 0x18132B930
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0x132C140 Offset: 0x132A740 VA: 0x18132C140
	private void Initialize() { }

}

internal class XsdCachingReader : XmlReader, IXmlLineInfo // TypeDefIndex: 1940
{	// Fields
	private XmlReader coreReader; // 0x10
	private XmlNameTable coreReaderNameTable; // 0x18
	private ValidatingReaderNodeData[] contentEvents; // 0x20
	private ValidatingReaderNodeData[] attributeEvents; // 0x28
	private ValidatingReaderNodeData cachedNode; // 0x30
	private XsdCachingReader.CachingReaderState cacheState; // 0x38
	private int contentIndex; // 0x3C
	private int attributeCount; // 0x40
	private bool returnOriginalStringValues; // 0x44
	private CachingEventHandler cacheHandler; // 0x48
	private int currentAttrIndex; // 0x50
	private int currentContentIndex; // 0x54
	private bool readAhead; // 0x58
	private IXmlLineInfo lineInfo; // 0x60
	private ValidatingReaderNodeData textNode; // 0x68

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	private int System.Xml.IXmlLineInfo.LineNumber { get; }
	private int System.Xml.IXmlLineInfo.LinePosition { get; }

	// Methods

	// RVA: 0x132E8D0 Offset: 0x132CED0 VA: 0x18132E8D0
	internal void .ctor(XmlReader reader, IXmlLineInfo lineInfo, CachingEventHandler handlerMethod) { }

	// RVA: 0x132D920 Offset: 0x132BF20 VA: 0x18132D920
	private void Init() { }

	// RVA: 0x132E510 Offset: 0x132CB10 VA: 0x18132E510
	internal void Reset(XmlReader reader) { }

	// RVA: 0x132EAD0 Offset: 0x132D0D0 VA: 0x18132EAD0 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x132EA90 Offset: 0x132D090 VA: 0x18132EA90 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x132EA40 Offset: 0x132D040 VA: 0x18132EA40 Slot: 7
	public override string get_Name() { }

	// RVA: 0x132EA20 Offset: 0x132D020 VA: 0x18132EA20 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x132EA70 Offset: 0x132D070 VA: 0x18132EA70 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x132EAB0 Offset: 0x132D0B0 VA: 0x18132EAB0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x132EB00 Offset: 0x132D100 VA: 0x18132EB00 Slot: 11
	public override string get_Value() { }

	// RVA: 0x132E9C0 Offset: 0x132CFC0 VA: 0x18132E9C0 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xBC90A0 Offset: 0xBC76A0 VA: 0x180BC90A0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xBC9380 Offset: 0xBC7980 VA: 0x180BC9380 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xBC9410 Offset: 0xBC7A10 VA: 0x180BC9410 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBC93E0 Offset: 0xBC79E0 VA: 0x180BC93E0 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x5DE3D0 Offset: 0x5DC9D0 VA: 0x1805DE3D0 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x132D6C0 Offset: 0x132BCC0 VA: 0x18132D6C0 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x132D800 Offset: 0x132BE00 VA: 0x18132D800 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x132D750 Offset: 0x132BD50 VA: 0x18132D750 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x132DB70 Offset: 0x132C170 VA: 0x18132DB70 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x132DAC0 Offset: 0x132C0C0 VA: 0x18132DAC0 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x132DC60 Offset: 0x132C260 VA: 0x18132DC60 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x132DCC0 Offset: 0x132C2C0 VA: 0x18132DCC0 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x132DC10 Offset: 0x132C210 VA: 0x18132DC10 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x132DE10 Offset: 0x132C410 VA: 0x18132DE10 Slot: 31
	public override bool Read() { }

	// RVA: 0x132E490 Offset: 0x132CA90 VA: 0x18132E490
	internal ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos) { }

	// RVA: 0x132E6F0 Offset: 0x132CCF0 VA: 0x18132E6F0
	internal void SwitchTextNodeAndEndElement(string textValue, string originalStringValue) { }

	// RVA: 0x132E340 Offset: 0x132C940 VA: 0x18132E340
	internal void RecordEndElementNode() { }

	// RVA: 0x132E9E0 Offset: 0x132CFE0 VA: 0x18132E9E0 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x132D440 Offset: 0x132BA40 VA: 0x18132D440 Slot: 33
	public override void Close() { }

	// RVA: 0xB9F640 Offset: 0xB9DC40 VA: 0x180B9F640 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x132E5C0 Offset: 0x132CBC0 VA: 0x18132E5C0 Slot: 35
	public override void Skip() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xBC8C10 Offset: 0xBC7210 VA: 0x180BC8C10 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x132E540 Offset: 0x132CB40 VA: 0x18132E540 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x132DD20 Offset: 0x132C320 VA: 0x18132DD20 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 53
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x132E890 Offset: 0x132CE90 VA: 0x18132E890 Slot: 54
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x132E8B0 Offset: 0x132CEB0 VA: 0x18132E8B0 Slot: 55
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x132E590 Offset: 0x132CB90 VA: 0x18132E590
	internal void SetToReplayMode() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal XmlReader GetCoreReader() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	internal IXmlLineInfo GetLineInfo() { }

	// RVA: 0x132D430 Offset: 0x132BA30 VA: 0x18132D430
	private void ClearAttributesInfo() { }

	// RVA: 0x132D0E0 Offset: 0x132B6E0 VA: 0x18132D0E0
	private ValidatingReaderNodeData AddAttribute(int attIndex) { }

	// RVA: 0x132D280 Offset: 0x132B880 VA: 0x18132D280
	private ValidatingReaderNodeData AddContent(XmlNodeType nodeType) { }

	// RVA: 0x132E180 Offset: 0x132C780 VA: 0x18132E180
	private void RecordAttributes() { }

	// RVA: 0x132D600 Offset: 0x132BC00 VA: 0x18132D600
	private int GetAttributeIndexWithoutPrefix(string name) { }

	// RVA: 0x132D540 Offset: 0x132BB40 VA: 0x18132D540
	private int GetAttributeIndexWithPrefix(string name) { }

	// RVA: 0x132D480 Offset: 0x132BA80 VA: 0x18132D480
	private ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

}

private enum XsdCachingReader.CachingReaderState // TypeDefIndex: 1941
{	// Fields
	public int value__; // 0x0
	public const XsdCachingReader.CachingReaderState None = 0;
	public const XsdCachingReader.CachingReaderState Init = 1;
	public const XsdCachingReader.CachingReaderState Record = 2;
	public const XsdCachingReader.CachingReaderState Replay = 3;
	public const XsdCachingReader.CachingReaderState ReaderClosed = 4;
	public const XsdCachingReader.CachingReaderState Error = 5;

}

internal class XsdValidatingReader : XmlReader, IXmlSchemaInfo, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 1944
{	// Fields
	private XmlReader coreReader; // 0x10
	private IXmlNamespaceResolver coreReaderNSResolver; // 0x18
	private IXmlNamespaceResolver thisNSResolver; // 0x20
	private XmlSchemaValidator validator; // 0x28
	private XmlResolver xmlResolver; // 0x30
	private ValidationEventHandler validationEvent; // 0x38
	private XsdValidatingReader.ValidatingReaderState validationState; // 0x40
	private XmlValueGetter valueGetter; // 0x48
	private XmlNamespaceManager nsManager; // 0x50
	private bool manageNamespaces; // 0x58
	private bool processInlineSchema; // 0x59
	private bool replayCache; // 0x5A
	private ValidatingReaderNodeData cachedNode; // 0x60
	private AttributePSVIInfo attributePSVI; // 0x68
	private int attributeCount; // 0x70
	private int coreReaderAttributeCount; // 0x74
	private int currentAttrIndex; // 0x78
	private AttributePSVIInfo[] attributePSVINodes; // 0x80
	private ArrayList defaultAttributes; // 0x88
	private Parser inlineSchemaParser; // 0x90
	private object atomicValue; // 0x98
	private XmlSchemaInfo xmlSchemaInfo; // 0xA0
	private string originalAtomicValueString; // 0xA8
	private XmlNameTable coreReaderNameTable; // 0xB0
	private XsdCachingReader cachingReader; // 0xB8
	private ValidatingReaderNodeData textNode; // 0xC0
	private string NsXmlNs; // 0xC8
	private string NsXs; // 0xD0
	private string NsXsi; // 0xD8
	private string XsiType; // 0xE0
	private string XsiNil; // 0xE8
	private string XsdSchema; // 0xF0
	private string XsiSchemaLocation; // 0xF8
	private string XsiNoNamespaceSchemaLocation; // 0x100
	private XmlCharType xmlCharType; // 0x108
	private IXmlLineInfo lineInfo; // 0x110
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x118
	private XsdValidatingReader.ValidatingReaderState savedState; // 0x120
	private static Type TypeOfString; // 0x0

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override Type ValueType { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsDefault { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsNil { get; }
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.Validity { get; }
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.MemberType { get; }
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.SchemaType { get; }
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.SchemaElement { get; }
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.SchemaAttribute { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	private XmlSchemaInfo AttributeSchemaInfo { get; }

	// Methods

	// RVA: 0x2244490 Offset: 0x2242A90 VA: 0x182244490
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings, XmlSchemaObject partialValidationType) { }

	// RVA: 0x2244660 Offset: 0x2242C60 VA: 0x182244660
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings) { }

	// RVA: 0x2241D20 Offset: 0x2240320 VA: 0x182241D20
	private void Init() { }

	// RVA: 0x2243860 Offset: 0x2241E60 VA: 0x182243860
	private void SetupValidator(XmlReaderSettings readerSettings, XmlReader reader, XmlSchemaObject partialValidationType) { }

	// RVA: 0x2244AD0 Offset: 0x22430D0 VA: 0x182244AD0 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x22449B0 Offset: 0x2242FB0 VA: 0x1822449B0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x2244800 Offset: 0x2242E00 VA: 0x182244800 Slot: 7
	public override string get_Name() { }

	// RVA: 0x22447C0 Offset: 0x2242DC0 VA: 0x1822447C0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x2244970 Offset: 0x2242F70 VA: 0x182244970 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x2244A50 Offset: 0x2243050 VA: 0x182244A50 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x2244C70 Offset: 0x2243270 VA: 0x182244C70 Slot: 11
	public override string get_Value() { }

	// RVA: 0x22446A0 Offset: 0x2242CA0 VA: 0x1822446A0 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xBC90A0 Offset: 0xBC76A0 VA: 0x180BC90A0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBC9190 Offset: 0xBC7790 VA: 0x180BC9190 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x22446E0 Offset: 0x2242CE0 VA: 0x1822446E0 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xBC9380 Offset: 0xBC7980 VA: 0x180BC9380 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xBC9410 Offset: 0xBC7A10 VA: 0x180BC9410 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBC93E0 Offset: 0xBC79E0 VA: 0x180BC93E0 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 19
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x2244BB0 Offset: 0x22431B0 VA: 0x182244BB0 Slot: 20
	public override Type get_ValueType() { }

	// RVA: 0x804110 Offset: 0x802710 VA: 0x180804110 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x22412E0 Offset: 0x223F8E0 VA: 0x1822412E0 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x22411C0 Offset: 0x223F7C0 VA: 0x1822411C0 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x2241350 Offset: 0x223F950 VA: 0x182241350 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x2242280 Offset: 0x2240880 VA: 0x182242280 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x22420E0 Offset: 0x22406E0 VA: 0x1822420E0 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x22423B0 Offset: 0x22409B0 VA: 0x1822423B0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x2242560 Offset: 0x2240B60 VA: 0x182242560 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x2242360 Offset: 0x2240960 VA: 0x182242360 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x2243540 Offset: 0x2241B40 VA: 0x182243540 Slot: 31
	public override bool Read() { }

	// RVA: 0xBC9130 Offset: 0xBC7730 VA: 0x180BC9130 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x2240E30 Offset: 0x223F430 VA: 0x182240E30 Slot: 33
	public override void Close() { }

	// RVA: 0x2244A90 Offset: 0x2243090 VA: 0x182244A90 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x2243AB0 Offset: 0x22420B0 VA: 0x182243AB0 Slot: 35
	public override void Skip() { }

	// RVA: 0x79BDB0 Offset: 0x79A3B0 VA: 0x18079BDB0 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x2242080 Offset: 0x2240680 VA: 0x182242080 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x2243810 Offset: 0x2241E10 VA: 0x182243810 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x22433F0 Offset: 0x22419F0 VA: 0x1822433F0 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x2243E20 Offset: 0x2242420 VA: 0x182243E20 Slot: 54
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0x2243EB0 Offset: 0x22424B0 VA: 0x182243EB0 Slot: 55
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0x22441C0 Offset: 0x22427C0 VA: 0x1822441C0 Slot: 53
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0x2243F00 Offset: 0x2242500 VA: 0x182243F00 Slot: 56
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0x2244160 Offset: 0x2242760 VA: 0x182244160 Slot: 57
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0x2244100 Offset: 0x2242700 VA: 0x182244100 Slot: 58
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0x22440B0 Offset: 0x22426B0 VA: 0x1822440B0 Slot: 59
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 60
	public bool HasLineInfo() { }

	// RVA: 0x2244720 Offset: 0x2242D20 VA: 0x182244720 Slot: 61
	public int get_LineNumber() { }

	// RVA: 0x2244770 Offset: 0x2242D70 VA: 0x182244770 Slot: 62
	public int get_LinePosition() { }

	// RVA: 0x2243C30 Offset: 0x2242230 VA: 0x182243C30 Slot: 63
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x2243D20 Offset: 0x2242320 VA: 0x182243D20 Slot: 64
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x2243DA0 Offset: 0x22423A0 VA: 0x182243DA0 Slot: 65
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0xBC93B0 Offset: 0xBC79B0 VA: 0x180BC93B0
	private object GetStringValue() { }

	// RVA: 0x2244680 Offset: 0x2242C80 VA: 0x182244680
	private XmlSchemaInfo get_AttributeSchemaInfo() { }

	// RVA: 0x2242FB0 Offset: 0x22415B0 VA: 0x182242FB0
	private void ProcessReaderEvent() { }

	// RVA: 0x22426D0 Offset: 0x2240CD0 VA: 0x1822426D0
	private void ProcessElementEvent() { }

	// RVA: 0x2242CE0 Offset: 0x22412E0 VA: 0x182242CE0
	private void ProcessEndElementEvent() { }

	// RVA: 0x2244260 Offset: 0x2242860 VA: 0x182244260
	private void ValidateAttributes() { }

	// RVA: 0x2240DD0 Offset: 0x223F3D0 VA: 0x182240DD0
	private void ClearAttributesInfo() { }

	// RVA: 0x2240FF0 Offset: 0x223F5F0 VA: 0x182240FF0
	private AttributePSVIInfo GetAttributePSVI(string name) { }

	// RVA: 0x2240F30 Offset: 0x223F530 VA: 0x182240F30
	private AttributePSVIInfo GetAttributePSVI(string localName, string ns) { }

	// RVA: 0x2241590 Offset: 0x223FB90 VA: 0x182241590
	private ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition) { }

	// RVA: 0x22416E0 Offset: 0x223FCE0 VA: 0x1822416E0
	private ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition) { }

	// RVA: 0x2240BE0 Offset: 0x223F1E0 VA: 0x182240BE0
	private AttributePSVIInfo AddAttributePSVI(int attIndex) { }

	// RVA: 0x2242030 Offset: 0x2240630 VA: 0x182242030
	private bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x2242E90 Offset: 0x2241490 VA: 0x182242E90
	private void ProcessInlineSchema() { }

	// RVA: 0x22431A0 Offset: 0x22417A0 VA: 0x1822431A0
	private void ReadAheadForMemberType() { }

	// RVA: 0x2241860 Offset: 0x223FE60 VA: 0x182241860
	private void GetIsDefault() { }

	// RVA: 0x2241B70 Offset: 0x2240170 VA: 0x182241B70
	private void GetMemberType() { }

	// RVA: 0x2241490 Offset: 0x223FA90 VA: 0x182241490
	private XsdCachingReader GetCachingReader() { }

	// RVA: 0x2240E70 Offset: 0x223F470 VA: 0x182240E70
	internal ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

	// RVA: 0x2240D80 Offset: 0x223F380 VA: 0x182240D80
	internal void CachingCallBack(XsdCachingReader cachingReader) { }

	// RVA: 0x2241C80 Offset: 0x2240280 VA: 0x182241C80
	private string GetOriginalAtomicValueStringOfElement() { }

}

private enum XsdValidatingReader.ValidatingReaderState // TypeDefIndex: 1945
{	// Fields
	public int value__; // 0x0
	public const XsdValidatingReader.ValidatingReaderState None = 0;
	public const XsdValidatingReader.ValidatingReaderState Init = 1;
	public const XsdValidatingReader.ValidatingReaderState Read = 2;
	public const XsdValidatingReader.ValidatingReaderState OnDefaultAttribute = -1;
	public const XsdValidatingReader.ValidatingReaderState OnReadAttributeValue = -2;
	public const XsdValidatingReader.ValidatingReaderState OnAttribute = 3;
	public const XsdValidatingReader.ValidatingReaderState ClearAttributes = 4;
	public const XsdValidatingReader.ValidatingReaderState ParseInlineSchema = 5;
	public const XsdValidatingReader.ValidatingReaderState ReadAhead = 6;
	public const XsdValidatingReader.ValidatingReaderState OnReadBinaryContent = 7;
	public const XsdValidatingReader.ValidatingReaderState ReaderClosed = 8;
	public const XsdValidatingReader.ValidatingReaderState EOF = 9;
	public const XsdValidatingReader.ValidatingReaderState Error = 10;

}

public class XmlAttribute : XmlNode // TypeDefIndex: 1947
{	// Fields
	private XmlName name; // 0x18
	private XmlLinkedNode lastChild; // 0x20

	// Properties
	internal int LocalNameHash { get; }
	internal XmlName XmlName { get; set; }
	public override XmlNode ParentNode { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; set; }
	public override XmlNodeType NodeType { get; }
	public override XmlDocument OwnerDocument { get; }
	public override string Value { get; set; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override string InnerText { set; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public virtual bool Specified { get; }
	public virtual XmlElement OwnerElement { get; }
	public override string InnerXml { set; }
	public override string BaseURI { get; }
	internal override XmlSpace XmlSpace { get; }
	internal override string XmlLang { get; }

	// Methods

	// RVA: 0xE57B90 Offset: 0xE56190 VA: 0x180E57B90
	internal void .ctor(XmlName name, XmlDocument doc) { }

	// RVA: 0xE57D40 Offset: 0xE56340 VA: 0x180E57D40
	internal int get_LocalNameHash() { }

	// RVA: 0xE57B40 Offset: 0xE56140 VA: 0x180E57B40
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal XmlName get_XmlName() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	internal void set_XmlName(XmlName value) { }

	// RVA: 0xE57410 Offset: 0xE55A10 VA: 0x180E57410 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0xE57D60 Offset: 0xE56360 VA: 0x180E57D60 Slot: 6
	public override string get_Name() { }

	// RVA: 0x8557E0 Offset: 0x853DE0 VA: 0x1808557E0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xE57D80 Offset: 0xE56380 VA: 0x180E57D80 Slot: 33
	public override string get_NamespaceURI() { }

	// RVA: 0xE57E40 Offset: 0xE56440 VA: 0x180E57E40 Slot: 34
	public override string get_Prefix() { }

	// RVA: 0xE58070 Offset: 0xE56670 VA: 0x180E58070 Slot: 35
	public override void set_Prefix(string value) { }

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xE57DA0 Offset: 0xE563A0 VA: 0x180E57DA0 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0xE57E60 Offset: 0xE56460 VA: 0x180E57E60 Slot: 7
	public override string get_Value() { }

	// RVA: 0xE58130 Offset: 0xE56730 VA: 0x180E58130 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 41
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xE57F70 Offset: 0xE56570 VA: 0x180E57F70 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0xE57640 Offset: 0xE55C40 VA: 0x180E57640
	internal bool PrepareOwnerElementInElementIdAttrMap() { }

	// RVA: 0xE578D0 Offset: 0xE55ED0 VA: 0x180E578D0
	internal void ResetOwnerElementInElementIdAttrMap(string oldInnerText) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0xE571C0 Offset: 0xE557C0 VA: 0x180E571C0 Slot: 26
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0xE57630 Offset: 0xE55C30 VA: 0x180E57630 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 56
	public virtual bool get_Specified() { }

	// RVA: 0xE57590 Offset: 0xE55B90 VA: 0x180E57590 Slot: 21
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0xE574F0 Offset: 0xE55AF0 VA: 0x180E574F0 Slot: 22
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0xE57850 Offset: 0xE55E50 VA: 0x180E57850 Slot: 23
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0xE577D0 Offset: 0xE55DD0 VA: 0x180E577D0 Slot: 24
	public override XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0xE57390 Offset: 0xE55990 VA: 0x180E57390 Slot: 25
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0xE57DC0 Offset: 0xE563C0 VA: 0x180E57DC0 Slot: 57
	public virtual XmlElement get_OwnerElement() { }

	// RVA: 0xE57FE0 Offset: 0xE565E0 VA: 0x180E57FE0 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0xE57A70 Offset: 0xE56070 VA: 0x180E57A70 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0xE57A00 Offset: 0xE56000 VA: 0x180E57A00 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0xE57CB0 Offset: 0xE562B0 VA: 0x180E57CB0 Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0 Slot: 47
	internal override void SetParent(XmlNode node) { }

	// RVA: 0xE57F10 Offset: 0xE56510 VA: 0x180E57F10 Slot: 53
	internal override XmlSpace get_XmlSpace() { }

	// RVA: 0xE57E80 Offset: 0xE56480 VA: 0x180E57E80 Slot: 54
	internal override string get_XmlLang() { }

}

public sealed class XmlAttributeCollection : XmlNamedNodeMap, ICollection, IEnumerable // TypeDefIndex: 1948
{	// Properties
	public XmlAttribute ItemOf { get; }
	public XmlAttribute ItemOf { get; }
	public XmlAttribute ItemOf { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }

	// Methods

	// RVA: 0xE56E30 Offset: 0xE55430 VA: 0x180E56E30
	internal void .ctor(XmlNode parent) { }

	// RVA: 0xE56E40 Offset: 0xE55440 VA: 0x180E56E40
	public XmlAttribute get_ItemOf(int i) { }

	// RVA: 0xE57090 Offset: 0xE55690 VA: 0x180E57090
	public XmlAttribute get_ItemOf(string name) { }

	// RVA: 0xE56F30 Offset: 0xE55530 VA: 0x180E56F30
	public XmlAttribute get_ItemOf(string localName, string namespaceURI) { }

	// RVA: 0xE55E30 Offset: 0xE54430 VA: 0x180E55E30
	internal int FindNodeOffsetNS(XmlAttribute node) { }

	// RVA: 0xE56B60 Offset: 0xE55160 VA: 0x180E56B60 Slot: 6
	public override XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0xE55B90 Offset: 0xE54190 VA: 0x180E55B90
	public XmlAttribute Append(XmlAttribute node) { }

	// RVA: 0xE569F0 Offset: 0xE54FF0 VA: 0x180E569F0
	public XmlAttribute Remove(XmlAttribute node) { }

	// RVA: 0xE564B0 Offset: 0xE54AB0 VA: 0x180E564B0
	public XmlAttribute RemoveAt(int i) { }

	// RVA: 0xE563D0 Offset: 0xE549D0 VA: 0x180E563D0
	public void RemoveAll() { }

	// RVA: 0xE56D90 Offset: 0xE55390 VA: 0x180E56D90 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xE56E20 Offset: 0xE55420 VA: 0x180E56E20 Slot: 14
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0xE55990 Offset: 0xE53F90 VA: 0x180E55990 Slot: 9
	internal override XmlNode AddNode(XmlNode node) { }

	// RVA: 0xE55FD0 Offset: 0xE545D0 VA: 0x180E55FD0 Slot: 12
	internal override XmlNode InsertNodeAt(int i, XmlNode node) { }

	// RVA: 0xE56680 Offset: 0xE54C80 VA: 0x180E56680 Slot: 11
	internal override XmlNode RemoveNodeAt(int i) { }

	// RVA: 0xE55D60 Offset: 0xE54360 VA: 0x180E55D60
	internal void Detach(XmlAttribute attr) { }

	// RVA: 0xE56090 Offset: 0xE54690 VA: 0x180E56090
	internal void InsertParentIntoElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0xE56860 Offset: 0xE54E60 VA: 0x180E56860
	internal void RemoveParentFromElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0xE56570 Offset: 0xE54B70 VA: 0x180E56570
	internal int RemoveDuplicateAttribute(XmlAttribute attr) { }

	// RVA: 0xE562D0 Offset: 0xE548D0 VA: 0x180E562D0
	internal bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName) { }

	// RVA: 0xE56A80 Offset: 0xE55080 VA: 0x180E56A80
	internal void ResetParentInElementIdAttrMap(string oldVal, string newVal) { }

	// RVA: 0xE56220 Offset: 0xE54820 VA: 0x180E56220
	internal XmlAttribute InternalAppendAttribute(XmlAttribute node) { }

}

public class XmlCDataSection : XmlCharacterData // TypeDefIndex: 1949
{	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	internal override bool IsText { get; }

	// Methods

	// RVA: 0xE591C0 Offset: 0xE577C0 VA: 0x180E591C0
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0xE59200 Offset: 0xE57800 VA: 0x180E59200 Slot: 6
	public override string get_Name() { }

	// RVA: 0xE59200 Offset: 0xE57800 VA: 0x180E59200 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xE38BC0 Offset: 0xE371C0 VA: 0x180E38BC0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC98A0 Offset: 0xBC7EA0 VA: 0x180BC98A0 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0xE59120 Offset: 0xE57720 VA: 0x180E59120 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xE59180 Offset: 0xE57780 VA: 0x180E59180 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 55
	internal override bool get_IsText() { }

}

public abstract class XmlCharacterData : XmlLinkedNode // TypeDefIndex: 1950
{	// Fields
	private string data; // 0x20

	// Properties
	public override string Value { get; set; }
	public override string InnerText { get; set; }
	public virtual string Data { get; set; }

	// Methods

	// RVA: 0xE591C0 Offset: 0xE577C0 VA: 0x180E591C0
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0xBA5720 Offset: 0xBA3D20 VA: 0x180BA5720 Slot: 7
	public override string get_Value() { }

	// RVA: 0xE59EF0 Offset: 0xE584F0 VA: 0x180E59EF0 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x82C300 Offset: 0x82A900 VA: 0x18082C300 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0xE59ED0 Offset: 0xE584D0 VA: 0x180E59ED0 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0xE59DB0 Offset: 0xE583B0 VA: 0x180E59DB0 Slot: 56
	public virtual string get_Data() { }

	// RVA: 0xE59E00 Offset: 0xE58400 VA: 0x180E59E00 Slot: 57
	public virtual void set_Data(string value) { }

	// RVA: 0xE59D30 Offset: 0xE58330 VA: 0x180E59D30
	internal bool CheckOnData(string data) { }

}

internal sealed class XmlChildEnumerator : IEnumerator // TypeDefIndex: 1951
{	// Fields
	internal XmlNode container; // 0x10
	internal XmlNode child; // 0x18
	internal bool isFirst; // 0x20

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	internal XmlNode Current { get; }

	// Methods

	// RVA: 0xE5A070 Offset: 0xE58670 VA: 0x180E5A070
	internal void .ctor(XmlNode container) { }

	// RVA: 0xE59F10 Offset: 0xE58510 VA: 0x180E59F10 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0xE59F10 Offset: 0xE58510 VA: 0x180E59F10
	internal bool MoveNext() { }

	// RVA: 0xE59FB0 Offset: 0xE585B0 VA: 0x180E59FB0 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xE59FF0 Offset: 0xE585F0 VA: 0x180E59FF0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xE59FF0 Offset: 0xE585F0 VA: 0x180E59FF0
	internal XmlNode get_Current() { }

}

internal class XmlChildNodes : XmlNodeList // TypeDefIndex: 1952
{	// Fields
	private XmlNode container; // 0x10

	// Properties
	public override int Count { get; }

	// Methods

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(XmlNode container) { }

	// RVA: 0xE5A1E0 Offset: 0xE587E0 VA: 0x180E5A1E0 Slot: 6
	public override XmlNode Item(int i) { }

	// RVA: 0xE5A250 Offset: 0xE58850 VA: 0x180E5A250 Slot: 7
	public override int get_Count() { }

	// RVA: 0xE5A0E0 Offset: 0xE586E0 VA: 0x180E5A0E0 Slot: 8
	public override IEnumerator GetEnumerator() { }

}

public class XmlComment : XmlCharacterData // TypeDefIndex: 1953
{	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0xE591C0 Offset: 0xE577C0 VA: 0x180E591C0
	protected internal void .ctor(string comment, XmlDocument doc) { }

	// RVA: 0xE5A350 Offset: 0xE58950 VA: 0x180E5A350 Slot: 6
	public override string get_Name() { }

	// RVA: 0xE5A350 Offset: 0xE58950 VA: 0x180E5A350 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x8C1310 Offset: 0x8BF910 VA: 0x1808C1310 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xE5A2B0 Offset: 0xE588B0 VA: 0x180E5A2B0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xE5A310 Offset: 0xE58910 VA: 0x180E5A310 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

}

public class XmlDeclaration : XmlLinkedNode // TypeDefIndex: 1954
{	// Fields
	private string version; // 0x20
	private string encoding; // 0x28
	private string standalone; // 0x30

	// Properties
	public string Version { get; set; }
	public string Encoding { get; set; }
	public string Standalone { get; set; }
	public override string Value { get; set; }
	public override string InnerText { get; set; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0xE625A0 Offset: 0xE60BA0 VA: 0x180E625A0
	protected internal void .ctor(string version, string encoding, string standalone, XmlDocument doc) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Version() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	internal void set_Version(string value) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public string get_Encoding() { }

	// RVA: 0xE628E0 Offset: 0xE60EE0 VA: 0x180E628E0
	public void set_Encoding(string value) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_Standalone() { }

	// RVA: 0xE62C60 Offset: 0xE61260 VA: 0x180E62C60
	public void set_Standalone(string value) { }

	// RVA: 0xE57E60 Offset: 0xE56460 VA: 0x180E57E60 Slot: 7
	public override string get_Value() { }

	// RVA: 0xE58130 Offset: 0xE56730 VA: 0x180E58130 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0xE62770 Offset: 0xE60D70 VA: 0x180E62770 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0xE62950 Offset: 0xE60F50 VA: 0x180E62950 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0xE628A0 Offset: 0xE60EA0 VA: 0x180E628A0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x95FF30 Offset: 0x95E530 VA: 0x18095FF30 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xE628D0 Offset: 0xE60ED0 VA: 0x180E628D0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xE62430 Offset: 0xE60A30 VA: 0x180E62430 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xE62530 Offset: 0xE60B30 VA: 0x180E62530 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0xE62480 Offset: 0xE60A80 VA: 0x180E62480
	private bool IsValidXmlVersion(string ver) { }

}

public class XmlDocument : XmlNode // TypeDefIndex: 1955
{	// Fields
	private XmlImplementation implementation; // 0x18
	private DomNameTable domNameTable; // 0x20
	private XmlLinkedNode lastChild; // 0x28
	private XmlNamedNodeMap entities; // 0x30
	private Hashtable htElementIdMap; // 0x38
	private Hashtable htElementIDAttrDecl; // 0x40
	private SchemaInfo schemaInfo; // 0x48
	private XmlSchemaSet schemas; // 0x50
	private bool reportValidity; // 0x58
	private bool actualLoadingStatus; // 0x59
	private XmlNodeChangedEventHandler onNodeInsertingDelegate; // 0x60
	private XmlNodeChangedEventHandler onNodeInsertedDelegate; // 0x68
	private XmlNodeChangedEventHandler onNodeRemovingDelegate; // 0x70
	private XmlNodeChangedEventHandler onNodeRemovedDelegate; // 0x78
	private XmlNodeChangedEventHandler onNodeChangingDelegate; // 0x80
	private XmlNodeChangedEventHandler onNodeChangedDelegate; // 0x88
	internal bool fEntRefNodesPresent; // 0x90
	internal bool fCDataNodesPresent; // 0x91
	private bool preserveWhitespace; // 0x92
	private bool isLoading; // 0x93
	internal string strDocumentName; // 0x98
	internal string strDocumentFragmentName; // 0xA0
	internal string strCommentName; // 0xA8
	internal string strTextName; // 0xB0
	internal string strCDataSectionName; // 0xB8
	internal string strEntityName; // 0xC0
	internal string strID; // 0xC8
	internal string strXmlns; // 0xD0
	internal string strXml; // 0xD8
	internal string strSpace; // 0xE0
	internal string strLang; // 0xE8
	internal string strEmpty; // 0xF0
	internal string strNonSignificantWhitespaceName; // 0xF8
	internal string strSignificantWhitespaceName; // 0x100
	internal string strReservedXmlns; // 0x108
	internal string strReservedXml; // 0x110
	internal string baseURI; // 0x118
	private XmlResolver resolver; // 0x120
	internal bool bSetResolver; // 0x128
	internal object objLock; // 0x130
	internal static EmptyEnumerator EmptyEnumerator; // 0x0
	internal static IXmlSchemaInfo NotKnownSchemaInfo; // 0x8
	internal static IXmlSchemaInfo ValidSchemaInfo; // 0x10
	internal static IXmlSchemaInfo InvalidSchemaInfo; // 0x18

	// Properties
	internal SchemaInfo DtdSchemaInfo { get; set; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public virtual XmlDocumentType DocumentType { get; }
	internal virtual XmlDeclaration Declaration { get; }
	public XmlImplementation Implementation { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public XmlElement DocumentElement { get; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlDocument OwnerDocument { get; }
	public XmlSchemaSet Schemas { set; }
	internal bool CanReportValidity { get; }
	internal bool HasSetResolver { get; }
	public virtual XmlResolver XmlResolver { set; }
	public XmlNameTable NameTable { get; }
	public override bool IsReadOnly { get; }
	internal XmlNamedNodeMap Entities { get; set; }
	internal bool IsLoading { get; set; }
	internal bool ActualLoadingStatus { get; }
	public override string InnerText { set; }
	public override string InnerXml { set; }
	internal string Version { get; }
	internal string Encoding { get; }
	internal string Standalone { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override string BaseURI { get; }

	// Methods

	// RVA: 0xE67050 Offset: 0xE65650 VA: 0x180E67050
	public void .ctor() { }

	// RVA: 0xE66C00 Offset: 0xE65200 VA: 0x180E66C00
	public void .ctor(XmlNameTable nt) { }

	// RVA: 0xE66C70 Offset: 0xE65270 VA: 0x180E66C70
	protected internal void .ctor(XmlImplementation imp) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x5DD7A0 Offset: 0x5DBDA0 VA: 0x1805DD7A0
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

	// RVA: 0xE63A80 Offset: 0xE62080 VA: 0x180E63A80
	internal static void CheckName(string name) { }

	// RVA: 0xE63470 Offset: 0xE61A70 VA: 0x180E63470
	internal XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0xE65320 Offset: 0xE63920 VA: 0x180E65320
	internal XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0xE62D80 Offset: 0xE61380 VA: 0x180E62D80
	internal XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0xE63390 Offset: 0xE61990 VA: 0x180E63390
	internal bool AddIdInfo(XmlName eleName, XmlName attrName) { }

	// RVA: 0xE64F20 Offset: 0xE63520 VA: 0x180E64F20
	private XmlName GetIDInfoByElement_(XmlName eleName) { }

	// RVA: 0xE65030 Offset: 0xE63630 VA: 0x180E65030
	internal XmlName GetIDInfoByElement(XmlName eleName) { }

	// RVA: 0xE648C0 Offset: 0xE62EC0 VA: 0x180E648C0
	private WeakReference GetElement(ArrayList elementList, XmlElement elem) { }

	// RVA: 0xE63190 Offset: 0xE61790 VA: 0x180E63190
	internal void AddElementWithId(string id, XmlElement elem) { }

	// RVA: 0xE663F0 Offset: 0xE649F0 VA: 0x180E663F0
	internal void RemoveElementWithId(string id, XmlElement elem) { }

	// RVA: 0xE63BE0 Offset: 0xE621E0 VA: 0x180E63BE0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xE67360 Offset: 0xE65960 VA: 0x180E67360 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0xE67200 Offset: 0xE65800 VA: 0x180E67200 Slot: 56
	public virtual XmlDocumentType get_DocumentType() { }

	// RVA: 0xE670C0 Offset: 0xE656C0 VA: 0x180E670C0 Slot: 57
	internal virtual XmlDeclaration get_Declaration() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public XmlImplementation get_Implementation() { }

	// RVA: 0x574310 Offset: 0x572910 VA: 0x180574310 Slot: 6
	public override string get_Name() { }

	// RVA: 0x574310 Offset: 0x572910 VA: 0x180574310 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xE67170 Offset: 0xE65770 VA: 0x180E67170
	public XmlElement get_DocumentElement() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x5925C0 Offset: 0x590BC0 VA: 0x1805925C0
	internal bool get_CanReportValidity() { }

	// RVA: 0xE67340 Offset: 0xE65940 VA: 0x180E67340
	internal bool get_HasSetResolver() { }

	// RVA: 0x7A9690 Offset: 0x7A7C90 VA: 0x1807A9690
	internal XmlResolver GetResolver() { }

	// RVA: 0xE675A0 Offset: 0xE65BA0 VA: 0x180E675A0 Slot: 58
	public virtual void set_XmlResolver(XmlResolver value) { }

	// RVA: 0xE65D70 Offset: 0xE64370 VA: 0x180E65D70 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0xE653C0 Offset: 0xE639C0 VA: 0x180E653C0
	private bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0xE65350 Offset: 0xE63950 VA: 0x180E65350
	private bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0xE638C0 Offset: 0xE61EC0 VA: 0x180E638C0 Slot: 28
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0xE63770 Offset: 0xE61D70 VA: 0x180E63770 Slot: 29
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0xE63E10 Offset: 0xE62410 VA: 0x180E63E10
	public XmlAttribute CreateAttribute(string name) { }

	// RVA: 0xE66780 Offset: 0xE64D80 VA: 0x180E66780
	internal void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI) { }

	// RVA: 0xE63F40 Offset: 0xE62540 VA: 0x180E63F40 Slot: 59
	public virtual XmlCDataSection CreateCDataSection(string data) { }

	// RVA: 0xE63FC0 Offset: 0xE625C0 VA: 0x180E63FC0 Slot: 60
	public virtual XmlComment CreateComment(string data) { }

	// RVA: 0xE64120 Offset: 0xE62720 VA: 0x180E64120 Slot: 61
	public virtual XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0xE640C0 Offset: 0xE626C0 VA: 0x180E640C0 Slot: 62
	public virtual XmlDocumentFragment CreateDocumentFragment() { }

	// RVA: 0xE64270 Offset: 0xE62870 VA: 0x180E64270
	public XmlElement CreateElement(string name) { }

	// RVA: 0xE62ED0 Offset: 0xE614D0 VA: 0x180E62ED0
	internal void AddDefaultAttributes(XmlElement elem) { }

	// RVA: 0xE65210 Offset: 0xE63810 VA: 0x180E65210
	private SchemaElementDecl GetSchemaElementDecl(XmlElement elem) { }

	// RVA: 0xE66190 Offset: 0xE64790 VA: 0x180E66190
	private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0xE643F0 Offset: 0xE629F0 VA: 0x180E643F0 Slot: 63
	public virtual XmlEntityReference CreateEntityReference(string name) { }

	// RVA: 0xE64460 Offset: 0xE62A60 VA: 0x180E64460 Slot: 64
	public virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data) { }

	// RVA: 0xE64630 Offset: 0xE62C30 VA: 0x180E64630 Slot: 65
	public virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0xE64550 Offset: 0xE62B50 VA: 0x180E64550 Slot: 66
	public virtual XmlText CreateTextNode(string text) { }

	// RVA: 0xE644E0 Offset: 0xE62AE0 VA: 0x180E644E0 Slot: 67
	public virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text) { }

	// RVA: 0xE645C0 Offset: 0xE62BC0 VA: 0x180E645C0 Slot: 68
	public virtual XmlWhitespace CreateWhitespace(string text) { }

	// RVA: 0xE63D60 Offset: 0xE62360 VA: 0x180E63D60
	public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI) { }

	// RVA: 0xE641C0 Offset: 0xE627C0 VA: 0x180E641C0
	public XmlElement CreateElement(string qualifiedName, string namespaceURI) { }

	// RVA: 0xE656B0 Offset: 0xE63CB0 VA: 0x180E656B0
	private XmlNode ImportNodeInternal(XmlNode node, bool deep) { }

	// RVA: 0xE654A0 Offset: 0xE63AA0 VA: 0x180E654A0
	private void ImportAttributes(XmlNode fromElem, XmlNode toElem) { }

	// RVA: 0xE65600 Offset: 0xE63C00 VA: 0x180E65600
	private void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep) { }

	// RVA: 0xE57E40 Offset: 0xE56440 VA: 0x180E57E40
	public XmlNameTable get_NameTable() { }

	// RVA: 0xE63CC0 Offset: 0xE622C0 VA: 0x180E63CC0 Slot: 69
	public virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0xE64030 Offset: 0xE62630 VA: 0x180E64030 Slot: 70
	protected internal virtual XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0xE64320 Offset: 0xE62920 VA: 0x180E64320 Slot: 71
	public virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0xE672C0 Offset: 0xE658C0 VA: 0x180E672C0
	internal XmlNamedNodeMap get_Entities() { }

	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	internal void set_Entities(XmlNamedNodeMap value) { }

	// RVA: 0xE67350 Offset: 0xE65950 VA: 0x180E67350
	internal bool get_IsLoading() { }

	// RVA: 0xE67590 Offset: 0xE65B90 VA: 0x180E67590
	internal void set_IsLoading(bool value) { }

	// RVA: 0xAF6470 Offset: 0xAF4A70 VA: 0x180AF6470
	internal bool get_ActualLoadingStatus() { }

	// RVA: 0xE662F0 Offset: 0xE648F0 VA: 0x180E662F0 Slot: 72
	public virtual XmlNode ReadNode(XmlReader reader) { }

	// RVA: 0xE66830 Offset: 0xE64E30 VA: 0x180E66830
	private XmlTextReader SetupReader(XmlTextReader tr) { }

	// RVA: 0xE66070 Offset: 0xE64670 VA: 0x180E66070 Slot: 73
	public virtual void Load(XmlReader reader) { }

	// RVA: 0xE65F10 Offset: 0xE64510 VA: 0x180E65F10 Slot: 74
	public virtual void LoadXml(string xml) { }

	// RVA: 0xE67500 Offset: 0xE65B00 VA: 0x180E67500 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0xE67570 Offset: 0xE65B70 VA: 0x180E67570 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0xE66550 Offset: 0xE64B50 VA: 0x180E66550 Slot: 75
	public virtual void Save(XmlWriter w) { }

	// RVA: 0xE66AD0 Offset: 0xE650D0 VA: 0x180E66AD0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0xE66890 Offset: 0xE64E90 VA: 0x180E66890 Slot: 44
	public override void WriteContentTo(XmlWriter xw) { }

	// RVA: 0xE64E30 Offset: 0xE63430 VA: 0x180E64E30 Slot: 50
	internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0xE65140 Offset: 0xE63740 VA: 0x180E65140
	internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent) { }

	// RVA: 0xE63720 Offset: 0xE61D20 VA: 0x180E63720 Slot: 51
	internal override void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0xE634A0 Offset: 0xE61AA0 VA: 0x180E634A0 Slot: 52
	internal override void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0xE646C0 Offset: 0xE62CC0 VA: 0x180E646C0
	internal XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0xE674D0 Offset: 0xE65AD0 VA: 0x180E674D0
	internal string get_Version() { }

	// RVA: 0xE67290 Offset: 0xE65890 VA: 0x180E67290
	internal string get_Encoding() { }

	// RVA: 0xE674A0 Offset: 0xE65AA0 VA: 0x180E674A0
	internal string get_Standalone() { }

	// RVA: 0xE64D40 Offset: 0xE63340 VA: 0x180E64D40
	internal XmlEntity GetEntityNode(string name) { }

	// RVA: 0xE67370 Offset: 0xE65970 VA: 0x180E67370 Slot: 41
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xE670B0 Offset: 0xE656B0 VA: 0x180E670B0 Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0xE66770 Offset: 0xE64D70 VA: 0x180E66770
	internal void SetBaseURI(string inBaseURI) { }

	// RVA: 0xE634F0 Offset: 0xE61AF0 VA: 0x180E634F0 Slot: 26
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0xE66AF0 Offset: 0xE650F0 VA: 0x180E66AF0
	private static void .cctor() { }

}

public class XmlDocumentFragment : XmlNode // TypeDefIndex: 1956
{	// Fields
	private XmlLinkedNode lastChild; // 0x18

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override XmlDocument OwnerDocument { get; }
	public override string InnerXml { set; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }

	// Methods

	// RVA: 0x11BB7B0 Offset: 0x11B9DB0 VA: 0x1811BB7B0
	protected internal void .ctor(XmlDocument ownerDocument) { }

	// RVA: 0x11BB850 Offset: 0x11B9E50 VA: 0x1811BB850 Slot: 6
	public override string get_Name() { }

	// RVA: 0x11BB850 Offset: 0x11B9E50 VA: 0x1811BB850 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x11BB880 Offset: 0x11B9E80 VA: 0x1811BB880 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x11BB890 Offset: 0x11B9E90 VA: 0x1811BB890 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x11BB910 Offset: 0x11B9F10 VA: 0x1811BB910 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x11BB400 Offset: 0x11B9A00 VA: 0x1811BB400 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11BB4A0 Offset: 0x11B9AA0 VA: 0x1811BB4A0 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x11BB310 Offset: 0x11B9910 VA: 0x1811BB310 Slot: 29
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11BB390 Offset: 0x11B9990 VA: 0x1811BB390 Slot: 28
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0xE66AD0 Offset: 0xE650D0 VA: 0x180E66AD0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11BB550 Offset: 0x11B9B50 VA: 0x1811BB550 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

}

public class XmlDocumentType : XmlLinkedNode // TypeDefIndex: 1957
{	// Fields
	private string name; // 0x20
	private string publicId; // 0x28
	private string systemId; // 0x30
	private string internalSubset; // 0x38
	private bool namespaces; // 0x40
	private XmlNamedNodeMap entities; // 0x48
	private XmlNamedNodeMap notations; // 0x50
	private SchemaInfo schemaInfo; // 0x58

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override bool IsReadOnly { get; }
	public XmlNamedNodeMap Entities { get; }
	public XmlNamedNodeMap Notations { get; }
	public string PublicId { get; }
	public string SystemId { get; }
	public string InternalSubset { get; }
	internal bool ParseWithNamespaces { get; }
	internal SchemaInfo DtdSchemaInfo { get; set; }

	// Methods

	// RVA: 0x11BBA60 Offset: 0x11BA060 VA: 0x1811BBA60
	protected internal void .ctor(string name, string publicId, string systemId, string internalSubset, XmlDocument doc) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 6
	public override string get_Name() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x4A6020 Offset: 0x4A4620 VA: 0x1804A6020 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11BB9B0 Offset: 0x11B9FB0 VA: 0x1811BB9B0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x11BBC20 Offset: 0x11BA220 VA: 0x1811BBC20
	public XmlNamedNodeMap get_Entities() { }

	// RVA: 0x11BBCB0 Offset: 0x11BA2B0 VA: 0x1811BBCB0
	public XmlNamedNodeMap get_Notations() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public string get_PublicId() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_SystemId() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public string get_InternalSubset() { }

	// RVA: 0x805B90 Offset: 0x804190 VA: 0x180805B90
	internal bool get_ParseWithNamespaces() { }

	// RVA: 0x11BBA10 Offset: 0x11BA010 VA: 0x1811BBA10 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

}

public class XmlElement : XmlLinkedNode // TypeDefIndex: 1958
{	// Fields
	private XmlName name; // 0x20
	private XmlAttributeCollection attributes; // 0x28
	private XmlLinkedNode lastChild; // 0x30

	// Properties
	internal XmlName XmlName { get; set; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; set; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override XmlDocument OwnerDocument { get; }
	internal override bool IsContainer { get; }
	public bool IsEmpty { get; set; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlAttributeCollection Attributes { get; }
	public virtual bool HasAttributes { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override string InnerXml { set; }
	public override string InnerText { get; set; }
	public override XmlNode NextSibling { get; }

	// Methods

	// RVA: 0x11BDBA0 Offset: 0x11BC1A0 VA: 0x1811BDBA0
	internal void .ctor(XmlName name, bool empty, XmlDocument doc) { }

	// RVA: 0x11BDA10 Offset: 0x11BC010 VA: 0x1811BDA10
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal XmlName get_XmlName() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	internal void set_XmlName(XmlName value) { }

	// RVA: 0x11BC980 Offset: 0x11BAF80 VA: 0x1811BC980 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x11BDF30 Offset: 0x11BC530 VA: 0x1811BDF30 Slot: 6
	public override string get_Name() { }

	// RVA: 0x11BDF10 Offset: 0x11BC510 VA: 0x1811BDF10 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x11BDF50 Offset: 0x11BC550 VA: 0x1811BDF50 Slot: 33
	public override string get_NamespaceURI() { }

	// RVA: 0x11BDFD0 Offset: 0x11BC5D0 VA: 0x1811BDFD0 Slot: 34
	public override string get_Prefix() { }

	// RVA: 0x11BE1B0 Offset: 0x11BC7B0 VA: 0x1811BE1B0 Slot: 35
	public override void set_Prefix(string value) { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x11BDFB0 Offset: 0x11BC5B0 VA: 0x1811BDFB0 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x11BC7B0 Offset: 0x11BADB0 VA: 0x1811BC7B0 Slot: 26
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x11BDEF0 Offset: 0x11BC4F0 VA: 0x1811BDEF0
	public bool get_IsEmpty() { }

	// RVA: 0x11BE150 Offset: 0x11BC750 VA: 0x1811BE150
	public void set_IsEmpty(bool value) { }

	// RVA: 0x11BDF00 Offset: 0x11BC500 VA: 0x1811BDF00 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11BD0C0 Offset: 0x11BB6C0 VA: 0x1811BD0C0 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x11BDD70 Offset: 0x11BC370 VA: 0x1811BDD70 Slot: 14
	public override XmlAttributeCollection get_Attributes() { }

	// RVA: 0x11BDEB0 Offset: 0x11BC4B0 VA: 0x1811BDEB0 Slot: 56
	public virtual bool get_HasAttributes() { }

	// RVA: 0x11BCF80 Offset: 0x11BB580 VA: 0x1811BCF80 Slot: 57
	public virtual string GetAttribute(string name) { }

	// RVA: 0x11BD4E0 Offset: 0x11BBAE0 VA: 0x1811BD4E0 Slot: 58
	public virtual void SetAttribute(string name, string value) { }

	// RVA: 0x11BCF10 Offset: 0x11BB510 VA: 0x1811BCF10 Slot: 59
	public virtual XmlAttribute GetAttributeNode(string name) { }

	// RVA: 0x11BD290 Offset: 0x11BB890 VA: 0x1811BD290 Slot: 60
	public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr) { }

	// RVA: 0x11BD000 Offset: 0x11BB600 VA: 0x1811BD000 Slot: 61
	public virtual string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x11BD3B0 Offset: 0x11BB9B0 VA: 0x1811BD3B0 Slot: 62
	public virtual string SetAttribute(string localName, string namespaceURI, string value) { }

	// RVA: 0x11BCE90 Offset: 0x11BB490 VA: 0x1811BCE90 Slot: 63
	public virtual XmlAttribute GetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x11BD1A0 Offset: 0x11BB7A0 VA: 0x1811BD1A0 Slot: 64
	public virtual XmlAttribute SetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x11BD0A0 Offset: 0x11BB6A0 VA: 0x1811BD0A0 Slot: 65
	public virtual bool HasAttribute(string name) { }

	// RVA: 0x11BD900 Offset: 0x11BBF00 VA: 0x1811BD900 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11BD5C0 Offset: 0x11BBBC0 VA: 0x1811BD5C0
	private static void WriteElementTo(XmlWriter writer, XmlElement e) { }

	// RVA: 0x11BD7D0 Offset: 0x11BBDD0 VA: 0x1811BD7D0
	private void WriteStartElement(XmlWriter w) { }

	// RVA: 0xE57A00 Offset: 0xE56000 VA: 0x180E57A00 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11BD120 Offset: 0x11BB720 VA: 0x1811BD120 Slot: 66
	public virtual void RemoveAllAttributes() { }

	// RVA: 0x11BD170 Offset: 0x11BB770 VA: 0x1811BD170 Slot: 45
	public override void RemoveAll() { }

	// RVA: 0x11BD160 Offset: 0x11BB760 VA: 0x1811BD160
	internal void RemoveAllChildren() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 41
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11BE0D0 Offset: 0x11BC6D0 VA: 0x1811BE0D0 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x11BDEE0 Offset: 0x11BC4E0 VA: 0x1811BDEE0 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0x11BDFF0 Offset: 0x11BC5F0 VA: 0x1811BDFF0 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x11BDF70 Offset: 0x11BC570 VA: 0x1811BDF70 Slot: 13
	public override XmlNode get_NextSibling() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0 Slot: 47
	internal override void SetParent(XmlNode node) { }

}

public class XmlEntity : XmlNode // TypeDefIndex: 1959
{	// Fields
	private string publicId; // 0x18
	private string systemId; // 0x20
	private string notationName; // 0x28
	private string name; // 0x30
	private string unparsedReplacementStr; // 0x38
	private string baseURI; // 0x40
	private XmlLinkedNode lastChild; // 0x48
	private bool childrenFoliating; // 0x50

	// Properties
	public override bool IsReadOnly { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string InnerText { get; set; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlNodeType NodeType { get; }
	public string SystemId { get; }
	public override string InnerXml { set; }
	public override string BaseURI { get; }

	// Methods

	// RVA: 0x11C4010 Offset: 0x11C2610 VA: 0x1811C4010
	internal void .ctor(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc) { }

	// RVA: 0x11C3F80 Offset: 0x11C2580 VA: 0x1811C3F80 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x11BDEE0 Offset: 0x11BC4E0 VA: 0x1811BDEE0 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0x11C4260 Offset: 0x11C2860 VA: 0x1811C4260 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x11C4160 Offset: 0x11C2760 VA: 0x1811C4160 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x5DD7A0 Offset: 0x5DBDA0 VA: 0x1805DD7A0 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11C3FF0 Offset: 0x11C25F0 VA: 0x1811C3FF0 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x920210 Offset: 0x91E810 VA: 0x180920210 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_SystemId() { }

	// RVA: 0x11C42D0 Offset: 0x11C28D0 VA: 0x1811C42D0 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540 Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	internal void SetBaseURI(string inBaseURI) { }

}

public class XmlEntityReference : XmlLinkedNode // TypeDefIndex: 1960
{	// Fields
	private string name; // 0x20
	private XmlLinkedNode lastChild; // 0x28

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override string Value { get; set; }
	public override XmlNodeType NodeType { get; }
	public override bool IsReadOnly { get; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override string BaseURI { get; }
	internal string ChildBaseURI { get; }

	// Methods

	// RVA: 0x11C3BD0 Offset: 0x11C21D0 VA: 0x1811C3BD0
	protected internal void .ctor(string name, XmlDocument doc) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 6
	public override string get_Name() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 7
	public override string get_Value() { }

	// RVA: 0x11C3F10 Offset: 0x11C2510 VA: 0x1811C3F10 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x6F35A0 Offset: 0x6F1BA0 VA: 0x1806F35A0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11C3750 Offset: 0x11C1D50 VA: 0x1811C3750 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x11C3860 Offset: 0x11C1E60 VA: 0x1811C3860 Slot: 47
	internal override void SetParent(XmlNode node) { }

	// RVA: 0xE31130 Offset: 0xE2F730 VA: 0x180E31130 Slot: 48
	internal override void SetParentForLoad(XmlNode node) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11BD0C0 Offset: 0x11BB6C0 VA: 0x1811BD0C0 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x11C3BA0 Offset: 0x11C21A0 VA: 0x1811C3BA0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11C3940 Offset: 0x11C1F40 VA: 0x1811C3940 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11C3D60 Offset: 0x11C2360 VA: 0x1811C3D60 Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0x11C37A0 Offset: 0x11C1DA0 VA: 0x1811C37A0
	private string ConstructBaseURI(string baseURI, string systemId) { }

	// RVA: 0x11C3DA0 Offset: 0x11C23A0 VA: 0x1811C3DA0
	internal string get_ChildBaseURI() { }

}

public enum XmlNodeChangedAction // TypeDefIndex: 1961
{	// Fields
	public int value__; // 0x0
	public const XmlNodeChangedAction Insert = 0;
	public const XmlNodeChangedAction Remove = 1;
	public const XmlNodeChangedAction Change = 2;

}

public class XmlImplementation // TypeDefIndex: 1962
{	// Fields
	private XmlNameTable nameTable; // 0x10

	// Properties
	internal XmlNameTable NameTable { get; }

	// Methods

	// RVA: 0x11C7720 Offset: 0x11C5D20 VA: 0x1811C7720
	public void .ctor() { }

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	public void .ctor(XmlNameTable nt) { }

	// RVA: 0x11C76C0 Offset: 0x11C5CC0 VA: 0x1811C76C0 Slot: 4
	public virtual XmlDocument CreateDocument() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal XmlNameTable get_NameTable() { }

}

public abstract class XmlLinkedNode : XmlNode // TypeDefIndex: 1963
{	// Fields
	internal XmlLinkedNode next; // 0x18

	// Properties
	public override XmlNode PreviousSibling { get; }
	public override XmlNode NextSibling { get; }

	// Methods

	// RVA: 0x11C7790 Offset: 0x11C5D90 VA: 0x1811C7790
	internal void .ctor(XmlDocument doc) { }

	// RVA: 0x11C78A0 Offset: 0x11C5EA0 VA: 0x1811C78A0 Slot: 12
	public override XmlNode get_PreviousSibling() { }

	// RVA: 0x11C7840 Offset: 0x11C5E40 VA: 0x1811C7840 Slot: 13
	public override XmlNode get_NextSibling() { }

}

internal class XmlLoader // TypeDefIndex: 1964
{	// Fields
	private XmlDocument doc; // 0x10
	private XmlReader reader; // 0x18
	private bool preserveWhitespace; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x11CBA20 Offset: 0x11CA020 VA: 0x1811CBA20
	internal void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace) { }

	// RVA: 0x11C9B00 Offset: 0x11C8100 VA: 0x1811C9B00
	private void LoadDocSequence(XmlDocument parentDoc) { }

	// RVA: 0x11CC420 Offset: 0x11CAA20 VA: 0x1811CC420
	internal XmlNode ReadCurrentNode(XmlDocument doc, XmlReader reader) { }

	// RVA: 0x11CB360 Offset: 0x11C9960 VA: 0x1811CB360
	private XmlNode LoadNode(bool skipOverWhitespace) { }

	// RVA: 0x11C8F20 Offset: 0x11C7520 VA: 0x1811C8F20
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0x11C9740 Offset: 0x11C7D40 VA: 0x1811C9740
	private XmlAttribute LoadDefaultAttribute() { }

	// RVA: 0x11C9280 Offset: 0x11C7880 VA: 0x1811C9280
	private void LoadAttributeValue(XmlNode parent, bool direct) { }

	// RVA: 0x11CA8F0 Offset: 0x11C8EF0 VA: 0x1811CA8F0
	private XmlEntityReference LoadEntityReferenceNode(bool direct) { }

	// RVA: 0x11C9570 Offset: 0x11C7B70 VA: 0x1811C9570
	private XmlDeclaration LoadDeclarationNode() { }

	// RVA: 0x11C9B70 Offset: 0x11C8170 VA: 0x1811C9B70
	private XmlDocumentType LoadDocumentTypeNode() { }

	// RVA: 0x11CACE0 Offset: 0x11C92E0 VA: 0x1811CACE0
	private XmlNode LoadNodeDirect() { }

	// RVA: 0x11C89B0 Offset: 0x11C6FB0 VA: 0x1811C89B0
	private XmlAttribute LoadAttributeNodeDirect() { }

	// RVA: 0x11CBF70 Offset: 0x11CA570 VA: 0x1811CBF70
	internal void ParseDocumentType(XmlDocumentType dtNode) { }

	// RVA: 0x11CBD00 Offset: 0x11CA300 VA: 0x1811CBD00
	private void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver) { }

	// RVA: 0x11C9DA0 Offset: 0x11C83A0 VA: 0x1811C9DA0
	private void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode) { }

	// RVA: 0x11C8120 Offset: 0x11C6720 VA: 0x1811C8120
	private XmlParserContext GetContext(XmlNode node) { }

	// RVA: 0x11CBFF0 Offset: 0x11CA5F0 VA: 0x1811CBFF0
	internal XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt) { }

	// RVA: 0x11CAB40 Offset: 0x11C9140 VA: 0x1811CAB40
	internal void LoadInnerXmlElement(XmlElement node, string innerxmltext) { }

	// RVA: 0x11CAB20 Offset: 0x11C9120 VA: 0x1811CAB20
	internal void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext) { }

	// RVA: 0x11CC5C0 Offset: 0x11CABC0 VA: 0x1811CC5C0
	private void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs) { }

	// RVA: 0x11C7B50 Offset: 0x11C6150 VA: 0x1811C7B50
	private string EntitizeName(string name) { }

	// RVA: 0x11C8080 Offset: 0x11C6680 VA: 0x1811C8080
	internal void ExpandEntity(XmlEntity ent) { }

	// RVA: 0x11C7BA0 Offset: 0x11C61A0 VA: 0x1811C7BA0
	internal void ExpandEntityReference(XmlEntityReference eref) { }

	// RVA: 0x11C7920 Offset: 0x11C5F20 VA: 0x1811C7920
	private XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc) { }

	// RVA: 0x11CC220 Offset: 0x11CA820 VA: 0x1811CC220
	internal static void ParseXmlDeclarationValue(string strValue, out string version, out string encoding, out string standalone) { }

	// RVA: 0x11CC8E0 Offset: 0x11CAEE0 VA: 0x1811CC8E0
	internal static Exception UnexpectedNodeType(XmlNodeType nodetype) { }

}

internal class XmlName : IXmlSchemaInfo // TypeDefIndex: 1965
{	// Fields
	private string prefix; // 0x10
	private string localName; // 0x18
	private string ns; // 0x20
	private string name; // 0x28
	private int hashCode; // 0x30
	internal XmlDocument ownerDoc; // 0x38
	internal XmlName next; // 0x40

	// Properties
	public string LocalName { get; }
	public string NamespaceURI { get; }
	public string Prefix { get; }
	public int HashCode { get; }
	public XmlDocument OwnerDocument { get; }
	public string Name { get; }
	public virtual XmlSchemaValidity Validity { get; }
	public virtual bool IsDefault { get; }
	public virtual bool IsNil { get; }
	public virtual XmlSchemaSimpleType MemberType { get; }
	public virtual XmlSchemaType SchemaType { get; }
	public virtual XmlSchemaElement SchemaElement { get; }
	public virtual XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: 0x11CCF00 Offset: 0x11CB500 VA: 0x1811CCF00
	public static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x11CD190 Offset: 0x11CB790 VA: 0x1811CD190
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_LocalName() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_NamespaceURI() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Prefix() { }

	// RVA: 0xA39490 Offset: 0xA37A90 VA: 0x180A39490
	public int get_HashCode() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public XmlDocument get_OwnerDocument() { }

	// RVA: 0x11CD240 Offset: 0x11CB840 VA: 0x1811CD240
	public string get_Name() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 11
	public virtual XmlSchemaValidity get_Validity() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 12
	public virtual bool get_IsDefault() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 13
	public virtual bool get_IsNil() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 14
	public virtual XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 15
	public virtual XmlSchemaType get_SchemaType() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 16
	public virtual XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 17
	public virtual XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0xDF0D80 Offset: 0xDEF380 VA: 0x180DF0D80 Slot: 18
	public virtual bool Equals(IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x11CD120 Offset: 0x11CB720 VA: 0x1811CD120
	public static int GetHashCode(string name) { }

}

internal sealed class XmlNameEx : XmlName // TypeDefIndex: 1966
{	// Fields
	private byte flags; // 0x48
	private XmlSchemaSimpleType memberType; // 0x50
	private XmlSchemaType schemaType; // 0x58
	private object decl; // 0x60

	// Properties
	public override XmlSchemaValidity Validity { get; }
	public override bool IsDefault { get; }
	public override bool IsNil { get; }
	public override XmlSchemaSimpleType MemberType { get; }
	public override XmlSchemaType SchemaType { get; }
	public override XmlSchemaElement SchemaElement { get; }
	public override XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: 0x11CCC10 Offset: 0x11CB210 VA: 0x1811CCC10
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x11CCED0 Offset: 0x11CB4D0 VA: 0x1811CCED0 Slot: 11
	public override XmlSchemaValidity get_Validity() { }

	// RVA: 0x11CCDB0 Offset: 0x11CB3B0 VA: 0x1811CCDB0 Slot: 12
	public override bool get_IsDefault() { }

	// RVA: 0x11CCDC0 Offset: 0x11CB3C0 VA: 0x1811CCDC0 Slot: 13
	public override bool get_IsNil() { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800 Slot: 14
	public override XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0 Slot: 15
	public override XmlSchemaType get_SchemaType() { }

	// RVA: 0x11CCE50 Offset: 0x11CB450 VA: 0x1811CCE50 Slot: 16
	public override XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x11CCDD0 Offset: 0x11CB3D0 VA: 0x1811CCDD0 Slot: 17
	public override XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x11CCC00 Offset: 0x11CB200 VA: 0x1811CCC00
	public void SetValidity(XmlSchemaValidity value) { }

	// RVA: 0x11CCBA0 Offset: 0x11CB1A0 VA: 0x1811CCBA0
	public void SetIsDefault(bool value) { }

	// RVA: 0x11CCBD0 Offset: 0x11CB1D0 VA: 0x1811CCBD0
	public void SetIsNil(bool value) { }

	// RVA: 0x11CC9E0 Offset: 0x11CAFE0 VA: 0x1811CC9E0 Slot: 18
	public override bool Equals(IXmlSchemaInfo schemaInfo) { }

}

public class XmlNamedNodeMap : IEnumerable // TypeDefIndex: 1967
{	// Fields
	internal XmlNode parent; // 0x10
	internal XmlNamedNodeMap.SmallXmlNodeList nodes; // 0x18

	// Properties
	public virtual int Count { get; }

	// Methods

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	internal void .ctor(XmlNode parent) { }

	// RVA: 0x11CD8E0 Offset: 0x11CBEE0 VA: 0x1811CD8E0 Slot: 5
	public virtual XmlNode GetNamedItem(string name) { }

	// RVA: 0x11CDE50 Offset: 0x11CC450 VA: 0x1811CDE50 Slot: 6
	public virtual XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x11CE030 Offset: 0x11CC630 VA: 0x1811CE030 Slot: 7
	public virtual int get_Count() { }

	// RVA: 0x11CD8D0 Offset: 0x11CBED0 VA: 0x1811CD8D0 Slot: 8
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x11CD690 Offset: 0x11CBC90 VA: 0x1811CD690
	internal int FindNodeOffset(string name) { }

	// RVA: 0x11CD790 Offset: 0x11CBD90 VA: 0x1811CD790
	internal int FindNodeOffset(string localName, string namespaceURI) { }

	// RVA: 0x11CD4B0 Offset: 0x11CBAB0 VA: 0x1811CD4B0 Slot: 9
	internal virtual XmlNode AddNode(XmlNode node) { }

	// RVA: 0x11CD3F0 Offset: 0x11CB9F0 VA: 0x1811CD3F0 Slot: 10
	internal virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc) { }

	// RVA: 0x11CDC60 Offset: 0x11CC260 VA: 0x1811CDC60 Slot: 11
	internal virtual XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x11CDDE0 Offset: 0x11CC3E0 VA: 0x1811CDDE0
	internal XmlNode ReplaceNodeAt(int i, XmlNode node) { }

	// RVA: 0x11CDA70 Offset: 0x11CC070 VA: 0x1811CDA70 Slot: 12
	internal virtual XmlNode InsertNodeAt(int i, XmlNode node) { }

}

internal struct XmlNamedNodeMap.SmallXmlNodeList // TypeDefIndex: 1968
{	// Fields
	private object field; // 0x0

	// Properties
	public int Count { get; }
	public object Item { get; }

	// Methods

	// RVA: 0x1D1260 Offset: 0x1D0660 VA: 0x1801D1260
	public int get_Count() { }

	// RVA: 0x1D1270 Offset: 0x1D0670 VA: 0x1801D1270
	public object get_Item(int index) { }

	// RVA: 0x1D1220 Offset: 0x1D0620 VA: 0x1801D1220
	public void Add(object value) { }

	// RVA: 0x1D1250 Offset: 0x1D0650 VA: 0x1801D1250
	public void RemoveAt(int index) { }

	// RVA: 0x1D1240 Offset: 0x1D0640 VA: 0x1801D1240
	public void Insert(int index, object value) { }

	// RVA: 0x1D1230 Offset: 0x1D0630 VA: 0x1801D1230
	public IEnumerator GetEnumerator() { }

}

private class XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator : IEnumerator // TypeDefIndex: 1969
{	// Fields
	private object loneValue; // 0x10
	private int position; // 0x18

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x11BA3C0 Offset: 0x11B89C0 VA: 0x1811BA3C0
	public void .ctor(object value) { }

	// RVA: 0x11BA400 Offset: 0x11B8A00 VA: 0x1811BA400 Slot: 5
	public object get_Current() { }

	// RVA: 0x11BA3A0 Offset: 0x11B89A0 VA: 0x1811BA3A0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1180FF0 Offset: 0x117F5F0 VA: 0x181180FF0 Slot: 6
	public void Reset() { }

}

public abstract class XmlNode : ICloneable, IEnumerable // TypeDefIndex: 1970
{	// Fields
	internal XmlNode parentNode; // 0x10

	// Properties
	public abstract string Name { get; }
	public virtual string Value { get; set; }
	public abstract XmlNodeType NodeType { get; }
	public virtual XmlNode ParentNode { get; }
	public virtual XmlNodeList ChildNodes { get; }
	public virtual XmlNode PreviousSibling { get; }
	public virtual XmlNode NextSibling { get; }
	public virtual XmlAttributeCollection Attributes { get; }
	public virtual XmlDocument OwnerDocument { get; }
	public virtual XmlNode FirstChild { get; }
	public virtual XmlNode LastChild { get; }
	internal virtual bool IsContainer { get; }
	internal virtual XmlLinkedNode LastNode { get; set; }
	public virtual bool HasChildNodes { get; }
	public virtual string NamespaceURI { get; }
	public virtual string Prefix { get; set; }
	public abstract string LocalName { get; }
	public virtual bool IsReadOnly { get; }
	public virtual string InnerText { get; set; }
	public virtual string InnerXml { set; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }
	public virtual string BaseURI { get; }
	internal XmlDocument Document { get; }
	internal virtual XmlSpace XmlSpace { get; }
	internal virtual string XmlLang { get; }
	internal virtual bool IsText { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x11D2B80 Offset: 0x11D1180 VA: 0x1811D2B80
	internal void .ctor(XmlDocument doc) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_Name();

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 7
	public virtual string get_Value() { }

	// RVA: 0x11D3780 Offset: 0x11D1D80 VA: 0x1811D3780 Slot: 8
	public virtual void set_Value(string value) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x11D3220 Offset: 0x11D1820 VA: 0x1811D3220 Slot: 10
	public virtual XmlNode get_ParentNode() { }

	// RVA: 0x11D2D60 Offset: 0x11D1360 VA: 0x1811D2D60 Slot: 11
	public virtual XmlNodeList get_ChildNodes() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 12
	public virtual XmlNode get_PreviousSibling() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 13
	public virtual XmlNode get_NextSibling() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 14
	public virtual XmlAttributeCollection get_Attributes() { }

	// RVA: 0x11D3150 Offset: 0x11D1750 VA: 0x1811D3150 Slot: 15
	public virtual XmlDocument get_OwnerDocument() { }

	// RVA: 0x11D2E60 Offset: 0x11D1460 VA: 0x1811D2E60 Slot: 16
	public virtual XmlNode get_FirstChild() { }

	// RVA: 0x11D30F0 Offset: 0x11D16F0 VA: 0x1811D30F0 Slot: 17
	public virtual XmlNode get_LastChild() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 18
	internal virtual bool get_IsContainer() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 19
	internal virtual XmlLinkedNode get_LastNode() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 20
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11D0420 Offset: 0x11CEA20 VA: 0x1811D0420
	internal bool AncestorNode(XmlNode node) { }

	// RVA: 0x11D1D40 Offset: 0x11D0340 VA: 0x1811D1D40 Slot: 21
	public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11D1650 Offset: 0x11CFC50 VA: 0x1811D1650 Slot: 22
	public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11D2530 Offset: 0x11D0B30 VA: 0x1811D2530 Slot: 23
	public virtual XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x11D2460 Offset: 0x11D0A60 VA: 0x1811D2460 Slot: 24
	public virtual XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0x11D0780 Offset: 0x11CED80 VA: 0x1811D0780 Slot: 25
	public virtual XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x11D0490 Offset: 0x11CEA90 VA: 0x1811D0490 Slot: 26
	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 27
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 28
	internal virtual bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 29
	internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11D2E90 Offset: 0x11D1490 VA: 0x1811D2E90 Slot: 30
	public virtual bool get_HasChildNodes() { }

	// RVA: -1 Offset: -1 Slot: 31
	public abstract XmlNode CloneNode(bool deep);

	// RVA: 0x11D0D60 Offset: 0x11CF360 VA: 0x1811D0D60 Slot: 32
	internal virtual void CopyChildren(XmlDocument doc, XmlNode container, bool deep) { }

	// RVA: 0x11D3110 Offset: 0x11D1710 VA: 0x1811D3110 Slot: 33
	public virtual string get_NamespaceURI() { }

	// RVA: 0x11D3310 Offset: 0x11D1910 VA: 0x1811D3310 Slot: 34
	public virtual string get_Prefix() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 35
	public virtual void set_Prefix(string value) { }

	// RVA: -1 Offset: -1 Slot: 36
	public abstract string get_LocalName();

	// RVA: 0x11D2FC0 Offset: 0x11D15C0 VA: 0x1811D2FC0 Slot: 37
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x11D1530 Offset: 0x11CFB30 VA: 0x1811D1530
	internal static bool HasReadOnlyParent(XmlNode n) { }

	// RVA: 0x11D2B20 Offset: 0x11D1120 VA: 0x1811D2B20 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x11D2AC0 Offset: 0x11D10C0 VA: 0x1811D2AC0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x11D0E90 Offset: 0x11CF490 VA: 0x1811D0E90
	public IEnumerator GetEnumerator() { }

	// RVA: 0x11D0670 Offset: 0x11CEC70 VA: 0x1811D0670
	private void AppendChildText(StringBuilder builder) { }

	// RVA: 0x11D2EB0 Offset: 0x11D14B0 VA: 0x1811D2EB0 Slot: 38
	public virtual string get_InnerText() { }

	// RVA: 0x11D3610 Offset: 0x11D1C10 VA: 0x1811D3610 Slot: 39
	public virtual void set_InnerText(string value) { }

	// RVA: 0x11D3710 Offset: 0x11D1D10 VA: 0x1811D3710 Slot: 40
	public virtual void set_InnerXml(string value) { }

	// RVA: 0x11D3350 Offset: 0x11D1950 VA: 0x1811D3350 Slot: 41
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11D2C20 Offset: 0x11D1220 VA: 0x1811D2C20 Slot: 42
	public virtual string get_BaseURI() { }

	// RVA: -1 Offset: -1 Slot: 43
	public abstract void WriteTo(XmlWriter w);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract void WriteContentTo(XmlWriter w);

	// RVA: 0x11D24B0 Offset: 0x11D0AB0 VA: 0x1811D24B0 Slot: 45
	public virtual void RemoveAll() { }

	// RVA: 0x11D2DC0 Offset: 0x11D13C0 VA: 0x1811D2DC0
	internal XmlDocument get_Document() { }

	// RVA: 0x11D14D0 Offset: 0x11CFAD0 VA: 0x1811D14D0 Slot: 46
	public virtual string GetPrefixOfNamespace(string namespaceURI) { }

	// RVA: 0x11D1020 Offset: 0x11CF620 VA: 0x1811D1020
	internal string GetPrefixOfNamespaceStrict(string namespaceURI) { }

	// RVA: 0x11D29A0 Offset: 0x11D0FA0 VA: 0x1811D29A0 Slot: 47
	internal virtual void SetParent(XmlNode node) { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0 Slot: 48
	internal virtual void SetParentForLoad(XmlNode node) { }

	// RVA: 0x11D29E0 Offset: 0x11D0FE0 VA: 0x1811D29E0
	internal static void SplitName(string name, out string prefix, out string localName) { }

	// RVA: 0x11D0E10 Offset: 0x11CF410 VA: 0x1811D0E10 Slot: 49
	internal virtual XmlNode FindChild(XmlNodeType type) { }

	// RVA: 0x11D0EF0 Offset: 0x11CF4F0 VA: 0x1811D0EF0 Slot: 50
	internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x11D0D10 Offset: 0x11CF310 VA: 0x1811D0D10 Slot: 51
	internal virtual void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x11D03D0 Offset: 0x11CE9D0 VA: 0x1811D03D0 Slot: 52
	internal virtual void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x11D34B0 Offset: 0x11D1AB0 VA: 0x1811D34B0 Slot: 53
	internal virtual XmlSpace get_XmlSpace() { }

	// RVA: 0x11D33B0 Offset: 0x11D19B0 VA: 0x1811D33B0 Slot: 54
	internal virtual string get_XmlLang() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 55
	internal virtual bool get_IsText() { }

	// RVA: 0x11D2430 Offset: 0x11D0A30 VA: 0x1811D2430
	internal static void NestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

	// RVA: 0x11D2B40 Offset: 0x11D1140 VA: 0x1811D2B40
	internal static void UnnestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

}

public class XmlNodeChangedEventArgs : EventArgs // TypeDefIndex: 1971
{	// Fields
	private XmlNodeChangedAction action; // 0x10
	private XmlNode node; // 0x18
	private XmlNode oldParent; // 0x20
	private XmlNode newParent; // 0x28
	private string oldValue; // 0x30
	private string newValue; // 0x38

	// Properties
	public XmlNodeChangedAction Action { get; }

	// Methods

	// RVA: 0x11CEFB0 Offset: 0x11CD5B0 VA: 0x1811CEFB0
	public void .ctor(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public XmlNodeChangedAction get_Action() { }

}

public sealed class XmlNodeChangedEventHandler : MulticastDelegate // TypeDefIndex: 1972
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4D50 Offset: 0xAE3350 VA: 0x180AE4D50 Slot: 12
	public virtual void Invoke(object sender, XmlNodeChangedEventArgs e) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, XmlNodeChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public abstract class XmlNodeList : IEnumerable, IDisposable // TypeDefIndex: 1973
{	// Properties
	public abstract int Count { get; }
	public virtual XmlNode ItemOf { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract XmlNode Item(int index);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_Count();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IEnumerator GetEnumerator();

	// RVA: 0x11CF080 Offset: 0x11CD680 VA: 0x1811CF080 Slot: 9
	public virtual XmlNode get_ItemOf(int i) { }

	// RVA: 0xE3BF00 Offset: 0xE3A500 VA: 0x180E3BF00 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected virtual void PrivateDisposeNodeList() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

internal class XmlNodeReaderNavigator // TypeDefIndex: 1974
{	// Fields
	private XmlNode curNode; // 0x10
	private XmlNode elemNode; // 0x18
	private XmlNode logNode; // 0x20
	private int attrIndex; // 0x28
	private int logAttrIndex; // 0x2C
	private XmlNameTable nameTable; // 0x30
	private XmlDocument doc; // 0x38
	private int nAttrInd; // 0x40
	private int nDeclarationAttrCount; // 0x44
	private int nDocTypeAttrCount; // 0x48
	private int nLogLevel; // 0x4C
	private int nLogAttrInd; // 0x50
	private bool bLogOnAttrVal; // 0x54
	private bool bCreatedOnAttribute; // 0x55
	internal XmlNodeReaderNavigator.VirtualAttribute[] decNodeAttributes; // 0x58
	internal XmlNodeReaderNavigator.VirtualAttribute[] docTypeNodeAttributes; // 0x60
	private bool bOnAttrVal; // 0x68

	// Properties
	public XmlNodeType NodeType { get; }
	public string NamespaceURI { get; }
	public string Name { get; }
	public string LocalName { get; }
	internal bool CreatedOnAttribute { get; }
	public string Prefix { get; }
	public string Value { get; }
	public string BaseURI { get; }
	public XmlSpace XmlSpace { get; }
	public string XmlLang { get; }
	public bool IsEmptyElement { get; }
	public bool IsDefault { get; }
	public IXmlSchemaInfo SchemaInfo { get; }
	public XmlNameTable NameTable { get; }
	public int AttributeCount { get; }
	private bool IsOnDeclOrDocType { get; }
	public XmlDocument Document { get; }

	// Methods

	// RVA: 0xB9EAE0 Offset: 0xB9D0E0 VA: 0x180B9EAE0
	public void .ctor(XmlNode node) { }

	// RVA: 0xB9F600 Offset: 0xB9DC00 VA: 0x180B9F600
	public XmlNodeType get_NodeType() { }

	// RVA: 0xB9F5D0 Offset: 0xB9DBD0 VA: 0x180B9F5D0
	public string get_NamespaceURI() { }

	// RVA: 0xB9F480 Offset: 0xB9DA80 VA: 0x180B9F480
	public string get_Name() { }

	// RVA: 0xB9F270 Offset: 0xB9D870 VA: 0x180B9F270
	public string get_LocalName() { }

	// RVA: 0xB9F030 Offset: 0xB9D630 VA: 0x180B9F030
	internal bool get_CreatedOnAttribute() { }

	// RVA: 0xB9D270 Offset: 0xB9B870 VA: 0x180B9D270
	private bool IsLocalNameEmpty(XmlNodeType nt) { }

	// RVA: 0xB9F640 Offset: 0xB9DC40 VA: 0x180B9F640
	public string get_Prefix() { }

	// RVA: 0xB9F6A0 Offset: 0xB9DCA0 VA: 0x180B9F6A0
	public string get_Value() { }

	// RVA: 0xB9F000 Offset: 0xB9D600 VA: 0x180B9F000
	public string get_BaseURI() { }

	// RVA: 0xB9F9A0 Offset: 0xB9DFA0 VA: 0x180B9F9A0
	public XmlSpace get_XmlSpace() { }

	// RVA: 0xB9F970 Offset: 0xB9DF70 VA: 0x180B9F970
	public string get_XmlLang() { }

	// RVA: 0xB9F140 Offset: 0xB9D740 VA: 0x180B9F140
	public bool get_IsEmptyElement() { }

	// RVA: 0xB9F040 Offset: 0xB9D640 VA: 0x180B9F040
	public bool get_IsDefault() { }

	// RVA: 0xB9F670 Offset: 0xB9DC70 VA: 0x180B9F670
	public IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public XmlNameTable get_NameTable() { }

	// RVA: 0xB9EE70 Offset: 0xB9D470 VA: 0x180B9EE70
	public int get_AttributeCount() { }

	// RVA: 0xB9BA20 Offset: 0xB9A020 VA: 0x180B9BA20
	private void CheckIndexCondition(int attributeIndex) { }

	// RVA: 0xB9CED0 Offset: 0xB9B4D0 VA: 0x180B9CED0
	private void InitDecAttr() { }

	// RVA: 0xB9C7A0 Offset: 0xB9ADA0 VA: 0x180B9C7A0
	public string GetDeclarationAttr(XmlDeclaration decl, string name) { }

	// RVA: 0xB9C740 Offset: 0xB9AD40 VA: 0x180B9C740
	public string GetDeclarationAttr(int i) { }

	// RVA: 0xB9C6A0 Offset: 0xB9ACA0 VA: 0x180B9C6A0
	public int GetDecAttrInd(string name) { }

	// RVA: 0xB9D100 Offset: 0xB9B700 VA: 0x180B9D100
	private void InitDocTypeAttr() { }

	// RVA: 0xB9C900 Offset: 0xB9AF00 VA: 0x180B9C900
	public string GetDocumentTypeAttr(XmlDocumentType docType, string name) { }

	// RVA: 0xB9C9A0 Offset: 0xB9AFA0 VA: 0x180B9C9A0
	public string GetDocumentTypeAttr(int i) { }

	// RVA: 0xB9C860 Offset: 0xB9AE60 VA: 0x180B9C860
	public int GetDocTypeAttrInd(string name) { }

	// RVA: 0xB9BC30 Offset: 0xB9A230 VA: 0x180B9BC30
	private string GetAttributeFromElement(XmlElement elem, string name) { }

	// RVA: 0xB9C320 Offset: 0xB9A920 VA: 0x180B9C320
	public string GetAttribute(string name) { }

	// RVA: 0xB9BBD0 Offset: 0xB9A1D0 VA: 0x180B9BBD0
	private string GetAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0xB9BF70 Offset: 0xB9A570 VA: 0x180B9BF70
	public string GetAttribute(string name, string ns) { }

	// RVA: 0xB9BC80 Offset: 0xB9A280 VA: 0x180B9BC80
	public string GetAttribute(int attributeIndex) { }

	// RVA: 0xB9D2C0 Offset: 0xB9B8C0 VA: 0x180B9D2C0
	public void LogMove(int level) { }

	// RVA: 0xB9EA90 Offset: 0xB9D090 VA: 0x180B9EA90
	public void RollBackMove(ref int level) { }

	// RVA: 0xB9F230 Offset: 0xB9D830 VA: 0x180B9F230
	private bool get_IsOnDeclOrDocType() { }

	// RVA: 0xB9E9B0 Offset: 0xB9CFB0 VA: 0x180B9E9B0
	public void ResetToAttribute(ref int level) { }

	// RVA: 0xB9E6F0 Offset: 0xB9CCF0 VA: 0x180B9E6F0
	public void ResetMove(ref int level, ref XmlNodeType nt) { }

	// RVA: 0xB9DD70 Offset: 0xB9C370 VA: 0x180B9DD70
	public bool MoveToAttribute(string name) { }

	// RVA: 0xB9DA00 Offset: 0xB9C000 VA: 0x180B9DA00
	private bool MoveToAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0xB9DAE0 Offset: 0xB9C0E0 VA: 0x180B9DAE0
	public bool MoveToAttribute(string name, string namespaceURI) { }

	// RVA: 0xB9DDD0 Offset: 0xB9C3D0 VA: 0x180B9DDD0
	public void MoveToAttribute(int attributeIndex) { }

	// RVA: 0xB9E150 Offset: 0xB9C750 VA: 0x180B9E150
	public bool MoveToNextAttribute(ref int level) { }

	// RVA: 0xB9E450 Offset: 0xB9CA50 VA: 0x180B9E450
	public bool MoveToParent() { }

	// RVA: 0xB9E0E0 Offset: 0xB9C6E0 VA: 0x180B9E0E0
	public bool MoveToFirstChild() { }

	// RVA: 0xB9E360 Offset: 0xB9C960 VA: 0x180B9E360
	private bool MoveToNextSibling(XmlNode node) { }

	// RVA: 0xB9E3C0 Offset: 0xB9C9C0 VA: 0x180B9E3C0
	public bool MoveToNext() { }

	// RVA: 0xB9E040 Offset: 0xB9C640 VA: 0x180B9E040
	public bool MoveToElement() { }

	// RVA: 0xB9D300 Offset: 0xB9B900 VA: 0x180B9D300
	public string LookupNamespace(string prefix) { }

	// RVA: 0xB9BAA0 Offset: 0xB9A0A0 VA: 0x180B9BAA0
	internal string DefaultLookupNamespace(string prefix) { }

	// RVA: 0xB9D5E0 Offset: 0xB9BBE0 VA: 0x180B9D5E0
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0xB9CA00 Offset: 0xB9B000 VA: 0x180B9CA00
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xB9E4C0 Offset: 0xB9CAC0 VA: 0x180B9E4C0
	public bool ReadAttributeValue(ref int level, ref bool bResolveEntity, ref XmlNodeType nt) { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public XmlDocument get_Document() { }

}

internal struct XmlNodeReaderNavigator.VirtualAttribute // TypeDefIndex: 1975
{	// Fields
	internal string name; // 0x0
	internal string value; // 0x8

	// Methods

	// RVA: 0xF5DB0 Offset: 0xF51B0 VA: 0x1800F5DB0
	internal void .ctor(string name, string value) { }

}

public class XmlNodeReader : XmlReader, IXmlNamespaceResolver // TypeDefIndex: 1976
{	// Fields
	private XmlNodeReaderNavigator readerNav; // 0x10
	private XmlNodeType nodeType; // 0x18
	private int curDepth; // 0x1C
	private ReadState readState; // 0x20
	private bool fEOF; // 0x24
	private bool bResolveEntity; // 0x25
	private bool bStartFromDocument; // 0x26
	private bool bInReadBinary; // 0x27
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool CanResolveEntity { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override bool HasAttributes { get; }
	public override XmlNameTable NameTable { get; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x11CFF40 Offset: 0x11CE540 VA: 0x1811CFF40
	public void .ctor(XmlNode node) { }

	// RVA: 0x11CF230 Offset: 0x11CD830 VA: 0x1811CF230
	internal bool IsInReadingStates() { }

	// RVA: 0x11D0240 Offset: 0x11CE840 VA: 0x1811D0240 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11D0180 Offset: 0x11CE780 VA: 0x1811D0180 Slot: 7
	public override string get_Name() { }

	// RVA: 0x11D0120 Offset: 0x11CE720 VA: 0x1811D0120 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x11D01E0 Offset: 0x11CE7E0 VA: 0x1811D01E0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x11D0250 Offset: 0x11CE850 VA: 0x1811D0250 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x11D02E0 Offset: 0x11CE8E0 VA: 0x1811D02E0 Slot: 11
	public override string get_Value() { }

	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x11D0060 Offset: 0x11CE660 VA: 0x1811D0060 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x11D00F0 Offset: 0x11CE6F0 VA: 0x1811D00F0 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x11D00C0 Offset: 0x11CE6C0 VA: 0x1811D00C0 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x11D03A0 Offset: 0x11CE9A0 VA: 0x1811D03A0 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x11D0340 Offset: 0x11CE940 VA: 0x1811D0340 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x11D02B0 Offset: 0x11CE8B0 VA: 0x1811D02B0 Slot: 19
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11D0020 Offset: 0x11CE620 VA: 0x1811D0020 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x11CF0E0 Offset: 0x11CD6E0 VA: 0x1811CF0E0 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x11CF110 Offset: 0x11CD710 VA: 0x1811CF110 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x11CF1A0 Offset: 0x11CD7A0 VA: 0x1811CF1A0 Slot: 24
	public override string GetAttribute(int attributeIndex) { }

	// RVA: 0x11CF420 Offset: 0x11CDA20 VA: 0x1811CF420 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x11CF280 Offset: 0x11CD880 VA: 0x1811CF280 Slot: 26
	public override void MoveToAttribute(int attributeIndex) { }

	// RVA: 0x11CF5C0 Offset: 0x11CDBC0 VA: 0x1811CF5C0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x11CF6A0 Offset: 0x11CDCA0 VA: 0x1811CF6A0 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x11CF4F0 Offset: 0x11CDAF0 VA: 0x1811CF4F0 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x11CFC60 Offset: 0x11CE260 VA: 0x1811CFC60 Slot: 31
	public override bool Read() { }

	// RVA: 0x11CFC70 Offset: 0x11CE270 VA: 0x1811CFC70
	private bool Read(bool fSkipChildren) { }

	// RVA: 0x11CF9A0 Offset: 0x11CDFA0 VA: 0x1811CF9A0
	private bool ReadNextNode(bool fSkipChildren) { }

	// RVA: 0x11CFE60 Offset: 0x11CE460 VA: 0x1811CFE60
	private void SetEndOfFile() { }

	// RVA: 0x11CF7B0 Offset: 0x11CDDB0 VA: 0x1811CF7B0
	private bool ReadAtZeroLevel(bool fSkipChildren) { }

	// RVA: 0x11CF870 Offset: 0x11CDE70 VA: 0x1811CF870
	private bool ReadForward(bool fSkipChildren) { }

	// RVA: 0x11CF780 Offset: 0x11CDD80 VA: 0x1811CF780
	private void ReSetReadingMarks() { }

	// RVA: 0x11D00B0 Offset: 0x11CE6B0 VA: 0x1811D00B0 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x11CF0A0 Offset: 0x11CD6A0 VA: 0x1811CF0A0 Slot: 33
	public override void Close() { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x11CFE80 Offset: 0x11CE480 VA: 0x1811CFE80 Slot: 35
	public override void Skip() { }

	// RVA: 0x11CFBB0 Offset: 0x11CE1B0 VA: 0x1811CFBB0 Slot: 42
	public override string ReadString() { }

	// RVA: 0xBA4930 Offset: 0xBA2F30 VA: 0x180BA4930 Slot: 49
	public override bool get_HasAttributes() { }

	// RVA: 0x6C8150 Offset: 0x6C6750 VA: 0x1806C8150 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x11CF240 Offset: 0x11CD840 VA: 0x1811CF240 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x11CFDD0 Offset: 0x11CE3D0 VA: 0x1811CFDD0 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x11CF820 Offset: 0x11CDE20 VA: 0x1811CF820 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x11CF0B0 Offset: 0x11CD6B0 VA: 0x1811CF0B0
	private void FinishReadBinary() { }

	// RVA: 0x11CFE90 Offset: 0x11CE490 VA: 0x1811CFE90 Slot: 53
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11CFF20 Offset: 0x11CE520 VA: 0x1811CFF20 Slot: 55
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x11CFEB0 Offset: 0x11CE4B0 VA: 0x1811CFEB0 Slot: 54
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x11D0080 Offset: 0x11CE680 VA: 0x1811D0080 Slot: 52
	internal override IDtdInfo get_DtdInfo() { }

}

public class XmlNotation : XmlNode // TypeDefIndex: 1977
{	// Fields
	private string publicId; // 0x18
	private string systemId; // 0x20
	private string name; // 0x28

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override bool IsReadOnly { get; }
	public override string InnerXml { set; }

	// Methods

	// RVA: 0xB9FA40 Offset: 0xB9E040 VA: 0x180B9FA40
	internal void .ctor(string name, string publicId, string systemId, XmlDocument doc) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xB9FAF0 Offset: 0xB9E0F0 VA: 0x180B9FAF0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xB9F9D0 Offset: 0xB9DFD0 VA: 0x180B9F9D0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0xB9FB00 Offset: 0xB9E100 VA: 0x180B9FB00 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

}

public class XmlProcessingInstruction : XmlLinkedNode // TypeDefIndex: 1978
{	// Fields
	private string target; // 0x20
	private string data; // 0x28

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override string Value { get; set; }
	public string Data { set; }
	public override string InnerText { get; set; }
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0xBA0080 Offset: 0xB9E680 VA: 0x180BA0080
	protected internal void .ctor(string target, string data, XmlDocument doc) { }

	// RVA: 0xBA00D0 Offset: 0xB9E6D0 VA: 0x180BA00D0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x95FF30 Offset: 0x95E530 VA: 0x18095FF30 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 7
	public override string get_Value() { }

	// RVA: 0xBA0200 Offset: 0xB9E800 VA: 0x180BA0200 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0xBA0130 Offset: 0xB9E730 VA: 0x180BA0130
	public void set_Data(string value) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0xBA0200 Offset: 0xB9E800 VA: 0x180BA0200 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0xBA0120 Offset: 0xB9E720 VA: 0x180BA0120 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xB9FFF0 Offset: 0xB9E5F0 VA: 0x180B9FFF0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xBA0040 Offset: 0xB9E640 VA: 0x180BA0040 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

}

public class XmlSignificantWhitespace : XmlCharacterData // TypeDefIndex: 1979
{	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override string Value { get; set; }
	internal override bool IsText { get; }

	// Methods

	// RVA: 0xBA5580 Offset: 0xBA3B80 VA: 0x180BA5580
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0xBA5640 Offset: 0xBA3C40 VA: 0x180BA5640 Slot: 6
	public override string get_Name() { }

	// RVA: 0xBA5640 Offset: 0xBA3C40 VA: 0x180BA5640 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xBA5670 Offset: 0xBA3C70 VA: 0x180BA5670 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBA5680 Offset: 0xBA3C80 VA: 0x180BA5680 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0xBA54E0 Offset: 0xBA3AE0 VA: 0x180BA54E0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xBA5720 Offset: 0xBA3D20 VA: 0x180BA5720 Slot: 7
	public override string get_Value() { }

	// RVA: 0xBA5740 Offset: 0xBA3D40 VA: 0x180BA5740 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0xBA5540 Offset: 0xBA3B40 VA: 0x180BA5540 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 55
	internal override bool get_IsText() { }

}

public class XmlText : XmlCharacterData // TypeDefIndex: 1980
{	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override string Value { get; set; }
	internal override bool IsText { get; }

	// Methods

	// RVA: 0xBC9860 Offset: 0xBC7E60 VA: 0x180BC9860
	internal void .ctor(string strData) { }

	// RVA: 0xBC9850 Offset: 0xBC7E50 VA: 0x180BC9850
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0xBC9870 Offset: 0xBC7E70 VA: 0x180BC9870 Slot: 6
	public override string get_Name() { }

	// RVA: 0xBC9870 Offset: 0xBC7E70 VA: 0x180BC9870 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xAC2530 Offset: 0xAC0B30 VA: 0x180AC2530 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC98A0 Offset: 0xBC7EA0 VA: 0x180BC98A0 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0xBC97F0 Offset: 0xBC7DF0 VA: 0x180BC97F0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xBA5720 Offset: 0xBA3D20 VA: 0x180BA5720 Slot: 7
	public override string get_Value() { }

	// RVA: 0xBC9940 Offset: 0xBC7F40 VA: 0x180BC9940 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0xBA5540 Offset: 0xBA3B40 VA: 0x180BA5540 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 55
	internal override bool get_IsText() { }

}

internal class XmlUnspecifiedAttribute : XmlAttribute // TypeDefIndex: 1981
{	// Fields
	private bool fSpecified; // 0x28

	// Properties
	public override bool Specified { get; }
	public override string InnerText { set; }

	// Methods

	// RVA: 0x131E9E0 Offset: 0x131CFE0 VA: 0x18131E9E0
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x997AE0 Offset: 0x9960E0 VA: 0x180997AE0 Slot: 56
	public override bool get_Specified() { }

	// RVA: 0x131E820 Offset: 0x131CE20 VA: 0x18131E820 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x131E9F0 Offset: 0x131CFF0 VA: 0x18131E9F0 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x131E990 Offset: 0x131CF90 VA: 0x18131E990 Slot: 21
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x131E970 Offset: 0x131CF70 VA: 0x18131E970 Slot: 22
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x131E9B0 Offset: 0x131CFB0 VA: 0x18131E9B0 Slot: 23
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x131E800 Offset: 0x131CE00 VA: 0x18131E800 Slot: 25
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x131E9D0 Offset: 0x131CFD0 VA: 0x18131E9D0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x997AF0 Offset: 0x9960F0 VA: 0x180997AF0
	internal void SetSpecified(bool f) { }

}

public class XmlWhitespace : XmlCharacterData // TypeDefIndex: 1982
{	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override string Value { get; set; }
	internal override bool IsText { get; }

	// Methods

	// RVA: 0x132B790 Offset: 0x1329D90 VA: 0x18132B790
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x132B850 Offset: 0x1329E50 VA: 0x18132B850 Slot: 6
	public override string get_Name() { }

	// RVA: 0x132B850 Offset: 0x1329E50 VA: 0x18132B850 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x132B880 Offset: 0x1329E80 VA: 0x18132B880 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBA5680 Offset: 0xBA3C80 VA: 0x180BA5680 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0xBA5720 Offset: 0xBA3D20 VA: 0x180BA5720 Slot: 7
	public override string get_Value() { }

	// RVA: 0x132B890 Offset: 0x1329E90 VA: 0x18132B890 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x132B6F0 Offset: 0x1329CF0 VA: 0x18132B6F0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x132B750 Offset: 0x1329D50 VA: 0x18132B750 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 55
	internal override bool get_IsText() { }

}

public enum XmlTokenizedType // TypeDefIndex: 1999
{	// Fields
	public int value__; // 0x0
	public const XmlTokenizedType CDATA = 0;
	public const XmlTokenizedType ID = 1;
	public const XmlTokenizedType IDREF = 2;
	public const XmlTokenizedType IDREFS = 3;
	public const XmlTokenizedType ENTITY = 4;
	public const XmlTokenizedType ENTITIES = 5;
	public const XmlTokenizedType NMTOKEN = 6;
	public const XmlTokenizedType NMTOKENS = 7;
	public const XmlTokenizedType NOTATION = 8;
	public const XmlTokenizedType ENUMERATION = 9;
	public const XmlTokenizedType QName = 10;
	public const XmlTokenizedType NCName = 11;
	public const XmlTokenizedType None = 12;

}

internal struct XmlCharType // TypeDefIndex: 2001
{	// Fields
	private static object s_Lock; // 0x0
	private static byte[] s_CharProperties; // 0x8
	internal byte[] charProperties; // 0x0

	// Properties
	private static object StaticLock { get; }
	public static XmlCharType Instance { get; }

	// Methods

	// RVA: 0xE59CA0 Offset: 0xE582A0 VA: 0x180E59CA0
	private static object get_StaticLock() { }

	// RVA: 0xE593C0 Offset: 0xE579C0 VA: 0x180E593C0
	private static void InitInstance() { }

	// RVA: 0xE59AF0 Offset: 0xE580F0 VA: 0x180E59AF0
	private static void SetProperties(string ranges, byte value) { }

	// RVA: 0xF1490 Offset: 0xF0890 VA: 0x1800F1490
	private void .ctor(byte[] charProperties) { }

	// RVA: 0xE59C20 Offset: 0xE58220 VA: 0x180E59C20
	public static XmlCharType get_Instance() { }

	// RVA: 0x12C5C0 Offset: 0x12B9C0 VA: 0x18012C5C0
	public bool IsWhiteSpace(char ch) { }

	// RVA: 0x12C1A0 Offset: 0x12B5A0 VA: 0x18012C1A0
	public bool IsNCNameSingleChar(char ch) { }

	// RVA: 0x12C540 Offset: 0x12B940 VA: 0x18012C540
	public bool IsStartNCNameSingleChar(char ch) { }

	// RVA: 0x12C230 Offset: 0x12B630 VA: 0x18012C230
	public bool IsNameSingleChar(char ch) { }

	// RVA: 0x12C0E0 Offset: 0x12B4E0 VA: 0x18012C0E0
	public bool IsCharData(char ch) { }

	// RVA: 0x12C470 Offset: 0x12B870 VA: 0x18012C470
	public bool IsPubidChar(char ch) { }

	// RVA: 0x12C580 Offset: 0x12B980 VA: 0x18012C580
	internal bool IsTextChar(char ch) { }

	// RVA: 0x12C120 Offset: 0x12B520 VA: 0x18012C120
	public bool IsLetter(char ch) { }

	// RVA: 0x12C160 Offset: 0x12B560 VA: 0x18012C160
	public bool IsNCNameCharXml4e(char ch) { }

	// RVA: 0x12C4F0 Offset: 0x12B8F0 VA: 0x18012C4F0
	public bool IsStartNCNameCharXml4e(char ch) { }

	// RVA: 0x12C1E0 Offset: 0x12B5E0 VA: 0x18012C1E0
	public bool IsNameCharXml4e(char ch) { }

	// RVA: 0xE59620 Offset: 0xE57C20 VA: 0x180E59620
	public static bool IsDigit(char ch) { }

	// RVA: 0xE59630 Offset: 0xE57C30 VA: 0x180E59630
	internal static bool IsHighSurrogate(int ch) { }

	// RVA: 0xE59640 Offset: 0xE57C40 VA: 0x180E59640
	internal static bool IsLowSurrogate(int ch) { }

	// RVA: 0xE59A60 Offset: 0xE58060 VA: 0x180E59A60
	internal static bool IsSurrogate(int ch) { }

	// RVA: 0xE59390 Offset: 0xE57990 VA: 0x180E59390
	internal static int CombineSurrogateChar(int lowChar, int highChar) { }

	// RVA: 0xE59BE0 Offset: 0xE581E0 VA: 0x180E59BE0
	internal static void SplitSurrogateChar(int combinedChar, out char lowChar, out char highChar) { }

	// RVA: 0x12C3E0 Offset: 0x12B7E0 VA: 0x18012C3E0
	internal bool IsOnlyWhitespace(string str) { }

	// RVA: 0x12C350 Offset: 0x12B750 VA: 0x18012C350
	internal int IsOnlyWhitespaceWithPos(string str) { }

	// RVA: 0x12C280 Offset: 0x12B680 VA: 0x18012C280
	internal int IsOnlyCharData(string str) { }

	// RVA: 0xE59840 Offset: 0xE57E40 VA: 0x180E59840
	internal static bool IsOnlyDigits(string str, int startPos, int len) { }

	// RVA: 0x12C480 Offset: 0x12B880 VA: 0x18012C480
	internal int IsPublicId(string str) { }

	// RVA: 0xE593B0 Offset: 0xE579B0 VA: 0x180E593B0
	private static bool InRange(int value, int start, int end) { }

}

internal static class XmlComplianceUtil // TypeDefIndex: 2002
{	// Methods

	// RVA: 0xE5A530 Offset: 0xE58B30 VA: 0x180E5A530
	public static string NonCDataNormalize(string value) { }

	// RVA: 0xE5A380 Offset: 0xE58980 VA: 0x180E5A380
	public static string CDataNormalize(string value) { }

}

public enum XmlDateTimeSerializationMode // TypeDefIndex: 2004
{	// Fields
	public int value__; // 0x0
	public const XmlDateTimeSerializationMode Local = 0;
	public const XmlDateTimeSerializationMode Utc = 1;
	public const XmlDateTimeSerializationMode Unspecified = 2;
	public const XmlDateTimeSerializationMode RoundtripKind = 3;

}

public class XmlConvert // TypeDefIndex: 2005
{	// Fields
	private static XmlCharType xmlCharType; // 0x0
	internal static char[] crt; // 0x8
	private static readonly int c_EncodedCharLength; // 0x10
	private static Regex c_EncodeCharPattern; // 0x18
	private static Regex c_DecodeCharPattern; // 0x20
	private static string[] s_allDateTimeFormats; // 0x28
	internal static readonly char[] WhitespaceChars; // 0x30

	// Properties
	private static string[] AllDateTimeFormats { get; }

	// Methods

	// RVA: 0xE5CA30 Offset: 0xE5B030 VA: 0x180E5CA30
	public static string EncodeName(string name) { }

	// RVA: 0xE5C9D0 Offset: 0xE5AFD0 VA: 0x180E5C9D0
	public static string EncodeLocalName(string name) { }

	// RVA: 0xE5C100 Offset: 0xE5A700 VA: 0x180E5C100
	public static string DecodeName(string name) { }

	// RVA: 0xE5CA90 Offset: 0xE5B090 VA: 0x180E5CA90
	private static string EncodeName(string name, bool first, bool local) { }

	// RVA: 0xE5D4E0 Offset: 0xE5BAE0 VA: 0x180E5D4E0
	private static int FromHex(char digit) { }

	// RVA: 0xE5D3A0 Offset: 0xE5B9A0 VA: 0x180E5D3A0
	internal static byte[] FromBinHexString(string s) { }

	// RVA: 0xE5D450 Offset: 0xE5BA50 VA: 0x180E5D450
	internal static byte[] FromBinHexString(string s, bool allowOddCount) { }

	// RVA: 0xE5D7A0 Offset: 0xE5BDA0 VA: 0x180E5D7A0
	internal static string ToBinHexString(byte[] inArray) { }

	// RVA: 0xE61E80 Offset: 0xE60480 VA: 0x180E61E80
	public static string VerifyName(string name) { }

	// RVA: 0xE61680 Offset: 0xE5FC80 VA: 0x180E61680
	internal static Exception TryVerifyName(string name) { }

	// RVA: 0xE61FB0 Offset: 0xE605B0 VA: 0x180E61FB0
	internal static string VerifyQName(string name, ExceptionType exceptionType) { }

	// RVA: 0xE61D10 Offset: 0xE60310 VA: 0x180E61D10
	public static string VerifyNCName(string name) { }

	// RVA: 0xE61BD0 Offset: 0xE601D0 VA: 0x180E61BD0
	internal static string VerifyNCName(string name, ExceptionType exceptionType) { }

	// RVA: 0xE613C0 Offset: 0xE5F9C0 VA: 0x180E613C0
	internal static Exception TryVerifyNCName(string name) { }

	// RVA: 0xE62170 Offset: 0xE60770 VA: 0x180E62170
	public static string VerifyTOKEN(string token) { }

	// RVA: 0xE61860 Offset: 0xE5FE60 VA: 0x180E61860
	internal static Exception TryVerifyTOKEN(string token) { }

	// RVA: 0xE614B0 Offset: 0xE5FAB0 VA: 0x180E614B0
	internal static Exception TryVerifyNMTOKEN(string name) { }

	// RVA: 0xE617A0 Offset: 0xE5FDA0 VA: 0x180E617A0
	internal static Exception TryVerifyNormalizedString(string str) { }

	// RVA: 0xE5EAB0 Offset: 0xE5D0B0 VA: 0x180E5EAB0
	public static string ToString(bool value) { }

	// RVA: 0xE5E580 Offset: 0xE5CB80 VA: 0x180E5E580
	public static string ToString(char value) { }

	// RVA: 0xE5EB80 Offset: 0xE5D180 VA: 0x180E5EB80
	public static string ToString(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE5EC20 Offset: 0xE5D220 VA: 0x180E5EC20
	public static string ToString(sbyte value) { }

	// RVA: 0xE5EBB0 Offset: 0xE5D1B0 VA: 0x180E5EBB0
	public static string ToString(short value) { }

	// RVA: 0xE5E980 Offset: 0xE5CF80 VA: 0x180E5E980
	public static string ToString(int value) { }

	// RVA: 0xE5EAF0 Offset: 0xE5D0F0 VA: 0x180E5EAF0
	public static string ToString(long value) { }

	// RVA: 0xE5E950 Offset: 0xE5CF50 VA: 0x180E5E950
	public static string ToString(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE5E910 Offset: 0xE5CF10 VA: 0x180E5E910
	public static string ToString(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE5E9B0 Offset: 0xE5CFB0 VA: 0x180E5E9B0
	public static string ToString(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE5E550 Offset: 0xE5CB50 VA: 0x180E5E550
	public static string ToString(ulong value) { }

	// RVA: 0xE5E9E0 Offset: 0xE5CFE0 VA: 0x180E5E9E0
	public static string ToString(float value) { }

	// RVA: 0xE5E610 Offset: 0xE5CC10 VA: 0x180E5E610
	public static string ToString(double value) { }

	// RVA: 0xE5EB20 Offset: 0xE5D120 VA: 0x180E5EB20
	public static string ToString(TimeSpan value) { }

	// RVA: 0xE5E5A0 Offset: 0xE5CBA0 VA: 0x180E5E5A0
	public static string ToString(DateTime value, string format) { }

	// RVA: 0xE5E740 Offset: 0xE5CD40 VA: 0x180E5E740
	public static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0xE5EBE0 Offset: 0xE5D1E0 VA: 0x180E5EBE0
	public static string ToString(DateTimeOffset value) { }

	// RVA: 0xE5E940 Offset: 0xE5CF40 VA: 0x180E5E940
	public static string ToString(Guid value) { }

	// RVA: 0xE5D810 Offset: 0xE5BE10 VA: 0x180E5D810
	public static bool ToBoolean(string s) { }

	// RVA: 0xE5F480 Offset: 0xE5DA80 VA: 0x180E5F480
	internal static Exception TryToBoolean(string s, out bool result) { }

	// RVA: 0xE5DA10 Offset: 0xE5C010 VA: 0x180E5DA10
	public static char ToChar(string s) { }

	// RVA: 0xE5F860 Offset: 0xE5DE60 VA: 0x180E5F860
	internal static Exception TryToChar(string s, out char result) { }

	// RVA: 0xE5E000 Offset: 0xE5C600 VA: 0x180E5E000
	public static Decimal ToDecimal(string s) { }

	// RVA: 0xE5F9F0 Offset: 0xE5DFF0 VA: 0x180E5F9F0
	internal static Exception TryToDecimal(string s, out Decimal result) { }

	// RVA: 0xE5E300 Offset: 0xE5C900 VA: 0x180E5E300
	internal static Decimal ToInteger(string s) { }

	// RVA: 0xE605A0 Offset: 0xE5EBA0 VA: 0x180E605A0
	internal static Exception TryToInteger(string s, out Decimal result) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE5E390 Offset: 0xE5C990 VA: 0x180E5E390
	public static sbyte ToSByte(string s) { }

	// RVA: 0xE60750 Offset: 0xE5ED50 VA: 0x180E60750
	internal static Exception TryToSByte(string s, out sbyte result) { }

	// RVA: 0xE5E270 Offset: 0xE5C870 VA: 0x180E5E270
	public static short ToInt16(string s) { }

	// RVA: 0xE60120 Offset: 0xE5E720 VA: 0x180E60120
	internal static Exception TryToInt16(string s, out short result) { }

	// RVA: 0xE5E2A0 Offset: 0xE5C8A0 VA: 0x180E5E2A0
	public static int ToInt32(string s) { }

	// RVA: 0xE602A0 Offset: 0xE5E8A0 VA: 0x180E602A0
	internal static Exception TryToInt32(string s, out int result) { }

	// RVA: 0xE5E2D0 Offset: 0xE5C8D0 VA: 0x180E5E2D0
	public static long ToInt64(string s) { }

	// RVA: 0xE60420 Offset: 0xE5EA20 VA: 0x180E60420
	internal static Exception TryToInt64(string s, out long result) { }

	// RVA: 0xE5D9E0 Offset: 0xE5BFE0 VA: 0x180E5D9E0
	public static byte ToByte(string s) { }

	// RVA: 0xE5F6E0 Offset: 0xE5DCE0 VA: 0x180E5F6E0
	internal static Exception TryToByte(string s, out byte result) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE5ED90 Offset: 0xE5D390 VA: 0x180E5ED90
	public static ushort ToUInt16(string s) { }

	// RVA: 0xE60C20 Offset: 0xE5F220 VA: 0x180E60C20
	internal static Exception TryToUInt16(string s, out ushort result) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE5EDC0 Offset: 0xE5D3C0 VA: 0x180E5EDC0
	public static uint ToUInt32(string s) { }

	// RVA: 0xE60DA0 Offset: 0xE5F3A0 VA: 0x180E60DA0
	internal static Exception TryToUInt32(string s, out uint result) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE5EDF0 Offset: 0xE5D3F0 VA: 0x180E5EDF0
	public static ulong ToUInt64(string s) { }

	// RVA: 0xE60F20 Offset: 0xE5F520 VA: 0x180E60F20
	internal static Exception TryToUInt64(string s, out ulong result) { }

	// RVA: 0xE5E3C0 Offset: 0xE5C9C0 VA: 0x180E5E3C0
	public static float ToSingle(string s) { }

	// RVA: 0xE608D0 Offset: 0xE5EED0 VA: 0x180E608D0
	internal static Exception TryToSingle(string s, out float result) { }

	// RVA: 0xE5E090 Offset: 0xE5C690 VA: 0x180E5E090
	public static double ToDouble(string s) { }

	// RVA: 0xE5FBA0 Offset: 0xE5E1A0 VA: 0x180E5FBA0
	internal static Exception TryToDouble(string s, out double result) { }

	// RVA: 0xE5F0B0 Offset: 0xE5D6B0 VA: 0x180E5F0B0
	internal static double ToXPathDouble(object o) { }

	// RVA: 0xE5EC50 Offset: 0xE5D250 VA: 0x180E5EC50
	public static TimeSpan ToTimeSpan(string s) { }

	// RVA: 0xE60B60 Offset: 0xE5F160 VA: 0x180E60B60
	internal static Exception TryToTimeSpan(string s, out TimeSpan result) { }

	// RVA: 0xE62360 Offset: 0xE60960 VA: 0x180E62360
	private static string[] get_AllDateTimeFormats() { }

	// RVA: 0xE5A820 Offset: 0xE58E20 VA: 0x180E5A820
	private static void CreateAllDateTimeFormats() { }

	[ObsoleteAttribute] // RVA: 0x83AA0 Offset: 0x82EA0 VA: 0x180083AA0
	// RVA: 0xE5DDB0 Offset: 0xE5C3B0 VA: 0x180E5DDB0
	public static DateTime ToDateTime(string s) { }

	// RVA: 0xE5DF50 Offset: 0xE5C550 VA: 0x180E5DF50
	public static DateTime ToDateTime(string s, string[] formats) { }

	// RVA: 0xE5DBA0 Offset: 0xE5C1A0 VA: 0x180E5DBA0
	public static DateTime ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0xE5DAD0 Offset: 0xE5C0D0 VA: 0x180E5DAD0
	public static DateTimeOffset ToDateTimeOffset(string s) { }

	// RVA: 0xE5E250 Offset: 0xE5C850 VA: 0x180E5E250
	public static Guid ToGuid(string s) { }

	// RVA: 0xE5FE80 Offset: 0xE5E480 VA: 0x180E5FE80
	internal static Exception TryToGuid(string s, out Guid result) { }

	// RVA: 0xE5D6B0 Offset: 0xE5BCB0 VA: 0x180E5D6B0
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0xE5D720 Offset: 0xE5BD20 VA: 0x180E5D720
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0xE5EE20 Offset: 0xE5D420 VA: 0x180E5EE20
	internal static Uri ToUri(string s) { }

	// RVA: 0xE610A0 Offset: 0xE5F6A0 VA: 0x180E610A0
	internal static Exception TryToUri(string s, out Uri result) { }

	// RVA: 0xE5D610 Offset: 0xE5BC10 VA: 0x180E5D610
	internal static bool StrEqual(char[] chars, int strPos1, int strLen1, string str2) { }

	// RVA: 0xE5F400 Offset: 0xE5DA00 VA: 0x180E5F400
	internal static string TrimString(string value) { }

	// RVA: 0xE5F380 Offset: 0xE5D980 VA: 0x180E5F380
	internal static string TrimStringStart(string value) { }

	// RVA: 0xE5F300 Offset: 0xE5D900 VA: 0x180E5F300
	internal static string TrimStringEnd(string value) { }

	// RVA: 0xE5D590 Offset: 0xE5BB90 VA: 0x180E5D590
	internal static string[] SplitString(string value) { }

	// RVA: 0xE5D510 Offset: 0xE5BB10 VA: 0x180E5D510
	internal static bool IsNegativeZero(double value) { }

	// RVA: 0xE5C9C0 Offset: 0xE5AFC0 VA: 0x180E5C9C0
	private static long DoubleToInt64Bits(double value) { }

	// RVA: 0xE61960 Offset: 0xE5FF60 VA: 0x180E61960
	internal static void VerifyCharData(string data, ExceptionType invCharExceptionType, ExceptionType invSurrogateExceptionType) { }

	// RVA: 0xE5B280 Offset: 0xE59880 VA: 0x180E5B280
	internal static Exception CreateException(string res, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0xE5B350 Offset: 0xE59950 VA: 0x180E5B350
	internal static Exception CreateException(string res, string arg, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0xE5B550 Offset: 0xE59B50 VA: 0x180E5B550
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType) { }

	// RVA: 0xE5B490 Offset: 0xE59A90 VA: 0x180E5B490
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0xE5BE00 Offset: 0xE5A400 VA: 0x180E5BE00
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi) { }

	// RVA: 0xE5BEB0 Offset: 0xE5A4B0 VA: 0x180E5BEB0
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType) { }

	// RVA: 0xE5BF30 Offset: 0xE5A530 VA: 0x180E5BF30
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0xE5BA80 Offset: 0xE5A080 VA: 0x180E5BA80
	internal static Exception CreateInvalidHighSurrogateCharException(char hi) { }

	// RVA: 0xE5B890 Offset: 0xE59E90 VA: 0x180E5B890
	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType) { }

	// RVA: 0xE5BAE0 Offset: 0xE5A0E0 VA: 0x180E5BAE0
	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0xE5B7F0 Offset: 0xE59DF0 VA: 0x180E5B7F0
	internal static Exception CreateInvalidCharException(string data, int invCharPos, ExceptionType exceptionType) { }

	// RVA: 0xE5B5D0 Offset: 0xE59BD0 VA: 0x180E5B5D0
	internal static Exception CreateInvalidCharException(char invChar, char nextChar) { }

	// RVA: 0xE5B710 Offset: 0xE59D10 VA: 0x180E5B710
	internal static Exception CreateInvalidCharException(char invChar, char nextChar, ExceptionType exceptionType) { }

	// RVA: 0xE5BD50 Offset: 0xE5A350 VA: 0x180E5BD50
	internal static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType) { }

	// RVA: 0xE5BCA0 Offset: 0xE5A2A0 VA: 0x180E5BCA0
	internal static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName) { }

	// RVA: 0xE62280 Offset: 0xE60880 VA: 0x180E62280
	private static void .cctor() { }

}

internal class XmlDownloadManager // TypeDefIndex: 2006
{	// Fields
	private Hashtable connections; // 0x10

	// Methods

	// RVA: 0x11BC550 Offset: 0x11BAB50 VA: 0x1811BC550
	internal Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x11BBEA0 Offset: 0x11BA4A0 VA: 0x1811BBEA0
	private Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x11BC650 Offset: 0x11BAC50 VA: 0x1811BC650
	internal void Remove(string host) { }

	// RVA: 0x11BC300 Offset: 0x11BA900 VA: 0x1811BC300
	internal Task<Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	[AsyncStateMachineAttribute] // RVA: 0x83C40 Offset: 0x83040 VA: 0x180083C40
	// RVA: 0x11BBD40 Offset: 0x11BA340 VA: 0x1811BBD40
	private Task<Stream> GetNonFileStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class XmlDownloadManager.<>c__DisplayClass4_0 // TypeDefIndex: 2007
{	// Fields
	public Uri uri; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x11BB270 Offset: 0x11B9870 VA: 0x1811BB270
	internal Stream <GetStreamAsync>b__0() { }

}

private struct XmlDownloadManager.<GetNonFileStreamAsync>d__5 : IAsyncStateMachine // TypeDefIndex: 2008
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Stream> <>t__builder; // 0x8
	public Uri uri; // 0x20
	public ICredentials credentials; // 0x28
	public IWebProxy proxy; // 0x30
	public RequestCachePolicy cachePolicy; // 0x38
	private WebRequest <req>5__1; // 0x40
	public XmlDownloadManager <>4__this; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebResponse> <>u__1; // 0x50

	// Methods

	// RVA: 0x1D1380 Offset: 0x1D0780 VA: 0x1801D1380 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D1390 Offset: 0x1D0790 VA: 0x1801D1390 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

internal class XmlRegisteredNonCachedStream : Stream // TypeDefIndex: 2010
{	// Fields
	protected Stream stream; // 0x28
	private XmlDownloadManager downloadManager; // 0x30
	private string host; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0xBA4FC0 Offset: 0xBA35C0 VA: 0x180BA4FC0
	internal void .ctor(Stream stream, XmlDownloadManager downloadManager, string host) { }

	// RVA: 0xBA4DC0 Offset: 0xBA33C0 VA: 0x180BA4DC0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0xBA4C20 Offset: 0xBA3220 VA: 0x180BA4C20 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0xBA4BC0 Offset: 0xBA31C0 VA: 0x180BA4BC0 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0xBA4BF0 Offset: 0xBA31F0 VA: 0x180BA4BF0 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0xBA4D60 Offset: 0xBA3360 VA: 0x180BA4D60 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0xBA4D90 Offset: 0xBA3390 VA: 0x180BA4D90 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0xBA4E70 Offset: 0xBA3470 VA: 0x180BA4E70 Slot: 18
	public override void Flush() { }

	// RVA: 0xBA4ED0 Offset: 0xBA34D0 VA: 0x180BA4ED0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0xBA4EA0 Offset: 0xBA34A0 VA: 0x180BA4EA0 Slot: 28
	public override int ReadByte() { }

	// RVA: 0xBA4F00 Offset: 0xBA3500 VA: 0x180BA4F00 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xBA4F30 Offset: 0xBA3530 VA: 0x180BA4F30 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0xBA4F90 Offset: 0xBA3590 VA: 0x180BA4F90 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0xBA4F60 Offset: 0xBA3560 VA: 0x180BA4F60 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0xBA5070 Offset: 0xBA3670 VA: 0x180BA5070 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0xBA50A0 Offset: 0xBA36A0 VA: 0x180BA50A0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0xBA50D0 Offset: 0xBA36D0 VA: 0x180BA50D0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0xBA5100 Offset: 0xBA3700 VA: 0x180BA5100 Slot: 10
	public override long get_Length() { }

	// RVA: 0xBA5130 Offset: 0xBA3730 VA: 0x180BA5130 Slot: 11
	public override long get_Position() { }

	// RVA: 0xBA5160 Offset: 0xBA3760 VA: 0x180BA5160 Slot: 12
	public override void set_Position(long value) { }

}

internal class XmlCachedStream : MemoryStream // TypeDefIndex: 2011
{	// Fields
	private Uri uri; // 0x50

	// Methods

	// RVA: 0xE59230 Offset: 0xE57830 VA: 0x180E59230
	internal void .ctor(Uri uri, Stream stream) { }

}

public class XmlException : SystemException // TypeDefIndex: 2024
{	// Fields
	private string res; // 0x88
	private string[] args; // 0x90
	private int lineNumber; // 0x98
	private int linePosition; // 0x9C
	[OptionalFieldAttribute] // RVA: 0x7B570 Offset: 0x7A970 VA: 0x18007B570
	private string sourceUri; // 0xA0
	private string message; // 0xA8

	// Properties
	public int LineNumber { get; }
	public int LinePosition { get; }
	public override string Message { get; }
	internal string ResString { get; }

	// Methods

	// RVA: 0x11C7160 Offset: 0x11C5760 VA: 0x1811C7160
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11C65B0 Offset: 0x11C4BB0 VA: 0x1811C65B0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11C6C60 Offset: 0x11C5260 VA: 0x1811C6C60
	public void .ctor() { }

	// RVA: 0x11C6D70 Offset: 0x11C5370 VA: 0x1811C6D70
	public void .ctor(string message) { }

	// RVA: 0x11C7640 Offset: 0x11C5C40 VA: 0x1811C7640
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x11C7130 Offset: 0x11C5730 VA: 0x1811C7130
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x11C6950 Offset: 0x11C4F50 VA: 0x1811C6950
	internal void .ctor(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11C6F70 Offset: 0x11C5570 VA: 0x1811C6F70
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x11C7520 Offset: 0x11C5B20 VA: 0x1811C7520
	internal void .ctor(string res, string arg) { }

	// RVA: 0x11C66C0 Offset: 0x11C4CC0 VA: 0x1811C66C0
	internal void .ctor(string res, string arg, string sourceUri) { }

	// RVA: 0x11C6FA0 Offset: 0x11C55A0 VA: 0x1811C6FA0
	internal void .ctor(string res, string arg, IXmlLineInfo lineInfo) { }

	// RVA: 0x11C6880 Offset: 0x11C4E80 VA: 0x1811C6880
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo) { }

	// RVA: 0x11C67B0 Offset: 0x11C4DB0 VA: 0x1811C67B0
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo, string sourceUri) { }

	// RVA: 0x11C6B60 Offset: 0x11C5160 VA: 0x1811C6B60
	internal void .ctor(string res, string arg, int lineNumber, int linePosition) { }

	// RVA: 0x11C6E70 Offset: 0x11C5470 VA: 0x1811C6E70
	internal void .ctor(string res, string arg, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11C7670 Offset: 0x11C5C70 VA: 0x1811C7670
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x11C7600 Offset: 0x11C5C00 VA: 0x1811C7600
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11C7100 Offset: 0x11C5700 VA: 0x1811C7100
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x11C6DA0 Offset: 0x11C53A0 VA: 0x1811C6DA0
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11C6480 Offset: 0x11C4A80 VA: 0x1811C6480
	private static string FormatUserMessage(string message, int lineNumber, int linePosition) { }

	// RVA: 0x11C6260 Offset: 0x11C4860 VA: 0x1811C6260
	private static string CreateMessage(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x11C5DD0 Offset: 0x11C43D0 VA: 0x1811C5DD0
	internal static string[] BuildCharExceptionArgs(string data, int invCharIndex) { }

	// RVA: 0x11C5E30 Offset: 0x11C4430 VA: 0x1811C5E30
	internal static string[] BuildCharExceptionArgs(char[] data, int length, int invCharIndex) { }

	// RVA: 0x11C5EB0 Offset: 0x11C44B0 VA: 0x1811C5EB0
	internal static string[] BuildCharExceptionArgs(char invChar, char nextChar) { }

	// RVA: 0xB9BA00 Offset: 0xB9A000 VA: 0x180B9BA00
	public int get_LineNumber() { }

	// RVA: 0xB9BA10 Offset: 0xB9A010 VA: 0x180B9BA10
	public int get_LinePosition() { }

	// RVA: 0x11C76A0 Offset: 0x11C5CA0 VA: 0x1811C76A0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x574300 Offset: 0x572900 VA: 0x180574300
	internal string get_ResString() { }

}

public abstract class XmlNameTable // TypeDefIndex: 2025
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string Get(string array);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string Add(char[] array, int offset, int length);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string Add(string array);

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

public enum XmlNamespaceScope // TypeDefIndex: 2026
{	// Fields
	public int value__; // 0x0
	public const XmlNamespaceScope All = 0;
	public const XmlNamespaceScope ExcludeXml = 1;
	public const XmlNamespaceScope Local = 2;

}

public class XmlNamespaceManager : IXmlNamespaceResolver, IEnumerable // TypeDefIndex: 2027
{	// Fields
	private XmlNamespaceManager.NamespaceDeclaration[] nsdecls; // 0x10
	private int lastDecl; // 0x18
	private XmlNameTable nameTable; // 0x20
	private int scopeId; // 0x28
	private Dictionary<string, int> hashTable; // 0x30
	private bool useHashtable; // 0x38
	private string xml; // 0x40
	private string xmlNs; // 0x48

	// Properties
	public virtual XmlNameTable NameTable { get; }
	public virtual string DefaultNamespace { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x11CECD0 Offset: 0x11CD2D0 VA: 0x1811CECD0
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 8
	public virtual XmlNameTable get_NameTable() { }

	// RVA: 0x11CEF40 Offset: 0x11CD540 VA: 0x1811CEF40 Slot: 9
	public virtual string get_DefaultNamespace() { }

	// RVA: 0xEAECB0 Offset: 0xEAD2B0 VA: 0x180EAECB0 Slot: 10
	public virtual void PushScope() { }

	// RVA: 0x11CEA20 Offset: 0x11CD020 VA: 0x1811CEA20 Slot: 11
	public virtual bool PopScope() { }

	// RVA: 0x11CE040 Offset: 0x11CC640 VA: 0x1811CE040 Slot: 12
	public virtual void AddNamespace(string prefix, string uri) { }

	// RVA: 0x11CEB20 Offset: 0x11CD120 VA: 0x1811CEB20 Slot: 13
	public virtual void RemoveNamespace(string prefix, string uri) { }

	// RVA: 0x11CE450 Offset: 0x11CCA50 VA: 0x1811CE450 Slot: 14
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x11CE580 Offset: 0x11CCB80 VA: 0x1811CE580 Slot: 15
	public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11CE8E0 Offset: 0x11CCEE0 VA: 0x1811CE8E0 Slot: 16
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0x11CE710 Offset: 0x11CCD10 VA: 0x1811CE710
	private int LookupNamespaceDecl(string prefix) { }

	// RVA: 0x11CE940 Offset: 0x11CCF40 VA: 0x1811CE940 Slot: 17
	public virtual string LookupPrefix(string uri) { }

}

private struct XmlNamespaceManager.NamespaceDeclaration // TypeDefIndex: 2028
{	// Fields
	public string prefix; // 0x0
	public string uri; // 0x8
	public int scopeId; // 0x10
	public int previousNsIndex; // 0x14

	// Methods

	// RVA: 0x1D1130 Offset: 0x1D0530 VA: 0x1801D1130
	public void Set(string prefix, string uri, int scopeId, int previousNsIndex) { }

}

public enum XmlNodeType // TypeDefIndex: 2029
{	// Fields
	public int value__; // 0x0
	public const XmlNodeType None = 0;
	public const XmlNodeType Element = 1;
	public const XmlNodeType Attribute = 2;
	public const XmlNodeType Text = 3;
	public const XmlNodeType CDATA = 4;
	public const XmlNodeType EntityReference = 5;
	public const XmlNodeType Entity = 6;
	public const XmlNodeType ProcessingInstruction = 7;
	public const XmlNodeType Comment = 8;
	public const XmlNodeType Document = 9;
	public const XmlNodeType DocumentType = 10;
	public const XmlNodeType DocumentFragment = 11;
	public const XmlNodeType Notation = 12;
	public const XmlNodeType Whitespace = 13;
	public const XmlNodeType SignificantWhitespace = 14;
	public const XmlNodeType EndElement = 15;
	public const XmlNodeType EndEntity = 16;
	public const XmlNodeType XmlDeclaration = 17;

}

public class XmlQualifiedName // TypeDefIndex: 2030
{	// Fields
	private static XmlQualifiedName.HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private string name; // 0x10
	private string ns; // 0x18
	private int hash; // 0x20
	public static readonly XmlQualifiedName Empty; // 0x8

	// Properties
	public string Namespace { get; }
	public string Name { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0xBA0E20 Offset: 0xB9F420 VA: 0x180BA0E20
	public void .ctor() { }

	// RVA: 0xBA0D50 Offset: 0xB9F350 VA: 0x180BA0D50
	public void .ctor(string name) { }

	// RVA: 0xBA0CA0 Offset: 0xB9F2A0 VA: 0x180BA0CA0
	public void .ctor(string name, string ns) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Namespace() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Name() { }

	// RVA: 0xBA05D0 Offset: 0xB9EBD0 VA: 0x180BA05D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xBA0EE0 Offset: 0xB9F4E0 VA: 0x180BA0EE0
	public bool get_IsEmpty() { }

	// RVA: 0xBA0A60 Offset: 0xB9F060 VA: 0x180BA0A60 Slot: 3
	public override string ToString() { }

	// RVA: 0xBA0310 Offset: 0xB9E910 VA: 0x180BA0310 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xBA0F20 Offset: 0xB9F520 VA: 0x180BA0F20
	public static bool op_Equality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0xBA0F90 Offset: 0xB9F590 VA: 0x180BA0F90
	public static bool op_Inequality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0xBA09F0 Offset: 0xB9EFF0 VA: 0x180BA09F0
	public static string ToString(string name, string ns) { }

	// RVA: 0xBA0440 Offset: 0xB9EA40 VA: 0x180BA0440
	private static XmlQualifiedName.HashCodeOfStringDelegate GetHashCodeDelegate() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private static bool IsRandomizedHashingDisabled() { }

	// RVA: 0xBA05A0 Offset: 0xB9EBA0 VA: 0x180BA05A0
	private static int GetHashCodeOfString(string s, int length, long additionalEntropy) { }

	// RVA: 0xBA0820 Offset: 0xB9EE20 VA: 0x180BA0820
	internal void Init(string name, string ns) { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	internal void SetNamespace(string ns) { }

	// RVA: 0xBA0AC0 Offset: 0xB9F0C0 VA: 0x180BA0AC0
	internal void Verify() { }

	// RVA: 0xBA0210 Offset: 0xB9E810 VA: 0x180BA0210
	internal void Atomize(XmlNameTable nameTable) { }

	// RVA: 0xBA0860 Offset: 0xB9EE60 VA: 0x180BA0860
	internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, out string prefix) { }

	// RVA: 0xBA0290 Offset: 0xB9E890 VA: 0x180BA0290
	internal XmlQualifiedName Clone() { }

	// RVA: 0xBA0B60 Offset: 0xB9F160 VA: 0x180BA0B60
	private static void .cctor() { }

}

private sealed class XmlQualifiedName.HashCodeOfStringDelegate : MulticastDelegate // TypeDefIndex: 2031
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xB9AED0 Offset: 0xB994D0 VA: 0x180B9AED0 Slot: 12
	public virtual int Invoke(string s, int sLen, long additionalEntropy) { }

	// RVA: 0xB9AE00 Offset: 0xB99400 VA: 0x180B9AE00 Slot: 13
	public virtual IAsyncResult BeginInvoke(string s, int sLen, long additionalEntropy, AsyncCallback callback, object object) { }

	// RVA: 0xB9AEA0 Offset: 0xB994A0 VA: 0x180B9AEA0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

public abstract class XmlResolver // TypeDefIndex: 2032
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn);

	// RVA: 0xBA51E0 Offset: 0xBA37E0 VA: 0x180BA51E0 Slot: 5
	public virtual Uri ResolveUri(Uri baseUri, string relativeUri) { }

	// RVA: 0xBA53C0 Offset: 0xBA39C0 VA: 0x180BA53C0 Slot: 6
	public virtual bool SupportsType(Uri absoluteUri, Type type) { }

	// RVA: 0xBA5190 Offset: 0xBA3790 VA: 0x180BA5190 Slot: 7
	public virtual Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

public class XmlUrlResolver : XmlResolver // TypeDefIndex: 2033
{	// Fields
	private static object s_DownloadManager; // 0x0
	private ICredentials _credentials; // 0x10
	private IWebProxy _proxy; // 0x18
	private RequestCachePolicy _cachePolicy; // 0x20

	// Properties
	private static XmlDownloadManager DownloadManager { get; }

	// Methods

	// RVA: 0x131ECF0 Offset: 0x131D2F0 VA: 0x18131ECF0
	private static XmlDownloadManager get_DownloadManager() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0x131EB50 Offset: 0x131D150 VA: 0x18131EB50 Slot: 4
	public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x131ECE0 Offset: 0x131D2E0 VA: 0x18131ECE0 Slot: 5
	public override Uri ResolveUri(Uri baseUri, string relativeUri) { }

	[AsyncStateMachineAttribute] // RVA: 0x84090 Offset: 0x83490 VA: 0x180084090
	// RVA: 0x131EA10 Offset: 0x131D010 VA: 0x18131EA10 Slot: 7
	public override Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

}

private struct XmlUrlResolver.<GetEntityAsync>d__15 : IAsyncStateMachine // TypeDefIndex: 2034
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<object> <>t__builder; // 0x8
	public Type ofObjectToReturn; // 0x20
	public Uri absoluteUri; // 0x28
	public XmlUrlResolver <>4__this; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream> <>u__1; // 0x38

	// Methods

	// RVA: 0x1E16B0 Offset: 0x1E0AB0 VA: 0x1801E16B0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1E16C0 Offset: 0x1E0AC0 VA: 0x1801E16C0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class XPathDocument // TypeDefIndex: 2036
{	// Fields
	private XPathNode[] pageXmlNmsp; // 0x10
	private int idxXmlNmsp; // 0x18
	private XmlNameTable nameTable; // 0x20
	private bool hasLineInfo; // 0x28
	private Dictionary<XPathNodeRef, XPathNodeRef> mapNmsp; // 0x30

	// Properties
	internal XmlNameTable NameTable { get; }
	internal bool HasLineInfo { get; }

	// Methods

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal XmlNameTable get_NameTable() { }

	// RVA: 0x997AE0 Offset: 0x9960E0 VA: 0x180997AE0
	internal bool get_HasLineInfo() { }

	// RVA: 0xE510A0 Offset: 0xE4F6A0 VA: 0x180E510A0
	internal int GetXmlNamespaceNode(out XPathNode[] pageXmlNmsp) { }

	// RVA: 0xE510D0 Offset: 0xE4F6D0 VA: 0x180E510D0
	internal int LookupNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

}

public class XPathException : SystemException // TypeDefIndex: 2037
{	// Fields
	private string res; // 0x88
	private string[] args; // 0x90
	private string message; // 0x98

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0xE518D0 Offset: 0xE4FED0 VA: 0x180E518D0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE515B0 Offset: 0xE4FBB0 VA: 0x180E515B0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE517D0 Offset: 0xE4FDD0 VA: 0x180E517D0
	public void .ctor() { }

	// RVA: 0xE516F0 Offset: 0xE4FCF0 VA: 0x180E516F0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0xE51390 Offset: 0xE4F990 VA: 0x180E51390
	internal static XPathException Create(string res) { }

	// RVA: 0xE51270 Offset: 0xE4F870 VA: 0x180E51270
	internal static XPathException Create(string res, string arg) { }

	// RVA: 0xE51430 Offset: 0xE4FA30 VA: 0x180E51430
	internal static XPathException Create(string res, string arg, string arg2) { }

	// RVA: 0xE51B10 Offset: 0xE50110 VA: 0x180E51B10
	private void .ctor(string res, string[] args) { }

	// RVA: 0xE51670 Offset: 0xE4FC70 VA: 0x180E51670
	private void .ctor(string res, string[] args, Exception inner) { }

	// RVA: 0xE511D0 Offset: 0xE4F7D0 VA: 0x180E511D0
	private static string CreateMessage(string res, string[] args) { }

	// RVA: 0xE51B90 Offset: 0xE50190 VA: 0x180E51B90 Slot: 5
	public override string get_Message() { }

}

public enum XPathResultType // TypeDefIndex: 2038
{	// Fields
	public int value__; // 0x0
	public const XPathResultType Number = 0;
	public const XPathResultType String = 1;
	public const XPathResultType Boolean = 2;
	public const XPathResultType NodeSet = 3;
	public const XPathResultType Navigator = 1;
	public const XPathResultType Any = 5;
	public const XPathResultType Error = 6;

}

public abstract class XPathItem // TypeDefIndex: 2039
{	// Properties
	public abstract XmlSchemaType XmlType { get; }
	public abstract string Value { get; }
	public abstract object TypedValue { get; }
	public abstract Type ValueType { get; }
	public abstract bool ValueAsBoolean { get; }
	public abstract DateTime ValueAsDateTime { get; }
	public abstract double ValueAsDouble { get; }
	public abstract int ValueAsInt { get; }
	public abstract long ValueAsLong { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract XmlSchemaType get_XmlType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Value();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object get_TypedValue();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Type get_ValueType();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_ValueAsBoolean();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DateTime get_ValueAsDateTime();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract double get_ValueAsDouble();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int get_ValueAsInt();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract long get_ValueAsLong();

	// RVA: 0xE51BB0 Offset: 0xE501B0 VA: 0x180E51BB0 Slot: 13
	public virtual object ValueAs(Type returnType) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver);

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

public enum XPathNamespaceScope // TypeDefIndex: 2040
{	// Fields
	public int value__; // 0x0
	public const XPathNamespaceScope All = 0;
	public const XPathNamespaceScope ExcludeXml = 1;
	public const XPathNamespaceScope Local = 2;

}

public abstract class XPathNavigator : XPathItem, ICloneable, IXmlNamespaceResolver // TypeDefIndex: 2041
{	// Fields
	internal static readonly XPathNavigatorKeyComparer comparer; // 0x0
	internal static readonly char[] NodeTypeLetter; // 0x8
	internal static readonly char[] UniqueIdTbl; // 0x10
	internal static readonly int[] ContentKindMasks; // 0x18

	// Properties
	public override XmlSchemaType XmlType { get; }
	public override object TypedValue { get; }
	public override Type ValueType { get; }
	public override bool ValueAsBoolean { get; }
	public override DateTime ValueAsDateTime { get; }
	public override double ValueAsDouble { get; }
	public override int ValueAsInt { get; }
	public override long ValueAsLong { get; }
	public abstract XmlNameTable NameTable { get; }
	public abstract XPathNodeType NodeType { get; }
	public abstract string LocalName { get; }
	public abstract string NamespaceURI { get; }
	public abstract string Prefix { get; }
	public virtual object UnderlyingObject { get; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }

	// Methods

	// RVA: 0x95FE40 Offset: 0x95E440 VA: 0x18095FE40 Slot: 3
	public override string ToString() { }

	// RVA: 0xE534A0 Offset: 0xE51AA0 VA: 0x180E534A0 Slot: 4
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0xE52860 Offset: 0xE50E60 VA: 0x180E52860 Slot: 6
	public override object get_TypedValue() { }

	// RVA: 0xE533C0 Offset: 0xE519C0 VA: 0x180E533C0 Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0xE52A60 Offset: 0xE51060 VA: 0x180E52A60 Slot: 8
	public override bool get_ValueAsBoolean() { }

	// RVA: 0xE52C40 Offset: 0xE51240 VA: 0x180E52C40 Slot: 9
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0xE52E20 Offset: 0xE51420 VA: 0x180E52E20 Slot: 10
	public override double get_ValueAsDouble() { }

	// RVA: 0xE53000 Offset: 0xE51600 VA: 0x180E53000 Slot: 11
	public override int get_ValueAsInt() { }

	// RVA: 0xE531E0 Offset: 0xE517E0 VA: 0x180E531E0 Slot: 12
	public override long get_ValueAsLong() { }

	// RVA: 0xE524D0 Offset: 0xE50AD0 VA: 0x180E524D0 Slot: 14
	public override object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xE524B0 Offset: 0xE50AB0 VA: 0x180E524B0 Slot: 15
	private object System.ICloneable.Clone() { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract XmlNameTable get_NameTable();

	// RVA: 0xE52090 Offset: 0xE50690 VA: 0x180E52090 Slot: 20
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0xE52210 Offset: 0xE50810 VA: 0x180E52210 Slot: 21
	public virtual string LookupPrefix(string namespaceURI) { }

	// RVA: 0xE51EB0 Offset: 0xE504B0 VA: 0x180E51EB0 Slot: 22
	public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract XPathNavigator Clone();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract XPathNodeType get_NodeType();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract string get_LocalName();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract string get_NamespaceURI();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract string get_Prefix();

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 28
	public virtual object get_UnderlyingObject() { }

	// RVA: 0xE52410 Offset: 0xE50A10 VA: 0x180E52410 Slot: 29
	public virtual bool MoveToNamespace(string name) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract bool MoveToParent();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract bool IsSamePosition(XPathNavigator other);

	// RVA: 0xE52820 Offset: 0xE50E20 VA: 0x180E52820 Slot: 34
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xE52080 Offset: 0xE50680 VA: 0x180E52080
	internal static bool IsText(XPathNodeType type) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0xE526F0 Offset: 0xE50CF0 VA: 0x180E526F0
	private static void .cctor() { }

}

internal class XPathNavigatorKeyComparer : IEqualityComparer // TypeDefIndex: 2042
{	// Methods

	// RVA: 0xE51BD0 Offset: 0xE501D0 VA: 0x180E51BD0 Slot: 4
	private bool System.Collections.IEqualityComparer.Equals(object obj1, object obj2) { }

	// RVA: 0xE51CB0 Offset: 0xE502B0 VA: 0x180E51CB0 Slot: 5
	private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public enum XPathNodeType // TypeDefIndex: 2043
{	// Fields
	public int value__; // 0x0
	public const XPathNodeType Root = 0;
	public const XPathNodeType Element = 1;
	public const XPathNodeType Attribute = 2;
	public const XPathNodeType Namespace = 3;
	public const XPathNodeType Text = 4;
	public const XPathNodeType SignificantWhitespace = 5;
	public const XPathNodeType Whitespace = 6;
	public const XPathNodeType ProcessingInstruction = 7;
	public const XPathNodeType Comment = 8;
	public const XPathNodeType All = 9;

}

public class XmlSerializerNamespaces // TypeDefIndex: 2045
{	// Fields
	private Hashtable namespaces; // 0x10

	// Properties
	public int Count { get; }
	internal ArrayList NamespaceList { get; }
	internal Hashtable Namespaces { get; set; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xE67C50 Offset: 0xE66250 VA: 0x180E67C50
	public void Add(string prefix, string ns) { }

	// RVA: 0xE67BA0 Offset: 0xE661A0 VA: 0x180E67BA0
	internal void AddInternal(string prefix, string ns) { }

	// RVA: 0xE67EA0 Offset: 0xE664A0 VA: 0x180E67EA0
	public XmlQualifiedName[] ToArray() { }

	// RVA: 0xE67F90 Offset: 0xE66590 VA: 0x180E67F90
	public int get_Count() { }

	// RVA: 0xE68020 Offset: 0xE66620 VA: 0x180E68020
	internal ArrayList get_NamespaceList() { }

	// RVA: 0xE68340 Offset: 0xE66940 VA: 0x180E68340
	internal Hashtable get_Namespaces() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	internal void set_Namespaces(Hashtable value) { }

}

public sealed class XmlAttributeEventHandler : MulticastDelegate // TypeDefIndex: 2046
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4D50 Offset: 0xAE3350 VA: 0x180AE4D50 Slot: 12
	public virtual void Invoke(object sender, XmlAttributeEventArgs e) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, XmlAttributeEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public class XmlAttributeEventArgs : EventArgs // TypeDefIndex: 2047
{	// Fields
	private object o; // 0x10
	private XmlAttribute attr; // 0x18
	private string qnames; // 0x20
	private int lineNumber; // 0x28
	private int linePosition; // 0x2C

	// Methods

	// RVA: 0x110D560 Offset: 0x110BB60 VA: 0x18110D560
	internal void .ctor(XmlAttribute attr, int lineNumber, int linePosition, object o, string qnames) { }

}

public sealed class XmlElementEventHandler : MulticastDelegate // TypeDefIndex: 2048
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4D50 Offset: 0xAE3350 VA: 0x180AE4D50 Slot: 12
	public virtual void Invoke(object sender, XmlElementEventArgs e) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, XmlElementEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public class XmlElementEventArgs : EventArgs // TypeDefIndex: 2049
{	// Fields
	private object o; // 0x10
	private XmlElement elem; // 0x18
	private string qnames; // 0x20
	private int lineNumber; // 0x28
	private int linePosition; // 0x2C

	// Methods

	// RVA: 0x1685FE0 Offset: 0x16845E0 VA: 0x181685FE0
	internal void .ctor(XmlElement elem, int lineNumber, int linePosition, object o, string qnames) { }

}

public sealed class XmlNodeEventHandler : MulticastDelegate // TypeDefIndex: 2050
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4D50 Offset: 0xAE3350 VA: 0x180AE4D50 Slot: 12
	public virtual void Invoke(object sender, XmlNodeEventArgs e) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, XmlNodeEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public class XmlNodeEventArgs : EventArgs // TypeDefIndex: 2051
{	// Fields
	private object o; // 0x10
	private XmlNode xmlNode; // 0x18
	private int lineNumber; // 0x20
	private int linePosition; // 0x24

	// Methods

	// RVA: 0x1686180 Offset: 0x1684780 VA: 0x181686180
	internal void .ctor(XmlNode xmlNode, int lineNumber, int linePosition, object o) { }

}

internal class XmlTypeSerializationSource : SerializationSource // TypeDefIndex: 2060
{	// Fields
	private string attributeOverridesHash; // 0x28
	private Type type; // 0x30
	private string rootHash; // 0x38

	// Methods

	// RVA: 0xE6C370 Offset: 0xE6A970 VA: 0x180E6C370
	public void .ctor(Type type, XmlRootAttribute root, XmlAttributeOverrides attributeOverrides, string namspace, Type[] includedTypes) { }

	// RVA: 0xE6C240 Offset: 0xE6A840 VA: 0x180E6C240 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0xE6C340 Offset: 0xE6A940 VA: 0x180E6C340 Slot: 2
	public override int GetHashCode() { }

}

internal class XmlTypeConvertorAttribute : Attribute // TypeDefIndex: 2061
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Method>k__BackingField; // 0x10

	// Properties
	public string Method { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Method() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	private void set_Method(string value) { }

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(string method) { }

}

public class XmlAnyAttributeAttribute : Attribute // TypeDefIndex: 2065
{	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

}

public class XmlAnyElementAttribute : Attribute // TypeDefIndex: 2066
{	// Fields
	private string elementName; // 0x10
	private string ns; // 0x18
	private int order; // 0x20

	// Properties
	public string Name { get; }
	public string Namespace { get; }
	public int Order { get; }

	// Methods

	// RVA: 0x110BF60 Offset: 0x110A560 VA: 0x18110BF60
	public void .ctor() { }

	// RVA: 0x110BF70 Offset: 0x110A570 VA: 0x18110BF70
	public string get_Name() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Namespace() { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public int get_Order() { }

	// RVA: 0x110BD70 Offset: 0x110A370 VA: 0x18110BD70
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlAnyElementAttributes : CollectionBase // TypeDefIndex: 2067
{	// Properties
	public XmlAnyElementAttribute Item { get; }
	internal int Order { get; }

	// Methods

	// RVA: 0x110C180 Offset: 0x110A780 VA: 0x18110C180
	public XmlAnyElementAttribute get_Item(int index) { }

	// RVA: 0x110C110 Offset: 0x110A710 VA: 0x18110C110
	public int Add(XmlAnyElementAttribute attribute) { }

	// RVA: 0x110BFC0 Offset: 0x110A5C0 VA: 0x18110BFC0
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x110C230 Offset: 0x110A830 VA: 0x18110C230
	internal int get_Order() { }

	// RVA: 0x105D9B0 Offset: 0x105BFB0 VA: 0x18105D9B0
	public void .ctor() { }

}

public class XmlArrayAttribute : Attribute // TypeDefIndex: 2068
{	// Fields
	private string elementName; // 0x10
	private XmlSchemaForm form; // 0x18
	private bool isNullable; // 0x1C
	private string ns; // 0x20
	private int order; // 0x28

	// Properties
	public string ElementName { get; }
	public XmlSchemaForm Form { get; }
	public bool IsNullable { get; }
	public string Namespace { get; }
	public int Order { get; }

	// Methods

	// RVA: 0x110C750 Offset: 0x110AD50 VA: 0x18110C750
	public string get_ElementName() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public XmlSchemaForm get_Form() { }

	// RVA: 0x79C660 Offset: 0x79AC60 VA: 0x18079C660
	public bool get_IsNullable() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Namespace() { }

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
	public int get_Order() { }

	// RVA: 0x110C3E0 Offset: 0x110A9E0 VA: 0x18110C3E0
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlArrayItemAttribute : Attribute // TypeDefIndex: 2069
{	// Fields
	private string dataType; // 0x10
	private string elementName; // 0x18
	private XmlSchemaForm form; // 0x20
	private string ns; // 0x28
	private bool isNullable; // 0x30
	private bool isNullableSpecified; // 0x31
	private int nestingLevel; // 0x34
	private Type type; // 0x38

	// Properties
	public string DataType { get; }
	public string ElementName { get; }
	public XmlSchemaForm Form { get; }
	public string Namespace { get; }
	public bool IsNullable { get; }
	internal bool IsNullableSpecified { get; }
	public Type Type { get; }
	public int NestingLevel { get; }

	// Methods

	// RVA: 0x110CCF0 Offset: 0x110B2F0 VA: 0x18110CCF0
	public string get_DataType() { }

	// RVA: 0x110CD40 Offset: 0x110B340 VA: 0x18110CD40
	public string get_ElementName() { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public XmlSchemaForm get_Form() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public string get_Namespace() { }

	// RVA: 0x82C2F0 Offset: 0x82A8F0 VA: 0x18082C2F0
	public bool get_IsNullable() { }

	// RVA: 0xFFC010 Offset: 0xFFA610 VA: 0x180FFC010
	internal bool get_IsNullableSpecified() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public Type get_Type() { }

	// RVA: 0x5E2ED0 Offset: 0x5E14D0 VA: 0x1805E2ED0
	public int get_NestingLevel() { }

	// RVA: 0x110C7A0 Offset: 0x110ADA0 VA: 0x18110C7A0
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlArrayItemAttributes : CollectionBase // TypeDefIndex: 2070
{	// Properties
	public XmlArrayItemAttribute Item { get; }

	// Methods

	// RVA: 0x110CF50 Offset: 0x110B550 VA: 0x18110CF50
	public XmlArrayItemAttribute get_Item(int index) { }

	// RVA: 0x110CEE0 Offset: 0x110B4E0 VA: 0x18110CEE0
	public int Add(XmlArrayItemAttribute attribute) { }

	// RVA: 0x110CD90 Offset: 0x110B390 VA: 0x18110CD90
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x105D9B0 Offset: 0x105BFB0 VA: 0x18105D9B0
	public void .ctor() { }

}

public class XmlAttributeAttribute : Attribute // TypeDefIndex: 2071
{	// Fields
	private string attributeName; // 0x10
	private string dataType; // 0x18
	private Type type; // 0x20
	private XmlSchemaForm form; // 0x28
	private string ns; // 0x30

	// Properties
	public string AttributeName { get; }
	public string DataType { get; set; }
	public XmlSchemaForm Form { get; }
	public string Namespace { get; }

	// Methods

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(string attributeName) { }

	// RVA: 0x110D4C0 Offset: 0x110BAC0 VA: 0x18110D4C0
	public string get_AttributeName() { }

	// RVA: 0x110D510 Offset: 0x110BB10 VA: 0x18110D510
	public string get_DataType() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_DataType(string value) { }

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
	public XmlSchemaForm get_Form() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_Namespace() { }

	// RVA: 0x110D000 Offset: 0x110B600 VA: 0x18110D000
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlAttributeOverrides // TypeDefIndex: 2072
{	// Fields
	private Hashtable overrides; // 0x10

	// Properties
	public XmlAttributes Item { get; }
	public XmlAttributes Item { get; }

	// Methods

	// RVA: 0x110D9C0 Offset: 0x110BFC0 VA: 0x18110D9C0
	public void .ctor() { }

	// RVA: 0x110DA30 Offset: 0x110C030 VA: 0x18110DA30
	public XmlAttributes get_Item(Type type) { }

	// RVA: 0x110DB70 Offset: 0x110C170 VA: 0x18110DB70
	public XmlAttributes get_Item(Type type, string member) { }

	// RVA: 0x110D940 Offset: 0x110BF40 VA: 0x18110D940
	private TypeMember GetKey(Type type, string member) { }

	// RVA: 0x110D610 Offset: 0x110BC10 VA: 0x18110D610
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlAttributes // TypeDefIndex: 2073
{	// Fields
	private XmlAnyAttributeAttribute xmlAnyAttribute; // 0x10
	private XmlAnyElementAttributes xmlAnyElements; // 0x18
	private XmlArrayAttribute xmlArray; // 0x20
	private XmlArrayItemAttributes xmlArrayItems; // 0x28
	private XmlAttributeAttribute xmlAttribute; // 0x30
	private XmlChoiceIdentifierAttribute xmlChoiceIdentifier; // 0x38
	private object xmlDefaultValue; // 0x40
	private XmlElementAttributes xmlElements; // 0x48
	private XmlEnumAttribute xmlEnum; // 0x50
	private bool xmlIgnore; // 0x58
	private bool xmlns; // 0x59
	private XmlRootAttribute xmlRoot; // 0x60
	private XmlTextAttribute xmlText; // 0x68
	private XmlTypeAttribute xmlType; // 0x70

	// Properties
	public XmlAnyAttributeAttribute XmlAnyAttribute { get; }
	public XmlAnyElementAttributes XmlAnyElements { get; }
	public XmlArrayAttribute XmlArray { get; }
	public XmlArrayItemAttributes XmlArrayItems { get; }
	public XmlAttributeAttribute XmlAttribute { get; }
	public XmlChoiceIdentifierAttribute XmlChoiceIdentifier { get; }
	public object XmlDefaultValue { get; }
	public XmlElementAttributes XmlElements { get; }
	public bool XmlIgnore { get; }
	public bool Xmlns { get; }
	public XmlRootAttribute XmlRoot { get; }
	public XmlTextAttribute XmlText { get; }
	public XmlTypeAttribute XmlType { get; }
	internal Nullable<int> Order { get; }
	internal int SortableOrder { get; }

	// Methods

	// RVA: 0x110EE60 Offset: 0x110D460 VA: 0x18110EE60
	public void .ctor() { }

	// RVA: 0x110E380 Offset: 0x110C980 VA: 0x18110E380
	public void .ctor(ICustomAttributeProvider provider) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public XmlAnyAttributeAttribute get_XmlAnyAttribute() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public XmlAnyElementAttributes get_XmlAnyElements() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public XmlArrayAttribute get_XmlArray() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public XmlArrayItemAttributes get_XmlArrayItems() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public XmlAttributeAttribute get_XmlAttribute() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public XmlChoiceIdentifierAttribute get_XmlChoiceIdentifier() { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public object get_XmlDefaultValue() { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public XmlElementAttributes get_XmlElements() { }

	// RVA: 0x5925C0 Offset: 0x590BC0 VA: 0x1805925C0
	public bool get_XmlIgnore() { }

	// RVA: 0xAF6470 Offset: 0xAF4A70 VA: 0x180AF6470
	public bool get_Xmlns() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public XmlRootAttribute get_XmlRoot() { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public XmlTextAttribute get_XmlText() { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public XmlTypeAttribute get_XmlType() { }

	// RVA: 0x110DC90 Offset: 0x110C290 VA: 0x18110DC90
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x110EF60 Offset: 0x110D560 VA: 0x18110EF60
	internal Nullable<int> get_Order() { }

	// RVA: 0x110F010 Offset: 0x110D610 VA: 0x18110F010
	internal int get_SortableOrder() { }

}

public class XmlChoiceIdentifierAttribute : Attribute // TypeDefIndex: 2074
{	// Fields
	private string memberName; // 0x10

	// Properties
	public string MemberName { get; }

	// Methods

	// RVA: 0x110F1B0 Offset: 0x110D7B0 VA: 0x18110F1B0
	public string get_MemberName() { }

	// RVA: 0x110F090 Offset: 0x110D690 VA: 0x18110F090
	internal void AddKeyHash(StringBuilder sb) { }

}

internal class XmlCustomFormatter // TypeDefIndex: 2075
{	// Fields
	private static string[] allTimeFormats; // 0x13F80

	// Methods

	// RVA: 0x110F200 Offset: 0x110D800 VA: 0x18110F200
	internal static string FromEnum(long value, string[] values, long[] ids, string typeName) { }

	// RVA: 0x110F580 Offset: 0x110DB80 VA: 0x18110F580
	internal static string FromXmlName(string name) { }

	// RVA: 0x110F520 Offset: 0x110DB20 VA: 0x18110F520
	internal static string FromXmlNCName(string ncName) { }

	// RVA: 0x110FEC0 Offset: 0x110E4C0 VA: 0x18110FEC0
	internal static string ToXmlString(TypeData type, object value) { }

	// RVA: 0x110F5E0 Offset: 0x110DBE0 VA: 0x18110F5E0
	internal static object FromXmlString(TypeData type, string value) { }

	// RVA: 0x1110A30 Offset: 0x110F030 VA: 0x181110A30
	private static void .cctor() { }

}

public class XmlElementAttribute : Attribute // TypeDefIndex: 2076
{	// Fields
	private string dataType; // 0x10
	private string elementName; // 0x18
	private XmlSchemaForm form; // 0x20
	private string ns; // 0x28
	private bool isNullable; // 0x30
	private Type type; // 0x38
	private int order; // 0x40

	// Properties
	public string DataType { get; }
	public string ElementName { get; }
	public XmlSchemaForm Form { get; }
	public string Namespace { get; }
	public bool IsNullable { get; }
	public int Order { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x1111970 Offset: 0x110FF70 VA: 0x181111970
	public void .ctor(string elementName) { }

	// RVA: 0x1111910 Offset: 0x110FF10 VA: 0x181111910
	public void .ctor(string elementName, Type type) { }

	// RVA: 0x11119B0 Offset: 0x110FFB0 VA: 0x1811119B0
	public string get_DataType() { }

	// RVA: 0x1111A00 Offset: 0x1110000 VA: 0x181111A00
	public string get_ElementName() { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public XmlSchemaForm get_Form() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public string get_Namespace() { }

	// RVA: 0x82C2F0 Offset: 0x82A8F0 VA: 0x18082C2F0
	public bool get_IsNullable() { }

	// RVA: 0x5DE3D0 Offset: 0x5DC9D0 VA: 0x1805DE3D0
	public int get_Order() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public Type get_Type() { }

	// RVA: 0x1111420 Offset: 0x110FA20 VA: 0x181111420
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlElementAttributes : CollectionBase // TypeDefIndex: 2077
{	// Properties
	public XmlElementAttribute Item { get; }
	internal int Order { get; }

	// Methods

	// RVA: 0x1111C10 Offset: 0x1110210 VA: 0x181111C10
	public XmlElementAttribute get_Item(int index) { }

	// RVA: 0x1111BA0 Offset: 0x11101A0 VA: 0x181111BA0
	public int Add(XmlElementAttribute attribute) { }

	// RVA: 0x1111A50 Offset: 0x1110050 VA: 0x181111A50
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x1111CC0 Offset: 0x11102C0 VA: 0x181111CC0
	internal int get_Order() { }

	// RVA: 0x105D9B0 Offset: 0x105BFB0 VA: 0x18105D9B0
	public void .ctor() { }

}

public class XmlEnumAttribute : Attribute // TypeDefIndex: 2078
{	// Fields
	private string name; // 0x10

	// Properties
	public string Name { get; }

	// Methods

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(string name) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Name() { }

	// RVA: 0x1686090 Offset: 0x1684690 VA: 0x181686090
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlIgnoreAttribute : Attribute // TypeDefIndex: 2079
{	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

}

public class XmlIncludeAttribute : Attribute // TypeDefIndex: 2080
{	// Fields
	private Type type; // 0x10

	// Properties
	public Type Type { get; }

	// Methods

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public Type get_Type() { }

}

public abstract class XmlMapping // TypeDefIndex: 2081
{	// Fields
	private ObjectMap map; // 0x10
	private ArrayList relatedMaps; // 0x18
	private SerializationFormat format; // 0x20
	private SerializationSource source; // 0x28
	internal string _elementName; // 0x30
	internal string _namespace; // 0x38
	private string key; // 0x40

	// Properties
	public string ElementName { get; }
	public string Namespace { get; }
	internal ObjectMap ObjectMap { get; set; }
	internal ArrayList RelatedMaps { get; set; }
	internal SerializationFormat Format { get; set; }
	internal SerializationSource Source { get; }

	// Methods

	// RVA: 0x1686110 Offset: 0x1684710 VA: 0x181686110
	internal void .ctor(string elementName, string ns) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_ElementName() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public string get_Namespace() { }

	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	public void SetKey(string key) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal ObjectMap get_ObjectMap() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	internal void set_ObjectMap(ObjectMap value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal ArrayList get_RelatedMaps() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	internal void set_RelatedMaps(ArrayList value) { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	internal SerializationFormat get_Format() { }

	// RVA: 0x69D6C0 Offset: 0x69BCC0 VA: 0x18069D6C0
	internal void set_Format(SerializationFormat value) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	internal SerializationSource get_Source() { }

}

public class XmlMembersMapping : XmlMapping // TypeDefIndex: 2085
{
// Namespace: System.Xml.Serialization
[DefaultMemberAttribute] // RVA: 0x70CB0 Offset: 0x700B0 VA: 0x180070CB0
public class XmlMembersMapping : XmlMapping // TypeDefIndex: 2085
	// Fields
	private bool _hasWrapperElement; // 0x48
	private XmlMemberMapping[] _mapping; // 0x50

	// Properties
	public int Count { get; }
	internal bool HasWrapperElement { get; }

	// Methods

	// RVA: 0x1686160 Offset: 0x1684760 VA: 0x181686160
	public int get_Count() { }

	// RVA: 0x4BC370 Offset: 0x4BA970 VA: 0x1804BC370
	internal bool get_HasWrapperElement() { }

}

public class XmlNamespaceDeclarationsAttribute : Attribute // TypeDefIndex: 2086
{	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

}

public class XmlReflectionImporter // TypeDefIndex: 2087
{	// Fields
	private string initialDefaultNamespace; // 0x10
	private XmlAttributeOverrides attributeOverrides; // 0x18
	private ArrayList includedTypes; // 0x20
	private ReflectionHelper helper; // 0x28
	private int arrayChoiceCount; // 0x30
	private ArrayList relatedMaps; // 0x38
	private bool allowPrivateTypes; // 0x40
	private static readonly string errSimple; // 0x0
	private static readonly string errSimple2; // 0x8

	// Methods

	// RVA: 0x168D090 Offset: 0x168B690 VA: 0x18168D090
	public void .ctor(XmlAttributeOverrides attributeOverrides, string defaultNamespace) { }

	// RVA: 0x168C540 Offset: 0x168AB40 VA: 0x18168C540
	public XmlTypeMapping ImportTypeMapping(Type type) { }

	// RVA: 0x168C560 Offset: 0x168AB60 VA: 0x18168C560
	public XmlTypeMapping ImportTypeMapping(Type type, string defaultNamespace) { }

	// RVA: 0x168C390 Offset: 0x168A990 VA: 0x18168C390
	public XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x168BFB0 Offset: 0x168A5B0 VA: 0x18168BFB0
	private XmlTypeMapping ImportTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1686E10 Offset: 0x1685410 VA: 0x181686E10
	private XmlTypeMapping CreateTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultXmlType, string defaultNamespace) { }

	// RVA: 0x1689640 Offset: 0x1687C40 VA: 0x181689640
	private XmlTypeMapping ImportClassMapping(Type type, XmlRootAttribute root, string defaultNamespace, bool isBaseType = False) { }

	// RVA: 0x16885B0 Offset: 0x1686BB0 VA: 0x1816885B0
	private XmlTypeMapping ImportClassMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, bool isBaseType = False) { }

	// RVA: 0x168CEF0 Offset: 0x168B4F0 VA: 0x18168CEF0
	private void RegisterDerivedMap(XmlTypeMapping map, XmlTypeMapping derivedMap) { }

	// RVA: 0x1687FD0 Offset: 0x16865D0 VA: 0x181687FD0
	private string GetTypeNamespace(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x168BA20 Offset: 0x168A020 VA: 0x18168BA20
	private XmlTypeMapping ImportListMapping(Type type, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x168ADE0 Offset: 0x16893E0 VA: 0x18168ADE0
	private XmlTypeMapping ImportListMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x168C580 Offset: 0x168AB80 VA: 0x18168C580
	private XmlTypeMapping ImportXmlNodeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x168BAC0 Offset: 0x168A0C0 VA: 0x18168BAC0
	private XmlTypeMapping ImportPrimitiveMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x168A640 Offset: 0x1688C40 VA: 0x18168A640
	private XmlTypeMapping ImportEnumMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x168C920 Offset: 0x168AF20 VA: 0x18168C920
	private XmlTypeMapping ImportXmlSerializableMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x168ACA0 Offset: 0x16892A0 VA: 0x18168ACA0
	private void ImportIncludedTypes(Type type, string defaultNamespace) { }

	// RVA: 0x1687420 Offset: 0x1685A20 VA: 0x181687420
	private List<XmlReflectionMember> GetReflectionMembers(Type type) { }

	// RVA: 0x1686260 Offset: 0x1684860 VA: 0x181686260
	private XmlTypeMapMember CreateMapMember(Type declaringType, XmlReflectionMember rmember, string defaultNamespace) { }

	// RVA: 0x16896E0 Offset: 0x1687CE0 VA: 0x1816896E0
	private XmlTypeMapElementInfoList ImportElementInfo(Type cls, string defaultName, string defaultNamespace, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x16880E0 Offset: 0x16866E0 VA: 0x1816880E0
	private XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, XmlReflectionMember rmember, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x168BC60 Offset: 0x168A260 VA: 0x18168BC60
	private void ImportTextElementInfo(XmlTypeMapElementInfoList list, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts, string defaultNamespace) { }

	// RVA: 0x1686220 Offset: 0x1684820 VA: 0x181686220
	private bool CanBeNull(TypeData type) { }

	// RVA: 0x168CB10 Offset: 0x168B110 VA: 0x18168CB10
	public void IncludeType(Type type) { }

	// RVA: 0x1687280 Offset: 0x1685880 VA: 0x181687280
	private object GetDefaultValue(TypeData typeData, object defaultValue) { }

	// RVA: 0x168D020 Offset: 0x168B620 VA: 0x18168D020
	private static void .cctor() { }

}

private sealed class XmlReflectionImporter.<>c // TypeDefIndex: 2088
{	// Fields
	public static readonly XmlReflectionImporter.<>c <>9; // 0x0
	public static Comparison<XmlReflectionMember> <>9__28_0; // 0x8

	// Methods

	// RVA: 0x1685F80 Offset: 0x1684580 VA: 0x181685F80
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1685E70 Offset: 0x1684470 VA: 0x181685E70
	internal int <ImportClassMapping>b__28_0(XmlReflectionMember m1, XmlReflectionMember m2) { }

}

public class XmlReflectionMember // TypeDefIndex: 2089
{	// Fields
	private bool isReturnValue; // 0x10
	private string memberName; // 0x18
	private Type memberType; // 0x20
	private XmlAttributes xmlAttributes; // 0x28
	private Type declaringType; // 0x30

	// Properties
	public bool IsReturnValue { get; }
	public string MemberName { get; }
	public Type MemberType { get; }
	public XmlAttributes XmlAttributes { get; }
	internal Type DeclaringType { get; set; }

	// Methods

	// RVA: 0x168D190 Offset: 0x168B790 VA: 0x18168D190
	internal void .ctor(string name, Type type, XmlAttributes attributes) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_IsReturnValue() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_MemberName() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public Type get_MemberType() { }

	// RVA: 0x168D200 Offset: 0x168B800 VA: 0x18168D200
	public XmlAttributes get_XmlAttributes() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	internal Type get_DeclaringType() { }

	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	internal void set_DeclaringType(Type value) { }

}

public class XmlRootAttribute : Attribute // TypeDefIndex: 2090
{	// Fields
	private string dataType; // 0x10
	private string elementName; // 0x18
	private bool isNullable; // 0x20
	private string ns; // 0x28

	// Properties
	public string DataType { get; set; }
	public string ElementName { get; set; }
	public bool IsNullable { get; set; }
	public string Namespace { get; set; }

	// Methods

	// RVA: 0x168D320 Offset: 0x168B920 VA: 0x18168D320
	public void .ctor() { }

	// RVA: 0x168D330 Offset: 0x168B930 VA: 0x18168D330
	public void .ctor(string elementName) { }

	// RVA: 0x168D370 Offset: 0x168B970 VA: 0x18168D370
	public string get_DataType() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_DataType(string value) { }

	// RVA: 0x168D3C0 Offset: 0x168B9C0 VA: 0x18168D3C0
	public string get_ElementName() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_ElementName(string value) { }

	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80
	public bool get_IsNullable() { }

	// RVA: 0x7FA180 Offset: 0x7F8780 VA: 0x1807FA180
	public void set_IsNullable(bool value) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public string get_Namespace() { }

	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	public void set_Namespace(string value) { }

	// RVA: 0x168D270 Offset: 0x168B870 VA: 0x18168D270
	internal void AddKeyHash(StringBuilder sb) { }

}

public sealed class XmlSchemaProviderAttribute : Attribute // TypeDefIndex: 2091
{	// Fields
	private string _methodName; // 0x10
	private bool _isAny; // 0x18

	// Properties
	public string MethodName { get; }
	public bool IsAny { get; set; }

	// Methods

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(string methodName) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_MethodName() { }

	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0
	public bool get_IsAny() { }

	// RVA: 0x960010 Offset: 0x95E610 VA: 0x180960010
	public void set_IsAny(bool value) { }

}

public sealed class XmlSerializationCollectionFixupCallback : MulticastDelegate // TypeDefIndex: 2092
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x168DC70 Offset: 0x168C270 VA: 0x18168DC70 Slot: 12
	public virtual void Invoke(object collection, object collectionItems) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object collection, object collectionItems, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class XmlSerializationFixupCallback : MulticastDelegate // TypeDefIndex: 2093
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1428A90 Offset: 0x1427090 VA: 0x181428A90 Slot: 12
	public virtual void Invoke(object fixup) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(object fixup, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public abstract class XmlSerializationGeneratedCode // TypeDefIndex: 2094
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

public sealed class XmlSerializationReadCallback : MulticastDelegate // TypeDefIndex: 2095
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xD3DB90 Offset: 0xD3C190 VA: 0x180D3DB90 Slot: 12
	public virtual object Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual object EndInvoke(IAsyncResult result) { }

}

public abstract class XmlSerializationReader : XmlSerializationGeneratedCode // TypeDefIndex: 2096
{	// Fields
	private XmlDocument document; // 0x10
	private XmlReader reader; // 0x18
	private ArrayList fixups; // 0x20
	private Hashtable collFixups; // 0x28
	private ArrayList collItemFixups; // 0x30
	private Hashtable typesCallbacks; // 0x38
	private ArrayList noIDTargets; // 0x40
	private Hashtable targets; // 0x48
	private Hashtable delayedListFixups; // 0x50
	private XmlSerializer eventSource; // 0x58
	private int delayedFixupId; // 0x60
	private Hashtable referencedObjects; // 0x68
	private int readCount; // 0x70
	private int whileIterationCount; // 0x74
	private string w3SchemaNS; // 0x78
	private string w3InstanceNS; // 0x80
	private string w3InstanceNS2000; // 0x88
	private string w3InstanceNS1999; // 0x90
	private string soapNS; // 0x98
	private string wsdlNS; // 0xA0
	private string nullX; // 0xA8
	private string nil; // 0xB0
	private string typeX; // 0xB8
	private string arrayType; // 0xC0
	private XmlQualifiedName arrayQName; // 0xC8

	// Properties
	protected XmlDocument Document { get; }
	protected XmlReader Reader { get; }

	// Methods

	// RVA: 0x1695F80 Offset: 0x1694580 VA: 0x181695F80
	internal void Initialize(XmlReader reader, XmlSerializer eventSource) { }

	// RVA: 0x1695A30 Offset: 0x1694030 VA: 0x181695A30
	private ArrayList EnsureArrayList(ArrayList list) { }

	// RVA: 0x1695A80 Offset: 0x1694080 VA: 0x181695A80
	private Hashtable EnsureHashtable(Hashtable hash) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x1699D40 Offset: 0x1698340 VA: 0x181699D40
	protected XmlDocument get_Document() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	protected XmlReader get_Reader() { }

	// RVA: 0x1694F70 Offset: 0x1693570 VA: 0x181694F70
	protected void AddFixup(XmlSerializationReader.CollectionFixup fixup) { }

	// RVA: 0x1695090 Offset: 0x1693690 VA: 0x181695090
	protected void AddFixup(XmlSerializationReader.Fixup fixup) { }

	// RVA: 0x1694ED0 Offset: 0x16934D0 VA: 0x181694ED0
	private void AddFixup(XmlSerializationReader.CollectionItemFixup fixup) { }

	// RVA: 0x1695130 Offset: 0x1693730 VA: 0x181695130
	protected void AddReadCallback(string name, string ns, Type type, XmlSerializationReadCallback read) { }

	// RVA: 0x1695290 Offset: 0x1693890 VA: 0x181695290
	protected void AddTarget(string id, object o) { }

	// RVA: 0x1695830 Offset: 0x1693E30 VA: 0x181695830
	private string CurrentTag() { }

	// RVA: 0x16953E0 Offset: 0x16939E0 VA: 0x1816953E0
	protected Exception CreateReadOnlyCollectionException(string name) { }

	// RVA: 0x1695450 Offset: 0x1693A50 VA: 0x181695450
	protected Exception CreateUnknownConstantException(string value, Type enumType) { }

	// RVA: 0x16954C0 Offset: 0x1693AC0 VA: 0x1816954C0
	protected Exception CreateUnknownNodeException() { }

	// RVA: 0x1695540 Offset: 0x1693B40 VA: 0x181695540
	protected Exception CreateUnknownTypeException(XmlQualifiedName type) { }

	// RVA: 0x16959A0 Offset: 0x1693FA0 VA: 0x1816959A0
	protected Array EnsureArrayIndex(Array a, int index, Type elementType) { }

	// RVA: 0x1695BD0 Offset: 0x16941D0 VA: 0x181695BD0
	protected bool GetNullAttr() { }

	// RVA: 0x1695CB0 Offset: 0x16942B0 VA: 0x181695CB0
	protected object GetTarget(string id) { }

	// RVA: 0x1699550 Offset: 0x1697B50 VA: 0x181699550
	private bool TargetReady(string id) { }

	// RVA: 0x1695D80 Offset: 0x1694380 VA: 0x181695D80
	protected XmlQualifiedName GetXsiType() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void InitCallbacks();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void InitIDs();

	// RVA: 0x1696330 Offset: 0x1694930 VA: 0x181696330
	protected bool IsXmlnsAttribute(string name) { }

	// RVA: 0x16967A0 Offset: 0x1694DA0 VA: 0x1816967A0
	protected void ParseWsdlArrayType(XmlAttribute attr) { }

	// RVA: 0x1696940 Offset: 0x1694F40 VA: 0x181696940
	protected XmlQualifiedName ReadElementQualifiedName() { }

	// RVA: 0x1696A50 Offset: 0x1695050 VA: 0x181696A50
	protected void ReadEndElement() { }

	// RVA: 0x1696FF0 Offset: 0x16955F0 VA: 0x181696FF0
	protected bool ReadNull() { }

	// RVA: 0x1697250 Offset: 0x1695850 VA: 0x181697250
	protected XmlQualifiedName ReadNullableQualifiedName() { }

	// RVA: 0x1697280 Offset: 0x1695880 VA: 0x181697280
	protected string ReadNullableString() { }

	// RVA: 0x16972D0 Offset: 0x16958D0 VA: 0x1816972D0
	protected object ReadReferencedElement() { }

	// RVA: 0x1695AD0 Offset: 0x16940D0 VA: 0x181695AD0
	private XmlSerializationReader.WriteCallbackInfo GetCallbackInfo(XmlQualifiedName qname) { }

	// RVA: 0x1697340 Offset: 0x1695940 VA: 0x181697340
	protected object ReadReferencedElement(string name, string ns) { }

	// RVA: 0x1696B10 Offset: 0x1695110 VA: 0x181696B10
	private bool ReadList(out object resultList) { }

	// RVA: 0x1697620 Offset: 0x1695C20 VA: 0x181697620
	protected void ReadReferencedElements() { }

	// RVA: 0x16987F0 Offset: 0x1696DF0 VA: 0x1816987F0
	protected object ReadReferencingElement(out string fixupReference) { }

	// RVA: 0x16987D0 Offset: 0x1696DD0 VA: 0x1816987D0
	protected object ReadReferencingElement(string name, string ns, out string fixupReference) { }

	// RVA: 0x1698460 Offset: 0x1696A60 VA: 0x181698460
	protected object ReadReferencingElement(string name, string ns, bool elementCanBeType, out string fixupReference) { }

	// RVA: 0x1698870 Offset: 0x1696E70 VA: 0x181698870
	protected IXmlSerializable ReadSerializable(IXmlSerializable serializable) { }

	// RVA: 0x16992E0 Offset: 0x16978E0 VA: 0x1816992E0
	protected object ReadTypedPrimitive(XmlQualifiedName type) { }

	// RVA: 0x1698A60 Offset: 0x1697060 VA: 0x181698A60
	private object ReadTypedPrimitive(XmlQualifiedName qname, bool reportUnknown) { }

	// RVA: 0x1699420 Offset: 0x1697A20 VA: 0x181699420
	protected XmlNode ReadXmlNode(bool wrapped) { }

	// RVA: 0x16992F0 Offset: 0x16978F0 VA: 0x1816992F0
	protected XmlDocument ReadXmlDocument(bool wrapped) { }

	// RVA: 0x1699490 Offset: 0x1697A90 VA: 0x181699490
	protected Array ShrinkArray(Array a, int length, Type elementType, bool isNullable) { }

	// RVA: 0x1699570 Offset: 0x1697B70 VA: 0x181699570
	protected XmlQualifiedName ToXmlQualifiedName(string value) { }

	// RVA: 0x1699790 Offset: 0x1697D90 VA: 0x181699790
	protected void UnknownAttribute(object o, XmlAttribute attr, string qnames) { }

	// RVA: 0x16999C0 Offset: 0x1697FC0 VA: 0x1816999C0
	protected void UnknownElement(object o, XmlElement elem, string qnames) { }

	// RVA: 0x168F490 Offset: 0x168DA90 VA: 0x18168F490
	protected void UnknownNode(object o) { }

	// RVA: 0x1699C40 Offset: 0x1698240 VA: 0x181699C40
	protected void UnknownNode(object o, string qnames) { }

	// RVA: 0x16963A0 Offset: 0x16949A0 VA: 0x1816963A0
	private void OnUnknownNode(XmlNode node, object o, string qnames) { }

	// RVA: 0x1699CB0 Offset: 0x16982B0 VA: 0x181699CB0
	protected void UnreferencedObject(string id, object o) { }

}

private class XmlSerializationReader.WriteCallbackInfo // TypeDefIndex: 2097
{	// Fields
	public Type Type; // 0x10
	public string TypeName; // 0x18
	public string TypeNs; // 0x20
	public XmlSerializationReadCallback Callback; // 0x28

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private class XmlSerializationReader.CollectionItemFixup // TypeDefIndex: 2100
{	// Fields
	private Array list; // 0x10
	private int index; // 0x18
	private string id; // 0x20

	// Properties
	public Array Collection { get; }
	public int Index { get; }
	public string Id { get; }

	// Methods

	// RVA: 0xF5F970 Offset: 0xF5DF70 VA: 0x180F5F970
	public void .ctor(Array list, int index, string id) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public Array get_Collection() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public int get_Index() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Id() { }

}

internal class XmlSerializationReaderInterpreter : XmlSerializationReader // TypeDefIndex: 2101
{	// Fields
	private XmlMapping _typeMap; // 0xD0
	private SerializationFormat _format; // 0xD8
	private static readonly XmlQualifiedName AnyType; // 0x0
	private static readonly object[] empty_array; // 0x8

	// Methods

	// RVA: 0x1694E80 Offset: 0x1693480 VA: 0x181694E80
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x168F0D0 Offset: 0x168D6D0 VA: 0x18168F0D0 Slot: 4
	protected override void InitCallbacks() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	protected override void InitIDs() { }

	// RVA: 0x1694010 Offset: 0x1692610 VA: 0x181694010
	public object ReadRoot() { }

	// RVA: 0x168FF90 Offset: 0x168E590 VA: 0x18168FF90
	private object ReadEncodedObject(XmlTypeMapping typeMap) { }

	// RVA: 0x16931F0 Offset: 0x16917F0 VA: 0x1816931F0 Slot: 6
	protected virtual object ReadMessage(XmlMembersMapping typeMap) { }

	// RVA: 0x16942C0 Offset: 0x16928C0 VA: 0x1816942C0
	private object ReadRoot(XmlTypeMapping rootMap) { }

	// RVA: 0x1693B80 Offset: 0x1692180 VA: 0x181693B80 Slot: 7
	protected virtual object ReadObject(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x168FC90 Offset: 0x168E290 VA: 0x18168FC90 Slot: 8
	protected virtual object ReadClassInstance(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x168FBD0 Offset: 0x168E1D0 VA: 0x18168FBD0 Slot: 9
	protected virtual void ReadClassInstanceMembers(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x168F500 Offset: 0x168DB00 VA: 0x18168F500
	private void ReadAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x1690900 Offset: 0x168EF00 VA: 0x181690900
	private void ReadMembers(ClassMap map, object ob, bool isValueList, bool readBySoapOrder) { }

	// RVA: 0x16947E0 Offset: 0x1692DE0 VA: 0x1816947E0
	private void SetListMembersDefaults(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x168E870 Offset: 0x168CE70 VA: 0x18168E870
	internal void FixupMembers(ClassMap map, object obfixup, bool isValueList) { }

	// RVA: 0x168F490 Offset: 0x168DA90 VA: 0x18168F490 Slot: 10
	protected virtual void ProcessUnknownAttribute(object target) { }

	// RVA: 0x168F490 Offset: 0x168DA90 VA: 0x18168F490 Slot: 11
	protected virtual void ProcessUnknownElement(object target) { }

	// RVA: 0x168F410 Offset: 0x168DA10 VA: 0x18168F410
	private bool IsReadOnly(XmlTypeMapMember member, TypeData memType, object ob, bool isValueList) { }

	// RVA: 0x1694C10 Offset: 0x1693210 VA: 0x181694C10
	private void SetMemberValue(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x1694B10 Offset: 0x1693110 VA: 0x181694B10
	private void SetMemberValueFromAttr(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x168EEC0 Offset: 0x168D4C0 VA: 0x18168EEC0
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x16939C0 Offset: 0x1691FC0 VA: 0x1816939C0
	private object ReadObjectElement(XmlTypeMapElementInfo elem) { }

	// RVA: 0x1693E90 Offset: 0x1692490 VA: 0x181693E90
	private object ReadPrimitiveValue(XmlTypeMapElementInfo elem) { }

	// RVA: 0x168EFA0 Offset: 0x168D5A0 VA: 0x18168EFA0
	private object GetValueFromXmlString(string value, TypeData typeData, XmlTypeMapping typeMap) { }

	// RVA: 0x1690170 Offset: 0x168E770 VA: 0x181690170
	private object ReadListElement(XmlTypeMapping typeMap, bool isNullable, object list, bool canCreateInstance) { }

	// RVA: 0x1690650 Offset: 0x168EC50 VA: 0x181690650
	private object ReadListString(XmlTypeMapping typeMap, string values) { }

	// RVA: 0x168E070 Offset: 0x168C670 VA: 0x18168E070
	private void AddListValue(TypeData listType, ref object list, int index, object value, bool canCreateInstance) { }

	// RVA: 0x168E7A0 Offset: 0x168CDA0 VA: 0x18168E7A0
	private static object CreateInstance(Type type, bool nonPublic) { }

	// RVA: 0x168E730 Offset: 0x168CD30 VA: 0x18168E730
	private object CreateInstance(Type type) { }

	// RVA: 0x168E7B0 Offset: 0x168CDB0 VA: 0x18168E7B0
	private object CreateList(Type listType) { }

	// RVA: 0x168F390 Offset: 0x168D990 VA: 0x18168F390
	private object InitializeList(TypeData listType) { }

	// RVA: 0x168E850 Offset: 0x168CE50 VA: 0x18168E850
	private void FillList(object list, object items) { }

	// RVA: 0x168E420 Offset: 0x168CA20 VA: 0x18168E420
	private void CopyEnumerableList(object source, object dest) { }

	// RVA: 0x16943E0 Offset: 0x16929E0 VA: 0x1816943E0
	private object ReadXmlNodeElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x1694410 Offset: 0x1692A10 VA: 0x181694410
	private object ReadXmlNode(TypeData type, bool wrapped) { }

	// RVA: 0x1693DC0 Offset: 0x16923C0 VA: 0x181693DC0
	private object ReadPrimitiveElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x16900F0 Offset: 0x168E6F0 VA: 0x1816900F0
	private object ReadEnumElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x168ECF0 Offset: 0x168D2F0 VA: 0x18168ECF0
	private object GetEnumValue(XmlTypeMapping typeMap, string val) { }

	// RVA: 0x1694600 Offset: 0x1692C00 VA: 0x181694600
	private object ReadXmlSerializableElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x1694DE0 Offset: 0x16933E0 VA: 0x181694DE0
	private static void .cctor() { }

}

private class XmlSerializationReaderInterpreter.FixupCallbackInfo // TypeDefIndex: 2102
{	// Fields
	private XmlSerializationReaderInterpreter _sri; // 0x10
	private ClassMap _map; // 0x18
	private bool _isValueList; // 0x20

	// Methods

	// RVA: 0xFFCAB0 Offset: 0xFFB0B0 VA: 0x180FFCAB0
	public void .ctor(XmlSerializationReaderInterpreter sri, ClassMap map, bool isValueList) { }

	// RVA: 0x1685D50 Offset: 0x1684350 VA: 0x181685D50
	public void FixupMembers(object fixup) { }

}

private class XmlSerializationReaderInterpreter.ReaderCallbackInfo // TypeDefIndex: 2103
{	// Fields
	private XmlSerializationReaderInterpreter _sri; // 0x10
	private XmlTypeMapping _typeMap; // 0x18

	// Methods

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	public void .ctor(XmlSerializationReaderInterpreter sri, XmlTypeMapping typeMap) { }

	// RVA: 0x1685E30 Offset: 0x1684430 VA: 0x181685E30
	internal object ReadObject() { }

}

public sealed class XmlSerializationWriteCallback : MulticastDelegate // TypeDefIndex: 2104
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1428A90 Offset: 0x1427090 VA: 0x181428A90 Slot: 12
	public virtual void Invoke(object o) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(object o, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public abstract class XmlSerializationWriter : XmlSerializationGeneratedCode // TypeDefIndex: 2105
{	// Fields
	private ObjectIDGenerator idGenerator; // 0x10
	private int qnameCount; // 0x18
	private bool topLevelElement; // 0x1C
	private ArrayList namespaces; // 0x20
	private XmlWriter writer; // 0x28
	private Queue referencedElements; // 0x30
	private Hashtable callbacks; // 0x38
	private Hashtable serializedObjects; // 0x40

	// Properties
	protected XmlWriter Writer { get; }

	// Methods

	// RVA: 0x16A1A60 Offset: 0x16A0060 VA: 0x1816A1A60
	protected void .ctor() { }

	// RVA: 0x169EF50 Offset: 0x169D550 VA: 0x18169EF50
	internal void Initialize(XmlWriter writer, XmlSerializerNamespaces nss) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	protected XmlWriter get_Writer() { }

	// RVA: 0x169E780 Offset: 0x169CD80 VA: 0x18169E780
	protected void AddWriteCallback(Type type, string typeName, string typeNs, XmlSerializationWriteCallback callback) { }

	// RVA: 0x169E960 Offset: 0x169CF60 VA: 0x18169E960
	protected Exception CreateUnknownAnyElementException(string name, string ns) { }

	// RVA: 0x169EA40 Offset: 0x169D040 VA: 0x18169EA40
	protected Exception CreateUnknownTypeException(object o) { }

	// RVA: 0x169E9D0 Offset: 0x169CFD0 VA: 0x18169E9D0
	protected Exception CreateUnknownTypeException(Type type) { }

	// RVA: 0x169EAD0 Offset: 0x169D0D0 VA: 0x18169EAD0
	protected string FromXmlQualifiedName(XmlQualifiedName xmlQualifiedName) { }

	// RVA: 0x169EBB0 Offset: 0x169D1B0 VA: 0x18169EBB0
	private string GetId(object o, bool addToReferencesList) { }

	// RVA: 0x169E8A0 Offset: 0x169CEA0 VA: 0x18169E8A0
	private bool AlreadyQueued(object ob) { }

	// RVA: 0x169ECB0 Offset: 0x169D2B0 VA: 0x18169ECB0
	private string GetNamespacePrefix(string ns) { }

	// RVA: 0x169EDC0 Offset: 0x169D3C0 VA: 0x18169EDC0
	private string GetQualifiedName(string name, string ns) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void InitCallbacks();

	// RVA: 0x169F180 Offset: 0x169D780 VA: 0x18169F180
	protected void TopLevelElement() { }

	// RVA: 0x169F460 Offset: 0x169DA60 VA: 0x18169F460
	protected void WriteAttribute(string localName, string ns, string value) { }

	// RVA: 0x169F420 Offset: 0x169DA20 VA: 0x18169F420
	protected void WriteAttribute(string prefix, string localName, string ns, string value) { }

	// RVA: 0x16A1860 Offset: 0x169FE60 VA: 0x1816A1860
	private void WriteXmlNode(XmlNode node) { }

	// RVA: 0x169F4A0 Offset: 0x169DAA0 VA: 0x18169F4A0
	protected void WriteElementEncoded(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x169F590 Offset: 0x169DB90 VA: 0x18169F590
	protected void WriteElementLiteral(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x169F680 Offset: 0x169DC80 VA: 0x18169F680
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value) { }

	// RVA: 0x169F6A0 Offset: 0x169DCA0 VA: 0x18169F6A0
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x169F880 Offset: 0x169DE80 VA: 0x18169F880
	protected void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x169F8A0 Offset: 0x169DEA0 VA: 0x18169F8A0
	protected void WriteElementString(string localName, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0xBA5100 Offset: 0xBA3700 VA: 0x180BA5100
	protected void WriteEndElement() { }

	// RVA: 0x169FA10 Offset: 0x169E010 VA: 0x18169FA10
	protected void WriteEndElement(object o) { }

	// RVA: 0x169FA60 Offset: 0x169E060 VA: 0x18169FA60
	protected void WriteNamespaceDeclarations(XmlSerializerNamespaces xmlns) { }

	// RVA: 0x169FF20 Offset: 0x169E520 VA: 0x18169FF20
	protected void WriteNullableQualifiedNameEncoded(string name, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x169FFD0 Offset: 0x169E5D0 VA: 0x18169FFD0
	protected void WriteNullableQualifiedNameLiteral(string name, string ns, XmlQualifiedName value) { }

	// RVA: 0x16A0080 Offset: 0x169E680 VA: 0x1816A0080
	protected void WriteNullableStringEncoded(string name, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0x16A00A0 Offset: 0x169E6A0 VA: 0x1816A00A0
	protected void WriteNullableStringLiteral(string name, string ns, string value) { }

	// RVA: 0x169FDB0 Offset: 0x169E3B0 VA: 0x18169FDB0
	protected void WriteNullTagEncoded(string name, string ns) { }

	// RVA: 0x169FE60 Offset: 0x169E460 VA: 0x18169FE60
	protected void WriteNullTagLiteral(string name, string ns) { }

	// RVA: 0x16A00D0 Offset: 0x169E6D0 VA: 0x1816A00D0
	protected void WritePotentiallyReferencingElement(string n, string ns, object o, Type ambientType, bool suppressReference, bool isNullable) { }

	// RVA: 0x16A0530 Offset: 0x169EB30 VA: 0x1816A0530
	protected void WriteReferencedElements() { }

	// RVA: 0x169F080 Offset: 0x169D680 VA: 0x18169F080
	private bool IsPrimitiveArray(TypeData td) { }

	// RVA: 0x169F190 Offset: 0x169D790 VA: 0x18169F190
	private void WriteArray(object o, TypeData td) { }

	// RVA: 0x16A0790 Offset: 0x169ED90 VA: 0x1816A0790
	protected void WriteReferencingElement(string n, string ns, object o, bool isNullable) { }

	// RVA: 0x169E8E0 Offset: 0x169CEE0 VA: 0x18169E8E0
	private void CheckReferenceQueue() { }

	// RVA: 0x16A08E0 Offset: 0x169EEE0 VA: 0x1816A08E0
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable) { }

	// RVA: 0x16A0A10 Offset: 0x169F010 VA: 0x1816A0A10
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped) { }

	// RVA: 0x16A0B50 Offset: 0x169F150 VA: 0x1816A0B50
	protected void WriteStartDocument() { }

	// RVA: 0x16A1230 Offset: 0x169F830 VA: 0x1816A1230
	protected void WriteStartElement(string name, string ns) { }

	// RVA: 0x16A11D0 Offset: 0x169F7D0 VA: 0x1816A11D0
	protected void WriteStartElement(string name, string ns, bool writePrefixed) { }

	// RVA: 0x16A1200 Offset: 0x169F800 VA: 0x1816A1200
	protected void WriteStartElement(string name, string ns, object o) { }

	// RVA: 0x16A0BB0 Offset: 0x169F1B0 VA: 0x1816A0BB0
	protected void WriteStartElement(string name, string ns, object o, bool writePrefixed) { }

	// RVA: 0x16A0BE0 Offset: 0x169F1E0 VA: 0x1816A0BE0
	private void WriteStartElement(string name, string ns, object o, bool writePrefixed, ICollection namespaces) { }

	// RVA: 0x16A1260 Offset: 0x169F860 VA: 0x1816A1260
	protected void WriteTypedPrimitive(string name, string ns, object o, bool xsiType) { }

	// RVA: 0x16A1580 Offset: 0x169FB80 VA: 0x1816A1580
	protected void WriteValue(string value) { }

	// RVA: 0x16A15C0 Offset: 0x169FBC0 VA: 0x1816A15C0
	protected void WriteXmlAttribute(XmlNode node, object container) { }

	// RVA: 0x16A1990 Offset: 0x169FF90 VA: 0x1816A1990
	protected void WriteXsiType(string name, string ns) { }

}

private class XmlSerializationWriter.WriteCallbackInfo // TypeDefIndex: 2106
{	// Fields
	public Type Type; // 0x10
	public string TypeName; // 0x18
	public string TypeNs; // 0x20
	public XmlSerializationWriteCallback Callback; // 0x28

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal class XmlSerializationWriterInterpreter : XmlSerializationWriter // TypeDefIndex: 2107
{	// Fields
	private XmlMapping _typeMap; // 0x48
	private SerializationFormat _format; // 0x50

	// Methods

	// RVA: 0x169E6E0 Offset: 0x169CCE0 VA: 0x18169E6E0
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x169A750 Offset: 0x1698D50 VA: 0x18169A750 Slot: 4
	protected override void InitCallbacks() { }

	// RVA: 0x169E440 Offset: 0x169CA40 VA: 0x18169E440
	public void WriteRoot(object ob) { }

	// RVA: 0x169D730 Offset: 0x169BD30 VA: 0x18169D730 Slot: 5
	protected virtual void WriteObject(XmlTypeMapping typeMap, object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem) { }

	// RVA: 0x169D260 Offset: 0x169B860 VA: 0x18169D260 Slot: 6
	protected virtual void WriteMessage(XmlMembersMapping membersMap, object[] parameters) { }

	// RVA: 0x169D5E0 Offset: 0x169BBE0 VA: 0x18169D5E0 Slot: 7
	protected virtual void WriteObjectElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x169D460 Offset: 0x169BA60 VA: 0x18169D460 Slot: 8
	protected virtual void WriteObjectElementAttributes(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x169D520 Offset: 0x169BB20 VA: 0x18169D520 Slot: 9
	protected virtual void WriteObjectElementElements(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x169D200 Offset: 0x169B800 VA: 0x18169D200
	private void WriteMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x169B540 Offset: 0x1699B40 VA: 0x18169B540
	private void WriteAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x169BCB0 Offset: 0x169A2B0 VA: 0x18169BCB0
	private void WriteElementMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x169A070 Offset: 0x1698670 VA: 0x18169A070
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x169AA10 Offset: 0x1699010 VA: 0x18169AA10
	private bool MemberHasValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x169CB60 Offset: 0x169B160 VA: 0x18169CB60
	private void WriteMemberElement(XmlTypeMapElementInfo elem, object memberValue) { }

	// RVA: 0x169A3A0 Offset: 0x16989A0 VA: 0x18169A3A0
	internal static object ImplicitConvert(object obj, Type type) { }

	// RVA: 0x169E140 Offset: 0x169C740 VA: 0x18169E140
	private void WritePrimitiveValueLiteral(object memberValue, string name, string ns, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x169DE10 Offset: 0x169C410 VA: 0x18169DE10
	private void WritePrimitiveValueEncoded(object memberValue, string name, string ns, XmlQualifiedName xsiType, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x169C900 Offset: 0x169AF00 VA: 0x18169C900 Slot: 10
	protected virtual void WriteListElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x169C290 Offset: 0x169A890 VA: 0x18169C290
	private void WriteListContent(object container, TypeData listType, ListMap map, object ob, StringBuilder targetString) { }

	// RVA: 0x1699F00 Offset: 0x1698500 VA: 0x181699F00
	private int GetListCount(TypeData listType, object ob) { }

	// RVA: 0x169AC60 Offset: 0x1699260 VA: 0x18169AC60
	private void WriteAnyElementContent(XmlTypeMapMemberAnyElement member, object memberValue) { }

	// RVA: 0x169DDC0 Offset: 0x169C3C0 VA: 0x18169DDC0 Slot: 11
	protected virtual void WritePrimitiveElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x169C250 Offset: 0x169A850 VA: 0x18169C250 Slot: 12
	protected virtual void WriteEnumElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x169A150 Offset: 0x1698750 VA: 0x18169A150
	private string GetStringValue(XmlTypeMapping typeMap, TypeData type, object value) { }

	// RVA: 0x1699DE0 Offset: 0x16983E0 VA: 0x181699DE0
	private string GetEnumXmlValue(XmlTypeMapping typeMap, object ob) { }

}

private class XmlSerializationWriterInterpreter.CallbackInfo // TypeDefIndex: 2108
{	// Fields
	private XmlSerializationWriterInterpreter _swi; // 0x10
	private XmlTypeMapping _typeMap; // 0x18

	// Methods

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	public void .ctor(XmlSerializationWriterInterpreter swi, XmlTypeMapping typeMap) { }

	// RVA: 0xE4DBD0 Offset: 0xE4C1D0 VA: 0x180E4DBD0
	internal void WriteObject(object ob) { }

	// RVA: 0xE4DB70 Offset: 0xE4C170 VA: 0x180E4DB70
	internal void WriteEnum(object ob) { }

}

public class XmlSerializer // TypeDefIndex: 2109
{	// Fields
	private static int generationThreshold; // 0x0
	private static bool backgroundGeneration; // 0x4
	private static bool deleteTempFiles; // 0x5
	private static bool generatorFallback; // 0x6
	private bool customSerializer; // 0x10
	private XmlMapping typeMapping; // 0x18
	private XmlSerializer.SerializerData serializerData; // 0x20
	private static Hashtable serializerTypes; // 0x8
	private UnreferencedObjectEventHandler onUnreferencedObject; // 0x28
	private XmlAttributeEventHandler onUnknownAttribute; // 0x30
	private XmlElementEventHandler onUnknownElement; // 0x38
	private XmlNodeEventHandler onUnknownNode; // 0x40
	private static Encoding DefaultEncoding; // 0x10

	// Properties
	internal XmlMapping Mapping { get; }

	// Methods

	// RVA: 0xE691D0 Offset: 0xE677D0 VA: 0x180E691D0
	private static void .cctor() { }

	// RVA: 0xE69440 Offset: 0xE67A40 VA: 0x180E69440
	public void .ctor(Type type) { }

	// RVA: 0xE692C0 Offset: 0xE678C0 VA: 0x180E692C0
	public void .ctor(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal XmlMapping get_Mapping() { }

	// RVA: 0xE68BC0 Offset: 0xE671C0 VA: 0x180E68BC0 Slot: 4
	internal virtual void OnUnknownAttribute(XmlAttributeEventArgs e) { }

	// RVA: 0xE68BE0 Offset: 0xE671E0 VA: 0x180E68BE0 Slot: 5
	internal virtual void OnUnknownElement(XmlElementEventArgs e) { }

	// RVA: 0xE68C00 Offset: 0xE67200 VA: 0x180E68C00 Slot: 6
	internal virtual void OnUnknownNode(XmlNodeEventArgs e) { }

	// RVA: 0xE68C20 Offset: 0xE67220 VA: 0x180E68C20 Slot: 7
	internal virtual void OnUnreferencedObject(UnreferencedObjectEventArgs e) { }

	// RVA: 0xE683B0 Offset: 0xE669B0 VA: 0x180E683B0 Slot: 8
	protected virtual XmlSerializationReader CreateReader() { }

	// RVA: 0xE68460 Offset: 0xE66A60 VA: 0x180E68460 Slot: 9
	protected virtual XmlSerializationWriter CreateWriter() { }

	// RVA: 0xE68AA0 Offset: 0xE670A0 VA: 0x180E68AA0
	public object Deserialize(TextReader textReader) { }

	// RVA: 0xE68760 Offset: 0xE66D60 VA: 0x180E68760
	public object Deserialize(XmlReader xmlReader) { }

	// RVA: 0xE68820 Offset: 0xE66E20 VA: 0x180E68820 Slot: 10
	protected virtual object Deserialize(XmlSerializationReader reader) { }

	// RVA: 0xE68EF0 Offset: 0xE674F0 VA: 0x180E68EF0 Slot: 11
	protected virtual void Serialize(object o, XmlSerializationWriter writer) { }

	// RVA: 0xE69130 Offset: 0xE67730 VA: 0x180E69130
	public void Serialize(TextWriter textWriter, object o) { }

	// RVA: 0xE69110 Offset: 0xE67710 VA: 0x180E69110
	public void Serialize(XmlWriter xmlWriter, object o) { }

	// RVA: 0xE68C40 Offset: 0xE67240 VA: 0x180E68C40
	public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces) { }

	// RVA: 0xE684B0 Offset: 0xE66AB0 VA: 0x180E684B0
	private XmlSerializationWriter CreateWriter(XmlMapping typeMapping) { }

	// RVA: 0xE68400 Offset: 0xE66A00 VA: 0x180E68400
	private XmlSerializationReader CreateReader(XmlMapping typeMapping) { }

}

internal class XmlSerializer.SerializerData // TypeDefIndex: 2110
{	// Fields
	public MethodInfo ReaderMethod; // 0x10
	public Type WriterType; // 0x18
	public MethodInfo WriterMethod; // 0x20
	public XmlSerializerImplementation Implementation; // 0x28

	// Methods

	// RVA: 0xE4DC30 Offset: 0xE4C230 VA: 0x180E4DC30
	public XmlSerializationWriter CreateWriter() { }

}

public class XmlSerializerFactory // TypeDefIndex: 2111
{	// Fields
	private static Hashtable serializersBySource; // 0x14001

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xE67710 Offset: 0xE65D10 VA: 0x180E67710
	public XmlSerializer CreateSerializer(Type type) { }

	// RVA: 0xE67740 Offset: 0xE65D40 VA: 0x180E67740
	public XmlSerializer CreateSerializer(Type type, XmlRootAttribute root) { }

	// RVA: 0xE67770 Offset: 0xE65D70 VA: 0x180E67770
	public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0xE67AF0 Offset: 0xE660F0 VA: 0x180E67AF0
	private static void .cctor() { }

}

public abstract class XmlSerializerImplementation // TypeDefIndex: 2112
{	// Properties
	public virtual XmlSerializationWriter Writer { get; }

	// Methods

	// RVA: 0xE67B50 Offset: 0xE66150 VA: 0x180E67B50 Slot: 4
	public virtual XmlSerializationWriter get_Writer() { }

}

public class XmlTextAttribute : Attribute // TypeDefIndex: 2113
{	// Fields
	private string dataType; // 0x10
	private Type type; // 0x18

	// Properties
	public string DataType { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xE69500 Offset: 0xE67B00 VA: 0x180E69500
	public string get_DataType() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Type get_Type() { }

	// RVA: 0xE69470 Offset: 0xE67A70 VA: 0x180E69470
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlTypeAttribute : Attribute // TypeDefIndex: 2114
{	// Fields
	private bool includeInSchema; // 0x10
	private string ns; // 0x18
	private string typeName; // 0x20

	// Properties
	public bool IncludeInSchema { get; }
	public string Namespace { get; }
	public string TypeName { get; }

	// Methods

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_IncludeInSchema() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Namespace() { }

	// RVA: 0xE695F0 Offset: 0xE67BF0 VA: 0x180E695F0
	public string get_TypeName() { }

	// RVA: 0xE69550 Offset: 0xE67B50 VA: 0x180E69550
	internal void AddKeyHash(StringBuilder sb) { }

}

internal class XmlTypeMapElementInfo // TypeDefIndex: 2115
{	// Fields
	private string _elementName; // 0x10
	private string _namespace; // 0x18
	private XmlSchemaForm _form; // 0x20
	private XmlTypeMapMember _member; // 0x28
	private object _choiceValue; // 0x30
	private bool _isNullable; // 0x38
	private int _nestingLevel; // 0x3C
	private XmlTypeMapping _mappedType; // 0x40
	private TypeData _type; // 0x48
	private bool _wrappedElement; // 0x50
	private int _explicitOrder; // 0x54

	// Properties
	public TypeData TypeData { get; }
	public object ChoiceValue { get; set; }
	public string ElementName { get; set; }
	public string Namespace { get; set; }
	public string DataTypeNamespace { get; }
	public string DataTypeName { get; }
	public XmlSchemaForm Form { get; set; }
	public XmlTypeMapping MappedType { get; set; }
	public bool IsNullable { get; set; }
	public XmlTypeMapMember Member { get; }
	public int NestingLevel { set; }
	public bool MultiReferenceType { get; }
	public bool WrappedElement { get; set; }
	public bool IsTextElement { get; set; }
	public bool IsUnnamedAnyElement { get; set; }
	public int ExplicitOrder { get; set; }

	// Methods

	// RVA: 0xE697F0 Offset: 0xE67DF0 VA: 0x180E697F0
	public void .ctor(XmlTypeMapMember member, TypeData type) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public TypeData get_TypeData() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public object get_ChoiceValue() { }

	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	public void set_ChoiceValue(object value) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_ElementName() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_ElementName(string value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Namespace() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_Namespace(string value) { }

	// RVA: 0xE698E0 Offset: 0xE67EE0 VA: 0x180E698E0
	public string get_DataTypeNamespace() { }

	// RVA: 0xE698B0 Offset: 0xE67EB0 VA: 0x180E698B0
	public string get_DataTypeName() { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public XmlSchemaForm get_Form() { }

	// RVA: 0x69D6C0 Offset: 0x69BCC0 VA: 0x18069D6C0
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public XmlTypeMapping get_MappedType() { }

	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	public void set_MappedType(XmlTypeMapping value) { }

	// RVA: 0x8C1660 Offset: 0x8BFC60 VA: 0x1808C1660
	public bool get_IsNullable() { }

	// RVA: 0x78E190 Offset: 0x78C790 VA: 0x18078E190
	public void set_IsNullable(bool value) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public XmlTypeMapMember get_Member() { }

	// RVA: 0x8C1690 Offset: 0x8BFC90 VA: 0x1808C1690
	public void set_NestingLevel(int value) { }

	// RVA: 0xE699F0 Offset: 0xE67FF0 VA: 0x180E699F0
	public bool get_MultiReferenceType() { }

	// RVA: 0x77B140 Offset: 0x779740 VA: 0x18077B140
	public bool get_WrappedElement() { }

	// RVA: 0xE69B60 Offset: 0xE68160 VA: 0x180E69B60
	public void set_WrappedElement(bool value) { }

	// RVA: 0xE69960 Offset: 0xE67F60 VA: 0x180E69960
	public bool get_IsTextElement() { }

	// RVA: 0xE69A10 Offset: 0xE68010 VA: 0x180E69A10
	public void set_IsTextElement(bool value) { }

	// RVA: 0xE699A0 Offset: 0xE67FA0 VA: 0x180E699A0
	public bool get_IsUnnamedAnyElement() { }

	// RVA: 0xE69AB0 Offset: 0xE680B0 VA: 0x180E69AB0
	public void set_IsUnnamedAnyElement(bool value) { }

	// RVA: 0x5DE8B0 Offset: 0x5DCEB0 VA: 0x1805DE8B0
	public int get_ExplicitOrder() { }

	// RVA: 0xE69A00 Offset: 0xE68000 VA: 0x180E69A00
	public void set_ExplicitOrder(int value) { }

	// RVA: 0xE696A0 Offset: 0xE67CA0 VA: 0x180E696A0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xCCECC0 Offset: 0xCCD2C0 VA: 0x180CCECC0 Slot: 2
	public override int GetHashCode() { }

}

internal class XmlTypeMapElementInfoList : ArrayList // TypeDefIndex: 2116
{	// Methods

	// RVA: 0xE69640 Offset: 0xE67C40 VA: 0x180E69640
	public void .ctor() { }

}

internal class XmlTypeMapMember // TypeDefIndex: 2117
{	// Fields
	private string _name; // 0x10
	private int _index; // 0x18
	private int _globalIndex; // 0x1C
	private int _specifiedGlobalIndex; // 0x20
	private TypeData _typeData; // 0x28
	private MemberInfo _member; // 0x30
	private MemberInfo _specifiedMember; // 0x38
	private MethodInfo _shouldSerialize; // 0x40
	private object _defaultValue; // 0x48
	private int _flags; // 0x50

	// Properties
	public string Name { get; set; }
	public object DefaultValue { get; set; }
	public TypeData TypeData { get; set; }
	public int Index { get; set; }
	public int GlobalIndex { get; set; }
	public bool IsOptionalValueType { get; set; }
	public bool IsReturnValue { get; set; }

	// Methods

	// RVA: 0xE6BB60 Offset: 0xE6A160 VA: 0x180E6BB60
	public void .ctor() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Name() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_Name(string value) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public object get_DefaultValue() { }

	// RVA: 0x5DD7A0 Offset: 0x5DBDA0 VA: 0x1805DD7A0
	public void set_DefaultValue(object value) { }

	// RVA: 0xE6B1C0 Offset: 0xE697C0 VA: 0x180E6B1C0
	public bool IsReadOnly(Type type) { }

	// RVA: 0xE6AA70 Offset: 0xE69070 VA: 0x180E6AA70
	public static object GetValue(object ob, string name) { }

	// RVA: 0xE6ACA0 Offset: 0xE692A0 VA: 0x180E6ACA0
	public object GetValue(object ob) { }

	// RVA: 0xE6B6F0 Offset: 0xE69CF0 VA: 0x180E6B6F0
	public void SetValue(object ob, object value) { }

	// RVA: 0xE6B920 Offset: 0xE69F20 VA: 0x180E6B920
	public static void SetValue(object ob, string name, object value) { }

	// RVA: 0xE6AEB0 Offset: 0xE694B0 VA: 0x180E6AEB0
	private void InitMember(Type type) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public TypeData get_TypeData() { }

	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	public void set_TypeData(TypeData value) { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public int get_Index() { }

	// RVA: 0x79C6B0 Offset: 0x79ACB0 VA: 0x18079C6B0
	public void set_Index(int value) { }

	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0
	public int get_GlobalIndex() { }

	// RVA: 0x960000 Offset: 0x95E600 VA: 0x180960000
	public void set_GlobalIndex(int value) { }

	// RVA: 0xD86AE0 Offset: 0xD850E0 VA: 0x180D86AE0
	public bool get_IsOptionalValueType() { }

	// RVA: 0xE6BBF0 Offset: 0xE6A1F0 VA: 0x180E6BBF0
	public void set_IsOptionalValueType(bool value) { }

	// RVA: 0xE6BBE0 Offset: 0xE6A1E0 VA: 0x180E6BBE0
	public bool get_IsReturnValue() { }

	// RVA: 0xE6BC10 Offset: 0xE6A210 VA: 0x180E6BC10
	public void set_IsReturnValue(bool value) { }

	// RVA: 0xE6A690 Offset: 0xE68C90 VA: 0x180E6A690
	public void CheckOptionalValueType(Type type) { }

	// RVA: 0xE6A710 Offset: 0xE68D10 VA: 0x180E6A710
	public bool GetValueSpecified(object ob) { }

	// RVA: 0xE6B300 Offset: 0xE69900 VA: 0x180E6B300
	public void SetValueSpecified(object ob, bool value) { }

}

internal class XmlTypeMapMemberAttribute : XmlTypeMapMember // TypeDefIndex: 2118
{	// Fields
	private string _attributeName; // 0x58
	private string _namespace; // 0x60
	private XmlSchemaForm _form; // 0x68
	private XmlTypeMapping _mappedType; // 0x70

	// Properties
	public string AttributeName { get; set; }
	public string Namespace { get; set; }
	public XmlSchemaForm Form { set; }
	public XmlTypeMapping MappedType { get; set; }

	// Methods

	// RVA: 0xE6A020 Offset: 0xE68620 VA: 0x180E6A020
	public void .ctor() { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public string get_AttributeName() { }

	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810
	public void set_AttributeName(string value) { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public string get_Namespace() { }

	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0
	public void set_Namespace(string value) { }

	// RVA: 0x804150 Offset: 0x802750 VA: 0x180804150
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public XmlTypeMapping get_MappedType() { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	public void set_MappedType(XmlTypeMapping value) { }

}

internal class XmlTypeMapMemberElement : XmlTypeMapMember // TypeDefIndex: 2119
{	// Fields
	private XmlTypeMapElementInfoList _elementInfo; // 0x58
	private string _choiceMember; // 0x60
	private bool _isTextCollector; // 0x68
	private TypeData _choiceTypeData; // 0x70

	// Properties
	public XmlTypeMapElementInfoList ElementInfo { get; set; }
	public string ChoiceMember { get; set; }
	public TypeData ChoiceTypeData { get; set; }
	public bool IsXmlTextCollector { get; set; }

	// Methods

	// RVA: 0xE69B70 Offset: 0xE68170 VA: 0x180E69B70
	public void .ctor() { }

	// RVA: 0xE6A5D0 Offset: 0xE68BD0 VA: 0x180E6A5D0
	public XmlTypeMapElementInfoList get_ElementInfo() { }

	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810
	public void set_ElementInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public string get_ChoiceMember() { }

	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0
	public void set_ChoiceMember(string value) { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public TypeData get_ChoiceTypeData() { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	public void set_ChoiceTypeData(TypeData value) { }

	// RVA: 0xE6A070 Offset: 0xE68670 VA: 0x180E6A070
	public XmlTypeMapElementInfo FindElement(object ob, object memberValue) { }

	// RVA: 0xE6A5B0 Offset: 0xE68BB0 VA: 0x180E6A5B0
	public void SetChoice(object ob, object choice) { }

	// RVA: 0x82D060 Offset: 0x82B660 VA: 0x18082D060
	public bool get_IsXmlTextCollector() { }

	// RVA: 0xE6A680 Offset: 0xE68C80 VA: 0x180E6A680
	public void set_IsXmlTextCollector(bool value) { }

}

internal class XmlTypeMapMemberList : XmlTypeMapMemberElement // TypeDefIndex: 2120
{	// Methods

	// RVA: 0xE69B70 Offset: 0xE68170 VA: 0x180E69B70
	public void .ctor() { }

}

internal class XmlTypeMapMemberExpandable : XmlTypeMapMemberElement // TypeDefIndex: 2121
{	// Fields
	private int _flatArrayIndex; // 0x78

	// Properties
	public int FlatArrayIndex { get; set; }

	// Methods

	// RVA: 0xAF64F0 Offset: 0xAF4AF0 VA: 0x180AF64F0
	public int get_FlatArrayIndex() { }

	// RVA: 0xB29460 Offset: 0xB27A60 VA: 0x180B29460
	public void set_FlatArrayIndex(int value) { }

	// RVA: 0xE69B70 Offset: 0xE68170 VA: 0x180E69B70
	public void .ctor() { }

}

internal class XmlTypeMapMemberFlatList : XmlTypeMapMemberExpandable // TypeDefIndex: 2122
{	// Fields
	private ListMap _listMap; // 0x80

	// Properties
	public ListMap ListMap { get; set; }

	// Methods

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public ListMap get_ListMap() { }

	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	public void set_ListMap(ListMap value) { }

	// RVA: 0xE69B70 Offset: 0xE68170 VA: 0x180E69B70
	public void .ctor() { }

}

internal class XmlTypeMapMemberAnyElement : XmlTypeMapMemberExpandable // TypeDefIndex: 2123
{	// Properties
	public bool IsDefaultAny { get; }

	// Methods

	// RVA: 0xE69B80 Offset: 0xE68180 VA: 0x180E69B80
	public bool IsElementDefined(string name, string ns) { }

	// RVA: 0xE69DD0 Offset: 0xE683D0 VA: 0x180E69DD0
	public bool get_IsDefaultAny() { }

	// RVA: 0xE69B70 Offset: 0xE68170 VA: 0x180E69B70
	public void .ctor() { }

}

internal class XmlTypeMapMemberAnyAttribute : XmlTypeMapMember // TypeDefIndex: 2124
{	// Methods

	// RVA: 0xE69B70 Offset: 0xE68170 VA: 0x180E69B70
	public void .ctor() { }

}

internal class XmlTypeMapMemberNamespaces : XmlTypeMapMember // TypeDefIndex: 2125
{	// Methods

	// RVA: 0xE69B70 Offset: 0xE68170 VA: 0x180E69B70
	public void .ctor() { }

}

public class XmlTypeMapping : XmlMapping // TypeDefIndex: 2126
{	// Fields
	private string xmlType; // 0x48
	private string xmlTypeNamespace; // 0x50
	private TypeData type; // 0x58
	private XmlTypeMapping baseMap; // 0x60
	private bool multiReferenceType; // 0x68
	private bool includeInSchema; // 0x69
	private bool isNullable; // 0x6A
	private bool isAny; // 0x6B
	private ArrayList _derivedTypes; // 0x70

	// Properties
	public string TypeFullName { get; }
	internal TypeData TypeData { get; }
	internal string XmlType { get; set; }
	internal string XmlTypeNamespace { get; set; }
	internal bool HasXmlTypeNamespace { get; }
	internal ArrayList DerivedTypes { get; }
	internal bool MultiReferenceType { get; }
	internal XmlTypeMapping BaseMap { get; set; }
	internal bool IncludeInSchema { set; }
	internal bool IsNullable { get; set; }
	internal bool IsAny { get; set; }

	// Methods

	// RVA: 0xE6C0D0 Offset: 0xE6A6D0 VA: 0x180E6C0D0
	internal void .ctor(string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }

	// RVA: 0xE6C1C0 Offset: 0xE6A7C0 VA: 0x180E6C1C0
	public string get_TypeFullName() { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	internal TypeData get_TypeData() { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	internal string get_XmlType() { }

	// RVA: 0x5DD7A0 Offset: 0x5DBDA0 VA: 0x1805DD7A0
	internal void set_XmlType(string value) { }

	// RVA: 0xE6C1E0 Offset: 0xE6A7E0 VA: 0x180E6C1E0
	internal string get_XmlTypeNamespace() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	internal void set_XmlTypeNamespace(string value) { }

	// RVA: 0xE6C1A0 Offset: 0xE6A7A0 VA: 0x180E6C1A0
	internal bool get_HasXmlTypeNamespace() { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	internal ArrayList get_DerivedTypes() { }

	// RVA: 0x82D060 Offset: 0x82B660 VA: 0x18082D060
	internal bool get_MultiReferenceType() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	internal XmlTypeMapping get_BaseMap() { }

	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0
	internal void set_BaseMap(XmlTypeMapping value) { }

	// RVA: 0xBA27D0 Offset: 0xBA0DD0 VA: 0x180BA27D0
	internal void set_IncludeInSchema(bool value) { }

	// RVA: 0xBA2240 Offset: 0xBA0840 VA: 0x180BA2240
	internal bool get_IsNullable() { }

	// RVA: 0xBA25A0 Offset: 0xBA0BA0 VA: 0x180BA25A0
	internal void set_IsNullable(bool value) { }

	// RVA: 0xE6C1B0 Offset: 0xE6A7B0 VA: 0x180E6C1B0
	internal bool get_IsAny() { }

	// RVA: 0xE6C230 Offset: 0xE6A830 VA: 0x180E6C230
	internal void set_IsAny(bool value) { }

	// RVA: 0xE6BE90 Offset: 0xE6A490 VA: 0x180E6BE90
	internal XmlTypeMapping GetRealTypeMap(Type objectType) { }

	// RVA: 0xE6BC30 Offset: 0xE6A230 VA: 0x180E6BC30
	internal XmlTypeMapping GetRealElementMap(string name, string ens) { }

	// RVA: 0xE6C040 Offset: 0xE6A640 VA: 0x180E6C040
	internal void UpdateRoot(XmlQualifiedName qname) { }

}

public enum XmlSchemaDatatypeVariety // TypeDefIndex: 2174
{	// Fields
	public int value__; // 0x0
	public const XmlSchemaDatatypeVariety Atomic = 0;
	public const XmlSchemaDatatypeVariety List = 1;
	public const XmlSchemaDatatypeVariety Union = 2;

}

internal class XsdSimpleValue // TypeDefIndex: 2175
{	// Fields
	private XmlSchemaSimpleType xmlType; // 0x10
	private object typedValue; // 0x18

	// Properties
	public XmlSchemaSimpleType XmlType { get; }
	public object TypedValue { get; }

	// Methods

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	public void .ctor(XmlSchemaSimpleType st, object value) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public XmlSchemaSimpleType get_XmlType() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public object get_TypedValue() { }

}

internal enum XmlSchemaWhiteSpace // TypeDefIndex: 2177
{	// Fields
	public int value__; // 0x0
	public const XmlSchemaWhiteSpace Preserve = 0;
	public const XmlSchemaWhiteSpace Replace = 1;
	public const XmlSchemaWhiteSpace Collapse = 2;

}

public sealed class XmlSchemaInference // TypeDefIndex: 2259
{	// Fields
	internal static XmlQualifiedName ST_boolean; // 0x0
	internal static XmlQualifiedName ST_byte; // 0x8
	internal static XmlQualifiedName ST_unsignedByte; // 0x10
	internal static XmlQualifiedName ST_short; // 0x18
	internal static XmlQualifiedName ST_unsignedShort; // 0x20
	internal static XmlQualifiedName ST_int; // 0x28
	internal static XmlQualifiedName ST_unsignedInt; // 0x30
	internal static XmlQualifiedName ST_long; // 0x38
	internal static XmlQualifiedName ST_unsignedLong; // 0x40
	internal static XmlQualifiedName ST_integer; // 0x48
	internal static XmlQualifiedName ST_decimal; // 0x50
	internal static XmlQualifiedName ST_float; // 0x58
	internal static XmlQualifiedName ST_double; // 0x60
	internal static XmlQualifiedName ST_duration; // 0x68
	internal static XmlQualifiedName ST_dateTime; // 0x70
	internal static XmlQualifiedName ST_time; // 0x78
	internal static XmlQualifiedName ST_date; // 0x80
	internal static XmlQualifiedName ST_gYearMonth; // 0x88
	internal static XmlQualifiedName ST_string; // 0x90
	internal static XmlQualifiedName ST_anySimpleType; // 0x98
	internal static XmlQualifiedName[] SimpleTypes; // 0xA0
	private XmlSchema rootSchema; // 0x10
	private XmlSchemaSet schemaSet; // 0x18
	private XmlReader xtr; // 0x20
	private NameTable nametable; // 0x28
	private string TargetNamespace; // 0x30
	private XmlNamespaceManager NamespaceManager; // 0x38
	private ArrayList schemaList; // 0x40
	private XmlSchemaInference.InferenceOption occurrence; // 0x48
	private XmlSchemaInference.InferenceOption typeInference; // 0x4C

	// Properties
	public XmlSchemaInference.InferenceOption Occurrence { get; set; }
	public XmlSchemaInference.InferenceOption TypeInference { set; }

	// Methods

	// RVA: 0x5983C0 Offset: 0x5969C0 VA: 0x1805983C0
	public void set_Occurrence(XmlSchemaInference.InferenceOption value) { }

	// RVA: 0x5983B0 Offset: 0x5969B0 VA: 0x1805983B0
	public XmlSchemaInference.InferenceOption get_Occurrence() { }

	// RVA: 0x59A080 Offset: 0x598680 VA: 0x18059A080
	public void set_TypeInference(XmlSchemaInference.InferenceOption value) { }

	// RVA: 0x105CF30 Offset: 0x105B530 VA: 0x18105CF30
	public void .ctor() { }

	// RVA: 0x1059150 Offset: 0x1057750 VA: 0x181059150
	public XmlSchemaSet InferSchema(XmlReader instanceDocument) { }

	// RVA: 0x10589D0 Offset: 0x1056FD0 VA: 0x1810589D0
	internal XmlSchemaSet InferSchema1(XmlReader instanceDocument, XmlSchemaSet schemas) { }

	// RVA: 0x1052C10 Offset: 0x1051210 VA: 0x181052C10
	private XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, XmlSchemaObjectTable compiledAttributes) { }

	// RVA: 0x10541B0 Offset: 0x10527B0 VA: 0x1810541B0
	private XmlSchema CreateXmlSchema(string targetNS) { }

	// RVA: 0x1053530 Offset: 0x1051B30 VA: 0x181053530
	private XmlSchemaElement AddElement(string localName, string prefix, string childURI, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, int positionWithinCollection) { }

	// RVA: 0x1056E80 Offset: 0x1055480 VA: 0x181056E80
	internal void InferElement(XmlSchemaElement xse, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x1053CE0 Offset: 0x10522E0 VA: 0x181053CE0
	private XmlSchemaSimpleContentExtension CheckSimpleContentExtension(XmlSchemaComplexType ct) { }

	// RVA: 0x1056030 Offset: 0x1054630 VA: 0x181056030
	private XmlSchemaType GetEffectiveSchemaType(XmlSchemaElement elem, bool bCreatingNewType) { }

	// RVA: 0x1054C80 Offset: 0x1053280 VA: 0x181054C80
	internal XmlSchemaElement FindMatchingElement(bool bCreatingNewType, XmlReader xtr, XmlSchemaComplexType ct, ref int lastUsedSeqItem, ref bool bParticleChanged, XmlSchema parentSchema, bool setMaxoccurs) { }

	// RVA: 0x105A7A0 Offset: 0x1058DA0 VA: 0x18105A7A0
	internal void ProcessAttributes(ref XmlSchemaElement xse, XmlSchemaType effectiveSchemaType, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x105A690 Offset: 0x1058C90 VA: 0x18105A690
	private void MoveAttributes(XmlSchemaSimpleContentExtension scExtension, XmlSchemaComplexType ct) { }

	// RVA: 0x105A360 Offset: 0x1058960 VA: 0x18105A360
	private void MoveAttributes(XmlSchemaComplexType ct, XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType) { }

	// RVA: 0x10545A0 Offset: 0x1052BA0 VA: 0x1810545A0
	internal XmlSchemaAttribute FindAttribute(ICollection attributes, string attrName) { }

	// RVA: 0x1054A50 Offset: 0x1053050 VA: 0x181054A50
	internal XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, out XmlSchema parentSchema) { }

	// RVA: 0x1054910 Offset: 0x1052F10 VA: 0x181054910
	internal XmlSchemaElement FindElement(XmlSchemaObjectCollection elements, string elementName) { }

	// RVA: 0x1054340 Offset: 0x1052940 VA: 0x181054340
	internal XmlSchemaAttribute FindAttributeRef(ICollection attributes, string attributeName, string nsURI) { }

	// RVA: 0x10547B0 Offset: 0x1052DB0 VA: 0x1810547B0
	internal XmlSchemaElement FindElementRef(XmlSchemaObjectCollection elements, string elementName, string nsURI) { }

	// RVA: 0x105A290 Offset: 0x1058890 VA: 0x18105A290
	internal void MakeExistingAttributesOptional(XmlSchemaComplexType ct, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x105C040 Offset: 0x105A640 VA: 0x18105C040
	private void SwitchUseToOptional(XmlSchemaObjectCollection attributes, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x105AF30 Offset: 0x1059530 VA: 0x18105AF30
	internal XmlQualifiedName RefineSimpleType(string s, ref int iTypeFlags) { }

	// RVA: 0x10591D0 Offset: 0x10577D0 VA: 0x1810591D0
	internal static int InferSimpleType(string s, ref bool bNeedsRangeCheck) { }

	// RVA: 0x1054250 Offset: 0x1052850 VA: 0x181054250
	internal static int DateTime(string s, bool bDate, bool bTime) { }

	// RVA: 0x1053E40 Offset: 0x1052440 VA: 0x181053E40
	private XmlSchemaElement CreateNewElementforChoice(XmlSchemaElement copyElement) { }

	// RVA: 0x10561B0 Offset: 0x10547B0 VA: 0x1810561B0
	private static int GetSchemaType(XmlQualifiedName qname) { }

	// RVA: 0x105BE30 Offset: 0x105A430 VA: 0x18105BE30
	internal void SetMinMaxOccurs(XmlSchemaElement el, bool setMaxOccurs) { }

	// RVA: 0x105C180 Offset: 0x105A780 VA: 0x18105C180
	private static void .cctor() { }

}

public enum XmlSchemaInference.InferenceOption // TypeDefIndex: 2260
{	// Fields
	public int value__; // 0x0
	public const XmlSchemaInference.InferenceOption Restricted = 0;
	public const XmlSchemaInference.InferenceOption Relaxed = 1;

}

public class XmlSchemaInferenceException : XmlSchemaException // TypeDefIndex: 2261
{	// Methods

	// RVA: 0xD28150 Offset: 0xD26750 VA: 0x180D28150
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10515F0 Offset: 0x104FBF0 VA: 0x1810515F0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1052310 Offset: 0x1050910 VA: 0x181052310
	public void .ctor() { }

	// RVA: 0x1052AA0 Offset: 0x10510A0 VA: 0x181052AA0
	internal void .ctor(string res, string arg) { }

	// RVA: 0x1052BE0 Offset: 0x10511E0 VA: 0x181052BE0
	internal void .ctor(string res, int lineNumber, int linePosition) { }

}

public sealed class XmlAtomicValue : XPathItem, ICloneable // TypeDefIndex: 2303
{	// Fields
	private XmlSchemaType xmlType; // 0x10
	private object objVal; // 0x18
	private TypeCode clrType; // 0x20
	private XmlAtomicValue.Union unionVal; // 0x28
	private XmlAtomicValue.NamespacePrefixForQName nsPrefix; // 0x30

	// Properties
	public override XmlSchemaType XmlType { get; }
	public override Type ValueType { get; }
	public override object TypedValue { get; }
	public override bool ValueAsBoolean { get; }
	public override DateTime ValueAsDateTime { get; }
	public override double ValueAsDouble { get; }
	public override int ValueAsInt { get; }
	public override long ValueAsLong { get; }
	public override string Value { get; }

	// Methods

	// RVA: 0x1431AE0 Offset: 0x14300E0 VA: 0x181431AE0
	internal void .ctor(XmlSchemaType xmlType, bool value) { }

	// RVA: 0x14318C0 Offset: 0x142FEC0 VA: 0x1814318C0
	internal void .ctor(XmlSchemaType xmlType, DateTime value) { }

	// RVA: 0x1431E20 Offset: 0x1430420 VA: 0x181431E20
	internal void .ctor(XmlSchemaType xmlType, double value) { }

	// RVA: 0x1431B80 Offset: 0x1430180 VA: 0x181431B80
	internal void .ctor(XmlSchemaType xmlType, int value) { }

	// RVA: 0x1431A40 Offset: 0x1430040 VA: 0x181431A40
	internal void .ctor(XmlSchemaType xmlType, long value) { }

	// RVA: 0x1431EC0 Offset: 0x14304C0 VA: 0x181431EC0
	internal void .ctor(XmlSchemaType xmlType, string value) { }

	// RVA: 0x1431C20 Offset: 0x1430220 VA: 0x181431C20
	internal void .ctor(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1431960 Offset: 0x142FF60 VA: 0x181431960
	internal void .ctor(XmlSchemaType xmlType, object value) { }

	// RVA: 0x1431FA0 Offset: 0x14305A0 VA: 0x181431FA0
	internal void .ctor(XmlSchemaType xmlType, object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 15
	private object System.ICloneable.Clone() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 4
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0x14328A0 Offset: 0x1430EA0 VA: 0x1814328A0 Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0x14321B0 Offset: 0x14307B0 VA: 0x1814321B0 Slot: 6
	public override object get_TypedValue() { }

	// RVA: 0x14323A0 Offset: 0x14309A0 VA: 0x1814323A0 Slot: 8
	public override bool get_ValueAsBoolean() { }

	// RVA: 0x14324A0 Offset: 0x1430AA0 VA: 0x1814324A0 Slot: 9
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0x14325A0 Offset: 0x1430BA0 VA: 0x1814325A0 Slot: 10
	public override double get_ValueAsDouble() { }

	// RVA: 0x14326A0 Offset: 0x1430CA0 VA: 0x1814326A0 Slot: 11
	public override int get_ValueAsInt() { }

	// RVA: 0x14327A0 Offset: 0x1430DA0 VA: 0x1814327A0 Slot: 12
	public override long get_ValueAsLong() { }

	// RVA: 0x14316A0 Offset: 0x142FCA0 VA: 0x1814316A0 Slot: 14
	public override object ValueAs(Type type, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x14328E0 Offset: 0x1430EE0 VA: 0x1814328E0 Slot: 5
	public override string get_Value() { }

	// RVA: 0x95FE40 Offset: 0x95E440 VA: 0x18095FE40 Slot: 3
	public override string ToString() { }

	// RVA: 0x14315F0 Offset: 0x142FBF0 VA: 0x1814315F0
	private string GetPrefixFromQName(string value) { }

}

private struct XmlAtomicValue.Union // TypeDefIndex: 2304
{	// Fields
	public bool boolVal; // 0x0
	public double dblVal; // 0x0
	public long i64Val; // 0x0
	public int i32Val; // 0x0
	public DateTime dtVal; // 0x0

}

private class XmlAtomicValue.NamespacePrefixForQName : IXmlNamespaceResolver // TypeDefIndex: 2305
{	// Fields
	public string prefix; // 0x10
	public string ns; // 0x18

	// Methods

	// RVA: 0x1428960 Offset: 0x1426F60 VA: 0x181428960
	public void .ctor(string prefix, string ns) { }

	// RVA: 0x14288F0 Offset: 0x1426EF0 VA: 0x1814288F0 Slot: 5
	public string LookupNamespace(string prefix) { }

	// RVA: 0x1428930 Offset: 0x1426F30 VA: 0x181428930 Slot: 6
	public string LookupPrefix(string namespaceName) { }

	// RVA: 0x1428870 Offset: 0x1426E70 VA: 0x181428870 Slot: 4
	public IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

}

public class XmlSchema : XmlSchemaObject // TypeDefIndex: 2306
{	// Fields
	private XmlSchemaForm attributeFormDefault; // 0x38
	private XmlSchemaForm elementFormDefault; // 0x3C
	private XmlSchemaDerivationMethod blockDefault; // 0x40
	private XmlSchemaDerivationMethod finalDefault; // 0x44
	private string targetNs; // 0x48
	private string version; // 0x50
	private XmlSchemaObjectCollection includes; // 0x58
	private XmlSchemaObjectCollection items; // 0x60
	private string id; // 0x68
	private XmlAttribute[] moreAttributes; // 0x70
	private bool isCompiled; // 0x78
	private bool isCompiledBySet; // 0x79
	private bool isPreprocessed; // 0x7A
	private bool isRedefined; // 0x7B
	private int errorCount; // 0x7C
	private XmlSchemaObjectTable attributes; // 0x80
	private XmlSchemaObjectTable attributeGroups; // 0x88
	private XmlSchemaObjectTable elements; // 0x90
	private XmlSchemaObjectTable types; // 0x98
	private XmlSchemaObjectTable groups; // 0xA0
	private XmlSchemaObjectTable notations; // 0xA8
	private XmlSchemaObjectTable identityConstraints; // 0xB0
	private static int globalIdCounter; // 0x0
	private ArrayList importedSchemas; // 0xB8
	private ArrayList importedNamespaces; // 0xC0
	private int schemaId; // 0xC8
	private Uri baseUri; // 0xD0
	private bool isChameleon; // 0xD8
	private Hashtable ids; // 0xE0
	private XmlDocument document; // 0xE8

	// Properties
	[XmlAttributeAttribute] // RVA: 0x86670 Offset: 0x85A70 VA: 0x180086670
	[DefaultValueAttribute] // RVA: 0x86670 Offset: 0x85A70 VA: 0x180086670
	public XmlSchemaForm AttributeFormDefault { get; set; }
	[XmlAttributeAttribute] // RVA: 0x87BF0 Offset: 0x86FF0 VA: 0x180087BF0
	[DefaultValueAttribute] // RVA: 0x87BF0 Offset: 0x86FF0 VA: 0x180087BF0
	public XmlSchemaDerivationMethod BlockDefault { get; set; }
	[DefaultValueAttribute] // RVA: 0x88090 Offset: 0x87490 VA: 0x180088090
	[XmlAttributeAttribute] // RVA: 0x88090 Offset: 0x87490 VA: 0x180088090
	public XmlSchemaDerivationMethod FinalDefault { get; set; }
	[DefaultValueAttribute] // RVA: 0x88280 Offset: 0x87680 VA: 0x180088280
	[XmlAttributeAttribute] // RVA: 0x88280 Offset: 0x87680 VA: 0x180088280
	public XmlSchemaForm ElementFormDefault { get; set; }
	[XmlAttributeAttribute] // RVA: 0x88710 Offset: 0x87B10 VA: 0x180088710
	public string TargetNamespace { get; set; }
	[XmlAttributeAttribute] // RVA: 0x888B0 Offset: 0x87CB0 VA: 0x1800888B0
	public string Version { get; set; }
	[XmlElementAttribute] // RVA: 0x889B0 Offset: 0x87DB0 VA: 0x1800889B0
	[XmlElementAttribute] // RVA: 0x889B0 Offset: 0x87DB0 VA: 0x1800889B0
	[XmlElementAttribute] // RVA: 0x889B0 Offset: 0x87DB0 VA: 0x1800889B0
	public XmlSchemaObjectCollection Includes { get; }
	[XmlElementAttribute] // RVA: 0x88C80 Offset: 0x88080 VA: 0x180088C80
	[XmlElementAttribute] // RVA: 0x88C80 Offset: 0x88080 VA: 0x180088C80
	[XmlElementAttribute] // RVA: 0x88C80 Offset: 0x88080 VA: 0x180088C80
	[XmlElementAttribute] // RVA: 0x88C80 Offset: 0x88080 VA: 0x180088C80
	[XmlElementAttribute] // RVA: 0x88C80 Offset: 0x88080 VA: 0x180088C80
	[XmlElementAttribute] // RVA: 0x88C80 Offset: 0x88080 VA: 0x180088C80
	[XmlElementAttribute] // RVA: 0x88C80 Offset: 0x88080 VA: 0x180088C80
	[XmlElementAttribute] // RVA: 0x88C80 Offset: 0x88080 VA: 0x180088C80
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal bool IsCompiledBySet { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal bool IsPreprocessed { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal bool IsRedefined { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaObjectTable Attributes { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaObjectTable AttributeGroups { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaObjectTable SchemaTypes { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaObjectTable Elements { get; }
	[XmlAttributeAttribute] // RVA: 0x8A950 Offset: 0x89D50 VA: 0x18008A950
	public string Id { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaObjectTable Groups { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaObjectTable Notations { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal XmlSchemaObjectTable IdentityConstraints { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal Uri BaseUri { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal int SchemaId { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal bool IsChameleon { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal Hashtable Ids { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal XmlDocument Document { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal int ErrorCount { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal override string IdAttribute { get; set; }
	internal ArrayList ImportedSchemas { get; }
	internal ArrayList ImportedNamespaces { get; }

	// Methods

	// RVA: 0x1449280 Offset: 0x1447880 VA: 0x181449280
	public void .ctor() { }

	// RVA: 0x14490E0 Offset: 0x14476E0 VA: 0x1814490E0
	public static XmlSchema Read(XmlReader reader, ValidationEventHandler validationEventHandler) { }

	// RVA: 0x1448950 Offset: 0x1446F50 VA: 0x181448950
	internal bool CompileSchema(XmlSchemaCollection xsc, XmlResolver resolver, SchemaInfo schemaInfo, string ns, ValidationEventHandler validationEventHandler, XmlNameTable nameTable, bool CompileContentModel) { }

	// RVA: 0x1448890 Offset: 0x1446E90 VA: 0x181448890
	internal void CompileSchemaInSet(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x6BB9E0 Offset: 0x6B9FE0 VA: 0x1806BB9E0
	public XmlSchemaForm get_AttributeFormDefault() { }

	// RVA: 0xC75070 Offset: 0xC73670 VA: 0x180C75070
	public void set_AttributeFormDefault(XmlSchemaForm value) { }

	// RVA: 0x5DE3D0 Offset: 0x5DC9D0 VA: 0x1805DE3D0
	public XmlSchemaDerivationMethod get_BlockDefault() { }

	// RVA: 0x6840F0 Offset: 0x6826F0 VA: 0x1806840F0
	public void set_BlockDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x5DE3E0 Offset: 0x5DC9E0 VA: 0x1805DE3E0
	public XmlSchemaDerivationMethod get_FinalDefault() { }

	// RVA: 0x8C1320 Offset: 0x8BF920 VA: 0x1808C1320
	public void set_FinalDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x5E2EE0 Offset: 0x5E14E0 VA: 0x1805E2EE0
	public XmlSchemaForm get_ElementFormDefault() { }

	// RVA: 0x8C1690 Offset: 0x8BFC90 VA: 0x1808C1690
	public void set_ElementFormDefault(XmlSchemaForm value) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public string get_TargetNamespace() { }

	// RVA: 0x5DD7A0 Offset: 0x5DBDA0 VA: 0x1805DD7A0
	public void set_TargetNamespace(string value) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public string get_Version() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	public void set_Version(string value) { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public XmlSchemaObjectCollection get_Includes() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x1051260 Offset: 0x104F860 VA: 0x181051260
	internal bool get_IsCompiledBySet() { }

	// RVA: 0x10FFE80 Offset: 0x10FE480 VA: 0x1810FFE80
	internal void set_IsCompiledBySet(bool value) { }

	// RVA: 0x10512B0 Offset: 0x104F8B0 VA: 0x1810512B0
	internal bool get_IsPreprocessed() { }

	// RVA: 0x1449880 Offset: 0x1447E80 VA: 0x181449880
	internal void set_IsPreprocessed(bool value) { }

	// RVA: 0x10512A0 Offset: 0x104F8A0 VA: 0x1810512A0
	internal bool get_IsRedefined() { }

	// RVA: 0x1449890 Offset: 0x1447E90 VA: 0x181449890
	internal void set_IsRedefined(bool value) { }

	// RVA: 0x14494E0 Offset: 0x1447AE0 VA: 0x1814494E0
	public XmlSchemaObjectTable get_Attributes() { }

	// RVA: 0x1449460 Offset: 0x1447A60 VA: 0x181449460
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x14497E0 Offset: 0x1447DE0 VA: 0x1814497E0
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x14495E0 Offset: 0x1447BE0 VA: 0x1814495E0
	public XmlSchemaObjectTable get_Elements() { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public string get_Id() { }

	// RVA: 0x519DE0 Offset: 0x5183E0 VA: 0x180519DE0
	public void set_Id(string value) { }

	// RVA: 0x5742F0 Offset: 0x5728F0 VA: 0x1805742F0
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x79BDE0 Offset: 0x79A3E0 VA: 0x18079BDE0
	public XmlSchemaObjectTable get_Notations() { }

	// RVA: 0x79BDB0 Offset: 0x79A3B0 VA: 0x18079BDB0
	internal XmlSchemaObjectTable get_IdentityConstraints() { }

	// RVA: 0x79BDF0 Offset: 0x79A3F0 VA: 0x18079BDF0
	internal Uri get_BaseUri() { }

	// RVA: 0x79BE70 Offset: 0x79A470 VA: 0x18079BE70
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x1449760 Offset: 0x1447D60 VA: 0x181449760
	internal int get_SchemaId() { }

	// RVA: 0x79BA60 Offset: 0x79A060 VA: 0x18079BA60
	internal bool get_IsChameleon() { }

	// RVA: 0x1449870 Offset: 0x1447E70 VA: 0x181449870
	internal void set_IsChameleon(bool value) { }

	// RVA: 0x4EF330 Offset: 0x4ED930 VA: 0x1804EF330
	internal Hashtable get_Ids() { }

	// RVA: 0x1449560 Offset: 0x1447B60 VA: 0x181449560
	internal XmlDocument get_Document() { }

	// RVA: 0x1010C90 Offset: 0x100F290 VA: 0x181010C90
	internal int get_ErrorCount() { }

	// RVA: 0x1449860 Offset: 0x1447E60 VA: 0x181449860
	internal void set_ErrorCount(int value) { }

	// RVA: 0x14487A0 Offset: 0x1446DA0 VA: 0x1814487A0
	internal XmlSchema Clone() { }

	// RVA: 0x1448B10 Offset: 0x1447110 VA: 0x181448B10
	internal XmlSchema DeepClone() { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x519DE0 Offset: 0x5183E0 VA: 0x180519DE0 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x1449230 Offset: 0x1447830 VA: 0x181449230
	internal void SetIsCompiled(bool isCompiled) { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x1448780 Offset: 0x1446D80 VA: 0x181448780 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x14496E0 Offset: 0x1447CE0 VA: 0x1814496E0
	internal ArrayList get_ImportedSchemas() { }

	// RVA: 0x1449660 Offset: 0x1447C60 VA: 0x181449660
	internal ArrayList get_ImportedNamespaces() { }

	// RVA: 0x1448EB0 Offset: 0x14474B0 VA: 0x181448EB0
	internal void GetExternalSchemasList(IList extList, XmlSchema schema) { }

	// RVA: 0x1449240 Offset: 0x1447840 VA: 0x181449240
	private static void .cctor() { }

}

public class XmlSchemaAll : XmlSchemaGroupBase // TypeDefIndex: 2307
{	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Properties
	[XmlElementAttribute] // RVA: 0x8B0C0 Offset: 0x8A4C0 VA: 0x18008B0C0
	public override XmlSchemaObjectCollection Items { get; }
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x4E84B0 Offset: 0x4E6AB0 VA: 0x1804E84B0 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x104BA10 Offset: 0x104A010 VA: 0x18104BA10 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x4E87D0 Offset: 0x4E6DD0 VA: 0x1804E87D0 Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x104B970 Offset: 0x1049F70 VA: 0x18104B970
	public void .ctor() { }

}

public class XmlSchemaAnnotated : XmlSchemaObject // TypeDefIndex: 2308
{	// Fields
	private string id; // 0x38
	private XmlSchemaAnnotation annotation; // 0x40
	private XmlAttribute[] moreAttributes; // 0x48

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8A950 Offset: 0x89D50 VA: 0x18008A950
	public string Id { get; set; }
	[XmlElementAttribute] // RVA: 0x8B290 Offset: 0x8A690 VA: 0x18008B290
	public XmlSchemaAnnotation Annotation { get; set; }
	[XmlAnyAttributeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlAttribute[] UnhandledAttributes { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal override string IdAttribute { get; set; }

	// Methods

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public string get_Id() { }

	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	public void set_Id(string value) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public XmlSchemaAnnotation get_Annotation() { }

	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	public void set_Annotation(XmlSchemaAnnotation value) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public XmlAttribute[] get_UnhandledAttributes() { }

	// RVA: 0x5DD7A0 Offset: 0x5DBDA0 VA: 0x1805DD7A0
	public void set_UnhandledAttributes(XmlAttribute[] value) { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x5DD7A0 Offset: 0x5DBDA0 VA: 0x1805DD7A0 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class XmlSchemaAnnotation : XmlSchemaObject // TypeDefIndex: 2309
{	// Fields
	private string id; // 0x38
	private XmlSchemaObjectCollection items; // 0x40
	private XmlAttribute[] moreAttributes; // 0x48

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8A950 Offset: 0x89D50 VA: 0x18008A950
	public string Id { get; set; }
	[XmlElementAttribute] // RVA: 0x8C820 Offset: 0x8BC20 VA: 0x18008C820
	[XmlElementAttribute] // RVA: 0x8C820 Offset: 0x8BC20 VA: 0x18008C820
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal override string IdAttribute { get; set; }

	// Methods

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public string get_Id() { }

	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	public void set_Id(string value) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x5DD7A0 Offset: 0x5DBDA0 VA: 0x1805DD7A0 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x104BA50 Offset: 0x104A050 VA: 0x18104BA50
	public void .ctor() { }

}

public class XmlSchemaAny : XmlSchemaParticle // TypeDefIndex: 2310
{	// Fields
	private string ns; // 0x78
	private XmlSchemaContentProcessing processContents; // 0x80
	private NamespaceList namespaceList; // 0x88

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8CB20 Offset: 0x8BF20 VA: 0x18008CB20
	public string Namespace { get; set; }
	[DefaultValueAttribute] // RVA: 0x8CBB0 Offset: 0x8BFB0 VA: 0x18008CBB0
	[XmlAttributeAttribute] // RVA: 0x8CBB0 Offset: 0x8BFB0 VA: 0x18008CBB0
	public XmlSchemaContentProcessing ProcessContents { set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal NamespaceList NamespaceList { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal string ResolvedNamespace { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal XmlSchemaContentProcessing ProcessContentsCorrect { get; }
	internal override string NameString { get; }

	// Methods

	// RVA: 0x4E84B0 Offset: 0x4E6AB0 VA: 0x1804E84B0
	public string get_Namespace() { }

	// RVA: 0x4E87D0 Offset: 0x4E6DD0 VA: 0x1804E87D0
	public void set_Namespace(string value) { }

	// RVA: 0x5828E0 Offset: 0x580EE0 VA: 0x1805828E0
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x574300 Offset: 0x572900 VA: 0x180574300
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x104C380 Offset: 0x104A980 VA: 0x18104C380
	internal string get_ResolvedNamespace() { }

	// RVA: 0x104C360 Offset: 0x104A960 VA: 0x18104C360
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x104C000 Offset: 0x104A600 VA: 0x18104C000 Slot: 15
	internal override string get_NameString() { }

	// RVA: 0x104BF00 Offset: 0x104A500 VA: 0x18104BF00
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x104BE50 Offset: 0x104A450 VA: 0x18104BE50
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x104BE10 Offset: 0x104A410 VA: 0x18104BE10
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x104BFA0 Offset: 0x104A5A0 VA: 0x18104BFA0
	public void .ctor() { }

}

public class XmlSchemaAnyAttribute : XmlSchemaAnnotated // TypeDefIndex: 2311
{	// Fields
	private string ns; // 0x50
	private XmlSchemaContentProcessing processContents; // 0x58
	private NamespaceList namespaceList; // 0x60

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8CB20 Offset: 0x8BF20 VA: 0x18008CB20
	public string Namespace { set; }
	[XmlAttributeAttribute] // RVA: 0x8CEC0 Offset: 0x8C2C0 VA: 0x18008CEC0
	[DefaultValueAttribute] // RVA: 0x8CEC0 Offset: 0x8C2C0 VA: 0x18008CEC0
	public XmlSchemaContentProcessing ProcessContents { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal NamespaceList NamespaceList { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal XmlSchemaContentProcessing ProcessContentsCorrect { get; }

	// Methods

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	public void set_Namespace(string value) { }

	// RVA: 0xAE9F70 Offset: 0xAE8570 VA: 0x180AE9F70
	public XmlSchemaContentProcessing get_ProcessContents() { }

	// RVA: 0xD280D0 Offset: 0xD266D0 VA: 0x180D280D0
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x104BE00 Offset: 0x104A400 VA: 0x18104BE00
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x104BBA0 Offset: 0x104A1A0 VA: 0x18104BBA0
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x104BB00 Offset: 0x104A100 VA: 0x18104BB00
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x104BAC0 Offset: 0x104A0C0 VA: 0x18104BAC0
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x104BD00 Offset: 0x104A300 VA: 0x18104BD00
	internal static bool IsSubset(XmlSchemaAnyAttribute sub, XmlSchemaAnyAttribute super) { }

	// RVA: 0x104BC30 Offset: 0x104A230 VA: 0x18104BC30
	internal static XmlSchemaAnyAttribute Intersection(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x104BD30 Offset: 0x104A330 VA: 0x18104BD30
	internal static XmlSchemaAnyAttribute Union(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class XmlSchemaAppInfo : XmlSchemaObject // TypeDefIndex: 2312
{	// Fields
	private string source; // 0x38
	private XmlNode[] markup; // 0x40

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8D290 Offset: 0x8C690 VA: 0x18008D290
	public string Source { set; }
	[XmlTextAttribute] // RVA: 0x8D410 Offset: 0x8C810 VA: 0x18008D410
	[XmlAnyElementAttribute] // RVA: 0x8D410 Offset: 0x8C810 VA: 0x18008D410
	public XmlNode[] Markup { get; set; }

	// Methods

	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	public void set_Source(string value) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public XmlNode[] get_Markup() { }

	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class XmlSchemaAttribute : XmlSchemaAnnotated // TypeDefIndex: 2313
{	// Fields
	private string defaultValue; // 0x50
	private string fixedValue; // 0x58
	private string name; // 0x60
	private XmlSchemaForm form; // 0x68
	private XmlSchemaUse use; // 0x6C
	private XmlQualifiedName refName; // 0x70
	private XmlQualifiedName typeName; // 0x78
	private XmlQualifiedName qualifiedName; // 0x80
	private XmlSchemaSimpleType type; // 0x88
	private XmlSchemaSimpleType attributeType; // 0x90
	private SchemaAttDef attDef; // 0x98

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8D4A0 Offset: 0x8C8A0 VA: 0x18008D4A0
	[DefaultValueAttribute] // RVA: 0x8D4A0 Offset: 0x8C8A0 VA: 0x18008D4A0
	public string DefaultValue { get; set; }
	[DefaultValueAttribute] // RVA: 0x8D600 Offset: 0x8CA00 VA: 0x18008D600
	[XmlAttributeAttribute] // RVA: 0x8D600 Offset: 0x8CA00 VA: 0x18008D600
	public string FixedValue { get; set; }
	[DefaultValueAttribute] // RVA: 0x8D6D0 Offset: 0x8CAD0 VA: 0x18008D6D0
	[XmlAttributeAttribute] // RVA: 0x8D6D0 Offset: 0x8CAD0 VA: 0x18008D6D0
	public XmlSchemaForm Form { get; set; }
	[XmlAttributeAttribute] // RVA: 0x8D970 Offset: 0x8CD70 VA: 0x18008D970
	public string Name { get; set; }
	[XmlAttributeAttribute] // RVA: 0x8DAE0 Offset: 0x8CEE0 VA: 0x18008DAE0
	public XmlQualifiedName RefName { get; set; }
	[XmlAttributeAttribute] // RVA: 0x8DB80 Offset: 0x8CF80 VA: 0x18008DB80
	public XmlQualifiedName SchemaTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x8DC90 Offset: 0x8D090 VA: 0x18008DC90
	public XmlSchemaSimpleType SchemaType { get; set; }
	[XmlAttributeAttribute] // RVA: 0x8DDA0 Offset: 0x8D1A0 VA: 0x18008DDA0
	[DefaultValueAttribute] // RVA: 0x8DDA0 Offset: 0x8D1A0 VA: 0x18008DDA0
	public XmlSchemaUse Use { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaSimpleType AttributeSchemaType { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal XmlSchemaDatatype Datatype { get; }
	internal SchemaAttDef AttDef { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public string get_DefaultValue() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	public void set_DefaultValue(string value) { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public string get_FixedValue() { }

	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810
	public void set_FixedValue(string value) { }

	// RVA: 0x804120 Offset: 0x802720 VA: 0x180804120
	public XmlSchemaForm get_Form() { }

	// RVA: 0x804150 Offset: 0x802750 VA: 0x180804150
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public string get_Name() { }

	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0
	public void set_Name(string value) { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x104C930 Offset: 0x104AF30 VA: 0x18104C930
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x4E84B0 Offset: 0x4E6AB0 VA: 0x1804E84B0
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x104C9F0 Offset: 0x104AFF0 VA: 0x18104C9F0
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x574300 Offset: 0x572900 VA: 0x180574300
	public XmlSchemaSimpleType get_SchemaType() { }

	// RVA: 0x574390 Offset: 0x572990 VA: 0x180574390
	public void set_SchemaType(XmlSchemaSimpleType value) { }

	// RVA: 0x804100 Offset: 0x802700 VA: 0x180804100
	public XmlSchemaUse get_Use() { }

	// RVA: 0x804130 Offset: 0x802730 VA: 0x180804130
	public void set_Use(XmlSchemaUse value) { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x4E3FE0 Offset: 0x4E25E0 VA: 0x1804E3FE0
	public XmlSchemaSimpleType get_AttributeSchemaType() { }

	// RVA: 0x104C910 Offset: 0x104AF10 VA: 0x18104C910
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x4E3FF0 Offset: 0x4E25F0 VA: 0x1804E3FF0
	internal void SetAttributeType(XmlSchemaSimpleType value) { }

	// RVA: 0x574310 Offset: 0x572910 VA: 0x180574310
	internal SchemaAttDef get_AttDef() { }

	// RVA: 0x5743A0 Offset: 0x5729A0 VA: 0x1805743A0
	internal void set_AttDef(SchemaAttDef value) { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x104C750 Offset: 0x104AD50 VA: 0x18104C750 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x104C850 Offset: 0x104AE50 VA: 0x18104C850
	public void .ctor() { }

}

public class XmlSchemaAttributeGroup : XmlSchemaAnnotated // TypeDefIndex: 2314
{	// Fields
	private string name; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName qname; // 0x68
	private XmlSchemaAttributeGroup redefined; // 0x70
	private XmlSchemaObjectTable attributeUses; // 0x78
	private XmlSchemaAnyAttribute attributeWildcard; // 0x80
	private int selfReferenceCount; // 0x88

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8D970 Offset: 0x8CD70 VA: 0x18008D970
	public string Name { get; set; }
	[XmlElementAttribute] // RVA: 0x8E2B0 Offset: 0x8D6B0 VA: 0x18008E2B0
	[XmlElementAttribute] // RVA: 0x8E2B0 Offset: 0x8D6B0 VA: 0x18008E2B0
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] // RVA: 0x8E5E0 Offset: 0x8D9E0 VA: 0x18008E5E0
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal XmlSchemaObjectTable AttributeUses { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal XmlSchemaAnyAttribute AttributeWildcard { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaAttributeGroup RedefinedAttributeGroup { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal XmlSchemaAttributeGroup Redefined { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal int SelfReferenceCount { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public string get_Name() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	public void set_Name(string value) { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x104C6E0 Offset: 0x104ACE0 VA: 0x18104C6E0
	internal XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	internal XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	internal void set_AttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public XmlSchemaAttributeGroup get_RedefinedAttributeGroup() { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	internal XmlSchemaAttributeGroup get_Redefined() { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	internal void set_Redefined(XmlSchemaAttributeGroup value) { }

	// RVA: 0x58AC00 Offset: 0x589200 VA: 0x18058AC00
	internal int get_SelfReferenceCount() { }

	// RVA: 0xF8CD60 Offset: 0xF8B360 VA: 0x180F8CD60
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x519DE0 Offset: 0x5183E0 VA: 0x180519DE0
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x104C500 Offset: 0x104AB00 VA: 0x18104C500 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x104C630 Offset: 0x104AC30 VA: 0x18104C630
	public void .ctor() { }

}

public class XmlSchemaAttributeGroupRef : XmlSchemaAnnotated // TypeDefIndex: 2315
{	// Fields
	private XmlQualifiedName refName; // 0x50

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8DAE0 Offset: 0x8CEE0 VA: 0x18008DAE0
	public XmlQualifiedName RefName { get; set; }

	// Methods

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x104C440 Offset: 0x104AA40 VA: 0x18104C440
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x104C3C0 Offset: 0x104A9C0 VA: 0x18104C3C0
	public void .ctor() { }

}

public class XmlSchemaChoice : XmlSchemaGroupBase // TypeDefIndex: 2316
{	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Properties
	[XmlElementAttribute] // RVA: 0x8E9A0 Offset: 0x8DDA0 VA: 0x18008E9A0
	[XmlElementAttribute] // RVA: 0x8E9A0 Offset: 0x8DDA0 VA: 0x18008E9A0
	[XmlElementAttribute] // RVA: 0x8E9A0 Offset: 0x8DDA0 VA: 0x18008E9A0
	[XmlElementAttribute] // RVA: 0x8E9A0 Offset: 0x8DDA0 VA: 0x18008E9A0
	[XmlElementAttribute] // RVA: 0x8E9A0 Offset: 0x8DDA0 VA: 0x18008E9A0
	public override XmlSchemaObjectCollection Items { get; }
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x4E84B0 Offset: 0x4E6AB0 VA: 0x1804E84B0 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x104CB50 Offset: 0x104B150 VA: 0x18104CB50 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x4E87D0 Offset: 0x4E6DD0 VA: 0x1804E87D0 Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x104CAB0 Offset: 0x104B0B0 VA: 0x18104CAB0
	public void .ctor() { }

}

public sealed class XmlSchemaCollection : ICollection, IEnumerable // TypeDefIndex: 2317
{	// Fields
	private Hashtable collection; // 0x10
	private XmlNameTable nameTable; // 0x18
	private SchemaNames schemaNames; // 0x20
	private ReaderWriterLock wLock; // 0x28
	private int timeout; // 0x30
	private bool isThreadSafe; // 0x34
	private ValidationEventHandler validationEventHandler; // 0x38
	private XmlResolver xmlResolver; // 0x40

	// Properties
	public int Count { get; }
	public XmlNameTable NameTable { get; }
	internal XmlResolver XmlResolver { set; }
	public XmlSchema Item { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }
	internal ValidationEventHandler EventHandler { get; set; }

	// Methods

	// RVA: 0x104D670 Offset: 0x104BC70 VA: 0x18104D670
	public void .ctor(XmlNameTable nametable) { }

	// RVA: 0x104D5B0 Offset: 0x104BBB0 VA: 0x18104D5B0
	public int get_Count() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public XmlNameTable get_NameTable() { }

	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x104D780 Offset: 0x104BD80 VA: 0x18104D780
	public XmlSchema get_Item(string ns) { }

	// RVA: 0x104D5E0 Offset: 0x104BBE0 VA: 0x18104D5E0 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x104D1F0 Offset: 0x104B7F0 VA: 0x18104D1F0
	public XmlSchemaCollectionEnumerator GetEnumerator() { }

	// RVA: 0x104D3D0 Offset: 0x104B9D0 VA: 0x18104D3D0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x104D5B0 Offset: 0x104BBB0 VA: 0x18104D5B0 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x104D280 Offset: 0x104B880 VA: 0x18104D280
	internal SchemaInfo GetSchemaInfo(string ns) { }

	// RVA: 0x104D320 Offset: 0x104B920 VA: 0x18104D320
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x104CDA0 Offset: 0x104B3A0 VA: 0x18104CDA0
	internal XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile) { }

	// RVA: 0x104D070 Offset: 0x104B670 VA: 0x18104D070
	private XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile, XmlResolver resolver) { }

	// RVA: 0x104CF20 Offset: 0x104B520 VA: 0x18104CF20
	private void Add(string ns, XmlSchemaCollectionNode node) { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	internal ValidationEventHandler get_EventHandler() { }

	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	internal void set_EventHandler(ValidationEventHandler value) { }

}

internal sealed class XmlSchemaCollectionNode // TypeDefIndex: 2318
{	// Fields
	private string namespaceUri; // 0x10
	private SchemaInfo schemaInfo; // 0x18
	private XmlSchema schema; // 0x20

	// Properties
	internal string NamespaceURI { set; }
	internal SchemaInfo SchemaInfo { get; set; }
	internal XmlSchema Schema { get; set; }

	// Methods

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	internal void set_NamespaceURI(string value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal SchemaInfo get_SchemaInfo() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	internal void set_SchemaInfo(SchemaInfo value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal XmlSchema get_Schema() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	internal void set_Schema(XmlSchema value) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public sealed class XmlSchemaCollectionEnumerator : IEnumerator // TypeDefIndex: 2319
{	// Fields
	private IDictionaryEnumerator enumerator; // 0x10

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public XmlSchema Current { get; }
	internal XmlSchemaCollectionNode CurrentNode { get; }

	// Methods

	// RVA: 0x104CC60 Offset: 0x104B260 VA: 0x18104CC60
	internal void .ctor(Hashtable collection) { }

	// RVA: 0x104CC00 Offset: 0x104B200 VA: 0x18104CC00 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x104CBB0 Offset: 0x104B1B0 VA: 0x18104CBB0 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x104CB60 Offset: 0x104B160 VA: 0x18104CB60
	public bool MoveNext() { }

	// RVA: 0x104CC50 Offset: 0x104B250 VA: 0x18104CC50 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x104CD20 Offset: 0x104B320 VA: 0x18104CD20
	public XmlSchema get_Current() { }

	// RVA: 0x104CCB0 Offset: 0x104B2B0 VA: 0x18104CCB0
	internal XmlSchemaCollectionNode get_CurrentNode() { }

}

public sealed class XmlSchemaCompilationSettings // TypeDefIndex: 2320
{	// Fields
	private bool enableUpaCheck; // 0x10

	// Properties
	public bool EnableUpaCheck { get; }

	// Methods

	// RVA: 0x104D820 Offset: 0x104BE20 VA: 0x18104D820
	public void .ctor() { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_EnableUpaCheck() { }

}

public class XmlSchemaComplexContent : XmlSchemaContentModel // TypeDefIndex: 2321
{	// Fields
	private XmlSchemaContent content; // 0x50
	private bool isMixed; // 0x58
	private bool hasMixedAttribute; // 0x59

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8EF40 Offset: 0x8E340 VA: 0x18008EF40
	public bool IsMixed { get; set; }
	[XmlElementAttribute] // RVA: 0x8EFD0 Offset: 0x8E3D0 VA: 0x18008EFD0
	[XmlElementAttribute] // RVA: 0x8EFD0 Offset: 0x8E3D0 VA: 0x18008EFD0
	public override XmlSchemaContent Content { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal bool HasMixedAttribute { get; }

	// Methods

	// RVA: 0x5925C0 Offset: 0x590BC0 VA: 0x1805925C0
	public bool get_IsMixed() { }

	// RVA: 0x104DB20 Offset: 0x104C120 VA: 0x18104DB20
	public void set_IsMixed(bool value) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800 Slot: 14
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820 Slot: 15
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0xAF6470 Offset: 0xAF4A70 VA: 0x180AF6470
	internal bool get_HasMixedAttribute() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class XmlSchemaComplexContentExtension : XmlSchemaContent // TypeDefIndex: 2322
{	// Fields
	private XmlSchemaParticle particle; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName baseTypeName; // 0x68

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8F490 Offset: 0x8E890 VA: 0x18008F490
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x8F630 Offset: 0x8EA30 VA: 0x18008F630
	[XmlElementAttribute] // RVA: 0x8F630 Offset: 0x8EA30 VA: 0x18008F630
	[XmlElementAttribute] // RVA: 0x8F630 Offset: 0x8EA30 VA: 0x18008F630
	[XmlElementAttribute] // RVA: 0x8F630 Offset: 0x8EA30 VA: 0x18008F630
	public XmlSchemaParticle Particle { get; set; }
	[XmlElementAttribute] // RVA: 0x8F900 Offset: 0x8ED00 VA: 0x18008F900
	[XmlElementAttribute] // RVA: 0x8F900 Offset: 0x8ED00 VA: 0x18008F900
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] // RVA: 0x8E5E0 Offset: 0x8D9E0 VA: 0x18008E5E0
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x104D8F0 Offset: 0x104BEF0 VA: 0x18104D8F0
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x104D840 Offset: 0x104BE40 VA: 0x18104D840
	public void .ctor() { }

}

public class XmlSchemaComplexContentRestriction : XmlSchemaContent // TypeDefIndex: 2323
{	// Fields
	private XmlSchemaParticle particle; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName baseTypeName; // 0x68

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8F490 Offset: 0x8E890 VA: 0x18008F490
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x8FCA0 Offset: 0x8F0A0 VA: 0x18008FCA0
	[XmlElementAttribute] // RVA: 0x8FCA0 Offset: 0x8F0A0 VA: 0x18008FCA0
	[XmlElementAttribute] // RVA: 0x8FCA0 Offset: 0x8F0A0 VA: 0x18008FCA0
	[XmlElementAttribute] // RVA: 0x8FCA0 Offset: 0x8F0A0 VA: 0x18008FCA0
	public XmlSchemaParticle Particle { get; set; }
	[XmlElementAttribute] // RVA: 0x90020 Offset: 0x8F420 VA: 0x180090020
	[XmlElementAttribute] // RVA: 0x90020 Offset: 0x8F420 VA: 0x180090020
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] // RVA: 0x8E5E0 Offset: 0x8D9E0 VA: 0x18008E5E0
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x104DA60 Offset: 0x104C060 VA: 0x18104DA60
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x104D9B0 Offset: 0x104BFB0 VA: 0x18104D9B0
	public void .ctor() { }

}

public class XmlSchemaComplexType : XmlSchemaType // TypeDefIndex: 2324
{	// Fields
	private XmlSchemaDerivationMethod block; // 0x98
	private XmlSchemaContentModel contentModel; // 0xA0
	private XmlSchemaParticle particle; // 0xA8
	private XmlSchemaObjectCollection attributes; // 0xB0
	private XmlSchemaAnyAttribute anyAttribute; // 0xB8
	private XmlSchemaParticle contentTypeParticle; // 0xC0
	private XmlSchemaDerivationMethod blockResolved; // 0xC8
	private XmlSchemaObjectTable localElements; // 0xD0
	private XmlSchemaObjectTable attributeUses; // 0xD8
	private XmlSchemaAnyAttribute attributeWildcard; // 0xE0
	private static XmlSchemaComplexType anyTypeLax; // 0x0
	private static XmlSchemaComplexType anyTypeSkip; // 0x8
	private static XmlSchemaComplexType untypedAnyType; // 0x10
	private byte pvFlags; // 0xE8

	// Properties
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static XmlSchemaComplexType AnyType { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static XmlSchemaComplexType UntypedAnyType { get; }
	internal static ContentValidator AnyTypeContentValidator { get; }
	[XmlAttributeAttribute] // RVA: 0x903F0 Offset: 0x8F7F0 VA: 0x1800903F0
	[DefaultValueAttribute] // RVA: 0x903F0 Offset: 0x8F7F0 VA: 0x1800903F0
	public bool IsAbstract { get; set; }
	[XmlAttributeAttribute] // RVA: 0x90590 Offset: 0x8F990 VA: 0x180090590
	[DefaultValueAttribute] // RVA: 0x90590 Offset: 0x8F990 VA: 0x180090590
	public XmlSchemaDerivationMethod Block { get; set; }
	[XmlAttributeAttribute] // RVA: 0x90850 Offset: 0x8FC50 VA: 0x180090850
	[DefaultValueAttribute] // RVA: 0x90850 Offset: 0x8FC50 VA: 0x180090850
	public override bool IsMixed { get; set; }
	[XmlElementAttribute] // RVA: 0x90900 Offset: 0x8FD00 VA: 0x180090900
	[XmlElementAttribute] // RVA: 0x90900 Offset: 0x8FD00 VA: 0x180090900
	public XmlSchemaContentModel ContentModel { get; set; }
	[XmlElementAttribute] // RVA: 0x90C20 Offset: 0x90020 VA: 0x180090C20
	[XmlElementAttribute] // RVA: 0x90C20 Offset: 0x90020 VA: 0x180090C20
	[XmlElementAttribute] // RVA: 0x90C20 Offset: 0x90020 VA: 0x180090C20
	[XmlElementAttribute] // RVA: 0x90C20 Offset: 0x90020 VA: 0x180090C20
	public XmlSchemaParticle Particle { get; set; }
	[XmlElementAttribute] // RVA: 0x90FE0 Offset: 0x903E0 VA: 0x180090FE0
	[XmlElementAttribute] // RVA: 0x90FE0 Offset: 0x903E0 VA: 0x180090FE0
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] // RVA: 0x8E5E0 Offset: 0x8D9E0 VA: 0x18008E5E0
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaContentType ContentType { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaParticle ContentTypeParticle { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaDerivationMethod BlockResolved { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaObjectTable AttributeUses { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaAnyAttribute AttributeWildcard { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal XmlSchemaObjectTable LocalElements { get; }
	internal bool HasWildCard { set; }

	// Methods

	// RVA: 0x104F9E0 Offset: 0x104DFE0 VA: 0x18104F9E0
	private static void .cctor() { }

	// RVA: 0x104F0E0 Offset: 0x104D6E0 VA: 0x18104F0E0
	private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents) { }

	// RVA: 0x104FCB0 Offset: 0x104E2B0 VA: 0x18104FCB0
	public void .ctor() { }

	// RVA: 0x104FDB0 Offset: 0x104E3B0 VA: 0x18104FDB0
	internal static XmlSchemaComplexType get_AnyType() { }

	// RVA: 0x104FFB0 Offset: 0x104E5B0 VA: 0x18104FFB0
	internal static XmlSchemaComplexType get_UntypedAnyType() { }

	// RVA: 0x104FD30 Offset: 0x104E330 VA: 0x18104FD30
	internal static ContentValidator get_AnyTypeContentValidator() { }

	// RVA: 0x104FF10 Offset: 0x104E510 VA: 0x18104FF10
	public bool get_IsAbstract() { }

	// RVA: 0x1050050 Offset: 0x104E650 VA: 0x181050050
	public void set_IsAbstract(bool value) { }

	// RVA: 0xB9BA00 Offset: 0xB9A000 VA: 0x180B9BA00
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x1050010 Offset: 0x104E610 VA: 0x181050010
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x104FF20 Offset: 0x104E520 VA: 0x18104FF20 Slot: 14
	public override bool get_IsMixed() { }

	// RVA: 0x1050080 Offset: 0x104E680 VA: 0x181050080 Slot: 15
	public override void set_IsMixed(bool value) { }

	// RVA: 0x5742F0 Offset: 0x5728F0 VA: 0x1805742F0
	public XmlSchemaContentModel get_ContentModel() { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public void set_ContentModel(XmlSchemaContentModel value) { }

	// RVA: 0x79BDE0 Offset: 0x79A3E0 VA: 0x18079BDE0
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x79BE60 Offset: 0x79A460 VA: 0x18079BE60
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x104FE90 Offset: 0x104E490 VA: 0x18104FE90
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x79BDD0 Offset: 0x79A3D0 VA: 0x18079BDD0
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x79BE50 Offset: 0x79A450 VA: 0x18079BE50
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0xD27F40 Offset: 0xD26540 VA: 0x180D27F40
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x79BE20 Offset: 0x79A420 VA: 0x18079BE20
	public XmlSchemaParticle get_ContentTypeParticle() { }

	// RVA: 0xAE31D0 Offset: 0xAE17D0 VA: 0x180AE31D0
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x104FE10 Offset: 0x104E410 VA: 0x18104FE10
	public XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x4EF330 Offset: 0x4ED930 VA: 0x1804EF330
	public XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x104FF30 Offset: 0x104E530 VA: 0x18104FF30
	internal XmlSchemaObjectTable get_LocalElements() { }

	// RVA: 0x79BEA0 Offset: 0x79A4A0 VA: 0x18079BEA0
	internal void SetContentTypeParticle(XmlSchemaParticle value) { }

	// RVA: 0x104F9D0 Offset: 0x104DFD0 VA: 0x18104F9D0
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x4EF340 Offset: 0x4ED940 VA: 0x1804EF340
	internal void SetAttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x1050020 Offset: 0x104E620 VA: 0x181050020
	internal void set_HasWildCard(bool value) { }

	// RVA: 0x79BE40 Offset: 0x79A440 VA: 0x18079BE40
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x104EEB0 Offset: 0x104D4B0 VA: 0x18104EEB0
	internal bool ContainsIdAttribute(bool findAll) { }

	// RVA: 0x104EEA0 Offset: 0x104D4A0 VA: 0x18104EEA0 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x104E490 Offset: 0x104CA90 VA: 0x18104E490
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x104DB30 Offset: 0x104C130 VA: 0x18104DB30
	private void ClearCompiledState() { }

	// RVA: 0x104DBF0 Offset: 0x104C1F0 VA: 0x18104DBF0
	internal static XmlSchemaObjectCollection CloneAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x104DE80 Offset: 0x104C480 VA: 0x18104DE80
	private static XmlSchemaObjectCollection CloneGroupBaseParticles(XmlSchemaObjectCollection groupBaseParticles, XmlSchema parentSchema) { }

	// RVA: 0x104DFC0 Offset: 0x104C5C0 VA: 0x18104DFC0
	internal static XmlSchemaParticle CloneParticle(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x104F520 Offset: 0x104DB20 VA: 0x18104F520
	private static XmlSchemaForm GetResolvedElementForm(XmlSchema parentSchema, XmlSchemaElement element) { }

	// RVA: 0x104F6C0 Offset: 0x104DCC0 VA: 0x18104F6C0
	internal static bool HasParticleRef(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x104F550 Offset: 0x104DB50 VA: 0x18104F550
	internal static bool HasAttributeQNameRef(XmlSchemaObjectCollection attributes) { }

}

public abstract class XmlSchemaContent : XmlSchemaAnnotated // TypeDefIndex: 2325
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

public abstract class XmlSchemaContentModel : XmlSchemaAnnotated // TypeDefIndex: 2326
{	// Properties
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public abstract XmlSchemaContent Content { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 14
	public abstract XmlSchemaContent get_Content();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void set_Content(XmlSchemaContent value);

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

public enum XmlSchemaContentProcessing // TypeDefIndex: 2327
{	// Fields
	public int value__; // 0x0
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public const XmlSchemaContentProcessing None = 0;
	[XmlEnumAttribute] // RVA: 0x916F0 Offset: 0x90AF0 VA: 0x1800916F0
	public const XmlSchemaContentProcessing Skip = 1;
	[XmlEnumAttribute] // RVA: 0x91810 Offset: 0x90C10 VA: 0x180091810
	public const XmlSchemaContentProcessing Lax = 2;
	[XmlEnumAttribute] // RVA: 0x91950 Offset: 0x90D50 VA: 0x180091950
	public const XmlSchemaContentProcessing Strict = 3;

}

public enum XmlSchemaContentType // TypeDefIndex: 2328
{	// Fields
	public int value__; // 0x0
	public const XmlSchemaContentType TextOnly = 0;
	public const XmlSchemaContentType Empty = 1;
	public const XmlSchemaContentType ElementOnly = 2;
	public const XmlSchemaContentType Mixed = 3;

}

public abstract class XmlSchemaDatatype // TypeDefIndex: 2329
{	// Properties
	public abstract Type ValueType { get; }
	public abstract XmlTokenizedType TokenizedType { get; }
	public virtual XmlSchemaDatatypeVariety Variety { get; }
	public virtual XmlTypeCode TypeCode { get; }
	internal abstract bool HasLexicalFacets { get; }
	internal abstract bool HasValueFacets { get; }
	internal abstract XmlValueConverter ValueConverter { get; }
	internal abstract RestrictionFacets Restriction { get; }
	internal abstract FacetsChecker FacetsChecker { get; }
	internal abstract XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal string TypeCodeString { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Type get_ValueType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract XmlTokenizedType get_TokenizedType();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr);

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 7
	public virtual XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 8
	public virtual XmlTypeCode get_TypeCode() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	public virtual bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool get_HasLexicalFacets();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract bool get_HasValueFacets();

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract XmlValueConverter get_ValueConverter();

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract RestrictionFacets get_Restriction();

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract int Compare(object value1, object value2);

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue);

	// RVA: -1 Offset: -1 Slot: 16
	internal abstract Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue);

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue);

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract FacetsChecker get_FacetsChecker();

	// RVA: -1 Offset: -1 Slot: 19
	internal abstract XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();

	// RVA: -1 Offset: -1 Slot: 20
	internal abstract XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType);

	// RVA: -1 Offset: -1 Slot: 21
	internal abstract XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType);

	// RVA: -1 Offset: -1 Slot: 22
	internal abstract void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller);

	// RVA: -1 Offset: -1 Slot: 23
	internal abstract bool IsEqual(object o1, object o2);

	// RVA: -1 Offset: -1 Slot: 24
	internal abstract bool IsComparable(XmlSchemaDatatype dtype);

	// RVA: 0x1050BA0 Offset: 0x104F1A0 VA: 0x181050BA0
	internal string get_TypeCodeString() { }

	// RVA: 0x1050670 Offset: 0x104EC70 VA: 0x181050670
	internal string TypeCodeToString(XmlTypeCode typeCode) { }

	// RVA: 0x10500B0 Offset: 0x104E6B0 VA: 0x1810500B0
	internal static string ConcatenatedToString(object value) { }

	// RVA: 0x1050620 Offset: 0x104EC20 VA: 0x181050620
	internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x10505D0 Offset: 0x104EBD0 VA: 0x1810505D0
	internal static XmlSchemaDatatype FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x1050570 Offset: 0x104EB70 VA: 0x181050570
	internal static XmlSchemaDatatype FromXdrName(string name) { }

	// RVA: 0x1050500 Offset: 0x104EB00 VA: 0x181050500
	internal static XmlSchemaDatatype DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x1050A00 Offset: 0x104F000 VA: 0x181050A00
	internal static string XdrCanonizeUri(string uri, XmlNameTable nameTable, SchemaNames schemaNames) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

public enum XmlSchemaDerivationMethod // TypeDefIndex: 2330
{	// Fields
	public int value__; // 0x0
	[XmlEnumAttribute] // RVA: 0x91B10 Offset: 0x90F10 VA: 0x180091B10
	public const XmlSchemaDerivationMethod Empty = 0;
	[XmlEnumAttribute] // RVA: 0x91C10 Offset: 0x91010 VA: 0x180091C10
	public const XmlSchemaDerivationMethod Substitution = 1;
	[XmlEnumAttribute] // RVA: 0x93020 Offset: 0x92420 VA: 0x180093020
	public const XmlSchemaDerivationMethod Extension = 2;
	[XmlEnumAttribute] // RVA: 0x93080 Offset: 0x92480 VA: 0x180093080
	public const XmlSchemaDerivationMethod Restriction = 4;
	[XmlEnumAttribute] // RVA: 0x93110 Offset: 0x92510 VA: 0x180093110
	public const XmlSchemaDerivationMethod List = 8;
	[XmlEnumAttribute] // RVA: 0x93210 Offset: 0x92610 VA: 0x180093210
	public const XmlSchemaDerivationMethod Union = 16;
	[XmlEnumAttribute] // RVA: 0x933A0 Offset: 0x927A0 VA: 0x1800933A0
	public const XmlSchemaDerivationMethod All = 255;
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public const XmlSchemaDerivationMethod None = 256;

}

public class XmlSchemaDocumentation : XmlSchemaObject // TypeDefIndex: 2331
{	// Fields
	private string source; // 0x38
	private string language; // 0x40
	private XmlNode[] markup; // 0x48
	private static XmlSchemaSimpleType languageType; // 0x0

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8D290 Offset: 0x8C690 VA: 0x18008D290
	public string Source { set; }
	[XmlAttributeAttribute] // RVA: 0x93580 Offset: 0x92980 VA: 0x180093580
	public string Language { set; }
	[XmlAnyElementAttribute] // RVA: 0x93650 Offset: 0x92A50 VA: 0x180093650
	[XmlTextAttribute] // RVA: 0x93650 Offset: 0x92A50 VA: 0x180093650
	public XmlNode[] Markup { set; }

	// Methods

	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	public void set_Source(string value) { }

	// RVA: 0x1050D60 Offset: 0x104F360 VA: 0x181050D60
	public void set_Language(string value) { }

	// RVA: 0x5DD7A0 Offset: 0x5DBDA0 VA: 0x1805DD7A0
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1050CD0 Offset: 0x104F2D0 VA: 0x181050CD0
	private static void .cctor() { }

}

public class XmlSchemaElement : XmlSchemaParticle // TypeDefIndex: 2332
{	// Fields
	private bool isAbstract; // 0x78
	private bool hasAbstractAttribute; // 0x79
	private bool isNillable; // 0x7A
	private bool hasNillableAttribute; // 0x7B
	private bool isLocalTypeDerivationChecked; // 0x7C
	private XmlSchemaDerivationMethod block; // 0x80
	private XmlSchemaDerivationMethod final; // 0x84
	private XmlSchemaForm form; // 0x88
	private string defaultValue; // 0x90
	private string fixedValue; // 0x98
	private string name; // 0xA0
	private XmlQualifiedName refName; // 0xA8
	private XmlQualifiedName substitutionGroup; // 0xB0
	private XmlQualifiedName typeName; // 0xB8
	private XmlSchemaType type; // 0xC0
	private XmlQualifiedName qualifiedName; // 0xC8
	private XmlSchemaType elementType; // 0xD0
	private XmlSchemaDerivationMethod blockResolved; // 0xD8
	private XmlSchemaDerivationMethod finalResolved; // 0xDC
	private XmlSchemaObjectCollection constraints; // 0xE0
	private SchemaElementDecl elementDecl; // 0xE8

	// Properties
	[XmlAttributeAttribute] // RVA: 0x903F0 Offset: 0x8F7F0 VA: 0x1800903F0
	[DefaultValueAttribute] // RVA: 0x903F0 Offset: 0x8F7F0 VA: 0x1800903F0
	public bool IsAbstract { get; set; }
	[DefaultValueAttribute] // RVA: 0x937A0 Offset: 0x92BA0 VA: 0x1800937A0
	[XmlAttributeAttribute] // RVA: 0x937A0 Offset: 0x92BA0 VA: 0x1800937A0
	public XmlSchemaDerivationMethod Block { get; set; }
	[XmlAttributeAttribute] // RVA: 0x8D4A0 Offset: 0x8C8A0 VA: 0x18008D4A0
	[DefaultValueAttribute] // RVA: 0x8D4A0 Offset: 0x8C8A0 VA: 0x18008D4A0
	public string DefaultValue { get; set; }
	[DefaultValueAttribute] // RVA: 0x93A10 Offset: 0x92E10 VA: 0x180093A10
	[XmlAttributeAttribute] // RVA: 0x93A10 Offset: 0x92E10 VA: 0x180093A10
	public XmlSchemaDerivationMethod Final { get; set; }
	[DefaultValueAttribute] // RVA: 0x8D600 Offset: 0x8CA00 VA: 0x18008D600
	[XmlAttributeAttribute] // RVA: 0x8D600 Offset: 0x8CA00 VA: 0x18008D600
	public string FixedValue { get; set; }
	[DefaultValueAttribute] // RVA: 0x93C40 Offset: 0x93040 VA: 0x180093C40
	[XmlAttributeAttribute] // RVA: 0x93C40 Offset: 0x93040 VA: 0x180093C40
	public XmlSchemaForm Form { get; set; }
	[DefaultValueAttribute] // RVA: 0x93D60 Offset: 0x93160 VA: 0x180093D60
	[XmlAttributeAttribute] // RVA: 0x93D60 Offset: 0x93160 VA: 0x180093D60
	public string Name { get; set; }
	[XmlAttributeAttribute] // RVA: 0x93E50 Offset: 0x93250 VA: 0x180093E50
	[DefaultValueAttribute] // RVA: 0x93E50 Offset: 0x93250 VA: 0x180093E50
	public bool IsNillable { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal bool HasNillableAttribute { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal bool HasAbstractAttribute { get; }
	[XmlAttributeAttribute] // RVA: 0x8DAE0 Offset: 0x8CEE0 VA: 0x18008DAE0
	public XmlQualifiedName RefName { get; set; }
	[XmlAttributeAttribute] // RVA: 0x94120 Offset: 0x93520 VA: 0x180094120
	public XmlQualifiedName SubstitutionGroup { get; set; }
	[XmlAttributeAttribute] // RVA: 0x8DB80 Offset: 0x8CF80 VA: 0x18008DB80
	public XmlQualifiedName SchemaTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x94240 Offset: 0x93640 VA: 0x180094240
	[XmlElementAttribute] // RVA: 0x94240 Offset: 0x93640 VA: 0x180094240
	public XmlSchemaType SchemaType { get; set; }
	[XmlElementAttribute] // RVA: 0x94380 Offset: 0x93780 VA: 0x180094380
	[XmlElementAttribute] // RVA: 0x94380 Offset: 0x93780 VA: 0x180094380
	[XmlElementAttribute] // RVA: 0x94380 Offset: 0x93780 VA: 0x180094380
	public XmlSchemaObjectCollection Constraints { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaType ElementSchemaType { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaDerivationMethod BlockResolved { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaDerivationMethod FinalResolved { get; }
	internal bool HasConstraints { get; }
	internal bool IsLocalTypeDerivationChecked { get; set; }
	internal SchemaElementDecl ElementDecl { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal override string NameAttribute { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal override string NameString { get; }

	// Methods

	// RVA: 0x956010 Offset: 0x954610 VA: 0x180956010
	public bool get_IsAbstract() { }

	// RVA: 0x10512F0 Offset: 0x104F8F0 VA: 0x1810512F0
	public void set_IsAbstract(bool value) { }

	// RVA: 0x5828D0 Offset: 0x580ED0 VA: 0x1805828D0
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x5828E0 Offset: 0x580EE0 VA: 0x1805828E0
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x4E3FE0 Offset: 0x4E25E0 VA: 0x1804E3FE0
	public string get_DefaultValue() { }

	// RVA: 0x4E3FF0 Offset: 0x4E25F0 VA: 0x1804E3FF0
	public void set_DefaultValue(string value) { }

	// RVA: 0x79BE30 Offset: 0x79A430 VA: 0x18079BE30
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x79BEB0 Offset: 0x79A4B0 VA: 0x18079BEB0
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0x574310 Offset: 0x572910 VA: 0x180574310
	public string get_FixedValue() { }

	// RVA: 0x5743A0 Offset: 0x5729A0 VA: 0x1805743A0
	public void set_FixedValue(string value) { }

	// RVA: 0x58AC00 Offset: 0x589200 VA: 0x18058AC00
	public XmlSchemaForm get_Form() { }

	// RVA: 0xF8CD60 Offset: 0xF8B360 VA: 0x180F8CD60
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x5742F0 Offset: 0x5728F0 VA: 0x1805742F0
	public string get_Name() { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public void set_Name(string value) { }

	// RVA: 0x10512B0 Offset: 0x104F8B0 VA: 0x1810512B0
	public bool get_IsNillable() { }

	// RVA: 0x1051300 Offset: 0x104F900 VA: 0x181051300
	public void set_IsNillable(bool value) { }

	// RVA: 0x10512A0 Offset: 0x104F8A0 VA: 0x1810512A0
	internal bool get_HasNillableAttribute() { }

	// RVA: 0x1051260 Offset: 0x104F860 VA: 0x181051260
	internal bool get_HasAbstractAttribute() { }

	// RVA: 0x79BDE0 Offset: 0x79A3E0 VA: 0x18079BDE0
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x1051310 Offset: 0x104F910 VA: 0x181051310
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x79BDB0 Offset: 0x79A3B0 VA: 0x18079BDB0
	public XmlQualifiedName get_SubstitutionGroup() { }

	// RVA: 0x1051490 Offset: 0x104FA90 VA: 0x181051490
	public void set_SubstitutionGroup(XmlQualifiedName value) { }

	// RVA: 0x79BDD0 Offset: 0x79A3D0 VA: 0x18079BDD0
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x10513D0 Offset: 0x104F9D0 VA: 0x1810513D0
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x79BE20 Offset: 0x79A420 VA: 0x18079BE20
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0x79BEA0 Offset: 0x79A4A0 VA: 0x18079BEA0
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x10511D0 Offset: 0x104F7D0 VA: 0x1810511D0
	public XmlSchemaObjectCollection get_Constraints() { }

	// RVA: 0xDA0E50 Offset: 0xD9F450 VA: 0x180DA0E50
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x79BDF0 Offset: 0x79A3F0 VA: 0x18079BDF0
	public XmlSchemaType get_ElementSchemaType() { }

	// RVA: 0x10511C0 Offset: 0x104F7C0 VA: 0x1810511C0
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x1051250 Offset: 0x104F850 VA: 0x181051250
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0xDA1230 Offset: 0xD9F830 VA: 0x180DA1230
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x79BE70 Offset: 0x79A470 VA: 0x18079BE70
	internal void SetElementType(XmlSchemaType value) { }

	// RVA: 0x1051090 Offset: 0x104F690 VA: 0x181051090
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10510A0 Offset: 0x104F6A0 VA: 0x1810510A0
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1051270 Offset: 0x104F870 VA: 0x181051270
	internal bool get_HasConstraints() { }

	// RVA: 0x966700 Offset: 0x964D00 VA: 0x180966700
	internal bool get_IsLocalTypeDerivationChecked() { }

	// RVA: 0x966710 Offset: 0x964D10 VA: 0x180966710
	internal void set_IsLocalTypeDerivationChecked(bool value) { }

	// RVA: 0x88D970 Offset: 0x88BF70 VA: 0x18088D970
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x88D9F0 Offset: 0x88BFF0 VA: 0x18088D9F0
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x5742F0 Offset: 0x5728F0 VA: 0x1805742F0 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x10512C0 Offset: 0x104F8C0 VA: 0x1810512C0 Slot: 15
	internal override string get_NameString() { }

	// RVA: 0x1051080 Offset: 0x104F680 VA: 0x181051080 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1050E30 Offset: 0x104F430 VA: 0x181050E30
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x10510B0 Offset: 0x104F6B0 VA: 0x1810510B0
	public void .ctor() { }

}

public class XmlSchemaException : SystemException // TypeDefIndex: 2333
{	// Fields
	private string res; // 0x88
	private string[] args; // 0x90
	private string sourceUri; // 0x98
	private int lineNumber; // 0xA0
	private int linePosition; // 0xA4
	private XmlSchemaObject sourceSchemaObject; // 0xA8
	private string message; // 0xB0

	// Properties
	internal string GetRes { get; }
	internal string[] Args { get; }
	public string SourceUri { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	public XmlSchemaObject SourceSchemaObject { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x1051F20 Offset: 0x1050520 VA: 0x181051F20
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10515F0 Offset: 0x104FBF0 VA: 0x1810515F0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1052310 Offset: 0x1050910 VA: 0x181052310
	public void .ctor() { }

	// RVA: 0x1051980 Offset: 0x104FF80 VA: 0x181051980
	public void .ctor(string message) { }

	// RVA: 0x1051E10 Offset: 0x1050410 VA: 0x181051E10
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1051AD0 Offset: 0x10500D0 VA: 0x181051AD0
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x1052270 Offset: 0x1050870 VA: 0x181052270
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x1051840 Offset: 0x104FE40 VA: 0x181051840
	internal void .ctor(string res, string arg) { }

	// RVA: 0x1051D00 Offset: 0x1050300 VA: 0x181051D00
	internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1051800 Offset: 0x104FE00 VA: 0x181051800
	internal void .ctor(string res, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0xD28290 Offset: 0xD26890 VA: 0x180D28290
	internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x10517B0 Offset: 0x104FDB0 VA: 0x1810517B0
	internal void .ctor(string res, XmlSchemaObject source) { }

	// RVA: 0x1051BF0 Offset: 0x10501F0 VA: 0x181051BF0
	internal void .ctor(string res, string arg, XmlSchemaObject source) { }

	// RVA: 0x1051A80 Offset: 0x1050080 VA: 0x181051A80
	internal void .ctor(string res, string[] args, XmlSchemaObject source) { }

	// RVA: 0x10523D0 Offset: 0x10509D0 VA: 0x1810523D0
	internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source) { }

	// RVA: 0x1051570 Offset: 0x104FB70 VA: 0x181051570
	internal static string CreateMessage(string res, string[] args) { }

	// RVA: 0x574300 Offset: 0x572900 VA: 0x180574300
	internal string get_GetRes() { }

	// RVA: 0x4E3FE0 Offset: 0x4E25E0 VA: 0x1804E3FE0
	internal string[] get_Args() { }

	// RVA: 0x574310 Offset: 0x572910 VA: 0x180574310
	public string get_SourceUri() { }

	// RVA: 0x1052490 Offset: 0x1050A90 VA: 0x181052490
	public int get_LineNumber() { }

	// RVA: 0x10524A0 Offset: 0x1050AA0 VA: 0x1810524A0
	public int get_LinePosition() { }

	// RVA: 0x79BDE0 Offset: 0x79A3E0 VA: 0x18079BDE0
	public XmlSchemaObject get_SourceSchemaObject() { }

	// RVA: 0x1051700 Offset: 0x104FD00 VA: 0x181051700
	internal void SetSource(string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x79BE60 Offset: 0x79A460 VA: 0x18079BE60
	internal void SetSchemaObject(XmlSchemaObject source) { }

	// RVA: 0x1051750 Offset: 0x104FD50 VA: 0x181051750
	internal void SetSource(XmlSchemaObject source) { }

	// RVA: 0x10524B0 Offset: 0x1050AB0 VA: 0x1810524B0 Slot: 5
	public override string get_Message() { }

}

public abstract class XmlSchemaExternal : XmlSchemaObject // TypeDefIndex: 2334
{	// Fields
	private string location; // 0x38
	private Uri baseUri; // 0x40
	private XmlSchema schema; // 0x48
	private string id; // 0x50
	private XmlAttribute[] moreAttributes; // 0x58
	private Compositor compositor; // 0x60

	// Properties
	[XmlAttributeAttribute] // RVA: 0x94900 Offset: 0x93D00 VA: 0x180094900
	public string SchemaLocation { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchema Schema { get; set; }
	[XmlAttributeAttribute] // RVA: 0x8A950 Offset: 0x89D50 VA: 0x18008A950
	public string Id { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal Uri BaseUri { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal override string IdAttribute { get; set; }
	internal Compositor Compositor { get; set; }

	// Methods

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public string get_SchemaLocation() { }

	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	public void set_SchemaLocation(string value) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public XmlSchema get_Schema() { }

	// RVA: 0x5DD7A0 Offset: 0x5DBDA0 VA: 0x1805DD7A0
	public void set_Schema(XmlSchema value) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public string get_Id() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	public void set_Id(string value) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	internal Uri get_BaseUri() { }

	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x574340 Offset: 0x572940 VA: 0x180574340
	internal Compositor get_Compositor() { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	internal void set_Compositor(Compositor value) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

public abstract class XmlSchemaFacet : XmlSchemaAnnotated // TypeDefIndex: 2336
{	// Fields
	private string value; // 0x50
	private bool isFixed; // 0x58
	private FacetType facetType; // 0x5C

	// Properties
	[XmlAttributeAttribute] // RVA: 0x94C00 Offset: 0x94000 VA: 0x180094C00
	public string Value { get; set; }
	[DefaultValueAttribute] // RVA: 0x94D20 Offset: 0x94120 VA: 0x180094D20
	[XmlAttributeAttribute] // RVA: 0x94D20 Offset: 0x94120 VA: 0x180094D20
	public virtual bool IsFixed { get; set; }
	internal FacetType FacetType { get; set; }

	// Methods

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public string get_Value() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	public void set_Value(string value) { }

	// RVA: 0x5925C0 Offset: 0x590BC0 VA: 0x1805925C0 Slot: 14
	public virtual bool get_IsFixed() { }

	// RVA: 0x10524D0 Offset: 0x1050AD0 VA: 0x1810524D0 Slot: 15
	public virtual void set_IsFixed(bool value) { }

	// RVA: 0x574330 Offset: 0x572930 VA: 0x180574330
	internal FacetType get_FacetType() { }

	// RVA: 0x5743C0 Offset: 0x5729C0 VA: 0x1805743C0
	internal void set_FacetType(FacetType value) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

public abstract class XmlSchemaNumericFacet : XmlSchemaFacet // TypeDefIndex: 2337
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

public class XmlSchemaLengthFacet : XmlSchemaNumericFacet // TypeDefIndex: 2338
{	// Methods

	// RVA: 0x105D430 Offset: 0x105BA30 VA: 0x18105D430
	public void .ctor() { }

}

public class XmlSchemaMinLengthFacet : XmlSchemaNumericFacet // TypeDefIndex: 2339
{	// Methods

	// RVA: 0x105D4F0 Offset: 0x105BAF0 VA: 0x18105D4F0
	public void .ctor() { }

}

public class XmlSchemaMaxLengthFacet : XmlSchemaNumericFacet // TypeDefIndex: 2340
{	// Methods

	// RVA: 0x105D490 Offset: 0x105BA90 VA: 0x18105D490
	public void .ctor() { }

}

public class XmlSchemaPatternFacet : XmlSchemaFacet // TypeDefIndex: 2341
{	// Methods

	// RVA: 0x105F1B0 Offset: 0x105D7B0 VA: 0x18105F1B0
	public void .ctor() { }

}

public class XmlSchemaEnumerationFacet : XmlSchemaFacet // TypeDefIndex: 2342
{	// Methods

	// RVA: 0x1051550 Offset: 0x104FB50 VA: 0x181051550
	public void .ctor() { }

}

public class XmlSchemaMinExclusiveFacet : XmlSchemaFacet // TypeDefIndex: 2343
{	// Methods

	// RVA: 0x105D4B0 Offset: 0x105BAB0 VA: 0x18105D4B0
	public void .ctor() { }

}

public class XmlSchemaMinInclusiveFacet : XmlSchemaFacet // TypeDefIndex: 2344
{	// Methods

	// RVA: 0x105D4D0 Offset: 0x105BAD0 VA: 0x18105D4D0
	public void .ctor() { }

}

public class XmlSchemaMaxExclusiveFacet : XmlSchemaFacet // TypeDefIndex: 2345
{	// Methods

	// RVA: 0x105D450 Offset: 0x105BA50 VA: 0x18105D450
	public void .ctor() { }

}

public class XmlSchemaMaxInclusiveFacet : XmlSchemaFacet // TypeDefIndex: 2346
{	// Methods

	// RVA: 0x105D470 Offset: 0x105BA70 VA: 0x18105D470
	public void .ctor() { }

}

public class XmlSchemaTotalDigitsFacet : XmlSchemaNumericFacet // TypeDefIndex: 2347
{	// Methods

	// RVA: 0xD27900 Offset: 0xD25F00 VA: 0x180D27900
	public void .ctor() { }

}

public class XmlSchemaFractionDigitsFacet : XmlSchemaNumericFacet // TypeDefIndex: 2348
{	// Methods

	// RVA: 0x1052590 Offset: 0x1050B90 VA: 0x181052590
	public void .ctor() { }

}

public class XmlSchemaWhiteSpaceFacet : XmlSchemaFacet // TypeDefIndex: 2349
{	// Methods

	// RVA: 0xD357E0 Offset: 0xD33DE0 VA: 0x180D357E0
	public void .ctor() { }

}

public enum XmlSchemaForm // TypeDefIndex: 2350
{	// Fields
	public int value__; // 0x0
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public const XmlSchemaForm None = 0;
	[XmlEnumAttribute] // RVA: 0x94EA0 Offset: 0x942A0 VA: 0x180094EA0
	public const XmlSchemaForm Qualified = 1;
	[XmlEnumAttribute] // RVA: 0x94F40 Offset: 0x94340 VA: 0x180094F40
	public const XmlSchemaForm Unqualified = 2;

}

public class XmlSchemaGroup : XmlSchemaAnnotated // TypeDefIndex: 2351
{	// Fields
	private string name; // 0x50
	private XmlSchemaGroupBase particle; // 0x58
	private XmlSchemaParticle canonicalParticle; // 0x60
	private XmlQualifiedName qname; // 0x68
	private XmlSchemaGroup redefined; // 0x70
	private int selfReferenceCount; // 0x78

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8D970 Offset: 0x8CD70 VA: 0x18008D970
	public string Name { get; set; }
	[XmlElementAttribute] // RVA: 0x950D0 Offset: 0x944D0 VA: 0x1800950D0
	[XmlElementAttribute] // RVA: 0x950D0 Offset: 0x944D0 VA: 0x1800950D0
	[XmlElementAttribute] // RVA: 0x950D0 Offset: 0x944D0 VA: 0x1800950D0
	public XmlSchemaGroupBase Particle { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal XmlSchemaParticle CanonicalParticle { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal XmlSchemaGroup Redefined { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal int SelfReferenceCount { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public string get_Name() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	public void set_Name(string value) { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810
	public void set_Particle(XmlSchemaGroupBase value) { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	internal XmlSchemaParticle get_CanonicalParticle() { }

	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0
	internal void set_CanonicalParticle(XmlSchemaParticle value) { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0xAF64F0 Offset: 0xAF4AF0 VA: 0x180AF64F0
	internal int get_SelfReferenceCount() { }

	// RVA: 0xB29460 Offset: 0xB27A60 VA: 0x180B29460
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x519DE0 Offset: 0x5183E0 VA: 0x180519DE0
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1052760 Offset: 0x1050D60 VA: 0x181052760 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1052770 Offset: 0x1050D70 VA: 0x181052770
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x1052930 Offset: 0x1050F30 VA: 0x181052930
	public void .ctor() { }

}

public abstract class XmlSchemaGroupBase : XmlSchemaParticle // TypeDefIndex: 2352
{	// Properties
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public abstract XmlSchemaObjectCollection Items { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 16
	public abstract XmlSchemaObjectCollection get_Items();

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract void SetItems(XmlSchemaObjectCollection newItems);

	// RVA: 0x10525B0 Offset: 0x1050BB0 VA: 0x1810525B0
	protected void .ctor() { }

}

public class XmlSchemaGroupRef : XmlSchemaParticle // TypeDefIndex: 2353
{	// Fields
	private XmlQualifiedName refName; // 0x78
	private XmlSchemaGroupBase particle; // 0x80
	private XmlSchemaGroup refined; // 0x88

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8DAE0 Offset: 0x8CEE0 VA: 0x18008DAE0
	public XmlQualifiedName RefName { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaGroupBase Particle { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal XmlSchemaGroup Redefined { get; set; }

	// Methods

	// RVA: 0x4E84B0 Offset: 0x4E6AB0 VA: 0x1804E84B0
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x10526A0 Offset: 0x1050CA0 VA: 0x1810526A0
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	internal void SetParticle(XmlSchemaGroupBase value) { }

	// RVA: 0x574300 Offset: 0x572900 VA: 0x180574300
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x574390 Offset: 0x572990 VA: 0x180574390
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x1052610 Offset: 0x1050C10 VA: 0x181052610
	public void .ctor() { }

}

public class XmlSchemaIdentityConstraint : XmlSchemaAnnotated // TypeDefIndex: 2354
{	// Fields
	private string name; // 0x50
	private XmlSchemaXPath selector; // 0x58
	private XmlSchemaObjectCollection fields; // 0x60
	private XmlQualifiedName qualifiedName; // 0x68
	private CompiledIdentityConstraint compiledConstraint; // 0x70

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8D970 Offset: 0x8CD70 VA: 0x18008D970
	public string Name { get; set; }
	[XmlElementAttribute] // RVA: 0x95970 Offset: 0x94D70 VA: 0x180095970
	public XmlSchemaXPath Selector { get; set; }
	[XmlElementAttribute] // RVA: 0x95AE0 Offset: 0x94EE0 VA: 0x180095AE0
	public XmlSchemaObjectCollection Fields { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal CompiledIdentityConstraint CompiledConstraint { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public string get_Name() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	public void set_Name(string value) { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public XmlSchemaXPath get_Selector() { }

	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810
	public void set_Selector(XmlSchemaXPath value) { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public XmlSchemaObjectCollection get_Fields() { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x519DE0 Offset: 0x5183E0 VA: 0x180519DE0
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	internal CompiledIdentityConstraint get_CompiledConstraint() { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	internal void set_CompiledConstraint(CompiledIdentityConstraint value) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x10529B0 Offset: 0x1050FB0 VA: 0x1810529B0
	public void .ctor() { }

}

public class XmlSchemaXPath : XmlSchemaAnnotated // TypeDefIndex: 2355
{	// Fields
	private string xpath; // 0x50

	// Properties
	[XmlAttributeAttribute] // RVA: 0x95F20 Offset: 0x95320 VA: 0x180095F20
	[DefaultValueAttribute] // RVA: 0x95F20 Offset: 0x95320 VA: 0x180095F20
	public string XPath { get; set; }

	// Methods

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public string get_XPath() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	public void set_XPath(string value) { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

}

public class XmlSchemaUnique : XmlSchemaIdentityConstraint // TypeDefIndex: 2356
{	// Methods

	// RVA: 0xD280E0 Offset: 0xD266E0 VA: 0x180D280E0
	public void .ctor() { }

}

public class XmlSchemaKey : XmlSchemaIdentityConstraint // TypeDefIndex: 2357
{	// Methods

	// RVA: 0xD280E0 Offset: 0xD266E0 VA: 0x180D280E0
	public void .ctor() { }

}

public class XmlSchemaKeyref : XmlSchemaIdentityConstraint // TypeDefIndex: 2358
{	// Fields
	private XmlQualifiedName refer; // 0x78

	// Properties
	[XmlAttributeAttribute] // RVA: 0x96090 Offset: 0x95490 VA: 0x180096090
	public XmlQualifiedName Refer { get; set; }

	// Methods

	// RVA: 0x4E84B0 Offset: 0x4E6AB0 VA: 0x1804E84B0
	public XmlQualifiedName get_Refer() { }

	// RVA: 0x105D370 Offset: 0x105B970 VA: 0x18105D370
	public void set_Refer(XmlQualifiedName value) { }

	// RVA: 0x105D2F0 Offset: 0x105B8F0 VA: 0x18105D2F0
	public void .ctor() { }

}

public class XmlSchemaImport : XmlSchemaExternal // TypeDefIndex: 2359
{	// Fields
	private string ns; // 0x68
	private XmlSchemaAnnotation annotation; // 0x70

	// Properties
	[XmlAttributeAttribute] // RVA: 0x961D0 Offset: 0x955D0 VA: 0x1800961D0
	public string Namespace { get; set; }

	// Methods

	// RVA: 0x1052A60 Offset: 0x1051060 VA: 0x181052A60
	public void .ctor() { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public string get_Namespace() { }

	// RVA: 0x519DE0 Offset: 0x5183E0 VA: 0x180519DE0
	public void set_Namespace(string value) { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

}

public class XmlSchemaInclude : XmlSchemaExternal // TypeDefIndex: 2360
{	// Fields
	private XmlSchemaAnnotation annotation; // 0x68

	// Methods

	// RVA: 0x1052A80 Offset: 0x1051080 VA: 0x181052A80
	public void .ctor() { }

	// RVA: 0x519DE0 Offset: 0x5183E0 VA: 0x180519DE0 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

}

public class XmlSchemaInfo : IXmlSchemaInfo // TypeDefIndex: 2361
{	// Fields
	private bool isDefault; // 0x10
	private bool isNil; // 0x11
	private XmlSchemaElement schemaElement; // 0x18
	private XmlSchemaAttribute schemaAttribute; // 0x20
	private XmlSchemaType schemaType; // 0x28
	private XmlSchemaSimpleType memberType; // 0x30
	private XmlSchemaValidity validity; // 0x38
	private XmlSchemaContentType contentType; // 0x3C

	// Properties
	public XmlSchemaValidity Validity { get; set; }
	public bool IsDefault { get; set; }
	public bool IsNil { get; set; }
	public XmlSchemaSimpleType MemberType { get; set; }
	public XmlSchemaType SchemaType { get; set; }
	public XmlSchemaElement SchemaElement { get; set; }
	public XmlSchemaAttribute SchemaAttribute { get; set; }
	public XmlSchemaContentType ContentType { get; }
	internal XmlSchemaType XmlType { get; }
	internal bool HasDefaultValue { get; }
	internal bool IsUnionType { get; }

	// Methods

	// RVA: 0x105D120 Offset: 0x105B720 VA: 0x18105D120
	public void .ctor() { }

	// RVA: 0x105D0A0 Offset: 0x105B6A0 VA: 0x18105D0A0
	internal void .ctor(XmlSchemaValidity validity) { }

	// RVA: 0x6BB9E0 Offset: 0x6B9FE0 VA: 0x1806BB9E0 Slot: 4
	public XmlSchemaValidity get_Validity() { }

	// RVA: 0xC75070 Offset: 0xC73670 VA: 0x180C75070
	public void set_Validity(XmlSchemaValidity value) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90 Slot: 5
	public bool get_IsDefault() { }

	// RVA: 0x49AFC0 Offset: 0x4995C0 VA: 0x18049AFC0
	public void set_IsDefault(bool value) { }

	// RVA: 0xF8C110 Offset: 0xF8A710 VA: 0x180F8C110 Slot: 6
	public bool get_IsNil() { }

	// RVA: 0xF8C120 Offset: 0xF8A720 VA: 0x180F8C120
	public void set_IsNil(bool value) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0 Slot: 7
	public XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	public void set_MemberType(XmlSchemaSimpleType value) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 8
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0x105D2A0 Offset: 0x105B8A0 VA: 0x18105D2A0
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	public XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x105D260 Offset: 0x105B860 VA: 0x18105D260
	public void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 10
	public XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x105D220 Offset: 0x105B820 VA: 0x18105D220
	public void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0x5E2EE0 Offset: 0x5E14E0 VA: 0x1805E2EE0
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x105D210 Offset: 0x105B810 VA: 0x18105D210
	internal XmlSchemaType get_XmlType() { }

	// RVA: 0x105D190 Offset: 0x105B790 VA: 0x18105D190
	internal bool get_HasDefaultValue() { }

	// RVA: 0x105D1D0 Offset: 0x105B7D0 VA: 0x18105D1D0
	internal bool get_IsUnionType() { }

	// RVA: 0x105D030 Offset: 0x105B630 VA: 0x18105D030
	internal void Clear() { }

}

public class XmlSchemaNotation : XmlSchemaAnnotated // TypeDefIndex: 2362
{	// Fields
	private string name; // 0x50
	private string publicId; // 0x58
	private string systemId; // 0x60
	private XmlQualifiedName qname; // 0x68

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8D970 Offset: 0x8CD70 VA: 0x18008D970
	public string Name { get; set; }
	[XmlAttributeAttribute] // RVA: 0x96390 Offset: 0x95790 VA: 0x180096390
	public string Public { get; set; }
	[XmlAttributeAttribute] // RVA: 0x963C0 Offset: 0x957C0 VA: 0x1800963C0
	public string System { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal XmlQualifiedName QualifiedName { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public string get_Name() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	public void set_Name(string value) { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public string get_Public() { }

	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810
	public void set_Public(string value) { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public string get_System() { }

	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0
	public void set_System(string value) { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	internal XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x519DE0 Offset: 0x5183E0 VA: 0x180519DE0
	internal void set_QualifiedName(XmlQualifiedName value) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x105D510 Offset: 0x105BB10 VA: 0x18105D510
	public void .ctor() { }

}

public abstract class XmlSchemaObject // TypeDefIndex: 2363
{	// Fields
	private int lineNum; // 0x10
	private int linePos; // 0x14
	private string sourceUri; // 0x18
	private XmlSerializerNamespaces namespaces; // 0x20
	private XmlSchemaObject parent; // 0x28
	private bool isProcessing; // 0x30

	// Properties
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int LineNumber { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int LinePosition { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public string SourceUri { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaObject Parent { get; set; }
	[XmlNamespaceDeclarationsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSerializerNamespaces Namespaces { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal virtual string IdAttribute { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal virtual string NameAttribute { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal bool IsProcessing { get; set; }

	// Methods

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_LineNumber() { }

	// RVA: 0x57C970 Offset: 0x57AF70 VA: 0x18057C970
	public void set_LineNumber(int value) { }

	// RVA: 0x57C960 Offset: 0x57AF60 VA: 0x18057C960
	public int get_LinePosition() { }

	// RVA: 0x57C980 Offset: 0x57AF80 VA: 0x18057C980
	public void set_LinePosition(int value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_SourceUri() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_SourceUri(string value) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public XmlSchemaObject get_Parent() { }

	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	public void set_Parent(XmlSchemaObject value) { }

	// RVA: 0x105E5A0 Offset: 0x105CBA0 VA: 0x18105E5A0
	public XmlSerializerNamespaces get_Namespaces() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_Namespaces(XmlSerializerNamespaces value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	internal virtual void OnAdd(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	internal virtual void OnRemove(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	internal virtual void OnClear(XmlSchemaObjectCollection container) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 7
	internal virtual string get_IdAttribute() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	internal virtual void set_IdAttribute(string value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 11
	internal virtual string get_NameAttribute() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	internal virtual void set_NameAttribute(string value) { }

	// RVA: 0x82C2F0 Offset: 0x82A8F0 VA: 0x18082C2F0
	internal bool get_IsProcessing() { }

	// RVA: 0x82C320 Offset: 0x82A920 VA: 0x18082C320
	internal void set_IsProcessing(bool value) { }

	// RVA: 0x105E520 Offset: 0x105CB20 VA: 0x18105E520 Slot: 13
	internal virtual XmlSchemaObject Clone() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

public class XmlSchemaObjectCollection : CollectionBase // TypeDefIndex: 2364
{	// Fields
	private XmlSchemaObject parent; // 0x18

	// Properties
	public virtual XmlSchemaObject Item { get; set; }

	// Methods

	// RVA: 0x105D9B0 Offset: 0x105BFB0 VA: 0x18105D9B0
	public void .ctor() { }

	// RVA: 0x105D9C0 Offset: 0x105BFC0 VA: 0x18105D9C0 Slot: 28
	public virtual XmlSchemaObject get_Item(int index) { }

	// RVA: 0x105DAE0 Offset: 0x105C0E0 VA: 0x18105DAE0 Slot: 29
	public virtual void set_Item(int index, XmlSchemaObject value) { }

	// RVA: 0x105D720 Offset: 0x105BD20 VA: 0x18105D720
	public XmlSchemaObjectEnumerator GetEnumerator() { }

	// RVA: 0x105D5D0 Offset: 0x105BBD0 VA: 0x18105D5D0
	public int Add(XmlSchemaObject item) { }

	// RVA: 0x105D7B0 Offset: 0x105BDB0 VA: 0x18105D7B0
	public void Insert(int index, XmlSchemaObject item) { }

	// RVA: 0x105D8F0 Offset: 0x105BEF0 VA: 0x18105D8F0
	public void Remove(XmlSchemaObject item) { }

	// RVA: 0x105D850 Offset: 0x105BE50 VA: 0x18105D850 Slot: 20
	protected override void OnInsert(int index, object item) { }

	// RVA: 0x105D890 Offset: 0x105BE90 VA: 0x18105D890 Slot: 19
	protected override void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x105D830 Offset: 0x105BE30 VA: 0x18105D830 Slot: 21
	protected override void OnClear() { }

	// RVA: 0x105D870 Offset: 0x105BE70 VA: 0x18105D870 Slot: 22
	protected override void OnRemove(int index, object item) { }

	// RVA: 0x105D690 Offset: 0x105BC90 VA: 0x18105D690
	internal XmlSchemaObjectCollection Clone() { }

	// RVA: 0x105D590 Offset: 0x105BB90 VA: 0x18105D590
	private void Add(XmlSchemaObjectCollection collToAdd) { }

}

public class XmlSchemaObjectEnumerator : IEnumerator // TypeDefIndex: 2365
{	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public XmlSchemaObject Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	internal void .ctor(IEnumerator enumerator) { }

	// RVA: 0x105DB60 Offset: 0x105C160 VA: 0x18105DB60
	public bool MoveNext() { }

	// RVA: 0x105DCA0 Offset: 0x105C2A0 VA: 0x18105DCA0
	public XmlSchemaObject get_Current() { }

	// RVA: 0x105DC00 Offset: 0x105C200 VA: 0x18105DC00 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x105DBB0 Offset: 0x105C1B0 VA: 0x18105DBB0 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x105DC50 Offset: 0x105C250 VA: 0x18105DC50 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

}

public class XmlSchemaObjectTable // TypeDefIndex: 2366
{	// Fields
	private Dictionary<XmlQualifiedName, XmlSchemaObject> table; // 0x10
	private List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x18

	// Properties
	public int Count { get; }
	public XmlSchemaObject Item { get; }
	public ICollection Values { get; }

	// Methods

	// RVA: 0x105E320 Offset: 0x105C920 VA: 0x18105E320
	internal void .ctor() { }

	// RVA: 0x105DD40 Offset: 0x105C340 VA: 0x18105DD40
	internal void Add(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x105E020 Offset: 0x105C620 VA: 0x18105E020
	internal void Insert(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x105E200 Offset: 0x105C800 VA: 0x18105E200
	internal void Replace(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x105DE00 Offset: 0x105C400 VA: 0x18105DE00
	internal void Clear() { }

	// RVA: 0x105E150 Offset: 0x105C750 VA: 0x18105E150
	internal void Remove(XmlQualifiedName name) { }

	// RVA: 0x105DEC0 Offset: 0x105C4C0 VA: 0x18105DEC0
	private int FindIndexByValue(XmlSchemaObject xso) { }

	// RVA: 0x105E3C0 Offset: 0x105C9C0 VA: 0x18105E3C0
	public int get_Count() { }

	// RVA: 0x105DE60 Offset: 0x105C460 VA: 0x18105DE60
	public bool Contains(XmlQualifiedName name) { }

	// RVA: 0x105E410 Offset: 0x105CA10 VA: 0x18105E410
	public XmlSchemaObject get_Item(XmlQualifiedName name) { }

	// RVA: 0x105E490 Offset: 0x105CA90 VA: 0x18105E490
	public ICollection get_Values() { }

	// RVA: 0x105DF80 Offset: 0x105C580 VA: 0x18105DF80
	public IDictionaryEnumerator GetEnumerator() { }

}

internal enum XmlSchemaObjectTable.EnumeratorType // TypeDefIndex: 2367
{	// Fields
	public int value__; // 0x0
	public const XmlSchemaObjectTable.EnumeratorType Keys = 0;
	public const XmlSchemaObjectTable.EnumeratorType Values = 1;
	public const XmlSchemaObjectTable.EnumeratorType DictionaryEntry = 2;

}

internal struct XmlSchemaObjectTable.XmlSchemaObjectEntry // TypeDefIndex: 2368
{	// Fields
	internal XmlQualifiedName qname; // 0x0
	internal XmlSchemaObject xso; // 0x8

	// Methods

	// RVA: 0xF5DB0 Offset: 0xF51B0 VA: 0x1800F5DB0
	public void .ctor(XmlQualifiedName name, XmlSchemaObject value) { }

}

internal class XmlSchemaObjectTable.ValuesCollection : ICollection, IEnumerable // TypeDefIndex: 2369
{	// Fields
	private List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x10
	private int size; // 0x18

	// Properties
	public int Count { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0xAE4C40 Offset: 0xAE3240 VA: 0x180AE4C40
	internal void .ctor(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size) { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400 Slot: 5
	public int get_Count() { }

	// RVA: 0x104B140 Offset: 0x1049740 VA: 0x18104B140 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x104AF90 Offset: 0x1049590 VA: 0x18104AF90 Slot: 4
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x104B0C0 Offset: 0x10496C0 VA: 0x18104B0C0 Slot: 7
	public IEnumerator GetEnumerator() { }

}

internal class XmlSchemaObjectTable.XSOEnumerator : IEnumerator // TypeDefIndex: 2370
{	// Fields
	private List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x10
	private XmlSchemaObjectTable.EnumeratorType enumType; // 0x18
	protected int currentIndex; // 0x1C
	protected int size; // 0x20
	protected XmlQualifiedName currentKey; // 0x28
	protected XmlSchemaObject currentValue; // 0x30

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x104B190 Offset: 0x1049790 VA: 0x18104B190
	internal void .ctor(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, XmlSchemaObjectTable.EnumeratorType enumType) { }

	// RVA: 0x104B790 Offset: 0x1049D90 VA: 0x18104B790 Slot: 5
	public object get_Current() { }

	// RVA: 0x104B650 Offset: 0x1049C50 VA: 0x18104B650 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x104B750 Offset: 0x1049D50 VA: 0x18104B750 Slot: 6
	public void Reset() { }

}

internal class XmlSchemaObjectTable.XSODictionaryEnumerator : XmlSchemaObjectTable.XSOEnumerator, IDictionaryEnumerator, IEnumerator // TypeDefIndex: 2371
{	// Properties
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x104B190 Offset: 0x1049790 VA: 0x18104B190
	internal void .ctor(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, XmlSchemaObjectTable.EnumeratorType enumType) { }

	// RVA: 0x104B1F0 Offset: 0x10497F0 VA: 0x18104B1F0 Slot: 9
	public DictionaryEntry get_Entry() { }

	// RVA: 0x104B370 Offset: 0x1049970 VA: 0x18104B370 Slot: 7
	public object get_Key() { }

	// RVA: 0x104B4E0 Offset: 0x1049AE0 VA: 0x18104B4E0 Slot: 8
	public object get_Value() { }

}

public abstract class XmlSchemaParticle : XmlSchemaAnnotated // TypeDefIndex: 2372
{	// Fields
	private Decimal minOccurs; // 0x50
	private Decimal maxOccurs; // 0x60
	private XmlSchemaParticle.Occurs flags; // 0x70
	internal static readonly XmlSchemaParticle Empty; // 0x0

	// Properties
	[XmlAttributeAttribute] // RVA: 0x96E60 Offset: 0x96260 VA: 0x180096E60
	public string MinOccursString { get; set; }
	[XmlAttributeAttribute] // RVA: 0x96ED0 Offset: 0x962D0 VA: 0x180096ED0
	public string MaxOccursString { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Decimal MinOccurs { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Decimal MaxOccurs { get; set; }
	internal virtual bool IsEmpty { get; }
	internal virtual string NameString { get; }

	// Methods

	// RVA: 0x105EA50 Offset: 0x105D050 VA: 0x18105EA50
	public string get_MinOccursString() { }

	// RVA: 0x105EF00 Offset: 0x105D500 VA: 0x18105EF00
	public void set_MinOccursString(string value) { }

	// RVA: 0x105E940 Offset: 0x105CF40 VA: 0x18105E940
	public string get_MaxOccursString() { }

	// RVA: 0x105EB20 Offset: 0x105D120 VA: 0x18105EB20
	public void set_MaxOccursString(string value) { }

	// RVA: 0x105EAD0 Offset: 0x105D0D0 VA: 0x18105EAD0
	public Decimal get_MinOccurs() { }

	// RVA: 0x105F070 Offset: 0x105D670 VA: 0x18105F070
	public void set_MinOccurs(Decimal value) { }

	// RVA: 0xC325D0 Offset: 0xC30BD0 VA: 0x180C325D0
	public Decimal get_MaxOccurs() { }

	// RVA: 0x105ED50 Offset: 0x105D350 VA: 0x18105ED50
	public void set_MaxOccurs(Decimal value) { }

	// RVA: 0x105E8B0 Offset: 0x105CEB0 VA: 0x18105E8B0 Slot: 14
	internal virtual bool get_IsEmpty() { }

	// RVA: 0x105EAE0 Offset: 0x105D0E0 VA: 0x18105EAE0 Slot: 15
	internal virtual string get_NameString() { }

	// RVA: 0x105E610 Offset: 0x105CC10 VA: 0x18105E610
	internal XmlQualifiedName GetQualifiedName() { }

	// RVA: 0x105E830 Offset: 0x105CE30 VA: 0x18105E830
	protected void .ctor() { }

	// RVA: 0x105E790 Offset: 0x105CD90 VA: 0x18105E790
	private static void .cctor() { }

}

private enum XmlSchemaParticle.Occurs // TypeDefIndex: 2373
{	// Fields
	public int value__; // 0x0
	public const XmlSchemaParticle.Occurs None = 0;
	public const XmlSchemaParticle.Occurs Min = 1;
	public const XmlSchemaParticle.Occurs Max = 2;

}

private class XmlSchemaParticle.EmptyParticle : XmlSchemaParticle // TypeDefIndex: 2374
{	// Properties
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x104AF30 Offset: 0x1049530 VA: 0x18104AF30
	public void .ctor() { }

}

public class XmlSchemaRedefine : XmlSchemaExternal // TypeDefIndex: 2375
{	// Fields
	private XmlSchemaObjectCollection items; // 0x68
	private XmlSchemaObjectTable attributeGroups; // 0x70
	private XmlSchemaObjectTable types; // 0x78
	private XmlSchemaObjectTable groups; // 0x80

	// Properties
	[XmlElementAttribute] // RVA: 0x97310 Offset: 0x96710 VA: 0x180097310
	[XmlElementAttribute] // RVA: 0x97310 Offset: 0x96710 VA: 0x180097310
	[XmlElementAttribute] // RVA: 0x97310 Offset: 0x96710 VA: 0x180097310
	[XmlElementAttribute] // RVA: 0x97310 Offset: 0x96710 VA: 0x180097310
	[XmlElementAttribute] // RVA: 0x97310 Offset: 0x96710 VA: 0x180097310
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaObjectTable AttributeGroups { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaObjectTable SchemaTypes { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaObjectTable Groups { get; }

	// Methods

	// RVA: 0x105F1F0 Offset: 0x105D7F0 VA: 0x18105F1F0
	public void .ctor() { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x4E84B0 Offset: 0x4E6AB0 VA: 0x1804E84B0
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x105F1D0 Offset: 0x105D7D0 VA: 0x18105F1D0 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

}

public class XmlSchemaSequence : XmlSchemaGroupBase // TypeDefIndex: 2376
{	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Properties
	[XmlElementAttribute] // RVA: 0x97AC0 Offset: 0x96EC0 VA: 0x180097AC0
	[XmlElementAttribute] // RVA: 0x97AC0 Offset: 0x96EC0 VA: 0x180097AC0
	[XmlElementAttribute] // RVA: 0x97AC0 Offset: 0x96EC0 VA: 0x180097AC0
	[XmlElementAttribute] // RVA: 0x97AC0 Offset: 0x96EC0 VA: 0x180097AC0
	[XmlElementAttribute] // RVA: 0x97AC0 Offset: 0x96EC0 VA: 0x180097AC0
	public override XmlSchemaObjectCollection Items { get; }
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x4E84B0 Offset: 0x4E6AB0 VA: 0x1804E84B0 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x104BA10 Offset: 0x104A010 VA: 0x18104BA10 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x4E87D0 Offset: 0x4E6DD0 VA: 0x1804E87D0 Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x105F2E0 Offset: 0x105D8E0 VA: 0x18105F2E0
	public void .ctor() { }

}

public class XmlSchemaSet // TypeDefIndex: 2377
{	// Fields
	private XmlNameTable nameTable; // 0x10
	private SchemaNames schemaNames; // 0x18
	private SortedList schemas; // 0x20
	private ValidationEventHandler internalEventHandler; // 0x28
	private ValidationEventHandler eventHandler; // 0x30
	private bool isCompiled; // 0x38
	private Hashtable schemaLocations; // 0x40
	private Hashtable chameleonSchemas; // 0x48
	private Hashtable targetNamespaces; // 0x50
	private bool compileAll; // 0x58
	private SchemaInfo cachedCompiledInfo; // 0x60
	private XmlReaderSettings readerSettings; // 0x68
	private XmlSchema schemaForSchema; // 0x70
	private XmlSchemaCompilationSettings compilationSettings; // 0x78
	internal XmlSchemaObjectTable elements; // 0x80
	internal XmlSchemaObjectTable attributes; // 0x88
	internal XmlSchemaObjectTable schemaTypes; // 0x90
	internal XmlSchemaObjectTable substitutionGroups; // 0x98
	private XmlSchemaObjectTable typeExtensions; // 0xA0
	private object internalSyncObject; // 0xA8

	// Properties
	internal object InternalSyncObject { get; }
	public bool IsCompiled { get; }
	public XmlResolver XmlResolver { set; }
	public XmlSchemaCompilationSettings CompilationSettings { get; set; }
	public int Count { get; }
	public XmlSchemaObjectTable GlobalElements { get; }
	public XmlSchemaObjectTable GlobalAttributes { get; }
	public XmlSchemaObjectTable GlobalTypes { get; }
	internal XmlSchemaObjectTable SubstitutionGroups { get; }
	internal Hashtable SchemaLocations { get; }
	internal XmlSchemaObjectTable TypeExtensions { get; }
	internal SchemaInfo CompiledInfo { get; }
	internal XmlReaderSettings ReaderSettings { get; }
	internal SortedList SortedSchemas { get; }

	// Methods

	// RVA: 0x10680E0 Offset: 0x10666E0 VA: 0x1810680E0
	internal object get_InternalSyncObject() { }

	// RVA: 0x1067B50 Offset: 0x1066150 VA: 0x181067B50
	public void .ctor() { }

	// RVA: 0x1067BB0 Offset: 0x10661B0 VA: 0x181067BB0
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x1067E40 Offset: 0x1066440 VA: 0x181067E40
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x1068260 Offset: 0x1066860 VA: 0x181068260
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x8C1660 Offset: 0x8BFC60 VA: 0x1808C1660
	public bool get_IsCompiled() { }

	// RVA: 0x1068300 Offset: 0x1066900 VA: 0x181068300
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x4E84B0 Offset: 0x4E6AB0 VA: 0x1804E84B0
	public XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x4E87D0 Offset: 0x4E6DD0 VA: 0x1804E87D0
	public void set_CompilationSettings(XmlSchemaCompilationSettings value) { }

	// RVA: 0x1067F30 Offset: 0x1066530 VA: 0x181067F30
	public int get_Count() { }

	// RVA: 0x1067FE0 Offset: 0x10665E0 VA: 0x181067FE0
	public XmlSchemaObjectTable get_GlobalElements() { }

	// RVA: 0x1067F60 Offset: 0x1066560 VA: 0x181067F60
	public XmlSchemaObjectTable get_GlobalAttributes() { }

	// RVA: 0x1068060 Offset: 0x1066660 VA: 0x181068060
	public XmlSchemaObjectTable get_GlobalTypes() { }

	// RVA: 0x1068160 Offset: 0x1066760 VA: 0x181068160
	internal XmlSchemaObjectTable get_SubstitutionGroups() { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	internal Hashtable get_SchemaLocations() { }

	// RVA: 0x10681E0 Offset: 0x10667E0 VA: 0x1810681E0
	internal XmlSchemaObjectTable get_TypeExtensions() { }

	// RVA: 0x105FB20 Offset: 0x105E120 VA: 0x18105FB20
	public void Add(XmlSchemaSet schemas) { }

	// RVA: 0x10606B0 Offset: 0x105ECB0 VA: 0x1810606B0
	public XmlSchema Add(XmlSchema schema) { }

	// RVA: 0x10652B0 Offset: 0x10638B0 VA: 0x1810652B0
	public bool RemoveRecursive(XmlSchema schemaToRemove) { }

	// RVA: 0x1061430 Offset: 0x105FA30 VA: 0x181061430
	public bool Contains(string targetNamespace) { }

	// RVA: 0x1060EF0 Offset: 0x105F4F0 VA: 0x181060EF0
	public void Compile() { }

	// RVA: 0x1066CB0 Offset: 0x10652B0 VA: 0x181066CB0
	public XmlSchema Reprocess(XmlSchema schema) { }

	// RVA: 0x10632E0 Offset: 0x10618E0 VA: 0x1810632E0
	public void CopyTo(XmlSchema[] schemas, int index) { }

	// RVA: 0x1067940 Offset: 0x1065F40 VA: 0x181067940
	public ICollection Schemas() { }

	// RVA: 0x1067790 Offset: 0x1065D90 VA: 0x181067790
	public ICollection Schemas(string targetNamespace) { }

	// RVA: 0x1060650 Offset: 0x105EC50 VA: 0x181060650
	private XmlSchema Add(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x1060870 Offset: 0x105EE70 VA: 0x181060870
	internal void Add(string targetNamespace, XmlReader reader, Hashtable validatedNamespaces) { }

	// RVA: 0x1063450 Offset: 0x1061A50 VA: 0x181063450
	internal XmlSchema FindSchemaByNSAndUrl(Uri schemaUri, string ns, DictionaryEntry[] locationsTable) { }

	// RVA: 0x105F380 Offset: 0x105D980 VA: 0x18105F380
	private void AddSchemaToSet(XmlSchema schema) { }

	// RVA: 0x1064850 Offset: 0x1062E50 VA: 0x181064850
	private void ProcessNewSubstitutionGroups(XmlSchemaObjectTable substitutionGroupsTable, bool resolve) { }

	// RVA: 0x10673E0 Offset: 0x10659E0 VA: 0x1810673E0
	private void ResolveSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup, XmlSchemaObjectTable substTable) { }

	// RVA: 0x10669A0 Offset: 0x1064FA0 VA: 0x1810669A0
	internal XmlSchema Remove(XmlSchema schema, bool forceCompile) { }

	// RVA: 0x1060CA0 Offset: 0x105F2A0 VA: 0x181060CA0
	private void ClearTables() { }

	// RVA: 0x1064700 Offset: 0x1062D00 VA: 0x181064700
	internal bool PreprocessSchema(ref XmlSchema schema, string targetNamespace) { }

	// RVA: 0x10645E0 Offset: 0x1062BE0 VA: 0x1810645E0
	internal XmlSchema ParseSchema(string targetNamespace, XmlReader reader) { }

	// RVA: 0x10614B0 Offset: 0x105FAB0 VA: 0x1810614B0
	internal void CopyFromCompiledSet(XmlSchemaSet otherSet) { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	internal SchemaInfo get_CompiledInfo() { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	internal XmlReaderSettings get_ReaderSettings() { }

	// RVA: 0x1063750 Offset: 0x1061D50 VA: 0x181063750
	internal XmlResolver GetResolver() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0x1063900 Offset: 0x1061F00 VA: 0x181063900
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x1063A60 Offset: 0x1062060 VA: 0x181063A60
	internal bool IsSchemaLoaded(Uri schemaUri, string targetNamespace, out XmlSchema schema) { }

	// RVA: 0x1063770 Offset: 0x1061D70 VA: 0x181063770
	internal bool GetSchemaByUri(Uri schemaUri, out XmlSchema schema) { }

	// RVA: 0x10639B0 Offset: 0x1061FB0 VA: 0x1810639B0
	internal string GetTargetNamespace(XmlSchema schema) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal SortedList get_SortedSchemas() { }

	// RVA: 0x1065AF0 Offset: 0x10640F0 VA: 0x181065AF0
	private void RemoveSchemaFromCaches(XmlSchema schema) { }

	// RVA: 0x1065F50 Offset: 0x1064550 VA: 0x181065F50
	private void RemoveSchemaFromGlobalTables(XmlSchema schema) { }

	// RVA: 0x105F790 Offset: 0x105DD90 VA: 0x18105F790
	private bool AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x1067A20 Offset: 0x1066020 VA: 0x181067A20
	private void VerifyTables() { }

	// RVA: 0x1063A00 Offset: 0x1062000 VA: 0x181063A00
	private void InternalValidationCallback(object sender, ValidationEventArgs e) { }

	// RVA: 0x1067970 Offset: 0x1065F70 VA: 0x181067970
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

}

public class XmlSchemaSimpleContent : XmlSchemaContentModel // TypeDefIndex: 2378
{	// Fields
	private XmlSchemaContent content; // 0x50

	// Properties
	[XmlElementAttribute] // RVA: 0x97E40 Offset: 0x97240 VA: 0x180097E40
	[XmlElementAttribute] // RVA: 0x97E40 Offset: 0x97240 VA: 0x180097E40
	public override XmlSchemaContent Content { get; set; }

	// Methods

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800 Slot: 14
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820 Slot: 15
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

}

public class XmlSchemaSimpleContentExtension : XmlSchemaContent // TypeDefIndex: 2379
{	// Fields
	private XmlSchemaObjectCollection attributes; // 0x50
	private XmlSchemaAnyAttribute anyAttribute; // 0x58
	private XmlQualifiedName baseTypeName; // 0x60

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8F490 Offset: 0x8E890 VA: 0x18008F490
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x98230 Offset: 0x97630 VA: 0x180098230
	[XmlElementAttribute] // RVA: 0x98230 Offset: 0x97630 VA: 0x180098230
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] // RVA: 0x8E5E0 Offset: 0x8D9E0 VA: 0x18008E5E0
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0xD26CC0 Offset: 0xD252C0 VA: 0x180D26CC0
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0xD26C10 Offset: 0xD25210 VA: 0x180D26C10
	public void .ctor() { }

}

public class XmlSchemaSimpleContentRestriction : XmlSchemaContent // TypeDefIndex: 2380
{	// Fields
	private XmlQualifiedName baseTypeName; // 0x50
	private XmlSchemaSimpleType baseType; // 0x58
	private XmlSchemaObjectCollection facets; // 0x60
	private XmlSchemaObjectCollection attributes; // 0x68
	private XmlSchemaAnyAttribute anyAttribute; // 0x70

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8F490 Offset: 0x8E890 VA: 0x18008F490
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x984D0 Offset: 0x978D0 VA: 0x1800984D0
	public XmlSchemaSimpleType BaseType { get; set; }
	[XmlElementAttribute] // RVA: 0x98670 Offset: 0x97A70 VA: 0x180098670
	[XmlElementAttribute] // RVA: 0x98670 Offset: 0x97A70 VA: 0x180098670
	[XmlElementAttribute] // RVA: 0x98670 Offset: 0x97A70 VA: 0x180098670
	[XmlElementAttribute] // RVA: 0x98670 Offset: 0x97A70 VA: 0x180098670
	[XmlElementAttribute] // RVA: 0x98670 Offset: 0x97A70 VA: 0x180098670
	[XmlElementAttribute] // RVA: 0x98670 Offset: 0x97A70 VA: 0x180098670
	[XmlElementAttribute] // RVA: 0x98670 Offset: 0x97A70 VA: 0x180098670
	[XmlElementAttribute] // RVA: 0x98670 Offset: 0x97A70 VA: 0x180098670
	[XmlElementAttribute] // RVA: 0x98670 Offset: 0x97A70 VA: 0x180098670
	[XmlElementAttribute] // RVA: 0x98670 Offset: 0x97A70 VA: 0x180098670
	[XmlElementAttribute] // RVA: 0x98670 Offset: 0x97A70 VA: 0x180098670
	[XmlElementAttribute] // RVA: 0x98670 Offset: 0x97A70 VA: 0x180098670
	public XmlSchemaObjectCollection Facets { get; }
	[XmlElementAttribute] // RVA: 0x98FF0 Offset: 0x983F0 VA: 0x180098FF0
	[XmlElementAttribute] // RVA: 0x98FF0 Offset: 0x983F0 VA: 0x180098FF0
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] // RVA: 0x8E5E0 Offset: 0x8D9E0 VA: 0x18008E5E0
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0xD26E50 Offset: 0xD25450 VA: 0x180D26E50
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810
	public void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x519DE0 Offset: 0x5183E0 VA: 0x180519DE0
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0xD26D80 Offset: 0xD25380 VA: 0x180D26D80
	public void .ctor() { }

}

public class XmlSchemaSimpleType : XmlSchemaType // TypeDefIndex: 2381
{	// Fields
	private XmlSchemaSimpleTypeContent content; // 0x98

	// Properties
	[XmlElementAttribute] // RVA: 0x99530 Offset: 0x98930 VA: 0x180099530
	[XmlElementAttribute] // RVA: 0x99530 Offset: 0x98930 VA: 0x180099530
	[XmlElementAttribute] // RVA: 0x99530 Offset: 0x98930 VA: 0x180099530
	public XmlSchemaSimpleTypeContent Content { get; set; }

	// Methods

	// RVA: 0xD276D0 Offset: 0xD25CD0 VA: 0x180D276D0
	public void .ctor() { }

	// RVA: 0x574310 Offset: 0x572910 VA: 0x180574310
	public XmlSchemaSimpleTypeContent get_Content() { }

	// RVA: 0x5743A0 Offset: 0x5729A0 VA: 0x1805743A0
	public void set_Content(XmlSchemaSimpleTypeContent value) { }

	// RVA: 0xD275A0 Offset: 0xD25BA0 VA: 0x180D275A0 Slot: 13
	internal override XmlSchemaObject Clone() { }

}

public abstract class XmlSchemaSimpleTypeContent : XmlSchemaAnnotated // TypeDefIndex: 2382
{	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	protected void .ctor() { }

}

public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent // TypeDefIndex: 2383
{	// Fields
	private XmlQualifiedName itemTypeName; // 0x50
	private XmlSchemaSimpleType itemType; // 0x58
	private XmlSchemaSimpleType baseItemType; // 0x60

	// Properties
	[XmlAttributeAttribute] // RVA: 0x998C0 Offset: 0x98CC0 VA: 0x1800998C0
	public XmlQualifiedName ItemTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x99CC0 Offset: 0x990C0 VA: 0x180099CC0
	public XmlSchemaSimpleType ItemType { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaSimpleType BaseItemType { get; set; }

	// Methods

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public XmlQualifiedName get_ItemTypeName() { }

	// RVA: 0xD27050 Offset: 0xD25650 VA: 0x180D27050
	public void set_ItemTypeName(XmlQualifiedName value) { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public XmlSchemaSimpleType get_ItemType() { }

	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810
	public void set_ItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public XmlSchemaSimpleType get_BaseItemType() { }

	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0
	public void set_BaseItemType(XmlSchemaSimpleType value) { }

	// RVA: 0xD26F10 Offset: 0xD25510 VA: 0x180D26F10 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0xD26FD0 Offset: 0xD255D0 VA: 0x180D26FD0
	public void .ctor() { }

}

public class XmlSchemaSimpleTypeRestriction : XmlSchemaSimpleTypeContent // TypeDefIndex: 2384
{	// Fields
	private XmlQualifiedName baseTypeName; // 0x50
	private XmlSchemaSimpleType baseType; // 0x58
	private XmlSchemaObjectCollection facets; // 0x60

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8F490 Offset: 0x8E890 VA: 0x18008F490
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x9A090 Offset: 0x99490 VA: 0x18009A090
	public XmlSchemaSimpleType BaseType { get; set; }
	[XmlElementAttribute] // RVA: 0x9A2A0 Offset: 0x996A0 VA: 0x18009A2A0
	[XmlElementAttribute] // RVA: 0x9A2A0 Offset: 0x996A0 VA: 0x18009A2A0
	[XmlElementAttribute] // RVA: 0x9A2A0 Offset: 0x996A0 VA: 0x18009A2A0
	[XmlElementAttribute] // RVA: 0x9A2A0 Offset: 0x996A0 VA: 0x18009A2A0
	[XmlElementAttribute] // RVA: 0x9A2A0 Offset: 0x996A0 VA: 0x18009A2A0
	[XmlElementAttribute] // RVA: 0x9A2A0 Offset: 0x996A0 VA: 0x18009A2A0
	[XmlElementAttribute] // RVA: 0x9A2A0 Offset: 0x996A0 VA: 0x18009A2A0
	[XmlElementAttribute] // RVA: 0x9A2A0 Offset: 0x996A0 VA: 0x18009A2A0
	[XmlElementAttribute] // RVA: 0x9A2A0 Offset: 0x996A0 VA: 0x18009A2A0
	[XmlElementAttribute] // RVA: 0x9A2A0 Offset: 0x996A0 VA: 0x18009A2A0
	[XmlElementAttribute] // RVA: 0x9A2A0 Offset: 0x996A0 VA: 0x18009A2A0
	[XmlElementAttribute] // RVA: 0x9A2A0 Offset: 0x996A0 VA: 0x18009A2A0
	public XmlSchemaObjectCollection Facets { get; }

	// Methods

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0xD27280 Offset: 0xD25880 VA: 0x180D27280
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810
	public void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0xD27110 Offset: 0xD25710 VA: 0x180D27110 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0xD271D0 Offset: 0xD257D0 VA: 0x180D271D0
	public void .ctor() { }

}

public class XmlSchemaSimpleTypeUnion : XmlSchemaSimpleTypeContent // TypeDefIndex: 2385
{	// Fields
	private XmlSchemaObjectCollection baseTypes; // 0x50
	private XmlQualifiedName[] memberTypes; // 0x58
	private XmlSchemaSimpleType[] baseMemberTypes; // 0x60

	// Properties
	[XmlElementAttribute] // RVA: 0x9AA10 Offset: 0x99E10 VA: 0x18009AA10
	public XmlSchemaObjectCollection BaseTypes { get; }
	[XmlAttributeAttribute] // RVA: 0x9ACA0 Offset: 0x9A0A0 VA: 0x18009ACA0
	public XmlQualifiedName[] MemberTypes { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaSimpleType[] BaseMemberTypes { get; }

	// Methods

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public XmlSchemaObjectCollection get_BaseTypes() { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public XmlQualifiedName[] get_MemberTypes() { }

	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810
	public void set_MemberTypes(XmlQualifiedName[] value) { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0
	internal void SetBaseMemberTypes(XmlSchemaSimpleType[] baseMemberTypes) { }

	// RVA: 0xD27340 Offset: 0xD25940 VA: 0x180D27340 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0xD27530 Offset: 0xD25B30 VA: 0x180D27530
	public void .ctor() { }

}

internal class XmlSchemaSubstitutionGroup : XmlSchemaObject // TypeDefIndex: 2386
{	// Fields
	private ArrayList membersList; // 0x38
	private XmlQualifiedName examplar; // 0x40

	// Properties
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal ArrayList Members { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal XmlQualifiedName Examplar { get; set; }

	// Methods

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	internal ArrayList get_Members() { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	internal XmlQualifiedName get_Examplar() { }

	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	internal void set_Examplar(XmlQualifiedName value) { }

	// RVA: 0xD27850 Offset: 0xD25E50 VA: 0x180D27850
	public void .ctor() { }

}

internal class XmlSchemaSubstitutionGroupV1Compat : XmlSchemaSubstitutionGroup // TypeDefIndex: 2387
{	// Fields
	private XmlSchemaChoice choice; // 0x48

	// Properties
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal XmlSchemaChoice Choice { get; }

	// Methods

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	internal XmlSchemaChoice get_Choice() { }

	// RVA: 0xD27760 Offset: 0xD25D60 VA: 0x180D27760
	public void .ctor() { }

}

public class XmlSchemaType : XmlSchemaAnnotated // TypeDefIndex: 2388
{	// Fields
	private string name; // 0x50
	private XmlSchemaDerivationMethod final; // 0x58
	private XmlSchemaDerivationMethod derivedBy; // 0x5C
	private XmlSchemaType baseSchemaType; // 0x60
	private XmlSchemaDatatype datatype; // 0x68
	private XmlSchemaDerivationMethod finalResolved; // 0x70
	private SchemaElementDecl elementDecl; // 0x78
	private XmlQualifiedName qname; // 0x80
	private XmlSchemaType redefined; // 0x88
	private XmlSchemaContentType contentType; // 0x90

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8D970 Offset: 0x8CD70 VA: 0x18008D970
	public string Name { get; set; }
	[XmlAttributeAttribute] // RVA: 0x9B150 Offset: 0x9A550 VA: 0x18009B150
	[DefaultValueAttribute] // RVA: 0x9B150 Offset: 0x9A550 VA: 0x18009B150
	public XmlSchemaDerivationMethod Final { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaDerivationMethod FinalResolved { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaType BaseXmlSchemaType { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaDerivationMethod DerivedBy { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlSchemaDatatype Datatype { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public virtual bool IsMixed { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public XmlTypeCode TypeCode { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal XmlValueConverter ValueConverter { get; }
	internal XmlSchemaContentType SchemaContentType { get; }
	internal SchemaElementDecl ElementDecl { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal XmlSchemaType Redefined { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0xD27B70 Offset: 0xD26170 VA: 0x180D27B70
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlQualifiedName qualifiedName) { }

	// RVA: 0xD27B20 Offset: 0xD26120 VA: 0x180D27B20
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode) { }

	// RVA: 0xD27920 Offset: 0xD25F20 VA: 0x180D27920
	public static XmlSchemaComplexType GetBuiltInComplexType(XmlQualifiedName qualifiedName) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public string get_Name() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	public void set_Name(string value) { }

	// RVA: 0xAE9F70 Offset: 0xAE8570 VA: 0x180AE9F70
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0xD280D0 Offset: 0xD266D0 VA: 0x180D280D0
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0xD27F20 Offset: 0xD26520 VA: 0x180D27F20
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x804110 Offset: 0x802710 VA: 0x180804110
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public XmlSchemaType get_BaseXmlSchemaType() { }

	// RVA: 0x574330 Offset: 0x572930 VA: 0x180574330
	public XmlSchemaDerivationMethod get_DerivedBy() { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 14
	public virtual bool get_IsMixed() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 15
	public virtual void set_IsMixed(bool value) { }

	// RVA: 0xD27F50 Offset: 0xD26550 VA: 0x180D27F50
	public XmlTypeCode get_TypeCode() { }

	// RVA: 0xD28020 Offset: 0xD26620 VA: 0x180D28020
	internal XmlValueConverter get_ValueConverter() { }

	// RVA: 0xD27F40 Offset: 0xD26540 VA: 0x180D27F40
	internal XmlSchemaContentType get_SchemaContentType() { }

	// RVA: 0xD27EC0 Offset: 0xD264C0 VA: 0x180D27EC0
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x804140 Offset: 0x802740 VA: 0x180804140
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0
	internal void SetBaseSchemaType(XmlSchemaType value) { }

	// RVA: 0x5743C0 Offset: 0x5729C0 VA: 0x1805743C0
	internal void SetDerivedBy(XmlSchemaDerivationMethod value) { }

	// RVA: 0x519DE0 Offset: 0x5183E0 VA: 0x180519DE0
	internal void SetDatatype(XmlSchemaDatatype value) { }

	// RVA: 0xD27F00 Offset: 0xD26500 VA: 0x180D27F00
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0xD280A0 Offset: 0xD266A0 VA: 0x180D280A0
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x574300 Offset: 0x572900 VA: 0x180574300
	internal XmlSchemaType get_Redefined() { }

	// RVA: 0x574390 Offset: 0x572990 VA: 0x180574390
	internal void set_Redefined(XmlSchemaType value) { }

	// RVA: 0xD27EB0 Offset: 0xD264B0 VA: 0x180D27EB0
	internal void SetContentType(XmlSchemaContentType value) { }

	// RVA: 0xD27D20 Offset: 0xD26320 VA: 0x180D27D20
	public static bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except) { }

	// RVA: 0xD27C30 Offset: 0xD26230 VA: 0x180D27C30
	internal static bool IsDerivedFromDatatype(XmlSchemaDatatype derivedDataType, XmlSchemaDatatype baseDataType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0xD276D0 Offset: 0xD25CD0 VA: 0x180D276D0
	public void .ctor() { }

}

public enum XmlSchemaUse // TypeDefIndex: 2389
{	// Fields
	public int value__; // 0x0
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public const XmlSchemaUse None = 0;
	[XmlEnumAttribute] // RVA: 0x9CE80 Offset: 0x9C280 VA: 0x18009CE80
	public const XmlSchemaUse Optional = 1;
	[XmlEnumAttribute] // RVA: 0x9D010 Offset: 0x9C410 VA: 0x18009D010
	public const XmlSchemaUse Prohibited = 2;
	[XmlEnumAttribute] // RVA: 0x9D140 Offset: 0x9C540 VA: 0x18009D140
	public const XmlSchemaUse Required = 3;

}

public class XmlSchemaValidationException : XmlSchemaException // TypeDefIndex: 2390
{	// Methods

	// RVA: 0xD28150 Offset: 0xD26750 VA: 0x180D28150
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xD280F0 Offset: 0xD266F0 VA: 0x180D280F0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xD28170 Offset: 0xD26770 VA: 0x180D28170
	public void .ctor() { }

	// RVA: 0xD28180 Offset: 0xD26780 VA: 0x180D28180
	internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0xD28290 Offset: 0xD26890 VA: 0x180D28290
	internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0xD28110 Offset: 0xD26710 VA: 0x180D28110
	internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition) { }

}

public sealed class XmlValueGetter : MulticastDelegate // TypeDefIndex: 2391
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xD3DB90 Offset: 0xD3C190 VA: 0x180D3DB90 Slot: 12
	public virtual object Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual object EndInvoke(IAsyncResult result) { }

}

public enum XmlSchemaValidationFlags // TypeDefIndex: 2392
{	// Fields
	public int value__; // 0x0
	public const XmlSchemaValidationFlags None = 0;
	public const XmlSchemaValidationFlags ProcessInlineSchema = 1;
	public const XmlSchemaValidationFlags ProcessSchemaLocation = 2;
	public const XmlSchemaValidationFlags ReportValidationWarnings = 4;
	public const XmlSchemaValidationFlags ProcessIdentityConstraints = 8;
	public const XmlSchemaValidationFlags AllowXmlAttributes = 16;

}

public sealed class XmlSchemaValidator // TypeDefIndex: 2395
{	// Fields
	private XmlSchemaSet schemaSet; // 0x10
	private XmlSchemaValidationFlags validationFlags; // 0x18
	private int startIDConstraint; // 0x1C
	private bool isRoot; // 0x20
	private bool rootHasSchema; // 0x21
	private bool attrValid; // 0x22
	private bool checkEntity; // 0x23
	private SchemaInfo compiledSchemaInfo; // 0x28
	private IDtdInfo dtdSchemaInfo; // 0x30
	private Hashtable validatedNamespaces; // 0x38
	private HWStack validationStack; // 0x40
	private ValidationState context; // 0x48
	private ValidatorState currentState; // 0x50
	private Hashtable attPresence; // 0x58
	private SchemaAttDef wildID; // 0x60
	private Hashtable IDs; // 0x68
	private IdRefNode idRefListHead; // 0x70
	private XmlQualifiedName contextQName; // 0x78
	private string NsXs; // 0x80
	private string NsXsi; // 0x88
	private string NsXmlNs; // 0x90
	private string NsXml; // 0x98
	private XmlSchemaObject partialValidationType; // 0xA0
	private StringBuilder textValue; // 0xA8
	private ValidationEventHandler eventHandler; // 0xB0
	private object validationEventSender; // 0xB8
	private XmlNameTable nameTable; // 0xC0
	private IXmlLineInfo positionInfo; // 0xC8
	private IXmlLineInfo dummyPositionInfo; // 0xD0
	private XmlResolver xmlResolver; // 0xD8
	private Uri sourceUri; // 0xE0
	private string sourceUriString; // 0xE8
	private IXmlNamespaceResolver nsResolver; // 0xF0
	private XmlSchemaContentProcessing processContents; // 0xF8
	private string xsiTypeString; // 0x100
	private string xsiNilString; // 0x108
	private string xsiSchemaLocationString; // 0x110
	private string xsiNoNamespaceSchemaLocationString; // 0x118
	private static readonly XmlSchemaDatatype dtQName; // 0x0
	private static readonly XmlSchemaDatatype dtCDATA; // 0x8
	private static readonly XmlSchemaDatatype dtStringArray; // 0x10
	private static XmlSchemaParticle[] EmptyParticleArray; // 0x18
	private static XmlSchemaAttribute[] EmptyAttributeArray; // 0x20
	private XmlCharType xmlCharType; // 0x120
	internal static bool[,] ValidStates; // 0x28
	private static string[] MethodNames; // 0x30

	// Properties
	public XmlResolver XmlResolver { set; }
	public IXmlLineInfo LineInfoProvider { set; }
	public Uri SourceUri { set; }
	public object ValidationEventSender { set; }
	internal XmlSchemaSet SchemaSet { get; }
	internal XmlSchemaValidationFlags ValidationFlags { get; }
	internal XmlSchemaContentType CurrentContentType { get; }
	private bool StrictlyAssessed { get; }
	private bool HasSchema { get; }
	private bool HasIdentityConstraints { get; }
	internal bool ProcessIdentityConstraints { get; }
	internal bool ReportValidationWarnings { get; }
	internal bool ProcessSchemaHints { get; }

	// Methods

	// RVA: 0xD352E0 Offset: 0xD338E0 VA: 0x180D352E0
	public void .ctor(XmlNameTable nameTable, XmlSchemaSet schemas, IXmlNamespaceResolver namespaceResolver, XmlSchemaValidationFlags validationFlags) { }

	// RVA: 0xD2E930 Offset: 0xD2CF30 VA: 0x180D2E930
	private void Init() { }

	// RVA: 0xD314D0 Offset: 0xD2FAD0 VA: 0x180D314D0
	private void Reset() { }

	// RVA: 0xD357D0 Offset: 0xD33DD0 VA: 0x180D357D0
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0xD35750 Offset: 0xD33D50 VA: 0x180D35750
	public void set_LineInfoProvider(IXmlLineInfo value) { }

	// RVA: 0xD35770 Offset: 0xD33D70 VA: 0x180D35770
	public void set_SourceUri(Uri value) { }

	// RVA: 0x79BE50 Offset: 0x79A450 VA: 0x18079BE50
	public void set_ValidationEventSender(object value) { }

	// RVA: 0xD35530 Offset: 0xD33B30 VA: 0x180D35530
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0xD356D0 Offset: 0xD33CD0 VA: 0x180D356D0
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0xD28850 Offset: 0xD26E50 VA: 0x180D28850
	public void AddSchema(XmlSchema schema) { }

	// RVA: 0xD2EF80 Offset: 0xD2D580 VA: 0x180D2EF80
	public void Initialize() { }

	// RVA: 0xD2ECB0 Offset: 0xD2D2B0 VA: 0x180D2ECB0
	public void Initialize(XmlSchemaObject partialValidationType) { }

	// RVA: 0xD33E50 Offset: 0xD32450 VA: 0x180D33E50
	public void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0xD32E80 Offset: 0xD31480 VA: 0x180D32E80
	public object ValidateAttribute(string localName, string namespaceUri, XmlValueGetter attributeValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0xD32F30 Offset: 0xD31530 VA: 0x180D32F30
	private object ValidateAttribute(string lName, string ns, XmlValueGetter attributeValueGetter, string attributeStringValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0xD34340 Offset: 0xD32940 VA: 0x180D34340
	public void ValidateEndOfAttributes(XmlSchemaInfo schemaInfo) { }

	// RVA: 0xD34920 Offset: 0xD32F20 VA: 0x180D34920
	public void ValidateText(XmlValueGetter elementValue) { }

	// RVA: 0xD34480 Offset: 0xD32A80 VA: 0x180D34480
	private void ValidateText(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0xD34C00 Offset: 0xD33200 VA: 0x180D34C00
	public void ValidateWhitespace(XmlValueGetter elementValue) { }

	// RVA: 0xD349A0 Offset: 0xD32FA0 VA: 0x180D349A0
	private void ValidateWhitespace(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0xD34330 Offset: 0xD32930 VA: 0x180D34330
	public object ValidateEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0xD321D0 Offset: 0xD307D0 VA: 0x180D321D0
	public void SkipToEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0xD2D3C0 Offset: 0xD2B9C0 VA: 0x180D2D3C0
	public void EndValidation() { }

	// RVA: 0xD2E2D0 Offset: 0xD2C8D0 VA: 0x180D2E2D0
	internal void GetUnspecifiedDefaultAttributes(ArrayList defaultAttributes, bool createNodeData) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal XmlSchemaSet get_SchemaSet() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	internal XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0xD355B0 Offset: 0xD33BB0 VA: 0x180D355B0
	internal XmlSchemaContentType get_CurrentContentType() { }

	// RVA: 0xD321B0 Offset: 0xD307B0 VA: 0x180D321B0
	internal void SetDtdSchemaInfo(IDtdInfo dtdSchemaInfo) { }

	// RVA: 0xD35690 Offset: 0xD33C90 VA: 0x180D35690
	private bool get_StrictlyAssessed() { }

	// RVA: 0xD35610 Offset: 0xD33C10 VA: 0x180D35610
	private bool get_HasSchema() { }

	// RVA: 0xD2DB40 Offset: 0xD2C140 VA: 0x180D2DB40
	internal string GetConcatenatedValue() { }

	// RVA: 0xD2F100 Offset: 0xD2D700 VA: 0x180D2F100
	private object InternalValidateEndElement(XmlSchemaInfo schemaInfo, object typedValue) { }

	// RVA: 0xD30B20 Offset: 0xD2F120 VA: 0x180D30B20
	private void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0xD33980 Offset: 0xD31F80 VA: 0x180D33980
	private object ValidateElementContext(XmlQualifiedName elementName, out bool invalidElementInContext) { }

	// RVA: 0xD2DF40 Offset: 0xD2C540 VA: 0x180D2DF40
	private XmlSchemaElement GetSubstitutionGroupHead(XmlQualifiedName member) { }

	// RVA: 0xD32640 Offset: 0xD30C40 VA: 0x180D32640
	private object ValidateAtomicValue(string stringValue, out XmlSchemaSimpleType memberType) { }

	// RVA: 0xD32990 Offset: 0xD30F90 VA: 0x180D32990
	private object ValidateAtomicValue(object parsedValue, out XmlSchemaSimpleType memberType) { }

	// RVA: 0xD2E260 Offset: 0xD2C860 VA: 0x180D2E260
	private string GetTypeName(SchemaDeclBase decl) { }

	// RVA: 0xD31580 Offset: 0xD2FB80 VA: 0x180D31580
	private void SaveTextValue(object value) { }

	// RVA: 0xD311E0 Offset: 0xD2F7E0 VA: 0x180D311E0
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0xD2FC30 Offset: 0xD2E230 VA: 0x180D2FC30
	private void Pop() { }

	// RVA: 0xD2D7E0 Offset: 0xD2BDE0 VA: 0x180D2D7E0
	private SchemaElementDecl FastGetElementDecl(XmlQualifiedName elementName, object particle) { }

	// RVA: 0xD2A460 Offset: 0xD28A60 VA: 0x180D2A460
	private SchemaElementDecl CheckXsiTypeAndNil(SchemaElementDecl elementDecl, string xsiType, string xsiNil, ref bool declFound) { }

	// RVA: 0xD32400 Offset: 0xD30A00 VA: 0x180D32400
	private void ThrowDeclNotFoundWarningOrError(bool declFound) { }

	// RVA: 0xD29640 Offset: 0xD27C40 VA: 0x180D29640
	private void CheckElementProperties() { }

	// RVA: 0xD34420 Offset: 0xD32A20 VA: 0x180D34420
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0xD29C40 Offset: 0xD28240 VA: 0x180D29C40
	private SchemaAttDef CheckIsXmlAttribute(XmlQualifiedName attQName) { }

	// RVA: 0xD28CC0 Offset: 0xD272C0 VA: 0x180D28CC0
	private void AddXmlNamespaceSchema() { }

	// RVA: 0xD29D80 Offset: 0xD28380 VA: 0x180D29D80
	internal object CheckMixedValueConstraint(string elementValue) { }

	// RVA: 0xD2F720 Offset: 0xD2DD20 VA: 0x180D2F720
	private void LoadSchema(string uri, string url) { }

	// RVA: 0xD31430 Offset: 0xD2FA30 VA: 0x180D31430
	internal void RecompileSchemaSet() { }

	// RVA: 0xD30F10 Offset: 0xD2F510 VA: 0x180D30F10
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name, bool attrValue) { }

	// RVA: 0xD292B0 Offset: 0xD278B0 VA: 0x180D292B0
	private object CheckAttributeValue(object value, SchemaAttDef attdef) { }

	// RVA: 0xD29720 Offset: 0xD27D20 VA: 0x180D29720
	private object CheckElementValue(string stringValue) { }

	// RVA: 0xD2A2E0 Offset: 0xD288E0 VA: 0x180D2A2E0
	private void CheckTokenizedTypes(XmlSchemaDatatype dtype, object typedValue, bool attrValue) { }

	// RVA: 0xD2DB20 Offset: 0xD2C120 VA: 0x180D2DB20
	private object FindId(string name) { }

	// RVA: 0xD29B20 Offset: 0xD28120 VA: 0x180D29B20
	private void CheckForwardRefs() { }

	// RVA: 0xD355F0 Offset: 0xD33BF0 VA: 0x180D355F0
	private bool get_HasIdentityConstraints() { }

	// RVA: 0xD35660 Offset: 0xD33C60 VA: 0x180D35660
	internal bool get_ProcessIdentityConstraints() { }

	// RVA: 0xD35680 Offset: 0xD33C80 VA: 0x180D35680
	internal bool get_ReportValidationWarnings() { }

	// RVA: 0xD35670 Offset: 0xD33C70 VA: 0x180D35670
	internal bool get_ProcessSchemaHints() { }

	// RVA: 0xD2A030 Offset: 0xD28630 VA: 0x180D2A030
	private void CheckStateTransition(ValidatorState toState, string methodName) { }

	// RVA: 0xD2AC70 Offset: 0xD29270 VA: 0x180D2AC70
	private void ClearPSVI() { }

	// RVA: 0xD29E80 Offset: 0xD28480 VA: 0x180D29E80
	private void CheckRequiredAttributes(SchemaElementDecl currentElementDecl) { }

	// RVA: 0xD2DDE0 Offset: 0xD2C3E0 VA: 0x180D2DDE0
	private XmlSchemaElement GetSchemaElement() { }

	// RVA: 0xD2DB70 Offset: 0xD2C170 VA: 0x180D2DB70
	internal string GetDefaultAttributePrefix(string attributeNS) { }

	// RVA: 0xD282D0 Offset: 0xD268D0 VA: 0x180D282D0
	private void AddIdentityConstraints() { }

	// RVA: 0xD2B470 Offset: 0xD29A70 VA: 0x180D2B470
	private void ElementIdentityConstraints() { }

	// RVA: 0xD28D60 Offset: 0xD27360 VA: 0x180D28D60
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, XmlSchemaDatatype datatype) { }

	// RVA: 0xD2C540 Offset: 0xD2AB40 VA: 0x180D2C540
	private void EndElementIdentityConstraints(object typedValue, string stringValue, XmlSchemaDatatype datatype) { }

	// RVA: 0xD2B820 Offset: 0xD29E20 VA: 0x180D2B820
	internal static void ElementValidationError(XmlQualifiedName name, ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0xD2ACD0 Offset: 0xD292D0 VA: 0x180D2ACD0
	internal static void CompleteValidationError(ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0xD2FD70 Offset: 0xD2E370 VA: 0x180D2FD70
	internal static string PrintExpectedElements(ArrayList expected, bool getParticles) { }

	// RVA: 0xD308A0 Offset: 0xD2EEA0 VA: 0x180D308A0
	private static string PrintNames(ArrayList expected) { }

	// RVA: 0xD302C0 Offset: 0xD2E8C0 VA: 0x180D302C0
	private static void PrintNamesWithNS(ArrayList expected, StringBuilder builder) { }

	// RVA: 0xD2D5D0 Offset: 0xD2BBD0 VA: 0x180D2D5D0
	private static void EnumerateAny(StringBuilder builder, string namespaces) { }

	// RVA: 0xD313C0 Offset: 0xD2F9C0 VA: 0x180D313C0
	internal static string QNameString(string localName, string ns) { }

	// RVA: 0xD29090 Offset: 0xD27690 VA: 0x180D29090
	internal static string BuildElementName(XmlQualifiedName qname) { }

	// RVA: 0xD29110 Offset: 0xD27710 VA: 0x180D29110
	internal static string BuildElementName(string localName, string ns) { }

	// RVA: 0xD30A10 Offset: 0xD2F010 VA: 0x180D30A10
	private void ProcessEntity(string name) { }

	// RVA: 0xD31CF0 Offset: 0xD302F0 VA: 0x180D31CF0
	private void SendValidationEvent(string code) { }

	// RVA: 0xD31ED0 Offset: 0xD304D0 VA: 0x180D31ED0
	private void SendValidationEvent(string code, string[] args) { }

	// RVA: 0xD31AA0 Offset: 0xD300A0 VA: 0x180D31AA0
	private void SendValidationEvent(string code, string arg) { }

	// RVA: 0xD31FE0 Offset: 0xD305E0 VA: 0x180D31FE0
	private void SendValidationEvent(string code, string arg1, string arg2) { }

	// RVA: 0xD31860 Offset: 0xD2FE60 VA: 0x180D31860
	private void SendValidationEvent(string code, string[] args, Exception innerException, XmlSeverityType severity) { }

	// RVA: 0xD31D50 Offset: 0xD30350 VA: 0x180D31D50
	private void SendValidationEvent(string code, string[] args, Exception innerException) { }

	// RVA: 0xD317A0 Offset: 0xD2FDA0 VA: 0x180D317A0
	private void SendValidationEvent(XmlSchemaValidationException e) { }

	// RVA: 0xD31B90 Offset: 0xD30190 VA: 0x180D31B90
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0xD315D0 Offset: 0xD2FBD0 VA: 0x180D315D0
	private void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0xD319A0 Offset: 0xD2FFA0 VA: 0x180D319A0
	private void SendValidationEvent(XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0xD316F0 Offset: 0xD2FCF0 VA: 0x180D316F0
	internal static void SendValidationEvent(ValidationEventHandler eventHandler, object sender, XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0xD34C80 Offset: 0xD33280 VA: 0x180D34C80
	private static void .cctor() { }

}

public enum XmlSchemaValidity // TypeDefIndex: 2396
{	// Fields
	public int value__; // 0x0
	public const XmlSchemaValidity NotKnown = 0;
	public const XmlSchemaValidity Valid = 1;
	public const XmlSchemaValidity Invalid = 2;

}

public enum XmlSeverityType // TypeDefIndex: 2397
{	// Fields
	public int value__; // 0x0
	public const XmlSeverityType Error = 0;
	public const XmlSeverityType Warning = 1;

}

public enum XmlTypeCode // TypeDefIndex: 2398
{	// Fields
	public int value__; // 0x0
	public const XmlTypeCode None = 0;
	public const XmlTypeCode Item = 1;
	public const XmlTypeCode Node = 2;
	public const XmlTypeCode Document = 3;
	public const XmlTypeCode Element = 4;
	public const XmlTypeCode Attribute = 5;
	public const XmlTypeCode Namespace = 6;
	public const XmlTypeCode ProcessingInstruction = 7;
	public const XmlTypeCode Comment = 8;
	public const XmlTypeCode Text = 9;
	public const XmlTypeCode AnyAtomicType = 10;
	public const XmlTypeCode UntypedAtomic = 11;
	public const XmlTypeCode String = 12;
	public const XmlTypeCode Boolean = 13;
	public const XmlTypeCode Decimal = 14;
	public const XmlTypeCode Float = 15;
	public const XmlTypeCode Double = 16;
	public const XmlTypeCode Duration = 17;
	public const XmlTypeCode DateTime = 18;
	public const XmlTypeCode Time = 19;
	public const XmlTypeCode Date = 20;
	public const XmlTypeCode GYearMonth = 21;
	public const XmlTypeCode GYear = 22;
	public const XmlTypeCode GMonthDay = 23;
	public const XmlTypeCode GDay = 24;
	public const XmlTypeCode GMonth = 25;
	public const XmlTypeCode HexBinary = 26;
	public const XmlTypeCode Base64Binary = 27;
	public const XmlTypeCode AnyUri = 28;
	public const XmlTypeCode QName = 29;
	public const XmlTypeCode Notation = 30;
	public const XmlTypeCode NormalizedString = 31;
	public const XmlTypeCode Token = 32;
	public const XmlTypeCode Language = 33;
	public const XmlTypeCode NmToken = 34;
	public const XmlTypeCode Name = 35;
	public const XmlTypeCode NCName = 36;
	public const XmlTypeCode Id = 37;
	public const XmlTypeCode Idref = 38;
	public const XmlTypeCode Entity = 39;
	public const XmlTypeCode Integer = 40;
	public const XmlTypeCode NonPositiveInteger = 41;
	public const XmlTypeCode NegativeInteger = 42;
	public const XmlTypeCode Long = 43;
	public const XmlTypeCode Int = 44;
	public const XmlTypeCode Short = 45;
	public const XmlTypeCode Byte = 46;
	public const XmlTypeCode NonNegativeInteger = 47;
	public const XmlTypeCode UnsignedLong = 48;
	public const XmlTypeCode UnsignedInt = 49;
	public const XmlTypeCode UnsignedShort = 50;
	public const XmlTypeCode UnsignedByte = 51;
	public const XmlTypeCode PositiveInteger = 52;
	public const XmlTypeCode YearMonthDuration = 53;
	public const XmlTypeCode DayTimeDuration = 54;

}

internal abstract class XmlValueConverter // TypeDefIndex: 2399
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool ToBoolean(long value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool ToBoolean(int value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool ToBoolean(double value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool ToBoolean(DateTime value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool ToBoolean(string value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool ToBoolean(object value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int ToInt32(bool value);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int ToInt32(long value);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int ToInt32(double value);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int ToInt32(DateTime value);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int ToInt32(string value);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int ToInt32(object value);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract long ToInt64(bool value);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract long ToInt64(int value);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract long ToInt64(double value);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract long ToInt64(DateTime value);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract long ToInt64(string value);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract long ToInt64(object value);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract Decimal ToDecimal(string value);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract Decimal ToDecimal(object value);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract double ToDouble(bool value);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract double ToDouble(int value);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract double ToDouble(long value);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract double ToDouble(DateTime value);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract double ToDouble(string value);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract double ToDouble(object value);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract float ToSingle(double value);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract float ToSingle(string value);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract float ToSingle(object value);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract DateTime ToDateTime(bool value);

	// RVA: -1 Offset: -1 Slot: 34
	public abstract DateTime ToDateTime(int value);

	// RVA: -1 Offset: -1 Slot: 35
	public abstract DateTime ToDateTime(long value);

	// RVA: -1 Offset: -1 Slot: 36
	public abstract DateTime ToDateTime(double value);

	// RVA: -1 Offset: -1 Slot: 37
	public abstract DateTime ToDateTime(DateTimeOffset value);

	// RVA: -1 Offset: -1 Slot: 38
	public abstract DateTime ToDateTime(string value);

	// RVA: -1 Offset: -1 Slot: 39
	public abstract DateTime ToDateTime(object value);

	// RVA: -1 Offset: -1 Slot: 40
	public abstract DateTimeOffset ToDateTimeOffset(DateTime value);

	// RVA: -1 Offset: -1 Slot: 41
	public abstract DateTimeOffset ToDateTimeOffset(string value);

	// RVA: -1 Offset: -1 Slot: 42
	public abstract DateTimeOffset ToDateTimeOffset(object value);

	// RVA: -1 Offset: -1 Slot: 43
	public abstract string ToString(bool value);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract string ToString(int value);

	// RVA: -1 Offset: -1 Slot: 45
	public abstract string ToString(long value);

	// RVA: -1 Offset: -1 Slot: 46
	public abstract string ToString(Decimal value);

	// RVA: -1 Offset: -1 Slot: 47
	public abstract string ToString(float value);

	// RVA: -1 Offset: -1 Slot: 48
	public abstract string ToString(double value);

	// RVA: -1 Offset: -1 Slot: 49
	public abstract string ToString(DateTime value);

	// RVA: -1 Offset: -1 Slot: 50
	public abstract string ToString(DateTimeOffset value);

	// RVA: -1 Offset: -1 Slot: 51
	public abstract string ToString(object value);

	// RVA: -1 Offset: -1 Slot: 52
	public abstract string ToString(object value, IXmlNamespaceResolver nsResolver);

	// RVA: -1 Offset: -1 Slot: 53
	public abstract object ChangeType(bool value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 54
	public abstract object ChangeType(int value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 55
	public abstract object ChangeType(long value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 56
	public abstract object ChangeType(Decimal value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 57
	public abstract object ChangeType(double value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 58
	public abstract object ChangeType(DateTime value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 59
	public abstract object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver);

	// RVA: -1 Offset: -1 Slot: 60
	public abstract object ChangeType(object value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 61
	public abstract object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver);

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

internal abstract class XmlBaseConverter : XmlValueConverter // TypeDefIndex: 2400
{	// Fields
	private XmlSchemaType schemaType; // 0x10
	private XmlTypeCode typeCode; // 0x18
	private Type clrTypeDefault; // 0x20
	protected static readonly Type ICollectionType; // 0x0
	protected static readonly Type IEnumerableType; // 0x8
	protected static readonly Type IListType; // 0x10
	protected static readonly Type ObjectArrayType; // 0x18
	protected static readonly Type StringArrayType; // 0x20
	protected static readonly Type XmlAtomicValueArrayType; // 0x28
	protected static readonly Type DecimalType; // 0x30
	protected static readonly Type Int32Type; // 0x38
	protected static readonly Type Int64Type; // 0x40
	protected static readonly Type StringType; // 0x48
	protected static readonly Type XmlAtomicValueType; // 0x50
	protected static readonly Type ObjectType; // 0x58
	protected static readonly Type ByteType; // 0x60
	protected static readonly Type Int16Type; // 0x68
	protected static readonly Type SByteType; // 0x70
	protected static readonly Type UInt16Type; // 0x78
	protected static readonly Type UInt32Type; // 0x80
	protected static readonly Type UInt64Type; // 0x88
	protected static readonly Type XPathItemType; // 0x90
	protected static readonly Type DoubleType; // 0x98
	protected static readonly Type SingleType; // 0xA0
	protected static readonly Type DateTimeType; // 0xA8
	protected static readonly Type DateTimeOffsetType; // 0xB0
	protected static readonly Type BooleanType; // 0xB8
	protected static readonly Type ByteArrayType; // 0xC0
	protected static readonly Type XmlQualifiedNameType; // 0xC8
	protected static readonly Type UriType; // 0xD0
	protected static readonly Type TimeSpanType; // 0xD8
	protected static readonly Type XPathNavigatorType; // 0xE0

	// Properties
	protected XmlSchemaType SchemaType { get; }
	protected XmlTypeCode TypeCode { get; }
	protected string XmlTypeName { get; }
	protected Type DefaultClrType { get; }

	// Methods

	// RVA: 0x14383A0 Offset: 0x14369A0 VA: 0x1814383A0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x14384B0 Offset: 0x1436AB0 VA: 0x1814384B0
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x1438330 Offset: 0x1436930 VA: 0x181438330
	protected void .ctor(XmlBaseConverter converterAtomic) { }

	// RVA: 0x14382D0 Offset: 0x14368D0 VA: 0x1814382D0
	protected void .ctor(XmlBaseConverter converterAtomic, Type clrTypeDefault) { }

	// RVA: 0x14357E0 Offset: 0x1433DE0 VA: 0x1814357E0 Slot: 7
	public override bool ToBoolean(DateTime value) { }

	// RVA: 0x1435620 Offset: 0x1433C20 VA: 0x181435620 Slot: 6
	public override bool ToBoolean(double value) { }

	// RVA: 0x1435700 Offset: 0x1433D00 VA: 0x181435700 Slot: 5
	public override bool ToBoolean(int value) { }

	// RVA: 0x1435540 Offset: 0x1433B40 VA: 0x181435540 Slot: 4
	public override bool ToBoolean(long value) { }

	// RVA: 0x1435480 Offset: 0x1433A80 VA: 0x181435480 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x14358C0 Offset: 0x1433EC0 VA: 0x1814358C0 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x1436130 Offset: 0x1434730 VA: 0x181436130 Slot: 33
	public override DateTime ToDateTime(bool value) { }

	// RVA: 0x1435F70 Offset: 0x1434570 VA: 0x181435F70 Slot: 37
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x1436050 Offset: 0x1434650 VA: 0x181436050 Slot: 36
	public override DateTime ToDateTime(double value) { }

	// RVA: 0x1435C30 Offset: 0x1434230 VA: 0x181435C30 Slot: 34
	public override DateTime ToDateTime(int value) { }

	// RVA: 0x1435DD0 Offset: 0x14343D0 VA: 0x181435DD0 Slot: 35
	public override DateTime ToDateTime(long value) { }

	// RVA: 0x1435EB0 Offset: 0x14344B0 VA: 0x181435EB0 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x1435D10 Offset: 0x1434310 VA: 0x181435D10 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x1435980 Offset: 0x1433F80 VA: 0x181435980 Slot: 40
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x1435A70 Offset: 0x1434070 VA: 0x181435A70 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x1435B50 Offset: 0x1434150 VA: 0x181435B50 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x14362E0 Offset: 0x14348E0 VA: 0x1814362E0 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x1436210 Offset: 0x1434810 VA: 0x181436210 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x1436630 Offset: 0x1434C30 VA: 0x181436630 Slot: 24
	public override double ToDouble(bool value) { }

	// RVA: 0x14367D0 Offset: 0x1434DD0 VA: 0x1814367D0 Slot: 27
	public override double ToDouble(DateTime value) { }

	// RVA: 0x1436490 Offset: 0x1434A90 VA: 0x181436490 Slot: 25
	public override double ToDouble(int value) { }

	// RVA: 0x14363B0 Offset: 0x14349B0 VA: 0x1814363B0 Slot: 26
	public override double ToDouble(long value) { }

	// RVA: 0x1436570 Offset: 0x1434B70 VA: 0x181436570 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x1436710 Offset: 0x1434D10 VA: 0x181436710 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x1436A50 Offset: 0x1435050 VA: 0x181436A50 Slot: 10
	public override int ToInt32(bool value) { }

	// RVA: 0x1436B20 Offset: 0x1435120 VA: 0x181436B20 Slot: 13
	public override int ToInt32(DateTime value) { }

	// RVA: 0x1436970 Offset: 0x1434F70 VA: 0x181436970 Slot: 12
	public override int ToInt32(double value) { }

	// RVA: 0x1436BF0 Offset: 0x14351F0 VA: 0x181436BF0 Slot: 11
	public override int ToInt32(long value) { }

	// RVA: 0x14368B0 Offset: 0x1434EB0 VA: 0x1814368B0 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x1436CC0 Offset: 0x14352C0 VA: 0x181436CC0 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x1436FD0 Offset: 0x14355D0 VA: 0x181436FD0 Slot: 16
	public override long ToInt64(bool value) { }

	// RVA: 0x1437180 Offset: 0x1435780 VA: 0x181437180 Slot: 19
	public override long ToInt64(DateTime value) { }

	// RVA: 0x14370A0 Offset: 0x14356A0 VA: 0x1814370A0 Slot: 18
	public override long ToInt64(double value) { }

	// RVA: 0x1436F00 Offset: 0x1435500 VA: 0x181436F00 Slot: 17
	public override long ToInt64(int value) { }

	// RVA: 0x1436E40 Offset: 0x1435440 VA: 0x181436E40 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x1436D80 Offset: 0x1435380 VA: 0x181436D80 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x1437320 Offset: 0x1435920 VA: 0x181437320 Slot: 30
	public override float ToSingle(double value) { }

	// RVA: 0x1437260 Offset: 0x1435860 VA: 0x181437260 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x1437400 Offset: 0x1435A00 VA: 0x181437400 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x14374C0 Offset: 0x1435AC0 VA: 0x1814374C0 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x1437640 Offset: 0x1435C40 VA: 0x181437640 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x14377E0 Offset: 0x1435DE0 VA: 0x1814377E0 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x1437710 Offset: 0x1435D10 VA: 0x181437710 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x1437B30 Offset: 0x1436130 VA: 0x181437B30 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x1437980 Offset: 0x1435F80 VA: 0x181437980 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x14378B0 Offset: 0x1435EB0 VA: 0x1814378B0 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x1437A40 Offset: 0x1436040 VA: 0x181437A40 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x1437580 Offset: 0x1435B80 VA: 0x181437580 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1437B10 Offset: 0x1436110 VA: 0x181437B10 Slot: 51
	public override string ToString(object value) { }

	// RVA: 0x1432D10 Offset: 0x1431310 VA: 0x181432D10 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x1432B70 Offset: 0x1431170 VA: 0x181432B70 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x1432DC0 Offset: 0x14313C0 VA: 0x181432DC0 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x1432C70 Offset: 0x1431270 VA: 0x181432C70 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x1432AF0 Offset: 0x14310F0 VA: 0x181432AF0 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x1432BF0 Offset: 0x14311F0 VA: 0x181432BF0 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x1432CF0 Offset: 0x14312F0 VA: 0x181432CF0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1432D90 Offset: 0x1431390 VA: 0x181432D90 Slot: 60
	public override object ChangeType(object value, Type destinationType) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	protected XmlSchemaType get_SchemaType() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	protected XmlTypeCode get_TypeCode() { }

	// RVA: 0x14385B0 Offset: 0x1436BB0 VA: 0x1814385B0
	protected string get_XmlTypeName() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	protected Type get_DefaultClrType() { }

	// RVA: 0x14342C0 Offset: 0x14328C0 VA: 0x1814342C0
	protected static bool IsDerivedFrom(Type derivedType, Type baseType) { }

	// RVA: 0x1432E40 Offset: 0x1431440 VA: 0x181432E40
	protected Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

	// RVA: 0x1434520 Offset: 0x1432B20 VA: 0x181434520
	protected static string QNameToString(XmlQualifiedName name) { }

	// RVA: 0x1432A80 Offset: 0x1431080 VA: 0x181432A80 Slot: 62
	protected virtual object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1434600 Offset: 0x1432C00 VA: 0x181434600
	protected static byte[] StringToBase64Binary(string value) { }

	// RVA: 0x1434840 Offset: 0x1432E40 VA: 0x181434840
	protected static DateTime StringToDate(string value) { }

	// RVA: 0x14347C0 Offset: 0x1432DC0 VA: 0x1814347C0
	protected static DateTime StringToDateTime(string value) { }

	// RVA: 0x14348C0 Offset: 0x1432EC0 VA: 0x1814348C0
	protected static TimeSpan StringToDayTimeDuration(string value) { }

	// RVA: 0x1434920 Offset: 0x1432F20 VA: 0x181434920
	protected static TimeSpan StringToDuration(string value) { }

	// RVA: 0x1434A20 Offset: 0x1433020 VA: 0x181434A20
	protected static DateTime StringToGDay(string value) { }

	// RVA: 0x1434C60 Offset: 0x1433260 VA: 0x181434C60
	protected static DateTime StringToGMonth(string value) { }

	// RVA: 0x1434B40 Offset: 0x1433140 VA: 0x181434B40
	protected static DateTime StringToGMonthDay(string value) { }

	// RVA: 0x1434EA0 Offset: 0x14334A0 VA: 0x181434EA0
	protected static DateTime StringToGYear(string value) { }

	// RVA: 0x1434D80 Offset: 0x1433380 VA: 0x181434D80
	protected static DateTime StringToGYearMonth(string value) { }

	// RVA: 0x1434680 Offset: 0x1432C80 VA: 0x181434680
	protected static DateTimeOffset StringToDateOffset(string value) { }

	// RVA: 0x1434720 Offset: 0x1432D20 VA: 0x181434720
	protected static DateTimeOffset StringToDateTimeOffset(string value) { }

	// RVA: 0x1434980 Offset: 0x1432F80 VA: 0x181434980
	protected static DateTimeOffset StringToGDayOffset(string value) { }

	// RVA: 0x1434BC0 Offset: 0x14331C0 VA: 0x181434BC0
	protected static DateTimeOffset StringToGMonthOffset(string value) { }

	// RVA: 0x1434AA0 Offset: 0x14330A0 VA: 0x181434AA0
	protected static DateTimeOffset StringToGMonthDayOffset(string value) { }

	// RVA: 0x1434E00 Offset: 0x1433400 VA: 0x181434E00
	protected static DateTimeOffset StringToGYearOffset(string value) { }

	// RVA: 0x1434CE0 Offset: 0x14332E0 VA: 0x181434CE0
	protected static DateTimeOffset StringToGYearMonthOffset(string value) { }

	// RVA: 0x1434F20 Offset: 0x1433520 VA: 0x181434F20
	protected static byte[] StringToHexBinary(string value) { }

	// RVA: 0x1434FF0 Offset: 0x14335F0 VA: 0x181434FF0
	protected static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1435310 Offset: 0x1433910 VA: 0x181435310
	protected static DateTime StringToTime(string value) { }

	// RVA: 0x1435270 Offset: 0x1433870 VA: 0x181435270
	protected static DateTimeOffset StringToTimeOffset(string value) { }

	// RVA: 0x1435390 Offset: 0x1433990 VA: 0x181435390
	protected static TimeSpan StringToYearMonthDuration(string value) { }

	// RVA: 0x1432A00 Offset: 0x1431000 VA: 0x181432A00
	protected static string AnyUriToString(Uri value) { }

	// RVA: 0x1432A20 Offset: 0x1431020 VA: 0x181432A20
	protected static string Base64BinaryToString(byte[] value) { }

	// RVA: 0x1433260 Offset: 0x1431860 VA: 0x181433260
	protected static string DateToString(DateTime value) { }

	// RVA: 0x1433220 Offset: 0x1431820 VA: 0x181433220
	protected static string DateTimeToString(DateTime value) { }

	// RVA: 0x14332A0 Offset: 0x14318A0 VA: 0x1814332A0
	protected static string DayTimeDurationToString(TimeSpan value) { }

	// RVA: 0x1433920 Offset: 0x1431F20 VA: 0x181433920
	protected static string DurationToString(TimeSpan value) { }

	// RVA: 0x14339D0 Offset: 0x1431FD0 VA: 0x1814339D0
	protected static string GDayToString(DateTime value) { }

	// RVA: 0x1433AF0 Offset: 0x14320F0 VA: 0x181433AF0
	protected static string GMonthToString(DateTime value) { }

	// RVA: 0x1433A60 Offset: 0x1432060 VA: 0x181433A60
	protected static string GMonthDayToString(DateTime value) { }

	// RVA: 0x1433C10 Offset: 0x1432210 VA: 0x181433C10
	protected static string GYearToString(DateTime value) { }

	// RVA: 0x1433B80 Offset: 0x1432180 VA: 0x181433B80
	protected static string GYearMonthToString(DateTime value) { }

	// RVA: 0x1433170 Offset: 0x1431770 VA: 0x181433170
	protected static string DateOffsetToString(DateTimeOffset value) { }

	// RVA: 0x14331D0 Offset: 0x14317D0 VA: 0x1814331D0
	protected static string DateTimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1433980 Offset: 0x1431F80 VA: 0x181433980
	protected static string GDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1433AA0 Offset: 0x14320A0 VA: 0x181433AA0
	protected static string GMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1433A10 Offset: 0x1432010 VA: 0x181433A10
	protected static string GMonthDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1433BC0 Offset: 0x14321C0 VA: 0x181433BC0
	protected static string GYearOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1433B30 Offset: 0x1432130 VA: 0x181433B30
	protected static string GYearMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1434390 Offset: 0x1432990 VA: 0x181434390
	protected static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1435440 Offset: 0x1433A40 VA: 0x181435440
	protected static string TimeToString(DateTime value) { }

	// RVA: 0x14353F0 Offset: 0x14339F0 VA: 0x1814353F0
	protected static string TimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1437D20 Offset: 0x1436320 VA: 0x181437D20
	protected static string YearMonthDurationToString(TimeSpan value) { }

	// RVA: 0x14331C0 Offset: 0x14317C0 VA: 0x1814331C0
	internal static DateTime DateTimeOffsetToDateTime(DateTimeOffset value) { }

	// RVA: 0x1433300 Offset: 0x1431900 VA: 0x181433300
	internal static int DecimalToInt32(Decimal value) { }

	// RVA: 0x1433510 Offset: 0x1431B10 VA: 0x181433510
	protected static long DecimalToInt64(Decimal value) { }

	// RVA: 0x1433720 Offset: 0x1431D20 VA: 0x181433720
	protected static ulong DecimalToUInt64(Decimal value) { }

	// RVA: 0x1433C50 Offset: 0x1432250 VA: 0x181433C50
	protected static byte Int32ToByte(int value) { }

	// RVA: 0x1433D60 Offset: 0x1432360 VA: 0x181433D60
	protected static short Int32ToInt16(int value) { }

	// RVA: 0x1433E70 Offset: 0x1432470 VA: 0x181433E70
	protected static sbyte Int32ToSByte(int value) { }

	// RVA: 0x1433F80 Offset: 0x1432580 VA: 0x181433F80
	protected static ushort Int32ToUInt16(int value) { }

	// RVA: 0x1434090 Offset: 0x1432690 VA: 0x181434090
	protected static int Int64ToInt32(long value) { }

	// RVA: 0x14341B0 Offset: 0x14327B0 VA: 0x1814341B0
	protected static uint Int64ToUInt32(long value) { }

	// RVA: 0x1437CA0 Offset: 0x14362A0 VA: 0x181437CA0
	protected static DateTime UntypedAtomicToDateTime(string value) { }

	// RVA: 0x1437C00 Offset: 0x1436200 VA: 0x181437C00
	protected static DateTimeOffset UntypedAtomicToDateTimeOffset(string value) { }

	// RVA: 0x1437D80 Offset: 0x1436380 VA: 0x181437D80
	private static void .cctor() { }

}

internal class XmlNumeric10Converter : XmlBaseConverter // TypeDefIndex: 2401
{	// Methods

	// RVA: 0x14462F0 Offset: 0x14448F0 VA: 0x1814462F0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1444B90 Offset: 0x1443190 VA: 0x181444B90
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1444C20 Offset: 0x1443220 VA: 0x181444C20 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x1444D00 Offset: 0x1443300 VA: 0x181444D00 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x14451D0 Offset: 0x14437D0 VA: 0x1814451D0 Slot: 11
	public override int ToInt32(long value) { }

	// RVA: 0x1445690 Offset: 0x1443C90 VA: 0x181445690 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x1445230 Offset: 0x1443830 VA: 0x181445230 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x14457A0 Offset: 0x1443DA0 VA: 0x1814457A0 Slot: 17
	public override long ToInt64(int value) { }

	// RVA: 0x1445BE0 Offset: 0x14441E0 VA: 0x181445BE0 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x14457B0 Offset: 0x1443DB0 VA: 0x1814457B0 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x14461B0 Offset: 0x14447B0 VA: 0x1814461B0 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x14462A0 Offset: 0x14448A0 VA: 0x1814462A0 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x1445CF0 Offset: 0x14442F0 VA: 0x181445CF0 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x1445D50 Offset: 0x1444350 VA: 0x181445D50 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1441EA0 Offset: 0x14404A0 VA: 0x181441EA0 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x1444640 Offset: 0x1442C40 VA: 0x181444640 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x14424C0 Offset: 0x1440AC0 VA: 0x1814424C0 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x1442A40 Offset: 0x1441040 VA: 0x181442A40 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1442FB0 Offset: 0x14415B0 VA: 0x181442FB0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1441510 Offset: 0x143FB10 VA: 0x181441510
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1441990 Offset: 0x143FF90 VA: 0x181441990
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlNumeric2Converter : XmlBaseConverter // TypeDefIndex: 2402
{	// Methods

	// RVA: 0x1448710 Offset: 0x1446D10 VA: 0x181448710
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1447880 Offset: 0x1445E80 VA: 0x181447880
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1447910 Offset: 0x1445F10 VA: 0x181447910 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x14479E0 Offset: 0x1445FE0 VA: 0x1814479E0 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x1448150 Offset: 0x1446750 VA: 0x181448150 Slot: 30
	public override float ToSingle(double value) { }

	// RVA: 0x1448160 Offset: 0x1446760 VA: 0x181448160 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x1447D70 Offset: 0x1446370 VA: 0x181447D70 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x14485C0 Offset: 0x1446BC0 VA: 0x1814485C0 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x1448670 Offset: 0x1446C70 VA: 0x181448670 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x1448230 Offset: 0x1446830 VA: 0x181448230 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1446EE0 Offset: 0x14454E0 VA: 0x181446EE0 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x1447390 Offset: 0x1445990 VA: 0x181447390 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1446360 Offset: 0x1444960 VA: 0x181446360 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlDateTimeConverter : XmlBaseConverter // TypeDefIndex: 2403
{	// Methods

	// RVA: 0x143CDD0 Offset: 0x143B3D0 VA: 0x18143CDD0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x143B720 Offset: 0x1439D20 VA: 0x18143B720
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x143C5C0 Offset: 0x143ABC0 VA: 0x18143C5C0 Slot: 37
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x143C2A0 Offset: 0x143A8A0 VA: 0x18143C2A0 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x143BF00 Offset: 0x143A500 VA: 0x18143BF00 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x143B7B0 Offset: 0x1439DB0 VA: 0x18143B7B0 Slot: 40
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x143BBC0 Offset: 0x143A1C0 VA: 0x18143BBC0 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x143B7E0 Offset: 0x1439DE0 VA: 0x18143B7E0 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x143C9C0 Offset: 0x143AFC0 VA: 0x18143C9C0 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x143CBB0 Offset: 0x143B1B0 VA: 0x18143CBB0 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x143C620 Offset: 0x143AC20 VA: 0x18143C620 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143A0F0 Offset: 0x14386F0 VA: 0x18143A0F0 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x143A5C0 Offset: 0x1438BC0 VA: 0x18143A5C0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143AAB0 Offset: 0x14390B0 VA: 0x18143AAB0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlBooleanConverter : XmlBaseConverter // TypeDefIndex: 2404
{	// Methods

	// RVA: 0x143A080 Offset: 0x1438680 VA: 0x18143A080
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1439910 Offset: 0x1437F10 VA: 0x181439910
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1439C90 Offset: 0x1438290 VA: 0x181439C90 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x14399A0 Offset: 0x1437FA0 VA: 0x1814399A0 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x143A020 Offset: 0x1438620 VA: 0x18143A020 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x1439D20 Offset: 0x1438320 VA: 0x181439D20 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1439060 Offset: 0x1437660 VA: 0x181439060 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x14394A0 Offset: 0x1437AA0 VA: 0x1814394A0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1438770 Offset: 0x1436D70 VA: 0x181438770 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlMiscConverter : XmlBaseConverter // TypeDefIndex: 2405
{	// Methods

	// RVA: 0x14414A0 Offset: 0x143FAA0 VA: 0x1814414A0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1440C00 Offset: 0x143F200 VA: 0x181440C00
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1440C90 Offset: 0x143F290 VA: 0x181440C90 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1440530 Offset: 0x143EB30 VA: 0x181440530 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143F0E0 Offset: 0x143D6E0 VA: 0x18143F0E0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143EE10 Offset: 0x143D410 VA: 0x18143EE10
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143EF50 Offset: 0x143D550 VA: 0x18143EF50
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlStringConverter : XmlBaseConverter // TypeDefIndex: 2406
{	// Methods

	// RVA: 0xD36310 Offset: 0xD34910 VA: 0x180D36310
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0xD36040 Offset: 0xD34640 VA: 0x180D36040
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0xD360D0 Offset: 0xD346D0 VA: 0x180D360D0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD35800 Offset: 0xD33E00 VA: 0x180D35800 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD35AF0 Offset: 0xD340F0 VA: 0x180D35AF0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlUntypedConverter : XmlListConverter // TypeDefIndex: 2407
{	// Fields
	private bool allowListToList; // 0x30
	public static readonly XmlValueConverter Untyped; // 0x0
	public static readonly XmlValueConverter UntypedList; // 0x8

	// Methods

	// RVA: 0xD3DAE0 Offset: 0xD3C0E0 VA: 0x180D3DAE0
	protected void .ctor() { }

	// RVA: 0xD3DA10 Offset: 0xD3C010 VA: 0x180D3DA10
	protected void .ctor(XmlUntypedConverter atomicConverter, bool allowListToList) { }

	// RVA: 0xD3B420 Offset: 0xD39A20 VA: 0x180D3B420 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0xD3B250 Offset: 0xD39850 VA: 0x180D3B250 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0xD3B910 Offset: 0xD39F10 VA: 0x180D3B910 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0xD3B740 Offset: 0xD39D40 VA: 0x180D3B740 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0xD3B4B0 Offset: 0xD39AB0 VA: 0x180D3B4B0 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0xD3B560 Offset: 0xD39B60 VA: 0x180D3B560 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0xD3BB80 Offset: 0xD3A180 VA: 0x180D3BB80 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0xD3B9A0 Offset: 0xD39FA0 VA: 0x180D3B9A0 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0xD3BC30 Offset: 0xD3A230 VA: 0x180D3BC30 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0xD3BCC0 Offset: 0xD3A2C0 VA: 0x180D3BCC0 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0xD3C050 Offset: 0xD3A650 VA: 0x180D3C050 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0xD3BE90 Offset: 0xD3A490 VA: 0x180D3BE90 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0xD3C2B0 Offset: 0xD3A8B0 VA: 0x180D3C2B0 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0xD3C0E0 Offset: 0xD3A6E0 VA: 0x180D3C0E0 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0xD3C340 Offset: 0xD3A940 VA: 0x180D3C340 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0xD3C3D0 Offset: 0xD3A9D0 VA: 0x180D3C3D0 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0xD3D820 Offset: 0xD3BE20 VA: 0x180D3D820 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0xD3C5A0 Offset: 0xD3ABA0 VA: 0x180D3C5A0 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0xD3D700 Offset: 0xD3BD00 VA: 0x180D3D700 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0xD3D6A0 Offset: 0xD3BCA0 VA: 0x180D3D6A0 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0xD3D7C0 Offset: 0xD3BDC0 VA: 0x180D3D7C0 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0xD3C600 Offset: 0xD3AC00 VA: 0x180D3C600 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0xD3D760 Offset: 0xD3BD60 VA: 0x180D3D760 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0xD3C650 Offset: 0xD3AC50 VA: 0x180D3C650 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0xD3C6B0 Offset: 0xD3ACB0 VA: 0x180D3C6B0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD3A6D0 Offset: 0xD38CD0 VA: 0x180D3A6D0 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0xD3A8C0 Offset: 0xD38EC0 VA: 0x180D3A8C0 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0xD37650 Offset: 0xD35C50 VA: 0x180D37650 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0xD37460 Offset: 0xD35A60 VA: 0x180D37460 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0xD37850 Offset: 0xD35E50 VA: 0x180D37850 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0xD37270 Offset: 0xD35870 VA: 0x180D37270 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0xD37A30 Offset: 0xD36030 VA: 0x180D37A30 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD389B0 Offset: 0xD36FB0 VA: 0x180D389B0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD36FA0 Offset: 0xD355A0 VA: 0x180D36FA0
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD370E0 Offset: 0xD356E0 VA: 0x180D370E0
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD36C70 Offset: 0xD35270 VA: 0x180D36C70 Slot: 62
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD3AAB0 Offset: 0xD390B0 VA: 0x180D3AAB0
	private bool SupportsType(Type clrType) { }

	// RVA: 0xD3D880 Offset: 0xD3BE80 VA: 0x180D3D880
	private static void .cctor() { }

}

internal class XmlAnyConverter : XmlBaseConverter // TypeDefIndex: 2408
{	// Fields
	public static readonly XmlValueConverter Item; // 0x0
	public static readonly XmlValueConverter AnyAtomic; // 0x8

	// Methods

	// RVA: 0x1431080 Offset: 0x142F680 VA: 0x181431080
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x142FF30 Offset: 0x142E530 VA: 0x18142FF30 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x1430300 Offset: 0x142E900 VA: 0x181430300 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x14300E0 Offset: 0x142E6E0 VA: 0x1814300E0 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x14304B0 Offset: 0x142EAB0 VA: 0x1814304B0 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x14306D0 Offset: 0x142ECD0 VA: 0x1814306D0 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x1430880 Offset: 0x142EE80 VA: 0x181430880 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x1430A30 Offset: 0x142F030 VA: 0x181430A30 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x1430CA0 Offset: 0x142F2A0 VA: 0x181430CA0 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x142CC40 Offset: 0x142B240 VA: 0x18142CC40 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x142F5D0 Offset: 0x142DBD0 VA: 0x18142F5D0 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x142CE90 Offset: 0x142B490 VA: 0x18142CE90 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x142C9F0 Offset: 0x142AFF0 VA: 0x18142C9F0 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x142FA70 Offset: 0x142E070 VA: 0x18142FA70 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x142F820 Offset: 0x142DE20 VA: 0x18142F820 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x142FCB0 Offset: 0x142E2B0 VA: 0x18142FCB0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x142D140 Offset: 0x142B740 VA: 0x18142D140 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x142C720 Offset: 0x142AD20 VA: 0x18142C720
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x142C860 Offset: 0x142AE60 VA: 0x18142C860
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1430BE0 Offset: 0x142F1E0 VA: 0x181430BE0
	private XPathNavigator ToNavigator(XPathNavigator nav) { }

	// RVA: 0x1430EB0 Offset: 0x142F4B0 VA: 0x181430EB0
	private static void .cctor() { }

}

internal class XmlAnyListConverter : XmlListConverter // TypeDefIndex: 2409
{	// Fields
	public static readonly XmlValueConverter ItemList; // 0x0
	public static readonly XmlValueConverter AnyAtomicList; // 0x8

	// Methods

	// RVA: 0x14315E0 Offset: 0x142FBE0 VA: 0x1814315E0
	protected void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x14311C0 Offset: 0x142F7C0 VA: 0x1814311C0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1431450 Offset: 0x142FA50 VA: 0x181431450
	private static void .cctor() { }

}

internal class XmlListConverter : XmlBaseConverter // TypeDefIndex: 2410
{	// Fields
	protected XmlValueConverter atomicConverter; // 0x28

	// Methods

	// RVA: 0x143ED50 Offset: 0x143D350 VA: 0x18143ED50
	protected void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x143ECA0 Offset: 0x143D2A0 VA: 0x18143ECA0
	protected void .ctor(XmlBaseConverter atomicConverter, Type clrTypeDefault) { }

	// RVA: 0x143EC30 Offset: 0x143D230 VA: 0x18143EC30
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x143E220 Offset: 0x143C820 VA: 0x18143E220
	public static XmlValueConverter Create(XmlValueConverter atomicConverter) { }

	// RVA: 0x143DDE0 Offset: 0x143C3E0 VA: 0x18143DDE0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143CE40 Offset: 0x143B440 VA: 0x18143CE40 Slot: 62
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143E400 Offset: 0x143CA00 VA: 0x18143E400
	private bool IsListType(Type type) { }

	// RVA: -1 Offset: -1
	private T[] ToArray<T>(object list, IXmlNamespaceResolver nsResolver) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B610 Offset: 0x1A39C10 VA: 0x181A3B610
	|-XmlListConverter.ToArray<bool>
	|
	|-RVA: 0x1A3BA50 Offset: 0x1A3A050 VA: 0x181A3BA50
	|-XmlListConverter.ToArray<byte>
	|
	|-RVA: 0x1A3DC50 Offset: 0x1A3C250 VA: 0x181A3DC50
	|-XmlListConverter.ToArray<byte[]>
	|-XmlListConverter.ToArray<object>
	|-XmlListConverter.ToArray<string>
	|-XmlListConverter.ToArray<Uri>
	|-XmlListConverter.ToArray<XmlAtomicValue>
	|-XmlListConverter.ToArray<XPathItem>
	|-XmlListConverter.ToArray<XPathNavigator>
	|-XmlListConverter.ToArray<XmlQualifiedName>
	|
	|-RVA: 0x1A3C2D0 Offset: 0x1A3A8D0 VA: 0x181A3C2D0
	|-XmlListConverter.ToArray<DateTime>
	|
	|-RVA: 0x1A3BE90 Offset: 0x1A3A490 VA: 0x181A3BE90
	|-XmlListConverter.ToArray<DateTimeOffset>
	|
	|-RVA: 0x1A3C710 Offset: 0x1A3AD10 VA: 0x181A3C710
	|-XmlListConverter.ToArray<Decimal>
	|
	|-RVA: 0x1A3CB50 Offset: 0x1A3B150 VA: 0x181A3CB50
	|-XmlListConverter.ToArray<double>
	|
	|-RVA: 0x1A3CF90 Offset: 0x1A3B590 VA: 0x181A3CF90
	|-XmlListConverter.ToArray<short>
	|
	|-RVA: 0x1A3D3D0 Offset: 0x1A3B9D0 VA: 0x181A3D3D0
	|-XmlListConverter.ToArray<int>
	|
	|-RVA: 0x1A3D810 Offset: 0x1A3BE10 VA: 0x181A3D810
	|-XmlListConverter.ToArray<long>
	|
	|-RVA: 0x1A3E070 Offset: 0x1A3C670 VA: 0x181A3E070
	|-XmlListConverter.ToArray<sbyte>
	|
	|-RVA: 0x1A3E4B0 Offset: 0x1A3CAB0 VA: 0x181A3E4B0
	|-XmlListConverter.ToArray<float>
	|
	|-RVA: 0x1A3E8F0 Offset: 0x1A3CEF0 VA: 0x181A3E8F0
	|-XmlListConverter.ToArray<TimeSpan>
	|
	|-RVA: 0x1A3ED30 Offset: 0x1A3D330 VA: 0x181A3ED30
	|-XmlListConverter.ToArray<ushort>
	|
	|-RVA: 0x1A3F170 Offset: 0x1A3D770 VA: 0x181A3F170
	|-XmlListConverter.ToArray<uint>
	|
	|-RVA: 0x1A3F5B0 Offset: 0x1A3DBB0 VA: 0x181A3F5B0
	|-XmlListConverter.ToArray<ulong>
	*/

	// RVA: 0x143E8E0 Offset: 0x143CEE0 VA: 0x18143E8E0
	private IList ToList(object list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143E850 Offset: 0x143CE50 VA: 0x18143E850
	private List<string> StringAsList(string value) { }

	// RVA: 0x143E5F0 Offset: 0x143CBF0 VA: 0x18143E5F0
	private string ListAsString(IEnumerable list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143DEF0 Offset: 0x143C4F0 VA: 0x18143DEF0
	private Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

}

internal class XmlUnionConverter : XmlBaseConverter // TypeDefIndex: 2411
{	// Fields
	private XmlValueConverter[] converters; // 0x28
	private bool hasAtomicMember; // 0x30
	private bool hasListMember; // 0x31

	// Methods

	// RVA: 0xD368C0 Offset: 0xD34EC0 VA: 0x180D368C0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0xD36860 Offset: 0xD34E60 VA: 0x180D36860
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0xD36380 Offset: 0xD34980 VA: 0x180D36380 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal sealed class XsdBuilder : SchemaBuilder // TypeDefIndex: 2412
{	// Fields
	private static readonly XsdBuilder.State[] SchemaElement; // 0x0
	private static readonly XsdBuilder.State[] SchemaSubelements; // 0x8
	private static readonly XsdBuilder.State[] AttributeSubelements; // 0x10
	private static readonly XsdBuilder.State[] ElementSubelements; // 0x18
	private static readonly XsdBuilder.State[] ComplexTypeSubelements; // 0x20
	private static readonly XsdBuilder.State[] SimpleContentSubelements; // 0x28
	private static readonly XsdBuilder.State[] SimpleContentExtensionSubelements; // 0x30
	private static readonly XsdBuilder.State[] SimpleContentRestrictionSubelements; // 0x38
	private static readonly XsdBuilder.State[] ComplexContentSubelements; // 0x40
	private static readonly XsdBuilder.State[] ComplexContentExtensionSubelements; // 0x48
	private static readonly XsdBuilder.State[] ComplexContentRestrictionSubelements; // 0x50
	private static readonly XsdBuilder.State[] SimpleTypeSubelements; // 0x58
	private static readonly XsdBuilder.State[] SimpleTypeRestrictionSubelements; // 0x60
	private static readonly XsdBuilder.State[] SimpleTypeListSubelements; // 0x68
	private static readonly XsdBuilder.State[] SimpleTypeUnionSubelements; // 0x70
	private static readonly XsdBuilder.State[] RedefineSubelements; // 0x78
	private static readonly XsdBuilder.State[] AttributeGroupSubelements; // 0x80
	private static readonly XsdBuilder.State[] GroupSubelements; // 0x88
	private static readonly XsdBuilder.State[] AllSubelements; // 0x90
	private static readonly XsdBuilder.State[] ChoiceSequenceSubelements; // 0x98
	private static readonly XsdBuilder.State[] IdentityConstraintSubelements; // 0xA0
	private static readonly XsdBuilder.State[] AnnotationSubelements; // 0xA8
	private static readonly XsdBuilder.State[] AnnotatedSubelements; // 0xB0
	private static readonly XsdBuilder.XsdAttributeEntry[] SchemaAttributes; // 0xB8
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeAttributes; // 0xC0
	private static readonly XsdBuilder.XsdAttributeEntry[] ElementAttributes; // 0xC8
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexTypeAttributes; // 0xD0
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentAttributes; // 0xD8
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentExtensionAttributes; // 0xE0
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentRestrictionAttributes; // 0xE8
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentAttributes; // 0xF0
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentExtensionAttributes; // 0xF8
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentRestrictionAttributes; // 0x100
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeAttributes; // 0x108
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeRestrictionAttributes; // 0x110
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeUnionAttributes; // 0x118
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeListAttributes; // 0x120
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeGroupAttributes; // 0x128
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeGroupRefAttributes; // 0x130
	private static readonly XsdBuilder.XsdAttributeEntry[] GroupAttributes; // 0x138
	private static readonly XsdBuilder.XsdAttributeEntry[] GroupRefAttributes; // 0x140
	private static readonly XsdBuilder.XsdAttributeEntry[] ParticleAttributes; // 0x148
	private static readonly XsdBuilder.XsdAttributeEntry[] AnyAttributes; // 0x150
	private static readonly XsdBuilder.XsdAttributeEntry[] IdentityConstraintAttributes; // 0x158
	private static readonly XsdBuilder.XsdAttributeEntry[] SelectorAttributes; // 0x160
	private static readonly XsdBuilder.XsdAttributeEntry[] FieldAttributes; // 0x168
	private static readonly XsdBuilder.XsdAttributeEntry[] NotationAttributes; // 0x170
	private static readonly XsdBuilder.XsdAttributeEntry[] IncludeAttributes; // 0x178
	private static readonly XsdBuilder.XsdAttributeEntry[] ImportAttributes; // 0x180
	private static readonly XsdBuilder.XsdAttributeEntry[] FacetAttributes; // 0x188
	private static readonly XsdBuilder.XsdAttributeEntry[] AnyAttributeAttributes; // 0x190
	private static readonly XsdBuilder.XsdAttributeEntry[] DocumentationAttributes; // 0x198
	private static readonly XsdBuilder.XsdAttributeEntry[] AppinfoAttributes; // 0x1A0
	private static readonly XsdBuilder.XsdAttributeEntry[] RedefineAttributes; // 0x1A8
	private static readonly XsdBuilder.XsdAttributeEntry[] AnnotationAttributes; // 0x1B0
	private static readonly XsdBuilder.XsdEntry[] SchemaEntries; // 0x1B8
	private static readonly int[] DerivationMethodValues; // 0x1C0
	private static readonly string[] DerivationMethodStrings; // 0x1C8
	private static readonly string[] FormStringValues; // 0x1D0
	private static readonly string[] UseStringValues; // 0x1D8
	private static readonly string[] ProcessContentsStringValues; // 0x1E0
	private XmlReader reader; // 0x10
	private PositionInfo positionInfo; // 0x18
	private XsdBuilder.XsdEntry currentEntry; // 0x20
	private XsdBuilder.XsdEntry nextEntry; // 0x28
	private bool hasChild; // 0x30
	private HWStack stateHistory; // 0x38
	private Stack containerStack; // 0x40
	private XmlNameTable nameTable; // 0x48
	private SchemaNames schemaNames; // 0x50
	private XmlNamespaceManager namespaceManager; // 0x58
	private bool canIncludeImport; // 0x60
	private XmlSchema schema; // 0x68
	private XmlSchemaObject xso; // 0x70
	private XmlSchemaElement element; // 0x78
	private XmlSchemaAny anyElement; // 0x80
	private XmlSchemaAttribute attribute; // 0x88
	private XmlSchemaAnyAttribute anyAttribute; // 0x90
	private XmlSchemaComplexType complexType; // 0x98
	private XmlSchemaSimpleType simpleType; // 0xA0
	private XmlSchemaComplexContent complexContent; // 0xA8
	private XmlSchemaComplexContentExtension complexContentExtension; // 0xB0
	private XmlSchemaComplexContentRestriction complexContentRestriction; // 0xB8
	private XmlSchemaSimpleContent simpleContent; // 0xC0
	private XmlSchemaSimpleContentExtension simpleContentExtension; // 0xC8
	private XmlSchemaSimpleContentRestriction simpleContentRestriction; // 0xD0
	private XmlSchemaSimpleTypeUnion simpleTypeUnion; // 0xD8
	private XmlSchemaSimpleTypeList simpleTypeList; // 0xE0
	private XmlSchemaSimpleTypeRestriction simpleTypeRestriction; // 0xE8
	private XmlSchemaGroup group; // 0xF0
	private XmlSchemaGroupRef groupRef; // 0xF8
	private XmlSchemaAll all; // 0x100
	private XmlSchemaChoice choice; // 0x108
	private XmlSchemaSequence sequence; // 0x110
	private XmlSchemaParticle particle; // 0x118
	private XmlSchemaAttributeGroup attributeGroup; // 0x120
	private XmlSchemaAttributeGroupRef attributeGroupRef; // 0x128
	private XmlSchemaNotation notation; // 0x130
	private XmlSchemaIdentityConstraint identityConstraint; // 0x138
	private XmlSchemaXPath xpath; // 0x140
	private XmlSchemaInclude include; // 0x148
	private XmlSchemaImport import; // 0x150
	private XmlSchemaAnnotation annotation; // 0x158
	private XmlSchemaAppInfo appInfo; // 0x160
	private XmlSchemaDocumentation documentation; // 0x168
	private XmlSchemaFacet facet; // 0x170
	private XmlNode[] markup; // 0x178
	private XmlSchemaRedefine redefine; // 0x180
	private ValidationEventHandler validationEventHandler; // 0x188
	private ArrayList unhandledAttributes; // 0x190
	private Hashtable namespaces; // 0x198

	// Properties
	private SchemaNames.Token CurrentElement { get; }
	private SchemaNames.Token ParentElement { get; }
	private XmlSchemaObject ParentContainer { get; }

	// Methods

	// RVA: 0xD4D3A0 Offset: 0xD4B9A0 VA: 0x180D4D3A0
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, XmlSchema schema, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0xD43C20 Offset: 0xD42220 VA: 0x180D43C20 Slot: 4
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0xD436E0 Offset: 0xD41CE0 VA: 0x180D436E0 Slot: 5
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0xD43060 Offset: 0xD41660 VA: 0x180D43060 Slot: 6
	internal override bool IsContentParsed() { }

	// RVA: 0xD43DF0 Offset: 0xD423F0 VA: 0x180D43DF0 Slot: 7
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0xD43BD0 Offset: 0xD421D0 VA: 0x180D43BD0 Slot: 8
	internal override void ProcessCData(string value) { }

	// RVA: 0xD45700 Offset: 0xD43D00 VA: 0x180D45700 Slot: 9
	internal override void StartChildren() { }

	// RVA: 0xD401C0 Offset: 0xD3E7C0 VA: 0x180D401C0 Slot: 10
	internal override void EndChildren() { }

	// RVA: 0xD43E00 Offset: 0xD42400 VA: 0x180D43E00
	private void Push() { }

	// RVA: 0xD43620 Offset: 0xD41C20 VA: 0x180D43620
	private void Pop() { }

	// RVA: 0xD4D5D0 Offset: 0xD4BBD0 VA: 0x180D4D5D0
	private SchemaNames.Token get_CurrentElement() { }

	// RVA: 0xD4D690 Offset: 0xD4BC90 VA: 0x180D4D690
	private SchemaNames.Token get_ParentElement() { }

	// RVA: 0xD4D5F0 Offset: 0xD4BBF0 VA: 0x180D4D5F0
	private XmlSchemaObject get_ParentContainer() { }

	// RVA: 0xD40300 Offset: 0xD3E900 VA: 0x180D40300
	private XmlSchemaObject GetContainer(XsdBuilder.State state) { }

	// RVA: 0xD44790 Offset: 0xD42D90 VA: 0x180D44790
	private void SetContainer(XsdBuilder.State state, object container) { }

	// RVA: 0xD3E400 Offset: 0xD3CA00 VA: 0x180D3E400
	private static void BuildAnnotated_Id(XsdBuilder builder, string value) { }

	// RVA: 0xD3F960 Offset: 0xD3DF60 VA: 0x180D3F960
	private static void BuildSchema_AttributeFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0xD3FA80 Offset: 0xD3E080 VA: 0x180D3FA80
	private static void BuildSchema_ElementFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0xD3FBA0 Offset: 0xD3E1A0 VA: 0x180D3FBA0
	private static void BuildSchema_TargetNamespace(XsdBuilder builder, string value) { }

	// RVA: 0xD3FBD0 Offset: 0xD3E1D0 VA: 0x180D3FBD0
	private static void BuildSchema_Version(XsdBuilder builder, string value) { }

	// RVA: 0xD3FB30 Offset: 0xD3E130 VA: 0x180D3FB30
	private static void BuildSchema_FinalDefault(XsdBuilder builder, string value) { }

	// RVA: 0xD3FA10 Offset: 0xD3E010 VA: 0x180D3FA10
	private static void BuildSchema_BlockDefault(XsdBuilder builder, string value) { }

	// RVA: 0xD42280 Offset: 0xD40880 VA: 0x180D42280
	private static void InitSchema(XsdBuilder builder, string value) { }

	// RVA: 0xD42030 Offset: 0xD40630 VA: 0x180D42030
	private static void InitInclude(XsdBuilder builder, string value) { }

	// RVA: 0xD3F810 Offset: 0xD3DE10 VA: 0x180D3F810
	private static void BuildInclude_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0xD41F60 Offset: 0xD40560 VA: 0x180D41F60
	private static void InitImport(XsdBuilder builder, string value) { }

	// RVA: 0xD3F7B0 Offset: 0xD3DDB0 VA: 0x180D3F7B0
	private static void BuildImport_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0xD3F7E0 Offset: 0xD3DDE0 VA: 0x180D3F7E0
	private static void BuildImport_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0xD421B0 Offset: 0xD407B0 VA: 0x180D421B0
	private static void InitRedefine(XsdBuilder builder, string value) { }

	// RVA: 0xD3F930 Offset: 0xD3DF30 VA: 0x180D3F930
	private static void BuildRedefine_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0xD402E0 Offset: 0xD3E8E0 VA: 0x180D402E0
	private static void EndRedefine(XsdBuilder builder) { }

	// RVA: 0xD40F70 Offset: 0xD3F570 VA: 0x180D40F70
	private static void InitAttribute(XsdBuilder builder, string value) { }

	// RVA: 0xD3E720 Offset: 0xD3CD20 VA: 0x180D3E720
	private static void BuildAttribute_Default(XsdBuilder builder, string value) { }

	// RVA: 0xD3E750 Offset: 0xD3CD50 VA: 0x180D3E750
	private static void BuildAttribute_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0xD3E780 Offset: 0xD3CD80 VA: 0x180D3E780
	private static void BuildAttribute_Form(XsdBuilder builder, string value) { }

	// RVA: 0xD3E960 Offset: 0xD3CF60 VA: 0x180D3E960
	private static void BuildAttribute_Use(XsdBuilder builder, string value) { }

	// RVA: 0xD3E860 Offset: 0xD3CE60 VA: 0x180D3E860
	private static void BuildAttribute_Ref(XsdBuilder builder, string value) { }

	// RVA: 0xD3E830 Offset: 0xD3CE30 VA: 0x180D3E830
	private static void BuildAttribute_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD3E8E0 Offset: 0xD3CEE0 VA: 0x180D3E8E0
	private static void BuildAttribute_Type(XsdBuilder builder, string value) { }

	// RVA: 0xD416C0 Offset: 0xD3FCC0 VA: 0x180D416C0
	private static void InitElement(XsdBuilder builder, string value) { }

	// RVA: 0xD3EF70 Offset: 0xD3D570 VA: 0x180D3EF70
	private static void BuildElement_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0xD3EFF0 Offset: 0xD3D5F0 VA: 0x180D3EFF0
	private static void BuildElement_Block(XsdBuilder builder, string value) { }

	// RVA: 0xD3F060 Offset: 0xD3D660 VA: 0x180D3F060
	private static void BuildElement_Default(XsdBuilder builder, string value) { }

	// RVA: 0xD3F130 Offset: 0xD3D730 VA: 0x180D3F130
	private static void BuildElement_Form(XsdBuilder builder, string value) { }

	// RVA: 0xD3F370 Offset: 0xD3D970 VA: 0x180D3F370
	private static void BuildElement_SubstitutionGroup(XsdBuilder builder, string value) { }

	// RVA: 0xD3F090 Offset: 0xD3D690 VA: 0x180D3F090
	private static void BuildElement_Final(XsdBuilder builder, string value) { }

	// RVA: 0xD3F100 Offset: 0xD3D700 VA: 0x180D3F100
	private static void BuildElement_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0xD3F1E0 Offset: 0xD3D7E0 VA: 0x180D3F1E0
	private static void BuildElement_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0xD3F210 Offset: 0xD3D810 VA: 0x180D3F210
	private static void BuildElement_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0xD3F240 Offset: 0xD3D840 VA: 0x180D3F240
	private static void BuildElement_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD3F270 Offset: 0xD3D870 VA: 0x180D3F270
	private static void BuildElement_Nillable(XsdBuilder builder, string value) { }

	// RVA: 0xD3F2F0 Offset: 0xD3D8F0 VA: 0x180D3F2F0
	private static void BuildElement_Ref(XsdBuilder builder, string value) { }

	// RVA: 0xD3F3F0 Offset: 0xD3D9F0 VA: 0x180D3F3F0
	private static void BuildElement_Type(XsdBuilder builder, string value) { }

	// RVA: 0xD42C30 Offset: 0xD41230 VA: 0x180D42C30
	private static void InitSimpleType(XsdBuilder builder, string value) { }

	// RVA: 0xD40150 Offset: 0xD3E750 VA: 0x180D40150
	private static void BuildSimpleType_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD400E0 Offset: 0xD3E6E0 VA: 0x180D400E0
	private static void BuildSimpleType_Final(XsdBuilder builder, string value) { }

	// RVA: 0xD42B10 Offset: 0xD41110 VA: 0x180D42B10
	private static void InitSimpleTypeUnion(XsdBuilder builder, string value) { }

	// RVA: 0xD3FF20 Offset: 0xD3E520 VA: 0x180D3FF20
	private static void BuildSimpleTypeUnion_MemberTypes(XsdBuilder builder, string value) { }

	// RVA: 0xD42870 Offset: 0xD40E70 VA: 0x180D42870
	private static void InitSimpleTypeList(XsdBuilder builder, string value) { }

	// RVA: 0xD3FE20 Offset: 0xD3E420 VA: 0x180D3FE20
	private static void BuildSimpleTypeList_ItemType(XsdBuilder builder, string value) { }

	// RVA: 0xD429B0 Offset: 0xD40FB0 VA: 0x180D429B0
	private static void InitSimpleTypeRestriction(XsdBuilder builder, string value) { }

	// RVA: 0xD3FEA0 Offset: 0xD3E4A0 VA: 0x180D3FEA0
	private static void BuildSimpleTypeRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0xD41410 Offset: 0xD3FA10 VA: 0x180D41410
	private static void InitComplexType(XsdBuilder builder, string value) { }

	// RVA: 0xD3EB90 Offset: 0xD3D190 VA: 0x180D3EB90
	private static void BuildComplexType_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0xD3EC10 Offset: 0xD3D210 VA: 0x180D3EC10
	private static void BuildComplexType_Block(XsdBuilder builder, string value) { }

	// RVA: 0xD3EC90 Offset: 0xD3D290 VA: 0x180D3EC90
	private static void BuildComplexType_Final(XsdBuilder builder, string value) { }

	// RVA: 0xD3ED00 Offset: 0xD3D300 VA: 0x180D3ED00
	private static void BuildComplexType_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0xD3ED90 Offset: 0xD3D390 VA: 0x180D3ED90
	private static void BuildComplexType_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD412E0 Offset: 0xD3F8E0 VA: 0x180D412E0
	private static void InitComplexContent(XsdBuilder builder, string value) { }

	// RVA: 0xD3EB10 Offset: 0xD3D110 VA: 0x180D3EB10
	private static void BuildComplexContent_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0xD41140 Offset: 0xD3F740 VA: 0x180D41140
	private static void InitComplexContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0xD3EA10 Offset: 0xD3D010 VA: 0x180D3EA10
	private static void BuildComplexContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0xD41230 Offset: 0xD3F830 VA: 0x180D41230
	private static void InitComplexContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0xD3EA90 Offset: 0xD3D090 VA: 0x180D3EA90
	private static void BuildComplexContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0xD42740 Offset: 0xD40D40 VA: 0x180D42740
	private static void InitSimpleContent(XsdBuilder builder, string value) { }

	// RVA: 0xD42430 Offset: 0xD40A30 VA: 0x180D42430
	private static void InitSimpleContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0xD3FC00 Offset: 0xD3E200 VA: 0x180D3FC00
	private static void BuildSimpleContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0xD425A0 Offset: 0xD40BA0 VA: 0x180D425A0
	private static void InitSimpleContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0xD3FD10 Offset: 0xD3E310 VA: 0x180D3FD10
	private static void BuildSimpleContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0xD40E40 Offset: 0xD3F440 VA: 0x180D40E40
	private static void InitAttributeGroup(XsdBuilder builder, string value) { }

	// RVA: 0xD3E6F0 Offset: 0xD3CCF0 VA: 0x180D3E6F0
	private static void BuildAttributeGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD40DA0 Offset: 0xD3F3A0 VA: 0x180D40DA0
	private static void InitAttributeGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0xD3E670 Offset: 0xD3CC70 VA: 0x180D3E670
	private static void BuildAttributeGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0xD40910 Offset: 0xD3EF10 VA: 0x180D40910
	private static void InitAnyAttribute(XsdBuilder builder, string value) { }

	// RVA: 0xD3E430 Offset: 0xD3CA30 VA: 0x180D3E430
	private static void BuildAnyAttribute_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0xD3E460 Offset: 0xD3CA60 VA: 0x180D3E460
	private static void BuildAnyAttribute_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0xD41CF0 Offset: 0xD402F0 VA: 0x180D41CF0
	private static void InitGroup(XsdBuilder builder, string value) { }

	// RVA: 0xD3F5E0 Offset: 0xD3DBE0 VA: 0x180D3F5E0
	private static void BuildGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD41C40 Offset: 0xD40240 VA: 0x180D41C40
	private static void InitGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0xD3F8D0 Offset: 0xD3DED0 VA: 0x180D3F8D0
	private static void BuildParticle_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0xD3F900 Offset: 0xD3DF00 VA: 0x180D3F900
	private static void BuildParticle_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0xD3F560 Offset: 0xD3DB60 VA: 0x180D3F560
	private static void BuildGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0xD40770 Offset: 0xD3ED70 VA: 0x180D40770
	private static void InitAll(XsdBuilder builder, string value) { }

	// RVA: 0xD41090 Offset: 0xD3F690 VA: 0x180D41090
	private static void InitChoice(XsdBuilder builder, string value) { }

	// RVA: 0xD42380 Offset: 0xD40980 VA: 0x180D42380
	private static void InitSequence(XsdBuilder builder, string value) { }

	// RVA: 0xD40C20 Offset: 0xD3F220 VA: 0x180D40C20
	private static void InitAny(XsdBuilder builder, string value) { }

	// RVA: 0xD3E510 Offset: 0xD3CB10 VA: 0x180D3E510
	private static void BuildAny_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0xD3E540 Offset: 0xD3CB40 VA: 0x180D3E540
	private static void BuildAny_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0xD42100 Offset: 0xD40700 VA: 0x180D42100
	private static void InitNotation(XsdBuilder builder, string value) { }

	// RVA: 0xD3F840 Offset: 0xD3DE40 VA: 0x180D3F840
	private static void BuildNotation_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD3F870 Offset: 0xD3DE70 VA: 0x180D3F870
	private static void BuildNotation_Public(XsdBuilder builder, string value) { }

	// RVA: 0xD3F8A0 Offset: 0xD3DEA0 VA: 0x180D3F8A0
	private static void BuildNotation_System(XsdBuilder builder, string value) { }

	// RVA: 0xD41820 Offset: 0xD3FE20 VA: 0x180D41820
	private static void InitFacet(XsdBuilder builder, string value) { }

	// RVA: 0xD3F470 Offset: 0xD3DA70 VA: 0x180D3F470
	private static void BuildFacet_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0xD3F500 Offset: 0xD3DB00 VA: 0x180D3F500
	private static void BuildFacet_Value(XsdBuilder builder, string value) { }

	// RVA: 0xD41E20 Offset: 0xD40420 VA: 0x180D41E20
	private static void InitIdentityConstraint(XsdBuilder builder, string value) { }

	// RVA: 0xD3F610 Offset: 0xD3DC10 VA: 0x180D3F610
	private static void BuildIdentityConstraint_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD3F640 Offset: 0xD3DC40 VA: 0x180D3F640
	private static void BuildIdentityConstraint_Refer(XsdBuilder builder, string value) { }

	// RVA: 0xD422B0 Offset: 0xD408B0 VA: 0x180D422B0
	private static void InitSelector(XsdBuilder builder, string value) { }

	// RVA: 0xD3F530 Offset: 0xD3DB30 VA: 0x180D3F530
	private static void BuildSelector_XPath(XsdBuilder builder, string value) { }

	// RVA: 0xD41B60 Offset: 0xD40160 VA: 0x180D41B60
	private static void InitField(XsdBuilder builder, string value) { }

	// RVA: 0xD3F530 Offset: 0xD3DB30 VA: 0x180D3F530
	private static void BuildField_XPath(XsdBuilder builder, string value) { }

	// RVA: 0xD40820 Offset: 0xD3EE20 VA: 0x180D40820
	private static void InitAnnotation(XsdBuilder builder, string value) { }

	// RVA: 0xD40CD0 Offset: 0xD3F2D0 VA: 0x180D40CD0
	private static void InitAppinfo(XsdBuilder builder, string value) { }

	// RVA: 0xD3E5F0 Offset: 0xD3CBF0 VA: 0x180D3E5F0
	private static void BuildAppinfo_Source(XsdBuilder builder, string value) { }

	// RVA: 0xD40180 Offset: 0xD3E780 VA: 0x180D40180
	private static void EndAppinfo(XsdBuilder builder) { }

	// RVA: 0xD415F0 Offset: 0xD3FBF0 VA: 0x180D415F0
	private static void InitDocumentation(XsdBuilder builder, string value) { }

	// RVA: 0xD3EDC0 Offset: 0xD3D3C0 VA: 0x180D3EDC0
	private static void BuildDocumentation_Source(XsdBuilder builder, string value) { }

	// RVA: 0xD3EE40 Offset: 0xD3D440 VA: 0x180D3EE40
	private static void BuildDocumentation_XmlLang(XsdBuilder builder, string value) { }

	// RVA: 0xD402A0 Offset: 0xD3E8A0 VA: 0x180D402A0
	private static void EndDocumentation(XsdBuilder builder) { }

	// RVA: 0xD3DD90 Offset: 0xD3C390 VA: 0x180D3DD90
	private void AddAttribute(XmlSchemaObject value) { }

	// RVA: 0xD3E040 Offset: 0xD3C640 VA: 0x180D3E040
	private void AddParticle(XmlSchemaParticle particle) { }

	// RVA: 0xD40550 Offset: 0xD3EB50 VA: 0x180D40550
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0xD43080 Offset: 0xD41680 VA: 0x180D43080
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0xD45670 Offset: 0xD43C70 VA: 0x180D45670
	private void SetMinOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0xD455E0 Offset: 0xD43BE0 VA: 0x180D455E0
	private void SetMaxOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0xD43390 Offset: 0xD41990 VA: 0x180D43390
	private bool ParseBoolean(string value, string attributeName) { }

	// RVA: 0xD43430 Offset: 0xD41A30 VA: 0x180D43430
	private int ParseEnum(string value, string attributeName, string[] values) { }

	// RVA: 0xD43520 Offset: 0xD41B20 VA: 0x180D43520
	private XmlQualifiedName ParseQName(string value, string attributeName) { }

	// RVA: 0xD430B0 Offset: 0xD416B0 VA: 0x180D430B0
	private int ParseBlockFinalEnum(string value, string attributeName) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	private static string ParseUriReference(string s) { }

	// RVA: 0xD44460 Offset: 0xD42A60 VA: 0x180D44460
	private void SendValidationEvent(string code, string arg0, string arg1, string arg2) { }

	// RVA: 0xD44690 Offset: 0xD42C90 VA: 0x180D44690
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0xD44270 Offset: 0xD42870 VA: 0x180D44270
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0xD44390 Offset: 0xD42990 VA: 0x180D44390
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0xD441B0 Offset: 0xD427B0 VA: 0x180D441B0
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0xD440E0 Offset: 0xD426E0 VA: 0x180D440E0
	private void RecordPosition() { }

	// RVA: 0xD458B0 Offset: 0xD43EB0 VA: 0x180D458B0
	private static void .cctor() { }

}

private enum XsdBuilder.State // TypeDefIndex: 2413
{	// Fields
	public int value__; // 0x0
	public const XsdBuilder.State Root = 0;
	public const XsdBuilder.State Schema = 1;
	public const XsdBuilder.State Annotation = 2;
	public const XsdBuilder.State Include = 3;
	public const XsdBuilder.State Import = 4;
	public const XsdBuilder.State Element = 5;
	public const XsdBuilder.State Attribute = 6;
	public const XsdBuilder.State AttributeGroup = 7;
	public const XsdBuilder.State AttributeGroupRef = 8;
	public const XsdBuilder.State AnyAttribute = 9;
	public const XsdBuilder.State Group = 10;
	public const XsdBuilder.State GroupRef = 11;
	public const XsdBuilder.State All = 12;
	public const XsdBuilder.State Choice = 13;
	public const XsdBuilder.State Sequence = 14;
	public const XsdBuilder.State Any = 15;
	public const XsdBuilder.State Notation = 16;
	public const XsdBuilder.State SimpleType = 17;
	public const XsdBuilder.State ComplexType = 18;
	public const XsdBuilder.State ComplexContent = 19;
	public const XsdBuilder.State ComplexContentRestriction = 20;
	public const XsdBuilder.State ComplexContentExtension = 21;
	public const XsdBuilder.State SimpleContent = 22;
	public const XsdBuilder.State SimpleContentExtension = 23;
	public const XsdBuilder.State SimpleContentRestriction = 24;
	public const XsdBuilder.State SimpleTypeUnion = 25;
	public const XsdBuilder.State SimpleTypeList = 26;
	public const XsdBuilder.State SimpleTypeRestriction = 27;
	public const XsdBuilder.State Unique = 28;
	public const XsdBuilder.State Key = 29;
	public const XsdBuilder.State KeyRef = 30;
	public const XsdBuilder.State Selector = 31;
	public const XsdBuilder.State Field = 32;
	public const XsdBuilder.State MinExclusive = 33;
	public const XsdBuilder.State MinInclusive = 34;
	public const XsdBuilder.State MaxExclusive = 35;
	public const XsdBuilder.State MaxInclusive = 36;
	public const XsdBuilder.State TotalDigits = 37;
	public const XsdBuilder.State FractionDigits = 38;
	public const XsdBuilder.State Length = 39;
	public const XsdBuilder.State MinLength = 40;
	public const XsdBuilder.State MaxLength = 41;
	public const XsdBuilder.State Enumeration = 42;
	public const XsdBuilder.State Pattern = 43;
	public const XsdBuilder.State WhiteSpace = 44;
	public const XsdBuilder.State AppInfo = 45;
	public const XsdBuilder.State Documentation = 46;
	public const XsdBuilder.State Redefine = 47;

}

private sealed class XsdBuilder.XsdBuildFunction : MulticastDelegate // TypeDefIndex: 2414
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1111E70 Offset: 0x1110470 VA: 0x181111E70 Slot: 12
	public virtual void Invoke(XsdBuilder builder, string value) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(XsdBuilder builder, string value, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XsdBuilder.XsdInitFunction : MulticastDelegate // TypeDefIndex: 2415
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1111E70 Offset: 0x1110470 VA: 0x181111E70 Slot: 12
	public virtual void Invoke(XsdBuilder builder, string value) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(XsdBuilder builder, string value, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XsdBuilder.XsdEndChildFunction : MulticastDelegate // TypeDefIndex: 2416
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x583DB0 Offset: 0x5823B0 VA: 0x180583DB0 Slot: 12
	public virtual void Invoke(XsdBuilder builder) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(XsdBuilder builder, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XsdBuilder.XsdAttributeEntry // TypeDefIndex: 2417
{	// Fields
	public SchemaNames.Token Attribute; // 0x10
	public XsdBuilder.XsdBuildFunction BuildFunc; // 0x18

	// Methods

	// RVA: 0xC65850 Offset: 0xC63E50 VA: 0x180C65850
	public void .ctor(SchemaNames.Token a, XsdBuilder.XsdBuildFunction build) { }

}

private sealed class XsdBuilder.XsdEntry // TypeDefIndex: 2418
{	// Fields
	public SchemaNames.Token Name; // 0x10
	public XsdBuilder.State CurrentState; // 0x14
	public XsdBuilder.State[] NextStates; // 0x18
	public XsdBuilder.XsdAttributeEntry[] Attributes; // 0x20
	public XsdBuilder.XsdInitFunction InitFunc; // 0x28
	public XsdBuilder.XsdEndChildFunction EndChildFunc; // 0x30
	public bool ParseContent; // 0x38

	// Methods

	// RVA: 0x11160E0 Offset: 0x11146E0 VA: 0x1811160E0
	public void .ctor(SchemaNames.Token n, XsdBuilder.State state, XsdBuilder.State[] nextStates, XsdBuilder.XsdAttributeEntry[] attributes, XsdBuilder.XsdInitFunction init, XsdBuilder.XsdEndChildFunction end, bool parseContent) { }

}

private class XsdBuilder.BuilderNamespaceManager : XmlNamespaceManager // TypeDefIndex: 2419
{	// Fields
	private XmlNamespaceManager nsMgr; // 0x50
	private XmlReader reader; // 0x58

	// Methods

	// RVA: 0x10FEAE0 Offset: 0x10FD0E0 VA: 0x1810FEAE0
	public void .ctor(XmlNamespaceManager nsMgr, XmlReader reader) { }

	// RVA: 0x10FEA80 Offset: 0x10FD080 VA: 0x1810FEA80 Slot: 16
	public override string LookupNamespace(string prefix) { }

}

internal enum XsdDateTimeFlags // TypeDefIndex: 2420
{	// Fields
	public int value__; // 0x0
	public const XsdDateTimeFlags DateTime = 1;
	public const XsdDateTimeFlags Time = 2;
	public const XsdDateTimeFlags Date = 4;
	public const XsdDateTimeFlags GYearMonth = 8;
	public const XsdDateTimeFlags GYear = 16;
	public const XsdDateTimeFlags GMonthDay = 32;
	public const XsdDateTimeFlags GDay = 64;
	public const XsdDateTimeFlags GMonth = 128;
	public const XsdDateTimeFlags XdrDateTimeNoTz = 256;
	public const XsdDateTimeFlags XdrDateTime = 512;
	public const XsdDateTimeFlags XdrTimeNoTz = 1024;
	public const XsdDateTimeFlags AllXsd = 255;

}

internal struct XsdDateTime // TypeDefIndex: 2421
{	// Fields
	private DateTime dt; // 0x0
	private uint extra; // 0x8
	private static readonly int Lzyyyy; // 0x0
	private static readonly int Lzyyyy_; // 0x4
	private static readonly int Lzyyyy_MM; // 0x8
	private static readonly int Lzyyyy_MM_; // 0xC
	private static readonly int Lzyyyy_MM_dd; // 0x10
	private static readonly int Lzyyyy_MM_ddT; // 0x14
	private static readonly int LzHH; // 0x18
	private static readonly int LzHH_; // 0x1C
	private static readonly int LzHH_mm; // 0x20
	private static readonly int LzHH_mm_; // 0x24
	private static readonly int LzHH_mm_ss; // 0x28
	private static readonly int Lz_; // 0x2C
	private static readonly int Lz_zz; // 0x30
	private static readonly int Lz_zz_; // 0x34
	private static readonly int Lz_zz_zz; // 0x38
	private static readonly int Lz__; // 0x3C
	private static readonly int Lz__mm; // 0x40
	private static readonly int Lz__mm_; // 0x44
	private static readonly int Lz__mm__; // 0x48
	private static readonly int Lz__mm_dd; // 0x4C
	private static readonly int Lz___; // 0x50
	private static readonly int Lz___dd; // 0x54
	private static readonly XmlTypeCode[] typeCodes; // 0x58

	// Properties
	private XsdDateTime.DateTimeTypeCode InternalTypeCode { get; }
	private XsdDateTime.XsdDateTimeKind InternalKind { get; }
	public int Year { get; }
	public int Month { get; }
	public int Day { get; }
	public int Hour { get; }
	public int Minute { get; }
	public int Second { get; }
	public int Fraction { get; }
	public int ZoneHour { get; }
	public int ZoneMinute { get; }

	// Methods

	// RVA: 0x1ADCB0 Offset: 0x1AD0B0 VA: 0x1801ADCB0
	public void .ctor(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x1ADC10 Offset: 0x1AD010 VA: 0x1801ADC10
	private void .ctor(XsdDateTime.Parser parser) { }

	// RVA: 0x1ADA90 Offset: 0x1ACE90 VA: 0x1801ADA90
	private void InitiateXsdDateTime(XsdDateTime.Parser parser) { }

	// RVA: 0x11133C0 Offset: 0x11119C0 VA: 0x1811133C0
	internal static bool TryParse(string text, XsdDateTimeFlags kinds, out XsdDateTime result) { }

	// RVA: 0x1ADE40 Offset: 0x1AD240 VA: 0x1801ADE40
	public void .ctor(DateTime dateTime, XsdDateTimeFlags kinds) { }

	// RVA: 0x1ADC60 Offset: 0x1AD060 VA: 0x1801ADC60
	public void .ctor(DateTimeOffset dateTimeOffset) { }

	// RVA: 0x1ADC90 Offset: 0x1AD090 VA: 0x1801ADC90
	public void .ctor(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds) { }

	// RVA: 0x1ADFA0 Offset: 0x1AD3A0 VA: 0x1801ADFA0
	private XsdDateTime.DateTimeTypeCode get_InternalTypeCode() { }

	// RVA: 0x1ADF90 Offset: 0x1AD390 VA: 0x1801ADF90
	private XsdDateTime.XsdDateTimeKind get_InternalKind() { }

	// RVA: 0x1ADFE0 Offset: 0x1AD3E0 VA: 0x1801ADFE0
	public int get_Year() { }

	// RVA: 0x1ADFC0 Offset: 0x1AD3C0 VA: 0x1801ADFC0
	public int get_Month() { }

	// RVA: 0x1ADF60 Offset: 0x1AD360 VA: 0x1801ADF60
	public int get_Day() { }

	// RVA: 0x1ADF80 Offset: 0x1AD380 VA: 0x1801ADF80
	public int get_Hour() { }

	// RVA: 0x1ADFB0 Offset: 0x1AD3B0 VA: 0x1801ADFB0
	public int get_Minute() { }

	// RVA: 0x1ADFD0 Offset: 0x1AD3D0 VA: 0x1801ADFD0
	public int get_Second() { }

	// RVA: 0x1ADF70 Offset: 0x1AD370 VA: 0x1801ADF70
	public int get_Fraction() { }

	// RVA: 0x1ADFF0 Offset: 0x1AD3F0 VA: 0x1801ADFF0
	public int get_ZoneHour() { }

	// RVA: 0x14B5F0 Offset: 0x14A9F0 VA: 0x18014B5F0
	public int get_ZoneMinute() { }

	// RVA: 0x1113F20 Offset: 0x1112520 VA: 0x181113F20
	public static DateTime op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x1113CD0 Offset: 0x11122D0 VA: 0x181113CD0
	public static DateTimeOffset op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x1ADC00 Offset: 0x1AD000 VA: 0x1801ADC00 Slot: 3
	public override string ToString() { }

	// RVA: 0x1ADB50 Offset: 0x1ACF50 VA: 0x1801ADB50
	private void PrintDate(StringBuilder sb) { }

	// RVA: 0x1ADB60 Offset: 0x1ACF60 VA: 0x1801ADB60
	private void PrintTime(StringBuilder sb) { }

	// RVA: 0x1ADB70 Offset: 0x1ACF70 VA: 0x1801ADB70
	private void PrintZone(StringBuilder sb) { }

	// RVA: 0x1ADAD0 Offset: 0x1ACED0 VA: 0x1801ADAD0
	private void IntToCharArray(char[] text, int start, int value, int digits) { }

	// RVA: 0x1ADB80 Offset: 0x1ACF80 VA: 0x1801ADB80
	private void ShortToCharArray(char[] text, int start, int value) { }

	// RVA: 0x1113470 Offset: 0x1111A70 VA: 0x181113470
	private static void .cctor() { }

}

private enum XsdDateTime.DateTimeTypeCode // TypeDefIndex: 2422
{	// Fields
	public int value__; // 0x0
	public const XsdDateTime.DateTimeTypeCode DateTime = 0;
	public const XsdDateTime.DateTimeTypeCode Time = 1;
	public const XsdDateTime.DateTimeTypeCode Date = 2;
	public const XsdDateTime.DateTimeTypeCode GYearMonth = 3;
	public const XsdDateTime.DateTimeTypeCode GYear = 4;
	public const XsdDateTime.DateTimeTypeCode GMonthDay = 5;
	public const XsdDateTime.DateTimeTypeCode GDay = 6;
	public const XsdDateTime.DateTimeTypeCode GMonth = 7;
	public const XsdDateTime.DateTimeTypeCode XdrDateTime = 8;

}

private enum XsdDateTime.XsdDateTimeKind // TypeDefIndex: 2423
{	// Fields
	public int value__; // 0x0
	public const XsdDateTime.XsdDateTimeKind Unspecified = 0;
	public const XsdDateTime.XsdDateTimeKind Zulu = 1;
	public const XsdDateTime.XsdDateTimeKind LocalWestOfZulu = 2;
	public const XsdDateTime.XsdDateTimeKind LocalEastOfZulu = 3;

}

private struct XsdDateTime.Parser // TypeDefIndex: 2424
{	// Fields
	public XsdDateTime.DateTimeTypeCode typeCode; // 0x0
	public int year; // 0x4
	public int month; // 0x8
	public int day; // 0xC
	public int hour; // 0x10
	public int minute; // 0x14
	public int second; // 0x18
	public int fraction; // 0x1C
	public XsdDateTime.XsdDateTimeKind kind; // 0x20
	public int zoneHour; // 0x24
	public int zoneMinute; // 0x28
	private string text; // 0x30
	private int length; // 0x38
	private static int[] Power10; // 0x0

	// Methods

	// RVA: 0x1AD970 Offset: 0x1ACD70 VA: 0x1801AD970
	public bool Parse(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x1AD8B0 Offset: 0x1ACCB0 VA: 0x1801AD8B0
	private bool ParseDate(int start) { }

	// RVA: 0x1AD900 Offset: 0x1ACD00 VA: 0x1801AD900
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0x1AD8C0 Offset: 0x1ACCC0 VA: 0x1801AD8C0
	private bool ParseTimeAndWhitespace(int start) { }

	// RVA: 0x1AD950 Offset: 0x1ACD50 VA: 0x1801AD950
	private bool ParseTime(ref int start) { }

	// RVA: 0x1AD960 Offset: 0x1ACD60 VA: 0x1801AD960
	private bool ParseZoneAndWhitespace(int start) { }

	// RVA: 0x1AD860 Offset: 0x1ACC60 VA: 0x1801AD860
	private bool Parse4Dig(int start, ref int num) { }

	// RVA: 0x1AD850 Offset: 0x1ACC50 VA: 0x1801AD850
	private bool Parse2Dig(int start, ref int num) { }

	// RVA: 0x1AD870 Offset: 0x1ACC70 VA: 0x1801AD870
	private bool ParseChar(int start, char ch) { }

	// RVA: 0x1104080 Offset: 0x1102680 VA: 0x181104080
	private static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right) { }

	// RVA: 0x1104090 Offset: 0x1102690 VA: 0x181104090
	private static void .cctor() { }

}

internal struct XsdDuration // TypeDefIndex: 2425
{	// Fields
	private int years; // 0x0
	private int months; // 0x4
	private int days; // 0x8
	private int hours; // 0xC
	private int minutes; // 0x10
	private int seconds; // 0x14
	private uint nanoseconds; // 0x18

	// Properties
	public bool IsNegative { get; }
	public int Years { get; }
	public int Months { get; }
	public int Days { get; }
	public int Hours { get; }
	public int Minutes { get; }
	public int Seconds { get; }
	public int Nanoseconds { get; }

	// Methods

	// RVA: 0x1AE110 Offset: 0x1AD510 VA: 0x1801AE110
	public void .ctor(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds) { }

	// RVA: 0x1AE100 Offset: 0x1AD500 VA: 0x1801AE100
	public void .ctor(TimeSpan timeSpan) { }

	// RVA: 0x1AE0E0 Offset: 0x1AD4E0 VA: 0x1801AE0E0
	public void .ctor(TimeSpan timeSpan, XsdDuration.DurationType durationType) { }

	// RVA: 0x1AE0F0 Offset: 0x1AD4F0 VA: 0x1801AE0F0
	public void .ctor(string s) { }

	// RVA: 0x1AE120 Offset: 0x1AD520 VA: 0x1801AE120
	public void .ctor(string s, XsdDuration.DurationType durationType) { }

	// RVA: 0x1AE140 Offset: 0x1AD540 VA: 0x1801AE140
	public bool get_IsNegative() { }

	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720
	public int get_Years() { }

	// RVA: 0x14B600 Offset: 0x14AA00 VA: 0x18014B600
	public int get_Months() { }

	// RVA: 0x122C30 Offset: 0x122030 VA: 0x180122C30
	public int get_Days() { }

	// RVA: 0x1AE130 Offset: 0x1AD530 VA: 0x1801AE130
	public int get_Hours() { }

	// RVA: 0xF3EB0 Offset: 0xF32B0 VA: 0x1800F3EB0
	public int get_Minutes() { }

	// RVA: 0x1AE160 Offset: 0x1AD560 VA: 0x1801AE160
	public int get_Seconds() { }

	// RVA: 0x1AE150 Offset: 0x1AD550 VA: 0x1801AE150
	public int get_Nanoseconds() { }

	// RVA: 0x1AE050 Offset: 0x1AD450 VA: 0x1801AE050
	public TimeSpan ToTimeSpan() { }

	// RVA: 0x1AE040 Offset: 0x1AD440 VA: 0x1801AE040
	public TimeSpan ToTimeSpan(XsdDuration.DurationType durationType) { }

	// RVA: 0x1AE0B0 Offset: 0x1AD4B0 VA: 0x1801AE0B0
	internal Exception TryToTimeSpan(out TimeSpan result) { }

	// RVA: 0x1AE0D0 Offset: 0x1AD4D0 VA: 0x1801AE0D0
	internal Exception TryToTimeSpan(XsdDuration.DurationType durationType, out TimeSpan result) { }

	// RVA: 0x1AE030 Offset: 0x1AD430 VA: 0x1801AE030 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AE020 Offset: 0x1AD420 VA: 0x1801AE020
	internal string ToString(XsdDuration.DurationType durationType) { }

	// RVA: 0x1115640 Offset: 0x1113C40 VA: 0x181115640
	internal static Exception TryParse(string s, out XsdDuration result) { }

	// RVA: 0x1114A00 Offset: 0x1113000 VA: 0x181114A00
	internal static Exception TryParse(string s, XsdDuration.DurationType durationType, out XsdDuration result) { }

	// RVA: 0x1114890 Offset: 0x1112E90 VA: 0x181114890
	private static string TryParseDigits(string s, ref int offset, bool eatDigits, out int result, out int numDigits) { }

}

private enum XsdDuration.Parts // TypeDefIndex: 2426
{	// Fields
	public int value__; // 0x0
	public const XsdDuration.Parts HasNone = 0;
	public const XsdDuration.Parts HasYears = 1;
	public const XsdDuration.Parts HasMonths = 2;
	public const XsdDuration.Parts HasDays = 4;
	public const XsdDuration.Parts HasHours = 8;
	public const XsdDuration.Parts HasMinutes = 16;
	public const XsdDuration.Parts HasSeconds = 32;

}

public enum XsdDuration.DurationType // TypeDefIndex: 2427
{	// Fields
	public int value__; // 0x0
	public const XsdDuration.DurationType Duration = 0;
	public const XsdDuration.DurationType YearMonthDuration = 1;
	public const XsdDuration.DurationType DayTimeDuration = 2;

}

internal sealed class XsdValidator : BaseValidator // TypeDefIndex: 2428
{	// Fields
	private int startIDConstraint; // 0x80
	private HWStack validationStack; // 0x88
	private Hashtable attPresence; // 0x90
	private XmlNamespaceManager nsManager; // 0x98
	private bool bManageNamespaces; // 0xA0
	private Hashtable IDs; // 0xA8
	private IdRefNode idRefListHead; // 0xB0
	private Parser inlineSchemaParser; // 0xB8
	private XmlSchemaContentProcessing processContents; // 0xC0
	private static readonly XmlSchemaDatatype dtCDATA; // 0x0
	private static readonly XmlSchemaDatatype dtQName; // 0x8
	private static readonly XmlSchemaDatatype dtStringArray; // 0x10
	private string NsXmlNs; // 0xC8
	private string NsXs; // 0xD0
	private string NsXsi; // 0xD8
	private string XsiType; // 0xE0
	private string XsiNil; // 0xE8
	private string XsiSchemaLocation; // 0xF0
	private string XsiNoNamespaceSchemaLocation; // 0xF8
	private string XsdSchema; // 0x100

	// Properties
	private bool IsInlineSchemaStarted { get; }
	private bool HasSchema { get; }
	public override bool PreserveWhitespace { get; }
	private bool HasIdentityConstraints { get; }

	// Methods

	// RVA: 0x111BF20 Offset: 0x111A520 VA: 0x18111BF20
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x111BF50 Offset: 0x111A550 VA: 0x18111BF50
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x11184D0 Offset: 0x1116AD0 VA: 0x1811184D0
	private void Init() { }

	// RVA: 0x111BD90 Offset: 0x111A390 VA: 0x18111BD90 Slot: 5
	public override void Validate() { }

	// RVA: 0x1116B10 Offset: 0x1115110 VA: 0x181116B10 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x111BFB0 Offset: 0x111A5B0 VA: 0x18111BFB0
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x1119870 Offset: 0x1117E70 VA: 0x181119870
	private void ProcessInlineSchema() { }

	// RVA: 0x111ADF0 Offset: 0x11193F0 VA: 0x18111ADF0
	private void ValidateElement() { }

	// RVA: 0x111ABA0 Offset: 0x11191A0 VA: 0x18111ABA0
	private object ValidateChildElement() { }

	// RVA: 0x11190E0 Offset: 0x11176E0 VA: 0x1811190E0
	private void ProcessElement(object particle) { }

	// RVA: 0x1119DB0 Offset: 0x11183B0 VA: 0x181119DB0
	private void ProcessXsiAttributes(out XmlQualifiedName xsiType, out string xsiNil) { }

	// RVA: 0x111AFD0 Offset: 0x11195D0 VA: 0x18111AFD0
	private void ValidateEndElement() { }

	// RVA: 0x11183B0 Offset: 0x11169B0 VA: 0x1811183B0
	private SchemaElementDecl FastGetElementDecl(object particle) { }

	// RVA: 0x111A6E0 Offset: 0x1118CE0 VA: 0x18111A6E0
	private SchemaElementDecl ThoroughGetElementDecl(SchemaElementDecl elementDecl, XmlQualifiedName xsiType, string xsiNil) { }

	// RVA: 0x111B750 Offset: 0x1119D50 VA: 0x18111B750
	private void ValidateStartElement() { }

	// RVA: 0x111B2D0 Offset: 0x11198D0 VA: 0x18111B2D0
	private void ValidateEndStartElement() { }

	// RVA: 0x1118890 Offset: 0x1116E90 VA: 0x181118890
	private void LoadSchemaFromLocation(string uri, string url) { }

	// RVA: 0x1118E60 Offset: 0x1117460 VA: 0x181118E60
	private void LoadSchema(string uri, string url) { }

	// RVA: 0x111BF90 Offset: 0x111A590 VA: 0x18111BF90
	private bool get_HasSchema() { }

	// RVA: 0x111BFC0 Offset: 0x111A5C0 VA: 0x18111BFC0 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x1119B30 Offset: 0x1118130 VA: 0x181119B30
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x1116C50 Offset: 0x1115250 VA: 0x181116C50
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x1116170 Offset: 0x1114770 VA: 0x181116170
	internal void AddID(string name, object node) { }

	// RVA: 0x11184B0 Offset: 0x1116AB0 VA: 0x1811184B0 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x1118840 Offset: 0x1116E40 VA: 0x181118840
	public bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x111A560 Offset: 0x1118B60 VA: 0x18111A560
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x1119020 Offset: 0x1117620 VA: 0x181119020
	private void Pop() { }

	// RVA: 0x1116B10 Offset: 0x1115110 VA: 0x181116B10
	private void CheckForwardRefs() { }

	// RVA: 0x111B700 Offset: 0x1119D00 VA: 0x18111B700
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x111BF80 Offset: 0x111A580 VA: 0x18111BF80
	private bool get_HasIdentityConstraints() { }

	// RVA: 0x1116220 Offset: 0x1114820 VA: 0x181116220
	private void AddIdentityConstraints() { }

	// RVA: 0x1117070 Offset: 0x1115670 VA: 0x181117070
	private void ElementIdentityConstraints() { }

	// RVA: 0x11167C0 Offset: 0x1114DC0 VA: 0x1811167C0
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, SchemaAttDef attdef) { }

	// RVA: 0x111AB20 Offset: 0x1119120 VA: 0x18111AB20
	private object UnWrapUnion(object typedValue) { }

	// RVA: 0x1117480 Offset: 0x1115A80 VA: 0x181117480
	private void EndElementIdentityConstraints() { }

	// RVA: 0x111BE60 Offset: 0x111A460 VA: 0x18111BE60
	private static void .cctor() { }

}

public sealed class XmlReaderSection // TypeDefIndex: 2429
{	// Properties
	internal static bool ProhibitDefaultUrlResolver { get; }
	internal static bool CollapseWhiteSpaceIntoEmptyString { get; }

	// Methods

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	internal static bool get_ProhibitDefaultUrlResolver() { }

	// RVA: 0xE676C0 Offset: 0xE65CC0 VA: 0x180E676C0
	internal static XmlResolver CreateDefaultResolver() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	internal static bool get_CollapseWhiteSpaceIntoEmptyString() { }

}

public enum XRNode // TypeDefIndex: 4139
{	// Fields
	public int value__; // 0x0
	public const XRNode LeftEye = 0;
	public const XRNode RightEye = 1;
	public const XRNode CenterEye = 2;
	public const XRNode Head = 3;
	public const XRNode LeftHand = 4;
	public const XRNode RightHand = 5;
	public const XRNode GameController = 6;
	public const XRNode TrackingReference = 7;
	public const XRNode HardwareTracker = 8;

}

public struct XRNodeState // TypeDefIndex: 4141
{	// Fields
	private XRNode m_Type; // 0x0
	private AvailableTrackingData m_AvailableFields; // 0x4
	private Vector3 m_Position; // 0x8
	private Quaternion m_Rotation; // 0x14
	private Vector3 m_Velocity; // 0x24
	private Vector3 m_AngularVelocity; // 0x30
	private Vector3 m_Acceleration; // 0x3C
	private Vector3 m_AngularAcceleration; // 0x48
	private int m_Tracked; // 0x54
	private ulong m_UniqueID; // 0x58

	// Properties
	public ulong uniqueID { set; }
	public XRNode nodeType { set; }
	public bool tracked { set; }

	// Methods

	// RVA: 0x23EC00 Offset: 0x23E000 VA: 0x18023EC00
	public void set_uniqueID(ulong value) { }

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public void set_nodeType(XRNode value) { }

	// RVA: 0x23EBF0 Offset: 0x23DFF0 VA: 0x18023EBF0
	public void set_tracked(bool value) { }

}

public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor> // TypeDefIndex: 4150
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static Action<bool> displayFocusChanged; // 0x132E0

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22FC350 Offset: 0x22FA950 VA: 0x1822FC350
	private static void InvokeDisplayFocusChanged(bool focus) { }

	// RVA: 0x22FC3B0 Offset: 0x22FA9B0 VA: 0x1822FC3B0
	public void .ctor() { }

}

public struct XRDisplaySubsystem.XRRenderPass // TypeDefIndex: 4151
{	// Fields
	private IntPtr displaySubsystemInstance; // 0x0
	public int renderPassIndex; // 0x8
	public RenderTargetIdentifier renderTarget; // 0x10
	public RenderTextureDescriptor renderTargetDesc; // 0x38
	public bool shouldFillOutDepth; // 0x6C
	public int cullingPassIndex; // 0x70

}

public struct XRDisplaySubsystem.XRMirrorViewBlitDesc // TypeDefIndex: 4152
{	// Fields
	private IntPtr displaySubsystemInstance; // 0x0
	public bool nativeBlitAvailable; // 0x8
	public bool nativeBlitInvalidStates; // 0x9
	public int blitParamsCount; // 0xC

}

public class XRDisplaySubsystemDescriptor : IntegratedSubsystemDescriptor<XRDisplaySubsystem> // TypeDefIndex: 4153
{	// Methods

	// RVA: 0x22FC310 Offset: 0x22FA910 VA: 0x1822FC310
	public void .ctor() { }

}

public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor> // TypeDefIndex: 4154
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private Action<XRInputSubsystem> trackingOriginUpdated; // 0x20
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private Action<XRInputSubsystem> boundaryChanged; // 0x28

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x978F0 Offset: 0x96CF0 VA: 0x1800978F0
	// RVA: 0x22FC4E0 Offset: 0x22FAAE0 VA: 0x1822FC4E0
	private static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x978F0 Offset: 0x96CF0 VA: 0x1800978F0
	// RVA: 0x22FC430 Offset: 0x22FAA30 VA: 0x1822FC430
	private static void InvokeBoundaryChangedEvent(IntPtr internalPtr) { }

	// RVA: 0x22FC590 Offset: 0x22FAB90 VA: 0x1822FC590
	public void .ctor() { }

}

public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor<XRInputSubsystem> // TypeDefIndex: 4155
{	// Methods

	// RVA: 0x22FC3F0 Offset: 0x22FA9F0 VA: 0x1822FC3F0
	public void .ctor() { }

}

public class XRMeshSubsystem : IntegratedSubsystem<XRMeshSubsystemDescriptor> // TypeDefIndex: 4161
{	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22FC610 Offset: 0x22FAC10 VA: 0x1822FC610
	private void InvokeMeshReadyDelegate(MeshGenerationResult result, Action<MeshGenerationResult> onMeshGenerationComplete) { }

	// RVA: 0x22FC680 Offset: 0x22FAC80 VA: 0x1822FC680
	public void .ctor() { }

}

public class XRMeshSubsystemDescriptor : IntegratedSubsystemDescriptor<XRMeshSubsystem> // TypeDefIndex: 4162
{	// Methods

	// RVA: 0x22FC5D0 Offset: 0x22FABD0 VA: 0x1822FC5D0
	public void .ctor() { }

}

internal sealed class XDRSchema : XMLSchema // TypeDefIndex: 4313
{	// Fields
	internal string _schemaName; // 0x10
	internal string _schemaUri; // 0x18
	internal XmlElement _schemaRoot; // 0x20
	internal DataSet _ds; // 0x28
	private static readonly char[] s_colonArray; // 0x0
	private static XDRSchema.NameType[] s_mapNameTypeXdr; // 0x8
	private static XDRSchema.NameType s_enumerationNameType; // 0x10

	// Methods

	// RVA: 0xCD3F30 Offset: 0xCD2530 VA: 0x180CD3F30
	internal void .ctor(DataSet ds, bool fInline) { }

	// RVA: 0xCD16B0 Offset: 0xCCFCB0 VA: 0x180CD16B0
	internal void LoadSchema(XmlElement schemaRoot, DataSet ds) { }

	// RVA: 0xCCF400 Offset: 0xCCDA00 VA: 0x180CCF400
	internal XmlElement FindTypeNode(XmlElement node) { }

	// RVA: 0xCD1270 Offset: 0xCCF870 VA: 0x180CD1270
	internal bool IsTextOnlyContent(XmlElement node) { }

	// RVA: 0xCD13C0 Offset: 0xCCF9C0 VA: 0x180CD13C0
	internal bool IsXDRField(XmlElement node, XmlElement typeNode) { }

	// RVA: 0xCD0730 Offset: 0xCCED30 VA: 0x180CD0730
	internal DataTable HandleTable(XmlElement node) { }

	// RVA: 0xCCF310 Offset: 0xCCD910 VA: 0x180CCF310
	private static XDRSchema.NameType FindNameType(string name) { }

	// RVA: 0xCD2600 Offset: 0xCD0C00 VA: 0x180CD2600
	private Type ParseDataType(string dt, string dtValues) { }

	// RVA: 0xCCF8C0 Offset: 0xCCDEC0 VA: 0x180CCF8C0
	internal string GetInstanceName(XmlElement node) { }

	// RVA: 0xCCFDB0 Offset: 0xCCE3B0 VA: 0x180CCFDB0
	internal void HandleColumn(XmlElement node, DataTable table) { }

	// RVA: 0xCCFD80 Offset: 0xCCE380 VA: 0x180CCFD80
	internal void GetMinMax(XmlElement elNode, ref int minOccurs, ref int maxOccurs) { }

	// RVA: 0xCCFA60 Offset: 0xCCE060 VA: 0x180CCFA60
	internal void GetMinMax(XmlElement elNode, bool isAttribute, ref int minOccurs, ref int maxOccurs) { }

	// RVA: 0xCD08C0 Offset: 0xCCEEC0 VA: 0x180CD08C0
	internal void HandleTypeNode(XmlElement typeNode, DataTable table, ArrayList tableChildren) { }

	// RVA: 0xCD0D10 Offset: 0xCCF310 VA: 0x180CD0D10
	internal DataTable InstantiateTable(DataSet dataSet, XmlElement node, XmlElement typeNode) { }

	// RVA: 0xCD0AD0 Offset: 0xCCF0D0 VA: 0x180CD0AD0
	internal DataTable InstantiateSimpleTable(DataSet dataSet, XmlElement node) { }

	// RVA: 0xCD2730 Offset: 0xCD0D30 VA: 0x180CD2730
	private static void .cctor() { }

}

private sealed class XDRSchema.NameType : IComparable // TypeDefIndex: 4314
{	// Fields
	public string name; // 0x10
	public Type type; // 0x18

	// Methods

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	public void .ctor(string n, Type t) { }

	// RVA: 0xCC0440 Offset: 0xCBEA40 VA: 0x180CC0440 Slot: 4
	public int CompareTo(object obj) { }

}

internal sealed class XMLDiffLoader // TypeDefIndex: 4315
{	// Fields
	private ArrayList _tables; // 0x10
	private DataSet _dataSet; // 0x18
	private DataTable _dataTable; // 0x20

	// Methods

	// RVA: 0xCD4690 Offset: 0xCD2C90 VA: 0x180CD4690
	internal void LoadDiffGram(DataSet ds, XmlReader dataTextReader) { }

	// RVA: 0xCD3FD0 Offset: 0xCD25D0 VA: 0x180CD3FD0
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0xCD44B0 Offset: 0xCD2AB0 VA: 0x180CD44B0
	internal void LoadDiffGram(DataTable dt, XmlReader dataTextReader) { }

	// RVA: 0xCD4B10 Offset: 0xCD3110 VA: 0x180CD4B10
	internal void ProcessDiffs(DataSet ds, XmlReader ssync) { }

	// RVA: 0xCD4800 Offset: 0xCD2E00 VA: 0x180CD4800
	internal void ProcessDiffs(ArrayList tableList, XmlReader ssync) { }

	// RVA: 0xCD53A0 Offset: 0xCD39A0 VA: 0x180CD53A0
	internal void ProcessErrors(DataSet ds, XmlReader ssync) { }

	// RVA: 0xCD4E70 Offset: 0xCD3470 VA: 0x180CD4E70
	internal void ProcessErrors(ArrayList dt, XmlReader ssync) { }

	// RVA: 0xCD4290 Offset: 0xCD2890 VA: 0x180CD4290
	private DataTable GetTable(string tableName, string ns) { }

	// RVA: 0xCD5770 Offset: 0xCD3D70 VA: 0x180CD5770
	private int ReadOldRowData(DataSet ds, ref DataTable table, ref int pos, XmlReader row) { }

	// RVA: 0xCD6480 Offset: 0xCD4A80 VA: 0x180CD6480
	internal void SkipWhitespaces(XmlReader reader) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal class XMLSchema // TypeDefIndex: 4316
{	// Methods

	// RVA: 0xCD67C0 Offset: 0xCD4DC0 VA: 0x180CD67C0
	internal static TypeConverter GetConverter(Type type) { }

	// RVA: 0xCD6820 Offset: 0xCD4E20 VA: 0x180CD6820
	internal static void SetProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0xCD64F0 Offset: 0xCD4AF0 VA: 0x180CD64F0
	internal static bool FEqualIdentity(XmlNode node, string name, string ns) { }

	// RVA: 0xCD66B0 Offset: 0xCD4CB0 VA: 0x180CD66B0
	internal static bool GetBooleanAttribute(XmlElement element, string attrName, string attrNS, bool defVal) { }

	// RVA: 0xCD6580 Offset: 0xCD4B80 VA: 0x180CD6580
	internal static string GenUniqueColumnName(string proposedName, DataTable table) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal sealed class XSDSchema : XMLSchema // TypeDefIndex: 4318
{	// Fields
	private XmlSchemaSet _schemaSet; // 0x10
	private XmlSchemaElement _dsElement; // 0x18
	private DataSet _ds; // 0x20
	private string _schemaName; // 0x28
	private ArrayList _columnExpressions; // 0x30
	private Hashtable _constraintNodes; // 0x38
	private ArrayList _refTables; // 0x40
	private ArrayList _complexTypes; // 0x48
	private XmlSchemaObjectCollection _annotations; // 0x50
	private XmlSchemaObjectCollection _elements; // 0x58
	private Hashtable _attributes; // 0x60
	private Hashtable _elementsTable; // 0x68
	private Hashtable _attributeGroups; // 0x70
	private Hashtable _schemaTypes; // 0x78
	private Hashtable _expressions; // 0x80
	private Dictionary<DataTable, List<DataTable>> _tableDictionary; // 0x88
	private Hashtable _udSimpleTypes; // 0x90
	private Hashtable _existingSimpleTypeMap; // 0x98
	private bool _fromInference; // 0xA0
	private static readonly XSDSchema.NameType[] s_mapNameTypeXsd; // 0x0

	// Properties
	internal bool FromInference { get; set; }

	// Methods

	// RVA: 0xC2BF70 Offset: 0xC2A570 VA: 0x180C2BF70
	internal bool get_FromInference() { }

	// RVA: 0xC2C450 Offset: 0xC2AA50 VA: 0x180C2C450
	internal void set_FromInference(bool value) { }

	// RVA: 0xCD78E0 Offset: 0xCD5EE0 VA: 0x180CD78E0
	private void CollectElementsAnnotations(XmlSchema schema) { }

	// RVA: 0xCD6F80 Offset: 0xCD5580 VA: 0x180CD6F80
	private void CollectElementsAnnotations(XmlSchema schema, ArrayList schemaList) { }

	// RVA: 0xCE8530 Offset: 0xCE6B30 VA: 0x180CE8530
	internal static string QualifiedName(string name) { }

	// RVA: 0xCE8B90 Offset: 0xCE7190 VA: 0x180CE8B90
	internal static void SetProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xCE87E0 Offset: 0xCE6DE0 VA: 0x180CE87E0
	private static void SetExtProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xCDAC80 Offset: 0xCD9280 VA: 0x180CDAC80
	private void HandleColumnExpression(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xCD8A60 Offset: 0xCD7060 VA: 0x180CD8A60
	internal static string GetMsdataAttribute(XmlSchemaAnnotated node, string ln) { }

	// RVA: 0xCE85A0 Offset: 0xCE6BA0 VA: 0x180CE85A0
	private static void SetExtProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0xCDFA30 Offset: 0xCDE030 VA: 0x180CDFA30
	internal void HandleRefTableProperties(ArrayList RefTables, XmlSchemaElement element) { }

	// RVA: 0xCDFB30 Offset: 0xCDE130 VA: 0x180CDFB30
	internal void HandleRelation(XmlElement node, bool fNested) { }

	// RVA: 0xCE19A0 Offset: 0xCDFFA0 VA: 0x180CE19A0
	private bool HasAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0xCE4F10 Offset: 0xCE3510 VA: 0x180CE4F10
	private bool IsDatasetParticle(XmlSchemaParticle pt) { }

	// RVA: 0xCD7970 Offset: 0xCD5F70 VA: 0x180CD7970
	private int DatasetElementCount(XmlSchemaObjectCollection elements) { }

	// RVA: 0xCD7B10 Offset: 0xCD6110 VA: 0x180CD7B10
	private XmlSchemaElement FindDatasetElement(XmlSchemaObjectCollection elements) { }

	// RVA: 0xCE8230 Offset: 0xCE6830 VA: 0x180CE8230
	public void LoadSchema(XmlSchemaSet schemaSet, DataTable dt) { }

	// RVA: 0xCE5A50 Offset: 0xCE4050 VA: 0x180CE5A50
	public void LoadSchema(XmlSchemaSet schemaSet, DataSet ds) { }

	// RVA: 0xCE0400 Offset: 0xCDEA00 VA: 0x180CE0400
	private void HandleRelations(XmlSchemaAnnotation ann, bool fNested) { }

	// RVA: 0xCD8E90 Offset: 0xCD7490 VA: 0x180CD8E90
	internal XmlSchemaObjectCollection GetParticleItems(XmlSchemaParticle pt) { }

	// RVA: 0xCDEAF0 Offset: 0xCDD0F0 VA: 0x180CDEAF0
	internal void HandleParticle(XmlSchemaParticle pt, DataTable table, ArrayList tableChildren, bool isBase) { }

	// RVA: 0xCDA9D0 Offset: 0xCD8FD0 VA: 0x180CDA9D0
	internal void HandleAttributes(XmlSchemaObjectCollection attributes, DataTable table, bool isBase) { }

	// RVA: 0xCDA630 Offset: 0xCD8C30 VA: 0x180CDA630
	private void HandleAttributeGroup(XmlSchemaAttributeGroup attributeGroup, DataTable table, bool isBase) { }

	// RVA: 0xCDAEA0 Offset: 0xCD94A0 VA: 0x180CDAEA0
	internal void HandleComplexType(XmlSchemaComplexType ct, DataTable table, ArrayList tableChildren, bool isNillable) { }

	// RVA: 0xCD92D0 Offset: 0xCD78D0 VA: 0x180CD92D0
	internal XmlSchemaParticle GetParticle(XmlSchemaComplexType ct) { }

	// RVA: 0xCD80C0 Offset: 0xCD66C0 VA: 0x180CD80C0
	internal DataColumn FindField(DataTable table, string field) { }

	// RVA: 0xCD6D50 Offset: 0xCD5350 VA: 0x180CD6D50
	internal DataColumn[] BuildKey(XmlSchemaIdentityConstraint keyNode, DataTable table) { }

	// RVA: 0xCD87E0 Offset: 0xCD6DE0 VA: 0x180CD87E0
	internal bool GetBooleanAttribute(XmlSchemaAnnotated element, string attrName, bool defVal) { }

	// RVA: 0xCD9820 Offset: 0xCD7E20 VA: 0x180CD9820
	internal string GetStringAttribute(XmlSchemaAnnotated element, string attrName, string defVal) { }

	// RVA: 0xCE9070 Offset: 0xCE7670 VA: 0x180CE9070
	internal static AcceptRejectRule TranslateAcceptRejectRule(string strRule) { }

	// RVA: 0xCE90D0 Offset: 0xCE76D0 VA: 0x180CE90D0
	internal static Rule TranslateRule(string strRule) { }

	// RVA: 0xCDE200 Offset: 0xCDC800 VA: 0x180CDE200
	internal void HandleKeyref(XmlSchemaKeyref keyref) { }

	// RVA: 0xCDB7A0 Offset: 0xCD9DA0 VA: 0x180CDB7A0
	internal void HandleConstraint(XmlSchemaIdentityConstraint keyNode) { }

	// RVA: 0xCE1BE0 Offset: 0xCE01E0 VA: 0x180CE1BE0
	internal DataTable InstantiateSimpleTable(XmlSchemaElement node) { }

	// RVA: 0xCD8900 Offset: 0xCD6F00 VA: 0x180CD8900
	internal string GetInstanceName(XmlSchemaAnnotated node) { }

	// RVA: 0xCE2B60 Offset: 0xCE1160 VA: 0x180CE2B60
	internal DataTable InstantiateTable(XmlSchemaElement node, XmlSchemaComplexType typeNode, bool isRef) { }

	// RVA: 0xCE9180 Offset: 0xCE7780 VA: 0x180CE9180
	public static Type XsdtoClr(string xsdTypeName) { }

	// RVA: 0xCD82A0 Offset: 0xCD68A0 VA: 0x180CD82A0
	private static XSDSchema.NameType FindNameType(string name) { }

	// RVA: 0xCE8260 Offset: 0xCE6860 VA: 0x180CE8260
	private Type ParseDataType(string dt) { }

	// RVA: 0xCE59E0 Offset: 0xCE3FE0 VA: 0x180CE59E0
	internal static bool IsXsdType(string name) { }

	// RVA: 0xCD8390 Offset: 0xCD6990 VA: 0x180CD8390
	internal XmlSchemaAnnotated FindTypeNode(XmlSchemaAnnotated node) { }

	// RVA: 0xCE0E50 Offset: 0xCDF450 VA: 0x180CE0E50
	internal void HandleSimpleTypeSimpleContentColumn(XmlSchemaSimpleType typeNode, string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0xCE06F0 Offset: 0xCDECF0 VA: 0x180CE06F0
	internal void HandleSimpleContentColumn(string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0xCD9BA0 Offset: 0xCD81A0 VA: 0x180CD9BA0
	internal void HandleAttributeColumn(XmlSchemaAttribute attrib, DataTable table, bool isBase) { }

	// RVA: 0xCDD1B0 Offset: 0xCDB7B0 VA: 0x180CDD1B0
	internal void HandleElementColumn(XmlSchemaElement elem, DataTable table, bool isBase) { }

	// RVA: 0xCDBC80 Offset: 0xCDA280 VA: 0x180CDBC80
	internal void HandleDataSet(XmlSchemaElement node, bool isNewDataSet) { }

	// RVA: 0xCD6BE0 Offset: 0xCD51E0 VA: 0x180CD6BE0
	private void AddTablesToList(List<DataTable> tableList, DataTable dt) { }

	// RVA: 0xCD9550 Offset: 0xCD7B50 VA: 0x180CD9550
	private string GetPrefix(string ns) { }

	// RVA: 0xCD8BB0 Offset: 0xCD71B0 VA: 0x180CD8BB0
	private string GetNamespaceFromPrefix(string prefix) { }

	// RVA: 0xCD99E0 Offset: 0xCD7FE0 VA: 0x180CD99E0
	private string GetTableNamespace(XmlSchemaIdentityConstraint key) { }

	// RVA: 0xCD98A0 Offset: 0xCD7EA0 VA: 0x180CD98A0
	private string GetTableName(XmlSchemaIdentityConstraint key) { }

	// RVA: 0xCE56C0 Offset: 0xCE3CC0 VA: 0x180CE56C0
	internal bool IsTable(XmlSchemaElement node) { }

	// RVA: 0xCE17E0 Offset: 0xCDFDE0 VA: 0x180CE17E0
	internal DataTable HandleTable(XmlSchemaElement node) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xCE9280 Offset: 0xCE7880 VA: 0x180CE9280
	private static void .cctor() { }

}

private sealed class XSDSchema.NameType : IComparable // TypeDefIndex: 4319
{	// Fields
	public readonly string name; // 0x10
	public readonly Type type; // 0x18

	// Methods

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	public void .ctor(string n, Type t) { }

	// RVA: 0x1AC71D0 Offset: 0x1AC57D0 VA: 0x181AC71D0 Slot: 4
	public int CompareTo(object obj) { }

}

internal sealed class XmlIgnoreNamespaceReader : XmlNodeReader // TypeDefIndex: 4320
{	// Fields
	private List<string> _namespacesToIgnore; // 0x30

	// Methods

	// RVA: 0x1AD10E0 Offset: 0x1ACF6E0 VA: 0x181AD10E0
	internal void .ctor(XmlDocument xdoc, string[] namespacesToIgnore) { }

	// RVA: 0x1AD0EF0 Offset: 0x1ACF4F0 VA: 0x181AD0EF0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1AD0FF0 Offset: 0x1ACF5F0 VA: 0x181AD0FF0 Slot: 28
	public override bool MoveToNextAttribute() { }

}

internal sealed class XmlDataLoader // TypeDefIndex: 4321
{	// Fields
	private DataSet _dataSet; // 0x10
	private XmlToDatasetMap _nodeToSchemaMap; // 0x18
	private Hashtable _nodeToRowMap; // 0x20
	private Stack _childRowsStack; // 0x28
	private Hashtable _htableExcludedNS; // 0x30
	private bool _fIsXdr; // 0x38
	internal bool _isDiffgram; // 0x39
	private XmlElement _topMostNode; // 0x40
	private bool _ignoreSchema; // 0x48
	private DataTable _dataTable; // 0x50
	private bool _isTableLevel; // 0x58
	private bool _fromInference; // 0x59
	private XmlReader _dataReader; // 0x60
	private object _XSD_XMLNS_NS; // 0x68
	private object _XDR_SCHEMA; // 0x70
	private object _XDRNS; // 0x78
	private object _SQL_SYNC; // 0x80
	private object _UPDGNS; // 0x88
	private object _XSD_SCHEMA; // 0x90
	private object _XSDNS; // 0x98
	private object _DFFNS; // 0xA0
	private object _MSDNS; // 0xA8
	private object _DIFFID; // 0xB0
	private object _HASCHANGES; // 0xB8
	private object _ROWORDER; // 0xC0

	// Properties
	internal bool FromInference { get; set; }

	// Methods

	// RVA: 0x1ACDD50 Offset: 0x1ACC350 VA: 0x181ACDD50
	internal void .ctor(DataSet dataset, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0x1ACDEB0 Offset: 0x1ACC4B0 VA: 0x181ACDEB0
	internal void .ctor(DataSet dataset, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0x1ACDDF0 Offset: 0x1ACC3F0 VA: 0x181ACDDF0
	internal void .ctor(DataTable datatable, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0x1ACDC60 Offset: 0x1ACC260 VA: 0x181ACDC60
	internal void .ctor(DataTable datatable, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0xAF6470 Offset: 0xAF4A70 VA: 0x180AF6470
	internal bool get_FromInference() { }

	// RVA: 0x1000540 Offset: 0xFFEB40 VA: 0x181000540
	internal void set_FromInference(bool value) { }

	// RVA: 0x1AC72F0 Offset: 0x1AC58F0 VA: 0x181AC72F0
	private void AttachRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0x1AC7470 Offset: 0x1AC5A70 VA: 0x181AC7470
	private int CountNonNSAttributes(XmlNode node) { }

	// RVA: 0x1AC7F50 Offset: 0x1AC6550 VA: 0x181AC7F50
	private string GetValueForTextOnlyColums(XmlNode n) { }

	// RVA: 0x1AC7AE0 Offset: 0x1AC60E0 VA: 0x181AC7AE0
	private string GetInitialTextFromNodes(ref XmlNode n) { }

	// RVA: 0x1AC7EA0 Offset: 0x1AC64A0 VA: 0x181AC7EA0
	private DataColumn GetTextOnlyColumn(DataRow row) { }

	// RVA: 0x1AC7DF0 Offset: 0x1AC63F0 VA: 0x181AC7DF0
	internal DataRow GetRowFromElement(XmlElement e) { }

	// RVA: 0x1AC7600 Offset: 0x1AC5C00 VA: 0x181AC7600
	internal bool FColumnElement(XmlElement e) { }

	// RVA: 0x1AC7860 Offset: 0x1AC5E60 VA: 0x181AC7860
	private bool FExcludedNamespace(string ns) { }

	// RVA: 0x1AC7980 Offset: 0x1AC5F80 VA: 0x181AC7980
	private bool FIgnoreNamespace(XmlNode node) { }

	// RVA: 0x1AC78F0 Offset: 0x1AC5EF0 VA: 0x181AC78F0
	private bool FIgnoreNamespace(XmlReader node) { }

	// RVA: 0x1AC84C0 Offset: 0x1AC6AC0 VA: 0x181AC84C0
	internal bool IsTextLikeNode(XmlNodeType n) { }

	// RVA: 0x1AC8520 Offset: 0x1AC6B20 VA: 0x181AC8520
	internal bool IsTextOnly(DataColumn c) { }

	// RVA: 0x1AC8F70 Offset: 0x1AC7570 VA: 0x181AC8F70
	internal void LoadData(XmlDocument xdoc) { }

	// RVA: 0x1AC9630 Offset: 0x1AC7C30 VA: 0x181AC9630
	private void LoadRowData(DataRow row, XmlElement rowElement) { }

	// RVA: 0x1ACADD0 Offset: 0x1AC93D0 VA: 0x181ACADD0
	private void LoadRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0x1ACDC10 Offset: 0x1ACC210 VA: 0x181ACDC10
	private void SetRowValueFromXmlText(DataRow row, DataColumn col, string xmlText) { }

	// RVA: 0x1AC8250 Offset: 0x1AC6850 VA: 0x181AC8250
	private void InitNameTable() { }

	// RVA: 0x1AC9250 Offset: 0x1AC7850 VA: 0x181AC9250
	internal void LoadData(XmlReader reader) { }

	// RVA: 0x1ACCB50 Offset: 0x1ACB150 VA: 0x181ACCB50
	private void LoadTopMostTable(DataTable table) { }

	// RVA: 0x1ACBCF0 Offset: 0x1ACA2F0 VA: 0x181ACBCF0
	private void LoadTable(DataTable table, bool isNested) { }

	// RVA: 0x1AC8550 Offset: 0x1AC6B50 VA: 0x181AC8550
	private void LoadColumn(DataColumn column, object[] foundColumns) { }

	// RVA: 0x1ACD9C0 Offset: 0x1ACBFC0 VA: 0x181ACD9C0
	private bool ProcessXsdSchema() { }

}

public enum XmlReadMode // TypeDefIndex: 4322
{	// Fields
	public int value__; // 0x0
	public const XmlReadMode Auto = 0;
	public const XmlReadMode ReadSchema = 1;
	public const XmlReadMode IgnoreSchema = 2;
	public const XmlReadMode InferSchema = 3;
	public const XmlReadMode DiffGram = 4;
	public const XmlReadMode Fragment = 5;
	public const XmlReadMode InferTypedSchema = 6;

}

internal sealed class XmlToDatasetMap // TypeDefIndex: 4323
{	// Fields
	private XmlToDatasetMap.XmlNodeIdHashtable _tableSchemaMap; // 0x10
	private XmlToDatasetMap.TableSchemaInfo _lastTableSchemaInfo; // 0x18

	// Methods

	// RVA: 0x1AD4C00 Offset: 0x1AD3200 VA: 0x181AD4C00
	public void .ctor(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0x1AD4B40 Offset: 0x1AD3140 VA: 0x181AD4B40
	public void .ctor(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0x1AD4BC0 Offset: 0x1AD31C0 VA: 0x181AD4BC0
	public void .ctor(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0x1AD4B80 Offset: 0x1AD3180 VA: 0x181AD4B80
	public void .ctor(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0x1AD4B10 Offset: 0x1AD3110 VA: 0x181AD4B10
	internal static bool IsMappedColumn(DataColumn c) { }

	// RVA: 0x1AD1A30 Offset: 0x1AD0030 VA: 0x181AD1A30
	private XmlToDatasetMap.TableSchemaInfo AddTableSchema(DataTable table, XmlNameTable nameTable) { }

	// RVA: 0x1AD1880 Offset: 0x1ACFE80 VA: 0x181AD1880
	private XmlToDatasetMap.TableSchemaInfo AddTableSchema(XmlNameTable nameTable, DataTable table) { }

	// RVA: 0x1AD1530 Offset: 0x1ACFB30 VA: 0x181AD1530
	private bool AddColumnSchema(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

	// RVA: 0x1AD1690 Offset: 0x1ACFC90 VA: 0x181AD1690
	private bool AddColumnSchema(XmlNameTable nameTable, DataColumn col, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

	// RVA: 0x1AD1B70 Offset: 0x1AD0170 VA: 0x181AD1B70
	private void BuildIdentityMap(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0x1AD2EF0 Offset: 0x1AD14F0 VA: 0x181AD2EF0
	private void BuildIdentityMap(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0x1AD3B10 Offset: 0x1AD2110 VA: 0x181AD3B10
	private void BuildIdentityMap(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0x1AD2300 Offset: 0x1AD0900 VA: 0x181AD2300
	private void BuildIdentityMap(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0x1AD4560 Offset: 0x1AD2B60 VA: 0x181AD4560
	private ArrayList GetSelfAndDescendants(DataTable dt) { }

	// RVA: 0x1AD4170 Offset: 0x1AD2770 VA: 0x181AD4170
	public object GetColumnSchema(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0x1AD3FC0 Offset: 0x1AD25C0 VA: 0x181AD3FC0
	public object GetColumnSchema(DataTable table, XmlReader dataReader, bool fIgnoreNamespace) { }

	// RVA: 0x1AD4460 Offset: 0x1AD2A60 VA: 0x181AD4460
	public object GetSchemaForNode(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0x1AD48A0 Offset: 0x1AD2EA0 VA: 0x181AD48A0
	public DataTable GetTableForNode(XmlReader node, bool fIgnoreNamespace) { }

	// RVA: 0x1AD4990 Offset: 0x1AD2F90 VA: 0x181AD4990
	private void HandleSpecialColumn(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

}

private sealed class XmlToDatasetMap.XmlNodeIdentety // TypeDefIndex: 4324
{	// Fields
	public string LocalName; // 0x10
	public string NamespaceURI; // 0x18

	// Methods

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	public void .ctor(string localName, string namespaceURI) { }

	// RVA: 0xDE2D10 Offset: 0xDE1310 VA: 0x180DE2D10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AD1480 Offset: 0x1ACFA80 VA: 0x181AD1480 Slot: 0
	public override bool Equals(object obj) { }

}

internal sealed class XmlToDatasetMap.XmlNodeIdHashtable : Hashtable // TypeDefIndex: 4325
{	// Fields
	private XmlToDatasetMap.XmlNodeIdentety _id; // 0x50

	// Properties
	public object Item { get; }
	public object Item { get; }
	public object Item { get; }
	public object Item { get; }

	// Methods

	// RVA: 0x1AD1160 Offset: 0x1ACF760 VA: 0x181AD1160
	public void .ctor(int capacity) { }

	// RVA: 0x1AD1340 Offset: 0x1ACF940 VA: 0x181AD1340
	public object get_Item(XmlNode node) { }

	// RVA: 0x1AD13E0 Offset: 0x1ACF9E0 VA: 0x181AD13E0
	public object get_Item(XmlReader dataReader) { }

	// RVA: 0x1AD12B0 Offset: 0x1ACF8B0 VA: 0x181AD12B0
	public object get_Item(DataTable table) { }

	// RVA: 0x1AD1210 Offset: 0x1ACF810 VA: 0x181AD1210
	public object get_Item(string name) { }

}

private sealed class XmlToDatasetMap.TableSchemaInfo // TypeDefIndex: 4326
{	// Fields
	public DataTable TableSchema; // 0x10
	public XmlToDatasetMap.XmlNodeIdHashtable ColumnsSchemaMap; // 0x18

	// Methods

	// RVA: 0x1AC7240 Offset: 0x1AC5840 VA: 0x181AC7240
	public void .ctor(DataTable tableSchema) { }

}

public enum XmlWriteMode // TypeDefIndex: 4327
{	// Fields
	public int value__; // 0x0
	public const XmlWriteMode WriteSchema = 0;
	public const XmlWriteMode IgnoreSchema = 1;
	public const XmlWriteMode DiffGram = 2;

}

internal sealed class XmlTreeGen // TypeDefIndex: 4330
{	// Fields
	private ArrayList _constraintNames; // 0x10
	private Hashtable _namespaces; // 0x18
	private Hashtable _autogenerated; // 0x20
	private Hashtable _prefixes; // 0x28
	private DataSet _ds; // 0x30
	private ArrayList _tables; // 0x38
	private ArrayList _relations; // 0x40
	private XmlDocument _dc; // 0x48
	private XmlElement _sRoot; // 0x50
	private int _prefixCount; // 0x58
	private SchemaFormat _schFormat; // 0x5C
	private string _filePath; // 0x60
	private string _fileName; // 0x68
	private string _fileExt; // 0x70
	private XmlElement _dsElement; // 0x78
	private XmlElement _constraintSeparator; // 0x80
	private Converter<Type, string> _targetConverter; // 0x88

	// Methods

	// RVA: 0x1AE19A0 Offset: 0x1ADFFA0 VA: 0x181AE19A0
	internal void .ctor(SchemaFormat format) { }

	// RVA: 0x1AD51F0 Offset: 0x1AD37F0 VA: 0x181AD51F0
	internal static void AddExtendedProperties(PropertyCollection props, XmlElement node) { }

	// RVA: 0x1AD5200 Offset: 0x1AD3800 VA: 0x181AD5200
	internal static void AddExtendedProperties(PropertyCollection props, XmlElement node, Type type) { }

	// RVA: 0x1AD5730 Offset: 0x1AD3D30 VA: 0x181AD5730
	internal void AddXdoProperties(object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0x1AD5900 Offset: 0x1AD3F00 VA: 0x181AD5900
	internal void AddXdoProperty(PropertyDescriptor pd, object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0x1AE0D80 Offset: 0x1ADF380 VA: 0x181AE0D80
	internal static string XmlDataTypeName(Type type) { }

	// RVA: 0x1AD8020 Offset: 0x1AD6620 VA: 0x181AD8020
	private void GenerateConstraintNames(DataTable table, bool fromTable) { }

	// RVA: 0x1AD7D20 Offset: 0x1AD6320 VA: 0x181AD7D20
	private void GenerateConstraintNames(ArrayList tables) { }

	// RVA: 0x1AD7E20 Offset: 0x1AD6420 VA: 0x181AD7E20
	private void GenerateConstraintNames(DataSet ds) { }

	// RVA: 0x1AE1970 Offset: 0x1ADFF70 VA: 0x181AE1970
	private static bool _PropsNotEmpty(PropertyCollection props) { }

	// RVA: 0x1ADC5C0 Offset: 0x1ADABC0 VA: 0x181ADC5C0
	private bool HaveExtendedProperties(DataSet ds) { }

	// RVA: 0x1AE0BF0 Offset: 0x1ADF1F0 VA: 0x181AE0BF0
	internal void WriteSchemaRoot(XmlDocument xd, XmlElement rootSchema, string targetNamespace) { }

	// RVA: 0x1AE0B80 Offset: 0x1ADF180 VA: 0x181AE0B80
	internal static void ValidateColumnMapping(Type columnType) { }

	// RVA: 0x1ADFB00 Offset: 0x1ADE100 VA: 0x181ADFB00
	internal void SetupAutoGenerated(DataSet ds) { }

	// RVA: 0x1ADFD00 Offset: 0x1ADE300 VA: 0x181ADFD00
	internal void SetupAutoGenerated(ArrayList dt) { }

	// RVA: 0x1ADFE00 Offset: 0x1ADE400 VA: 0x181ADFE00
	internal void SetupAutoGenerated(DataTable dt) { }

	// RVA: 0x1AD6D50 Offset: 0x1AD5350 VA: 0x181AD6D50
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0x1AD6AD0 Offset: 0x1AD50D0 VA: 0x181AD6AD0
	private void CreateRelations(DataTable dt) { }

	// RVA: 0x1AD7010 Offset: 0x1AD5610 VA: 0x181AD7010
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0x1ADCFE0 Offset: 0x1ADB5E0 VA: 0x181ADCFE0
	internal void SchemaTree(XmlDocument xd, XmlWriter xmlWriter, DataSet ds, DataTable dt, bool writeHierarchy) { }

	// RVA: 0x1ADCB40 Offset: 0x1ADB140 VA: 0x181ADCB40
	internal XmlElement SchemaTree(XmlDocument xd, DataTable dt) { }

	// RVA: 0x1AD72D0 Offset: 0x1AD58D0 VA: 0x181AD72D0
	internal XmlElement FillDataSetElement(XmlDocument xd, DataSet ds, DataTable dt) { }

	// RVA: 0x1ADF910 Offset: 0x1ADDF10 VA: 0x181ADF910
	internal void SetPath(XmlWriter xw) { }

	// RVA: 0x1ADC7C0 Offset: 0x1ADADC0 VA: 0x181ADC7C0
	internal void Save(DataSet ds, XmlWriter xw) { }

	// RVA: 0x1ADC940 Offset: 0x1ADAF40 VA: 0x181ADC940
	internal void Save(DataTable dt, XmlWriter xw) { }

	// RVA: 0x1ADC7F0 Offset: 0x1ADADF0 VA: 0x181ADC7F0
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw) { }

	// RVA: 0x1ADC810 Offset: 0x1ADAE10 VA: 0x181ADC810
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy) { }

	// RVA: 0x1ADCA10 Offset: 0x1ADB010 VA: 0x181ADCA10
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy, Converter<Type, string> multipleTargetConverter) { }

	// RVA: 0x1AD9530 Offset: 0x1AD7B30 VA: 0x181AD9530
	internal XmlElement HandleRelation(DataRelation rel, XmlDocument dc) { }

	// RVA: 0x1AD78D0 Offset: 0x1AD5ED0 VA: 0x181AD78D0
	private static XmlElement FindSimpleType(XmlElement schema, string name) { }

	// RVA: 0x1AD8460 Offset: 0x1AD6A60 VA: 0x181AD8460
	internal XmlElement GetSchema(string NamespaceURI) { }

	// RVA: 0x1AD86C0 Offset: 0x1AD6CC0 VA: 0x181AD86C0
	internal void HandleColumnType(DataColumn col, XmlDocument dc, XmlElement root, XmlElement schema) { }

	// RVA: 0x1AD4C40 Offset: 0x1AD3240 VA: 0x181AD4C40
	internal void AddColumnProperties(DataColumn col, XmlElement root) { }

	// RVA: 0x1AD7A20 Offset: 0x1AD6020 VA: 0x181AD7A20
	private string FindTargetNamespace(DataTable table) { }

	// RVA: 0x1AD8B30 Offset: 0x1AD7130 VA: 0x181AD8B30
	internal XmlElement HandleColumn(DataColumn col, XmlDocument dc, XmlElement schema, bool fWriteOrdinal) { }

	// RVA: 0x1AE0AB0 Offset: 0x1ADF0B0 VA: 0x181AE0AB0
	internal static string TranslateAcceptRejectRule(AcceptRejectRule rule) { }

	// RVA: 0x1AE0B00 Offset: 0x1ADF100 VA: 0x181AE0B00
	internal static string TranslateRule(Rule rule) { }

	// RVA: 0x1AD61E0 Offset: 0x1AD47E0 VA: 0x181AD61E0
	internal void AppendChildWithoutRef(XmlElement node, string Namespace, XmlElement el, string refString) { }

	// RVA: 0x1AD7B50 Offset: 0x1AD6150 VA: 0x181AD7B50
	internal XmlElement FindTypeNode(XmlElement node, string strType) { }

	// RVA: 0x1AD9AD0 Offset: 0x1AD80D0 VA: 0x181AD9AD0
	internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema) { }

	// RVA: 0x1ADC360 Offset: 0x1ADA960 VA: 0x181ADC360
	private bool HasMixedColumns(DataTable table) { }

	// RVA: 0x1AD65B0 Offset: 0x1AD4BB0 VA: 0x181AD65B0
	internal static bool AutoGenerated(DataColumn col) { }

	// RVA: 0x1AD69C0 Offset: 0x1AD4FC0 VA: 0x181AD69C0
	internal static bool AutoGenerated(DataRelation rel) { }

	// RVA: 0x1AD6290 Offset: 0x1AD4890 VA: 0x181AD6290
	internal static bool AutoGenerated(UniqueConstraint unique) { }

	// RVA: 0x1AD69B0 Offset: 0x1AD4FB0 VA: 0x181AD69B0
	private bool AutoGenerated(ForeignKeyConstraint fk) { }

	// RVA: 0x1AD6370 Offset: 0x1AD4970 VA: 0x181AD6370
	internal static bool AutoGenerated(ForeignKeyConstraint fk, bool checkRelation) { }

	// RVA: 0x1ADC780 Offset: 0x1ADAD80 VA: 0x181ADC780
	private bool IsAutoGenerated(object o) { }

	// RVA: 0x1AD9AF0 Offset: 0x1AD80F0 VA: 0x181AD9AF0
	internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema, bool genNested) { }

	// RVA: 0x1ADF760 Offset: 0x1ADDD60 VA: 0x181ADF760
	private void SetMSDataAttribute(XmlElement root, Type type) { }

}

internal sealed class XmlDataTreeWriter // TypeDefIndex: 4332
{	// Fields
	private XmlWriter _xmlw; // 0x10
	private DataSet _ds; // 0x18
	private DataTable _dt; // 0x20
	private ArrayList _dTables; // 0x28
	private DataTable[] _topLevelTables; // 0x30
	private bool _fFromTable; // 0x38
	private bool _isDiffgram; // 0x39
	private Hashtable _rowsOrder; // 0x40
	private bool _writeHierarchy; // 0x48

	// Methods

	// RVA: 0x1AD0A60 Offset: 0x1ACF060 VA: 0x181AD0A60
	internal void .ctor(DataSet ds) { }

	// RVA: 0x1AD0CE0 Offset: 0x1ACF2E0 VA: 0x181AD0CE0
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0x1ACE250 Offset: 0x1ACC850 VA: 0x181ACE250
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0x1ACDF90 Offset: 0x1ACC590 VA: 0x181ACDF90
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0x1ACE830 Offset: 0x1ACCE30 VA: 0x181ACE830
	internal static bool RowHasErrors(DataRow row) { }

	// RVA: 0x1ACE910 Offset: 0x1ACCF10 VA: 0x181ACE910
	internal void SaveDiffgramData(XmlWriter xw, Hashtable rowsOrder) { }

	// RVA: 0x1ACEEA0 Offset: 0x1ACD4A0 VA: 0x181ACEEA0
	internal void Save(XmlWriter xw, bool writeSchema) { }

	// RVA: 0x1ACE510 Offset: 0x1ACCB10 VA: 0x181ACE510
	private ArrayList GetNestedChildRelations(DataRow row) { }

	// RVA: 0x1ACF720 Offset: 0x1ACDD20 VA: 0x181ACF720
	internal void XmlDataRowWriter(DataRow row, string encodedTableName) { }

	// RVA: 0x1ACE780 Offset: 0x1ACCD80 VA: 0x181ACE780
	internal static bool PreserveSpace(object value) { }

}

public sealed class SqlXml : INullable, IXmlSerializable // TypeDefIndex: 4359
{	// Fields
	private static readonly Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> s_sqlReaderDelegate; // 0x0
	private static readonly XmlReaderSettings s_defaultXmlReaderSettings; // 0x8
	private static readonly XmlReaderSettings s_defaultXmlReaderSettingsCloseInput; // 0x10
	private static MethodInfo s_createSqlReaderMethodInfo; // 0x18
	private MethodInfo _createSqlReaderMethodInfo; // 0x10
	private bool _fNotNull; // 0x18
	private Stream _stream; // 0x20
	private bool _firstCreateReader; // 0x28

	// Properties
	private static MethodInfo CreateSqlReaderMethodInfo { get; }
	public bool IsNull { get; }

	// Methods

	// RVA: 0xCCCC80 Offset: 0xCCB280 VA: 0x180CCCC80
	public void .ctor() { }

	// RVA: 0xCCC360 Offset: 0xCCA960 VA: 0x180CCC360
	public XmlReader CreateReader() { }

	// RVA: 0xCCC5E0 Offset: 0xCCABE0 VA: 0x180CCC5E0
	internal static XmlReader CreateSqlXmlReader(Stream stream, bool closeInput = False, bool throwTargetInvocationExceptions = False) { }

	// RVA: 0xCCC510 Offset: 0xCCAB10 VA: 0x180CCC510
	private static Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> CreateSqlReaderDelegate() { }

	// RVA: 0xCCCCB0 Offset: 0xCCB2B0 VA: 0x180CCCCB0
	private static MethodInfo get_CreateSqlReaderMethodInfo() { }

	// RVA: 0xCCAED0 Offset: 0xCC94D0 VA: 0x180CCAED0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0xCCC7D0 Offset: 0xCCADD0 VA: 0x180CCC7D0
	private void SetNull() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xCCC800 Offset: 0xCCAE00 VA: 0x180CCC800 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0xCCC9C0 Offset: 0xCCAFC0 VA: 0x180CCC9C0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xCCC770 Offset: 0xCCAD70 VA: 0x180CCC770
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCCCAD0 Offset: 0xCCB0D0 VA: 0x180CCCAD0
	private static void .cctor() { }

}

internal sealed class SqlXmlStreamWrapper : Stream // TypeDefIndex: 4360
{	// Fields
	private Stream _stream; // 0x28
	private long _lPosition; // 0x30
	private bool _isClosed; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0xCCC060 Offset: 0xCCA660 VA: 0x180CCC060
	internal void .ctor(Stream stream) { }

	// RVA: 0xCCC0E0 Offset: 0xCCA6E0 VA: 0x180CCC0E0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0xCCC130 Offset: 0xCCA730 VA: 0x180CCC130 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0xCCC180 Offset: 0xCCA780 VA: 0x180CCC180 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0xCCC1D0 Offset: 0xCCA7D0 VA: 0x180CCC1D0 Slot: 10
	public override long get_Length() { }

	// RVA: 0xCCC240 Offset: 0xCCA840 VA: 0x180CCC240 Slot: 11
	public override long get_Position() { }

	// RVA: 0xCCC2A0 Offset: 0xCCA8A0 VA: 0x180CCC2A0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0xCCB8B0 Offset: 0xCC9EB0 VA: 0x180CCB8B0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xCCB6D0 Offset: 0xCC9CD0 VA: 0x180CCB6D0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0xCCBE90 Offset: 0xCCA490 VA: 0x180CCBE90 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0xCCB5A0 Offset: 0xCC9BA0 VA: 0x180CCB5A0 Slot: 28
	public override int ReadByte() { }

	// RVA: 0xCCBDB0 Offset: 0xCCA3B0 VA: 0x180CCBDB0 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0xCCBAC0 Offset: 0xCCA0C0 VA: 0x180CCBAC0 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0xCCB500 Offset: 0xCC9B00 VA: 0x180CCB500 Slot: 18
	public override void Flush() { }

	// RVA: 0xCCB490 Offset: 0xCC9A90 VA: 0x180CCB490 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0xCCBBF0 Offset: 0xCCA1F0 VA: 0x180CCBBF0
	private void ThrowIfStreamCannotSeek(string method) { }

	// RVA: 0xCCBB50 Offset: 0xCCA150 VA: 0x180CCBB50
	private void ThrowIfStreamCannotRead(string method) { }

	// RVA: 0xCCBC90 Offset: 0xCCA290 VA: 0x180CCBC90
	private void ThrowIfStreamCannotWrite(string method) { }

	// RVA: 0xCCBD30 Offset: 0xCCA330 VA: 0x180CCBD30
	private void ThrowIfStreamClosed(string method) { }

	// RVA: 0xCCB520 Offset: 0xCC9B20 VA: 0x180CCB520
	private bool IsStreamClosed() { }

}

public static class XRDevice // TypeDefIndex: 4768
{
// Namespace: 
internal class <Module> // TypeDefIndex: 4767

// Namespace: UnityEngine.XR
[NativeConditionalAttribute] // RVA: 0xC1B50 Offset: 0xC0F50 VA: 0x1800C1B50
public static class XRDevice // TypeDefIndex: 4768
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static Action<string> deviceLoaded; // 0x13430

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2323140 Offset: 0x2321740 VA: 0x182323140
	private static void InvokeDeviceLoaded(string loadedDeviceName) { }

	// RVA: 0x23231F0 Offset: 0x23217F0 VA: 0x1823231F0
	private static void .cctor() { }

}

public sealed class XName : IEquatable<XName>, ISerializable // TypeDefIndex: 5815
{
// Namespace: 
internal class <Module> // TypeDefIndex: 5814

// Namespace: System.Xml.Linq
[KnownTypeAttribute] // RVA: 0xE0EC0 Offset: 0xE02C0 VA: 0x1800E0EC0
[Serializable]
public sealed class XName : IEquatable<XName>, ISerializable // TypeDefIndex: 5815
	// Fields
	private XNamespace ns; // 0x10
	private string localName; // 0x18
	private int hashCode; // 0x20

	// Properties
	public string LocalName { get; }
	public XNamespace Namespace { get; }
	public string NamespaceName { get; }

	// Methods

	// RVA: 0x221F320 Offset: 0x221D920 VA: 0x18221F320
	internal void .ctor(XNamespace ns, string localName) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_LocalName() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public XNamespace get_Namespace() { }

	// RVA: 0xB292C0 Offset: 0xB278C0 VA: 0x180B292C0
	public string get_NamespaceName() { }

	// RVA: 0x221F2A0 Offset: 0x221D8A0 VA: 0x18221F2A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x221EEA0 Offset: 0x221D4A0 VA: 0x18221EEA0
	public static XName Get(string expandedName) { }

	// RVA: 0x221F0D0 Offset: 0x221D6D0 VA: 0x18221F0D0
	public static XName Get(string localName, string namespaceName) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x221F430 Offset: 0x221DA30 VA: 0x18221F430
	public static XName op_Implicit(string expandedName) { }

	// RVA: 0xAE6170 Offset: 0xAE4770 VA: 0x180AE6170 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xAE6170 Offset: 0xAE4770 VA: 0x180AE6170
	public static bool op_Equality(XName left, XName right) { }

	// RVA: 0xAE6170 Offset: 0xAE4770 VA: 0x180AE6170 Slot: 4
	private bool System.IEquatable<System.Xml.Linq.XName>.Equals(XName other) { }

	// RVA: 0x221F1D0 Offset: 0x221D7D0 VA: 0x18221F1D0 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x221F400 Offset: 0x221DA00 VA: 0x18221F400
	internal void .ctor() { }

}

public sealed class XNamespace // TypeDefIndex: 5817
{	// Fields
	private static XHashtable<WeakReference> namespaces; // 0x0
	private static WeakReference refNone; // 0x8
	private static WeakReference refXml; // 0x10
	private static WeakReference refXmlns; // 0x18
	private string namespaceName; // 0x10
	private int hashCode; // 0x18
	private XHashtable<XName> names; // 0x20

	// Properties
	public string NamespaceName { get; }
	public static XNamespace None { get; }
	public static XNamespace Xml { get; }
	public static XNamespace Xmlns { get; }

	// Methods

	// RVA: 0x221FB80 Offset: 0x221E180 VA: 0x18221FB80
	internal void .ctor(string namespaceName) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_NamespaceName() { }

	// RVA: 0x221F730 Offset: 0x221DD30 VA: 0x18221F730
	public XName GetName(string localName) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 3
	public override string ToString() { }

	// RVA: 0x221FC60 Offset: 0x221E260 VA: 0x18221FC60
	public static XNamespace get_None() { }

	// RVA: 0x221FCB0 Offset: 0x221E2B0 VA: 0x18221FCB0
	public static XNamespace get_Xml() { }

	// RVA: 0x221FD00 Offset: 0x221E300 VA: 0x18221FD00
	public static XNamespace get_Xmlns() { }

	// RVA: 0x221F7C0 Offset: 0x221DDC0 VA: 0x18221F7C0
	public static XNamespace Get(string namespaceName) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x221FD50 Offset: 0x221E350 VA: 0x18221FD50
	public static XNamespace op_Implicit(string namespaceName) { }

	// RVA: 0xAE6170 Offset: 0xAE4770 VA: 0x180AE6170 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xAE6170 Offset: 0xAE4770 VA: 0x180AE6170
	public static bool op_Equality(XNamespace left, XNamespace right) { }

	// RVA: 0x12A4AF0 Offset: 0x12A30F0 VA: 0x1812A4AF0
	public static bool op_Inequality(XNamespace left, XNamespace right) { }

	// RVA: 0x221F5B0 Offset: 0x221DBB0 VA: 0x18221F5B0
	internal XName GetName(string localName, int index, int count) { }

	// RVA: 0x221F830 Offset: 0x221DE30 VA: 0x18221F830
	internal static XNamespace Get(string namespaceName, int index, int count) { }

	// RVA: 0x14B70F0 Offset: 0x14B56F0 VA: 0x1814B70F0
	private static string ExtractLocalName(XName n) { }

	// RVA: 0x221F530 Offset: 0x221DB30 VA: 0x18221F530
	private static string ExtractNamespace(WeakReference r) { }

	// RVA: 0x221F440 Offset: 0x221DA40 VA: 0x18221F440
	private static XNamespace EnsureNamespace(ref WeakReference refNmsp, string namespaceName) { }

}

public abstract class XObject : IXmlLineInfo // TypeDefIndex: 5822
{	// Fields
	internal XContainer parent; // 0x10
	internal object annotations; // 0x18

	// Properties
	public string BaseUri { get; }
	public abstract XmlNodeType NodeType { get; }
	public XElement Parent { get; }
	private int System.Xml.IXmlLineInfo.LineNumber { get; }
	private int System.Xml.IXmlLineInfo.LinePosition { get; }
	internal bool HasBaseUri { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x2220D90 Offset: 0x221F390 VA: 0x182220D90
	public string get_BaseUri() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x2220E50 Offset: 0x221F450 VA: 0x182220E50
	public XElement get_Parent() { }

	// RVA: 0x22203B0 Offset: 0x221E9B0 VA: 0x1822203B0
	public void AddAnnotation(object annotation) { }

	// RVA: 0x2220680 Offset: 0x221EC80 VA: 0x182220680
	public object Annotation(Type type) { }

	// RVA: -1 Offset: -1
	public T Annotation<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0F70 Offset: 0xBDF570 VA: 0x180BE0F70
	|-XObject.Annotation<object>
	|-XObject.Annotation<BaseUriAnnotation>
	|-XObject.Annotation<LineInfoAnnotation>
	|-XObject.Annotation<XObjectChangeAnnotation>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xE1040 Offset: 0xE0440 VA: 0x1800E1040
	// RVA: -1 Offset: -1
	public IEnumerable<T> Annotations<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B48B0 Offset: 0x4B2EB0 VA: 0x1804B48B0
	|-XObject.Annotations<object>
	|-XObject.Annotations<XObjectChangeAnnotation>
	*/

	// RVA: 0x2220CB0 Offset: 0x221F2B0 VA: 0x182220CB0 Slot: 4
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x2220CF0 Offset: 0x221F2F0 VA: 0x182220CF0 Slot: 5
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x2220D40 Offset: 0x221F340 VA: 0x182220D40 Slot: 6
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x2220E10 Offset: 0x221F410 VA: 0x182220E10
	internal bool get_HasBaseUri() { }

	// RVA: 0x22209F0 Offset: 0x221EFF0 VA: 0x1822209F0
	internal bool NotifyChanged(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x2220AA0 Offset: 0x221F0A0 VA: 0x182220AA0
	internal bool NotifyChanging(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x2220B50 Offset: 0x221F150 VA: 0x182220B50
	internal void SetBaseUri(string baseUri) { }

	// RVA: 0x2220BD0 Offset: 0x221F1D0 VA: 0x182220BD0
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x2220C50 Offset: 0x221F250 VA: 0x182220C50
	internal bool SkipNotify() { }

	// RVA: 0x22207E0 Offset: 0x221EDE0 VA: 0x1822207E0
	internal SaveOptions GetSaveOptionsFromAnnotations() { }

}

private sealed class XObject.<Annotations>d__16<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 5823
{	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	public XObject <>4__this; // 0x0
	private object[] <a>5__1; // 0x0
	private int <i>5__2; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144ABD0 Offset: 0x14491D0 VA: 0x18144ABD0
	|-XObject.<Annotations>d__16<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	|-XObject.<Annotations>d__16<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A4C4D0 Offset: 0x1A4AAD0 VA: 0x181A4C4D0
	|-XObject.<Annotations>d__16<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-XObject.<Annotations>d__16<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A4C7E0 Offset: 0x1A4ADE0 VA: 0x181A4C7E0
	|-XObject.<Annotations>d__16<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-XObject.<Annotations>d__16<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A4C720 Offset: 0x1A4AD20 VA: 0x181A4C720
	|-XObject.<Annotations>d__16<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16508D0 Offset: 0x164EED0 VA: 0x1816508D0
	|-XObject.<Annotations>d__16<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

internal class XObjectChangeAnnotation // TypeDefIndex: 5827
{	// Fields
	internal EventHandler<XObjectChangeEventArgs> changing; // 0x10
	internal EventHandler<XObjectChangeEventArgs> changed; // 0x18

}

public enum XObjectChange // TypeDefIndex: 5828
{	// Fields
	public int value__; // 0x0
	public const XObjectChange Add = 0;
	public const XObjectChange Remove = 1;
	public const XObjectChange Name = 2;
	public const XObjectChange Value = 3;

}

public class XObjectChangeEventArgs : EventArgs // TypeDefIndex: 5829
{	// Fields
	private XObjectChange objectChange; // 0x10
	public static readonly XObjectChangeEventArgs Add; // 0x0
	public static readonly XObjectChangeEventArgs Remove; // 0x8
	public static readonly XObjectChangeEventArgs Name; // 0x10
	public static readonly XObjectChangeEventArgs Value; // 0x18

	// Methods

	// RVA: 0x2220350 Offset: 0x221E950 VA: 0x182220350
	public void .ctor(XObjectChange objectChange) { }

	// RVA: 0x2220150 Offset: 0x221E750 VA: 0x182220150
	private static void .cctor() { }

}

public abstract class XNode : XObject // TypeDefIndex: 5830
{	// Fields
	internal XNode next; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x2220090 Offset: 0x221E690 VA: 0x182220090
	public void Remove() { }

	// RVA: 0x2220120 Offset: 0x221E720 VA: 0x182220120 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void WriteTo(XmlWriter writer);

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	internal virtual void AppendText(StringBuilder sb) { }

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract XNode CloneNode();

	// RVA: 0x221FDA0 Offset: 0x221E3A0 VA: 0x18221FDA0
	private string GetXmlString(SaveOptions o) { }

}

public class XText : XNode // TypeDefIndex: 5831
{	// Fields
	internal string text; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x22181B0 Offset: 0x22167B0 VA: 0x1822181B0
	public void .ctor(string value) { }

	// RVA: 0x2218120 Offset: 0x2216720 VA: 0x182218120
	public void .ctor(XText other) { }

	// RVA: 0xAC2530 Offset: 0xAC0B30 VA: 0x180AC2530 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public string get_Value() { }

	// RVA: 0x2221500 Offset: 0x221FB00 VA: 0x182221500
	public void set_Value(string value) { }

	// RVA: 0x2221410 Offset: 0x221FA10 VA: 0x182221410 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x2221330 Offset: 0x221F930 VA: 0x182221330 Slot: 9
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x2221360 Offset: 0x221F960 VA: 0x182221360 Slot: 10
	internal override XNode CloneNode() { }

}

public class XCData : XText // TypeDefIndex: 5832
{	// Properties
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0x22181B0 Offset: 0x22167B0 VA: 0x1822181B0
	public void .ctor(string value) { }

	// RVA: 0x2218120 Offset: 0x2216720 VA: 0x182218120
	public void .ctor(XCData other) { }

	// RVA: 0xE38BC0 Offset: 0xE371C0 VA: 0x180E38BC0 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x2218090 Offset: 0x2216690 VA: 0x182218090 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x2217FE0 Offset: 0x22165E0 VA: 0x182217FE0 Slot: 10
	internal override XNode CloneNode() { }

}

public abstract class XContainer : XNode // TypeDefIndex: 5833
{	// Fields
	internal object content; // 0x28

	// Properties
	public XNode LastNode { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x221C120 Offset: 0x221A720 VA: 0x18221C120
	internal void .ctor(XContainer other) { }

	// RVA: 0x221C260 Offset: 0x221A860 VA: 0x18221C260
	public XNode get_LastNode() { }

	// RVA: 0x2219370 Offset: 0x2217970 VA: 0x182219370
	public void Add(object content) { }

	[IteratorStateMachineAttribute] // RVA: 0xE1930 Offset: 0xE0D30 VA: 0x1800E1930
	// RVA: 0x221A100 Offset: 0x2218700 VA: 0x18221A100
	public IEnumerable<XNode> Nodes() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 11
	internal virtual void AddAttribute(XAttribute a) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	internal virtual void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x22184A0 Offset: 0x2216AA0 VA: 0x1822184A0
	internal void AddContentSkipNotify(object content) { }

	// RVA: 0x2218D20 Offset: 0x2217320 VA: 0x182218D20
	internal void AddNode(XNode n) { }

	// RVA: 0x2218C80 Offset: 0x2217280 VA: 0x182218C80
	internal void AddNodeSkipNotify(XNode n) { }

	// RVA: 0x2218F90 Offset: 0x2217590 VA: 0x182218F90
	internal void AddString(string s) { }

	// RVA: 0x2218DC0 Offset: 0x22173C0 VA: 0x182218DC0
	internal void AddStringSkipNotify(string s) { }

	// RVA: 0x22198C0 Offset: 0x2217EC0 VA: 0x1822198C0
	internal void AppendNode(XNode n) { }

	// RVA: 0x22197C0 Offset: 0x2217DC0 VA: 0x1822197C0
	internal void AppendNodeSkipNotify(XNode n) { }

	// RVA: 0x22199F0 Offset: 0x2217FF0 VA: 0x1822199F0 Slot: 9
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x2219AF0 Offset: 0x22180F0 VA: 0x182219AF0
	internal void ConvertTextToNode() { }

	// RVA: 0x2219BE0 Offset: 0x22181E0 VA: 0x182219BE0
	internal static string GetDateTimeString(DateTime value) { }

	// RVA: 0x2219C40 Offset: 0x2218240 VA: 0x182219C40
	internal static string GetStringValue(object value) { }

	// RVA: 0x221B120 Offset: 0x2219720 VA: 0x18221B120
	internal void ReadContentFrom(XmlReader r) { }

	// RVA: 0x221A170 Offset: 0x2218770 VA: 0x18221A170
	internal void ReadContentFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x221BD70 Offset: 0x221A370 VA: 0x18221BD70
	internal void RemoveNode(XNode n) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 13
	internal virtual void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 14
	internal virtual void ValidateString(string s) { }

	// RVA: 0x221BF80 Offset: 0x221A580 VA: 0x18221BF80
	internal void WriteContentTo(XmlWriter writer) { }

}

private sealed class XContainer.<Nodes>d__18 : IEnumerable<XNode>, IEnumerable, IEnumerator<XNode>, IDisposable, IEnumerator // TypeDefIndex: 5834
{	// Fields
	private int <>1__state; // 0x10
	private XNode <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public XContainer <>4__this; // 0x28
	private XNode <n>5__1; // 0x30

	// Properties
	private XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD88200 Offset: 0xD86800 VA: 0x180D88200
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2217250 Offset: 0x2215850 VA: 0x182217250 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2217510 Offset: 0x2215B10 VA: 0x182217510 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2217470 Offset: 0x2215A70 VA: 0x182217470 Slot: 4
	private IEnumerator<XNode> System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2217470 Offset: 0x2215A70 VA: 0x182217470 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

public class XElement : XContainer, IXmlSerializable // TypeDefIndex: 5836
{	// Fields
	internal XName name; // 0x30
	internal XAttribute lastAttr; // 0x38

	// Properties
	public bool IsEmpty { get; }
	public XName Name { get; }
	public override XmlNodeType NodeType { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x221ECA0 Offset: 0x221D2A0 VA: 0x18221ECA0
	public void .ctor(XName name) { }

	// RVA: 0x221EB20 Offset: 0x221D120 VA: 0x18221EB20
	public void .ctor(XElement other) { }

	// RVA: 0x221ED30 Offset: 0x221D330 VA: 0x18221ED30
	public void .ctor(XStreamingElement other) { }

	// RVA: 0x221EDD0 Offset: 0x221D3D0 VA: 0x18221EDD0
	public bool get_IsEmpty() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public XName get_Name() { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x221EDE0 Offset: 0x221D3E0 VA: 0x18221EDE0
	public string get_Value() { }

	// RVA: 0x221D900 Offset: 0x221BF00 VA: 0x18221D900
	public XAttribute Attribute(XName name) { }

	// RVA: 0x221D940 Offset: 0x221BF40 VA: 0x18221D940
	public IEnumerable<XAttribute> Attributes() { }

	// RVA: 0x221DD30 Offset: 0x221C330 VA: 0x18221DD30
	public string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x221EA50 Offset: 0x221D050 VA: 0x18221EA50 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 15
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x221E680 Offset: 0x221CC80 VA: 0x18221E680 Slot: 16
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xE59ED0 Offset: 0xE584D0 VA: 0x180E59ED0 Slot: 17
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x221D490 Offset: 0x221BA90 VA: 0x18221D490 Slot: 11
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x221D310 Offset: 0x221B910 VA: 0x18221D310 Slot: 12
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x221D780 Offset: 0x221BD80 VA: 0x18221D780
	internal void AppendAttribute(XAttribute a) { }

	// RVA: 0x221D700 Offset: 0x221BD00 VA: 0x18221D700
	internal void AppendAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x221D9D0 Offset: 0x221BFD0 VA: 0x18221D9D0 Slot: 10
	internal override XNode CloneNode() { }

	[IteratorStateMachineAttribute] // RVA: 0xE5EE0 Offset: 0xE52E0 VA: 0x1800E5EE0
	// RVA: 0x221DB80 Offset: 0x221C180 VA: 0x18221DB80
	private IEnumerable<XAttribute> GetAttributes(XName name) { }

	// RVA: 0x221DC10 Offset: 0x221C210 VA: 0x18221DC10
	private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope) { }

	// RVA: 0x221DF80 Offset: 0x221C580 VA: 0x18221DF80
	private void ReadElementFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x221E600 Offset: 0x221CC00 VA: 0x18221E600
	internal void SetEndElementLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x221E870 Offset: 0x221CE70 VA: 0x18221E870 Slot: 13
	internal override void ValidateNode(XNode node, XNode previous) { }

}

private sealed class XElement.<GetAttributes>d__105 : IEnumerable<XAttribute>, IEnumerable, IEnumerator<XAttribute>, IDisposable, IEnumerator // TypeDefIndex: 5837
{	// Fields
	private int <>1__state; // 0x10
	private XAttribute <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public XElement <>4__this; // 0x28
	private XAttribute <a>5__1; // 0x30
	private XName name; // 0x38
	public XName <>3__name; // 0x40

	// Properties
	private XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD88200 Offset: 0xD86800 VA: 0x180D88200
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2217070 Offset: 0x2215670 VA: 0x182217070 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2217200 Offset: 0x2215800 VA: 0x182217200 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2217150 Offset: 0x2215750 VA: 0x182217150 Slot: 4
	private IEnumerator<XAttribute> System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2217150 Offset: 0x2215750 VA: 0x182217150 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

public class XDocument : XContainer // TypeDefIndex: 5843
{	// Fields
	private XDeclaration declaration; // 0x30

	// Properties
	public XDeclaration Declaration { get; set; }
	public override XmlNodeType NodeType { get; }
	public XElement Root { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x221D1F0 Offset: 0x221B7F0 VA: 0x18221D1F0
	public void .ctor(XDocument other) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public XDeclaration get_Declaration() { }

	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	public void set_Declaration(XDeclaration value) { }

	// RVA: 0xE67360 Offset: 0xE65960 VA: 0x180E67360 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x221D2D0 Offset: 0x221B8D0 VA: 0x18221D2D0
	public XElement get_Root() { }

	// RVA: 0x221D0D0 Offset: 0x221B6D0 VA: 0x18221D0D0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x221CA50 Offset: 0x221B050 VA: 0x18221CA50 Slot: 11
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x221C9E0 Offset: 0x221AFE0 VA: 0x18221C9E0 Slot: 12
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x221CAC0 Offset: 0x221B0C0 VA: 0x18221CAC0 Slot: 10
	internal override XNode CloneNode() { }

	// RVA: -1 Offset: -1
	private T GetFirstNode<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0E80 Offset: 0xBDF480 VA: 0x180BE0E80
	|-XDocument.GetFirstNode<object>
	|-XDocument.GetFirstNode<XElement>
	*/

	// RVA: 0x221CBD0 Offset: 0x221B1D0 VA: 0x18221CBD0
	internal static bool IsWhitespace(string s) { }

	// RVA: 0x221CD80 Offset: 0x221B380 VA: 0x18221CD80 Slot: 13
	internal override void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x221CC50 Offset: 0x221B250 VA: 0x18221CC50
	private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter) { }

	// RVA: 0x221D010 Offset: 0x221B610 VA: 0x18221D010 Slot: 14
	internal override void ValidateString(string s) { }

}

public class XComment : XNode // TypeDefIndex: 5844
{	// Fields
	internal string value; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x2218410 Offset: 0x2216A10 VA: 0x182218410
	public void .ctor(string value) { }

	// RVA: 0x2218380 Offset: 0x2216980 VA: 0x182218380
	public void .ctor(XComment other) { }

	// RVA: 0x8C1310 Offset: 0x8BF910 VA: 0x1808C1310 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public string get_Value() { }

	// RVA: 0x22182F0 Offset: 0x22168F0 VA: 0x1822182F0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x2218240 Offset: 0x2216840 VA: 0x182218240 Slot: 10
	internal override XNode CloneNode() { }

}

public class XProcessingInstruction : XNode // TypeDefIndex: 5845
{	// Fields
	internal string target; // 0x28
	internal string data; // 0x30

	// Properties
	public string Data { get; }
	public override XmlNodeType NodeType { get; }
	public string Target { get; }

	// Methods

	// RVA: 0x2221110 Offset: 0x221F710 VA: 0x182221110
	public void .ctor(string target, string data) { }

	// RVA: 0x2221290 Offset: 0x221F890 VA: 0x182221290
	public void .ctor(XProcessingInstruction other) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_Data() { }

	// RVA: 0xBA0120 Offset: 0xB9E720 VA: 0x180BA0120 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public string get_Target() { }

	// RVA: 0x2221080 Offset: 0x221F680 VA: 0x182221080 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x2220ED0 Offset: 0x221F4D0 VA: 0x182220ED0 Slot: 10
	internal override XNode CloneNode() { }

	// RVA: 0x2220F90 Offset: 0x221F590 VA: 0x182220F90
	private static void ValidateName(string name) { }

}

public class XDeclaration // TypeDefIndex: 5846
{	// Fields
	private string version; // 0x10
	private string encoding; // 0x18
	private string standalone; // 0x20

	// Properties
	public string Encoding { get; }
	public string Standalone { get; }
	public string Version { get; }

	// Methods

	// RVA: 0x14730A0 Offset: 0x14716A0 VA: 0x1814730A0
	public void .ctor(string version, string encoding, string standalone) { }

	// RVA: 0x221C540 Offset: 0x221AB40 VA: 0x18221C540
	public void .ctor(XDeclaration other) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Encoding() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Standalone() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Version() { }

	// RVA: 0x221C3F0 Offset: 0x221A9F0 VA: 0x18221C3F0 Slot: 3
	public override string ToString() { }

}

public class XDocumentType : XNode // TypeDefIndex: 5847
{	// Fields
	private string name; // 0x28
	private string publicId; // 0x30
	private string systemId; // 0x38
	private string internalSubset; // 0x40
	private IDtdInfo dtdInfo; // 0x48

	// Properties
	public string InternalSubset { get; }
	public string Name { get; }
	public override XmlNodeType NodeType { get; }
	public string PublicId { get; }
	public string SystemId { get; }

	// Methods

	// RVA: 0x221C920 Offset: 0x221AF20 VA: 0x18221C920
	public void .ctor(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x221C780 Offset: 0x221AD80 VA: 0x18221C780
	public void .ctor(XDocumentType other) { }

	// RVA: 0x221C850 Offset: 0x221AE50 VA: 0x18221C850
	internal void .ctor(string name, string publicId, string systemId, string internalSubset, IDtdInfo dtdInfo) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public string get_InternalSubset() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public string get_Name() { }

	// RVA: 0x4A6020 Offset: 0x4A4620 VA: 0x1804A6020 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_PublicId() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public string get_SystemId() { }

	// RVA: 0x221C6E0 Offset: 0x221ACE0 VA: 0x18221C6E0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x221C5F0 Offset: 0x221ABF0 VA: 0x18221C5F0 Slot: 10
	internal override XNode CloneNode() { }

}

public class XAttribute : XObject // TypeDefIndex: 5848
{	// Fields
	internal XAttribute next; // 0x20
	internal XName name; // 0x28
	internal string value; // 0x30

	// Properties
	public bool IsNamespaceDeclaration { get; }
	public XName Name { get; }
	public override XmlNodeType NodeType { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x2217DC0 Offset: 0x22163C0 VA: 0x182217DC0
	public void .ctor(XName name, object value) { }

	// RVA: 0x2217EC0 Offset: 0x22164C0 VA: 0x182217EC0
	public void .ctor(XAttribute other) { }

	// RVA: 0x2217F60 Offset: 0x2216560 VA: 0x182217F60
	public bool get_IsNamespaceDeclaration() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public XName get_Name() { }

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_Value() { }

	// RVA: 0x22176B0 Offset: 0x2215CB0 VA: 0x1822176B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2217560 Offset: 0x2215B60 VA: 0x182217560
	internal string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x2217A50 Offset: 0x2216050 VA: 0x182217A50
	private static void ValidateAttribute(XName name, string value) { }

}

public class XStreamingElement // TypeDefIndex: 5849
{	// Fields
	internal XName name; // 0x10
	internal object content; // 0x18

}

internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument, IXmlNode // TypeDefIndex: 6111
{	// Fields
	private readonly XmlDocument _document; // 0x28

	// Properties
	public IXmlElement DocumentElement { get; }

	// Methods

	// RVA: 0xFA1910 Offset: 0xF9FF10 VA: 0x180FA1910
	public void .ctor(XmlDocument document) { }

	// RVA: 0xFA1C40 Offset: 0xFA0240 VA: 0x180FA1C40 Slot: 15
	public IXmlNode CreateComment(string data) { }

	// RVA: 0xFA1F30 Offset: 0xFA0530 VA: 0x180FA1F30 Slot: 16
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0xFA1BB0 Offset: 0xFA01B0 VA: 0x180FA1BB0 Slot: 17
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0xFA1FC0 Offset: 0xFA05C0 VA: 0x180FA1FC0 Slot: 18
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0xFA1EA0 Offset: 0xFA04A0 VA: 0x180FA1EA0 Slot: 19
	public IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0xFA2050 Offset: 0xFA0650 VA: 0x180FA2050 Slot: 20
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0xFA2110 Offset: 0xFA0710 VA: 0x180FA2110 Slot: 21
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0xFA1E00 Offset: 0xFA0400 VA: 0x180FA1E00 Slot: 22
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0xFA1D70 Offset: 0xFA0370 VA: 0x180FA1D70 Slot: 23
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0xFA1CD0 Offset: 0xFA02D0 VA: 0x180FA1CD0 Slot: 24
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0xFA1A30 Offset: 0xFA0030 VA: 0x180FA1A30 Slot: 25
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0xFA1AF0 Offset: 0xFA00F0 VA: 0x180FA1AF0 Slot: 26
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	// RVA: 0xFA21E0 Offset: 0xFA07E0 VA: 0x180FA21E0 Slot: 27
	public IXmlElement get_DocumentElement() { }

}

internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement, IXmlNode // TypeDefIndex: 6112
{	// Fields
	private readonly XmlElement _element; // 0x28

	// Properties
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0xFA1910 Offset: 0xF9FF10 VA: 0x180FA1910
	public void .ctor(XmlElement element) { }

	// RVA: 0xFA22C0 Offset: 0xFA08C0 VA: 0x180FA22C0 Slot: 15
	public void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0xFA2290 Offset: 0xFA0890 VA: 0x180FA2290 Slot: 16
	public string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0xFA23C0 Offset: 0xFA09C0 VA: 0x180FA23C0 Slot: 17
	public bool get_IsEmpty() { }

}

internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode // TypeDefIndex: 6113
{	// Fields
	private readonly XmlDeclaration _declaration; // 0x28

	// Properties
	public string Version { get; }
	public string Encoding { get; }
	public string Standalone { get; }

	// Methods

	// RVA: 0xFA1910 Offset: 0xF9FF10 VA: 0x180FA1910
	public void .ctor(XmlDeclaration declaration) { }

	// RVA: 0xFA1990 Offset: 0xF9FF90 VA: 0x180FA1990 Slot: 15
	public string get_Version() { }

	// RVA: 0xFA1950 Offset: 0xF9FF50 VA: 0x180FA1950 Slot: 16
	public string get_Encoding() { }

	// RVA: 0xFA1970 Offset: 0xF9FF70 VA: 0x180FA1970 Slot: 17
	public string get_Standalone() { }

}

internal class XmlDocumentTypeWrapper : XmlNodeWrapper, IXmlDocumentType, IXmlNode // TypeDefIndex: 6114
{	// Fields
	private readonly XmlDocumentType _documentType; // 0x28

	// Properties
	public string Name { get; }
	public string System { get; }
	public string Public { get; }
	public string InternalSubset { get; }
	public override string LocalName { get; }

	// Methods

	// RVA: 0xFA1910 Offset: 0xF9FF10 VA: 0x180FA1910
	public void .ctor(XmlDocumentType documentType) { }

	// RVA: 0xFA1A00 Offset: 0xFA0000 VA: 0x180FA1A00 Slot: 15
	public string get_Name() { }

	// RVA: 0xFA1970 Offset: 0xF9FF70 VA: 0x180FA1970 Slot: 16
	public string get_System() { }

	// RVA: 0xFA1950 Offset: 0xF9FF50 VA: 0x180FA1950 Slot: 17
	public string get_Public() { }

	// RVA: 0xFA19B0 Offset: 0xF9FFB0 VA: 0x180FA19B0 Slot: 18
	public string get_InternalSubset() { }

	// RVA: 0xFA19D0 Offset: 0xF9FFD0 VA: 0x180FA19D0 Slot: 13
	public override string get_LocalName() { }

}

internal class XmlNodeWrapper : IXmlNode // TypeDefIndex: 6115
{	// Fields
	private readonly XmlNode _node; // 0x10
	private List<IXmlNode> _childNodes; // 0x18
	private List<IXmlNode> _attributes; // 0x20

	// Properties
	public object WrappedNode { get; }
	public XmlNodeType NodeType { get; }
	public virtual string LocalName { get; }
	public List<IXmlNode> ChildNodes { get; }
	public List<IXmlNode> Attributes { get; }
	public IXmlNode ParentNode { get; }
	public string Value { get; set; }
	public string NamespaceUri { get; }

	// Methods

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	public void .ctor(XmlNode node) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 12
	public object get_WrappedNode() { }

	// RVA: 0xBC92E0 Offset: 0xBC78E0 VA: 0x180BC92E0 Slot: 4
	public XmlNodeType get_NodeType() { }

	// RVA: 0xBC9250 Offset: 0xBC7850 VA: 0x180BC9250 Slot: 13
	public virtual string get_LocalName() { }

	// RVA: 0xFA8670 Offset: 0xFA6C70 VA: 0x180FA8670 Slot: 6
	public List<IXmlNode> get_ChildNodes() { }

	// RVA: 0xFA7FE0 Offset: 0xFA65E0 VA: 0x180FA7FE0
	internal static IXmlNode WrapNode(XmlNode node) { }

	// RVA: 0xFA81D0 Offset: 0xFA67D0 VA: 0x180FA81D0 Slot: 7
	public List<IXmlNode> get_Attributes() { }

	// RVA: 0xFA8AE0 Offset: 0xFA70E0 VA: 0x180FA8AE0 Slot: 8
	public IXmlNode get_ParentNode() { }

	// RVA: 0xBC9280 Offset: 0xBC7880 VA: 0x180BC9280 Slot: 9
	public string get_Value() { }

	// RVA: 0xFA8C20 Offset: 0xFA7220 VA: 0x180FA8C20 Slot: 14
	public void set_Value(string value) { }

	// RVA: 0xFA7F10 Offset: 0xFA6510 VA: 0x180FA7F10 Slot: 10
	public IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0xB9F5D0 Offset: 0xB9DBD0 VA: 0x180B9F5D0 Slot: 11
	public string get_NamespaceUri() { }

}

internal class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration, IXmlNode // TypeDefIndex: 6121
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private XDeclaration <Declaration>k__BackingField; // 0x18

	// Properties
	internal XDeclaration Declaration { get; set; }
	public override XmlNodeType NodeType { get; }
	public string Version { get; }
	public string Encoding { get; }
	public string Standalone { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal XDeclaration get_Declaration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	private void set_Declaration(XDeclaration value) { }

	// RVA: 0xFA0040 Offset: 0xF9E640 VA: 0x180FA0040
	public void .ctor(XDeclaration declaration) { }

	// RVA: 0xE628D0 Offset: 0xE60ED0 VA: 0x180E628D0 Slot: 13
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xE57E40 Offset: 0xE56440 VA: 0x180E57E40 Slot: 21
	public string get_Version() { }

	// RVA: 0x8557E0 Offset: 0x853DE0 VA: 0x1808557E0 Slot: 22
	public string get_Encoding() { }

	// RVA: 0xE57D80 Offset: 0xE56380 VA: 0x180E57D80 Slot: 23
	public string get_Standalone() { }

}

internal class XDocumentTypeWrapper : XObjectWrapper, IXmlDocumentType, IXmlNode // TypeDefIndex: 6122
{	// Fields
	private readonly XDocumentType _documentType; // 0x18

	// Properties
	public string Name { get; }
	public string System { get; }
	public string Public { get; }
	public string InternalSubset { get; }
	public override string LocalName { get; }

	// Methods

	// RVA: 0xFA00C0 Offset: 0xF9E6C0 VA: 0x180FA00C0
	public void .ctor(XDocumentType documentType) { }

	// RVA: 0xFA0190 Offset: 0xF9E790 VA: 0x180FA0190 Slot: 21
	public string get_Name() { }

	// RVA: 0xE57DA0 Offset: 0xE563A0 VA: 0x180E57DA0 Slot: 22
	public string get_System() { }

	// RVA: 0x8557C0 Offset: 0x853DC0 VA: 0x1808557C0 Slot: 23
	public string get_Public() { }

	// RVA: 0xFA0140 Offset: 0xF9E740 VA: 0x180FA0140 Slot: 24
	public string get_InternalSubset() { }

	// RVA: 0xFA0160 Offset: 0xF9E760 VA: 0x180FA0160 Slot: 14
	public override string get_LocalName() { }

}

internal class XDocumentWrapper : XContainerWrapper, IXmlDocument, IXmlNode // TypeDefIndex: 6123
{	// Properties
	private XDocument Document { get; }
	public override List<IXmlNode> ChildNodes { get; }
	public IXmlElement DocumentElement { get; }

	// Methods

	// RVA: 0xFA0C80 Offset: 0xF9F280 VA: 0x180FA0C80
	private XDocument get_Document() { }

	// RVA: 0xF9FCE0 Offset: 0xF9E2E0 VA: 0x180F9FCE0
	public void .ctor(XDocument document) { }

	// RVA: 0xFA0AF0 Offset: 0xF9F0F0 VA: 0x180FA0AF0 Slot: 15
	public override List<IXmlNode> get_ChildNodes() { }

	// RVA: 0xFA0530 Offset: 0xF9EB30 VA: 0x180FA0530 Slot: 21
	public IXmlNode CreateComment(string text) { }

	// RVA: 0xFA08B0 Offset: 0xF9EEB0 VA: 0x180FA08B0 Slot: 22
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0xFA04B0 Offset: 0xF9EAB0 VA: 0x180FA04B0 Slot: 23
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0xFA0930 Offset: 0xF9EF30 VA: 0x180FA0930 Slot: 24
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0xFA0830 Offset: 0xF9EE30 VA: 0x180FA0830 Slot: 25
	public IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0xFA09B0 Offset: 0xF9EFB0 VA: 0x180FA09B0 Slot: 26
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0xFA0A50 Offset: 0xF9F050 VA: 0x180FA0A50 Slot: 27
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0xFA0760 Offset: 0xF9ED60 VA: 0x180FA0760 Slot: 28
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0xFA0690 Offset: 0xF9EC90 VA: 0x180FA0690 Slot: 29
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0xFA05B0 Offset: 0xF9EBB0 VA: 0x180FA05B0 Slot: 30
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0xFA03D0 Offset: 0xF9E9D0 VA: 0x180FA03D0 Slot: 31
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0xFA02E0 Offset: 0xF9E8E0 VA: 0x180FA02E0 Slot: 32
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	// RVA: 0xFA0BE0 Offset: 0xF9F1E0 VA: 0x180FA0BE0 Slot: 33
	public IXmlElement get_DocumentElement() { }

	// RVA: 0xFA01B0 Offset: 0xF9E7B0 VA: 0x180FA01B0 Slot: 19
	public override IXmlNode AppendChild(IXmlNode newChild) { }

}

internal class XTextWrapper : XObjectWrapper // TypeDefIndex: 6124
{	// Properties
	private XText Text { get; }
	public override string Value { get; }
	public override IXmlNode ParentNode { get; }

	// Methods

	// RVA: 0xFA1870 Offset: 0xF9FE70 VA: 0x180FA1870
	private XText get_Text() { }

	// RVA: 0xFA17A0 Offset: 0xF9FDA0 VA: 0x180FA17A0
	public void .ctor(XText text) { }

	// RVA: 0xFA18F0 Offset: 0xF9FEF0 VA: 0x180FA18F0 Slot: 18
	public override string get_Value() { }

	// RVA: 0xFA1810 Offset: 0xF9FE10 VA: 0x180FA1810 Slot: 17
	public override IXmlNode get_ParentNode() { }

}

internal class XCommentWrapper : XObjectWrapper // TypeDefIndex: 6125
{	// Properties
	private XComment Text { get; }
	public override string Value { get; }
	public override IXmlNode ParentNode { get; }

	// Methods

	// RVA: 0xF9F4F0 Offset: 0xF9DAF0 VA: 0x180F9F4F0
	private XComment get_Text() { }

	// RVA: 0xF9F420 Offset: 0xF9DA20 VA: 0x180F9F420
	public void .ctor(XComment text) { }

	// RVA: 0xF9F570 Offset: 0xF9DB70 VA: 0x180F9F570 Slot: 18
	public override string get_Value() { }

	// RVA: 0xF9F490 Offset: 0xF9DA90 VA: 0x180F9F490 Slot: 17
	public override IXmlNode get_ParentNode() { }

}

internal class XProcessingInstructionWrapper : XObjectWrapper // TypeDefIndex: 6126
{	// Properties
	private XProcessingInstruction ProcessingInstruction { get; }
	public override string LocalName { get; }
	public override string Value { get; }

	// Methods

	// RVA: 0xFA1700 Offset: 0xF9FD00 VA: 0x180FA1700
	private XProcessingInstruction get_ProcessingInstruction() { }

	// RVA: 0xFA1670 Offset: 0xF9FC70 VA: 0x180FA1670
	public void .ctor(XProcessingInstruction processingInstruction) { }

	// RVA: 0xFA16E0 Offset: 0xF9FCE0 VA: 0x180FA16E0 Slot: 14
	public override string get_LocalName() { }

	// RVA: 0xFA1780 Offset: 0xF9FD80 VA: 0x180FA1780 Slot: 18
	public override string get_Value() { }

}

internal class XContainerWrapper : XObjectWrapper // TypeDefIndex: 6127
{	// Fields
	private List<IXmlNode> _childNodes; // 0x18

	// Properties
	private XContainer Container { get; }
	public override List<IXmlNode> ChildNodes { get; }
	public override IXmlNode ParentNode { get; }

	// Methods

	// RVA: 0xF9FF60 Offset: 0xF9E560 VA: 0x180F9FF60
	private XContainer get_Container() { }

	// RVA: 0xF9FCE0 Offset: 0xF9E2E0 VA: 0x180F9FCE0
	public void .ctor(XContainer container) { }

	// RVA: 0xF9FD50 Offset: 0xF9E350 VA: 0x180F9FD50 Slot: 15
	public override List<IXmlNode> get_ChildNodes() { }

	// RVA: 0xF9FFE0 Offset: 0xF9E5E0 VA: 0x180F9FFE0 Slot: 17
	public override IXmlNode get_ParentNode() { }

	// RVA: 0xF9F630 Offset: 0xF9DC30 VA: 0x180F9F630
	internal static IXmlNode WrapNode(XObject node) { }

	// RVA: 0xF9F590 Offset: 0xF9DB90 VA: 0x180F9F590 Slot: 19
	public override IXmlNode AppendChild(IXmlNode newChild) { }

}

internal class XObjectWrapper : IXmlNode // TypeDefIndex: 6128
{	// Fields
	private static readonly List<IXmlNode> EmptyChildNodes; // 0x0
	private readonly XObject _xmlObject; // 0x10

	// Properties
	public object WrappedNode { get; }
	public virtual XmlNodeType NodeType { get; }
	public virtual string LocalName { get; }
	public virtual List<IXmlNode> ChildNodes { get; }
	public virtual List<IXmlNode> Attributes { get; }
	public virtual IXmlNode ParentNode { get; }
	public virtual string Value { get; }
	public virtual string NamespaceUri { get; }

	// Methods

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	public void .ctor(XObject xmlObject) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 12
	public object get_WrappedNode() { }

	// RVA: 0xBC9280 Offset: 0xBC7880 VA: 0x180BC9280 Slot: 13
	public virtual XmlNodeType get_NodeType() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 14
	public virtual string get_LocalName() { }

	// RVA: 0xFA1610 Offset: 0xF9FC10 VA: 0x180FA1610 Slot: 15
	public virtual List<IXmlNode> get_ChildNodes() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 16
	public virtual List<IXmlNode> get_Attributes() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 17
	public virtual IXmlNode get_ParentNode() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 18
	public virtual string get_Value() { }

	// RVA: 0xFA1560 Offset: 0xF9FB60 VA: 0x180FA1560 Slot: 19
	public virtual IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 20
	public virtual string get_NamespaceUri() { }

	// RVA: 0xFA15B0 Offset: 0xF9FBB0 VA: 0x180FA15B0
	private static void .cctor() { }

}

internal class XAttributeWrapper : XObjectWrapper // TypeDefIndex: 6129
{	// Properties
	private XAttribute Attribute { get; }
	public override string Value { get; }
	public override string LocalName { get; }
	public override string NamespaceUri { get; }
	public override IXmlNode ParentNode { get; }

	// Methods

	// RVA: 0xF9F2C0 Offset: 0xF9D8C0 VA: 0x180F9F2C0
	private XAttribute get_Attribute() { }

	// RVA: 0xF9F250 Offset: 0xF9D850 VA: 0x180F9F250
	public void .ctor(XAttribute attribute) { }

	// RVA: 0xF9F400 Offset: 0xF9DA00 VA: 0x180F9F400 Slot: 18
	public override string get_Value() { }

	// RVA: 0xF9F340 Offset: 0xF9D940 VA: 0x180F9F340 Slot: 14
	public override string get_LocalName() { }

	// RVA: 0xF9F370 Offset: 0xF9D970 VA: 0x180F9F370 Slot: 20
	public override string get_NamespaceUri() { }

	// RVA: 0xF9F3A0 Offset: 0xF9D9A0 VA: 0x180F9F3A0 Slot: 17
	public override IXmlNode get_ParentNode() { }

}

internal class XElementWrapper : XContainerWrapper, IXmlElement, IXmlNode // TypeDefIndex: 6130
{	// Fields
	private List<IXmlNode> _attributes; // 0x20

	// Properties
	private XElement Element { get; }
	public override List<IXmlNode> Attributes { get; }
	public override string Value { get; }
	public override string LocalName { get; }
	public override string NamespaceUri { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0xFA1420 Offset: 0xF9FA20 VA: 0x180FA1420
	private XElement get_Element() { }

	// RVA: 0xF9FCE0 Offset: 0xF9E2E0 VA: 0x180F9FCE0
	public void .ctor(XElement element) { }

	// RVA: 0xFA0DF0 Offset: 0xF9F3F0 VA: 0x180FA0DF0 Slot: 21
	public void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0xFA0EC0 Offset: 0xF9F4C0 VA: 0x180FA0EC0 Slot: 16
	public override List<IXmlNode> get_Attributes() { }

	// RVA: 0xFA0D00 Offset: 0xF9F300 VA: 0x180FA0D00 Slot: 19
	public override IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0xFA1530 Offset: 0xF9FB30 VA: 0x180FA1530 Slot: 18
	public override string get_Value() { }

	// RVA: 0xFA14D0 Offset: 0xF9FAD0 VA: 0x180FA14D0 Slot: 14
	public override string get_LocalName() { }

	// RVA: 0xFA1500 Offset: 0xF9FB00 VA: 0x180FA1500 Slot: 20
	public override string get_NamespaceUri() { }

	// RVA: 0xFA0DA0 Offset: 0xF9F3A0 VA: 0x180FA0DA0 Slot: 22
	public string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0xFA14A0 Offset: 0xF9FAA0 VA: 0x180FA14A0 Slot: 23
	public bool get_IsEmpty() { }

}

public class XmlNodeConverter : JsonConverter // TypeDefIndex: 6131
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <DeserializeRootElementName>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <WriteArrayAttribute>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <OmitRootObject>k__BackingField; // 0x19

	// Properties
	public string DeserializeRootElementName { get; }
	public bool WriteArrayAttribute { get; }
	public bool OmitRootObject { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_DeserializeRootElementName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0
	public bool get_WriteArrayAttribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFA7F00 Offset: 0xFA6500 VA: 0x180FA7F00
	public bool get_OmitRootObject() { }

	// RVA: 0xFA7DE0 Offset: 0xFA63E0 VA: 0x180FA7DE0 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xFA7C70 Offset: 0xFA6270 VA: 0x180FA7C70
	private IXmlNode WrapXml(object value) { }

	// RVA: 0xFA5480 Offset: 0xFA3A80 VA: 0x180FA5480
	private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xFA6920 Offset: 0xFA4F20 VA: 0x180FA6920
	private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xFA4ED0 Offset: 0xFA34D0 VA: 0x180FA4ED0
	private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xFA5190 Offset: 0xFA3790 VA: 0x180FA5190
	private bool IsArray(IXmlNode node) { }

	// RVA: 0xFA6AB0 Offset: 0xFA50B0 VA: 0x180FA6AB0
	private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0xFA6EE0 Offset: 0xFA54E0 VA: 0x180FA6EE0
	private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0xFA2730 Offset: 0xFA0D30 VA: 0x180FA2730
	private static bool AllSameName(IXmlNode node) { }

	// RVA: 0xFA6430 Offset: 0xFA4A30 VA: 0x180FA6430 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xFA4BC0 Offset: 0xFA31C0 VA: 0x180FA4BC0
	private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode) { }

	// RVA: 0xFA61A0 Offset: 0xFA47A0 VA: 0x180FA61A0
	private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager) { }

	// RVA: 0xFA34D0 Offset: 0xFA1AD0 VA: 0x180FA34D0
	private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, Dictionary<string, string> attributeNameValues) { }

	// RVA: 0xFA23E0 Offset: 0xFA09E0 VA: 0x180FA23E0
	private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string attributeName, XmlNamespaceManager manager, string attributePrefix) { }

	// RVA: 0xFA29D0 Offset: 0xFA0FD0 VA: 0x180FA29D0
	private string ConvertTokenToXmlValue(JsonReader reader) { }

	// RVA: 0xFA5900 Offset: 0xFA3F00 VA: 0x180FA5900
	private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager) { }

	// RVA: 0xFA2580 Offset: 0xFA0B80 VA: 0x180FA2580
	private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document) { }

	// RVA: 0xFA5BA0 Offset: 0xFA41A0 VA: 0x180FA5BA0
	private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager) { }

	// RVA: 0xFA3950 Offset: 0xFA1F50 VA: 0x180FA3950
	private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName) { }

	// RVA: 0xFA3060 Offset: 0xFA1660 VA: 0x180FA3060
	private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode) { }

	// RVA: 0xFA33C0 Offset: 0xFA19C0 VA: 0x180FA33C0
	private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager) { }

	// RVA: 0xFA3C80 Offset: 0xFA2280 VA: 0x180FA3C80
	private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode) { }

	// RVA: 0xFA53A0 Offset: 0xFA39A0 VA: 0x180FA53A0
	private bool IsNamespaceAttribute(string attributeName, out string prefix) { }

	// RVA: 0xFA7B00 Offset: 0xFA6100 VA: 0x180FA7B00
	private bool ValueAttributes(List<IXmlNode> c) { }

	// RVA: 0xFA28E0 Offset: 0xFA0EE0 VA: 0x180FA28E0 Slot: 6
	public override bool CanConvert(Type valueType) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class XORSwitch : IOEntity // TypeDefIndex: 9806
{	// Fields
	private int input1Amount; // 0x288
	private int input2Amount; // 0x28C

	// Methods

	// RVA: 0x1A787A0 Offset: 0x1A76DA0 VA: 0x181A787A0
	public void .ctor() { }

}

