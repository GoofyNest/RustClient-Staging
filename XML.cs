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

	// RVA: 0x1567270 Offset: 0x1565870 VA: 0x181567270
	public void .ctor() { }

	// RVA: 0x1565090 Offset: 0x1563690 VA: 0x181565090
	private Exception Error(string msg) { }

	// RVA: 0x15671B0 Offset: 0x15657B0 VA: 0x1815671B0
	private Exception UnexpectedEndError() { }

	// RVA: 0x1565470 Offset: 0x1563A70 VA: 0x181565470
	private bool IsNameChar(char c, bool start) { }

	// RVA: 0x1565610 Offset: 0x1563C10 VA: 0x181565610
	private bool IsWhitespace(int c) { }

	// RVA: 0x15671A0 Offset: 0x15657A0 VA: 0x1815671A0
	public void SkipWhitespaces() { }

	// RVA: 0x1565360 Offset: 0x1563960 VA: 0x181565360
	private void HandleWhitespaces() { }

	// RVA: 0x15670B0 Offset: 0x15656B0 VA: 0x1815670B0
	public void SkipWhitespaces(bool expected) { }

	// RVA: 0x1565890 Offset: 0x1563E90 VA: 0x181565890
	private int Peek() { }

	// RVA: 0x1567050 Offset: 0x1565650 VA: 0x181567050
	private int Read() { }

	// RVA: 0x1565170 Offset: 0x1563770 VA: 0x181565170
	public void Expect(int c) { }

	// RVA: 0x1566EF0 Offset: 0x15654F0 VA: 0x181566EF0
	private string ReadUntil(char until, bool handleReferences) { }

	// RVA: 0x15669F0 Offset: 0x1564FF0 VA: 0x1815669F0
	public string ReadName() { }

	// RVA: 0x1565630 Offset: 0x1563C30 VA: 0x181565630
	public void Parse(TextReader input, SmallXmlParser.IContentHandler handler) { }

	// RVA: 0x1564F90 Offset: 0x1563590 VA: 0x181564F90
	private void Cleanup() { }

	// RVA: 0x1566020 Offset: 0x1564620 VA: 0x181566020
	public void ReadContent() { }

	// RVA: 0x1565290 Offset: 0x1563890 VA: 0x181565290
	private void HandleBufferedContent() { }

	// RVA: 0x1565DA0 Offset: 0x15643A0 VA: 0x181565DA0
	private void ReadCharacters() { }

	// RVA: 0x1566CD0 Offset: 0x15652D0 VA: 0x181566CD0
	private void ReadReference() { }

	// RVA: 0x1565BF0 Offset: 0x15641F0 VA: 0x181565BF0
	private int ReadCharacterReference() { }

	// RVA: 0x15658C0 Offset: 0x1563EC0 VA: 0x1815658C0
	private void ReadAttribute(SmallXmlParser.AttrListImpl a) { }

	// RVA: 0x1565A70 Offset: 0x1564070 VA: 0x181565A70
	private void ReadCDATASection() { }

	// RVA: 0x1565EC0 Offset: 0x15644C0 VA: 0x181565EC0
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

	// RVA: 0x155C010 Offset: 0x155A610 VA: 0x18155C010 Slot: 4
	public int get_Length() { }

	// RVA: 0x155BDD0 Offset: 0x155A3D0 VA: 0x18155BDD0 Slot: 5
	public string GetName(int i) { }

	// RVA: 0x155BE30 Offset: 0x155A430 VA: 0x18155BE30 Slot: 6
	public string GetValue(int i) { }

	// RVA: 0x155BE90 Offset: 0x155A490 VA: 0x18155BE90 Slot: 7
	public string GetValue(string name) { }

	// RVA: 0x155C050 Offset: 0x155A650 VA: 0x18155C050 Slot: 8
	public string[] get_Names() { }

	// RVA: 0x155C0A0 Offset: 0x155A6A0 VA: 0x18155C0A0 Slot: 9
	public string[] get_Values() { }

	// RVA: 0x155BD70 Offset: 0x155A370 VA: 0x18155BD70
	internal void Clear() { }

	// RVA: 0x155BCF0 Offset: 0x155A2F0 VA: 0x18155BCF0
	internal void Add(string name, string value) { }

	// RVA: 0x155BF70 Offset: 0x155A570 VA: 0x18155BF70
	public void .ctor() { }

}

internal class SmallXmlParserException : SystemException // TypeDefIndex: 28
{	// Fields
	private int line; // 0x88
	private int column; // 0x8C

	// Methods

	// RVA: 0x1564ED0 Offset: 0x15634D0 VA: 0x181564ED0
	public void .ctor(string msg, int line, int column) { }

}

public sealed class XmlSyntaxException : SystemException // TypeDefIndex: 909
{	// Methods

	// RVA: 0x18BC180 Offset: 0x18BA780 VA: 0x1818BC180
	public void .ctor() { }

	// RVA: 0x18C37C0 Offset: 0x18C1DC0 VA: 0x1818C37C0
	public void .ctor(int lineNumber) { }

	// RVA: 0x18C3640 Offset: 0x18C1C40 VA: 0x1818C3640
	public void .ctor(int lineNumber, string message) { }

	// RVA: 0x1486B10 Offset: 0x1485110 VA: 0x181486B10
	public void .ctor(string message) { }

	// RVA: 0x18BC0F0 Offset: 0x18BA6F0 VA: 0x1818BC0F0
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x18B00C0 Offset: 0x18AE6C0 VA: 0x1818B00C0
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

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	private void .ctor(XPathScanner scanner) { }

	// RVA: 0x12F9790 Offset: 0x12F7D90 VA: 0x1812F9790
	public static AstNode ParseXPathExpresion(string xpathExpresion) { }

	// RVA: 0x12F7670 Offset: 0x12F5C70 VA: 0x1812F7670
	private AstNode ParseExpresion(AstNode qyInput) { }

	// RVA: 0x12F87D0 Offset: 0x12F6DD0 VA: 0x1812F87D0
	private AstNode ParseOrExpr(AstNode qyInput) { }

	// RVA: 0x12F7400 Offset: 0x12F5A00 VA: 0x1812F7400
	private AstNode ParseAndExpr(AstNode qyInput) { }

	// RVA: 0x12F7550 Offset: 0x12F5B50 VA: 0x1812F7550
	private AstNode ParseEqualityExpr(AstNode qyInput) { }

	// RVA: 0x12F8E40 Offset: 0x12F7440 VA: 0x1812F8E40
	private AstNode ParseRelationalExpr(AstNode qyInput) { }

	// RVA: 0x12F72E0 Offset: 0x12F58E0 VA: 0x1812F72E0
	private AstNode ParseAdditiveExpr(AstNode qyInput) { }

	// RVA: 0x12F8330 Offset: 0x12F6930 VA: 0x1812F8330
	private AstNode ParseMultiplicativeExpr(AstNode qyInput) { }

	// RVA: 0x12F9430 Offset: 0x12F7A30 VA: 0x1812F9430
	private AstNode ParseUnaryExpr(AstNode qyInput) { }

	// RVA: 0x12F9580 Offset: 0x12F7B80 VA: 0x1812F9580
	private AstNode ParseUnionExpr(AstNode qyInput) { }

	// RVA: 0x12F7140 Offset: 0x12F5740 VA: 0x1812F7140
	private static bool IsNodeType(XPathScanner scaner) { }

	// RVA: 0x12F8920 Offset: 0x12F6F20 VA: 0x1812F8920
	private AstNode ParsePathExpr(AstNode qyInput) { }

	// RVA: 0x12F7810 Offset: 0x12F5E10 VA: 0x1812F7810
	private AstNode ParseFilterExpr(AstNode qyInput) { }

	// RVA: 0x12F8B70 Offset: 0x12F7170 VA: 0x1812F8B70
	private AstNode ParsePredicate(AstNode qyInput) { }

	// RVA: 0x12F7A60 Offset: 0x12F6060 VA: 0x1812F7A60
	private AstNode ParseLocationPath(AstNode qyInput) { }

	// RVA: 0x12F8F70 Offset: 0x12F7570 VA: 0x1812F8F70
	private AstNode ParseRelativeLocationPath(AstNode qyInput) { }

	// RVA: 0x12F7290 Offset: 0x12F5890 VA: 0x1812F7290
	private static bool IsStep(XPathScanner.LexKind lexKind) { }

	// RVA: 0x12F9050 Offset: 0x12F7650 VA: 0x1812F9050
	private AstNode ParseStep(AstNode qyInput) { }

	// RVA: 0x12F84E0 Offset: 0x12F6AE0 VA: 0x1812F84E0
	private AstNode ParseNodeTest(AstNode qyInput, Axis.AxisType axisType, XPathNodeType nodeType) { }

	// RVA: 0x12F71F0 Offset: 0x12F57F0 VA: 0x1812F71F0
	private static bool IsPrimaryExpr(XPathScanner scanner) { }

	// RVA: 0x12F8C10 Offset: 0x12F7210 VA: 0x1812F8C10
	private AstNode ParsePrimaryExpr(AstNode qyInput) { }

	// RVA: 0x12F7BA0 Offset: 0x12F61A0 VA: 0x1812F7BA0
	private AstNode ParseMethod(AstNode qyInput) { }

	// RVA: 0x12F60D0 Offset: 0x12F46D0 VA: 0x1812F60D0
	private void CheckToken(XPathScanner.LexKind t) { }

	// RVA: 0x12F9920 Offset: 0x12F7F20 VA: 0x1812F9920
	private void PassToken(XPathScanner.LexKind t) { }

	// RVA: 0x12F72C0 Offset: 0x12F58C0 VA: 0x1812F72C0
	private void NextLex() { }

	// RVA: 0x12F9950 Offset: 0x12F7F50 VA: 0x1812F9950
	private bool TestOp(string op) { }

	// RVA: 0x12F6050 Offset: 0x12F4650 VA: 0x1812F6050
	private void CheckNodeSet(XPathResultType t) { }

	// RVA: 0x12F6480 Offset: 0x12F4A80 VA: 0x1812F6480
	private static Hashtable CreateFunctionTable() { }

	// RVA: 0x12F6160 Offset: 0x12F4760 VA: 0x1812F6160
	private static Hashtable CreateAxesTable() { }

	// RVA: 0x12F7040 Offset: 0x12F5640 VA: 0x1812F7040
	private Axis.AxisType GetAxis(XPathScanner scaner) { }

	// RVA: 0x12F99A0 Offset: 0x12F7FA0 VA: 0x1812F99A0
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

	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0
	public int get_Minargs() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_Maxargs() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public XPathResultType[] get_ArgTypes() { }

	// RVA: 0x12F49B0 Offset: 0x12F2FB0 VA: 0x1812F49B0
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

	// RVA: 0x12FA7C0 Offset: 0x12F8DC0 VA: 0x1812FA7C0
	public void .ctor(string xpathExpr) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_SourceText() { }

	// RVA: 0x12FA8B0 Offset: 0x12F8EB0 VA: 0x1812FA8B0
	private char get_CurerntChar() { }

	// RVA: 0x12F9CF0 Offset: 0x12F82F0 VA: 0x1812F9CF0
	private bool NextChar() { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public XPathScanner.LexKind get_Kind() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public string get_Name() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_Prefix() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_StringValue() { }

	// RVA: 0x12FA8C0 Offset: 0x12F8EC0 VA: 0x1812FA8C0
	public double get_NumberValue() { }

	// RVA: 0x4BC3E0 Offset: 0x4BA9E0 VA: 0x1804BC3E0
	public bool get_CanBeFunction() { }

	// RVA: 0x12FA720 Offset: 0x12F8D20 VA: 0x1812FA720
	private void SkipSpace() { }

	// RVA: 0x12F9D40 Offset: 0x12F8340 VA: 0x1812F9D40
	public bool NextLex() { }

	// RVA: 0x12FA470 Offset: 0x12F8A70 VA: 0x1812FA470
	private double ScanNumber() { }

	// RVA: 0x12FA2C0 Offset: 0x12F88C0 VA: 0x1812FA2C0
	private double ScanFraction() { }

	// RVA: 0x12FA5E0 Offset: 0x12F8BE0 VA: 0x1812FA5E0
	private string ScanString() { }

	// RVA: 0x12FA3B0 Offset: 0x12F89B0 VA: 0x1812FA3B0
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

	// RVA: 0x12F52B0 Offset: 0x12F38B0 VA: 0x1812F52B0
	public void .ctor(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent) { }

	// RVA: 0x12F5630 Offset: 0x12F3C30 VA: 0x1812F5630 Slot: 5
	public override string get_Value() { }

	// RVA: 0x12F4B30 Offset: 0x12F3130 VA: 0x1812F4B30 Slot: 23
	public override XPathNavigator Clone() { }

	// RVA: 0x12F55A0 Offset: 0x12F3BA0 VA: 0x1812F55A0 Slot: 24
	public override XPathNodeType get_NodeType() { }

	// RVA: 0x12F54B0 Offset: 0x12F3AB0 VA: 0x1812F54B0 Slot: 25
	public override string get_LocalName() { }

	// RVA: 0x12F5550 Offset: 0x12F3B50 VA: 0x1812F5550 Slot: 26
	public override string get_NamespaceURI() { }

	// RVA: 0x12F55E0 Offset: 0x12F3BE0 VA: 0x1812F55E0 Slot: 27
	public override string get_Prefix() { }

	// RVA: 0x12F5500 Offset: 0x12F3B00 VA: 0x1812F5500 Slot: 19
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x12F4D00 Offset: 0x12F3300 VA: 0x1812F4D00 Slot: 30
	public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: 0x12F4FA0 Offset: 0x12F35A0 VA: 0x1812F4FA0 Slot: 31
	public override bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x12F51B0 Offset: 0x12F37B0 VA: 0x1812F51B0 Slot: 32
	public override bool MoveToParent() { }

	// RVA: 0x12F4C70 Offset: 0x12F3270 VA: 0x1812F4C70 Slot: 33
	public override bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0xE51A00 Offset: 0xE50000 VA: 0x180E51A00 Slot: 28
	public override object get_UnderlyingObject() { }

	// RVA: 0x12F4C20 Offset: 0x12F3220 VA: 0x1812F4C20 Slot: 35
	public bool HasLineInfo() { }

	// RVA: 0x12F5350 Offset: 0x12F3950 VA: 0x1812F5350 Slot: 36
	public int get_LineNumber() { }

	// RVA: 0x12F53F0 Offset: 0x12F39F0 VA: 0x1812F53F0 Slot: 37
	public int get_LinePosition() { }

	// RVA: 0x12F4C10 Offset: 0x12F3210 VA: 0x1812F4C10
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

	// RVA: 0x1E03A0 Offset: 0x1DF7A0 VA: 0x1801E03A0
	public XPathNodeType get_NodeType() { }

	// RVA: 0x1E03D0 Offset: 0x1DF7D0 VA: 0x1801E03D0
	public string get_Prefix() { }

	// RVA: 0x1E0360 Offset: 0x1DF760 VA: 0x1801E0360
	public string get_LocalName() { }

	// RVA: 0x1E0380 Offset: 0x1DF780 VA: 0x1801E0380
	public string get_NamespaceUri() { }

	// RVA: 0x1E01F0 Offset: 0x1DF5F0 VA: 0x1801E01F0
	public XPathDocument get_Document() { }

	// RVA: 0x1E0310 Offset: 0x1DF710 VA: 0x1801E0310
	public int get_LineNumber() { }

	// RVA: 0x1E0340 Offset: 0x1DF740 VA: 0x1801E0340
	public int get_LinePosition() { }

	// RVA: 0x1E01C0 Offset: 0x1DF5C0 VA: 0x1801E01C0
	public int get_CollapsedLinePosition() { }

	// RVA: 0x1E03B0 Offset: 0x1DF7B0 VA: 0x1801E03B0
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x1E0140 Offset: 0x1DF540 VA: 0x1801E0140
	public int GetParent(out XPathNode[] pageNode) { }

	// RVA: 0x1E0180 Offset: 0x1DF580 VA: 0x1801E0180
	public int GetSibling(out XPathNode[] pageNode) { }

	// RVA: 0x1E02A0 Offset: 0x1DF6A0 VA: 0x1801E02A0
	public bool get_IsXmlNamespaceNode() { }

	// RVA: 0x1E0230 Offset: 0x1DF630 VA: 0x1801E0230
	public bool get_HasSibling() { }

	// RVA: 0x1E0210 Offset: 0x1DF610 VA: 0x1801E0210
	public bool get_HasCollapsedText() { }

	// RVA: 0x1E0240 Offset: 0x1DF640 VA: 0x1801E0240
	public bool get_IsText() { }

	// RVA: 0x1E0220 Offset: 0x1DF620 VA: 0x1801E0220
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

	// RVA: 0x122E10 Offset: 0x122210 VA: 0x180122E10
	public int get_Index() { }

	// RVA: 0x1E00D0 Offset: 0x1DF4D0 VA: 0x1801E00D0 Slot: 2
	public override int GetHashCode() { }

}

internal abstract class XPathNodeHelper // TypeDefIndex: 1807
{	// Methods

	// RVA: 0x12F5AB0 Offset: 0x12F40B0 VA: 0x1812F5AB0
	public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0x12F5970 Offset: 0x12F3F70 VA: 0x1812F5970
	public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0x12F5C80 Offset: 0x12F4280 VA: 0x1812F5C80
	public static bool GetParent(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x12F5B30 Offset: 0x12F4130 VA: 0x1812F5B30
	public static int GetLocation(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x12F5D20 Offset: 0x12F4320 VA: 0x1812F5D20
	public static bool GetTextFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd) { }

	// RVA: 0x12F5B80 Offset: 0x12F4180 VA: 0x1812F5B80
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

	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0
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

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_LocalName() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_NamespaceUri() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Prefix() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public XPathNode[] get_SiblingPage() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public XPathNode[] get_ParentPage() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public XPathDocument get_Document() { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	public int get_LineNumberBase() { }

	// RVA: 0x5DE450 Offset: 0x5DCA50 VA: 0x1805DE450
	public int get_LinePositionBase() { }

}

internal class XmlRawWriterBase64Encoder : Base64Encoder // TypeDefIndex: 1814
{	// Fields
	private XmlRawWriter rawWriter; // 0x28

	// Methods

	// RVA: 0xBA0BA0 Offset: 0xB9F1A0 VA: 0x180BA0BA0
	internal void .ctor(XmlRawWriter rawWriter) { }

	// RVA: 0xBA0B70 Offset: 0xB9F170 VA: 0x180BA0B70 Slot: 4
	internal override void WriteChars(char[] chars, int index, int count) { }

}

internal class XmlTextWriterBase64Encoder : Base64Encoder // TypeDefIndex: 1815
{	// Fields
	private XmlTextEncoder xmlTextEncoder; // 0x28

	// Methods

	// RVA: 0xBA0BA0 Offset: 0xB9F1A0 VA: 0x180BA0BA0
	internal void .ctor(XmlTextEncoder xmlTextEncoder) { }

	// RVA: 0x1319C90 Offset: 0x1318290 VA: 0x181319C90 Slot: 4
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

	// RVA: 0x1DFFA0 Offset: 0x1DF3A0 VA: 0x1801DFFA0
	public bool get_IsPositive() { }

	// RVA: 0x1DFF90 Offset: 0x1DF390 VA: 0x1801DFF90
	public void .ctor(byte[] data, int offset, bool trim) { }

	// RVA: 0x1202D10 Offset: 0x1201310 VA: 0x181202D10
	private static uint UIntFromByteArray(byte[] data, int offset) { }

	// RVA: 0x12E1740 Offset: 0x12DFD40 VA: 0x1812E1740
	private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	// RVA: 0xEA3A30 Offset: 0xEA2030 VA: 0x180EA3A30
	private static void MpNormalize(uint[] rgulU, ref int ciulU) { }

	// RVA: 0xEA1880 Offset: 0xE9FE80 VA: 0x180EA1880
	private static char ChFromDigit(uint uiDigit) { }

	// RVA: 0x1DFEB0 Offset: 0x1DF2B0 VA: 0x1801DFEB0
	public Decimal ToDecimal() { }

	// RVA: 0x1DFF80 Offset: 0x1DF380 VA: 0x1801DFF80
	private void TrimTrailingZeros() { }

	// RVA: 0x1DFF70 Offset: 0x1DF370 VA: 0x1801DFF70 Slot: 3
	public override string ToString() { }

	// RVA: 0x12E20E0 Offset: 0x12E06E0 VA: 0x1812E20E0
	private static void .cctor() { }

}

internal struct BinXmlSqlMoney // TypeDefIndex: 1820
{	// Fields
	private long data; // 0x0

	// Methods

	// RVA: 0x1E00C0 Offset: 0x1DF4C0 VA: 0x1801E00C0
	public void .ctor(int v) { }

	// RVA: 0x1D2EB0 Offset: 0x1D22B0 VA: 0x1801D2EB0
	public void .ctor(long v) { }

	// RVA: 0x1DFFB0 Offset: 0x1DF3B0 VA: 0x1801DFFB0
	public Decimal ToDecimal() { }

	// RVA: 0x1E0000 Offset: 0x1DF400 VA: 0x1801E0000 Slot: 3
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

	// RVA: 0x12DF680 Offset: 0x12DDC80 VA: 0x1812DF680
	private static void Write2Dig(StringBuilder sb, int val) { }

	// RVA: 0x12DF7B0 Offset: 0x12DDDB0 VA: 0x1812DF7B0
	private static void Write4DigNeg(StringBuilder sb, int val) { }

	// RVA: 0x12DF6F0 Offset: 0x12DDCF0 VA: 0x1812DF6F0
	private static void Write3Dec(StringBuilder sb, int val) { }

	// RVA: 0x12DF8E0 Offset: 0x12DDEE0 VA: 0x1812DF8E0
	private static void WriteDate(StringBuilder sb, int yr, int mnth, int day) { }

	// RVA: 0x12DFF60 Offset: 0x12DE560 VA: 0x1812DFF60
	private static void WriteTime(StringBuilder sb, int hr, int min, int sec, int ms) { }

	// RVA: 0x12DFB10 Offset: 0x12DE110 VA: 0x1812DFB10
	private static void WriteTimeFullPrecision(StringBuilder sb, int hr, int min, int sec, int fraction) { }

	// RVA: 0x12DFD60 Offset: 0x12DE360 VA: 0x1812DFD60
	private static void WriteTimeZone(StringBuilder sb, TimeSpan zone) { }

	// RVA: 0x12DFE20 Offset: 0x12DE420 VA: 0x1812DFE20
	private static void WriteTimeZone(StringBuilder sb, bool negTimeZone, int hr, int min) { }

	// RVA: 0x12DE950 Offset: 0x12DCF50 VA: 0x1812DE950
	private static void BreakDownXsdDateTime(long val, out int yr, out int mnth, out int day, out int hr, out int min, out int sec, out int ms) { }

	// RVA: 0x12DEB10 Offset: 0x12DD110 VA: 0x1812DEB10
	private static void BreakDownXsdDate(long val, out int yr, out int mnth, out int day, out bool negTimeZone, out int hr, out int min) { }

	// RVA: 0x12DEC70 Offset: 0x12DD270 VA: 0x1812DEC70
	private static void BreakDownXsdTime(long val, out int hr, out int min, out int sec, out int ms) { }

	// RVA: 0x12E0180 Offset: 0x12DE780 VA: 0x1812E0180
	public static string XsdDateTimeToString(long val) { }

	// RVA: 0x12E0400 Offset: 0x12DEA00 VA: 0x1812E0400
	public static string XsdDateToString(long val) { }

	// RVA: 0x12E14B0 Offset: 0x12DFAB0 VA: 0x1812E14B0
	public static string XsdTimeToString(long val) { }

	// RVA: 0x12DF440 Offset: 0x12DDA40 VA: 0x1812DF440
	public static string SqlDateTimeToString(int dateticks, uint timeticks) { }

	// RVA: 0x12DF380 Offset: 0x12DD980 VA: 0x1812DF380
	public static DateTime SqlDateTimeToDateTime(int dateticks, uint timeticks) { }

	// RVA: 0x12DF580 Offset: 0x12DDB80 VA: 0x1812DF580
	public static string SqlSmallDateTimeToString(short dateticks, ushort timeticks) { }

	// RVA: 0x12DF500 Offset: 0x12DDB00 VA: 0x1812DF500
	public static DateTime SqlSmallDateTimeToDateTime(short dateticks, ushort timeticks) { }

	// RVA: 0x12E0E30 Offset: 0x12DF430 VA: 0x1812E0E30
	public static DateTime XsdKatmaiDateToDateTime(byte[] data, int offset) { }

	// RVA: 0x12E0BC0 Offset: 0x12DF1C0 VA: 0x1812E0BC0
	public static DateTime XsdKatmaiDateTimeToDateTime(byte[] data, int offset) { }

	// RVA: 0x12E1300 Offset: 0x12DF900 VA: 0x1812E1300
	public static DateTime XsdKatmaiTimeToDateTime(byte[] data, int offset) { }

	// RVA: 0x12E06E0 Offset: 0x12DECE0 VA: 0x1812E06E0
	public static DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x12E08B0 Offset: 0x12DEEB0 VA: 0x1812E08B0
	public static DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x12E1100 Offset: 0x12DF700 VA: 0x1812E1100
	public static DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x12E0F30 Offset: 0x12DF530 VA: 0x1812E0F30
	public static string XsdKatmaiDateToString(byte[] data, int offset) { }

	// RVA: 0x12E0CD0 Offset: 0x12DF2D0 VA: 0x1812E0CD0
	public static string XsdKatmaiDateTimeToString(byte[] data, int offset) { }

	// RVA: 0x12E1360 Offset: 0x12DF960 VA: 0x1812E1360
	public static string XsdKatmaiTimeToString(byte[] data, int offset) { }

	// RVA: 0x12E0760 Offset: 0x12DED60 VA: 0x1812E0760
	public static string XsdKatmaiDateOffsetToString(byte[] data, int offset) { }

	// RVA: 0x12E0A30 Offset: 0x12DF030 VA: 0x1812E0A30
	public static string XsdKatmaiDateTimeOffsetToString(byte[] data, int offset) { }

	// RVA: 0x12E1180 Offset: 0x12DF780 VA: 0x1812E1180
	public static string XsdKatmaiTimeOffsetToString(byte[] data, int offset) { }

	// RVA: 0x12DEF50 Offset: 0x12DD550 VA: 0x1812DEF50
	private static long GetKatmaiDateTicks(byte[] data, ref int pos) { }

	// RVA: 0x12DEFF0 Offset: 0x12DD5F0 VA: 0x1812DEFF0
	private static long GetKatmaiTimeTicks(byte[] data, ref int pos) { }

	// RVA: 0x12DF310 Offset: 0x12DD910 VA: 0x1812DF310
	private static long GetKatmaiTimeZoneTicks(byte[] data, int pos) { }

	// RVA: 0x12DEE70 Offset: 0x12DD470 VA: 0x1812DEE70
	private static int GetFractions(DateTime dt) { }

	// RVA: 0x12DED90 Offset: 0x12DD390 VA: 0x1812DED90
	private static int GetFractions(DateTimeOffset dt) { }

	// RVA: 0x12E1660 Offset: 0x12DFC60 VA: 0x1812E1660
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

	// RVA: 0xBAFF00 Offset: 0xBAE500 VA: 0x180BAFF00
	public void .ctor(Stream stream, byte[] data, int len, string baseUri, bool closeInput, XmlReaderSettings settings) { }

	// RVA: 0xBB06A0 Offset: 0xBAECA0 VA: 0x180BB06A0 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0xBB0600 Offset: 0xBAEC00 VA: 0x180BB0600 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x952CA0 Offset: 0x9512A0 VA: 0x180952CA0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x9922B0 Offset: 0x9908B0 VA: 0x1809922B0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xBB0930 Offset: 0xBAEF30 VA: 0x180BB0930 Slot: 11
	public override string get_Value() { }

	// RVA: 0xBB0500 Offset: 0xBAEB00 VA: 0x180BB0500 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBB05E0 Offset: 0xBAEBE0 VA: 0x180BB05E0 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xBB0D00 Offset: 0xBAF300 VA: 0x180BB0D00 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBB0C50 Offset: 0xBAF250 VA: 0x180BB0C50 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x871E40 Offset: 0x870440 VA: 0x180871E40 Slot: 20
	public override Type get_ValueType() { }

	// RVA: 0xBB04A0 Offset: 0xBAEAA0 VA: 0x180BB04A0 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xBA7A00 Offset: 0xBA6000 VA: 0x180BA7A00 Slot: 23
	public override string GetAttribute(string name, string ns) { }

	// RVA: 0xBA78D0 Offset: 0xBA5ED0 VA: 0x180BA78D0 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xBA7940 Offset: 0xBA5F40 VA: 0x180BA7940 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xBA9E00 Offset: 0xBA8400 VA: 0x180BA9E00 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xBA9E90 Offset: 0xBA8490 VA: 0x180BA9E90 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0xBAA070 Offset: 0xBA8670 VA: 0x180BAA070 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xBAA0F0 Offset: 0xBA86F0 VA: 0x180BAA0F0 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0xBA9F60 Offset: 0xBA8560 VA: 0x180BA9F60 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0xBB05D0 Offset: 0xBAEBD0 VA: 0x180BB05D0 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0xBAB120 Offset: 0xBA9720 VA: 0x180BAB120 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0xBA5DE0 Offset: 0xBA43E0 VA: 0x180BA5DE0 Slot: 33
	public override void Close() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xBA9D40 Offset: 0xBA8340 VA: 0x180BA9D40 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0xBACA50 Offset: 0xBAB050 VA: 0x180BACA50 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0xBB0610 Offset: 0xBAEC10 VA: 0x180BB0610 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xBAC590 Offset: 0xBAAB90 VA: 0x180BAC590 Slot: 31
	public override bool Read() { }

	// RVA: 0xBADBC0 Offset: 0xBAC1C0 VA: 0x180BADBC0 Slot: 53
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xBADF10 Offset: 0xBAC510 VA: 0x180BADF10 Slot: 55
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0xBAFB20 Offset: 0xBAE120 VA: 0x180BAFB20
	private void VerifyVersion(int requiredVersion, BinXmlToken token) { }

	// RVA: 0xBA5310 Offset: 0xBA3910 VA: 0x180BA5310
	private void AddInitNamespace(string prefix, string uri) { }

	// RVA: 0xBA5450 Offset: 0xBA3A50 VA: 0x180BA5450
	private void AddName() { }

	// RVA: 0xBA55B0 Offset: 0xBA3BB0 VA: 0x180BA55B0
	private void AddQName() { }

	// RVA: 0xBAA190 Offset: 0xBA8790 VA: 0x180BAA190
	private void NameFlush() { }

	// RVA: 0xBADA90 Offset: 0xBAC090 VA: 0x180BADA90
	private void SkipExtn() { }

	// RVA: 0xBAC3B0 Offset: 0xBAA9B0 VA: 0x180BAC3B0
	private int ReadQNameRef() { }

	// RVA: 0xBAC2D0 Offset: 0xBAA8D0 VA: 0x180BAC2D0
	private int ReadNameRef() { }

	// RVA: 0xBA5E90 Offset: 0xBA4490 VA: 0x180BA5E90
	private bool FillAllowEOF() { }

	// RVA: 0xBA60D0 Offset: 0xBA46D0 VA: 0x180BA60D0
	private void Fill_(int require) { }

	// RVA: 0xBA6150 Offset: 0xBA4750 VA: 0x180BA6150
	private void Fill(int require) { }

	// RVA: 0xBAB2F0 Offset: 0xBA98F0 VA: 0x180BAB2F0
	private byte ReadByte() { }

	// RVA: 0xBAC510 Offset: 0xBAAB10 VA: 0x180BAC510
	private ushort ReadUShort() { }

	// RVA: 0xBAA930 Offset: 0xBA8F30 VA: 0x180BAA930
	private int ParseMB32() { }

	// RVA: 0xBAA780 Offset: 0xBA8D80 VA: 0x180BAA780
	private int ParseMB32_(byte b) { }

	// RVA: 0xBAA9A0 Offset: 0xBA8FA0 VA: 0x180BAA9A0
	private int ParseMB32(int pos) { }

	// RVA: 0xBAA930 Offset: 0xBA8F30 VA: 0x180BAA930
	private int ParseMB64() { }

	// RVA: 0xBAABF0 Offset: 0xBA91F0 VA: 0x180BAABF0
	private BinXmlToken PeekToken() { }

	// RVA: 0xBAC490 Offset: 0xBAAA90 VA: 0x180BAC490
	private BinXmlToken ReadToken() { }

	// RVA: 0xBAA2C0 Offset: 0xBA88C0 VA: 0x180BAA2C0
	private BinXmlToken NextToken2(BinXmlToken token) { }

	// RVA: 0xBAA1F0 Offset: 0xBA87F0 VA: 0x180BAA1F0
	private BinXmlToken NextToken1() { }

	// RVA: 0xBAA670 Offset: 0xBA8C70 VA: 0x180BAA670
	private BinXmlToken NextToken() { }

	// RVA: 0xBAABD0 Offset: 0xBA91D0 VA: 0x180BAABD0
	private BinXmlToken PeekNextToken() { }

	// RVA: 0xBAC710 Offset: 0xBAAD10 VA: 0x180BAC710
	private BinXmlToken RescanNextToken() { }

	// RVA: 0xBAAB00 Offset: 0xBA9100 VA: 0x180BAAB00
	private string ParseText() { }

	// RVA: 0xBAD780 Offset: 0xBABD80 VA: 0x180BAD780
	private int ScanText(out int start) { }

	// RVA: 0xBA80B0 Offset: 0xBA66B0 VA: 0x180BA80B0
	private string GetString(int pos, int cch) { }

	// RVA: 0xBA8080 Offset: 0xBA6680 VA: 0x180BA8080
	private string GetStringAligned(byte[] data, int offset, int cch) { }

	// RVA: 0xBA7730 Offset: 0xBA5D30 VA: 0x180BA7730
	private string GetAttributeText(int i) { }

	// RVA: 0xBA9B80 Offset: 0xBA8180 VA: 0x180BA9B80
	private int LocateAttribute(string name, string ns) { }

	// RVA: 0xBA9C40 Offset: 0xBA8240 VA: 0x180BA9C40
	private int LocateAttribute(string name) { }

	// RVA: 0xBAAD40 Offset: 0xBA9340 VA: 0x180BAAD40
	private void PositionOnAttribute(int i) { }

	// RVA: 0xBA8570 Offset: 0xBA6B70 VA: 0x180BA8570
	private void GrowElements() { }

	// RVA: 0xBA84D0 Offset: 0xBA6AD0 VA: 0x180BA84D0
	private void GrowAttributes() { }

	// RVA: 0xBA5DC0 Offset: 0xBA43C0 VA: 0x180BA5DC0
	private void ClearAttributes() { }

	// RVA: 0xBAAE70 Offset: 0xBA9470 VA: 0x180BAAE70
	private void PushNamespace(string prefix, string ns, bool implied) { }

	// RVA: 0xBAAC60 Offset: 0xBA9260 VA: 0x180BAAC60
	private void PopNamespaces(XmlSqlBinaryReader.NamespaceDecl firstInScopeChain) { }

	// RVA: 0xBA6400 Offset: 0xBA4A00 VA: 0x180BA6400
	private void GenerateImpliedXmlnsAttrs() { }

	// RVA: 0xBABCC0 Offset: 0xBAA2C0 VA: 0x180BABCC0
	private bool ReadInit(bool skipXmlDecl) { }

	// RVA: 0xBACAA0 Offset: 0xBAB0A0 VA: 0x180BACAA0
	private void ScanAttributes() { }

	// RVA: 0xBAD8C0 Offset: 0xBABEC0 VA: 0x180BAD8C0
	private void SimpleCheckForDuplicateAttributes() { }

	// RVA: 0xBA8610 Offset: 0xBA6C10 VA: 0x180BA8610
	private void HashCheckForDuplicateAttributes() { }

	// RVA: 0xBAFB90 Offset: 0xBAE190 VA: 0x180BAFB90
	private string XmlDeclValue() { }

	// RVA: 0xBA5880 Offset: 0xBA3E80 VA: 0x180BA5880
	private string CDATAValue() { }

	// RVA: 0xBA61F0 Offset: 0xBA47F0 VA: 0x180BA61F0
	private void FinishCDATA() { }

	// RVA: 0xBA62E0 Offset: 0xBA48E0 VA: 0x180BA62E0
	private void FinishEndElement() { }

	// RVA: 0xBAB340 Offset: 0xBA9940 VA: 0x180BAB340
	private bool ReadDoc() { }

	// RVA: 0xBA8A30 Offset: 0xBA7030 VA: 0x180BA8A30
	private void ImplReadData(BinXmlToken tokenType) { }

	// RVA: 0xBA8F70 Offset: 0xBA7570 VA: 0x180BA8F70
	private void ImplReadElement() { }

	// RVA: 0xBA9320 Offset: 0xBA7920 VA: 0x180BA9320
	private void ImplReadEndElement() { }

	// RVA: 0xBA8BC0 Offset: 0xBA71C0 VA: 0x180BA8BC0
	private void ImplReadDoctype() { }

	// RVA: 0xBA9600 Offset: 0xBA7C00 VA: 0x180BA9600
	private void ImplReadPI() { }

	// RVA: 0xBA89F0 Offset: 0xBA6FF0 VA: 0x180BA89F0
	private void ImplReadComment() { }

	// RVA: 0xBA8960 Offset: 0xBA6F60 VA: 0x180BA8960
	private void ImplReadCDATA() { }

	// RVA: 0xBA94A0 Offset: 0xBA7AA0 VA: 0x180BA94A0
	private void ImplReadNest() { }

	// RVA: 0xBA9430 Offset: 0xBA7A30 VA: 0x180BA9430
	private void ImplReadEndNest() { }

	// RVA: 0xBA9690 Offset: 0xBA7C90 VA: 0x180BA9690
	private void ImplReadXmlText() { }

	// RVA: 0xBAE360 Offset: 0xBAC960 VA: 0x180BAE360
	private void UpdateFromTextReader() { }

	// RVA: 0xBAE340 Offset: 0xBAC940 VA: 0x180BAE340
	private bool UpdateFromTextReader(bool needUpdate) { }

	// RVA: 0xBA59E0 Offset: 0xBA3FE0 VA: 0x180BA59E0
	private void CheckAllowContent() { }

	// RVA: 0xBA6610 Offset: 0xBA4C10 VA: 0x180BA6610
	private void GenerateTokenTypeMap() { }

	// RVA: 0xBA8230 Offset: 0xBA6830 VA: 0x180BA8230
	private Type GetValueType(BinXmlToken token) { }

	// RVA: 0xBAB100 Offset: 0xBA9700 VA: 0x180BAB100
	private void ReScanOverValue(BinXmlToken token) { }

	// RVA: 0xBAD560 Offset: 0xBABB60 VA: 0x180BAD560
	private XmlNodeType ScanOverValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0xBAD030 Offset: 0xBAB630 VA: 0x180BAD030
	private XmlNodeType ScanOverAnyValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0xBA5B00 Offset: 0xBA4100 VA: 0x180BA5B00
	private XmlNodeType CheckText(bool attr) { }

	// RVA: 0xBA5A50 Offset: 0xBA4050 VA: 0x180BA5A50
	private XmlNodeType CheckTextIsWS() { }

	// RVA: 0xBA5D60 Offset: 0xBA4360 VA: 0x180BA5D60
	private void CheckValueTokenBounds() { }

	// RVA: 0xBA8320 Offset: 0xBA6920 VA: 0x180BA8320
	private int GetXsdKatmaiTokenLength(BinXmlToken token) { }

	// RVA: 0xBAFCF0 Offset: 0xBAE2F0 VA: 0x180BAFCF0
	private int XsdKatmaiTimeScaleToValueLength(byte scale) { }

	// RVA: 0xBAED70 Offset: 0xBAD370 VA: 0x180BAED70
	private long ValueAsLong() { }

	// RVA: 0xBAFA70 Offset: 0xBAE070 VA: 0x180BAFA70
	private ulong ValueAsULong() { }

	// RVA: 0xBAE8C0 Offset: 0xBACEC0 VA: 0x180BAE8C0
	private Decimal ValueAsDecimal() { }

	// RVA: 0xBAEB70 Offset: 0xBAD170 VA: 0x180BAEB70
	private double ValueAsDouble() { }

	// RVA: 0xBAE460 Offset: 0xBACA60 VA: 0x180BAE460
	private string ValueAsDateTimeString() { }

	// RVA: 0xBAF2A0 Offset: 0xBAD8A0 VA: 0x180BAF2A0
	private string ValueAsString(BinXmlToken token) { }

	// RVA: 0xBA7D20 Offset: 0xBA6320 VA: 0x180BA7D20
	private short GetInt16(int pos) { }

	// RVA: 0xBA7D20 Offset: 0xBA6320 VA: 0x180BA7D20
	private ushort GetUInt16(int pos) { }

	// RVA: 0xBA7D80 Offset: 0xBA6380 VA: 0x180BA7D80
	private int GetInt32(int pos) { }

	// RVA: 0xBA7D80 Offset: 0xBA6380 VA: 0x180BA7D80
	private uint GetUInt32(int pos) { }

	// RVA: 0xBA7E30 Offset: 0xBA6430 VA: 0x180BA7E30
	private long GetInt64(int pos) { }

	// RVA: 0xBA7E30 Offset: 0xBA6430 VA: 0x180BA7E30
	private ulong GetUInt64(int pos) { }

	// RVA: 0xBA7FD0 Offset: 0xBA65D0 VA: 0x180BA7FD0
	private float GetSingle(int offset) { }

	// RVA: 0xBA7B80 Offset: 0xBA6180 VA: 0x180BA7B80
	private double GetDouble(int offset) { }

	// RVA: 0xBAE0F0 Offset: 0xBAC6F0 VA: 0x180BAE0F0
	private Exception ThrowUnexpectedToken(BinXmlToken token) { }

	// RVA: 0xBAE2D0 Offset: 0xBAC8D0 VA: 0x180BAE2D0
	private Exception ThrowXmlException(string res) { }

	// RVA: 0xBAE180 Offset: 0xBAC780 VA: 0x180BAE180
	private Exception ThrowXmlException(string res, string arg1, string arg2) { }

	// RVA: 0xBAE080 Offset: 0xBAC680 VA: 0x180BAE080
	private Exception ThrowNotSupported(string res) { }

	// RVA: 0xBAFDB0 Offset: 0xBAE3B0 VA: 0x180BAFDB0
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

	// RVA: 0xF5C70 Offset: 0xF5070 VA: 0x1800F5C70
	public void .ctor(string prefix, string lname, string nsUri) { }

	// RVA: 0xF5C70 Offset: 0xF5070 VA: 0x1800F5C70
	public void Set(string prefix, string lname, string nsUri) { }

	// RVA: 0xFD990 Offset: 0xFCD90 VA: 0x1800FD990
	public void Clear() { }

	// RVA: 0xFD5E0 Offset: 0xFC9E0 VA: 0x1800FD5E0
	public bool MatchNs(string lname, string nsUri) { }

	// RVA: 0xFDB00 Offset: 0xFCF00 VA: 0x1800FDB00
	public bool MatchPrefix(string prefix, string lname) { }

	// RVA: 0xFD980 Offset: 0xFCD80 VA: 0x1800FD980
	public void CheckPrefixNS(string prefix, string namespaceUri) { }

	// RVA: 0xF59F0 Offset: 0xF4DF0 VA: 0x1800F59F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFDAA0 Offset: 0xFCEA0 VA: 0x1800FDAA0
	public int GetNSHashCode(SecureStringHasher hasher) { }

	// RVA: 0xFD9A0 Offset: 0xFCDA0 VA: 0x1800FD9A0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xFDB50 Offset: 0xFCF50 VA: 0x1800FDB50 Slot: 3
	public override string ToString() { }

	// RVA: 0xB9B390 Offset: 0xB99990 VA: 0x180B9B390
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

	// RVA: 0xB9AF90 Offset: 0xB99590 VA: 0x180B9AF90
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

	// RVA: 0xB9B020 Offset: 0xB99620 VA: 0x180B9B020
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

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal XmlReader get_CoreReader() { }

	// RVA: 0xE53430 Offset: 0xE51A30 VA: 0x180E53430
	public static XmlAsyncCheckReader CreateAsyncCheckWrapper(XmlReader reader) { }

	// RVA: 0xE53CA0 Offset: 0xE522A0 VA: 0x180E53CA0
	public void .ctor(XmlReader reader) { }

	// RVA: 0xE53360 Offset: 0xE51960 VA: 0x180E53360
	private void CheckAsync() { }

	// RVA: 0xE54250 Offset: 0xE52850 VA: 0x180E54250 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0xE54110 Offset: 0xE52710 VA: 0x180E54110 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xE54050 Offset: 0xE52650 VA: 0x180E54050 Slot: 7
	public override string get_Name() { }

	// RVA: 0xE53FD0 Offset: 0xE525D0 VA: 0x180E53FD0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0xE540D0 Offset: 0xE526D0 VA: 0x180E540D0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0xE54150 Offset: 0xE52750 VA: 0x180E54150 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xE54320 Offset: 0xE52920 VA: 0x180E54320 Slot: 11
	public override string get_Value() { }

	// RVA: 0xE53E50 Offset: 0xE52450 VA: 0x180E53E50 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xE53D90 Offset: 0xE52390 VA: 0x180E53D90 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xE53F90 Offset: 0xE52590 VA: 0x180E53F90 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xE53F50 Offset: 0xE52550 VA: 0x180E53F50 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xE54190 Offset: 0xE52790 VA: 0x180E54190 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xE543A0 Offset: 0xE529A0 VA: 0x180E543A0 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xE54360 Offset: 0xE52960 VA: 0x180E54360 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0xE54210 Offset: 0xE52810 VA: 0x180E54210 Slot: 19
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xE542E0 Offset: 0xE528E0 VA: 0x180E542E0 Slot: 20
	public override Type get_ValueType() { }

	// RVA: 0xE53D50 Offset: 0xE52350 VA: 0x180E53D50 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xE536A0 Offset: 0xE51CA0 VA: 0x180E536A0 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xE536F0 Offset: 0xE51CF0 VA: 0x180E536F0 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0xE53750 Offset: 0xE51D50 VA: 0x180E53750 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xE538A0 Offset: 0xE51EA0 VA: 0x180E538A0 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xE53850 Offset: 0xE51E50 VA: 0x180E53850 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0xE53970 Offset: 0xE51F70 VA: 0x180E53970 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xE539B0 Offset: 0xE51FB0 VA: 0x180E539B0 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0xE53930 Offset: 0xE51F30 VA: 0x180E53930 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0xE539F0 Offset: 0xE51FF0 VA: 0x180E539F0 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0xE53BE0 Offset: 0xE521E0 VA: 0x180E53BE0 Slot: 31
	public override bool Read() { }

	// RVA: 0xE53ED0 Offset: 0xE524D0 VA: 0x180E53ED0 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0xE533F0 Offset: 0xE519F0 VA: 0x180E533F0 Slot: 33
	public override void Close() { }

	// RVA: 0xE541D0 Offset: 0xE527D0 VA: 0x180E541D0 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xE53C60 Offset: 0xE52260 VA: 0x180E53C60 Slot: 35
	public override void Skip() { }

	// RVA: 0xE54010 Offset: 0xE52610 VA: 0x180E54010 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xE53800 Offset: 0xE51E00 VA: 0x180E53800 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0xE53E10 Offset: 0xE52410 VA: 0x180E53E10 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0xE53C20 Offset: 0xE52220 VA: 0x180E53C20 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0xE53DD0 Offset: 0xE523D0 VA: 0x180E53DD0 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0xE53B70 Offset: 0xE52170 VA: 0x180E53B70 Slot: 41
	public override int ReadValueChunk(char[] buffer, int index, int count) { }

	// RVA: 0xE53B30 Offset: 0xE52130 VA: 0x180E53B30 Slot: 42
	public override string ReadString() { }

	// RVA: 0xE538F0 Offset: 0xE51EF0 VA: 0x180E538F0 Slot: 43
	public override XmlNodeType MoveToContent() { }

	// RVA: 0xE53AF0 Offset: 0xE520F0 VA: 0x180E53AF0 Slot: 44
	public override void ReadStartElement() { }

	// RVA: 0xE53A30 Offset: 0xE52030 VA: 0x180E53A30 Slot: 45
	public override string ReadElementString() { }

	// RVA: 0xE53A70 Offset: 0xE52070 VA: 0x180E53A70 Slot: 46
	public override void ReadEndElement() { }

	// RVA: 0xE537A0 Offset: 0xE51DA0 VA: 0x180E537A0 Slot: 47
	public override bool IsStartElement(string localname, string ns) { }

	// RVA: 0xE53AB0 Offset: 0xE520B0 VA: 0x180E53AB0 Slot: 48
	public override string ReadInnerXml() { }

	// RVA: 0xE53F10 Offset: 0xE52510 VA: 0x180E53F10 Slot: 49
	public override bool get_HasAttributes() { }

	// RVA: 0xE53670 Offset: 0xE51C70 VA: 0x180E53670 Slot: 50
	protected override void Dispose(bool disposing) { }

	// RVA: 0xE54090 Offset: 0xE52690 VA: 0x180E54090 Slot: 51
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0xE53E90 Offset: 0xE52490 VA: 0x180E53E90 Slot: 52
	internal override IDtdInfo get_DtdInfo() { }

}

internal class XmlAsyncCheckReaderWithNS : XmlAsyncCheckReader, IXmlNamespaceResolver // TypeDefIndex: 1874
{	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x20

	// Methods

	// RVA: 0xE532D0 Offset: 0xE518D0 VA: 0x180E532D0
	public void .ctor(XmlReader reader) { }

	// RVA: 0xE531B0 Offset: 0xE517B0 VA: 0x180E531B0 Slot: 53
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xE53210 Offset: 0xE51810 VA: 0x180E53210 Slot: 54
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0xE53270 Offset: 0xE51870 VA: 0x180E53270 Slot: 55
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

internal class XmlAsyncCheckReaderWithLineInfo : XmlAsyncCheckReader, IXmlLineInfo // TypeDefIndex: 1875
{	// Fields
	private readonly IXmlLineInfo readerAsIXmlLineInfo; // 0x20

	// Properties
	public virtual int LineNumber { get; }
	public virtual int LinePosition { get; }

	// Methods

	// RVA: 0xE53080 Offset: 0xE51680 VA: 0x180E53080
	public void .ctor(XmlReader reader) { }

	// RVA: 0xE53030 Offset: 0xE51630 VA: 0x180E53030 Slot: 56
	public virtual bool HasLineInfo() { }

	// RVA: 0xE53110 Offset: 0xE51710 VA: 0x180E53110 Slot: 57
	public virtual int get_LineNumber() { }

	// RVA: 0xE53160 Offset: 0xE51760 VA: 0x180E53160 Slot: 58
	public virtual int get_LinePosition() { }

}

internal class XmlAsyncCheckReaderWithLineInfoNS : XmlAsyncCheckReaderWithLineInfo, IXmlNamespaceResolver // TypeDefIndex: 1876
{	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x28

	// Methods

	// RVA: 0xE52F40 Offset: 0xE51540 VA: 0x180E52F40
	public void .ctor(XmlReader reader) { }

	// RVA: 0xE52E20 Offset: 0xE51420 VA: 0x180E52E20 Slot: 59
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xE52E80 Offset: 0xE51480 VA: 0x180E52E80 Slot: 60
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0xE52EE0 Offset: 0xE514E0 VA: 0x180E52EE0 Slot: 61
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

	// RVA: 0xE52D90 Offset: 0xE51390 VA: 0x180E52D90
	public void .ctor(XmlReader reader) { }

	// RVA: 0xE52D40 Offset: 0xE51340 VA: 0x180E52D40 Slot: 62
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0xE52A80 Offset: 0xE51080 VA: 0x180E52A80 Slot: 63
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0xE52AD0 Offset: 0xE510D0 VA: 0x180E52AD0 Slot: 64
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0xE52B20 Offset: 0xE51120 VA: 0x180E52B20 Slot: 65
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0xE52CF0 Offset: 0xE512F0 VA: 0x180E52CF0 Slot: 66
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0xE52C30 Offset: 0xE51230 VA: 0x180E52C30 Slot: 67
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0xE52B70 Offset: 0xE51170 VA: 0x180E52B70 Slot: 68
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

}

internal class XmlAsyncCheckWriter : XmlWriter // TypeDefIndex: 1878
{	// Fields
	private readonly XmlWriter coreWriter; // 0x18
	private Task lastTask; // 0x20

	// Properties
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0xE54E10 Offset: 0xE53410 VA: 0x180E54E10
	public void .ctor(XmlWriter writer) { }

	// RVA: 0xE543E0 Offset: 0xE529E0 VA: 0x180E543E0
	private void CheckAsync() { }

	// RVA: 0xE54BC0 Offset: 0xE531C0 VA: 0x180E54BC0 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0xE54C00 Offset: 0xE53200 VA: 0x180E54C00 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0xE548C0 Offset: 0xE52EC0 VA: 0x180E548C0 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0xE54810 Offset: 0xE52E10 VA: 0x180E54810 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xE54C50 Offset: 0xE53250 VA: 0x180E54C50 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0xE54900 Offset: 0xE52F00 VA: 0x180E54900 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0xE54990 Offset: 0xE52F90 VA: 0x180E54990 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0xE54B50 Offset: 0xE53150 VA: 0x180E54B50 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0xE54880 Offset: 0xE52E80 VA: 0x180E54880 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0xE546B0 Offset: 0xE52CB0 VA: 0x180E546B0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0xE547C0 Offset: 0xE52DC0 VA: 0x180E547C0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0xE54A30 Offset: 0xE53030 VA: 0x180E54A30 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0xE54940 Offset: 0xE52F40 VA: 0x180E54940 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0xE54700 Offset: 0xE52D00 VA: 0x180E54700 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0xE54DC0 Offset: 0xE533C0 VA: 0x180E54DC0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0xE54CC0 Offset: 0xE532C0 VA: 0x180E54CC0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0xE54D10 Offset: 0xE53310 VA: 0x180E54D10 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0xE54750 Offset: 0xE52D50 VA: 0x180E54750 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0xE54A90 Offset: 0xE53090 VA: 0x180E54A90 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0xE54B00 Offset: 0xE53100 VA: 0x180E54B00 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0xE545D0 Offset: 0xE52BD0 VA: 0x180E545D0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0xE54640 Offset: 0xE52C40 VA: 0x180E54640 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0xE54EA0 Offset: 0xE534A0 VA: 0x180E54EA0 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0xE54470 Offset: 0xE52A70 VA: 0x180E54470 Slot: 28
	public override void Close() { }

	// RVA: 0xE544E0 Offset: 0xE52AE0 VA: 0x180E544E0 Slot: 29
	public override void Flush() { }

	// RVA: 0xE54520 Offset: 0xE52B20 VA: 0x180E54520 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0xE54D70 Offset: 0xE53370 VA: 0x180E54D70 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0xE54570 Offset: 0xE52B70 VA: 0x180E54570 Slot: 32
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0xE549D0 Offset: 0xE52FD0 VA: 0x180E549D0 Slot: 33
	public override void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0xE544B0 Offset: 0xE52AB0 VA: 0x180E544B0 Slot: 34
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

	// RVA: 0xE58520 Offset: 0xE56B20 VA: 0x180E58520
	private void .ctor(XmlWriterSettings writerSettings) { }

	// RVA: 0xE584A0 Offset: 0xE56AA0 VA: 0x180E584A0
	public void .ctor(TextWriter textWriter, XmlWriterSettings writerSettings) { }

	// RVA: 0xE584E0 Offset: 0xE56AE0 VA: 0x180E584E0
	public void .ctor(Stream strm, XmlWriterSettings writerSettings) { }

	// RVA: 0xE57D40 Offset: 0xE56340 VA: 0x180E57D40 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xE580B0 Offset: 0xE566B0 VA: 0x180E580B0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0xE58030 Offset: 0xE56630 VA: 0x180E58030 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0xE57DC0 Offset: 0xE563C0 VA: 0x180E57DC0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0xE57C40 Offset: 0xE56240 VA: 0x180E57C40 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0xE57CF0 Offset: 0xE562F0 VA: 0x180E57CF0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0xE57F50 Offset: 0xE56550 VA: 0x180E57F50 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0xE58390 Offset: 0xE56990 VA: 0x180E58390 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0xE58270 Offset: 0xE56870 VA: 0x180E58270 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0xBA0E20 Offset: 0xB9F420 VA: 0x180BA0E20 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0xE57FF0 Offset: 0xE565F0 VA: 0x180E57FF0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0xE57FA0 Offset: 0xE565A0 VA: 0x180E57FA0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0xE57E50 Offset: 0xE56450 VA: 0x180E57E50 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0xE57C90 Offset: 0xE56290 VA: 0x180E57C90 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0xE582C0 Offset: 0xE568C0 VA: 0x180E582C0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0xE57B40 Offset: 0xE56140 VA: 0x180E57B40 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0xE57BC0 Offset: 0xE561C0 VA: 0x180E57BC0 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0xE576A0 Offset: 0xE55CA0 VA: 0x180E576A0 Slot: 28
	public override void Close() { }

	// RVA: 0xE57930 Offset: 0xE55F30 VA: 0x180E57930 Slot: 29
	public override void Flush() { }

	// RVA: 0xE58330 Offset: 0xE56930 VA: 0x180E58330 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0xE58610 Offset: 0xE56C10 VA: 0x180E58610 Slot: 35
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0xE58440 Offset: 0xE56A40 VA: 0x180E58440 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0xE583E0 Offset: 0xE569E0 VA: 0x180E583E0 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0xE57A60 Offset: 0xE56060 VA: 0x180E57A60 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0xE57DF0 Offset: 0xE563F0 VA: 0x180E57DF0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0xE57EB0 Offset: 0xE564B0 VA: 0x180E57EB0 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0xE57EE0 Offset: 0xE564E0 VA: 0x180E57EE0 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0xE585E0 Offset: 0xE56BE0 VA: 0x180E585E0 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0xE58210 Offset: 0xE56810 VA: 0x180E58210 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0xE57E20 Offset: 0xE56420 VA: 0x180E57E20 Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0xE57980 Offset: 0xE55F80 VA: 0x180E57980
	private static bool IsHtmlTag(string tagName) { }

	// RVA: 0xE57920 Offset: 0xE55F20 VA: 0x180E57920
	private void EnsureWrappedWriter(XmlOutputMethod outMethod) { }

	// RVA: 0xE57A90 Offset: 0xE56090 VA: 0x180E57A90
	private bool TextBlockCreatesWriter(string textBlock) { }

	// RVA: 0xE576F0 Offset: 0xE55CF0 VA: 0x180E576F0
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

	// RVA: 0x11C2F90 Offset: 0x11C1590 VA: 0x1811C2F90
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x11C2B80 Offset: 0x11C1180 VA: 0x1811C2B80
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x11C2C80 Offset: 0x11C1280 VA: 0x1811C2C80
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x11C2910 Offset: 0x11C0F10 VA: 0x1811C2910 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x11C2B10 Offset: 0x11C1110 VA: 0x1811C2B10 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x11C0F60 Offset: 0x11BF560 VA: 0x1811C0F60 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x11C23A0 Offset: 0x11C09A0 VA: 0x1811C23A0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11BF900 Offset: 0x11BDF00 VA: 0x1811BF900 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x11C1670 Offset: 0x11BFC70 VA: 0x1811C1670 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11C1A10 Offset: 0x11C0010 VA: 0x1811C1A10 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11C2210 Offset: 0x11C0810 VA: 0x1811C2210 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x11C1600 Offset: 0x11BFC00 VA: 0x1811C1600 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x11C1BA0 Offset: 0x11C01A0 VA: 0x1811C1BA0 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x11C24C0 Offset: 0x11C0AC0 VA: 0x1811C24C0 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x11C18A0 Offset: 0x11BFEA0 VA: 0x1811C18A0 Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x11C03B0 Offset: 0x11BE9B0 VA: 0x1811C03B0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x11C0D80 Offset: 0x11BF380 VA: 0x1811C0D80 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x11C1C90 Offset: 0x11C0290 VA: 0x1811C1C90 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x11C1910 Offset: 0x11BFF10 VA: 0x1811C1910 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x11C06D0 Offset: 0x11BECD0 VA: 0x1811C06D0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x11C2890 Offset: 0x11C0E90 VA: 0x1811C2890 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x11C2650 Offset: 0x11C0C50 VA: 0x1811C2650 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x11C26D0 Offset: 0x11C0CD0 VA: 0x1811C26D0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x11C0900 Offset: 0x11BEF00 VA: 0x1811C0900 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x11C2180 Offset: 0x11C0780 VA: 0x1811C2180 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x11C2110 Offset: 0x11C0710 VA: 0x1811C2110 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x11BE8F0 Offset: 0x11BCEF0 VA: 0x1811BE8F0 Slot: 28
	public override void Close() { }

	// RVA: 0x11BF3F0 Offset: 0x11BD9F0 VA: 0x1811BF3F0 Slot: 29
	public override void Flush() { }

	// RVA: 0x11BEF70 Offset: 0x11BD570 VA: 0x1811BEF70 Slot: 48
	protected virtual void FlushBuffer() { }

	// RVA: 0x11BEC90 Offset: 0x11BD290 VA: 0x1811BEC90
	private void EncodeChars(int startOffset, int endOffset, bool writeAllToStream) { }

	// RVA: 0x11BF320 Offset: 0x11BD920 VA: 0x1811BF320
	private void FlushEncoder() { }

	// RVA: 0x11BFCD0 Offset: 0x11BE2D0 VA: 0x1811BFCD0
	protected void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x11C12C0 Offset: 0x11BF8C0 VA: 0x1811C12C0
	protected void WriteElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x11BF700 Offset: 0x11BDD00 VA: 0x1811BF700
	protected void RawText(string s) { }

	// RVA: 0x11BF750 Offset: 0x11BDD50 VA: 0x1811BF750
	protected void RawText(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x11C1E40 Offset: 0x11C0440 VA: 0x1811C1E40
	protected void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x11C09A0 Offset: 0x11BEFA0 VA: 0x1811C09A0
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x11BFFE0 Offset: 0x11BE5E0 VA: 0x1811BFFE0
	protected void WriteCDataSection(string text) { }

	// RVA: 0x11BEE10 Offset: 0x11BD410 VA: 0x1811BEE10
	private static char* EncodeSurrogate(char* pSrc, char* pSrcEnd, char* pDst) { }

	// RVA: 0x11BF510 Offset: 0x11BDB10 VA: 0x1811BF510
	private char* InvalidXmlChar(int ch, char* pDst, bool entitize) { }

	// RVA: 0x11BEB90 Offset: 0x11BD190 VA: 0x1811BEB90
	internal void EncodeChar(ref char* pSrc, char* pSrcEnd, ref char* pDst) { }

	// RVA: 0x11BE750 Offset: 0x11BCD50 VA: 0x1811BE750
	protected void ChangeTextContentMark(bool value) { }

	// RVA: 0x11BF460 Offset: 0x11BDA60 VA: 0x1811BF460
	private void GrowTextContentMarks() { }

	// RVA: 0x11C1C00 Offset: 0x11C0200 VA: 0x1811C1C00
	protected char* WriteNewLine(char* pDst) { }

	// RVA: 0x11BF670 Offset: 0x11BDC70 VA: 0x1811BF670
	protected static char* LtEntity(char* pDst) { }

	// RVA: 0x11BF4F0 Offset: 0x11BDAF0 VA: 0x1811BF4F0
	protected static char* GtEntity(char* pDst) { }

	// RVA: 0x11BE710 Offset: 0x11BCD10 VA: 0x1811BE710
	protected static char* AmpEntity(char* pDst) { }

	// RVA: 0x11BF690 Offset: 0x11BDC90 VA: 0x1811BF690
	protected static char* QuoteEntity(char* pDst) { }

	// RVA: 0x11BF950 Offset: 0x11BDF50 VA: 0x1811BF950
	protected static char* TabEntity(char* pDst) { }

	// RVA: 0x11BF650 Offset: 0x11BDC50 VA: 0x1811BF650
	protected static char* LineFeedEntity(char* pDst) { }

	// RVA: 0x11BE730 Offset: 0x11BCD30 VA: 0x1811BE730
	protected static char* CarriageReturnEntity(char* pDst) { }

	// RVA: 0x11BE840 Offset: 0x11BCE40 VA: 0x1811BE840
	private static char* CharEntity(char* pDst, char ch) { }

	// RVA: 0x11BF6D0 Offset: 0x11BDCD0 VA: 0x1811BF6D0
	protected static char* RawStartCData(char* pDst) { }

	// RVA: 0x11BF6B0 Offset: 0x11BDCB0 VA: 0x1811BF6B0
	protected static char* RawEndCData(char* pDst) { }

	// RVA: 0x11BF970 Offset: 0x11BDF70 VA: 0x1811BF970
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

	// RVA: 0x11BE610 Offset: 0x11BCC10 VA: 0x1811BE610
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x11BE5E0 Offset: 0x11BCBE0 VA: 0x1811BE5E0
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x11BDE80 Offset: 0x11BC480 VA: 0x1811BDE80 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x11BE370 Offset: 0x11BC970 VA: 0x1811BE370 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11BDCE0 Offset: 0x11BC2E0 VA: 0x1811BDCE0 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x8722C0 Offset: 0x8708C0 VA: 0x1808722C0 Slot: 39
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x11BDEF0 Offset: 0x11BC4F0 VA: 0x1811BDEF0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11BE080 Offset: 0x11BC680 VA: 0x1811BE080 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11BE310 Offset: 0x11BC910 VA: 0x1811BE310 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x11BDD80 Offset: 0x11BC380 VA: 0x1811BDD80 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x11BDE40 Offset: 0x11BC440 VA: 0x1811BDE40 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x11BE1B0 Offset: 0x11BC7B0 VA: 0x1811BE1B0 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x11BDF80 Offset: 0x11BC580 VA: 0x1811BDF80 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x11BDD90 Offset: 0x11BC390 VA: 0x1811BDD90 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x11BE550 Offset: 0x11BCB50 VA: 0x1811BE550 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x11BE560 Offset: 0x11BCB60 VA: 0x1811BE560 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x11BE4D0 Offset: 0x11BCAD0 VA: 0x1811BE4D0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x11BDDA0 Offset: 0x11BC3A0 VA: 0x1811BDDA0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x11BE200 Offset: 0x11BC800 VA: 0x1811BE200 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x11BE2A0 Offset: 0x11BC8A0 VA: 0x1811BE2A0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x11BDD60 Offset: 0x11BC360 VA: 0x1811BDD60 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x11BDBD0 Offset: 0x11BC1D0 VA: 0x1811BDBD0
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x11BE110 Offset: 0x11BC710 VA: 0x1811BE110
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

	// RVA: 0x11C56E0 Offset: 0x11C3CE0 VA: 0x1811C56E0
	public void .ctor(string baseUri, bool hasRootNode) { }

	// RVA: 0x11C40F0 Offset: 0x11C26F0 VA: 0x1811C40F0
	public void EndEvents() { }

	// RVA: 0x11C4140 Offset: 0x11C2740 VA: 0x1811C4140
	public void EventsToWriter(XmlWriter writer) { }

	// RVA: 0x11C5090 Offset: 0x11C3690 VA: 0x1811C5090 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x11C53B0 Offset: 0x11C39B0 VA: 0x1811C53B0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11C5380 Offset: 0x11C3980 VA: 0x1811C5380 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x11C5140 Offset: 0x11C3740 VA: 0x1811C5140 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x11C4F10 Offset: 0x11C3510 VA: 0x1811C4F10 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x11C5020 Offset: 0x11C3620 VA: 0x1811C5020 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x11C52E0 Offset: 0x11C38E0 VA: 0x1811C52E0 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x11C5560 Offset: 0x11C3B60 VA: 0x1811C5560 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x11C53E0 Offset: 0x11C39E0 VA: 0x1811C53E0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0xBA0E20 Offset: 0xB9F420 VA: 0x180BA0E20 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0xE57FF0 Offset: 0xE565F0 VA: 0x180E57FF0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x11C5310 Offset: 0x11C3910 VA: 0x1811C5310 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x11C5210 Offset: 0x11C3810 VA: 0x1811C5210 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x11C4F80 Offset: 0x11C3580 VA: 0x1811C4F80 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x11C5470 Offset: 0x11C3A70 VA: 0x1811C5470 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x11C4CF0 Offset: 0x11C32F0 VA: 0x1811C4CF0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x11C4E00 Offset: 0x11C3400 VA: 0x1811C4E00 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x11C3FB0 Offset: 0x11C25B0 VA: 0x1811C3FB0 Slot: 28
	public override void Close() { }

	// RVA: 0x11C4A10 Offset: 0x11C3010 VA: 0x1811C4A10 Slot: 29
	public override void Flush() { }

	// RVA: 0xAEEF20 Offset: 0xAED520 VA: 0x180AEEF20 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0x11C4000 Offset: 0x11C2600 VA: 0x1811C4000 Slot: 34
	protected override void Dispose(bool disposing) { }

	// RVA: 0x11C5640 Offset: 0x11C3C40 VA: 0x1811C5640 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x11C55D0 Offset: 0x11C3BD0 VA: 0x1811C55D0 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x11C4BE0 Offset: 0x11C31E0 VA: 0x1811C4BE0 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x11C51E0 Offset: 0x11C37E0 VA: 0x1811C51E0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11C5280 Offset: 0x11C3880 VA: 0x1811C5280 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11C52B0 Offset: 0x11C38B0 VA: 0x1811C52B0 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x11C5190 Offset: 0x11C3790 VA: 0x1811C5190 Slot: 46
	internal override void WriteEndBase64() { }

	// RVA: 0x11C3E60 Offset: 0x11C2460 VA: 0x1811C3E60
	private void AddEvent(XmlEventCache.XmlEventType eventType) { }

	// RVA: 0x11C3F40 Offset: 0x11C2540 VA: 0x1811C3F40
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1) { }

	// RVA: 0x11C3EB0 Offset: 0x11C24B0 VA: 0x1811C3EB0
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2) { }

	// RVA: 0x11C3D10 Offset: 0x11C2310 VA: 0x1811C3D10
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3) { }

	// RVA: 0x11C3DB0 Offset: 0x11C23B0 VA: 0x1811C3DB0
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o) { }

	// RVA: 0x11C3CA0 Offset: 0x11C22A0 VA: 0x1811C3CA0
	private void AddEvent(XmlEventCache.XmlEventType eventType, object o) { }

	// RVA: 0x11C4A60 Offset: 0x11C3060 VA: 0x1811C4A60
	private int NewEvent() { }

	// RVA: 0x11C4C30 Offset: 0x11C3230 VA: 0x1811C4C30
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

	// RVA: 0x1D0DF0 Offset: 0x1D01F0 VA: 0x1801D0DF0
	public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2) { }

	// RVA: 0xF2890 Offset: 0xF1C90 VA: 0x1800F2890
	public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3) { }

	// RVA: 0x1D0D70 Offset: 0x1D0170 VA: 0x1801D0D70
	public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o) { }

	// RVA: 0x1D0DD0 Offset: 0x1D01D0 VA: 0x1801D0DD0
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

	// RVA: 0xB9F6A0 Offset: 0xB9DCA0 VA: 0x180B9F6A0
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0xB9FA20 Offset: 0xB9E020 VA: 0x180B9FA20
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0xB9F750 Offset: 0xB9DD50 VA: 0x180B9F750
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public XmlNameTable get_NameTable() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_DocTypeName() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public string get_PublicId() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_SystemId() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public string get_BaseURI() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_InternalSubset() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public string get_XmlLang() { }

	// RVA: 0x598420 Offset: 0x596A20 VA: 0x180598420
	public XmlSpace get_XmlSpace() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public Encoding get_Encoding() { }

	// RVA: 0xB9FA90 Offset: 0xB9E090 VA: 0x180B9FA90
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

	// RVA: 0xBA1120 Offset: 0xB9F720 VA: 0x180BA1120 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0xBA10B0 Offset: 0xB9F6B0 VA: 0x180BA10B0 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0xBA0E80 Offset: 0xB9F480 VA: 0x180BA0E80 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xBA0EF0 Offset: 0xB9F4F0 VA: 0x180BA0EF0 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0xBA0FB0 Offset: 0xB9F5B0 VA: 0x180BA0FB0 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0xBA0CD0 Offset: 0xB9F2D0 VA: 0x180BA0CD0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0xBA0BF0 Offset: 0xB9F1F0 VA: 0x180BA0BF0 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0xBA12A0 Offset: 0xB9F8A0 VA: 0x180BA12A0 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0xAEEF20 Offset: 0xAED520 VA: 0x180AEEF20 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0xBA0D90 Offset: 0xB9F390 VA: 0x180BA0D90 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0xBA11E0 Offset: 0xB9F7E0 VA: 0x180BA11E0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0xAEEF20 Offset: 0xAED520 VA: 0x180AEEF20 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0xBA0E20 Offset: 0xB9F420 VA: 0x180BA0E20 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0xBA0E20 Offset: 0xB9F420 VA: 0x180BA0E20 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0xAEEF20 Offset: 0xAED520 VA: 0x180AEEF20 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0xAEEF20 Offset: 0xAED520 VA: 0x180AEEF20 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0xBA0C60 Offset: 0xB9F260 VA: 0x180BA0C60 Slot: 32
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0xBA1040 Offset: 0xB9F640 VA: 0x180BA1040 Slot: 33
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

	// RVA: 0xBA1020 Offset: 0xB9F620 VA: 0x180BA1020 Slot: 41
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: -1 Offset: -1 Slot: 42
	internal abstract void WriteNamespaceDeclaration(string prefix, string ns);

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 43
	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0xBA1190 Offset: 0xB9F790 VA: 0x180BA1190 Slot: 44
	internal virtual void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0xBA0F60 Offset: 0xB9F560 VA: 0x180BA0F60 Slot: 45
	internal virtual void WriteEndNamespaceDeclaration() { }

	// RVA: 0xBA0E60 Offset: 0xB9F460 VA: 0x180BA0E60 Slot: 46
	internal virtual void WriteEndBase64() { }

	// RVA: 0xBA0BD0 Offset: 0xB9F1D0 VA: 0x180BA0BD0 Slot: 47
	internal virtual void Close(WriteState currentState) { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
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

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	public virtual XmlReaderSettings get_Settings() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract XmlNodeType get_NodeType();

	// RVA: 0xBA4500 Offset: 0xBA2B00 VA: 0x180BA4500 Slot: 7
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

	// RVA: 0xBA4600 Offset: 0xBA2C00 VA: 0x180BA4600 Slot: 16
	public virtual char get_QuoteChar() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 17
	public virtual XmlSpace get_XmlSpace() { }

	// RVA: 0xBA46B0 Offset: 0xBA2CB0 VA: 0x180BA46B0 Slot: 18
	public virtual string get_XmlLang() { }

	// RVA: 0xBA4610 Offset: 0xBA2C10 VA: 0x180BA4610 Slot: 19
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xBA4650 Offset: 0xBA2C50 VA: 0x180BA4650 Slot: 20
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

	// RVA: 0xBA2E00 Offset: 0xBA1400 VA: 0x180BA2E00 Slot: 26
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

	// RVA: 0xBA3CC0 Offset: 0xBA22C0 VA: 0x180BA3CC0 Slot: 35
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

	// RVA: 0xBA3A60 Offset: 0xBA2060 VA: 0x180BA3A60 Slot: 41
	public virtual int ReadValueChunk(char[] buffer, int index, int count) { }

	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	// RVA: 0xBA3840 Offset: 0xBA1E40 VA: 0x180BA3840 Slot: 42
	public virtual string ReadString() { }

	// RVA: 0xBA2ED0 Offset: 0xBA14D0 VA: 0x180BA2ED0 Slot: 43
	public virtual XmlNodeType MoveToContent() { }

	// RVA: 0xBA3740 Offset: 0xBA1D40 VA: 0x180BA3740 Slot: 44
	public virtual void ReadStartElement() { }

	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	// RVA: 0xBA2F60 Offset: 0xBA1560 VA: 0x180BA2F60 Slot: 45
	public virtual string ReadElementString() { }

	// RVA: 0xBA31E0 Offset: 0xBA17E0 VA: 0x180BA31E0 Slot: 46
	public virtual void ReadEndElement() { }

	// RVA: 0xBA2CE0 Offset: 0xBA12E0 VA: 0x180BA2CE0 Slot: 47
	public virtual bool IsStartElement(string localname, string ns) { }

	// RVA: 0xBA32E0 Offset: 0xBA18E0 VA: 0x180BA32E0 Slot: 48
	public virtual string ReadInnerXml() { }

	// RVA: 0xBA3EC0 Offset: 0xBA24C0 VA: 0x180BA3EC0
	private void WriteNode(XmlWriter xtw, bool defattr) { }

	// RVA: 0xBA3DB0 Offset: 0xBA23B0 VA: 0x180BA3DB0
	private void WriteAttributeValue(XmlWriter xtw) { }

	// RVA: 0xBA2890 Offset: 0xBA0E90 VA: 0x180BA2890
	private XmlWriter CreateWriterForInnerOuterXml(StringWriter sw) { }

	// RVA: 0xBA3AD0 Offset: 0xBA20D0 VA: 0x180BA3AD0
	private void SetNamespacesFlag(XmlTextWriter xtw) { }

	// RVA: 0xBA4460 Offset: 0xBA2A60 VA: 0x180BA4460 Slot: 49
	public virtual bool get_HasAttributes() { }

	// RVA: 0xBA2C00 Offset: 0xBA1200 VA: 0x180BA2C00 Slot: 4
	public void Dispose() { }

	// RVA: 0xBA2C20 Offset: 0xBA1220 VA: 0x180BA2C20 Slot: 50
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 51
	internal virtual XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0xBA2D80 Offset: 0xBA1380 VA: 0x180BA2D80
	internal static bool IsTextualNode(XmlNodeType nodeType) { }

	// RVA: 0xBA2C60 Offset: 0xBA1260 VA: 0x180BA2C60
	internal static bool HasValueInternal(XmlNodeType nodeType) { }

	// RVA: 0xBA3BE0 Offset: 0xBA21E0 VA: 0x180BA3BE0
	private bool SkipSubtree() { }

	// RVA: 0xBA4480 Offset: 0xBA2A80 VA: 0x180BA4480
	internal bool get_IsDefaultInternal() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 52
	internal virtual IDtdInfo get_DtdInfo() { }

	// RVA: 0xBA29D0 Offset: 0xBA0FD0 VA: 0x180BA29D0
	public static XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0xBA2B70 Offset: 0xBA1170 VA: 0x180BA2B70
	public static XmlReader Create(TextReader input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0xBA2560 Offset: 0xBA0B60 VA: 0x180BA2560
	internal static XmlReader CreateSqlReader(Stream input, XmlReaderSettings settings, XmlParserContext inputContext) { }

	// RVA: 0xBA24D0 Offset: 0xBA0AD0 VA: 0x180BA24D0
	internal static int CalcBufferSize(Stream input) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0xBA43F0 Offset: 0xBA29F0 VA: 0x180BA43F0
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

	// RVA: 0xBA1C70 Offset: 0xBA0270 VA: 0x180BA1C70
	public void .ctor() { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_Async() { }

	// RVA: 0xBA1DF0 Offset: 0xBA03F0 VA: 0x180BA1DF0
	public void set_Async(bool value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public XmlNameTable get_NameTable() { }

	// RVA: 0xBA22A0 Offset: 0xBA08A0 VA: 0x180BA22A0
	public void set_NameTable(XmlNameTable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xBA1D70 Offset: 0xBA0370 VA: 0x180BA1D70
	internal bool get_IsXmlResolverSet() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xBA20D0 Offset: 0xBA06D0 VA: 0x180BA20D0
	internal void set_IsXmlResolverSet(bool value) { }

	// RVA: 0xBA2470 Offset: 0xBA0A70 VA: 0x180BA2470
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal XmlResolver GetXmlResolver() { }

	// RVA: 0xBA1AB0 Offset: 0xBA00B0 VA: 0x180BA1AB0
	internal XmlResolver GetXmlResolver_CheckConfig() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public int get_LineNumberOffset() { }

	// RVA: 0xBA20E0 Offset: 0xBA06E0 VA: 0x180BA20E0
	public void set_LineNumberOffset(int value) { }

	// RVA: 0x5DE3B0 Offset: 0x5DC9B0 VA: 0x1805DE3B0
	public int get_LinePositionOffset() { }

	// RVA: 0xBA2130 Offset: 0xBA0730 VA: 0x180BA2130
	public void set_LinePositionOffset(int value) { }

	// RVA: 0xA38FA0 Offset: 0xA375A0 VA: 0x180A38FA0
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0xBA1EE0 Offset: 0xBA04E0 VA: 0x180BA1EE0
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0xBA1D40 Offset: 0xBA0340 VA: 0x180BA1D40
	public bool get_CheckCharacters() { }

	// RVA: 0xBA1E40 Offset: 0xBA0440 VA: 0x180BA1E40
	public void set_CheckCharacters(bool value) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public long get_MaxCharactersInDocument() { }

	// RVA: 0xBA2210 Offset: 0xBA0810 VA: 0x180BA2210
	public void set_MaxCharactersInDocument(long value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public long get_MaxCharactersFromEntities() { }

	// RVA: 0xBA2180 Offset: 0xBA0780 VA: 0x180BA2180
	public void set_MaxCharactersFromEntities(long value) { }

	// RVA: 0x4BC3E0 Offset: 0x4BA9E0 VA: 0x1804BC3E0
	public bool get_IgnoreWhitespace() { }

	// RVA: 0xBA2080 Offset: 0xBA0680 VA: 0x180BA2080
	public void set_IgnoreWhitespace(bool value) { }

	// RVA: 0xBA1D60 Offset: 0xBA0360 VA: 0x180BA1D60
	public bool get_IgnoreProcessingInstructions() { }

	// RVA: 0xBA2030 Offset: 0xBA0630 VA: 0x180BA2030
	public void set_IgnoreProcessingInstructions(bool value) { }

	// RVA: 0xBA1D50 Offset: 0xBA0350 VA: 0x180BA1D50
	public bool get_IgnoreComments() { }

	// RVA: 0xBA1FE0 Offset: 0xBA05E0 VA: 0x180BA1FE0
	public void set_IgnoreComments(bool value) { }

	// RVA: 0x599D40 Offset: 0x598340 VA: 0x180599D40
	public DtdProcessing get_DtdProcessing() { }

	// RVA: 0xBA1F60 Offset: 0xBA0560 VA: 0x180BA1F60
	public void set_DtdProcessing(DtdProcessing value) { }

	// RVA: 0x82CB10 Offset: 0x82B110 VA: 0x18082CB10
	public bool get_CloseInput() { }

	// RVA: 0xBA1E90 Offset: 0xBA0490 VA: 0x180BA1E90
	public void set_CloseInput(bool value) { }

	// RVA: 0x8D9010 Offset: 0x8D7610 VA: 0x1808D9010
	public ValidationType get_ValidationType() { }

	// RVA: 0xBA23F0 Offset: 0xBA09F0 VA: 0x180BA23F0
	public void set_ValidationType(ValidationType value) { }

	// RVA: 0x5DE920 Offset: 0x5DCF20 VA: 0x1805DE920
	public XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0xBA2370 Offset: 0xBA0970 VA: 0x180BA2370
	public void set_ValidationFlags(XmlSchemaValidationFlags value) { }

	// RVA: 0xBA1D80 Offset: 0xBA0380 VA: 0x180BA1D80
	public XmlSchemaSet get_Schemas() { }

	// RVA: 0xBA2310 Offset: 0xBA0910 VA: 0x180BA2310
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0xBA14F0 Offset: 0xB9FAF0 VA: 0x180BA14F0
	public XmlReaderSettings Clone() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0xBA1630 Offset: 0xB9FC30 VA: 0x180BA1630
	internal XmlReader CreateReader(Stream input, Uri baseUri, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0xBA17B0 Offset: 0xB9FDB0 VA: 0x180BA17B0
	internal XmlReader CreateReader(TextReader input, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0xBA2300 Offset: 0xBA0900 VA: 0x180BA2300
	internal void set_ReadOnly(bool value) { }

	// RVA: 0xBA1440 Offset: 0xB9FA40 VA: 0x180BA1440
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0xBA1BB0 Offset: 0xBA01B0 VA: 0x180BA1BB0
	private void Initialize() { }

	// RVA: 0xBA1AE0 Offset: 0xBA00E0 VA: 0x180BA1AE0
	private void Initialize(XmlResolver resolver) { }

	// RVA: 0xBA1550 Offset: 0xB9FB50 VA: 0x180BA1550
	private static XmlResolver CreateDefaultResolver() { }

	// RVA: 0xBA1310 Offset: 0xB9F910 VA: 0x180BA1310
	internal XmlReader AddValidation(XmlReader reader) { }

	// RVA: 0xBA15A0 Offset: 0xB9FBA0 VA: 0x180BA15A0
	private XmlValidatingReaderImpl CreateDtdValidatingReader(XmlReader baseReader) { }

	// RVA: 0xBA19A0 Offset: 0xB9FFA0 VA: 0x180BA19A0
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

	// RVA: 0xBB2380 Offset: 0xBB0980 VA: 0x180BB2380
	internal void .ctor(TextWriter textWriter) { }

	// RVA: 0xBB2440 Offset: 0xBB0A40 VA: 0x180BB2440
	internal void set_QuoteChar(char value) { }

	// RVA: 0xBB0DC0 Offset: 0xBAF3C0 VA: 0x180BB0DC0
	internal void StartAttribute(bool cacheAttrValue) { }

	// RVA: 0xBB0D80 Offset: 0xBAF380 VA: 0x180BB0D80
	internal void EndAttribute() { }

	// RVA: 0xBB23D0 Offset: 0xBB09D0 VA: 0x180BB23D0
	internal string get_AttributeValue() { }

	// RVA: 0xBB1770 Offset: 0xBAFD70 VA: 0x180BB1770
	internal void WriteSurrogateChar(char lowChar, char highChar) { }

	// RVA: 0xBB1850 Offset: 0xBAFE50 VA: 0x180BB1850
	internal void Write(char[] array, int offset, int count) { }

	// RVA: 0xBB15F0 Offset: 0xBAFBF0 VA: 0x180BB15F0
	internal void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0xBB1D50 Offset: 0xBB0350 VA: 0x180BB1D50
	internal void Write(string text) { }

	// RVA: 0xBB1170 Offset: 0xBAF770 VA: 0x180BB1170
	internal void WriteRawWithSurrogateChecking(string text) { }

	// RVA: 0xBB1390 Offset: 0xBAF990 VA: 0x180BB1390
	internal void WriteRaw(char[] array, int offset, int count) { }

	// RVA: 0xBB0F60 Offset: 0xBAF560 VA: 0x180BB0F60
	internal void WriteCharEntity(char ch) { }

	// RVA: 0xBB10F0 Offset: 0xBAF6F0 VA: 0x180BB10F0
	internal void WriteEntityRef(string name) { }

	// RVA: 0xBB1530 Offset: 0xBAFB30 VA: 0x180BB1530
	private void WriteStringFragment(string str, int offset, int count, char[] helperBuffer) { }

	// RVA: 0xBB0EF0 Offset: 0xBAF4F0 VA: 0x180BB0EF0
	private void WriteCharEntityImpl(char ch) { }

	// RVA: 0xBB0E50 Offset: 0xBAF450 VA: 0x180BB0E50
	private void WriteCharEntityImpl(string strVal) { }

	// RVA: 0xBB1070 Offset: 0xBAF670 VA: 0x180BB1070
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

	// RVA: 0xBC8AB0 Offset: 0xBC70B0 VA: 0x180BC8AB0
	public void .ctor(Stream input) { }

	// RVA: 0xBC88D0 Offset: 0xBC6ED0 VA: 0x180BC88D0
	public void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0xBC87B0 Offset: 0xBC6DB0 VA: 0x180BC87B0
	public void .ctor(TextReader input) { }

	// RVA: 0xBC89B0 Offset: 0xBC6FB0 VA: 0x180BC89B0
	public void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0xB191B0 Offset: 0xB177B0 VA: 0x180B191B0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC8DB0 Offset: 0xBC73B0 VA: 0x180BC8DB0 Slot: 7
	public override string get_Name() { }

	// RVA: 0xBC8D50 Offset: 0xBC7350 VA: 0x180BC8D50 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0xBC8E10 Offset: 0xBC7410 VA: 0x180BC8E10 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0xBC8E80 Offset: 0xBC7480 VA: 0x180BC8E80 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xBC8EE0 Offset: 0xBC74E0 VA: 0x180BC8EE0 Slot: 11
	public override string get_Value() { }

	// RVA: 0xBC8C00 Offset: 0xBC7200 VA: 0x180BC8C00 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xBC8BD0 Offset: 0xBC71D0 VA: 0x180BC8BD0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBC8CC0 Offset: 0xBC72C0 VA: 0x180BC8CC0 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xBC8C90 Offset: 0xBC7290 VA: 0x180BC8C90 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xBC8EB0 Offset: 0xBC74B0 VA: 0x180BC8EB0 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xBC8F40 Offset: 0xBC7540 VA: 0x180BC8F40 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBC8F10 Offset: 0xBC7510 VA: 0x180BC8F10 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0xB19300 Offset: 0xB17900 VA: 0x180B19300 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xBC8450 Offset: 0xBC6A50 VA: 0x180BC8450 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xBC8480 Offset: 0xBC6A80 VA: 0x180BC8480 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0xBC84B0 Offset: 0xBC6AB0 VA: 0x180BC84B0 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xBC8550 Offset: 0xBC6B50 VA: 0x180BC8550 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xBC8520 Offset: 0xBC6B20 VA: 0x180BC8520 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0xBC85B0 Offset: 0xBC6BB0 VA: 0x180BC85B0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xBC85E0 Offset: 0xBC6BE0 VA: 0x180BC85E0 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0xBC8580 Offset: 0xBC6B80 VA: 0x180BC8580 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0xBC8610 Offset: 0xBC6C10 VA: 0x180BC8610 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0xBC8670 Offset: 0xBC6C70 VA: 0x180BC8670 Slot: 31
	public override bool Read() { }

	// RVA: 0xBC8C60 Offset: 0xBC7260 VA: 0x180BC8C60 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0xB9F100 Offset: 0xB9D700 VA: 0x180B9F100 Slot: 33
	public override void Close() { }

	// RVA: 0xB9F170 Offset: 0xB9D770 VA: 0x180B9F170 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xBC86D0 Offset: 0xBC6CD0 VA: 0x180BC86D0 Slot: 35
	public override void Skip() { }

	// RVA: 0xBC8D80 Offset: 0xBC7380 VA: 0x180BC8D80 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xBC84E0 Offset: 0xBC6AE0 VA: 0x180BC84E0 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0xBC86A0 Offset: 0xBC6CA0 VA: 0x180BC86A0 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0xBC8640 Offset: 0xBC6C40 VA: 0x180BC8640 Slot: 42
	public override string ReadString() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 53
	public bool HasLineInfo() { }

	// RVA: 0xBC8CF0 Offset: 0xBC72F0 VA: 0x180BC8CF0 Slot: 54
	public int get_LineNumber() { }

	// RVA: 0xBC8D20 Offset: 0xBC7320 VA: 0x180BC8D20 Slot: 55
	public int get_LinePosition() { }

	// RVA: 0xBC8700 Offset: 0xBC6D00 VA: 0x180BC8700 Slot: 56
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xBC8740 Offset: 0xBC6D40 VA: 0x180BC8740 Slot: 57
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0xBC8770 Offset: 0xBC6D70 VA: 0x180BC8770 Slot: 58
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0xBC8E40 Offset: 0xBC7440 VA: 0x180BC8E40
	public bool get_Namespaces() { }

	// RVA: 0xBC8E60 Offset: 0xBC7460 VA: 0x180BC8E60
	public bool get_Normalization() { }

	// RVA: 0xBC9010 Offset: 0xBC7610 VA: 0x180BC9010
	public void set_Normalization(bool value) { }

	// RVA: 0xBC90D0 Offset: 0xBC76D0 VA: 0x180BC90D0
	public void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0xBC8F70 Offset: 0xBC7570 VA: 0x180BC8F70
	public void set_EntityHandling(EntityHandling value) { }

	// RVA: 0xBC91B0 Offset: 0xBC77B0 VA: 0x180BC91B0
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal XmlTextReaderImpl get_Impl() { }

	// RVA: 0xBC8DE0 Offset: 0xBC73E0 VA: 0x180BC8DE0 Slot: 51
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0xBC9260 Offset: 0xBC7860 VA: 0x180BC9260
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0xBC8C30 Offset: 0xBC7230 VA: 0x180BC8C30 Slot: 52
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

	// RVA: 0xBC6030 Offset: 0xBC4630 VA: 0x180BC6030
	internal void .ctor(XmlNameTable nt) { }

	// RVA: 0xBC6A00 Offset: 0xBC5000 VA: 0x180BC6A00
	private void .ctor(XmlResolver resolver, XmlReaderSettings settings, XmlParserContext context) { }

	// RVA: 0xBC6600 Offset: 0xBC4C00 VA: 0x180BC6600
	internal void .ctor(Stream input) { }

	// RVA: 0xBC67D0 Offset: 0xBC4DD0 VA: 0x180BC67D0
	internal void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0xBC6570 Offset: 0xBC4B70 VA: 0x180BC6570
	internal void .ctor(TextReader input) { }

	// RVA: 0xBC6F30 Offset: 0xBC5530 VA: 0x180BC6F30
	internal void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0xBC7350 Offset: 0xBC5950 VA: 0x180BC7350
	internal void .ctor(string url, TextReader input, XmlNameTable nt) { }

	// RVA: 0xBC6440 Offset: 0xBC4A40 VA: 0x180BC6440
	internal void .ctor(string xmlFragment, XmlNodeType fragType, XmlParserContext context) { }

	// RVA: 0xBC68F0 Offset: 0xBC4EF0 VA: 0x180BC68F0
	internal void .ctor(string xmlFragment, XmlParserContext context) { }

	// RVA: 0xBB58B0 Offset: 0xBB3EB0 VA: 0x180BB58B0
	private void FinishInitUriString() { }

	// RVA: 0xBC6FA0 Offset: 0xBC55A0 VA: 0x180BC6FA0
	internal void .ctor(Stream stream, byte[] bytes, int byteCount, XmlReaderSettings settings, Uri baseUri, string baseUriStr, XmlParserContext context, bool closeInput) { }

	// RVA: 0xBB5730 Offset: 0xBB3D30 VA: 0x180BB5730
	private void FinishInitStream() { }

	// RVA: 0xBC6690 Offset: 0xBC4C90 VA: 0x180BC6690
	internal void .ctor(TextReader input, XmlReaderSettings settings, string baseUriStr, XmlParserContext context) { }

	// RVA: 0xBB5800 Offset: 0xBB3E00 VA: 0x180BB5800
	private void FinishInitTextReader() { }

	// RVA: 0xBC7290 Offset: 0xBC5890 VA: 0x180BC7290
	internal void .ctor(string xmlFragment, XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0xBC7820 Offset: 0xBC5E20 VA: 0x180BC7820 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0xBC77A0 Offset: 0xBC5DA0 VA: 0x180BC77A0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC7750 Offset: 0xBC5D50 VA: 0x180BC7750 Slot: 7
	public override string get_Name() { }

	// RVA: 0xBC7730 Offset: 0xBC5D30 VA: 0x180BC7730 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0xBC7780 Offset: 0xBC5D80 VA: 0x180BC7780 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0xBC77C0 Offset: 0xBC5DC0 VA: 0x180BC77C0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xBC7C50 Offset: 0xBC6250 VA: 0x180BC7C50 Slot: 11
	public override string get_Value() { }

	// RVA: 0xBC7450 Offset: 0xBC5A50 VA: 0x180BC7450 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x7E6EB0 Offset: 0x7E54B0 VA: 0x1807E6EB0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBC7650 Offset: 0xBC5C50 VA: 0x180BC7650 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xBC7620 Offset: 0xBC5C20 VA: 0x180BC7620 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xBC77E0 Offset: 0xBC5DE0 VA: 0x180BC77E0 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xBC7DE0 Offset: 0xBC63E0 VA: 0x180BC7DE0 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBC7DC0 Offset: 0xBC63C0 VA: 0x180BC7DC0 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0xBC7810 Offset: 0xBC5E10 VA: 0x180BC7810 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xBC75B0 Offset: 0xBC5BB0 VA: 0x180BC75B0 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x4EF3A0 Offset: 0x4ED9A0 VA: 0x1804EF3A0 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0xAE2D00 Offset: 0xAE1300 VA: 0x180AE2D00 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xBB6470 Offset: 0xBB4A70 VA: 0x180BB6470 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xBB62B0 Offset: 0xBB48B0 VA: 0x180BB62B0 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0xBB61F0 Offset: 0xBB47F0 VA: 0x180BB61F0 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xBB8AB0 Offset: 0xBB70B0 VA: 0x180BB8AB0 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xBB8B80 Offset: 0xBB7180 VA: 0x180BB8B80 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0xBB8D00 Offset: 0xBB7300 VA: 0x180BB8D00 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xBB8D90 Offset: 0xBB7390 VA: 0x180BB8D90 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0xBB8C60 Offset: 0xBB7260 VA: 0x180BB8C60 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0xBB5C00 Offset: 0xBB4200 VA: 0x180BB5C00
	private void FinishInit() { }

	// RVA: 0xBC28D0 Offset: 0xBC0ED0 VA: 0x180BC28D0 Slot: 31
	public override bool Read() { }

	// RVA: 0xBB4510 Offset: 0xBB2B10 VA: 0x180BB4510 Slot: 33
	public override void Close() { }

	// RVA: 0xBC4770 Offset: 0xBC2D70 VA: 0x180BC4770 Slot: 35
	public override void Skip() { }

	// RVA: 0xBB8970 Offset: 0xBB6F70 VA: 0x180BB8970 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0xBC1BA0 Offset: 0xBC01A0 VA: 0x180BC1BA0 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0xBC3280 Offset: 0xBC1880 VA: 0x180BC3280 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0xBC81E0 Offset: 0xBC67E0 VA: 0x180BC81E0
	internal void set_OuterReader(XmlReader value) { }

	// RVA: 0xBB89E0 Offset: 0xBB6FE0 VA: 0x180BB89E0
	internal void MoveOffEntityReference() { }

	// RVA: 0xBC23A0 Offset: 0xBC09A0 VA: 0x180BC23A0 Slot: 42
	public override string ReadString() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0xBC23C0 Offset: 0xBC09C0 VA: 0x180BC23C0 Slot: 41
	public override int ReadValueChunk(char[] buffer, int index, int count) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 53
	public bool HasLineInfo() { }

	// RVA: 0xBC76D0 Offset: 0xBC5CD0 VA: 0x180BC76D0 Slot: 54
	public int get_LineNumber() { }

	// RVA: 0xBC7700 Offset: 0xBC5D00 VA: 0x180BC7700 Slot: 55
	public int get_LinePosition() { }

	// RVA: 0xBB6820 Offset: 0xBB4E20 VA: 0x180BB6820 Slot: 56
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xBC4EA0 Offset: 0xBC34A0 VA: 0x180BC4EA0 Slot: 57
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0xBB89B0 Offset: 0xBB6FB0 VA: 0x180BB89B0 Slot: 58
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0xBB6820 Offset: 0xBB4E20 VA: 0x180BB6820
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xBB89B0 Offset: 0xBB6FB0 VA: 0x180BB89B0
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0xBC7580 Offset: 0xBC5B80 VA: 0x180BC7580
	internal bool get_Namespaces() { }

	// RVA: 0xBC7F00 Offset: 0xBC6500 VA: 0x180BC7F00
	internal void set_Namespaces(bool value) { }

	// RVA: 0xBC7590 Offset: 0xBC5B90 VA: 0x180BC7590
	internal bool get_Normalization() { }

	// RVA: 0xBC8120 Offset: 0xBC6720 VA: 0x180BC8120
	internal void set_Normalization(bool value) { }

	// RVA: 0xBC8200 Offset: 0xBC6800 VA: 0x180BC8200
	internal void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0xBC7E10 Offset: 0xBC6410 VA: 0x180BC7E10
	internal void set_EntityHandling(EntityHandling value) { }

	// RVA: 0xBC76C0 Offset: 0xBC5CC0 VA: 0x180BC76C0
	internal bool get_IsResolverSet() { }

	// RVA: 0xBC82E0 Offset: 0xBC68E0 VA: 0x180BC82E0
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x4EF3A0 Offset: 0x4ED9A0 VA: 0x1804EF3A0
	internal XmlNameTable get_DtdParserProxy_NameTable() { }

	// RVA: 0xBC7570 Offset: 0xBC5B70 VA: 0x180BC7570
	internal IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver() { }

	// RVA: 0xBC7540 Offset: 0xBC5B40 VA: 0x180BC7540
	internal bool get_DtdParserProxy_DtdValidation() { }

	// RVA: 0xBC7590 Offset: 0xBC5B90 VA: 0x180BC7590
	internal bool get_DtdParserProxy_Normalization() { }

	// RVA: 0xBC7580 Offset: 0xBC5B80 VA: 0x180BC7580
	internal bool get_DtdParserProxy_Namespaces() { }

	// RVA: 0xBC75A0 Offset: 0xBC5BA0 VA: 0x180BC75A0
	internal bool get_DtdParserProxy_V1CompatibilityMode() { }

	// RVA: 0xBC7470 Offset: 0xBC5A70 VA: 0x180BC7470
	internal Uri get_DtdParserProxy_BaseUri() { }

	// RVA: 0x69D710 Offset: 0x69BD10 VA: 0x18069D710
	internal bool get_DtdParserProxy_IsEof() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	internal char[] get_DtdParserProxy_ParsingBuffer() { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40
	internal int get_DtdParserProxy_ParsingBufferLength() { }

	// RVA: 0xA38FA0 Offset: 0xA375A0 VA: 0x180A38FA0
	internal int get_DtdParserProxy_CurrentPosition() { }

	// RVA: 0xA39560 Offset: 0xA37B60 VA: 0x180A39560
	internal void set_DtdParserProxy_CurrentPosition(int value) { }

	// RVA: 0xBC7550 Offset: 0xBC5B50 VA: 0x180BC7550
	internal int get_DtdParserProxy_EntityStackLength() { }

	// RVA: 0xBC7560 Offset: 0xBC5B60 VA: 0x180BC7560
	internal bool get_DtdParserProxy_IsEntityEolNormalized() { }

	// RVA: 0x737FC0 Offset: 0x7365C0 VA: 0x180737FC0
	internal IValidationEventHandling get_DtdParserProxy_ValidationEventHandling() { }

	// RVA: 0xBB4920 Offset: 0xBB2F20 VA: 0x180BB4920
	internal void DtdParserProxy_OnNewLine(int pos) { }

	// RVA: 0x803B80 Offset: 0x802180 VA: 0x180803B80
	internal int get_DtdParserProxy_LineNo() { }

	// RVA: 0xB28E70 Offset: 0xB27470 VA: 0x180B28E70
	internal int get_DtdParserProxy_LineStartPosition() { }

	// RVA: 0xBB5150 Offset: 0xBB3750 VA: 0x180BB5150
	internal int DtdParserProxy_ReadData() { }

	// RVA: 0xBB4C70 Offset: 0xBB3270 VA: 0x180BB4C70
	internal int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0xBB4C60 Offset: 0xBB3260 VA: 0x180BB4C60
	internal int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0xBB4D20 Offset: 0xBB3320 VA: 0x180BB4D20
	internal void DtdParserProxy_ParsePI(StringBuilder sb) { }

	// RVA: 0xBB4AF0 Offset: 0xBB30F0 VA: 0x180BB4AF0
	internal void DtdParserProxy_ParseComment(StringBuilder sb) { }

	// RVA: 0xBC7680 Offset: 0xBC5C80 VA: 0x180BC7680
	private bool get_IsResolverNull() { }

	// RVA: 0xBB6890 Offset: 0xBB4E90 VA: 0x180BB6890
	private XmlResolver GetTempResolver() { }

	// RVA: 0xBB4E60 Offset: 0xBB3460 VA: 0x180BB4E60
	internal bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, out int entityId) { }

	// RVA: 0xBB4D70 Offset: 0xBB3370 VA: 0x180BB4D70
	internal bool DtdParserProxy_PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	// RVA: 0xBB4F30 Offset: 0xBB3530 VA: 0x180BB4F30
	internal bool DtdParserProxy_PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0xBB50B0 Offset: 0xBB36B0 VA: 0x180BB50B0
	internal void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0xBB5160 Offset: 0xBB3760 VA: 0x180BB5160
	internal void DtdParserProxy_Throw(Exception e) { }

	// RVA: 0xBB4A10 Offset: 0xBB3010 VA: 0x180BB4A10
	internal void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0xBB4930 Offset: 0xBB2F30 VA: 0x180BB4930
	internal void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0xBC58F0 Offset: 0xBC3EF0 VA: 0x180BC58F0
	private void Throw(int pos, string res, string arg) { }

	// RVA: 0xBC5CB0 Offset: 0xBC42B0 VA: 0x180BC5CB0
	private void Throw(int pos, string res, string[] args) { }

	// RVA: 0xBC5930 Offset: 0xBC3F30 VA: 0x180BC5930
	private void Throw(int pos, string res) { }

	// RVA: 0xBC5A40 Offset: 0xBC4040 VA: 0x180BC5A40
	private void Throw(string res) { }

	// RVA: 0xBC5CF0 Offset: 0xBC42F0 VA: 0x180BC5CF0
	private void Throw(string res, int lineNo, int linePos) { }

	// RVA: 0xBC5B60 Offset: 0xBC4160 VA: 0x180BC5B60
	private void Throw(string res, string arg) { }

	// RVA: 0xBC59A0 Offset: 0xBC3FA0 VA: 0x180BC59A0
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0xBC5AA0 Offset: 0xBC40A0 VA: 0x180BC5AA0
	private void Throw(string res, string[] args) { }

	// RVA: 0xBC5C20 Offset: 0xBC4220 VA: 0x180BC5C20
	private void Throw(string res, string arg, Exception innerException) { }

	// RVA: 0xBC5830 Offset: 0xBC3E30 VA: 0x180BC5830
	private void Throw(string res, string[] args, Exception innerException) { }

	// RVA: 0xBC5770 Offset: 0xBC3D70 VA: 0x180BC5770
	private void Throw(Exception e) { }

	// RVA: 0xBC1AF0 Offset: 0xBC00F0 VA: 0x180BC1AF0
	private void ReThrow(Exception e, int lineNo, int linePos) { }

	// RVA: 0xBC55A0 Offset: 0xBC3BA0 VA: 0x180BC55A0
	private void ThrowWithoutLineInfo(string res) { }

	// RVA: 0xBC5640 Offset: 0xBC3C40 VA: 0x180BC5640
	private void ThrowWithoutLineInfo(string res, string arg) { }

	// RVA: 0xBC56D0 Offset: 0xBC3CD0 VA: 0x180BC56D0
	private void ThrowWithoutLineInfo(string res, string[] args, Exception innerException) { }

	// RVA: 0xBC4F30 Offset: 0xBC3530 VA: 0x180BC4F30
	private void ThrowInvalidChar(char[] data, int length, int invCharPos) { }

	// RVA: 0xBC37A0 Offset: 0xBC1DA0 VA: 0x180BC37A0
	private void SetErrorState() { }

	// RVA: 0xBC34E0 Offset: 0xBC1AE0 VA: 0x180BC34E0
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos) { }

	// RVA: 0xBC3620 Offset: 0xBC1C20 VA: 0x180BC3620
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception) { }

	// RVA: 0xBC75C0 Offset: 0xBC5BC0 VA: 0x180BC75C0
	private bool get_InAttributeValueIterator() { }

	// RVA: 0xBB5450 Offset: 0xBB3A50 VA: 0x180BB5450
	private void FinishAttributeValueIterator() { }

	// RVA: 0xBC7540 Offset: 0xBC5B40 VA: 0x180BC7540
	private bool get_DtdValidation() { }

	// RVA: 0xBB80C0 Offset: 0xBB66C0 VA: 0x180BB80C0
	private void InitStreamInput(Stream stream, Encoding encoding) { }

	// RVA: 0xBB84D0 Offset: 0xBB6AD0 VA: 0x180BB84D0
	private void InitStreamInput(string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0xBB8450 Offset: 0xBB6A50 VA: 0x180BB8450
	private void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding) { }

	// RVA: 0xBB8090 Offset: 0xBB6690 VA: 0x180BB8090
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0xBB8140 Offset: 0xBB6740 VA: 0x180BB8140
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, byte[] bytes, int byteCount, Encoding encoding) { }

	// RVA: 0xBB8620 Offset: 0xBB6C20 VA: 0x180BB8620
	private void InitTextReaderInput(string baseUriStr, TextReader input) { }

	// RVA: 0xBB8640 Offset: 0xBB6C40 VA: 0x180BB8640
	private void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input) { }

	// RVA: 0xBB8500 Offset: 0xBB6B00 VA: 0x180BB8500
	private void InitStringInput(string baseUriStr, Encoding originalEncoding, string str) { }

	// RVA: 0xBB7DF0 Offset: 0xBB63F0 VA: 0x180BB7DF0
	private void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment) { }

	// RVA: 0xBC1210 Offset: 0xBBF810 VA: 0x180BC1210
	private void ProcessDtdFromParserContext(XmlParserContext context) { }

	// RVA: 0xBB9880 Offset: 0xBB7E80 VA: 0x180BB9880
	private void OpenUrl() { }

	// RVA: 0xBB9730 Offset: 0xBB7D30 VA: 0x180BB9730
	private void OpenUrlDelegate(object xmlResolver) { }

	// RVA: 0xBB4700 Offset: 0xBB2D00 VA: 0x180BB4700
	private Encoding DetectEncoding() { }

	// RVA: 0xBC37C0 Offset: 0xBC1DC0 VA: 0x180BC37C0
	private void SetupEncoding(Encoding encoding) { }

	// RVA: 0xBC4D00 Offset: 0xBC3300 VA: 0x180BC4D00
	private void SwitchEncoding(Encoding newEncoding) { }

	// RVA: 0xBB4270 Offset: 0xBB2870 VA: 0x180BB4270
	private Encoding CheckEncoding(string newEncodingName) { }

	// RVA: 0xBC5DB0 Offset: 0xBC43B0 VA: 0x180BC5DB0
	private void UnDecodeChars() { }

	// RVA: 0xBC4C90 Offset: 0xBC3290 VA: 0x180BC4C90
	private void SwitchEncodingToUTF8() { }

	// RVA: 0xBC1F10 Offset: 0xBC0510 VA: 0x180BC1F10
	private int ReadData() { }

	// RVA: 0xBB6510 Offset: 0xBB4B10 VA: 0x180BB6510
	private int GetChars(int maxCharsCount) { }

	// RVA: 0xBB8730 Offset: 0xBB6D30 VA: 0x180BB8730
	private void InvalidCharRecovery(ref int bytesCount, out int charsCount) { }

	// RVA: 0xBB4610 Offset: 0xBB2C10 VA: 0x180BB4610
	internal void Close(bool closeInput) { }

	// RVA: 0xBC3D60 Offset: 0xBC2360 VA: 0x180BC3D60
	private void ShiftBuffer(int sourcePos, int destPos, int count) { }

	// RVA: 0xBBFF80 Offset: 0xBBE580 VA: 0x180BBFF80
	private bool ParseXmlDeclaration(bool isTextDecl) { }

	// RVA: 0xBBBD90 Offset: 0xBBA390 VA: 0x180BBBD90
	private bool ParseDocumentContent() { }

	// RVA: 0xBBC730 Offset: 0xBBAD30 VA: 0x180BBC730
	private bool ParseElementContent() { }

	// RVA: 0xBC51D0 Offset: 0xBC37D0 VA: 0x180BC51D0
	private void ThrowUnclosedElements() { }

	// RVA: 0xBBCAD0 Offset: 0xBBB0D0 VA: 0x180BBCAD0
	private void ParseElement() { }

	// RVA: 0xBB3180 Offset: 0xBB1780 VA: 0x180BB3180
	private void AddDefaultAttributesAndNormalize() { }

	// RVA: 0xBBD090 Offset: 0xBBB690 VA: 0x180BBD090
	private void ParseEndElement() { }

	// RVA: 0xBC4FA0 Offset: 0xBC35A0 VA: 0x180BC4FA0
	private void ThrowTagMismatch(XmlTextReaderImpl.NodeData startTag) { }

	// RVA: 0xBBAD10 Offset: 0xBB9310 VA: 0x180BBAD10
	private void ParseAttributes() { }

	// RVA: 0xBB53E0 Offset: 0xBB39E0 VA: 0x180BB53E0
	private void ElementNamespaceLookup() { }

	// RVA: 0xBB4160 Offset: 0xBB2760 VA: 0x180BB4160
	private void AttributeNamespaceLookup() { }

	// RVA: 0xBB3D30 Offset: 0xBB2330 VA: 0x180BB3D30
	private void AttributeDuplCheck() { }

	// RVA: 0xBB8F50 Offset: 0xBB7550 VA: 0x180BB8F50
	private void OnDefaultNamespaceDecl(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0xBB9160 Offset: 0xBB7760 VA: 0x180BB9160
	private void OnNamespaceDecl(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0xBB9270 Offset: 0xBB7870 VA: 0x180BB9270
	private void OnXmlReservedAttribute(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0xBBA240 Offset: 0xBB8840 VA: 0x180BBA240
	private void ParseAttributeValueSlow(int curPos, char quoteChar, XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0xBB2450 Offset: 0xBB0A50 VA: 0x180BB2450
	private void AddAttributeChunkToList(XmlTextReaderImpl.NodeData attr, XmlTextReaderImpl.NodeData chunk, ref XmlTextReaderImpl.NodeData lastChunk) { }

	// RVA: 0xBBF970 Offset: 0xBBDF70 VA: 0x180BBF970
	private bool ParseText() { }

	// RVA: 0xBBF1B0 Offset: 0xBBD7B0 VA: 0x180BBF1B0
	private bool ParseText(out int startPos, out int endPos, ref int outOrChars) { }

	// RVA: 0xBB5D90 Offset: 0xBB4390 VA: 0x180BB5D90
	private void FinishPartialValue() { }

	// RVA: 0xBB5C50 Offset: 0xBB4250 VA: 0x180BB5C50
	private void FinishOtherValueIterator() { }

	// RVA: 0xBC4140 Offset: 0xBC2740 VA: 0x180BC4140
	private void SkipPartialTextValue() { }

	// RVA: 0xBB6100 Offset: 0xBB4700 VA: 0x180BB6100
	private void FinishReadValueChunk() { }

	// RVA: 0xBB5EC0 Offset: 0xBB44C0 VA: 0x180BB5EC0
	private void FinishReadContentAsBinary() { }

	// RVA: 0xBB6010 Offset: 0xBB4610 VA: 0x180BB6010
	private void FinishReadElementContentAsBinary() { }

	// RVA: 0xBBEEC0 Offset: 0xBBD4C0 VA: 0x180BBEEC0
	private bool ParseRootLevelWhitespace() { }

	// RVA: 0xBBD620 Offset: 0xBBBC20 VA: 0x180BBD620
	private void ParseEntityReference() { }

	// RVA: 0xBB6B40 Offset: 0xBB5140 VA: 0x180BB6B40
	private XmlTextReaderImpl.EntityType HandleEntityReference(bool isInAttributeValue, XmlTextReaderImpl.EntityExpandType expandType, out int charRefEndPos) { }

	// RVA: 0xBB6DE0 Offset: 0xBB53E0 VA: 0x180BB6DE0
	private XmlTextReaderImpl.EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos) { }

	// RVA: 0xBC75E0 Offset: 0xBC5BE0 VA: 0x180BC75E0
	private bool get_InEntity() { }

	// RVA: 0xBB69A0 Offset: 0xBB4FA0 VA: 0x180BB69A0
	private bool HandleEntityEnd(bool checkEntityNesting) { }

	// RVA: 0xBC39B0 Offset: 0xBC1FB0 VA: 0x180BC39B0
	private void SetupEndEntityNodeInContent() { }

	// RVA: 0xBC3920 Offset: 0xBC1F20 VA: 0x180BC3920
	private void SetupEndEntityNodeInAttribute() { }

	// RVA: 0xBBE7D0 Offset: 0xBBCDD0 VA: 0x180BBE7D0
	private bool ParsePI() { }

	// RVA: 0xBBE7E0 Offset: 0xBBCDE0 VA: 0x180BBE7E0
	private bool ParsePI(StringBuilder piInDtdStringBuilder) { }

	// RVA: 0xBBE400 Offset: 0xBBCA00 VA: 0x180BBE400
	private bool ParsePIValue(out int outStartPos, out int outEndPos) { }

	// RVA: 0xBBBA70 Offset: 0xBBA070 VA: 0x180BBBA70
	private bool ParseComment() { }

	// RVA: 0xBBB9D0 Offset: 0xBB9FD0 VA: 0x180BBB9D0
	private void ParseCData() { }

	// RVA: 0xBBB390 Offset: 0xBB9990 VA: 0x180BBB390
	private void ParseCDataOrComment(XmlNodeType type) { }

	// RVA: 0xBBB570 Offset: 0xBB9B70 VA: 0x180BBB570
	private bool ParseCDataOrComment(XmlNodeType type, out int outStartPos, out int outEndPos) { }

	// RVA: 0xBBBAD0 Offset: 0xBBA0D0 VA: 0x180BBBAD0
	private bool ParseDoctypeDecl() { }

	// RVA: 0xBBC4B0 Offset: 0xBBAAB0 VA: 0x180BBC4B0
	private void ParseDtd() { }

	// RVA: 0xBC3D90 Offset: 0xBC2390 VA: 0x180BC3D90
	private void SkipDtd() { }

	// RVA: 0xBC41A0 Offset: 0xBC27A0 VA: 0x180BC41A0
	private void SkipPublicOrSystemIdLiteral() { }

	// RVA: 0xBC4240 Offset: 0xBC2840 VA: 0x180BC4240
	private void SkipUntil(char stopChar, bool recognizeLiterals) { }

	// RVA: 0xBB5170 Offset: 0xBB3770 VA: 0x180BB5170
	private int EatWhitespaces(StringBuilder sb) { }

	// RVA: 0xBBB9E0 Offset: 0xBB9FE0 VA: 0x180BBB9E0
	private int ParseCharRefInline(int startPos, out int charCount, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0xBBE330 Offset: 0xBBC930 VA: 0x180BBE330
	private int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0xBBDBC0 Offset: 0xBBC1C0 VA: 0x180BBDBC0
	private int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, out int charCount, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0xBBDB40 Offset: 0xBBC140 VA: 0x180BBDB40
	private int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0xBBD760 Offset: 0xBBBD60 VA: 0x180BBD760
	private int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0xBBD730 Offset: 0xBBBD30 VA: 0x180BBD730
	private int ParseName() { }

	// RVA: 0xBBEBF0 Offset: 0xBBD1F0 VA: 0x180BBEBF0
	private int ParseQName(out int colonPos) { }

	// RVA: 0xBBEC10 Offset: 0xBBD210 VA: 0x180BBEC10
	private int ParseQName(bool isQName, int startOffset, out int colonPos) { }

	// RVA: 0xBC1EC0 Offset: 0xBC04C0 VA: 0x180BC1EC0
	private bool ReadDataInName(ref int pos) { }

	// RVA: 0xBBD520 Offset: 0xBBBB20 VA: 0x180BBD520
	private string ParseEntityName() { }

	// RVA: 0xBB3A00 Offset: 0xBB2000 VA: 0x180BB3A00
	private XmlTextReaderImpl.NodeData AddNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0xBB3BB0 Offset: 0xBB21B0 VA: 0x180BB3BB0
	private XmlTextReaderImpl.NodeData AllocNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0xBB24C0 Offset: 0xBB0AC0 VA: 0x180BB24C0
	private XmlTextReaderImpl.NodeData AddAttributeNoChecks(string name, int attrDepth) { }

	// RVA: 0xBB2550 Offset: 0xBB0B50 VA: 0x180BB2550
	private XmlTextReaderImpl.NodeData AddAttribute(int endNamePos, int colonPos) { }

	// RVA: 0xBB2780 Offset: 0xBB0D80 VA: 0x180BB2780
	private XmlTextReaderImpl.NodeData AddAttribute(string localName, string prefix, string nameWPrefix) { }

	// RVA: 0xBC1000 Offset: 0xBBF600 VA: 0x180BC1000
	private void PopElementContext() { }

	// RVA: 0xBB4920 Offset: 0xBB2F20 VA: 0x180BB4920
	private void OnNewLine(int pos) { }

	// RVA: 0xBB9080 Offset: 0xBB7680 VA: 0x180BB9080
	private void OnEof() { }

	// RVA: 0xBB8890 Offset: 0xBB6E90 VA: 0x180BB8890
	private string LookupNamespace(XmlTextReaderImpl.NodeData node) { }

	// RVA: 0xBB3760 Offset: 0xBB1D60 VA: 0x180BB3760
	private void AddNamespace(string prefix, string uri, XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0xBC31B0 Offset: 0xBC17B0 VA: 0x180BC31B0
	private void ResetAttributes() { }

	// RVA: 0xBB6140 Offset: 0xBB4740 VA: 0x180BB6140
	private void FullAttributeCleanup() { }

	// RVA: 0xBC1A50 Offset: 0xBC0050 VA: 0x180BC1A50
	private void PushXmlContext() { }

	// RVA: 0xBC11D0 Offset: 0xBBF7D0 VA: 0x180BC11D0
	private void PopXmlContext() { }

	// RVA: 0xBB6950 Offset: 0xBB4F50 VA: 0x180BB6950
	private XmlNodeType GetWhitespaceType() { }

	// RVA: 0xBB68F0 Offset: 0xBB4EF0 VA: 0x180BB68F0
	private XmlNodeType GetTextNodeType(int orChars) { }

	// RVA: 0xBC1270 Offset: 0xBBF870 VA: 0x180BC1270
	private void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName) { }

	// RVA: 0xBB9490 Offset: 0xBB7A90 VA: 0x180BB9490
	private bool OpenAndPush(Uri uri) { }

	// RVA: 0xBC1580 Offset: 0xBBFB80 VA: 0x180BC1580
	private bool PushExternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0xBC1780 Offset: 0xBBFD80 VA: 0x180BC1780
	private void PushInternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0xBC1070 Offset: 0xBBF670 VA: 0x180BC1070
	private void PopEntity() { }

	// RVA: 0xBC2FD0 Offset: 0xBC15D0 VA: 0x180BC2FD0
	private void RegisterEntity(IDtdEntityInfo entity) { }

	// RVA: 0xBC5E60 Offset: 0xBC4460 VA: 0x180BC5E60
	private void UnregisterEntity() { }

	// RVA: 0xBC18F0 Offset: 0xBBFEF0 VA: 0x180BC18F0
	private void PushParsingState() { }

	// RVA: 0xBC1100 Offset: 0xBBF700 VA: 0x180BC1100
	private void PopParsingState() { }

	// RVA: 0xBB72C0 Offset: 0xBB58C0 VA: 0x180BB72C0
	private int IncrementalRead() { }

	// RVA: 0xBB56A0 Offset: 0xBB3CA0 VA: 0x180BB56A0
	private void FinishIncrementalRead() { }

	// RVA: 0xBBD6A0 Offset: 0xBBBCA0 VA: 0x180BBD6A0
	private bool ParseFragmentAttribute() { }

	// RVA: 0xBB9B60 Offset: 0xBB8160 VA: 0x180BB9B60
	private bool ParseAttributeValueChunk() { }

	// RVA: 0xBBFED0 Offset: 0xBBE4D0 VA: 0x180BBFED0
	private void ParseXmlDeclarationFragment() { }

	// RVA: 0xBC5580 Offset: 0xBC3B80 VA: 0x180BC5580
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0xBC5570 Offset: 0xBC3B70 VA: 0x180BC5570
	private void ThrowUnexpectedToken(string expectedToken1) { }

	// RVA: 0xBC53D0 Offset: 0xBC39D0 VA: 0x180BC53D0
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0xBC5410 Offset: 0xBC3A10 VA: 0x180BC5410
	private void ThrowUnexpectedToken(string expectedToken1, string expectedToken2) { }

	// RVA: 0xBBFDD0 Offset: 0xBBE3D0 VA: 0x180BBFDD0
	private string ParseUnexpectedToken(int pos) { }

	// RVA: 0xBBFDE0 Offset: 0xBBE3E0 VA: 0x180BBFDE0
	private string ParseUnexpectedToken() { }

	// RVA: 0xBC4EC0 Offset: 0xBC34C0 VA: 0x180BC4EC0
	private void ThrowExpectingWhitespace(int pos) { }

	// RVA: 0xBB6700 Offset: 0xBB4D00 VA: 0x180BB6700
	private int GetIndexOfAttributeWithoutPrefix(string name) { }

	// RVA: 0xBB6620 Offset: 0xBB4C20 VA: 0x180BB6620
	private int GetIndexOfAttributeWithPrefix(string name) { }

	// RVA: 0xBC5FB0 Offset: 0xBC45B0 VA: 0x180BC5FB0
	private bool ZeroEndingStream(int pos) { }

	// RVA: 0xBBC2E0 Offset: 0xBBA8E0 VA: 0x180BBC2E0
	private void ParseDtdFromParserContext() { }

	// RVA: 0xBB8E40 Offset: 0xBB7440 VA: 0x180BB8E40
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

	// RVA: 0xBC3AF0 Offset: 0xBC20F0 VA: 0x180BC3AF0
	private void SetupFromParserContext(XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0x900120 Offset: 0x8FE720 VA: 0x180900120 Slot: 52
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0xBC36E0 Offset: 0xBC1CE0 VA: 0x180BC36E0
	internal void SetDtdInfo(IDtdInfo newDtdInfo) { }

	// RVA: 0xBC81F0 Offset: 0xBC67F0 VA: 0x180BC81F0
	internal void set_ValidationEventHandling(IValidationEventHandling value) { }

	// RVA: 0xBC81D0 Offset: 0xBC67D0 VA: 0x180BC81D0
	internal void set_OnDefaultAttributeUse(XmlTextReaderImpl.OnDefaultAttributeUseDelegate value) { }

	// RVA: 0xBC8390 Offset: 0xBC6990 VA: 0x180BC8390
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x907140 Offset: 0x905740 VA: 0x180907140
	internal XmlNodeType get_FragmentType() { }

	// RVA: 0xBB4250 Offset: 0xBB2850 VA: 0x180BB4250
	internal void ChangeCurrentNodeType(XmlNodeType newNodeType) { }

	// RVA: 0xBB6850 Offset: 0xBB4E50 VA: 0x180BB6850
	internal XmlResolver GetResolver() { }

	// RVA: 0xBC7EA0 Offset: 0xBC64A0 VA: 0x180BC7EA0
	internal void set_InternalSchemaType(object value) { }

	// RVA: 0xBC75F0 Offset: 0xBC5BF0 VA: 0x180BC75F0
	internal object get_InternalTypedValue() { }

	// RVA: 0xBC7ED0 Offset: 0xBC64D0 VA: 0x180BC7ED0
	internal void set_InternalTypedValue(object value) { }

	// RVA: 0xBC7C40 Offset: 0xBC6240 VA: 0x180BC7C40
	internal bool get_StandAlone() { }

	// RVA: 0xBC7570 Offset: 0xBC5B70 VA: 0x180BC7570 Slot: 51
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0xBC75A0 Offset: 0xBC5BA0 VA: 0x180BC75A0
	internal bool get_V1Compat() { }

	// RVA: 0xBB28F0 Offset: 0xBB0EF0 VA: 0x180BB28F0
	private bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, XmlTextReaderImpl.NodeData[] nameSortedNodeData) { }

	// RVA: 0xBB2F00 Offset: 0xBB1500 VA: 0x180BB2F00
	internal bool AddDefaultAttributeNonDtd(SchemaAttDef attrDef) { }

	// RVA: 0xBB2C30 Offset: 0xBB1230 VA: 0x180BB2C30
	private XmlTextReaderImpl.NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute) { }

	// RVA: 0xBC7E00 Offset: 0xBC6400 VA: 0x180BC7E00
	internal void set_DisableUndeclaredEntityCheck(bool value) { }

	// RVA: 0xBC5EC0 Offset: 0xBC44C0 VA: 0x180BC5EC0
	private bool UriEqual(Uri uri1, string uri1Str, string uri2Str, XmlResolver resolver) { }

	// RVA: 0xBC2EC0 Offset: 0xBC14C0 VA: 0x180BC2EC0
	private void RegisterConsumedCharacters(long characters, bool inEntityReference) { }

	// RVA: 0xBC4AB0 Offset: 0xBC30B0 VA: 0x180BC4AB0
	internal static string StripSpaces(string value) { }

	// RVA: 0xBC4950 Offset: 0xBC2F50 VA: 0x180BC4950
	internal static void StripSpaces(char[] value, int index, ref int len) { }

	// RVA: 0xBB4220 Offset: 0xBB2820 VA: 0x180BB4220
	internal static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count) { }

	// RVA: 0xBB4240 Offset: 0xBB2840 VA: 0x180BB4240
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

	// RVA: 0x1318990 Offset: 0x1316F90 VA: 0x181318990
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

	// RVA: 0x1E1020 Offset: 0x1E0420 VA: 0x1801E1020
	internal void Clear() { }

	// RVA: 0x1E1100 Offset: 0x1E0500 VA: 0x1801E1100
	internal void Close(bool closeInput) { }

	// RVA: 0x1E0AF0 Offset: 0x1DFEF0 VA: 0x1801E0AF0
	internal int get_LineNo() { }

	// RVA: 0x1E1140 Offset: 0x1E0540 VA: 0x1801E1140
	internal int get_LinePos() { }

}

private class XmlTextReaderImpl.XmlContext // TypeDefIndex: 1901
{	// Fields
	internal XmlSpace xmlSpace; // 0x10
	internal string xmlLang; // 0x18
	internal string defaultNamespace; // 0x20
	internal XmlTextReaderImpl.XmlContext previousContext; // 0x28

	// Methods

	// RVA: 0x1319B90 Offset: 0x1318190 VA: 0x181319B90
	internal void .ctor() { }

	// RVA: 0x1319C20 Offset: 0x1318220 VA: 0x181319C20
	internal void .ctor(XmlTextReaderImpl.XmlContext previousContext) { }

}

private class XmlTextReaderImpl.NoNamespaceManager : XmlNamespaceManager // TypeDefIndex: 1902
{	// Properties
	public override string DefaultNamespace { get; }

	// Methods

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0x1318A80 Offset: 0x1317080 VA: 0x181318A80 Slot: 9
	public override string get_DefaultNamespace() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	public override void PushScope() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 11
	public override bool PopScope() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	public override void AddNamespace(string prefix, string uri) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 13
	public override void RemoveNamespace(string prefix, string uri) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 14
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 15
	public override IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1318A40 Offset: 0x1317040 VA: 0x181318A40 Slot: 16
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 17
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

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	internal void .ctor(XmlTextReaderImpl reader) { }

	// RVA: 0x1318880 Offset: 0x1316E80 VA: 0x181318880 Slot: 9
	private XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable() { }

	// RVA: 0x13188A0 Offset: 0x1316EA0 VA: 0x1813188A0 Slot: 10
	private IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver() { }

	// RVA: 0x13187A0 Offset: 0x1316DA0 VA: 0x1813187A0 Slot: 11
	private Uri System.Xml.IDtdParserAdapter.get_BaseUri() { }

	// RVA: 0x1318820 Offset: 0x1316E20 VA: 0x181318820 Slot: 18
	private bool System.Xml.IDtdParserAdapter.get_IsEof() { }

	// RVA: 0x13188E0 Offset: 0x1316EE0 VA: 0x1813188E0 Slot: 12
	private char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer() { }

	// RVA: 0x13188C0 Offset: 0x1316EC0 VA: 0x1813188C0 Slot: 13
	private int System.Xml.IDtdParserAdapter.get_ParsingBufferLength() { }

	// RVA: 0x13187C0 Offset: 0x1316DC0 VA: 0x1813187C0 Slot: 14
	private int System.Xml.IDtdParserAdapter.get_CurrentPosition() { }

	// RVA: 0x1318900 Offset: 0x1316F00 VA: 0x181318900 Slot: 15
	private void System.Xml.IDtdParserAdapter.set_CurrentPosition(int value) { }

	// RVA: 0x13187E0 Offset: 0x1316DE0 VA: 0x1813187E0 Slot: 19
	private int System.Xml.IDtdParserAdapter.get_EntityStackLength() { }

	// RVA: 0x1318800 Offset: 0x1316E00 VA: 0x181318800 Slot: 20
	private bool System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized() { }

	// RVA: 0x13185E0 Offset: 0x1316BE0 VA: 0x1813185E0 Slot: 22
	private void System.Xml.IDtdParserAdapter.OnNewLine(int pos) { }

	// RVA: 0x1318840 Offset: 0x1316E40 VA: 0x181318840 Slot: 16
	private int System.Xml.IDtdParserAdapter.get_LineNo() { }

	// RVA: 0x1318860 Offset: 0x1316E60 VA: 0x181318860 Slot: 17
	private int System.Xml.IDtdParserAdapter.get_LineStartPosition() { }

	// RVA: 0x1318760 Offset: 0x1316D60 VA: 0x181318760 Slot: 21
	private int System.Xml.IDtdParserAdapter.ReadData() { }

	// RVA: 0x13186A0 Offset: 0x1316CA0 VA: 0x1813186A0 Slot: 23
	private int System.Xml.IDtdParserAdapter.ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1318680 Offset: 0x1316C80 VA: 0x181318680 Slot: 24
	private int System.Xml.IDtdParserAdapter.ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x13186C0 Offset: 0x1316CC0 VA: 0x1813186C0 Slot: 25
	private void System.Xml.IDtdParserAdapter.ParsePI(StringBuilder sb) { }

	// RVA: 0x1318660 Offset: 0x1316C60 VA: 0x181318660 Slot: 26
	private void System.Xml.IDtdParserAdapter.ParseComment(StringBuilder sb) { }

	// RVA: 0x1318700 Offset: 0x1316D00 VA: 0x181318700 Slot: 27
	private bool System.Xml.IDtdParserAdapter.PushEntity(IDtdEntityInfo entity, out int entityId) { }

	// RVA: 0x13186E0 Offset: 0x1316CE0 VA: 0x1813186E0 Slot: 28
	private bool System.Xml.IDtdParserAdapter.PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	// RVA: 0x1318720 Offset: 0x1316D20 VA: 0x181318720 Slot: 29
	private bool System.Xml.IDtdParserAdapter.PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0x1318740 Offset: 0x1316D40 VA: 0x181318740 Slot: 30
	private void System.Xml.IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0x1318780 Offset: 0x1316D80 VA: 0x181318780 Slot: 33
	private void System.Xml.IDtdParserAdapter.Throw(Exception e) { }

	// RVA: 0x1318630 Offset: 0x1316C30 VA: 0x181318630 Slot: 31
	private void System.Xml.IDtdParserAdapter.OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0x1318600 Offset: 0x1316C00 VA: 0x181318600 Slot: 32
	private void System.Xml.IDtdParserAdapter.OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0x13185A0 Offset: 0x1316BA0 VA: 0x1813185A0 Slot: 7
	private bool System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation() { }

	// RVA: 0x13185C0 Offset: 0x1316BC0 VA: 0x1813185C0 Slot: 8
	private IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling() { }

	// RVA: 0xBC8E60 Offset: 0xBC7460 VA: 0x180BC8E60 Slot: 5
	private bool System.Xml.IDtdParserAdapterV1.get_Normalization() { }

	// RVA: 0xBC8E40 Offset: 0xBC7440 VA: 0x180BC8E40 Slot: 6
	private bool System.Xml.IDtdParserAdapterV1.get_Namespaces() { }

	// RVA: 0x1318580 Offset: 0x1316B80 VA: 0x181318580 Slot: 4
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

	// RVA: 0x13193F0 Offset: 0x13179F0 VA: 0x1813193F0
	internal static XmlTextReaderImpl.NodeData get_None() { }

	// RVA: 0x1319310 Offset: 0x1317910 VA: 0x181319310
	internal void .ctor() { }

	// RVA: 0x8D9010 Offset: 0x8D7610 VA: 0x1808D9010
	internal int get_LineNo() { }

	// RVA: 0x5DE920 Offset: 0x5DCF20 VA: 0x1805DE920
	internal int get_LinePos() { }

	// RVA: 0x13193E0 Offset: 0x13179E0 VA: 0x1813193E0
	internal bool get_IsEmptyElement() { }

	// RVA: 0xE69BD0 Offset: 0xE681D0 VA: 0x180E69BD0
	internal void set_IsEmptyElement(bool value) { }

	// RVA: 0x13193D0 Offset: 0x13179D0 VA: 0x1813193D0
	internal bool get_IsDefaultAttribute() { }

	// RVA: 0xE69BD0 Offset: 0xE681D0 VA: 0x180E69BD0
	internal void set_IsDefaultAttribute(bool value) { }

	// RVA: 0x1319580 Offset: 0x1317B80 VA: 0x181319580
	internal bool get_ValueBuffered() { }

	// RVA: 0x1319530 Offset: 0x1317B30 VA: 0x181319530
	internal string get_StringValue() { }

	// RVA: 0x13192C0 Offset: 0x13178C0 VA: 0x1813192C0
	internal void TrimSpacesInValue() { }

	// RVA: 0x1318B60 Offset: 0x1317160 VA: 0x181318B60
	internal void Clear(XmlNodeType type) { }

	// RVA: 0x1318AC0 Offset: 0x13170C0 VA: 0x181318AC0
	internal void ClearName() { }

	// RVA: 0x1318ED0 Offset: 0x13174D0 VA: 0x181318ED0
	internal void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0x1318EC0 Offset: 0x13174C0 VA: 0x181318EC0
	internal void SetLineInfo2(int lineNo, int linePos) { }

	// RVA: 0x13190A0 Offset: 0x13176A0 VA: 0x1813190A0
	internal void SetValueNode(XmlNodeType type, string value) { }

	// RVA: 0x13190E0 Offset: 0x13176E0 VA: 0x1813190E0
	internal void SetValueNode(XmlNodeType type, char[] chars, int startPos, int len) { }

	// RVA: 0x1318EE0 Offset: 0x13174E0 VA: 0x181318EE0
	internal void SetNamedNode(XmlNodeType type, string localName) { }

	// RVA: 0x1318FD0 Offset: 0x13175D0 VA: 0x181318FD0
	internal void SetNamedNode(XmlNodeType type, string localName, string prefix, string nameWPrefix) { }

	// RVA: 0x13191A0 Offset: 0x13177A0 VA: 0x1813191A0
	internal void SetValue(string value) { }

	// RVA: 0x1319140 Offset: 0x1317740 VA: 0x181319140
	internal void SetValue(char[] chars, int startPos, int len) { }

	// RVA: 0x1318E50 Offset: 0x1317450 VA: 0x181318E50
	internal void OnBufferInvalidated() { }

	// RVA: 0x1318C70 Offset: 0x1317270 VA: 0x181318C70
	internal void CopyTo(int valueOffset, StringBuilder sb) { }

	// RVA: 0x1318C10 Offset: 0x1317210 VA: 0x181318C10
	internal int CopyTo(int valueOffset, char[] buffer, int offset, int length) { }

	// RVA: 0x1318DA0 Offset: 0x13173A0 VA: 0x181318DA0
	internal string GetNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x1318D00 Offset: 0x1317300 VA: 0x181318D00
	internal string CreateNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x13191C0 Offset: 0x13177C0 VA: 0x1813191C0 Slot: 4
	private int System.IComparable.CompareTo(object obj) { }

}

private class XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer : IComparer<object> // TypeDefIndex: 1905
{	// Fields
	private static IComparer<object> s_instance; // 0x141BD

	// Properties
	internal static IComparer<object> Instance { get; }

	// Methods

	// RVA: 0x1318520 Offset: 0x1316B20 VA: 0x181318520
	internal static IComparer<object> get_Instance() { }

	// RVA: 0x1318260 Offset: 0x1316860 VA: 0x181318260 Slot: 4
	public int Compare(object x, object y) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13184C0 Offset: 0x1316AC0 VA: 0x1813184C0
	private static void .cctor() { }

}

internal sealed class XmlTextReaderImpl.OnDefaultAttributeUseDelegate : MulticastDelegate // TypeDefIndex: 1906
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4880 Offset: 0xAE2E80 VA: 0x180AE4880 Slot: 12
	public virtual void Invoke(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
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

	// RVA: 0x131F370 Offset: 0x131D970 VA: 0x18131F370
	internal void .ctor() { }

	// RVA: 0x131F270 Offset: 0x131D870 VA: 0x18131F270
	public void .ctor(Stream w, Encoding encoding) { }

	// RVA: 0x131F120 Offset: 0x131D720 VA: 0x18131F120
	public void .ctor(string filename, Encoding encoding) { }

	// RVA: 0x131F050 Offset: 0x131D650 VA: 0x18131F050
	public void .ctor(TextWriter w) { }

	// RVA: 0x131F4D0 Offset: 0x131DAD0 VA: 0x18131F4D0
	public Stream get_BaseStream() { }

	// RVA: 0x131F5E0 Offset: 0x131DBE0 VA: 0x18131F5E0
	public void set_Namespaces(bool value) { }

	// RVA: 0x131F5D0 Offset: 0x131DBD0 VA: 0x18131F5D0
	public void set_Formatting(Formatting value) { }

	// RVA: 0x131F660 Offset: 0x131DC60 VA: 0x18131F660
	public void set_QuoteChar(char value) { }

	// RVA: 0x131DA90 Offset: 0x131C090 VA: 0x18131DA90 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x131DA70 Offset: 0x131C070 VA: 0x18131DA70 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x131C990 Offset: 0x131AF90 VA: 0x18131C990 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x131C580 Offset: 0x131AB80 VA: 0x18131C580 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x131DAA0 Offset: 0x131C0A0 VA: 0x18131DAA0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x131CB10 Offset: 0x131B110 VA: 0x18131CB10 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x131D020 Offset: 0x131B620 VA: 0x18131D020 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x131D320 Offset: 0x131B920 VA: 0x18131D320 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x131C910 Offset: 0x131AF10 VA: 0x18131C910 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x131C160 Offset: 0x131A760 VA: 0x18131C160 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x131C410 Offset: 0x131AA10 VA: 0x18131C410 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x131D030 Offset: 0x131B630 VA: 0x18131D030 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x131CF70 Offset: 0x131B570 VA: 0x18131CF70 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x131C2B0 Offset: 0x131A8B0 VA: 0x18131C2B0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x131E170 Offset: 0x131C770 VA: 0x18131E170 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x131E010 Offset: 0x131C610 VA: 0x18131E010 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x131E0C0 Offset: 0x131C6C0 VA: 0x18131E0C0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x131C350 Offset: 0x131A950 VA: 0x18131C350 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x131D260 Offset: 0x131B860 VA: 0x18131D260 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x131D1C0 Offset: 0x131B7C0 VA: 0x18131D1C0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x131BFA0 Offset: 0x131A5A0 VA: 0x18131BFA0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x131C0B0 Offset: 0x131A6B0 VA: 0x18131C0B0 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x131F560 Offset: 0x131DB60 VA: 0x18131F560 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x131A5B0 Offset: 0x1318BB0 VA: 0x18131A5B0 Slot: 28
	public override void Close() { }

	// RVA: 0x131A810 Offset: 0x1318E10 VA: 0x18131A810 Slot: 29
	public override void Flush() { }

	// RVA: 0x131B340 Offset: 0x1319940 VA: 0x18131B340 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x131BA20 Offset: 0x131A020 VA: 0x18131BA20
	private void StartDocument(int standalone) { }

	// RVA: 0x1319FD0 Offset: 0x13185D0 VA: 0x181319FD0
	private void AutoComplete(XmlTextWriter.Token token) { }

	// RVA: 0x1319F80 Offset: 0x1318580 VA: 0x181319F80
	private void AutoCompleteAll() { }

	// RVA: 0x131AC50 Offset: 0x1319250 VA: 0x18131AC50
	private void InternalWriteEndElement(bool longFormat) { }

	// RVA: 0x131CB20 Offset: 0x131B120 VA: 0x18131CB20
	private void WriteEndStartTag(bool empty) { }

	// RVA: 0x131C8C0 Offset: 0x131AEC0 VA: 0x18131C8C0
	private void WriteEndAttributeQuote() { }

	// RVA: 0x131AB60 Offset: 0x1319160 VA: 0x18131AB60
	private void Indent(bool beforeEndElement) { }

	// RVA: 0x131B510 Offset: 0x1319B10 VA: 0x18131B510
	private void PushNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x1319CC0 Offset: 0x13182C0 VA: 0x181319CC0
	private void AddNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x1319E80 Offset: 0x1318480 VA: 0x181319E80
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x131B440 Offset: 0x1319A40 VA: 0x18131B440
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x131A840 Offset: 0x1318E40 VA: 0x18131A840
	private string GeneratePrefix() { }

	// RVA: 0x131AFC0 Offset: 0x13195C0 VA: 0x18131AFC0
	private void InternalWriteProcessingInstruction(string name, string text) { }

	// RVA: 0x131B220 Offset: 0x1319820 VA: 0x18131B220
	private int LookupNamespace(string prefix) { }

	// RVA: 0x131B0C0 Offset: 0x13196C0 VA: 0x18131B0C0
	private int LookupNamespaceInCurrentScope(string prefix) { }

	// RVA: 0x131A6D0 Offset: 0x1318CD0 VA: 0x18131A6D0
	private string FindPrefix(string ns) { }

	// RVA: 0x131BC80 Offset: 0x131A280 VA: 0x18131BC80
	private void ValidateName(string name, bool isNCName) { }

	// RVA: 0x131A930 Offset: 0x1318F30 VA: 0x18131A930
	private void HandleSpecialAttribute() { }

	// RVA: 0x131BE80 Offset: 0x131A480 VA: 0x18131BE80
	private void VerifyPrefixXml(string prefix, string ns) { }

	// RVA: 0x131B940 Offset: 0x1319F40 VA: 0x18131B940
	private void PushStack() { }

	// RVA: 0x131A7E0 Offset: 0x1318DE0 VA: 0x18131A7E0
	private void FlushEncoders() { }

	// RVA: 0x131E5C0 Offset: 0x131CBC0 VA: 0x18131E5C0
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

	// RVA: 0x1E1170 Offset: 0x1E0570 VA: 0x1801E1170
	internal void Init(int nsTop) { }

}

private struct XmlTextWriter.Namespace // TypeDefIndex: 1911
{	// Fields
	internal string prefix; // 0x0
	internal string ns; // 0x8
	internal bool declared; // 0x10
	internal int prevNsIndex; // 0x14

	// Methods

	// RVA: 0x1E0E20 Offset: 0x1E0220 VA: 0x1801E0E20
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

	// RVA: 0x1324170 Offset: 0x1322770 VA: 0x181324170
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x1323F20 Offset: 0x1322520 VA: 0x181323F20
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1323D40 Offset: 0x1322340 VA: 0x181323D40 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1323CD0 Offset: 0x13222D0 VA: 0x181323CD0 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x13226D0 Offset: 0x1320CD0 VA: 0x1813226D0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x13238C0 Offset: 0x1321EC0 VA: 0x1813238C0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1321380 Offset: 0x131F980 VA: 0x181321380 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x1322D30 Offset: 0x1321330 VA: 0x181322D30 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1323040 Offset: 0x1321640 VA: 0x181323040 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1323770 Offset: 0x1321D70 VA: 0x181323770 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1322CE0 Offset: 0x13212E0 VA: 0x181322CE0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x11C1BA0 Offset: 0x11C01A0 VA: 0x1811C1BA0 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x13239B0 Offset: 0x1321FB0 VA: 0x1813239B0 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1322F20 Offset: 0x1321520 VA: 0x181322F20 Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1321D40 Offset: 0x1320340 VA: 0x181321D40 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1322540 Offset: 0x1320B40 VA: 0x181322540 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1323210 Offset: 0x1321810 VA: 0x181323210 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1322F70 Offset: 0x1321570 VA: 0x181322F70 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1321FF0 Offset: 0x13205F0 VA: 0x181321FF0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1323AF0 Offset: 0x13220F0 VA: 0x181323AF0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1323AF0 Offset: 0x13220F0 VA: 0x181323AF0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1323B50 Offset: 0x1322150 VA: 0x181323B50 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x12F3370 Offset: 0x12F1970 VA: 0x1812F3370 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x13236D0 Offset: 0x1321CD0 VA: 0x1813236D0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1323720 Offset: 0x1321D20 VA: 0x181323720 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x13207E0 Offset: 0x131EDE0 VA: 0x1813207E0 Slot: 28
	public override void Close() { }

	// RVA: 0x1320EC0 Offset: 0x131F4C0 VA: 0x181320EC0 Slot: 29
	public override void Flush() { }

	// RVA: 0x1320C20 Offset: 0x131F220 VA: 0x181320C20 Slot: 48
	protected virtual void FlushBuffer() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void FlushEncoder() { }

	// RVA: 0x1321740 Offset: 0x131FD40 VA: 0x181321740
	protected void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x13229F0 Offset: 0x1320FF0 VA: 0x1813229F0
	protected void WriteElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1321330 Offset: 0x131F930 VA: 0x181321330
	protected void RawText(string s) { }

	// RVA: 0x1321100 Offset: 0x131F700 VA: 0x181321100
	protected void RawText(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x1323380 Offset: 0x1321980 VA: 0x181323380
	protected void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x13221E0 Offset: 0x13207E0 VA: 0x1813221E0
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x1321A10 Offset: 0x1320010 VA: 0x181321A10
	protected void WriteCDataSection(string text) { }

	// RVA: 0x1321080 Offset: 0x131F680 VA: 0x181321080
	private static bool IsSurrogateByte(byte b) { }

	// RVA: 0x1320A90 Offset: 0x131F090 VA: 0x181320A90
	private static byte* EncodeSurrogate(char* pSrc, char* pSrcEnd, byte* pDst) { }

	// RVA: 0x1320F10 Offset: 0x131F510 VA: 0x181320F10
	private byte* InvalidXmlChar(int ch, byte* pDst, bool entitize) { }

	// RVA: 0x1320960 Offset: 0x131EF60 VA: 0x181320960
	internal void EncodeChar(ref char* pSrc, char* pSrcEnd, ref byte* pDst) { }

	// RVA: 0x1320A40 Offset: 0x131F040 VA: 0x181320A40
	internal static byte* EncodeMultibyteUTF8(int ch, byte* pDst) { }

	// RVA: 0x1320730 Offset: 0x131ED30 VA: 0x181320730
	internal static void CharToUTF8(ref char* pSrc, char* pSrcEnd, ref byte* pDst) { }

	// RVA: 0x1323190 Offset: 0x1321790 VA: 0x181323190
	protected byte* WriteNewLine(byte* pDst) { }

	// RVA: 0x13210A0 Offset: 0x131F6A0 VA: 0x1813210A0
	protected static byte* LtEntity(byte* pDst) { }

	// RVA: 0x1320F00 Offset: 0x131F500 VA: 0x181320F00
	protected static byte* GtEntity(byte* pDst) { }

	// RVA: 0x1320670 Offset: 0x131EC70 VA: 0x181320670
	protected static byte* AmpEntity(byte* pDst) { }

	// RVA: 0x13210B0 Offset: 0x131F6B0 VA: 0x1813210B0
	protected static byte* QuoteEntity(byte* pDst) { }

	// RVA: 0x13213D0 Offset: 0x131F9D0 VA: 0x1813213D0
	protected static byte* TabEntity(byte* pDst) { }

	// RVA: 0x1321090 Offset: 0x131F690 VA: 0x181321090
	protected static byte* LineFeedEntity(byte* pDst) { }

	// RVA: 0x1320680 Offset: 0x131EC80 VA: 0x181320680
	protected static byte* CarriageReturnEntity(byte* pDst) { }

	// RVA: 0x1320690 Offset: 0x131EC90 VA: 0x181320690
	private static byte* CharEntity(byte* pDst, char ch) { }

	// RVA: 0x13210E0 Offset: 0x131F6E0 VA: 0x1813210E0
	protected static byte* RawStartCData(byte* pDst) { }

	// RVA: 0x13210D0 Offset: 0x131F6D0 VA: 0x1813210D0
	protected static byte* RawEndCData(byte* pDst) { }

	// RVA: 0x13213E0 Offset: 0x131F9E0 VA: 0x1813213E0
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

	// RVA: 0x1320550 Offset: 0x131EB50 VA: 0x181320550
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x131FF30 Offset: 0x131E530 VA: 0x18131FF30 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x13203A0 Offset: 0x131E9A0 VA: 0x1813203A0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x131FDD0 Offset: 0x131E3D0 VA: 0x18131FDD0 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x2FA5C0 Offset: 0x2F8BC0 VA: 0x1802FA5C0 Slot: 39
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x131FFA0 Offset: 0x131E5A0 VA: 0x18131FFA0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1320100 Offset: 0x131E700 VA: 0x181320100 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1320340 Offset: 0x131E940 VA: 0x181320340 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x131FE70 Offset: 0x131E470 VA: 0x18131FE70 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x131FEF0 Offset: 0x131E4F0 VA: 0x18131FEF0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1320230 Offset: 0x131E830 VA: 0x181320230 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x1320030 Offset: 0x131E630 VA: 0x181320030 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x131FE80 Offset: 0x131E480 VA: 0x18131FE80 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1320540 Offset: 0x131EB40 VA: 0x181320540 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x13204D0 Offset: 0x131EAD0 VA: 0x1813204D0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x13204D0 Offset: 0x131EAD0 VA: 0x1813204D0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x131FE90 Offset: 0x131E490 VA: 0x18131FE90 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x13202E0 Offset: 0x131E8E0 VA: 0x1813202E0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1320280 Offset: 0x131E880 VA: 0x181320280 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x131FE50 Offset: 0x131E450 VA: 0x18131FE50 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x131FCC0 Offset: 0x131E2C0 VA: 0x18131FCC0
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x1320190 Offset: 0x131E790 VA: 0x181320190
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

	// RVA: 0xB191B0 Offset: 0xB177B0 VA: 0x180B191B0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC8D50 Offset: 0xBC7350 VA: 0x180BC8D50 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0xBC8E10 Offset: 0xBC7410 VA: 0x180BC8E10 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0xBC8E80 Offset: 0xBC7480 VA: 0x180BC8E80 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xBC8EE0 Offset: 0xBC74E0 VA: 0x180BC8EE0 Slot: 11
	public override string get_Value() { }

	// RVA: 0xBC8C00 Offset: 0xBC7200 VA: 0x180BC8C00 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xBC8BD0 Offset: 0xBC71D0 VA: 0x180BC8BD0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBC8CC0 Offset: 0xBC72C0 VA: 0x180BC8CC0 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xB19300 Offset: 0xB17900 VA: 0x180B19300 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xBC8450 Offset: 0xBC6A50 VA: 0x180BC8450 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xBC8480 Offset: 0xBC6A80 VA: 0x180BC8480 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0xBC84B0 Offset: 0xBC6AB0 VA: 0x180BC84B0 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xBC8550 Offset: 0xBC6B50 VA: 0x180BC8550 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xBC85B0 Offset: 0xBC6BB0 VA: 0x180BC85B0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xBC85E0 Offset: 0xBC6BE0 VA: 0x180BC85E0 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0xBC8580 Offset: 0xBC6B80 VA: 0x180BC8580 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0xBC8610 Offset: 0xBC6C10 VA: 0x180BC8610 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0xBC8670 Offset: 0xBC6C70 VA: 0x180BC8670 Slot: 31
	public override bool Read() { }

	// RVA: 0xBC8C60 Offset: 0xBC7260 VA: 0x180BC8C60 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0xB9F170 Offset: 0xB9D770 VA: 0x180B9F170 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xBC8D80 Offset: 0xBC7380 VA: 0x180BC8D80 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xBC84E0 Offset: 0xBC6AE0 VA: 0x180BC84E0 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0xBC86A0 Offset: 0xBC6CA0 VA: 0x180BC86A0 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x1325840 Offset: 0x1323E40 VA: 0x181325840
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

	// RVA: 0x1325100 Offset: 0x1323700 VA: 0x181325100
	internal void .ctor(XmlReader reader, ValidationEventHandler settingsEventHandler, bool processIdentityConstraints) { }

	// RVA: 0x13256F0 Offset: 0x1323CF0 VA: 0x1813256F0 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0xB191B0 Offset: 0xB177B0 VA: 0x180B191B0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC8DB0 Offset: 0xBC73B0 VA: 0x180BC8DB0 Slot: 7
	public override string get_Name() { }

	// RVA: 0xBC8D50 Offset: 0xBC7350 VA: 0x180BC8D50 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0xBC8E10 Offset: 0xBC7410 VA: 0x180BC8E10 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0xBC8E80 Offset: 0xBC7480 VA: 0x180BC8E80 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xBC8EE0 Offset: 0xBC74E0 VA: 0x180BC8EE0 Slot: 11
	public override string get_Value() { }

	// RVA: 0xBC8C00 Offset: 0xBC7200 VA: 0x180BC8C00 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xBC8BD0 Offset: 0xBC71D0 VA: 0x180BC8BD0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBC8CC0 Offset: 0xBC72C0 VA: 0x180BC8CC0 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xBC8C90 Offset: 0xBC7290 VA: 0x180BC8C90 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xBC8EB0 Offset: 0xBC74B0 VA: 0x180BC8EB0 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xBC8F40 Offset: 0xBC7540 VA: 0x180BC8F40 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBC8F10 Offset: 0xBC7510 VA: 0x180BC8F10 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x13256B0 Offset: 0x1323CB0 VA: 0x1813256B0 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xBC8C60 Offset: 0xBC7260 VA: 0x180BC8C60 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0xBC8D80 Offset: 0xBC7380 VA: 0x180BC8D80 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xB19300 Offset: 0xB17900 VA: 0x180B19300 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xBC8450 Offset: 0xBC6A50 VA: 0x180BC8450 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xBC8480 Offset: 0xBC6A80 VA: 0x180BC8480 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0xBC84B0 Offset: 0xBC6AB0 VA: 0x180BC84B0 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x13245D0 Offset: 0x1322BD0 VA: 0x1813245D0 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1324620 Offset: 0x1322C20 VA: 0x181324620 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x13246B0 Offset: 0x1322CB0 VA: 0x1813246B0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1324700 Offset: 0x1322D00 VA: 0x181324700 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1324660 Offset: 0x1322C60 VA: 0x181324660 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x1324B40 Offset: 0x1323140 VA: 0x181324B40 Slot: 31
	public override bool Read() { }

	// RVA: 0x13242A0 Offset: 0x13228A0 VA: 0x1813242A0 Slot: 33
	public override void Close() { }

	// RVA: 0x1324480 Offset: 0x1322A80 VA: 0x181324480 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1324A10 Offset: 0x1323010 VA: 0x181324A10 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1324D60 Offset: 0x1323360 VA: 0x181324D60 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x1324510 Offset: 0x1322B10 VA: 0x181324510
	internal void MoveOffEntityReference() { }

	// RVA: 0x1324A70 Offset: 0x1323070 VA: 0x181324A70 Slot: 42
	public override string ReadString() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 53
	public bool HasLineInfo() { }

	// RVA: 0x1325520 Offset: 0x1323B20 VA: 0x181325520 Slot: 54
	public int get_LineNumber() { }

	// RVA: 0x13255C0 Offset: 0x1323BC0 VA: 0x1813255C0 Slot: 55
	public int get_LinePosition() { }

	// RVA: 0x13242E0 Offset: 0x13228E0 VA: 0x1813242E0 Slot: 56
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xBC4EA0 Offset: 0xBC34A0 VA: 0x180BC4EA0 Slot: 57
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x13244B0 Offset: 0x1322AB0 VA: 0x1813244B0 Slot: 58
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x13242E0 Offset: 0x13228E0 VA: 0x1813242E0
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x13244B0 Offset: 0x1322AB0 VA: 0x1813244B0
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	internal ValidationType get_ValidationType() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	internal XmlSchemaCollection get_Schemas() { }

	// RVA: 0x1325690 Offset: 0x1323C90 VA: 0x181325690
	internal bool get_Namespaces() { }

	// RVA: 0x1324750 Offset: 0x1322D50 VA: 0x181324750
	private void ParseDtdFromParserContext() { }

	// RVA: 0x1325080 Offset: 0x1323680 VA: 0x181325080
	private void ValidateDtd() { }

	// RVA: 0x1324CD0 Offset: 0x13232D0 VA: 0x181324CD0
	private void ResolveEntityInternally() { }

	// RVA: 0x1324DA0 Offset: 0x13233A0 VA: 0x181324DA0
	private void SetupValidation(ValidationType valType) { }

	// RVA: 0x13243A0 Offset: 0x13229A0 VA: 0x1813243A0
	private XmlResolver GetResolver() { }

	// RVA: 0x1324900 Offset: 0x1322F00 VA: 0x181324900
	private void ProcessCoreReaderEvent() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	internal BaseValidator get_Validator() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	internal void set_Validator(BaseValidator value) { }

	// RVA: 0x1325660 Offset: 0x1323C60 VA: 0x181325660 Slot: 51
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x13257C0 Offset: 0x1323DC0 VA: 0x1813257C0
	internal bool get_StandAlone() { }

	// RVA: 0x1325800 Offset: 0x1323E00 VA: 0x181325800
	internal void set_SchemaTypeObject(object value) { }

	// RVA: 0x13257E0 Offset: 0x1323DE0 VA: 0x1813257E0
	internal object get_TypedValueObject() { }

	// RVA: 0x1325820 Offset: 0x1323E20 VA: 0x181325820
	internal void set_TypedValueObject(object value) { }

	// RVA: 0x1324280 Offset: 0x1322880 VA: 0x181324280
	internal bool AddDefaultAttribute(SchemaAttDef attdef) { }

	// RVA: 0x13254F0 Offset: 0x1323AF0 VA: 0x1813254F0 Slot: 52
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0x1324F40 Offset: 0x1323540 VA: 0x181324F40
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

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	internal void .ctor(XmlValidatingReaderImpl reader) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Xml.IValidationEventHandling.get_EventHandler() { }

	// RVA: 0x1319A70 Offset: 0x1318070 VA: 0x181319A70 Slot: 5
	private void System.Xml.IValidationEventHandling.SendEvent(Exception exception, XmlSeverityType severity) { }

	// RVA: 0x13199F0 Offset: 0x1317FF0 VA: 0x1813199F0
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

	// RVA: 0x132C010 Offset: 0x132A610 VA: 0x18132C010
	internal void .ctor(XmlWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x132C550 Offset: 0x132AB50 VA: 0x18132C550 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x132A810 Offset: 0x1328E10 VA: 0x18132A810 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x132A820 Offset: 0x1328E20 VA: 0x18132A820 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x13294E0 Offset: 0x1327AE0 VA: 0x1813294E0 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x1328890 Offset: 0x1326E90 VA: 0x181328890 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x132A850 Offset: 0x1328E50 VA: 0x18132A850 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x13295F0 Offset: 0x1327BF0 VA: 0x1813295F0 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x13298E0 Offset: 0x1327EE0 VA: 0x1813298E0 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x132A080 Offset: 0x1328680 VA: 0x18132A080 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x1328C40 Offset: 0x1327240 VA: 0x181328C40 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1328290 Offset: 0x1326890 VA: 0x181328290 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x13287D0 Offset: 0x1326DD0 VA: 0x1813287D0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1329AB0 Offset: 0x13280B0 VA: 0x181329AB0 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x13297C0 Offset: 0x1327DC0 VA: 0x1813297C0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1328350 Offset: 0x1326950 VA: 0x181328350 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x132ACC0 Offset: 0x13292C0 VA: 0x18132ACC0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x132B060 Offset: 0x1329660 VA: 0x18132B060 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x132AB60 Offset: 0x1329160 VA: 0x18132AB60 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1328530 Offset: 0x1326B30 VA: 0x181328530 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1329CA0 Offset: 0x13282A0 VA: 0x181329CA0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1329F40 Offset: 0x1328540 VA: 0x181329F40 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1328000 Offset: 0x1326600 VA: 0x181328000 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1326500 Offset: 0x1324B00 VA: 0x181326500 Slot: 28
	public override void Close() { }

	// RVA: 0x1326810 Offset: 0x1324E10 VA: 0x181326810 Slot: 29
	public override void Flush() { }

	// RVA: 0x1326F50 Offset: 0x1325550 VA: 0x181326F50 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x132AF10 Offset: 0x1329510 VA: 0x18132AF10 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0x13281A0 Offset: 0x13267A0 VA: 0x1813281A0 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal XmlRawWriter get_RawWriter() { }

	// RVA: 0xB28DE0 Offset: 0xB273E0 VA: 0x180B28DE0
	private bool get_SaveAttrValue() { }

	// RVA: 0x132C520 Offset: 0x132AB20 VA: 0x18132C520
	private bool get_InBase64() { }

	// RVA: 0x1327B30 Offset: 0x1326130 VA: 0x181327B30
	private void SetSpecialAttribute(XmlWellFormedWriter.SpecialAttribute special) { }

	// RVA: 0x132A6B0 Offset: 0x1328CB0 VA: 0x18132A6B0
	private void WriteStartDocumentImpl(XmlStandalone standalone) { }

	// RVA: 0x1327DE0 Offset: 0x13263E0 VA: 0x181327DE0
	private void StartFragment() { }

	// RVA: 0x13276F0 Offset: 0x1325CF0 VA: 0x1813276F0
	private void PushNamespaceImplicit(string prefix, string ns) { }

	// RVA: 0x13271D0 Offset: 0x13257D0 VA: 0x1813271D0
	private bool PushNamespaceExplicit(string prefix, string ns) { }

	// RVA: 0x1325BB0 Offset: 0x13241B0 VA: 0x181325BB0
	private void AddNamespace(string prefix, string ns, XmlWellFormedWriter.NamespaceKind kind) { }

	// RVA: 0x1325E90 Offset: 0x1324490 VA: 0x181325E90
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x1326D50 Offset: 0x1325350 VA: 0x181326D50
	private int LookupNamespaceIndex(string prefix) { }

	// RVA: 0x1327110 Offset: 0x1325710 VA: 0x181327110
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x1326720 Offset: 0x1324D20 VA: 0x181326720
	private static XmlException DupAttrException(string prefix, string localName) { }

	// RVA: 0x1325F90 Offset: 0x1324590 VA: 0x181325F90
	private void AdvanceState(XmlWellFormedWriter.Token token) { }

	// RVA: 0x1327C20 Offset: 0x1326220 VA: 0x181327C20
	private void StartElementContent() { }

	// RVA: 0x13269D0 Offset: 0x1324FD0 VA: 0x1813269D0
	private static string GetStateName(XmlWellFormedWriter.State state) { }

	// RVA: 0x1326E60 Offset: 0x1325460 VA: 0x181326E60
	internal string LookupNamespace(string prefix) { }

	// RVA: 0x1326C60 Offset: 0x1325260 VA: 0x181326C60
	private string LookupLocalNamespace(string prefix) { }

	// RVA: 0x13268A0 Offset: 0x1324EA0 VA: 0x1813268A0
	private string GeneratePrefix() { }

	// RVA: 0x1326390 Offset: 0x1324990 VA: 0x181326390
	private void CheckNCName(string ncname) { }

	// RVA: 0x1326A70 Offset: 0x1325070 VA: 0x181326A70
	private static Exception InvalidCharsException(string name, int badCharIndex) { }

	// RVA: 0x1327DF0 Offset: 0x13263F0 VA: 0x181327DF0
	private void ThrowInvalidStateTransition(XmlWellFormedWriter.Token token, XmlWellFormedWriter.State currentState) { }

	// RVA: 0x132C540 Offset: 0x132AB40 VA: 0x18132C540
	private bool get_IsClosedOrErrorState() { }

	// RVA: 0x1325870 Offset: 0x1323E70 VA: 0x181325870
	private void AddAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x1325D40 Offset: 0x1324340 VA: 0x181325D40
	private void AddToAttrHashTable(int attributeIndex) { }

	// RVA: 0x132B210 Offset: 0x1329810 VA: 0x18132B210
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

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	internal void .ctor(XmlWellFormedWriter wfWriter) { }

	// RVA: 0x13189A0 Offset: 0x1316FA0 VA: 0x1813189A0 Slot: 4
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x13189F0 Offset: 0x1316FF0 VA: 0x1813189F0 Slot: 5
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1318A10 Offset: 0x1317010 VA: 0x181318A10 Slot: 6
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

	// RVA: 0x1E0B90 Offset: 0x1DFF90 VA: 0x1801E0B90
	internal void Set(string prefix, string localName, string namespaceUri, int prevNSTop) { }

	// RVA: 0x1E0C10 Offset: 0x1E0010 VA: 0x1801E0C10
	internal void WriteEndElement(XmlRawWriter rawWriter) { }

	// RVA: 0x1E0C50 Offset: 0x1E0050 VA: 0x1801E0C50
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

	// RVA: 0x1E0DD0 Offset: 0x1E01D0 VA: 0x1801E0DD0
	internal void Set(string prefix, string namespaceUri, XmlWellFormedWriter.NamespaceKind kind) { }

	// RVA: 0x1E0E70 Offset: 0x1E0270 VA: 0x1801E0E70
	internal void WriteDecl(XmlWriter writer, XmlRawWriter rawWriter) { }

}

private struct XmlWellFormedWriter.AttrName // TypeDefIndex: 1928
{	// Fields
	internal string prefix; // 0x0
	internal string namespaceUri; // 0x8
	internal string localName; // 0x10
	internal int prev; // 0x18

	// Methods

	// RVA: 0x1E0B30 Offset: 0x1DFF30 VA: 0x1801E0B30
	internal void Set(string prefix, string localName, string namespaceUri) { }

	// RVA: 0x1E0B20 Offset: 0x1DFF20 VA: 0x1801E0B20
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

	// RVA: 0x1318220 Offset: 0x1316820 VA: 0x181318220
	internal string get_StringValue() { }

	// RVA: 0x1317B60 Offset: 0x1316160 VA: 0x181317B60
	internal void WriteEntityRef(string name) { }

	// RVA: 0x1317980 Offset: 0x1315F80 VA: 0x181317980
	internal void WriteCharEntity(char ch) { }

	// RVA: 0x1317F70 Offset: 0x1316570 VA: 0x181317F70
	internal void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1318120 Offset: 0x1316720 VA: 0x181318120
	internal void WriteWhitespace(string ws) { }

	// RVA: 0x1317EB0 Offset: 0x13164B0 VA: 0x181317EB0
	internal void WriteString(string text) { }

	// RVA: 0x1317A50 Offset: 0x1316050 VA: 0x181317A50
	internal void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1317D10 Offset: 0x1316310 VA: 0x181317D10
	internal void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1317E20 Offset: 0x1316420 VA: 0x181317E20
	internal void WriteRaw(string data) { }

	// RVA: 0x1318090 Offset: 0x1316690 VA: 0x181318090
	internal void WriteValue(string value) { }

	// RVA: 0x1316FB0 Offset: 0x13155B0 VA: 0x181316FB0
	internal void Replay(XmlWriter writer) { }

	// RVA: 0x1317470 Offset: 0x1315A70 VA: 0x181317470
	internal void Trim() { }

	// RVA: 0x1316F60 Offset: 0x1315560 VA: 0x181316F60
	internal void Clear() { }

	// RVA: 0x1317410 Offset: 0x1315A10 VA: 0x181317410
	private void StartComplexValue() { }

	// RVA: 0x1316DB0 Offset: 0x13153B0 VA: 0x181316DB0
	private void AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType type, object data) { }

	// RVA: 0x13181B0 Offset: 0x13167B0 VA: 0x1813181B0
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

	// RVA: 0x11ECB80 Offset: 0x11EB180 VA: 0x1811ECB80
	internal void Set(XmlWellFormedWriter.AttributeValueCache.ItemType type, object data) { }

}

private class XmlWellFormedWriter.AttributeValueCache.BufferChunk // TypeDefIndex: 1933
{	// Fields
	internal char[] buffer; // 0x10
	internal int index; // 0x18
	internal int count; // 0x1C

	// Methods

	// RVA: 0xB7B950 Offset: 0xB79F50 VA: 0x180B7B950
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

	// RVA: 0x132DF90 Offset: 0x132C590 VA: 0x18132DF90
	public void WriteStartElement(string localName, string ns) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void WriteStartElement(string prefix, string localName, string ns);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void WriteEndElement();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void WriteFullEndElement();

	// RVA: 0x132D690 Offset: 0x132BC90 VA: 0x18132D690
	public void WriteAttributeString(string localName, string ns, string value) { }

	// RVA: 0x132D620 Offset: 0x132BC20 VA: 0x18132D620
	public void WriteAttributeString(string localName, string value) { }

	// RVA: 0x132D700 Offset: 0x132BD00 VA: 0x18132D700
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

	// RVA: 0x132DA10 Offset: 0x132C010 VA: 0x18132DA10 Slot: 26
	public virtual void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract WriteState get_WriteState();

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 28
	public virtual void Close() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void Flush();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract string LookupPrefix(string ns);

	// RVA: 0x132DFC0 Offset: 0x132C5C0 VA: 0x18132DFC0 Slot: 31
	public virtual void WriteValue(string value) { }

	// RVA: 0x132D750 Offset: 0x132BD50 VA: 0x18132D750 Slot: 32
	public virtual void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x132DAB0 Offset: 0x132C0B0 VA: 0x18132DAB0 Slot: 33
	public virtual void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x132DA40 Offset: 0x132C040 VA: 0x18132DA40
	public void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x132D5C0 Offset: 0x132BBC0 VA: 0x18132D5C0 Slot: 4
	public void Dispose() { }

	// RVA: 0x132D5E0 Offset: 0x132BBE0 VA: 0x18132D5E0 Slot: 34
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x132D4E0 Offset: 0x132BAE0 VA: 0x18132D4E0
	public static XmlWriter Create(Stream output, XmlWriterSettings settings) { }

	// RVA: 0x132D550 Offset: 0x132BB50 VA: 0x18132D550
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

	// RVA: 0x132D140 Offset: 0x132B740 VA: 0x18132D140
	public void .ctor() { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_Async() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Encoding get_Encoding() { }

	// RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0
	public bool get_OmitXmlDeclaration() { }

	// RVA: 0x132D480 Offset: 0x132BA80 VA: 0x18132D480
	public void set_OmitXmlDeclaration(bool value) { }

	// RVA: 0x7D0D10 Offset: 0x7CF310 VA: 0x1807D0D10
	public NewLineHandling get_NewLineHandling() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public string get_NewLineChars() { }

	// RVA: 0x132D2A0 Offset: 0x132B8A0 VA: 0x18132D2A0
	public bool get_Indent() { }

	// RVA: 0x132D3A0 Offset: 0x132B9A0 VA: 0x18132D3A0
	public void set_Indent(bool value) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_IndentChars() { }

	// RVA: 0x805600 Offset: 0x803C00 VA: 0x180805600
	public bool get_NewLineOnAttributes() { }

	// RVA: 0xEE7150 Offset: 0xEE5750 VA: 0x180EE7150
	public bool get_CloseOutput() { }

	// RVA: 0x598420 Offset: 0x596A20 VA: 0x180598420
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0x132D320 Offset: 0x132B920 VA: 0x18132D320
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0xC20D30 Offset: 0xC1F330 VA: 0x180C20D30
	public bool get_CheckCharacters() { }

	// RVA: 0x5DE450 Offset: 0x5DCA50 VA: 0x1805DE450
	public NamespaceHandling get_NamespaceHandling() { }

	// RVA: 0x132D400 Offset: 0x132BA00 VA: 0x18132D400
	public void set_NamespaceHandling(NamespaceHandling value) { }

	// RVA: 0x132D310 Offset: 0x132B910 VA: 0x18132D310
	public bool get_WriteEndDocumentOnClose() { }

	// RVA: 0x8D9010 Offset: 0x8D7610 VA: 0x1808D9010
	public XmlOutputMethod get_OutputMethod() { }

	// RVA: 0x8D9050 Offset: 0x8D7650 VA: 0x1808D9050
	internal void set_OutputMethod(XmlOutputMethod value) { }

	// RVA: 0x132C8E0 Offset: 0x132AEE0 VA: 0x18132C8E0
	public XmlWriterSettings Clone() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	internal List<XmlQualifiedName> get_CDataSectionElements() { }

	// RVA: 0xA4F2B0 Offset: 0xA4D8B0 VA: 0x180A4F2B0
	public bool get_DoNotEscapeUriAttributes() { }

	// RVA: 0x10867B0 Offset: 0x1084DB0 VA: 0x1810867B0
	internal bool get_MergeCDataSections() { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	internal string get_MediaType() { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	internal string get_DocTypeSystem() { }

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	internal string get_DocTypePublic() { }

	// RVA: 0x582940 Offset: 0x580F40 VA: 0x180582940
	internal XmlStandalone get_Standalone() { }

	// RVA: 0x132D290 Offset: 0x132B890 VA: 0x18132D290
	internal bool get_AutoXmlDeclaration() { }

	// RVA: 0xA38FA0 Offset: 0xA375A0 VA: 0x180A38FA0
	internal TriState get_IndentInternal() { }

	// RVA: 0x132D2B0 Offset: 0x132B8B0 VA: 0x18132D2B0
	internal bool get_IsQuerySpecific() { }

	// RVA: 0x132CBF0 Offset: 0x132B1F0 VA: 0x18132CBF0
	internal XmlWriter CreateWriter(Stream output) { }

	// RVA: 0x132C990 Offset: 0x132AF90 VA: 0x18132C990
	internal XmlWriter CreateWriter(TextWriter output) { }

	// RVA: 0x132D4D0 Offset: 0x132BAD0 VA: 0x18132D4D0
	internal void set_ReadOnly(bool value) { }

	// RVA: 0x132C830 Offset: 0x132AE30 VA: 0x18132C830
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0x132D040 Offset: 0x132B640 VA: 0x18132D040
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

	// RVA: 0x132F7D0 Offset: 0x132DDD0 VA: 0x18132F7D0
	internal void .ctor(XmlReader reader, IXmlLineInfo lineInfo, CachingEventHandler handlerMethod) { }

	// RVA: 0x132E820 Offset: 0x132CE20 VA: 0x18132E820
	private void Init() { }

	// RVA: 0x132F410 Offset: 0x132DA10 VA: 0x18132F410
	internal void Reset(XmlReader reader) { }

	// RVA: 0x132F9D0 Offset: 0x132DFD0 VA: 0x18132F9D0 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x132F990 Offset: 0x132DF90 VA: 0x18132F990 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x132F940 Offset: 0x132DF40 VA: 0x18132F940 Slot: 7
	public override string get_Name() { }

	// RVA: 0x132F920 Offset: 0x132DF20 VA: 0x18132F920 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x132F970 Offset: 0x132DF70 VA: 0x18132F970 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x132F9B0 Offset: 0x132DFB0 VA: 0x18132F9B0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x132FA00 Offset: 0x132E000 VA: 0x18132FA00 Slot: 11
	public override string get_Value() { }

	// RVA: 0x132F8C0 Offset: 0x132DEC0 VA: 0x18132F8C0 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xBC8BD0 Offset: 0xBC71D0 VA: 0x180BC8BD0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xBC8EB0 Offset: 0xBC74B0 VA: 0x180BC8EB0 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xBC8F40 Offset: 0xBC7540 VA: 0x180BC8F40 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBC8F10 Offset: 0xBC7510 VA: 0x180BC8F10 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x132E5C0 Offset: 0x132CBC0 VA: 0x18132E5C0 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x132E700 Offset: 0x132CD00 VA: 0x18132E700 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x132E650 Offset: 0x132CC50 VA: 0x18132E650 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x132EA70 Offset: 0x132D070 VA: 0x18132EA70 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x132E9C0 Offset: 0x132CFC0 VA: 0x18132E9C0 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x132EB60 Offset: 0x132D160 VA: 0x18132EB60 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x132EBC0 Offset: 0x132D1C0 VA: 0x18132EBC0 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x132EB10 Offset: 0x132D110 VA: 0x18132EB10 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x132ED10 Offset: 0x132D310 VA: 0x18132ED10 Slot: 31
	public override bool Read() { }

	// RVA: 0x132F390 Offset: 0x132D990 VA: 0x18132F390
	internal ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos) { }

	// RVA: 0x132F5F0 Offset: 0x132DBF0 VA: 0x18132F5F0
	internal void SwitchTextNodeAndEndElement(string textValue, string originalStringValue) { }

	// RVA: 0x132F240 Offset: 0x132D840 VA: 0x18132F240
	internal void RecordEndElementNode() { }

	// RVA: 0x132F8E0 Offset: 0x132DEE0 VA: 0x18132F8E0 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x132E340 Offset: 0x132C940 VA: 0x18132E340 Slot: 33
	public override void Close() { }

	// RVA: 0xB9F170 Offset: 0xB9D770 VA: 0x180B9F170 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x132F4C0 Offset: 0x132DAC0 VA: 0x18132F4C0 Slot: 35
	public override void Skip() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xBC8740 Offset: 0xBC6D40 VA: 0x180BC8740 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x132F440 Offset: 0x132DA40 VA: 0x18132F440 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x132EC20 Offset: 0x132D220 VA: 0x18132EC20 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 53
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x132F790 Offset: 0x132DD90 VA: 0x18132F790 Slot: 54
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x132F7B0 Offset: 0x132DDB0 VA: 0x18132F7B0 Slot: 55
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x132F490 Offset: 0x132DA90 VA: 0x18132F490
	internal void SetToReplayMode() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal XmlReader GetCoreReader() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	internal IXmlLineInfo GetLineInfo() { }

	// RVA: 0x132E330 Offset: 0x132C930 VA: 0x18132E330
	private void ClearAttributesInfo() { }

	// RVA: 0x132DFE0 Offset: 0x132C5E0 VA: 0x18132DFE0
	private ValidatingReaderNodeData AddAttribute(int attIndex) { }

	// RVA: 0x132E180 Offset: 0x132C780 VA: 0x18132E180
	private ValidatingReaderNodeData AddContent(XmlNodeType nodeType) { }

	// RVA: 0x132F080 Offset: 0x132D680 VA: 0x18132F080
	private void RecordAttributes() { }

	// RVA: 0x132E500 Offset: 0x132CB00 VA: 0x18132E500
	private int GetAttributeIndexWithoutPrefix(string name) { }

	// RVA: 0x132E440 Offset: 0x132CA40 VA: 0x18132E440
	private int GetAttributeIndexWithPrefix(string name) { }

	// RVA: 0x132E380 Offset: 0x132C980 VA: 0x18132E380
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

	// RVA: 0x2243C70 Offset: 0x2242270 VA: 0x182243C70
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings, XmlSchemaObject partialValidationType) { }

	// RVA: 0x2243E40 Offset: 0x2242440 VA: 0x182243E40
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings) { }

	// RVA: 0x2241500 Offset: 0x223FB00 VA: 0x182241500
	private void Init() { }

	// RVA: 0x2243040 Offset: 0x2241640 VA: 0x182243040
	private void SetupValidator(XmlReaderSettings readerSettings, XmlReader reader, XmlSchemaObject partialValidationType) { }

	// RVA: 0x22442B0 Offset: 0x22428B0 VA: 0x1822442B0 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x2244190 Offset: 0x2242790 VA: 0x182244190 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x2243FE0 Offset: 0x22425E0 VA: 0x182243FE0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x2243FA0 Offset: 0x22425A0 VA: 0x182243FA0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x2244150 Offset: 0x2242750 VA: 0x182244150 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x2244230 Offset: 0x2242830 VA: 0x182244230 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x2244450 Offset: 0x2242A50 VA: 0x182244450 Slot: 11
	public override string get_Value() { }

	// RVA: 0x2243E80 Offset: 0x2242480 VA: 0x182243E80 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xBC8BD0 Offset: 0xBC71D0 VA: 0x180BC8BD0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBC8CC0 Offset: 0xBC72C0 VA: 0x180BC8CC0 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x2243EC0 Offset: 0x22424C0 VA: 0x182243EC0 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xBC8EB0 Offset: 0xBC74B0 VA: 0x180BC8EB0 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xBC8F40 Offset: 0xBC7540 VA: 0x180BC8F40 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBC8F10 Offset: 0xBC7510 VA: 0x180BC8F10 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 19
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x2244390 Offset: 0x2242990 VA: 0x182244390 Slot: 20
	public override Type get_ValueType() { }

	// RVA: 0x803B80 Offset: 0x802180 VA: 0x180803B80 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x2240AC0 Offset: 0x223F0C0 VA: 0x182240AC0 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x22409A0 Offset: 0x223EFA0 VA: 0x1822409A0 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x2240B30 Offset: 0x223F130 VA: 0x182240B30 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x2241A60 Offset: 0x2240060 VA: 0x182241A60 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x22418C0 Offset: 0x223FEC0 VA: 0x1822418C0 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x2241B90 Offset: 0x2240190 VA: 0x182241B90 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x2241D40 Offset: 0x2240340 VA: 0x182241D40 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x2241B40 Offset: 0x2240140 VA: 0x182241B40 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x2242D20 Offset: 0x2241320 VA: 0x182242D20 Slot: 31
	public override bool Read() { }

	// RVA: 0xBC8C60 Offset: 0xBC7260 VA: 0x180BC8C60 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x2240610 Offset: 0x223EC10 VA: 0x182240610 Slot: 33
	public override void Close() { }

	// RVA: 0x2244270 Offset: 0x2242870 VA: 0x182244270 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x2243290 Offset: 0x2241890 VA: 0x182243290 Slot: 35
	public override void Skip() { }

	// RVA: 0x9922B0 Offset: 0x9908B0 VA: 0x1809922B0 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x2241860 Offset: 0x223FE60 VA: 0x182241860 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x2242FF0 Offset: 0x22415F0 VA: 0x182242FF0 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x2242BD0 Offset: 0x22411D0 VA: 0x182242BD0 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x2243600 Offset: 0x2241C00 VA: 0x182243600 Slot: 54
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0x2243690 Offset: 0x2241C90 VA: 0x182243690 Slot: 55
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0x22439A0 Offset: 0x2241FA0 VA: 0x1822439A0 Slot: 53
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0x22436E0 Offset: 0x2241CE0 VA: 0x1822436E0 Slot: 56
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0x2243940 Offset: 0x2241F40 VA: 0x182243940 Slot: 57
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0x22438E0 Offset: 0x2241EE0 VA: 0x1822438E0 Slot: 58
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0x2243890 Offset: 0x2241E90 VA: 0x182243890 Slot: 59
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 60
	public bool HasLineInfo() { }

	// RVA: 0x2243F00 Offset: 0x2242500 VA: 0x182243F00 Slot: 61
	public int get_LineNumber() { }

	// RVA: 0x2243F50 Offset: 0x2242550 VA: 0x182243F50 Slot: 62
	public int get_LinePosition() { }

	// RVA: 0x2243410 Offset: 0x2241A10 VA: 0x182243410 Slot: 63
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x2243500 Offset: 0x2241B00 VA: 0x182243500 Slot: 64
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x2243580 Offset: 0x2241B80 VA: 0x182243580 Slot: 65
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0xBC8EE0 Offset: 0xBC74E0 VA: 0x180BC8EE0
	private object GetStringValue() { }

	// RVA: 0x2243E60 Offset: 0x2242460 VA: 0x182243E60
	private XmlSchemaInfo get_AttributeSchemaInfo() { }

	// RVA: 0x2242790 Offset: 0x2240D90 VA: 0x182242790
	private void ProcessReaderEvent() { }

	// RVA: 0x2241EB0 Offset: 0x22404B0 VA: 0x182241EB0
	private void ProcessElementEvent() { }

	// RVA: 0x22424C0 Offset: 0x2240AC0 VA: 0x1822424C0
	private void ProcessEndElementEvent() { }

	// RVA: 0x2243A40 Offset: 0x2242040 VA: 0x182243A40
	private void ValidateAttributes() { }

	// RVA: 0x22405B0 Offset: 0x223EBB0 VA: 0x1822405B0
	private void ClearAttributesInfo() { }

	// RVA: 0x22407D0 Offset: 0x223EDD0 VA: 0x1822407D0
	private AttributePSVIInfo GetAttributePSVI(string name) { }

	// RVA: 0x2240710 Offset: 0x223ED10 VA: 0x182240710
	private AttributePSVIInfo GetAttributePSVI(string localName, string ns) { }

	// RVA: 0x2240D70 Offset: 0x223F370 VA: 0x182240D70
	private ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition) { }

	// RVA: 0x2240EC0 Offset: 0x223F4C0 VA: 0x182240EC0
	private ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition) { }

	// RVA: 0x22403C0 Offset: 0x223E9C0 VA: 0x1822403C0
	private AttributePSVIInfo AddAttributePSVI(int attIndex) { }

	// RVA: 0x2241810 Offset: 0x223FE10 VA: 0x182241810
	private bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x2242670 Offset: 0x2240C70 VA: 0x182242670
	private void ProcessInlineSchema() { }

	// RVA: 0x2242980 Offset: 0x2240F80 VA: 0x182242980
	private void ReadAheadForMemberType() { }

	// RVA: 0x2241040 Offset: 0x223F640 VA: 0x182241040
	private void GetIsDefault() { }

	// RVA: 0x2241350 Offset: 0x223F950 VA: 0x182241350
	private void GetMemberType() { }

	// RVA: 0x2240C70 Offset: 0x223F270 VA: 0x182240C70
	private XsdCachingReader GetCachingReader() { }

	// RVA: 0x2240650 Offset: 0x223EC50 VA: 0x182240650
	internal ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

	// RVA: 0x2240560 Offset: 0x223EB60 VA: 0x182240560
	internal void CachingCallBack(XsdCachingReader cachingReader) { }

	// RVA: 0x2241460 Offset: 0x223FA60 VA: 0x182241460
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

	// RVA: 0xE570E0 Offset: 0xE556E0 VA: 0x180E570E0
	internal void .ctor(XmlName name, XmlDocument doc) { }

	// RVA: 0xE57290 Offset: 0xE55890 VA: 0x180E57290
	internal int get_LocalNameHash() { }

	// RVA: 0xE57090 Offset: 0xE55690 VA: 0x180E57090
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal XmlName get_XmlName() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	internal void set_XmlName(XmlName value) { }

	// RVA: 0xE56960 Offset: 0xE54F60 VA: 0x180E56960 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0xE572B0 Offset: 0xE558B0 VA: 0x180E572B0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x855290 Offset: 0x853890 VA: 0x180855290 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xE572D0 Offset: 0xE558D0 VA: 0x180E572D0 Slot: 33
	public override string get_NamespaceURI() { }

	// RVA: 0xE57390 Offset: 0xE55990 VA: 0x180E57390 Slot: 34
	public override string get_Prefix() { }

	// RVA: 0xE575C0 Offset: 0xE55BC0 VA: 0x180E575C0 Slot: 35
	public override void set_Prefix(string value) { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xE572F0 Offset: 0xE558F0 VA: 0x180E572F0 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0xE573B0 Offset: 0xE559B0 VA: 0x180E573B0 Slot: 7
	public override string get_Value() { }

	// RVA: 0xE57680 Offset: 0xE55C80 VA: 0x180E57680 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 41
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xE574C0 Offset: 0xE55AC0 VA: 0x180E574C0 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0xE56B90 Offset: 0xE55190 VA: 0x180E56B90
	internal bool PrepareOwnerElementInElementIdAttrMap() { }

	// RVA: 0xE56E20 Offset: 0xE55420 VA: 0x180E56E20
	internal void ResetOwnerElementInElementIdAttrMap(string oldInnerText) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0xE56710 Offset: 0xE54D10 VA: 0x180E56710 Slot: 26
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0xE56B80 Offset: 0xE55180 VA: 0x180E56B80 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 56
	public virtual bool get_Specified() { }

	// RVA: 0xE56AE0 Offset: 0xE550E0 VA: 0x180E56AE0 Slot: 21
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0xE56A40 Offset: 0xE55040 VA: 0x180E56A40 Slot: 22
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0xE56DA0 Offset: 0xE553A0 VA: 0x180E56DA0 Slot: 23
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0xE56D20 Offset: 0xE55320 VA: 0x180E56D20 Slot: 24
	public override XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0xE568E0 Offset: 0xE54EE0 VA: 0x180E568E0 Slot: 25
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0xE57310 Offset: 0xE55910 VA: 0x180E57310 Slot: 57
	public virtual XmlElement get_OwnerElement() { }

	// RVA: 0xE57530 Offset: 0xE55B30 VA: 0x180E57530 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0xE56FC0 Offset: 0xE555C0 VA: 0x180E56FC0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0xE56F50 Offset: 0xE55550 VA: 0x180E56F50 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0xE57200 Offset: 0xE55800 VA: 0x180E57200 Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630 Slot: 47
	internal override void SetParent(XmlNode node) { }

	// RVA: 0xE57460 Offset: 0xE55A60 VA: 0x180E57460 Slot: 53
	internal override XmlSpace get_XmlSpace() { }

	// RVA: 0xE573D0 Offset: 0xE559D0 VA: 0x180E573D0 Slot: 54
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

	// RVA: 0xE56380 Offset: 0xE54980 VA: 0x180E56380
	internal void .ctor(XmlNode parent) { }

	// RVA: 0xE56390 Offset: 0xE54990 VA: 0x180E56390
	public XmlAttribute get_ItemOf(int i) { }

	// RVA: 0xE565E0 Offset: 0xE54BE0 VA: 0x180E565E0
	public XmlAttribute get_ItemOf(string name) { }

	// RVA: 0xE56480 Offset: 0xE54A80 VA: 0x180E56480
	public XmlAttribute get_ItemOf(string localName, string namespaceURI) { }

	// RVA: 0xE55380 Offset: 0xE53980 VA: 0x180E55380
	internal int FindNodeOffsetNS(XmlAttribute node) { }

	// RVA: 0xE560B0 Offset: 0xE546B0 VA: 0x180E560B0 Slot: 6
	public override XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0xE550E0 Offset: 0xE536E0 VA: 0x180E550E0
	public XmlAttribute Append(XmlAttribute node) { }

	// RVA: 0xE55F40 Offset: 0xE54540 VA: 0x180E55F40
	public XmlAttribute Remove(XmlAttribute node) { }

	// RVA: 0xE55A00 Offset: 0xE54000 VA: 0x180E55A00
	public XmlAttribute RemoveAt(int i) { }

	// RVA: 0xE55920 Offset: 0xE53F20 VA: 0x180E55920
	public void RemoveAll() { }

	// RVA: 0xE562E0 Offset: 0xE548E0 VA: 0x180E562E0 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xE56370 Offset: 0xE54970 VA: 0x180E56370 Slot: 14
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0xE54EE0 Offset: 0xE534E0 VA: 0x180E54EE0 Slot: 9
	internal override XmlNode AddNode(XmlNode node) { }

	// RVA: 0xE55520 Offset: 0xE53B20 VA: 0x180E55520 Slot: 12
	internal override XmlNode InsertNodeAt(int i, XmlNode node) { }

	// RVA: 0xE55BD0 Offset: 0xE541D0 VA: 0x180E55BD0 Slot: 11
	internal override XmlNode RemoveNodeAt(int i) { }

	// RVA: 0xE552B0 Offset: 0xE538B0 VA: 0x180E552B0
	internal void Detach(XmlAttribute attr) { }

	// RVA: 0xE555E0 Offset: 0xE53BE0 VA: 0x180E555E0
	internal void InsertParentIntoElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0xE55DB0 Offset: 0xE543B0 VA: 0x180E55DB0
	internal void RemoveParentFromElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0xE55AC0 Offset: 0xE540C0 VA: 0x180E55AC0
	internal int RemoveDuplicateAttribute(XmlAttribute attr) { }

	// RVA: 0xE55820 Offset: 0xE53E20 VA: 0x180E55820
	internal bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName) { }

	// RVA: 0xE55FD0 Offset: 0xE545D0 VA: 0x180E55FD0
	internal void ResetParentInElementIdAttrMap(string oldVal, string newVal) { }

	// RVA: 0xE55770 Offset: 0xE53D70 VA: 0x180E55770
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

	// RVA: 0xE58710 Offset: 0xE56D10 VA: 0x180E58710
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0xE58750 Offset: 0xE56D50 VA: 0x180E58750 Slot: 6
	public override string get_Name() { }

	// RVA: 0xE58750 Offset: 0xE56D50 VA: 0x180E58750 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xE38110 Offset: 0xE36710 VA: 0x180E38110 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC93D0 Offset: 0xBC79D0 VA: 0x180BC93D0 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0xE58670 Offset: 0xE56C70 VA: 0x180E58670 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xE586D0 Offset: 0xE56CD0 VA: 0x180E586D0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 55
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

	// RVA: 0xE58710 Offset: 0xE56D10 VA: 0x180E58710
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0xBA5250 Offset: 0xBA3850 VA: 0x180BA5250 Slot: 7
	public override string get_Value() { }

	// RVA: 0xE59440 Offset: 0xE57A40 VA: 0x180E59440 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x82BDB0 Offset: 0x82A3B0 VA: 0x18082BDB0 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0xE59420 Offset: 0xE57A20 VA: 0x180E59420 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0xE59300 Offset: 0xE57900 VA: 0x180E59300 Slot: 56
	public virtual string get_Data() { }

	// RVA: 0xE59350 Offset: 0xE57950 VA: 0x180E59350 Slot: 57
	public virtual void set_Data(string value) { }

	// RVA: 0xE59280 Offset: 0xE57880 VA: 0x180E59280
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

	// RVA: 0xE595C0 Offset: 0xE57BC0 VA: 0x180E595C0
	internal void .ctor(XmlNode container) { }

	// RVA: 0xE59460 Offset: 0xE57A60 VA: 0x180E59460 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0xE59460 Offset: 0xE57A60 VA: 0x180E59460
	internal bool MoveNext() { }

	// RVA: 0xE59500 Offset: 0xE57B00 VA: 0x180E59500 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xE59540 Offset: 0xE57B40 VA: 0x180E59540 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xE59540 Offset: 0xE57B40 VA: 0x180E59540
	internal XmlNode get_Current() { }

}

internal class XmlChildNodes : XmlNodeList // TypeDefIndex: 1952
{	// Fields
	private XmlNode container; // 0x10

	// Properties
	public override int Count { get; }

	// Methods

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
	public void .ctor(XmlNode container) { }

	// RVA: 0xE59730 Offset: 0xE57D30 VA: 0x180E59730 Slot: 6
	public override XmlNode Item(int i) { }

	// RVA: 0xE597A0 Offset: 0xE57DA0 VA: 0x180E597A0 Slot: 7
	public override int get_Count() { }

	// RVA: 0xE59630 Offset: 0xE57C30 VA: 0x180E59630 Slot: 8
	public override IEnumerator GetEnumerator() { }

}

public class XmlComment : XmlCharacterData // TypeDefIndex: 1953
{	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0xE58710 Offset: 0xE56D10 VA: 0x180E58710
	protected internal void .ctor(string comment, XmlDocument doc) { }

	// RVA: 0xE598A0 Offset: 0xE57EA0 VA: 0x180E598A0 Slot: 6
	public override string get_Name() { }

	// RVA: 0xE598A0 Offset: 0xE57EA0 VA: 0x180E598A0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x8C0E00 Offset: 0x8BF400 VA: 0x1808C0E00 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xE59800 Offset: 0xE57E00 VA: 0x180E59800 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xE59860 Offset: 0xE57E60 VA: 0x180E59860 Slot: 43
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

	// RVA: 0xE61AF0 Offset: 0xE600F0 VA: 0x180E61AF0
	protected internal void .ctor(string version, string encoding, string standalone, XmlDocument doc) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Version() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	internal void set_Version(string value) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public string get_Encoding() { }

	// RVA: 0xE61E30 Offset: 0xE60430 VA: 0x180E61E30
	public void set_Encoding(string value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_Standalone() { }

	// RVA: 0xE621B0 Offset: 0xE607B0 VA: 0x180E621B0
	public void set_Standalone(string value) { }

	// RVA: 0xE573B0 Offset: 0xE559B0 VA: 0x180E573B0 Slot: 7
	public override string get_Value() { }

	// RVA: 0xE57680 Offset: 0xE55C80 VA: 0x180E57680 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0xE61CC0 Offset: 0xE602C0 VA: 0x180E61CC0 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0xE61EA0 Offset: 0xE604A0 VA: 0x180E61EA0 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0xE61DF0 Offset: 0xE603F0 VA: 0x180E61DF0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x95FA30 Offset: 0x95E030 VA: 0x18095FA30 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xE61E20 Offset: 0xE60420 VA: 0x180E61E20 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xE61980 Offset: 0xE5FF80 VA: 0x180E61980 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xE61A80 Offset: 0xE60080 VA: 0x180E61A80 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0xE619D0 Offset: 0xE5FFD0 VA: 0x180E619D0
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

	// RVA: 0xE665A0 Offset: 0xE64BA0 VA: 0x180E665A0
	public void .ctor() { }

	// RVA: 0xE66150 Offset: 0xE64750 VA: 0x180E66150
	public void .ctor(XmlNameTable nt) { }

	// RVA: 0xE661C0 Offset: 0xE647C0 VA: 0x180E661C0
	protected internal void .ctor(XmlImplementation imp) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

	// RVA: 0xE62FD0 Offset: 0xE615D0 VA: 0x180E62FD0
	internal static void CheckName(string name) { }

	// RVA: 0xE629C0 Offset: 0xE60FC0 VA: 0x180E629C0
	internal XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0xE64870 Offset: 0xE62E70 VA: 0x180E64870
	internal XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0xE622D0 Offset: 0xE608D0 VA: 0x180E622D0
	internal XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0xE628E0 Offset: 0xE60EE0 VA: 0x180E628E0
	internal bool AddIdInfo(XmlName eleName, XmlName attrName) { }

	// RVA: 0xE64470 Offset: 0xE62A70 VA: 0x180E64470
	private XmlName GetIDInfoByElement_(XmlName eleName) { }

	// RVA: 0xE64580 Offset: 0xE62B80 VA: 0x180E64580
	internal XmlName GetIDInfoByElement(XmlName eleName) { }

	// RVA: 0xE63E10 Offset: 0xE62410 VA: 0x180E63E10
	private WeakReference GetElement(ArrayList elementList, XmlElement elem) { }

	// RVA: 0xE626E0 Offset: 0xE60CE0 VA: 0x180E626E0
	internal void AddElementWithId(string id, XmlElement elem) { }

	// RVA: 0xE65940 Offset: 0xE63F40 VA: 0x180E65940
	internal void RemoveElementWithId(string id, XmlElement elem) { }

	// RVA: 0xE63130 Offset: 0xE61730 VA: 0x180E63130 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xE668B0 Offset: 0xE64EB0 VA: 0x180E668B0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0xE66750 Offset: 0xE64D50 VA: 0x180E66750 Slot: 56
	public virtual XmlDocumentType get_DocumentType() { }

	// RVA: 0xE66610 Offset: 0xE64C10 VA: 0x180E66610 Slot: 57
	internal virtual XmlDeclaration get_Declaration() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public XmlImplementation get_Implementation() { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380 Slot: 6
	public override string get_Name() { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xE666C0 Offset: 0xE64CC0 VA: 0x180E666C0
	public XmlElement get_DocumentElement() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x592630 Offset: 0x590C30 VA: 0x180592630
	internal bool get_CanReportValidity() { }

	// RVA: 0xE66890 Offset: 0xE64E90 VA: 0x180E66890
	internal bool get_HasSetResolver() { }

	// RVA: 0x7DDD70 Offset: 0x7DC370 VA: 0x1807DDD70
	internal XmlResolver GetResolver() { }

	// RVA: 0xE66AF0 Offset: 0xE650F0 VA: 0x180E66AF0 Slot: 58
	public virtual void set_XmlResolver(XmlResolver value) { }

	// RVA: 0xE652C0 Offset: 0xE638C0 VA: 0x180E652C0 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0xE64910 Offset: 0xE62F10 VA: 0x180E64910
	private bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0xE648A0 Offset: 0xE62EA0 VA: 0x180E648A0
	private bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0xE62E10 Offset: 0xE61410 VA: 0x180E62E10 Slot: 28
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0xE62CC0 Offset: 0xE612C0 VA: 0x180E62CC0 Slot: 29
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0xE63360 Offset: 0xE61960 VA: 0x180E63360
	public XmlAttribute CreateAttribute(string name) { }

	// RVA: 0xE65CD0 Offset: 0xE642D0 VA: 0x180E65CD0
	internal void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI) { }

	// RVA: 0xE63490 Offset: 0xE61A90 VA: 0x180E63490 Slot: 59
	public virtual XmlCDataSection CreateCDataSection(string data) { }

	// RVA: 0xE63510 Offset: 0xE61B10 VA: 0x180E63510 Slot: 60
	public virtual XmlComment CreateComment(string data) { }

	// RVA: 0xE63670 Offset: 0xE61C70 VA: 0x180E63670 Slot: 61
	public virtual XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0xE63610 Offset: 0xE61C10 VA: 0x180E63610 Slot: 62
	public virtual XmlDocumentFragment CreateDocumentFragment() { }

	// RVA: 0xE637C0 Offset: 0xE61DC0 VA: 0x180E637C0
	public XmlElement CreateElement(string name) { }

	// RVA: 0xE62420 Offset: 0xE60A20 VA: 0x180E62420
	internal void AddDefaultAttributes(XmlElement elem) { }

	// RVA: 0xE64760 Offset: 0xE62D60 VA: 0x180E64760
	private SchemaElementDecl GetSchemaElementDecl(XmlElement elem) { }

	// RVA: 0xE656E0 Offset: 0xE63CE0 VA: 0x180E656E0
	private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0xE63940 Offset: 0xE61F40 VA: 0x180E63940 Slot: 63
	public virtual XmlEntityReference CreateEntityReference(string name) { }

	// RVA: 0xE639B0 Offset: 0xE61FB0 VA: 0x180E639B0 Slot: 64
	public virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data) { }

	// RVA: 0xE63B80 Offset: 0xE62180 VA: 0x180E63B80 Slot: 65
	public virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0xE63AA0 Offset: 0xE620A0 VA: 0x180E63AA0 Slot: 66
	public virtual XmlText CreateTextNode(string text) { }

	// RVA: 0xE63A30 Offset: 0xE62030 VA: 0x180E63A30 Slot: 67
	public virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text) { }

	// RVA: 0xE63B10 Offset: 0xE62110 VA: 0x180E63B10 Slot: 68
	public virtual XmlWhitespace CreateWhitespace(string text) { }

	// RVA: 0xE632B0 Offset: 0xE618B0 VA: 0x180E632B0
	public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI) { }

	// RVA: 0xE63710 Offset: 0xE61D10 VA: 0x180E63710
	public XmlElement CreateElement(string qualifiedName, string namespaceURI) { }

	// RVA: 0xE64C00 Offset: 0xE63200 VA: 0x180E64C00
	private XmlNode ImportNodeInternal(XmlNode node, bool deep) { }

	// RVA: 0xE649F0 Offset: 0xE62FF0 VA: 0x180E649F0
	private void ImportAttributes(XmlNode fromElem, XmlNode toElem) { }

	// RVA: 0xE64B50 Offset: 0xE63150 VA: 0x180E64B50
	private void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep) { }

	// RVA: 0xE57390 Offset: 0xE55990 VA: 0x180E57390
	public XmlNameTable get_NameTable() { }

	// RVA: 0xE63210 Offset: 0xE61810 VA: 0x180E63210 Slot: 69
	public virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0xE63580 Offset: 0xE61B80 VA: 0x180E63580 Slot: 70
	protected internal virtual XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0xE63870 Offset: 0xE61E70 VA: 0x180E63870 Slot: 71
	public virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0xE66810 Offset: 0xE64E10 VA: 0x180E66810
	internal XmlNamedNodeMap get_Entities() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	internal void set_Entities(XmlNamedNodeMap value) { }

	// RVA: 0xE668A0 Offset: 0xE64EA0 VA: 0x180E668A0
	internal bool get_IsLoading() { }

	// RVA: 0xE66AE0 Offset: 0xE650E0 VA: 0x180E66AE0
	internal void set_IsLoading(bool value) { }

	// RVA: 0xAF5FA0 Offset: 0xAF45A0 VA: 0x180AF5FA0
	internal bool get_ActualLoadingStatus() { }

	// RVA: 0xE65840 Offset: 0xE63E40 VA: 0x180E65840 Slot: 72
	public virtual XmlNode ReadNode(XmlReader reader) { }

	// RVA: 0xE65D80 Offset: 0xE64380 VA: 0x180E65D80
	private XmlTextReader SetupReader(XmlTextReader tr) { }

	// RVA: 0xE655C0 Offset: 0xE63BC0 VA: 0x180E655C0 Slot: 73
	public virtual void Load(XmlReader reader) { }

	// RVA: 0xE65460 Offset: 0xE63A60 VA: 0x180E65460 Slot: 74
	public virtual void LoadXml(string xml) { }

	// RVA: 0xE66A50 Offset: 0xE65050 VA: 0x180E66A50 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0xE66AC0 Offset: 0xE650C0 VA: 0x180E66AC0 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0xE65AA0 Offset: 0xE640A0 VA: 0x180E65AA0 Slot: 75
	public virtual void Save(XmlWriter w) { }

	// RVA: 0xE66020 Offset: 0xE64620 VA: 0x180E66020 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0xE65DE0 Offset: 0xE643E0 VA: 0x180E65DE0 Slot: 44
	public override void WriteContentTo(XmlWriter xw) { }

	// RVA: 0xE64380 Offset: 0xE62980 VA: 0x180E64380 Slot: 50
	internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0xE64690 Offset: 0xE62C90 VA: 0x180E64690
	internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent) { }

	// RVA: 0xE62C70 Offset: 0xE61270 VA: 0x180E62C70 Slot: 51
	internal override void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0xE629F0 Offset: 0xE60FF0 VA: 0x180E629F0 Slot: 52
	internal override void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0xE63C10 Offset: 0xE62210 VA: 0x180E63C10
	internal XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0xE66A20 Offset: 0xE65020 VA: 0x180E66A20
	internal string get_Version() { }

	// RVA: 0xE667E0 Offset: 0xE64DE0 VA: 0x180E667E0
	internal string get_Encoding() { }

	// RVA: 0xE669F0 Offset: 0xE64FF0 VA: 0x180E669F0
	internal string get_Standalone() { }

	// RVA: 0xE64290 Offset: 0xE62890 VA: 0x180E64290
	internal XmlEntity GetEntityNode(string name) { }

	// RVA: 0xE668C0 Offset: 0xE64EC0 VA: 0x180E668C0 Slot: 41
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xE66600 Offset: 0xE64C00 VA: 0x180E66600 Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0xE65CC0 Offset: 0xE642C0 VA: 0x180E65CC0
	internal void SetBaseURI(string inBaseURI) { }

	// RVA: 0xE62A40 Offset: 0xE61040 VA: 0x180E62A40 Slot: 26
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0xE66040 Offset: 0xE64640 VA: 0x180E66040
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

	// RVA: 0x11BB110 Offset: 0x11B9710 VA: 0x1811BB110
	protected internal void .ctor(XmlDocument ownerDocument) { }

	// RVA: 0x11BB1B0 Offset: 0x11B97B0 VA: 0x1811BB1B0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x11BB1B0 Offset: 0x11B97B0 VA: 0x1811BB1B0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x11BB1E0 Offset: 0x11B97E0 VA: 0x1811BB1E0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x11BB1F0 Offset: 0x11B97F0 VA: 0x1811BB1F0 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x11BB270 Offset: 0x11B9870 VA: 0x1811BB270 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x11BAD60 Offset: 0x11B9360 VA: 0x1811BAD60 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11BAE00 Offset: 0x11B9400 VA: 0x1811BAE00 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x11BAC70 Offset: 0x11B9270 VA: 0x1811BAC70 Slot: 29
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11BACF0 Offset: 0x11B92F0 VA: 0x1811BACF0 Slot: 28
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0xE66020 Offset: 0xE64620 VA: 0x180E66020 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11BAEB0 Offset: 0x11B94B0 VA: 0x1811BAEB0 Slot: 44
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

	// RVA: 0x11BB3C0 Offset: 0x11B99C0 VA: 0x1811BB3C0
	protected internal void .ctor(string name, string publicId, string systemId, string internalSubset, XmlDocument doc) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 6
	public override string get_Name() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x4A6090 Offset: 0x4A4690 VA: 0x1804A6090 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11BB310 Offset: 0x11B9910 VA: 0x1811BB310 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x11BB580 Offset: 0x11B9B80 VA: 0x1811BB580
	public XmlNamedNodeMap get_Entities() { }

	// RVA: 0x11BB610 Offset: 0x11B9C10 VA: 0x1811BB610
	public XmlNamedNodeMap get_Notations() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public string get_PublicId() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_SystemId() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_InternalSubset() { }

	// RVA: 0x805600 Offset: 0x803C00 VA: 0x180805600
	internal bool get_ParseWithNamespaces() { }

	// RVA: 0x11BB370 Offset: 0x11B9970 VA: 0x1811BB370 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
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

	// RVA: 0x11BD500 Offset: 0x11BBB00 VA: 0x1811BD500
	internal void .ctor(XmlName name, bool empty, XmlDocument doc) { }

	// RVA: 0x11BD370 Offset: 0x11BB970 VA: 0x1811BD370
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal XmlName get_XmlName() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	internal void set_XmlName(XmlName value) { }

	// RVA: 0x11BC2E0 Offset: 0x11BA8E0 VA: 0x1811BC2E0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x11BD890 Offset: 0x11BBE90 VA: 0x1811BD890 Slot: 6
	public override string get_Name() { }

	// RVA: 0x11BD870 Offset: 0x11BBE70 VA: 0x1811BD870 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x11BD8B0 Offset: 0x11BBEB0 VA: 0x1811BD8B0 Slot: 33
	public override string get_NamespaceURI() { }

	// RVA: 0x11BD930 Offset: 0x11BBF30 VA: 0x1811BD930 Slot: 34
	public override string get_Prefix() { }

	// RVA: 0x11BDB10 Offset: 0x11BC110 VA: 0x1811BDB10 Slot: 35
	public override void set_Prefix(string value) { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x11BD910 Offset: 0x11BBF10 VA: 0x1811BD910 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x11BC110 Offset: 0x11BA710 VA: 0x1811BC110 Slot: 26
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x11BD850 Offset: 0x11BBE50 VA: 0x1811BD850
	public bool get_IsEmpty() { }

	// RVA: 0x11BDAB0 Offset: 0x11BC0B0 VA: 0x1811BDAB0
	public void set_IsEmpty(bool value) { }

	// RVA: 0x11BD860 Offset: 0x11BBE60 VA: 0x1811BD860 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11BCA20 Offset: 0x11BB020 VA: 0x1811BCA20 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x11BD6D0 Offset: 0x11BBCD0 VA: 0x1811BD6D0 Slot: 14
	public override XmlAttributeCollection get_Attributes() { }

	// RVA: 0x11BD810 Offset: 0x11BBE10 VA: 0x1811BD810 Slot: 56
	public virtual bool get_HasAttributes() { }

	// RVA: 0x11BC8E0 Offset: 0x11BAEE0 VA: 0x1811BC8E0 Slot: 57
	public virtual string GetAttribute(string name) { }

	// RVA: 0x11BCE40 Offset: 0x11BB440 VA: 0x1811BCE40 Slot: 58
	public virtual void SetAttribute(string name, string value) { }

	// RVA: 0x11BC870 Offset: 0x11BAE70 VA: 0x1811BC870 Slot: 59
	public virtual XmlAttribute GetAttributeNode(string name) { }

	// RVA: 0x11BCBF0 Offset: 0x11BB1F0 VA: 0x1811BCBF0 Slot: 60
	public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr) { }

	// RVA: 0x11BC960 Offset: 0x11BAF60 VA: 0x1811BC960 Slot: 61
	public virtual string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x11BCD10 Offset: 0x11BB310 VA: 0x1811BCD10 Slot: 62
	public virtual string SetAttribute(string localName, string namespaceURI, string value) { }

	// RVA: 0x11BC7F0 Offset: 0x11BADF0 VA: 0x1811BC7F0 Slot: 63
	public virtual XmlAttribute GetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x11BCB00 Offset: 0x11BB100 VA: 0x1811BCB00 Slot: 64
	public virtual XmlAttribute SetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x11BCA00 Offset: 0x11BB000 VA: 0x1811BCA00 Slot: 65
	public virtual bool HasAttribute(string name) { }

	// RVA: 0x11BD260 Offset: 0x11BB860 VA: 0x1811BD260 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11BCF20 Offset: 0x11BB520 VA: 0x1811BCF20
	private static void WriteElementTo(XmlWriter writer, XmlElement e) { }

	// RVA: 0x11BD130 Offset: 0x11BB730 VA: 0x1811BD130
	private void WriteStartElement(XmlWriter w) { }

	// RVA: 0xE56F50 Offset: 0xE55550 VA: 0x180E56F50 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11BCA80 Offset: 0x11BB080 VA: 0x1811BCA80 Slot: 66
	public virtual void RemoveAllAttributes() { }

	// RVA: 0x11BCAD0 Offset: 0x11BB0D0 VA: 0x1811BCAD0 Slot: 45
	public override void RemoveAll() { }

	// RVA: 0x11BCAC0 Offset: 0x11BB0C0 VA: 0x1811BCAC0
	internal void RemoveAllChildren() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 41
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11BDA30 Offset: 0x11BC030 VA: 0x1811BDA30 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x11BD840 Offset: 0x11BBE40 VA: 0x1811BD840 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0x11BD950 Offset: 0x11BBF50 VA: 0x1811BD950 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x11BD8D0 Offset: 0x11BBED0 VA: 0x1811BD8D0 Slot: 13
	public override XmlNode get_NextSibling() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630 Slot: 47
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

	// RVA: 0x11C3970 Offset: 0x11C1F70 VA: 0x1811C3970
	internal void .ctor(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc) { }

	// RVA: 0x11C38E0 Offset: 0x11C1EE0 VA: 0x1811C38E0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 6
	public override string get_Name() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x11BD840 Offset: 0x11BBE40 VA: 0x1811BD840 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0x11C3BC0 Offset: 0x11C21C0 VA: 0x1811C3BC0 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x11C3AC0 Offset: 0x11C20C0 VA: 0x1811C3AC0 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11C3950 Offset: 0x11C1F50 VA: 0x1811C3950 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x91FD00 Offset: 0x91E300 VA: 0x18091FD00 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_SystemId() { }

	// RVA: 0x11C3C30 Offset: 0x11C2230 VA: 0x1811C3C30 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0 Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
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

	// RVA: 0x11C3530 Offset: 0x11C1B30 VA: 0x1811C3530
	protected internal void .ctor(string name, XmlDocument doc) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 6
	public override string get_Name() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 7
	public override string get_Value() { }

	// RVA: 0x11C3870 Offset: 0x11C1E70 VA: 0x1811C3870 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x6F3610 Offset: 0x6F1C10 VA: 0x1806F3610 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11C30B0 Offset: 0x11C16B0 VA: 0x1811C30B0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x11C31C0 Offset: 0x11C17C0 VA: 0x1811C31C0 Slot: 47
	internal override void SetParent(XmlNode node) { }

	// RVA: 0xE30680 Offset: 0xE2EC80 VA: 0x180E30680 Slot: 48
	internal override void SetParentForLoad(XmlNode node) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11BCA20 Offset: 0x11BB020 VA: 0x1811BCA20 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x11C3500 Offset: 0x11C1B00 VA: 0x1811C3500 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11C32A0 Offset: 0x11C18A0 VA: 0x1811C32A0 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11C36C0 Offset: 0x11C1CC0 VA: 0x1811C36C0 Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0x11C3100 Offset: 0x11C1700 VA: 0x1811C3100
	private string ConstructBaseURI(string baseURI, string systemId) { }

	// RVA: 0x11C3700 Offset: 0x11C1D00 VA: 0x1811C3700
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

	// RVA: 0x11C7080 Offset: 0x11C5680 VA: 0x1811C7080
	public void .ctor() { }

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(XmlNameTable nt) { }

	// RVA: 0x11C7020 Offset: 0x11C5620 VA: 0x1811C7020 Slot: 4
	public virtual XmlDocument CreateDocument() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal XmlNameTable get_NameTable() { }

}

public abstract class XmlLinkedNode : XmlNode // TypeDefIndex: 1963
{	// Fields
	internal XmlLinkedNode next; // 0x18

	// Properties
	public override XmlNode PreviousSibling { get; }
	public override XmlNode NextSibling { get; }

	// Methods

	// RVA: 0x11C70F0 Offset: 0x11C56F0 VA: 0x1811C70F0
	internal void .ctor(XmlDocument doc) { }

	// RVA: 0x11C7200 Offset: 0x11C5800 VA: 0x1811C7200 Slot: 12
	public override XmlNode get_PreviousSibling() { }

	// RVA: 0x11C71A0 Offset: 0x11C57A0 VA: 0x1811C71A0 Slot: 13
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

	// RVA: 0x11CB380 Offset: 0x11C9980 VA: 0x1811CB380
	internal void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace) { }

	// RVA: 0x11C9460 Offset: 0x11C7A60 VA: 0x1811C9460
	private void LoadDocSequence(XmlDocument parentDoc) { }

	// RVA: 0x11CBD80 Offset: 0x11CA380 VA: 0x1811CBD80
	internal XmlNode ReadCurrentNode(XmlDocument doc, XmlReader reader) { }

	// RVA: 0x11CACC0 Offset: 0x11C92C0 VA: 0x1811CACC0
	private XmlNode LoadNode(bool skipOverWhitespace) { }

	// RVA: 0x11C8880 Offset: 0x11C6E80 VA: 0x1811C8880
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0x11C90A0 Offset: 0x11C76A0 VA: 0x1811C90A0
	private XmlAttribute LoadDefaultAttribute() { }

	// RVA: 0x11C8BE0 Offset: 0x11C71E0 VA: 0x1811C8BE0
	private void LoadAttributeValue(XmlNode parent, bool direct) { }

	// RVA: 0x11CA250 Offset: 0x11C8850 VA: 0x1811CA250
	private XmlEntityReference LoadEntityReferenceNode(bool direct) { }

	// RVA: 0x11C8ED0 Offset: 0x11C74D0 VA: 0x1811C8ED0
	private XmlDeclaration LoadDeclarationNode() { }

	// RVA: 0x11C94D0 Offset: 0x11C7AD0 VA: 0x1811C94D0
	private XmlDocumentType LoadDocumentTypeNode() { }

	// RVA: 0x11CA640 Offset: 0x11C8C40 VA: 0x1811CA640
	private XmlNode LoadNodeDirect() { }

	// RVA: 0x11C8310 Offset: 0x11C6910 VA: 0x1811C8310
	private XmlAttribute LoadAttributeNodeDirect() { }

	// RVA: 0x11CB8D0 Offset: 0x11C9ED0 VA: 0x1811CB8D0
	internal void ParseDocumentType(XmlDocumentType dtNode) { }

	// RVA: 0x11CB660 Offset: 0x11C9C60 VA: 0x1811CB660
	private void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver) { }

	// RVA: 0x11C9700 Offset: 0x11C7D00 VA: 0x1811C9700
	private void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode) { }

	// RVA: 0x11C7A80 Offset: 0x11C6080 VA: 0x1811C7A80
	private XmlParserContext GetContext(XmlNode node) { }

	// RVA: 0x11CB950 Offset: 0x11C9F50 VA: 0x1811CB950
	internal XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt) { }

	// RVA: 0x11CA4A0 Offset: 0x11C8AA0 VA: 0x1811CA4A0
	internal void LoadInnerXmlElement(XmlElement node, string innerxmltext) { }

	// RVA: 0x11CA480 Offset: 0x11C8A80 VA: 0x1811CA480
	internal void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext) { }

	// RVA: 0x11CBF20 Offset: 0x11CA520 VA: 0x1811CBF20
	private void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs) { }

	// RVA: 0x11C74B0 Offset: 0x11C5AB0 VA: 0x1811C74B0
	private string EntitizeName(string name) { }

	// RVA: 0x11C79E0 Offset: 0x11C5FE0 VA: 0x1811C79E0
	internal void ExpandEntity(XmlEntity ent) { }

	// RVA: 0x11C7500 Offset: 0x11C5B00 VA: 0x1811C7500
	internal void ExpandEntityReference(XmlEntityReference eref) { }

	// RVA: 0x11C7280 Offset: 0x11C5880 VA: 0x1811C7280
	private XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc) { }

	// RVA: 0x11CBB80 Offset: 0x11CA180 VA: 0x1811CBB80
	internal static void ParseXmlDeclarationValue(string strValue, out string version, out string encoding, out string standalone) { }

	// RVA: 0x11CC240 Offset: 0x11CA840 VA: 0x1811CC240
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

	// RVA: 0x11CC860 Offset: 0x11CAE60 VA: 0x1811CC860
	public static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x11CCAF0 Offset: 0x11CB0F0 VA: 0x1811CCAF0
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_LocalName() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_NamespaceURI() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Prefix() { }

	// RVA: 0xA38FA0 Offset: 0xA375A0 VA: 0x180A38FA0
	public int get_HashCode() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public XmlDocument get_OwnerDocument() { }

	// RVA: 0x11CCBA0 Offset: 0x11CB1A0 VA: 0x1811CCBA0
	public string get_Name() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 11
	public virtual XmlSchemaValidity get_Validity() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 12
	public virtual bool get_IsDefault() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 13
	public virtual bool get_IsNil() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 14
	public virtual XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 15
	public virtual XmlSchemaType get_SchemaType() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 16
	public virtual XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 17
	public virtual XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0xDF02D0 Offset: 0xDEE8D0 VA: 0x180DF02D0 Slot: 18
	public virtual bool Equals(IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x11CCA80 Offset: 0x11CB080 VA: 0x1811CCA80
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

	// RVA: 0x11CC570 Offset: 0x11CAB70 VA: 0x1811CC570
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x11CC830 Offset: 0x11CAE30 VA: 0x1811CC830 Slot: 11
	public override XmlSchemaValidity get_Validity() { }

	// RVA: 0x11CC710 Offset: 0x11CAD10 VA: 0x1811CC710 Slot: 12
	public override bool get_IsDefault() { }

	// RVA: 0x11CC720 Offset: 0x11CAD20 VA: 0x1811CC720 Slot: 13
	public override bool get_IsNil() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 14
	public override XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860 Slot: 15
	public override XmlSchemaType get_SchemaType() { }

	// RVA: 0x11CC7B0 Offset: 0x11CADB0 VA: 0x1811CC7B0 Slot: 16
	public override XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x11CC730 Offset: 0x11CAD30 VA: 0x1811CC730 Slot: 17
	public override XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x11CC560 Offset: 0x11CAB60 VA: 0x1811CC560
	public void SetValidity(XmlSchemaValidity value) { }

	// RVA: 0x11CC500 Offset: 0x11CAB00 VA: 0x1811CC500
	public void SetIsDefault(bool value) { }

	// RVA: 0x11CC530 Offset: 0x11CAB30 VA: 0x1811CC530
	public void SetIsNil(bool value) { }

	// RVA: 0x11CC340 Offset: 0x11CA940 VA: 0x1811CC340 Slot: 18
	public override bool Equals(IXmlSchemaInfo schemaInfo) { }

}

public class XmlNamedNodeMap : IEnumerable // TypeDefIndex: 1967
{	// Fields
	internal XmlNode parent; // 0x10
	internal XmlNamedNodeMap.SmallXmlNodeList nodes; // 0x18

	// Properties
	public virtual int Count { get; }

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	internal void .ctor(XmlNode parent) { }

	// RVA: 0x11CD240 Offset: 0x11CB840 VA: 0x1811CD240 Slot: 5
	public virtual XmlNode GetNamedItem(string name) { }

	// RVA: 0x11CD7B0 Offset: 0x11CBDB0 VA: 0x1811CD7B0 Slot: 6
	public virtual XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x11CD990 Offset: 0x11CBF90 VA: 0x1811CD990 Slot: 7
	public virtual int get_Count() { }

	// RVA: 0x11CD230 Offset: 0x11CB830 VA: 0x1811CD230 Slot: 8
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x11CCFF0 Offset: 0x11CB5F0 VA: 0x1811CCFF0
	internal int FindNodeOffset(string name) { }

	// RVA: 0x11CD0F0 Offset: 0x11CB6F0 VA: 0x1811CD0F0
	internal int FindNodeOffset(string localName, string namespaceURI) { }

	// RVA: 0x11CCE10 Offset: 0x11CB410 VA: 0x1811CCE10 Slot: 9
	internal virtual XmlNode AddNode(XmlNode node) { }

	// RVA: 0x11CCD50 Offset: 0x11CB350 VA: 0x1811CCD50 Slot: 10
	internal virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc) { }

	// RVA: 0x11CD5C0 Offset: 0x11CBBC0 VA: 0x1811CD5C0 Slot: 11
	internal virtual XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x11CD740 Offset: 0x11CBD40 VA: 0x1811CD740
	internal XmlNode ReplaceNodeAt(int i, XmlNode node) { }

	// RVA: 0x11CD3D0 Offset: 0x11CB9D0 VA: 0x1811CD3D0 Slot: 12
	internal virtual XmlNode InsertNodeAt(int i, XmlNode node) { }

}

internal struct XmlNamedNodeMap.SmallXmlNodeList // TypeDefIndex: 1968
{	// Fields
	private object field; // 0x0

	// Properties
	public int Count { get; }
	public object Item { get; }

	// Methods

	// RVA: 0x1D0BF0 Offset: 0x1CFFF0 VA: 0x1801D0BF0
	public int get_Count() { }

	// RVA: 0x1D0C00 Offset: 0x1D0000 VA: 0x1801D0C00
	public object get_Item(int index) { }

	// RVA: 0x1D0BB0 Offset: 0x1CFFB0 VA: 0x1801D0BB0
	public void Add(object value) { }

	// RVA: 0x1D0BE0 Offset: 0x1CFFE0 VA: 0x1801D0BE0
	public void RemoveAt(int index) { }

	// RVA: 0x1D0BD0 Offset: 0x1CFFD0 VA: 0x1801D0BD0
	public void Insert(int index, object value) { }

	// RVA: 0x1D0BC0 Offset: 0x1CFFC0 VA: 0x1801D0BC0
	public IEnumerator GetEnumerator() { }

}

private class XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator : IEnumerator // TypeDefIndex: 1969
{	// Fields
	private object loneValue; // 0x10
	private int position; // 0x18

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x11B9D20 Offset: 0x11B8320 VA: 0x1811B9D20
	public void .ctor(object value) { }

	// RVA: 0x11B9D60 Offset: 0x11B8360 VA: 0x1811B9D60 Slot: 5
	public object get_Current() { }

	// RVA: 0x11B9D00 Offset: 0x11B8300 VA: 0x1811B9D00 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x117C6D0 Offset: 0x117ACD0 VA: 0x18117C6D0 Slot: 6
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

	// RVA: 0x11D24E0 Offset: 0x11D0AE0 VA: 0x1811D24E0
	internal void .ctor(XmlDocument doc) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_Name();

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 7
	public virtual string get_Value() { }

	// RVA: 0x11D30E0 Offset: 0x11D16E0 VA: 0x1811D30E0 Slot: 8
	public virtual void set_Value(string value) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x11D2B80 Offset: 0x11D1180 VA: 0x1811D2B80 Slot: 10
	public virtual XmlNode get_ParentNode() { }

	// RVA: 0x11D26C0 Offset: 0x11D0CC0 VA: 0x1811D26C0 Slot: 11
	public virtual XmlNodeList get_ChildNodes() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 12
	public virtual XmlNode get_PreviousSibling() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 13
	public virtual XmlNode get_NextSibling() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 14
	public virtual XmlAttributeCollection get_Attributes() { }

	// RVA: 0x11D2AB0 Offset: 0x11D10B0 VA: 0x1811D2AB0 Slot: 15
	public virtual XmlDocument get_OwnerDocument() { }

	// RVA: 0x11D27C0 Offset: 0x11D0DC0 VA: 0x1811D27C0 Slot: 16
	public virtual XmlNode get_FirstChild() { }

	// RVA: 0x11D2A50 Offset: 0x11D1050 VA: 0x1811D2A50 Slot: 17
	public virtual XmlNode get_LastChild() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 18
	internal virtual bool get_IsContainer() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 19
	internal virtual XmlLinkedNode get_LastNode() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 20
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11CFD80 Offset: 0x11CE380 VA: 0x1811CFD80
	internal bool AncestorNode(XmlNode node) { }

	// RVA: 0x11D16A0 Offset: 0x11CFCA0 VA: 0x1811D16A0 Slot: 21
	public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11D0FB0 Offset: 0x11CF5B0 VA: 0x1811D0FB0 Slot: 22
	public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11D1E90 Offset: 0x11D0490 VA: 0x1811D1E90 Slot: 23
	public virtual XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x11D1DC0 Offset: 0x11D03C0 VA: 0x1811D1DC0 Slot: 24
	public virtual XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0x11D00E0 Offset: 0x11CE6E0 VA: 0x1811D00E0 Slot: 25
	public virtual XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x11CFDF0 Offset: 0x11CE3F0 VA: 0x1811CFDF0 Slot: 26
	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 27
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 28
	internal virtual bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 29
	internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11D27F0 Offset: 0x11D0DF0 VA: 0x1811D27F0 Slot: 30
	public virtual bool get_HasChildNodes() { }

	// RVA: -1 Offset: -1 Slot: 31
	public abstract XmlNode CloneNode(bool deep);

	// RVA: 0x11D06C0 Offset: 0x11CECC0 VA: 0x1811D06C0 Slot: 32
	internal virtual void CopyChildren(XmlDocument doc, XmlNode container, bool deep) { }

	// RVA: 0x11D2A70 Offset: 0x11D1070 VA: 0x1811D2A70 Slot: 33
	public virtual string get_NamespaceURI() { }

	// RVA: 0x11D2C70 Offset: 0x11D1270 VA: 0x1811D2C70 Slot: 34
	public virtual string get_Prefix() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 35
	public virtual void set_Prefix(string value) { }

	// RVA: -1 Offset: -1 Slot: 36
	public abstract string get_LocalName();

	// RVA: 0x11D2920 Offset: 0x11D0F20 VA: 0x1811D2920 Slot: 37
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x11D0E90 Offset: 0x11CF490 VA: 0x1811D0E90
	internal static bool HasReadOnlyParent(XmlNode n) { }

	// RVA: 0x11D2480 Offset: 0x11D0A80 VA: 0x1811D2480 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x11D2420 Offset: 0x11D0A20 VA: 0x1811D2420 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x11D07F0 Offset: 0x11CEDF0 VA: 0x1811D07F0
	public IEnumerator GetEnumerator() { }

	// RVA: 0x11CFFD0 Offset: 0x11CE5D0 VA: 0x1811CFFD0
	private void AppendChildText(StringBuilder builder) { }

	// RVA: 0x11D2810 Offset: 0x11D0E10 VA: 0x1811D2810 Slot: 38
	public virtual string get_InnerText() { }

	// RVA: 0x11D2F70 Offset: 0x11D1570 VA: 0x1811D2F70 Slot: 39
	public virtual void set_InnerText(string value) { }

	// RVA: 0x11D3070 Offset: 0x11D1670 VA: 0x1811D3070 Slot: 40
	public virtual void set_InnerXml(string value) { }

	// RVA: 0x11D2CB0 Offset: 0x11D12B0 VA: 0x1811D2CB0 Slot: 41
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11D2580 Offset: 0x11D0B80 VA: 0x1811D2580 Slot: 42
	public virtual string get_BaseURI() { }

	// RVA: -1 Offset: -1 Slot: 43
	public abstract void WriteTo(XmlWriter w);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract void WriteContentTo(XmlWriter w);

	// RVA: 0x11D1E10 Offset: 0x11D0410 VA: 0x1811D1E10 Slot: 45
	public virtual void RemoveAll() { }

	// RVA: 0x11D2720 Offset: 0x11D0D20 VA: 0x1811D2720
	internal XmlDocument get_Document() { }

	// RVA: 0x11D0E30 Offset: 0x11CF430 VA: 0x1811D0E30 Slot: 46
	public virtual string GetPrefixOfNamespace(string namespaceURI) { }

	// RVA: 0x11D0980 Offset: 0x11CEF80 VA: 0x1811D0980
	internal string GetPrefixOfNamespaceStrict(string namespaceURI) { }

	// RVA: 0x11D2300 Offset: 0x11D0900 VA: 0x1811D2300 Slot: 47
	internal virtual void SetParent(XmlNode node) { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630 Slot: 48
	internal virtual void SetParentForLoad(XmlNode node) { }

	// RVA: 0x11D2340 Offset: 0x11D0940 VA: 0x1811D2340
	internal static void SplitName(string name, out string prefix, out string localName) { }

	// RVA: 0x11D0770 Offset: 0x11CED70 VA: 0x1811D0770 Slot: 49
	internal virtual XmlNode FindChild(XmlNodeType type) { }

	// RVA: 0x11D0850 Offset: 0x11CEE50 VA: 0x1811D0850 Slot: 50
	internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x11D0670 Offset: 0x11CEC70 VA: 0x1811D0670 Slot: 51
	internal virtual void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x11CFD30 Offset: 0x11CE330 VA: 0x1811CFD30 Slot: 52
	internal virtual void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x11D2E10 Offset: 0x11D1410 VA: 0x1811D2E10 Slot: 53
	internal virtual XmlSpace get_XmlSpace() { }

	// RVA: 0x11D2D10 Offset: 0x11D1310 VA: 0x1811D2D10 Slot: 54
	internal virtual string get_XmlLang() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 55
	internal virtual bool get_IsText() { }

	// RVA: 0x11D1D90 Offset: 0x11D0390 VA: 0x1811D1D90
	internal static void NestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

	// RVA: 0x11D24A0 Offset: 0x11D0AA0 VA: 0x1811D24A0
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

	// RVA: 0x11CE910 Offset: 0x11CCF10 VA: 0x1811CE910
	public void .ctor(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public XmlNodeChangedAction get_Action() { }

}

public sealed class XmlNodeChangedEventHandler : MulticastDelegate // TypeDefIndex: 1972
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4880 Offset: 0xAE2E80 VA: 0x180AE4880 Slot: 12
	public virtual void Invoke(object sender, XmlNodeChangedEventArgs e) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
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

	// RVA: 0x11CE9E0 Offset: 0x11CCFE0 VA: 0x1811CE9E0 Slot: 9
	public virtual XmlNode get_ItemOf(int i) { }

	// RVA: 0xE3B450 Offset: 0xE39A50 VA: 0x180E3B450 Slot: 5
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

	// RVA: 0xB9E610 Offset: 0xB9CC10 VA: 0x180B9E610
	public void .ctor(XmlNode node) { }

	// RVA: 0xB9F130 Offset: 0xB9D730 VA: 0x180B9F130
	public XmlNodeType get_NodeType() { }

	// RVA: 0xB9F100 Offset: 0xB9D700 VA: 0x180B9F100
	public string get_NamespaceURI() { }

	// RVA: 0xB9EFB0 Offset: 0xB9D5B0 VA: 0x180B9EFB0
	public string get_Name() { }

	// RVA: 0xB9EDA0 Offset: 0xB9D3A0 VA: 0x180B9EDA0
	public string get_LocalName() { }

	// RVA: 0xB9EB60 Offset: 0xB9D160 VA: 0x180B9EB60
	internal bool get_CreatedOnAttribute() { }

	// RVA: 0xB9CDA0 Offset: 0xB9B3A0 VA: 0x180B9CDA0
	private bool IsLocalNameEmpty(XmlNodeType nt) { }

	// RVA: 0xB9F170 Offset: 0xB9D770 VA: 0x180B9F170
	public string get_Prefix() { }

	// RVA: 0xB9F1D0 Offset: 0xB9D7D0 VA: 0x180B9F1D0
	public string get_Value() { }

	// RVA: 0xB9EB30 Offset: 0xB9D130 VA: 0x180B9EB30
	public string get_BaseURI() { }

	// RVA: 0xB9F4D0 Offset: 0xB9DAD0 VA: 0x180B9F4D0
	public XmlSpace get_XmlSpace() { }

	// RVA: 0xB9F4A0 Offset: 0xB9DAA0 VA: 0x180B9F4A0
	public string get_XmlLang() { }

	// RVA: 0xB9EC70 Offset: 0xB9D270 VA: 0x180B9EC70
	public bool get_IsEmptyElement() { }

	// RVA: 0xB9EB70 Offset: 0xB9D170 VA: 0x180B9EB70
	public bool get_IsDefault() { }

	// RVA: 0xB9F1A0 Offset: 0xB9D7A0 VA: 0x180B9F1A0
	public IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public XmlNameTable get_NameTable() { }

	// RVA: 0xB9E9A0 Offset: 0xB9CFA0 VA: 0x180B9E9A0
	public int get_AttributeCount() { }

	// RVA: 0xB9B550 Offset: 0xB99B50 VA: 0x180B9B550
	private void CheckIndexCondition(int attributeIndex) { }

	// RVA: 0xB9CA00 Offset: 0xB9B000 VA: 0x180B9CA00
	private void InitDecAttr() { }

	// RVA: 0xB9C2D0 Offset: 0xB9A8D0 VA: 0x180B9C2D0
	public string GetDeclarationAttr(XmlDeclaration decl, string name) { }

	// RVA: 0xB9C270 Offset: 0xB9A870 VA: 0x180B9C270
	public string GetDeclarationAttr(int i) { }

	// RVA: 0xB9C1D0 Offset: 0xB9A7D0 VA: 0x180B9C1D0
	public int GetDecAttrInd(string name) { }

	// RVA: 0xB9CC30 Offset: 0xB9B230 VA: 0x180B9CC30
	private void InitDocTypeAttr() { }

	// RVA: 0xB9C430 Offset: 0xB9AA30 VA: 0x180B9C430
	public string GetDocumentTypeAttr(XmlDocumentType docType, string name) { }

	// RVA: 0xB9C4D0 Offset: 0xB9AAD0 VA: 0x180B9C4D0
	public string GetDocumentTypeAttr(int i) { }

	// RVA: 0xB9C390 Offset: 0xB9A990 VA: 0x180B9C390
	public int GetDocTypeAttrInd(string name) { }

	// RVA: 0xB9B760 Offset: 0xB99D60 VA: 0x180B9B760
	private string GetAttributeFromElement(XmlElement elem, string name) { }

	// RVA: 0xB9BE50 Offset: 0xB9A450 VA: 0x180B9BE50
	public string GetAttribute(string name) { }

	// RVA: 0xB9B700 Offset: 0xB99D00 VA: 0x180B9B700
	private string GetAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0xB9BAA0 Offset: 0xB9A0A0 VA: 0x180B9BAA0
	public string GetAttribute(string name, string ns) { }

	// RVA: 0xB9B7B0 Offset: 0xB99DB0 VA: 0x180B9B7B0
	public string GetAttribute(int attributeIndex) { }

	// RVA: 0xB9CDF0 Offset: 0xB9B3F0 VA: 0x180B9CDF0
	public void LogMove(int level) { }

	// RVA: 0xB9E5C0 Offset: 0xB9CBC0 VA: 0x180B9E5C0
	public void RollBackMove(ref int level) { }

	// RVA: 0xB9ED60 Offset: 0xB9D360 VA: 0x180B9ED60
	private bool get_IsOnDeclOrDocType() { }

	// RVA: 0xB9E4E0 Offset: 0xB9CAE0 VA: 0x180B9E4E0
	public void ResetToAttribute(ref int level) { }

	// RVA: 0xB9E220 Offset: 0xB9C820 VA: 0x180B9E220
	public void ResetMove(ref int level, ref XmlNodeType nt) { }

	// RVA: 0xB9D8A0 Offset: 0xB9BEA0 VA: 0x180B9D8A0
	public bool MoveToAttribute(string name) { }

	// RVA: 0xB9D530 Offset: 0xB9BB30 VA: 0x180B9D530
	private bool MoveToAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0xB9D610 Offset: 0xB9BC10 VA: 0x180B9D610
	public bool MoveToAttribute(string name, string namespaceURI) { }

	// RVA: 0xB9D900 Offset: 0xB9BF00 VA: 0x180B9D900
	public void MoveToAttribute(int attributeIndex) { }

	// RVA: 0xB9DC80 Offset: 0xB9C280 VA: 0x180B9DC80
	public bool MoveToNextAttribute(ref int level) { }

	// RVA: 0xB9DF80 Offset: 0xB9C580 VA: 0x180B9DF80
	public bool MoveToParent() { }

	// RVA: 0xB9DC10 Offset: 0xB9C210 VA: 0x180B9DC10
	public bool MoveToFirstChild() { }

	// RVA: 0xB9DE90 Offset: 0xB9C490 VA: 0x180B9DE90
	private bool MoveToNextSibling(XmlNode node) { }

	// RVA: 0xB9DEF0 Offset: 0xB9C4F0 VA: 0x180B9DEF0
	public bool MoveToNext() { }

	// RVA: 0xB9DB70 Offset: 0xB9C170 VA: 0x180B9DB70
	public bool MoveToElement() { }

	// RVA: 0xB9CE30 Offset: 0xB9B430 VA: 0x180B9CE30
	public string LookupNamespace(string prefix) { }

	// RVA: 0xB9B5D0 Offset: 0xB99BD0 VA: 0x180B9B5D0
	internal string DefaultLookupNamespace(string prefix) { }

	// RVA: 0xB9D110 Offset: 0xB9B710 VA: 0x180B9D110
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0xB9C530 Offset: 0xB9AB30 VA: 0x180B9C530
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xB9DFF0 Offset: 0xB9C5F0 VA: 0x180B9DFF0
	public bool ReadAttributeValue(ref int level, ref bool bResolveEntity, ref XmlNodeType nt) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public XmlDocument get_Document() { }

}

internal struct XmlNodeReaderNavigator.VirtualAttribute // TypeDefIndex: 1975
{	// Fields
	internal string name; // 0x0
	internal string value; // 0x8

	// Methods

	// RVA: 0xF5A50 Offset: 0xF4E50 VA: 0x1800F5A50
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

	// RVA: 0x11CF8A0 Offset: 0x11CDEA0 VA: 0x1811CF8A0
	public void .ctor(XmlNode node) { }

	// RVA: 0x11CEB90 Offset: 0x11CD190 VA: 0x1811CEB90
	internal bool IsInReadingStates() { }

	// RVA: 0x11CFBA0 Offset: 0x11CE1A0 VA: 0x1811CFBA0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11CFAE0 Offset: 0x11CE0E0 VA: 0x1811CFAE0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x11CFA80 Offset: 0x11CE080 VA: 0x1811CFA80 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x11CFB40 Offset: 0x11CE140 VA: 0x1811CFB40 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x11CFBB0 Offset: 0x11CE1B0 VA: 0x1811CFBB0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x11CFC40 Offset: 0x11CE240 VA: 0x1811CFC40 Slot: 11
	public override string get_Value() { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x11CF9C0 Offset: 0x11CDFC0 VA: 0x1811CF9C0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x11CFA50 Offset: 0x11CE050 VA: 0x1811CFA50 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x11CFA20 Offset: 0x11CE020 VA: 0x1811CFA20 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x11CFD00 Offset: 0x11CE300 VA: 0x1811CFD00 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x11CFCA0 Offset: 0x11CE2A0 VA: 0x1811CFCA0 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x11CFC10 Offset: 0x11CE210 VA: 0x1811CFC10 Slot: 19
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11CF980 Offset: 0x11CDF80 VA: 0x1811CF980 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x11CEA40 Offset: 0x11CD040 VA: 0x1811CEA40 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x11CEA70 Offset: 0x11CD070 VA: 0x1811CEA70 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x11CEB00 Offset: 0x11CD100 VA: 0x1811CEB00 Slot: 24
	public override string GetAttribute(int attributeIndex) { }

	// RVA: 0x11CED80 Offset: 0x11CD380 VA: 0x1811CED80 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x11CEBE0 Offset: 0x11CD1E0 VA: 0x1811CEBE0 Slot: 26
	public override void MoveToAttribute(int attributeIndex) { }

	// RVA: 0x11CEF20 Offset: 0x11CD520 VA: 0x1811CEF20 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x11CF000 Offset: 0x11CD600 VA: 0x1811CF000 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x11CEE50 Offset: 0x11CD450 VA: 0x1811CEE50 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x11CF5C0 Offset: 0x11CDBC0 VA: 0x1811CF5C0 Slot: 31
	public override bool Read() { }

	// RVA: 0x11CF5D0 Offset: 0x11CDBD0 VA: 0x1811CF5D0
	private bool Read(bool fSkipChildren) { }

	// RVA: 0x11CF300 Offset: 0x11CD900 VA: 0x1811CF300
	private bool ReadNextNode(bool fSkipChildren) { }

	// RVA: 0x11CF7C0 Offset: 0x11CDDC0 VA: 0x1811CF7C0
	private void SetEndOfFile() { }

	// RVA: 0x11CF110 Offset: 0x11CD710 VA: 0x1811CF110
	private bool ReadAtZeroLevel(bool fSkipChildren) { }

	// RVA: 0x11CF1D0 Offset: 0x11CD7D0 VA: 0x1811CF1D0
	private bool ReadForward(bool fSkipChildren) { }

	// RVA: 0x11CF0E0 Offset: 0x11CD6E0 VA: 0x1811CF0E0
	private void ReSetReadingMarks() { }

	// RVA: 0x11CFA10 Offset: 0x11CE010 VA: 0x1811CFA10 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x11CEA00 Offset: 0x11CD000 VA: 0x1811CEA00 Slot: 33
	public override void Close() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x11CF7E0 Offset: 0x11CDDE0 VA: 0x1811CF7E0 Slot: 35
	public override void Skip() { }

	// RVA: 0x11CF510 Offset: 0x11CDB10 VA: 0x1811CF510 Slot: 42
	public override string ReadString() { }

	// RVA: 0xBA4460 Offset: 0xBA2A60 VA: 0x180BA4460 Slot: 49
	public override bool get_HasAttributes() { }

	// RVA: 0x6C81C0 Offset: 0x6C67C0 VA: 0x1806C81C0 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x11CEBA0 Offset: 0x11CD1A0 VA: 0x1811CEBA0 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x11CF730 Offset: 0x11CDD30 VA: 0x1811CF730 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x11CF180 Offset: 0x11CD780 VA: 0x1811CF180 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x11CEA10 Offset: 0x11CD010 VA: 0x1811CEA10
	private void FinishReadBinary() { }

	// RVA: 0x11CF7F0 Offset: 0x11CDDF0 VA: 0x1811CF7F0 Slot: 53
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11CF880 Offset: 0x11CDE80 VA: 0x1811CF880 Slot: 55
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x11CF810 Offset: 0x11CDE10 VA: 0x1811CF810 Slot: 54
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x11CF9E0 Offset: 0x11CDFE0 VA: 0x1811CF9E0 Slot: 52
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

	// RVA: 0xB9F570 Offset: 0xB9DB70 VA: 0x180B9F570
	internal void .ctor(string name, string publicId, string systemId, XmlDocument doc) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 6
	public override string get_Name() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xB9F620 Offset: 0xB9DC20 VA: 0x180B9F620 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xB9F500 Offset: 0xB9DB00 VA: 0x180B9F500 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0xB9F630 Offset: 0xB9DC30 VA: 0x180B9F630 Slot: 40
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

	// RVA: 0xB9FBB0 Offset: 0xB9E1B0 VA: 0x180B9FBB0
	protected internal void .ctor(string target, string data, XmlDocument doc) { }

	// RVA: 0xB9FC00 Offset: 0xB9E200 VA: 0x180B9FC00 Slot: 6
	public override string get_Name() { }

	// RVA: 0x95FA30 Offset: 0x95E030 VA: 0x18095FA30 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 7
	public override string get_Value() { }

	// RVA: 0xB9FD30 Offset: 0xB9E330 VA: 0x180B9FD30 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0xB9FC60 Offset: 0xB9E260 VA: 0x180B9FC60
	public void set_Data(string value) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0xB9FD30 Offset: 0xB9E330 VA: 0x180B9FD30 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0xB9FC50 Offset: 0xB9E250 VA: 0x180B9FC50 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xB9FB20 Offset: 0xB9E120 VA: 0x180B9FB20 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xB9FB70 Offset: 0xB9E170 VA: 0x180B9FB70 Slot: 43
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

	// RVA: 0xBA50B0 Offset: 0xBA36B0 VA: 0x180BA50B0
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0xBA5170 Offset: 0xBA3770 VA: 0x180BA5170 Slot: 6
	public override string get_Name() { }

	// RVA: 0xBA5170 Offset: 0xBA3770 VA: 0x180BA5170 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xBA51A0 Offset: 0xBA37A0 VA: 0x180BA51A0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBA51B0 Offset: 0xBA37B0 VA: 0x180BA51B0 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0xBA5010 Offset: 0xBA3610 VA: 0x180BA5010 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xBA5250 Offset: 0xBA3850 VA: 0x180BA5250 Slot: 7
	public override string get_Value() { }

	// RVA: 0xBA5270 Offset: 0xBA3870 VA: 0x180BA5270 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0xBA5070 Offset: 0xBA3670 VA: 0x180BA5070 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 55
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

	// RVA: 0xBC9390 Offset: 0xBC7990 VA: 0x180BC9390
	internal void .ctor(string strData) { }

	// RVA: 0xBC9380 Offset: 0xBC7980 VA: 0x180BC9380
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0xBC93A0 Offset: 0xBC79A0 VA: 0x180BC93A0 Slot: 6
	public override string get_Name() { }

	// RVA: 0xBC93A0 Offset: 0xBC79A0 VA: 0x180BC93A0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xAC2060 Offset: 0xAC0660 VA: 0x180AC2060 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC93D0 Offset: 0xBC79D0 VA: 0x180BC93D0 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0xBC9320 Offset: 0xBC7920 VA: 0x180BC9320 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xBA5250 Offset: 0xBA3850 VA: 0x180BA5250 Slot: 7
	public override string get_Value() { }

	// RVA: 0xBC9470 Offset: 0xBC7A70 VA: 0x180BC9470 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0xBA5070 Offset: 0xBA3670 VA: 0x180BA5070 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 55
	internal override bool get_IsText() { }

}

internal class XmlUnspecifiedAttribute : XmlAttribute // TypeDefIndex: 1981
{	// Fields
	private bool fSpecified; // 0x28

	// Properties
	public override bool Specified { get; }
	public override string InnerText { set; }

	// Methods

	// RVA: 0x131F8E0 Offset: 0x131DEE0 VA: 0x18131F8E0
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x9975F0 Offset: 0x995BF0 VA: 0x1809975F0 Slot: 56
	public override bool get_Specified() { }

	// RVA: 0x131F720 Offset: 0x131DD20 VA: 0x18131F720 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x131F8F0 Offset: 0x131DEF0 VA: 0x18131F8F0 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x131F890 Offset: 0x131DE90 VA: 0x18131F890 Slot: 21
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x131F870 Offset: 0x131DE70 VA: 0x18131F870 Slot: 22
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x131F8B0 Offset: 0x131DEB0 VA: 0x18131F8B0 Slot: 23
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x131F700 Offset: 0x131DD00 VA: 0x18131F700 Slot: 25
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x131F8D0 Offset: 0x131DED0 VA: 0x18131F8D0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x997600 Offset: 0x995C00 VA: 0x180997600
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

	// RVA: 0x132C690 Offset: 0x132AC90 VA: 0x18132C690
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x132C750 Offset: 0x132AD50 VA: 0x18132C750 Slot: 6
	public override string get_Name() { }

	// RVA: 0x132C750 Offset: 0x132AD50 VA: 0x18132C750 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x132C780 Offset: 0x132AD80 VA: 0x18132C780 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBA51B0 Offset: 0xBA37B0 VA: 0x180BA51B0 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0xBA5250 Offset: 0xBA3850 VA: 0x180BA5250 Slot: 7
	public override string get_Value() { }

	// RVA: 0x132C790 Offset: 0x132AD90 VA: 0x18132C790 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x132C5F0 Offset: 0x132ABF0 VA: 0x18132C5F0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x132C650 Offset: 0x132AC50 VA: 0x18132C650 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 55
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

	// RVA: 0xE591F0 Offset: 0xE577F0 VA: 0x180E591F0
	private static object get_StaticLock() { }

	// RVA: 0xE58910 Offset: 0xE56F10 VA: 0x180E58910
	private static void InitInstance() { }

	// RVA: 0xE59040 Offset: 0xE57640 VA: 0x180E59040
	private static void SetProperties(string ranges, byte value) { }

	// RVA: 0xF1490 Offset: 0xF0890 VA: 0x1800F1490
	private void .ctor(byte[] charProperties) { }

	// RVA: 0xE59170 Offset: 0xE57770 VA: 0x180E59170
	public static XmlCharType get_Instance() { }

	// RVA: 0x12C7A0 Offset: 0x12BBA0 VA: 0x18012C7A0
	public bool IsWhiteSpace(char ch) { }

	// RVA: 0x12C380 Offset: 0x12B780 VA: 0x18012C380
	public bool IsNCNameSingleChar(char ch) { }

	// RVA: 0x12C720 Offset: 0x12BB20 VA: 0x18012C720
	public bool IsStartNCNameSingleChar(char ch) { }

	// RVA: 0x12C410 Offset: 0x12B810 VA: 0x18012C410
	public bool IsNameSingleChar(char ch) { }

	// RVA: 0x12C2C0 Offset: 0x12B6C0 VA: 0x18012C2C0
	public bool IsCharData(char ch) { }

	// RVA: 0x12C650 Offset: 0x12BA50 VA: 0x18012C650
	public bool IsPubidChar(char ch) { }

	// RVA: 0x12C760 Offset: 0x12BB60 VA: 0x18012C760
	internal bool IsTextChar(char ch) { }

	// RVA: 0x12C300 Offset: 0x12B700 VA: 0x18012C300
	public bool IsLetter(char ch) { }

	// RVA: 0x12C340 Offset: 0x12B740 VA: 0x18012C340
	public bool IsNCNameCharXml4e(char ch) { }

	// RVA: 0x12C6D0 Offset: 0x12BAD0 VA: 0x18012C6D0
	public bool IsStartNCNameCharXml4e(char ch) { }

	// RVA: 0x12C3C0 Offset: 0x12B7C0 VA: 0x18012C3C0
	public bool IsNameCharXml4e(char ch) { }

	// RVA: 0xE58B70 Offset: 0xE57170 VA: 0x180E58B70
	public static bool IsDigit(char ch) { }

	// RVA: 0xE58B80 Offset: 0xE57180 VA: 0x180E58B80
	internal static bool IsHighSurrogate(int ch) { }

	// RVA: 0xE58B90 Offset: 0xE57190 VA: 0x180E58B90
	internal static bool IsLowSurrogate(int ch) { }

	// RVA: 0xE58FB0 Offset: 0xE575B0 VA: 0x180E58FB0
	internal static bool IsSurrogate(int ch) { }

	// RVA: 0xE588E0 Offset: 0xE56EE0 VA: 0x180E588E0
	internal static int CombineSurrogateChar(int lowChar, int highChar) { }

	// RVA: 0xE59130 Offset: 0xE57730 VA: 0x180E59130
	internal static void SplitSurrogateChar(int combinedChar, out char lowChar, out char highChar) { }

	// RVA: 0x12C5C0 Offset: 0x12B9C0 VA: 0x18012C5C0
	internal bool IsOnlyWhitespace(string str) { }

	// RVA: 0x12C530 Offset: 0x12B930 VA: 0x18012C530
	internal int IsOnlyWhitespaceWithPos(string str) { }

	// RVA: 0x12C460 Offset: 0x12B860 VA: 0x18012C460
	internal int IsOnlyCharData(string str) { }

	// RVA: 0xE58D90 Offset: 0xE57390 VA: 0x180E58D90
	internal static bool IsOnlyDigits(string str, int startPos, int len) { }

	// RVA: 0x12C660 Offset: 0x12BA60 VA: 0x18012C660
	internal int IsPublicId(string str) { }

	// RVA: 0xE58900 Offset: 0xE56F00 VA: 0x180E58900
	private static bool InRange(int value, int start, int end) { }

}

internal static class XmlComplianceUtil // TypeDefIndex: 2002
{	// Methods

	// RVA: 0xE59A80 Offset: 0xE58080 VA: 0x180E59A80
	public static string NonCDataNormalize(string value) { }

	// RVA: 0xE598D0 Offset: 0xE57ED0 VA: 0x180E598D0
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

	// RVA: 0xE5BF80 Offset: 0xE5A580 VA: 0x180E5BF80
	public static string EncodeName(string name) { }

	// RVA: 0xE5BF20 Offset: 0xE5A520 VA: 0x180E5BF20
	public static string EncodeLocalName(string name) { }

	// RVA: 0xE5B650 Offset: 0xE59C50 VA: 0x180E5B650
	public static string DecodeName(string name) { }

	// RVA: 0xE5BFE0 Offset: 0xE5A5E0 VA: 0x180E5BFE0
	private static string EncodeName(string name, bool first, bool local) { }

	// RVA: 0xE5CA30 Offset: 0xE5B030 VA: 0x180E5CA30
	private static int FromHex(char digit) { }

	// RVA: 0xE5C8F0 Offset: 0xE5AEF0 VA: 0x180E5C8F0
	internal static byte[] FromBinHexString(string s) { }

	// RVA: 0xE5C9A0 Offset: 0xE5AFA0 VA: 0x180E5C9A0
	internal static byte[] FromBinHexString(string s, bool allowOddCount) { }

	// RVA: 0xE5CCF0 Offset: 0xE5B2F0 VA: 0x180E5CCF0
	internal static string ToBinHexString(byte[] inArray) { }

	// RVA: 0xE613D0 Offset: 0xE5F9D0 VA: 0x180E613D0
	public static string VerifyName(string name) { }

	// RVA: 0xE60BD0 Offset: 0xE5F1D0 VA: 0x180E60BD0
	internal static Exception TryVerifyName(string name) { }

	// RVA: 0xE61500 Offset: 0xE5FB00 VA: 0x180E61500
	internal static string VerifyQName(string name, ExceptionType exceptionType) { }

	// RVA: 0xE61260 Offset: 0xE5F860 VA: 0x180E61260
	public static string VerifyNCName(string name) { }

	// RVA: 0xE61120 Offset: 0xE5F720 VA: 0x180E61120
	internal static string VerifyNCName(string name, ExceptionType exceptionType) { }

	// RVA: 0xE60910 Offset: 0xE5EF10 VA: 0x180E60910
	internal static Exception TryVerifyNCName(string name) { }

	// RVA: 0xE616C0 Offset: 0xE5FCC0 VA: 0x180E616C0
	public static string VerifyTOKEN(string token) { }

	// RVA: 0xE60DB0 Offset: 0xE5F3B0 VA: 0x180E60DB0
	internal static Exception TryVerifyTOKEN(string token) { }

	// RVA: 0xE60A00 Offset: 0xE5F000 VA: 0x180E60A00
	internal static Exception TryVerifyNMTOKEN(string name) { }

	// RVA: 0xE60CF0 Offset: 0xE5F2F0 VA: 0x180E60CF0
	internal static Exception TryVerifyNormalizedString(string str) { }

	// RVA: 0xE5E000 Offset: 0xE5C600 VA: 0x180E5E000
	public static string ToString(bool value) { }

	// RVA: 0xE5DAD0 Offset: 0xE5C0D0 VA: 0x180E5DAD0
	public static string ToString(char value) { }

	// RVA: 0xE5E0D0 Offset: 0xE5C6D0 VA: 0x180E5E0D0
	public static string ToString(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE5E170 Offset: 0xE5C770 VA: 0x180E5E170
	public static string ToString(sbyte value) { }

	// RVA: 0xE5E100 Offset: 0xE5C700 VA: 0x180E5E100
	public static string ToString(short value) { }

	// RVA: 0xE5DED0 Offset: 0xE5C4D0 VA: 0x180E5DED0
	public static string ToString(int value) { }

	// RVA: 0xE5E040 Offset: 0xE5C640 VA: 0x180E5E040
	public static string ToString(long value) { }

	// RVA: 0xE5DEA0 Offset: 0xE5C4A0 VA: 0x180E5DEA0
	public static string ToString(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE5DE60 Offset: 0xE5C460 VA: 0x180E5DE60
	public static string ToString(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE5DF00 Offset: 0xE5C500 VA: 0x180E5DF00
	public static string ToString(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE5DAA0 Offset: 0xE5C0A0 VA: 0x180E5DAA0
	public static string ToString(ulong value) { }

	// RVA: 0xE5DF30 Offset: 0xE5C530 VA: 0x180E5DF30
	public static string ToString(float value) { }

	// RVA: 0xE5DB60 Offset: 0xE5C160 VA: 0x180E5DB60
	public static string ToString(double value) { }

	// RVA: 0xE5E070 Offset: 0xE5C670 VA: 0x180E5E070
	public static string ToString(TimeSpan value) { }

	// RVA: 0xE5DAF0 Offset: 0xE5C0F0 VA: 0x180E5DAF0
	public static string ToString(DateTime value, string format) { }

	// RVA: 0xE5DC90 Offset: 0xE5C290 VA: 0x180E5DC90
	public static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0xE5E130 Offset: 0xE5C730 VA: 0x180E5E130
	public static string ToString(DateTimeOffset value) { }

	// RVA: 0xE5DE90 Offset: 0xE5C490 VA: 0x180E5DE90
	public static string ToString(Guid value) { }

	// RVA: 0xE5CD60 Offset: 0xE5B360 VA: 0x180E5CD60
	public static bool ToBoolean(string s) { }

	// RVA: 0xE5E9D0 Offset: 0xE5CFD0 VA: 0x180E5E9D0
	internal static Exception TryToBoolean(string s, out bool result) { }

	// RVA: 0xE5CF60 Offset: 0xE5B560 VA: 0x180E5CF60
	public static char ToChar(string s) { }

	// RVA: 0xE5EDB0 Offset: 0xE5D3B0 VA: 0x180E5EDB0
	internal static Exception TryToChar(string s, out char result) { }

	// RVA: 0xE5D550 Offset: 0xE5BB50 VA: 0x180E5D550
	public static Decimal ToDecimal(string s) { }

	// RVA: 0xE5EF40 Offset: 0xE5D540 VA: 0x180E5EF40
	internal static Exception TryToDecimal(string s, out Decimal result) { }

	// RVA: 0xE5D850 Offset: 0xE5BE50 VA: 0x180E5D850
	internal static Decimal ToInteger(string s) { }

	// RVA: 0xE5FAF0 Offset: 0xE5E0F0 VA: 0x180E5FAF0
	internal static Exception TryToInteger(string s, out Decimal result) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE5D8E0 Offset: 0xE5BEE0 VA: 0x180E5D8E0
	public static sbyte ToSByte(string s) { }

	// RVA: 0xE5FCA0 Offset: 0xE5E2A0 VA: 0x180E5FCA0
	internal static Exception TryToSByte(string s, out sbyte result) { }

	// RVA: 0xE5D7C0 Offset: 0xE5BDC0 VA: 0x180E5D7C0
	public static short ToInt16(string s) { }

	// RVA: 0xE5F670 Offset: 0xE5DC70 VA: 0x180E5F670
	internal static Exception TryToInt16(string s, out short result) { }

	// RVA: 0xE5D7F0 Offset: 0xE5BDF0 VA: 0x180E5D7F0
	public static int ToInt32(string s) { }

	// RVA: 0xE5F7F0 Offset: 0xE5DDF0 VA: 0x180E5F7F0
	internal static Exception TryToInt32(string s, out int result) { }

	// RVA: 0xE5D820 Offset: 0xE5BE20 VA: 0x180E5D820
	public static long ToInt64(string s) { }

	// RVA: 0xE5F970 Offset: 0xE5DF70 VA: 0x180E5F970
	internal static Exception TryToInt64(string s, out long result) { }

	// RVA: 0xE5CF30 Offset: 0xE5B530 VA: 0x180E5CF30
	public static byte ToByte(string s) { }

	// RVA: 0xE5EC30 Offset: 0xE5D230 VA: 0x180E5EC30
	internal static Exception TryToByte(string s, out byte result) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE5E2E0 Offset: 0xE5C8E0 VA: 0x180E5E2E0
	public static ushort ToUInt16(string s) { }

	// RVA: 0xE60170 Offset: 0xE5E770 VA: 0x180E60170
	internal static Exception TryToUInt16(string s, out ushort result) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE5E310 Offset: 0xE5C910 VA: 0x180E5E310
	public static uint ToUInt32(string s) { }

	// RVA: 0xE602F0 Offset: 0xE5E8F0 VA: 0x180E602F0
	internal static Exception TryToUInt32(string s, out uint result) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE5E340 Offset: 0xE5C940 VA: 0x180E5E340
	public static ulong ToUInt64(string s) { }

	// RVA: 0xE60470 Offset: 0xE5EA70 VA: 0x180E60470
	internal static Exception TryToUInt64(string s, out ulong result) { }

	// RVA: 0xE5D910 Offset: 0xE5BF10 VA: 0x180E5D910
	public static float ToSingle(string s) { }

	// RVA: 0xE5FE20 Offset: 0xE5E420 VA: 0x180E5FE20
	internal static Exception TryToSingle(string s, out float result) { }

	// RVA: 0xE5D5E0 Offset: 0xE5BBE0 VA: 0x180E5D5E0
	public static double ToDouble(string s) { }

	// RVA: 0xE5F0F0 Offset: 0xE5D6F0 VA: 0x180E5F0F0
	internal static Exception TryToDouble(string s, out double result) { }

	// RVA: 0xE5E600 Offset: 0xE5CC00 VA: 0x180E5E600
	internal static double ToXPathDouble(object o) { }

	// RVA: 0xE5E1A0 Offset: 0xE5C7A0 VA: 0x180E5E1A0
	public static TimeSpan ToTimeSpan(string s) { }

	// RVA: 0xE600B0 Offset: 0xE5E6B0 VA: 0x180E600B0
	internal static Exception TryToTimeSpan(string s, out TimeSpan result) { }

	// RVA: 0xE618B0 Offset: 0xE5FEB0 VA: 0x180E618B0
	private static string[] get_AllDateTimeFormats() { }

	// RVA: 0xE59D70 Offset: 0xE58370 VA: 0x180E59D70
	private static void CreateAllDateTimeFormats() { }

	[ObsoleteAttribute] // RVA: 0x83AA0 Offset: 0x82EA0 VA: 0x180083AA0
	// RVA: 0xE5D300 Offset: 0xE5B900 VA: 0x180E5D300
	public static DateTime ToDateTime(string s) { }

	// RVA: 0xE5D4A0 Offset: 0xE5BAA0 VA: 0x180E5D4A0
	public static DateTime ToDateTime(string s, string[] formats) { }

	// RVA: 0xE5D0F0 Offset: 0xE5B6F0 VA: 0x180E5D0F0
	public static DateTime ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0xE5D020 Offset: 0xE5B620 VA: 0x180E5D020
	public static DateTimeOffset ToDateTimeOffset(string s) { }

	// RVA: 0xE5D7A0 Offset: 0xE5BDA0 VA: 0x180E5D7A0
	public static Guid ToGuid(string s) { }

	// RVA: 0xE5F3D0 Offset: 0xE5D9D0 VA: 0x180E5F3D0
	internal static Exception TryToGuid(string s, out Guid result) { }

	// RVA: 0xE5CC00 Offset: 0xE5B200 VA: 0x180E5CC00
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0xE5CC70 Offset: 0xE5B270 VA: 0x180E5CC70
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0xE5E370 Offset: 0xE5C970 VA: 0x180E5E370
	internal static Uri ToUri(string s) { }

	// RVA: 0xE605F0 Offset: 0xE5EBF0 VA: 0x180E605F0
	internal static Exception TryToUri(string s, out Uri result) { }

	// RVA: 0xE5CB60 Offset: 0xE5B160 VA: 0x180E5CB60
	internal static bool StrEqual(char[] chars, int strPos1, int strLen1, string str2) { }

	// RVA: 0xE5E950 Offset: 0xE5CF50 VA: 0x180E5E950
	internal static string TrimString(string value) { }

	// RVA: 0xE5E8D0 Offset: 0xE5CED0 VA: 0x180E5E8D0
	internal static string TrimStringStart(string value) { }

	// RVA: 0xE5E850 Offset: 0xE5CE50 VA: 0x180E5E850
	internal static string TrimStringEnd(string value) { }

	// RVA: 0xE5CAE0 Offset: 0xE5B0E0 VA: 0x180E5CAE0
	internal static string[] SplitString(string value) { }

	// RVA: 0xE5CA60 Offset: 0xE5B060 VA: 0x180E5CA60
	internal static bool IsNegativeZero(double value) { }

	// RVA: 0xE5BF10 Offset: 0xE5A510 VA: 0x180E5BF10
	private static long DoubleToInt64Bits(double value) { }

	// RVA: 0xE60EB0 Offset: 0xE5F4B0 VA: 0x180E60EB0
	internal static void VerifyCharData(string data, ExceptionType invCharExceptionType, ExceptionType invSurrogateExceptionType) { }

	// RVA: 0xE5A7D0 Offset: 0xE58DD0 VA: 0x180E5A7D0
	internal static Exception CreateException(string res, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0xE5A8A0 Offset: 0xE58EA0 VA: 0x180E5A8A0
	internal static Exception CreateException(string res, string arg, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0xE5AAA0 Offset: 0xE590A0 VA: 0x180E5AAA0
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType) { }

	// RVA: 0xE5A9E0 Offset: 0xE58FE0 VA: 0x180E5A9E0
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0xE5B350 Offset: 0xE59950 VA: 0x180E5B350
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi) { }

	// RVA: 0xE5B400 Offset: 0xE59A00 VA: 0x180E5B400
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType) { }

	// RVA: 0xE5B480 Offset: 0xE59A80 VA: 0x180E5B480
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0xE5AFD0 Offset: 0xE595D0 VA: 0x180E5AFD0
	internal static Exception CreateInvalidHighSurrogateCharException(char hi) { }

	// RVA: 0xE5ADE0 Offset: 0xE593E0 VA: 0x180E5ADE0
	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType) { }

	// RVA: 0xE5B030 Offset: 0xE59630 VA: 0x180E5B030
	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0xE5AD40 Offset: 0xE59340 VA: 0x180E5AD40
	internal static Exception CreateInvalidCharException(string data, int invCharPos, ExceptionType exceptionType) { }

	// RVA: 0xE5AB20 Offset: 0xE59120 VA: 0x180E5AB20
	internal static Exception CreateInvalidCharException(char invChar, char nextChar) { }

	// RVA: 0xE5AC60 Offset: 0xE59260 VA: 0x180E5AC60
	internal static Exception CreateInvalidCharException(char invChar, char nextChar, ExceptionType exceptionType) { }

	// RVA: 0xE5B2A0 Offset: 0xE598A0 VA: 0x180E5B2A0
	internal static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType) { }

	// RVA: 0xE5B1F0 Offset: 0xE597F0 VA: 0x180E5B1F0
	internal static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName) { }

	// RVA: 0xE617D0 Offset: 0xE5FDD0 VA: 0x180E617D0
	private static void .cctor() { }

}

internal class XmlDownloadManager // TypeDefIndex: 2006
{	// Fields
	private Hashtable connections; // 0x10

	// Methods

	// RVA: 0x11BBEB0 Offset: 0x11BA4B0 VA: 0x1811BBEB0
	internal Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x11BB800 Offset: 0x11B9E00 VA: 0x1811BB800
	private Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x11BBFB0 Offset: 0x11BA5B0 VA: 0x1811BBFB0
	internal void Remove(string host) { }

	// RVA: 0x11BBC60 Offset: 0x11BA260 VA: 0x1811BBC60
	internal Task<Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	[AsyncStateMachineAttribute] // RVA: 0x83C40 Offset: 0x83040 VA: 0x180083C40
	// RVA: 0x11BB6A0 Offset: 0x11B9CA0 VA: 0x1811BB6A0
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

	// RVA: 0x11BABD0 Offset: 0x11B91D0 VA: 0x1811BABD0
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

	// RVA: 0x1D0D10 Offset: 0x1D0110 VA: 0x1801D0D10 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D0D20 Offset: 0x1D0120 VA: 0x1801D0D20 Slot: 5
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

	// RVA: 0xBA4AF0 Offset: 0xBA30F0 VA: 0x180BA4AF0
	internal void .ctor(Stream stream, XmlDownloadManager downloadManager, string host) { }

	// RVA: 0xBA48F0 Offset: 0xBA2EF0 VA: 0x180BA48F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0xBA4750 Offset: 0xBA2D50 VA: 0x180BA4750 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0xBA46F0 Offset: 0xBA2CF0 VA: 0x180BA46F0 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0xBA4720 Offset: 0xBA2D20 VA: 0x180BA4720 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0xBA4890 Offset: 0xBA2E90 VA: 0x180BA4890 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0xBA48C0 Offset: 0xBA2EC0 VA: 0x180BA48C0 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0xBA49A0 Offset: 0xBA2FA0 VA: 0x180BA49A0 Slot: 18
	public override void Flush() { }

	// RVA: 0xBA4A00 Offset: 0xBA3000 VA: 0x180BA4A00 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0xBA49D0 Offset: 0xBA2FD0 VA: 0x180BA49D0 Slot: 28
	public override int ReadByte() { }

	// RVA: 0xBA4A30 Offset: 0xBA3030 VA: 0x180BA4A30 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xBA4A60 Offset: 0xBA3060 VA: 0x180BA4A60 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0xBA4AC0 Offset: 0xBA30C0 VA: 0x180BA4AC0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0xBA4A90 Offset: 0xBA3090 VA: 0x180BA4A90 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0xBA4BA0 Offset: 0xBA31A0 VA: 0x180BA4BA0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0xBA4BD0 Offset: 0xBA31D0 VA: 0x180BA4BD0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0xBA4C00 Offset: 0xBA3200 VA: 0x180BA4C00 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0xBA4C30 Offset: 0xBA3230 VA: 0x180BA4C30 Slot: 10
	public override long get_Length() { }

	// RVA: 0xBA4C60 Offset: 0xBA3260 VA: 0x180BA4C60 Slot: 11
	public override long get_Position() { }

	// RVA: 0xBA4C90 Offset: 0xBA3290 VA: 0x180BA4C90 Slot: 12
	public override void set_Position(long value) { }

}

internal class XmlCachedStream : MemoryStream // TypeDefIndex: 2011
{	// Fields
	private Uri uri; // 0x50

	// Methods

	// RVA: 0xE58780 Offset: 0xE56D80 VA: 0x180E58780
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

	// RVA: 0x11C6AC0 Offset: 0x11C50C0 VA: 0x1811C6AC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11C5F10 Offset: 0x11C4510 VA: 0x1811C5F10 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11C65C0 Offset: 0x11C4BC0 VA: 0x1811C65C0
	public void .ctor() { }

	// RVA: 0x11C66D0 Offset: 0x11C4CD0 VA: 0x1811C66D0
	public void .ctor(string message) { }

	// RVA: 0x11C6FA0 Offset: 0x11C55A0 VA: 0x1811C6FA0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x11C6A90 Offset: 0x11C5090 VA: 0x1811C6A90
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x11C62B0 Offset: 0x11C48B0 VA: 0x1811C62B0
	internal void .ctor(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11C68D0 Offset: 0x11C4ED0 VA: 0x1811C68D0
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x11C6E80 Offset: 0x11C5480 VA: 0x1811C6E80
	internal void .ctor(string res, string arg) { }

	// RVA: 0x11C6020 Offset: 0x11C4620 VA: 0x1811C6020
	internal void .ctor(string res, string arg, string sourceUri) { }

	// RVA: 0x11C6900 Offset: 0x11C4F00 VA: 0x1811C6900
	internal void .ctor(string res, string arg, IXmlLineInfo lineInfo) { }

	// RVA: 0x11C61E0 Offset: 0x11C47E0 VA: 0x1811C61E0
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo) { }

	// RVA: 0x11C6110 Offset: 0x11C4710 VA: 0x1811C6110
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo, string sourceUri) { }

	// RVA: 0x11C64C0 Offset: 0x11C4AC0 VA: 0x1811C64C0
	internal void .ctor(string res, string arg, int lineNumber, int linePosition) { }

	// RVA: 0x11C67D0 Offset: 0x11C4DD0 VA: 0x1811C67D0
	internal void .ctor(string res, string arg, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11C6FD0 Offset: 0x11C55D0 VA: 0x1811C6FD0
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x11C6F60 Offset: 0x11C5560 VA: 0x1811C6F60
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11C6A60 Offset: 0x11C5060 VA: 0x1811C6A60
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x11C6700 Offset: 0x11C4D00 VA: 0x1811C6700
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11C5DE0 Offset: 0x11C43E0 VA: 0x1811C5DE0
	private static string FormatUserMessage(string message, int lineNumber, int linePosition) { }

	// RVA: 0x11C5BC0 Offset: 0x11C41C0 VA: 0x1811C5BC0
	private static string CreateMessage(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x11C5730 Offset: 0x11C3D30 VA: 0x1811C5730
	internal static string[] BuildCharExceptionArgs(string data, int invCharIndex) { }

	// RVA: 0x11C5790 Offset: 0x11C3D90 VA: 0x1811C5790
	internal static string[] BuildCharExceptionArgs(char[] data, int length, int invCharIndex) { }

	// RVA: 0x11C5810 Offset: 0x11C3E10 VA: 0x1811C5810
	internal static string[] BuildCharExceptionArgs(char invChar, char nextChar) { }

	// RVA: 0xB9B530 Offset: 0xB99B30 VA: 0x180B9B530
	public int get_LineNumber() { }

	// RVA: 0xB9B540 Offset: 0xB99B40 VA: 0x180B9B540
	public int get_LinePosition() { }

	// RVA: 0x11C7000 Offset: 0x11C5600 VA: 0x1811C7000 Slot: 5
	public override string get_Message() { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
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

	// RVA: 0x11CE630 Offset: 0x11CCC30 VA: 0x1811CE630
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 8
	public virtual XmlNameTable get_NameTable() { }

	// RVA: 0x11CE8A0 Offset: 0x11CCEA0 VA: 0x1811CE8A0 Slot: 9
	public virtual string get_DefaultNamespace() { }

	// RVA: 0xEAE200 Offset: 0xEAC800 VA: 0x180EAE200 Slot: 10
	public virtual void PushScope() { }

	// RVA: 0x11CE380 Offset: 0x11CC980 VA: 0x1811CE380 Slot: 11
	public virtual bool PopScope() { }

	// RVA: 0x11CD9A0 Offset: 0x11CBFA0 VA: 0x1811CD9A0 Slot: 12
	public virtual void AddNamespace(string prefix, string uri) { }

	// RVA: 0x11CE480 Offset: 0x11CCA80 VA: 0x1811CE480 Slot: 13
	public virtual void RemoveNamespace(string prefix, string uri) { }

	// RVA: 0x11CDDB0 Offset: 0x11CC3B0 VA: 0x1811CDDB0 Slot: 14
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x11CDEE0 Offset: 0x11CC4E0 VA: 0x1811CDEE0 Slot: 15
	public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11CE240 Offset: 0x11CC840 VA: 0x1811CE240 Slot: 16
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0x11CE070 Offset: 0x11CC670 VA: 0x1811CE070
	private int LookupNamespaceDecl(string prefix) { }

	// RVA: 0x11CE2A0 Offset: 0x11CC8A0 VA: 0x1811CE2A0 Slot: 17
	public virtual string LookupPrefix(string uri) { }

}

private struct XmlNamespaceManager.NamespaceDeclaration // TypeDefIndex: 2028
{	// Fields
	public string prefix; // 0x0
	public string uri; // 0x8
	public int scopeId; // 0x10
	public int previousNsIndex; // 0x14

	// Methods

	// RVA: 0x1D0AC0 Offset: 0x1CFEC0 VA: 0x1801D0AC0
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

	// RVA: 0xBA0950 Offset: 0xB9EF50 VA: 0x180BA0950
	public void .ctor() { }

	// RVA: 0xBA0880 Offset: 0xB9EE80 VA: 0x180BA0880
	public void .ctor(string name) { }

	// RVA: 0xBA07D0 Offset: 0xB9EDD0 VA: 0x180BA07D0
	public void .ctor(string name, string ns) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Namespace() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Name() { }

	// RVA: 0xBA0100 Offset: 0xB9E700 VA: 0x180BA0100 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xBA0A10 Offset: 0xB9F010 VA: 0x180BA0A10
	public bool get_IsEmpty() { }

	// RVA: 0xBA0590 Offset: 0xB9EB90 VA: 0x180BA0590 Slot: 3
	public override string ToString() { }

	// RVA: 0xB9FE40 Offset: 0xB9E440 VA: 0x180B9FE40 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xBA0A50 Offset: 0xB9F050 VA: 0x180BA0A50
	public static bool op_Equality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0xBA0AC0 Offset: 0xB9F0C0 VA: 0x180BA0AC0
	public static bool op_Inequality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0xBA0520 Offset: 0xB9EB20 VA: 0x180BA0520
	public static string ToString(string name, string ns) { }

	// RVA: 0xB9FF70 Offset: 0xB9E570 VA: 0x180B9FF70
	private static XmlQualifiedName.HashCodeOfStringDelegate GetHashCodeDelegate() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private static bool IsRandomizedHashingDisabled() { }

	// RVA: 0xBA00D0 Offset: 0xB9E6D0 VA: 0x180BA00D0
	private static int GetHashCodeOfString(string s, int length, long additionalEntropy) { }

	// RVA: 0xBA0350 Offset: 0xB9E950 VA: 0x180BA0350
	internal void Init(string name, string ns) { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	internal void SetNamespace(string ns) { }

	// RVA: 0xBA05F0 Offset: 0xB9EBF0 VA: 0x180BA05F0
	internal void Verify() { }

	// RVA: 0xB9FD40 Offset: 0xB9E340 VA: 0x180B9FD40
	internal void Atomize(XmlNameTable nameTable) { }

	// RVA: 0xBA0390 Offset: 0xB9E990 VA: 0x180BA0390
	internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, out string prefix) { }

	// RVA: 0xB9FDC0 Offset: 0xB9E3C0 VA: 0x180B9FDC0
	internal XmlQualifiedName Clone() { }

	// RVA: 0xBA0690 Offset: 0xB9EC90 VA: 0x180BA0690
	private static void .cctor() { }

}

private sealed class XmlQualifiedName.HashCodeOfStringDelegate : MulticastDelegate // TypeDefIndex: 2031
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xB9AA00 Offset: 0xB99000 VA: 0x180B9AA00 Slot: 12
	public virtual int Invoke(string s, int sLen, long additionalEntropy) { }

	// RVA: 0xB9A930 Offset: 0xB98F30 VA: 0x180B9A930 Slot: 13
	public virtual IAsyncResult BeginInvoke(string s, int sLen, long additionalEntropy, AsyncCallback callback, object object) { }

	// RVA: 0xB9A9D0 Offset: 0xB98FD0 VA: 0x180B9A9D0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

public abstract class XmlResolver // TypeDefIndex: 2032
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn);

	// RVA: 0xBA4D10 Offset: 0xBA3310 VA: 0x180BA4D10 Slot: 5
	public virtual Uri ResolveUri(Uri baseUri, string relativeUri) { }

	// RVA: 0xBA4EF0 Offset: 0xBA34F0 VA: 0x180BA4EF0 Slot: 6
	public virtual bool SupportsType(Uri absoluteUri, Type type) { }

	// RVA: 0xBA4CC0 Offset: 0xBA32C0 VA: 0x180BA4CC0 Slot: 7
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

	// RVA: 0x131FBF0 Offset: 0x131E1F0 VA: 0x18131FBF0
	private static XmlDownloadManager get_DownloadManager() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0x131FA50 Offset: 0x131E050 VA: 0x18131FA50 Slot: 4
	public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x131FBE0 Offset: 0x131E1E0 VA: 0x18131FBE0 Slot: 5
	public override Uri ResolveUri(Uri baseUri, string relativeUri) { }

	[AsyncStateMachineAttribute] // RVA: 0x84090 Offset: 0x83490 VA: 0x180084090
	// RVA: 0x131F910 Offset: 0x131DF10 VA: 0x18131F910 Slot: 7
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

	// RVA: 0x1E1290 Offset: 0x1E0690 VA: 0x1801E1290 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1E12A0 Offset: 0x1E06A0 VA: 0x1801E12A0 Slot: 5
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

	// RVA: 0x9975F0 Offset: 0x995BF0 VA: 0x1809975F0
	internal bool get_HasLineInfo() { }

	// RVA: 0xE505F0 Offset: 0xE4EBF0 VA: 0x180E505F0
	internal int GetXmlNamespaceNode(out XPathNode[] pageXmlNmsp) { }

	// RVA: 0xE50620 Offset: 0xE4EC20 VA: 0x180E50620
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

	// RVA: 0xE50E20 Offset: 0xE4F420 VA: 0x180E50E20
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE50B00 Offset: 0xE4F100 VA: 0x180E50B00 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE50D20 Offset: 0xE4F320 VA: 0x180E50D20
	public void .ctor() { }

	// RVA: 0xE50C40 Offset: 0xE4F240 VA: 0x180E50C40
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0xE508E0 Offset: 0xE4EEE0 VA: 0x180E508E0
	internal static XPathException Create(string res) { }

	// RVA: 0xE507C0 Offset: 0xE4EDC0 VA: 0x180E507C0
	internal static XPathException Create(string res, string arg) { }

	// RVA: 0xE50980 Offset: 0xE4EF80 VA: 0x180E50980
	internal static XPathException Create(string res, string arg, string arg2) { }

	// RVA: 0xE51060 Offset: 0xE4F660 VA: 0x180E51060
	private void .ctor(string res, string[] args) { }

	// RVA: 0xE50BC0 Offset: 0xE4F1C0 VA: 0x180E50BC0
	private void .ctor(string res, string[] args, Exception inner) { }

	// RVA: 0xE50720 Offset: 0xE4ED20 VA: 0x180E50720
	private static string CreateMessage(string res, string[] args) { }

	// RVA: 0xE510E0 Offset: 0xE4F6E0 VA: 0x180E510E0 Slot: 5
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

	// RVA: 0xE51100 Offset: 0xE4F700 VA: 0x180E51100 Slot: 13
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

	// RVA: 0x95F940 Offset: 0x95DF40 VA: 0x18095F940 Slot: 3
	public override string ToString() { }

	// RVA: 0xE529F0 Offset: 0xE50FF0 VA: 0x180E529F0 Slot: 4
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0xE51DB0 Offset: 0xE503B0 VA: 0x180E51DB0 Slot: 6
	public override object get_TypedValue() { }

	// RVA: 0xE52910 Offset: 0xE50F10 VA: 0x180E52910 Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0xE51FB0 Offset: 0xE505B0 VA: 0x180E51FB0 Slot: 8
	public override bool get_ValueAsBoolean() { }

	// RVA: 0xE52190 Offset: 0xE50790 VA: 0x180E52190 Slot: 9
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0xE52370 Offset: 0xE50970 VA: 0x180E52370 Slot: 10
	public override double get_ValueAsDouble() { }

	// RVA: 0xE52550 Offset: 0xE50B50 VA: 0x180E52550 Slot: 11
	public override int get_ValueAsInt() { }

	// RVA: 0xE52730 Offset: 0xE50D30 VA: 0x180E52730 Slot: 12
	public override long get_ValueAsLong() { }

	// RVA: 0xE51A20 Offset: 0xE50020 VA: 0x180E51A20 Slot: 14
	public override object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xE51A00 Offset: 0xE50000 VA: 0x180E51A00 Slot: 15
	private object System.ICloneable.Clone() { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract XmlNameTable get_NameTable();

	// RVA: 0xE515E0 Offset: 0xE4FBE0 VA: 0x180E515E0 Slot: 20
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0xE51760 Offset: 0xE4FD60 VA: 0x180E51760 Slot: 21
	public virtual string LookupPrefix(string namespaceURI) { }

	// RVA: 0xE51400 Offset: 0xE4FA00 VA: 0x180E51400 Slot: 22
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

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 28
	public virtual object get_UnderlyingObject() { }

	// RVA: 0xE51960 Offset: 0xE4FF60 VA: 0x180E51960 Slot: 29
	public virtual bool MoveToNamespace(string name) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract bool MoveToParent();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract bool IsSamePosition(XPathNavigator other);

	// RVA: 0xE51D70 Offset: 0xE50370 VA: 0x180E51D70 Slot: 34
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xE515D0 Offset: 0xE4FBD0 VA: 0x180E515D0
	internal static bool IsText(XPathNodeType type) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0xE51C40 Offset: 0xE50240 VA: 0x180E51C40
	private static void .cctor() { }

}

internal class XPathNavigatorKeyComparer : IEqualityComparer // TypeDefIndex: 2042
{	// Methods

	// RVA: 0xE51120 Offset: 0xE4F720 VA: 0x180E51120 Slot: 4
	private bool System.Collections.IEqualityComparer.Equals(object obj1, object obj2) { }

	// RVA: 0xE51200 Offset: 0xE4F800 VA: 0x180E51200 Slot: 5
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

	// RVA: 0xE671A0 Offset: 0xE657A0 VA: 0x180E671A0
	public void Add(string prefix, string ns) { }

	// RVA: 0xE670F0 Offset: 0xE656F0 VA: 0x180E670F0
	internal void AddInternal(string prefix, string ns) { }

	// RVA: 0xE673F0 Offset: 0xE659F0 VA: 0x180E673F0
	public XmlQualifiedName[] ToArray() { }

	// RVA: 0xE674E0 Offset: 0xE65AE0 VA: 0x180E674E0
	public int get_Count() { }

	// RVA: 0xE67570 Offset: 0xE65B70 VA: 0x180E67570
	internal ArrayList get_NamespaceList() { }

	// RVA: 0xE67890 Offset: 0xE65E90 VA: 0x180E67890
	internal Hashtable get_Namespaces() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	internal void set_Namespaces(Hashtable value) { }

}

public sealed class XmlAttributeEventHandler : MulticastDelegate // TypeDefIndex: 2046
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4880 Offset: 0xAE2E80 VA: 0x180AE4880 Slot: 12
	public virtual void Invoke(object sender, XmlAttributeEventArgs e) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
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

	// RVA: 0x110CAF0 Offset: 0x110B0F0 VA: 0x18110CAF0
	internal void .ctor(XmlAttribute attr, int lineNumber, int linePosition, object o, string qnames) { }

}

public sealed class XmlElementEventHandler : MulticastDelegate // TypeDefIndex: 2048
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4880 Offset: 0xAE2E80 VA: 0x180AE4880 Slot: 12
	public virtual void Invoke(object sender, XmlElementEventArgs e) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
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

	// RVA: 0x16883F0 Offset: 0x16869F0 VA: 0x1816883F0
	internal void .ctor(XmlElement elem, int lineNumber, int linePosition, object o, string qnames) { }

}

public sealed class XmlNodeEventHandler : MulticastDelegate // TypeDefIndex: 2050
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4880 Offset: 0xAE2E80 VA: 0x180AE4880 Slot: 12
	public virtual void Invoke(object sender, XmlNodeEventArgs e) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
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

	// RVA: 0x1688590 Offset: 0x1686B90 VA: 0x181688590
	internal void .ctor(XmlNode xmlNode, int lineNumber, int linePosition, object o) { }

}

internal class XmlTypeSerializationSource : SerializationSource // TypeDefIndex: 2060
{	// Fields
	private string attributeOverridesHash; // 0x28
	private Type type; // 0x30
	private string rootHash; // 0x38

	// Methods

	// RVA: 0xE6B8C0 Offset: 0xE69EC0 VA: 0x180E6B8C0
	public void .ctor(Type type, XmlRootAttribute root, XmlAttributeOverrides attributeOverrides, string namspace, Type[] includedTypes) { }

	// RVA: 0xE6B790 Offset: 0xE69D90 VA: 0x180E6B790 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0xE6B890 Offset: 0xE69E90 VA: 0x180E6B890 Slot: 2
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
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Method() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	private void set_Method(string value) { }

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
	public void .ctor(string method) { }

}

public class XmlAnyAttributeAttribute : Attribute // TypeDefIndex: 2065
{	// Methods

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
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

	// RVA: 0x110B4F0 Offset: 0x1109AF0 VA: 0x18110B4F0
	public void .ctor() { }

	// RVA: 0x110B500 Offset: 0x1109B00 VA: 0x18110B500
	public string get_Name() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Namespace() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public int get_Order() { }

	// RVA: 0x110B300 Offset: 0x1109900 VA: 0x18110B300
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlAnyElementAttributes : CollectionBase // TypeDefIndex: 2067
{	// Properties
	public XmlAnyElementAttribute Item { get; }
	internal int Order { get; }

	// Methods

	// RVA: 0x110B710 Offset: 0x1109D10 VA: 0x18110B710
	public XmlAnyElementAttribute get_Item(int index) { }

	// RVA: 0x110B6A0 Offset: 0x1109CA0 VA: 0x18110B6A0
	public int Add(XmlAnyElementAttribute attribute) { }

	// RVA: 0x110B550 Offset: 0x1109B50 VA: 0x18110B550
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x110B7C0 Offset: 0x1109DC0 VA: 0x18110B7C0
	internal int get_Order() { }

	// RVA: 0x105CF40 Offset: 0x105B540 VA: 0x18105CF40
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

	// RVA: 0x110BCE0 Offset: 0x110A2E0 VA: 0x18110BCE0
	public string get_ElementName() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public XmlSchemaForm get_Form() { }

	// RVA: 0x7D0D40 Offset: 0x7CF340 VA: 0x1807D0D40
	public bool get_IsNullable() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Namespace() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public int get_Order() { }

	// RVA: 0x110B970 Offset: 0x1109F70 VA: 0x18110B970
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

	// RVA: 0x110C280 Offset: 0x110A880 VA: 0x18110C280
	public string get_DataType() { }

	// RVA: 0x110C2D0 Offset: 0x110A8D0 VA: 0x18110C2D0
	public string get_ElementName() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public XmlSchemaForm get_Form() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public string get_Namespace() { }

	// RVA: 0x82BDA0 Offset: 0x82A3A0 VA: 0x18082BDA0
	public bool get_IsNullable() { }

	// RVA: 0xFFB570 Offset: 0xFF9B70 VA: 0x180FFB570
	internal bool get_IsNullableSpecified() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public Type get_Type() { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40
	public int get_NestingLevel() { }

	// RVA: 0x110BD30 Offset: 0x110A330 VA: 0x18110BD30
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlArrayItemAttributes : CollectionBase // TypeDefIndex: 2070
{	// Properties
	public XmlArrayItemAttribute Item { get; }

	// Methods

	// RVA: 0x110C4E0 Offset: 0x110AAE0 VA: 0x18110C4E0
	public XmlArrayItemAttribute get_Item(int index) { }

	// RVA: 0x110C470 Offset: 0x110AA70 VA: 0x18110C470
	public int Add(XmlArrayItemAttribute attribute) { }

	// RVA: 0x110C320 Offset: 0x110A920 VA: 0x18110C320
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x105CF40 Offset: 0x105B540 VA: 0x18105CF40
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

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
	public void .ctor(string attributeName) { }

	// RVA: 0x110CA50 Offset: 0x110B050 VA: 0x18110CA50
	public string get_AttributeName() { }

	// RVA: 0x110CAA0 Offset: 0x110B0A0 VA: 0x18110CAA0
	public string get_DataType() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_DataType(string value) { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public XmlSchemaForm get_Form() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_Namespace() { }

	// RVA: 0x110C590 Offset: 0x110AB90 VA: 0x18110C590
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlAttributeOverrides // TypeDefIndex: 2072
{	// Fields
	private Hashtable overrides; // 0x10

	// Properties
	public XmlAttributes Item { get; }
	public XmlAttributes Item { get; }

	// Methods

	// RVA: 0x110CF50 Offset: 0x110B550 VA: 0x18110CF50
	public void .ctor() { }

	// RVA: 0x110CFC0 Offset: 0x110B5C0 VA: 0x18110CFC0
	public XmlAttributes get_Item(Type type) { }

	// RVA: 0x110D100 Offset: 0x110B700 VA: 0x18110D100
	public XmlAttributes get_Item(Type type, string member) { }

	// RVA: 0x110CED0 Offset: 0x110B4D0 VA: 0x18110CED0
	private TypeMember GetKey(Type type, string member) { }

	// RVA: 0x110CBA0 Offset: 0x110B1A0 VA: 0x18110CBA0
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

	// RVA: 0x110E3F0 Offset: 0x110C9F0 VA: 0x18110E3F0
	public void .ctor() { }

	// RVA: 0x110D910 Offset: 0x110BF10 VA: 0x18110D910
	public void .ctor(ICustomAttributeProvider provider) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public XmlAnyAttributeAttribute get_XmlAnyAttribute() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public XmlAnyElementAttributes get_XmlAnyElements() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public XmlArrayAttribute get_XmlArray() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public XmlArrayItemAttributes get_XmlArrayItems() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public XmlAttributeAttribute get_XmlAttribute() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public XmlChoiceIdentifierAttribute get_XmlChoiceIdentifier() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public object get_XmlDefaultValue() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public XmlElementAttributes get_XmlElements() { }

	// RVA: 0x592630 Offset: 0x590C30 VA: 0x180592630
	public bool get_XmlIgnore() { }

	// RVA: 0xAF5FA0 Offset: 0xAF45A0 VA: 0x180AF5FA0
	public bool get_Xmlns() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public XmlRootAttribute get_XmlRoot() { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public XmlTextAttribute get_XmlText() { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	public XmlTypeAttribute get_XmlType() { }

	// RVA: 0x110D220 Offset: 0x110B820 VA: 0x18110D220
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x110E4F0 Offset: 0x110CAF0 VA: 0x18110E4F0
	internal Nullable<int> get_Order() { }

	// RVA: 0x110E5A0 Offset: 0x110CBA0 VA: 0x18110E5A0
	internal int get_SortableOrder() { }

}

public class XmlChoiceIdentifierAttribute : Attribute // TypeDefIndex: 2074
{	// Fields
	private string memberName; // 0x10

	// Properties
	public string MemberName { get; }

	// Methods

	// RVA: 0x110E740 Offset: 0x110CD40 VA: 0x18110E740
	public string get_MemberName() { }

	// RVA: 0x110E620 Offset: 0x110CC20 VA: 0x18110E620
	internal void AddKeyHash(StringBuilder sb) { }

}

internal class XmlCustomFormatter // TypeDefIndex: 2075
{	// Fields
	private static string[] allTimeFormats; // 0x14249

	// Methods

	// RVA: 0x110E790 Offset: 0x110CD90 VA: 0x18110E790
	internal static string FromEnum(long value, string[] values, long[] ids, string typeName) { }

	// RVA: 0x110EB10 Offset: 0x110D110 VA: 0x18110EB10
	internal static string FromXmlName(string name) { }

	// RVA: 0x110EAB0 Offset: 0x110D0B0 VA: 0x18110EAB0
	internal static string FromXmlNCName(string ncName) { }

	// RVA: 0x110F450 Offset: 0x110DA50 VA: 0x18110F450
	internal static string ToXmlString(TypeData type, object value) { }

	// RVA: 0x110EB70 Offset: 0x110D170 VA: 0x18110EB70
	internal static object FromXmlString(TypeData type, string value) { }

	// RVA: 0x110FFC0 Offset: 0x110E5C0 VA: 0x18110FFC0
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

	// RVA: 0x1110F00 Offset: 0x110F500 VA: 0x181110F00
	public void .ctor(string elementName) { }

	// RVA: 0x1110EA0 Offset: 0x110F4A0 VA: 0x181110EA0
	public void .ctor(string elementName, Type type) { }

	// RVA: 0x1110F40 Offset: 0x110F540 VA: 0x181110F40
	public string get_DataType() { }

	// RVA: 0x1110F90 Offset: 0x110F590 VA: 0x181110F90
	public string get_ElementName() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public XmlSchemaForm get_Form() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public string get_Namespace() { }

	// RVA: 0x82BDA0 Offset: 0x82A3A0 VA: 0x18082BDA0
	public bool get_IsNullable() { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	public int get_Order() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public Type get_Type() { }

	// RVA: 0x11109B0 Offset: 0x110EFB0 VA: 0x1811109B0
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlElementAttributes : CollectionBase // TypeDefIndex: 2077
{	// Properties
	public XmlElementAttribute Item { get; }
	internal int Order { get; }

	// Methods

	// RVA: 0x11111A0 Offset: 0x110F7A0 VA: 0x1811111A0
	public XmlElementAttribute get_Item(int index) { }

	// RVA: 0x1111130 Offset: 0x110F730 VA: 0x181111130
	public int Add(XmlElementAttribute attribute) { }

	// RVA: 0x1110FE0 Offset: 0x110F5E0 VA: 0x181110FE0
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x1111250 Offset: 0x110F850 VA: 0x181111250
	internal int get_Order() { }

	// RVA: 0x105CF40 Offset: 0x105B540 VA: 0x18105CF40
	public void .ctor() { }

}

public class XmlEnumAttribute : Attribute // TypeDefIndex: 2078
{	// Fields
	private string name; // 0x10

	// Properties
	public string Name { get; }

	// Methods

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
	public void .ctor(string name) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Name() { }

	// RVA: 0x16884A0 Offset: 0x1686AA0 VA: 0x1816884A0
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlIgnoreAttribute : Attribute // TypeDefIndex: 2079
{	// Methods

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

}

public class XmlIncludeAttribute : Attribute // TypeDefIndex: 2080
{	// Fields
	private Type type; // 0x10

	// Properties
	public Type Type { get; }

	// Methods

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
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

	// RVA: 0x1688520 Offset: 0x1686B20 VA: 0x181688520
	internal void .ctor(string elementName, string ns) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_ElementName() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_Namespace() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	public void SetKey(string key) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal ObjectMap get_ObjectMap() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	internal void set_ObjectMap(ObjectMap value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal ArrayList get_RelatedMaps() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	internal void set_RelatedMaps(ArrayList value) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	internal SerializationFormat get_Format() { }

	// RVA: 0x69D730 Offset: 0x69BD30 VA: 0x18069D730
	internal void set_Format(SerializationFormat value) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
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

	// RVA: 0x1688570 Offset: 0x1686B70 VA: 0x181688570
	public int get_Count() { }

	// RVA: 0x4BC3E0 Offset: 0x4BA9E0 VA: 0x1804BC3E0
	internal bool get_HasWrapperElement() { }

}

public class XmlNamespaceDeclarationsAttribute : Attribute // TypeDefIndex: 2086
{	// Methods

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
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

	// RVA: 0x168F4A0 Offset: 0x168DAA0 VA: 0x18168F4A0
	public void .ctor(XmlAttributeOverrides attributeOverrides, string defaultNamespace) { }

	// RVA: 0x168E950 Offset: 0x168CF50 VA: 0x18168E950
	public XmlTypeMapping ImportTypeMapping(Type type) { }

	// RVA: 0x168E970 Offset: 0x168CF70 VA: 0x18168E970
	public XmlTypeMapping ImportTypeMapping(Type type, string defaultNamespace) { }

	// RVA: 0x168E7A0 Offset: 0x168CDA0 VA: 0x18168E7A0
	public XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x168E3C0 Offset: 0x168C9C0 VA: 0x18168E3C0
	private XmlTypeMapping ImportTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1689220 Offset: 0x1687820 VA: 0x181689220
	private XmlTypeMapping CreateTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultXmlType, string defaultNamespace) { }

	// RVA: 0x168BA50 Offset: 0x168A050 VA: 0x18168BA50
	private XmlTypeMapping ImportClassMapping(Type type, XmlRootAttribute root, string defaultNamespace, bool isBaseType = False) { }

	// RVA: 0x168A9C0 Offset: 0x1688FC0 VA: 0x18168A9C0
	private XmlTypeMapping ImportClassMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, bool isBaseType = False) { }

	// RVA: 0x168F300 Offset: 0x168D900 VA: 0x18168F300
	private void RegisterDerivedMap(XmlTypeMapping map, XmlTypeMapping derivedMap) { }

	// RVA: 0x168A3E0 Offset: 0x16889E0 VA: 0x18168A3E0
	private string GetTypeNamespace(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x168DE30 Offset: 0x168C430 VA: 0x18168DE30
	private XmlTypeMapping ImportListMapping(Type type, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x168D1F0 Offset: 0x168B7F0 VA: 0x18168D1F0
	private XmlTypeMapping ImportListMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x168E990 Offset: 0x168CF90 VA: 0x18168E990
	private XmlTypeMapping ImportXmlNodeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x168DED0 Offset: 0x168C4D0 VA: 0x18168DED0
	private XmlTypeMapping ImportPrimitiveMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x168CA50 Offset: 0x168B050 VA: 0x18168CA50
	private XmlTypeMapping ImportEnumMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x168ED30 Offset: 0x168D330 VA: 0x18168ED30
	private XmlTypeMapping ImportXmlSerializableMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x168D0B0 Offset: 0x168B6B0 VA: 0x18168D0B0
	private void ImportIncludedTypes(Type type, string defaultNamespace) { }

	// RVA: 0x1689830 Offset: 0x1687E30 VA: 0x181689830
	private List<XmlReflectionMember> GetReflectionMembers(Type type) { }

	// RVA: 0x1688670 Offset: 0x1686C70 VA: 0x181688670
	private XmlTypeMapMember CreateMapMember(Type declaringType, XmlReflectionMember rmember, string defaultNamespace) { }

	// RVA: 0x168BAF0 Offset: 0x168A0F0 VA: 0x18168BAF0
	private XmlTypeMapElementInfoList ImportElementInfo(Type cls, string defaultName, string defaultNamespace, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x168A4F0 Offset: 0x1688AF0 VA: 0x18168A4F0
	private XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, XmlReflectionMember rmember, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x168E070 Offset: 0x168C670 VA: 0x18168E070
	private void ImportTextElementInfo(XmlTypeMapElementInfoList list, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts, string defaultNamespace) { }

	// RVA: 0x1688630 Offset: 0x1686C30 VA: 0x181688630
	private bool CanBeNull(TypeData type) { }

	// RVA: 0x168EF20 Offset: 0x168D520 VA: 0x18168EF20
	public void IncludeType(Type type) { }

	// RVA: 0x1689690 Offset: 0x1687C90 VA: 0x181689690
	private object GetDefaultValue(TypeData typeData, object defaultValue) { }

	// RVA: 0x168F430 Offset: 0x168DA30 VA: 0x18168F430
	private static void .cctor() { }

}

private sealed class XmlReflectionImporter.<>c // TypeDefIndex: 2088
{	// Fields
	public static readonly XmlReflectionImporter.<>c <>9; // 0x0
	public static Comparison<XmlReflectionMember> <>9__28_0; // 0x8

	// Methods

	// RVA: 0x1688390 Offset: 0x1686990 VA: 0x181688390
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1688280 Offset: 0x1686880 VA: 0x181688280
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

	// RVA: 0x168F5A0 Offset: 0x168DBA0 VA: 0x18168F5A0
	internal void .ctor(string name, Type type, XmlAttributes attributes) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_IsReturnValue() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_MemberName() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public Type get_MemberType() { }

	// RVA: 0x168F610 Offset: 0x168DC10 VA: 0x18168F610
	public XmlAttributes get_XmlAttributes() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	internal Type get_DeclaringType() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
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

	// RVA: 0x168F730 Offset: 0x168DD30 VA: 0x18168F730
	public void .ctor() { }

	// RVA: 0x168F740 Offset: 0x168DD40 VA: 0x18168F740
	public void .ctor(string elementName) { }

	// RVA: 0x168F780 Offset: 0x168DD80 VA: 0x18168F780
	public string get_DataType() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_DataType(string value) { }

	// RVA: 0x168F7D0 Offset: 0x168DDD0 VA: 0x18168F7D0
	public string get_ElementName() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_ElementName(string value) { }

	// RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0
	public bool get_IsNullable() { }

	// RVA: 0x7F9BF0 Offset: 0x7F81F0 VA: 0x1807F9BF0
	public void set_IsNullable(bool value) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public string get_Namespace() { }

	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	public void set_Namespace(string value) { }

	// RVA: 0x168F680 Offset: 0x168DC80 VA: 0x18168F680
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

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
	public void .ctor(string methodName) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_MethodName() { }

	// RVA: 0x95FAF0 Offset: 0x95E0F0 VA: 0x18095FAF0
	public bool get_IsAny() { }

	// RVA: 0x95FB10 Offset: 0x95E110 VA: 0x18095FB10
	public void set_IsAny(bool value) { }

}

public sealed class XmlSerializationCollectionFixupCallback : MulticastDelegate // TypeDefIndex: 2092
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1690080 Offset: 0x168E680 VA: 0x181690080 Slot: 12
	public virtual void Invoke(object collection, object collectionItems) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
	public virtual IAsyncResult BeginInvoke(object collection, object collectionItems, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class XmlSerializationFixupCallback : MulticastDelegate // TypeDefIndex: 2093
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14299B0 Offset: 0x1427FB0 VA: 0x1814299B0 Slot: 12
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

	// RVA: 0xD3D6F0 Offset: 0xD3BCF0 VA: 0x180D3D6F0 Slot: 12
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

	// RVA: 0x1698390 Offset: 0x1696990 VA: 0x181698390
	internal void Initialize(XmlReader reader, XmlSerializer eventSource) { }

	// RVA: 0x1697E40 Offset: 0x1696440 VA: 0x181697E40
	private ArrayList EnsureArrayList(ArrayList list) { }

	// RVA: 0x1697E90 Offset: 0x1696490 VA: 0x181697E90
	private Hashtable EnsureHashtable(Hashtable hash) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x169C150 Offset: 0x169A750 VA: 0x18169C150
	protected XmlDocument get_Document() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	protected XmlReader get_Reader() { }

	// RVA: 0x1697380 Offset: 0x1695980 VA: 0x181697380
	protected void AddFixup(XmlSerializationReader.CollectionFixup fixup) { }

	// RVA: 0x16974A0 Offset: 0x1695AA0 VA: 0x1816974A0
	protected void AddFixup(XmlSerializationReader.Fixup fixup) { }

	// RVA: 0x16972E0 Offset: 0x16958E0 VA: 0x1816972E0
	private void AddFixup(XmlSerializationReader.CollectionItemFixup fixup) { }

	// RVA: 0x1697540 Offset: 0x1695B40 VA: 0x181697540
	protected void AddReadCallback(string name, string ns, Type type, XmlSerializationReadCallback read) { }

	// RVA: 0x16976A0 Offset: 0x1695CA0 VA: 0x1816976A0
	protected void AddTarget(string id, object o) { }

	// RVA: 0x1697C40 Offset: 0x1696240 VA: 0x181697C40
	private string CurrentTag() { }

	// RVA: 0x16977F0 Offset: 0x1695DF0 VA: 0x1816977F0
	protected Exception CreateReadOnlyCollectionException(string name) { }

	// RVA: 0x1697860 Offset: 0x1695E60 VA: 0x181697860
	protected Exception CreateUnknownConstantException(string value, Type enumType) { }

	// RVA: 0x16978D0 Offset: 0x1695ED0 VA: 0x1816978D0
	protected Exception CreateUnknownNodeException() { }

	// RVA: 0x1697950 Offset: 0x1695F50 VA: 0x181697950
	protected Exception CreateUnknownTypeException(XmlQualifiedName type) { }

	// RVA: 0x1697DB0 Offset: 0x16963B0 VA: 0x181697DB0
	protected Array EnsureArrayIndex(Array a, int index, Type elementType) { }

	// RVA: 0x1697FE0 Offset: 0x16965E0 VA: 0x181697FE0
	protected bool GetNullAttr() { }

	// RVA: 0x16980C0 Offset: 0x16966C0 VA: 0x1816980C0
	protected object GetTarget(string id) { }

	// RVA: 0x169B960 Offset: 0x1699F60 VA: 0x18169B960
	private bool TargetReady(string id) { }

	// RVA: 0x1698190 Offset: 0x1696790 VA: 0x181698190
	protected XmlQualifiedName GetXsiType() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void InitCallbacks();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void InitIDs();

	// RVA: 0x1698740 Offset: 0x1696D40 VA: 0x181698740
	protected bool IsXmlnsAttribute(string name) { }

	// RVA: 0x1698BB0 Offset: 0x16971B0 VA: 0x181698BB0
	protected void ParseWsdlArrayType(XmlAttribute attr) { }

	// RVA: 0x1698D50 Offset: 0x1697350 VA: 0x181698D50
	protected XmlQualifiedName ReadElementQualifiedName() { }

	// RVA: 0x1698E60 Offset: 0x1697460 VA: 0x181698E60
	protected void ReadEndElement() { }

	// RVA: 0x1699400 Offset: 0x1697A00 VA: 0x181699400
	protected bool ReadNull() { }

	// RVA: 0x1699660 Offset: 0x1697C60 VA: 0x181699660
	protected XmlQualifiedName ReadNullableQualifiedName() { }

	// RVA: 0x1699690 Offset: 0x1697C90 VA: 0x181699690
	protected string ReadNullableString() { }

	// RVA: 0x16996E0 Offset: 0x1697CE0 VA: 0x1816996E0
	protected object ReadReferencedElement() { }

	// RVA: 0x1697EE0 Offset: 0x16964E0 VA: 0x181697EE0
	private XmlSerializationReader.WriteCallbackInfo GetCallbackInfo(XmlQualifiedName qname) { }

	// RVA: 0x1699750 Offset: 0x1697D50 VA: 0x181699750
	protected object ReadReferencedElement(string name, string ns) { }

	// RVA: 0x1698F20 Offset: 0x1697520 VA: 0x181698F20
	private bool ReadList(out object resultList) { }

	// RVA: 0x1699A30 Offset: 0x1698030 VA: 0x181699A30
	protected void ReadReferencedElements() { }

	// RVA: 0x169AC00 Offset: 0x1699200 VA: 0x18169AC00
	protected object ReadReferencingElement(out string fixupReference) { }

	// RVA: 0x169ABE0 Offset: 0x16991E0 VA: 0x18169ABE0
	protected object ReadReferencingElement(string name, string ns, out string fixupReference) { }

	// RVA: 0x169A870 Offset: 0x1698E70 VA: 0x18169A870
	protected object ReadReferencingElement(string name, string ns, bool elementCanBeType, out string fixupReference) { }

	// RVA: 0x169AC80 Offset: 0x1699280 VA: 0x18169AC80
	protected IXmlSerializable ReadSerializable(IXmlSerializable serializable) { }

	// RVA: 0x169B6F0 Offset: 0x1699CF0 VA: 0x18169B6F0
	protected object ReadTypedPrimitive(XmlQualifiedName type) { }

	// RVA: 0x169AE70 Offset: 0x1699470 VA: 0x18169AE70
	private object ReadTypedPrimitive(XmlQualifiedName qname, bool reportUnknown) { }

	// RVA: 0x169B830 Offset: 0x1699E30 VA: 0x18169B830
	protected XmlNode ReadXmlNode(bool wrapped) { }

	// RVA: 0x169B700 Offset: 0x1699D00 VA: 0x18169B700
	protected XmlDocument ReadXmlDocument(bool wrapped) { }

	// RVA: 0x169B8A0 Offset: 0x1699EA0 VA: 0x18169B8A0
	protected Array ShrinkArray(Array a, int length, Type elementType, bool isNullable) { }

	// RVA: 0x169B980 Offset: 0x1699F80 VA: 0x18169B980
	protected XmlQualifiedName ToXmlQualifiedName(string value) { }

	// RVA: 0x169BBA0 Offset: 0x169A1A0 VA: 0x18169BBA0
	protected void UnknownAttribute(object o, XmlAttribute attr, string qnames) { }

	// RVA: 0x169BDD0 Offset: 0x169A3D0 VA: 0x18169BDD0
	protected void UnknownElement(object o, XmlElement elem, string qnames) { }

	// RVA: 0x16918A0 Offset: 0x168FEA0 VA: 0x1816918A0
	protected void UnknownNode(object o) { }

	// RVA: 0x169C050 Offset: 0x169A650 VA: 0x18169C050
	protected void UnknownNode(object o, string qnames) { }

	// RVA: 0x16987B0 Offset: 0x1696DB0 VA: 0x1816987B0
	private void OnUnknownNode(XmlNode node, object o, string qnames) { }

	// RVA: 0x169C0C0 Offset: 0x169A6C0 VA: 0x18169C0C0
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

	// RVA: 0xF5EED0 Offset: 0xF5D4D0 VA: 0x180F5EED0
	public void .ctor(Array list, int index, string id) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public Array get_Collection() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
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

	// RVA: 0x1697290 Offset: 0x1695890 VA: 0x181697290
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x16914E0 Offset: 0x168FAE0 VA: 0x1816914E0 Slot: 4
	protected override void InitCallbacks() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	protected override void InitIDs() { }

	// RVA: 0x1696420 Offset: 0x1694A20 VA: 0x181696420
	public object ReadRoot() { }

	// RVA: 0x16923A0 Offset: 0x16909A0 VA: 0x1816923A0
	private object ReadEncodedObject(XmlTypeMapping typeMap) { }

	// RVA: 0x1695600 Offset: 0x1693C00 VA: 0x181695600 Slot: 6
	protected virtual object ReadMessage(XmlMembersMapping typeMap) { }

	// RVA: 0x16966D0 Offset: 0x1694CD0 VA: 0x1816966D0
	private object ReadRoot(XmlTypeMapping rootMap) { }

	// RVA: 0x1695F90 Offset: 0x1694590 VA: 0x181695F90 Slot: 7
	protected virtual object ReadObject(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x16920A0 Offset: 0x16906A0 VA: 0x1816920A0 Slot: 8
	protected virtual object ReadClassInstance(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x1691FE0 Offset: 0x16905E0 VA: 0x181691FE0 Slot: 9
	protected virtual void ReadClassInstanceMembers(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x1691910 Offset: 0x168FF10 VA: 0x181691910
	private void ReadAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x1692D10 Offset: 0x1691310 VA: 0x181692D10
	private void ReadMembers(ClassMap map, object ob, bool isValueList, bool readBySoapOrder) { }

	// RVA: 0x1696BF0 Offset: 0x16951F0 VA: 0x181696BF0
	private void SetListMembersDefaults(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x1690C80 Offset: 0x168F280 VA: 0x181690C80
	internal void FixupMembers(ClassMap map, object obfixup, bool isValueList) { }

	// RVA: 0x16918A0 Offset: 0x168FEA0 VA: 0x1816918A0 Slot: 10
	protected virtual void ProcessUnknownAttribute(object target) { }

	// RVA: 0x16918A0 Offset: 0x168FEA0 VA: 0x1816918A0 Slot: 11
	protected virtual void ProcessUnknownElement(object target) { }

	// RVA: 0x1691820 Offset: 0x168FE20 VA: 0x181691820
	private bool IsReadOnly(XmlTypeMapMember member, TypeData memType, object ob, bool isValueList) { }

	// RVA: 0x1697020 Offset: 0x1695620 VA: 0x181697020
	private void SetMemberValue(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x1696F20 Offset: 0x1695520 VA: 0x181696F20
	private void SetMemberValueFromAttr(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x16912D0 Offset: 0x168F8D0 VA: 0x1816912D0
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x1695DD0 Offset: 0x16943D0 VA: 0x181695DD0
	private object ReadObjectElement(XmlTypeMapElementInfo elem) { }

	// RVA: 0x16962A0 Offset: 0x16948A0 VA: 0x1816962A0
	private object ReadPrimitiveValue(XmlTypeMapElementInfo elem) { }

	// RVA: 0x16913B0 Offset: 0x168F9B0 VA: 0x1816913B0
	private object GetValueFromXmlString(string value, TypeData typeData, XmlTypeMapping typeMap) { }

	// RVA: 0x1692580 Offset: 0x1690B80 VA: 0x181692580
	private object ReadListElement(XmlTypeMapping typeMap, bool isNullable, object list, bool canCreateInstance) { }

	// RVA: 0x1692A60 Offset: 0x1691060 VA: 0x181692A60
	private object ReadListString(XmlTypeMapping typeMap, string values) { }

	// RVA: 0x1690480 Offset: 0x168EA80 VA: 0x181690480
	private void AddListValue(TypeData listType, ref object list, int index, object value, bool canCreateInstance) { }

	// RVA: 0x1690BB0 Offset: 0x168F1B0 VA: 0x181690BB0
	private static object CreateInstance(Type type, bool nonPublic) { }

	// RVA: 0x1690B40 Offset: 0x168F140 VA: 0x181690B40
	private object CreateInstance(Type type) { }

	// RVA: 0x1690BC0 Offset: 0x168F1C0 VA: 0x181690BC0
	private object CreateList(Type listType) { }

	// RVA: 0x16917A0 Offset: 0x168FDA0 VA: 0x1816917A0
	private object InitializeList(TypeData listType) { }

	// RVA: 0x1690C60 Offset: 0x168F260 VA: 0x181690C60
	private void FillList(object list, object items) { }

	// RVA: 0x1690830 Offset: 0x168EE30 VA: 0x181690830
	private void CopyEnumerableList(object source, object dest) { }

	// RVA: 0x16967F0 Offset: 0x1694DF0 VA: 0x1816967F0
	private object ReadXmlNodeElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x1696820 Offset: 0x1694E20 VA: 0x181696820
	private object ReadXmlNode(TypeData type, bool wrapped) { }

	// RVA: 0x16961D0 Offset: 0x16947D0 VA: 0x1816961D0
	private object ReadPrimitiveElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x1692500 Offset: 0x1690B00 VA: 0x181692500
	private object ReadEnumElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x1691100 Offset: 0x168F700 VA: 0x181691100
	private object GetEnumValue(XmlTypeMapping typeMap, string val) { }

	// RVA: 0x1696A10 Offset: 0x1695010 VA: 0x181696A10
	private object ReadXmlSerializableElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x16971F0 Offset: 0x16957F0 VA: 0x1816971F0
	private static void .cctor() { }

}

private class XmlSerializationReaderInterpreter.FixupCallbackInfo // TypeDefIndex: 2102
{	// Fields
	private XmlSerializationReaderInterpreter _sri; // 0x10
	private ClassMap _map; // 0x18
	private bool _isValueList; // 0x20

	// Methods

	// RVA: 0xFFC010 Offset: 0xFFA610 VA: 0x180FFC010
	public void .ctor(XmlSerializationReaderInterpreter sri, ClassMap map, bool isValueList) { }

	// RVA: 0x1688160 Offset: 0x1686760 VA: 0x181688160
	public void FixupMembers(object fixup) { }

}

private class XmlSerializationReaderInterpreter.ReaderCallbackInfo // TypeDefIndex: 2103
{	// Fields
	private XmlSerializationReaderInterpreter _sri; // 0x10
	private XmlTypeMapping _typeMap; // 0x18

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	public void .ctor(XmlSerializationReaderInterpreter sri, XmlTypeMapping typeMap) { }

	// RVA: 0x1688240 Offset: 0x1686840 VA: 0x181688240
	internal object ReadObject() { }

}

public sealed class XmlSerializationWriteCallback : MulticastDelegate // TypeDefIndex: 2104
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14299B0 Offset: 0x1427FB0 VA: 0x1814299B0 Slot: 12
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

	// RVA: 0x16A3E70 Offset: 0x16A2470 VA: 0x1816A3E70
	protected void .ctor() { }

	// RVA: 0x16A1360 Offset: 0x169F960 VA: 0x1816A1360
	internal void Initialize(XmlWriter writer, XmlSerializerNamespaces nss) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	protected XmlWriter get_Writer() { }

	// RVA: 0x16A0B90 Offset: 0x169F190 VA: 0x1816A0B90
	protected void AddWriteCallback(Type type, string typeName, string typeNs, XmlSerializationWriteCallback callback) { }

	// RVA: 0x16A0D70 Offset: 0x169F370 VA: 0x1816A0D70
	protected Exception CreateUnknownAnyElementException(string name, string ns) { }

	// RVA: 0x16A0E50 Offset: 0x169F450 VA: 0x1816A0E50
	protected Exception CreateUnknownTypeException(object o) { }

	// RVA: 0x16A0DE0 Offset: 0x169F3E0 VA: 0x1816A0DE0
	protected Exception CreateUnknownTypeException(Type type) { }

	// RVA: 0x16A0EE0 Offset: 0x169F4E0 VA: 0x1816A0EE0
	protected string FromXmlQualifiedName(XmlQualifiedName xmlQualifiedName) { }

	// RVA: 0x16A0FC0 Offset: 0x169F5C0 VA: 0x1816A0FC0
	private string GetId(object o, bool addToReferencesList) { }

	// RVA: 0x16A0CB0 Offset: 0x169F2B0 VA: 0x1816A0CB0
	private bool AlreadyQueued(object ob) { }

	// RVA: 0x16A10C0 Offset: 0x169F6C0 VA: 0x1816A10C0
	private string GetNamespacePrefix(string ns) { }

	// RVA: 0x16A11D0 Offset: 0x169F7D0 VA: 0x1816A11D0
	private string GetQualifiedName(string name, string ns) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void InitCallbacks();

	// RVA: 0x16A1590 Offset: 0x169FB90 VA: 0x1816A1590
	protected void TopLevelElement() { }

	// RVA: 0x16A1870 Offset: 0x169FE70 VA: 0x1816A1870
	protected void WriteAttribute(string localName, string ns, string value) { }

	// RVA: 0x16A1830 Offset: 0x169FE30 VA: 0x1816A1830
	protected void WriteAttribute(string prefix, string localName, string ns, string value) { }

	// RVA: 0x16A3C70 Offset: 0x16A2270 VA: 0x1816A3C70
	private void WriteXmlNode(XmlNode node) { }

	// RVA: 0x16A18B0 Offset: 0x169FEB0 VA: 0x1816A18B0
	protected void WriteElementEncoded(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x16A19A0 Offset: 0x169FFA0 VA: 0x1816A19A0
	protected void WriteElementLiteral(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x16A1A90 Offset: 0x16A0090 VA: 0x1816A1A90
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value) { }

	// RVA: 0x16A1AB0 Offset: 0x16A00B0 VA: 0x1816A1AB0
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x16A1C90 Offset: 0x16A0290 VA: 0x1816A1C90
	protected void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x16A1CB0 Offset: 0x16A02B0 VA: 0x1816A1CB0
	protected void WriteElementString(string localName, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0xBA4C30 Offset: 0xBA3230 VA: 0x180BA4C30
	protected void WriteEndElement() { }

	// RVA: 0x16A1E20 Offset: 0x16A0420 VA: 0x1816A1E20
	protected void WriteEndElement(object o) { }

	// RVA: 0x16A1E70 Offset: 0x16A0470 VA: 0x1816A1E70
	protected void WriteNamespaceDeclarations(XmlSerializerNamespaces xmlns) { }

	// RVA: 0x16A2330 Offset: 0x16A0930 VA: 0x1816A2330
	protected void WriteNullableQualifiedNameEncoded(string name, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x16A23E0 Offset: 0x16A09E0 VA: 0x1816A23E0
	protected void WriteNullableQualifiedNameLiteral(string name, string ns, XmlQualifiedName value) { }

	// RVA: 0x16A2490 Offset: 0x16A0A90 VA: 0x1816A2490
	protected void WriteNullableStringEncoded(string name, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0x16A24B0 Offset: 0x16A0AB0 VA: 0x1816A24B0
	protected void WriteNullableStringLiteral(string name, string ns, string value) { }

	// RVA: 0x16A21C0 Offset: 0x16A07C0 VA: 0x1816A21C0
	protected void WriteNullTagEncoded(string name, string ns) { }

	// RVA: 0x16A2270 Offset: 0x16A0870 VA: 0x1816A2270
	protected void WriteNullTagLiteral(string name, string ns) { }

	// RVA: 0x16A24E0 Offset: 0x16A0AE0 VA: 0x1816A24E0
	protected void WritePotentiallyReferencingElement(string n, string ns, object o, Type ambientType, bool suppressReference, bool isNullable) { }

	// RVA: 0x16A2940 Offset: 0x16A0F40 VA: 0x1816A2940
	protected void WriteReferencedElements() { }

	// RVA: 0x16A1490 Offset: 0x169FA90 VA: 0x1816A1490
	private bool IsPrimitiveArray(TypeData td) { }

	// RVA: 0x16A15A0 Offset: 0x169FBA0 VA: 0x1816A15A0
	private void WriteArray(object o, TypeData td) { }

	// RVA: 0x16A2BA0 Offset: 0x16A11A0 VA: 0x1816A2BA0
	protected void WriteReferencingElement(string n, string ns, object o, bool isNullable) { }

	// RVA: 0x16A0CF0 Offset: 0x169F2F0 VA: 0x1816A0CF0
	private void CheckReferenceQueue() { }

	// RVA: 0x16A2CF0 Offset: 0x16A12F0 VA: 0x1816A2CF0
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable) { }

	// RVA: 0x16A2E20 Offset: 0x16A1420 VA: 0x1816A2E20
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped) { }

	// RVA: 0x16A2F60 Offset: 0x16A1560 VA: 0x1816A2F60
	protected void WriteStartDocument() { }

	// RVA: 0x16A3640 Offset: 0x16A1C40 VA: 0x1816A3640
	protected void WriteStartElement(string name, string ns) { }

	// RVA: 0x16A35E0 Offset: 0x16A1BE0 VA: 0x1816A35E0
	protected void WriteStartElement(string name, string ns, bool writePrefixed) { }

	// RVA: 0x16A3610 Offset: 0x16A1C10 VA: 0x1816A3610
	protected void WriteStartElement(string name, string ns, object o) { }

	// RVA: 0x16A2FC0 Offset: 0x16A15C0 VA: 0x1816A2FC0
	protected void WriteStartElement(string name, string ns, object o, bool writePrefixed) { }

	// RVA: 0x16A2FF0 Offset: 0x16A15F0 VA: 0x1816A2FF0
	private void WriteStartElement(string name, string ns, object o, bool writePrefixed, ICollection namespaces) { }

	// RVA: 0x16A3670 Offset: 0x16A1C70 VA: 0x1816A3670
	protected void WriteTypedPrimitive(string name, string ns, object o, bool xsiType) { }

	// RVA: 0x16A3990 Offset: 0x16A1F90 VA: 0x1816A3990
	protected void WriteValue(string value) { }

	// RVA: 0x16A39D0 Offset: 0x16A1FD0 VA: 0x1816A39D0
	protected void WriteXmlAttribute(XmlNode node, object container) { }

	// RVA: 0x16A3DA0 Offset: 0x16A23A0 VA: 0x1816A3DA0
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

	// RVA: 0x16A0AF0 Offset: 0x169F0F0 VA: 0x1816A0AF0
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x169CB60 Offset: 0x169B160 VA: 0x18169CB60 Slot: 4
	protected override void InitCallbacks() { }

	// RVA: 0x16A0850 Offset: 0x169EE50 VA: 0x1816A0850
	public void WriteRoot(object ob) { }

	// RVA: 0x169FB40 Offset: 0x169E140 VA: 0x18169FB40 Slot: 5
	protected virtual void WriteObject(XmlTypeMapping typeMap, object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem) { }

	// RVA: 0x169F670 Offset: 0x169DC70 VA: 0x18169F670 Slot: 6
	protected virtual void WriteMessage(XmlMembersMapping membersMap, object[] parameters) { }

	// RVA: 0x169F9F0 Offset: 0x169DFF0 VA: 0x18169F9F0 Slot: 7
	protected virtual void WriteObjectElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x169F870 Offset: 0x169DE70 VA: 0x18169F870 Slot: 8
	protected virtual void WriteObjectElementAttributes(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x169F930 Offset: 0x169DF30 VA: 0x18169F930 Slot: 9
	protected virtual void WriteObjectElementElements(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x169F610 Offset: 0x169DC10 VA: 0x18169F610
	private void WriteMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x169D950 Offset: 0x169BF50 VA: 0x18169D950
	private void WriteAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x169E0C0 Offset: 0x169C6C0 VA: 0x18169E0C0
	private void WriteElementMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x169C480 Offset: 0x169AA80 VA: 0x18169C480
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x169CE20 Offset: 0x169B420 VA: 0x18169CE20
	private bool MemberHasValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x169EF70 Offset: 0x169D570 VA: 0x18169EF70
	private void WriteMemberElement(XmlTypeMapElementInfo elem, object memberValue) { }

	// RVA: 0x169C7B0 Offset: 0x169ADB0 VA: 0x18169C7B0
	internal static object ImplicitConvert(object obj, Type type) { }

	// RVA: 0x16A0550 Offset: 0x169EB50 VA: 0x1816A0550
	private void WritePrimitiveValueLiteral(object memberValue, string name, string ns, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x16A0220 Offset: 0x169E820 VA: 0x1816A0220
	private void WritePrimitiveValueEncoded(object memberValue, string name, string ns, XmlQualifiedName xsiType, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x169ED10 Offset: 0x169D310 VA: 0x18169ED10 Slot: 10
	protected virtual void WriteListElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x169E6A0 Offset: 0x169CCA0 VA: 0x18169E6A0
	private void WriteListContent(object container, TypeData listType, ListMap map, object ob, StringBuilder targetString) { }

	// RVA: 0x169C310 Offset: 0x169A910 VA: 0x18169C310
	private int GetListCount(TypeData listType, object ob) { }

	// RVA: 0x169D070 Offset: 0x169B670 VA: 0x18169D070
	private void WriteAnyElementContent(XmlTypeMapMemberAnyElement member, object memberValue) { }

	// RVA: 0x16A01D0 Offset: 0x169E7D0 VA: 0x1816A01D0 Slot: 11
	protected virtual void WritePrimitiveElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x169E660 Offset: 0x169CC60 VA: 0x18169E660 Slot: 12
	protected virtual void WriteEnumElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x169C560 Offset: 0x169AB60 VA: 0x18169C560
	private string GetStringValue(XmlTypeMapping typeMap, TypeData type, object value) { }

	// RVA: 0x169C1F0 Offset: 0x169A7F0 VA: 0x18169C1F0
	private string GetEnumXmlValue(XmlTypeMapping typeMap, object ob) { }

}

private class XmlSerializationWriterInterpreter.CallbackInfo // TypeDefIndex: 2108
{	// Fields
	private XmlSerializationWriterInterpreter _swi; // 0x10
	private XmlTypeMapping _typeMap; // 0x18

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	public void .ctor(XmlSerializationWriterInterpreter swi, XmlTypeMapping typeMap) { }

	// RVA: 0xE4D120 Offset: 0xE4B720 VA: 0x180E4D120
	internal void WriteObject(object ob) { }

	// RVA: 0xE4D0C0 Offset: 0xE4B6C0 VA: 0x180E4D0C0
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

	// RVA: 0xE68720 Offset: 0xE66D20 VA: 0x180E68720
	private static void .cctor() { }

	// RVA: 0xE68990 Offset: 0xE66F90 VA: 0x180E68990
	public void .ctor(Type type) { }

	// RVA: 0xE68810 Offset: 0xE66E10 VA: 0x180E68810
	public void .ctor(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal XmlMapping get_Mapping() { }

	// RVA: 0xE68110 Offset: 0xE66710 VA: 0x180E68110 Slot: 4
	internal virtual void OnUnknownAttribute(XmlAttributeEventArgs e) { }

	// RVA: 0xE68130 Offset: 0xE66730 VA: 0x180E68130 Slot: 5
	internal virtual void OnUnknownElement(XmlElementEventArgs e) { }

	// RVA: 0xE68150 Offset: 0xE66750 VA: 0x180E68150 Slot: 6
	internal virtual void OnUnknownNode(XmlNodeEventArgs e) { }

	// RVA: 0xE68170 Offset: 0xE66770 VA: 0x180E68170 Slot: 7
	internal virtual void OnUnreferencedObject(UnreferencedObjectEventArgs e) { }

	// RVA: 0xE67900 Offset: 0xE65F00 VA: 0x180E67900 Slot: 8
	protected virtual XmlSerializationReader CreateReader() { }

	// RVA: 0xE679B0 Offset: 0xE65FB0 VA: 0x180E679B0 Slot: 9
	protected virtual XmlSerializationWriter CreateWriter() { }

	// RVA: 0xE67FF0 Offset: 0xE665F0 VA: 0x180E67FF0
	public object Deserialize(TextReader textReader) { }

	// RVA: 0xE67CB0 Offset: 0xE662B0 VA: 0x180E67CB0
	public object Deserialize(XmlReader xmlReader) { }

	// RVA: 0xE67D70 Offset: 0xE66370 VA: 0x180E67D70 Slot: 10
	protected virtual object Deserialize(XmlSerializationReader reader) { }

	// RVA: 0xE68440 Offset: 0xE66A40 VA: 0x180E68440 Slot: 11
	protected virtual void Serialize(object o, XmlSerializationWriter writer) { }

	// RVA: 0xE68680 Offset: 0xE66C80 VA: 0x180E68680
	public void Serialize(TextWriter textWriter, object o) { }

	// RVA: 0xE68660 Offset: 0xE66C60 VA: 0x180E68660
	public void Serialize(XmlWriter xmlWriter, object o) { }

	// RVA: 0xE68190 Offset: 0xE66790 VA: 0x180E68190
	public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces) { }

	// RVA: 0xE67A00 Offset: 0xE66000 VA: 0x180E67A00
	private XmlSerializationWriter CreateWriter(XmlMapping typeMapping) { }

	// RVA: 0xE67950 Offset: 0xE65F50 VA: 0x180E67950
	private XmlSerializationReader CreateReader(XmlMapping typeMapping) { }

}

internal class XmlSerializer.SerializerData // TypeDefIndex: 2110
{	// Fields
	public MethodInfo ReaderMethod; // 0x10
	public Type WriterType; // 0x18
	public MethodInfo WriterMethod; // 0x20
	public XmlSerializerImplementation Implementation; // 0x28

	// Methods

	// RVA: 0xE4D180 Offset: 0xE4B780 VA: 0x180E4D180
	public XmlSerializationWriter CreateWriter() { }

}

public class XmlSerializerFactory // TypeDefIndex: 2111
{	// Fields
	private static Hashtable serializersBySource; // 0x2B11334

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xE66C60 Offset: 0xE65260 VA: 0x180E66C60
	public XmlSerializer CreateSerializer(Type type) { }

	// RVA: 0xE66C90 Offset: 0xE65290 VA: 0x180E66C90
	public XmlSerializer CreateSerializer(Type type, XmlRootAttribute root) { }

	// RVA: 0xE66CC0 Offset: 0xE652C0 VA: 0x180E66CC0
	public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0xE67040 Offset: 0xE65640 VA: 0x180E67040
	private static void .cctor() { }

}

public abstract class XmlSerializerImplementation // TypeDefIndex: 2112
{	// Properties
	public virtual XmlSerializationWriter Writer { get; }

	// Methods

	// RVA: 0xE670A0 Offset: 0xE656A0 VA: 0x180E670A0 Slot: 4
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

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xE68A50 Offset: 0xE67050 VA: 0x180E68A50
	public string get_DataType() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Type get_Type() { }

	// RVA: 0xE689C0 Offset: 0xE66FC0 VA: 0x180E689C0
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

	// RVA: 0xE68B40 Offset: 0xE67140 VA: 0x180E68B40
	public string get_TypeName() { }

	// RVA: 0xE68AA0 Offset: 0xE670A0 VA: 0x180E68AA0
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

	// RVA: 0xE68D40 Offset: 0xE67340 VA: 0x180E68D40
	public void .ctor(XmlTypeMapMember member, TypeData type) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public TypeData get_TypeData() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public object get_ChoiceValue() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	public void set_ChoiceValue(object value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_ElementName() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_ElementName(string value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Namespace() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_Namespace(string value) { }

	// RVA: 0xE68E30 Offset: 0xE67430 VA: 0x180E68E30
	public string get_DataTypeNamespace() { }

	// RVA: 0xE68E00 Offset: 0xE67400 VA: 0x180E68E00
	public string get_DataTypeName() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public XmlSchemaForm get_Form() { }

	// RVA: 0x69D730 Offset: 0x69BD30 VA: 0x18069D730
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public XmlTypeMapping get_MappedType() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	public void set_MappedType(XmlTypeMapping value) { }

	// RVA: 0x8C1150 Offset: 0x8BF750 VA: 0x1808C1150
	public bool get_IsNullable() { }

	// RVA: 0x78E280 Offset: 0x78C880 VA: 0x18078E280
	public void set_IsNullable(bool value) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public XmlTypeMapMember get_Member() { }

	// RVA: 0x8C1180 Offset: 0x8BF780 VA: 0x1808C1180
	public void set_NestingLevel(int value) { }

	// RVA: 0xE68F40 Offset: 0xE67540 VA: 0x180E68F40
	public bool get_MultiReferenceType() { }

	// RVA: 0x77B1F0 Offset: 0x7797F0 VA: 0x18077B1F0
	public bool get_WrappedElement() { }

	// RVA: 0xE690B0 Offset: 0xE676B0 VA: 0x180E690B0
	public void set_WrappedElement(bool value) { }

	// RVA: 0xE68EB0 Offset: 0xE674B0 VA: 0x180E68EB0
	public bool get_IsTextElement() { }

	// RVA: 0xE68F60 Offset: 0xE67560 VA: 0x180E68F60
	public void set_IsTextElement(bool value) { }

	// RVA: 0xE68EF0 Offset: 0xE674F0 VA: 0x180E68EF0
	public bool get_IsUnnamedAnyElement() { }

	// RVA: 0xE69000 Offset: 0xE67600 VA: 0x180E69000
	public void set_IsUnnamedAnyElement(bool value) { }

	// RVA: 0x5DE920 Offset: 0x5DCF20 VA: 0x1805DE920
	public int get_ExplicitOrder() { }

	// RVA: 0xE68F50 Offset: 0xE67550 VA: 0x180E68F50
	public void set_ExplicitOrder(int value) { }

	// RVA: 0xE68BF0 Offset: 0xE671F0 VA: 0x180E68BF0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xCCE820 Offset: 0xCCCE20 VA: 0x180CCE820 Slot: 2
	public override int GetHashCode() { }

}

internal class XmlTypeMapElementInfoList : ArrayList // TypeDefIndex: 2116
{	// Methods

	// RVA: 0xE68B90 Offset: 0xE67190 VA: 0x180E68B90
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

	// RVA: 0xE6B0B0 Offset: 0xE696B0 VA: 0x180E6B0B0
	public void .ctor() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Name() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_Name(string value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public object get_DefaultValue() { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810
	public void set_DefaultValue(object value) { }

	// RVA: 0xE6A710 Offset: 0xE68D10 VA: 0x180E6A710
	public bool IsReadOnly(Type type) { }

	// RVA: 0xE69FC0 Offset: 0xE685C0 VA: 0x180E69FC0
	public static object GetValue(object ob, string name) { }

	// RVA: 0xE6A1F0 Offset: 0xE687F0 VA: 0x180E6A1F0
	public object GetValue(object ob) { }

	// RVA: 0xE6AC40 Offset: 0xE69240 VA: 0x180E6AC40
	public void SetValue(object ob, object value) { }

	// RVA: 0xE6AE70 Offset: 0xE69470 VA: 0x180E6AE70
	public static void SetValue(object ob, string name, object value) { }

	// RVA: 0xE6A400 Offset: 0xE68A00 VA: 0x180E6A400
	private void InitMember(Type type) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public TypeData get_TypeData() { }

	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	public void set_TypeData(TypeData value) { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_Index() { }

	// RVA: 0x7D0D90 Offset: 0x7CF390 VA: 0x1807D0D90
	public void set_Index(int value) { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public int get_GlobalIndex() { }

	// RVA: 0x95FB00 Offset: 0x95E100 VA: 0x18095FB00
	public void set_GlobalIndex(int value) { }

	// RVA: 0xD86030 Offset: 0xD84630 VA: 0x180D86030
	public bool get_IsOptionalValueType() { }

	// RVA: 0xE6B140 Offset: 0xE69740 VA: 0x180E6B140
	public void set_IsOptionalValueType(bool value) { }

	// RVA: 0xE6B130 Offset: 0xE69730 VA: 0x180E6B130
	public bool get_IsReturnValue() { }

	// RVA: 0xE6B160 Offset: 0xE69760 VA: 0x180E6B160
	public void set_IsReturnValue(bool value) { }

	// RVA: 0xE69BE0 Offset: 0xE681E0 VA: 0x180E69BE0
	public void CheckOptionalValueType(Type type) { }

	// RVA: 0xE69C60 Offset: 0xE68260 VA: 0x180E69C60
	public bool GetValueSpecified(object ob) { }

	// RVA: 0xE6A850 Offset: 0xE68E50 VA: 0x180E6A850
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

	// RVA: 0xE69570 Offset: 0xE67B70 VA: 0x180E69570
	public void .ctor() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public string get_AttributeName() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	public void set_AttributeName(string value) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public string get_Namespace() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	public void set_Namespace(string value) { }

	// RVA: 0x803BC0 Offset: 0x8021C0 VA: 0x180803BC0
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	public XmlTypeMapping get_MappedType() { }

	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460
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

	// RVA: 0xE690C0 Offset: 0xE676C0 VA: 0x180E690C0
	public void .ctor() { }

	// RVA: 0xE69B20 Offset: 0xE68120 VA: 0x180E69B20
	public XmlTypeMapElementInfoList get_ElementInfo() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	public void set_ElementInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public string get_ChoiceMember() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	public void set_ChoiceMember(string value) { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	public TypeData get_ChoiceTypeData() { }

	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460
	public void set_ChoiceTypeData(TypeData value) { }

	// RVA: 0xE695C0 Offset: 0xE67BC0 VA: 0x180E695C0
	public XmlTypeMapElementInfo FindElement(object ob, object memberValue) { }

	// RVA: 0xE69B00 Offset: 0xE68100 VA: 0x180E69B00
	public void SetChoice(object ob, object choice) { }

	// RVA: 0x82CB10 Offset: 0x82B110 VA: 0x18082CB10
	public bool get_IsXmlTextCollector() { }

	// RVA: 0xE69BD0 Offset: 0xE681D0 VA: 0x180E69BD0
	public void set_IsXmlTextCollector(bool value) { }

}

internal class XmlTypeMapMemberList : XmlTypeMapMemberElement // TypeDefIndex: 2120
{	// Methods

	// RVA: 0xE690C0 Offset: 0xE676C0 VA: 0x180E690C0
	public void .ctor() { }

}

internal class XmlTypeMapMemberExpandable : XmlTypeMapMemberElement // TypeDefIndex: 2121
{	// Fields
	private int _flatArrayIndex; // 0x78

	// Properties
	public int FlatArrayIndex { get; set; }

	// Methods

	// RVA: 0xAF6020 Offset: 0xAF4620 VA: 0x180AF6020
	public int get_FlatArrayIndex() { }

	// RVA: 0xB28F90 Offset: 0xB27590 VA: 0x180B28F90
	public void set_FlatArrayIndex(int value) { }

	// RVA: 0xE690C0 Offset: 0xE676C0 VA: 0x180E690C0
	public void .ctor() { }

}

internal class XmlTypeMapMemberFlatList : XmlTypeMapMemberExpandable // TypeDefIndex: 2122
{	// Fields
	private ListMap _listMap; // 0x80

	// Properties
	public ListMap ListMap { get; set; }

	// Methods

	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	public ListMap get_ListMap() { }

	// RVA: 0x574470 Offset: 0x572A70 VA: 0x180574470
	public void set_ListMap(ListMap value) { }

	// RVA: 0xE690C0 Offset: 0xE676C0 VA: 0x180E690C0
	public void .ctor() { }

}

internal class XmlTypeMapMemberAnyElement : XmlTypeMapMemberExpandable // TypeDefIndex: 2123
{	// Properties
	public bool IsDefaultAny { get; }

	// Methods

	// RVA: 0xE690D0 Offset: 0xE676D0 VA: 0x180E690D0
	public bool IsElementDefined(string name, string ns) { }

	// RVA: 0xE69320 Offset: 0xE67920 VA: 0x180E69320
	public bool get_IsDefaultAny() { }

	// RVA: 0xE690C0 Offset: 0xE676C0 VA: 0x180E690C0
	public void .ctor() { }

}

internal class XmlTypeMapMemberAnyAttribute : XmlTypeMapMember // TypeDefIndex: 2124
{	// Methods

	// RVA: 0xE690C0 Offset: 0xE676C0 VA: 0x180E690C0
	public void .ctor() { }

}

internal class XmlTypeMapMemberNamespaces : XmlTypeMapMember // TypeDefIndex: 2125
{	// Methods

	// RVA: 0xE690C0 Offset: 0xE676C0 VA: 0x180E690C0
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

	// RVA: 0xE6B620 Offset: 0xE69C20 VA: 0x180E6B620
	internal void .ctor(string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }

	// RVA: 0xE6B710 Offset: 0xE69D10 VA: 0x180E6B710
	public string get_TypeFullName() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	internal TypeData get_TypeData() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	internal string get_XmlType() { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810
	internal void set_XmlType(string value) { }

	// RVA: 0xE6B730 Offset: 0xE69D30 VA: 0x180E6B730
	internal string get_XmlTypeNamespace() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	internal void set_XmlTypeNamespace(string value) { }

	// RVA: 0xE6B6F0 Offset: 0xE69CF0 VA: 0x180E6B6F0
	internal bool get_HasXmlTypeNamespace() { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	internal ArrayList get_DerivedTypes() { }

	// RVA: 0x82CB10 Offset: 0x82B110 VA: 0x18082CB10
	internal bool get_MultiReferenceType() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	internal XmlTypeMapping get_BaseMap() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	internal void set_BaseMap(XmlTypeMapping value) { }

	// RVA: 0xBA2300 Offset: 0xBA0900 VA: 0x180BA2300
	internal void set_IncludeInSchema(bool value) { }

	// RVA: 0xBA1D70 Offset: 0xBA0370 VA: 0x180BA1D70
	internal bool get_IsNullable() { }

	// RVA: 0xBA20D0 Offset: 0xBA06D0 VA: 0x180BA20D0
	internal void set_IsNullable(bool value) { }

	// RVA: 0xE6B700 Offset: 0xE69D00 VA: 0x180E6B700
	internal bool get_IsAny() { }

	// RVA: 0xE6B780 Offset: 0xE69D80 VA: 0x180E6B780
	internal void set_IsAny(bool value) { }

	// RVA: 0xE6B3E0 Offset: 0xE699E0 VA: 0x180E6B3E0
	internal XmlTypeMapping GetRealTypeMap(Type objectType) { }

	// RVA: 0xE6B180 Offset: 0xE69780 VA: 0x180E6B180
	internal XmlTypeMapping GetRealElementMap(string name, string ens) { }

	// RVA: 0xE6B590 Offset: 0xE69B90 VA: 0x180E6B590
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

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	public void .ctor(XmlSchemaSimpleType st, object value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
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

	// RVA: 0x598430 Offset: 0x596A30 VA: 0x180598430
	public void set_Occurrence(XmlSchemaInference.InferenceOption value) { }

	// RVA: 0x598420 Offset: 0x596A20 VA: 0x180598420
	public XmlSchemaInference.InferenceOption get_Occurrence() { }

	// RVA: 0x59A0F0 Offset: 0x5986F0 VA: 0x18059A0F0
	public void set_TypeInference(XmlSchemaInference.InferenceOption value) { }

	// RVA: 0x105C4C0 Offset: 0x105AAC0 VA: 0x18105C4C0
	public void .ctor() { }

	// RVA: 0x10586E0 Offset: 0x1056CE0 VA: 0x1810586E0
	public XmlSchemaSet InferSchema(XmlReader instanceDocument) { }

	// RVA: 0x1057F60 Offset: 0x1056560 VA: 0x181057F60
	internal XmlSchemaSet InferSchema1(XmlReader instanceDocument, XmlSchemaSet schemas) { }

	// RVA: 0x10521A0 Offset: 0x10507A0 VA: 0x1810521A0
	private XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, XmlSchemaObjectTable compiledAttributes) { }

	// RVA: 0x1053740 Offset: 0x1051D40 VA: 0x181053740
	private XmlSchema CreateXmlSchema(string targetNS) { }

	// RVA: 0x1052AC0 Offset: 0x10510C0 VA: 0x181052AC0
	private XmlSchemaElement AddElement(string localName, string prefix, string childURI, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, int positionWithinCollection) { }

	// RVA: 0x1056410 Offset: 0x1054A10 VA: 0x181056410
	internal void InferElement(XmlSchemaElement xse, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x1053270 Offset: 0x1051870 VA: 0x181053270
	private XmlSchemaSimpleContentExtension CheckSimpleContentExtension(XmlSchemaComplexType ct) { }

	// RVA: 0x10555C0 Offset: 0x1053BC0 VA: 0x1810555C0
	private XmlSchemaType GetEffectiveSchemaType(XmlSchemaElement elem, bool bCreatingNewType) { }

	// RVA: 0x1054210 Offset: 0x1052810 VA: 0x181054210
	internal XmlSchemaElement FindMatchingElement(bool bCreatingNewType, XmlReader xtr, XmlSchemaComplexType ct, ref int lastUsedSeqItem, ref bool bParticleChanged, XmlSchema parentSchema, bool setMaxoccurs) { }

	// RVA: 0x1059D30 Offset: 0x1058330 VA: 0x181059D30
	internal void ProcessAttributes(ref XmlSchemaElement xse, XmlSchemaType effectiveSchemaType, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x1059C20 Offset: 0x1058220 VA: 0x181059C20
	private void MoveAttributes(XmlSchemaSimpleContentExtension scExtension, XmlSchemaComplexType ct) { }

	// RVA: 0x10598F0 Offset: 0x1057EF0 VA: 0x1810598F0
	private void MoveAttributes(XmlSchemaComplexType ct, XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType) { }

	// RVA: 0x1053B30 Offset: 0x1052130 VA: 0x181053B30
	internal XmlSchemaAttribute FindAttribute(ICollection attributes, string attrName) { }

	// RVA: 0x1053FE0 Offset: 0x10525E0 VA: 0x181053FE0
	internal XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, out XmlSchema parentSchema) { }

	// RVA: 0x1053EA0 Offset: 0x10524A0 VA: 0x181053EA0
	internal XmlSchemaElement FindElement(XmlSchemaObjectCollection elements, string elementName) { }

	// RVA: 0x10538D0 Offset: 0x1051ED0 VA: 0x1810538D0
	internal XmlSchemaAttribute FindAttributeRef(ICollection attributes, string attributeName, string nsURI) { }

	// RVA: 0x1053D40 Offset: 0x1052340 VA: 0x181053D40
	internal XmlSchemaElement FindElementRef(XmlSchemaObjectCollection elements, string elementName, string nsURI) { }

	// RVA: 0x1059820 Offset: 0x1057E20 VA: 0x181059820
	internal void MakeExistingAttributesOptional(XmlSchemaComplexType ct, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x105B5D0 Offset: 0x1059BD0 VA: 0x18105B5D0
	private void SwitchUseToOptional(XmlSchemaObjectCollection attributes, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x105A4C0 Offset: 0x1058AC0 VA: 0x18105A4C0
	internal XmlQualifiedName RefineSimpleType(string s, ref int iTypeFlags) { }

	// RVA: 0x1058760 Offset: 0x1056D60 VA: 0x181058760
	internal static int InferSimpleType(string s, ref bool bNeedsRangeCheck) { }

	// RVA: 0x10537E0 Offset: 0x1051DE0 VA: 0x1810537E0
	internal static int DateTime(string s, bool bDate, bool bTime) { }

	// RVA: 0x10533D0 Offset: 0x10519D0 VA: 0x1810533D0
	private XmlSchemaElement CreateNewElementforChoice(XmlSchemaElement copyElement) { }

	// RVA: 0x1055740 Offset: 0x1053D40 VA: 0x181055740
	private static int GetSchemaType(XmlQualifiedName qname) { }

	// RVA: 0x105B3C0 Offset: 0x10599C0 VA: 0x18105B3C0
	internal void SetMinMaxOccurs(XmlSchemaElement el, bool setMaxOccurs) { }

	// RVA: 0x105B710 Offset: 0x1059D10 VA: 0x18105B710
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

	// RVA: 0xD27CB0 Offset: 0xD262B0 VA: 0x180D27CB0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1050B80 Offset: 0x104F180 VA: 0x181050B80 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10518A0 Offset: 0x104FEA0 VA: 0x1810518A0
	public void .ctor() { }

	// RVA: 0x1052030 Offset: 0x1050630 VA: 0x181052030
	internal void .ctor(string res, string arg) { }

	// RVA: 0x1052170 Offset: 0x1050770 VA: 0x181052170
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

	// RVA: 0x1432A00 Offset: 0x1431000 VA: 0x181432A00
	internal void .ctor(XmlSchemaType xmlType, bool value) { }

	// RVA: 0x14327E0 Offset: 0x1430DE0 VA: 0x1814327E0
	internal void .ctor(XmlSchemaType xmlType, DateTime value) { }

	// RVA: 0x1432D40 Offset: 0x1431340 VA: 0x181432D40
	internal void .ctor(XmlSchemaType xmlType, double value) { }

	// RVA: 0x1432AA0 Offset: 0x14310A0 VA: 0x181432AA0
	internal void .ctor(XmlSchemaType xmlType, int value) { }

	// RVA: 0x1432960 Offset: 0x1430F60 VA: 0x181432960
	internal void .ctor(XmlSchemaType xmlType, long value) { }

	// RVA: 0x1432DE0 Offset: 0x14313E0 VA: 0x181432DE0
	internal void .ctor(XmlSchemaType xmlType, string value) { }

	// RVA: 0x1432B40 Offset: 0x1431140 VA: 0x181432B40
	internal void .ctor(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1432880 Offset: 0x1430E80 VA: 0x181432880
	internal void .ctor(XmlSchemaType xmlType, object value) { }

	// RVA: 0x1432EC0 Offset: 0x14314C0 VA: 0x181432EC0
	internal void .ctor(XmlSchemaType xmlType, object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 15
	private object System.ICloneable.Clone() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 4
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0x14337C0 Offset: 0x1431DC0 VA: 0x1814337C0 Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0x14330D0 Offset: 0x14316D0 VA: 0x1814330D0 Slot: 6
	public override object get_TypedValue() { }

	// RVA: 0x14332C0 Offset: 0x14318C0 VA: 0x1814332C0 Slot: 8
	public override bool get_ValueAsBoolean() { }

	// RVA: 0x14333C0 Offset: 0x14319C0 VA: 0x1814333C0 Slot: 9
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0x14334C0 Offset: 0x1431AC0 VA: 0x1814334C0 Slot: 10
	public override double get_ValueAsDouble() { }

	// RVA: 0x14335C0 Offset: 0x1431BC0 VA: 0x1814335C0 Slot: 11
	public override int get_ValueAsInt() { }

	// RVA: 0x14336C0 Offset: 0x1431CC0 VA: 0x1814336C0 Slot: 12
	public override long get_ValueAsLong() { }

	// RVA: 0x14325C0 Offset: 0x1430BC0 VA: 0x1814325C0 Slot: 14
	public override object ValueAs(Type type, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1433800 Offset: 0x1431E00 VA: 0x181433800 Slot: 5
	public override string get_Value() { }

	// RVA: 0x95F940 Offset: 0x95DF40 VA: 0x18095F940 Slot: 3
	public override string ToString() { }

	// RVA: 0x1432510 Offset: 0x1430B10 VA: 0x181432510
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

	// RVA: 0x1429880 Offset: 0x1427E80 VA: 0x181429880
	public void .ctor(string prefix, string ns) { }

	// RVA: 0x1429810 Offset: 0x1427E10 VA: 0x181429810 Slot: 5
	public string LookupNamespace(string prefix) { }

	// RVA: 0x1429850 Offset: 0x1427E50 VA: 0x181429850 Slot: 6
	public string LookupPrefix(string namespaceName) { }

	// RVA: 0x1429790 Offset: 0x1427D90 VA: 0x181429790 Slot: 4
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

	// RVA: 0x144A1A0 Offset: 0x14487A0 VA: 0x18144A1A0
	public void .ctor() { }

	// RVA: 0x144A000 Offset: 0x1448600 VA: 0x18144A000
	public static XmlSchema Read(XmlReader reader, ValidationEventHandler validationEventHandler) { }

	// RVA: 0x1449870 Offset: 0x1447E70 VA: 0x181449870
	internal bool CompileSchema(XmlSchemaCollection xsc, XmlResolver resolver, SchemaInfo schemaInfo, string ns, ValidationEventHandler validationEventHandler, XmlNameTable nameTable, bool CompileContentModel) { }

	// RVA: 0x14497B0 Offset: 0x1447DB0 VA: 0x1814497B0
	internal void CompileSchemaInSet(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x6BBA50 Offset: 0x6BA050 VA: 0x1806BBA50
	public XmlSchemaForm get_AttributeFormDefault() { }

	// RVA: 0xC74BD0 Offset: 0xC731D0 VA: 0x180C74BD0
	public void set_AttributeFormDefault(XmlSchemaForm value) { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	public XmlSchemaDerivationMethod get_BlockDefault() { }

	// RVA: 0x684160 Offset: 0x682760 VA: 0x180684160
	public void set_BlockDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x5DE450 Offset: 0x5DCA50 VA: 0x1805DE450
	public XmlSchemaDerivationMethod get_FinalDefault() { }

	// RVA: 0x8C0E10 Offset: 0x8BF410 VA: 0x1808C0E10
	public void set_FinalDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50
	public XmlSchemaForm get_ElementFormDefault() { }

	// RVA: 0x8C1180 Offset: 0x8BF780 VA: 0x1808C1180
	public void set_ElementFormDefault(XmlSchemaForm value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public string get_TargetNamespace() { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810
	public void set_TargetNamespace(string value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public string get_Version() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	public void set_Version(string value) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public XmlSchemaObjectCollection get_Includes() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x10507E0 Offset: 0x104EDE0 VA: 0x1810507E0
	internal bool get_IsCompiledBySet() { }

	// RVA: 0x10FF410 Offset: 0x10FDA10 VA: 0x1810FF410
	internal void set_IsCompiledBySet(bool value) { }

	// RVA: 0x1050830 Offset: 0x104EE30 VA: 0x181050830
	internal bool get_IsPreprocessed() { }

	// RVA: 0x144A7B0 Offset: 0x1448DB0 VA: 0x18144A7B0
	internal void set_IsPreprocessed(bool value) { }

	// RVA: 0x1050820 Offset: 0x104EE20 VA: 0x181050820
	internal bool get_IsRedefined() { }

	// RVA: 0x144A7C0 Offset: 0x1448DC0 VA: 0x18144A7C0
	internal void set_IsRedefined(bool value) { }

	// RVA: 0x144A400 Offset: 0x1448A00 VA: 0x18144A400
	public XmlSchemaObjectTable get_Attributes() { }

	// RVA: 0x144A380 Offset: 0x1448980 VA: 0x18144A380
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x144A710 Offset: 0x1448D10 VA: 0x18144A710
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x144A500 Offset: 0x1448B00 VA: 0x18144A500
	public XmlSchemaObjectTable get_Elements() { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public string get_Id() { }

	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50
	public void set_Id(string value) { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x952CA0 Offset: 0x9512A0 VA: 0x180952CA0
	public XmlSchemaObjectTable get_Notations() { }

	// RVA: 0x9922B0 Offset: 0x9908B0 VA: 0x1809922B0
	internal XmlSchemaObjectTable get_IdentityConstraints() { }

	// RVA: 0xC73D40 Offset: 0xC72340 VA: 0x180C73D40
	internal Uri get_BaseUri() { }

	// RVA: 0xC73E90 Offset: 0xC72490 VA: 0x180C73E90
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x144A690 Offset: 0x1448C90 VA: 0x18144A690
	internal int get_SchemaId() { }

	// RVA: 0x144A680 Offset: 0x1448C80 VA: 0x18144A680
	internal bool get_IsChameleon() { }

	// RVA: 0x144A7A0 Offset: 0x1448DA0 VA: 0x18144A7A0
	internal void set_IsChameleon(bool value) { }

	// RVA: 0x4EF3A0 Offset: 0x4ED9A0 VA: 0x1804EF3A0
	internal Hashtable get_Ids() { }

	// RVA: 0x144A480 Offset: 0x1448A80 VA: 0x18144A480
	internal XmlDocument get_Document() { }

	// RVA: 0x10101F0 Offset: 0x100E7F0 VA: 0x1810101F0
	internal int get_ErrorCount() { }

	// RVA: 0x144A790 Offset: 0x1448D90 VA: 0x18144A790
	internal void set_ErrorCount(int value) { }

	// RVA: 0x14496C0 Offset: 0x1447CC0 VA: 0x1814496C0
	internal XmlSchema Clone() { }

	// RVA: 0x1449A30 Offset: 0x1448030 VA: 0x181449A30
	internal XmlSchema DeepClone() { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x144A150 Offset: 0x1448750 VA: 0x18144A150
	internal void SetIsCompiled(bool isCompiled) { }

	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x14496A0 Offset: 0x1447CA0 VA: 0x1814496A0 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x144A600 Offset: 0x1448C00 VA: 0x18144A600
	internal ArrayList get_ImportedSchemas() { }

	// RVA: 0x144A580 Offset: 0x1448B80 VA: 0x18144A580
	internal ArrayList get_ImportedNamespaces() { }

	// RVA: 0x1449DD0 Offset: 0x14483D0 VA: 0x181449DD0
	internal void GetExternalSchemasList(IList extList, XmlSchema schema) { }

	// RVA: 0x144A160 Offset: 0x1448760 VA: 0x18144A160
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

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x104AF70 Offset: 0x1049570 VA: 0x18104AF70 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x4E8840 Offset: 0x4E6E40 VA: 0x1804E8840 Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x104AED0 Offset: 0x10494D0 VA: 0x18104AED0
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

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_Id() { }

	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	public void set_Id(string value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public XmlSchemaAnnotation get_Annotation() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	public void set_Annotation(XmlSchemaAnnotation value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public XmlAttribute[] get_UnhandledAttributes() { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810
	public void set_UnhandledAttributes(XmlAttribute[] value) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610 Slot: 10
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

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_Id() { }

	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	public void set_Id(string value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x104AFB0 Offset: 0x10495B0 VA: 0x18104AFB0
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

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	public string get_Namespace() { }

	// RVA: 0x4E8840 Offset: 0x4E6E40 VA: 0x1804E8840
	public void set_Namespace(string value) { }

	// RVA: 0x582950 Offset: 0x580F50 VA: 0x180582950
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x104B8E0 Offset: 0x1049EE0 VA: 0x18104B8E0
	internal string get_ResolvedNamespace() { }

	// RVA: 0x104B8C0 Offset: 0x1049EC0 VA: 0x18104B8C0
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x104B560 Offset: 0x1049B60 VA: 0x18104B560 Slot: 15
	internal override string get_NameString() { }

	// RVA: 0x104B460 Offset: 0x1049A60 VA: 0x18104B460
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x104B3B0 Offset: 0x10499B0 VA: 0x18104B3B0
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x104B370 Offset: 0x1049970 VA: 0x18104B370
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x104B500 Offset: 0x1049B00 VA: 0x18104B500
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

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	public void set_Namespace(string value) { }

	// RVA: 0xAE9AA0 Offset: 0xAE80A0 VA: 0x180AE9AA0
	public XmlSchemaContentProcessing get_ProcessContents() { }

	// RVA: 0xD27C30 Offset: 0xD26230 VA: 0x180D27C30
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x104B360 Offset: 0x1049960 VA: 0x18104B360
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x104B100 Offset: 0x1049700 VA: 0x18104B100
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x104B060 Offset: 0x1049660 VA: 0x18104B060
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x104B020 Offset: 0x1049620 VA: 0x18104B020
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x104B260 Offset: 0x1049860 VA: 0x18104B260
	internal static bool IsSubset(XmlSchemaAnyAttribute sub, XmlSchemaAnyAttribute super) { }

	// RVA: 0x104B190 Offset: 0x1049790 VA: 0x18104B190
	internal static XmlSchemaAnyAttribute Intersection(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x104B290 Offset: 0x1049890 VA: 0x18104B290
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

	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	public void set_Source(string value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public XmlNode[] get_Markup() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
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

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public string get_DefaultValue() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	public void set_DefaultValue(string value) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public string get_FixedValue() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	public void set_FixedValue(string value) { }

	// RVA: 0x803B90 Offset: 0x802190 VA: 0x180803B90
	public XmlSchemaForm get_Form() { }

	// RVA: 0x803BC0 Offset: 0x8021C0 VA: 0x180803BC0
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public string get_Name() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	public void set_Name(string value) { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x104BE90 Offset: 0x104A490 VA: 0x18104BE90
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x104BF50 Offset: 0x104A550 VA: 0x18104BF50
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public XmlSchemaSimpleType get_SchemaType() { }

	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	public void set_SchemaType(XmlSchemaSimpleType value) { }

	// RVA: 0x803B70 Offset: 0x802170 VA: 0x180803B70
	public XmlSchemaUse get_Use() { }

	// RVA: 0x803BA0 Offset: 0x8021A0 VA: 0x180803BA0
	public void set_Use(XmlSchemaUse value) { }

	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050
	public XmlSchemaSimpleType get_AttributeSchemaType() { }

	// RVA: 0x104BE70 Offset: 0x104A470 VA: 0x18104BE70
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x574470 Offset: 0x572A70 VA: 0x180574470
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x4E4060 Offset: 0x4E2660 VA: 0x1804E4060
	internal void SetAttributeType(XmlSchemaSimpleType value) { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	internal SchemaAttDef get_AttDef() { }

	// RVA: 0x574410 Offset: 0x572A10 VA: 0x180574410
	internal void set_AttDef(SchemaAttDef value) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x104BCB0 Offset: 0x104A2B0 VA: 0x18104BCB0 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x104BDB0 Offset: 0x104A3B0 VA: 0x18104BDB0
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

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public string get_Name() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	public void set_Name(string value) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x104BC40 Offset: 0x104A240 VA: 0x18104BC40
	internal XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	internal XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x574470 Offset: 0x572A70 VA: 0x180574470
	internal void set_AttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	public XmlSchemaAttributeGroup get_RedefinedAttributeGroup() { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	internal XmlSchemaAttributeGroup get_Redefined() { }

	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460
	internal void set_Redefined(XmlSchemaAttributeGroup value) { }

	// RVA: 0x58AC70 Offset: 0x589270 VA: 0x18058AC70
	internal int get_SelfReferenceCount() { }

	// RVA: 0xF8C2C0 Offset: 0xF8A8C0 VA: 0x180F8C2C0
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x104BA60 Offset: 0x104A060 VA: 0x18104BA60 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x104BB90 Offset: 0x104A190 VA: 0x18104BB90
	public void .ctor() { }

}

public class XmlSchemaAttributeGroupRef : XmlSchemaAnnotated // TypeDefIndex: 2315
{	// Fields
	private XmlQualifiedName refName; // 0x50

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8DAE0 Offset: 0x8CEE0 VA: 0x18008DAE0
	public XmlQualifiedName RefName { get; set; }

	// Methods

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x104B9A0 Offset: 0x1049FA0 VA: 0x18104B9A0
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x104B920 Offset: 0x1049F20 VA: 0x18104B920
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

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x104C0B0 Offset: 0x104A6B0 VA: 0x18104C0B0 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x4E8840 Offset: 0x4E6E40 VA: 0x1804E8840 Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x104C010 Offset: 0x104A610 VA: 0x18104C010
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

	// RVA: 0x104CBD0 Offset: 0x104B1D0 VA: 0x18104CBD0
	public void .ctor(XmlNameTable nametable) { }

	// RVA: 0x104CB10 Offset: 0x104B110 VA: 0x18104CB10
	public int get_Count() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public XmlNameTable get_NameTable() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x104CCE0 Offset: 0x104B2E0 VA: 0x18104CCE0
	public XmlSchema get_Item(string ns) { }

	// RVA: 0x104CB40 Offset: 0x104B140 VA: 0x18104CB40 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x104C750 Offset: 0x104AD50 VA: 0x18104C750
	public XmlSchemaCollectionEnumerator GetEnumerator() { }

	// RVA: 0x104C930 Offset: 0x104AF30 VA: 0x18104C930 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x104CB10 Offset: 0x104B110 VA: 0x18104CB10 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x104C7E0 Offset: 0x104ADE0 VA: 0x18104C7E0
	internal SchemaInfo GetSchemaInfo(string ns) { }

	// RVA: 0x104C880 Offset: 0x104AE80 VA: 0x18104C880
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x104C300 Offset: 0x104A900 VA: 0x18104C300
	internal XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile) { }

	// RVA: 0x104C5D0 Offset: 0x104ABD0 VA: 0x18104C5D0
	private XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile, XmlResolver resolver) { }

	// RVA: 0x104C480 Offset: 0x104AA80 VA: 0x18104C480
	private void Add(string ns, XmlSchemaCollectionNode node) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	internal ValidationEventHandler get_EventHandler() { }

	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
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

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	internal void set_NamespaceURI(string value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal SchemaInfo get_SchemaInfo() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
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

	// RVA: 0x104C1C0 Offset: 0x104A7C0 VA: 0x18104C1C0
	internal void .ctor(Hashtable collection) { }

	// RVA: 0x104C160 Offset: 0x104A760 VA: 0x18104C160 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x104C110 Offset: 0x104A710 VA: 0x18104C110 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x104C0C0 Offset: 0x104A6C0 VA: 0x18104C0C0
	public bool MoveNext() { }

	// RVA: 0x104C1B0 Offset: 0x104A7B0 VA: 0x18104C1B0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x104C280 Offset: 0x104A880 VA: 0x18104C280
	public XmlSchema get_Current() { }

	// RVA: 0x104C210 Offset: 0x104A810 VA: 0x18104C210
	internal XmlSchemaCollectionNode get_CurrentNode() { }

}

public sealed class XmlSchemaCompilationSettings // TypeDefIndex: 2320
{	// Fields
	private bool enableUpaCheck; // 0x10

	// Properties
	public bool EnableUpaCheck { get; }

	// Methods

	// RVA: 0x104CD80 Offset: 0x104B380 VA: 0x18104CD80
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

	// RVA: 0x592630 Offset: 0x590C30 VA: 0x180592630
	public bool get_IsMixed() { }

	// RVA: 0x104D080 Offset: 0x104B680 VA: 0x18104D080
	public void set_IsMixed(bool value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 14
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890 Slot: 15
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0xAF5FA0 Offset: 0xAF45A0 VA: 0x180AF5FA0
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

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x104CE50 Offset: 0x104B450 VA: 0x18104CE50
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x104CDA0 Offset: 0x104B3A0 VA: 0x18104CDA0
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

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x104CFC0 Offset: 0x104B5C0 VA: 0x18104CFC0
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x104CF10 Offset: 0x104B510 VA: 0x18104CF10
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

	// RVA: 0x104EF40 Offset: 0x104D540 VA: 0x18104EF40
	private static void .cctor() { }

	// RVA: 0x104E640 Offset: 0x104CC40 VA: 0x18104E640
	private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents) { }

	// RVA: 0x104F210 Offset: 0x104D810 VA: 0x18104F210
	public void .ctor() { }

	// RVA: 0x104F310 Offset: 0x104D910 VA: 0x18104F310
	internal static XmlSchemaComplexType get_AnyType() { }

	// RVA: 0x104F520 Offset: 0x104DB20 VA: 0x18104F520
	internal static XmlSchemaComplexType get_UntypedAnyType() { }

	// RVA: 0x104F290 Offset: 0x104D890 VA: 0x18104F290
	internal static ContentValidator get_AnyTypeContentValidator() { }

	// RVA: 0x104F480 Offset: 0x104DA80 VA: 0x18104F480
	public bool get_IsAbstract() { }

	// RVA: 0x104F5C0 Offset: 0x104DBC0 VA: 0x18104F5C0
	public void set_IsAbstract(bool value) { }

	// RVA: 0xB9B530 Offset: 0xB99B30 VA: 0x180B9B530
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x104F580 Offset: 0x104DB80 VA: 0x18104F580
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x104F490 Offset: 0x104DA90 VA: 0x18104F490 Slot: 14
	public override bool get_IsMixed() { }

	// RVA: 0x104F5F0 Offset: 0x104DBF0 VA: 0x18104F5F0 Slot: 15
	public override void set_IsMixed(bool value) { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public XmlSchemaContentModel get_ContentModel() { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	public void set_ContentModel(XmlSchemaContentModel value) { }

	// RVA: 0x952CA0 Offset: 0x9512A0 VA: 0x180952CA0
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0xC73F50 Offset: 0xC72550 VA: 0x180C73F50
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x104F3F0 Offset: 0x104D9F0 VA: 0x18104F3F0
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x7AD080 Offset: 0x7AB680 VA: 0x1807AD080
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0xA4D4F0 Offset: 0xA4BAF0 VA: 0x180A4D4F0
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0xD27AA0 Offset: 0xD260A0 VA: 0x180D27AA0
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x104F470 Offset: 0x104DA70 VA: 0x18104F470
	public XmlSchemaParticle get_ContentTypeParticle() { }

	// RVA: 0xAE2D00 Offset: 0xAE1300 VA: 0x180AE2D00
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x104F370 Offset: 0x104D970 VA: 0x18104F370
	public XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x4EF3A0 Offset: 0x4ED9A0 VA: 0x1804EF3A0
	public XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x104F4A0 Offset: 0x104DAA0 VA: 0x18104F4A0
	internal XmlSchemaObjectTable get_LocalElements() { }

	// RVA: 0xEFB1E0 Offset: 0xEF97E0 VA: 0x180EFB1E0
	internal void SetContentTypeParticle(XmlSchemaParticle value) { }

	// RVA: 0x104EF30 Offset: 0x104D530 VA: 0x18104EF30
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x4EF3B0 Offset: 0x4ED9B0 VA: 0x1804EF3B0
	internal void SetAttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x104F590 Offset: 0x104DB90 VA: 0x18104F590
	internal void set_HasWildCard(bool value) { }

	// RVA: 0xA4D4E0 Offset: 0xA4BAE0 VA: 0x180A4D4E0
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x104E410 Offset: 0x104CA10 VA: 0x18104E410
	internal bool ContainsIdAttribute(bool findAll) { }

	// RVA: 0x104E400 Offset: 0x104CA00 VA: 0x18104E400 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x104D9F0 Offset: 0x104BFF0 VA: 0x18104D9F0
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x104D090 Offset: 0x104B690 VA: 0x18104D090
	private void ClearCompiledState() { }

	// RVA: 0x104D150 Offset: 0x104B750 VA: 0x18104D150
	internal static XmlSchemaObjectCollection CloneAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x104D3E0 Offset: 0x104B9E0 VA: 0x18104D3E0
	private static XmlSchemaObjectCollection CloneGroupBaseParticles(XmlSchemaObjectCollection groupBaseParticles, XmlSchema parentSchema) { }

	// RVA: 0x104D520 Offset: 0x104BB20 VA: 0x18104D520
	internal static XmlSchemaParticle CloneParticle(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x104EA80 Offset: 0x104D080 VA: 0x18104EA80
	private static XmlSchemaForm GetResolvedElementForm(XmlSchema parentSchema, XmlSchemaElement element) { }

	// RVA: 0x104EC20 Offset: 0x104D220 VA: 0x18104EC20
	internal static bool HasParticleRef(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x104EAB0 Offset: 0x104D0B0 VA: 0x18104EAB0
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

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 7
	public virtual XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 8
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

	// RVA: 0x1050110 Offset: 0x104E710 VA: 0x181050110
	internal string get_TypeCodeString() { }

	// RVA: 0x104FBE0 Offset: 0x104E1E0 VA: 0x18104FBE0
	internal string TypeCodeToString(XmlTypeCode typeCode) { }

	// RVA: 0x104F620 Offset: 0x104DC20 VA: 0x18104F620
	internal static string ConcatenatedToString(object value) { }

	// RVA: 0x104FB90 Offset: 0x104E190 VA: 0x18104FB90
	internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x104FB40 Offset: 0x104E140 VA: 0x18104FB40
	internal static XmlSchemaDatatype FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x104FAE0 Offset: 0x104E0E0 VA: 0x18104FAE0
	internal static XmlSchemaDatatype FromXdrName(string name) { }

	// RVA: 0x104FA70 Offset: 0x104E070 VA: 0x18104FA70
	internal static XmlSchemaDatatype DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x104FF70 Offset: 0x104E570 VA: 0x18104FF70
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

	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	public void set_Source(string value) { }

	// RVA: 0x10502D0 Offset: 0x104E8D0 VA: 0x1810502D0
	public void set_Language(string value) { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1050240 Offset: 0x104E840 VA: 0x181050240
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

	// RVA: 0x955B10 Offset: 0x954110 VA: 0x180955B10
	public bool get_IsAbstract() { }

	// RVA: 0x1050880 Offset: 0x104EE80 VA: 0x181050880
	public void set_IsAbstract(bool value) { }

	// RVA: 0x582940 Offset: 0x580F40 VA: 0x180582940
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x582950 Offset: 0x580F50 VA: 0x180582950
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050
	public string get_DefaultValue() { }

	// RVA: 0x4E4060 Offset: 0x4E2660 VA: 0x1804E4060
	public void set_DefaultValue(string value) { }

	// RVA: 0x10507D0 Offset: 0x104EDD0 VA: 0x1810507D0
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x1050870 Offset: 0x104EE70 VA: 0x181050870
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public string get_FixedValue() { }

	// RVA: 0x574410 Offset: 0x572A10 VA: 0x180574410
	public void set_FixedValue(string value) { }

	// RVA: 0x58AC70 Offset: 0x589270 VA: 0x18058AC70
	public XmlSchemaForm get_Form() { }

	// RVA: 0xF8C2C0 Offset: 0xF8A8C0 VA: 0x180F8C2C0
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public string get_Name() { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	public void set_Name(string value) { }

	// RVA: 0x1050830 Offset: 0x104EE30 VA: 0x181050830
	public bool get_IsNillable() { }

	// RVA: 0x1050890 Offset: 0x104EE90 VA: 0x181050890
	public void set_IsNillable(bool value) { }

	// RVA: 0x1050820 Offset: 0x104EE20 VA: 0x181050820
	internal bool get_HasNillableAttribute() { }

	// RVA: 0x10507E0 Offset: 0x104EDE0 VA: 0x1810507E0
	internal bool get_HasAbstractAttribute() { }

	// RVA: 0x952CA0 Offset: 0x9512A0 VA: 0x180952CA0
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x10508A0 Offset: 0x104EEA0 VA: 0x1810508A0
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x9922B0 Offset: 0x9908B0 VA: 0x1809922B0
	public XmlQualifiedName get_SubstitutionGroup() { }

	// RVA: 0x1050A20 Offset: 0x104F020 VA: 0x181050A20
	public void set_SubstitutionGroup(XmlQualifiedName value) { }

	// RVA: 0x7AD080 Offset: 0x7AB680 VA: 0x1807AD080
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x1050960 Offset: 0x104EF60 VA: 0x181050960
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x104F470 Offset: 0x104DA70 VA: 0x18104F470
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0xEFB1E0 Offset: 0xEF97E0 VA: 0x180EFB1E0
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x1050740 Offset: 0x104ED40 VA: 0x181050740
	public XmlSchemaObjectCollection get_Constraints() { }

	// RVA: 0xDA03A0 Offset: 0xD9E9A0 VA: 0x180DA03A0
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0xC73D40 Offset: 0xC72340 VA: 0x180C73D40
	public XmlSchemaType get_ElementSchemaType() { }

	// RVA: 0x1050730 Offset: 0x104ED30 VA: 0x181050730
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x10507C0 Offset: 0x104EDC0 VA: 0x1810507C0
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0xDA0780 Offset: 0xD9ED80 VA: 0x180DA0780
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0xC73E90 Offset: 0xC72490 VA: 0x180C73E90
	internal void SetElementType(XmlSchemaType value) { }

	// RVA: 0x1050600 Offset: 0x104EC00 VA: 0x181050600
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1050610 Offset: 0x104EC10 VA: 0x181050610
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10507F0 Offset: 0x104EDF0 VA: 0x1810507F0
	internal bool get_HasConstraints() { }

	// RVA: 0x966200 Offset: 0x964800 VA: 0x180966200
	internal bool get_IsLocalTypeDerivationChecked() { }

	// RVA: 0x966210 Offset: 0x964810 VA: 0x180966210
	internal void set_IsLocalTypeDerivationChecked(bool value) { }

	// RVA: 0x872250 Offset: 0x870850 VA: 0x180872250
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x8722D0 Offset: 0x8708D0 VA: 0x1808722D0
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1050840 Offset: 0x104EE40 VA: 0x181050840 Slot: 15
	internal override string get_NameString() { }

	// RVA: 0x10505F0 Offset: 0x104EBF0 VA: 0x1810505F0 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10503A0 Offset: 0x104E9A0 VA: 0x1810503A0
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x1050620 Offset: 0x104EC20 VA: 0x181050620
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

	// RVA: 0x10514B0 Offset: 0x104FAB0 VA: 0x1810514B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1050B80 Offset: 0x104F180 VA: 0x181050B80 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10518A0 Offset: 0x104FEA0 VA: 0x1810518A0
	public void .ctor() { }

	// RVA: 0x1050F10 Offset: 0x104F510 VA: 0x181050F10
	public void .ctor(string message) { }

	// RVA: 0x10513A0 Offset: 0x104F9A0 VA: 0x1810513A0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1051060 Offset: 0x104F660 VA: 0x181051060
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x1051800 Offset: 0x104FE00 VA: 0x181051800
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x1050DD0 Offset: 0x104F3D0 VA: 0x181050DD0
	internal void .ctor(string res, string arg) { }

	// RVA: 0x1051290 Offset: 0x104F890 VA: 0x181051290
	internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1050D90 Offset: 0x104F390 VA: 0x181050D90
	internal void .ctor(string res, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0xD27DF0 Offset: 0xD263F0 VA: 0x180D27DF0
	internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1050D40 Offset: 0x104F340 VA: 0x181050D40
	internal void .ctor(string res, XmlSchemaObject source) { }

	// RVA: 0x1051180 Offset: 0x104F780 VA: 0x181051180
	internal void .ctor(string res, string arg, XmlSchemaObject source) { }

	// RVA: 0x1051010 Offset: 0x104F610 VA: 0x181051010
	internal void .ctor(string res, string[] args, XmlSchemaObject source) { }

	// RVA: 0x1051960 Offset: 0x104FF60 VA: 0x181051960
	internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source) { }

	// RVA: 0x1050B00 Offset: 0x104F100 VA: 0x181050B00
	internal static string CreateMessage(string res, string[] args) { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	internal string get_GetRes() { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050
	internal string[] get_Args() { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public string get_SourceUri() { }

	// RVA: 0x1051A20 Offset: 0x1050020 VA: 0x181051A20
	public int get_LineNumber() { }

	// RVA: 0x1051A30 Offset: 0x1050030 VA: 0x181051A30
	public int get_LinePosition() { }

	// RVA: 0x952CA0 Offset: 0x9512A0 VA: 0x180952CA0
	public XmlSchemaObject get_SourceSchemaObject() { }

	// RVA: 0x1050C90 Offset: 0x104F290 VA: 0x181050C90
	internal void SetSource(string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0xC73F50 Offset: 0xC72550 VA: 0x180C73F50
	internal void SetSchemaObject(XmlSchemaObject source) { }

	// RVA: 0x1050CE0 Offset: 0x104F2E0 VA: 0x181050CE0
	internal void SetSource(XmlSchemaObject source) { }

	// RVA: 0x1051A40 Offset: 0x1050040 VA: 0x181051A40 Slot: 5
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

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_SchemaLocation() { }

	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	public void set_SchemaLocation(string value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public XmlSchema get_Schema() { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810
	public void set_Schema(XmlSchema value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public string get_Id() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	public void set_Id(string value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal Uri get_BaseUri() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x5743B0 Offset: 0x5729B0 VA: 0x1805743B0
	internal Compositor get_Compositor() { }

	// RVA: 0x574440 Offset: 0x572A40 VA: 0x180574440
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

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public string get_Value() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	public void set_Value(string value) { }

	// RVA: 0x592630 Offset: 0x590C30 VA: 0x180592630 Slot: 14
	public virtual bool get_IsFixed() { }

	// RVA: 0x1051A60 Offset: 0x1050060 VA: 0x181051A60 Slot: 15
	public virtual void set_IsFixed(bool value) { }

	// RVA: 0x5743A0 Offset: 0x5729A0 VA: 0x1805743A0
	internal FacetType get_FacetType() { }

	// RVA: 0x574430 Offset: 0x572A30 VA: 0x180574430
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

	// RVA: 0x105C9C0 Offset: 0x105AFC0 VA: 0x18105C9C0
	public void .ctor() { }

}

public class XmlSchemaMinLengthFacet : XmlSchemaNumericFacet // TypeDefIndex: 2339
{	// Methods

	// RVA: 0x105CA80 Offset: 0x105B080 VA: 0x18105CA80
	public void .ctor() { }

}

public class XmlSchemaMaxLengthFacet : XmlSchemaNumericFacet // TypeDefIndex: 2340
{	// Methods

	// RVA: 0x105CA20 Offset: 0x105B020 VA: 0x18105CA20
	public void .ctor() { }

}

public class XmlSchemaPatternFacet : XmlSchemaFacet // TypeDefIndex: 2341
{	// Methods

	// RVA: 0x105E740 Offset: 0x105CD40 VA: 0x18105E740
	public void .ctor() { }

}

public class XmlSchemaEnumerationFacet : XmlSchemaFacet // TypeDefIndex: 2342
{	// Methods

	// RVA: 0x1050AE0 Offset: 0x104F0E0 VA: 0x181050AE0
	public void .ctor() { }

}

public class XmlSchemaMinExclusiveFacet : XmlSchemaFacet // TypeDefIndex: 2343
{	// Methods

	// RVA: 0x105CA40 Offset: 0x105B040 VA: 0x18105CA40
	public void .ctor() { }

}

public class XmlSchemaMinInclusiveFacet : XmlSchemaFacet // TypeDefIndex: 2344
{	// Methods

	// RVA: 0x105CA60 Offset: 0x105B060 VA: 0x18105CA60
	public void .ctor() { }

}

public class XmlSchemaMaxExclusiveFacet : XmlSchemaFacet // TypeDefIndex: 2345
{	// Methods

	// RVA: 0x105C9E0 Offset: 0x105AFE0 VA: 0x18105C9E0
	public void .ctor() { }

}

public class XmlSchemaMaxInclusiveFacet : XmlSchemaFacet // TypeDefIndex: 2346
{	// Methods

	// RVA: 0x105CA00 Offset: 0x105B000 VA: 0x18105CA00
	public void .ctor() { }

}

public class XmlSchemaTotalDigitsFacet : XmlSchemaNumericFacet // TypeDefIndex: 2347
{	// Methods

	// RVA: 0xD27460 Offset: 0xD25A60 VA: 0x180D27460
	public void .ctor() { }

}

public class XmlSchemaFractionDigitsFacet : XmlSchemaNumericFacet // TypeDefIndex: 2348
{	// Methods

	// RVA: 0x1051B20 Offset: 0x1050120 VA: 0x181051B20
	public void .ctor() { }

}

public class XmlSchemaWhiteSpaceFacet : XmlSchemaFacet // TypeDefIndex: 2349
{	// Methods

	// RVA: 0xD35340 Offset: 0xD33940 VA: 0x180D35340
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

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public string get_Name() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	public void set_Name(string value) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	public void set_Particle(XmlSchemaGroupBase value) { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	internal XmlSchemaParticle get_CanonicalParticle() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	internal void set_CanonicalParticle(XmlSchemaParticle value) { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0xAF6020 Offset: 0xAF4620 VA: 0x180AF6020
	internal int get_SelfReferenceCount() { }

	// RVA: 0xB28F90 Offset: 0xB27590 VA: 0x180B28F90
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1051CF0 Offset: 0x10502F0 VA: 0x181051CF0 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1051D00 Offset: 0x1050300 VA: 0x181051D00
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x1051EC0 Offset: 0x10504C0 VA: 0x181051EC0
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

	// RVA: 0x1051B40 Offset: 0x1050140 VA: 0x181051B40
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

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x1051C30 Offset: 0x1050230 VA: 0x181051C30
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x574470 Offset: 0x572A70 VA: 0x180574470
	internal void SetParticle(XmlSchemaGroupBase value) { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x1051BA0 Offset: 0x10501A0 VA: 0x181051BA0
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

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public string get_Name() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	public void set_Name(string value) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public XmlSchemaXPath get_Selector() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	public void set_Selector(XmlSchemaXPath value) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public XmlSchemaObjectCollection get_Fields() { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	internal CompiledIdentityConstraint get_CompiledConstraint() { }

	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460
	internal void set_CompiledConstraint(CompiledIdentityConstraint value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1051F40 Offset: 0x1050540 VA: 0x181051F40
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

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public string get_XPath() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	public void set_XPath(string value) { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

}

public class XmlSchemaUnique : XmlSchemaIdentityConstraint // TypeDefIndex: 2356
{	// Methods

	// RVA: 0xD27C40 Offset: 0xD26240 VA: 0x180D27C40
	public void .ctor() { }

}

public class XmlSchemaKey : XmlSchemaIdentityConstraint // TypeDefIndex: 2357
{	// Methods

	// RVA: 0xD27C40 Offset: 0xD26240 VA: 0x180D27C40
	public void .ctor() { }

}

public class XmlSchemaKeyref : XmlSchemaIdentityConstraint // TypeDefIndex: 2358
{	// Fields
	private XmlQualifiedName refer; // 0x78

	// Properties
	[XmlAttributeAttribute] // RVA: 0x96090 Offset: 0x95490 VA: 0x180096090
	public XmlQualifiedName Refer { get; set; }

	// Methods

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	public XmlQualifiedName get_Refer() { }

	// RVA: 0x105C900 Offset: 0x105AF00 VA: 0x18105C900
	public void set_Refer(XmlQualifiedName value) { }

	// RVA: 0x105C880 Offset: 0x105AE80 VA: 0x18105C880
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

	// RVA: 0x1051FF0 Offset: 0x10505F0 VA: 0x181051FF0
	public void .ctor() { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public string get_Namespace() { }

	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50
	public void set_Namespace(string value) { }

	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

}

public class XmlSchemaInclude : XmlSchemaExternal // TypeDefIndex: 2360
{	// Fields
	private XmlSchemaAnnotation annotation; // 0x68

	// Methods

	// RVA: 0x1052010 Offset: 0x1050610 VA: 0x181052010
	public void .ctor() { }

	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50 Slot: 10
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

	// RVA: 0x105C6B0 Offset: 0x105ACB0 VA: 0x18105C6B0
	public void .ctor() { }

	// RVA: 0x105C630 Offset: 0x105AC30 VA: 0x18105C630
	internal void .ctor(XmlSchemaValidity validity) { }

	// RVA: 0x6BBA50 Offset: 0x6BA050 VA: 0x1806BBA50 Slot: 4
	public XmlSchemaValidity get_Validity() { }

	// RVA: 0xC74BD0 Offset: 0xC731D0 VA: 0x180C74BD0
	public void set_Validity(XmlSchemaValidity value) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90 Slot: 5
	public bool get_IsDefault() { }

	// RVA: 0x49AFC0 Offset: 0x4995C0 VA: 0x18049AFC0
	public void set_IsDefault(bool value) { }

	// RVA: 0xF8B670 Offset: 0xF89C70 VA: 0x180F8B670 Slot: 6
	public bool get_IsNil() { }

	// RVA: 0xF8B680 Offset: 0xF89C80 VA: 0x180F8B680
	public void set_IsNil(bool value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 7
	public XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	public void set_MemberType(XmlSchemaSimpleType value) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 8
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0x105C830 Offset: 0x105AE30 VA: 0x18105C830
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	public XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x105C7F0 Offset: 0x105ADF0 VA: 0x18105C7F0
	public void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 10
	public XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x105C7B0 Offset: 0x105ADB0 VA: 0x18105C7B0
	public void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x105C7A0 Offset: 0x105ADA0 VA: 0x18105C7A0
	internal XmlSchemaType get_XmlType() { }

	// RVA: 0x105C720 Offset: 0x105AD20 VA: 0x18105C720
	internal bool get_HasDefaultValue() { }

	// RVA: 0x105C760 Offset: 0x105AD60 VA: 0x18105C760
	internal bool get_IsUnionType() { }

	// RVA: 0x105C5C0 Offset: 0x105ABC0 VA: 0x18105C5C0
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

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public string get_Name() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	public void set_Name(string value) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public string get_Public() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	public void set_Public(string value) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public string get_System() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	public void set_System(string value) { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	internal XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50
	internal void set_QualifiedName(XmlQualifiedName value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x105CAA0 Offset: 0x105B0A0 VA: 0x18105CAA0
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

	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0
	public void set_LineNumber(int value) { }

	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0
	public int get_LinePosition() { }

	// RVA: 0x57C9F0 Offset: 0x57AFF0 VA: 0x18057C9F0
	public void set_LinePosition(int value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_SourceUri() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_SourceUri(string value) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public XmlSchemaObject get_Parent() { }

	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	public void set_Parent(XmlSchemaObject value) { }

	// RVA: 0x105DB30 Offset: 0x105C130 VA: 0x18105DB30
	public XmlSerializerNamespaces get_Namespaces() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_Namespaces(XmlSerializerNamespaces value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	internal virtual void OnAdd(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	internal virtual void OnRemove(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	internal virtual void OnClear(XmlSchemaObjectCollection container) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 7
	internal virtual string get_IdAttribute() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	internal virtual void set_IdAttribute(string value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 11
	internal virtual string get_NameAttribute() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	internal virtual void set_NameAttribute(string value) { }

	// RVA: 0x82BDA0 Offset: 0x82A3A0 VA: 0x18082BDA0
	internal bool get_IsProcessing() { }

	// RVA: 0x82BDD0 Offset: 0x82A3D0 VA: 0x18082BDD0
	internal void set_IsProcessing(bool value) { }

	// RVA: 0x105DAB0 Offset: 0x105C0B0 VA: 0x18105DAB0 Slot: 13
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

	// RVA: 0x105CF40 Offset: 0x105B540 VA: 0x18105CF40
	public void .ctor() { }

	// RVA: 0x105CF50 Offset: 0x105B550 VA: 0x18105CF50 Slot: 28
	public virtual XmlSchemaObject get_Item(int index) { }

	// RVA: 0x105D070 Offset: 0x105B670 VA: 0x18105D070 Slot: 29
	public virtual void set_Item(int index, XmlSchemaObject value) { }

	// RVA: 0x105CCB0 Offset: 0x105B2B0 VA: 0x18105CCB0
	public XmlSchemaObjectEnumerator GetEnumerator() { }

	// RVA: 0x105CB60 Offset: 0x105B160 VA: 0x18105CB60
	public int Add(XmlSchemaObject item) { }

	// RVA: 0x105CD40 Offset: 0x105B340 VA: 0x18105CD40
	public void Insert(int index, XmlSchemaObject item) { }

	// RVA: 0x105CE80 Offset: 0x105B480 VA: 0x18105CE80
	public void Remove(XmlSchemaObject item) { }

	// RVA: 0x105CDE0 Offset: 0x105B3E0 VA: 0x18105CDE0 Slot: 20
	protected override void OnInsert(int index, object item) { }

	// RVA: 0x105CE20 Offset: 0x105B420 VA: 0x18105CE20 Slot: 19
	protected override void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x105CDC0 Offset: 0x105B3C0 VA: 0x18105CDC0 Slot: 21
	protected override void OnClear() { }

	// RVA: 0x105CE00 Offset: 0x105B400 VA: 0x18105CE00 Slot: 22
	protected override void OnRemove(int index, object item) { }

	// RVA: 0x105CC20 Offset: 0x105B220 VA: 0x18105CC20
	internal XmlSchemaObjectCollection Clone() { }

	// RVA: 0x105CB20 Offset: 0x105B120 VA: 0x18105CB20
	private void Add(XmlSchemaObjectCollection collToAdd) { }

}

public class XmlSchemaObjectEnumerator : IEnumerator // TypeDefIndex: 2365
{	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public XmlSchemaObject Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	internal void .ctor(IEnumerator enumerator) { }

	// RVA: 0x105D0F0 Offset: 0x105B6F0 VA: 0x18105D0F0
	public bool MoveNext() { }

	// RVA: 0x105D230 Offset: 0x105B830 VA: 0x18105D230
	public XmlSchemaObject get_Current() { }

	// RVA: 0x105D190 Offset: 0x105B790 VA: 0x18105D190 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x105D140 Offset: 0x105B740 VA: 0x18105D140 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x105D1E0 Offset: 0x105B7E0 VA: 0x18105D1E0 Slot: 5
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

	// RVA: 0x105D8B0 Offset: 0x105BEB0 VA: 0x18105D8B0
	internal void .ctor() { }

	// RVA: 0x105D2D0 Offset: 0x105B8D0 VA: 0x18105D2D0
	internal void Add(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x105D5B0 Offset: 0x105BBB0 VA: 0x18105D5B0
	internal void Insert(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x105D790 Offset: 0x105BD90 VA: 0x18105D790
	internal void Replace(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x105D390 Offset: 0x105B990 VA: 0x18105D390
	internal void Clear() { }

	// RVA: 0x105D6E0 Offset: 0x105BCE0 VA: 0x18105D6E0
	internal void Remove(XmlQualifiedName name) { }

	// RVA: 0x105D450 Offset: 0x105BA50 VA: 0x18105D450
	private int FindIndexByValue(XmlSchemaObject xso) { }

	// RVA: 0x105D950 Offset: 0x105BF50 VA: 0x18105D950
	public int get_Count() { }

	// RVA: 0x105D3F0 Offset: 0x105B9F0 VA: 0x18105D3F0
	public bool Contains(XmlQualifiedName name) { }

	// RVA: 0x105D9A0 Offset: 0x105BFA0 VA: 0x18105D9A0
	public XmlSchemaObject get_Item(XmlQualifiedName name) { }

	// RVA: 0x105DA20 Offset: 0x105C020 VA: 0x18105DA20
	public ICollection get_Values() { }

	// RVA: 0x105D510 Offset: 0x105BB10 VA: 0x18105D510
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

	// RVA: 0xF5A50 Offset: 0xF4E50 VA: 0x1800F5A50
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

	// RVA: 0xAE4770 Offset: 0xAE2D70 VA: 0x180AE4770
	internal void .ctor(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size) { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470 Slot: 5
	public int get_Count() { }

	// RVA: 0x104A6A0 Offset: 0x1048CA0 VA: 0x18104A6A0 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x104A4F0 Offset: 0x1048AF0 VA: 0x18104A4F0 Slot: 4
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x104A620 Offset: 0x1048C20 VA: 0x18104A620 Slot: 7
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

	// RVA: 0x104A6F0 Offset: 0x1048CF0 VA: 0x18104A6F0
	internal void .ctor(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, XmlSchemaObjectTable.EnumeratorType enumType) { }

	// RVA: 0x104ACF0 Offset: 0x10492F0 VA: 0x18104ACF0 Slot: 5
	public object get_Current() { }

	// RVA: 0x104ABB0 Offset: 0x10491B0 VA: 0x18104ABB0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x104ACB0 Offset: 0x10492B0 VA: 0x18104ACB0 Slot: 6
	public void Reset() { }

}

internal class XmlSchemaObjectTable.XSODictionaryEnumerator : XmlSchemaObjectTable.XSOEnumerator, IDictionaryEnumerator, IEnumerator // TypeDefIndex: 2371
{	// Properties
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x104A6F0 Offset: 0x1048CF0 VA: 0x18104A6F0
	internal void .ctor(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, XmlSchemaObjectTable.EnumeratorType enumType) { }

	// RVA: 0x104A750 Offset: 0x1048D50 VA: 0x18104A750 Slot: 9
	public DictionaryEntry get_Entry() { }

	// RVA: 0x104A8D0 Offset: 0x1048ED0 VA: 0x18104A8D0 Slot: 7
	public object get_Key() { }

	// RVA: 0x104AA40 Offset: 0x1049040 VA: 0x18104AA40 Slot: 8
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

	// RVA: 0x105DFE0 Offset: 0x105C5E0 VA: 0x18105DFE0
	public string get_MinOccursString() { }

	// RVA: 0x105E490 Offset: 0x105CA90 VA: 0x18105E490
	public void set_MinOccursString(string value) { }

	// RVA: 0x105DED0 Offset: 0x105C4D0 VA: 0x18105DED0
	public string get_MaxOccursString() { }

	// RVA: 0x105E0B0 Offset: 0x105C6B0 VA: 0x18105E0B0
	public void set_MaxOccursString(string value) { }

	// RVA: 0x105E060 Offset: 0x105C660 VA: 0x18105E060
	public Decimal get_MinOccurs() { }

	// RVA: 0x105E600 Offset: 0x105CC00 VA: 0x18105E600
	public void set_MinOccurs(Decimal value) { }

	// RVA: 0xC32100 Offset: 0xC30700 VA: 0x180C32100
	public Decimal get_MaxOccurs() { }

	// RVA: 0x105E2E0 Offset: 0x105C8E0 VA: 0x18105E2E0
	public void set_MaxOccurs(Decimal value) { }

	// RVA: 0x105DE40 Offset: 0x105C440 VA: 0x18105DE40 Slot: 14
	internal virtual bool get_IsEmpty() { }

	// RVA: 0x105E070 Offset: 0x105C670 VA: 0x18105E070 Slot: 15
	internal virtual string get_NameString() { }

	// RVA: 0x105DBA0 Offset: 0x105C1A0 VA: 0x18105DBA0
	internal XmlQualifiedName GetQualifiedName() { }

	// RVA: 0x105DDC0 Offset: 0x105C3C0 VA: 0x18105DDC0
	protected void .ctor() { }

	// RVA: 0x105DD20 Offset: 0x105C320 VA: 0x18105DD20
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

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x104A490 Offset: 0x1048A90 VA: 0x18104A490
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

	// RVA: 0x105E780 Offset: 0x105CD80 VA: 0x18105E780
	public void .ctor() { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x105E760 Offset: 0x105CD60 VA: 0x18105E760 Slot: 10
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

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x104AF70 Offset: 0x1049570 VA: 0x18104AF70 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x4E8840 Offset: 0x4E6E40 VA: 0x1804E8840 Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x105E870 Offset: 0x105CE70 VA: 0x18105E870
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

	// RVA: 0x1067670 Offset: 0x1065C70 VA: 0x181067670
	internal object get_InternalSyncObject() { }

	// RVA: 0x10670E0 Offset: 0x10656E0 VA: 0x1810670E0
	public void .ctor() { }

	// RVA: 0x1067140 Offset: 0x1065740 VA: 0x181067140
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x10673D0 Offset: 0x10659D0 VA: 0x1810673D0
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x10677F0 Offset: 0x1065DF0 VA: 0x1810677F0
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x8C1150 Offset: 0x8BF750 VA: 0x1808C1150
	public bool get_IsCompiled() { }

	// RVA: 0x1067890 Offset: 0x1065E90 VA: 0x181067890
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	public XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x4E8840 Offset: 0x4E6E40 VA: 0x1804E8840
	public void set_CompilationSettings(XmlSchemaCompilationSettings value) { }

	// RVA: 0x10674C0 Offset: 0x1065AC0 VA: 0x1810674C0
	public int get_Count() { }

	// RVA: 0x1067570 Offset: 0x1065B70 VA: 0x181067570
	public XmlSchemaObjectTable get_GlobalElements() { }

	// RVA: 0x10674F0 Offset: 0x1065AF0 VA: 0x1810674F0
	public XmlSchemaObjectTable get_GlobalAttributes() { }

	// RVA: 0x10675F0 Offset: 0x1065BF0 VA: 0x1810675F0
	public XmlSchemaObjectTable get_GlobalTypes() { }

	// RVA: 0x10676F0 Offset: 0x1065CF0 VA: 0x1810676F0
	internal XmlSchemaObjectTable get_SubstitutionGroups() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal Hashtable get_SchemaLocations() { }

	// RVA: 0x1067770 Offset: 0x1065D70 VA: 0x181067770
	internal XmlSchemaObjectTable get_TypeExtensions() { }

	// RVA: 0x105F0B0 Offset: 0x105D6B0 VA: 0x18105F0B0
	public void Add(XmlSchemaSet schemas) { }

	// RVA: 0x105FC40 Offset: 0x105E240 VA: 0x18105FC40
	public XmlSchema Add(XmlSchema schema) { }

	// RVA: 0x1064840 Offset: 0x1062E40 VA: 0x181064840
	public bool RemoveRecursive(XmlSchema schemaToRemove) { }

	// RVA: 0x10609C0 Offset: 0x105EFC0 VA: 0x1810609C0
	public bool Contains(string targetNamespace) { }

	// RVA: 0x1060480 Offset: 0x105EA80 VA: 0x181060480
	public void Compile() { }

	// RVA: 0x1066240 Offset: 0x1064840 VA: 0x181066240
	public XmlSchema Reprocess(XmlSchema schema) { }

	// RVA: 0x1062870 Offset: 0x1060E70 VA: 0x181062870
	public void CopyTo(XmlSchema[] schemas, int index) { }

	// RVA: 0x1066ED0 Offset: 0x10654D0 VA: 0x181066ED0
	public ICollection Schemas() { }

	// RVA: 0x1066D20 Offset: 0x1065320 VA: 0x181066D20
	public ICollection Schemas(string targetNamespace) { }

	// RVA: 0x105FBE0 Offset: 0x105E1E0 VA: 0x18105FBE0
	private XmlSchema Add(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x105FE00 Offset: 0x105E400 VA: 0x18105FE00
	internal void Add(string targetNamespace, XmlReader reader, Hashtable validatedNamespaces) { }

	// RVA: 0x10629E0 Offset: 0x1060FE0 VA: 0x1810629E0
	internal XmlSchema FindSchemaByNSAndUrl(Uri schemaUri, string ns, DictionaryEntry[] locationsTable) { }

	// RVA: 0x105E910 Offset: 0x105CF10 VA: 0x18105E910
	private void AddSchemaToSet(XmlSchema schema) { }

	// RVA: 0x1063DE0 Offset: 0x10623E0 VA: 0x181063DE0
	private void ProcessNewSubstitutionGroups(XmlSchemaObjectTable substitutionGroupsTable, bool resolve) { }

	// RVA: 0x1066970 Offset: 0x1064F70 VA: 0x181066970
	private void ResolveSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup, XmlSchemaObjectTable substTable) { }

	// RVA: 0x1065F30 Offset: 0x1064530 VA: 0x181065F30
	internal XmlSchema Remove(XmlSchema schema, bool forceCompile) { }

	// RVA: 0x1060230 Offset: 0x105E830 VA: 0x181060230
	private void ClearTables() { }

	// RVA: 0x1063C90 Offset: 0x1062290 VA: 0x181063C90
	internal bool PreprocessSchema(ref XmlSchema schema, string targetNamespace) { }

	// RVA: 0x1063B70 Offset: 0x1062170 VA: 0x181063B70
	internal XmlSchema ParseSchema(string targetNamespace, XmlReader reader) { }

	// RVA: 0x1060A40 Offset: 0x105F040 VA: 0x181060A40
	internal void CopyFromCompiledSet(XmlSchemaSet otherSet) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	internal SchemaInfo get_CompiledInfo() { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	internal XmlReaderSettings get_ReaderSettings() { }

	// RVA: 0x1062CE0 Offset: 0x10612E0 VA: 0x181062CE0
	internal XmlResolver GetResolver() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0x1062E90 Offset: 0x1061490 VA: 0x181062E90
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x1062FF0 Offset: 0x10615F0 VA: 0x181062FF0
	internal bool IsSchemaLoaded(Uri schemaUri, string targetNamespace, out XmlSchema schema) { }

	// RVA: 0x1062D00 Offset: 0x1061300 VA: 0x181062D00
	internal bool GetSchemaByUri(Uri schemaUri, out XmlSchema schema) { }

	// RVA: 0x1062F40 Offset: 0x1061540 VA: 0x181062F40
	internal string GetTargetNamespace(XmlSchema schema) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal SortedList get_SortedSchemas() { }

	// RVA: 0x1065080 Offset: 0x1063680 VA: 0x181065080
	private void RemoveSchemaFromCaches(XmlSchema schema) { }

	// RVA: 0x10654E0 Offset: 0x1063AE0 VA: 0x1810654E0
	private void RemoveSchemaFromGlobalTables(XmlSchema schema) { }

	// RVA: 0x105ED20 Offset: 0x105D320 VA: 0x18105ED20
	private bool AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x1066FB0 Offset: 0x10655B0 VA: 0x181066FB0
	private void VerifyTables() { }

	// RVA: 0x1062F90 Offset: 0x1061590 VA: 0x181062F90
	private void InternalValidationCallback(object sender, ValidationEventArgs e) { }

	// RVA: 0x1066F00 Offset: 0x1065500 VA: 0x181066F00
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

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 14
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890 Slot: 15
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
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

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0xD26820 Offset: 0xD24E20 VA: 0x180D26820
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0xD26770 Offset: 0xD24D70 VA: 0x180D26770
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

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0xD269B0 Offset: 0xD24FB0 VA: 0x180D269B0
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	public void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0xD268E0 Offset: 0xD24EE0 VA: 0x180D268E0
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

	// RVA: 0xD27230 Offset: 0xD25830 VA: 0x180D27230
	public void .ctor() { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public XmlSchemaSimpleTypeContent get_Content() { }

	// RVA: 0x574410 Offset: 0x572A10 VA: 0x180574410
	public void set_Content(XmlSchemaSimpleTypeContent value) { }

	// RVA: 0xD27100 Offset: 0xD25700 VA: 0x180D27100 Slot: 13
	internal override XmlSchemaObject Clone() { }

}

public abstract class XmlSchemaSimpleTypeContent : XmlSchemaAnnotated // TypeDefIndex: 2382
{	// Methods

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
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

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public XmlQualifiedName get_ItemTypeName() { }

	// RVA: 0xD26BB0 Offset: 0xD251B0 VA: 0x180D26BB0
	public void set_ItemTypeName(XmlQualifiedName value) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public XmlSchemaSimpleType get_ItemType() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	public void set_ItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public XmlSchemaSimpleType get_BaseItemType() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	public void set_BaseItemType(XmlSchemaSimpleType value) { }

	// RVA: 0xD26A70 Offset: 0xD25070 VA: 0x180D26A70 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0xD26B30 Offset: 0xD25130 VA: 0x180D26B30
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

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0xD26DE0 Offset: 0xD253E0 VA: 0x180D26DE0
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	public void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0xD26C70 Offset: 0xD25270 VA: 0x180D26C70 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0xD26D30 Offset: 0xD25330 VA: 0x180D26D30
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

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public XmlSchemaObjectCollection get_BaseTypes() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public XmlQualifiedName[] get_MemberTypes() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	public void set_MemberTypes(XmlQualifiedName[] value) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	internal void SetBaseMemberTypes(XmlSchemaSimpleType[] baseMemberTypes) { }

	// RVA: 0xD26EA0 Offset: 0xD254A0 VA: 0x180D26EA0 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0xD27090 Offset: 0xD25690 VA: 0x180D27090
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

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	internal ArrayList get_Members() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal XmlQualifiedName get_Examplar() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	internal void set_Examplar(XmlQualifiedName value) { }

	// RVA: 0xD273B0 Offset: 0xD259B0 VA: 0x180D273B0
	public void .ctor() { }

}

internal class XmlSchemaSubstitutionGroupV1Compat : XmlSchemaSubstitutionGroup // TypeDefIndex: 2387
{	// Fields
	private XmlSchemaChoice choice; // 0x48

	// Properties
	[XmlIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal XmlSchemaChoice Choice { get; }

	// Methods

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	internal XmlSchemaChoice get_Choice() { }

	// RVA: 0xD272C0 Offset: 0xD258C0 VA: 0x180D272C0
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

	// RVA: 0xD276D0 Offset: 0xD25CD0 VA: 0x180D276D0
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlQualifiedName qualifiedName) { }

	// RVA: 0xD27680 Offset: 0xD25C80 VA: 0x180D27680
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode) { }

	// RVA: 0xD27480 Offset: 0xD25A80 VA: 0x180D27480
	public static XmlSchemaComplexType GetBuiltInComplexType(XmlQualifiedName qualifiedName) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public string get_Name() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	public void set_Name(string value) { }

	// RVA: 0xAE9AA0 Offset: 0xAE80A0 VA: 0x180AE9AA0
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0xD27C30 Offset: 0xD26230 VA: 0x180D27C30
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0xD27A80 Offset: 0xD26080 VA: 0x180D27A80
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x803B80 Offset: 0x802180 VA: 0x180803B80
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public XmlSchemaType get_BaseXmlSchemaType() { }

	// RVA: 0x5743A0 Offset: 0x5729A0 VA: 0x1805743A0
	public XmlSchemaDerivationMethod get_DerivedBy() { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 14
	public virtual bool get_IsMixed() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 15
	public virtual void set_IsMixed(bool value) { }

	// RVA: 0xD27AB0 Offset: 0xD260B0 VA: 0x180D27AB0
	public XmlTypeCode get_TypeCode() { }

	// RVA: 0xD27B80 Offset: 0xD26180 VA: 0x180D27B80
	internal XmlValueConverter get_ValueConverter() { }

	// RVA: 0xD27AA0 Offset: 0xD260A0 VA: 0x180D27AA0
	internal XmlSchemaContentType get_SchemaContentType() { }

	// RVA: 0xD27A20 Offset: 0xD26020 VA: 0x180D27A20
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x803BB0 Offset: 0x8021B0 VA: 0x180803BB0
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	internal void SetBaseSchemaType(XmlSchemaType value) { }

	// RVA: 0x574430 Offset: 0x572A30 VA: 0x180574430
	internal void SetDerivedBy(XmlSchemaDerivationMethod value) { }

	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50
	internal void SetDatatype(XmlSchemaDatatype value) { }

	// RVA: 0xD27A60 Offset: 0xD26060 VA: 0x180D27A60
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0xD27C00 Offset: 0xD26200 VA: 0x180D27C00
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	internal XmlSchemaType get_Redefined() { }

	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	internal void set_Redefined(XmlSchemaType value) { }

	// RVA: 0xD27A10 Offset: 0xD26010 VA: 0x180D27A10
	internal void SetContentType(XmlSchemaContentType value) { }

	// RVA: 0xD27880 Offset: 0xD25E80 VA: 0x180D27880
	public static bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except) { }

	// RVA: 0xD27790 Offset: 0xD25D90 VA: 0x180D27790
	internal static bool IsDerivedFromDatatype(XmlSchemaDatatype derivedDataType, XmlSchemaDatatype baseDataType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0xD27230 Offset: 0xD25830 VA: 0x180D27230
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

	// RVA: 0xD27CB0 Offset: 0xD262B0 VA: 0x180D27CB0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xD27C50 Offset: 0xD26250 VA: 0x180D27C50 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xD27CD0 Offset: 0xD262D0 VA: 0x180D27CD0
	public void .ctor() { }

	// RVA: 0xD27CE0 Offset: 0xD262E0 VA: 0x180D27CE0
	internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0xD27DF0 Offset: 0xD263F0 VA: 0x180D27DF0
	internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0xD27C70 Offset: 0xD26270 VA: 0x180D27C70
	internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition) { }

}

public sealed class XmlValueGetter : MulticastDelegate // TypeDefIndex: 2391
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xD3D6F0 Offset: 0xD3BCF0 VA: 0x180D3D6F0 Slot: 12
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

	// RVA: 0xD34E40 Offset: 0xD33440 VA: 0x180D34E40
	public void .ctor(XmlNameTable nameTable, XmlSchemaSet schemas, IXmlNamespaceResolver namespaceResolver, XmlSchemaValidationFlags validationFlags) { }

	// RVA: 0xD2E490 Offset: 0xD2CA90 VA: 0x180D2E490
	private void Init() { }

	// RVA: 0xD31030 Offset: 0xD2F630 VA: 0x180D31030
	private void Reset() { }

	// RVA: 0xD35330 Offset: 0xD33930 VA: 0x180D35330
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0xD352B0 Offset: 0xD338B0 VA: 0x180D352B0
	public void set_LineInfoProvider(IXmlLineInfo value) { }

	// RVA: 0xD352D0 Offset: 0xD338D0 VA: 0x180D352D0
	public void set_SourceUri(Uri value) { }

	// RVA: 0xA4D4F0 Offset: 0xA4BAF0 VA: 0x180A4D4F0
	public void set_ValidationEventSender(object value) { }

	// RVA: 0xD35090 Offset: 0xD33690 VA: 0x180D35090
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0xD35230 Offset: 0xD33830 VA: 0x180D35230
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0xD283B0 Offset: 0xD269B0 VA: 0x180D283B0
	public void AddSchema(XmlSchema schema) { }

	// RVA: 0xD2EAE0 Offset: 0xD2D0E0 VA: 0x180D2EAE0
	public void Initialize() { }

	// RVA: 0xD2E810 Offset: 0xD2CE10 VA: 0x180D2E810
	public void Initialize(XmlSchemaObject partialValidationType) { }

	// RVA: 0xD339B0 Offset: 0xD31FB0 VA: 0x180D339B0
	public void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0xD329E0 Offset: 0xD30FE0 VA: 0x180D329E0
	public object ValidateAttribute(string localName, string namespaceUri, XmlValueGetter attributeValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0xD32A90 Offset: 0xD31090 VA: 0x180D32A90
	private object ValidateAttribute(string lName, string ns, XmlValueGetter attributeValueGetter, string attributeStringValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0xD33EA0 Offset: 0xD324A0 VA: 0x180D33EA0
	public void ValidateEndOfAttributes(XmlSchemaInfo schemaInfo) { }

	// RVA: 0xD34480 Offset: 0xD32A80 VA: 0x180D34480
	public void ValidateText(XmlValueGetter elementValue) { }

	// RVA: 0xD33FE0 Offset: 0xD325E0 VA: 0x180D33FE0
	private void ValidateText(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0xD34760 Offset: 0xD32D60 VA: 0x180D34760
	public void ValidateWhitespace(XmlValueGetter elementValue) { }

	// RVA: 0xD34500 Offset: 0xD32B00 VA: 0x180D34500
	private void ValidateWhitespace(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0xD33E90 Offset: 0xD32490 VA: 0x180D33E90
	public object ValidateEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0xD31D30 Offset: 0xD30330 VA: 0x180D31D30
	public void SkipToEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0xD2CF20 Offset: 0xD2B520 VA: 0x180D2CF20
	public void EndValidation() { }

	// RVA: 0xD2DE30 Offset: 0xD2C430 VA: 0x180D2DE30
	internal void GetUnspecifiedDefaultAttributes(ArrayList defaultAttributes, bool createNodeData) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal XmlSchemaSet get_SchemaSet() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	internal XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0xD35110 Offset: 0xD33710 VA: 0x180D35110
	internal XmlSchemaContentType get_CurrentContentType() { }

	// RVA: 0xD31D10 Offset: 0xD30310 VA: 0x180D31D10
	internal void SetDtdSchemaInfo(IDtdInfo dtdSchemaInfo) { }

	// RVA: 0xD351F0 Offset: 0xD337F0 VA: 0x180D351F0
	private bool get_StrictlyAssessed() { }

	// RVA: 0xD35170 Offset: 0xD33770 VA: 0x180D35170
	private bool get_HasSchema() { }

	// RVA: 0xD2D6A0 Offset: 0xD2BCA0 VA: 0x180D2D6A0
	internal string GetConcatenatedValue() { }

	// RVA: 0xD2EC60 Offset: 0xD2D260 VA: 0x180D2EC60
	private object InternalValidateEndElement(XmlSchemaInfo schemaInfo, object typedValue) { }

	// RVA: 0xD30680 Offset: 0xD2EC80 VA: 0x180D30680
	private void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0xD334E0 Offset: 0xD31AE0 VA: 0x180D334E0
	private object ValidateElementContext(XmlQualifiedName elementName, out bool invalidElementInContext) { }

	// RVA: 0xD2DAA0 Offset: 0xD2C0A0 VA: 0x180D2DAA0
	private XmlSchemaElement GetSubstitutionGroupHead(XmlQualifiedName member) { }

	// RVA: 0xD321A0 Offset: 0xD307A0 VA: 0x180D321A0
	private object ValidateAtomicValue(string stringValue, out XmlSchemaSimpleType memberType) { }

	// RVA: 0xD324F0 Offset: 0xD30AF0 VA: 0x180D324F0
	private object ValidateAtomicValue(object parsedValue, out XmlSchemaSimpleType memberType) { }

	// RVA: 0xD2DDC0 Offset: 0xD2C3C0 VA: 0x180D2DDC0
	private string GetTypeName(SchemaDeclBase decl) { }

	// RVA: 0xD310E0 Offset: 0xD2F6E0 VA: 0x180D310E0
	private void SaveTextValue(object value) { }

	// RVA: 0xD30D40 Offset: 0xD2F340 VA: 0x180D30D40
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0xD2F790 Offset: 0xD2DD90 VA: 0x180D2F790
	private void Pop() { }

	// RVA: 0xD2D340 Offset: 0xD2B940 VA: 0x180D2D340
	private SchemaElementDecl FastGetElementDecl(XmlQualifiedName elementName, object particle) { }

	// RVA: 0xD29FC0 Offset: 0xD285C0 VA: 0x180D29FC0
	private SchemaElementDecl CheckXsiTypeAndNil(SchemaElementDecl elementDecl, string xsiType, string xsiNil, ref bool declFound) { }

	// RVA: 0xD31F60 Offset: 0xD30560 VA: 0x180D31F60
	private void ThrowDeclNotFoundWarningOrError(bool declFound) { }

	// RVA: 0xD291A0 Offset: 0xD277A0 VA: 0x180D291A0
	private void CheckElementProperties() { }

	// RVA: 0xD33F80 Offset: 0xD32580 VA: 0x180D33F80
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0xD297A0 Offset: 0xD27DA0 VA: 0x180D297A0
	private SchemaAttDef CheckIsXmlAttribute(XmlQualifiedName attQName) { }

	// RVA: 0xD28820 Offset: 0xD26E20 VA: 0x180D28820
	private void AddXmlNamespaceSchema() { }

	// RVA: 0xD298E0 Offset: 0xD27EE0 VA: 0x180D298E0
	internal object CheckMixedValueConstraint(string elementValue) { }

	// RVA: 0xD2F280 Offset: 0xD2D880 VA: 0x180D2F280
	private void LoadSchema(string uri, string url) { }

	// RVA: 0xD30F90 Offset: 0xD2F590 VA: 0x180D30F90
	internal void RecompileSchemaSet() { }

	// RVA: 0xD30A70 Offset: 0xD2F070 VA: 0x180D30A70
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name, bool attrValue) { }

	// RVA: 0xD28E10 Offset: 0xD27410 VA: 0x180D28E10
	private object CheckAttributeValue(object value, SchemaAttDef attdef) { }

	// RVA: 0xD29280 Offset: 0xD27880 VA: 0x180D29280
	private object CheckElementValue(string stringValue) { }

	// RVA: 0xD29E40 Offset: 0xD28440 VA: 0x180D29E40
	private void CheckTokenizedTypes(XmlSchemaDatatype dtype, object typedValue, bool attrValue) { }

	// RVA: 0xD2D680 Offset: 0xD2BC80 VA: 0x180D2D680
	private object FindId(string name) { }

	// RVA: 0xD29680 Offset: 0xD27C80 VA: 0x180D29680
	private void CheckForwardRefs() { }

	// RVA: 0xD35150 Offset: 0xD33750 VA: 0x180D35150
	private bool get_HasIdentityConstraints() { }

	// RVA: 0xD351C0 Offset: 0xD337C0 VA: 0x180D351C0
	internal bool get_ProcessIdentityConstraints() { }

	// RVA: 0xD351E0 Offset: 0xD337E0 VA: 0x180D351E0
	internal bool get_ReportValidationWarnings() { }

	// RVA: 0xD351D0 Offset: 0xD337D0 VA: 0x180D351D0
	internal bool get_ProcessSchemaHints() { }

	// RVA: 0xD29B90 Offset: 0xD28190 VA: 0x180D29B90
	private void CheckStateTransition(ValidatorState toState, string methodName) { }

	// RVA: 0xD2A7D0 Offset: 0xD28DD0 VA: 0x180D2A7D0
	private void ClearPSVI() { }

	// RVA: 0xD299E0 Offset: 0xD27FE0 VA: 0x180D299E0
	private void CheckRequiredAttributes(SchemaElementDecl currentElementDecl) { }

	// RVA: 0xD2D940 Offset: 0xD2BF40 VA: 0x180D2D940
	private XmlSchemaElement GetSchemaElement() { }

	// RVA: 0xD2D6D0 Offset: 0xD2BCD0 VA: 0x180D2D6D0
	internal string GetDefaultAttributePrefix(string attributeNS) { }

	// RVA: 0xD27E30 Offset: 0xD26430 VA: 0x180D27E30
	private void AddIdentityConstraints() { }

	// RVA: 0xD2AFD0 Offset: 0xD295D0 VA: 0x180D2AFD0
	private void ElementIdentityConstraints() { }

	// RVA: 0xD288C0 Offset: 0xD26EC0 VA: 0x180D288C0
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, XmlSchemaDatatype datatype) { }

	// RVA: 0xD2C0A0 Offset: 0xD2A6A0 VA: 0x180D2C0A0
	private void EndElementIdentityConstraints(object typedValue, string stringValue, XmlSchemaDatatype datatype) { }

	// RVA: 0xD2B380 Offset: 0xD29980 VA: 0x180D2B380
	internal static void ElementValidationError(XmlQualifiedName name, ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0xD2A830 Offset: 0xD28E30 VA: 0x180D2A830
	internal static void CompleteValidationError(ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0xD2F8D0 Offset: 0xD2DED0 VA: 0x180D2F8D0
	internal static string PrintExpectedElements(ArrayList expected, bool getParticles) { }

	// RVA: 0xD30400 Offset: 0xD2EA00 VA: 0x180D30400
	private static string PrintNames(ArrayList expected) { }

	// RVA: 0xD2FE20 Offset: 0xD2E420 VA: 0x180D2FE20
	private static void PrintNamesWithNS(ArrayList expected, StringBuilder builder) { }

	// RVA: 0xD2D130 Offset: 0xD2B730 VA: 0x180D2D130
	private static void EnumerateAny(StringBuilder builder, string namespaces) { }

	// RVA: 0xD30F20 Offset: 0xD2F520 VA: 0x180D30F20
	internal static string QNameString(string localName, string ns) { }

	// RVA: 0xD28BF0 Offset: 0xD271F0 VA: 0x180D28BF0
	internal static string BuildElementName(XmlQualifiedName qname) { }

	// RVA: 0xD28C70 Offset: 0xD27270 VA: 0x180D28C70
	internal static string BuildElementName(string localName, string ns) { }

	// RVA: 0xD30570 Offset: 0xD2EB70 VA: 0x180D30570
	private void ProcessEntity(string name) { }

	// RVA: 0xD31850 Offset: 0xD2FE50 VA: 0x180D31850
	private void SendValidationEvent(string code) { }

	// RVA: 0xD31A30 Offset: 0xD30030 VA: 0x180D31A30
	private void SendValidationEvent(string code, string[] args) { }

	// RVA: 0xD31600 Offset: 0xD2FC00 VA: 0x180D31600
	private void SendValidationEvent(string code, string arg) { }

	// RVA: 0xD31B40 Offset: 0xD30140 VA: 0x180D31B40
	private void SendValidationEvent(string code, string arg1, string arg2) { }

	// RVA: 0xD313C0 Offset: 0xD2F9C0 VA: 0x180D313C0
	private void SendValidationEvent(string code, string[] args, Exception innerException, XmlSeverityType severity) { }

	// RVA: 0xD318B0 Offset: 0xD2FEB0 VA: 0x180D318B0
	private void SendValidationEvent(string code, string[] args, Exception innerException) { }

	// RVA: 0xD31300 Offset: 0xD2F900 VA: 0x180D31300
	private void SendValidationEvent(XmlSchemaValidationException e) { }

	// RVA: 0xD316F0 Offset: 0xD2FCF0 VA: 0x180D316F0
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0xD31130 Offset: 0xD2F730 VA: 0x180D31130
	private void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0xD31500 Offset: 0xD2FB00 VA: 0x180D31500
	private void SendValidationEvent(XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0xD31250 Offset: 0xD2F850 VA: 0x180D31250
	internal static void SendValidationEvent(ValidationEventHandler eventHandler, object sender, XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0xD347E0 Offset: 0xD32DE0 VA: 0x180D347E0
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

	// RVA: 0x14392C0 Offset: 0x14378C0 VA: 0x1814392C0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x14393D0 Offset: 0x14379D0 VA: 0x1814393D0
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x1439250 Offset: 0x1437850 VA: 0x181439250
	protected void .ctor(XmlBaseConverter converterAtomic) { }

	// RVA: 0x14391F0 Offset: 0x14377F0 VA: 0x1814391F0
	protected void .ctor(XmlBaseConverter converterAtomic, Type clrTypeDefault) { }

	// RVA: 0x1436700 Offset: 0x1434D00 VA: 0x181436700 Slot: 7
	public override bool ToBoolean(DateTime value) { }

	// RVA: 0x1436540 Offset: 0x1434B40 VA: 0x181436540 Slot: 6
	public override bool ToBoolean(double value) { }

	// RVA: 0x1436620 Offset: 0x1434C20 VA: 0x181436620 Slot: 5
	public override bool ToBoolean(int value) { }

	// RVA: 0x1436460 Offset: 0x1434A60 VA: 0x181436460 Slot: 4
	public override bool ToBoolean(long value) { }

	// RVA: 0x14363A0 Offset: 0x14349A0 VA: 0x1814363A0 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x14367E0 Offset: 0x1434DE0 VA: 0x1814367E0 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x1437050 Offset: 0x1435650 VA: 0x181437050 Slot: 33
	public override DateTime ToDateTime(bool value) { }

	// RVA: 0x1436E90 Offset: 0x1435490 VA: 0x181436E90 Slot: 37
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x1436F70 Offset: 0x1435570 VA: 0x181436F70 Slot: 36
	public override DateTime ToDateTime(double value) { }

	// RVA: 0x1436B50 Offset: 0x1435150 VA: 0x181436B50 Slot: 34
	public override DateTime ToDateTime(int value) { }

	// RVA: 0x1436CF0 Offset: 0x14352F0 VA: 0x181436CF0 Slot: 35
	public override DateTime ToDateTime(long value) { }

	// RVA: 0x1436DD0 Offset: 0x14353D0 VA: 0x181436DD0 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x1436C30 Offset: 0x1435230 VA: 0x181436C30 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x14368A0 Offset: 0x1434EA0 VA: 0x1814368A0 Slot: 40
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x1436990 Offset: 0x1434F90 VA: 0x181436990 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x1436A70 Offset: 0x1435070 VA: 0x181436A70 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x1437200 Offset: 0x1435800 VA: 0x181437200 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x1437130 Offset: 0x1435730 VA: 0x181437130 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x1437550 Offset: 0x1435B50 VA: 0x181437550 Slot: 24
	public override double ToDouble(bool value) { }

	// RVA: 0x14376F0 Offset: 0x1435CF0 VA: 0x1814376F0 Slot: 27
	public override double ToDouble(DateTime value) { }

	// RVA: 0x14373B0 Offset: 0x14359B0 VA: 0x1814373B0 Slot: 25
	public override double ToDouble(int value) { }

	// RVA: 0x14372D0 Offset: 0x14358D0 VA: 0x1814372D0 Slot: 26
	public override double ToDouble(long value) { }

	// RVA: 0x1437490 Offset: 0x1435A90 VA: 0x181437490 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x1437630 Offset: 0x1435C30 VA: 0x181437630 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x1437970 Offset: 0x1435F70 VA: 0x181437970 Slot: 10
	public override int ToInt32(bool value) { }

	// RVA: 0x1437A40 Offset: 0x1436040 VA: 0x181437A40 Slot: 13
	public override int ToInt32(DateTime value) { }

	// RVA: 0x1437890 Offset: 0x1435E90 VA: 0x181437890 Slot: 12
	public override int ToInt32(double value) { }

	// RVA: 0x1437B10 Offset: 0x1436110 VA: 0x181437B10 Slot: 11
	public override int ToInt32(long value) { }

	// RVA: 0x14377D0 Offset: 0x1435DD0 VA: 0x1814377D0 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x1437BE0 Offset: 0x14361E0 VA: 0x181437BE0 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x1437EF0 Offset: 0x14364F0 VA: 0x181437EF0 Slot: 16
	public override long ToInt64(bool value) { }

	// RVA: 0x14380A0 Offset: 0x14366A0 VA: 0x1814380A0 Slot: 19
	public override long ToInt64(DateTime value) { }

	// RVA: 0x1437FC0 Offset: 0x14365C0 VA: 0x181437FC0 Slot: 18
	public override long ToInt64(double value) { }

	// RVA: 0x1437E20 Offset: 0x1436420 VA: 0x181437E20 Slot: 17
	public override long ToInt64(int value) { }

	// RVA: 0x1437D60 Offset: 0x1436360 VA: 0x181437D60 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x1437CA0 Offset: 0x14362A0 VA: 0x181437CA0 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x1438240 Offset: 0x1436840 VA: 0x181438240 Slot: 30
	public override float ToSingle(double value) { }

	// RVA: 0x1438180 Offset: 0x1436780 VA: 0x181438180 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x1438320 Offset: 0x1436920 VA: 0x181438320 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x14383E0 Offset: 0x14369E0 VA: 0x1814383E0 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x1438560 Offset: 0x1436B60 VA: 0x181438560 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x1438700 Offset: 0x1436D00 VA: 0x181438700 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x1438630 Offset: 0x1436C30 VA: 0x181438630 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x1438A50 Offset: 0x1437050 VA: 0x181438A50 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x14388A0 Offset: 0x1436EA0 VA: 0x1814388A0 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x14387D0 Offset: 0x1436DD0 VA: 0x1814387D0 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x1438960 Offset: 0x1436F60 VA: 0x181438960 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x14384A0 Offset: 0x1436AA0 VA: 0x1814384A0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1438A30 Offset: 0x1437030 VA: 0x181438A30 Slot: 51
	public override string ToString(object value) { }

	// RVA: 0x1433C30 Offset: 0x1432230 VA: 0x181433C30 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x1433A90 Offset: 0x1432090 VA: 0x181433A90 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x1433CE0 Offset: 0x14322E0 VA: 0x181433CE0 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x1433B90 Offset: 0x1432190 VA: 0x181433B90 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x1433A10 Offset: 0x1432010 VA: 0x181433A10 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x1433B10 Offset: 0x1432110 VA: 0x181433B10 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x1433C10 Offset: 0x1432210 VA: 0x181433C10 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1433CB0 Offset: 0x14322B0 VA: 0x181433CB0 Slot: 60
	public override object ChangeType(object value, Type destinationType) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	protected XmlSchemaType get_SchemaType() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	protected XmlTypeCode get_TypeCode() { }

	// RVA: 0x14394D0 Offset: 0x1437AD0 VA: 0x1814394D0
	protected string get_XmlTypeName() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	protected Type get_DefaultClrType() { }

	// RVA: 0x14351E0 Offset: 0x14337E0 VA: 0x1814351E0
	protected static bool IsDerivedFrom(Type derivedType, Type baseType) { }

	// RVA: 0x1433D60 Offset: 0x1432360 VA: 0x181433D60
	protected Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

	// RVA: 0x1435440 Offset: 0x1433A40 VA: 0x181435440
	protected static string QNameToString(XmlQualifiedName name) { }

	// RVA: 0x14339A0 Offset: 0x1431FA0 VA: 0x1814339A0 Slot: 62
	protected virtual object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1435520 Offset: 0x1433B20 VA: 0x181435520
	protected static byte[] StringToBase64Binary(string value) { }

	// RVA: 0x1435760 Offset: 0x1433D60 VA: 0x181435760
	protected static DateTime StringToDate(string value) { }

	// RVA: 0x14356E0 Offset: 0x1433CE0 VA: 0x1814356E0
	protected static DateTime StringToDateTime(string value) { }

	// RVA: 0x14357E0 Offset: 0x1433DE0 VA: 0x1814357E0
	protected static TimeSpan StringToDayTimeDuration(string value) { }

	// RVA: 0x1435840 Offset: 0x1433E40 VA: 0x181435840
	protected static TimeSpan StringToDuration(string value) { }

	// RVA: 0x1435940 Offset: 0x1433F40 VA: 0x181435940
	protected static DateTime StringToGDay(string value) { }

	// RVA: 0x1435B80 Offset: 0x1434180 VA: 0x181435B80
	protected static DateTime StringToGMonth(string value) { }

	// RVA: 0x1435A60 Offset: 0x1434060 VA: 0x181435A60
	protected static DateTime StringToGMonthDay(string value) { }

	// RVA: 0x1435DC0 Offset: 0x14343C0 VA: 0x181435DC0
	protected static DateTime StringToGYear(string value) { }

	// RVA: 0x1435CA0 Offset: 0x14342A0 VA: 0x181435CA0
	protected static DateTime StringToGYearMonth(string value) { }

	// RVA: 0x14355A0 Offset: 0x1433BA0 VA: 0x1814355A0
	protected static DateTimeOffset StringToDateOffset(string value) { }

	// RVA: 0x1435640 Offset: 0x1433C40 VA: 0x181435640
	protected static DateTimeOffset StringToDateTimeOffset(string value) { }

	// RVA: 0x14358A0 Offset: 0x1433EA0 VA: 0x1814358A0
	protected static DateTimeOffset StringToGDayOffset(string value) { }

	// RVA: 0x1435AE0 Offset: 0x14340E0 VA: 0x181435AE0
	protected static DateTimeOffset StringToGMonthOffset(string value) { }

	// RVA: 0x14359C0 Offset: 0x1433FC0 VA: 0x1814359C0
	protected static DateTimeOffset StringToGMonthDayOffset(string value) { }

	// RVA: 0x1435D20 Offset: 0x1434320 VA: 0x181435D20
	protected static DateTimeOffset StringToGYearOffset(string value) { }

	// RVA: 0x1435C00 Offset: 0x1434200 VA: 0x181435C00
	protected static DateTimeOffset StringToGYearMonthOffset(string value) { }

	// RVA: 0x1435E40 Offset: 0x1434440 VA: 0x181435E40
	protected static byte[] StringToHexBinary(string value) { }

	// RVA: 0x1435F10 Offset: 0x1434510 VA: 0x181435F10
	protected static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1436230 Offset: 0x1434830 VA: 0x181436230
	protected static DateTime StringToTime(string value) { }

	// RVA: 0x1436190 Offset: 0x1434790 VA: 0x181436190
	protected static DateTimeOffset StringToTimeOffset(string value) { }

	// RVA: 0x14362B0 Offset: 0x14348B0 VA: 0x1814362B0
	protected static TimeSpan StringToYearMonthDuration(string value) { }

	// RVA: 0x1433920 Offset: 0x1431F20 VA: 0x181433920
	protected static string AnyUriToString(Uri value) { }

	// RVA: 0x1433940 Offset: 0x1431F40 VA: 0x181433940
	protected static string Base64BinaryToString(byte[] value) { }

	// RVA: 0x1434180 Offset: 0x1432780 VA: 0x181434180
	protected static string DateToString(DateTime value) { }

	// RVA: 0x1434140 Offset: 0x1432740 VA: 0x181434140
	protected static string DateTimeToString(DateTime value) { }

	// RVA: 0x14341C0 Offset: 0x14327C0 VA: 0x1814341C0
	protected static string DayTimeDurationToString(TimeSpan value) { }

	// RVA: 0x1434840 Offset: 0x1432E40 VA: 0x181434840
	protected static string DurationToString(TimeSpan value) { }

	// RVA: 0x14348F0 Offset: 0x1432EF0 VA: 0x1814348F0
	protected static string GDayToString(DateTime value) { }

	// RVA: 0x1434A10 Offset: 0x1433010 VA: 0x181434A10
	protected static string GMonthToString(DateTime value) { }

	// RVA: 0x1434980 Offset: 0x1432F80 VA: 0x181434980
	protected static string GMonthDayToString(DateTime value) { }

	// RVA: 0x1434B30 Offset: 0x1433130 VA: 0x181434B30
	protected static string GYearToString(DateTime value) { }

	// RVA: 0x1434AA0 Offset: 0x14330A0 VA: 0x181434AA0
	protected static string GYearMonthToString(DateTime value) { }

	// RVA: 0x1434090 Offset: 0x1432690 VA: 0x181434090
	protected static string DateOffsetToString(DateTimeOffset value) { }

	// RVA: 0x14340F0 Offset: 0x14326F0 VA: 0x1814340F0
	protected static string DateTimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x14348A0 Offset: 0x1432EA0 VA: 0x1814348A0
	protected static string GDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x14349C0 Offset: 0x1432FC0 VA: 0x1814349C0
	protected static string GMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1434930 Offset: 0x1432F30 VA: 0x181434930
	protected static string GMonthDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1434AE0 Offset: 0x14330E0 VA: 0x181434AE0
	protected static string GYearOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1434A50 Offset: 0x1433050 VA: 0x181434A50
	protected static string GYearMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x14352B0 Offset: 0x14338B0 VA: 0x1814352B0
	protected static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1436360 Offset: 0x1434960 VA: 0x181436360
	protected static string TimeToString(DateTime value) { }

	// RVA: 0x1436310 Offset: 0x1434910 VA: 0x181436310
	protected static string TimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1438C40 Offset: 0x1437240 VA: 0x181438C40
	protected static string YearMonthDurationToString(TimeSpan value) { }

	// RVA: 0x14340E0 Offset: 0x14326E0 VA: 0x1814340E0
	internal static DateTime DateTimeOffsetToDateTime(DateTimeOffset value) { }

	// RVA: 0x1434220 Offset: 0x1432820 VA: 0x181434220
	internal static int DecimalToInt32(Decimal value) { }

	// RVA: 0x1434430 Offset: 0x1432A30 VA: 0x181434430
	protected static long DecimalToInt64(Decimal value) { }

	// RVA: 0x1434640 Offset: 0x1432C40 VA: 0x181434640
	protected static ulong DecimalToUInt64(Decimal value) { }

	// RVA: 0x1434B70 Offset: 0x1433170 VA: 0x181434B70
	protected static byte Int32ToByte(int value) { }

	// RVA: 0x1434C80 Offset: 0x1433280 VA: 0x181434C80
	protected static short Int32ToInt16(int value) { }

	// RVA: 0x1434D90 Offset: 0x1433390 VA: 0x181434D90
	protected static sbyte Int32ToSByte(int value) { }

	// RVA: 0x1434EA0 Offset: 0x14334A0 VA: 0x181434EA0
	protected static ushort Int32ToUInt16(int value) { }

	// RVA: 0x1434FB0 Offset: 0x14335B0 VA: 0x181434FB0
	protected static int Int64ToInt32(long value) { }

	// RVA: 0x14350D0 Offset: 0x14336D0 VA: 0x1814350D0
	protected static uint Int64ToUInt32(long value) { }

	// RVA: 0x1438BC0 Offset: 0x14371C0 VA: 0x181438BC0
	protected static DateTime UntypedAtomicToDateTime(string value) { }

	// RVA: 0x1438B20 Offset: 0x1437120 VA: 0x181438B20
	protected static DateTimeOffset UntypedAtomicToDateTimeOffset(string value) { }

	// RVA: 0x1438CA0 Offset: 0x14372A0 VA: 0x181438CA0
	private static void .cctor() { }

}

internal class XmlNumeric10Converter : XmlBaseConverter // TypeDefIndex: 2401
{	// Methods

	// RVA: 0x1447210 Offset: 0x1445810 VA: 0x181447210
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1445AB0 Offset: 0x14440B0 VA: 0x181445AB0
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1445B40 Offset: 0x1444140 VA: 0x181445B40 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x1445C20 Offset: 0x1444220 VA: 0x181445C20 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x14460F0 Offset: 0x14446F0 VA: 0x1814460F0 Slot: 11
	public override int ToInt32(long value) { }

	// RVA: 0x14465B0 Offset: 0x1444BB0 VA: 0x1814465B0 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x1446150 Offset: 0x1444750 VA: 0x181446150 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x14466C0 Offset: 0x1444CC0 VA: 0x1814466C0 Slot: 17
	public override long ToInt64(int value) { }

	// RVA: 0x1446B00 Offset: 0x1445100 VA: 0x181446B00 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x14466D0 Offset: 0x1444CD0 VA: 0x1814466D0 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x14470D0 Offset: 0x14456D0 VA: 0x1814470D0 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x14471C0 Offset: 0x14457C0 VA: 0x1814471C0 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x1446C10 Offset: 0x1445210 VA: 0x181446C10 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x1446C70 Offset: 0x1445270 VA: 0x181446C70 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1442DC0 Offset: 0x14413C0 VA: 0x181442DC0 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x1445560 Offset: 0x1443B60 VA: 0x181445560 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x14433E0 Offset: 0x14419E0 VA: 0x1814433E0 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x1443960 Offset: 0x1441F60 VA: 0x181443960 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1443ED0 Offset: 0x14424D0 VA: 0x181443ED0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1442430 Offset: 0x1440A30 VA: 0x181442430
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x14428B0 Offset: 0x1440EB0 VA: 0x1814428B0
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlNumeric2Converter : XmlBaseConverter // TypeDefIndex: 2402
{	// Methods

	// RVA: 0x1449630 Offset: 0x1447C30 VA: 0x181449630
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x14487A0 Offset: 0x1446DA0 VA: 0x1814487A0
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1448830 Offset: 0x1446E30 VA: 0x181448830 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x1448900 Offset: 0x1446F00 VA: 0x181448900 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x1449070 Offset: 0x1447670 VA: 0x181449070 Slot: 30
	public override float ToSingle(double value) { }

	// RVA: 0x1449080 Offset: 0x1447680 VA: 0x181449080 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x1448C90 Offset: 0x1447290 VA: 0x181448C90 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x14494E0 Offset: 0x1447AE0 VA: 0x1814494E0 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x1449590 Offset: 0x1447B90 VA: 0x181449590 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x1449150 Offset: 0x1447750 VA: 0x181449150 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1447E00 Offset: 0x1446400 VA: 0x181447E00 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x14482B0 Offset: 0x14468B0 VA: 0x1814482B0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1447280 Offset: 0x1445880 VA: 0x181447280 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlDateTimeConverter : XmlBaseConverter // TypeDefIndex: 2403
{	// Methods

	// RVA: 0x143DCF0 Offset: 0x143C2F0 VA: 0x18143DCF0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x143C640 Offset: 0x143AC40 VA: 0x18143C640
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x143D4E0 Offset: 0x143BAE0 VA: 0x18143D4E0 Slot: 37
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x143D1C0 Offset: 0x143B7C0 VA: 0x18143D1C0 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x143CE20 Offset: 0x143B420 VA: 0x18143CE20 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x143C6D0 Offset: 0x143ACD0 VA: 0x18143C6D0 Slot: 40
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x143CAE0 Offset: 0x143B0E0 VA: 0x18143CAE0 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x143C700 Offset: 0x143AD00 VA: 0x18143C700 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x143D8E0 Offset: 0x143BEE0 VA: 0x18143D8E0 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x143DAD0 Offset: 0x143C0D0 VA: 0x18143DAD0 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x143D540 Offset: 0x143BB40 VA: 0x18143D540 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143B010 Offset: 0x1439610 VA: 0x18143B010 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x143B4E0 Offset: 0x1439AE0 VA: 0x18143B4E0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143B9D0 Offset: 0x1439FD0 VA: 0x18143B9D0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlBooleanConverter : XmlBaseConverter // TypeDefIndex: 2404
{	// Methods

	// RVA: 0x143AFA0 Offset: 0x14395A0 VA: 0x18143AFA0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x143A830 Offset: 0x1438E30 VA: 0x18143A830
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x143ABB0 Offset: 0x14391B0 VA: 0x18143ABB0 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x143A8C0 Offset: 0x1438EC0 VA: 0x18143A8C0 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x143AF40 Offset: 0x1439540 VA: 0x18143AF40 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x143AC40 Offset: 0x1439240 VA: 0x18143AC40 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1439F80 Offset: 0x1438580 VA: 0x181439F80 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x143A3C0 Offset: 0x14389C0 VA: 0x18143A3C0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1439690 Offset: 0x1437C90 VA: 0x181439690 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlMiscConverter : XmlBaseConverter // TypeDefIndex: 2405
{	// Methods

	// RVA: 0x14423C0 Offset: 0x14409C0 VA: 0x1814423C0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1441B20 Offset: 0x1440120 VA: 0x181441B20
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1441BB0 Offset: 0x14401B0 VA: 0x181441BB0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1441450 Offset: 0x143FA50 VA: 0x181441450 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1440000 Offset: 0x143E600 VA: 0x181440000 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143FD30 Offset: 0x143E330 VA: 0x18143FD30
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143FE70 Offset: 0x143E470 VA: 0x18143FE70
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlStringConverter : XmlBaseConverter // TypeDefIndex: 2406
{	// Methods

	// RVA: 0xD35E70 Offset: 0xD34470 VA: 0x180D35E70
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0xD35BA0 Offset: 0xD341A0 VA: 0x180D35BA0
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0xD35C30 Offset: 0xD34230 VA: 0x180D35C30 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD35360 Offset: 0xD33960 VA: 0x180D35360 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD35650 Offset: 0xD33C50 VA: 0x180D35650 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlUntypedConverter : XmlListConverter // TypeDefIndex: 2407
{	// Fields
	private bool allowListToList; // 0x30
	public static readonly XmlValueConverter Untyped; // 0x0
	public static readonly XmlValueConverter UntypedList; // 0x8

	// Methods

	// RVA: 0xD3D640 Offset: 0xD3BC40 VA: 0x180D3D640
	protected void .ctor() { }

	// RVA: 0xD3D570 Offset: 0xD3BB70 VA: 0x180D3D570
	protected void .ctor(XmlUntypedConverter atomicConverter, bool allowListToList) { }

	// RVA: 0xD3AF80 Offset: 0xD39580 VA: 0x180D3AF80 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0xD3ADB0 Offset: 0xD393B0 VA: 0x180D3ADB0 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0xD3B470 Offset: 0xD39A70 VA: 0x180D3B470 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0xD3B2A0 Offset: 0xD398A0 VA: 0x180D3B2A0 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0xD3B010 Offset: 0xD39610 VA: 0x180D3B010 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0xD3B0C0 Offset: 0xD396C0 VA: 0x180D3B0C0 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0xD3B6E0 Offset: 0xD39CE0 VA: 0x180D3B6E0 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0xD3B500 Offset: 0xD39B00 VA: 0x180D3B500 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0xD3B790 Offset: 0xD39D90 VA: 0x180D3B790 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0xD3B820 Offset: 0xD39E20 VA: 0x180D3B820 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0xD3BBB0 Offset: 0xD3A1B0 VA: 0x180D3BBB0 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0xD3B9F0 Offset: 0xD39FF0 VA: 0x180D3B9F0 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0xD3BE10 Offset: 0xD3A410 VA: 0x180D3BE10 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0xD3BC40 Offset: 0xD3A240 VA: 0x180D3BC40 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0xD3BEA0 Offset: 0xD3A4A0 VA: 0x180D3BEA0 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0xD3BF30 Offset: 0xD3A530 VA: 0x180D3BF30 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0xD3D380 Offset: 0xD3B980 VA: 0x180D3D380 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0xD3C100 Offset: 0xD3A700 VA: 0x180D3C100 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0xD3D260 Offset: 0xD3B860 VA: 0x180D3D260 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0xD3D200 Offset: 0xD3B800 VA: 0x180D3D200 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0xD3D320 Offset: 0xD3B920 VA: 0x180D3D320 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0xD3C160 Offset: 0xD3A760 VA: 0x180D3C160 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0xD3D2C0 Offset: 0xD3B8C0 VA: 0x180D3D2C0 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0xD3C1B0 Offset: 0xD3A7B0 VA: 0x180D3C1B0 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0xD3C210 Offset: 0xD3A810 VA: 0x180D3C210 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD3A230 Offset: 0xD38830 VA: 0x180D3A230 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0xD3A420 Offset: 0xD38A20 VA: 0x180D3A420 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0xD371B0 Offset: 0xD357B0 VA: 0x180D371B0 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0xD36FC0 Offset: 0xD355C0 VA: 0x180D36FC0 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0xD373B0 Offset: 0xD359B0 VA: 0x180D373B0 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0xD36DD0 Offset: 0xD353D0 VA: 0x180D36DD0 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0xD37590 Offset: 0xD35B90 VA: 0x180D37590 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD38510 Offset: 0xD36B10 VA: 0x180D38510 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD36B00 Offset: 0xD35100 VA: 0x180D36B00
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD36C40 Offset: 0xD35240 VA: 0x180D36C40
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD367D0 Offset: 0xD34DD0 VA: 0x180D367D0 Slot: 62
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD3A610 Offset: 0xD38C10 VA: 0x180D3A610
	private bool SupportsType(Type clrType) { }

	// RVA: 0xD3D3E0 Offset: 0xD3B9E0 VA: 0x180D3D3E0
	private static void .cctor() { }

}

internal class XmlAnyConverter : XmlBaseConverter // TypeDefIndex: 2408
{	// Fields
	public static readonly XmlValueConverter Item; // 0x0
	public static readonly XmlValueConverter AnyAtomic; // 0x8

	// Methods

	// RVA: 0x1431FA0 Offset: 0x14305A0 VA: 0x181431FA0
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x1430E50 Offset: 0x142F450 VA: 0x181430E50 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x1431220 Offset: 0x142F820 VA: 0x181431220 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x1431000 Offset: 0x142F600 VA: 0x181431000 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x14313D0 Offset: 0x142F9D0 VA: 0x1814313D0 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x14315F0 Offset: 0x142FBF0 VA: 0x1814315F0 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x14317A0 Offset: 0x142FDA0 VA: 0x1814317A0 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x1431950 Offset: 0x142FF50 VA: 0x181431950 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x1431BC0 Offset: 0x14301C0 VA: 0x181431BC0 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x142DB60 Offset: 0x142C160 VA: 0x18142DB60 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x14304F0 Offset: 0x142EAF0 VA: 0x1814304F0 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x142DDB0 Offset: 0x142C3B0 VA: 0x18142DDB0 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x142D910 Offset: 0x142BF10 VA: 0x18142D910 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x1430990 Offset: 0x142EF90 VA: 0x181430990 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x1430740 Offset: 0x142ED40 VA: 0x181430740 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x1430BD0 Offset: 0x142F1D0 VA: 0x181430BD0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x142E060 Offset: 0x142C660 VA: 0x18142E060 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x142D640 Offset: 0x142BC40 VA: 0x18142D640
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x142D780 Offset: 0x142BD80 VA: 0x18142D780
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1431B00 Offset: 0x1430100 VA: 0x181431B00
	private XPathNavigator ToNavigator(XPathNavigator nav) { }

	// RVA: 0x1431DD0 Offset: 0x14303D0 VA: 0x181431DD0
	private static void .cctor() { }

}

internal class XmlAnyListConverter : XmlListConverter // TypeDefIndex: 2409
{	// Fields
	public static readonly XmlValueConverter ItemList; // 0x0
	public static readonly XmlValueConverter AnyAtomicList; // 0x8

	// Methods

	// RVA: 0x1432500 Offset: 0x1430B00 VA: 0x181432500
	protected void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x14320E0 Offset: 0x14306E0 VA: 0x1814320E0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1432370 Offset: 0x1430970 VA: 0x181432370
	private static void .cctor() { }

}

internal class XmlListConverter : XmlBaseConverter // TypeDefIndex: 2410
{	// Fields
	protected XmlValueConverter atomicConverter; // 0x28

	// Methods

	// RVA: 0x143FC70 Offset: 0x143E270 VA: 0x18143FC70
	protected void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x143FBC0 Offset: 0x143E1C0 VA: 0x18143FBC0
	protected void .ctor(XmlBaseConverter atomicConverter, Type clrTypeDefault) { }

	// RVA: 0x143FB50 Offset: 0x143E150 VA: 0x18143FB50
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x143F140 Offset: 0x143D740 VA: 0x18143F140
	public static XmlValueConverter Create(XmlValueConverter atomicConverter) { }

	// RVA: 0x143ED00 Offset: 0x143D300 VA: 0x18143ED00 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143DD60 Offset: 0x143C360 VA: 0x18143DD60 Slot: 62
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143F320 Offset: 0x143D920 VA: 0x18143F320
	private bool IsListType(Type type) { }

	// RVA: -1 Offset: -1
	private T[] ToArray<T>(object list, IXmlNamespaceResolver nsResolver) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3BEF0 Offset: 0x1A3A4F0 VA: 0x181A3BEF0
	|-XmlListConverter.ToArray<bool>
	|
	|-RVA: 0x1A3C330 Offset: 0x1A3A930 VA: 0x181A3C330
	|-XmlListConverter.ToArray<byte>
	|
	|-RVA: 0x1A3E530 Offset: 0x1A3CB30 VA: 0x181A3E530
	|-XmlListConverter.ToArray<byte[]>
	|-XmlListConverter.ToArray<object>
	|-XmlListConverter.ToArray<string>
	|-XmlListConverter.ToArray<Uri>
	|-XmlListConverter.ToArray<XmlAtomicValue>
	|-XmlListConverter.ToArray<XPathItem>
	|-XmlListConverter.ToArray<XPathNavigator>
	|-XmlListConverter.ToArray<XmlQualifiedName>
	|
	|-RVA: 0x1A3CBB0 Offset: 0x1A3B1B0 VA: 0x181A3CBB0
	|-XmlListConverter.ToArray<DateTime>
	|
	|-RVA: 0x1A3C770 Offset: 0x1A3AD70 VA: 0x181A3C770
	|-XmlListConverter.ToArray<DateTimeOffset>
	|
	|-RVA: 0x1A3CFF0 Offset: 0x1A3B5F0 VA: 0x181A3CFF0
	|-XmlListConverter.ToArray<Decimal>
	|
	|-RVA: 0x1A3D430 Offset: 0x1A3BA30 VA: 0x181A3D430
	|-XmlListConverter.ToArray<double>
	|
	|-RVA: 0x1A3D870 Offset: 0x1A3BE70 VA: 0x181A3D870
	|-XmlListConverter.ToArray<short>
	|
	|-RVA: 0x1A3DCB0 Offset: 0x1A3C2B0 VA: 0x181A3DCB0
	|-XmlListConverter.ToArray<int>
	|
	|-RVA: 0x1A3E0F0 Offset: 0x1A3C6F0 VA: 0x181A3E0F0
	|-XmlListConverter.ToArray<long>
	|
	|-RVA: 0x1A3E950 Offset: 0x1A3CF50 VA: 0x181A3E950
	|-XmlListConverter.ToArray<sbyte>
	|
	|-RVA: 0x1A3ED90 Offset: 0x1A3D390 VA: 0x181A3ED90
	|-XmlListConverter.ToArray<float>
	|
	|-RVA: 0x1A3F1D0 Offset: 0x1A3D7D0 VA: 0x181A3F1D0
	|-XmlListConverter.ToArray<TimeSpan>
	|
	|-RVA: 0x1A3F610 Offset: 0x1A3DC10 VA: 0x181A3F610
	|-XmlListConverter.ToArray<ushort>
	|
	|-RVA: 0x1A3FA50 Offset: 0x1A3E050 VA: 0x181A3FA50
	|-XmlListConverter.ToArray<uint>
	|
	|-RVA: 0x1A3FE90 Offset: 0x1A3E490 VA: 0x181A3FE90
	|-XmlListConverter.ToArray<ulong>
	*/

	// RVA: 0x143F800 Offset: 0x143DE00 VA: 0x18143F800
	private IList ToList(object list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143F770 Offset: 0x143DD70 VA: 0x18143F770
	private List<string> StringAsList(string value) { }

	// RVA: 0x143F510 Offset: 0x143DB10 VA: 0x18143F510
	private string ListAsString(IEnumerable list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143EE10 Offset: 0x143D410 VA: 0x18143EE10
	private Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

}

internal class XmlUnionConverter : XmlBaseConverter // TypeDefIndex: 2411
{	// Fields
	private XmlValueConverter[] converters; // 0x28
	private bool hasAtomicMember; // 0x30
	private bool hasListMember; // 0x31

	// Methods

	// RVA: 0xD36420 Offset: 0xD34A20 VA: 0x180D36420
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0xD363C0 Offset: 0xD349C0 VA: 0x180D363C0
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0xD35EE0 Offset: 0xD344E0 VA: 0x180D35EE0 Slot: 61
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

	// RVA: 0xD4CF00 Offset: 0xD4B500 VA: 0x180D4CF00
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, XmlSchema schema, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0xD43780 Offset: 0xD41D80 VA: 0x180D43780 Slot: 4
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0xD43240 Offset: 0xD41840 VA: 0x180D43240 Slot: 5
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0xD42BC0 Offset: 0xD411C0 VA: 0x180D42BC0 Slot: 6
	internal override bool IsContentParsed() { }

	// RVA: 0xD43950 Offset: 0xD41F50 VA: 0x180D43950 Slot: 7
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0xD43730 Offset: 0xD41D30 VA: 0x180D43730 Slot: 8
	internal override void ProcessCData(string value) { }

	// RVA: 0xD45260 Offset: 0xD43860 VA: 0x180D45260 Slot: 9
	internal override void StartChildren() { }

	// RVA: 0xD3FD20 Offset: 0xD3E320 VA: 0x180D3FD20 Slot: 10
	internal override void EndChildren() { }

	// RVA: 0xD43960 Offset: 0xD41F60 VA: 0x180D43960
	private void Push() { }

	// RVA: 0xD43180 Offset: 0xD41780 VA: 0x180D43180
	private void Pop() { }

	// RVA: 0xD4D130 Offset: 0xD4B730 VA: 0x180D4D130
	private SchemaNames.Token get_CurrentElement() { }

	// RVA: 0xD4D1F0 Offset: 0xD4B7F0 VA: 0x180D4D1F0
	private SchemaNames.Token get_ParentElement() { }

	// RVA: 0xD4D150 Offset: 0xD4B750 VA: 0x180D4D150
	private XmlSchemaObject get_ParentContainer() { }

	// RVA: 0xD3FE60 Offset: 0xD3E460 VA: 0x180D3FE60
	private XmlSchemaObject GetContainer(XsdBuilder.State state) { }

	// RVA: 0xD442F0 Offset: 0xD428F0 VA: 0x180D442F0
	private void SetContainer(XsdBuilder.State state, object container) { }

	// RVA: 0xD3DF60 Offset: 0xD3C560 VA: 0x180D3DF60
	private static void BuildAnnotated_Id(XsdBuilder builder, string value) { }

	// RVA: 0xD3F4C0 Offset: 0xD3DAC0 VA: 0x180D3F4C0
	private static void BuildSchema_AttributeFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0xD3F5E0 Offset: 0xD3DBE0 VA: 0x180D3F5E0
	private static void BuildSchema_ElementFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0xD3F700 Offset: 0xD3DD00 VA: 0x180D3F700
	private static void BuildSchema_TargetNamespace(XsdBuilder builder, string value) { }

	// RVA: 0xD3F730 Offset: 0xD3DD30 VA: 0x180D3F730
	private static void BuildSchema_Version(XsdBuilder builder, string value) { }

	// RVA: 0xD3F690 Offset: 0xD3DC90 VA: 0x180D3F690
	private static void BuildSchema_FinalDefault(XsdBuilder builder, string value) { }

	// RVA: 0xD3F570 Offset: 0xD3DB70 VA: 0x180D3F570
	private static void BuildSchema_BlockDefault(XsdBuilder builder, string value) { }

	// RVA: 0xD41DE0 Offset: 0xD403E0 VA: 0x180D41DE0
	private static void InitSchema(XsdBuilder builder, string value) { }

	// RVA: 0xD41B90 Offset: 0xD40190 VA: 0x180D41B90
	private static void InitInclude(XsdBuilder builder, string value) { }

	// RVA: 0xD3F370 Offset: 0xD3D970 VA: 0x180D3F370
	private static void BuildInclude_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0xD41AC0 Offset: 0xD400C0 VA: 0x180D41AC0
	private static void InitImport(XsdBuilder builder, string value) { }

	// RVA: 0xD3F310 Offset: 0xD3D910 VA: 0x180D3F310
	private static void BuildImport_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0xD3F340 Offset: 0xD3D940 VA: 0x180D3F340
	private static void BuildImport_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0xD41D10 Offset: 0xD40310 VA: 0x180D41D10
	private static void InitRedefine(XsdBuilder builder, string value) { }

	// RVA: 0xD3F490 Offset: 0xD3DA90 VA: 0x180D3F490
	private static void BuildRedefine_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0xD3FE40 Offset: 0xD3E440 VA: 0x180D3FE40
	private static void EndRedefine(XsdBuilder builder) { }

	// RVA: 0xD40AD0 Offset: 0xD3F0D0 VA: 0x180D40AD0
	private static void InitAttribute(XsdBuilder builder, string value) { }

	// RVA: 0xD3E280 Offset: 0xD3C880 VA: 0x180D3E280
	private static void BuildAttribute_Default(XsdBuilder builder, string value) { }

	// RVA: 0xD3E2B0 Offset: 0xD3C8B0 VA: 0x180D3E2B0
	private static void BuildAttribute_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0xD3E2E0 Offset: 0xD3C8E0 VA: 0x180D3E2E0
	private static void BuildAttribute_Form(XsdBuilder builder, string value) { }

	// RVA: 0xD3E4C0 Offset: 0xD3CAC0 VA: 0x180D3E4C0
	private static void BuildAttribute_Use(XsdBuilder builder, string value) { }

	// RVA: 0xD3E3C0 Offset: 0xD3C9C0 VA: 0x180D3E3C0
	private static void BuildAttribute_Ref(XsdBuilder builder, string value) { }

	// RVA: 0xD3E390 Offset: 0xD3C990 VA: 0x180D3E390
	private static void BuildAttribute_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD3E440 Offset: 0xD3CA40 VA: 0x180D3E440
	private static void BuildAttribute_Type(XsdBuilder builder, string value) { }

	// RVA: 0xD41220 Offset: 0xD3F820 VA: 0x180D41220
	private static void InitElement(XsdBuilder builder, string value) { }

	// RVA: 0xD3EAD0 Offset: 0xD3D0D0 VA: 0x180D3EAD0
	private static void BuildElement_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0xD3EB50 Offset: 0xD3D150 VA: 0x180D3EB50
	private static void BuildElement_Block(XsdBuilder builder, string value) { }

	// RVA: 0xD3EBC0 Offset: 0xD3D1C0 VA: 0x180D3EBC0
	private static void BuildElement_Default(XsdBuilder builder, string value) { }

	// RVA: 0xD3EC90 Offset: 0xD3D290 VA: 0x180D3EC90
	private static void BuildElement_Form(XsdBuilder builder, string value) { }

	// RVA: 0xD3EED0 Offset: 0xD3D4D0 VA: 0x180D3EED0
	private static void BuildElement_SubstitutionGroup(XsdBuilder builder, string value) { }

	// RVA: 0xD3EBF0 Offset: 0xD3D1F0 VA: 0x180D3EBF0
	private static void BuildElement_Final(XsdBuilder builder, string value) { }

	// RVA: 0xD3EC60 Offset: 0xD3D260 VA: 0x180D3EC60
	private static void BuildElement_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0xD3ED40 Offset: 0xD3D340 VA: 0x180D3ED40
	private static void BuildElement_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0xD3ED70 Offset: 0xD3D370 VA: 0x180D3ED70
	private static void BuildElement_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0xD3EDA0 Offset: 0xD3D3A0 VA: 0x180D3EDA0
	private static void BuildElement_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD3EDD0 Offset: 0xD3D3D0 VA: 0x180D3EDD0
	private static void BuildElement_Nillable(XsdBuilder builder, string value) { }

	// RVA: 0xD3EE50 Offset: 0xD3D450 VA: 0x180D3EE50
	private static void BuildElement_Ref(XsdBuilder builder, string value) { }

	// RVA: 0xD3EF50 Offset: 0xD3D550 VA: 0x180D3EF50
	private static void BuildElement_Type(XsdBuilder builder, string value) { }

	// RVA: 0xD42790 Offset: 0xD40D90 VA: 0x180D42790
	private static void InitSimpleType(XsdBuilder builder, string value) { }

	// RVA: 0xD3FCB0 Offset: 0xD3E2B0 VA: 0x180D3FCB0
	private static void BuildSimpleType_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD3FC40 Offset: 0xD3E240 VA: 0x180D3FC40
	private static void BuildSimpleType_Final(XsdBuilder builder, string value) { }

	// RVA: 0xD42670 Offset: 0xD40C70 VA: 0x180D42670
	private static void InitSimpleTypeUnion(XsdBuilder builder, string value) { }

	// RVA: 0xD3FA80 Offset: 0xD3E080 VA: 0x180D3FA80
	private static void BuildSimpleTypeUnion_MemberTypes(XsdBuilder builder, string value) { }

	// RVA: 0xD423D0 Offset: 0xD409D0 VA: 0x180D423D0
	private static void InitSimpleTypeList(XsdBuilder builder, string value) { }

	// RVA: 0xD3F980 Offset: 0xD3DF80 VA: 0x180D3F980
	private static void BuildSimpleTypeList_ItemType(XsdBuilder builder, string value) { }

	// RVA: 0xD42510 Offset: 0xD40B10 VA: 0x180D42510
	private static void InitSimpleTypeRestriction(XsdBuilder builder, string value) { }

	// RVA: 0xD3FA00 Offset: 0xD3E000 VA: 0x180D3FA00
	private static void BuildSimpleTypeRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0xD40F70 Offset: 0xD3F570 VA: 0x180D40F70
	private static void InitComplexType(XsdBuilder builder, string value) { }

	// RVA: 0xD3E6F0 Offset: 0xD3CCF0 VA: 0x180D3E6F0
	private static void BuildComplexType_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0xD3E770 Offset: 0xD3CD70 VA: 0x180D3E770
	private static void BuildComplexType_Block(XsdBuilder builder, string value) { }

	// RVA: 0xD3E7F0 Offset: 0xD3CDF0 VA: 0x180D3E7F0
	private static void BuildComplexType_Final(XsdBuilder builder, string value) { }

	// RVA: 0xD3E860 Offset: 0xD3CE60 VA: 0x180D3E860
	private static void BuildComplexType_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0xD3E8F0 Offset: 0xD3CEF0 VA: 0x180D3E8F0
	private static void BuildComplexType_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD40E40 Offset: 0xD3F440 VA: 0x180D40E40
	private static void InitComplexContent(XsdBuilder builder, string value) { }

	// RVA: 0xD3E670 Offset: 0xD3CC70 VA: 0x180D3E670
	private static void BuildComplexContent_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0xD40CA0 Offset: 0xD3F2A0 VA: 0x180D40CA0
	private static void InitComplexContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0xD3E570 Offset: 0xD3CB70 VA: 0x180D3E570
	private static void BuildComplexContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0xD40D90 Offset: 0xD3F390 VA: 0x180D40D90
	private static void InitComplexContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0xD3E5F0 Offset: 0xD3CBF0 VA: 0x180D3E5F0
	private static void BuildComplexContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0xD422A0 Offset: 0xD408A0 VA: 0x180D422A0
	private static void InitSimpleContent(XsdBuilder builder, string value) { }

	// RVA: 0xD41F90 Offset: 0xD40590 VA: 0x180D41F90
	private static void InitSimpleContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0xD3F760 Offset: 0xD3DD60 VA: 0x180D3F760
	private static void BuildSimpleContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0xD42100 Offset: 0xD40700 VA: 0x180D42100
	private static void InitSimpleContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0xD3F870 Offset: 0xD3DE70 VA: 0x180D3F870
	private static void BuildSimpleContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0xD409A0 Offset: 0xD3EFA0 VA: 0x180D409A0
	private static void InitAttributeGroup(XsdBuilder builder, string value) { }

	// RVA: 0xD3E250 Offset: 0xD3C850 VA: 0x180D3E250
	private static void BuildAttributeGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD40900 Offset: 0xD3EF00 VA: 0x180D40900
	private static void InitAttributeGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0xD3E1D0 Offset: 0xD3C7D0 VA: 0x180D3E1D0
	private static void BuildAttributeGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0xD40470 Offset: 0xD3EA70 VA: 0x180D40470
	private static void InitAnyAttribute(XsdBuilder builder, string value) { }

	// RVA: 0xD3DF90 Offset: 0xD3C590 VA: 0x180D3DF90
	private static void BuildAnyAttribute_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0xD3DFC0 Offset: 0xD3C5C0 VA: 0x180D3DFC0
	private static void BuildAnyAttribute_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0xD41850 Offset: 0xD3FE50 VA: 0x180D41850
	private static void InitGroup(XsdBuilder builder, string value) { }

	// RVA: 0xD3F140 Offset: 0xD3D740 VA: 0x180D3F140
	private static void BuildGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD417A0 Offset: 0xD3FDA0 VA: 0x180D417A0
	private static void InitGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0xD3F430 Offset: 0xD3DA30 VA: 0x180D3F430
	private static void BuildParticle_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0xD3F460 Offset: 0xD3DA60 VA: 0x180D3F460
	private static void BuildParticle_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0xD3F0C0 Offset: 0xD3D6C0 VA: 0x180D3F0C0
	private static void BuildGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0xD402D0 Offset: 0xD3E8D0 VA: 0x180D402D0
	private static void InitAll(XsdBuilder builder, string value) { }

	// RVA: 0xD40BF0 Offset: 0xD3F1F0 VA: 0x180D40BF0
	private static void InitChoice(XsdBuilder builder, string value) { }

	// RVA: 0xD41EE0 Offset: 0xD404E0 VA: 0x180D41EE0
	private static void InitSequence(XsdBuilder builder, string value) { }

	// RVA: 0xD40780 Offset: 0xD3ED80 VA: 0x180D40780
	private static void InitAny(XsdBuilder builder, string value) { }

	// RVA: 0xD3E070 Offset: 0xD3C670 VA: 0x180D3E070
	private static void BuildAny_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0xD3E0A0 Offset: 0xD3C6A0 VA: 0x180D3E0A0
	private static void BuildAny_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0xD41C60 Offset: 0xD40260 VA: 0x180D41C60
	private static void InitNotation(XsdBuilder builder, string value) { }

	// RVA: 0xD3F3A0 Offset: 0xD3D9A0 VA: 0x180D3F3A0
	private static void BuildNotation_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD3F3D0 Offset: 0xD3D9D0 VA: 0x180D3F3D0
	private static void BuildNotation_Public(XsdBuilder builder, string value) { }

	// RVA: 0xD3F400 Offset: 0xD3DA00 VA: 0x180D3F400
	private static void BuildNotation_System(XsdBuilder builder, string value) { }

	// RVA: 0xD41380 Offset: 0xD3F980 VA: 0x180D41380
	private static void InitFacet(XsdBuilder builder, string value) { }

	// RVA: 0xD3EFD0 Offset: 0xD3D5D0 VA: 0x180D3EFD0
	private static void BuildFacet_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0xD3F060 Offset: 0xD3D660 VA: 0x180D3F060
	private static void BuildFacet_Value(XsdBuilder builder, string value) { }

	// RVA: 0xD41980 Offset: 0xD3FF80 VA: 0x180D41980
	private static void InitIdentityConstraint(XsdBuilder builder, string value) { }

	// RVA: 0xD3F170 Offset: 0xD3D770 VA: 0x180D3F170
	private static void BuildIdentityConstraint_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD3F1A0 Offset: 0xD3D7A0 VA: 0x180D3F1A0
	private static void BuildIdentityConstraint_Refer(XsdBuilder builder, string value) { }

	// RVA: 0xD41E10 Offset: 0xD40410 VA: 0x180D41E10
	private static void InitSelector(XsdBuilder builder, string value) { }

	// RVA: 0xD3F090 Offset: 0xD3D690 VA: 0x180D3F090
	private static void BuildSelector_XPath(XsdBuilder builder, string value) { }

	// RVA: 0xD416C0 Offset: 0xD3FCC0 VA: 0x180D416C0
	private static void InitField(XsdBuilder builder, string value) { }

	// RVA: 0xD3F090 Offset: 0xD3D690 VA: 0x180D3F090
	private static void BuildField_XPath(XsdBuilder builder, string value) { }

	// RVA: 0xD40380 Offset: 0xD3E980 VA: 0x180D40380
	private static void InitAnnotation(XsdBuilder builder, string value) { }

	// RVA: 0xD40830 Offset: 0xD3EE30 VA: 0x180D40830
	private static void InitAppinfo(XsdBuilder builder, string value) { }

	// RVA: 0xD3E150 Offset: 0xD3C750 VA: 0x180D3E150
	private static void BuildAppinfo_Source(XsdBuilder builder, string value) { }

	// RVA: 0xD3FCE0 Offset: 0xD3E2E0 VA: 0x180D3FCE0
	private static void EndAppinfo(XsdBuilder builder) { }

	// RVA: 0xD41150 Offset: 0xD3F750 VA: 0x180D41150
	private static void InitDocumentation(XsdBuilder builder, string value) { }

	// RVA: 0xD3E920 Offset: 0xD3CF20 VA: 0x180D3E920
	private static void BuildDocumentation_Source(XsdBuilder builder, string value) { }

	// RVA: 0xD3E9A0 Offset: 0xD3CFA0 VA: 0x180D3E9A0
	private static void BuildDocumentation_XmlLang(XsdBuilder builder, string value) { }

	// RVA: 0xD3FE00 Offset: 0xD3E400 VA: 0x180D3FE00
	private static void EndDocumentation(XsdBuilder builder) { }

	// RVA: 0xD3D8F0 Offset: 0xD3BEF0 VA: 0x180D3D8F0
	private void AddAttribute(XmlSchemaObject value) { }

	// RVA: 0xD3DBA0 Offset: 0xD3C1A0 VA: 0x180D3DBA0
	private void AddParticle(XmlSchemaParticle particle) { }

	// RVA: 0xD400B0 Offset: 0xD3E6B0 VA: 0x180D400B0
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0xD42BE0 Offset: 0xD411E0 VA: 0x180D42BE0
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0xD451D0 Offset: 0xD437D0 VA: 0x180D451D0
	private void SetMinOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0xD45140 Offset: 0xD43740 VA: 0x180D45140
	private void SetMaxOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0xD42EF0 Offset: 0xD414F0 VA: 0x180D42EF0
	private bool ParseBoolean(string value, string attributeName) { }

	// RVA: 0xD42F90 Offset: 0xD41590 VA: 0x180D42F90
	private int ParseEnum(string value, string attributeName, string[] values) { }

	// RVA: 0xD43080 Offset: 0xD41680 VA: 0x180D43080
	private XmlQualifiedName ParseQName(string value, string attributeName) { }

	// RVA: 0xD42C10 Offset: 0xD41210 VA: 0x180D42C10
	private int ParseBlockFinalEnum(string value, string attributeName) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	private static string ParseUriReference(string s) { }

	// RVA: 0xD43FC0 Offset: 0xD425C0 VA: 0x180D43FC0
	private void SendValidationEvent(string code, string arg0, string arg1, string arg2) { }

	// RVA: 0xD441F0 Offset: 0xD427F0 VA: 0x180D441F0
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0xD43DD0 Offset: 0xD423D0 VA: 0x180D43DD0
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0xD43EF0 Offset: 0xD424F0 VA: 0x180D43EF0
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0xD43D10 Offset: 0xD42310 VA: 0x180D43D10
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0xD43C40 Offset: 0xD42240 VA: 0x180D43C40
	private void RecordPosition() { }

	// RVA: 0xD45410 Offset: 0xD43A10 VA: 0x180D45410
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

	// RVA: 0x1111400 Offset: 0x110FA00 VA: 0x181111400 Slot: 12
	public virtual void Invoke(XsdBuilder builder, string value) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
	public virtual IAsyncResult BeginInvoke(XsdBuilder builder, string value, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XsdBuilder.XsdInitFunction : MulticastDelegate // TypeDefIndex: 2415
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1111400 Offset: 0x110FA00 VA: 0x181111400 Slot: 12
	public virtual void Invoke(XsdBuilder builder, string value) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
	public virtual IAsyncResult BeginInvoke(XsdBuilder builder, string value, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XsdBuilder.XsdEndChildFunction : MulticastDelegate // TypeDefIndex: 2416
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x583E20 Offset: 0x582420 VA: 0x180583E20 Slot: 12
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

	// RVA: 0xC65380 Offset: 0xC63980 VA: 0x180C65380
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

	// RVA: 0x1115670 Offset: 0x1113C70 VA: 0x181115670
	public void .ctor(SchemaNames.Token n, XsdBuilder.State state, XsdBuilder.State[] nextStates, XsdBuilder.XsdAttributeEntry[] attributes, XsdBuilder.XsdInitFunction init, XsdBuilder.XsdEndChildFunction end, bool parseContent) { }

}

private class XsdBuilder.BuilderNamespaceManager : XmlNamespaceManager // TypeDefIndex: 2419
{	// Fields
	private XmlNamespaceManager nsMgr; // 0x50
	private XmlReader reader; // 0x58

	// Methods

	// RVA: 0x10FE070 Offset: 0x10FC670 VA: 0x1810FE070
	public void .ctor(XmlNamespaceManager nsMgr, XmlReader reader) { }

	// RVA: 0x10FE010 Offset: 0x10FC610 VA: 0x1810FE010 Slot: 16
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

	// RVA: 0x1ADFB0 Offset: 0x1AD3B0 VA: 0x1801ADFB0
	public void .ctor(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x1ADF10 Offset: 0x1AD310 VA: 0x1801ADF10
	private void .ctor(XsdDateTime.Parser parser) { }

	// RVA: 0x1ADD90 Offset: 0x1AD190 VA: 0x1801ADD90
	private void InitiateXsdDateTime(XsdDateTime.Parser parser) { }

	// RVA: 0x1112950 Offset: 0x1110F50 VA: 0x181112950
	internal static bool TryParse(string text, XsdDateTimeFlags kinds, out XsdDateTime result) { }

	// RVA: 0x1AE140 Offset: 0x1AD540 VA: 0x1801AE140
	public void .ctor(DateTime dateTime, XsdDateTimeFlags kinds) { }

	// RVA: 0x1ADF60 Offset: 0x1AD360 VA: 0x1801ADF60
	public void .ctor(DateTimeOffset dateTimeOffset) { }

	// RVA: 0x1ADF90 Offset: 0x1AD390 VA: 0x1801ADF90
	public void .ctor(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds) { }

	// RVA: 0x1AE2A0 Offset: 0x1AD6A0 VA: 0x1801AE2A0
	private XsdDateTime.DateTimeTypeCode get_InternalTypeCode() { }

	// RVA: 0x1AE290 Offset: 0x1AD690 VA: 0x1801AE290
	private XsdDateTime.XsdDateTimeKind get_InternalKind() { }

	// RVA: 0x1AE2E0 Offset: 0x1AD6E0 VA: 0x1801AE2E0
	public int get_Year() { }

	// RVA: 0x1AE2C0 Offset: 0x1AD6C0 VA: 0x1801AE2C0
	public int get_Month() { }

	// RVA: 0x1AE260 Offset: 0x1AD660 VA: 0x1801AE260
	public int get_Day() { }

	// RVA: 0x1AE280 Offset: 0x1AD680 VA: 0x1801AE280
	public int get_Hour() { }

	// RVA: 0x1AE2B0 Offset: 0x1AD6B0 VA: 0x1801AE2B0
	public int get_Minute() { }

	// RVA: 0x1AE2D0 Offset: 0x1AD6D0 VA: 0x1801AE2D0
	public int get_Second() { }

	// RVA: 0x1AE270 Offset: 0x1AD670 VA: 0x1801AE270
	public int get_Fraction() { }

	// RVA: 0x1AE2F0 Offset: 0x1AD6F0 VA: 0x1801AE2F0
	public int get_ZoneHour() { }

	// RVA: 0x14B7D0 Offset: 0x14ABD0 VA: 0x18014B7D0
	public int get_ZoneMinute() { }

	// RVA: 0x11134B0 Offset: 0x1111AB0 VA: 0x1811134B0
	public static DateTime op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x1113260 Offset: 0x1111860 VA: 0x181113260
	public static DateTimeOffset op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x1ADF00 Offset: 0x1AD300 VA: 0x1801ADF00 Slot: 3
	public override string ToString() { }

	// RVA: 0x1ADE50 Offset: 0x1AD250 VA: 0x1801ADE50
	private void PrintDate(StringBuilder sb) { }

	// RVA: 0x1ADE60 Offset: 0x1AD260 VA: 0x1801ADE60
	private void PrintTime(StringBuilder sb) { }

	// RVA: 0x1ADE70 Offset: 0x1AD270 VA: 0x1801ADE70
	private void PrintZone(StringBuilder sb) { }

	// RVA: 0x1ADDD0 Offset: 0x1AD1D0 VA: 0x1801ADDD0
	private void IntToCharArray(char[] text, int start, int value, int digits) { }

	// RVA: 0x1ADE80 Offset: 0x1AD280 VA: 0x1801ADE80
	private void ShortToCharArray(char[] text, int start, int value) { }

	// RVA: 0x1112A00 Offset: 0x1111000 VA: 0x181112A00
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

	// RVA: 0x1ADC70 Offset: 0x1AD070 VA: 0x1801ADC70
	public bool Parse(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x1ADBB0 Offset: 0x1ACFB0 VA: 0x1801ADBB0
	private bool ParseDate(int start) { }

	// RVA: 0x1ADC00 Offset: 0x1AD000 VA: 0x1801ADC00
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0x1ADBC0 Offset: 0x1ACFC0 VA: 0x1801ADBC0
	private bool ParseTimeAndWhitespace(int start) { }

	// RVA: 0x1ADC50 Offset: 0x1AD050 VA: 0x1801ADC50
	private bool ParseTime(ref int start) { }

	// RVA: 0x1ADC60 Offset: 0x1AD060 VA: 0x1801ADC60
	private bool ParseZoneAndWhitespace(int start) { }

	// RVA: 0x1ADB60 Offset: 0x1ACF60 VA: 0x1801ADB60
	private bool Parse4Dig(int start, ref int num) { }

	// RVA: 0x1ADB50 Offset: 0x1ACF50 VA: 0x1801ADB50
	private bool Parse2Dig(int start, ref int num) { }

	// RVA: 0x1ADB70 Offset: 0x1ACF70 VA: 0x1801ADB70
	private bool ParseChar(int start, char ch) { }

	// RVA: 0x1103610 Offset: 0x1101C10 VA: 0x181103610
	private static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right) { }

	// RVA: 0x1103620 Offset: 0x1101C20 VA: 0x181103620
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

	// RVA: 0x1AE410 Offset: 0x1AD810 VA: 0x1801AE410
	public void .ctor(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds) { }

	// RVA: 0x1AE400 Offset: 0x1AD800 VA: 0x1801AE400
	public void .ctor(TimeSpan timeSpan) { }

	// RVA: 0x1AE3E0 Offset: 0x1AD7E0 VA: 0x1801AE3E0
	public void .ctor(TimeSpan timeSpan, XsdDuration.DurationType durationType) { }

	// RVA: 0x1AE3F0 Offset: 0x1AD7F0 VA: 0x1801AE3F0
	public void .ctor(string s) { }

	// RVA: 0x1AE420 Offset: 0x1AD820 VA: 0x1801AE420
	public void .ctor(string s, XsdDuration.DurationType durationType) { }

	// RVA: 0x1AE440 Offset: 0x1AD840 VA: 0x1801AE440
	public bool get_IsNegative() { }

	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720
	public int get_Years() { }

	// RVA: 0x14B7E0 Offset: 0x14ABE0 VA: 0x18014B7E0
	public int get_Months() { }

	// RVA: 0x122E10 Offset: 0x122210 VA: 0x180122E10
	public int get_Days() { }

	// RVA: 0x1AE430 Offset: 0x1AD830 VA: 0x1801AE430
	public int get_Hours() { }

	// RVA: 0xF3EB0 Offset: 0xF32B0 VA: 0x1800F3EB0
	public int get_Minutes() { }

	// RVA: 0x1AE460 Offset: 0x1AD860 VA: 0x1801AE460
	public int get_Seconds() { }

	// RVA: 0x1AE450 Offset: 0x1AD850 VA: 0x1801AE450
	public int get_Nanoseconds() { }

	// RVA: 0x1AE350 Offset: 0x1AD750 VA: 0x1801AE350
	public TimeSpan ToTimeSpan() { }

	// RVA: 0x1AE340 Offset: 0x1AD740 VA: 0x1801AE340
	public TimeSpan ToTimeSpan(XsdDuration.DurationType durationType) { }

	// RVA: 0x1AE3B0 Offset: 0x1AD7B0 VA: 0x1801AE3B0
	internal Exception TryToTimeSpan(out TimeSpan result) { }

	// RVA: 0x1AE3D0 Offset: 0x1AD7D0 VA: 0x1801AE3D0
	internal Exception TryToTimeSpan(XsdDuration.DurationType durationType, out TimeSpan result) { }

	// RVA: 0x1AE330 Offset: 0x1AD730 VA: 0x1801AE330 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AE320 Offset: 0x1AD720 VA: 0x1801AE320
	internal string ToString(XsdDuration.DurationType durationType) { }

	// RVA: 0x1114BD0 Offset: 0x11131D0 VA: 0x181114BD0
	internal static Exception TryParse(string s, out XsdDuration result) { }

	// RVA: 0x1113F90 Offset: 0x1112590 VA: 0x181113F90
	internal static Exception TryParse(string s, XsdDuration.DurationType durationType, out XsdDuration result) { }

	// RVA: 0x1113E20 Offset: 0x1112420 VA: 0x181113E20
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

	// RVA: 0x111B4B0 Offset: 0x1119AB0 VA: 0x18111B4B0
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x111B4E0 Offset: 0x1119AE0 VA: 0x18111B4E0
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x1117A60 Offset: 0x1116060 VA: 0x181117A60
	private void Init() { }

	// RVA: 0x111B320 Offset: 0x1119920 VA: 0x18111B320 Slot: 5
	public override void Validate() { }

	// RVA: 0x11160A0 Offset: 0x11146A0 VA: 0x1811160A0 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x111B540 Offset: 0x1119B40 VA: 0x18111B540
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x1118E00 Offset: 0x1117400 VA: 0x181118E00
	private void ProcessInlineSchema() { }

	// RVA: 0x111A380 Offset: 0x1118980 VA: 0x18111A380
	private void ValidateElement() { }

	// RVA: 0x111A130 Offset: 0x1118730 VA: 0x18111A130
	private object ValidateChildElement() { }

	// RVA: 0x1118670 Offset: 0x1116C70 VA: 0x181118670
	private void ProcessElement(object particle) { }

	// RVA: 0x1119340 Offset: 0x1117940 VA: 0x181119340
	private void ProcessXsiAttributes(out XmlQualifiedName xsiType, out string xsiNil) { }

	// RVA: 0x111A560 Offset: 0x1118B60 VA: 0x18111A560
	private void ValidateEndElement() { }

	// RVA: 0x1117940 Offset: 0x1115F40 VA: 0x181117940
	private SchemaElementDecl FastGetElementDecl(object particle) { }

	// RVA: 0x1119C70 Offset: 0x1118270 VA: 0x181119C70
	private SchemaElementDecl ThoroughGetElementDecl(SchemaElementDecl elementDecl, XmlQualifiedName xsiType, string xsiNil) { }

	// RVA: 0x111ACE0 Offset: 0x11192E0 VA: 0x18111ACE0
	private void ValidateStartElement() { }

	// RVA: 0x111A860 Offset: 0x1118E60 VA: 0x18111A860
	private void ValidateEndStartElement() { }

	// RVA: 0x1117E20 Offset: 0x1116420 VA: 0x181117E20
	private void LoadSchemaFromLocation(string uri, string url) { }

	// RVA: 0x11183F0 Offset: 0x11169F0 VA: 0x1811183F0
	private void LoadSchema(string uri, string url) { }

	// RVA: 0x111B520 Offset: 0x1119B20 VA: 0x18111B520
	private bool get_HasSchema() { }

	// RVA: 0x111B550 Offset: 0x1119B50 VA: 0x18111B550 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x11190C0 Offset: 0x11176C0 VA: 0x1811190C0
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x11161E0 Offset: 0x11147E0 VA: 0x1811161E0
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x1115700 Offset: 0x1113D00 VA: 0x181115700
	internal void AddID(string name, object node) { }

	// RVA: 0x1117A40 Offset: 0x1116040 VA: 0x181117A40 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x1117DD0 Offset: 0x11163D0 VA: 0x181117DD0
	public bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x1119AF0 Offset: 0x11180F0 VA: 0x181119AF0
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x11185B0 Offset: 0x1116BB0 VA: 0x1811185B0
	private void Pop() { }

	// RVA: 0x11160A0 Offset: 0x11146A0 VA: 0x1811160A0
	private void CheckForwardRefs() { }

	// RVA: 0x111AC90 Offset: 0x1119290 VA: 0x18111AC90
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x111B510 Offset: 0x1119B10 VA: 0x18111B510
	private bool get_HasIdentityConstraints() { }

	// RVA: 0x11157B0 Offset: 0x1113DB0 VA: 0x1811157B0
	private void AddIdentityConstraints() { }

	// RVA: 0x1116600 Offset: 0x1114C00 VA: 0x181116600
	private void ElementIdentityConstraints() { }

	// RVA: 0x1115D50 Offset: 0x1114350 VA: 0x181115D50
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, SchemaAttDef attdef) { }

	// RVA: 0x111A0B0 Offset: 0x11186B0 VA: 0x18111A0B0
	private object UnWrapUnion(object typedValue) { }

	// RVA: 0x1116A10 Offset: 0x1115010 VA: 0x181116A10
	private void EndElementIdentityConstraints() { }

	// RVA: 0x111B3F0 Offset: 0x11199F0 VA: 0x18111B3F0
	private static void .cctor() { }

}

public sealed class XmlReaderSection // TypeDefIndex: 2429
{	// Properties
	internal static bool ProhibitDefaultUrlResolver { get; }
	internal static bool CollapseWhiteSpaceIntoEmptyString { get; }

	// Methods

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	internal static bool get_ProhibitDefaultUrlResolver() { }

	// RVA: 0xE66C10 Offset: 0xE65210 VA: 0x180E66C10
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
	private static Action<bool> displayFocusChanged; // 0x1351B

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22FBB30 Offset: 0x22FA130 VA: 0x1822FBB30
	private static void InvokeDisplayFocusChanged(bool focus) { }

	// RVA: 0x22FBB90 Offset: 0x22FA190 VA: 0x1822FBB90
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

	// RVA: 0x22FBAF0 Offset: 0x22FA0F0 VA: 0x1822FBAF0
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
	// RVA: 0x22FBCC0 Offset: 0x22FA2C0 VA: 0x1822FBCC0
	private static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x978F0 Offset: 0x96CF0 VA: 0x1800978F0
	// RVA: 0x22FBC10 Offset: 0x22FA210 VA: 0x1822FBC10
	private static void InvokeBoundaryChangedEvent(IntPtr internalPtr) { }

	// RVA: 0x22FBD70 Offset: 0x22FA370 VA: 0x1822FBD70
	public void .ctor() { }

}

public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor<XRInputSubsystem> // TypeDefIndex: 4155
{	// Methods

	// RVA: 0x22FBBD0 Offset: 0x22FA1D0 VA: 0x1822FBBD0
	public void .ctor() { }

}

public class XRMeshSubsystem : IntegratedSubsystem<XRMeshSubsystemDescriptor> // TypeDefIndex: 4161
{	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22FBDF0 Offset: 0x22FA3F0 VA: 0x1822FBDF0
	private void InvokeMeshReadyDelegate(MeshGenerationResult result, Action<MeshGenerationResult> onMeshGenerationComplete) { }

	// RVA: 0x22FBE60 Offset: 0x22FA460 VA: 0x1822FBE60
	public void .ctor() { }

}

public class XRMeshSubsystemDescriptor : IntegratedSubsystemDescriptor<XRMeshSubsystem> // TypeDefIndex: 4162
{	// Methods

	// RVA: 0x22FBDB0 Offset: 0x22FA3B0 VA: 0x1822FBDB0
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

	// RVA: 0xCD3A90 Offset: 0xCD2090 VA: 0x180CD3A90
	internal void .ctor(DataSet ds, bool fInline) { }

	// RVA: 0xCD1210 Offset: 0xCCF810 VA: 0x180CD1210
	internal void LoadSchema(XmlElement schemaRoot, DataSet ds) { }

	// RVA: 0xCCEF60 Offset: 0xCCD560 VA: 0x180CCEF60
	internal XmlElement FindTypeNode(XmlElement node) { }

	// RVA: 0xCD0DD0 Offset: 0xCCF3D0 VA: 0x180CD0DD0
	internal bool IsTextOnlyContent(XmlElement node) { }

	// RVA: 0xCD0F20 Offset: 0xCCF520 VA: 0x180CD0F20
	internal bool IsXDRField(XmlElement node, XmlElement typeNode) { }

	// RVA: 0xCD0290 Offset: 0xCCE890 VA: 0x180CD0290
	internal DataTable HandleTable(XmlElement node) { }

	// RVA: 0xCCEE70 Offset: 0xCCD470 VA: 0x180CCEE70
	private static XDRSchema.NameType FindNameType(string name) { }

	// RVA: 0xCD2160 Offset: 0xCD0760 VA: 0x180CD2160
	private Type ParseDataType(string dt, string dtValues) { }

	// RVA: 0xCCF420 Offset: 0xCCDA20 VA: 0x180CCF420
	internal string GetInstanceName(XmlElement node) { }

	// RVA: 0xCCF910 Offset: 0xCCDF10 VA: 0x180CCF910
	internal void HandleColumn(XmlElement node, DataTable table) { }

	// RVA: 0xCCF8E0 Offset: 0xCCDEE0 VA: 0x180CCF8E0
	internal void GetMinMax(XmlElement elNode, ref int minOccurs, ref int maxOccurs) { }

	// RVA: 0xCCF5C0 Offset: 0xCCDBC0 VA: 0x180CCF5C0
	internal void GetMinMax(XmlElement elNode, bool isAttribute, ref int minOccurs, ref int maxOccurs) { }

	// RVA: 0xCD0420 Offset: 0xCCEA20 VA: 0x180CD0420
	internal void HandleTypeNode(XmlElement typeNode, DataTable table, ArrayList tableChildren) { }

	// RVA: 0xCD0870 Offset: 0xCCEE70 VA: 0x180CD0870
	internal DataTable InstantiateTable(DataSet dataSet, XmlElement node, XmlElement typeNode) { }

	// RVA: 0xCD0630 Offset: 0xCCEC30 VA: 0x180CD0630
	internal DataTable InstantiateSimpleTable(DataSet dataSet, XmlElement node) { }

	// RVA: 0xCD2290 Offset: 0xCD0890 VA: 0x180CD2290
	private static void .cctor() { }

}

private sealed class XDRSchema.NameType : IComparable // TypeDefIndex: 4314
{	// Fields
	public string name; // 0x10
	public Type type; // 0x18

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	public void .ctor(string n, Type t) { }

	// RVA: 0xCBFFA0 Offset: 0xCBE5A0 VA: 0x180CBFFA0 Slot: 4
	public int CompareTo(object obj) { }

}

internal sealed class XMLDiffLoader // TypeDefIndex: 4315
{	// Fields
	private ArrayList _tables; // 0x10
	private DataSet _dataSet; // 0x18
	private DataTable _dataTable; // 0x20

	// Methods

	// RVA: 0xCD41F0 Offset: 0xCD27F0 VA: 0x180CD41F0
	internal void LoadDiffGram(DataSet ds, XmlReader dataTextReader) { }

	// RVA: 0xCD3B30 Offset: 0xCD2130 VA: 0x180CD3B30
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0xCD4010 Offset: 0xCD2610 VA: 0x180CD4010
	internal void LoadDiffGram(DataTable dt, XmlReader dataTextReader) { }

	// RVA: 0xCD4670 Offset: 0xCD2C70 VA: 0x180CD4670
	internal void ProcessDiffs(DataSet ds, XmlReader ssync) { }

	// RVA: 0xCD4360 Offset: 0xCD2960 VA: 0x180CD4360
	internal void ProcessDiffs(ArrayList tableList, XmlReader ssync) { }

	// RVA: 0xCD4F00 Offset: 0xCD3500 VA: 0x180CD4F00
	internal void ProcessErrors(DataSet ds, XmlReader ssync) { }

	// RVA: 0xCD49D0 Offset: 0xCD2FD0 VA: 0x180CD49D0
	internal void ProcessErrors(ArrayList dt, XmlReader ssync) { }

	// RVA: 0xCD3DF0 Offset: 0xCD23F0 VA: 0x180CD3DF0
	private DataTable GetTable(string tableName, string ns) { }

	// RVA: 0xCD52D0 Offset: 0xCD38D0 VA: 0x180CD52D0
	private int ReadOldRowData(DataSet ds, ref DataTable table, ref int pos, XmlReader row) { }

	// RVA: 0xCD5FE0 Offset: 0xCD45E0 VA: 0x180CD5FE0
	internal void SkipWhitespaces(XmlReader reader) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal class XMLSchema // TypeDefIndex: 4316
{	// Methods

	// RVA: 0xCD6320 Offset: 0xCD4920 VA: 0x180CD6320
	internal static TypeConverter GetConverter(Type type) { }

	// RVA: 0xCD6380 Offset: 0xCD4980 VA: 0x180CD6380
	internal static void SetProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0xCD6050 Offset: 0xCD4650 VA: 0x180CD6050
	internal static bool FEqualIdentity(XmlNode node, string name, string ns) { }

	// RVA: 0xCD6210 Offset: 0xCD4810 VA: 0x180CD6210
	internal static bool GetBooleanAttribute(XmlElement element, string attrName, string attrNS, bool defVal) { }

	// RVA: 0xCD60E0 Offset: 0xCD46E0 VA: 0x180CD60E0
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

	// RVA: 0xC2BAA0 Offset: 0xC2A0A0 VA: 0x180C2BAA0
	internal bool get_FromInference() { }

	// RVA: 0xC2BF80 Offset: 0xC2A580 VA: 0x180C2BF80
	internal void set_FromInference(bool value) { }

	// RVA: 0xCD7440 Offset: 0xCD5A40 VA: 0x180CD7440
	private void CollectElementsAnnotations(XmlSchema schema) { }

	// RVA: 0xCD6AE0 Offset: 0xCD50E0 VA: 0x180CD6AE0
	private void CollectElementsAnnotations(XmlSchema schema, ArrayList schemaList) { }

	// RVA: 0xCE8090 Offset: 0xCE6690 VA: 0x180CE8090
	internal static string QualifiedName(string name) { }

	// RVA: 0xCE86F0 Offset: 0xCE6CF0 VA: 0x180CE86F0
	internal static void SetProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xCE8340 Offset: 0xCE6940 VA: 0x180CE8340
	private static void SetExtProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xCDA7E0 Offset: 0xCD8DE0 VA: 0x180CDA7E0
	private void HandleColumnExpression(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xCD85C0 Offset: 0xCD6BC0 VA: 0x180CD85C0
	internal static string GetMsdataAttribute(XmlSchemaAnnotated node, string ln) { }

	// RVA: 0xCE8100 Offset: 0xCE6700 VA: 0x180CE8100
	private static void SetExtProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0xCDF590 Offset: 0xCDDB90 VA: 0x180CDF590
	internal void HandleRefTableProperties(ArrayList RefTables, XmlSchemaElement element) { }

	// RVA: 0xCDF690 Offset: 0xCDDC90 VA: 0x180CDF690
	internal void HandleRelation(XmlElement node, bool fNested) { }

	// RVA: 0xCE1500 Offset: 0xCDFB00 VA: 0x180CE1500
	private bool HasAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0xCE4A70 Offset: 0xCE3070 VA: 0x180CE4A70
	private bool IsDatasetParticle(XmlSchemaParticle pt) { }

	// RVA: 0xCD74D0 Offset: 0xCD5AD0 VA: 0x180CD74D0
	private int DatasetElementCount(XmlSchemaObjectCollection elements) { }

	// RVA: 0xCD7670 Offset: 0xCD5C70 VA: 0x180CD7670
	private XmlSchemaElement FindDatasetElement(XmlSchemaObjectCollection elements) { }

	// RVA: 0xCE7D90 Offset: 0xCE6390 VA: 0x180CE7D90
	public void LoadSchema(XmlSchemaSet schemaSet, DataTable dt) { }

	// RVA: 0xCE55B0 Offset: 0xCE3BB0 VA: 0x180CE55B0
	public void LoadSchema(XmlSchemaSet schemaSet, DataSet ds) { }

	// RVA: 0xCDFF60 Offset: 0xCDE560 VA: 0x180CDFF60
	private void HandleRelations(XmlSchemaAnnotation ann, bool fNested) { }

	// RVA: 0xCD89F0 Offset: 0xCD6FF0 VA: 0x180CD89F0
	internal XmlSchemaObjectCollection GetParticleItems(XmlSchemaParticle pt) { }

	// RVA: 0xCDE650 Offset: 0xCDCC50 VA: 0x180CDE650
	internal void HandleParticle(XmlSchemaParticle pt, DataTable table, ArrayList tableChildren, bool isBase) { }

	// RVA: 0xCDA530 Offset: 0xCD8B30 VA: 0x180CDA530
	internal void HandleAttributes(XmlSchemaObjectCollection attributes, DataTable table, bool isBase) { }

	// RVA: 0xCDA190 Offset: 0xCD8790 VA: 0x180CDA190
	private void HandleAttributeGroup(XmlSchemaAttributeGroup attributeGroup, DataTable table, bool isBase) { }

	// RVA: 0xCDAA00 Offset: 0xCD9000 VA: 0x180CDAA00
	internal void HandleComplexType(XmlSchemaComplexType ct, DataTable table, ArrayList tableChildren, bool isNillable) { }

	// RVA: 0xCD8E30 Offset: 0xCD7430 VA: 0x180CD8E30
	internal XmlSchemaParticle GetParticle(XmlSchemaComplexType ct) { }

	// RVA: 0xCD7C20 Offset: 0xCD6220 VA: 0x180CD7C20
	internal DataColumn FindField(DataTable table, string field) { }

	// RVA: 0xCD68B0 Offset: 0xCD4EB0 VA: 0x180CD68B0
	internal DataColumn[] BuildKey(XmlSchemaIdentityConstraint keyNode, DataTable table) { }

	// RVA: 0xCD8340 Offset: 0xCD6940 VA: 0x180CD8340
	internal bool GetBooleanAttribute(XmlSchemaAnnotated element, string attrName, bool defVal) { }

	// RVA: 0xCD9380 Offset: 0xCD7980 VA: 0x180CD9380
	internal string GetStringAttribute(XmlSchemaAnnotated element, string attrName, string defVal) { }

	// RVA: 0xCE8BD0 Offset: 0xCE71D0 VA: 0x180CE8BD0
	internal static AcceptRejectRule TranslateAcceptRejectRule(string strRule) { }

	// RVA: 0xCE8C30 Offset: 0xCE7230 VA: 0x180CE8C30
	internal static Rule TranslateRule(string strRule) { }

	// RVA: 0xCDDD60 Offset: 0xCDC360 VA: 0x180CDDD60
	internal void HandleKeyref(XmlSchemaKeyref keyref) { }

	// RVA: 0xCDB300 Offset: 0xCD9900 VA: 0x180CDB300
	internal void HandleConstraint(XmlSchemaIdentityConstraint keyNode) { }

	// RVA: 0xCE1740 Offset: 0xCDFD40 VA: 0x180CE1740
	internal DataTable InstantiateSimpleTable(XmlSchemaElement node) { }

	// RVA: 0xCD8460 Offset: 0xCD6A60 VA: 0x180CD8460
	internal string GetInstanceName(XmlSchemaAnnotated node) { }

	// RVA: 0xCE26C0 Offset: 0xCE0CC0 VA: 0x180CE26C0
	internal DataTable InstantiateTable(XmlSchemaElement node, XmlSchemaComplexType typeNode, bool isRef) { }

	// RVA: 0xCE8CE0 Offset: 0xCE72E0 VA: 0x180CE8CE0
	public static Type XsdtoClr(string xsdTypeName) { }

	// RVA: 0xCD7E00 Offset: 0xCD6400 VA: 0x180CD7E00
	private static XSDSchema.NameType FindNameType(string name) { }

	// RVA: 0xCE7DC0 Offset: 0xCE63C0 VA: 0x180CE7DC0
	private Type ParseDataType(string dt) { }

	// RVA: 0xCE5540 Offset: 0xCE3B40 VA: 0x180CE5540
	internal static bool IsXsdType(string name) { }

	// RVA: 0xCD7EF0 Offset: 0xCD64F0 VA: 0x180CD7EF0
	internal XmlSchemaAnnotated FindTypeNode(XmlSchemaAnnotated node) { }

	// RVA: 0xCE09B0 Offset: 0xCDEFB0 VA: 0x180CE09B0
	internal void HandleSimpleTypeSimpleContentColumn(XmlSchemaSimpleType typeNode, string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0xCE0250 Offset: 0xCDE850 VA: 0x180CE0250
	internal void HandleSimpleContentColumn(string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0xCD9700 Offset: 0xCD7D00 VA: 0x180CD9700
	internal void HandleAttributeColumn(XmlSchemaAttribute attrib, DataTable table, bool isBase) { }

	// RVA: 0xCDCD10 Offset: 0xCDB310 VA: 0x180CDCD10
	internal void HandleElementColumn(XmlSchemaElement elem, DataTable table, bool isBase) { }

	// RVA: 0xCDB7E0 Offset: 0xCD9DE0 VA: 0x180CDB7E0
	internal void HandleDataSet(XmlSchemaElement node, bool isNewDataSet) { }

	// RVA: 0xCD6740 Offset: 0xCD4D40 VA: 0x180CD6740
	private void AddTablesToList(List<DataTable> tableList, DataTable dt) { }

	// RVA: 0xCD90B0 Offset: 0xCD76B0 VA: 0x180CD90B0
	private string GetPrefix(string ns) { }

	// RVA: 0xCD8710 Offset: 0xCD6D10 VA: 0x180CD8710
	private string GetNamespaceFromPrefix(string prefix) { }

	// RVA: 0xCD9540 Offset: 0xCD7B40 VA: 0x180CD9540
	private string GetTableNamespace(XmlSchemaIdentityConstraint key) { }

	// RVA: 0xCD9400 Offset: 0xCD7A00 VA: 0x180CD9400
	private string GetTableName(XmlSchemaIdentityConstraint key) { }

	// RVA: 0xCE5220 Offset: 0xCE3820 VA: 0x180CE5220
	internal bool IsTable(XmlSchemaElement node) { }

	// RVA: 0xCE1340 Offset: 0xCDF940 VA: 0x180CE1340
	internal DataTable HandleTable(XmlSchemaElement node) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xCE8DE0 Offset: 0xCE73E0 VA: 0x180CE8DE0
	private static void .cctor() { }

}

private sealed class XSDSchema.NameType : IComparable // TypeDefIndex: 4319
{	// Fields
	public readonly string name; // 0x10
	public readonly Type type; // 0x18

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	public void .ctor(string n, Type t) { }

	// RVA: 0x1AC69E0 Offset: 0x1AC4FE0 VA: 0x181AC69E0 Slot: 4
	public int CompareTo(object obj) { }

}

internal sealed class XmlIgnoreNamespaceReader : XmlNodeReader // TypeDefIndex: 4320
{	// Fields
	private List<string> _namespacesToIgnore; // 0x30

	// Methods

	// RVA: 0x1AD08F0 Offset: 0x1ACEEF0 VA: 0x181AD08F0
	internal void .ctor(XmlDocument xdoc, string[] namespacesToIgnore) { }

	// RVA: 0x1AD0700 Offset: 0x1ACED00 VA: 0x181AD0700 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1AD0800 Offset: 0x1ACEE00 VA: 0x181AD0800 Slot: 28
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

	// RVA: 0x1ACD560 Offset: 0x1ACBB60 VA: 0x181ACD560
	internal void .ctor(DataSet dataset, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0x1ACD6C0 Offset: 0x1ACBCC0 VA: 0x181ACD6C0
	internal void .ctor(DataSet dataset, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0x1ACD600 Offset: 0x1ACBC00 VA: 0x181ACD600
	internal void .ctor(DataTable datatable, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0x1ACD470 Offset: 0x1ACBA70 VA: 0x181ACD470
	internal void .ctor(DataTable datatable, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0xAF5FA0 Offset: 0xAF45A0 VA: 0x180AF5FA0
	internal bool get_FromInference() { }

	// RVA: 0xFFFAA0 Offset: 0xFFE0A0 VA: 0x180FFFAA0
	internal void set_FromInference(bool value) { }

	// RVA: 0x1AC6B00 Offset: 0x1AC5100 VA: 0x181AC6B00
	private void AttachRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0x1AC6C80 Offset: 0x1AC5280 VA: 0x181AC6C80
	private int CountNonNSAttributes(XmlNode node) { }

	// RVA: 0x1AC7760 Offset: 0x1AC5D60 VA: 0x181AC7760
	private string GetValueForTextOnlyColums(XmlNode n) { }

	// RVA: 0x1AC72F0 Offset: 0x1AC58F0 VA: 0x181AC72F0
	private string GetInitialTextFromNodes(ref XmlNode n) { }

	// RVA: 0x1AC76B0 Offset: 0x1AC5CB0 VA: 0x181AC76B0
	private DataColumn GetTextOnlyColumn(DataRow row) { }

	// RVA: 0x1AC7600 Offset: 0x1AC5C00 VA: 0x181AC7600
	internal DataRow GetRowFromElement(XmlElement e) { }

	// RVA: 0x1AC6E10 Offset: 0x1AC5410 VA: 0x181AC6E10
	internal bool FColumnElement(XmlElement e) { }

	// RVA: 0x1AC7070 Offset: 0x1AC5670 VA: 0x181AC7070
	private bool FExcludedNamespace(string ns) { }

	// RVA: 0x1AC7190 Offset: 0x1AC5790 VA: 0x181AC7190
	private bool FIgnoreNamespace(XmlNode node) { }

	// RVA: 0x1AC7100 Offset: 0x1AC5700 VA: 0x181AC7100
	private bool FIgnoreNamespace(XmlReader node) { }

	// RVA: 0x1AC7CD0 Offset: 0x1AC62D0 VA: 0x181AC7CD0
	internal bool IsTextLikeNode(XmlNodeType n) { }

	// RVA: 0x1AC7D30 Offset: 0x1AC6330 VA: 0x181AC7D30
	internal bool IsTextOnly(DataColumn c) { }

	// RVA: 0x1AC8780 Offset: 0x1AC6D80 VA: 0x181AC8780
	internal void LoadData(XmlDocument xdoc) { }

	// RVA: 0x1AC8E40 Offset: 0x1AC7440 VA: 0x181AC8E40
	private void LoadRowData(DataRow row, XmlElement rowElement) { }

	// RVA: 0x1ACA5E0 Offset: 0x1AC8BE0 VA: 0x181ACA5E0
	private void LoadRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0x1ACD420 Offset: 0x1ACBA20 VA: 0x181ACD420
	private void SetRowValueFromXmlText(DataRow row, DataColumn col, string xmlText) { }

	// RVA: 0x1AC7A60 Offset: 0x1AC6060 VA: 0x181AC7A60
	private void InitNameTable() { }

	// RVA: 0x1AC8A60 Offset: 0x1AC7060 VA: 0x181AC8A60
	internal void LoadData(XmlReader reader) { }

	// RVA: 0x1ACC360 Offset: 0x1ACA960 VA: 0x181ACC360
	private void LoadTopMostTable(DataTable table) { }

	// RVA: 0x1ACB500 Offset: 0x1AC9B00 VA: 0x181ACB500
	private void LoadTable(DataTable table, bool isNested) { }

	// RVA: 0x1AC7D60 Offset: 0x1AC6360 VA: 0x181AC7D60
	private void LoadColumn(DataColumn column, object[] foundColumns) { }

	// RVA: 0x1ACD1D0 Offset: 0x1ACB7D0 VA: 0x181ACD1D0
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

	// RVA: 0x1AD4410 Offset: 0x1AD2A10 VA: 0x181AD4410
	public void .ctor(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0x1AD4350 Offset: 0x1AD2950 VA: 0x181AD4350
	public void .ctor(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0x1AD43D0 Offset: 0x1AD29D0 VA: 0x181AD43D0
	public void .ctor(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0x1AD4390 Offset: 0x1AD2990 VA: 0x181AD4390
	public void .ctor(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0x1AD4320 Offset: 0x1AD2920 VA: 0x181AD4320
	internal static bool IsMappedColumn(DataColumn c) { }

	// RVA: 0x1AD1240 Offset: 0x1ACF840 VA: 0x181AD1240
	private XmlToDatasetMap.TableSchemaInfo AddTableSchema(DataTable table, XmlNameTable nameTable) { }

	// RVA: 0x1AD1090 Offset: 0x1ACF690 VA: 0x181AD1090
	private XmlToDatasetMap.TableSchemaInfo AddTableSchema(XmlNameTable nameTable, DataTable table) { }

	// RVA: 0x1AD0D40 Offset: 0x1ACF340 VA: 0x181AD0D40
	private bool AddColumnSchema(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

	// RVA: 0x1AD0EA0 Offset: 0x1ACF4A0 VA: 0x181AD0EA0
	private bool AddColumnSchema(XmlNameTable nameTable, DataColumn col, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

	// RVA: 0x1AD1380 Offset: 0x1ACF980 VA: 0x181AD1380
	private void BuildIdentityMap(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0x1AD2700 Offset: 0x1AD0D00 VA: 0x181AD2700
	private void BuildIdentityMap(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0x1AD3320 Offset: 0x1AD1920 VA: 0x181AD3320
	private void BuildIdentityMap(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0x1AD1B10 Offset: 0x1AD0110 VA: 0x181AD1B10
	private void BuildIdentityMap(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0x1AD3D70 Offset: 0x1AD2370 VA: 0x181AD3D70
	private ArrayList GetSelfAndDescendants(DataTable dt) { }

	// RVA: 0x1AD3980 Offset: 0x1AD1F80 VA: 0x181AD3980
	public object GetColumnSchema(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0x1AD37D0 Offset: 0x1AD1DD0 VA: 0x181AD37D0
	public object GetColumnSchema(DataTable table, XmlReader dataReader, bool fIgnoreNamespace) { }

	// RVA: 0x1AD3C70 Offset: 0x1AD2270 VA: 0x181AD3C70
	public object GetSchemaForNode(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0x1AD40B0 Offset: 0x1AD26B0 VA: 0x181AD40B0
	public DataTable GetTableForNode(XmlReader node, bool fIgnoreNamespace) { }

	// RVA: 0x1AD41A0 Offset: 0x1AD27A0 VA: 0x181AD41A0
	private void HandleSpecialColumn(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

}

private sealed class XmlToDatasetMap.XmlNodeIdentety // TypeDefIndex: 4324
{	// Fields
	public string LocalName; // 0x10
	public string NamespaceURI; // 0x18

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	public void .ctor(string localName, string namespaceURI) { }

	// RVA: 0xDE2260 Offset: 0xDE0860 VA: 0x180DE2260 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AD0C90 Offset: 0x1ACF290 VA: 0x181AD0C90 Slot: 0
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

	// RVA: 0x1AD0970 Offset: 0x1ACEF70 VA: 0x181AD0970
	public void .ctor(int capacity) { }

	// RVA: 0x1AD0B50 Offset: 0x1ACF150 VA: 0x181AD0B50
	public object get_Item(XmlNode node) { }

	// RVA: 0x1AD0BF0 Offset: 0x1ACF1F0 VA: 0x181AD0BF0
	public object get_Item(XmlReader dataReader) { }

	// RVA: 0x1AD0AC0 Offset: 0x1ACF0C0 VA: 0x181AD0AC0
	public object get_Item(DataTable table) { }

	// RVA: 0x1AD0A20 Offset: 0x1ACF020 VA: 0x181AD0A20
	public object get_Item(string name) { }

}

private sealed class XmlToDatasetMap.TableSchemaInfo // TypeDefIndex: 4326
{	// Fields
	public DataTable TableSchema; // 0x10
	public XmlToDatasetMap.XmlNodeIdHashtable ColumnsSchemaMap; // 0x18

	// Methods

	// RVA: 0x1AC6A50 Offset: 0x1AC5050 VA: 0x181AC6A50
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

	// RVA: 0x1AE11B0 Offset: 0x1ADF7B0 VA: 0x181AE11B0
	internal void .ctor(SchemaFormat format) { }

	// RVA: 0x1AD4A00 Offset: 0x1AD3000 VA: 0x181AD4A00
	internal static void AddExtendedProperties(PropertyCollection props, XmlElement node) { }

	// RVA: 0x1AD4A10 Offset: 0x1AD3010 VA: 0x181AD4A10
	internal static void AddExtendedProperties(PropertyCollection props, XmlElement node, Type type) { }

	// RVA: 0x1AD4F40 Offset: 0x1AD3540 VA: 0x181AD4F40
	internal void AddXdoProperties(object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0x1AD5110 Offset: 0x1AD3710 VA: 0x181AD5110
	internal void AddXdoProperty(PropertyDescriptor pd, object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0x1AE0590 Offset: 0x1ADEB90 VA: 0x181AE0590
	internal static string XmlDataTypeName(Type type) { }

	// RVA: 0x1AD7830 Offset: 0x1AD5E30 VA: 0x181AD7830
	private void GenerateConstraintNames(DataTable table, bool fromTable) { }

	// RVA: 0x1AD7530 Offset: 0x1AD5B30 VA: 0x181AD7530
	private void GenerateConstraintNames(ArrayList tables) { }

	// RVA: 0x1AD7630 Offset: 0x1AD5C30 VA: 0x181AD7630
	private void GenerateConstraintNames(DataSet ds) { }

	// RVA: 0x1AE1180 Offset: 0x1ADF780 VA: 0x181AE1180
	private static bool _PropsNotEmpty(PropertyCollection props) { }

	// RVA: 0x1ADBDD0 Offset: 0x1ADA3D0 VA: 0x181ADBDD0
	private bool HaveExtendedProperties(DataSet ds) { }

	// RVA: 0x1AE0400 Offset: 0x1ADEA00 VA: 0x181AE0400
	internal void WriteSchemaRoot(XmlDocument xd, XmlElement rootSchema, string targetNamespace) { }

	// RVA: 0x1AE0390 Offset: 0x1ADE990 VA: 0x181AE0390
	internal static void ValidateColumnMapping(Type columnType) { }

	// RVA: 0x1ADF310 Offset: 0x1ADD910 VA: 0x181ADF310
	internal void SetupAutoGenerated(DataSet ds) { }

	// RVA: 0x1ADF510 Offset: 0x1ADDB10 VA: 0x181ADF510
	internal void SetupAutoGenerated(ArrayList dt) { }

	// RVA: 0x1ADF610 Offset: 0x1ADDC10 VA: 0x181ADF610
	internal void SetupAutoGenerated(DataTable dt) { }

	// RVA: 0x1AD6560 Offset: 0x1AD4B60 VA: 0x181AD6560
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0x1AD62E0 Offset: 0x1AD48E0 VA: 0x181AD62E0
	private void CreateRelations(DataTable dt) { }

	// RVA: 0x1AD6820 Offset: 0x1AD4E20 VA: 0x181AD6820
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0x1ADC7F0 Offset: 0x1ADADF0 VA: 0x181ADC7F0
	internal void SchemaTree(XmlDocument xd, XmlWriter xmlWriter, DataSet ds, DataTable dt, bool writeHierarchy) { }

	// RVA: 0x1ADC350 Offset: 0x1ADA950 VA: 0x181ADC350
	internal XmlElement SchemaTree(XmlDocument xd, DataTable dt) { }

	// RVA: 0x1AD6AE0 Offset: 0x1AD50E0 VA: 0x181AD6AE0
	internal XmlElement FillDataSetElement(XmlDocument xd, DataSet ds, DataTable dt) { }

	// RVA: 0x1ADF120 Offset: 0x1ADD720 VA: 0x181ADF120
	internal void SetPath(XmlWriter xw) { }

	// RVA: 0x1ADBFD0 Offset: 0x1ADA5D0 VA: 0x181ADBFD0
	internal void Save(DataSet ds, XmlWriter xw) { }

	// RVA: 0x1ADC150 Offset: 0x1ADA750 VA: 0x181ADC150
	internal void Save(DataTable dt, XmlWriter xw) { }

	// RVA: 0x1ADC000 Offset: 0x1ADA600 VA: 0x181ADC000
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw) { }

	// RVA: 0x1ADC020 Offset: 0x1ADA620 VA: 0x181ADC020
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy) { }

	// RVA: 0x1ADC220 Offset: 0x1ADA820 VA: 0x181ADC220
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy, Converter<Type, string> multipleTargetConverter) { }

	// RVA: 0x1AD8D40 Offset: 0x1AD7340 VA: 0x181AD8D40
	internal XmlElement HandleRelation(DataRelation rel, XmlDocument dc) { }

	// RVA: 0x1AD70E0 Offset: 0x1AD56E0 VA: 0x181AD70E0
	private static XmlElement FindSimpleType(XmlElement schema, string name) { }

	// RVA: 0x1AD7C70 Offset: 0x1AD6270 VA: 0x181AD7C70
	internal XmlElement GetSchema(string NamespaceURI) { }

	// RVA: 0x1AD7ED0 Offset: 0x1AD64D0 VA: 0x181AD7ED0
	internal void HandleColumnType(DataColumn col, XmlDocument dc, XmlElement root, XmlElement schema) { }

	// RVA: 0x1AD4450 Offset: 0x1AD2A50 VA: 0x181AD4450
	internal void AddColumnProperties(DataColumn col, XmlElement root) { }

	// RVA: 0x1AD7230 Offset: 0x1AD5830 VA: 0x181AD7230
	private string FindTargetNamespace(DataTable table) { }

	// RVA: 0x1AD8340 Offset: 0x1AD6940 VA: 0x181AD8340
	internal XmlElement HandleColumn(DataColumn col, XmlDocument dc, XmlElement schema, bool fWriteOrdinal) { }

	// RVA: 0x1AE02C0 Offset: 0x1ADE8C0 VA: 0x181AE02C0
	internal static string TranslateAcceptRejectRule(AcceptRejectRule rule) { }

	// RVA: 0x1AE0310 Offset: 0x1ADE910 VA: 0x181AE0310
	internal static string TranslateRule(Rule rule) { }

	// RVA: 0x1AD59F0 Offset: 0x1AD3FF0 VA: 0x181AD59F0
	internal void AppendChildWithoutRef(XmlElement node, string Namespace, XmlElement el, string refString) { }

	// RVA: 0x1AD7360 Offset: 0x1AD5960 VA: 0x181AD7360
	internal XmlElement FindTypeNode(XmlElement node, string strType) { }

	// RVA: 0x1AD92E0 Offset: 0x1AD78E0 VA: 0x181AD92E0
	internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema) { }

	// RVA: 0x1ADBB70 Offset: 0x1ADA170 VA: 0x181ADBB70
	private bool HasMixedColumns(DataTable table) { }

	// RVA: 0x1AD5DC0 Offset: 0x1AD43C0 VA: 0x181AD5DC0
	internal static bool AutoGenerated(DataColumn col) { }

	// RVA: 0x1AD61D0 Offset: 0x1AD47D0 VA: 0x181AD61D0
	internal static bool AutoGenerated(DataRelation rel) { }

	// RVA: 0x1AD5AA0 Offset: 0x1AD40A0 VA: 0x181AD5AA0
	internal static bool AutoGenerated(UniqueConstraint unique) { }

	// RVA: 0x1AD61C0 Offset: 0x1AD47C0 VA: 0x181AD61C0
	private bool AutoGenerated(ForeignKeyConstraint fk) { }

	// RVA: 0x1AD5B80 Offset: 0x1AD4180 VA: 0x181AD5B80
	internal static bool AutoGenerated(ForeignKeyConstraint fk, bool checkRelation) { }

	// RVA: 0x1ADBF90 Offset: 0x1ADA590 VA: 0x181ADBF90
	private bool IsAutoGenerated(object o) { }

	// RVA: 0x1AD9300 Offset: 0x1AD7900 VA: 0x181AD9300
	internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema, bool genNested) { }

	// RVA: 0x1ADEF70 Offset: 0x1ADD570 VA: 0x181ADEF70
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

	// RVA: 0x1AD0270 Offset: 0x1ACE870 VA: 0x181AD0270
	internal void .ctor(DataSet ds) { }

	// RVA: 0x1AD04F0 Offset: 0x1ACEAF0 VA: 0x181AD04F0
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0x1ACDA60 Offset: 0x1ACC060 VA: 0x181ACDA60
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0x1ACD7A0 Offset: 0x1ACBDA0 VA: 0x181ACD7A0
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0x1ACE040 Offset: 0x1ACC640 VA: 0x181ACE040
	internal static bool RowHasErrors(DataRow row) { }

	// RVA: 0x1ACE120 Offset: 0x1ACC720 VA: 0x181ACE120
	internal void SaveDiffgramData(XmlWriter xw, Hashtable rowsOrder) { }

	// RVA: 0x1ACE6B0 Offset: 0x1ACCCB0 VA: 0x181ACE6B0
	internal void Save(XmlWriter xw, bool writeSchema) { }

	// RVA: 0x1ACDD20 Offset: 0x1ACC320 VA: 0x181ACDD20
	private ArrayList GetNestedChildRelations(DataRow row) { }

	// RVA: 0x1ACEF30 Offset: 0x1ACD530 VA: 0x181ACEF30
	internal void XmlDataRowWriter(DataRow row, string encodedTableName) { }

	// RVA: 0x1ACDF90 Offset: 0x1ACC590 VA: 0x181ACDF90
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

	// RVA: 0xCCC7E0 Offset: 0xCCADE0 VA: 0x180CCC7E0
	public void .ctor() { }

	// RVA: 0xCCBEC0 Offset: 0xCCA4C0 VA: 0x180CCBEC0
	public XmlReader CreateReader() { }

	// RVA: 0xCCC140 Offset: 0xCCA740 VA: 0x180CCC140
	internal static XmlReader CreateSqlXmlReader(Stream stream, bool closeInput = False, bool throwTargetInvocationExceptions = False) { }

	// RVA: 0xCCC070 Offset: 0xCCA670 VA: 0x180CCC070
	private static Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> CreateSqlReaderDelegate() { }

	// RVA: 0xCCC810 Offset: 0xCCAE10 VA: 0x180CCC810
	private static MethodInfo get_CreateSqlReaderMethodInfo() { }

	// RVA: 0xCCAA30 Offset: 0xCC9030 VA: 0x180CCAA30 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0xCCC330 Offset: 0xCCA930 VA: 0x180CCC330
	private void SetNull() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xCCC360 Offset: 0xCCA960 VA: 0x180CCC360 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0xCCC520 Offset: 0xCCAB20 VA: 0x180CCC520 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xCCC2D0 Offset: 0xCCA8D0 VA: 0x180CCC2D0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCCC630 Offset: 0xCCAC30 VA: 0x180CCC630
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

	// RVA: 0xCCBBC0 Offset: 0xCCA1C0 VA: 0x180CCBBC0
	internal void .ctor(Stream stream) { }

	// RVA: 0xCCBC40 Offset: 0xCCA240 VA: 0x180CCBC40 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0xCCBC90 Offset: 0xCCA290 VA: 0x180CCBC90 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0xCCBCE0 Offset: 0xCCA2E0 VA: 0x180CCBCE0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0xCCBD30 Offset: 0xCCA330 VA: 0x180CCBD30 Slot: 10
	public override long get_Length() { }

	// RVA: 0xCCBDA0 Offset: 0xCCA3A0 VA: 0x180CCBDA0 Slot: 11
	public override long get_Position() { }

	// RVA: 0xCCBE00 Offset: 0xCCA400 VA: 0x180CCBE00 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0xCCB410 Offset: 0xCC9A10 VA: 0x180CCB410 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xCCB230 Offset: 0xCC9830 VA: 0x180CCB230 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0xCCB9F0 Offset: 0xCC9FF0 VA: 0x180CCB9F0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0xCCB100 Offset: 0xCC9700 VA: 0x180CCB100 Slot: 28
	public override int ReadByte() { }

	// RVA: 0xCCB910 Offset: 0xCC9F10 VA: 0x180CCB910 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0xCCB620 Offset: 0xCC9C20 VA: 0x180CCB620 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0xCCB060 Offset: 0xCC9660 VA: 0x180CCB060 Slot: 18
	public override void Flush() { }

	// RVA: 0xCCAFF0 Offset: 0xCC95F0 VA: 0x180CCAFF0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0xCCB750 Offset: 0xCC9D50 VA: 0x180CCB750
	private void ThrowIfStreamCannotSeek(string method) { }

	// RVA: 0xCCB6B0 Offset: 0xCC9CB0 VA: 0x180CCB6B0
	private void ThrowIfStreamCannotRead(string method) { }

	// RVA: 0xCCB7F0 Offset: 0xCC9DF0 VA: 0x180CCB7F0
	private void ThrowIfStreamCannotWrite(string method) { }

	// RVA: 0xCCB890 Offset: 0xCC9E90 VA: 0x180CCB890
	private void ThrowIfStreamClosed(string method) { }

	// RVA: 0xCCB080 Offset: 0xCC9680 VA: 0x180CCB080
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
	private static Action<string> deviceLoaded; // 0x1365D

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2322920 Offset: 0x2320F20 VA: 0x182322920
	private static void InvokeDeviceLoaded(string loadedDeviceName) { }

	// RVA: 0x23229D0 Offset: 0x2320FD0 VA: 0x1823229D0
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

	// RVA: 0x221EB00 Offset: 0x221D100 VA: 0x18221EB00
	internal void .ctor(XNamespace ns, string localName) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_LocalName() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public XNamespace get_Namespace() { }

	// RVA: 0xB28DF0 Offset: 0xB273F0 VA: 0x180B28DF0
	public string get_NamespaceName() { }

	// RVA: 0x221EA80 Offset: 0x221D080 VA: 0x18221EA80 Slot: 3
	public override string ToString() { }

	// RVA: 0x221E680 Offset: 0x221CC80 VA: 0x18221E680
	public static XName Get(string expandedName) { }

	// RVA: 0x221E8B0 Offset: 0x221CEB0 VA: 0x18221E8B0
	public static XName Get(string localName, string namespaceName) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x221EC10 Offset: 0x221D210 VA: 0x18221EC10
	public static XName op_Implicit(string expandedName) { }

	// RVA: 0xAE5CA0 Offset: 0xAE42A0 VA: 0x180AE5CA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xAE5CA0 Offset: 0xAE42A0 VA: 0x180AE5CA0
	public static bool op_Equality(XName left, XName right) { }

	// RVA: 0xAE5CA0 Offset: 0xAE42A0 VA: 0x180AE5CA0 Slot: 4
	private bool System.IEquatable<System.Xml.Linq.XName>.Equals(XName other) { }

	// RVA: 0x221E9B0 Offset: 0x221CFB0 VA: 0x18221E9B0 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x221EBE0 Offset: 0x221D1E0 VA: 0x18221EBE0
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

	// RVA: 0x221F360 Offset: 0x221D960 VA: 0x18221F360
	internal void .ctor(string namespaceName) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_NamespaceName() { }

	// RVA: 0x221EF10 Offset: 0x221D510 VA: 0x18221EF10
	public XName GetName(string localName) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x221F440 Offset: 0x221DA40 VA: 0x18221F440
	public static XNamespace get_None() { }

	// RVA: 0x221F490 Offset: 0x221DA90 VA: 0x18221F490
	public static XNamespace get_Xml() { }

	// RVA: 0x221F4E0 Offset: 0x221DAE0 VA: 0x18221F4E0
	public static XNamespace get_Xmlns() { }

	// RVA: 0x221EFA0 Offset: 0x221D5A0 VA: 0x18221EFA0
	public static XNamespace Get(string namespaceName) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x221F530 Offset: 0x221DB30 VA: 0x18221F530
	public static XNamespace op_Implicit(string namespaceName) { }

	// RVA: 0xAE5CA0 Offset: 0xAE42A0 VA: 0x180AE5CA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xAE5CA0 Offset: 0xAE42A0 VA: 0x180AE5CA0
	public static bool op_Equality(XNamespace left, XNamespace right) { }

	// RVA: 0x12A4450 Offset: 0x12A2A50 VA: 0x1812A4450
	public static bool op_Inequality(XNamespace left, XNamespace right) { }

	// RVA: 0x221ED90 Offset: 0x221D390 VA: 0x18221ED90
	internal XName GetName(string localName, int index, int count) { }

	// RVA: 0x221F010 Offset: 0x221D610 VA: 0x18221F010
	internal static XNamespace Get(string namespaceName, int index, int count) { }

	// RVA: 0x14B8020 Offset: 0x14B6620 VA: 0x1814B8020
	private static string ExtractLocalName(XName n) { }

	// RVA: 0x221ED10 Offset: 0x221D310 VA: 0x18221ED10
	private static string ExtractNamespace(WeakReference r) { }

	// RVA: 0x221EC20 Offset: 0x221D220 VA: 0x18221EC20
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

	// RVA: 0x2220570 Offset: 0x221EB70 VA: 0x182220570
	public string get_BaseUri() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x2220630 Offset: 0x221EC30 VA: 0x182220630
	public XElement get_Parent() { }

	// RVA: 0x221FB90 Offset: 0x221E190 VA: 0x18221FB90
	public void AddAnnotation(object annotation) { }

	// RVA: 0x221FE60 Offset: 0x221E460 VA: 0x18221FE60
	public object Annotation(Type type) { }

	// RVA: -1 Offset: -1
	public T Annotation<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0AA0 Offset: 0xBDF0A0 VA: 0x180BE0AA0
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
	|-RVA: 0x4B4920 Offset: 0x4B2F20 VA: 0x1804B4920
	|-XObject.Annotations<object>
	|-XObject.Annotations<XObjectChangeAnnotation>
	*/

	// RVA: 0x2220490 Offset: 0x221EA90 VA: 0x182220490 Slot: 4
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x22204D0 Offset: 0x221EAD0 VA: 0x1822204D0 Slot: 5
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x2220520 Offset: 0x221EB20 VA: 0x182220520 Slot: 6
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x22205F0 Offset: 0x221EBF0 VA: 0x1822205F0
	internal bool get_HasBaseUri() { }

	// RVA: 0x22201D0 Offset: 0x221E7D0 VA: 0x1822201D0
	internal bool NotifyChanged(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x2220280 Offset: 0x221E880 VA: 0x182220280
	internal bool NotifyChanging(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x2220330 Offset: 0x221E930 VA: 0x182220330
	internal void SetBaseUri(string baseUri) { }

	// RVA: 0x22203B0 Offset: 0x221E9B0 VA: 0x1822203B0
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x2220430 Offset: 0x221EA30 VA: 0x182220430
	internal bool SkipNotify() { }

	// RVA: 0x221FFC0 Offset: 0x221E5C0 VA: 0x18221FFC0
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
	|-RVA: 0x144BB00 Offset: 0x144A100 VA: 0x18144BB00
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
	|-RVA: 0x1A5FFA0 Offset: 0x1A5E5A0 VA: 0x181A5FFA0
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
	|-RVA: 0x1A602B0 Offset: 0x1A5E8B0 VA: 0x181A602B0
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
	|-RVA: 0x1A601F0 Offset: 0x1A5E7F0 VA: 0x181A601F0
	|-XObject.<Annotations>d__16<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1761100 Offset: 0x175F700 VA: 0x181761100
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

	// RVA: 0x221FB30 Offset: 0x221E130 VA: 0x18221FB30
	public void .ctor(XObjectChange objectChange) { }

	// RVA: 0x221F930 Offset: 0x221DF30 VA: 0x18221F930
	private static void .cctor() { }

}

public abstract class XNode : XObject // TypeDefIndex: 5830
{	// Fields
	internal XNode next; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x221F870 Offset: 0x221DE70 VA: 0x18221F870
	public void Remove() { }

	// RVA: 0x221F900 Offset: 0x221DF00 VA: 0x18221F900 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void WriteTo(XmlWriter writer);

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	internal virtual void AppendText(StringBuilder sb) { }

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract XNode CloneNode();

	// RVA: 0x221F580 Offset: 0x221DB80 VA: 0x18221F580
	private string GetXmlString(SaveOptions o) { }

}

public class XText : XNode // TypeDefIndex: 5831
{	// Fields
	internal string text; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x2217990 Offset: 0x2215F90 VA: 0x182217990
	public void .ctor(string value) { }

	// RVA: 0x2217900 Offset: 0x2215F00 VA: 0x182217900
	public void .ctor(XText other) { }

	// RVA: 0xAC2060 Offset: 0xAC0660 VA: 0x180AC2060 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public string get_Value() { }

	// RVA: 0x2220CE0 Offset: 0x221F2E0 VA: 0x182220CE0
	public void set_Value(string value) { }

	// RVA: 0x2220BF0 Offset: 0x221F1F0 VA: 0x182220BF0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x2220B10 Offset: 0x221F110 VA: 0x182220B10 Slot: 9
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x2220B40 Offset: 0x221F140 VA: 0x182220B40 Slot: 10
	internal override XNode CloneNode() { }

}

public class XCData : XText // TypeDefIndex: 5832
{	// Properties
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0x2217990 Offset: 0x2215F90 VA: 0x182217990
	public void .ctor(string value) { }

	// RVA: 0x2217900 Offset: 0x2215F00 VA: 0x182217900
	public void .ctor(XCData other) { }

	// RVA: 0xE38110 Offset: 0xE36710 VA: 0x180E38110 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x2217870 Offset: 0x2215E70 VA: 0x182217870 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x22177C0 Offset: 0x2215DC0 VA: 0x1822177C0 Slot: 10
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

	// RVA: 0x221B900 Offset: 0x2219F00 VA: 0x18221B900
	internal void .ctor(XContainer other) { }

	// RVA: 0x221BA40 Offset: 0x221A040 VA: 0x18221BA40
	public XNode get_LastNode() { }

	// RVA: 0x2218B50 Offset: 0x2217150 VA: 0x182218B50
	public void Add(object content) { }

	[IteratorStateMachineAttribute] // RVA: 0xE1930 Offset: 0xE0D30 VA: 0x1800E1930
	// RVA: 0x22198E0 Offset: 0x2217EE0 VA: 0x1822198E0
	public IEnumerable<XNode> Nodes() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 11
	internal virtual void AddAttribute(XAttribute a) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	internal virtual void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x2217C80 Offset: 0x2216280 VA: 0x182217C80
	internal void AddContentSkipNotify(object content) { }

	// RVA: 0x2218500 Offset: 0x2216B00 VA: 0x182218500
	internal void AddNode(XNode n) { }

	// RVA: 0x2218460 Offset: 0x2216A60 VA: 0x182218460
	internal void AddNodeSkipNotify(XNode n) { }

	// RVA: 0x2218770 Offset: 0x2216D70 VA: 0x182218770
	internal void AddString(string s) { }

	// RVA: 0x22185A0 Offset: 0x2216BA0 VA: 0x1822185A0
	internal void AddStringSkipNotify(string s) { }

	// RVA: 0x22190A0 Offset: 0x22176A0 VA: 0x1822190A0
	internal void AppendNode(XNode n) { }

	// RVA: 0x2218FA0 Offset: 0x22175A0 VA: 0x182218FA0
	internal void AppendNodeSkipNotify(XNode n) { }

	// RVA: 0x22191D0 Offset: 0x22177D0 VA: 0x1822191D0 Slot: 9
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x22192D0 Offset: 0x22178D0 VA: 0x1822192D0
	internal void ConvertTextToNode() { }

	// RVA: 0x22193C0 Offset: 0x22179C0 VA: 0x1822193C0
	internal static string GetDateTimeString(DateTime value) { }

	// RVA: 0x2219420 Offset: 0x2217A20 VA: 0x182219420
	internal static string GetStringValue(object value) { }

	// RVA: 0x221A900 Offset: 0x2218F00 VA: 0x18221A900
	internal void ReadContentFrom(XmlReader r) { }

	// RVA: 0x2219950 Offset: 0x2217F50 VA: 0x182219950
	internal void ReadContentFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x221B550 Offset: 0x2219B50 VA: 0x18221B550
	internal void RemoveNode(XNode n) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 13
	internal virtual void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 14
	internal virtual void ValidateString(string s) { }

	// RVA: 0x221B760 Offset: 0x2219D60 VA: 0x18221B760
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
	// RVA: 0xD87750 Offset: 0xD85D50 VA: 0x180D87750
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2216A30 Offset: 0x2215030 VA: 0x182216A30 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2216CF0 Offset: 0x22152F0 VA: 0x182216CF0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2216C50 Offset: 0x2215250 VA: 0x182216C50 Slot: 4
	private IEnumerator<XNode> System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2216C50 Offset: 0x2215250 VA: 0x182216C50 Slot: 5
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

	// RVA: 0x221E480 Offset: 0x221CA80 VA: 0x18221E480
	public void .ctor(XName name) { }

	// RVA: 0x221E300 Offset: 0x221C900 VA: 0x18221E300
	public void .ctor(XElement other) { }

	// RVA: 0x221E510 Offset: 0x221CB10 VA: 0x18221E510
	public void .ctor(XStreamingElement other) { }

	// RVA: 0x221E5B0 Offset: 0x221CBB0 VA: 0x18221E5B0
	public bool get_IsEmpty() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public XName get_Name() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x221E5C0 Offset: 0x221CBC0 VA: 0x18221E5C0
	public string get_Value() { }

	// RVA: 0x221D0E0 Offset: 0x221B6E0 VA: 0x18221D0E0
	public XAttribute Attribute(XName name) { }

	// RVA: 0x221D120 Offset: 0x221B720 VA: 0x18221D120
	public IEnumerable<XAttribute> Attributes() { }

	// RVA: 0x221D510 Offset: 0x221BB10 VA: 0x18221D510
	public string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x221E230 Offset: 0x221C830 VA: 0x18221E230 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 15
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x221DE60 Offset: 0x221C460 VA: 0x18221DE60 Slot: 16
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xE59420 Offset: 0xE57A20 VA: 0x180E59420 Slot: 17
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x221CC70 Offset: 0x221B270 VA: 0x18221CC70 Slot: 11
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x221CAF0 Offset: 0x221B0F0 VA: 0x18221CAF0 Slot: 12
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x221CF60 Offset: 0x221B560 VA: 0x18221CF60
	internal void AppendAttribute(XAttribute a) { }

	// RVA: 0x221CEE0 Offset: 0x221B4E0 VA: 0x18221CEE0
	internal void AppendAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x221D1B0 Offset: 0x221B7B0 VA: 0x18221D1B0 Slot: 10
	internal override XNode CloneNode() { }

	[IteratorStateMachineAttribute] // RVA: 0xE5EE0 Offset: 0xE52E0 VA: 0x1800E5EE0
	// RVA: 0x221D360 Offset: 0x221B960 VA: 0x18221D360
	private IEnumerable<XAttribute> GetAttributes(XName name) { }

	// RVA: 0x221D3F0 Offset: 0x221B9F0 VA: 0x18221D3F0
	private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope) { }

	// RVA: 0x221D760 Offset: 0x221BD60 VA: 0x18221D760
	private void ReadElementFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x221DDE0 Offset: 0x221C3E0 VA: 0x18221DDE0
	internal void SetEndElementLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x221E050 Offset: 0x221C650 VA: 0x18221E050 Slot: 13
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
	// RVA: 0xD87750 Offset: 0xD85D50 VA: 0x180D87750
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2216850 Offset: 0x2214E50 VA: 0x182216850 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22169E0 Offset: 0x2214FE0 VA: 0x1822169E0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2216930 Offset: 0x2214F30 VA: 0x182216930 Slot: 4
	private IEnumerator<XAttribute> System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2216930 Offset: 0x2214F30 VA: 0x182216930 Slot: 5
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

	// RVA: 0x221C9D0 Offset: 0x221AFD0 VA: 0x18221C9D0
	public void .ctor(XDocument other) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public XDeclaration get_Declaration() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	public void set_Declaration(XDeclaration value) { }

	// RVA: 0xE668B0 Offset: 0xE64EB0 VA: 0x180E668B0 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x221CAB0 Offset: 0x221B0B0 VA: 0x18221CAB0
	public XElement get_Root() { }

	// RVA: 0x221C8B0 Offset: 0x221AEB0 VA: 0x18221C8B0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x221C230 Offset: 0x221A830 VA: 0x18221C230 Slot: 11
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x221C1C0 Offset: 0x221A7C0 VA: 0x18221C1C0 Slot: 12
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x221C2A0 Offset: 0x221A8A0 VA: 0x18221C2A0 Slot: 10
	internal override XNode CloneNode() { }

	// RVA: -1 Offset: -1
	private T GetFirstNode<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE09B0 Offset: 0xBDEFB0 VA: 0x180BE09B0
	|-XDocument.GetFirstNode<object>
	|-XDocument.GetFirstNode<XElement>
	*/

	// RVA: 0x221C3B0 Offset: 0x221A9B0 VA: 0x18221C3B0
	internal static bool IsWhitespace(string s) { }

	// RVA: 0x221C560 Offset: 0x221AB60 VA: 0x18221C560 Slot: 13
	internal override void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x221C430 Offset: 0x221AA30 VA: 0x18221C430
	private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter) { }

	// RVA: 0x221C7F0 Offset: 0x221ADF0 VA: 0x18221C7F0 Slot: 14
	internal override void ValidateString(string s) { }

}

public class XComment : XNode // TypeDefIndex: 5844
{	// Fields
	internal string value; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x2217BF0 Offset: 0x22161F0 VA: 0x182217BF0
	public void .ctor(string value) { }

	// RVA: 0x2217B60 Offset: 0x2216160 VA: 0x182217B60
	public void .ctor(XComment other) { }

	// RVA: 0x8C0E00 Offset: 0x8BF400 VA: 0x1808C0E00 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public string get_Value() { }

	// RVA: 0x2217AD0 Offset: 0x22160D0 VA: 0x182217AD0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x2217A20 Offset: 0x2216020 VA: 0x182217A20 Slot: 10
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

	// RVA: 0x22208F0 Offset: 0x221EEF0 VA: 0x1822208F0
	public void .ctor(string target, string data) { }

	// RVA: 0x2220A70 Offset: 0x221F070 VA: 0x182220A70
	public void .ctor(XProcessingInstruction other) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_Data() { }

	// RVA: 0xB9FC50 Offset: 0xB9E250 VA: 0x180B9FC50 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public string get_Target() { }

	// RVA: 0x2220860 Offset: 0x221EE60 VA: 0x182220860 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x22206B0 Offset: 0x221ECB0 VA: 0x1822206B0 Slot: 10
	internal override XNode CloneNode() { }

	// RVA: 0x2220770 Offset: 0x221ED70 VA: 0x182220770
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

	// RVA: 0x1473FD0 Offset: 0x14725D0 VA: 0x181473FD0
	public void .ctor(string version, string encoding, string standalone) { }

	// RVA: 0x221BD20 Offset: 0x221A320 VA: 0x18221BD20
	public void .ctor(XDeclaration other) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Encoding() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Standalone() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Version() { }

	// RVA: 0x221BBD0 Offset: 0x221A1D0 VA: 0x18221BBD0 Slot: 3
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

	// RVA: 0x221C100 Offset: 0x221A700 VA: 0x18221C100
	public void .ctor(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x221BF60 Offset: 0x221A560 VA: 0x18221BF60
	public void .ctor(XDocumentType other) { }

	// RVA: 0x221C030 Offset: 0x221A630 VA: 0x18221C030
	internal void .ctor(string name, string publicId, string systemId, string internalSubset, IDtdInfo dtdInfo) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public string get_InternalSubset() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public string get_Name() { }

	// RVA: 0x4A6090 Offset: 0x4A4690 VA: 0x1804A6090 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_PublicId() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_SystemId() { }

	// RVA: 0x221BEC0 Offset: 0x221A4C0 VA: 0x18221BEC0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x221BDD0 Offset: 0x221A3D0 VA: 0x18221BDD0 Slot: 10
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

	// RVA: 0x22175A0 Offset: 0x2215BA0 VA: 0x1822175A0
	public void .ctor(XName name, object value) { }

	// RVA: 0x22176A0 Offset: 0x2215CA0 VA: 0x1822176A0
	public void .ctor(XAttribute other) { }

	// RVA: 0x2217740 Offset: 0x2215D40 VA: 0x182217740
	public bool get_IsNamespaceDeclaration() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public XName get_Name() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_Value() { }

	// RVA: 0x2216E90 Offset: 0x2215490 VA: 0x182216E90 Slot: 3
	public override string ToString() { }

	// RVA: 0x2216D40 Offset: 0x2215340 VA: 0x182216D40
	internal string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x2217230 Offset: 0x2215830 VA: 0x182217230
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

	// RVA: 0xFA0E70 Offset: 0xF9F470 VA: 0x180FA0E70
	public void .ctor(XmlDocument document) { }

	// RVA: 0xFA11A0 Offset: 0xF9F7A0 VA: 0x180FA11A0 Slot: 15
	public IXmlNode CreateComment(string data) { }

	// RVA: 0xFA1490 Offset: 0xF9FA90 VA: 0x180FA1490 Slot: 16
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0xFA1110 Offset: 0xF9F710 VA: 0x180FA1110 Slot: 17
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0xFA1520 Offset: 0xF9FB20 VA: 0x180FA1520 Slot: 18
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0xFA1400 Offset: 0xF9FA00 VA: 0x180FA1400 Slot: 19
	public IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0xFA15B0 Offset: 0xF9FBB0 VA: 0x180FA15B0 Slot: 20
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0xFA1670 Offset: 0xF9FC70 VA: 0x180FA1670 Slot: 21
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0xFA1360 Offset: 0xF9F960 VA: 0x180FA1360 Slot: 22
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0xFA12D0 Offset: 0xF9F8D0 VA: 0x180FA12D0 Slot: 23
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0xFA1230 Offset: 0xF9F830 VA: 0x180FA1230 Slot: 24
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0xFA0F90 Offset: 0xF9F590 VA: 0x180FA0F90 Slot: 25
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0xFA1050 Offset: 0xF9F650 VA: 0x180FA1050 Slot: 26
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	// RVA: 0xFA1740 Offset: 0xF9FD40 VA: 0x180FA1740 Slot: 27
	public IXmlElement get_DocumentElement() { }

}

internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement, IXmlNode // TypeDefIndex: 6112
{	// Fields
	private readonly XmlElement _element; // 0x28

	// Properties
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0xFA0E70 Offset: 0xF9F470 VA: 0x180FA0E70
	public void .ctor(XmlElement element) { }

	// RVA: 0xFA1820 Offset: 0xF9FE20 VA: 0x180FA1820 Slot: 15
	public void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0xFA17F0 Offset: 0xF9FDF0 VA: 0x180FA17F0 Slot: 16
	public string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0xFA1920 Offset: 0xF9FF20 VA: 0x180FA1920 Slot: 17
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

	// RVA: 0xFA0E70 Offset: 0xF9F470 VA: 0x180FA0E70
	public void .ctor(XmlDeclaration declaration) { }

	// RVA: 0xFA0EF0 Offset: 0xF9F4F0 VA: 0x180FA0EF0 Slot: 15
	public string get_Version() { }

	// RVA: 0xFA0EB0 Offset: 0xF9F4B0 VA: 0x180FA0EB0 Slot: 16
	public string get_Encoding() { }

	// RVA: 0xFA0ED0 Offset: 0xF9F4D0 VA: 0x180FA0ED0 Slot: 17
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

	// RVA: 0xFA0E70 Offset: 0xF9F470 VA: 0x180FA0E70
	public void .ctor(XmlDocumentType documentType) { }

	// RVA: 0xFA0F60 Offset: 0xF9F560 VA: 0x180FA0F60 Slot: 15
	public string get_Name() { }

	// RVA: 0xFA0ED0 Offset: 0xF9F4D0 VA: 0x180FA0ED0 Slot: 16
	public string get_System() { }

	// RVA: 0xFA0EB0 Offset: 0xF9F4B0 VA: 0x180FA0EB0 Slot: 17
	public string get_Public() { }

	// RVA: 0xFA0F10 Offset: 0xF9F510 VA: 0x180FA0F10 Slot: 18
	public string get_InternalSubset() { }

	// RVA: 0xFA0F30 Offset: 0xF9F530 VA: 0x180FA0F30 Slot: 13
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

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(XmlNode node) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 12
	public object get_WrappedNode() { }

	// RVA: 0xBC8E10 Offset: 0xBC7410 VA: 0x180BC8E10 Slot: 4
	public XmlNodeType get_NodeType() { }

	// RVA: 0xBC8D80 Offset: 0xBC7380 VA: 0x180BC8D80 Slot: 13
	public virtual string get_LocalName() { }

	// RVA: 0xFA7BD0 Offset: 0xFA61D0 VA: 0x180FA7BD0 Slot: 6
	public List<IXmlNode> get_ChildNodes() { }

	// RVA: 0xFA7540 Offset: 0xFA5B40 VA: 0x180FA7540
	internal static IXmlNode WrapNode(XmlNode node) { }

	// RVA: 0xFA7730 Offset: 0xFA5D30 VA: 0x180FA7730 Slot: 7
	public List<IXmlNode> get_Attributes() { }

	// RVA: 0xFA8040 Offset: 0xFA6640 VA: 0x180FA8040 Slot: 8
	public IXmlNode get_ParentNode() { }

	// RVA: 0xBC8DB0 Offset: 0xBC73B0 VA: 0x180BC8DB0 Slot: 9
	public string get_Value() { }

	// RVA: 0xFA8180 Offset: 0xFA6780 VA: 0x180FA8180 Slot: 14
	public void set_Value(string value) { }

	// RVA: 0xFA7470 Offset: 0xFA5A70 VA: 0x180FA7470 Slot: 10
	public IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0xB9F100 Offset: 0xB9D700 VA: 0x180B9F100 Slot: 11
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
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_Declaration(XDeclaration value) { }

	// RVA: 0xF9F5A0 Offset: 0xF9DBA0 VA: 0x180F9F5A0
	public void .ctor(XDeclaration declaration) { }

	// RVA: 0xE61E20 Offset: 0xE60420 VA: 0x180E61E20 Slot: 13
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xE57390 Offset: 0xE55990 VA: 0x180E57390 Slot: 21
	public string get_Version() { }

	// RVA: 0x855290 Offset: 0x853890 VA: 0x180855290 Slot: 22
	public string get_Encoding() { }

	// RVA: 0xE572D0 Offset: 0xE558D0 VA: 0x180E572D0 Slot: 23
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

	// RVA: 0xF9F620 Offset: 0xF9DC20 VA: 0x180F9F620
	public void .ctor(XDocumentType documentType) { }

	// RVA: 0xF9F6F0 Offset: 0xF9DCF0 VA: 0x180F9F6F0 Slot: 21
	public string get_Name() { }

	// RVA: 0xE572F0 Offset: 0xE558F0 VA: 0x180E572F0 Slot: 22
	public string get_System() { }

	// RVA: 0x855270 Offset: 0x853870 VA: 0x180855270 Slot: 23
	public string get_Public() { }

	// RVA: 0xF9F6A0 Offset: 0xF9DCA0 VA: 0x180F9F6A0 Slot: 24
	public string get_InternalSubset() { }

	// RVA: 0xF9F6C0 Offset: 0xF9DCC0 VA: 0x180F9F6C0 Slot: 14
	public override string get_LocalName() { }

}

internal class XDocumentWrapper : XContainerWrapper, IXmlDocument, IXmlNode // TypeDefIndex: 6123
{	// Properties
	private XDocument Document { get; }
	public override List<IXmlNode> ChildNodes { get; }
	public IXmlElement DocumentElement { get; }

	// Methods

	// RVA: 0xFA01E0 Offset: 0xF9E7E0 VA: 0x180FA01E0
	private XDocument get_Document() { }

	// RVA: 0xF9F240 Offset: 0xF9D840 VA: 0x180F9F240
	public void .ctor(XDocument document) { }

	// RVA: 0xFA0050 Offset: 0xF9E650 VA: 0x180FA0050 Slot: 15
	public override List<IXmlNode> get_ChildNodes() { }

	// RVA: 0xF9FA90 Offset: 0xF9E090 VA: 0x180F9FA90 Slot: 21
	public IXmlNode CreateComment(string text) { }

	// RVA: 0xF9FE10 Offset: 0xF9E410 VA: 0x180F9FE10 Slot: 22
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0xF9FA10 Offset: 0xF9E010 VA: 0x180F9FA10 Slot: 23
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0xF9FE90 Offset: 0xF9E490 VA: 0x180F9FE90 Slot: 24
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0xF9FD90 Offset: 0xF9E390 VA: 0x180F9FD90 Slot: 25
	public IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0xF9FF10 Offset: 0xF9E510 VA: 0x180F9FF10 Slot: 26
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0xF9FFB0 Offset: 0xF9E5B0 VA: 0x180F9FFB0 Slot: 27
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0xF9FCC0 Offset: 0xF9E2C0 VA: 0x180F9FCC0 Slot: 28
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0xF9FBF0 Offset: 0xF9E1F0 VA: 0x180F9FBF0 Slot: 29
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0xF9FB10 Offset: 0xF9E110 VA: 0x180F9FB10 Slot: 30
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0xF9F930 Offset: 0xF9DF30 VA: 0x180F9F930 Slot: 31
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0xF9F840 Offset: 0xF9DE40 VA: 0x180F9F840 Slot: 32
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	// RVA: 0xFA0140 Offset: 0xF9E740 VA: 0x180FA0140 Slot: 33
	public IXmlElement get_DocumentElement() { }

	// RVA: 0xF9F710 Offset: 0xF9DD10 VA: 0x180F9F710 Slot: 19
	public override IXmlNode AppendChild(IXmlNode newChild) { }

}

internal class XTextWrapper : XObjectWrapper // TypeDefIndex: 6124
{	// Properties
	private XText Text { get; }
	public override string Value { get; }
	public override IXmlNode ParentNode { get; }

	// Methods

	// RVA: 0xFA0DD0 Offset: 0xF9F3D0 VA: 0x180FA0DD0
	private XText get_Text() { }

	// RVA: 0xFA0D00 Offset: 0xF9F300 VA: 0x180FA0D00
	public void .ctor(XText text) { }

	// RVA: 0xFA0E50 Offset: 0xF9F450 VA: 0x180FA0E50 Slot: 18
	public override string get_Value() { }

	// RVA: 0xFA0D70 Offset: 0xF9F370 VA: 0x180FA0D70 Slot: 17
	public override IXmlNode get_ParentNode() { }

}

internal class XCommentWrapper : XObjectWrapper // TypeDefIndex: 6125
{	// Properties
	private XComment Text { get; }
	public override string Value { get; }
	public override IXmlNode ParentNode { get; }

	// Methods

	// RVA: 0xF9EA50 Offset: 0xF9D050 VA: 0x180F9EA50
	private XComment get_Text() { }

	// RVA: 0xF9E980 Offset: 0xF9CF80 VA: 0x180F9E980
	public void .ctor(XComment text) { }

	// RVA: 0xF9EAD0 Offset: 0xF9D0D0 VA: 0x180F9EAD0 Slot: 18
	public override string get_Value() { }

	// RVA: 0xF9E9F0 Offset: 0xF9CFF0 VA: 0x180F9E9F0 Slot: 17
	public override IXmlNode get_ParentNode() { }

}

internal class XProcessingInstructionWrapper : XObjectWrapper // TypeDefIndex: 6126
{	// Properties
	private XProcessingInstruction ProcessingInstruction { get; }
	public override string LocalName { get; }
	public override string Value { get; }

	// Methods

	// RVA: 0xFA0C60 Offset: 0xF9F260 VA: 0x180FA0C60
	private XProcessingInstruction get_ProcessingInstruction() { }

	// RVA: 0xFA0BD0 Offset: 0xF9F1D0 VA: 0x180FA0BD0
	public void .ctor(XProcessingInstruction processingInstruction) { }

	// RVA: 0xFA0C40 Offset: 0xF9F240 VA: 0x180FA0C40 Slot: 14
	public override string get_LocalName() { }

	// RVA: 0xFA0CE0 Offset: 0xF9F2E0 VA: 0x180FA0CE0 Slot: 18
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

	// RVA: 0xF9F4C0 Offset: 0xF9DAC0 VA: 0x180F9F4C0
	private XContainer get_Container() { }

	// RVA: 0xF9F240 Offset: 0xF9D840 VA: 0x180F9F240
	public void .ctor(XContainer container) { }

	// RVA: 0xF9F2B0 Offset: 0xF9D8B0 VA: 0x180F9F2B0 Slot: 15
	public override List<IXmlNode> get_ChildNodes() { }

	// RVA: 0xF9F540 Offset: 0xF9DB40 VA: 0x180F9F540 Slot: 17
	public override IXmlNode get_ParentNode() { }

	// RVA: 0xF9EB90 Offset: 0xF9D190 VA: 0x180F9EB90
	internal static IXmlNode WrapNode(XObject node) { }

	// RVA: 0xF9EAF0 Offset: 0xF9D0F0 VA: 0x180F9EAF0 Slot: 19
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

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(XObject xmlObject) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 12
	public object get_WrappedNode() { }

	// RVA: 0xBC8DB0 Offset: 0xBC73B0 VA: 0x180BC8DB0 Slot: 13
	public virtual XmlNodeType get_NodeType() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 14
	public virtual string get_LocalName() { }

	// RVA: 0xFA0B70 Offset: 0xF9F170 VA: 0x180FA0B70 Slot: 15
	public virtual List<IXmlNode> get_ChildNodes() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 16
	public virtual List<IXmlNode> get_Attributes() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 17
	public virtual IXmlNode get_ParentNode() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 18
	public virtual string get_Value() { }

	// RVA: 0xFA0AC0 Offset: 0xF9F0C0 VA: 0x180FA0AC0 Slot: 19
	public virtual IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 20
	public virtual string get_NamespaceUri() { }

	// RVA: 0xFA0B10 Offset: 0xF9F110 VA: 0x180FA0B10
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

	// RVA: 0xF9E820 Offset: 0xF9CE20 VA: 0x180F9E820
	private XAttribute get_Attribute() { }

	// RVA: 0xF9E7B0 Offset: 0xF9CDB0 VA: 0x180F9E7B0
	public void .ctor(XAttribute attribute) { }

	// RVA: 0xF9E960 Offset: 0xF9CF60 VA: 0x180F9E960 Slot: 18
	public override string get_Value() { }

	// RVA: 0xF9E8A0 Offset: 0xF9CEA0 VA: 0x180F9E8A0 Slot: 14
	public override string get_LocalName() { }

	// RVA: 0xF9E8D0 Offset: 0xF9CED0 VA: 0x180F9E8D0 Slot: 20
	public override string get_NamespaceUri() { }

	// RVA: 0xF9E900 Offset: 0xF9CF00 VA: 0x180F9E900 Slot: 17
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

	// RVA: 0xFA0980 Offset: 0xF9EF80 VA: 0x180FA0980
	private XElement get_Element() { }

	// RVA: 0xF9F240 Offset: 0xF9D840 VA: 0x180F9F240
	public void .ctor(XElement element) { }

	// RVA: 0xFA0350 Offset: 0xF9E950 VA: 0x180FA0350 Slot: 21
	public void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0xFA0420 Offset: 0xF9EA20 VA: 0x180FA0420 Slot: 16
	public override List<IXmlNode> get_Attributes() { }

	// RVA: 0xFA0260 Offset: 0xF9E860 VA: 0x180FA0260 Slot: 19
	public override IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0xFA0A90 Offset: 0xF9F090 VA: 0x180FA0A90 Slot: 18
	public override string get_Value() { }

	// RVA: 0xFA0A30 Offset: 0xF9F030 VA: 0x180FA0A30 Slot: 14
	public override string get_LocalName() { }

	// RVA: 0xFA0A60 Offset: 0xF9F060 VA: 0x180FA0A60 Slot: 20
	public override string get_NamespaceUri() { }

	// RVA: 0xFA0300 Offset: 0xF9E900 VA: 0x180FA0300 Slot: 22
	public string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0xFA0A00 Offset: 0xF9F000 VA: 0x180FA0A00 Slot: 23
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
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_DeserializeRootElementName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FAF0 Offset: 0x95E0F0 VA: 0x18095FAF0
	public bool get_WriteArrayAttribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFA7460 Offset: 0xFA5A60 VA: 0x180FA7460
	public bool get_OmitRootObject() { }

	// RVA: 0xFA7340 Offset: 0xFA5940 VA: 0x180FA7340 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xFA71D0 Offset: 0xFA57D0 VA: 0x180FA71D0
	private IXmlNode WrapXml(object value) { }

	// RVA: 0xFA49E0 Offset: 0xFA2FE0 VA: 0x180FA49E0
	private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xFA5E80 Offset: 0xFA4480 VA: 0x180FA5E80
	private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xFA4430 Offset: 0xFA2A30 VA: 0x180FA4430
	private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xFA46F0 Offset: 0xFA2CF0 VA: 0x180FA46F0
	private bool IsArray(IXmlNode node) { }

	// RVA: 0xFA6010 Offset: 0xFA4610 VA: 0x180FA6010
	private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0xFA6440 Offset: 0xFA4A40 VA: 0x180FA6440
	private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0xFA1C90 Offset: 0xFA0290 VA: 0x180FA1C90
	private static bool AllSameName(IXmlNode node) { }

	// RVA: 0xFA5990 Offset: 0xFA3F90 VA: 0x180FA5990 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xFA4120 Offset: 0xFA2720 VA: 0x180FA4120
	private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode) { }

	// RVA: 0xFA5700 Offset: 0xFA3D00 VA: 0x180FA5700
	private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager) { }

	// RVA: 0xFA2A30 Offset: 0xFA1030 VA: 0x180FA2A30
	private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, Dictionary<string, string> attributeNameValues) { }

	// RVA: 0xFA1940 Offset: 0xF9FF40 VA: 0x180FA1940
	private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string attributeName, XmlNamespaceManager manager, string attributePrefix) { }

	// RVA: 0xFA1F30 Offset: 0xFA0530 VA: 0x180FA1F30
	private string ConvertTokenToXmlValue(JsonReader reader) { }

	// RVA: 0xFA4E60 Offset: 0xFA3460 VA: 0x180FA4E60
	private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager) { }

	// RVA: 0xFA1AE0 Offset: 0xFA00E0 VA: 0x180FA1AE0
	private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document) { }

	// RVA: 0xFA5100 Offset: 0xFA3700 VA: 0x180FA5100
	private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager) { }

	// RVA: 0xFA2EB0 Offset: 0xFA14B0 VA: 0x180FA2EB0
	private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName) { }

	// RVA: 0xFA25C0 Offset: 0xFA0BC0 VA: 0x180FA25C0
	private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode) { }

	// RVA: 0xFA2920 Offset: 0xFA0F20 VA: 0x180FA2920
	private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager) { }

	// RVA: 0xFA31E0 Offset: 0xFA17E0 VA: 0x180FA31E0
	private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode) { }

	// RVA: 0xFA4900 Offset: 0xFA2F00 VA: 0x180FA4900
	private bool IsNamespaceAttribute(string attributeName, out string prefix) { }

	// RVA: 0xFA7060 Offset: 0xFA5660 VA: 0x180FA7060
	private bool ValueAttributes(List<IXmlNode> c) { }

	// RVA: 0xFA1E40 Offset: 0xFA0440 VA: 0x180FA1E40 Slot: 6
	public override bool CanConvert(Type valueType) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class XORSwitch : IOEntity // TypeDefIndex: 9806
{	// Fields
	private int input1Amount; // 0x288
	private int input2Amount; // 0x28C

	// Methods

	// RVA: 0x1A8BF90 Offset: 0x1A8A590 VA: 0x181A8BF90
	public void .ctor() { }

}

