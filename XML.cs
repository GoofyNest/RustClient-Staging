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

	// RVA: 0x1566FB0 Offset: 0x15655B0 VA: 0x181566FB0
	public void .ctor() { }

	// RVA: 0x1564DD0 Offset: 0x15633D0 VA: 0x181564DD0
	private Exception Error(string msg) { }

	// RVA: 0x1566EF0 Offset: 0x15654F0 VA: 0x181566EF0
	private Exception UnexpectedEndError() { }

	// RVA: 0x15651B0 Offset: 0x15637B0 VA: 0x1815651B0
	private bool IsNameChar(char c, bool start) { }

	// RVA: 0x1565350 Offset: 0x1563950 VA: 0x181565350
	private bool IsWhitespace(int c) { }

	// RVA: 0x1566EE0 Offset: 0x15654E0 VA: 0x181566EE0
	public void SkipWhitespaces() { }

	// RVA: 0x15650A0 Offset: 0x15636A0 VA: 0x1815650A0
	private void HandleWhitespaces() { }

	// RVA: 0x1566DF0 Offset: 0x15653F0 VA: 0x181566DF0
	public void SkipWhitespaces(bool expected) { }

	// RVA: 0x15655D0 Offset: 0x1563BD0 VA: 0x1815655D0
	private int Peek() { }

	// RVA: 0x1566D90 Offset: 0x1565390 VA: 0x181566D90
	private int Read() { }

	// RVA: 0x1564EB0 Offset: 0x15634B0 VA: 0x181564EB0
	public void Expect(int c) { }

	// RVA: 0x1566C30 Offset: 0x1565230 VA: 0x181566C30
	private string ReadUntil(char until, bool handleReferences) { }

	// RVA: 0x1566730 Offset: 0x1564D30 VA: 0x181566730
	public string ReadName() { }

	// RVA: 0x1565370 Offset: 0x1563970 VA: 0x181565370
	public void Parse(TextReader input, SmallXmlParser.IContentHandler handler) { }

	// RVA: 0x1564CD0 Offset: 0x15632D0 VA: 0x181564CD0
	private void Cleanup() { }

	// RVA: 0x1565D60 Offset: 0x1564360 VA: 0x181565D60
	public void ReadContent() { }

	// RVA: 0x1564FD0 Offset: 0x15635D0 VA: 0x181564FD0
	private void HandleBufferedContent() { }

	// RVA: 0x1565AE0 Offset: 0x15640E0 VA: 0x181565AE0
	private void ReadCharacters() { }

	// RVA: 0x1566A10 Offset: 0x1565010 VA: 0x181566A10
	private void ReadReference() { }

	// RVA: 0x1565930 Offset: 0x1563F30 VA: 0x181565930
	private int ReadCharacterReference() { }

	// RVA: 0x1565600 Offset: 0x1563C00 VA: 0x181565600
	private void ReadAttribute(SmallXmlParser.AttrListImpl a) { }

	// RVA: 0x15657B0 Offset: 0x1563DB0 VA: 0x1815657B0
	private void ReadCDATASection() { }

	// RVA: 0x1565C00 Offset: 0x1564200 VA: 0x181565C00
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

	// RVA: 0x155BD50 Offset: 0x155A350 VA: 0x18155BD50 Slot: 4
	public int get_Length() { }

	// RVA: 0x155BB10 Offset: 0x155A110 VA: 0x18155BB10 Slot: 5
	public string GetName(int i) { }

	// RVA: 0x155BB70 Offset: 0x155A170 VA: 0x18155BB70 Slot: 6
	public string GetValue(int i) { }

	// RVA: 0x155BBD0 Offset: 0x155A1D0 VA: 0x18155BBD0 Slot: 7
	public string GetValue(string name) { }

	// RVA: 0x155BD90 Offset: 0x155A390 VA: 0x18155BD90 Slot: 8
	public string[] get_Names() { }

	// RVA: 0x155BDE0 Offset: 0x155A3E0 VA: 0x18155BDE0 Slot: 9
	public string[] get_Values() { }

	// RVA: 0x155BAB0 Offset: 0x155A0B0 VA: 0x18155BAB0
	internal void Clear() { }

	// RVA: 0x155BA30 Offset: 0x155A030 VA: 0x18155BA30
	internal void Add(string name, string value) { }

	// RVA: 0x155BCB0 Offset: 0x155A2B0 VA: 0x18155BCB0
	public void .ctor() { }

}

internal class SmallXmlParserException : SystemException // TypeDefIndex: 28
{	// Fields
	private int line; // 0x88
	private int column; // 0x8C

	// Methods

	// RVA: 0x1564C10 Offset: 0x1563210 VA: 0x181564C10
	public void .ctor(string msg, int line, int column) { }

}

public sealed class XmlSyntaxException : SystemException // TypeDefIndex: 909
{	// Methods

	// RVA: 0x18BBF00 Offset: 0x18BA500 VA: 0x1818BBF00
	public void .ctor() { }

	// RVA: 0x18C3540 Offset: 0x18C1B40 VA: 0x1818C3540
	public void .ctor(int lineNumber) { }

	// RVA: 0x18C33C0 Offset: 0x18C19C0 VA: 0x1818C33C0
	public void .ctor(int lineNumber, string message) { }

	// RVA: 0x1486850 Offset: 0x1484E50 VA: 0x181486850
	public void .ctor(string message) { }

	// RVA: 0x18BBE70 Offset: 0x18BA470 VA: 0x1818BBE70
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x18AFE40 Offset: 0x18AE440 VA: 0x1818AFE40
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

	// RVA: 0x12F94D0 Offset: 0x12F7AD0 VA: 0x1812F94D0
	public static AstNode ParseXPathExpresion(string xpathExpresion) { }

	// RVA: 0x12F73B0 Offset: 0x12F59B0 VA: 0x1812F73B0
	private AstNode ParseExpresion(AstNode qyInput) { }

	// RVA: 0x12F8510 Offset: 0x12F6B10 VA: 0x1812F8510
	private AstNode ParseOrExpr(AstNode qyInput) { }

	// RVA: 0x12F7140 Offset: 0x12F5740 VA: 0x1812F7140
	private AstNode ParseAndExpr(AstNode qyInput) { }

	// RVA: 0x12F7290 Offset: 0x12F5890 VA: 0x1812F7290
	private AstNode ParseEqualityExpr(AstNode qyInput) { }

	// RVA: 0x12F8B80 Offset: 0x12F7180 VA: 0x1812F8B80
	private AstNode ParseRelationalExpr(AstNode qyInput) { }

	// RVA: 0x12F7020 Offset: 0x12F5620 VA: 0x1812F7020
	private AstNode ParseAdditiveExpr(AstNode qyInput) { }

	// RVA: 0x12F8070 Offset: 0x12F6670 VA: 0x1812F8070
	private AstNode ParseMultiplicativeExpr(AstNode qyInput) { }

	// RVA: 0x12F9170 Offset: 0x12F7770 VA: 0x1812F9170
	private AstNode ParseUnaryExpr(AstNode qyInput) { }

	// RVA: 0x12F92C0 Offset: 0x12F78C0 VA: 0x1812F92C0
	private AstNode ParseUnionExpr(AstNode qyInput) { }

	// RVA: 0x12F6E80 Offset: 0x12F5480 VA: 0x1812F6E80
	private static bool IsNodeType(XPathScanner scaner) { }

	// RVA: 0x12F8660 Offset: 0x12F6C60 VA: 0x1812F8660
	private AstNode ParsePathExpr(AstNode qyInput) { }

	// RVA: 0x12F7550 Offset: 0x12F5B50 VA: 0x1812F7550
	private AstNode ParseFilterExpr(AstNode qyInput) { }

	// RVA: 0x12F88B0 Offset: 0x12F6EB0 VA: 0x1812F88B0
	private AstNode ParsePredicate(AstNode qyInput) { }

	// RVA: 0x12F77A0 Offset: 0x12F5DA0 VA: 0x1812F77A0
	private AstNode ParseLocationPath(AstNode qyInput) { }

	// RVA: 0x12F8CB0 Offset: 0x12F72B0 VA: 0x1812F8CB0
	private AstNode ParseRelativeLocationPath(AstNode qyInput) { }

	// RVA: 0x12F6FD0 Offset: 0x12F55D0 VA: 0x1812F6FD0
	private static bool IsStep(XPathScanner.LexKind lexKind) { }

	// RVA: 0x12F8D90 Offset: 0x12F7390 VA: 0x1812F8D90
	private AstNode ParseStep(AstNode qyInput) { }

	// RVA: 0x12F8220 Offset: 0x12F6820 VA: 0x1812F8220
	private AstNode ParseNodeTest(AstNode qyInput, Axis.AxisType axisType, XPathNodeType nodeType) { }

	// RVA: 0x12F6F30 Offset: 0x12F5530 VA: 0x1812F6F30
	private static bool IsPrimaryExpr(XPathScanner scanner) { }

	// RVA: 0x12F8950 Offset: 0x12F6F50 VA: 0x1812F8950
	private AstNode ParsePrimaryExpr(AstNode qyInput) { }

	// RVA: 0x12F78E0 Offset: 0x12F5EE0 VA: 0x1812F78E0
	private AstNode ParseMethod(AstNode qyInput) { }

	// RVA: 0x12F5E10 Offset: 0x12F4410 VA: 0x1812F5E10
	private void CheckToken(XPathScanner.LexKind t) { }

	// RVA: 0x12F9660 Offset: 0x12F7C60 VA: 0x1812F9660
	private void PassToken(XPathScanner.LexKind t) { }

	// RVA: 0x12F7000 Offset: 0x12F5600 VA: 0x1812F7000
	private void NextLex() { }

	// RVA: 0x12F9690 Offset: 0x12F7C90 VA: 0x1812F9690
	private bool TestOp(string op) { }

	// RVA: 0x12F5D90 Offset: 0x12F4390 VA: 0x1812F5D90
	private void CheckNodeSet(XPathResultType t) { }

	// RVA: 0x12F61C0 Offset: 0x12F47C0 VA: 0x1812F61C0
	private static Hashtable CreateFunctionTable() { }

	// RVA: 0x12F5EA0 Offset: 0x12F44A0 VA: 0x1812F5EA0
	private static Hashtable CreateAxesTable() { }

	// RVA: 0x12F6D80 Offset: 0x12F5380 VA: 0x1812F6D80
	private Axis.AxisType GetAxis(XPathScanner scaner) { }

	// RVA: 0x12F96E0 Offset: 0x12F7CE0 VA: 0x1812F96E0
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

	// RVA: 0x12F46F0 Offset: 0x12F2CF0 VA: 0x1812F46F0
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

	// RVA: 0x12FA500 Offset: 0x12F8B00 VA: 0x1812FA500
	public void .ctor(string xpathExpr) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_SourceText() { }

	// RVA: 0x12FA5F0 Offset: 0x12F8BF0 VA: 0x1812FA5F0
	private char get_CurerntChar() { }

	// RVA: 0x12F9A30 Offset: 0x12F8030 VA: 0x1812F9A30
	private bool NextChar() { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public XPathScanner.LexKind get_Kind() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public string get_Name() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_Prefix() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_StringValue() { }

	// RVA: 0x12FA600 Offset: 0x12F8C00 VA: 0x1812FA600
	public double get_NumberValue() { }

	// RVA: 0x4BC3E0 Offset: 0x4BA9E0 VA: 0x1804BC3E0
	public bool get_CanBeFunction() { }

	// RVA: 0x12FA460 Offset: 0x12F8A60 VA: 0x1812FA460
	private void SkipSpace() { }

	// RVA: 0x12F9A80 Offset: 0x12F8080 VA: 0x1812F9A80
	public bool NextLex() { }

	// RVA: 0x12FA1B0 Offset: 0x12F87B0 VA: 0x1812FA1B0
	private double ScanNumber() { }

	// RVA: 0x12FA000 Offset: 0x12F8600 VA: 0x1812FA000
	private double ScanFraction() { }

	// RVA: 0x12FA320 Offset: 0x12F8920 VA: 0x1812FA320
	private string ScanString() { }

	// RVA: 0x12FA0F0 Offset: 0x12F86F0 VA: 0x1812FA0F0
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

	// RVA: 0x12F4FF0 Offset: 0x12F35F0 VA: 0x1812F4FF0
	public void .ctor(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent) { }

	// RVA: 0x12F5370 Offset: 0x12F3970 VA: 0x1812F5370 Slot: 5
	public override string get_Value() { }

	// RVA: 0x12F4870 Offset: 0x12F2E70 VA: 0x1812F4870 Slot: 23
	public override XPathNavigator Clone() { }

	// RVA: 0x12F52E0 Offset: 0x12F38E0 VA: 0x1812F52E0 Slot: 24
	public override XPathNodeType get_NodeType() { }

	// RVA: 0x12F51F0 Offset: 0x12F37F0 VA: 0x1812F51F0 Slot: 25
	public override string get_LocalName() { }

	// RVA: 0x12F5290 Offset: 0x12F3890 VA: 0x1812F5290 Slot: 26
	public override string get_NamespaceURI() { }

	// RVA: 0x12F5320 Offset: 0x12F3920 VA: 0x1812F5320 Slot: 27
	public override string get_Prefix() { }

	// RVA: 0x12F5240 Offset: 0x12F3840 VA: 0x1812F5240 Slot: 19
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x12F4A40 Offset: 0x12F3040 VA: 0x1812F4A40 Slot: 30
	public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: 0x12F4CE0 Offset: 0x12F32E0 VA: 0x1812F4CE0 Slot: 31
	public override bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x12F4EF0 Offset: 0x12F34F0 VA: 0x1812F4EF0 Slot: 32
	public override bool MoveToParent() { }

	// RVA: 0x12F49B0 Offset: 0x12F2FB0 VA: 0x1812F49B0 Slot: 33
	public override bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0xE51740 Offset: 0xE4FD40 VA: 0x180E51740 Slot: 28
	public override object get_UnderlyingObject() { }

	// RVA: 0x12F4960 Offset: 0x12F2F60 VA: 0x1812F4960 Slot: 35
	public bool HasLineInfo() { }

	// RVA: 0x12F5090 Offset: 0x12F3690 VA: 0x1812F5090 Slot: 36
	public int get_LineNumber() { }

	// RVA: 0x12F5130 Offset: 0x12F3730 VA: 0x1812F5130 Slot: 37
	public int get_LinePosition() { }

	// RVA: 0x12F4950 Offset: 0x12F2F50 VA: 0x1812F4950
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

	// RVA: 0x1E0420 Offset: 0x1DF820 VA: 0x1801E0420
	public XPathNodeType get_NodeType() { }

	// RVA: 0x1E0450 Offset: 0x1DF850 VA: 0x1801E0450
	public string get_Prefix() { }

	// RVA: 0x1E03E0 Offset: 0x1DF7E0 VA: 0x1801E03E0
	public string get_LocalName() { }

	// RVA: 0x1E0400 Offset: 0x1DF800 VA: 0x1801E0400
	public string get_NamespaceUri() { }

	// RVA: 0x1E0270 Offset: 0x1DF670 VA: 0x1801E0270
	public XPathDocument get_Document() { }

	// RVA: 0x1E0390 Offset: 0x1DF790 VA: 0x1801E0390
	public int get_LineNumber() { }

	// RVA: 0x1E03C0 Offset: 0x1DF7C0 VA: 0x1801E03C0
	public int get_LinePosition() { }

	// RVA: 0x1E0240 Offset: 0x1DF640 VA: 0x1801E0240
	public int get_CollapsedLinePosition() { }

	// RVA: 0x1E0430 Offset: 0x1DF830 VA: 0x1801E0430
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x1E01C0 Offset: 0x1DF5C0 VA: 0x1801E01C0
	public int GetParent(out XPathNode[] pageNode) { }

	// RVA: 0x1E0200 Offset: 0x1DF600 VA: 0x1801E0200
	public int GetSibling(out XPathNode[] pageNode) { }

	// RVA: 0x1E0320 Offset: 0x1DF720 VA: 0x1801E0320
	public bool get_IsXmlNamespaceNode() { }

	// RVA: 0x1E02B0 Offset: 0x1DF6B0 VA: 0x1801E02B0
	public bool get_HasSibling() { }

	// RVA: 0x1E0290 Offset: 0x1DF690 VA: 0x1801E0290
	public bool get_HasCollapsedText() { }

	// RVA: 0x1E02C0 Offset: 0x1DF6C0 VA: 0x1801E02C0
	public bool get_IsText() { }

	// RVA: 0x1E02A0 Offset: 0x1DF6A0 VA: 0x1801E02A0
	public bool get_HasNamespaceDecls() { }

	// RVA: 0xF3F70 Offset: 0xF3370 VA: 0x1800F3F70
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

	// RVA: 0xF91E0 Offset: 0xF85E0 VA: 0x1800F91E0
	public void .ctor(XPathNode[] page, int idx) { }

	// RVA: 0xFC8C0 Offset: 0xFBCC0 VA: 0x1800FC8C0
	public XPathNode[] get_Page() { }

	// RVA: 0x122E90 Offset: 0x122290 VA: 0x180122E90
	public int get_Index() { }

	// RVA: 0x1E0150 Offset: 0x1DF550 VA: 0x1801E0150 Slot: 2
	public override int GetHashCode() { }

}

internal abstract class XPathNodeHelper // TypeDefIndex: 1807
{	// Methods

	// RVA: 0x12F57F0 Offset: 0x12F3DF0 VA: 0x1812F57F0
	public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0x12F56B0 Offset: 0x12F3CB0 VA: 0x1812F56B0
	public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0x12F59C0 Offset: 0x12F3FC0 VA: 0x1812F59C0
	public static bool GetParent(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x12F5870 Offset: 0x12F3E70 VA: 0x1812F5870
	public static int GetLocation(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x12F5A60 Offset: 0x12F4060 VA: 0x1812F5A60
	public static bool GetTextFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd) { }

	// RVA: 0x12F58C0 Offset: 0x12F3EC0 VA: 0x1812F58C0
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

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
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

	// RVA: 0xBA08E0 Offset: 0xB9EEE0 VA: 0x180BA08E0
	internal void .ctor(XmlRawWriter rawWriter) { }

	// RVA: 0xBA08B0 Offset: 0xB9EEB0 VA: 0x180BA08B0 Slot: 4
	internal override void WriteChars(char[] chars, int index, int count) { }

}

internal class XmlTextWriterBase64Encoder : Base64Encoder // TypeDefIndex: 1815
{	// Fields
	private XmlTextEncoder xmlTextEncoder; // 0x28

	// Methods

	// RVA: 0xBA08E0 Offset: 0xB9EEE0 VA: 0x180BA08E0
	internal void .ctor(XmlTextEncoder xmlTextEncoder) { }

	// RVA: 0x13199D0 Offset: 0x1317FD0 VA: 0x1813199D0 Slot: 4
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

	// RVA: 0x1E0020 Offset: 0x1DF420 VA: 0x1801E0020
	public bool get_IsPositive() { }

	// RVA: 0x1E0010 Offset: 0x1DF410 VA: 0x1801E0010
	public void .ctor(byte[] data, int offset, bool trim) { }

	// RVA: 0x1202A50 Offset: 0x1201050 VA: 0x181202A50
	private static uint UIntFromByteArray(byte[] data, int offset) { }

	// RVA: 0x12E1480 Offset: 0x12DFA80 VA: 0x1812E1480
	private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	// RVA: 0xEA3770 Offset: 0xEA1D70 VA: 0x180EA3770
	private static void MpNormalize(uint[] rgulU, ref int ciulU) { }

	// RVA: 0xEA15C0 Offset: 0xE9FBC0 VA: 0x180EA15C0
	private static char ChFromDigit(uint uiDigit) { }

	// RVA: 0x1DFF30 Offset: 0x1DF330 VA: 0x1801DFF30
	public Decimal ToDecimal() { }

	// RVA: 0x1E0000 Offset: 0x1DF400 VA: 0x1801E0000
	private void TrimTrailingZeros() { }

	// RVA: 0x1DFFF0 Offset: 0x1DF3F0 VA: 0x1801DFFF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x12E1E20 Offset: 0x12E0420 VA: 0x1812E1E20
	private static void .cctor() { }

}

internal struct BinXmlSqlMoney // TypeDefIndex: 1820
{	// Fields
	private long data; // 0x0

	// Methods

	// RVA: 0x1E0140 Offset: 0x1DF540 VA: 0x1801E0140
	public void .ctor(int v) { }

	// RVA: 0x1D2F30 Offset: 0x1D2330 VA: 0x1801D2F30
	public void .ctor(long v) { }

	// RVA: 0x1E0030 Offset: 0x1DF430 VA: 0x1801E0030
	public Decimal ToDecimal() { }

	// RVA: 0x1E0080 Offset: 0x1DF480 VA: 0x1801E0080 Slot: 3
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

	// RVA: 0x12DF3C0 Offset: 0x12DD9C0 VA: 0x1812DF3C0
	private static void Write2Dig(StringBuilder sb, int val) { }

	// RVA: 0x12DF4F0 Offset: 0x12DDAF0 VA: 0x1812DF4F0
	private static void Write4DigNeg(StringBuilder sb, int val) { }

	// RVA: 0x12DF430 Offset: 0x12DDA30 VA: 0x1812DF430
	private static void Write3Dec(StringBuilder sb, int val) { }

	// RVA: 0x12DF620 Offset: 0x12DDC20 VA: 0x1812DF620
	private static void WriteDate(StringBuilder sb, int yr, int mnth, int day) { }

	// RVA: 0x12DFCA0 Offset: 0x12DE2A0 VA: 0x1812DFCA0
	private static void WriteTime(StringBuilder sb, int hr, int min, int sec, int ms) { }

	// RVA: 0x12DF850 Offset: 0x12DDE50 VA: 0x1812DF850
	private static void WriteTimeFullPrecision(StringBuilder sb, int hr, int min, int sec, int fraction) { }

	// RVA: 0x12DFAA0 Offset: 0x12DE0A0 VA: 0x1812DFAA0
	private static void WriteTimeZone(StringBuilder sb, TimeSpan zone) { }

	// RVA: 0x12DFB60 Offset: 0x12DE160 VA: 0x1812DFB60
	private static void WriteTimeZone(StringBuilder sb, bool negTimeZone, int hr, int min) { }

	// RVA: 0x12DE690 Offset: 0x12DCC90 VA: 0x1812DE690
	private static void BreakDownXsdDateTime(long val, out int yr, out int mnth, out int day, out int hr, out int min, out int sec, out int ms) { }

	// RVA: 0x12DE850 Offset: 0x12DCE50 VA: 0x1812DE850
	private static void BreakDownXsdDate(long val, out int yr, out int mnth, out int day, out bool negTimeZone, out int hr, out int min) { }

	// RVA: 0x12DE9B0 Offset: 0x12DCFB0 VA: 0x1812DE9B0
	private static void BreakDownXsdTime(long val, out int hr, out int min, out int sec, out int ms) { }

	// RVA: 0x12DFEC0 Offset: 0x12DE4C0 VA: 0x1812DFEC0
	public static string XsdDateTimeToString(long val) { }

	// RVA: 0x12E0140 Offset: 0x12DE740 VA: 0x1812E0140
	public static string XsdDateToString(long val) { }

	// RVA: 0x12E11F0 Offset: 0x12DF7F0 VA: 0x1812E11F0
	public static string XsdTimeToString(long val) { }

	// RVA: 0x12DF180 Offset: 0x12DD780 VA: 0x1812DF180
	public static string SqlDateTimeToString(int dateticks, uint timeticks) { }

	// RVA: 0x12DF0C0 Offset: 0x12DD6C0 VA: 0x1812DF0C0
	public static DateTime SqlDateTimeToDateTime(int dateticks, uint timeticks) { }

	// RVA: 0x12DF2C0 Offset: 0x12DD8C0 VA: 0x1812DF2C0
	public static string SqlSmallDateTimeToString(short dateticks, ushort timeticks) { }

	// RVA: 0x12DF240 Offset: 0x12DD840 VA: 0x1812DF240
	public static DateTime SqlSmallDateTimeToDateTime(short dateticks, ushort timeticks) { }

	// RVA: 0x12E0B70 Offset: 0x12DF170 VA: 0x1812E0B70
	public static DateTime XsdKatmaiDateToDateTime(byte[] data, int offset) { }

	// RVA: 0x12E0900 Offset: 0x12DEF00 VA: 0x1812E0900
	public static DateTime XsdKatmaiDateTimeToDateTime(byte[] data, int offset) { }

	// RVA: 0x12E1040 Offset: 0x12DF640 VA: 0x1812E1040
	public static DateTime XsdKatmaiTimeToDateTime(byte[] data, int offset) { }

	// RVA: 0x12E0420 Offset: 0x12DEA20 VA: 0x1812E0420
	public static DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x12E05F0 Offset: 0x12DEBF0 VA: 0x1812E05F0
	public static DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x12E0E40 Offset: 0x12DF440 VA: 0x1812E0E40
	public static DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x12E0C70 Offset: 0x12DF270 VA: 0x1812E0C70
	public static string XsdKatmaiDateToString(byte[] data, int offset) { }

	// RVA: 0x12E0A10 Offset: 0x12DF010 VA: 0x1812E0A10
	public static string XsdKatmaiDateTimeToString(byte[] data, int offset) { }

	// RVA: 0x12E10A0 Offset: 0x12DF6A0 VA: 0x1812E10A0
	public static string XsdKatmaiTimeToString(byte[] data, int offset) { }

	// RVA: 0x12E04A0 Offset: 0x12DEAA0 VA: 0x1812E04A0
	public static string XsdKatmaiDateOffsetToString(byte[] data, int offset) { }

	// RVA: 0x12E0770 Offset: 0x12DED70 VA: 0x1812E0770
	public static string XsdKatmaiDateTimeOffsetToString(byte[] data, int offset) { }

	// RVA: 0x12E0EC0 Offset: 0x12DF4C0 VA: 0x1812E0EC0
	public static string XsdKatmaiTimeOffsetToString(byte[] data, int offset) { }

	// RVA: 0x12DEC90 Offset: 0x12DD290 VA: 0x1812DEC90
	private static long GetKatmaiDateTicks(byte[] data, ref int pos) { }

	// RVA: 0x12DED30 Offset: 0x12DD330 VA: 0x1812DED30
	private static long GetKatmaiTimeTicks(byte[] data, ref int pos) { }

	// RVA: 0x12DF050 Offset: 0x12DD650 VA: 0x1812DF050
	private static long GetKatmaiTimeZoneTicks(byte[] data, int pos) { }

	// RVA: 0x12DEBB0 Offset: 0x12DD1B0 VA: 0x1812DEBB0
	private static int GetFractions(DateTime dt) { }

	// RVA: 0x12DEAD0 Offset: 0x12DD0D0 VA: 0x1812DEAD0
	private static int GetFractions(DateTimeOffset dt) { }

	// RVA: 0x12E13A0 Offset: 0x12DF9A0 VA: 0x1812E13A0
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

	// RVA: 0xBAFC40 Offset: 0xBAE240 VA: 0x180BAFC40
	public void .ctor(Stream stream, byte[] data, int len, string baseUri, bool closeInput, XmlReaderSettings settings) { }

	// RVA: 0xBB03E0 Offset: 0xBAE9E0 VA: 0x180BB03E0 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0xBB0340 Offset: 0xBAE940 VA: 0x180BB0340 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x952B90 Offset: 0x951190 VA: 0x180952B90 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x9921A0 Offset: 0x9907A0 VA: 0x1809921A0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xBB0670 Offset: 0xBAEC70 VA: 0x180BB0670 Slot: 11
	public override string get_Value() { }

	// RVA: 0xBB0240 Offset: 0xBAE840 VA: 0x180BB0240 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBB0320 Offset: 0xBAE920 VA: 0x180BB0320 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xBB0A40 Offset: 0xBAF040 VA: 0x180BB0A40 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBB0990 Offset: 0xBAEF90 VA: 0x180BB0990 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x871D30 Offset: 0x870330 VA: 0x180871D30 Slot: 20
	public override Type get_ValueType() { }

	// RVA: 0xBB01E0 Offset: 0xBAE7E0 VA: 0x180BB01E0 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xBA7740 Offset: 0xBA5D40 VA: 0x180BA7740 Slot: 23
	public override string GetAttribute(string name, string ns) { }

	// RVA: 0xBA7610 Offset: 0xBA5C10 VA: 0x180BA7610 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xBA7680 Offset: 0xBA5C80 VA: 0x180BA7680 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xBA9B40 Offset: 0xBA8140 VA: 0x180BA9B40 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xBA9BD0 Offset: 0xBA81D0 VA: 0x180BA9BD0 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0xBA9DB0 Offset: 0xBA83B0 VA: 0x180BA9DB0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xBA9E30 Offset: 0xBA8430 VA: 0x180BA9E30 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0xBA9CA0 Offset: 0xBA82A0 VA: 0x180BA9CA0 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0xBB0310 Offset: 0xBAE910 VA: 0x180BB0310 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0xBAAE60 Offset: 0xBA9460 VA: 0x180BAAE60 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0xBA5B20 Offset: 0xBA4120 VA: 0x180BA5B20 Slot: 33
	public override void Close() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xBA9A80 Offset: 0xBA8080 VA: 0x180BA9A80 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0xBAC790 Offset: 0xBAAD90 VA: 0x180BAC790 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0xBB0350 Offset: 0xBAE950 VA: 0x180BB0350 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xBAC2D0 Offset: 0xBAA8D0 VA: 0x180BAC2D0 Slot: 31
	public override bool Read() { }

	// RVA: 0xBAD900 Offset: 0xBABF00 VA: 0x180BAD900 Slot: 53
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xBADC50 Offset: 0xBAC250 VA: 0x180BADC50 Slot: 55
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0xBAF860 Offset: 0xBADE60 VA: 0x180BAF860
	private void VerifyVersion(int requiredVersion, BinXmlToken token) { }

	// RVA: 0xBA5050 Offset: 0xBA3650 VA: 0x180BA5050
	private void AddInitNamespace(string prefix, string uri) { }

	// RVA: 0xBA5190 Offset: 0xBA3790 VA: 0x180BA5190
	private void AddName() { }

	// RVA: 0xBA52F0 Offset: 0xBA38F0 VA: 0x180BA52F0
	private void AddQName() { }

	// RVA: 0xBA9ED0 Offset: 0xBA84D0 VA: 0x180BA9ED0
	private void NameFlush() { }

	// RVA: 0xBAD7D0 Offset: 0xBABDD0 VA: 0x180BAD7D0
	private void SkipExtn() { }

	// RVA: 0xBAC0F0 Offset: 0xBAA6F0 VA: 0x180BAC0F0
	private int ReadQNameRef() { }

	// RVA: 0xBAC010 Offset: 0xBAA610 VA: 0x180BAC010
	private int ReadNameRef() { }

	// RVA: 0xBA5BD0 Offset: 0xBA41D0 VA: 0x180BA5BD0
	private bool FillAllowEOF() { }

	// RVA: 0xBA5E10 Offset: 0xBA4410 VA: 0x180BA5E10
	private void Fill_(int require) { }

	// RVA: 0xBA5E90 Offset: 0xBA4490 VA: 0x180BA5E90
	private void Fill(int require) { }

	// RVA: 0xBAB030 Offset: 0xBA9630 VA: 0x180BAB030
	private byte ReadByte() { }

	// RVA: 0xBAC250 Offset: 0xBAA850 VA: 0x180BAC250
	private ushort ReadUShort() { }

	// RVA: 0xBAA670 Offset: 0xBA8C70 VA: 0x180BAA670
	private int ParseMB32() { }

	// RVA: 0xBAA4C0 Offset: 0xBA8AC0 VA: 0x180BAA4C0
	private int ParseMB32_(byte b) { }

	// RVA: 0xBAA6E0 Offset: 0xBA8CE0 VA: 0x180BAA6E0
	private int ParseMB32(int pos) { }

	// RVA: 0xBAA670 Offset: 0xBA8C70 VA: 0x180BAA670
	private int ParseMB64() { }

	// RVA: 0xBAA930 Offset: 0xBA8F30 VA: 0x180BAA930
	private BinXmlToken PeekToken() { }

	// RVA: 0xBAC1D0 Offset: 0xBAA7D0 VA: 0x180BAC1D0
	private BinXmlToken ReadToken() { }

	// RVA: 0xBAA000 Offset: 0xBA8600 VA: 0x180BAA000
	private BinXmlToken NextToken2(BinXmlToken token) { }

	// RVA: 0xBA9F30 Offset: 0xBA8530 VA: 0x180BA9F30
	private BinXmlToken NextToken1() { }

	// RVA: 0xBAA3B0 Offset: 0xBA89B0 VA: 0x180BAA3B0
	private BinXmlToken NextToken() { }

	// RVA: 0xBAA910 Offset: 0xBA8F10 VA: 0x180BAA910
	private BinXmlToken PeekNextToken() { }

	// RVA: 0xBAC450 Offset: 0xBAAA50 VA: 0x180BAC450
	private BinXmlToken RescanNextToken() { }

	// RVA: 0xBAA840 Offset: 0xBA8E40 VA: 0x180BAA840
	private string ParseText() { }

	// RVA: 0xBAD4C0 Offset: 0xBABAC0 VA: 0x180BAD4C0
	private int ScanText(out int start) { }

	// RVA: 0xBA7DF0 Offset: 0xBA63F0 VA: 0x180BA7DF0
	private string GetString(int pos, int cch) { }

	// RVA: 0xBA7DC0 Offset: 0xBA63C0 VA: 0x180BA7DC0
	private string GetStringAligned(byte[] data, int offset, int cch) { }

	// RVA: 0xBA7470 Offset: 0xBA5A70 VA: 0x180BA7470
	private string GetAttributeText(int i) { }

	// RVA: 0xBA98C0 Offset: 0xBA7EC0 VA: 0x180BA98C0
	private int LocateAttribute(string name, string ns) { }

	// RVA: 0xBA9980 Offset: 0xBA7F80 VA: 0x180BA9980
	private int LocateAttribute(string name) { }

	// RVA: 0xBAAA80 Offset: 0xBA9080 VA: 0x180BAAA80
	private void PositionOnAttribute(int i) { }

	// RVA: 0xBA82B0 Offset: 0xBA68B0 VA: 0x180BA82B0
	private void GrowElements() { }

	// RVA: 0xBA8210 Offset: 0xBA6810 VA: 0x180BA8210
	private void GrowAttributes() { }

	// RVA: 0xBA5B00 Offset: 0xBA4100 VA: 0x180BA5B00
	private void ClearAttributes() { }

	// RVA: 0xBAABB0 Offset: 0xBA91B0 VA: 0x180BAABB0
	private void PushNamespace(string prefix, string ns, bool implied) { }

	// RVA: 0xBAA9A0 Offset: 0xBA8FA0 VA: 0x180BAA9A0
	private void PopNamespaces(XmlSqlBinaryReader.NamespaceDecl firstInScopeChain) { }

	// RVA: 0xBA6140 Offset: 0xBA4740 VA: 0x180BA6140
	private void GenerateImpliedXmlnsAttrs() { }

	// RVA: 0xBABA00 Offset: 0xBAA000 VA: 0x180BABA00
	private bool ReadInit(bool skipXmlDecl) { }

	// RVA: 0xBAC7E0 Offset: 0xBAADE0 VA: 0x180BAC7E0
	private void ScanAttributes() { }

	// RVA: 0xBAD600 Offset: 0xBABC00 VA: 0x180BAD600
	private void SimpleCheckForDuplicateAttributes() { }

	// RVA: 0xBA8350 Offset: 0xBA6950 VA: 0x180BA8350
	private void HashCheckForDuplicateAttributes() { }

	// RVA: 0xBAF8D0 Offset: 0xBADED0 VA: 0x180BAF8D0
	private string XmlDeclValue() { }

	// RVA: 0xBA55C0 Offset: 0xBA3BC0 VA: 0x180BA55C0
	private string CDATAValue() { }

	// RVA: 0xBA5F30 Offset: 0xBA4530 VA: 0x180BA5F30
	private void FinishCDATA() { }

	// RVA: 0xBA6020 Offset: 0xBA4620 VA: 0x180BA6020
	private void FinishEndElement() { }

	// RVA: 0xBAB080 Offset: 0xBA9680 VA: 0x180BAB080
	private bool ReadDoc() { }

	// RVA: 0xBA8770 Offset: 0xBA6D70 VA: 0x180BA8770
	private void ImplReadData(BinXmlToken tokenType) { }

	// RVA: 0xBA8CB0 Offset: 0xBA72B0 VA: 0x180BA8CB0
	private void ImplReadElement() { }

	// RVA: 0xBA9060 Offset: 0xBA7660 VA: 0x180BA9060
	private void ImplReadEndElement() { }

	// RVA: 0xBA8900 Offset: 0xBA6F00 VA: 0x180BA8900
	private void ImplReadDoctype() { }

	// RVA: 0xBA9340 Offset: 0xBA7940 VA: 0x180BA9340
	private void ImplReadPI() { }

	// RVA: 0xBA8730 Offset: 0xBA6D30 VA: 0x180BA8730
	private void ImplReadComment() { }

	// RVA: 0xBA86A0 Offset: 0xBA6CA0 VA: 0x180BA86A0
	private void ImplReadCDATA() { }

	// RVA: 0xBA91E0 Offset: 0xBA77E0 VA: 0x180BA91E0
	private void ImplReadNest() { }

	// RVA: 0xBA9170 Offset: 0xBA7770 VA: 0x180BA9170
	private void ImplReadEndNest() { }

	// RVA: 0xBA93D0 Offset: 0xBA79D0 VA: 0x180BA93D0
	private void ImplReadXmlText() { }

	// RVA: 0xBAE0A0 Offset: 0xBAC6A0 VA: 0x180BAE0A0
	private void UpdateFromTextReader() { }

	// RVA: 0xBAE080 Offset: 0xBAC680 VA: 0x180BAE080
	private bool UpdateFromTextReader(bool needUpdate) { }

	// RVA: 0xBA5720 Offset: 0xBA3D20 VA: 0x180BA5720
	private void CheckAllowContent() { }

	// RVA: 0xBA6350 Offset: 0xBA4950 VA: 0x180BA6350
	private void GenerateTokenTypeMap() { }

	// RVA: 0xBA7F70 Offset: 0xBA6570 VA: 0x180BA7F70
	private Type GetValueType(BinXmlToken token) { }

	// RVA: 0xBAAE40 Offset: 0xBA9440 VA: 0x180BAAE40
	private void ReScanOverValue(BinXmlToken token) { }

	// RVA: 0xBAD2A0 Offset: 0xBAB8A0 VA: 0x180BAD2A0
	private XmlNodeType ScanOverValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0xBACD70 Offset: 0xBAB370 VA: 0x180BACD70
	private XmlNodeType ScanOverAnyValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0xBA5840 Offset: 0xBA3E40 VA: 0x180BA5840
	private XmlNodeType CheckText(bool attr) { }

	// RVA: 0xBA5790 Offset: 0xBA3D90 VA: 0x180BA5790
	private XmlNodeType CheckTextIsWS() { }

	// RVA: 0xBA5AA0 Offset: 0xBA40A0 VA: 0x180BA5AA0
	private void CheckValueTokenBounds() { }

	// RVA: 0xBA8060 Offset: 0xBA6660 VA: 0x180BA8060
	private int GetXsdKatmaiTokenLength(BinXmlToken token) { }

	// RVA: 0xBAFA30 Offset: 0xBAE030 VA: 0x180BAFA30
	private int XsdKatmaiTimeScaleToValueLength(byte scale) { }

	// RVA: 0xBAEAB0 Offset: 0xBAD0B0 VA: 0x180BAEAB0
	private long ValueAsLong() { }

	// RVA: 0xBAF7B0 Offset: 0xBADDB0 VA: 0x180BAF7B0
	private ulong ValueAsULong() { }

	// RVA: 0xBAE600 Offset: 0xBACC00 VA: 0x180BAE600
	private Decimal ValueAsDecimal() { }

	// RVA: 0xBAE8B0 Offset: 0xBACEB0 VA: 0x180BAE8B0
	private double ValueAsDouble() { }

	// RVA: 0xBAE1A0 Offset: 0xBAC7A0 VA: 0x180BAE1A0
	private string ValueAsDateTimeString() { }

	// RVA: 0xBAEFE0 Offset: 0xBAD5E0 VA: 0x180BAEFE0
	private string ValueAsString(BinXmlToken token) { }

	// RVA: 0xBA7A60 Offset: 0xBA6060 VA: 0x180BA7A60
	private short GetInt16(int pos) { }

	// RVA: 0xBA7A60 Offset: 0xBA6060 VA: 0x180BA7A60
	private ushort GetUInt16(int pos) { }

	// RVA: 0xBA7AC0 Offset: 0xBA60C0 VA: 0x180BA7AC0
	private int GetInt32(int pos) { }

	// RVA: 0xBA7AC0 Offset: 0xBA60C0 VA: 0x180BA7AC0
	private uint GetUInt32(int pos) { }

	// RVA: 0xBA7B70 Offset: 0xBA6170 VA: 0x180BA7B70
	private long GetInt64(int pos) { }

	// RVA: 0xBA7B70 Offset: 0xBA6170 VA: 0x180BA7B70
	private ulong GetUInt64(int pos) { }

	// RVA: 0xBA7D10 Offset: 0xBA6310 VA: 0x180BA7D10
	private float GetSingle(int offset) { }

	// RVA: 0xBA78C0 Offset: 0xBA5EC0 VA: 0x180BA78C0
	private double GetDouble(int offset) { }

	// RVA: 0xBADE30 Offset: 0xBAC430 VA: 0x180BADE30
	private Exception ThrowUnexpectedToken(BinXmlToken token) { }

	// RVA: 0xBAE010 Offset: 0xBAC610 VA: 0x180BAE010
	private Exception ThrowXmlException(string res) { }

	// RVA: 0xBADEC0 Offset: 0xBAC4C0 VA: 0x180BADEC0
	private Exception ThrowXmlException(string res, string arg1, string arg2) { }

	// RVA: 0xBADDC0 Offset: 0xBAC3C0 VA: 0x180BADDC0
	private Exception ThrowNotSupported(string res) { }

	// RVA: 0xBAFAF0 Offset: 0xBAE0F0 VA: 0x180BAFAF0
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

	// RVA: 0xF5CF0 Offset: 0xF50F0 VA: 0x1800F5CF0
	public void .ctor(string prefix, string lname, string nsUri) { }

	// RVA: 0xF5CF0 Offset: 0xF50F0 VA: 0x1800F5CF0
	public void Set(string prefix, string lname, string nsUri) { }

	// RVA: 0xFDA10 Offset: 0xFCE10 VA: 0x1800FDA10
	public void Clear() { }

	// RVA: 0xFD660 Offset: 0xFCA60 VA: 0x1800FD660
	public bool MatchNs(string lname, string nsUri) { }

	// RVA: 0xFDB80 Offset: 0xFCF80 VA: 0x1800FDB80
	public bool MatchPrefix(string prefix, string lname) { }

	// RVA: 0xFDA00 Offset: 0xFCE00 VA: 0x1800FDA00
	public void CheckPrefixNS(string prefix, string namespaceUri) { }

	// RVA: 0xF5A70 Offset: 0xF4E70 VA: 0x1800F5A70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFDB20 Offset: 0xFCF20 VA: 0x1800FDB20
	public int GetNSHashCode(SecureStringHasher hasher) { }

	// RVA: 0xFDA20 Offset: 0xFCE20 VA: 0x1800FDA20 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xFDBD0 Offset: 0xFCFD0 VA: 0x1800FDBD0 Slot: 3
	public override string ToString() { }

	// RVA: 0xB9B0D0 Offset: 0xB996D0 VA: 0x180B9B0D0
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

	// RVA: 0xFD980 Offset: 0xFCD80 VA: 0x1800FD980
	public void Set(XmlSqlBinaryReader.QName name, bool xmlspacePreserve) { }

	// RVA: 0xFD950 Offset: 0xFCD50 VA: 0x1800FD950
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

	// RVA: 0xFD6B0 Offset: 0xFCAB0 VA: 0x1800FD6B0
	public void Set(XmlSqlBinaryReader.QName n, string v) { }

	// RVA: 0xFD700 Offset: 0xFCB00 VA: 0x1800FD700
	public void Set(XmlSqlBinaryReader.QName n, int pos) { }

	// RVA: 0xFD5C0 Offset: 0xFC9C0 VA: 0x1800FD5C0
	public void GetLocalnameAndNamespaceUri(out string localname, out string namespaceUri) { }

	// RVA: 0xFD540 Offset: 0xFC940 VA: 0x1800FD540
	public int GetLocalnameAndNamespaceUriAndHash(SecureStringHasher hasher, out string localname, out string namespaceUri) { }

	// RVA: 0xFD660 Offset: 0xFCA60 VA: 0x1800FD660
	public bool MatchNS(string localname, string namespaceUri) { }

	// RVA: 0xFD600 Offset: 0xFCA00 VA: 0x1800FD600
	public bool MatchHashNS(int hash, string localname, string namespaceUri) { }

	// RVA: 0xFD530 Offset: 0xFC930 VA: 0x1800FD530
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

	// RVA: 0xB9ACD0 Offset: 0xB992D0 VA: 0x180B9ACD0
	public void .ctor(string prefix, string nsuri, XmlSqlBinaryReader.NamespaceDecl nextInScope, XmlSqlBinaryReader.NamespaceDecl prevDecl, int scope, bool implied) { }

}

private struct XmlSqlBinaryReader.SymbolTables // TypeDefIndex: 1828
{	// Fields
	public string[] symtable; // 0x0
	public int symCount; // 0x8
	public XmlSqlBinaryReader.QName[] qnametable; // 0x10
	public int qnameCount; // 0x18

	// Methods

	// RVA: 0xFDC30 Offset: 0xFD030 VA: 0x1800FDC30
	public void Init() { }

}

private class XmlSqlBinaryReader.NestedBinXml // TypeDefIndex: 1829
{	// Fields
	public XmlSqlBinaryReader.SymbolTables symbolTables; // 0x10
	public int docState; // 0x30
	public XmlSqlBinaryReader.NestedBinXml next; // 0x38

	// Methods

	// RVA: 0xB9AD60 Offset: 0xB99360 VA: 0x180B9AD60
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

	// RVA: 0xE53170 Offset: 0xE51770 VA: 0x180E53170
	public static XmlAsyncCheckReader CreateAsyncCheckWrapper(XmlReader reader) { }

	// RVA: 0xE539E0 Offset: 0xE51FE0 VA: 0x180E539E0
	public void .ctor(XmlReader reader) { }

	// RVA: 0xE530A0 Offset: 0xE516A0 VA: 0x180E530A0
	private void CheckAsync() { }

	// RVA: 0xE53F90 Offset: 0xE52590 VA: 0x180E53F90 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0xE53E50 Offset: 0xE52450 VA: 0x180E53E50 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xE53D90 Offset: 0xE52390 VA: 0x180E53D90 Slot: 7
	public override string get_Name() { }

	// RVA: 0xE53D10 Offset: 0xE52310 VA: 0x180E53D10 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0xE53E10 Offset: 0xE52410 VA: 0x180E53E10 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0xE53E90 Offset: 0xE52490 VA: 0x180E53E90 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xE54060 Offset: 0xE52660 VA: 0x180E54060 Slot: 11
	public override string get_Value() { }

	// RVA: 0xE53B90 Offset: 0xE52190 VA: 0x180E53B90 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xE53AD0 Offset: 0xE520D0 VA: 0x180E53AD0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xE53CD0 Offset: 0xE522D0 VA: 0x180E53CD0 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xE53C90 Offset: 0xE52290 VA: 0x180E53C90 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xE53ED0 Offset: 0xE524D0 VA: 0x180E53ED0 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xE540E0 Offset: 0xE526E0 VA: 0x180E540E0 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xE540A0 Offset: 0xE526A0 VA: 0x180E540A0 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0xE53F50 Offset: 0xE52550 VA: 0x180E53F50 Slot: 19
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xE54020 Offset: 0xE52620 VA: 0x180E54020 Slot: 20
	public override Type get_ValueType() { }

	// RVA: 0xE53A90 Offset: 0xE52090 VA: 0x180E53A90 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xE533E0 Offset: 0xE519E0 VA: 0x180E533E0 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xE53430 Offset: 0xE51A30 VA: 0x180E53430 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0xE53490 Offset: 0xE51A90 VA: 0x180E53490 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xE535E0 Offset: 0xE51BE0 VA: 0x180E535E0 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xE53590 Offset: 0xE51B90 VA: 0x180E53590 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0xE536B0 Offset: 0xE51CB0 VA: 0x180E536B0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xE536F0 Offset: 0xE51CF0 VA: 0x180E536F0 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0xE53670 Offset: 0xE51C70 VA: 0x180E53670 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0xE53730 Offset: 0xE51D30 VA: 0x180E53730 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0xE53920 Offset: 0xE51F20 VA: 0x180E53920 Slot: 31
	public override bool Read() { }

	// RVA: 0xE53C10 Offset: 0xE52210 VA: 0x180E53C10 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0xE53130 Offset: 0xE51730 VA: 0x180E53130 Slot: 33
	public override void Close() { }

	// RVA: 0xE53F10 Offset: 0xE52510 VA: 0x180E53F10 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xE539A0 Offset: 0xE51FA0 VA: 0x180E539A0 Slot: 35
	public override void Skip() { }

	// RVA: 0xE53D50 Offset: 0xE52350 VA: 0x180E53D50 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xE53540 Offset: 0xE51B40 VA: 0x180E53540 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0xE53B50 Offset: 0xE52150 VA: 0x180E53B50 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0xE53960 Offset: 0xE51F60 VA: 0x180E53960 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0xE53B10 Offset: 0xE52110 VA: 0x180E53B10 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0xE538B0 Offset: 0xE51EB0 VA: 0x180E538B0 Slot: 41
	public override int ReadValueChunk(char[] buffer, int index, int count) { }

	// RVA: 0xE53870 Offset: 0xE51E70 VA: 0x180E53870 Slot: 42
	public override string ReadString() { }

	// RVA: 0xE53630 Offset: 0xE51C30 VA: 0x180E53630 Slot: 43
	public override XmlNodeType MoveToContent() { }

	// RVA: 0xE53830 Offset: 0xE51E30 VA: 0x180E53830 Slot: 44
	public override void ReadStartElement() { }

	// RVA: 0xE53770 Offset: 0xE51D70 VA: 0x180E53770 Slot: 45
	public override string ReadElementString() { }

	// RVA: 0xE537B0 Offset: 0xE51DB0 VA: 0x180E537B0 Slot: 46
	public override void ReadEndElement() { }

	// RVA: 0xE534E0 Offset: 0xE51AE0 VA: 0x180E534E0 Slot: 47
	public override bool IsStartElement(string localname, string ns) { }

	// RVA: 0xE537F0 Offset: 0xE51DF0 VA: 0x180E537F0 Slot: 48
	public override string ReadInnerXml() { }

	// RVA: 0xE53C50 Offset: 0xE52250 VA: 0x180E53C50 Slot: 49
	public override bool get_HasAttributes() { }

	// RVA: 0xE533B0 Offset: 0xE519B0 VA: 0x180E533B0 Slot: 50
	protected override void Dispose(bool disposing) { }

	// RVA: 0xE53DD0 Offset: 0xE523D0 VA: 0x180E53DD0 Slot: 51
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0xE53BD0 Offset: 0xE521D0 VA: 0x180E53BD0 Slot: 52
	internal override IDtdInfo get_DtdInfo() { }

}

internal class XmlAsyncCheckReaderWithNS : XmlAsyncCheckReader, IXmlNamespaceResolver // TypeDefIndex: 1874
{	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x20

	// Methods

	// RVA: 0xE53010 Offset: 0xE51610 VA: 0x180E53010
	public void .ctor(XmlReader reader) { }

	// RVA: 0xE52EF0 Offset: 0xE514F0 VA: 0x180E52EF0 Slot: 53
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xE52F50 Offset: 0xE51550 VA: 0x180E52F50 Slot: 54
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0xE52FB0 Offset: 0xE515B0 VA: 0x180E52FB0 Slot: 55
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

internal class XmlAsyncCheckReaderWithLineInfo : XmlAsyncCheckReader, IXmlLineInfo // TypeDefIndex: 1875
{	// Fields
	private readonly IXmlLineInfo readerAsIXmlLineInfo; // 0x20

	// Properties
	public virtual int LineNumber { get; }
	public virtual int LinePosition { get; }

	// Methods

	// RVA: 0xE52DC0 Offset: 0xE513C0 VA: 0x180E52DC0
	public void .ctor(XmlReader reader) { }

	// RVA: 0xE52D70 Offset: 0xE51370 VA: 0x180E52D70 Slot: 56
	public virtual bool HasLineInfo() { }

	// RVA: 0xE52E50 Offset: 0xE51450 VA: 0x180E52E50 Slot: 57
	public virtual int get_LineNumber() { }

	// RVA: 0xE52EA0 Offset: 0xE514A0 VA: 0x180E52EA0 Slot: 58
	public virtual int get_LinePosition() { }

}

internal class XmlAsyncCheckReaderWithLineInfoNS : XmlAsyncCheckReaderWithLineInfo, IXmlNamespaceResolver // TypeDefIndex: 1876
{	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x28

	// Methods

	// RVA: 0xE52C80 Offset: 0xE51280 VA: 0x180E52C80
	public void .ctor(XmlReader reader) { }

	// RVA: 0xE52B60 Offset: 0xE51160 VA: 0x180E52B60 Slot: 59
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xE52BC0 Offset: 0xE511C0 VA: 0x180E52BC0 Slot: 60
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0xE52C20 Offset: 0xE51220 VA: 0x180E52C20 Slot: 61
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

	// RVA: 0xE52AD0 Offset: 0xE510D0 VA: 0x180E52AD0
	public void .ctor(XmlReader reader) { }

	// RVA: 0xE52A80 Offset: 0xE51080 VA: 0x180E52A80 Slot: 62
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0xE527C0 Offset: 0xE50DC0 VA: 0x180E527C0 Slot: 63
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0xE52810 Offset: 0xE50E10 VA: 0x180E52810 Slot: 64
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0xE52860 Offset: 0xE50E60 VA: 0x180E52860 Slot: 65
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0xE52A30 Offset: 0xE51030 VA: 0x180E52A30 Slot: 66
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0xE52970 Offset: 0xE50F70 VA: 0x180E52970 Slot: 67
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0xE528B0 Offset: 0xE50EB0 VA: 0x180E528B0 Slot: 68
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

}

internal class XmlAsyncCheckWriter : XmlWriter // TypeDefIndex: 1878
{	// Fields
	private readonly XmlWriter coreWriter; // 0x18
	private Task lastTask; // 0x20

	// Properties
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0xE54B50 Offset: 0xE53150 VA: 0x180E54B50
	public void .ctor(XmlWriter writer) { }

	// RVA: 0xE54120 Offset: 0xE52720 VA: 0x180E54120
	private void CheckAsync() { }

	// RVA: 0xE54900 Offset: 0xE52F00 VA: 0x180E54900 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0xE54940 Offset: 0xE52F40 VA: 0x180E54940 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0xE54600 Offset: 0xE52C00 VA: 0x180E54600 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0xE54550 Offset: 0xE52B50 VA: 0x180E54550 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xE54990 Offset: 0xE52F90 VA: 0x180E54990 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0xE54640 Offset: 0xE52C40 VA: 0x180E54640 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0xE546D0 Offset: 0xE52CD0 VA: 0x180E546D0 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0xE54890 Offset: 0xE52E90 VA: 0x180E54890 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0xE545C0 Offset: 0xE52BC0 VA: 0x180E545C0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0xE543F0 Offset: 0xE529F0 VA: 0x180E543F0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0xE54500 Offset: 0xE52B00 VA: 0x180E54500 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0xE54770 Offset: 0xE52D70 VA: 0x180E54770 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0xE54680 Offset: 0xE52C80 VA: 0x180E54680 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0xE54440 Offset: 0xE52A40 VA: 0x180E54440 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0xE54B00 Offset: 0xE53100 VA: 0x180E54B00 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0xE54A00 Offset: 0xE53000 VA: 0x180E54A00 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0xE54A50 Offset: 0xE53050 VA: 0x180E54A50 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0xE54490 Offset: 0xE52A90 VA: 0x180E54490 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0xE547D0 Offset: 0xE52DD0 VA: 0x180E547D0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0xE54840 Offset: 0xE52E40 VA: 0x180E54840 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0xE54310 Offset: 0xE52910 VA: 0x180E54310 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0xE54380 Offset: 0xE52980 VA: 0x180E54380 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0xE54BE0 Offset: 0xE531E0 VA: 0x180E54BE0 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0xE541B0 Offset: 0xE527B0 VA: 0x180E541B0 Slot: 28
	public override void Close() { }

	// RVA: 0xE54220 Offset: 0xE52820 VA: 0x180E54220 Slot: 29
	public override void Flush() { }

	// RVA: 0xE54260 Offset: 0xE52860 VA: 0x180E54260 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0xE54AB0 Offset: 0xE530B0 VA: 0x180E54AB0 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0xE542B0 Offset: 0xE528B0 VA: 0x180E542B0 Slot: 32
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0xE54710 Offset: 0xE52D10 VA: 0x180E54710 Slot: 33
	public override void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0xE541F0 Offset: 0xE527F0 VA: 0x180E541F0 Slot: 34
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

	// RVA: 0xE58260 Offset: 0xE56860 VA: 0x180E58260
	private void .ctor(XmlWriterSettings writerSettings) { }

	// RVA: 0xE581E0 Offset: 0xE567E0 VA: 0x180E581E0
	public void .ctor(TextWriter textWriter, XmlWriterSettings writerSettings) { }

	// RVA: 0xE58220 Offset: 0xE56820 VA: 0x180E58220
	public void .ctor(Stream strm, XmlWriterSettings writerSettings) { }

	// RVA: 0xE57A80 Offset: 0xE56080 VA: 0x180E57A80 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xE57DF0 Offset: 0xE563F0 VA: 0x180E57DF0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0xE57D70 Offset: 0xE56370 VA: 0x180E57D70 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0xE57B00 Offset: 0xE56100 VA: 0x180E57B00 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0xE57980 Offset: 0xE55F80 VA: 0x180E57980 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0xE57A30 Offset: 0xE56030 VA: 0x180E57A30 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0xE57C90 Offset: 0xE56290 VA: 0x180E57C90 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0xE580D0 Offset: 0xE566D0 VA: 0x180E580D0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0xE57FB0 Offset: 0xE565B0 VA: 0x180E57FB0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0xBA0B60 Offset: 0xB9F160 VA: 0x180BA0B60 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0xE57D30 Offset: 0xE56330 VA: 0x180E57D30 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0xE57CE0 Offset: 0xE562E0 VA: 0x180E57CE0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0xE57B90 Offset: 0xE56190 VA: 0x180E57B90 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0xE579D0 Offset: 0xE55FD0 VA: 0x180E579D0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0xE58000 Offset: 0xE56600 VA: 0x180E58000 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0xE57880 Offset: 0xE55E80 VA: 0x180E57880 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0xE57900 Offset: 0xE55F00 VA: 0x180E57900 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0xE573E0 Offset: 0xE559E0 VA: 0x180E573E0 Slot: 28
	public override void Close() { }

	// RVA: 0xE57670 Offset: 0xE55C70 VA: 0x180E57670 Slot: 29
	public override void Flush() { }

	// RVA: 0xE58070 Offset: 0xE56670 VA: 0x180E58070 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0xE58350 Offset: 0xE56950 VA: 0x180E58350 Slot: 35
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0xE58180 Offset: 0xE56780 VA: 0x180E58180 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0xE58120 Offset: 0xE56720 VA: 0x180E58120 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0xE577A0 Offset: 0xE55DA0 VA: 0x180E577A0 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0xE57B30 Offset: 0xE56130 VA: 0x180E57B30 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0xE57BF0 Offset: 0xE561F0 VA: 0x180E57BF0 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0xE57C20 Offset: 0xE56220 VA: 0x180E57C20 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0xE58320 Offset: 0xE56920 VA: 0x180E58320 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0xE57F50 Offset: 0xE56550 VA: 0x180E57F50 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0xE57B60 Offset: 0xE56160 VA: 0x180E57B60 Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0xE576C0 Offset: 0xE55CC0 VA: 0x180E576C0
	private static bool IsHtmlTag(string tagName) { }

	// RVA: 0xE57660 Offset: 0xE55C60 VA: 0x180E57660
	private void EnsureWrappedWriter(XmlOutputMethod outMethod) { }

	// RVA: 0xE577D0 Offset: 0xE55DD0 VA: 0x180E577D0
	private bool TextBlockCreatesWriter(string textBlock) { }

	// RVA: 0xE57430 Offset: 0xE55A30 VA: 0x180E57430
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

	// RVA: 0x11C2CD0 Offset: 0x11C12D0 VA: 0x1811C2CD0
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x11C28C0 Offset: 0x11C0EC0 VA: 0x1811C28C0
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x11C29C0 Offset: 0x11C0FC0 VA: 0x1811C29C0
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x11C2650 Offset: 0x11C0C50 VA: 0x1811C2650 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x11C2850 Offset: 0x11C0E50 VA: 0x1811C2850 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x11C0CA0 Offset: 0x11BF2A0 VA: 0x1811C0CA0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x11C20E0 Offset: 0x11C06E0 VA: 0x1811C20E0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11BF640 Offset: 0x11BDC40 VA: 0x1811BF640 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x11C13B0 Offset: 0x11BF9B0 VA: 0x1811C13B0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11C1750 Offset: 0x11BFD50 VA: 0x1811C1750 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11C1F50 Offset: 0x11C0550 VA: 0x1811C1F50 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x11C1340 Offset: 0x11BF940 VA: 0x1811C1340 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x11C18E0 Offset: 0x11BFEE0 VA: 0x1811C18E0 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x11C2200 Offset: 0x11C0800 VA: 0x1811C2200 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x11C15E0 Offset: 0x11BFBE0 VA: 0x1811C15E0 Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x11C00F0 Offset: 0x11BE6F0 VA: 0x1811C00F0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x11C0AC0 Offset: 0x11BF0C0 VA: 0x1811C0AC0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x11C19D0 Offset: 0x11BFFD0 VA: 0x1811C19D0 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x11C1650 Offset: 0x11BFC50 VA: 0x1811C1650 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x11C0410 Offset: 0x11BEA10 VA: 0x1811C0410 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x11C25D0 Offset: 0x11C0BD0 VA: 0x1811C25D0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x11C2390 Offset: 0x11C0990 VA: 0x1811C2390 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x11C2410 Offset: 0x11C0A10 VA: 0x1811C2410 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x11C0640 Offset: 0x11BEC40 VA: 0x1811C0640 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x11C1EC0 Offset: 0x11C04C0 VA: 0x1811C1EC0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x11C1E50 Offset: 0x11C0450 VA: 0x1811C1E50 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x11BE630 Offset: 0x11BCC30 VA: 0x1811BE630 Slot: 28
	public override void Close() { }

	// RVA: 0x11BF130 Offset: 0x11BD730 VA: 0x1811BF130 Slot: 29
	public override void Flush() { }

	// RVA: 0x11BECB0 Offset: 0x11BD2B0 VA: 0x1811BECB0 Slot: 48
	protected virtual void FlushBuffer() { }

	// RVA: 0x11BE9D0 Offset: 0x11BCFD0 VA: 0x1811BE9D0
	private void EncodeChars(int startOffset, int endOffset, bool writeAllToStream) { }

	// RVA: 0x11BF060 Offset: 0x11BD660 VA: 0x1811BF060
	private void FlushEncoder() { }

	// RVA: 0x11BFA10 Offset: 0x11BE010 VA: 0x1811BFA10
	protected void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x11C1000 Offset: 0x11BF600 VA: 0x1811C1000
	protected void WriteElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x11BF440 Offset: 0x11BDA40 VA: 0x1811BF440
	protected void RawText(string s) { }

	// RVA: 0x11BF490 Offset: 0x11BDA90 VA: 0x1811BF490
	protected void RawText(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x11C1B80 Offset: 0x11C0180 VA: 0x1811C1B80
	protected void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x11C06E0 Offset: 0x11BECE0 VA: 0x1811C06E0
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x11BFD20 Offset: 0x11BE320 VA: 0x1811BFD20
	protected void WriteCDataSection(string text) { }

	// RVA: 0x11BEB50 Offset: 0x11BD150 VA: 0x1811BEB50
	private static char* EncodeSurrogate(char* pSrc, char* pSrcEnd, char* pDst) { }

	// RVA: 0x11BF250 Offset: 0x11BD850 VA: 0x1811BF250
	private char* InvalidXmlChar(int ch, char* pDst, bool entitize) { }

	// RVA: 0x11BE8D0 Offset: 0x11BCED0 VA: 0x1811BE8D0
	internal void EncodeChar(ref char* pSrc, char* pSrcEnd, ref char* pDst) { }

	// RVA: 0x11BE490 Offset: 0x11BCA90 VA: 0x1811BE490
	protected void ChangeTextContentMark(bool value) { }

	// RVA: 0x11BF1A0 Offset: 0x11BD7A0 VA: 0x1811BF1A0
	private void GrowTextContentMarks() { }

	// RVA: 0x11C1940 Offset: 0x11BFF40 VA: 0x1811C1940
	protected char* WriteNewLine(char* pDst) { }

	// RVA: 0x11BF3B0 Offset: 0x11BD9B0 VA: 0x1811BF3B0
	protected static char* LtEntity(char* pDst) { }

	// RVA: 0x11BF230 Offset: 0x11BD830 VA: 0x1811BF230
	protected static char* GtEntity(char* pDst) { }

	// RVA: 0x11BE450 Offset: 0x11BCA50 VA: 0x1811BE450
	protected static char* AmpEntity(char* pDst) { }

	// RVA: 0x11BF3D0 Offset: 0x11BD9D0 VA: 0x1811BF3D0
	protected static char* QuoteEntity(char* pDst) { }

	// RVA: 0x11BF690 Offset: 0x11BDC90 VA: 0x1811BF690
	protected static char* TabEntity(char* pDst) { }

	// RVA: 0x11BF390 Offset: 0x11BD990 VA: 0x1811BF390
	protected static char* LineFeedEntity(char* pDst) { }

	// RVA: 0x11BE470 Offset: 0x11BCA70 VA: 0x1811BE470
	protected static char* CarriageReturnEntity(char* pDst) { }

	// RVA: 0x11BE580 Offset: 0x11BCB80 VA: 0x1811BE580
	private static char* CharEntity(char* pDst, char ch) { }

	// RVA: 0x11BF410 Offset: 0x11BDA10 VA: 0x1811BF410
	protected static char* RawStartCData(char* pDst) { }

	// RVA: 0x11BF3F0 Offset: 0x11BD9F0 VA: 0x1811BF3F0
	protected static char* RawEndCData(char* pDst) { }

	// RVA: 0x11BF6B0 Offset: 0x11BDCB0 VA: 0x1811BF6B0
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

	// RVA: 0x11BE350 Offset: 0x11BC950 VA: 0x1811BE350
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x11BE320 Offset: 0x11BC920 VA: 0x1811BE320
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x11BDBC0 Offset: 0x11BC1C0 VA: 0x1811BDBC0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x11BE0B0 Offset: 0x11BC6B0 VA: 0x1811BE0B0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11BDA20 Offset: 0x11BC020 VA: 0x1811BDA20 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x8721B0 Offset: 0x8707B0 VA: 0x1808721B0 Slot: 39
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x11BDC30 Offset: 0x11BC230 VA: 0x1811BDC30 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11BDDC0 Offset: 0x11BC3C0 VA: 0x1811BDDC0 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11BE050 Offset: 0x11BC650 VA: 0x1811BE050 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x11BDAC0 Offset: 0x11BC0C0 VA: 0x1811BDAC0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x11BDB80 Offset: 0x11BC180 VA: 0x1811BDB80 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x11BDEF0 Offset: 0x11BC4F0 VA: 0x1811BDEF0 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x11BDCC0 Offset: 0x11BC2C0 VA: 0x1811BDCC0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x11BDAD0 Offset: 0x11BC0D0 VA: 0x1811BDAD0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x11BE290 Offset: 0x11BC890 VA: 0x1811BE290 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x11BE2A0 Offset: 0x11BC8A0 VA: 0x1811BE2A0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x11BE210 Offset: 0x11BC810 VA: 0x1811BE210 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x11BDAE0 Offset: 0x11BC0E0 VA: 0x1811BDAE0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x11BDF40 Offset: 0x11BC540 VA: 0x1811BDF40 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x11BDFE0 Offset: 0x11BC5E0 VA: 0x1811BDFE0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x11BDAA0 Offset: 0x11BC0A0 VA: 0x1811BDAA0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x11BD910 Offset: 0x11BBF10 VA: 0x1811BD910
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x11BDE50 Offset: 0x11BC450 VA: 0x1811BDE50
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

	// RVA: 0x11C5420 Offset: 0x11C3A20 VA: 0x1811C5420
	public void .ctor(string baseUri, bool hasRootNode) { }

	// RVA: 0x11C3E30 Offset: 0x11C2430 VA: 0x1811C3E30
	public void EndEvents() { }

	// RVA: 0x11C3E80 Offset: 0x11C2480 VA: 0x1811C3E80
	public void EventsToWriter(XmlWriter writer) { }

	// RVA: 0x11C4DD0 Offset: 0x11C33D0 VA: 0x1811C4DD0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x11C50F0 Offset: 0x11C36F0 VA: 0x1811C50F0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11C50C0 Offset: 0x11C36C0 VA: 0x1811C50C0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x11C4E80 Offset: 0x11C3480 VA: 0x1811C4E80 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x11C4C50 Offset: 0x11C3250 VA: 0x1811C4C50 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x11C4D60 Offset: 0x11C3360 VA: 0x1811C4D60 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x11C5020 Offset: 0x11C3620 VA: 0x1811C5020 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x11C52A0 Offset: 0x11C38A0 VA: 0x1811C52A0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x11C5120 Offset: 0x11C3720 VA: 0x1811C5120 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0xBA0B60 Offset: 0xB9F160 VA: 0x180BA0B60 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0xE57D30 Offset: 0xE56330 VA: 0x180E57D30 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x11C5050 Offset: 0x11C3650 VA: 0x1811C5050 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x11C4F50 Offset: 0x11C3550 VA: 0x1811C4F50 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x11C4CC0 Offset: 0x11C32C0 VA: 0x1811C4CC0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x11C51B0 Offset: 0x11C37B0 VA: 0x1811C51B0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x11C4A30 Offset: 0x11C3030 VA: 0x1811C4A30 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x11C4B40 Offset: 0x11C3140 VA: 0x1811C4B40 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x11C3CF0 Offset: 0x11C22F0 VA: 0x1811C3CF0 Slot: 28
	public override void Close() { }

	// RVA: 0x11C4750 Offset: 0x11C2D50 VA: 0x1811C4750 Slot: 29
	public override void Flush() { }

	// RVA: 0xAEEC60 Offset: 0xAED260 VA: 0x180AEEC60 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0x11C3D40 Offset: 0x11C2340 VA: 0x1811C3D40 Slot: 34
	protected override void Dispose(bool disposing) { }

	// RVA: 0x11C5380 Offset: 0x11C3980 VA: 0x1811C5380 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x11C5310 Offset: 0x11C3910 VA: 0x1811C5310 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x11C4920 Offset: 0x11C2F20 VA: 0x1811C4920 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x11C4F20 Offset: 0x11C3520 VA: 0x1811C4F20 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11C4FC0 Offset: 0x11C35C0 VA: 0x1811C4FC0 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11C4FF0 Offset: 0x11C35F0 VA: 0x1811C4FF0 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x11C4ED0 Offset: 0x11C34D0 VA: 0x1811C4ED0 Slot: 46
	internal override void WriteEndBase64() { }

	// RVA: 0x11C3BA0 Offset: 0x11C21A0 VA: 0x1811C3BA0
	private void AddEvent(XmlEventCache.XmlEventType eventType) { }

	// RVA: 0x11C3C80 Offset: 0x11C2280 VA: 0x1811C3C80
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1) { }

	// RVA: 0x11C3BF0 Offset: 0x11C21F0 VA: 0x1811C3BF0
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2) { }

	// RVA: 0x11C3A50 Offset: 0x11C2050 VA: 0x1811C3A50
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3) { }

	// RVA: 0x11C3AF0 Offset: 0x11C20F0 VA: 0x1811C3AF0
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o) { }

	// RVA: 0x11C39E0 Offset: 0x11C1FE0 VA: 0x1811C39E0
	private void AddEvent(XmlEventCache.XmlEventType eventType, object o) { }

	// RVA: 0x11C47A0 Offset: 0x11C2DA0 VA: 0x1811C47A0
	private int NewEvent() { }

	// RVA: 0x11C4970 Offset: 0x11C2F70 VA: 0x1811C4970
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

	// RVA: 0xF38D0 Offset: 0xF2CD0 VA: 0x1800F38D0
	public void InitEvent(XmlEventCache.XmlEventType eventType) { }

	// RVA: 0xFCB60 Offset: 0xFBF60 VA: 0x1800FCB60
	public void InitEvent(XmlEventCache.XmlEventType eventType, string s1) { }

	// RVA: 0x1D0E70 Offset: 0x1D0270 VA: 0x1801D0E70
	public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2) { }

	// RVA: 0xF2910 Offset: 0xF1D10 VA: 0x1800F2910
	public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3) { }

	// RVA: 0x1D0DF0 Offset: 0x1D01F0 VA: 0x1801D0DF0
	public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o) { }

	// RVA: 0x1D0E50 Offset: 0x1D0250 VA: 0x1801D0E50
	public void InitEvent(XmlEventCache.XmlEventType eventType, object o) { }

	// RVA: 0xF37A0 Offset: 0xF2BA0 VA: 0x1800F37A0
	public XmlEventCache.XmlEventType get_EventType() { }

	// RVA: 0xF3F40 Offset: 0xF3340 VA: 0x1800F3F40
	public string get_String1() { }

	// RVA: 0xF3F60 Offset: 0xF3360 VA: 0x1800F3F60
	public string get_String2() { }

	// RVA: 0xF3F70 Offset: 0xF3370 VA: 0x1800F3F70
	public string get_String3() { }

	// RVA: 0xF37B0 Offset: 0xF2BB0 VA: 0x1800F37B0
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

	// RVA: 0xB9F3E0 Offset: 0xB9D9E0 VA: 0x180B9F3E0
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0xB9F760 Offset: 0xB9DD60 VA: 0x180B9F760
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0xB9F490 Offset: 0xB9DA90 VA: 0x180B9F490
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public XmlNameTable get_NameTable() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_DocTypeName() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
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

	// RVA: 0xB9F7D0 Offset: 0xB9DDD0 VA: 0x180B9F7D0
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

	// RVA: 0xBA0E60 Offset: 0xB9F460 VA: 0x180BA0E60 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0xBA0DF0 Offset: 0xB9F3F0 VA: 0x180BA0DF0 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0xBA0BC0 Offset: 0xB9F1C0 VA: 0x180BA0BC0 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xBA0C30 Offset: 0xB9F230 VA: 0x180BA0C30 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0xBA0CF0 Offset: 0xB9F2F0 VA: 0x180BA0CF0 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0xBA0A10 Offset: 0xB9F010 VA: 0x180BA0A10 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0xBA0930 Offset: 0xB9EF30 VA: 0x180BA0930 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0xBA0FE0 Offset: 0xB9F5E0 VA: 0x180BA0FE0 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0xAEEC60 Offset: 0xAED260 VA: 0x180AEEC60 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0xBA0AD0 Offset: 0xB9F0D0 VA: 0x180BA0AD0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0xBA0F20 Offset: 0xB9F520 VA: 0x180BA0F20 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0xAEEC60 Offset: 0xAED260 VA: 0x180AEEC60 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0xBA0B60 Offset: 0xB9F160 VA: 0x180BA0B60 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0xBA0B60 Offset: 0xB9F160 VA: 0x180BA0B60 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0xAEEC60 Offset: 0xAED260 VA: 0x180AEEC60 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0xAEEC60 Offset: 0xAED260 VA: 0x180AEEC60 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0xBA09A0 Offset: 0xB9EFA0 VA: 0x180BA09A0 Slot: 32
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0xBA0D80 Offset: 0xB9F380 VA: 0x180BA0D80 Slot: 33
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

	// RVA: 0xBA0D60 Offset: 0xB9F360 VA: 0x180BA0D60 Slot: 41
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: -1 Offset: -1 Slot: 42
	internal abstract void WriteNamespaceDeclaration(string prefix, string ns);

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 43
	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0xBA0ED0 Offset: 0xB9F4D0 VA: 0x180BA0ED0 Slot: 44
	internal virtual void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0xBA0CA0 Offset: 0xB9F2A0 VA: 0x180BA0CA0 Slot: 45
	internal virtual void WriteEndNamespaceDeclaration() { }

	// RVA: 0xBA0BA0 Offset: 0xB9F1A0 VA: 0x180BA0BA0 Slot: 46
	internal virtual void WriteEndBase64() { }

	// RVA: 0xBA0910 Offset: 0xB9EF10 VA: 0x180BA0910 Slot: 47
	internal virtual void Close(WriteState currentState) { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
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

	// RVA: 0xBA4240 Offset: 0xBA2840 VA: 0x180BA4240 Slot: 7
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

	// RVA: 0xBA4340 Offset: 0xBA2940 VA: 0x180BA4340 Slot: 16
	public virtual char get_QuoteChar() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 17
	public virtual XmlSpace get_XmlSpace() { }

	// RVA: 0xBA43F0 Offset: 0xBA29F0 VA: 0x180BA43F0 Slot: 18
	public virtual string get_XmlLang() { }

	// RVA: 0xBA4350 Offset: 0xBA2950 VA: 0x180BA4350 Slot: 19
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xBA4390 Offset: 0xBA2990 VA: 0x180BA4390 Slot: 20
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

	// RVA: 0xBA2B40 Offset: 0xBA1140 VA: 0x180BA2B40 Slot: 26
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

	// RVA: 0xBA3A00 Offset: 0xBA2000 VA: 0x180BA3A00 Slot: 35
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

	// RVA: 0xBA37A0 Offset: 0xBA1DA0 VA: 0x180BA37A0 Slot: 41
	public virtual int ReadValueChunk(char[] buffer, int index, int count) { }

	[EditorBrowsableAttribute] // RVA: 0x7D6F0 Offset: 0x7CAF0 VA: 0x18007D6F0
	// RVA: 0xBA3580 Offset: 0xBA1B80 VA: 0x180BA3580 Slot: 42
	public virtual string ReadString() { }

	// RVA: 0xBA2C10 Offset: 0xBA1210 VA: 0x180BA2C10 Slot: 43
	public virtual XmlNodeType MoveToContent() { }

	// RVA: 0xBA3480 Offset: 0xBA1A80 VA: 0x180BA3480 Slot: 44
	public virtual void ReadStartElement() { }

	[EditorBrowsableAttribute] // RVA: 0x7D6F0 Offset: 0x7CAF0 VA: 0x18007D6F0
	// RVA: 0xBA2CA0 Offset: 0xBA12A0 VA: 0x180BA2CA0 Slot: 45
	public virtual string ReadElementString() { }

	// RVA: 0xBA2F20 Offset: 0xBA1520 VA: 0x180BA2F20 Slot: 46
	public virtual void ReadEndElement() { }

	// RVA: 0xBA2A20 Offset: 0xBA1020 VA: 0x180BA2A20 Slot: 47
	public virtual bool IsStartElement(string localname, string ns) { }

	// RVA: 0xBA3020 Offset: 0xBA1620 VA: 0x180BA3020 Slot: 48
	public virtual string ReadInnerXml() { }

	// RVA: 0xBA3C00 Offset: 0xBA2200 VA: 0x180BA3C00
	private void WriteNode(XmlWriter xtw, bool defattr) { }

	// RVA: 0xBA3AF0 Offset: 0xBA20F0 VA: 0x180BA3AF0
	private void WriteAttributeValue(XmlWriter xtw) { }

	// RVA: 0xBA25D0 Offset: 0xBA0BD0 VA: 0x180BA25D0
	private XmlWriter CreateWriterForInnerOuterXml(StringWriter sw) { }

	// RVA: 0xBA3810 Offset: 0xBA1E10 VA: 0x180BA3810
	private void SetNamespacesFlag(XmlTextWriter xtw) { }

	// RVA: 0xBA41A0 Offset: 0xBA27A0 VA: 0x180BA41A0 Slot: 49
	public virtual bool get_HasAttributes() { }

	// RVA: 0xBA2940 Offset: 0xBA0F40 VA: 0x180BA2940 Slot: 4
	public void Dispose() { }

	// RVA: 0xBA2960 Offset: 0xBA0F60 VA: 0x180BA2960 Slot: 50
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 51
	internal virtual XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0xBA2AC0 Offset: 0xBA10C0 VA: 0x180BA2AC0
	internal static bool IsTextualNode(XmlNodeType nodeType) { }

	// RVA: 0xBA29A0 Offset: 0xBA0FA0 VA: 0x180BA29A0
	internal static bool HasValueInternal(XmlNodeType nodeType) { }

	// RVA: 0xBA3920 Offset: 0xBA1F20 VA: 0x180BA3920
	private bool SkipSubtree() { }

	// RVA: 0xBA41C0 Offset: 0xBA27C0 VA: 0x180BA41C0
	internal bool get_IsDefaultInternal() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 52
	internal virtual IDtdInfo get_DtdInfo() { }

	// RVA: 0xBA2710 Offset: 0xBA0D10 VA: 0x180BA2710
	public static XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0xBA28B0 Offset: 0xBA0EB0 VA: 0x180BA28B0
	public static XmlReader Create(TextReader input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0xBA22A0 Offset: 0xBA08A0 VA: 0x180BA22A0
	internal static XmlReader CreateSqlReader(Stream input, XmlReaderSettings settings, XmlParserContext inputContext) { }

	// RVA: 0xBA2210 Offset: 0xBA0810 VA: 0x180BA2210
	internal static int CalcBufferSize(Stream input) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0xBA4130 Offset: 0xBA2730 VA: 0x180BA4130
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0xBA19B0 Offset: 0xB9FFB0 VA: 0x180BA19B0
	public void .ctor() { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_Async() { }

	// RVA: 0xBA1B30 Offset: 0xBA0130 VA: 0x180BA1B30
	public void set_Async(bool value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public XmlNameTable get_NameTable() { }

	// RVA: 0xBA1FE0 Offset: 0xBA05E0 VA: 0x180BA1FE0
	public void set_NameTable(XmlNameTable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xBA1AB0 Offset: 0xBA00B0 VA: 0x180BA1AB0
	internal bool get_IsXmlResolverSet() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xBA1E10 Offset: 0xBA0410 VA: 0x180BA1E10
	internal void set_IsXmlResolverSet(bool value) { }

	// RVA: 0xBA21B0 Offset: 0xBA07B0 VA: 0x180BA21B0
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal XmlResolver GetXmlResolver() { }

	// RVA: 0xBA17F0 Offset: 0xB9FDF0 VA: 0x180BA17F0
	internal XmlResolver GetXmlResolver_CheckConfig() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public int get_LineNumberOffset() { }

	// RVA: 0xBA1E20 Offset: 0xBA0420 VA: 0x180BA1E20
	public void set_LineNumberOffset(int value) { }

	// RVA: 0x5DE3B0 Offset: 0x5DC9B0 VA: 0x1805DE3B0
	public int get_LinePositionOffset() { }

	// RVA: 0xBA1E70 Offset: 0xBA0470 VA: 0x180BA1E70
	public void set_LinePositionOffset(int value) { }

	// RVA: 0xA38CE0 Offset: 0xA372E0 VA: 0x180A38CE0
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0xBA1C20 Offset: 0xBA0220 VA: 0x180BA1C20
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0xBA1A80 Offset: 0xBA0080 VA: 0x180BA1A80
	public bool get_CheckCharacters() { }

	// RVA: 0xBA1B80 Offset: 0xBA0180 VA: 0x180BA1B80
	public void set_CheckCharacters(bool value) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public long get_MaxCharactersInDocument() { }

	// RVA: 0xBA1F50 Offset: 0xBA0550 VA: 0x180BA1F50
	public void set_MaxCharactersInDocument(long value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public long get_MaxCharactersFromEntities() { }

	// RVA: 0xBA1EC0 Offset: 0xBA04C0 VA: 0x180BA1EC0
	public void set_MaxCharactersFromEntities(long value) { }

	// RVA: 0x4BC3E0 Offset: 0x4BA9E0 VA: 0x1804BC3E0
	public bool get_IgnoreWhitespace() { }

	// RVA: 0xBA1DC0 Offset: 0xBA03C0 VA: 0x180BA1DC0
	public void set_IgnoreWhitespace(bool value) { }

	// RVA: 0xBA1AA0 Offset: 0xBA00A0 VA: 0x180BA1AA0
	public bool get_IgnoreProcessingInstructions() { }

	// RVA: 0xBA1D70 Offset: 0xBA0370 VA: 0x180BA1D70
	public void set_IgnoreProcessingInstructions(bool value) { }

	// RVA: 0xBA1A90 Offset: 0xBA0090 VA: 0x180BA1A90
	public bool get_IgnoreComments() { }

	// RVA: 0xBA1D20 Offset: 0xBA0320 VA: 0x180BA1D20
	public void set_IgnoreComments(bool value) { }

	// RVA: 0x599D40 Offset: 0x598340 VA: 0x180599D40
	public DtdProcessing get_DtdProcessing() { }

	// RVA: 0xBA1CA0 Offset: 0xBA02A0 VA: 0x180BA1CA0
	public void set_DtdProcessing(DtdProcessing value) { }

	// RVA: 0x82CA00 Offset: 0x82B000 VA: 0x18082CA00
	public bool get_CloseInput() { }

	// RVA: 0xBA1BD0 Offset: 0xBA01D0 VA: 0x180BA1BD0
	public void set_CloseInput(bool value) { }

	// RVA: 0x8D8F00 Offset: 0x8D7500 VA: 0x1808D8F00
	public ValidationType get_ValidationType() { }

	// RVA: 0xBA2130 Offset: 0xBA0730 VA: 0x180BA2130
	public void set_ValidationType(ValidationType value) { }

	// RVA: 0x5DE920 Offset: 0x5DCF20 VA: 0x1805DE920
	public XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0xBA20B0 Offset: 0xBA06B0 VA: 0x180BA20B0
	public void set_ValidationFlags(XmlSchemaValidationFlags value) { }

	// RVA: 0xBA1AC0 Offset: 0xBA00C0 VA: 0x180BA1AC0
	public XmlSchemaSet get_Schemas() { }

	// RVA: 0xBA2050 Offset: 0xBA0650 VA: 0x180BA2050
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0xBA1230 Offset: 0xB9F830 VA: 0x180BA1230
	public XmlReaderSettings Clone() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0xBA1370 Offset: 0xB9F970 VA: 0x180BA1370
	internal XmlReader CreateReader(Stream input, Uri baseUri, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0xBA14F0 Offset: 0xB9FAF0 VA: 0x180BA14F0
	internal XmlReader CreateReader(TextReader input, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0xBA2040 Offset: 0xBA0640 VA: 0x180BA2040
	internal void set_ReadOnly(bool value) { }

	// RVA: 0xBA1180 Offset: 0xB9F780 VA: 0x180BA1180
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0xBA18F0 Offset: 0xB9FEF0 VA: 0x180BA18F0
	private void Initialize() { }

	// RVA: 0xBA1820 Offset: 0xB9FE20 VA: 0x180BA1820
	private void Initialize(XmlResolver resolver) { }

	// RVA: 0xBA1290 Offset: 0xB9F890 VA: 0x180BA1290
	private static XmlResolver CreateDefaultResolver() { }

	// RVA: 0xBA1050 Offset: 0xB9F650 VA: 0x180BA1050
	internal XmlReader AddValidation(XmlReader reader) { }

	// RVA: 0xBA12E0 Offset: 0xB9F8E0 VA: 0x180BA12E0
	private XmlValidatingReaderImpl CreateDtdValidatingReader(XmlReader baseReader) { }

	// RVA: 0xBA16E0 Offset: 0xB9FCE0 VA: 0x180BA16E0
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

	// RVA: 0xBB20C0 Offset: 0xBB06C0 VA: 0x180BB20C0
	internal void .ctor(TextWriter textWriter) { }

	// RVA: 0xBB2180 Offset: 0xBB0780 VA: 0x180BB2180
	internal void set_QuoteChar(char value) { }

	// RVA: 0xBB0B00 Offset: 0xBAF100 VA: 0x180BB0B00
	internal void StartAttribute(bool cacheAttrValue) { }

	// RVA: 0xBB0AC0 Offset: 0xBAF0C0 VA: 0x180BB0AC0
	internal void EndAttribute() { }

	// RVA: 0xBB2110 Offset: 0xBB0710 VA: 0x180BB2110
	internal string get_AttributeValue() { }

	// RVA: 0xBB14B0 Offset: 0xBAFAB0 VA: 0x180BB14B0
	internal void WriteSurrogateChar(char lowChar, char highChar) { }

	// RVA: 0xBB1590 Offset: 0xBAFB90 VA: 0x180BB1590
	internal void Write(char[] array, int offset, int count) { }

	// RVA: 0xBB1330 Offset: 0xBAF930 VA: 0x180BB1330
	internal void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0xBB1A90 Offset: 0xBB0090 VA: 0x180BB1A90
	internal void Write(string text) { }

	// RVA: 0xBB0EB0 Offset: 0xBAF4B0 VA: 0x180BB0EB0
	internal void WriteRawWithSurrogateChecking(string text) { }

	// RVA: 0xBB10D0 Offset: 0xBAF6D0 VA: 0x180BB10D0
	internal void WriteRaw(char[] array, int offset, int count) { }

	// RVA: 0xBB0CA0 Offset: 0xBAF2A0 VA: 0x180BB0CA0
	internal void WriteCharEntity(char ch) { }

	// RVA: 0xBB0E30 Offset: 0xBAF430 VA: 0x180BB0E30
	internal void WriteEntityRef(string name) { }

	// RVA: 0xBB1270 Offset: 0xBAF870 VA: 0x180BB1270
	private void WriteStringFragment(string str, int offset, int count, char[] helperBuffer) { }

	// RVA: 0xBB0C30 Offset: 0xBAF230 VA: 0x180BB0C30
	private void WriteCharEntityImpl(char ch) { }

	// RVA: 0xBB0B90 Offset: 0xBAF190 VA: 0x180BB0B90
	private void WriteCharEntityImpl(string strVal) { }

	// RVA: 0xBB0DB0 Offset: 0xBAF3B0 VA: 0x180BB0DB0
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

	// RVA: 0xBC87F0 Offset: 0xBC6DF0 VA: 0x180BC87F0
	public void .ctor(Stream input) { }

	// RVA: 0xBC8610 Offset: 0xBC6C10 VA: 0x180BC8610
	public void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0xBC84F0 Offset: 0xBC6AF0 VA: 0x180BC84F0
	public void .ctor(TextReader input) { }

	// RVA: 0xBC86F0 Offset: 0xBC6CF0 VA: 0x180BC86F0
	public void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0xB18EF0 Offset: 0xB174F0 VA: 0x180B18EF0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC8AF0 Offset: 0xBC70F0 VA: 0x180BC8AF0 Slot: 7
	public override string get_Name() { }

	// RVA: 0xBC8A90 Offset: 0xBC7090 VA: 0x180BC8A90 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0xBC8B50 Offset: 0xBC7150 VA: 0x180BC8B50 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0xBC8BC0 Offset: 0xBC71C0 VA: 0x180BC8BC0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xBC8C20 Offset: 0xBC7220 VA: 0x180BC8C20 Slot: 11
	public override string get_Value() { }

	// RVA: 0xBC8940 Offset: 0xBC6F40 VA: 0x180BC8940 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xBC8910 Offset: 0xBC6F10 VA: 0x180BC8910 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBC8A00 Offset: 0xBC7000 VA: 0x180BC8A00 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xBC89D0 Offset: 0xBC6FD0 VA: 0x180BC89D0 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xBC8BF0 Offset: 0xBC71F0 VA: 0x180BC8BF0 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xBC8C80 Offset: 0xBC7280 VA: 0x180BC8C80 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBC8C50 Offset: 0xBC7250 VA: 0x180BC8C50 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0xB19040 Offset: 0xB17640 VA: 0x180B19040 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xBC8190 Offset: 0xBC6790 VA: 0x180BC8190 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xBC81C0 Offset: 0xBC67C0 VA: 0x180BC81C0 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0xBC81F0 Offset: 0xBC67F0 VA: 0x180BC81F0 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xBC8290 Offset: 0xBC6890 VA: 0x180BC8290 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xBC8260 Offset: 0xBC6860 VA: 0x180BC8260 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0xBC82F0 Offset: 0xBC68F0 VA: 0x180BC82F0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xBC8320 Offset: 0xBC6920 VA: 0x180BC8320 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0xBC82C0 Offset: 0xBC68C0 VA: 0x180BC82C0 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0xBC8350 Offset: 0xBC6950 VA: 0x180BC8350 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0xBC83B0 Offset: 0xBC69B0 VA: 0x180BC83B0 Slot: 31
	public override bool Read() { }

	// RVA: 0xBC89A0 Offset: 0xBC6FA0 VA: 0x180BC89A0 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0xB9EE40 Offset: 0xB9D440 VA: 0x180B9EE40 Slot: 33
	public override void Close() { }

	// RVA: 0xB9EEB0 Offset: 0xB9D4B0 VA: 0x180B9EEB0 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xBC8410 Offset: 0xBC6A10 VA: 0x180BC8410 Slot: 35
	public override void Skip() { }

	// RVA: 0xBC8AC0 Offset: 0xBC70C0 VA: 0x180BC8AC0 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xBC8220 Offset: 0xBC6820 VA: 0x180BC8220 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0xBC83E0 Offset: 0xBC69E0 VA: 0x180BC83E0 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0xBC8380 Offset: 0xBC6980 VA: 0x180BC8380 Slot: 42
	public override string ReadString() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 53
	public bool HasLineInfo() { }

	// RVA: 0xBC8A30 Offset: 0xBC7030 VA: 0x180BC8A30 Slot: 54
	public int get_LineNumber() { }

	// RVA: 0xBC8A60 Offset: 0xBC7060 VA: 0x180BC8A60 Slot: 55
	public int get_LinePosition() { }

	// RVA: 0xBC8440 Offset: 0xBC6A40 VA: 0x180BC8440 Slot: 56
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xBC8480 Offset: 0xBC6A80 VA: 0x180BC8480 Slot: 57
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0xBC84B0 Offset: 0xBC6AB0 VA: 0x180BC84B0 Slot: 58
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0xBC8B80 Offset: 0xBC7180 VA: 0x180BC8B80
	public bool get_Namespaces() { }

	// RVA: 0xBC8BA0 Offset: 0xBC71A0 VA: 0x180BC8BA0
	public bool get_Normalization() { }

	// RVA: 0xBC8D50 Offset: 0xBC7350 VA: 0x180BC8D50
	public void set_Normalization(bool value) { }

	// RVA: 0xBC8E10 Offset: 0xBC7410 VA: 0x180BC8E10
	public void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0xBC8CB0 Offset: 0xBC72B0 VA: 0x180BC8CB0
	public void set_EntityHandling(EntityHandling value) { }

	// RVA: 0xBC8EF0 Offset: 0xBC74F0 VA: 0x180BC8EF0
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal XmlTextReaderImpl get_Impl() { }

	// RVA: 0xBC8B20 Offset: 0xBC7120 VA: 0x180BC8B20 Slot: 51
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0xBC8FA0 Offset: 0xBC75A0 VA: 0x180BC8FA0
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0xBC8970 Offset: 0xBC6F70 VA: 0x180BC8970 Slot: 52
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

	// RVA: 0xBC5D70 Offset: 0xBC4370 VA: 0x180BC5D70
	internal void .ctor(XmlNameTable nt) { }

	// RVA: 0xBC6740 Offset: 0xBC4D40 VA: 0x180BC6740
	private void .ctor(XmlResolver resolver, XmlReaderSettings settings, XmlParserContext context) { }

	// RVA: 0xBC6340 Offset: 0xBC4940 VA: 0x180BC6340
	internal void .ctor(Stream input) { }

	// RVA: 0xBC6510 Offset: 0xBC4B10 VA: 0x180BC6510
	internal void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0xBC62B0 Offset: 0xBC48B0 VA: 0x180BC62B0
	internal void .ctor(TextReader input) { }

	// RVA: 0xBC6C70 Offset: 0xBC5270 VA: 0x180BC6C70
	internal void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0xBC7090 Offset: 0xBC5690 VA: 0x180BC7090
	internal void .ctor(string url, TextReader input, XmlNameTable nt) { }

	// RVA: 0xBC6180 Offset: 0xBC4780 VA: 0x180BC6180
	internal void .ctor(string xmlFragment, XmlNodeType fragType, XmlParserContext context) { }

	// RVA: 0xBC6630 Offset: 0xBC4C30 VA: 0x180BC6630
	internal void .ctor(string xmlFragment, XmlParserContext context) { }

	// RVA: 0xBB55F0 Offset: 0xBB3BF0 VA: 0x180BB55F0
	private void FinishInitUriString() { }

	// RVA: 0xBC6CE0 Offset: 0xBC52E0 VA: 0x180BC6CE0
	internal void .ctor(Stream stream, byte[] bytes, int byteCount, XmlReaderSettings settings, Uri baseUri, string baseUriStr, XmlParserContext context, bool closeInput) { }

	// RVA: 0xBB5470 Offset: 0xBB3A70 VA: 0x180BB5470
	private void FinishInitStream() { }

	// RVA: 0xBC63D0 Offset: 0xBC49D0 VA: 0x180BC63D0
	internal void .ctor(TextReader input, XmlReaderSettings settings, string baseUriStr, XmlParserContext context) { }

	// RVA: 0xBB5540 Offset: 0xBB3B40 VA: 0x180BB5540
	private void FinishInitTextReader() { }

	// RVA: 0xBC6FD0 Offset: 0xBC55D0 VA: 0x180BC6FD0
	internal void .ctor(string xmlFragment, XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0xBC7560 Offset: 0xBC5B60 VA: 0x180BC7560 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0xBC74E0 Offset: 0xBC5AE0 VA: 0x180BC74E0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC7490 Offset: 0xBC5A90 VA: 0x180BC7490 Slot: 7
	public override string get_Name() { }

	// RVA: 0xBC7470 Offset: 0xBC5A70 VA: 0x180BC7470 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0xBC74C0 Offset: 0xBC5AC0 VA: 0x180BC74C0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0xBC7500 Offset: 0xBC5B00 VA: 0x180BC7500 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xBC7990 Offset: 0xBC5F90 VA: 0x180BC7990 Slot: 11
	public override string get_Value() { }

	// RVA: 0xBC7190 Offset: 0xBC5790 VA: 0x180BC7190 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x7E6DA0 Offset: 0x7E53A0 VA: 0x1807E6DA0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBC7390 Offset: 0xBC5990 VA: 0x180BC7390 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xBC7360 Offset: 0xBC5960 VA: 0x180BC7360 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xBC7520 Offset: 0xBC5B20 VA: 0x180BC7520 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xBC7B20 Offset: 0xBC6120 VA: 0x180BC7B20 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBC7B00 Offset: 0xBC6100 VA: 0x180BC7B00 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0xBC7550 Offset: 0xBC5B50 VA: 0x180BC7550 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xBC72F0 Offset: 0xBC58F0 VA: 0x180BC72F0 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x4EF3A0 Offset: 0x4ED9A0 VA: 0x1804EF3A0 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0xAE2A40 Offset: 0xAE1040 VA: 0x180AE2A40 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xBB61B0 Offset: 0xBB47B0 VA: 0x180BB61B0 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xBB5FF0 Offset: 0xBB45F0 VA: 0x180BB5FF0 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0xBB5F30 Offset: 0xBB4530 VA: 0x180BB5F30 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xBB87F0 Offset: 0xBB6DF0 VA: 0x180BB87F0 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xBB88C0 Offset: 0xBB6EC0 VA: 0x180BB88C0 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0xBB8A40 Offset: 0xBB7040 VA: 0x180BB8A40 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xBB8AD0 Offset: 0xBB70D0 VA: 0x180BB8AD0 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0xBB89A0 Offset: 0xBB6FA0 VA: 0x180BB89A0 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0xBB5940 Offset: 0xBB3F40 VA: 0x180BB5940
	private void FinishInit() { }

	// RVA: 0xBC2610 Offset: 0xBC0C10 VA: 0x180BC2610 Slot: 31
	public override bool Read() { }

	// RVA: 0xBB4250 Offset: 0xBB2850 VA: 0x180BB4250 Slot: 33
	public override void Close() { }

	// RVA: 0xBC44B0 Offset: 0xBC2AB0 VA: 0x180BC44B0 Slot: 35
	public override void Skip() { }

	// RVA: 0xBB86B0 Offset: 0xBB6CB0 VA: 0x180BB86B0 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0xBC18E0 Offset: 0xBBFEE0 VA: 0x180BC18E0 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0xBC2FC0 Offset: 0xBC15C0 VA: 0x180BC2FC0 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0xBC7F20 Offset: 0xBC6520 VA: 0x180BC7F20
	internal void set_OuterReader(XmlReader value) { }

	// RVA: 0xBB8720 Offset: 0xBB6D20 VA: 0x180BB8720
	internal void MoveOffEntityReference() { }

	// RVA: 0xBC20E0 Offset: 0xBC06E0 VA: 0x180BC20E0 Slot: 42
	public override string ReadString() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0xBC2100 Offset: 0xBC0700 VA: 0x180BC2100 Slot: 41
	public override int ReadValueChunk(char[] buffer, int index, int count) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 53
	public bool HasLineInfo() { }

	// RVA: 0xBC7410 Offset: 0xBC5A10 VA: 0x180BC7410 Slot: 54
	public int get_LineNumber() { }

	// RVA: 0xBC7440 Offset: 0xBC5A40 VA: 0x180BC7440 Slot: 55
	public int get_LinePosition() { }

	// RVA: 0xBB6560 Offset: 0xBB4B60 VA: 0x180BB6560 Slot: 56
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xBC4BE0 Offset: 0xBC31E0 VA: 0x180BC4BE0 Slot: 57
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0xBB86F0 Offset: 0xBB6CF0 VA: 0x180BB86F0 Slot: 58
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0xBB6560 Offset: 0xBB4B60 VA: 0x180BB6560
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xBB86F0 Offset: 0xBB6CF0 VA: 0x180BB86F0
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0xBC72C0 Offset: 0xBC58C0 VA: 0x180BC72C0
	internal bool get_Namespaces() { }

	// RVA: 0xBC7C40 Offset: 0xBC6240 VA: 0x180BC7C40
	internal void set_Namespaces(bool value) { }

	// RVA: 0xBC72D0 Offset: 0xBC58D0 VA: 0x180BC72D0
	internal bool get_Normalization() { }

	// RVA: 0xBC7E60 Offset: 0xBC6460 VA: 0x180BC7E60
	internal void set_Normalization(bool value) { }

	// RVA: 0xBC7F40 Offset: 0xBC6540 VA: 0x180BC7F40
	internal void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0xBC7B50 Offset: 0xBC6150 VA: 0x180BC7B50
	internal void set_EntityHandling(EntityHandling value) { }

	// RVA: 0xBC7400 Offset: 0xBC5A00 VA: 0x180BC7400
	internal bool get_IsResolverSet() { }

	// RVA: 0xBC8020 Offset: 0xBC6620 VA: 0x180BC8020
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x4EF3A0 Offset: 0x4ED9A0 VA: 0x1804EF3A0
	internal XmlNameTable get_DtdParserProxy_NameTable() { }

	// RVA: 0xBC72B0 Offset: 0xBC58B0 VA: 0x180BC72B0
	internal IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver() { }

	// RVA: 0xBC7280 Offset: 0xBC5880 VA: 0x180BC7280
	internal bool get_DtdParserProxy_DtdValidation() { }

	// RVA: 0xBC72D0 Offset: 0xBC58D0 VA: 0x180BC72D0
	internal bool get_DtdParserProxy_Normalization() { }

	// RVA: 0xBC72C0 Offset: 0xBC58C0 VA: 0x180BC72C0
	internal bool get_DtdParserProxy_Namespaces() { }

	// RVA: 0xBC72E0 Offset: 0xBC58E0 VA: 0x180BC72E0
	internal bool get_DtdParserProxy_V1CompatibilityMode() { }

	// RVA: 0xBC71B0 Offset: 0xBC57B0 VA: 0x180BC71B0
	internal Uri get_DtdParserProxy_BaseUri() { }

	// RVA: 0x69D600 Offset: 0x69BC00 VA: 0x18069D600
	internal bool get_DtdParserProxy_IsEof() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	internal char[] get_DtdParserProxy_ParsingBuffer() { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40
	internal int get_DtdParserProxy_ParsingBufferLength() { }

	// RVA: 0xA38CE0 Offset: 0xA372E0 VA: 0x180A38CE0
	internal int get_DtdParserProxy_CurrentPosition() { }

	// RVA: 0xA392A0 Offset: 0xA378A0 VA: 0x180A392A0
	internal void set_DtdParserProxy_CurrentPosition(int value) { }

	// RVA: 0xBC7290 Offset: 0xBC5890 VA: 0x180BC7290
	internal int get_DtdParserProxy_EntityStackLength() { }

	// RVA: 0xBC72A0 Offset: 0xBC58A0 VA: 0x180BC72A0
	internal bool get_DtdParserProxy_IsEntityEolNormalized() { }

	// RVA: 0x737EB0 Offset: 0x7364B0 VA: 0x180737EB0
	internal IValidationEventHandling get_DtdParserProxy_ValidationEventHandling() { }

	// RVA: 0xBB4660 Offset: 0xBB2C60 VA: 0x180BB4660
	internal void DtdParserProxy_OnNewLine(int pos) { }

	// RVA: 0x803A70 Offset: 0x802070 VA: 0x180803A70
	internal int get_DtdParserProxy_LineNo() { }

	// RVA: 0xB28BB0 Offset: 0xB271B0 VA: 0x180B28BB0
	internal int get_DtdParserProxy_LineStartPosition() { }

	// RVA: 0xBB4E90 Offset: 0xBB3490 VA: 0x180BB4E90
	internal int DtdParserProxy_ReadData() { }

	// RVA: 0xBB49B0 Offset: 0xBB2FB0 VA: 0x180BB49B0
	internal int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0xBB49A0 Offset: 0xBB2FA0 VA: 0x180BB49A0
	internal int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0xBB4A60 Offset: 0xBB3060 VA: 0x180BB4A60
	internal void DtdParserProxy_ParsePI(StringBuilder sb) { }

	// RVA: 0xBB4830 Offset: 0xBB2E30 VA: 0x180BB4830
	internal void DtdParserProxy_ParseComment(StringBuilder sb) { }

	// RVA: 0xBC73C0 Offset: 0xBC59C0 VA: 0x180BC73C0
	private bool get_IsResolverNull() { }

	// RVA: 0xBB65D0 Offset: 0xBB4BD0 VA: 0x180BB65D0
	private XmlResolver GetTempResolver() { }

	// RVA: 0xBB4BA0 Offset: 0xBB31A0 VA: 0x180BB4BA0
	internal bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, out int entityId) { }

	// RVA: 0xBB4AB0 Offset: 0xBB30B0 VA: 0x180BB4AB0
	internal bool DtdParserProxy_PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	// RVA: 0xBB4C70 Offset: 0xBB3270 VA: 0x180BB4C70
	internal bool DtdParserProxy_PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0xBB4DF0 Offset: 0xBB33F0 VA: 0x180BB4DF0
	internal void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0xBB4EA0 Offset: 0xBB34A0 VA: 0x180BB4EA0
	internal void DtdParserProxy_Throw(Exception e) { }

	// RVA: 0xBB4750 Offset: 0xBB2D50 VA: 0x180BB4750
	internal void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0xBB4670 Offset: 0xBB2C70 VA: 0x180BB4670
	internal void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0xBC5630 Offset: 0xBC3C30 VA: 0x180BC5630
	private void Throw(int pos, string res, string arg) { }

	// RVA: 0xBC59F0 Offset: 0xBC3FF0 VA: 0x180BC59F0
	private void Throw(int pos, string res, string[] args) { }

	// RVA: 0xBC5670 Offset: 0xBC3C70 VA: 0x180BC5670
	private void Throw(int pos, string res) { }

	// RVA: 0xBC5780 Offset: 0xBC3D80 VA: 0x180BC5780
	private void Throw(string res) { }

	// RVA: 0xBC5A30 Offset: 0xBC4030 VA: 0x180BC5A30
	private void Throw(string res, int lineNo, int linePos) { }

	// RVA: 0xBC58A0 Offset: 0xBC3EA0 VA: 0x180BC58A0
	private void Throw(string res, string arg) { }

	// RVA: 0xBC56E0 Offset: 0xBC3CE0 VA: 0x180BC56E0
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0xBC57E0 Offset: 0xBC3DE0 VA: 0x180BC57E0
	private void Throw(string res, string[] args) { }

	// RVA: 0xBC5960 Offset: 0xBC3F60 VA: 0x180BC5960
	private void Throw(string res, string arg, Exception innerException) { }

	// RVA: 0xBC5570 Offset: 0xBC3B70 VA: 0x180BC5570
	private void Throw(string res, string[] args, Exception innerException) { }

	// RVA: 0xBC54B0 Offset: 0xBC3AB0 VA: 0x180BC54B0
	private void Throw(Exception e) { }

	// RVA: 0xBC1830 Offset: 0xBBFE30 VA: 0x180BC1830
	private void ReThrow(Exception e, int lineNo, int linePos) { }

	// RVA: 0xBC52E0 Offset: 0xBC38E0 VA: 0x180BC52E0
	private void ThrowWithoutLineInfo(string res) { }

	// RVA: 0xBC5380 Offset: 0xBC3980 VA: 0x180BC5380
	private void ThrowWithoutLineInfo(string res, string arg) { }

	// RVA: 0xBC5410 Offset: 0xBC3A10 VA: 0x180BC5410
	private void ThrowWithoutLineInfo(string res, string[] args, Exception innerException) { }

	// RVA: 0xBC4C70 Offset: 0xBC3270 VA: 0x180BC4C70
	private void ThrowInvalidChar(char[] data, int length, int invCharPos) { }

	// RVA: 0xBC34E0 Offset: 0xBC1AE0 VA: 0x180BC34E0
	private void SetErrorState() { }

	// RVA: 0xBC3220 Offset: 0xBC1820 VA: 0x180BC3220
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos) { }

	// RVA: 0xBC3360 Offset: 0xBC1960 VA: 0x180BC3360
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception) { }

	// RVA: 0xBC7300 Offset: 0xBC5900 VA: 0x180BC7300
	private bool get_InAttributeValueIterator() { }

	// RVA: 0xBB5190 Offset: 0xBB3790 VA: 0x180BB5190
	private void FinishAttributeValueIterator() { }

	// RVA: 0xBC7280 Offset: 0xBC5880 VA: 0x180BC7280
	private bool get_DtdValidation() { }

	// RVA: 0xBB7E00 Offset: 0xBB6400 VA: 0x180BB7E00
	private void InitStreamInput(Stream stream, Encoding encoding) { }

	// RVA: 0xBB8210 Offset: 0xBB6810 VA: 0x180BB8210
	private void InitStreamInput(string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0xBB8190 Offset: 0xBB6790 VA: 0x180BB8190
	private void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding) { }

	// RVA: 0xBB7DD0 Offset: 0xBB63D0 VA: 0x180BB7DD0
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0xBB7E80 Offset: 0xBB6480 VA: 0x180BB7E80
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, byte[] bytes, int byteCount, Encoding encoding) { }

	// RVA: 0xBB8360 Offset: 0xBB6960 VA: 0x180BB8360
	private void InitTextReaderInput(string baseUriStr, TextReader input) { }

	// RVA: 0xBB8380 Offset: 0xBB6980 VA: 0x180BB8380
	private void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input) { }

	// RVA: 0xBB8240 Offset: 0xBB6840 VA: 0x180BB8240
	private void InitStringInput(string baseUriStr, Encoding originalEncoding, string str) { }

	// RVA: 0xBB7B30 Offset: 0xBB6130 VA: 0x180BB7B30
	private void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment) { }

	// RVA: 0xBC0F50 Offset: 0xBBF550 VA: 0x180BC0F50
	private void ProcessDtdFromParserContext(XmlParserContext context) { }

	// RVA: 0xBB95C0 Offset: 0xBB7BC0 VA: 0x180BB95C0
	private void OpenUrl() { }

	// RVA: 0xBB9470 Offset: 0xBB7A70 VA: 0x180BB9470
	private void OpenUrlDelegate(object xmlResolver) { }

	// RVA: 0xBB4440 Offset: 0xBB2A40 VA: 0x180BB4440
	private Encoding DetectEncoding() { }

	// RVA: 0xBC3500 Offset: 0xBC1B00 VA: 0x180BC3500
	private void SetupEncoding(Encoding encoding) { }

	// RVA: 0xBC4A40 Offset: 0xBC3040 VA: 0x180BC4A40
	private void SwitchEncoding(Encoding newEncoding) { }

	// RVA: 0xBB3FB0 Offset: 0xBB25B0 VA: 0x180BB3FB0
	private Encoding CheckEncoding(string newEncodingName) { }

	// RVA: 0xBC5AF0 Offset: 0xBC40F0 VA: 0x180BC5AF0
	private void UnDecodeChars() { }

	// RVA: 0xBC49D0 Offset: 0xBC2FD0 VA: 0x180BC49D0
	private void SwitchEncodingToUTF8() { }

	// RVA: 0xBC1C50 Offset: 0xBC0250 VA: 0x180BC1C50
	private int ReadData() { }

	// RVA: 0xBB6250 Offset: 0xBB4850 VA: 0x180BB6250
	private int GetChars(int maxCharsCount) { }

	// RVA: 0xBB8470 Offset: 0xBB6A70 VA: 0x180BB8470
	private void InvalidCharRecovery(ref int bytesCount, out int charsCount) { }

	// RVA: 0xBB4350 Offset: 0xBB2950 VA: 0x180BB4350
	internal void Close(bool closeInput) { }

	// RVA: 0xBC3AA0 Offset: 0xBC20A0 VA: 0x180BC3AA0
	private void ShiftBuffer(int sourcePos, int destPos, int count) { }

	// RVA: 0xBBFCC0 Offset: 0xBBE2C0 VA: 0x180BBFCC0
	private bool ParseXmlDeclaration(bool isTextDecl) { }

	// RVA: 0xBBBAD0 Offset: 0xBBA0D0 VA: 0x180BBBAD0
	private bool ParseDocumentContent() { }

	// RVA: 0xBBC470 Offset: 0xBBAA70 VA: 0x180BBC470
	private bool ParseElementContent() { }

	// RVA: 0xBC4F10 Offset: 0xBC3510 VA: 0x180BC4F10
	private void ThrowUnclosedElements() { }

	// RVA: 0xBBC810 Offset: 0xBBAE10 VA: 0x180BBC810
	private void ParseElement() { }

	// RVA: 0xBB2EC0 Offset: 0xBB14C0 VA: 0x180BB2EC0
	private void AddDefaultAttributesAndNormalize() { }

	// RVA: 0xBBCDD0 Offset: 0xBBB3D0 VA: 0x180BBCDD0
	private void ParseEndElement() { }

	// RVA: 0xBC4CE0 Offset: 0xBC32E0 VA: 0x180BC4CE0
	private void ThrowTagMismatch(XmlTextReaderImpl.NodeData startTag) { }

	// RVA: 0xBBAA50 Offset: 0xBB9050 VA: 0x180BBAA50
	private void ParseAttributes() { }

	// RVA: 0xBB5120 Offset: 0xBB3720 VA: 0x180BB5120
	private void ElementNamespaceLookup() { }

	// RVA: 0xBB3EA0 Offset: 0xBB24A0 VA: 0x180BB3EA0
	private void AttributeNamespaceLookup() { }

	// RVA: 0xBB3A70 Offset: 0xBB2070 VA: 0x180BB3A70
	private void AttributeDuplCheck() { }

	// RVA: 0xBB8C90 Offset: 0xBB7290 VA: 0x180BB8C90
	private void OnDefaultNamespaceDecl(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0xBB8EA0 Offset: 0xBB74A0 VA: 0x180BB8EA0
	private void OnNamespaceDecl(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0xBB8FB0 Offset: 0xBB75B0 VA: 0x180BB8FB0
	private void OnXmlReservedAttribute(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0xBB9F80 Offset: 0xBB8580 VA: 0x180BB9F80
	private void ParseAttributeValueSlow(int curPos, char quoteChar, XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0xBB2190 Offset: 0xBB0790 VA: 0x180BB2190
	private void AddAttributeChunkToList(XmlTextReaderImpl.NodeData attr, XmlTextReaderImpl.NodeData chunk, ref XmlTextReaderImpl.NodeData lastChunk) { }

	// RVA: 0xBBF6B0 Offset: 0xBBDCB0 VA: 0x180BBF6B0
	private bool ParseText() { }

	// RVA: 0xBBEEF0 Offset: 0xBBD4F0 VA: 0x180BBEEF0
	private bool ParseText(out int startPos, out int endPos, ref int outOrChars) { }

	// RVA: 0xBB5AD0 Offset: 0xBB40D0 VA: 0x180BB5AD0
	private void FinishPartialValue() { }

	// RVA: 0xBB5990 Offset: 0xBB3F90 VA: 0x180BB5990
	private void FinishOtherValueIterator() { }

	// RVA: 0xBC3E80 Offset: 0xBC2480 VA: 0x180BC3E80
	private void SkipPartialTextValue() { }

	// RVA: 0xBB5E40 Offset: 0xBB4440 VA: 0x180BB5E40
	private void FinishReadValueChunk() { }

	// RVA: 0xBB5C00 Offset: 0xBB4200 VA: 0x180BB5C00
	private void FinishReadContentAsBinary() { }

	// RVA: 0xBB5D50 Offset: 0xBB4350 VA: 0x180BB5D50
	private void FinishReadElementContentAsBinary() { }

	// RVA: 0xBBEC00 Offset: 0xBBD200 VA: 0x180BBEC00
	private bool ParseRootLevelWhitespace() { }

	// RVA: 0xBBD360 Offset: 0xBBB960 VA: 0x180BBD360
	private void ParseEntityReference() { }

	// RVA: 0xBB6880 Offset: 0xBB4E80 VA: 0x180BB6880
	private XmlTextReaderImpl.EntityType HandleEntityReference(bool isInAttributeValue, XmlTextReaderImpl.EntityExpandType expandType, out int charRefEndPos) { }

	// RVA: 0xBB6B20 Offset: 0xBB5120 VA: 0x180BB6B20
	private XmlTextReaderImpl.EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos) { }

	// RVA: 0xBC7320 Offset: 0xBC5920 VA: 0x180BC7320
	private bool get_InEntity() { }

	// RVA: 0xBB66E0 Offset: 0xBB4CE0 VA: 0x180BB66E0
	private bool HandleEntityEnd(bool checkEntityNesting) { }

	// RVA: 0xBC36F0 Offset: 0xBC1CF0 VA: 0x180BC36F0
	private void SetupEndEntityNodeInContent() { }

	// RVA: 0xBC3660 Offset: 0xBC1C60 VA: 0x180BC3660
	private void SetupEndEntityNodeInAttribute() { }

	// RVA: 0xBBE510 Offset: 0xBBCB10 VA: 0x180BBE510
	private bool ParsePI() { }

	// RVA: 0xBBE520 Offset: 0xBBCB20 VA: 0x180BBE520
	private bool ParsePI(StringBuilder piInDtdStringBuilder) { }

	// RVA: 0xBBE140 Offset: 0xBBC740 VA: 0x180BBE140
	private bool ParsePIValue(out int outStartPos, out int outEndPos) { }

	// RVA: 0xBBB7B0 Offset: 0xBB9DB0 VA: 0x180BBB7B0
	private bool ParseComment() { }

	// RVA: 0xBBB710 Offset: 0xBB9D10 VA: 0x180BBB710
	private void ParseCData() { }

	// RVA: 0xBBB0D0 Offset: 0xBB96D0 VA: 0x180BBB0D0
	private void ParseCDataOrComment(XmlNodeType type) { }

	// RVA: 0xBBB2B0 Offset: 0xBB98B0 VA: 0x180BBB2B0
	private bool ParseCDataOrComment(XmlNodeType type, out int outStartPos, out int outEndPos) { }

	// RVA: 0xBBB810 Offset: 0xBB9E10 VA: 0x180BBB810
	private bool ParseDoctypeDecl() { }

	// RVA: 0xBBC1F0 Offset: 0xBBA7F0 VA: 0x180BBC1F0
	private void ParseDtd() { }

	// RVA: 0xBC3AD0 Offset: 0xBC20D0 VA: 0x180BC3AD0
	private void SkipDtd() { }

	// RVA: 0xBC3EE0 Offset: 0xBC24E0 VA: 0x180BC3EE0
	private void SkipPublicOrSystemIdLiteral() { }

	// RVA: 0xBC3F80 Offset: 0xBC2580 VA: 0x180BC3F80
	private void SkipUntil(char stopChar, bool recognizeLiterals) { }

	// RVA: 0xBB4EB0 Offset: 0xBB34B0 VA: 0x180BB4EB0
	private int EatWhitespaces(StringBuilder sb) { }

	// RVA: 0xBBB720 Offset: 0xBB9D20 VA: 0x180BBB720
	private int ParseCharRefInline(int startPos, out int charCount, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0xBBE070 Offset: 0xBBC670 VA: 0x180BBE070
	private int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0xBBD900 Offset: 0xBBBF00 VA: 0x180BBD900
	private int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, out int charCount, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0xBBD880 Offset: 0xBBBE80 VA: 0x180BBD880
	private int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0xBBD4A0 Offset: 0xBBBAA0 VA: 0x180BBD4A0
	private int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0xBBD470 Offset: 0xBBBA70 VA: 0x180BBD470
	private int ParseName() { }

	// RVA: 0xBBE930 Offset: 0xBBCF30 VA: 0x180BBE930
	private int ParseQName(out int colonPos) { }

	// RVA: 0xBBE950 Offset: 0xBBCF50 VA: 0x180BBE950
	private int ParseQName(bool isQName, int startOffset, out int colonPos) { }

	// RVA: 0xBC1C00 Offset: 0xBC0200 VA: 0x180BC1C00
	private bool ReadDataInName(ref int pos) { }

	// RVA: 0xBBD260 Offset: 0xBBB860 VA: 0x180BBD260
	private string ParseEntityName() { }

	// RVA: 0xBB3740 Offset: 0xBB1D40 VA: 0x180BB3740
	private XmlTextReaderImpl.NodeData AddNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0xBB38F0 Offset: 0xBB1EF0 VA: 0x180BB38F0
	private XmlTextReaderImpl.NodeData AllocNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0xBB2200 Offset: 0xBB0800 VA: 0x180BB2200
	private XmlTextReaderImpl.NodeData AddAttributeNoChecks(string name, int attrDepth) { }

	// RVA: 0xBB2290 Offset: 0xBB0890 VA: 0x180BB2290
	private XmlTextReaderImpl.NodeData AddAttribute(int endNamePos, int colonPos) { }

	// RVA: 0xBB24C0 Offset: 0xBB0AC0 VA: 0x180BB24C0
	private XmlTextReaderImpl.NodeData AddAttribute(string localName, string prefix, string nameWPrefix) { }

	// RVA: 0xBC0D40 Offset: 0xBBF340 VA: 0x180BC0D40
	private void PopElementContext() { }

	// RVA: 0xBB4660 Offset: 0xBB2C60 VA: 0x180BB4660
	private void OnNewLine(int pos) { }

	// RVA: 0xBB8DC0 Offset: 0xBB73C0 VA: 0x180BB8DC0
	private void OnEof() { }

	// RVA: 0xBB85D0 Offset: 0xBB6BD0 VA: 0x180BB85D0
	private string LookupNamespace(XmlTextReaderImpl.NodeData node) { }

	// RVA: 0xBB34A0 Offset: 0xBB1AA0 VA: 0x180BB34A0
	private void AddNamespace(string prefix, string uri, XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0xBC2EF0 Offset: 0xBC14F0 VA: 0x180BC2EF0
	private void ResetAttributes() { }

	// RVA: 0xBB5E80 Offset: 0xBB4480 VA: 0x180BB5E80
	private void FullAttributeCleanup() { }

	// RVA: 0xBC1790 Offset: 0xBBFD90 VA: 0x180BC1790
	private void PushXmlContext() { }

	// RVA: 0xBC0F10 Offset: 0xBBF510 VA: 0x180BC0F10
	private void PopXmlContext() { }

	// RVA: 0xBB6690 Offset: 0xBB4C90 VA: 0x180BB6690
	private XmlNodeType GetWhitespaceType() { }

	// RVA: 0xBB6630 Offset: 0xBB4C30 VA: 0x180BB6630
	private XmlNodeType GetTextNodeType(int orChars) { }

	// RVA: 0xBC0FB0 Offset: 0xBBF5B0 VA: 0x180BC0FB0
	private void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName) { }

	// RVA: 0xBB91D0 Offset: 0xBB77D0 VA: 0x180BB91D0
	private bool OpenAndPush(Uri uri) { }

	// RVA: 0xBC12C0 Offset: 0xBBF8C0 VA: 0x180BC12C0
	private bool PushExternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0xBC14C0 Offset: 0xBBFAC0 VA: 0x180BC14C0
	private void PushInternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0xBC0DB0 Offset: 0xBBF3B0 VA: 0x180BC0DB0
	private void PopEntity() { }

	// RVA: 0xBC2D10 Offset: 0xBC1310 VA: 0x180BC2D10
	private void RegisterEntity(IDtdEntityInfo entity) { }

	// RVA: 0xBC5BA0 Offset: 0xBC41A0 VA: 0x180BC5BA0
	private void UnregisterEntity() { }

	// RVA: 0xBC1630 Offset: 0xBBFC30 VA: 0x180BC1630
	private void PushParsingState() { }

	// RVA: 0xBC0E40 Offset: 0xBBF440 VA: 0x180BC0E40
	private void PopParsingState() { }

	// RVA: 0xBB7000 Offset: 0xBB5600 VA: 0x180BB7000
	private int IncrementalRead() { }

	// RVA: 0xBB53E0 Offset: 0xBB39E0 VA: 0x180BB53E0
	private void FinishIncrementalRead() { }

	// RVA: 0xBBD3E0 Offset: 0xBBB9E0 VA: 0x180BBD3E0
	private bool ParseFragmentAttribute() { }

	// RVA: 0xBB98A0 Offset: 0xBB7EA0 VA: 0x180BB98A0
	private bool ParseAttributeValueChunk() { }

	// RVA: 0xBBFC10 Offset: 0xBBE210 VA: 0x180BBFC10
	private void ParseXmlDeclarationFragment() { }

	// RVA: 0xBC52C0 Offset: 0xBC38C0 VA: 0x180BC52C0
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0xBC52B0 Offset: 0xBC38B0 VA: 0x180BC52B0
	private void ThrowUnexpectedToken(string expectedToken1) { }

	// RVA: 0xBC5110 Offset: 0xBC3710 VA: 0x180BC5110
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0xBC5150 Offset: 0xBC3750 VA: 0x180BC5150
	private void ThrowUnexpectedToken(string expectedToken1, string expectedToken2) { }

	// RVA: 0xBBFB10 Offset: 0xBBE110 VA: 0x180BBFB10
	private string ParseUnexpectedToken(int pos) { }

	// RVA: 0xBBFB20 Offset: 0xBBE120 VA: 0x180BBFB20
	private string ParseUnexpectedToken() { }

	// RVA: 0xBC4C00 Offset: 0xBC3200 VA: 0x180BC4C00
	private void ThrowExpectingWhitespace(int pos) { }

	// RVA: 0xBB6440 Offset: 0xBB4A40 VA: 0x180BB6440
	private int GetIndexOfAttributeWithoutPrefix(string name) { }

	// RVA: 0xBB6360 Offset: 0xBB4960 VA: 0x180BB6360
	private int GetIndexOfAttributeWithPrefix(string name) { }

	// RVA: 0xBC5CF0 Offset: 0xBC42F0 VA: 0x180BC5CF0
	private bool ZeroEndingStream(int pos) { }

	// RVA: 0xBBC020 Offset: 0xBBA620 VA: 0x180BBC020
	private void ParseDtdFromParserContext() { }

	// RVA: 0xBB8B80 Offset: 0xBB7180 VA: 0x180BB8B80
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

	// RVA: 0xBC3830 Offset: 0xBC1E30 VA: 0x180BC3830
	private void SetupFromParserContext(XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0x900010 Offset: 0x8FE610 VA: 0x180900010 Slot: 52
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0xBC3420 Offset: 0xBC1A20 VA: 0x180BC3420
	internal void SetDtdInfo(IDtdInfo newDtdInfo) { }

	// RVA: 0xBC7F30 Offset: 0xBC6530 VA: 0x180BC7F30
	internal void set_ValidationEventHandling(IValidationEventHandling value) { }

	// RVA: 0xBC7F10 Offset: 0xBC6510 VA: 0x180BC7F10
	internal void set_OnDefaultAttributeUse(XmlTextReaderImpl.OnDefaultAttributeUseDelegate value) { }

	// RVA: 0xBC80D0 Offset: 0xBC66D0 VA: 0x180BC80D0
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x907030 Offset: 0x905630 VA: 0x180907030
	internal XmlNodeType get_FragmentType() { }

	// RVA: 0xBB3F90 Offset: 0xBB2590 VA: 0x180BB3F90
	internal void ChangeCurrentNodeType(XmlNodeType newNodeType) { }

	// RVA: 0xBB6590 Offset: 0xBB4B90 VA: 0x180BB6590
	internal XmlResolver GetResolver() { }

	// RVA: 0xBC7BE0 Offset: 0xBC61E0 VA: 0x180BC7BE0
	internal void set_InternalSchemaType(object value) { }

	// RVA: 0xBC7330 Offset: 0xBC5930 VA: 0x180BC7330
	internal object get_InternalTypedValue() { }

	// RVA: 0xBC7C10 Offset: 0xBC6210 VA: 0x180BC7C10
	internal void set_InternalTypedValue(object value) { }

	// RVA: 0xBC7980 Offset: 0xBC5F80 VA: 0x180BC7980
	internal bool get_StandAlone() { }

	// RVA: 0xBC72B0 Offset: 0xBC58B0 VA: 0x180BC72B0 Slot: 51
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0xBC72E0 Offset: 0xBC58E0 VA: 0x180BC72E0
	internal bool get_V1Compat() { }

	// RVA: 0xBB2630 Offset: 0xBB0C30 VA: 0x180BB2630
	private bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, XmlTextReaderImpl.NodeData[] nameSortedNodeData) { }

	// RVA: 0xBB2C40 Offset: 0xBB1240 VA: 0x180BB2C40
	internal bool AddDefaultAttributeNonDtd(SchemaAttDef attrDef) { }

	// RVA: 0xBB2970 Offset: 0xBB0F70 VA: 0x180BB2970
	private XmlTextReaderImpl.NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute) { }

	// RVA: 0xBC7B40 Offset: 0xBC6140 VA: 0x180BC7B40
	internal void set_DisableUndeclaredEntityCheck(bool value) { }

	// RVA: 0xBC5C00 Offset: 0xBC4200 VA: 0x180BC5C00
	private bool UriEqual(Uri uri1, string uri1Str, string uri2Str, XmlResolver resolver) { }

	// RVA: 0xBC2C00 Offset: 0xBC1200 VA: 0x180BC2C00
	private void RegisterConsumedCharacters(long characters, bool inEntityReference) { }

	// RVA: 0xBC47F0 Offset: 0xBC2DF0 VA: 0x180BC47F0
	internal static string StripSpaces(string value) { }

	// RVA: 0xBC4690 Offset: 0xBC2C90 VA: 0x180BC4690
	internal static void StripSpaces(char[] value, int index, ref int len) { }

	// RVA: 0xBB3F60 Offset: 0xBB2560 VA: 0x180BB3F60
	internal static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count) { }

	// RVA: 0xBB3F80 Offset: 0xBB2580 VA: 0x180BB3F80
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

	// RVA: 0x13186D0 Offset: 0x1316CD0 VA: 0x1813186D0
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

	// RVA: 0x1E10A0 Offset: 0x1E04A0 VA: 0x1801E10A0
	internal void Clear() { }

	// RVA: 0x1E1180 Offset: 0x1E0580 VA: 0x1801E1180
	internal void Close(bool closeInput) { }

	// RVA: 0x1E0B70 Offset: 0x1DFF70 VA: 0x1801E0B70
	internal int get_LineNo() { }

	// RVA: 0x1E11C0 Offset: 0x1E05C0 VA: 0x1801E11C0
	internal int get_LinePos() { }

}

private class XmlTextReaderImpl.XmlContext // TypeDefIndex: 1901
{	// Fields
	internal XmlSpace xmlSpace; // 0x10
	internal string xmlLang; // 0x18
	internal string defaultNamespace; // 0x20
	internal XmlTextReaderImpl.XmlContext previousContext; // 0x28

	// Methods

	// RVA: 0x13198D0 Offset: 0x1317ED0 VA: 0x1813198D0
	internal void .ctor() { }

	// RVA: 0x1319960 Offset: 0x1317F60 VA: 0x181319960
	internal void .ctor(XmlTextReaderImpl.XmlContext previousContext) { }

}

private class XmlTextReaderImpl.NoNamespaceManager : XmlNamespaceManager // TypeDefIndex: 1902
{	// Properties
	public override string DefaultNamespace { get; }

	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0x13187C0 Offset: 0x1316DC0 VA: 0x1813187C0 Slot: 9
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

	// RVA: 0x1318780 Offset: 0x1316D80 VA: 0x181318780 Slot: 16
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

	// RVA: 0x13185C0 Offset: 0x1316BC0 VA: 0x1813185C0 Slot: 9
	private XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable() { }

	// RVA: 0x13185E0 Offset: 0x1316BE0 VA: 0x1813185E0 Slot: 10
	private IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver() { }

	// RVA: 0x13184E0 Offset: 0x1316AE0 VA: 0x1813184E0 Slot: 11
	private Uri System.Xml.IDtdParserAdapter.get_BaseUri() { }

	// RVA: 0x1318560 Offset: 0x1316B60 VA: 0x181318560 Slot: 18
	private bool System.Xml.IDtdParserAdapter.get_IsEof() { }

	// RVA: 0x1318620 Offset: 0x1316C20 VA: 0x181318620 Slot: 12
	private char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer() { }

	// RVA: 0x1318600 Offset: 0x1316C00 VA: 0x181318600 Slot: 13
	private int System.Xml.IDtdParserAdapter.get_ParsingBufferLength() { }

	// RVA: 0x1318500 Offset: 0x1316B00 VA: 0x181318500 Slot: 14
	private int System.Xml.IDtdParserAdapter.get_CurrentPosition() { }

	// RVA: 0x1318640 Offset: 0x1316C40 VA: 0x181318640 Slot: 15
	private void System.Xml.IDtdParserAdapter.set_CurrentPosition(int value) { }

	// RVA: 0x1318520 Offset: 0x1316B20 VA: 0x181318520 Slot: 19
	private int System.Xml.IDtdParserAdapter.get_EntityStackLength() { }

	// RVA: 0x1318540 Offset: 0x1316B40 VA: 0x181318540 Slot: 20
	private bool System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized() { }

	// RVA: 0x1318320 Offset: 0x1316920 VA: 0x181318320 Slot: 22
	private void System.Xml.IDtdParserAdapter.OnNewLine(int pos) { }

	// RVA: 0x1318580 Offset: 0x1316B80 VA: 0x181318580 Slot: 16
	private int System.Xml.IDtdParserAdapter.get_LineNo() { }

	// RVA: 0x13185A0 Offset: 0x1316BA0 VA: 0x1813185A0 Slot: 17
	private int System.Xml.IDtdParserAdapter.get_LineStartPosition() { }

	// RVA: 0x13184A0 Offset: 0x1316AA0 VA: 0x1813184A0 Slot: 21
	private int System.Xml.IDtdParserAdapter.ReadData() { }

	// RVA: 0x13183E0 Offset: 0x13169E0 VA: 0x1813183E0 Slot: 23
	private int System.Xml.IDtdParserAdapter.ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0x13183C0 Offset: 0x13169C0 VA: 0x1813183C0 Slot: 24
	private int System.Xml.IDtdParserAdapter.ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1318400 Offset: 0x1316A00 VA: 0x181318400 Slot: 25
	private void System.Xml.IDtdParserAdapter.ParsePI(StringBuilder sb) { }

	// RVA: 0x13183A0 Offset: 0x13169A0 VA: 0x1813183A0 Slot: 26
	private void System.Xml.IDtdParserAdapter.ParseComment(StringBuilder sb) { }

	// RVA: 0x1318440 Offset: 0x1316A40 VA: 0x181318440 Slot: 27
	private bool System.Xml.IDtdParserAdapter.PushEntity(IDtdEntityInfo entity, out int entityId) { }

	// RVA: 0x1318420 Offset: 0x1316A20 VA: 0x181318420 Slot: 28
	private bool System.Xml.IDtdParserAdapter.PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	// RVA: 0x1318460 Offset: 0x1316A60 VA: 0x181318460 Slot: 29
	private bool System.Xml.IDtdParserAdapter.PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0x1318480 Offset: 0x1316A80 VA: 0x181318480 Slot: 30
	private void System.Xml.IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0x13184C0 Offset: 0x1316AC0 VA: 0x1813184C0 Slot: 33
	private void System.Xml.IDtdParserAdapter.Throw(Exception e) { }

	// RVA: 0x1318370 Offset: 0x1316970 VA: 0x181318370 Slot: 31
	private void System.Xml.IDtdParserAdapter.OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0x1318340 Offset: 0x1316940 VA: 0x181318340 Slot: 32
	private void System.Xml.IDtdParserAdapter.OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0x13182E0 Offset: 0x13168E0 VA: 0x1813182E0 Slot: 7
	private bool System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation() { }

	// RVA: 0x1318300 Offset: 0x1316900 VA: 0x181318300 Slot: 8
	private IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling() { }

	// RVA: 0xBC8BA0 Offset: 0xBC71A0 VA: 0x180BC8BA0 Slot: 5
	private bool System.Xml.IDtdParserAdapterV1.get_Normalization() { }

	// RVA: 0xBC8B80 Offset: 0xBC7180 VA: 0x180BC8B80 Slot: 6
	private bool System.Xml.IDtdParserAdapterV1.get_Namespaces() { }

	// RVA: 0x13182C0 Offset: 0x13168C0 VA: 0x1813182C0 Slot: 4
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

	// RVA: 0x1319130 Offset: 0x1317730 VA: 0x181319130
	internal static XmlTextReaderImpl.NodeData get_None() { }

	// RVA: 0x1319050 Offset: 0x1317650 VA: 0x181319050
	internal void .ctor() { }

	// RVA: 0x8D8F00 Offset: 0x8D7500 VA: 0x1808D8F00
	internal int get_LineNo() { }

	// RVA: 0x5DE920 Offset: 0x5DCF20 VA: 0x1805DE920
	internal int get_LinePos() { }

	// RVA: 0x1319120 Offset: 0x1317720 VA: 0x181319120
	internal bool get_IsEmptyElement() { }

	// RVA: 0xE69910 Offset: 0xE67F10 VA: 0x180E69910
	internal void set_IsEmptyElement(bool value) { }

	// RVA: 0x1319110 Offset: 0x1317710 VA: 0x181319110
	internal bool get_IsDefaultAttribute() { }

	// RVA: 0xE69910 Offset: 0xE67F10 VA: 0x180E69910
	internal void set_IsDefaultAttribute(bool value) { }

	// RVA: 0x13192C0 Offset: 0x13178C0 VA: 0x1813192C0
	internal bool get_ValueBuffered() { }

	// RVA: 0x1319270 Offset: 0x1317870 VA: 0x181319270
	internal string get_StringValue() { }

	// RVA: 0x1319000 Offset: 0x1317600 VA: 0x181319000
	internal void TrimSpacesInValue() { }

	// RVA: 0x13188A0 Offset: 0x1316EA0 VA: 0x1813188A0
	internal void Clear(XmlNodeType type) { }

	// RVA: 0x1318800 Offset: 0x1316E00 VA: 0x181318800
	internal void ClearName() { }

	// RVA: 0x1318C10 Offset: 0x1317210 VA: 0x181318C10
	internal void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0x1318C00 Offset: 0x1317200 VA: 0x181318C00
	internal void SetLineInfo2(int lineNo, int linePos) { }

	// RVA: 0x1318DE0 Offset: 0x13173E0 VA: 0x181318DE0
	internal void SetValueNode(XmlNodeType type, string value) { }

	// RVA: 0x1318E20 Offset: 0x1317420 VA: 0x181318E20
	internal void SetValueNode(XmlNodeType type, char[] chars, int startPos, int len) { }

	// RVA: 0x1318C20 Offset: 0x1317220 VA: 0x181318C20
	internal void SetNamedNode(XmlNodeType type, string localName) { }

	// RVA: 0x1318D10 Offset: 0x1317310 VA: 0x181318D10
	internal void SetNamedNode(XmlNodeType type, string localName, string prefix, string nameWPrefix) { }

	// RVA: 0x1318EE0 Offset: 0x13174E0 VA: 0x181318EE0
	internal void SetValue(string value) { }

	// RVA: 0x1318E80 Offset: 0x1317480 VA: 0x181318E80
	internal void SetValue(char[] chars, int startPos, int len) { }

	// RVA: 0x1318B90 Offset: 0x1317190 VA: 0x181318B90
	internal void OnBufferInvalidated() { }

	// RVA: 0x13189B0 Offset: 0x1316FB0 VA: 0x1813189B0
	internal void CopyTo(int valueOffset, StringBuilder sb) { }

	// RVA: 0x1318950 Offset: 0x1316F50 VA: 0x181318950
	internal int CopyTo(int valueOffset, char[] buffer, int offset, int length) { }

	// RVA: 0x1318AE0 Offset: 0x13170E0 VA: 0x181318AE0
	internal string GetNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x1318A40 Offset: 0x1317040 VA: 0x181318A40
	internal string CreateNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x1318F00 Offset: 0x1317500 VA: 0x181318F00 Slot: 4
	private int System.IComparable.CompareTo(object obj) { }

}

private class XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer : IComparer<object> // TypeDefIndex: 1905
{	// Fields
	private static IComparer<object> s_instance; // 0x141BD

	// Properties
	internal static IComparer<object> Instance { get; }

	// Methods

	// RVA: 0x1318260 Offset: 0x1316860 VA: 0x181318260
	internal static IComparer<object> get_Instance() { }

	// RVA: 0x1317FA0 Offset: 0x13165A0 VA: 0x181317FA0 Slot: 4
	public int Compare(object x, object y) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1318200 Offset: 0x1316800 VA: 0x181318200
	private static void .cctor() { }

}

internal sealed class XmlTextReaderImpl.OnDefaultAttributeUseDelegate : MulticastDelegate // TypeDefIndex: 1906
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE45C0 Offset: 0xAE2BC0 VA: 0x180AE45C0 Slot: 12
	public virtual void Invoke(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
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

	// RVA: 0x131F0B0 Offset: 0x131D6B0 VA: 0x18131F0B0
	internal void .ctor() { }

	// RVA: 0x131EFB0 Offset: 0x131D5B0 VA: 0x18131EFB0
	public void .ctor(Stream w, Encoding encoding) { }

	// RVA: 0x131EE60 Offset: 0x131D460 VA: 0x18131EE60
	public void .ctor(string filename, Encoding encoding) { }

	// RVA: 0x131ED90 Offset: 0x131D390 VA: 0x18131ED90
	public void .ctor(TextWriter w) { }

	// RVA: 0x131F210 Offset: 0x131D810 VA: 0x18131F210
	public Stream get_BaseStream() { }

	// RVA: 0x131F320 Offset: 0x131D920 VA: 0x18131F320
	public void set_Namespaces(bool value) { }

	// RVA: 0x131F310 Offset: 0x131D910 VA: 0x18131F310
	public void set_Formatting(Formatting value) { }

	// RVA: 0x131F3A0 Offset: 0x131D9A0 VA: 0x18131F3A0
	public void set_QuoteChar(char value) { }

	// RVA: 0x131D7D0 Offset: 0x131BDD0 VA: 0x18131D7D0 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x131D7B0 Offset: 0x131BDB0 VA: 0x18131D7B0 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x131C6D0 Offset: 0x131ACD0 VA: 0x18131C6D0 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x131C2C0 Offset: 0x131A8C0 VA: 0x18131C2C0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x131D7E0 Offset: 0x131BDE0 VA: 0x18131D7E0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x131C850 Offset: 0x131AE50 VA: 0x18131C850 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x131CD60 Offset: 0x131B360 VA: 0x18131CD60 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x131D060 Offset: 0x131B660 VA: 0x18131D060 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x131C650 Offset: 0x131AC50 VA: 0x18131C650 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x131BEA0 Offset: 0x131A4A0 VA: 0x18131BEA0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x131C150 Offset: 0x131A750 VA: 0x18131C150 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x131CD70 Offset: 0x131B370 VA: 0x18131CD70 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x131CCB0 Offset: 0x131B2B0 VA: 0x18131CCB0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x131BFF0 Offset: 0x131A5F0 VA: 0x18131BFF0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x131DEB0 Offset: 0x131C4B0 VA: 0x18131DEB0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x131DD50 Offset: 0x131C350 VA: 0x18131DD50 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x131DE00 Offset: 0x131C400 VA: 0x18131DE00 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x131C090 Offset: 0x131A690 VA: 0x18131C090 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x131CFA0 Offset: 0x131B5A0 VA: 0x18131CFA0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x131CF00 Offset: 0x131B500 VA: 0x18131CF00 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x131BCE0 Offset: 0x131A2E0 VA: 0x18131BCE0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x131BDF0 Offset: 0x131A3F0 VA: 0x18131BDF0 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x131F2A0 Offset: 0x131D8A0 VA: 0x18131F2A0 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x131A2F0 Offset: 0x13188F0 VA: 0x18131A2F0 Slot: 28
	public override void Close() { }

	// RVA: 0x131A550 Offset: 0x1318B50 VA: 0x18131A550 Slot: 29
	public override void Flush() { }

	// RVA: 0x131B080 Offset: 0x1319680 VA: 0x18131B080 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x131B760 Offset: 0x1319D60 VA: 0x18131B760
	private void StartDocument(int standalone) { }

	// RVA: 0x1319D10 Offset: 0x1318310 VA: 0x181319D10
	private void AutoComplete(XmlTextWriter.Token token) { }

	// RVA: 0x1319CC0 Offset: 0x13182C0 VA: 0x181319CC0
	private void AutoCompleteAll() { }

	// RVA: 0x131A990 Offset: 0x1318F90 VA: 0x18131A990
	private void InternalWriteEndElement(bool longFormat) { }

	// RVA: 0x131C860 Offset: 0x131AE60 VA: 0x18131C860
	private void WriteEndStartTag(bool empty) { }

	// RVA: 0x131C600 Offset: 0x131AC00 VA: 0x18131C600
	private void WriteEndAttributeQuote() { }

	// RVA: 0x131A8A0 Offset: 0x1318EA0 VA: 0x18131A8A0
	private void Indent(bool beforeEndElement) { }

	// RVA: 0x131B250 Offset: 0x1319850 VA: 0x18131B250
	private void PushNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x1319A00 Offset: 0x1318000 VA: 0x181319A00
	private void AddNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x1319BC0 Offset: 0x13181C0 VA: 0x181319BC0
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x131B180 Offset: 0x1319780 VA: 0x18131B180
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x131A580 Offset: 0x1318B80 VA: 0x18131A580
	private string GeneratePrefix() { }

	// RVA: 0x131AD00 Offset: 0x1319300 VA: 0x18131AD00
	private void InternalWriteProcessingInstruction(string name, string text) { }

	// RVA: 0x131AF60 Offset: 0x1319560 VA: 0x18131AF60
	private int LookupNamespace(string prefix) { }

	// RVA: 0x131AE00 Offset: 0x1319400 VA: 0x18131AE00
	private int LookupNamespaceInCurrentScope(string prefix) { }

	// RVA: 0x131A410 Offset: 0x1318A10 VA: 0x18131A410
	private string FindPrefix(string ns) { }

	// RVA: 0x131B9C0 Offset: 0x1319FC0 VA: 0x18131B9C0
	private void ValidateName(string name, bool isNCName) { }

	// RVA: 0x131A670 Offset: 0x1318C70 VA: 0x18131A670
	private void HandleSpecialAttribute() { }

	// RVA: 0x131BBC0 Offset: 0x131A1C0 VA: 0x18131BBC0
	private void VerifyPrefixXml(string prefix, string ns) { }

	// RVA: 0x131B680 Offset: 0x1319C80 VA: 0x18131B680
	private void PushStack() { }

	// RVA: 0x131A520 Offset: 0x1318B20 VA: 0x18131A520
	private void FlushEncoders() { }

	// RVA: 0x131E300 Offset: 0x131C900 VA: 0x18131E300
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

	// RVA: 0x1E11F0 Offset: 0x1E05F0 VA: 0x1801E11F0
	internal void Init(int nsTop) { }

}

private struct XmlTextWriter.Namespace // TypeDefIndex: 1911
{	// Fields
	internal string prefix; // 0x0
	internal string ns; // 0x8
	internal bool declared; // 0x10
	internal int prevNsIndex; // 0x14

	// Methods

	// RVA: 0x1E0EA0 Offset: 0x1E02A0 VA: 0x1801E0EA0
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

	// RVA: 0x1323EB0 Offset: 0x13224B0 VA: 0x181323EB0
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x1323C60 Offset: 0x1322260 VA: 0x181323C60
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1323A80 Offset: 0x1322080 VA: 0x181323A80 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1323A10 Offset: 0x1322010 VA: 0x181323A10 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1322410 Offset: 0x1320A10 VA: 0x181322410 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1323600 Offset: 0x1321C00 VA: 0x181323600 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x13210C0 Offset: 0x131F6C0 VA: 0x1813210C0 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x1322A70 Offset: 0x1321070 VA: 0x181322A70 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1322D80 Offset: 0x1321380 VA: 0x181322D80 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x13234B0 Offset: 0x1321AB0 VA: 0x1813234B0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1322A20 Offset: 0x1321020 VA: 0x181322A20 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x11C18E0 Offset: 0x11BFEE0 VA: 0x1811C18E0 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x13236F0 Offset: 0x1321CF0 VA: 0x1813236F0 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1322C60 Offset: 0x1321260 VA: 0x181322C60 Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1321A80 Offset: 0x1320080 VA: 0x181321A80 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1322280 Offset: 0x1320880 VA: 0x181322280 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1322F50 Offset: 0x1321550 VA: 0x181322F50 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1322CB0 Offset: 0x13212B0 VA: 0x181322CB0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1321D30 Offset: 0x1320330 VA: 0x181321D30 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1323830 Offset: 0x1321E30 VA: 0x181323830 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1323830 Offset: 0x1321E30 VA: 0x181323830 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1323890 Offset: 0x1321E90 VA: 0x181323890 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x12F30B0 Offset: 0x12F16B0 VA: 0x1812F30B0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1323410 Offset: 0x1321A10 VA: 0x181323410 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1323460 Offset: 0x1321A60 VA: 0x181323460 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1320520 Offset: 0x131EB20 VA: 0x181320520 Slot: 28
	public override void Close() { }

	// RVA: 0x1320C00 Offset: 0x131F200 VA: 0x181320C00 Slot: 29
	public override void Flush() { }

	// RVA: 0x1320960 Offset: 0x131EF60 VA: 0x181320960 Slot: 48
	protected virtual void FlushBuffer() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void FlushEncoder() { }

	// RVA: 0x1321480 Offset: 0x131FA80 VA: 0x181321480
	protected void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1322730 Offset: 0x1320D30 VA: 0x181322730
	protected void WriteElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1321070 Offset: 0x131F670 VA: 0x181321070
	protected void RawText(string s) { }

	// RVA: 0x1320E40 Offset: 0x131F440 VA: 0x181320E40
	protected void RawText(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x13230C0 Offset: 0x13216C0 VA: 0x1813230C0
	protected void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x1321F20 Offset: 0x1320520 VA: 0x181321F20
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x1321750 Offset: 0x131FD50 VA: 0x181321750
	protected void WriteCDataSection(string text) { }

	// RVA: 0x1320DC0 Offset: 0x131F3C0 VA: 0x181320DC0
	private static bool IsSurrogateByte(byte b) { }

	// RVA: 0x13207D0 Offset: 0x131EDD0 VA: 0x1813207D0
	private static byte* EncodeSurrogate(char* pSrc, char* pSrcEnd, byte* pDst) { }

	// RVA: 0x1320C50 Offset: 0x131F250 VA: 0x181320C50
	private byte* InvalidXmlChar(int ch, byte* pDst, bool entitize) { }

	// RVA: 0x13206A0 Offset: 0x131ECA0 VA: 0x1813206A0
	internal void EncodeChar(ref char* pSrc, char* pSrcEnd, ref byte* pDst) { }

	// RVA: 0x1320780 Offset: 0x131ED80 VA: 0x181320780
	internal static byte* EncodeMultibyteUTF8(int ch, byte* pDst) { }

	// RVA: 0x1320470 Offset: 0x131EA70 VA: 0x181320470
	internal static void CharToUTF8(ref char* pSrc, char* pSrcEnd, ref byte* pDst) { }

	// RVA: 0x1322ED0 Offset: 0x13214D0 VA: 0x181322ED0
	protected byte* WriteNewLine(byte* pDst) { }

	// RVA: 0x1320DE0 Offset: 0x131F3E0 VA: 0x181320DE0
	protected static byte* LtEntity(byte* pDst) { }

	// RVA: 0x1320C40 Offset: 0x131F240 VA: 0x181320C40
	protected static byte* GtEntity(byte* pDst) { }

	// RVA: 0x13203B0 Offset: 0x131E9B0 VA: 0x1813203B0
	protected static byte* AmpEntity(byte* pDst) { }

	// RVA: 0x1320DF0 Offset: 0x131F3F0 VA: 0x181320DF0
	protected static byte* QuoteEntity(byte* pDst) { }

	// RVA: 0x1321110 Offset: 0x131F710 VA: 0x181321110
	protected static byte* TabEntity(byte* pDst) { }

	// RVA: 0x1320DD0 Offset: 0x131F3D0 VA: 0x181320DD0
	protected static byte* LineFeedEntity(byte* pDst) { }

	// RVA: 0x13203C0 Offset: 0x131E9C0 VA: 0x1813203C0
	protected static byte* CarriageReturnEntity(byte* pDst) { }

	// RVA: 0x13203D0 Offset: 0x131E9D0 VA: 0x1813203D0
	private static byte* CharEntity(byte* pDst, char ch) { }

	// RVA: 0x1320E20 Offset: 0x131F420 VA: 0x181320E20
	protected static byte* RawStartCData(byte* pDst) { }

	// RVA: 0x1320E10 Offset: 0x131F410 VA: 0x181320E10
	protected static byte* RawEndCData(byte* pDst) { }

	// RVA: 0x1321120 Offset: 0x131F720 VA: 0x181321120
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

	// RVA: 0x1320290 Offset: 0x131E890 VA: 0x181320290
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x131FC70 Offset: 0x131E270 VA: 0x18131FC70 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x13200E0 Offset: 0x131E6E0 VA: 0x1813200E0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x131FB10 Offset: 0x131E110 VA: 0x18131FB10 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x2FA5C0 Offset: 0x2F8BC0 VA: 0x1802FA5C0 Slot: 39
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x131FCE0 Offset: 0x131E2E0 VA: 0x18131FCE0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x131FE40 Offset: 0x131E440 VA: 0x18131FE40 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1320080 Offset: 0x131E680 VA: 0x181320080 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x131FBB0 Offset: 0x131E1B0 VA: 0x18131FBB0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x131FC30 Offset: 0x131E230 VA: 0x18131FC30 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x131FF70 Offset: 0x131E570 VA: 0x18131FF70 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x131FD70 Offset: 0x131E370 VA: 0x18131FD70 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x131FBC0 Offset: 0x131E1C0 VA: 0x18131FBC0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1320280 Offset: 0x131E880 VA: 0x181320280 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1320210 Offset: 0x131E810 VA: 0x181320210 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1320210 Offset: 0x131E810 VA: 0x181320210 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x131FBD0 Offset: 0x131E1D0 VA: 0x18131FBD0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1320020 Offset: 0x131E620 VA: 0x181320020 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x131FFC0 Offset: 0x131E5C0 VA: 0x18131FFC0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x131FB90 Offset: 0x131E190 VA: 0x18131FB90 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x131FA00 Offset: 0x131E000 VA: 0x18131FA00
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x131FED0 Offset: 0x131E4D0 VA: 0x18131FED0
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

	// RVA: 0xB18EF0 Offset: 0xB174F0 VA: 0x180B18EF0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC8A90 Offset: 0xBC7090 VA: 0x180BC8A90 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0xBC8B50 Offset: 0xBC7150 VA: 0x180BC8B50 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0xBC8BC0 Offset: 0xBC71C0 VA: 0x180BC8BC0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xBC8C20 Offset: 0xBC7220 VA: 0x180BC8C20 Slot: 11
	public override string get_Value() { }

	// RVA: 0xBC8940 Offset: 0xBC6F40 VA: 0x180BC8940 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xBC8910 Offset: 0xBC6F10 VA: 0x180BC8910 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBC8A00 Offset: 0xBC7000 VA: 0x180BC8A00 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xB19040 Offset: 0xB17640 VA: 0x180B19040 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xBC8190 Offset: 0xBC6790 VA: 0x180BC8190 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xBC81C0 Offset: 0xBC67C0 VA: 0x180BC81C0 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0xBC81F0 Offset: 0xBC67F0 VA: 0x180BC81F0 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xBC8290 Offset: 0xBC6890 VA: 0x180BC8290 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xBC82F0 Offset: 0xBC68F0 VA: 0x180BC82F0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xBC8320 Offset: 0xBC6920 VA: 0x180BC8320 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0xBC82C0 Offset: 0xBC68C0 VA: 0x180BC82C0 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0xBC8350 Offset: 0xBC6950 VA: 0x180BC8350 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0xBC83B0 Offset: 0xBC69B0 VA: 0x180BC83B0 Slot: 31
	public override bool Read() { }

	// RVA: 0xBC89A0 Offset: 0xBC6FA0 VA: 0x180BC89A0 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0xB9EEB0 Offset: 0xB9D4B0 VA: 0x180B9EEB0 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xBC8AC0 Offset: 0xBC70C0 VA: 0x180BC8AC0 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xBC8220 Offset: 0xBC6820 VA: 0x180BC8220 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0xBC83E0 Offset: 0xBC69E0 VA: 0x180BC83E0 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x1325580 Offset: 0x1323B80 VA: 0x181325580
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

	// RVA: 0x1324E40 Offset: 0x1323440 VA: 0x181324E40
	internal void .ctor(XmlReader reader, ValidationEventHandler settingsEventHandler, bool processIdentityConstraints) { }

	// RVA: 0x1325430 Offset: 0x1323A30 VA: 0x181325430 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0xB18EF0 Offset: 0xB174F0 VA: 0x180B18EF0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC8AF0 Offset: 0xBC70F0 VA: 0x180BC8AF0 Slot: 7
	public override string get_Name() { }

	// RVA: 0xBC8A90 Offset: 0xBC7090 VA: 0x180BC8A90 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0xBC8B50 Offset: 0xBC7150 VA: 0x180BC8B50 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0xBC8BC0 Offset: 0xBC71C0 VA: 0x180BC8BC0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xBC8C20 Offset: 0xBC7220 VA: 0x180BC8C20 Slot: 11
	public override string get_Value() { }

	// RVA: 0xBC8940 Offset: 0xBC6F40 VA: 0x180BC8940 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xBC8910 Offset: 0xBC6F10 VA: 0x180BC8910 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBC8A00 Offset: 0xBC7000 VA: 0x180BC8A00 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xBC89D0 Offset: 0xBC6FD0 VA: 0x180BC89D0 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xBC8BF0 Offset: 0xBC71F0 VA: 0x180BC8BF0 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xBC8C80 Offset: 0xBC7280 VA: 0x180BC8C80 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBC8C50 Offset: 0xBC7250 VA: 0x180BC8C50 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x13253F0 Offset: 0x13239F0 VA: 0x1813253F0 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xBC89A0 Offset: 0xBC6FA0 VA: 0x180BC89A0 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0xBC8AC0 Offset: 0xBC70C0 VA: 0x180BC8AC0 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xB19040 Offset: 0xB17640 VA: 0x180B19040 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xBC8190 Offset: 0xBC6790 VA: 0x180BC8190 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xBC81C0 Offset: 0xBC67C0 VA: 0x180BC81C0 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0xBC81F0 Offset: 0xBC67F0 VA: 0x180BC81F0 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x1324310 Offset: 0x1322910 VA: 0x181324310 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1324360 Offset: 0x1322960 VA: 0x181324360 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x13243F0 Offset: 0x13229F0 VA: 0x1813243F0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1324440 Offset: 0x1322A40 VA: 0x181324440 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x13243A0 Offset: 0x13229A0 VA: 0x1813243A0 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x1324880 Offset: 0x1322E80 VA: 0x181324880 Slot: 31
	public override bool Read() { }

	// RVA: 0x1323FE0 Offset: 0x13225E0 VA: 0x181323FE0 Slot: 33
	public override void Close() { }

	// RVA: 0x13241C0 Offset: 0x13227C0 VA: 0x1813241C0 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1324750 Offset: 0x1322D50 VA: 0x181324750 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1324AA0 Offset: 0x13230A0 VA: 0x181324AA0 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x1324250 Offset: 0x1322850 VA: 0x181324250
	internal void MoveOffEntityReference() { }

	// RVA: 0x13247B0 Offset: 0x1322DB0 VA: 0x1813247B0 Slot: 42
	public override string ReadString() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 53
	public bool HasLineInfo() { }

	// RVA: 0x1325260 Offset: 0x1323860 VA: 0x181325260 Slot: 54
	public int get_LineNumber() { }

	// RVA: 0x1325300 Offset: 0x1323900 VA: 0x181325300 Slot: 55
	public int get_LinePosition() { }

	// RVA: 0x1324020 Offset: 0x1322620 VA: 0x181324020 Slot: 56
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xBC4BE0 Offset: 0xBC31E0 VA: 0x180BC4BE0 Slot: 57
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x13241F0 Offset: 0x13227F0 VA: 0x1813241F0 Slot: 58
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1324020 Offset: 0x1322620 VA: 0x181324020
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x13241F0 Offset: 0x13227F0 VA: 0x1813241F0
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	internal ValidationType get_ValidationType() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	internal XmlSchemaCollection get_Schemas() { }

	// RVA: 0x13253D0 Offset: 0x13239D0 VA: 0x1813253D0
	internal bool get_Namespaces() { }

	// RVA: 0x1324490 Offset: 0x1322A90 VA: 0x181324490
	private void ParseDtdFromParserContext() { }

	// RVA: 0x1324DC0 Offset: 0x13233C0 VA: 0x181324DC0
	private void ValidateDtd() { }

	// RVA: 0x1324A10 Offset: 0x1323010 VA: 0x181324A10
	private void ResolveEntityInternally() { }

	// RVA: 0x1324AE0 Offset: 0x13230E0 VA: 0x181324AE0
	private void SetupValidation(ValidationType valType) { }

	// RVA: 0x13240E0 Offset: 0x13226E0 VA: 0x1813240E0
	private XmlResolver GetResolver() { }

	// RVA: 0x1324640 Offset: 0x1322C40 VA: 0x181324640
	private void ProcessCoreReaderEvent() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	internal BaseValidator get_Validator() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	internal void set_Validator(BaseValidator value) { }

	// RVA: 0x13253A0 Offset: 0x13239A0 VA: 0x1813253A0 Slot: 51
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1325500 Offset: 0x1323B00 VA: 0x181325500
	internal bool get_StandAlone() { }

	// RVA: 0x1325540 Offset: 0x1323B40 VA: 0x181325540
	internal void set_SchemaTypeObject(object value) { }

	// RVA: 0x1325520 Offset: 0x1323B20 VA: 0x181325520
	internal object get_TypedValueObject() { }

	// RVA: 0x1325560 Offset: 0x1323B60 VA: 0x181325560
	internal void set_TypedValueObject(object value) { }

	// RVA: 0x1323FC0 Offset: 0x13225C0 VA: 0x181323FC0
	internal bool AddDefaultAttribute(SchemaAttDef attdef) { }

	// RVA: 0x1325230 Offset: 0x1323830 VA: 0x181325230 Slot: 52
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0x1324C80 Offset: 0x1323280 VA: 0x181324C80
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

	// RVA: 0x13197B0 Offset: 0x1317DB0 VA: 0x1813197B0 Slot: 5
	private void System.Xml.IValidationEventHandling.SendEvent(Exception exception, XmlSeverityType severity) { }

	// RVA: 0x1319730 Offset: 0x1317D30 VA: 0x181319730
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

	// RVA: 0x132BD50 Offset: 0x132A350 VA: 0x18132BD50
	internal void .ctor(XmlWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x132C290 Offset: 0x132A890 VA: 0x18132C290 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x132A550 Offset: 0x1328B50 VA: 0x18132A550 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x132A560 Offset: 0x1328B60 VA: 0x18132A560 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1329220 Offset: 0x1327820 VA: 0x181329220 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x13285D0 Offset: 0x1326BD0 VA: 0x1813285D0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x132A590 Offset: 0x1328B90 VA: 0x18132A590 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1329330 Offset: 0x1327930 VA: 0x181329330 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x1329620 Offset: 0x1327C20 VA: 0x181329620 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x1329DC0 Offset: 0x13283C0 VA: 0x181329DC0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x1328980 Offset: 0x1326F80 VA: 0x181328980 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1327FD0 Offset: 0x13265D0 VA: 0x181327FD0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1328510 Offset: 0x1326B10 VA: 0x181328510 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x13297F0 Offset: 0x1327DF0 VA: 0x1813297F0 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1329500 Offset: 0x1327B00 VA: 0x181329500 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1328090 Offset: 0x1326690 VA: 0x181328090 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x132AA00 Offset: 0x1329000 VA: 0x18132AA00 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x132ADA0 Offset: 0x13293A0 VA: 0x18132ADA0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x132A8A0 Offset: 0x1328EA0 VA: 0x18132A8A0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1328270 Offset: 0x1326870 VA: 0x181328270 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x13299E0 Offset: 0x1327FE0 VA: 0x1813299E0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1329C80 Offset: 0x1328280 VA: 0x181329C80 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1327D40 Offset: 0x1326340 VA: 0x181327D40 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1326240 Offset: 0x1324840 VA: 0x181326240 Slot: 28
	public override void Close() { }

	// RVA: 0x1326550 Offset: 0x1324B50 VA: 0x181326550 Slot: 29
	public override void Flush() { }

	// RVA: 0x1326C90 Offset: 0x1325290 VA: 0x181326C90 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x132AC50 Offset: 0x1329250 VA: 0x18132AC50 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0x1327EE0 Offset: 0x13264E0 VA: 0x181327EE0 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal XmlRawWriter get_RawWriter() { }

	// RVA: 0xB28B20 Offset: 0xB27120 VA: 0x180B28B20
	private bool get_SaveAttrValue() { }

	// RVA: 0x132C260 Offset: 0x132A860 VA: 0x18132C260
	private bool get_InBase64() { }

	// RVA: 0x1327870 Offset: 0x1325E70 VA: 0x181327870
	private void SetSpecialAttribute(XmlWellFormedWriter.SpecialAttribute special) { }

	// RVA: 0x132A3F0 Offset: 0x13289F0 VA: 0x18132A3F0
	private void WriteStartDocumentImpl(XmlStandalone standalone) { }

	// RVA: 0x1327B20 Offset: 0x1326120 VA: 0x181327B20
	private void StartFragment() { }

	// RVA: 0x1327430 Offset: 0x1325A30 VA: 0x181327430
	private void PushNamespaceImplicit(string prefix, string ns) { }

	// RVA: 0x1326F10 Offset: 0x1325510 VA: 0x181326F10
	private bool PushNamespaceExplicit(string prefix, string ns) { }

	// RVA: 0x13258F0 Offset: 0x1323EF0 VA: 0x1813258F0
	private void AddNamespace(string prefix, string ns, XmlWellFormedWriter.NamespaceKind kind) { }

	// RVA: 0x1325BD0 Offset: 0x13241D0 VA: 0x181325BD0
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x1326A90 Offset: 0x1325090 VA: 0x181326A90
	private int LookupNamespaceIndex(string prefix) { }

	// RVA: 0x1326E50 Offset: 0x1325450 VA: 0x181326E50
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x1326460 Offset: 0x1324A60 VA: 0x181326460
	private static XmlException DupAttrException(string prefix, string localName) { }

	// RVA: 0x1325CD0 Offset: 0x13242D0 VA: 0x181325CD0
	private void AdvanceState(XmlWellFormedWriter.Token token) { }

	// RVA: 0x1327960 Offset: 0x1325F60 VA: 0x181327960
	private void StartElementContent() { }

	// RVA: 0x1326710 Offset: 0x1324D10 VA: 0x181326710
	private static string GetStateName(XmlWellFormedWriter.State state) { }

	// RVA: 0x1326BA0 Offset: 0x13251A0 VA: 0x181326BA0
	internal string LookupNamespace(string prefix) { }

	// RVA: 0x13269A0 Offset: 0x1324FA0 VA: 0x1813269A0
	private string LookupLocalNamespace(string prefix) { }

	// RVA: 0x13265E0 Offset: 0x1324BE0 VA: 0x1813265E0
	private string GeneratePrefix() { }

	// RVA: 0x13260D0 Offset: 0x13246D0 VA: 0x1813260D0
	private void CheckNCName(string ncname) { }

	// RVA: 0x13267B0 Offset: 0x1324DB0 VA: 0x1813267B0
	private static Exception InvalidCharsException(string name, int badCharIndex) { }

	// RVA: 0x1327B30 Offset: 0x1326130 VA: 0x181327B30
	private void ThrowInvalidStateTransition(XmlWellFormedWriter.Token token, XmlWellFormedWriter.State currentState) { }

	// RVA: 0x132C280 Offset: 0x132A880 VA: 0x18132C280
	private bool get_IsClosedOrErrorState() { }

	// RVA: 0x13255B0 Offset: 0x1323BB0 VA: 0x1813255B0
	private void AddAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x1325A80 Offset: 0x1324080 VA: 0x181325A80
	private void AddToAttrHashTable(int attributeIndex) { }

	// RVA: 0x132AF50 Offset: 0x1329550 VA: 0x18132AF50
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

	// RVA: 0x13186E0 Offset: 0x1316CE0 VA: 0x1813186E0 Slot: 4
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1318730 Offset: 0x1316D30 VA: 0x181318730 Slot: 5
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1318750 Offset: 0x1316D50 VA: 0x181318750 Slot: 6
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

	// RVA: 0x1E0C10 Offset: 0x1E0010 VA: 0x1801E0C10
	internal void Set(string prefix, string localName, string namespaceUri, int prevNSTop) { }

	// RVA: 0x1E0C90 Offset: 0x1E0090 VA: 0x1801E0C90
	internal void WriteEndElement(XmlRawWriter rawWriter) { }

	// RVA: 0x1E0CD0 Offset: 0x1E00D0 VA: 0x1801E0CD0
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

	// RVA: 0x1E0E50 Offset: 0x1E0250 VA: 0x1801E0E50
	internal void Set(string prefix, string namespaceUri, XmlWellFormedWriter.NamespaceKind kind) { }

	// RVA: 0x1E0EF0 Offset: 0x1E02F0 VA: 0x1801E0EF0
	internal void WriteDecl(XmlWriter writer, XmlRawWriter rawWriter) { }

}

private struct XmlWellFormedWriter.AttrName // TypeDefIndex: 1928
{	// Fields
	internal string prefix; // 0x0
	internal string namespaceUri; // 0x8
	internal string localName; // 0x10
	internal int prev; // 0x18

	// Methods

	// RVA: 0x1E0BB0 Offset: 0x1DFFB0 VA: 0x1801E0BB0
	internal void Set(string prefix, string localName, string namespaceUri) { }

	// RVA: 0x1E0BA0 Offset: 0x1DFFA0 VA: 0x1801E0BA0
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

	// RVA: 0x1317F60 Offset: 0x1316560 VA: 0x181317F60
	internal string get_StringValue() { }

	// RVA: 0x13178A0 Offset: 0x1315EA0 VA: 0x1813178A0
	internal void WriteEntityRef(string name) { }

	// RVA: 0x13176C0 Offset: 0x1315CC0 VA: 0x1813176C0
	internal void WriteCharEntity(char ch) { }

	// RVA: 0x1317CB0 Offset: 0x13162B0 VA: 0x181317CB0
	internal void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1317E60 Offset: 0x1316460 VA: 0x181317E60
	internal void WriteWhitespace(string ws) { }

	// RVA: 0x1317BF0 Offset: 0x13161F0 VA: 0x181317BF0
	internal void WriteString(string text) { }

	// RVA: 0x1317790 Offset: 0x1315D90 VA: 0x181317790
	internal void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1317A50 Offset: 0x1316050 VA: 0x181317A50
	internal void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1317B60 Offset: 0x1316160 VA: 0x181317B60
	internal void WriteRaw(string data) { }

	// RVA: 0x1317DD0 Offset: 0x13163D0 VA: 0x181317DD0
	internal void WriteValue(string value) { }

	// RVA: 0x1316CF0 Offset: 0x13152F0 VA: 0x181316CF0
	internal void Replay(XmlWriter writer) { }

	// RVA: 0x13171B0 Offset: 0x13157B0 VA: 0x1813171B0
	internal void Trim() { }

	// RVA: 0x1316CA0 Offset: 0x13152A0 VA: 0x181316CA0
	internal void Clear() { }

	// RVA: 0x1317150 Offset: 0x1315750 VA: 0x181317150
	private void StartComplexValue() { }

	// RVA: 0x1316AF0 Offset: 0x13150F0 VA: 0x181316AF0
	private void AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType type, object data) { }

	// RVA: 0x1317EF0 Offset: 0x13164F0 VA: 0x181317EF0
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

	// RVA: 0x11EC8C0 Offset: 0x11EAEC0 VA: 0x1811EC8C0
	internal void Set(XmlWellFormedWriter.AttributeValueCache.ItemType type, object data) { }

}

private class XmlWellFormedWriter.AttributeValueCache.BufferChunk // TypeDefIndex: 1933
{	// Fields
	internal char[] buffer; // 0x10
	internal int index; // 0x18
	internal int count; // 0x1C

	// Methods

	// RVA: 0xB7B690 Offset: 0xB79C90 VA: 0x180B7B690
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

	// RVA: 0x132DCD0 Offset: 0x132C2D0 VA: 0x18132DCD0
	public void WriteStartElement(string localName, string ns) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void WriteStartElement(string prefix, string localName, string ns);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void WriteEndElement();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void WriteFullEndElement();

	// RVA: 0x132D3D0 Offset: 0x132B9D0 VA: 0x18132D3D0
	public void WriteAttributeString(string localName, string ns, string value) { }

	// RVA: 0x132D360 Offset: 0x132B960 VA: 0x18132D360
	public void WriteAttributeString(string localName, string value) { }

	// RVA: 0x132D440 Offset: 0x132BA40 VA: 0x18132D440
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

	// RVA: 0x132D750 Offset: 0x132BD50 VA: 0x18132D750 Slot: 26
	public virtual void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract WriteState get_WriteState();

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 28
	public virtual void Close() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void Flush();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract string LookupPrefix(string ns);

	// RVA: 0x132DD00 Offset: 0x132C300 VA: 0x18132DD00 Slot: 31
	public virtual void WriteValue(string value) { }

	// RVA: 0x132D490 Offset: 0x132BA90 VA: 0x18132D490 Slot: 32
	public virtual void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x132D7F0 Offset: 0x132BDF0 VA: 0x18132D7F0 Slot: 33
	public virtual void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x132D780 Offset: 0x132BD80 VA: 0x18132D780
	public void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x132D300 Offset: 0x132B900 VA: 0x18132D300 Slot: 4
	public void Dispose() { }

	// RVA: 0x132D320 Offset: 0x132B920 VA: 0x18132D320 Slot: 34
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x132D220 Offset: 0x132B820 VA: 0x18132D220
	public static XmlWriter Create(Stream output, XmlWriterSettings settings) { }

	// RVA: 0x132D290 Offset: 0x132B890 VA: 0x18132D290
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

	// RVA: 0x132CE80 Offset: 0x132B480 VA: 0x18132CE80
	public void .ctor() { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_Async() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Encoding get_Encoding() { }

	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0
	public bool get_OmitXmlDeclaration() { }

	// RVA: 0x132D1C0 Offset: 0x132B7C0 VA: 0x18132D1C0
	public void set_OmitXmlDeclaration(bool value) { }

	// RVA: 0x7D0C00 Offset: 0x7CF200 VA: 0x1807D0C00
	public NewLineHandling get_NewLineHandling() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public string get_NewLineChars() { }

	// RVA: 0x132CFE0 Offset: 0x132B5E0 VA: 0x18132CFE0
	public bool get_Indent() { }

	// RVA: 0x132D0E0 Offset: 0x132B6E0 VA: 0x18132D0E0
	public void set_Indent(bool value) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_IndentChars() { }

	// RVA: 0x8054F0 Offset: 0x803AF0 VA: 0x1808054F0
	public bool get_NewLineOnAttributes() { }

	// RVA: 0xEE6E90 Offset: 0xEE5490 VA: 0x180EE6E90
	public bool get_CloseOutput() { }

	// RVA: 0x598420 Offset: 0x596A20 VA: 0x180598420
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0x132D060 Offset: 0x132B660 VA: 0x18132D060
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0xC20A70 Offset: 0xC1F070 VA: 0x180C20A70
	public bool get_CheckCharacters() { }

	// RVA: 0x5DE450 Offset: 0x5DCA50 VA: 0x1805DE450
	public NamespaceHandling get_NamespaceHandling() { }

	// RVA: 0x132D140 Offset: 0x132B740 VA: 0x18132D140
	public void set_NamespaceHandling(NamespaceHandling value) { }

	// RVA: 0x132D050 Offset: 0x132B650 VA: 0x18132D050
	public bool get_WriteEndDocumentOnClose() { }

	// RVA: 0x8D8F00 Offset: 0x8D7500 VA: 0x1808D8F00
	public XmlOutputMethod get_OutputMethod() { }

	// RVA: 0x8D8F40 Offset: 0x8D7540 VA: 0x1808D8F40
	internal void set_OutputMethod(XmlOutputMethod value) { }

	// RVA: 0x132C620 Offset: 0x132AC20 VA: 0x18132C620
	public XmlWriterSettings Clone() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	internal List<XmlQualifiedName> get_CDataSectionElements() { }

	// RVA: 0xA4EFF0 Offset: 0xA4D5F0 VA: 0x180A4EFF0
	public bool get_DoNotEscapeUriAttributes() { }

	// RVA: 0x10864F0 Offset: 0x1084AF0 VA: 0x1810864F0
	internal bool get_MergeCDataSections() { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	internal string get_MediaType() { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	internal string get_DocTypeSystem() { }

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	internal string get_DocTypePublic() { }

	// RVA: 0x582940 Offset: 0x580F40 VA: 0x180582940
	internal XmlStandalone get_Standalone() { }

	// RVA: 0x132CFD0 Offset: 0x132B5D0 VA: 0x18132CFD0
	internal bool get_AutoXmlDeclaration() { }

	// RVA: 0xA38CE0 Offset: 0xA372E0 VA: 0x180A38CE0
	internal TriState get_IndentInternal() { }

	// RVA: 0x132CFF0 Offset: 0x132B5F0 VA: 0x18132CFF0
	internal bool get_IsQuerySpecific() { }

	// RVA: 0x132C930 Offset: 0x132AF30 VA: 0x18132C930
	internal XmlWriter CreateWriter(Stream output) { }

	// RVA: 0x132C6D0 Offset: 0x132ACD0 VA: 0x18132C6D0
	internal XmlWriter CreateWriter(TextWriter output) { }

	// RVA: 0x132D210 Offset: 0x132B810 VA: 0x18132D210
	internal void set_ReadOnly(bool value) { }

	// RVA: 0x132C570 Offset: 0x132AB70 VA: 0x18132C570
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0x132CD80 Offset: 0x132B380 VA: 0x18132CD80
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

	// RVA: 0x132F510 Offset: 0x132DB10 VA: 0x18132F510
	internal void .ctor(XmlReader reader, IXmlLineInfo lineInfo, CachingEventHandler handlerMethod) { }

	// RVA: 0x132E560 Offset: 0x132CB60 VA: 0x18132E560
	private void Init() { }

	// RVA: 0x132F150 Offset: 0x132D750 VA: 0x18132F150
	internal void Reset(XmlReader reader) { }

	// RVA: 0x132F710 Offset: 0x132DD10 VA: 0x18132F710 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x132F6D0 Offset: 0x132DCD0 VA: 0x18132F6D0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x132F680 Offset: 0x132DC80 VA: 0x18132F680 Slot: 7
	public override string get_Name() { }

	// RVA: 0x132F660 Offset: 0x132DC60 VA: 0x18132F660 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x132F6B0 Offset: 0x132DCB0 VA: 0x18132F6B0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x132F6F0 Offset: 0x132DCF0 VA: 0x18132F6F0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x132F740 Offset: 0x132DD40 VA: 0x18132F740 Slot: 11
	public override string get_Value() { }

	// RVA: 0x132F600 Offset: 0x132DC00 VA: 0x18132F600 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xBC8910 Offset: 0xBC6F10 VA: 0x180BC8910 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xBC8BF0 Offset: 0xBC71F0 VA: 0x180BC8BF0 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xBC8C80 Offset: 0xBC7280 VA: 0x180BC8C80 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBC8C50 Offset: 0xBC7250 VA: 0x180BC8C50 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x132E300 Offset: 0x132C900 VA: 0x18132E300 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x132E440 Offset: 0x132CA40 VA: 0x18132E440 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x132E390 Offset: 0x132C990 VA: 0x18132E390 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x132E7B0 Offset: 0x132CDB0 VA: 0x18132E7B0 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x132E700 Offset: 0x132CD00 VA: 0x18132E700 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x132E8A0 Offset: 0x132CEA0 VA: 0x18132E8A0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x132E900 Offset: 0x132CF00 VA: 0x18132E900 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x132E850 Offset: 0x132CE50 VA: 0x18132E850 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x132EA50 Offset: 0x132D050 VA: 0x18132EA50 Slot: 31
	public override bool Read() { }

	// RVA: 0x132F0D0 Offset: 0x132D6D0 VA: 0x18132F0D0
	internal ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos) { }

	// RVA: 0x132F330 Offset: 0x132D930 VA: 0x18132F330
	internal void SwitchTextNodeAndEndElement(string textValue, string originalStringValue) { }

	// RVA: 0x132EF80 Offset: 0x132D580 VA: 0x18132EF80
	internal void RecordEndElementNode() { }

	// RVA: 0x132F620 Offset: 0x132DC20 VA: 0x18132F620 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x132E080 Offset: 0x132C680 VA: 0x18132E080 Slot: 33
	public override void Close() { }

	// RVA: 0xB9EEB0 Offset: 0xB9D4B0 VA: 0x180B9EEB0 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x132F200 Offset: 0x132D800 VA: 0x18132F200 Slot: 35
	public override void Skip() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xBC8480 Offset: 0xBC6A80 VA: 0x180BC8480 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x132F180 Offset: 0x132D780 VA: 0x18132F180 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x132E960 Offset: 0x132CF60 VA: 0x18132E960 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 53
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x132F4D0 Offset: 0x132DAD0 VA: 0x18132F4D0 Slot: 54
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x132F4F0 Offset: 0x132DAF0 VA: 0x18132F4F0 Slot: 55
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x132F1D0 Offset: 0x132D7D0 VA: 0x18132F1D0
	internal void SetToReplayMode() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal XmlReader GetCoreReader() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	internal IXmlLineInfo GetLineInfo() { }

	// RVA: 0x132E070 Offset: 0x132C670 VA: 0x18132E070
	private void ClearAttributesInfo() { }

	// RVA: 0x132DD20 Offset: 0x132C320 VA: 0x18132DD20
	private ValidatingReaderNodeData AddAttribute(int attIndex) { }

	// RVA: 0x132DEC0 Offset: 0x132C4C0 VA: 0x18132DEC0
	private ValidatingReaderNodeData AddContent(XmlNodeType nodeType) { }

	// RVA: 0x132EDC0 Offset: 0x132D3C0 VA: 0x18132EDC0
	private void RecordAttributes() { }

	// RVA: 0x132E240 Offset: 0x132C840 VA: 0x18132E240
	private int GetAttributeIndexWithoutPrefix(string name) { }

	// RVA: 0x132E180 Offset: 0x132C780 VA: 0x18132E180
	private int GetAttributeIndexWithPrefix(string name) { }

	// RVA: 0x132E0C0 Offset: 0x132C6C0 VA: 0x18132E0C0
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

	// RVA: 0x2243B70 Offset: 0x2242170 VA: 0x182243B70
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings, XmlSchemaObject partialValidationType) { }

	// RVA: 0x2243D40 Offset: 0x2242340 VA: 0x182243D40
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings) { }

	// RVA: 0x2241400 Offset: 0x223FA00 VA: 0x182241400
	private void Init() { }

	// RVA: 0x2242F40 Offset: 0x2241540 VA: 0x182242F40
	private void SetupValidator(XmlReaderSettings readerSettings, XmlReader reader, XmlSchemaObject partialValidationType) { }

	// RVA: 0x22441B0 Offset: 0x22427B0 VA: 0x1822441B0 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x2244090 Offset: 0x2242690 VA: 0x182244090 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x2243EE0 Offset: 0x22424E0 VA: 0x182243EE0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x2243EA0 Offset: 0x22424A0 VA: 0x182243EA0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x2244050 Offset: 0x2242650 VA: 0x182244050 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x2244130 Offset: 0x2242730 VA: 0x182244130 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x2244350 Offset: 0x2242950 VA: 0x182244350 Slot: 11
	public override string get_Value() { }

	// RVA: 0x2243D80 Offset: 0x2242380 VA: 0x182243D80 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xBC8910 Offset: 0xBC6F10 VA: 0x180BC8910 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBC8A00 Offset: 0xBC7000 VA: 0x180BC8A00 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x2243DC0 Offset: 0x22423C0 VA: 0x182243DC0 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xBC8BF0 Offset: 0xBC71F0 VA: 0x180BC8BF0 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xBC8C80 Offset: 0xBC7280 VA: 0x180BC8C80 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBC8C50 Offset: 0xBC7250 VA: 0x180BC8C50 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 19
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x2244290 Offset: 0x2242890 VA: 0x182244290 Slot: 20
	public override Type get_ValueType() { }

	// RVA: 0x803A70 Offset: 0x802070 VA: 0x180803A70 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x22409C0 Offset: 0x223EFC0 VA: 0x1822409C0 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x22408A0 Offset: 0x223EEA0 VA: 0x1822408A0 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x2240A30 Offset: 0x223F030 VA: 0x182240A30 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x2241960 Offset: 0x223FF60 VA: 0x182241960 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x22417C0 Offset: 0x223FDC0 VA: 0x1822417C0 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x2241A90 Offset: 0x2240090 VA: 0x182241A90 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x2241C40 Offset: 0x2240240 VA: 0x182241C40 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x2241A40 Offset: 0x2240040 VA: 0x182241A40 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x2242C20 Offset: 0x2241220 VA: 0x182242C20 Slot: 31
	public override bool Read() { }

	// RVA: 0xBC89A0 Offset: 0xBC6FA0 VA: 0x180BC89A0 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x2240510 Offset: 0x223EB10 VA: 0x182240510 Slot: 33
	public override void Close() { }

	// RVA: 0x2244170 Offset: 0x2242770 VA: 0x182244170 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x2243190 Offset: 0x2241790 VA: 0x182243190 Slot: 35
	public override void Skip() { }

	// RVA: 0x9921A0 Offset: 0x9907A0 VA: 0x1809921A0 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x2241760 Offset: 0x223FD60 VA: 0x182241760 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x2242EF0 Offset: 0x22414F0 VA: 0x182242EF0 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x2242AD0 Offset: 0x22410D0 VA: 0x182242AD0 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x2243500 Offset: 0x2241B00 VA: 0x182243500 Slot: 54
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0x2243590 Offset: 0x2241B90 VA: 0x182243590 Slot: 55
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0x22438A0 Offset: 0x2241EA0 VA: 0x1822438A0 Slot: 53
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0x22435E0 Offset: 0x2241BE0 VA: 0x1822435E0 Slot: 56
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0x2243840 Offset: 0x2241E40 VA: 0x182243840 Slot: 57
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0x22437E0 Offset: 0x2241DE0 VA: 0x1822437E0 Slot: 58
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0x2243790 Offset: 0x2241D90 VA: 0x182243790 Slot: 59
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 60
	public bool HasLineInfo() { }

	// RVA: 0x2243E00 Offset: 0x2242400 VA: 0x182243E00 Slot: 61
	public int get_LineNumber() { }

	// RVA: 0x2243E50 Offset: 0x2242450 VA: 0x182243E50 Slot: 62
	public int get_LinePosition() { }

	// RVA: 0x2243310 Offset: 0x2241910 VA: 0x182243310 Slot: 63
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x2243400 Offset: 0x2241A00 VA: 0x182243400 Slot: 64
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x2243480 Offset: 0x2241A80 VA: 0x182243480 Slot: 65
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0xBC8C20 Offset: 0xBC7220 VA: 0x180BC8C20
	private object GetStringValue() { }

	// RVA: 0x2243D60 Offset: 0x2242360 VA: 0x182243D60
	private XmlSchemaInfo get_AttributeSchemaInfo() { }

	// RVA: 0x2242690 Offset: 0x2240C90 VA: 0x182242690
	private void ProcessReaderEvent() { }

	// RVA: 0x2241DB0 Offset: 0x22403B0 VA: 0x182241DB0
	private void ProcessElementEvent() { }

	// RVA: 0x22423C0 Offset: 0x22409C0 VA: 0x1822423C0
	private void ProcessEndElementEvent() { }

	// RVA: 0x2243940 Offset: 0x2241F40 VA: 0x182243940
	private void ValidateAttributes() { }

	// RVA: 0x22404B0 Offset: 0x223EAB0 VA: 0x1822404B0
	private void ClearAttributesInfo() { }

	// RVA: 0x22406D0 Offset: 0x223ECD0 VA: 0x1822406D0
	private AttributePSVIInfo GetAttributePSVI(string name) { }

	// RVA: 0x2240610 Offset: 0x223EC10 VA: 0x182240610
	private AttributePSVIInfo GetAttributePSVI(string localName, string ns) { }

	// RVA: 0x2240C70 Offset: 0x223F270 VA: 0x182240C70
	private ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition) { }

	// RVA: 0x2240DC0 Offset: 0x223F3C0 VA: 0x182240DC0
	private ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition) { }

	// RVA: 0x22402C0 Offset: 0x223E8C0 VA: 0x1822402C0
	private AttributePSVIInfo AddAttributePSVI(int attIndex) { }

	// RVA: 0x2241710 Offset: 0x223FD10 VA: 0x182241710
	private bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x2242570 Offset: 0x2240B70 VA: 0x182242570
	private void ProcessInlineSchema() { }

	// RVA: 0x2242880 Offset: 0x2240E80 VA: 0x182242880
	private void ReadAheadForMemberType() { }

	// RVA: 0x2240F40 Offset: 0x223F540 VA: 0x182240F40
	private void GetIsDefault() { }

	// RVA: 0x2241250 Offset: 0x223F850 VA: 0x182241250
	private void GetMemberType() { }

	// RVA: 0x2240B70 Offset: 0x223F170 VA: 0x182240B70
	private XsdCachingReader GetCachingReader() { }

	// RVA: 0x2240550 Offset: 0x223EB50 VA: 0x182240550
	internal ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

	// RVA: 0x2240460 Offset: 0x223EA60 VA: 0x182240460
	internal void CachingCallBack(XsdCachingReader cachingReader) { }

	// RVA: 0x2241360 Offset: 0x223F960 VA: 0x182241360
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

	// RVA: 0xE56E20 Offset: 0xE55420 VA: 0x180E56E20
	internal void .ctor(XmlName name, XmlDocument doc) { }

	// RVA: 0xE56FD0 Offset: 0xE555D0 VA: 0x180E56FD0
	internal int get_LocalNameHash() { }

	// RVA: 0xE56DD0 Offset: 0xE553D0 VA: 0x180E56DD0
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal XmlName get_XmlName() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	internal void set_XmlName(XmlName value) { }

	// RVA: 0xE566A0 Offset: 0xE54CA0 VA: 0x180E566A0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0xE56FF0 Offset: 0xE555F0 VA: 0x180E56FF0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x855180 Offset: 0x853780 VA: 0x180855180 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xE57010 Offset: 0xE55610 VA: 0x180E57010 Slot: 33
	public override string get_NamespaceURI() { }

	// RVA: 0xE570D0 Offset: 0xE556D0 VA: 0x180E570D0 Slot: 34
	public override string get_Prefix() { }

	// RVA: 0xE57300 Offset: 0xE55900 VA: 0x180E57300 Slot: 35
	public override void set_Prefix(string value) { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xE57030 Offset: 0xE55630 VA: 0x180E57030 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0xE570F0 Offset: 0xE556F0 VA: 0x180E570F0 Slot: 7
	public override string get_Value() { }

	// RVA: 0xE573C0 Offset: 0xE559C0 VA: 0x180E573C0 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 41
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xE57200 Offset: 0xE55800 VA: 0x180E57200 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0xE568D0 Offset: 0xE54ED0 VA: 0x180E568D0
	internal bool PrepareOwnerElementInElementIdAttrMap() { }

	// RVA: 0xE56B60 Offset: 0xE55160 VA: 0x180E56B60
	internal void ResetOwnerElementInElementIdAttrMap(string oldInnerText) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0xE56450 Offset: 0xE54A50 VA: 0x180E56450 Slot: 26
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0xE568C0 Offset: 0xE54EC0 VA: 0x180E568C0 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 56
	public virtual bool get_Specified() { }

	// RVA: 0xE56820 Offset: 0xE54E20 VA: 0x180E56820 Slot: 21
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0xE56780 Offset: 0xE54D80 VA: 0x180E56780 Slot: 22
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0xE56AE0 Offset: 0xE550E0 VA: 0x180E56AE0 Slot: 23
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0xE56A60 Offset: 0xE55060 VA: 0x180E56A60 Slot: 24
	public override XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0xE56620 Offset: 0xE54C20 VA: 0x180E56620 Slot: 25
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0xE57050 Offset: 0xE55650 VA: 0x180E57050 Slot: 57
	public virtual XmlElement get_OwnerElement() { }

	// RVA: 0xE57270 Offset: 0xE55870 VA: 0x180E57270 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0xE56D00 Offset: 0xE55300 VA: 0x180E56D00 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0xE56C90 Offset: 0xE55290 VA: 0x180E56C90 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0xE56F40 Offset: 0xE55540 VA: 0x180E56F40 Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630 Slot: 47
	internal override void SetParent(XmlNode node) { }

	// RVA: 0xE571A0 Offset: 0xE557A0 VA: 0x180E571A0 Slot: 53
	internal override XmlSpace get_XmlSpace() { }

	// RVA: 0xE57110 Offset: 0xE55710 VA: 0x180E57110 Slot: 54
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

	// RVA: 0xE560C0 Offset: 0xE546C0 VA: 0x180E560C0
	internal void .ctor(XmlNode parent) { }

	// RVA: 0xE560D0 Offset: 0xE546D0 VA: 0x180E560D0
	public XmlAttribute get_ItemOf(int i) { }

	// RVA: 0xE56320 Offset: 0xE54920 VA: 0x180E56320
	public XmlAttribute get_ItemOf(string name) { }

	// RVA: 0xE561C0 Offset: 0xE547C0 VA: 0x180E561C0
	public XmlAttribute get_ItemOf(string localName, string namespaceURI) { }

	// RVA: 0xE550C0 Offset: 0xE536C0 VA: 0x180E550C0
	internal int FindNodeOffsetNS(XmlAttribute node) { }

	// RVA: 0xE55DF0 Offset: 0xE543F0 VA: 0x180E55DF0 Slot: 6
	public override XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0xE54E20 Offset: 0xE53420 VA: 0x180E54E20
	public XmlAttribute Append(XmlAttribute node) { }

	// RVA: 0xE55C80 Offset: 0xE54280 VA: 0x180E55C80
	public XmlAttribute Remove(XmlAttribute node) { }

	// RVA: 0xE55740 Offset: 0xE53D40 VA: 0x180E55740
	public XmlAttribute RemoveAt(int i) { }

	// RVA: 0xE55660 Offset: 0xE53C60 VA: 0x180E55660
	public void RemoveAll() { }

	// RVA: 0xE56020 Offset: 0xE54620 VA: 0x180E56020 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xE560B0 Offset: 0xE546B0 VA: 0x180E560B0 Slot: 14
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0xE54C20 Offset: 0xE53220 VA: 0x180E54C20 Slot: 9
	internal override XmlNode AddNode(XmlNode node) { }

	// RVA: 0xE55260 Offset: 0xE53860 VA: 0x180E55260 Slot: 12
	internal override XmlNode InsertNodeAt(int i, XmlNode node) { }

	// RVA: 0xE55910 Offset: 0xE53F10 VA: 0x180E55910 Slot: 11
	internal override XmlNode RemoveNodeAt(int i) { }

	// RVA: 0xE54FF0 Offset: 0xE535F0 VA: 0x180E54FF0
	internal void Detach(XmlAttribute attr) { }

	// RVA: 0xE55320 Offset: 0xE53920 VA: 0x180E55320
	internal void InsertParentIntoElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0xE55AF0 Offset: 0xE540F0 VA: 0x180E55AF0
	internal void RemoveParentFromElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0xE55800 Offset: 0xE53E00 VA: 0x180E55800
	internal int RemoveDuplicateAttribute(XmlAttribute attr) { }

	// RVA: 0xE55560 Offset: 0xE53B60 VA: 0x180E55560
	internal bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName) { }

	// RVA: 0xE55D10 Offset: 0xE54310 VA: 0x180E55D10
	internal void ResetParentInElementIdAttrMap(string oldVal, string newVal) { }

	// RVA: 0xE554B0 Offset: 0xE53AB0 VA: 0x180E554B0
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

	// RVA: 0xE58450 Offset: 0xE56A50 VA: 0x180E58450
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0xE58490 Offset: 0xE56A90 VA: 0x180E58490 Slot: 6
	public override string get_Name() { }

	// RVA: 0xE58490 Offset: 0xE56A90 VA: 0x180E58490 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xE37E50 Offset: 0xE36450 VA: 0x180E37E50 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC9110 Offset: 0xBC7710 VA: 0x180BC9110 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0xE583B0 Offset: 0xE569B0 VA: 0x180E583B0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xE58410 Offset: 0xE56A10 VA: 0x180E58410 Slot: 43
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

	// RVA: 0xE58450 Offset: 0xE56A50 VA: 0x180E58450
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0xBA4F90 Offset: 0xBA3590 VA: 0x180BA4F90 Slot: 7
	public override string get_Value() { }

	// RVA: 0xE59180 Offset: 0xE57780 VA: 0x180E59180 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x82BCA0 Offset: 0x82A2A0 VA: 0x18082BCA0 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0xE59160 Offset: 0xE57760 VA: 0x180E59160 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0xE59040 Offset: 0xE57640 VA: 0x180E59040 Slot: 56
	public virtual string get_Data() { }

	// RVA: 0xE59090 Offset: 0xE57690 VA: 0x180E59090 Slot: 57
	public virtual void set_Data(string value) { }

	// RVA: 0xE58FC0 Offset: 0xE575C0 VA: 0x180E58FC0
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

	// RVA: 0xE59300 Offset: 0xE57900 VA: 0x180E59300
	internal void .ctor(XmlNode container) { }

	// RVA: 0xE591A0 Offset: 0xE577A0 VA: 0x180E591A0 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0xE591A0 Offset: 0xE577A0 VA: 0x180E591A0
	internal bool MoveNext() { }

	// RVA: 0xE59240 Offset: 0xE57840 VA: 0x180E59240 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xE59280 Offset: 0xE57880 VA: 0x180E59280 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xE59280 Offset: 0xE57880 VA: 0x180E59280
	internal XmlNode get_Current() { }

}

internal class XmlChildNodes : XmlNodeList // TypeDefIndex: 1952
{	// Fields
	private XmlNode container; // 0x10

	// Properties
	public override int Count { get; }

	// Methods

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(XmlNode container) { }

	// RVA: 0xE59470 Offset: 0xE57A70 VA: 0x180E59470 Slot: 6
	public override XmlNode Item(int i) { }

	// RVA: 0xE594E0 Offset: 0xE57AE0 VA: 0x180E594E0 Slot: 7
	public override int get_Count() { }

	// RVA: 0xE59370 Offset: 0xE57970 VA: 0x180E59370 Slot: 8
	public override IEnumerator GetEnumerator() { }

}

public class XmlComment : XmlCharacterData // TypeDefIndex: 1953
{	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0xE58450 Offset: 0xE56A50 VA: 0x180E58450
	protected internal void .ctor(string comment, XmlDocument doc) { }

	// RVA: 0xE595E0 Offset: 0xE57BE0 VA: 0x180E595E0 Slot: 6
	public override string get_Name() { }

	// RVA: 0xE595E0 Offset: 0xE57BE0 VA: 0x180E595E0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x8C0CF0 Offset: 0x8BF2F0 VA: 0x1808C0CF0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xE59540 Offset: 0xE57B40 VA: 0x180E59540 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xE595A0 Offset: 0xE57BA0 VA: 0x180E595A0 Slot: 43
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

	// RVA: 0xE61830 Offset: 0xE5FE30 VA: 0x180E61830
	protected internal void .ctor(string version, string encoding, string standalone, XmlDocument doc) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Version() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	internal void set_Version(string value) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public string get_Encoding() { }

	// RVA: 0xE61B70 Offset: 0xE60170 VA: 0x180E61B70
	public void set_Encoding(string value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_Standalone() { }

	// RVA: 0xE61EF0 Offset: 0xE604F0 VA: 0x180E61EF0
	public void set_Standalone(string value) { }

	// RVA: 0xE570F0 Offset: 0xE556F0 VA: 0x180E570F0 Slot: 7
	public override string get_Value() { }

	// RVA: 0xE573C0 Offset: 0xE559C0 VA: 0x180E573C0 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0xE61A00 Offset: 0xE60000 VA: 0x180E61A00 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0xE61BE0 Offset: 0xE601E0 VA: 0x180E61BE0 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0xE61B30 Offset: 0xE60130 VA: 0x180E61B30 Slot: 6
	public override string get_Name() { }

	// RVA: 0x95F920 Offset: 0x95DF20 VA: 0x18095F920 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xE61B60 Offset: 0xE60160 VA: 0x180E61B60 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xE616C0 Offset: 0xE5FCC0 VA: 0x180E616C0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xE617C0 Offset: 0xE5FDC0 VA: 0x180E617C0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0xE61710 Offset: 0xE5FD10 VA: 0x180E61710
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

	// RVA: 0xE662E0 Offset: 0xE648E0 VA: 0x180E662E0
	public void .ctor() { }

	// RVA: 0xE65E90 Offset: 0xE64490 VA: 0x180E65E90
	public void .ctor(XmlNameTable nt) { }

	// RVA: 0xE65F00 Offset: 0xE64500 VA: 0x180E65F00
	protected internal void .ctor(XmlImplementation imp) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

	// RVA: 0xE62D10 Offset: 0xE61310 VA: 0x180E62D10
	internal static void CheckName(string name) { }

	// RVA: 0xE62700 Offset: 0xE60D00 VA: 0x180E62700
	internal XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0xE645B0 Offset: 0xE62BB0 VA: 0x180E645B0
	internal XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0xE62010 Offset: 0xE60610 VA: 0x180E62010
	internal XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0xE62620 Offset: 0xE60C20 VA: 0x180E62620
	internal bool AddIdInfo(XmlName eleName, XmlName attrName) { }

	// RVA: 0xE641B0 Offset: 0xE627B0 VA: 0x180E641B0
	private XmlName GetIDInfoByElement_(XmlName eleName) { }

	// RVA: 0xE642C0 Offset: 0xE628C0 VA: 0x180E642C0
	internal XmlName GetIDInfoByElement(XmlName eleName) { }

	// RVA: 0xE63B50 Offset: 0xE62150 VA: 0x180E63B50
	private WeakReference GetElement(ArrayList elementList, XmlElement elem) { }

	// RVA: 0xE62420 Offset: 0xE60A20 VA: 0x180E62420
	internal void AddElementWithId(string id, XmlElement elem) { }

	// RVA: 0xE65680 Offset: 0xE63C80 VA: 0x180E65680
	internal void RemoveElementWithId(string id, XmlElement elem) { }

	// RVA: 0xE62E70 Offset: 0xE61470 VA: 0x180E62E70 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xE665F0 Offset: 0xE64BF0 VA: 0x180E665F0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0xE66490 Offset: 0xE64A90 VA: 0x180E66490 Slot: 56
	public virtual XmlDocumentType get_DocumentType() { }

	// RVA: 0xE66350 Offset: 0xE64950 VA: 0x180E66350 Slot: 57
	internal virtual XmlDeclaration get_Declaration() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public XmlImplementation get_Implementation() { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380 Slot: 6
	public override string get_Name() { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xE66400 Offset: 0xE64A00 VA: 0x180E66400
	public XmlElement get_DocumentElement() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x592630 Offset: 0x590C30 VA: 0x180592630
	internal bool get_CanReportValidity() { }

	// RVA: 0xE665D0 Offset: 0xE64BD0 VA: 0x180E665D0
	internal bool get_HasSetResolver() { }

	// RVA: 0x7DDC60 Offset: 0x7DC260 VA: 0x1807DDC60
	internal XmlResolver GetResolver() { }

	// RVA: 0xE66830 Offset: 0xE64E30 VA: 0x180E66830 Slot: 58
	public virtual void set_XmlResolver(XmlResolver value) { }

	// RVA: 0xE65000 Offset: 0xE63600 VA: 0x180E65000 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0xE64650 Offset: 0xE62C50 VA: 0x180E64650
	private bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0xE645E0 Offset: 0xE62BE0 VA: 0x180E645E0
	private bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0xE62B50 Offset: 0xE61150 VA: 0x180E62B50 Slot: 28
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0xE62A00 Offset: 0xE61000 VA: 0x180E62A00 Slot: 29
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0xE630A0 Offset: 0xE616A0 VA: 0x180E630A0
	public XmlAttribute CreateAttribute(string name) { }

	// RVA: 0xE65A10 Offset: 0xE64010 VA: 0x180E65A10
	internal void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI) { }

	// RVA: 0xE631D0 Offset: 0xE617D0 VA: 0x180E631D0 Slot: 59
	public virtual XmlCDataSection CreateCDataSection(string data) { }

	// RVA: 0xE63250 Offset: 0xE61850 VA: 0x180E63250 Slot: 60
	public virtual XmlComment CreateComment(string data) { }

	// RVA: 0xE633B0 Offset: 0xE619B0 VA: 0x180E633B0 Slot: 61
	public virtual XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0xE63350 Offset: 0xE61950 VA: 0x180E63350 Slot: 62
	public virtual XmlDocumentFragment CreateDocumentFragment() { }

	// RVA: 0xE63500 Offset: 0xE61B00 VA: 0x180E63500
	public XmlElement CreateElement(string name) { }

	// RVA: 0xE62160 Offset: 0xE60760 VA: 0x180E62160
	internal void AddDefaultAttributes(XmlElement elem) { }

	// RVA: 0xE644A0 Offset: 0xE62AA0 VA: 0x180E644A0
	private SchemaElementDecl GetSchemaElementDecl(XmlElement elem) { }

	// RVA: 0xE65420 Offset: 0xE63A20 VA: 0x180E65420
	private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0xE63680 Offset: 0xE61C80 VA: 0x180E63680 Slot: 63
	public virtual XmlEntityReference CreateEntityReference(string name) { }

	// RVA: 0xE636F0 Offset: 0xE61CF0 VA: 0x180E636F0 Slot: 64
	public virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data) { }

	// RVA: 0xE638C0 Offset: 0xE61EC0 VA: 0x180E638C0 Slot: 65
	public virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0xE637E0 Offset: 0xE61DE0 VA: 0x180E637E0 Slot: 66
	public virtual XmlText CreateTextNode(string text) { }

	// RVA: 0xE63770 Offset: 0xE61D70 VA: 0x180E63770 Slot: 67
	public virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text) { }

	// RVA: 0xE63850 Offset: 0xE61E50 VA: 0x180E63850 Slot: 68
	public virtual XmlWhitespace CreateWhitespace(string text) { }

	// RVA: 0xE62FF0 Offset: 0xE615F0 VA: 0x180E62FF0
	public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI) { }

	// RVA: 0xE63450 Offset: 0xE61A50 VA: 0x180E63450
	public XmlElement CreateElement(string qualifiedName, string namespaceURI) { }

	// RVA: 0xE64940 Offset: 0xE62F40 VA: 0x180E64940
	private XmlNode ImportNodeInternal(XmlNode node, bool deep) { }

	// RVA: 0xE64730 Offset: 0xE62D30 VA: 0x180E64730
	private void ImportAttributes(XmlNode fromElem, XmlNode toElem) { }

	// RVA: 0xE64890 Offset: 0xE62E90 VA: 0x180E64890
	private void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep) { }

	// RVA: 0xE570D0 Offset: 0xE556D0 VA: 0x180E570D0
	public XmlNameTable get_NameTable() { }

	// RVA: 0xE62F50 Offset: 0xE61550 VA: 0x180E62F50 Slot: 69
	public virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0xE632C0 Offset: 0xE618C0 VA: 0x180E632C0 Slot: 70
	protected internal virtual XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0xE635B0 Offset: 0xE61BB0 VA: 0x180E635B0 Slot: 71
	public virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0xE66550 Offset: 0xE64B50 VA: 0x180E66550
	internal XmlNamedNodeMap get_Entities() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	internal void set_Entities(XmlNamedNodeMap value) { }

	// RVA: 0xE665E0 Offset: 0xE64BE0 VA: 0x180E665E0
	internal bool get_IsLoading() { }

	// RVA: 0xE66820 Offset: 0xE64E20 VA: 0x180E66820
	internal void set_IsLoading(bool value) { }

	// RVA: 0xAF5CE0 Offset: 0xAF42E0 VA: 0x180AF5CE0
	internal bool get_ActualLoadingStatus() { }

	// RVA: 0xE65580 Offset: 0xE63B80 VA: 0x180E65580 Slot: 72
	public virtual XmlNode ReadNode(XmlReader reader) { }

	// RVA: 0xE65AC0 Offset: 0xE640C0 VA: 0x180E65AC0
	private XmlTextReader SetupReader(XmlTextReader tr) { }

	// RVA: 0xE65300 Offset: 0xE63900 VA: 0x180E65300 Slot: 73
	public virtual void Load(XmlReader reader) { }

	// RVA: 0xE651A0 Offset: 0xE637A0 VA: 0x180E651A0 Slot: 74
	public virtual void LoadXml(string xml) { }

	// RVA: 0xE66790 Offset: 0xE64D90 VA: 0x180E66790 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0xE66800 Offset: 0xE64E00 VA: 0x180E66800 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0xE657E0 Offset: 0xE63DE0 VA: 0x180E657E0 Slot: 75
	public virtual void Save(XmlWriter w) { }

	// RVA: 0xE65D60 Offset: 0xE64360 VA: 0x180E65D60 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0xE65B20 Offset: 0xE64120 VA: 0x180E65B20 Slot: 44
	public override void WriteContentTo(XmlWriter xw) { }

	// RVA: 0xE640C0 Offset: 0xE626C0 VA: 0x180E640C0 Slot: 50
	internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0xE643D0 Offset: 0xE629D0 VA: 0x180E643D0
	internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent) { }

	// RVA: 0xE629B0 Offset: 0xE60FB0 VA: 0x180E629B0 Slot: 51
	internal override void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0xE62730 Offset: 0xE60D30 VA: 0x180E62730 Slot: 52
	internal override void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0xE63950 Offset: 0xE61F50 VA: 0x180E63950
	internal XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0xE66760 Offset: 0xE64D60 VA: 0x180E66760
	internal string get_Version() { }

	// RVA: 0xE66520 Offset: 0xE64B20 VA: 0x180E66520
	internal string get_Encoding() { }

	// RVA: 0xE66730 Offset: 0xE64D30 VA: 0x180E66730
	internal string get_Standalone() { }

	// RVA: 0xE63FD0 Offset: 0xE625D0 VA: 0x180E63FD0
	internal XmlEntity GetEntityNode(string name) { }

	// RVA: 0xE66600 Offset: 0xE64C00 VA: 0x180E66600 Slot: 41
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xE66340 Offset: 0xE64940 VA: 0x180E66340 Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0xE65A00 Offset: 0xE64000 VA: 0x180E65A00
	internal void SetBaseURI(string inBaseURI) { }

	// RVA: 0xE62780 Offset: 0xE60D80 VA: 0x180E62780 Slot: 26
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0xE65D80 Offset: 0xE64380 VA: 0x180E65D80
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

	// RVA: 0x11BAE50 Offset: 0x11B9450 VA: 0x1811BAE50
	protected internal void .ctor(XmlDocument ownerDocument) { }

	// RVA: 0x11BAEF0 Offset: 0x11B94F0 VA: 0x1811BAEF0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x11BAEF0 Offset: 0x11B94F0 VA: 0x1811BAEF0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x11BAF20 Offset: 0x11B9520 VA: 0x1811BAF20 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x11BAF30 Offset: 0x11B9530 VA: 0x1811BAF30 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x11BAFB0 Offset: 0x11B95B0 VA: 0x1811BAFB0 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x11BAAA0 Offset: 0x11B90A0 VA: 0x1811BAAA0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11BAB40 Offset: 0x11B9140 VA: 0x1811BAB40 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x11BA9B0 Offset: 0x11B8FB0 VA: 0x1811BA9B0 Slot: 29
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11BAA30 Offset: 0x11B9030 VA: 0x1811BAA30 Slot: 28
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0xE65D60 Offset: 0xE64360 VA: 0x180E65D60 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11BABF0 Offset: 0x11B91F0 VA: 0x1811BABF0 Slot: 44
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

	// RVA: 0x11BB100 Offset: 0x11B9700 VA: 0x1811BB100
	protected internal void .ctor(string name, string publicId, string systemId, string internalSubset, XmlDocument doc) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 6
	public override string get_Name() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x4A6090 Offset: 0x4A4690 VA: 0x1804A6090 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11BB050 Offset: 0x11B9650 VA: 0x1811BB050 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x11BB2C0 Offset: 0x11B98C0 VA: 0x1811BB2C0
	public XmlNamedNodeMap get_Entities() { }

	// RVA: 0x11BB350 Offset: 0x11B9950 VA: 0x1811BB350
	public XmlNamedNodeMap get_Notations() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public string get_PublicId() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_SystemId() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_InternalSubset() { }

	// RVA: 0x8054F0 Offset: 0x803AF0 VA: 0x1808054F0
	internal bool get_ParseWithNamespaces() { }

	// RVA: 0x11BB0B0 Offset: 0x11B96B0 VA: 0x1811BB0B0 Slot: 43
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

	// RVA: 0x11BD240 Offset: 0x11BB840 VA: 0x1811BD240
	internal void .ctor(XmlName name, bool empty, XmlDocument doc) { }

	// RVA: 0x11BD0B0 Offset: 0x11BB6B0 VA: 0x1811BD0B0
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal XmlName get_XmlName() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	internal void set_XmlName(XmlName value) { }

	// RVA: 0x11BC020 Offset: 0x11BA620 VA: 0x1811BC020 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x11BD5D0 Offset: 0x11BBBD0 VA: 0x1811BD5D0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x11BD5B0 Offset: 0x11BBBB0 VA: 0x1811BD5B0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x11BD5F0 Offset: 0x11BBBF0 VA: 0x1811BD5F0 Slot: 33
	public override string get_NamespaceURI() { }

	// RVA: 0x11BD670 Offset: 0x11BBC70 VA: 0x1811BD670 Slot: 34
	public override string get_Prefix() { }

	// RVA: 0x11BD850 Offset: 0x11BBE50 VA: 0x1811BD850 Slot: 35
	public override void set_Prefix(string value) { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x11BD650 Offset: 0x11BBC50 VA: 0x1811BD650 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x11BBE50 Offset: 0x11BA450 VA: 0x1811BBE50 Slot: 26
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x11BD590 Offset: 0x11BBB90 VA: 0x1811BD590
	public bool get_IsEmpty() { }

	// RVA: 0x11BD7F0 Offset: 0x11BBDF0 VA: 0x1811BD7F0
	public void set_IsEmpty(bool value) { }

	// RVA: 0x11BD5A0 Offset: 0x11BBBA0 VA: 0x1811BD5A0 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11BC760 Offset: 0x11BAD60 VA: 0x1811BC760 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x11BD410 Offset: 0x11BBA10 VA: 0x1811BD410 Slot: 14
	public override XmlAttributeCollection get_Attributes() { }

	// RVA: 0x11BD550 Offset: 0x11BBB50 VA: 0x1811BD550 Slot: 56
	public virtual bool get_HasAttributes() { }

	// RVA: 0x11BC620 Offset: 0x11BAC20 VA: 0x1811BC620 Slot: 57
	public virtual string GetAttribute(string name) { }

	// RVA: 0x11BCB80 Offset: 0x11BB180 VA: 0x1811BCB80 Slot: 58
	public virtual void SetAttribute(string name, string value) { }

	// RVA: 0x11BC5B0 Offset: 0x11BABB0 VA: 0x1811BC5B0 Slot: 59
	public virtual XmlAttribute GetAttributeNode(string name) { }

	// RVA: 0x11BC930 Offset: 0x11BAF30 VA: 0x1811BC930 Slot: 60
	public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr) { }

	// RVA: 0x11BC6A0 Offset: 0x11BACA0 VA: 0x1811BC6A0 Slot: 61
	public virtual string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x11BCA50 Offset: 0x11BB050 VA: 0x1811BCA50 Slot: 62
	public virtual string SetAttribute(string localName, string namespaceURI, string value) { }

	// RVA: 0x11BC530 Offset: 0x11BAB30 VA: 0x1811BC530 Slot: 63
	public virtual XmlAttribute GetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x11BC840 Offset: 0x11BAE40 VA: 0x1811BC840 Slot: 64
	public virtual XmlAttribute SetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x11BC740 Offset: 0x11BAD40 VA: 0x1811BC740 Slot: 65
	public virtual bool HasAttribute(string name) { }

	// RVA: 0x11BCFA0 Offset: 0x11BB5A0 VA: 0x1811BCFA0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11BCC60 Offset: 0x11BB260 VA: 0x1811BCC60
	private static void WriteElementTo(XmlWriter writer, XmlElement e) { }

	// RVA: 0x11BCE70 Offset: 0x11BB470 VA: 0x1811BCE70
	private void WriteStartElement(XmlWriter w) { }

	// RVA: 0xE56C90 Offset: 0xE55290 VA: 0x180E56C90 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11BC7C0 Offset: 0x11BADC0 VA: 0x1811BC7C0 Slot: 66
	public virtual void RemoveAllAttributes() { }

	// RVA: 0x11BC810 Offset: 0x11BAE10 VA: 0x1811BC810 Slot: 45
	public override void RemoveAll() { }

	// RVA: 0x11BC800 Offset: 0x11BAE00 VA: 0x1811BC800
	internal void RemoveAllChildren() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 41
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11BD770 Offset: 0x11BBD70 VA: 0x1811BD770 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x11BD580 Offset: 0x11BBB80 VA: 0x1811BD580 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0x11BD690 Offset: 0x11BBC90 VA: 0x1811BD690 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x11BD610 Offset: 0x11BBC10 VA: 0x1811BD610 Slot: 13
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

	// RVA: 0x11C36B0 Offset: 0x11C1CB0 VA: 0x1811C36B0
	internal void .ctor(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc) { }

	// RVA: 0x11C3620 Offset: 0x11C1C20 VA: 0x1811C3620 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 6
	public override string get_Name() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x11BD580 Offset: 0x11BBB80 VA: 0x1811BD580 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0x11C3900 Offset: 0x11C1F00 VA: 0x1811C3900 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x11C3800 Offset: 0x11C1E00 VA: 0x1811C3800 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11C3690 Offset: 0x11C1C90 VA: 0x1811C3690 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x91FBF0 Offset: 0x91E1F0 VA: 0x18091FBF0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_SystemId() { }

	// RVA: 0x11C3970 Offset: 0x11C1F70 VA: 0x1811C3970 Slot: 40
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

	// RVA: 0x11C3270 Offset: 0x11C1870 VA: 0x1811C3270
	protected internal void .ctor(string name, XmlDocument doc) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 6
	public override string get_Name() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 7
	public override string get_Value() { }

	// RVA: 0x11C35B0 Offset: 0x11C1BB0 VA: 0x1811C35B0 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x6F3500 Offset: 0x6F1B00 VA: 0x1806F3500 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11C2DF0 Offset: 0x11C13F0 VA: 0x1811C2DF0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x11C2F00 Offset: 0x11C1500 VA: 0x1811C2F00 Slot: 47
	internal override void SetParent(XmlNode node) { }

	// RVA: 0xE303C0 Offset: 0xE2E9C0 VA: 0x180E303C0 Slot: 48
	internal override void SetParentForLoad(XmlNode node) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11BC760 Offset: 0x11BAD60 VA: 0x1811BC760 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x11C3240 Offset: 0x11C1840 VA: 0x1811C3240 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11C2FE0 Offset: 0x11C15E0 VA: 0x1811C2FE0 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11C3400 Offset: 0x11C1A00 VA: 0x1811C3400 Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0x11C2E40 Offset: 0x11C1440 VA: 0x1811C2E40
	private string ConstructBaseURI(string baseURI, string systemId) { }

	// RVA: 0x11C3440 Offset: 0x11C1A40 VA: 0x1811C3440
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

	// RVA: 0x11C6DC0 Offset: 0x11C53C0 VA: 0x1811C6DC0
	public void .ctor() { }

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(XmlNameTable nt) { }

	// RVA: 0x11C6D60 Offset: 0x11C5360 VA: 0x1811C6D60 Slot: 4
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

	// RVA: 0x11C6E30 Offset: 0x11C5430 VA: 0x1811C6E30
	internal void .ctor(XmlDocument doc) { }

	// RVA: 0x11C6F40 Offset: 0x11C5540 VA: 0x1811C6F40 Slot: 12
	public override XmlNode get_PreviousSibling() { }

	// RVA: 0x11C6EE0 Offset: 0x11C54E0 VA: 0x1811C6EE0 Slot: 13
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

	// RVA: 0x11CB0C0 Offset: 0x11C96C0 VA: 0x1811CB0C0
	internal void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace) { }

	// RVA: 0x11C91A0 Offset: 0x11C77A0 VA: 0x1811C91A0
	private void LoadDocSequence(XmlDocument parentDoc) { }

	// RVA: 0x11CBAC0 Offset: 0x11CA0C0 VA: 0x1811CBAC0
	internal XmlNode ReadCurrentNode(XmlDocument doc, XmlReader reader) { }

	// RVA: 0x11CAA00 Offset: 0x11C9000 VA: 0x1811CAA00
	private XmlNode LoadNode(bool skipOverWhitespace) { }

	// RVA: 0x11C85C0 Offset: 0x11C6BC0 VA: 0x1811C85C0
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0x11C8DE0 Offset: 0x11C73E0 VA: 0x1811C8DE0
	private XmlAttribute LoadDefaultAttribute() { }

	// RVA: 0x11C8920 Offset: 0x11C6F20 VA: 0x1811C8920
	private void LoadAttributeValue(XmlNode parent, bool direct) { }

	// RVA: 0x11C9F90 Offset: 0x11C8590 VA: 0x1811C9F90
	private XmlEntityReference LoadEntityReferenceNode(bool direct) { }

	// RVA: 0x11C8C10 Offset: 0x11C7210 VA: 0x1811C8C10
	private XmlDeclaration LoadDeclarationNode() { }

	// RVA: 0x11C9210 Offset: 0x11C7810 VA: 0x1811C9210
	private XmlDocumentType LoadDocumentTypeNode() { }

	// RVA: 0x11CA380 Offset: 0x11C8980 VA: 0x1811CA380
	private XmlNode LoadNodeDirect() { }

	// RVA: 0x11C8050 Offset: 0x11C6650 VA: 0x1811C8050
	private XmlAttribute LoadAttributeNodeDirect() { }

	// RVA: 0x11CB610 Offset: 0x11C9C10 VA: 0x1811CB610
	internal void ParseDocumentType(XmlDocumentType dtNode) { }

	// RVA: 0x11CB3A0 Offset: 0x11C99A0 VA: 0x1811CB3A0
	private void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver) { }

	// RVA: 0x11C9440 Offset: 0x11C7A40 VA: 0x1811C9440
	private void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode) { }

	// RVA: 0x11C77C0 Offset: 0x11C5DC0 VA: 0x1811C77C0
	private XmlParserContext GetContext(XmlNode node) { }

	// RVA: 0x11CB690 Offset: 0x11C9C90 VA: 0x1811CB690
	internal XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt) { }

	// RVA: 0x11CA1E0 Offset: 0x11C87E0 VA: 0x1811CA1E0
	internal void LoadInnerXmlElement(XmlElement node, string innerxmltext) { }

	// RVA: 0x11CA1C0 Offset: 0x11C87C0 VA: 0x1811CA1C0
	internal void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext) { }

	// RVA: 0x11CBC60 Offset: 0x11CA260 VA: 0x1811CBC60
	private void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs) { }

	// RVA: 0x11C71F0 Offset: 0x11C57F0 VA: 0x1811C71F0
	private string EntitizeName(string name) { }

	// RVA: 0x11C7720 Offset: 0x11C5D20 VA: 0x1811C7720
	internal void ExpandEntity(XmlEntity ent) { }

	// RVA: 0x11C7240 Offset: 0x11C5840 VA: 0x1811C7240
	internal void ExpandEntityReference(XmlEntityReference eref) { }

	// RVA: 0x11C6FC0 Offset: 0x11C55C0 VA: 0x1811C6FC0
	private XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc) { }

	// RVA: 0x11CB8C0 Offset: 0x11C9EC0 VA: 0x1811CB8C0
	internal static void ParseXmlDeclarationValue(string strValue, out string version, out string encoding, out string standalone) { }

	// RVA: 0x11CBF80 Offset: 0x11CA580 VA: 0x1811CBF80
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

	// RVA: 0x11CC5A0 Offset: 0x11CABA0 VA: 0x1811CC5A0
	public static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x11CC830 Offset: 0x11CAE30 VA: 0x1811CC830
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_LocalName() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_NamespaceURI() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Prefix() { }

	// RVA: 0xA38CE0 Offset: 0xA372E0 VA: 0x180A38CE0
	public int get_HashCode() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public XmlDocument get_OwnerDocument() { }

	// RVA: 0x11CC8E0 Offset: 0x11CAEE0 VA: 0x1811CC8E0
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

	// RVA: 0xDF0010 Offset: 0xDEE610 VA: 0x180DF0010 Slot: 18
	public virtual bool Equals(IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x11CC7C0 Offset: 0x11CADC0 VA: 0x1811CC7C0
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

	// RVA: 0x11CC2B0 Offset: 0x11CA8B0 VA: 0x1811CC2B0
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x11CC570 Offset: 0x11CAB70 VA: 0x1811CC570 Slot: 11
	public override XmlSchemaValidity get_Validity() { }

	// RVA: 0x11CC450 Offset: 0x11CAA50 VA: 0x1811CC450 Slot: 12
	public override bool get_IsDefault() { }

	// RVA: 0x11CC460 Offset: 0x11CAA60 VA: 0x1811CC460 Slot: 13
	public override bool get_IsNil() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 14
	public override XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860 Slot: 15
	public override XmlSchemaType get_SchemaType() { }

	// RVA: 0x11CC4F0 Offset: 0x11CAAF0 VA: 0x1811CC4F0 Slot: 16
	public override XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x11CC470 Offset: 0x11CAA70 VA: 0x1811CC470 Slot: 17
	public override XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x11CC2A0 Offset: 0x11CA8A0 VA: 0x1811CC2A0
	public void SetValidity(XmlSchemaValidity value) { }

	// RVA: 0x11CC240 Offset: 0x11CA840 VA: 0x1811CC240
	public void SetIsDefault(bool value) { }

	// RVA: 0x11CC270 Offset: 0x11CA870 VA: 0x1811CC270
	public void SetIsNil(bool value) { }

	// RVA: 0x11CC080 Offset: 0x11CA680 VA: 0x1811CC080 Slot: 18
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

	// RVA: 0x11CCF80 Offset: 0x11CB580 VA: 0x1811CCF80 Slot: 5
	public virtual XmlNode GetNamedItem(string name) { }

	// RVA: 0x11CD4F0 Offset: 0x11CBAF0 VA: 0x1811CD4F0 Slot: 6
	public virtual XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x11CD6D0 Offset: 0x11CBCD0 VA: 0x1811CD6D0 Slot: 7
	public virtual int get_Count() { }

	// RVA: 0x11CCF70 Offset: 0x11CB570 VA: 0x1811CCF70 Slot: 8
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x11CCD30 Offset: 0x11CB330 VA: 0x1811CCD30
	internal int FindNodeOffset(string name) { }

	// RVA: 0x11CCE30 Offset: 0x11CB430 VA: 0x1811CCE30
	internal int FindNodeOffset(string localName, string namespaceURI) { }

	// RVA: 0x11CCB50 Offset: 0x11CB150 VA: 0x1811CCB50 Slot: 9
	internal virtual XmlNode AddNode(XmlNode node) { }

	// RVA: 0x11CCA90 Offset: 0x11CB090 VA: 0x1811CCA90 Slot: 10
	internal virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc) { }

	// RVA: 0x11CD300 Offset: 0x11CB900 VA: 0x1811CD300 Slot: 11
	internal virtual XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x11CD480 Offset: 0x11CBA80 VA: 0x1811CD480
	internal XmlNode ReplaceNodeAt(int i, XmlNode node) { }

	// RVA: 0x11CD110 Offset: 0x11CB710 VA: 0x1811CD110 Slot: 12
	internal virtual XmlNode InsertNodeAt(int i, XmlNode node) { }

}

internal struct XmlNamedNodeMap.SmallXmlNodeList // TypeDefIndex: 1968
{	// Fields
	private object field; // 0x0

	// Properties
	public int Count { get; }
	public object Item { get; }

	// Methods

	// RVA: 0x1D0C70 Offset: 0x1D0070 VA: 0x1801D0C70
	public int get_Count() { }

	// RVA: 0x1D0C80 Offset: 0x1D0080 VA: 0x1801D0C80
	public object get_Item(int index) { }

	// RVA: 0x1D0C30 Offset: 0x1D0030 VA: 0x1801D0C30
	public void Add(object value) { }

	// RVA: 0x1D0C60 Offset: 0x1D0060 VA: 0x1801D0C60
	public void RemoveAt(int index) { }

	// RVA: 0x1D0C50 Offset: 0x1D0050 VA: 0x1801D0C50
	public void Insert(int index, object value) { }

	// RVA: 0x1D0C40 Offset: 0x1D0040 VA: 0x1801D0C40
	public IEnumerator GetEnumerator() { }

}

private class XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator : IEnumerator // TypeDefIndex: 1969
{	// Fields
	private object loneValue; // 0x10
	private int position; // 0x18

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x11B9A60 Offset: 0x11B8060 VA: 0x1811B9A60
	public void .ctor(object value) { }

	// RVA: 0x11B9AA0 Offset: 0x11B80A0 VA: 0x1811B9AA0 Slot: 5
	public object get_Current() { }

	// RVA: 0x11B9A40 Offset: 0x11B8040 VA: 0x1811B9A40 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x117C410 Offset: 0x117AA10 VA: 0x18117C410 Slot: 6
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

	// RVA: 0x11D2220 Offset: 0x11D0820 VA: 0x1811D2220
	internal void .ctor(XmlDocument doc) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_Name();

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 7
	public virtual string get_Value() { }

	// RVA: 0x11D2E20 Offset: 0x11D1420 VA: 0x1811D2E20 Slot: 8
	public virtual void set_Value(string value) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x11D28C0 Offset: 0x11D0EC0 VA: 0x1811D28C0 Slot: 10
	public virtual XmlNode get_ParentNode() { }

	// RVA: 0x11D2400 Offset: 0x11D0A00 VA: 0x1811D2400 Slot: 11
	public virtual XmlNodeList get_ChildNodes() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 12
	public virtual XmlNode get_PreviousSibling() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 13
	public virtual XmlNode get_NextSibling() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 14
	public virtual XmlAttributeCollection get_Attributes() { }

	// RVA: 0x11D27F0 Offset: 0x11D0DF0 VA: 0x1811D27F0 Slot: 15
	public virtual XmlDocument get_OwnerDocument() { }

	// RVA: 0x11D2500 Offset: 0x11D0B00 VA: 0x1811D2500 Slot: 16
	public virtual XmlNode get_FirstChild() { }

	// RVA: 0x11D2790 Offset: 0x11D0D90 VA: 0x1811D2790 Slot: 17
	public virtual XmlNode get_LastChild() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 18
	internal virtual bool get_IsContainer() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 19
	internal virtual XmlLinkedNode get_LastNode() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 20
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11CFAC0 Offset: 0x11CE0C0 VA: 0x1811CFAC0
	internal bool AncestorNode(XmlNode node) { }

	// RVA: 0x11D13E0 Offset: 0x11CF9E0 VA: 0x1811D13E0 Slot: 21
	public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11D0CF0 Offset: 0x11CF2F0 VA: 0x1811D0CF0 Slot: 22
	public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11D1BD0 Offset: 0x11D01D0 VA: 0x1811D1BD0 Slot: 23
	public virtual XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x11D1B00 Offset: 0x11D0100 VA: 0x1811D1B00 Slot: 24
	public virtual XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0x11CFE20 Offset: 0x11CE420 VA: 0x1811CFE20 Slot: 25
	public virtual XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x11CFB30 Offset: 0x11CE130 VA: 0x1811CFB30 Slot: 26
	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 27
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 28
	internal virtual bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 29
	internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11D2530 Offset: 0x11D0B30 VA: 0x1811D2530 Slot: 30
	public virtual bool get_HasChildNodes() { }

	// RVA: -1 Offset: -1 Slot: 31
	public abstract XmlNode CloneNode(bool deep);

	// RVA: 0x11D0400 Offset: 0x11CEA00 VA: 0x1811D0400 Slot: 32
	internal virtual void CopyChildren(XmlDocument doc, XmlNode container, bool deep) { }

	// RVA: 0x11D27B0 Offset: 0x11D0DB0 VA: 0x1811D27B0 Slot: 33
	public virtual string get_NamespaceURI() { }

	// RVA: 0x11D29B0 Offset: 0x11D0FB0 VA: 0x1811D29B0 Slot: 34
	public virtual string get_Prefix() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 35
	public virtual void set_Prefix(string value) { }

	// RVA: -1 Offset: -1 Slot: 36
	public abstract string get_LocalName();

	// RVA: 0x11D2660 Offset: 0x11D0C60 VA: 0x1811D2660 Slot: 37
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x11D0BD0 Offset: 0x11CF1D0 VA: 0x1811D0BD0
	internal static bool HasReadOnlyParent(XmlNode n) { }

	// RVA: 0x11D21C0 Offset: 0x11D07C0 VA: 0x1811D21C0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x11D2160 Offset: 0x11D0760 VA: 0x1811D2160 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x11D0530 Offset: 0x11CEB30 VA: 0x1811D0530
	public IEnumerator GetEnumerator() { }

	// RVA: 0x11CFD10 Offset: 0x11CE310 VA: 0x1811CFD10
	private void AppendChildText(StringBuilder builder) { }

	// RVA: 0x11D2550 Offset: 0x11D0B50 VA: 0x1811D2550 Slot: 38
	public virtual string get_InnerText() { }

	// RVA: 0x11D2CB0 Offset: 0x11D12B0 VA: 0x1811D2CB0 Slot: 39
	public virtual void set_InnerText(string value) { }

	// RVA: 0x11D2DB0 Offset: 0x11D13B0 VA: 0x1811D2DB0 Slot: 40
	public virtual void set_InnerXml(string value) { }

	// RVA: 0x11D29F0 Offset: 0x11D0FF0 VA: 0x1811D29F0 Slot: 41
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11D22C0 Offset: 0x11D08C0 VA: 0x1811D22C0 Slot: 42
	public virtual string get_BaseURI() { }

	// RVA: -1 Offset: -1 Slot: 43
	public abstract void WriteTo(XmlWriter w);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract void WriteContentTo(XmlWriter w);

	// RVA: 0x11D1B50 Offset: 0x11D0150 VA: 0x1811D1B50 Slot: 45
	public virtual void RemoveAll() { }

	// RVA: 0x11D2460 Offset: 0x11D0A60 VA: 0x1811D2460
	internal XmlDocument get_Document() { }

	// RVA: 0x11D0B70 Offset: 0x11CF170 VA: 0x1811D0B70 Slot: 46
	public virtual string GetPrefixOfNamespace(string namespaceURI) { }

	// RVA: 0x11D06C0 Offset: 0x11CECC0 VA: 0x1811D06C0
	internal string GetPrefixOfNamespaceStrict(string namespaceURI) { }

	// RVA: 0x11D2040 Offset: 0x11D0640 VA: 0x1811D2040 Slot: 47
	internal virtual void SetParent(XmlNode node) { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630 Slot: 48
	internal virtual void SetParentForLoad(XmlNode node) { }

	// RVA: 0x11D2080 Offset: 0x11D0680 VA: 0x1811D2080
	internal static void SplitName(string name, out string prefix, out string localName) { }

	// RVA: 0x11D04B0 Offset: 0x11CEAB0 VA: 0x1811D04B0 Slot: 49
	internal virtual XmlNode FindChild(XmlNodeType type) { }

	// RVA: 0x11D0590 Offset: 0x11CEB90 VA: 0x1811D0590 Slot: 50
	internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x11D03B0 Offset: 0x11CE9B0 VA: 0x1811D03B0 Slot: 51
	internal virtual void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x11CFA70 Offset: 0x11CE070 VA: 0x1811CFA70 Slot: 52
	internal virtual void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x11D2B50 Offset: 0x11D1150 VA: 0x1811D2B50 Slot: 53
	internal virtual XmlSpace get_XmlSpace() { }

	// RVA: 0x11D2A50 Offset: 0x11D1050 VA: 0x1811D2A50 Slot: 54
	internal virtual string get_XmlLang() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 55
	internal virtual bool get_IsText() { }

	// RVA: 0x11D1AD0 Offset: 0x11D00D0 VA: 0x1811D1AD0
	internal static void NestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

	// RVA: 0x11D21E0 Offset: 0x11D07E0 VA: 0x1811D21E0
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

	// RVA: 0x11CE650 Offset: 0x11CCC50 VA: 0x1811CE650
	public void .ctor(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public XmlNodeChangedAction get_Action() { }

}

public sealed class XmlNodeChangedEventHandler : MulticastDelegate // TypeDefIndex: 1972
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE45C0 Offset: 0xAE2BC0 VA: 0x180AE45C0 Slot: 12
	public virtual void Invoke(object sender, XmlNodeChangedEventArgs e) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
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

	// RVA: 0x11CE720 Offset: 0x11CCD20 VA: 0x1811CE720 Slot: 9
	public virtual XmlNode get_ItemOf(int i) { }

	// RVA: 0xE3B190 Offset: 0xE39790 VA: 0x180E3B190 Slot: 5
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

	// RVA: 0xB9E350 Offset: 0xB9C950 VA: 0x180B9E350
	public void .ctor(XmlNode node) { }

	// RVA: 0xB9EE70 Offset: 0xB9D470 VA: 0x180B9EE70
	public XmlNodeType get_NodeType() { }

	// RVA: 0xB9EE40 Offset: 0xB9D440 VA: 0x180B9EE40
	public string get_NamespaceURI() { }

	// RVA: 0xB9ECF0 Offset: 0xB9D2F0 VA: 0x180B9ECF0
	public string get_Name() { }

	// RVA: 0xB9EAE0 Offset: 0xB9D0E0 VA: 0x180B9EAE0
	public string get_LocalName() { }

	// RVA: 0xB9E8A0 Offset: 0xB9CEA0 VA: 0x180B9E8A0
	internal bool get_CreatedOnAttribute() { }

	// RVA: 0xB9CAE0 Offset: 0xB9B0E0 VA: 0x180B9CAE0
	private bool IsLocalNameEmpty(XmlNodeType nt) { }

	// RVA: 0xB9EEB0 Offset: 0xB9D4B0 VA: 0x180B9EEB0
	public string get_Prefix() { }

	// RVA: 0xB9EF10 Offset: 0xB9D510 VA: 0x180B9EF10
	public string get_Value() { }

	// RVA: 0xB9E870 Offset: 0xB9CE70 VA: 0x180B9E870
	public string get_BaseURI() { }

	// RVA: 0xB9F210 Offset: 0xB9D810 VA: 0x180B9F210
	public XmlSpace get_XmlSpace() { }

	// RVA: 0xB9F1E0 Offset: 0xB9D7E0 VA: 0x180B9F1E0
	public string get_XmlLang() { }

	// RVA: 0xB9E9B0 Offset: 0xB9CFB0 VA: 0x180B9E9B0
	public bool get_IsEmptyElement() { }

	// RVA: 0xB9E8B0 Offset: 0xB9CEB0 VA: 0x180B9E8B0
	public bool get_IsDefault() { }

	// RVA: 0xB9EEE0 Offset: 0xB9D4E0 VA: 0x180B9EEE0
	public IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public XmlNameTable get_NameTable() { }

	// RVA: 0xB9E6E0 Offset: 0xB9CCE0 VA: 0x180B9E6E0
	public int get_AttributeCount() { }

	// RVA: 0xB9B290 Offset: 0xB99890 VA: 0x180B9B290
	private void CheckIndexCondition(int attributeIndex) { }

	// RVA: 0xB9C740 Offset: 0xB9AD40 VA: 0x180B9C740
	private void InitDecAttr() { }

	// RVA: 0xB9C010 Offset: 0xB9A610 VA: 0x180B9C010
	public string GetDeclarationAttr(XmlDeclaration decl, string name) { }

	// RVA: 0xB9BFB0 Offset: 0xB9A5B0 VA: 0x180B9BFB0
	public string GetDeclarationAttr(int i) { }

	// RVA: 0xB9BF10 Offset: 0xB9A510 VA: 0x180B9BF10
	public int GetDecAttrInd(string name) { }

	// RVA: 0xB9C970 Offset: 0xB9AF70 VA: 0x180B9C970
	private void InitDocTypeAttr() { }

	// RVA: 0xB9C170 Offset: 0xB9A770 VA: 0x180B9C170
	public string GetDocumentTypeAttr(XmlDocumentType docType, string name) { }

	// RVA: 0xB9C210 Offset: 0xB9A810 VA: 0x180B9C210
	public string GetDocumentTypeAttr(int i) { }

	// RVA: 0xB9C0D0 Offset: 0xB9A6D0 VA: 0x180B9C0D0
	public int GetDocTypeAttrInd(string name) { }

	// RVA: 0xB9B4A0 Offset: 0xB99AA0 VA: 0x180B9B4A0
	private string GetAttributeFromElement(XmlElement elem, string name) { }

	// RVA: 0xB9BB90 Offset: 0xB9A190 VA: 0x180B9BB90
	public string GetAttribute(string name) { }

	// RVA: 0xB9B440 Offset: 0xB99A40 VA: 0x180B9B440
	private string GetAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0xB9B7E0 Offset: 0xB99DE0 VA: 0x180B9B7E0
	public string GetAttribute(string name, string ns) { }

	// RVA: 0xB9B4F0 Offset: 0xB99AF0 VA: 0x180B9B4F0
	public string GetAttribute(int attributeIndex) { }

	// RVA: 0xB9CB30 Offset: 0xB9B130 VA: 0x180B9CB30
	public void LogMove(int level) { }

	// RVA: 0xB9E300 Offset: 0xB9C900 VA: 0x180B9E300
	public void RollBackMove(ref int level) { }

	// RVA: 0xB9EAA0 Offset: 0xB9D0A0 VA: 0x180B9EAA0
	private bool get_IsOnDeclOrDocType() { }

	// RVA: 0xB9E220 Offset: 0xB9C820 VA: 0x180B9E220
	public void ResetToAttribute(ref int level) { }

	// RVA: 0xB9DF60 Offset: 0xB9C560 VA: 0x180B9DF60
	public void ResetMove(ref int level, ref XmlNodeType nt) { }

	// RVA: 0xB9D5E0 Offset: 0xB9BBE0 VA: 0x180B9D5E0
	public bool MoveToAttribute(string name) { }

	// RVA: 0xB9D270 Offset: 0xB9B870 VA: 0x180B9D270
	private bool MoveToAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0xB9D350 Offset: 0xB9B950 VA: 0x180B9D350
	public bool MoveToAttribute(string name, string namespaceURI) { }

	// RVA: 0xB9D640 Offset: 0xB9BC40 VA: 0x180B9D640
	public void MoveToAttribute(int attributeIndex) { }

	// RVA: 0xB9D9C0 Offset: 0xB9BFC0 VA: 0x180B9D9C0
	public bool MoveToNextAttribute(ref int level) { }

	// RVA: 0xB9DCC0 Offset: 0xB9C2C0 VA: 0x180B9DCC0
	public bool MoveToParent() { }

	// RVA: 0xB9D950 Offset: 0xB9BF50 VA: 0x180B9D950
	public bool MoveToFirstChild() { }

	// RVA: 0xB9DBD0 Offset: 0xB9C1D0 VA: 0x180B9DBD0
	private bool MoveToNextSibling(XmlNode node) { }

	// RVA: 0xB9DC30 Offset: 0xB9C230 VA: 0x180B9DC30
	public bool MoveToNext() { }

	// RVA: 0xB9D8B0 Offset: 0xB9BEB0 VA: 0x180B9D8B0
	public bool MoveToElement() { }

	// RVA: 0xB9CB70 Offset: 0xB9B170 VA: 0x180B9CB70
	public string LookupNamespace(string prefix) { }

	// RVA: 0xB9B310 Offset: 0xB99910 VA: 0x180B9B310
	internal string DefaultLookupNamespace(string prefix) { }

	// RVA: 0xB9CE50 Offset: 0xB9B450 VA: 0x180B9CE50
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0xB9C270 Offset: 0xB9A870 VA: 0x180B9C270
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xB9DD30 Offset: 0xB9C330 VA: 0x180B9DD30
	public bool ReadAttributeValue(ref int level, ref bool bResolveEntity, ref XmlNodeType nt) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public XmlDocument get_Document() { }

}

internal struct XmlNodeReaderNavigator.VirtualAttribute // TypeDefIndex: 1975
{	// Fields
	internal string name; // 0x0
	internal string value; // 0x8

	// Methods

	// RVA: 0xF5AD0 Offset: 0xF4ED0 VA: 0x1800F5AD0
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

	// RVA: 0x11CF5E0 Offset: 0x11CDBE0 VA: 0x1811CF5E0
	public void .ctor(XmlNode node) { }

	// RVA: 0x11CE8D0 Offset: 0x11CCED0 VA: 0x1811CE8D0
	internal bool IsInReadingStates() { }

	// RVA: 0x11CF8E0 Offset: 0x11CDEE0 VA: 0x1811CF8E0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11CF820 Offset: 0x11CDE20 VA: 0x1811CF820 Slot: 7
	public override string get_Name() { }

	// RVA: 0x11CF7C0 Offset: 0x11CDDC0 VA: 0x1811CF7C0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x11CF880 Offset: 0x11CDE80 VA: 0x1811CF880 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x11CF8F0 Offset: 0x11CDEF0 VA: 0x1811CF8F0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x11CF980 Offset: 0x11CDF80 VA: 0x1811CF980 Slot: 11
	public override string get_Value() { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x11CF700 Offset: 0x11CDD00 VA: 0x1811CF700 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x11CF790 Offset: 0x11CDD90 VA: 0x1811CF790 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x11CF760 Offset: 0x11CDD60 VA: 0x1811CF760 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x11CFA40 Offset: 0x11CE040 VA: 0x1811CFA40 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x11CF9E0 Offset: 0x11CDFE0 VA: 0x1811CF9E0 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x11CF950 Offset: 0x11CDF50 VA: 0x1811CF950 Slot: 19
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11CF6C0 Offset: 0x11CDCC0 VA: 0x1811CF6C0 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x11CE780 Offset: 0x11CCD80 VA: 0x1811CE780 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x11CE7B0 Offset: 0x11CCDB0 VA: 0x1811CE7B0 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x11CE840 Offset: 0x11CCE40 VA: 0x1811CE840 Slot: 24
	public override string GetAttribute(int attributeIndex) { }

	// RVA: 0x11CEAC0 Offset: 0x11CD0C0 VA: 0x1811CEAC0 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x11CE920 Offset: 0x11CCF20 VA: 0x1811CE920 Slot: 26
	public override void MoveToAttribute(int attributeIndex) { }

	// RVA: 0x11CEC60 Offset: 0x11CD260 VA: 0x1811CEC60 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x11CED40 Offset: 0x11CD340 VA: 0x1811CED40 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x11CEB90 Offset: 0x11CD190 VA: 0x1811CEB90 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x11CF300 Offset: 0x11CD900 VA: 0x1811CF300 Slot: 31
	public override bool Read() { }

	// RVA: 0x11CF310 Offset: 0x11CD910 VA: 0x1811CF310
	private bool Read(bool fSkipChildren) { }

	// RVA: 0x11CF040 Offset: 0x11CD640 VA: 0x1811CF040
	private bool ReadNextNode(bool fSkipChildren) { }

	// RVA: 0x11CF500 Offset: 0x11CDB00 VA: 0x1811CF500
	private void SetEndOfFile() { }

	// RVA: 0x11CEE50 Offset: 0x11CD450 VA: 0x1811CEE50
	private bool ReadAtZeroLevel(bool fSkipChildren) { }

	// RVA: 0x11CEF10 Offset: 0x11CD510 VA: 0x1811CEF10
	private bool ReadForward(bool fSkipChildren) { }

	// RVA: 0x11CEE20 Offset: 0x11CD420 VA: 0x1811CEE20
	private void ReSetReadingMarks() { }

	// RVA: 0x11CF750 Offset: 0x11CDD50 VA: 0x1811CF750 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x11CE740 Offset: 0x11CCD40 VA: 0x1811CE740 Slot: 33
	public override void Close() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x11CF520 Offset: 0x11CDB20 VA: 0x1811CF520 Slot: 35
	public override void Skip() { }

	// RVA: 0x11CF250 Offset: 0x11CD850 VA: 0x1811CF250 Slot: 42
	public override string ReadString() { }

	// RVA: 0xBA41A0 Offset: 0xBA27A0 VA: 0x180BA41A0 Slot: 49
	public override bool get_HasAttributes() { }

	// RVA: 0x6C80B0 Offset: 0x6C66B0 VA: 0x1806C80B0 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x11CE8E0 Offset: 0x11CCEE0 VA: 0x1811CE8E0 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x11CF470 Offset: 0x11CDA70 VA: 0x1811CF470 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x11CEEC0 Offset: 0x11CD4C0 VA: 0x1811CEEC0 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x11CE750 Offset: 0x11CCD50 VA: 0x1811CE750
	private void FinishReadBinary() { }

	// RVA: 0x11CF530 Offset: 0x11CDB30 VA: 0x1811CF530 Slot: 53
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11CF5C0 Offset: 0x11CDBC0 VA: 0x1811CF5C0 Slot: 55
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x11CF550 Offset: 0x11CDB50 VA: 0x1811CF550 Slot: 54
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x11CF720 Offset: 0x11CDD20 VA: 0x1811CF720 Slot: 52
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

	// RVA: 0xB9F2B0 Offset: 0xB9D8B0 VA: 0x180B9F2B0
	internal void .ctor(string name, string publicId, string systemId, XmlDocument doc) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 6
	public override string get_Name() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xB9F360 Offset: 0xB9D960 VA: 0x180B9F360 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xB9F240 Offset: 0xB9D840 VA: 0x180B9F240 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0xB9F370 Offset: 0xB9D970 VA: 0x180B9F370 Slot: 40
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

	// RVA: 0xB9F8F0 Offset: 0xB9DEF0 VA: 0x180B9F8F0
	protected internal void .ctor(string target, string data, XmlDocument doc) { }

	// RVA: 0xB9F940 Offset: 0xB9DF40 VA: 0x180B9F940 Slot: 6
	public override string get_Name() { }

	// RVA: 0x95F920 Offset: 0x95DF20 VA: 0x18095F920 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 7
	public override string get_Value() { }

	// RVA: 0xB9FA70 Offset: 0xB9E070 VA: 0x180B9FA70 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0xB9F9A0 Offset: 0xB9DFA0 VA: 0x180B9F9A0
	public void set_Data(string value) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0xB9FA70 Offset: 0xB9E070 VA: 0x180B9FA70 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0xB9F990 Offset: 0xB9DF90 VA: 0x180B9F990 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xB9F860 Offset: 0xB9DE60 VA: 0x180B9F860 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xB9F8B0 Offset: 0xB9DEB0 VA: 0x180B9F8B0 Slot: 43
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

	// RVA: 0xBA4DF0 Offset: 0xBA33F0 VA: 0x180BA4DF0
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0xBA4EB0 Offset: 0xBA34B0 VA: 0x180BA4EB0 Slot: 6
	public override string get_Name() { }

	// RVA: 0xBA4EB0 Offset: 0xBA34B0 VA: 0x180BA4EB0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xBA4EE0 Offset: 0xBA34E0 VA: 0x180BA4EE0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBA4EF0 Offset: 0xBA34F0 VA: 0x180BA4EF0 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0xBA4D50 Offset: 0xBA3350 VA: 0x180BA4D50 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xBA4F90 Offset: 0xBA3590 VA: 0x180BA4F90 Slot: 7
	public override string get_Value() { }

	// RVA: 0xBA4FB0 Offset: 0xBA35B0 VA: 0x180BA4FB0 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0xBA4DB0 Offset: 0xBA33B0 VA: 0x180BA4DB0 Slot: 43
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

	// RVA: 0xBC90D0 Offset: 0xBC76D0 VA: 0x180BC90D0
	internal void .ctor(string strData) { }

	// RVA: 0xBC90C0 Offset: 0xBC76C0 VA: 0x180BC90C0
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0xBC90E0 Offset: 0xBC76E0 VA: 0x180BC90E0 Slot: 6
	public override string get_Name() { }

	// RVA: 0xBC90E0 Offset: 0xBC76E0 VA: 0x180BC90E0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xAC1DA0 Offset: 0xAC03A0 VA: 0x180AC1DA0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC9110 Offset: 0xBC7710 VA: 0x180BC9110 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0xBC9060 Offset: 0xBC7660 VA: 0x180BC9060 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xBA4F90 Offset: 0xBA3590 VA: 0x180BA4F90 Slot: 7
	public override string get_Value() { }

	// RVA: 0xBC91B0 Offset: 0xBC77B0 VA: 0x180BC91B0 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0xBA4DB0 Offset: 0xBA33B0 VA: 0x180BA4DB0 Slot: 43
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

	// RVA: 0x131F620 Offset: 0x131DC20 VA: 0x18131F620
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x9974E0 Offset: 0x995AE0 VA: 0x1809974E0 Slot: 56
	public override bool get_Specified() { }

	// RVA: 0x131F460 Offset: 0x131DA60 VA: 0x18131F460 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x131F630 Offset: 0x131DC30 VA: 0x18131F630 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x131F5D0 Offset: 0x131DBD0 VA: 0x18131F5D0 Slot: 21
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x131F5B0 Offset: 0x131DBB0 VA: 0x18131F5B0 Slot: 22
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x131F5F0 Offset: 0x131DBF0 VA: 0x18131F5F0 Slot: 23
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x131F440 Offset: 0x131DA40 VA: 0x18131F440 Slot: 25
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x131F610 Offset: 0x131DC10 VA: 0x18131F610 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x9974F0 Offset: 0x995AF0 VA: 0x1809974F0
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

	// RVA: 0x132C3D0 Offset: 0x132A9D0 VA: 0x18132C3D0
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x132C490 Offset: 0x132AA90 VA: 0x18132C490 Slot: 6
	public override string get_Name() { }

	// RVA: 0x132C490 Offset: 0x132AA90 VA: 0x18132C490 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x132C4C0 Offset: 0x132AAC0 VA: 0x18132C4C0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBA4EF0 Offset: 0xBA34F0 VA: 0x180BA4EF0 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0xBA4F90 Offset: 0xBA3590 VA: 0x180BA4F90 Slot: 7
	public override string get_Value() { }

	// RVA: 0x132C4D0 Offset: 0x132AAD0 VA: 0x18132C4D0 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x132C330 Offset: 0x132A930 VA: 0x18132C330 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x132C390 Offset: 0x132A990 VA: 0x18132C390 Slot: 43
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

	// RVA: 0xE58F30 Offset: 0xE57530 VA: 0x180E58F30
	private static object get_StaticLock() { }

	// RVA: 0xE58650 Offset: 0xE56C50 VA: 0x180E58650
	private static void InitInstance() { }

	// RVA: 0xE58D80 Offset: 0xE57380 VA: 0x180E58D80
	private static void SetProperties(string ranges, byte value) { }

	// RVA: 0xF1510 Offset: 0xF0910 VA: 0x1800F1510
	private void .ctor(byte[] charProperties) { }

	// RVA: 0xE58EB0 Offset: 0xE574B0 VA: 0x180E58EB0
	public static XmlCharType get_Instance() { }

	// RVA: 0x12C820 Offset: 0x12BC20 VA: 0x18012C820
	public bool IsWhiteSpace(char ch) { }

	// RVA: 0x12C400 Offset: 0x12B800 VA: 0x18012C400
	public bool IsNCNameSingleChar(char ch) { }

	// RVA: 0x12C7A0 Offset: 0x12BBA0 VA: 0x18012C7A0
	public bool IsStartNCNameSingleChar(char ch) { }

	// RVA: 0x12C490 Offset: 0x12B890 VA: 0x18012C490
	public bool IsNameSingleChar(char ch) { }

	// RVA: 0x12C340 Offset: 0x12B740 VA: 0x18012C340
	public bool IsCharData(char ch) { }

	// RVA: 0x12C6D0 Offset: 0x12BAD0 VA: 0x18012C6D0
	public bool IsPubidChar(char ch) { }

	// RVA: 0x12C7E0 Offset: 0x12BBE0 VA: 0x18012C7E0
	internal bool IsTextChar(char ch) { }

	// RVA: 0x12C380 Offset: 0x12B780 VA: 0x18012C380
	public bool IsLetter(char ch) { }

	// RVA: 0x12C3C0 Offset: 0x12B7C0 VA: 0x18012C3C0
	public bool IsNCNameCharXml4e(char ch) { }

	// RVA: 0x12C750 Offset: 0x12BB50 VA: 0x18012C750
	public bool IsStartNCNameCharXml4e(char ch) { }

	// RVA: 0x12C440 Offset: 0x12B840 VA: 0x18012C440
	public bool IsNameCharXml4e(char ch) { }

	// RVA: 0xE588B0 Offset: 0xE56EB0 VA: 0x180E588B0
	public static bool IsDigit(char ch) { }

	// RVA: 0xE588C0 Offset: 0xE56EC0 VA: 0x180E588C0
	internal static bool IsHighSurrogate(int ch) { }

	// RVA: 0xE588D0 Offset: 0xE56ED0 VA: 0x180E588D0
	internal static bool IsLowSurrogate(int ch) { }

	// RVA: 0xE58CF0 Offset: 0xE572F0 VA: 0x180E58CF0
	internal static bool IsSurrogate(int ch) { }

	// RVA: 0xE58620 Offset: 0xE56C20 VA: 0x180E58620
	internal static int CombineSurrogateChar(int lowChar, int highChar) { }

	// RVA: 0xE58E70 Offset: 0xE57470 VA: 0x180E58E70
	internal static void SplitSurrogateChar(int combinedChar, out char lowChar, out char highChar) { }

	// RVA: 0x12C640 Offset: 0x12BA40 VA: 0x18012C640
	internal bool IsOnlyWhitespace(string str) { }

	// RVA: 0x12C5B0 Offset: 0x12B9B0 VA: 0x18012C5B0
	internal int IsOnlyWhitespaceWithPos(string str) { }

	// RVA: 0x12C4E0 Offset: 0x12B8E0 VA: 0x18012C4E0
	internal int IsOnlyCharData(string str) { }

	// RVA: 0xE58AD0 Offset: 0xE570D0 VA: 0x180E58AD0
	internal static bool IsOnlyDigits(string str, int startPos, int len) { }

	// RVA: 0x12C6E0 Offset: 0x12BAE0 VA: 0x18012C6E0
	internal int IsPublicId(string str) { }

	// RVA: 0xE58640 Offset: 0xE56C40 VA: 0x180E58640
	private static bool InRange(int value, int start, int end) { }

}

internal static class XmlComplianceUtil // TypeDefIndex: 2002
{	// Methods

	// RVA: 0xE597C0 Offset: 0xE57DC0 VA: 0x180E597C0
	public static string NonCDataNormalize(string value) { }

	// RVA: 0xE59610 Offset: 0xE57C10 VA: 0x180E59610
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

	// RVA: 0xE5BCC0 Offset: 0xE5A2C0 VA: 0x180E5BCC0
	public static string EncodeName(string name) { }

	// RVA: 0xE5BC60 Offset: 0xE5A260 VA: 0x180E5BC60
	public static string EncodeLocalName(string name) { }

	// RVA: 0xE5B390 Offset: 0xE59990 VA: 0x180E5B390
	public static string DecodeName(string name) { }

	// RVA: 0xE5BD20 Offset: 0xE5A320 VA: 0x180E5BD20
	private static string EncodeName(string name, bool first, bool local) { }

	// RVA: 0xE5C770 Offset: 0xE5AD70 VA: 0x180E5C770
	private static int FromHex(char digit) { }

	// RVA: 0xE5C630 Offset: 0xE5AC30 VA: 0x180E5C630
	internal static byte[] FromBinHexString(string s) { }

	// RVA: 0xE5C6E0 Offset: 0xE5ACE0 VA: 0x180E5C6E0
	internal static byte[] FromBinHexString(string s, bool allowOddCount) { }

	// RVA: 0xE5CA30 Offset: 0xE5B030 VA: 0x180E5CA30
	internal static string ToBinHexString(byte[] inArray) { }

	// RVA: 0xE61110 Offset: 0xE5F710 VA: 0x180E61110
	public static string VerifyName(string name) { }

	// RVA: 0xE60910 Offset: 0xE5EF10 VA: 0x180E60910
	internal static Exception TryVerifyName(string name) { }

	// RVA: 0xE61240 Offset: 0xE5F840 VA: 0x180E61240
	internal static string VerifyQName(string name, ExceptionType exceptionType) { }

	// RVA: 0xE60FA0 Offset: 0xE5F5A0 VA: 0x180E60FA0
	public static string VerifyNCName(string name) { }

	// RVA: 0xE60E60 Offset: 0xE5F460 VA: 0x180E60E60
	internal static string VerifyNCName(string name, ExceptionType exceptionType) { }

	// RVA: 0xE60650 Offset: 0xE5EC50 VA: 0x180E60650
	internal static Exception TryVerifyNCName(string name) { }

	// RVA: 0xE61400 Offset: 0xE5FA00 VA: 0x180E61400
	public static string VerifyTOKEN(string token) { }

	// RVA: 0xE60AF0 Offset: 0xE5F0F0 VA: 0x180E60AF0
	internal static Exception TryVerifyTOKEN(string token) { }

	// RVA: 0xE60740 Offset: 0xE5ED40 VA: 0x180E60740
	internal static Exception TryVerifyNMTOKEN(string name) { }

	// RVA: 0xE60A30 Offset: 0xE5F030 VA: 0x180E60A30
	internal static Exception TryVerifyNormalizedString(string str) { }

	// RVA: 0xE5DD40 Offset: 0xE5C340 VA: 0x180E5DD40
	public static string ToString(bool value) { }

	// RVA: 0xE5D810 Offset: 0xE5BE10 VA: 0x180E5D810
	public static string ToString(char value) { }

	// RVA: 0xE5DE10 Offset: 0xE5C410 VA: 0x180E5DE10
	public static string ToString(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0xE5DEB0 Offset: 0xE5C4B0 VA: 0x180E5DEB0
	public static string ToString(sbyte value) { }

	// RVA: 0xE5DE40 Offset: 0xE5C440 VA: 0x180E5DE40
	public static string ToString(short value) { }

	// RVA: 0xE5DC10 Offset: 0xE5C210 VA: 0x180E5DC10
	public static string ToString(int value) { }

	// RVA: 0xE5DD80 Offset: 0xE5C380 VA: 0x180E5DD80
	public static string ToString(long value) { }

	// RVA: 0xE5DBE0 Offset: 0xE5C1E0 VA: 0x180E5DBE0
	public static string ToString(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0xE5DBA0 Offset: 0xE5C1A0 VA: 0x180E5DBA0
	public static string ToString(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0xE5DC40 Offset: 0xE5C240 VA: 0x180E5DC40
	public static string ToString(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0xE5D7E0 Offset: 0xE5BDE0 VA: 0x180E5D7E0
	public static string ToString(ulong value) { }

	// RVA: 0xE5DC70 Offset: 0xE5C270 VA: 0x180E5DC70
	public static string ToString(float value) { }

	// RVA: 0xE5D8A0 Offset: 0xE5BEA0 VA: 0x180E5D8A0
	public static string ToString(double value) { }

	// RVA: 0xE5DDB0 Offset: 0xE5C3B0 VA: 0x180E5DDB0
	public static string ToString(TimeSpan value) { }

	// RVA: 0xE5D830 Offset: 0xE5BE30 VA: 0x180E5D830
	public static string ToString(DateTime value, string format) { }

	// RVA: 0xE5D9D0 Offset: 0xE5BFD0 VA: 0x180E5D9D0
	public static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0xE5DE70 Offset: 0xE5C470 VA: 0x180E5DE70
	public static string ToString(DateTimeOffset value) { }

	// RVA: 0xE5DBD0 Offset: 0xE5C1D0 VA: 0x180E5DBD0
	public static string ToString(Guid value) { }

	// RVA: 0xE5CAA0 Offset: 0xE5B0A0 VA: 0x180E5CAA0
	public static bool ToBoolean(string s) { }

	// RVA: 0xE5E710 Offset: 0xE5CD10 VA: 0x180E5E710
	internal static Exception TryToBoolean(string s, out bool result) { }

	// RVA: 0xE5CCA0 Offset: 0xE5B2A0 VA: 0x180E5CCA0
	public static char ToChar(string s) { }

	// RVA: 0xE5EAF0 Offset: 0xE5D0F0 VA: 0x180E5EAF0
	internal static Exception TryToChar(string s, out char result) { }

	// RVA: 0xE5D290 Offset: 0xE5B890 VA: 0x180E5D290
	public static Decimal ToDecimal(string s) { }

	// RVA: 0xE5EC80 Offset: 0xE5D280 VA: 0x180E5EC80
	internal static Exception TryToDecimal(string s, out Decimal result) { }

	// RVA: 0xE5D590 Offset: 0xE5BB90 VA: 0x180E5D590
	internal static Decimal ToInteger(string s) { }

	// RVA: 0xE5F830 Offset: 0xE5DE30 VA: 0x180E5F830
	internal static Exception TryToInteger(string s, out Decimal result) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0xE5D620 Offset: 0xE5BC20 VA: 0x180E5D620
	public static sbyte ToSByte(string s) { }

	// RVA: 0xE5F9E0 Offset: 0xE5DFE0 VA: 0x180E5F9E0
	internal static Exception TryToSByte(string s, out sbyte result) { }

	// RVA: 0xE5D500 Offset: 0xE5BB00 VA: 0x180E5D500
	public static short ToInt16(string s) { }

	// RVA: 0xE5F3B0 Offset: 0xE5D9B0 VA: 0x180E5F3B0
	internal static Exception TryToInt16(string s, out short result) { }

	// RVA: 0xE5D530 Offset: 0xE5BB30 VA: 0x180E5D530
	public static int ToInt32(string s) { }

	// RVA: 0xE5F530 Offset: 0xE5DB30 VA: 0x180E5F530
	internal static Exception TryToInt32(string s, out int result) { }

	// RVA: 0xE5D560 Offset: 0xE5BB60 VA: 0x180E5D560
	public static long ToInt64(string s) { }

	// RVA: 0xE5F6B0 Offset: 0xE5DCB0 VA: 0x180E5F6B0
	internal static Exception TryToInt64(string s, out long result) { }

	// RVA: 0xE5CC70 Offset: 0xE5B270 VA: 0x180E5CC70
	public static byte ToByte(string s) { }

	// RVA: 0xE5E970 Offset: 0xE5CF70 VA: 0x180E5E970
	internal static Exception TryToByte(string s, out byte result) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0xE5E020 Offset: 0xE5C620 VA: 0x180E5E020
	public static ushort ToUInt16(string s) { }

	// RVA: 0xE5FEB0 Offset: 0xE5E4B0 VA: 0x180E5FEB0
	internal static Exception TryToUInt16(string s, out ushort result) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0xE5E050 Offset: 0xE5C650 VA: 0x180E5E050
	public static uint ToUInt32(string s) { }

	// RVA: 0xE60030 Offset: 0xE5E630 VA: 0x180E60030
	internal static Exception TryToUInt32(string s, out uint result) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0xE5E080 Offset: 0xE5C680 VA: 0x180E5E080
	public static ulong ToUInt64(string s) { }

	// RVA: 0xE601B0 Offset: 0xE5E7B0 VA: 0x180E601B0
	internal static Exception TryToUInt64(string s, out ulong result) { }

	// RVA: 0xE5D650 Offset: 0xE5BC50 VA: 0x180E5D650
	public static float ToSingle(string s) { }

	// RVA: 0xE5FB60 Offset: 0xE5E160 VA: 0x180E5FB60
	internal static Exception TryToSingle(string s, out float result) { }

	// RVA: 0xE5D320 Offset: 0xE5B920 VA: 0x180E5D320
	public static double ToDouble(string s) { }

	// RVA: 0xE5EE30 Offset: 0xE5D430 VA: 0x180E5EE30
	internal static Exception TryToDouble(string s, out double result) { }

	// RVA: 0xE5E340 Offset: 0xE5C940 VA: 0x180E5E340
	internal static double ToXPathDouble(object o) { }

	// RVA: 0xE5DEE0 Offset: 0xE5C4E0 VA: 0x180E5DEE0
	public static TimeSpan ToTimeSpan(string s) { }

	// RVA: 0xE5FDF0 Offset: 0xE5E3F0 VA: 0x180E5FDF0
	internal static Exception TryToTimeSpan(string s, out TimeSpan result) { }

	// RVA: 0xE615F0 Offset: 0xE5FBF0 VA: 0x180E615F0
	private static string[] get_AllDateTimeFormats() { }

	// RVA: 0xE59AB0 Offset: 0xE580B0 VA: 0x180E59AB0
	private static void CreateAllDateTimeFormats() { }

	[ObsoleteAttribute] // RVA: 0x83BA0 Offset: 0x82FA0 VA: 0x180083BA0
	// RVA: 0xE5D040 Offset: 0xE5B640 VA: 0x180E5D040
	public static DateTime ToDateTime(string s) { }

	// RVA: 0xE5D1E0 Offset: 0xE5B7E0 VA: 0x180E5D1E0
	public static DateTime ToDateTime(string s, string[] formats) { }

	// RVA: 0xE5CE30 Offset: 0xE5B430 VA: 0x180E5CE30
	public static DateTime ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0xE5CD60 Offset: 0xE5B360 VA: 0x180E5CD60
	public static DateTimeOffset ToDateTimeOffset(string s) { }

	// RVA: 0xE5D4E0 Offset: 0xE5BAE0 VA: 0x180E5D4E0
	public static Guid ToGuid(string s) { }

	// RVA: 0xE5F110 Offset: 0xE5D710 VA: 0x180E5F110
	internal static Exception TryToGuid(string s, out Guid result) { }

	// RVA: 0xE5C940 Offset: 0xE5AF40 VA: 0x180E5C940
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0xE5C9B0 Offset: 0xE5AFB0 VA: 0x180E5C9B0
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0xE5E0B0 Offset: 0xE5C6B0 VA: 0x180E5E0B0
	internal static Uri ToUri(string s) { }

	// RVA: 0xE60330 Offset: 0xE5E930 VA: 0x180E60330
	internal static Exception TryToUri(string s, out Uri result) { }

	// RVA: 0xE5C8A0 Offset: 0xE5AEA0 VA: 0x180E5C8A0
	internal static bool StrEqual(char[] chars, int strPos1, int strLen1, string str2) { }

	// RVA: 0xE5E690 Offset: 0xE5CC90 VA: 0x180E5E690
	internal static string TrimString(string value) { }

	// RVA: 0xE5E610 Offset: 0xE5CC10 VA: 0x180E5E610
	internal static string TrimStringStart(string value) { }

	// RVA: 0xE5E590 Offset: 0xE5CB90 VA: 0x180E5E590
	internal static string TrimStringEnd(string value) { }

	// RVA: 0xE5C820 Offset: 0xE5AE20 VA: 0x180E5C820
	internal static string[] SplitString(string value) { }

	// RVA: 0xE5C7A0 Offset: 0xE5ADA0 VA: 0x180E5C7A0
	internal static bool IsNegativeZero(double value) { }

	// RVA: 0xE5BC50 Offset: 0xE5A250 VA: 0x180E5BC50
	private static long DoubleToInt64Bits(double value) { }

	// RVA: 0xE60BF0 Offset: 0xE5F1F0 VA: 0x180E60BF0
	internal static void VerifyCharData(string data, ExceptionType invCharExceptionType, ExceptionType invSurrogateExceptionType) { }

	// RVA: 0xE5A510 Offset: 0xE58B10 VA: 0x180E5A510
	internal static Exception CreateException(string res, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0xE5A5E0 Offset: 0xE58BE0 VA: 0x180E5A5E0
	internal static Exception CreateException(string res, string arg, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0xE5A7E0 Offset: 0xE58DE0 VA: 0x180E5A7E0
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType) { }

	// RVA: 0xE5A720 Offset: 0xE58D20 VA: 0x180E5A720
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0xE5B090 Offset: 0xE59690 VA: 0x180E5B090
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi) { }

	// RVA: 0xE5B140 Offset: 0xE59740 VA: 0x180E5B140
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType) { }

	// RVA: 0xE5B1C0 Offset: 0xE597C0 VA: 0x180E5B1C0
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0xE5AD10 Offset: 0xE59310 VA: 0x180E5AD10
	internal static Exception CreateInvalidHighSurrogateCharException(char hi) { }

	// RVA: 0xE5AB20 Offset: 0xE59120 VA: 0x180E5AB20
	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType) { }

	// RVA: 0xE5AD70 Offset: 0xE59370 VA: 0x180E5AD70
	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0xE5AA80 Offset: 0xE59080 VA: 0x180E5AA80
	internal static Exception CreateInvalidCharException(string data, int invCharPos, ExceptionType exceptionType) { }

	// RVA: 0xE5A860 Offset: 0xE58E60 VA: 0x180E5A860
	internal static Exception CreateInvalidCharException(char invChar, char nextChar) { }

	// RVA: 0xE5A9A0 Offset: 0xE58FA0 VA: 0x180E5A9A0
	internal static Exception CreateInvalidCharException(char invChar, char nextChar, ExceptionType exceptionType) { }

	// RVA: 0xE5AFE0 Offset: 0xE595E0 VA: 0x180E5AFE0
	internal static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType) { }

	// RVA: 0xE5AF30 Offset: 0xE59530 VA: 0x180E5AF30
	internal static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName) { }

	// RVA: 0xE61510 Offset: 0xE5FB10 VA: 0x180E61510
	private static void .cctor() { }

}

internal class XmlDownloadManager // TypeDefIndex: 2006
{	// Fields
	private Hashtable connections; // 0x10

	// Methods

	// RVA: 0x11BBBF0 Offset: 0x11BA1F0 VA: 0x1811BBBF0
	internal Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x11BB540 Offset: 0x11B9B40 VA: 0x1811BB540
	private Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x11BBCF0 Offset: 0x11BA2F0 VA: 0x1811BBCF0
	internal void Remove(string host) { }

	// RVA: 0x11BB9A0 Offset: 0x11B9FA0 VA: 0x1811BB9A0
	internal Task<Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	[AsyncStateMachineAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x11BB3E0 Offset: 0x11B99E0 VA: 0x1811BB3E0
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

	// RVA: 0x11BA910 Offset: 0x11B8F10 VA: 0x1811BA910
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

	// RVA: 0x1D0D90 Offset: 0x1D0190 VA: 0x1801D0D90 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1D0DA0 Offset: 0x1D01A0 VA: 0x1801D0DA0 Slot: 5
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

	// RVA: 0xBA4830 Offset: 0xBA2E30 VA: 0x180BA4830
	internal void .ctor(Stream stream, XmlDownloadManager downloadManager, string host) { }

	// RVA: 0xBA4630 Offset: 0xBA2C30 VA: 0x180BA4630 Slot: 1
	protected override void Finalize() { }

	// RVA: 0xBA4490 Offset: 0xBA2A90 VA: 0x180BA4490 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0xBA4430 Offset: 0xBA2A30 VA: 0x180BA4430 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0xBA4460 Offset: 0xBA2A60 VA: 0x180BA4460 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0xBA45D0 Offset: 0xBA2BD0 VA: 0x180BA45D0 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0xBA4600 Offset: 0xBA2C00 VA: 0x180BA4600 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0xBA46E0 Offset: 0xBA2CE0 VA: 0x180BA46E0 Slot: 18
	public override void Flush() { }

	// RVA: 0xBA4740 Offset: 0xBA2D40 VA: 0x180BA4740 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0xBA4710 Offset: 0xBA2D10 VA: 0x180BA4710 Slot: 28
	public override int ReadByte() { }

	// RVA: 0xBA4770 Offset: 0xBA2D70 VA: 0x180BA4770 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xBA47A0 Offset: 0xBA2DA0 VA: 0x180BA47A0 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0xBA4800 Offset: 0xBA2E00 VA: 0x180BA4800 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0xBA47D0 Offset: 0xBA2DD0 VA: 0x180BA47D0 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0xBA48E0 Offset: 0xBA2EE0 VA: 0x180BA48E0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0xBA4910 Offset: 0xBA2F10 VA: 0x180BA4910 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0xBA4940 Offset: 0xBA2F40 VA: 0x180BA4940 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0xBA4970 Offset: 0xBA2F70 VA: 0x180BA4970 Slot: 10
	public override long get_Length() { }

	// RVA: 0xBA49A0 Offset: 0xBA2FA0 VA: 0x180BA49A0 Slot: 11
	public override long get_Position() { }

	// RVA: 0xBA49D0 Offset: 0xBA2FD0 VA: 0x180BA49D0 Slot: 12
	public override void set_Position(long value) { }

}

internal class XmlCachedStream : MemoryStream // TypeDefIndex: 2011
{	// Fields
	private Uri uri; // 0x50

	// Methods

	// RVA: 0xE584C0 Offset: 0xE56AC0 VA: 0x180E584C0
	internal void .ctor(Uri uri, Stream stream) { }

}

public class XmlException : SystemException // TypeDefIndex: 2024
{	// Fields
	private string res; // 0x88
	private string[] args; // 0x90
	private int lineNumber; // 0x98
	private int linePosition; // 0x9C
	[OptionalFieldAttribute] // RVA: 0x7B620 Offset: 0x7AA20 VA: 0x18007B620
	private string sourceUri; // 0xA0
	private string message; // 0xA8

	// Properties
	public int LineNumber { get; }
	public int LinePosition { get; }
	public override string Message { get; }
	internal string ResString { get; }

	// Methods

	// RVA: 0x11C6800 Offset: 0x11C4E00 VA: 0x1811C6800
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11C5C50 Offset: 0x11C4250 VA: 0x1811C5C50 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11C6300 Offset: 0x11C4900 VA: 0x1811C6300
	public void .ctor() { }

	// RVA: 0x11C6410 Offset: 0x11C4A10 VA: 0x1811C6410
	public void .ctor(string message) { }

	// RVA: 0x11C6CE0 Offset: 0x11C52E0 VA: 0x1811C6CE0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x11C67D0 Offset: 0x11C4DD0 VA: 0x1811C67D0
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x11C5FF0 Offset: 0x11C45F0 VA: 0x1811C5FF0
	internal void .ctor(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11C6610 Offset: 0x11C4C10 VA: 0x1811C6610
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x11C6BC0 Offset: 0x11C51C0 VA: 0x1811C6BC0
	internal void .ctor(string res, string arg) { }

	// RVA: 0x11C5D60 Offset: 0x11C4360 VA: 0x1811C5D60
	internal void .ctor(string res, string arg, string sourceUri) { }

	// RVA: 0x11C6640 Offset: 0x11C4C40 VA: 0x1811C6640
	internal void .ctor(string res, string arg, IXmlLineInfo lineInfo) { }

	// RVA: 0x11C5F20 Offset: 0x11C4520 VA: 0x1811C5F20
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo) { }

	// RVA: 0x11C5E50 Offset: 0x11C4450 VA: 0x1811C5E50
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo, string sourceUri) { }

	// RVA: 0x11C6200 Offset: 0x11C4800 VA: 0x1811C6200
	internal void .ctor(string res, string arg, int lineNumber, int linePosition) { }

	// RVA: 0x11C6510 Offset: 0x11C4B10 VA: 0x1811C6510
	internal void .ctor(string res, string arg, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11C6D10 Offset: 0x11C5310 VA: 0x1811C6D10
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x11C6CA0 Offset: 0x11C52A0 VA: 0x1811C6CA0
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11C67A0 Offset: 0x11C4DA0 VA: 0x1811C67A0
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x11C6440 Offset: 0x11C4A40 VA: 0x1811C6440
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11C5B20 Offset: 0x11C4120 VA: 0x1811C5B20
	private static string FormatUserMessage(string message, int lineNumber, int linePosition) { }

	// RVA: 0x11C5900 Offset: 0x11C3F00 VA: 0x1811C5900
	private static string CreateMessage(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x11C5470 Offset: 0x11C3A70 VA: 0x1811C5470
	internal static string[] BuildCharExceptionArgs(string data, int invCharIndex) { }

	// RVA: 0x11C54D0 Offset: 0x11C3AD0 VA: 0x1811C54D0
	internal static string[] BuildCharExceptionArgs(char[] data, int length, int invCharIndex) { }

	// RVA: 0x11C5550 Offset: 0x11C3B50 VA: 0x1811C5550
	internal static string[] BuildCharExceptionArgs(char invChar, char nextChar) { }

	// RVA: 0xB9B270 Offset: 0xB99870 VA: 0x180B9B270
	public int get_LineNumber() { }

	// RVA: 0xB9B280 Offset: 0xB99880 VA: 0x180B9B280
	public int get_LinePosition() { }

	// RVA: 0x11C6D40 Offset: 0x11C5340 VA: 0x1811C6D40 Slot: 5
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

	// RVA: 0x11CE370 Offset: 0x11CC970 VA: 0x1811CE370
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 8
	public virtual XmlNameTable get_NameTable() { }

	// RVA: 0x11CE5E0 Offset: 0x11CCBE0 VA: 0x1811CE5E0 Slot: 9
	public virtual string get_DefaultNamespace() { }

	// RVA: 0xEADF40 Offset: 0xEAC540 VA: 0x180EADF40 Slot: 10
	public virtual void PushScope() { }

	// RVA: 0x11CE0C0 Offset: 0x11CC6C0 VA: 0x1811CE0C0 Slot: 11
	public virtual bool PopScope() { }

	// RVA: 0x11CD6E0 Offset: 0x11CBCE0 VA: 0x1811CD6E0 Slot: 12
	public virtual void AddNamespace(string prefix, string uri) { }

	// RVA: 0x11CE1C0 Offset: 0x11CC7C0 VA: 0x1811CE1C0 Slot: 13
	public virtual void RemoveNamespace(string prefix, string uri) { }

	// RVA: 0x11CDAF0 Offset: 0x11CC0F0 VA: 0x1811CDAF0 Slot: 14
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x11CDC20 Offset: 0x11CC220 VA: 0x1811CDC20 Slot: 15
	public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11CDF80 Offset: 0x11CC580 VA: 0x1811CDF80 Slot: 16
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0x11CDDB0 Offset: 0x11CC3B0 VA: 0x1811CDDB0
	private int LookupNamespaceDecl(string prefix) { }

	// RVA: 0x11CDFE0 Offset: 0x11CC5E0 VA: 0x1811CDFE0 Slot: 17
	public virtual string LookupPrefix(string uri) { }

}

private struct XmlNamespaceManager.NamespaceDeclaration // TypeDefIndex: 2028
{	// Fields
	public string prefix; // 0x0
	public string uri; // 0x8
	public int scopeId; // 0x10
	public int previousNsIndex; // 0x14

	// Methods

	// RVA: 0x1D0B40 Offset: 0x1CFF40 VA: 0x1801D0B40
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

	// RVA: 0xBA0690 Offset: 0xB9EC90 VA: 0x180BA0690
	public void .ctor() { }

	// RVA: 0xBA05C0 Offset: 0xB9EBC0 VA: 0x180BA05C0
	public void .ctor(string name) { }

	// RVA: 0xBA0510 Offset: 0xB9EB10 VA: 0x180BA0510
	public void .ctor(string name, string ns) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Namespace() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Name() { }

	// RVA: 0xB9FE40 Offset: 0xB9E440 VA: 0x180B9FE40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xBA0750 Offset: 0xB9ED50 VA: 0x180BA0750
	public bool get_IsEmpty() { }

	// RVA: 0xBA02D0 Offset: 0xB9E8D0 VA: 0x180BA02D0 Slot: 3
	public override string ToString() { }

	// RVA: 0xB9FB80 Offset: 0xB9E180 VA: 0x180B9FB80 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xBA0790 Offset: 0xB9ED90 VA: 0x180BA0790
	public static bool op_Equality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0xBA0800 Offset: 0xB9EE00 VA: 0x180BA0800
	public static bool op_Inequality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0xBA0260 Offset: 0xB9E860 VA: 0x180BA0260
	public static string ToString(string name, string ns) { }

	// RVA: 0xB9FCB0 Offset: 0xB9E2B0 VA: 0x180B9FCB0
	private static XmlQualifiedName.HashCodeOfStringDelegate GetHashCodeDelegate() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private static bool IsRandomizedHashingDisabled() { }

	// RVA: 0xB9FE10 Offset: 0xB9E410 VA: 0x180B9FE10
	private static int GetHashCodeOfString(string s, int length, long additionalEntropy) { }

	// RVA: 0xBA0090 Offset: 0xB9E690 VA: 0x180BA0090
	internal void Init(string name, string ns) { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	internal void SetNamespace(string ns) { }

	// RVA: 0xBA0330 Offset: 0xB9E930 VA: 0x180BA0330
	internal void Verify() { }

	// RVA: 0xB9FA80 Offset: 0xB9E080 VA: 0x180B9FA80
	internal void Atomize(XmlNameTable nameTable) { }

	// RVA: 0xBA00D0 Offset: 0xB9E6D0 VA: 0x180BA00D0
	internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, out string prefix) { }

	// RVA: 0xB9FB00 Offset: 0xB9E100 VA: 0x180B9FB00
	internal XmlQualifiedName Clone() { }

	// RVA: 0xBA03D0 Offset: 0xB9E9D0 VA: 0x180BA03D0
	private static void .cctor() { }

}

private sealed class XmlQualifiedName.HashCodeOfStringDelegate : MulticastDelegate // TypeDefIndex: 2031
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xB9A740 Offset: 0xB98D40 VA: 0x180B9A740 Slot: 12
	public virtual int Invoke(string s, int sLen, long additionalEntropy) { }

	// RVA: 0xB9A670 Offset: 0xB98C70 VA: 0x180B9A670 Slot: 13
	public virtual IAsyncResult BeginInvoke(string s, int sLen, long additionalEntropy, AsyncCallback callback, object object) { }

	// RVA: 0xB9A710 Offset: 0xB98D10 VA: 0x180B9A710 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

public abstract class XmlResolver // TypeDefIndex: 2032
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn);

	// RVA: 0xBA4A50 Offset: 0xBA3050 VA: 0x180BA4A50 Slot: 5
	public virtual Uri ResolveUri(Uri baseUri, string relativeUri) { }

	// RVA: 0xBA4C30 Offset: 0xBA3230 VA: 0x180BA4C30 Slot: 6
	public virtual bool SupportsType(Uri absoluteUri, Type type) { }

	// RVA: 0xBA4A00 Offset: 0xBA3000 VA: 0x180BA4A00 Slot: 7
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

	// RVA: 0x131F930 Offset: 0x131DF30 VA: 0x18131F930
	private static XmlDownloadManager get_DownloadManager() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0x131F790 Offset: 0x131DD90 VA: 0x18131F790 Slot: 4
	public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x131F920 Offset: 0x131DF20 VA: 0x18131F920 Slot: 5
	public override Uri ResolveUri(Uri baseUri, string relativeUri) { }

	[AsyncStateMachineAttribute] // RVA: 0x84330 Offset: 0x83730 VA: 0x180084330
	// RVA: 0x131F650 Offset: 0x131DC50 VA: 0x18131F650 Slot: 7
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

	// RVA: 0x1E1310 Offset: 0x1E0710 VA: 0x1801E1310 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1E1320 Offset: 0x1E0720 VA: 0x1801E1320 Slot: 5
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

	// RVA: 0x9974E0 Offset: 0x995AE0 VA: 0x1809974E0
	internal bool get_HasLineInfo() { }

	// RVA: 0xE50330 Offset: 0xE4E930 VA: 0x180E50330
	internal int GetXmlNamespaceNode(out XPathNode[] pageXmlNmsp) { }

	// RVA: 0xE50360 Offset: 0xE4E960 VA: 0x180E50360
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

	// RVA: 0xE50B60 Offset: 0xE4F160 VA: 0x180E50B60
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE50840 Offset: 0xE4EE40 VA: 0x180E50840 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE50A60 Offset: 0xE4F060 VA: 0x180E50A60
	public void .ctor() { }

	// RVA: 0xE50980 Offset: 0xE4EF80 VA: 0x180E50980
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0xE50620 Offset: 0xE4EC20 VA: 0x180E50620
	internal static XPathException Create(string res) { }

	// RVA: 0xE50500 Offset: 0xE4EB00 VA: 0x180E50500
	internal static XPathException Create(string res, string arg) { }

	// RVA: 0xE506C0 Offset: 0xE4ECC0 VA: 0x180E506C0
	internal static XPathException Create(string res, string arg, string arg2) { }

	// RVA: 0xE50DA0 Offset: 0xE4F3A0 VA: 0x180E50DA0
	private void .ctor(string res, string[] args) { }

	// RVA: 0xE50900 Offset: 0xE4EF00 VA: 0x180E50900
	private void .ctor(string res, string[] args, Exception inner) { }

	// RVA: 0xE50460 Offset: 0xE4EA60 VA: 0x180E50460
	private static string CreateMessage(string res, string[] args) { }

	// RVA: 0xE50E20 Offset: 0xE4F420 VA: 0x180E50E20 Slot: 5
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

	// RVA: 0xE50E40 Offset: 0xE4F440 VA: 0x180E50E40 Slot: 13
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

	// RVA: 0x95F830 Offset: 0x95DE30 VA: 0x18095F830 Slot: 3
	public override string ToString() { }

	// RVA: 0xE52730 Offset: 0xE50D30 VA: 0x180E52730 Slot: 4
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0xE51AF0 Offset: 0xE500F0 VA: 0x180E51AF0 Slot: 6
	public override object get_TypedValue() { }

	// RVA: 0xE52650 Offset: 0xE50C50 VA: 0x180E52650 Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0xE51CF0 Offset: 0xE502F0 VA: 0x180E51CF0 Slot: 8
	public override bool get_ValueAsBoolean() { }

	// RVA: 0xE51ED0 Offset: 0xE504D0 VA: 0x180E51ED0 Slot: 9
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0xE520B0 Offset: 0xE506B0 VA: 0x180E520B0 Slot: 10
	public override double get_ValueAsDouble() { }

	// RVA: 0xE52290 Offset: 0xE50890 VA: 0x180E52290 Slot: 11
	public override int get_ValueAsInt() { }

	// RVA: 0xE52470 Offset: 0xE50A70 VA: 0x180E52470 Slot: 12
	public override long get_ValueAsLong() { }

	// RVA: 0xE51760 Offset: 0xE4FD60 VA: 0x180E51760 Slot: 14
	public override object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xE51740 Offset: 0xE4FD40 VA: 0x180E51740 Slot: 15
	private object System.ICloneable.Clone() { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract XmlNameTable get_NameTable();

	// RVA: 0xE51320 Offset: 0xE4F920 VA: 0x180E51320 Slot: 20
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0xE514A0 Offset: 0xE4FAA0 VA: 0x180E514A0 Slot: 21
	public virtual string LookupPrefix(string namespaceURI) { }

	// RVA: 0xE51140 Offset: 0xE4F740 VA: 0x180E51140 Slot: 22
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

	// RVA: 0xE516A0 Offset: 0xE4FCA0 VA: 0x180E516A0 Slot: 29
	public virtual bool MoveToNamespace(string name) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract bool MoveToParent();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract bool IsSamePosition(XPathNavigator other);

	// RVA: 0xE51AB0 Offset: 0xE500B0 VA: 0x180E51AB0 Slot: 34
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xE51310 Offset: 0xE4F910 VA: 0x180E51310
	internal static bool IsText(XPathNodeType type) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0xE51980 Offset: 0xE4FF80 VA: 0x180E51980
	private static void .cctor() { }

}

internal class XPathNavigatorKeyComparer : IEqualityComparer // TypeDefIndex: 2042
{	// Methods

	// RVA: 0xE50E60 Offset: 0xE4F460 VA: 0x180E50E60 Slot: 4
	private bool System.Collections.IEqualityComparer.Equals(object obj1, object obj2) { }

	// RVA: 0xE50F40 Offset: 0xE4F540 VA: 0x180E50F40 Slot: 5
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

	// RVA: 0xE66EE0 Offset: 0xE654E0 VA: 0x180E66EE0
	public void Add(string prefix, string ns) { }

	// RVA: 0xE66E30 Offset: 0xE65430 VA: 0x180E66E30
	internal void AddInternal(string prefix, string ns) { }

	// RVA: 0xE67130 Offset: 0xE65730 VA: 0x180E67130
	public XmlQualifiedName[] ToArray() { }

	// RVA: 0xE67220 Offset: 0xE65820 VA: 0x180E67220
	public int get_Count() { }

	// RVA: 0xE672B0 Offset: 0xE658B0 VA: 0x180E672B0
	internal ArrayList get_NamespaceList() { }

	// RVA: 0xE675D0 Offset: 0xE65BD0 VA: 0x180E675D0
	internal Hashtable get_Namespaces() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	internal void set_Namespaces(Hashtable value) { }

}

public sealed class XmlAttributeEventHandler : MulticastDelegate // TypeDefIndex: 2046
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE45C0 Offset: 0xAE2BC0 VA: 0x180AE45C0 Slot: 12
	public virtual void Invoke(object sender, XmlAttributeEventArgs e) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
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

	// RVA: 0x110C830 Offset: 0x110AE30 VA: 0x18110C830
	internal void .ctor(XmlAttribute attr, int lineNumber, int linePosition, object o, string qnames) { }

}

public sealed class XmlElementEventHandler : MulticastDelegate // TypeDefIndex: 2048
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE45C0 Offset: 0xAE2BC0 VA: 0x180AE45C0 Slot: 12
	public virtual void Invoke(object sender, XmlElementEventArgs e) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
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

	// RVA: 0x1688130 Offset: 0x1686730 VA: 0x181688130
	internal void .ctor(XmlElement elem, int lineNumber, int linePosition, object o, string qnames) { }

}

public sealed class XmlNodeEventHandler : MulticastDelegate // TypeDefIndex: 2050
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE45C0 Offset: 0xAE2BC0 VA: 0x180AE45C0 Slot: 12
	public virtual void Invoke(object sender, XmlNodeEventArgs e) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
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

	// RVA: 0x16882D0 Offset: 0x16868D0 VA: 0x1816882D0
	internal void .ctor(XmlNode xmlNode, int lineNumber, int linePosition, object o) { }

}

internal class XmlTypeSerializationSource : SerializationSource // TypeDefIndex: 2060
{	// Fields
	private string attributeOverridesHash; // 0x28
	private Type type; // 0x30
	private string rootHash; // 0x38

	// Methods

	// RVA: 0xE6B600 Offset: 0xE69C00 VA: 0x180E6B600
	public void .ctor(Type type, XmlRootAttribute root, XmlAttributeOverrides attributeOverrides, string namspace, Type[] includedTypes) { }

	// RVA: 0xE6B4D0 Offset: 0xE69AD0 VA: 0x180E6B4D0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0xE6B5D0 Offset: 0xE69BD0 VA: 0x180E6B5D0 Slot: 2
	public override int GetHashCode() { }

}

internal class XmlTypeConvertorAttribute : Attribute // TypeDefIndex: 2061
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <Method>k__BackingField; // 0x10

	// Properties
	public string Method { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Method() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	private void set_Method(string value) { }

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(string method) { }

}

public class XmlAnyAttributeAttribute : Attribute // TypeDefIndex: 2065
{	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
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

	// RVA: 0x110B230 Offset: 0x1109830 VA: 0x18110B230
	public void .ctor() { }

	// RVA: 0x110B240 Offset: 0x1109840 VA: 0x18110B240
	public string get_Name() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Namespace() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public int get_Order() { }

	// RVA: 0x110B040 Offset: 0x1109640 VA: 0x18110B040
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlAnyElementAttributes : CollectionBase // TypeDefIndex: 2067
{	// Properties
	public XmlAnyElementAttribute Item { get; }
	internal int Order { get; }

	// Methods

	// RVA: 0x110B450 Offset: 0x1109A50 VA: 0x18110B450
	public XmlAnyElementAttribute get_Item(int index) { }

	// RVA: 0x110B3E0 Offset: 0x11099E0 VA: 0x18110B3E0
	public int Add(XmlAnyElementAttribute attribute) { }

	// RVA: 0x110B290 Offset: 0x1109890 VA: 0x18110B290
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x110B500 Offset: 0x1109B00 VA: 0x18110B500
	internal int get_Order() { }

	// RVA: 0x105CC80 Offset: 0x105B280 VA: 0x18105CC80
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

	// RVA: 0x110BA20 Offset: 0x110A020 VA: 0x18110BA20
	public string get_ElementName() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public XmlSchemaForm get_Form() { }

	// RVA: 0x7D0C30 Offset: 0x7CF230 VA: 0x1807D0C30
	public bool get_IsNullable() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Namespace() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public int get_Order() { }

	// RVA: 0x110B6B0 Offset: 0x1109CB0 VA: 0x18110B6B0
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

	// RVA: 0x110BFC0 Offset: 0x110A5C0 VA: 0x18110BFC0
	public string get_DataType() { }

	// RVA: 0x110C010 Offset: 0x110A610 VA: 0x18110C010
	public string get_ElementName() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public XmlSchemaForm get_Form() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public string get_Namespace() { }

	// RVA: 0x82BC90 Offset: 0x82A290 VA: 0x18082BC90
	public bool get_IsNullable() { }

	// RVA: 0xFFB2B0 Offset: 0xFF98B0 VA: 0x180FFB2B0
	internal bool get_IsNullableSpecified() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public Type get_Type() { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40
	public int get_NestingLevel() { }

	// RVA: 0x110BA70 Offset: 0x110A070 VA: 0x18110BA70
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlArrayItemAttributes : CollectionBase // TypeDefIndex: 2070
{	// Properties
	public XmlArrayItemAttribute Item { get; }

	// Methods

	// RVA: 0x110C220 Offset: 0x110A820 VA: 0x18110C220
	public XmlArrayItemAttribute get_Item(int index) { }

	// RVA: 0x110C1B0 Offset: 0x110A7B0 VA: 0x18110C1B0
	public int Add(XmlArrayItemAttribute attribute) { }

	// RVA: 0x110C060 Offset: 0x110A660 VA: 0x18110C060
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x105CC80 Offset: 0x105B280 VA: 0x18105CC80
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

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(string attributeName) { }

	// RVA: 0x110C790 Offset: 0x110AD90 VA: 0x18110C790
	public string get_AttributeName() { }

	// RVA: 0x110C7E0 Offset: 0x110ADE0 VA: 0x18110C7E0
	public string get_DataType() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_DataType(string value) { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public XmlSchemaForm get_Form() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_Namespace() { }

	// RVA: 0x110C2D0 Offset: 0x110A8D0 VA: 0x18110C2D0
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlAttributeOverrides // TypeDefIndex: 2072
{	// Fields
	private Hashtable overrides; // 0x10

	// Properties
	public XmlAttributes Item { get; }
	public XmlAttributes Item { get; }

	// Methods

	// RVA: 0x110CC90 Offset: 0x110B290 VA: 0x18110CC90
	public void .ctor() { }

	// RVA: 0x110CD00 Offset: 0x110B300 VA: 0x18110CD00
	public XmlAttributes get_Item(Type type) { }

	// RVA: 0x110CE40 Offset: 0x110B440 VA: 0x18110CE40
	public XmlAttributes get_Item(Type type, string member) { }

	// RVA: 0x110CC10 Offset: 0x110B210 VA: 0x18110CC10
	private TypeMember GetKey(Type type, string member) { }

	// RVA: 0x110C8E0 Offset: 0x110AEE0 VA: 0x18110C8E0
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

	// RVA: 0x110E130 Offset: 0x110C730 VA: 0x18110E130
	public void .ctor() { }

	// RVA: 0x110D650 Offset: 0x110BC50 VA: 0x18110D650
	public void .ctor(ICustomAttributeProvider provider) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public XmlAnyAttributeAttribute get_XmlAnyAttribute() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public XmlAnyElementAttributes get_XmlAnyElements() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public XmlArrayAttribute get_XmlArray() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
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

	// RVA: 0xAF5CE0 Offset: 0xAF42E0 VA: 0x180AF5CE0
	public bool get_Xmlns() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public XmlRootAttribute get_XmlRoot() { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public XmlTextAttribute get_XmlText() { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	public XmlTypeAttribute get_XmlType() { }

	// RVA: 0x110CF60 Offset: 0x110B560 VA: 0x18110CF60
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x110E230 Offset: 0x110C830 VA: 0x18110E230
	internal Nullable<int> get_Order() { }

	// RVA: 0x110E2E0 Offset: 0x110C8E0 VA: 0x18110E2E0
	internal int get_SortableOrder() { }

}

public class XmlChoiceIdentifierAttribute : Attribute // TypeDefIndex: 2074
{	// Fields
	private string memberName; // 0x10

	// Properties
	public string MemberName { get; }

	// Methods

	// RVA: 0x110E480 Offset: 0x110CA80 VA: 0x18110E480
	public string get_MemberName() { }

	// RVA: 0x110E360 Offset: 0x110C960 VA: 0x18110E360
	internal void AddKeyHash(StringBuilder sb) { }

}

internal class XmlCustomFormatter // TypeDefIndex: 2075
{	// Fields
	private static string[] allTimeFormats; // 0x14249

	// Methods

	// RVA: 0x110E4D0 Offset: 0x110CAD0 VA: 0x18110E4D0
	internal static string FromEnum(long value, string[] values, long[] ids, string typeName) { }

	// RVA: 0x110E850 Offset: 0x110CE50 VA: 0x18110E850
	internal static string FromXmlName(string name) { }

	// RVA: 0x110E7F0 Offset: 0x110CDF0 VA: 0x18110E7F0
	internal static string FromXmlNCName(string ncName) { }

	// RVA: 0x110F190 Offset: 0x110D790 VA: 0x18110F190
	internal static string ToXmlString(TypeData type, object value) { }

	// RVA: 0x110E8B0 Offset: 0x110CEB0 VA: 0x18110E8B0
	internal static object FromXmlString(TypeData type, string value) { }

	// RVA: 0x110FD00 Offset: 0x110E300 VA: 0x18110FD00
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

	// RVA: 0x1110C40 Offset: 0x110F240 VA: 0x181110C40
	public void .ctor(string elementName) { }

	// RVA: 0x1110BE0 Offset: 0x110F1E0 VA: 0x181110BE0
	public void .ctor(string elementName, Type type) { }

	// RVA: 0x1110C80 Offset: 0x110F280 VA: 0x181110C80
	public string get_DataType() { }

	// RVA: 0x1110CD0 Offset: 0x110F2D0 VA: 0x181110CD0
	public string get_ElementName() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public XmlSchemaForm get_Form() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public string get_Namespace() { }

	// RVA: 0x82BC90 Offset: 0x82A290 VA: 0x18082BC90
	public bool get_IsNullable() { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	public int get_Order() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public Type get_Type() { }

	// RVA: 0x11106F0 Offset: 0x110ECF0 VA: 0x1811106F0
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlElementAttributes : CollectionBase // TypeDefIndex: 2077
{	// Properties
	public XmlElementAttribute Item { get; }
	internal int Order { get; }

	// Methods

	// RVA: 0x1110EE0 Offset: 0x110F4E0 VA: 0x181110EE0
	public XmlElementAttribute get_Item(int index) { }

	// RVA: 0x1110E70 Offset: 0x110F470 VA: 0x181110E70
	public int Add(XmlElementAttribute attribute) { }

	// RVA: 0x1110D20 Offset: 0x110F320 VA: 0x181110D20
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x1110F90 Offset: 0x110F590 VA: 0x181110F90
	internal int get_Order() { }

	// RVA: 0x105CC80 Offset: 0x105B280 VA: 0x18105CC80
	public void .ctor() { }

}

public class XmlEnumAttribute : Attribute // TypeDefIndex: 2078
{	// Fields
	private string name; // 0x10

	// Properties
	public string Name { get; }

	// Methods

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(string name) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Name() { }

	// RVA: 0x16881E0 Offset: 0x16867E0 VA: 0x1816881E0
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlIgnoreAttribute : Attribute // TypeDefIndex: 2079
{	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
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

	// RVA: 0x1688260 Offset: 0x1686860 VA: 0x181688260
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

	// RVA: 0x69D620 Offset: 0x69BC20 VA: 0x18069D620
	internal void set_Format(SerializationFormat value) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	internal SerializationSource get_Source() { }

}

public class XmlMembersMapping : XmlMapping // TypeDefIndex: 2085
{
// Namespace: System.Xml.Serialization
[DefaultMemberAttribute] // RVA: 0x70BA0 Offset: 0x6FFA0 VA: 0x180070BA0
public class XmlMembersMapping : XmlMapping // TypeDefIndex: 2085
	// Fields
	private bool _hasWrapperElement; // 0x48
	private XmlMemberMapping[] _mapping; // 0x50

	// Properties
	public int Count { get; }
	internal bool HasWrapperElement { get; }

	// Methods

	// RVA: 0x16882B0 Offset: 0x16868B0 VA: 0x1816882B0
	public int get_Count() { }

	// RVA: 0x4BC3E0 Offset: 0x4BA9E0 VA: 0x1804BC3E0
	internal bool get_HasWrapperElement() { }

}

public class XmlNamespaceDeclarationsAttribute : Attribute // TypeDefIndex: 2086
{	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
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

	// RVA: 0x168F1E0 Offset: 0x168D7E0 VA: 0x18168F1E0
	public void .ctor(XmlAttributeOverrides attributeOverrides, string defaultNamespace) { }

	// RVA: 0x168E690 Offset: 0x168CC90 VA: 0x18168E690
	public XmlTypeMapping ImportTypeMapping(Type type) { }

	// RVA: 0x168E6B0 Offset: 0x168CCB0 VA: 0x18168E6B0
	public XmlTypeMapping ImportTypeMapping(Type type, string defaultNamespace) { }

	// RVA: 0x168E4E0 Offset: 0x168CAE0 VA: 0x18168E4E0
	public XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x168E100 Offset: 0x168C700 VA: 0x18168E100
	private XmlTypeMapping ImportTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1688F60 Offset: 0x1687560 VA: 0x181688F60
	private XmlTypeMapping CreateTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultXmlType, string defaultNamespace) { }

	// RVA: 0x168B790 Offset: 0x1689D90 VA: 0x18168B790
	private XmlTypeMapping ImportClassMapping(Type type, XmlRootAttribute root, string defaultNamespace, bool isBaseType = False) { }

	// RVA: 0x168A700 Offset: 0x1688D00 VA: 0x18168A700
	private XmlTypeMapping ImportClassMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, bool isBaseType = False) { }

	// RVA: 0x168F040 Offset: 0x168D640 VA: 0x18168F040
	private void RegisterDerivedMap(XmlTypeMapping map, XmlTypeMapping derivedMap) { }

	// RVA: 0x168A120 Offset: 0x1688720 VA: 0x18168A120
	private string GetTypeNamespace(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x168DB70 Offset: 0x168C170 VA: 0x18168DB70
	private XmlTypeMapping ImportListMapping(Type type, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x168CF30 Offset: 0x168B530 VA: 0x18168CF30
	private XmlTypeMapping ImportListMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x168E6D0 Offset: 0x168CCD0 VA: 0x18168E6D0
	private XmlTypeMapping ImportXmlNodeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x168DC10 Offset: 0x168C210 VA: 0x18168DC10
	private XmlTypeMapping ImportPrimitiveMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x168C790 Offset: 0x168AD90 VA: 0x18168C790
	private XmlTypeMapping ImportEnumMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x168EA70 Offset: 0x168D070 VA: 0x18168EA70
	private XmlTypeMapping ImportXmlSerializableMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x168CDF0 Offset: 0x168B3F0 VA: 0x18168CDF0
	private void ImportIncludedTypes(Type type, string defaultNamespace) { }

	// RVA: 0x1689570 Offset: 0x1687B70 VA: 0x181689570
	private List<XmlReflectionMember> GetReflectionMembers(Type type) { }

	// RVA: 0x16883B0 Offset: 0x16869B0 VA: 0x1816883B0
	private XmlTypeMapMember CreateMapMember(Type declaringType, XmlReflectionMember rmember, string defaultNamespace) { }

	// RVA: 0x168B830 Offset: 0x1689E30 VA: 0x18168B830
	private XmlTypeMapElementInfoList ImportElementInfo(Type cls, string defaultName, string defaultNamespace, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x168A230 Offset: 0x1688830 VA: 0x18168A230
	private XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, XmlReflectionMember rmember, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x168DDB0 Offset: 0x168C3B0 VA: 0x18168DDB0
	private void ImportTextElementInfo(XmlTypeMapElementInfoList list, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts, string defaultNamespace) { }

	// RVA: 0x1688370 Offset: 0x1686970 VA: 0x181688370
	private bool CanBeNull(TypeData type) { }

	// RVA: 0x168EC60 Offset: 0x168D260 VA: 0x18168EC60
	public void IncludeType(Type type) { }

	// RVA: 0x16893D0 Offset: 0x16879D0 VA: 0x1816893D0
	private object GetDefaultValue(TypeData typeData, object defaultValue) { }

	// RVA: 0x168F170 Offset: 0x168D770 VA: 0x18168F170
	private static void .cctor() { }

}

private sealed class XmlReflectionImporter.<>c // TypeDefIndex: 2088
{	// Fields
	public static readonly XmlReflectionImporter.<>c <>9; // 0x0
	public static Comparison<XmlReflectionMember> <>9__28_0; // 0x8

	// Methods

	// RVA: 0x16880D0 Offset: 0x16866D0 VA: 0x1816880D0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1687FC0 Offset: 0x16865C0 VA: 0x181687FC0
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

	// RVA: 0x168F2E0 Offset: 0x168D8E0 VA: 0x18168F2E0
	internal void .ctor(string name, Type type, XmlAttributes attributes) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_IsReturnValue() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_MemberName() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public Type get_MemberType() { }

	// RVA: 0x168F350 Offset: 0x168D950 VA: 0x18168F350
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

	// RVA: 0x168F470 Offset: 0x168DA70 VA: 0x18168F470
	public void .ctor() { }

	// RVA: 0x168F480 Offset: 0x168DA80 VA: 0x18168F480
	public void .ctor(string elementName) { }

	// RVA: 0x168F4C0 Offset: 0x168DAC0 VA: 0x18168F4C0
	public string get_DataType() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_DataType(string value) { }

	// RVA: 0x168F510 Offset: 0x168DB10 VA: 0x18168F510
	public string get_ElementName() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_ElementName(string value) { }

	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0
	public bool get_IsNullable() { }

	// RVA: 0x7F9AE0 Offset: 0x7F80E0 VA: 0x1807F9AE0
	public void set_IsNullable(bool value) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public string get_Namespace() { }

	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
	public void set_Namespace(string value) { }

	// RVA: 0x168F3C0 Offset: 0x168D9C0 VA: 0x18168F3C0
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

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(string methodName) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_MethodName() { }

	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0
	public bool get_IsAny() { }

	// RVA: 0x95FA00 Offset: 0x95E000 VA: 0x18095FA00
	public void set_IsAny(bool value) { }

}

public sealed class XmlSerializationCollectionFixupCallback : MulticastDelegate // TypeDefIndex: 2092
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x168FDC0 Offset: 0x168E3C0 VA: 0x18168FDC0 Slot: 12
	public virtual void Invoke(object collection, object collectionItems) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
	public virtual IAsyncResult BeginInvoke(object collection, object collectionItems, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class XmlSerializationFixupCallback : MulticastDelegate // TypeDefIndex: 2093
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14296F0 Offset: 0x1427CF0 VA: 0x1814296F0 Slot: 12
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

	// RVA: 0xD3D430 Offset: 0xD3BA30 VA: 0x180D3D430 Slot: 12
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

	// RVA: 0x16980D0 Offset: 0x16966D0 VA: 0x1816980D0
	internal void Initialize(XmlReader reader, XmlSerializer eventSource) { }

	// RVA: 0x1697B80 Offset: 0x1696180 VA: 0x181697B80
	private ArrayList EnsureArrayList(ArrayList list) { }

	// RVA: 0x1697BD0 Offset: 0x16961D0 VA: 0x181697BD0
	private Hashtable EnsureHashtable(Hashtable hash) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x169BE90 Offset: 0x169A490 VA: 0x18169BE90
	protected XmlDocument get_Document() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	protected XmlReader get_Reader() { }

	// RVA: 0x16970C0 Offset: 0x16956C0 VA: 0x1816970C0
	protected void AddFixup(XmlSerializationReader.CollectionFixup fixup) { }

	// RVA: 0x16971E0 Offset: 0x16957E0 VA: 0x1816971E0
	protected void AddFixup(XmlSerializationReader.Fixup fixup) { }

	// RVA: 0x1697020 Offset: 0x1695620 VA: 0x181697020
	private void AddFixup(XmlSerializationReader.CollectionItemFixup fixup) { }

	// RVA: 0x1697280 Offset: 0x1695880 VA: 0x181697280
	protected void AddReadCallback(string name, string ns, Type type, XmlSerializationReadCallback read) { }

	// RVA: 0x16973E0 Offset: 0x16959E0 VA: 0x1816973E0
	protected void AddTarget(string id, object o) { }

	// RVA: 0x1697980 Offset: 0x1695F80 VA: 0x181697980
	private string CurrentTag() { }

	// RVA: 0x1697530 Offset: 0x1695B30 VA: 0x181697530
	protected Exception CreateReadOnlyCollectionException(string name) { }

	// RVA: 0x16975A0 Offset: 0x1695BA0 VA: 0x1816975A0
	protected Exception CreateUnknownConstantException(string value, Type enumType) { }

	// RVA: 0x1697610 Offset: 0x1695C10 VA: 0x181697610
	protected Exception CreateUnknownNodeException() { }

	// RVA: 0x1697690 Offset: 0x1695C90 VA: 0x181697690
	protected Exception CreateUnknownTypeException(XmlQualifiedName type) { }

	// RVA: 0x1697AF0 Offset: 0x16960F0 VA: 0x181697AF0
	protected Array EnsureArrayIndex(Array a, int index, Type elementType) { }

	// RVA: 0x1697D20 Offset: 0x1696320 VA: 0x181697D20
	protected bool GetNullAttr() { }

	// RVA: 0x1697E00 Offset: 0x1696400 VA: 0x181697E00
	protected object GetTarget(string id) { }

	// RVA: 0x169B6A0 Offset: 0x1699CA0 VA: 0x18169B6A0
	private bool TargetReady(string id) { }

	// RVA: 0x1697ED0 Offset: 0x16964D0 VA: 0x181697ED0
	protected XmlQualifiedName GetXsiType() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void InitCallbacks();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void InitIDs();

	// RVA: 0x1698480 Offset: 0x1696A80 VA: 0x181698480
	protected bool IsXmlnsAttribute(string name) { }

	// RVA: 0x16988F0 Offset: 0x1696EF0 VA: 0x1816988F0
	protected void ParseWsdlArrayType(XmlAttribute attr) { }

	// RVA: 0x1698A90 Offset: 0x1697090 VA: 0x181698A90
	protected XmlQualifiedName ReadElementQualifiedName() { }

	// RVA: 0x1698BA0 Offset: 0x16971A0 VA: 0x181698BA0
	protected void ReadEndElement() { }

	// RVA: 0x1699140 Offset: 0x1697740 VA: 0x181699140
	protected bool ReadNull() { }

	// RVA: 0x16993A0 Offset: 0x16979A0 VA: 0x1816993A0
	protected XmlQualifiedName ReadNullableQualifiedName() { }

	// RVA: 0x16993D0 Offset: 0x16979D0 VA: 0x1816993D0
	protected string ReadNullableString() { }

	// RVA: 0x1699420 Offset: 0x1697A20 VA: 0x181699420
	protected object ReadReferencedElement() { }

	// RVA: 0x1697C20 Offset: 0x1696220 VA: 0x181697C20
	private XmlSerializationReader.WriteCallbackInfo GetCallbackInfo(XmlQualifiedName qname) { }

	// RVA: 0x1699490 Offset: 0x1697A90 VA: 0x181699490
	protected object ReadReferencedElement(string name, string ns) { }

	// RVA: 0x1698C60 Offset: 0x1697260 VA: 0x181698C60
	private bool ReadList(out object resultList) { }

	// RVA: 0x1699770 Offset: 0x1697D70 VA: 0x181699770
	protected void ReadReferencedElements() { }

	// RVA: 0x169A940 Offset: 0x1698F40 VA: 0x18169A940
	protected object ReadReferencingElement(out string fixupReference) { }

	// RVA: 0x169A920 Offset: 0x1698F20 VA: 0x18169A920
	protected object ReadReferencingElement(string name, string ns, out string fixupReference) { }

	// RVA: 0x169A5B0 Offset: 0x1698BB0 VA: 0x18169A5B0
	protected object ReadReferencingElement(string name, string ns, bool elementCanBeType, out string fixupReference) { }

	// RVA: 0x169A9C0 Offset: 0x1698FC0 VA: 0x18169A9C0
	protected IXmlSerializable ReadSerializable(IXmlSerializable serializable) { }

	// RVA: 0x169B430 Offset: 0x1699A30 VA: 0x18169B430
	protected object ReadTypedPrimitive(XmlQualifiedName type) { }

	// RVA: 0x169ABB0 Offset: 0x16991B0 VA: 0x18169ABB0
	private object ReadTypedPrimitive(XmlQualifiedName qname, bool reportUnknown) { }

	// RVA: 0x169B570 Offset: 0x1699B70 VA: 0x18169B570
	protected XmlNode ReadXmlNode(bool wrapped) { }

	// RVA: 0x169B440 Offset: 0x1699A40 VA: 0x18169B440
	protected XmlDocument ReadXmlDocument(bool wrapped) { }

	// RVA: 0x169B5E0 Offset: 0x1699BE0 VA: 0x18169B5E0
	protected Array ShrinkArray(Array a, int length, Type elementType, bool isNullable) { }

	// RVA: 0x169B6C0 Offset: 0x1699CC0 VA: 0x18169B6C0
	protected XmlQualifiedName ToXmlQualifiedName(string value) { }

	// RVA: 0x169B8E0 Offset: 0x1699EE0 VA: 0x18169B8E0
	protected void UnknownAttribute(object o, XmlAttribute attr, string qnames) { }

	// RVA: 0x169BB10 Offset: 0x169A110 VA: 0x18169BB10
	protected void UnknownElement(object o, XmlElement elem, string qnames) { }

	// RVA: 0x16915E0 Offset: 0x168FBE0 VA: 0x1816915E0
	protected void UnknownNode(object o) { }

	// RVA: 0x169BD90 Offset: 0x169A390 VA: 0x18169BD90
	protected void UnknownNode(object o, string qnames) { }

	// RVA: 0x16984F0 Offset: 0x1696AF0 VA: 0x1816984F0
	private void OnUnknownNode(XmlNode node, object o, string qnames) { }

	// RVA: 0x169BE00 Offset: 0x169A400 VA: 0x18169BE00
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

	// RVA: 0xF5EC10 Offset: 0xF5D210 VA: 0x180F5EC10
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

	// RVA: 0x1696FD0 Offset: 0x16955D0 VA: 0x181696FD0
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x1691220 Offset: 0x168F820 VA: 0x181691220 Slot: 4
	protected override void InitCallbacks() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	protected override void InitIDs() { }

	// RVA: 0x1696160 Offset: 0x1694760 VA: 0x181696160
	public object ReadRoot() { }

	// RVA: 0x16920E0 Offset: 0x16906E0 VA: 0x1816920E0
	private object ReadEncodedObject(XmlTypeMapping typeMap) { }

	// RVA: 0x1695340 Offset: 0x1693940 VA: 0x181695340 Slot: 6
	protected virtual object ReadMessage(XmlMembersMapping typeMap) { }

	// RVA: 0x1696410 Offset: 0x1694A10 VA: 0x181696410
	private object ReadRoot(XmlTypeMapping rootMap) { }

	// RVA: 0x1695CD0 Offset: 0x16942D0 VA: 0x181695CD0 Slot: 7
	protected virtual object ReadObject(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x1691DE0 Offset: 0x16903E0 VA: 0x181691DE0 Slot: 8
	protected virtual object ReadClassInstance(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x1691D20 Offset: 0x1690320 VA: 0x181691D20 Slot: 9
	protected virtual void ReadClassInstanceMembers(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x1691650 Offset: 0x168FC50 VA: 0x181691650
	private void ReadAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x1692A50 Offset: 0x1691050 VA: 0x181692A50
	private void ReadMembers(ClassMap map, object ob, bool isValueList, bool readBySoapOrder) { }

	// RVA: 0x1696930 Offset: 0x1694F30 VA: 0x181696930
	private void SetListMembersDefaults(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x16909C0 Offset: 0x168EFC0 VA: 0x1816909C0
	internal void FixupMembers(ClassMap map, object obfixup, bool isValueList) { }

	// RVA: 0x16915E0 Offset: 0x168FBE0 VA: 0x1816915E0 Slot: 10
	protected virtual void ProcessUnknownAttribute(object target) { }

	// RVA: 0x16915E0 Offset: 0x168FBE0 VA: 0x1816915E0 Slot: 11
	protected virtual void ProcessUnknownElement(object target) { }

	// RVA: 0x1691560 Offset: 0x168FB60 VA: 0x181691560
	private bool IsReadOnly(XmlTypeMapMember member, TypeData memType, object ob, bool isValueList) { }

	// RVA: 0x1696D60 Offset: 0x1695360 VA: 0x181696D60
	private void SetMemberValue(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x1696C60 Offset: 0x1695260 VA: 0x181696C60
	private void SetMemberValueFromAttr(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x1691010 Offset: 0x168F610 VA: 0x181691010
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x1695B10 Offset: 0x1694110 VA: 0x181695B10
	private object ReadObjectElement(XmlTypeMapElementInfo elem) { }

	// RVA: 0x1695FE0 Offset: 0x16945E0 VA: 0x181695FE0
	private object ReadPrimitiveValue(XmlTypeMapElementInfo elem) { }

	// RVA: 0x16910F0 Offset: 0x168F6F0 VA: 0x1816910F0
	private object GetValueFromXmlString(string value, TypeData typeData, XmlTypeMapping typeMap) { }

	// RVA: 0x16922C0 Offset: 0x16908C0 VA: 0x1816922C0
	private object ReadListElement(XmlTypeMapping typeMap, bool isNullable, object list, bool canCreateInstance) { }

	// RVA: 0x16927A0 Offset: 0x1690DA0 VA: 0x1816927A0
	private object ReadListString(XmlTypeMapping typeMap, string values) { }

	// RVA: 0x16901C0 Offset: 0x168E7C0 VA: 0x1816901C0
	private void AddListValue(TypeData listType, ref object list, int index, object value, bool canCreateInstance) { }

	// RVA: 0x16908F0 Offset: 0x168EEF0 VA: 0x1816908F0
	private static object CreateInstance(Type type, bool nonPublic) { }

	// RVA: 0x1690880 Offset: 0x168EE80 VA: 0x181690880
	private object CreateInstance(Type type) { }

	// RVA: 0x1690900 Offset: 0x168EF00 VA: 0x181690900
	private object CreateList(Type listType) { }

	// RVA: 0x16914E0 Offset: 0x168FAE0 VA: 0x1816914E0
	private object InitializeList(TypeData listType) { }

	// RVA: 0x16909A0 Offset: 0x168EFA0 VA: 0x1816909A0
	private void FillList(object list, object items) { }

	// RVA: 0x1690570 Offset: 0x168EB70 VA: 0x181690570
	private void CopyEnumerableList(object source, object dest) { }

	// RVA: 0x1696530 Offset: 0x1694B30 VA: 0x181696530
	private object ReadXmlNodeElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x1696560 Offset: 0x1694B60 VA: 0x181696560
	private object ReadXmlNode(TypeData type, bool wrapped) { }

	// RVA: 0x1695F10 Offset: 0x1694510 VA: 0x181695F10
	private object ReadPrimitiveElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x1692240 Offset: 0x1690840 VA: 0x181692240
	private object ReadEnumElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x1690E40 Offset: 0x168F440 VA: 0x181690E40
	private object GetEnumValue(XmlTypeMapping typeMap, string val) { }

	// RVA: 0x1696750 Offset: 0x1694D50 VA: 0x181696750
	private object ReadXmlSerializableElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x1696F30 Offset: 0x1695530 VA: 0x181696F30
	private static void .cctor() { }

}

private class XmlSerializationReaderInterpreter.FixupCallbackInfo // TypeDefIndex: 2102
{	// Fields
	private XmlSerializationReaderInterpreter _sri; // 0x10
	private ClassMap _map; // 0x18
	private bool _isValueList; // 0x20

	// Methods

	// RVA: 0xFFBD50 Offset: 0xFFA350 VA: 0x180FFBD50
	public void .ctor(XmlSerializationReaderInterpreter sri, ClassMap map, bool isValueList) { }

	// RVA: 0x1687EA0 Offset: 0x16864A0 VA: 0x181687EA0
	public void FixupMembers(object fixup) { }

}

private class XmlSerializationReaderInterpreter.ReaderCallbackInfo // TypeDefIndex: 2103
{	// Fields
	private XmlSerializationReaderInterpreter _sri; // 0x10
	private XmlTypeMapping _typeMap; // 0x18

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	public void .ctor(XmlSerializationReaderInterpreter sri, XmlTypeMapping typeMap) { }

	// RVA: 0x1687F80 Offset: 0x1686580 VA: 0x181687F80
	internal object ReadObject() { }

}

public sealed class XmlSerializationWriteCallback : MulticastDelegate // TypeDefIndex: 2104
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14296F0 Offset: 0x1427CF0 VA: 0x1814296F0 Slot: 12
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

	// RVA: 0x16A3BB0 Offset: 0x16A21B0 VA: 0x1816A3BB0
	protected void .ctor() { }

	// RVA: 0x16A10A0 Offset: 0x169F6A0 VA: 0x1816A10A0
	internal void Initialize(XmlWriter writer, XmlSerializerNamespaces nss) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	protected XmlWriter get_Writer() { }

	// RVA: 0x16A08D0 Offset: 0x169EED0 VA: 0x1816A08D0
	protected void AddWriteCallback(Type type, string typeName, string typeNs, XmlSerializationWriteCallback callback) { }

	// RVA: 0x16A0AB0 Offset: 0x169F0B0 VA: 0x1816A0AB0
	protected Exception CreateUnknownAnyElementException(string name, string ns) { }

	// RVA: 0x16A0B90 Offset: 0x169F190 VA: 0x1816A0B90
	protected Exception CreateUnknownTypeException(object o) { }

	// RVA: 0x16A0B20 Offset: 0x169F120 VA: 0x1816A0B20
	protected Exception CreateUnknownTypeException(Type type) { }

	// RVA: 0x16A0C20 Offset: 0x169F220 VA: 0x1816A0C20
	protected string FromXmlQualifiedName(XmlQualifiedName xmlQualifiedName) { }

	// RVA: 0x16A0D00 Offset: 0x169F300 VA: 0x1816A0D00
	private string GetId(object o, bool addToReferencesList) { }

	// RVA: 0x16A09F0 Offset: 0x169EFF0 VA: 0x1816A09F0
	private bool AlreadyQueued(object ob) { }

	// RVA: 0x16A0E00 Offset: 0x169F400 VA: 0x1816A0E00
	private string GetNamespacePrefix(string ns) { }

	// RVA: 0x16A0F10 Offset: 0x169F510 VA: 0x1816A0F10
	private string GetQualifiedName(string name, string ns) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void InitCallbacks();

	// RVA: 0x16A12D0 Offset: 0x169F8D0 VA: 0x1816A12D0
	protected void TopLevelElement() { }

	// RVA: 0x16A15B0 Offset: 0x169FBB0 VA: 0x1816A15B0
	protected void WriteAttribute(string localName, string ns, string value) { }

	// RVA: 0x16A1570 Offset: 0x169FB70 VA: 0x1816A1570
	protected void WriteAttribute(string prefix, string localName, string ns, string value) { }

	// RVA: 0x16A39B0 Offset: 0x16A1FB0 VA: 0x1816A39B0
	private void WriteXmlNode(XmlNode node) { }

	// RVA: 0x16A15F0 Offset: 0x169FBF0 VA: 0x1816A15F0
	protected void WriteElementEncoded(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x16A16E0 Offset: 0x169FCE0 VA: 0x1816A16E0
	protected void WriteElementLiteral(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x16A17D0 Offset: 0x169FDD0 VA: 0x1816A17D0
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value) { }

	// RVA: 0x16A17F0 Offset: 0x169FDF0 VA: 0x1816A17F0
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x16A19D0 Offset: 0x169FFD0 VA: 0x1816A19D0
	protected void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x16A19F0 Offset: 0x169FFF0 VA: 0x1816A19F0
	protected void WriteElementString(string localName, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0xBA4970 Offset: 0xBA2F70 VA: 0x180BA4970
	protected void WriteEndElement() { }

	// RVA: 0x16A1B60 Offset: 0x16A0160 VA: 0x1816A1B60
	protected void WriteEndElement(object o) { }

	// RVA: 0x16A1BB0 Offset: 0x16A01B0 VA: 0x1816A1BB0
	protected void WriteNamespaceDeclarations(XmlSerializerNamespaces xmlns) { }

	// RVA: 0x16A2070 Offset: 0x16A0670 VA: 0x1816A2070
	protected void WriteNullableQualifiedNameEncoded(string name, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x16A2120 Offset: 0x16A0720 VA: 0x1816A2120
	protected void WriteNullableQualifiedNameLiteral(string name, string ns, XmlQualifiedName value) { }

	// RVA: 0x16A21D0 Offset: 0x16A07D0 VA: 0x1816A21D0
	protected void WriteNullableStringEncoded(string name, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0x16A21F0 Offset: 0x16A07F0 VA: 0x1816A21F0
	protected void WriteNullableStringLiteral(string name, string ns, string value) { }

	// RVA: 0x16A1F00 Offset: 0x16A0500 VA: 0x1816A1F00
	protected void WriteNullTagEncoded(string name, string ns) { }

	// RVA: 0x16A1FB0 Offset: 0x16A05B0 VA: 0x1816A1FB0
	protected void WriteNullTagLiteral(string name, string ns) { }

	// RVA: 0x16A2220 Offset: 0x16A0820 VA: 0x1816A2220
	protected void WritePotentiallyReferencingElement(string n, string ns, object o, Type ambientType, bool suppressReference, bool isNullable) { }

	// RVA: 0x16A2680 Offset: 0x16A0C80 VA: 0x1816A2680
	protected void WriteReferencedElements() { }

	// RVA: 0x16A11D0 Offset: 0x169F7D0 VA: 0x1816A11D0
	private bool IsPrimitiveArray(TypeData td) { }

	// RVA: 0x16A12E0 Offset: 0x169F8E0 VA: 0x1816A12E0
	private void WriteArray(object o, TypeData td) { }

	// RVA: 0x16A28E0 Offset: 0x16A0EE0 VA: 0x1816A28E0
	protected void WriteReferencingElement(string n, string ns, object o, bool isNullable) { }

	// RVA: 0x16A0A30 Offset: 0x169F030 VA: 0x1816A0A30
	private void CheckReferenceQueue() { }

	// RVA: 0x16A2A30 Offset: 0x16A1030 VA: 0x1816A2A30
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable) { }

	// RVA: 0x16A2B60 Offset: 0x16A1160 VA: 0x1816A2B60
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped) { }

	// RVA: 0x16A2CA0 Offset: 0x16A12A0 VA: 0x1816A2CA0
	protected void WriteStartDocument() { }

	// RVA: 0x16A3380 Offset: 0x16A1980 VA: 0x1816A3380
	protected void WriteStartElement(string name, string ns) { }

	// RVA: 0x16A3320 Offset: 0x16A1920 VA: 0x1816A3320
	protected void WriteStartElement(string name, string ns, bool writePrefixed) { }

	// RVA: 0x16A3350 Offset: 0x16A1950 VA: 0x1816A3350
	protected void WriteStartElement(string name, string ns, object o) { }

	// RVA: 0x16A2D00 Offset: 0x16A1300 VA: 0x1816A2D00
	protected void WriteStartElement(string name, string ns, object o, bool writePrefixed) { }

	// RVA: 0x16A2D30 Offset: 0x16A1330 VA: 0x1816A2D30
	private void WriteStartElement(string name, string ns, object o, bool writePrefixed, ICollection namespaces) { }

	// RVA: 0x16A33B0 Offset: 0x16A19B0 VA: 0x1816A33B0
	protected void WriteTypedPrimitive(string name, string ns, object o, bool xsiType) { }

	// RVA: 0x16A36D0 Offset: 0x16A1CD0 VA: 0x1816A36D0
	protected void WriteValue(string value) { }

	// RVA: 0x16A3710 Offset: 0x16A1D10 VA: 0x1816A3710
	protected void WriteXmlAttribute(XmlNode node, object container) { }

	// RVA: 0x16A3AE0 Offset: 0x16A20E0 VA: 0x1816A3AE0
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

	// RVA: 0x16A0830 Offset: 0x169EE30 VA: 0x1816A0830
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x169C8A0 Offset: 0x169AEA0 VA: 0x18169C8A0 Slot: 4
	protected override void InitCallbacks() { }

	// RVA: 0x16A0590 Offset: 0x169EB90 VA: 0x1816A0590
	public void WriteRoot(object ob) { }

	// RVA: 0x169F880 Offset: 0x169DE80 VA: 0x18169F880 Slot: 5
	protected virtual void WriteObject(XmlTypeMapping typeMap, object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem) { }

	// RVA: 0x169F3B0 Offset: 0x169D9B0 VA: 0x18169F3B0 Slot: 6
	protected virtual void WriteMessage(XmlMembersMapping membersMap, object[] parameters) { }

	// RVA: 0x169F730 Offset: 0x169DD30 VA: 0x18169F730 Slot: 7
	protected virtual void WriteObjectElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x169F5B0 Offset: 0x169DBB0 VA: 0x18169F5B0 Slot: 8
	protected virtual void WriteObjectElementAttributes(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x169F670 Offset: 0x169DC70 VA: 0x18169F670 Slot: 9
	protected virtual void WriteObjectElementElements(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x169F350 Offset: 0x169D950 VA: 0x18169F350
	private void WriteMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x169D690 Offset: 0x169BC90 VA: 0x18169D690
	private void WriteAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x169DE00 Offset: 0x169C400 VA: 0x18169DE00
	private void WriteElementMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x169C1C0 Offset: 0x169A7C0 VA: 0x18169C1C0
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x169CB60 Offset: 0x169B160 VA: 0x18169CB60
	private bool MemberHasValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x169ECB0 Offset: 0x169D2B0 VA: 0x18169ECB0
	private void WriteMemberElement(XmlTypeMapElementInfo elem, object memberValue) { }

	// RVA: 0x169C4F0 Offset: 0x169AAF0 VA: 0x18169C4F0
	internal static object ImplicitConvert(object obj, Type type) { }

	// RVA: 0x16A0290 Offset: 0x169E890 VA: 0x1816A0290
	private void WritePrimitiveValueLiteral(object memberValue, string name, string ns, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x169FF60 Offset: 0x169E560 VA: 0x18169FF60
	private void WritePrimitiveValueEncoded(object memberValue, string name, string ns, XmlQualifiedName xsiType, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x169EA50 Offset: 0x169D050 VA: 0x18169EA50 Slot: 10
	protected virtual void WriteListElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x169E3E0 Offset: 0x169C9E0 VA: 0x18169E3E0
	private void WriteListContent(object container, TypeData listType, ListMap map, object ob, StringBuilder targetString) { }

	// RVA: 0x169C050 Offset: 0x169A650 VA: 0x18169C050
	private int GetListCount(TypeData listType, object ob) { }

	// RVA: 0x169CDB0 Offset: 0x169B3B0 VA: 0x18169CDB0
	private void WriteAnyElementContent(XmlTypeMapMemberAnyElement member, object memberValue) { }

	// RVA: 0x169FF10 Offset: 0x169E510 VA: 0x18169FF10 Slot: 11
	protected virtual void WritePrimitiveElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x169E3A0 Offset: 0x169C9A0 VA: 0x18169E3A0 Slot: 12
	protected virtual void WriteEnumElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x169C2A0 Offset: 0x169A8A0 VA: 0x18169C2A0
	private string GetStringValue(XmlTypeMapping typeMap, TypeData type, object value) { }

	// RVA: 0x169BF30 Offset: 0x169A530 VA: 0x18169BF30
	private string GetEnumXmlValue(XmlTypeMapping typeMap, object ob) { }

}

private class XmlSerializationWriterInterpreter.CallbackInfo // TypeDefIndex: 2108
{	// Fields
	private XmlSerializationWriterInterpreter _swi; // 0x10
	private XmlTypeMapping _typeMap; // 0x18

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	public void .ctor(XmlSerializationWriterInterpreter swi, XmlTypeMapping typeMap) { }

	// RVA: 0xE4CE60 Offset: 0xE4B460 VA: 0x180E4CE60
	internal void WriteObject(object ob) { }

	// RVA: 0xE4CE00 Offset: 0xE4B400 VA: 0x180E4CE00
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

	// RVA: 0xE68460 Offset: 0xE66A60 VA: 0x180E68460
	private static void .cctor() { }

	// RVA: 0xE686D0 Offset: 0xE66CD0 VA: 0x180E686D0
	public void .ctor(Type type) { }

	// RVA: 0xE68550 Offset: 0xE66B50 VA: 0x180E68550
	public void .ctor(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal XmlMapping get_Mapping() { }

	// RVA: 0xE67E50 Offset: 0xE66450 VA: 0x180E67E50 Slot: 4
	internal virtual void OnUnknownAttribute(XmlAttributeEventArgs e) { }

	// RVA: 0xE67E70 Offset: 0xE66470 VA: 0x180E67E70 Slot: 5
	internal virtual void OnUnknownElement(XmlElementEventArgs e) { }

	// RVA: 0xE67E90 Offset: 0xE66490 VA: 0x180E67E90 Slot: 6
	internal virtual void OnUnknownNode(XmlNodeEventArgs e) { }

	// RVA: 0xE67EB0 Offset: 0xE664B0 VA: 0x180E67EB0 Slot: 7
	internal virtual void OnUnreferencedObject(UnreferencedObjectEventArgs e) { }

	// RVA: 0xE67640 Offset: 0xE65C40 VA: 0x180E67640 Slot: 8
	protected virtual XmlSerializationReader CreateReader() { }

	// RVA: 0xE676F0 Offset: 0xE65CF0 VA: 0x180E676F0 Slot: 9
	protected virtual XmlSerializationWriter CreateWriter() { }

	// RVA: 0xE67D30 Offset: 0xE66330 VA: 0x180E67D30
	public object Deserialize(TextReader textReader) { }

	// RVA: 0xE679F0 Offset: 0xE65FF0 VA: 0x180E679F0
	public object Deserialize(XmlReader xmlReader) { }

	// RVA: 0xE67AB0 Offset: 0xE660B0 VA: 0x180E67AB0 Slot: 10
	protected virtual object Deserialize(XmlSerializationReader reader) { }

	// RVA: 0xE68180 Offset: 0xE66780 VA: 0x180E68180 Slot: 11
	protected virtual void Serialize(object o, XmlSerializationWriter writer) { }

	// RVA: 0xE683C0 Offset: 0xE669C0 VA: 0x180E683C0
	public void Serialize(TextWriter textWriter, object o) { }

	// RVA: 0xE683A0 Offset: 0xE669A0 VA: 0x180E683A0
	public void Serialize(XmlWriter xmlWriter, object o) { }

	// RVA: 0xE67ED0 Offset: 0xE664D0 VA: 0x180E67ED0
	public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces) { }

	// RVA: 0xE67740 Offset: 0xE65D40 VA: 0x180E67740
	private XmlSerializationWriter CreateWriter(XmlMapping typeMapping) { }

	// RVA: 0xE67690 Offset: 0xE65C90 VA: 0x180E67690
	private XmlSerializationReader CreateReader(XmlMapping typeMapping) { }

}

internal class XmlSerializer.SerializerData // TypeDefIndex: 2110
{	// Fields
	public MethodInfo ReaderMethod; // 0x10
	public Type WriterType; // 0x18
	public MethodInfo WriterMethod; // 0x20
	public XmlSerializerImplementation Implementation; // 0x28

	// Methods

	// RVA: 0xE4CEC0 Offset: 0xE4B4C0 VA: 0x180E4CEC0
	public XmlSerializationWriter CreateWriter() { }

}

public class XmlSerializerFactory // TypeDefIndex: 2111
{	// Fields
	private static Hashtable serializersBySource; // 0x2B112D4

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xE669A0 Offset: 0xE64FA0 VA: 0x180E669A0
	public XmlSerializer CreateSerializer(Type type) { }

	// RVA: 0xE669D0 Offset: 0xE64FD0 VA: 0x180E669D0
	public XmlSerializer CreateSerializer(Type type, XmlRootAttribute root) { }

	// RVA: 0xE66A00 Offset: 0xE65000 VA: 0x180E66A00
	public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0xE66D80 Offset: 0xE65380 VA: 0x180E66D80
	private static void .cctor() { }

}

public abstract class XmlSerializerImplementation // TypeDefIndex: 2112
{	// Properties
	public virtual XmlSerializationWriter Writer { get; }

	// Methods

	// RVA: 0xE66DE0 Offset: 0xE653E0 VA: 0x180E66DE0 Slot: 4
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

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xE68790 Offset: 0xE66D90 VA: 0x180E68790
	public string get_DataType() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Type get_Type() { }

	// RVA: 0xE68700 Offset: 0xE66D00 VA: 0x180E68700
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

	// RVA: 0xE68880 Offset: 0xE66E80 VA: 0x180E68880
	public string get_TypeName() { }

	// RVA: 0xE687E0 Offset: 0xE66DE0 VA: 0x180E687E0
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

	// RVA: 0xE68A80 Offset: 0xE67080 VA: 0x180E68A80
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

	// RVA: 0xE68B70 Offset: 0xE67170 VA: 0x180E68B70
	public string get_DataTypeNamespace() { }

	// RVA: 0xE68B40 Offset: 0xE67140 VA: 0x180E68B40
	public string get_DataTypeName() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public XmlSchemaForm get_Form() { }

	// RVA: 0x69D620 Offset: 0x69BC20 VA: 0x18069D620
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public XmlTypeMapping get_MappedType() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	public void set_MappedType(XmlTypeMapping value) { }

	// RVA: 0x8C1040 Offset: 0x8BF640 VA: 0x1808C1040
	public bool get_IsNullable() { }

	// RVA: 0x78E170 Offset: 0x78C770 VA: 0x18078E170
	public void set_IsNullable(bool value) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public XmlTypeMapMember get_Member() { }

	// RVA: 0x8C1070 Offset: 0x8BF670 VA: 0x1808C1070
	public void set_NestingLevel(int value) { }

	// RVA: 0xE68C80 Offset: 0xE67280 VA: 0x180E68C80
	public bool get_MultiReferenceType() { }

	// RVA: 0x77B0E0 Offset: 0x7796E0 VA: 0x18077B0E0
	public bool get_WrappedElement() { }

	// RVA: 0xE68DF0 Offset: 0xE673F0 VA: 0x180E68DF0
	public void set_WrappedElement(bool value) { }

	// RVA: 0xE68BF0 Offset: 0xE671F0 VA: 0x180E68BF0
	public bool get_IsTextElement() { }

	// RVA: 0xE68CA0 Offset: 0xE672A0 VA: 0x180E68CA0
	public void set_IsTextElement(bool value) { }

	// RVA: 0xE68C30 Offset: 0xE67230 VA: 0x180E68C30
	public bool get_IsUnnamedAnyElement() { }

	// RVA: 0xE68D40 Offset: 0xE67340 VA: 0x180E68D40
	public void set_IsUnnamedAnyElement(bool value) { }

	// RVA: 0x5DE920 Offset: 0x5DCF20 VA: 0x1805DE920
	public int get_ExplicitOrder() { }

	// RVA: 0xE68C90 Offset: 0xE67290 VA: 0x180E68C90
	public void set_ExplicitOrder(int value) { }

	// RVA: 0xE68930 Offset: 0xE66F30 VA: 0x180E68930 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xCCE560 Offset: 0xCCCB60 VA: 0x180CCE560 Slot: 2
	public override int GetHashCode() { }

}

internal class XmlTypeMapElementInfoList : ArrayList // TypeDefIndex: 2116
{	// Methods

	// RVA: 0xE688D0 Offset: 0xE66ED0 VA: 0x180E688D0
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

	// RVA: 0xE6ADF0 Offset: 0xE693F0 VA: 0x180E6ADF0
	public void .ctor() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Name() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_Name(string value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public object get_DefaultValue() { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810
	public void set_DefaultValue(object value) { }

	// RVA: 0xE6A450 Offset: 0xE68A50 VA: 0x180E6A450
	public bool IsReadOnly(Type type) { }

	// RVA: 0xE69D00 Offset: 0xE68300 VA: 0x180E69D00
	public static object GetValue(object ob, string name) { }

	// RVA: 0xE69F30 Offset: 0xE68530 VA: 0x180E69F30
	public object GetValue(object ob) { }

	// RVA: 0xE6A980 Offset: 0xE68F80 VA: 0x180E6A980
	public void SetValue(object ob, object value) { }

	// RVA: 0xE6ABB0 Offset: 0xE691B0 VA: 0x180E6ABB0
	public static void SetValue(object ob, string name, object value) { }

	// RVA: 0xE6A140 Offset: 0xE68740 VA: 0x180E6A140
	private void InitMember(Type type) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public TypeData get_TypeData() { }

	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
	public void set_TypeData(TypeData value) { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_Index() { }

	// RVA: 0x7D0C80 Offset: 0x7CF280 VA: 0x1807D0C80
	public void set_Index(int value) { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public int get_GlobalIndex() { }

	// RVA: 0x95F9F0 Offset: 0x95DFF0 VA: 0x18095F9F0
	public void set_GlobalIndex(int value) { }

	// RVA: 0xD85D70 Offset: 0xD84370 VA: 0x180D85D70
	public bool get_IsOptionalValueType() { }

	// RVA: 0xE6AE80 Offset: 0xE69480 VA: 0x180E6AE80
	public void set_IsOptionalValueType(bool value) { }

	// RVA: 0xE6AE70 Offset: 0xE69470 VA: 0x180E6AE70
	public bool get_IsReturnValue() { }

	// RVA: 0xE6AEA0 Offset: 0xE694A0 VA: 0x180E6AEA0
	public void set_IsReturnValue(bool value) { }

	// RVA: 0xE69920 Offset: 0xE67F20 VA: 0x180E69920
	public void CheckOptionalValueType(Type type) { }

	// RVA: 0xE699A0 Offset: 0xE67FA0 VA: 0x180E699A0
	public bool GetValueSpecified(object ob) { }

	// RVA: 0xE6A590 Offset: 0xE68B90 VA: 0x180E6A590
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

	// RVA: 0xE692B0 Offset: 0xE678B0 VA: 0x180E692B0
	public void .ctor() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public string get_AttributeName() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	public void set_AttributeName(string value) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public string get_Namespace() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	public void set_Namespace(string value) { }

	// RVA: 0x803AB0 Offset: 0x8020B0 VA: 0x180803AB0
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

	// RVA: 0xE68E00 Offset: 0xE67400 VA: 0x180E68E00
	public void .ctor() { }

	// RVA: 0xE69860 Offset: 0xE67E60 VA: 0x180E69860
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

	// RVA: 0xE69300 Offset: 0xE67900 VA: 0x180E69300
	public XmlTypeMapElementInfo FindElement(object ob, object memberValue) { }

	// RVA: 0xE69840 Offset: 0xE67E40 VA: 0x180E69840
	public void SetChoice(object ob, object choice) { }

	// RVA: 0x82CA00 Offset: 0x82B000 VA: 0x18082CA00
	public bool get_IsXmlTextCollector() { }

	// RVA: 0xE69910 Offset: 0xE67F10 VA: 0x180E69910
	public void set_IsXmlTextCollector(bool value) { }

}

internal class XmlTypeMapMemberList : XmlTypeMapMemberElement // TypeDefIndex: 2120
{	// Methods

	// RVA: 0xE68E00 Offset: 0xE67400 VA: 0x180E68E00
	public void .ctor() { }

}

internal class XmlTypeMapMemberExpandable : XmlTypeMapMemberElement // TypeDefIndex: 2121
{	// Fields
	private int _flatArrayIndex; // 0x78

	// Properties
	public int FlatArrayIndex { get; set; }

	// Methods

	// RVA: 0xAF5D60 Offset: 0xAF4360 VA: 0x180AF5D60
	public int get_FlatArrayIndex() { }

	// RVA: 0xB28CD0 Offset: 0xB272D0 VA: 0x180B28CD0
	public void set_FlatArrayIndex(int value) { }

	// RVA: 0xE68E00 Offset: 0xE67400 VA: 0x180E68E00
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

	// RVA: 0xE68E00 Offset: 0xE67400 VA: 0x180E68E00
	public void .ctor() { }

}

internal class XmlTypeMapMemberAnyElement : XmlTypeMapMemberExpandable // TypeDefIndex: 2123
{	// Properties
	public bool IsDefaultAny { get; }

	// Methods

	// RVA: 0xE68E10 Offset: 0xE67410 VA: 0x180E68E10
	public bool IsElementDefined(string name, string ns) { }

	// RVA: 0xE69060 Offset: 0xE67660 VA: 0x180E69060
	public bool get_IsDefaultAny() { }

	// RVA: 0xE68E00 Offset: 0xE67400 VA: 0x180E68E00
	public void .ctor() { }

}

internal class XmlTypeMapMemberAnyAttribute : XmlTypeMapMember // TypeDefIndex: 2124
{	// Methods

	// RVA: 0xE68E00 Offset: 0xE67400 VA: 0x180E68E00
	public void .ctor() { }

}

internal class XmlTypeMapMemberNamespaces : XmlTypeMapMember // TypeDefIndex: 2125
{	// Methods

	// RVA: 0xE68E00 Offset: 0xE67400 VA: 0x180E68E00
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

	// RVA: 0xE6B360 Offset: 0xE69960 VA: 0x180E6B360
	internal void .ctor(string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }

	// RVA: 0xE6B450 Offset: 0xE69A50 VA: 0x180E6B450
	public string get_TypeFullName() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	internal TypeData get_TypeData() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	internal string get_XmlType() { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810
	internal void set_XmlType(string value) { }

	// RVA: 0xE6B470 Offset: 0xE69A70 VA: 0x180E6B470
	internal string get_XmlTypeNamespace() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	internal void set_XmlTypeNamespace(string value) { }

	// RVA: 0xE6B430 Offset: 0xE69A30 VA: 0x180E6B430
	internal bool get_HasXmlTypeNamespace() { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	internal ArrayList get_DerivedTypes() { }

	// RVA: 0x82CA00 Offset: 0x82B000 VA: 0x18082CA00
	internal bool get_MultiReferenceType() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	internal XmlTypeMapping get_BaseMap() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	internal void set_BaseMap(XmlTypeMapping value) { }

	// RVA: 0xBA2040 Offset: 0xBA0640 VA: 0x180BA2040
	internal void set_IncludeInSchema(bool value) { }

	// RVA: 0xBA1AB0 Offset: 0xBA00B0 VA: 0x180BA1AB0
	internal bool get_IsNullable() { }

	// RVA: 0xBA1E10 Offset: 0xBA0410 VA: 0x180BA1E10
	internal void set_IsNullable(bool value) { }

	// RVA: 0xE6B440 Offset: 0xE69A40 VA: 0x180E6B440
	internal bool get_IsAny() { }

	// RVA: 0xE6B4C0 Offset: 0xE69AC0 VA: 0x180E6B4C0
	internal void set_IsAny(bool value) { }

	// RVA: 0xE6B120 Offset: 0xE69720 VA: 0x180E6B120
	internal XmlTypeMapping GetRealTypeMap(Type objectType) { }

	// RVA: 0xE6AEC0 Offset: 0xE694C0 VA: 0x180E6AEC0
	internal XmlTypeMapping GetRealElementMap(string name, string ens) { }

	// RVA: 0xE6B2D0 Offset: 0xE698D0 VA: 0x180E6B2D0
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

	// RVA: 0x105C200 Offset: 0x105A800 VA: 0x18105C200
	public void .ctor() { }

	// RVA: 0x1058420 Offset: 0x1056A20 VA: 0x181058420
	public XmlSchemaSet InferSchema(XmlReader instanceDocument) { }

	// RVA: 0x1057CA0 Offset: 0x10562A0 VA: 0x181057CA0
	internal XmlSchemaSet InferSchema1(XmlReader instanceDocument, XmlSchemaSet schemas) { }

	// RVA: 0x1051EE0 Offset: 0x10504E0 VA: 0x181051EE0
	private XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, XmlSchemaObjectTable compiledAttributes) { }

	// RVA: 0x1053480 Offset: 0x1051A80 VA: 0x181053480
	private XmlSchema CreateXmlSchema(string targetNS) { }

	// RVA: 0x1052800 Offset: 0x1050E00 VA: 0x181052800
	private XmlSchemaElement AddElement(string localName, string prefix, string childURI, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, int positionWithinCollection) { }

	// RVA: 0x1056150 Offset: 0x1054750 VA: 0x181056150
	internal void InferElement(XmlSchemaElement xse, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x1052FB0 Offset: 0x10515B0 VA: 0x181052FB0
	private XmlSchemaSimpleContentExtension CheckSimpleContentExtension(XmlSchemaComplexType ct) { }

	// RVA: 0x1055300 Offset: 0x1053900 VA: 0x181055300
	private XmlSchemaType GetEffectiveSchemaType(XmlSchemaElement elem, bool bCreatingNewType) { }

	// RVA: 0x1053F50 Offset: 0x1052550 VA: 0x181053F50
	internal XmlSchemaElement FindMatchingElement(bool bCreatingNewType, XmlReader xtr, XmlSchemaComplexType ct, ref int lastUsedSeqItem, ref bool bParticleChanged, XmlSchema parentSchema, bool setMaxoccurs) { }

	// RVA: 0x1059A70 Offset: 0x1058070 VA: 0x181059A70
	internal void ProcessAttributes(ref XmlSchemaElement xse, XmlSchemaType effectiveSchemaType, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x1059960 Offset: 0x1057F60 VA: 0x181059960
	private void MoveAttributes(XmlSchemaSimpleContentExtension scExtension, XmlSchemaComplexType ct) { }

	// RVA: 0x1059630 Offset: 0x1057C30 VA: 0x181059630
	private void MoveAttributes(XmlSchemaComplexType ct, XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType) { }

	// RVA: 0x1053870 Offset: 0x1051E70 VA: 0x181053870
	internal XmlSchemaAttribute FindAttribute(ICollection attributes, string attrName) { }

	// RVA: 0x1053D20 Offset: 0x1052320 VA: 0x181053D20
	internal XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, out XmlSchema parentSchema) { }

	// RVA: 0x1053BE0 Offset: 0x10521E0 VA: 0x181053BE0
	internal XmlSchemaElement FindElement(XmlSchemaObjectCollection elements, string elementName) { }

	// RVA: 0x1053610 Offset: 0x1051C10 VA: 0x181053610
	internal XmlSchemaAttribute FindAttributeRef(ICollection attributes, string attributeName, string nsURI) { }

	// RVA: 0x1053A80 Offset: 0x1052080 VA: 0x181053A80
	internal XmlSchemaElement FindElementRef(XmlSchemaObjectCollection elements, string elementName, string nsURI) { }

	// RVA: 0x1059560 Offset: 0x1057B60 VA: 0x181059560
	internal void MakeExistingAttributesOptional(XmlSchemaComplexType ct, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x105B310 Offset: 0x1059910 VA: 0x18105B310
	private void SwitchUseToOptional(XmlSchemaObjectCollection attributes, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x105A200 Offset: 0x1058800 VA: 0x18105A200
	internal XmlQualifiedName RefineSimpleType(string s, ref int iTypeFlags) { }

	// RVA: 0x10584A0 Offset: 0x1056AA0 VA: 0x1810584A0
	internal static int InferSimpleType(string s, ref bool bNeedsRangeCheck) { }

	// RVA: 0x1053520 Offset: 0x1051B20 VA: 0x181053520
	internal static int DateTime(string s, bool bDate, bool bTime) { }

	// RVA: 0x1053110 Offset: 0x1051710 VA: 0x181053110
	private XmlSchemaElement CreateNewElementforChoice(XmlSchemaElement copyElement) { }

	// RVA: 0x1055480 Offset: 0x1053A80 VA: 0x181055480
	private static int GetSchemaType(XmlQualifiedName qname) { }

	// RVA: 0x105B100 Offset: 0x1059700 VA: 0x18105B100
	internal void SetMinMaxOccurs(XmlSchemaElement el, bool setMaxOccurs) { }

	// RVA: 0x105B450 Offset: 0x1059A50 VA: 0x18105B450
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

	// RVA: 0xD279F0 Offset: 0xD25FF0 VA: 0x180D279F0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10508C0 Offset: 0x104EEC0 VA: 0x1810508C0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10515E0 Offset: 0x104FBE0 VA: 0x1810515E0
	public void .ctor() { }

	// RVA: 0x1051D70 Offset: 0x1050370 VA: 0x181051D70
	internal void .ctor(string res, string arg) { }

	// RVA: 0x1051EB0 Offset: 0x10504B0 VA: 0x181051EB0
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

	// RVA: 0x1432740 Offset: 0x1430D40 VA: 0x181432740
	internal void .ctor(XmlSchemaType xmlType, bool value) { }

	// RVA: 0x1432520 Offset: 0x1430B20 VA: 0x181432520
	internal void .ctor(XmlSchemaType xmlType, DateTime value) { }

	// RVA: 0x1432A80 Offset: 0x1431080 VA: 0x181432A80
	internal void .ctor(XmlSchemaType xmlType, double value) { }

	// RVA: 0x14327E0 Offset: 0x1430DE0 VA: 0x1814327E0
	internal void .ctor(XmlSchemaType xmlType, int value) { }

	// RVA: 0x14326A0 Offset: 0x1430CA0 VA: 0x1814326A0
	internal void .ctor(XmlSchemaType xmlType, long value) { }

	// RVA: 0x1432B20 Offset: 0x1431120 VA: 0x181432B20
	internal void .ctor(XmlSchemaType xmlType, string value) { }

	// RVA: 0x1432880 Offset: 0x1430E80 VA: 0x181432880
	internal void .ctor(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x14325C0 Offset: 0x1430BC0 VA: 0x1814325C0
	internal void .ctor(XmlSchemaType xmlType, object value) { }

	// RVA: 0x1432C00 Offset: 0x1431200 VA: 0x181432C00
	internal void .ctor(XmlSchemaType xmlType, object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 15
	private object System.ICloneable.Clone() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 4
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0x1433500 Offset: 0x1431B00 VA: 0x181433500 Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0x1432E10 Offset: 0x1431410 VA: 0x181432E10 Slot: 6
	public override object get_TypedValue() { }

	// RVA: 0x1433000 Offset: 0x1431600 VA: 0x181433000 Slot: 8
	public override bool get_ValueAsBoolean() { }

	// RVA: 0x1433100 Offset: 0x1431700 VA: 0x181433100 Slot: 9
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0x1433200 Offset: 0x1431800 VA: 0x181433200 Slot: 10
	public override double get_ValueAsDouble() { }

	// RVA: 0x1433300 Offset: 0x1431900 VA: 0x181433300 Slot: 11
	public override int get_ValueAsInt() { }

	// RVA: 0x1433400 Offset: 0x1431A00 VA: 0x181433400 Slot: 12
	public override long get_ValueAsLong() { }

	// RVA: 0x1432300 Offset: 0x1430900 VA: 0x181432300 Slot: 14
	public override object ValueAs(Type type, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1433540 Offset: 0x1431B40 VA: 0x181433540 Slot: 5
	public override string get_Value() { }

	// RVA: 0x95F830 Offset: 0x95DE30 VA: 0x18095F830 Slot: 3
	public override string ToString() { }

	// RVA: 0x1432250 Offset: 0x1430850 VA: 0x181432250
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

	// RVA: 0x14295C0 Offset: 0x1427BC0 VA: 0x1814295C0
	public void .ctor(string prefix, string ns) { }

	// RVA: 0x1429550 Offset: 0x1427B50 VA: 0x181429550 Slot: 5
	public string LookupNamespace(string prefix) { }

	// RVA: 0x1429590 Offset: 0x1427B90 VA: 0x181429590 Slot: 6
	public string LookupPrefix(string namespaceName) { }

	// RVA: 0x14294D0 Offset: 0x1427AD0 VA: 0x1814294D0 Slot: 4
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
	[XmlAttributeAttribute] // RVA: 0x879E0 Offset: 0x86DE0 VA: 0x1800879E0
	[DefaultValueAttribute] // RVA: 0x879E0 Offset: 0x86DE0 VA: 0x1800879E0
	public XmlSchemaForm AttributeFormDefault { get; set; }
	[XmlAttributeAttribute] // RVA: 0x87CD0 Offset: 0x870D0 VA: 0x180087CD0
	[DefaultValueAttribute] // RVA: 0x87CD0 Offset: 0x870D0 VA: 0x180087CD0
	public XmlSchemaDerivationMethod BlockDefault { get; set; }
	[DefaultValueAttribute] // RVA: 0x880A0 Offset: 0x874A0 VA: 0x1800880A0
	[XmlAttributeAttribute] // RVA: 0x880A0 Offset: 0x874A0 VA: 0x1800880A0
	public XmlSchemaDerivationMethod FinalDefault { get; set; }
	[DefaultValueAttribute] // RVA: 0x883D0 Offset: 0x877D0 VA: 0x1800883D0
	[XmlAttributeAttribute] // RVA: 0x883D0 Offset: 0x877D0 VA: 0x1800883D0
	public XmlSchemaForm ElementFormDefault { get; set; }
	[XmlAttributeAttribute] // RVA: 0x88770 Offset: 0x87B70 VA: 0x180088770
	public string TargetNamespace { get; set; }
	[XmlAttributeAttribute] // RVA: 0x88840 Offset: 0x87C40 VA: 0x180088840
	public string Version { get; set; }
	[XmlElementAttribute] // RVA: 0x88A10 Offset: 0x87E10 VA: 0x180088A10
	[XmlElementAttribute] // RVA: 0x88A10 Offset: 0x87E10 VA: 0x180088A10
	[XmlElementAttribute] // RVA: 0x88A10 Offset: 0x87E10 VA: 0x180088A10
	public XmlSchemaObjectCollection Includes { get; }
	[XmlElementAttribute] // RVA: 0x88DF0 Offset: 0x881F0 VA: 0x180088DF0
	[XmlElementAttribute] // RVA: 0x88DF0 Offset: 0x881F0 VA: 0x180088DF0
	[XmlElementAttribute] // RVA: 0x88DF0 Offset: 0x881F0 VA: 0x180088DF0
	[XmlElementAttribute] // RVA: 0x88DF0 Offset: 0x881F0 VA: 0x180088DF0
	[XmlElementAttribute] // RVA: 0x88DF0 Offset: 0x881F0 VA: 0x180088DF0
	[XmlElementAttribute] // RVA: 0x88DF0 Offset: 0x881F0 VA: 0x180088DF0
	[XmlElementAttribute] // RVA: 0x88DF0 Offset: 0x881F0 VA: 0x180088DF0
	[XmlElementAttribute] // RVA: 0x88DF0 Offset: 0x881F0 VA: 0x180088DF0
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal bool IsCompiledBySet { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal bool IsPreprocessed { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal bool IsRedefined { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaObjectTable Attributes { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaObjectTable AttributeGroups { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaObjectTable SchemaTypes { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaObjectTable Elements { get; }
	[XmlAttributeAttribute] // RVA: 0x8AAD0 Offset: 0x89ED0 VA: 0x18008AAD0
	public string Id { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaObjectTable Groups { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaObjectTable Notations { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal XmlSchemaObjectTable IdentityConstraints { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal Uri BaseUri { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal int SchemaId { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal bool IsChameleon { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal Hashtable Ids { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal XmlDocument Document { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal int ErrorCount { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal override string IdAttribute { get; set; }
	internal ArrayList ImportedSchemas { get; }
	internal ArrayList ImportedNamespaces { get; }

	// Methods

	// RVA: 0x1449EE0 Offset: 0x14484E0 VA: 0x181449EE0
	public void .ctor() { }

	// RVA: 0x1449D40 Offset: 0x1448340 VA: 0x181449D40
	public static XmlSchema Read(XmlReader reader, ValidationEventHandler validationEventHandler) { }

	// RVA: 0x14495B0 Offset: 0x1447BB0 VA: 0x1814495B0
	internal bool CompileSchema(XmlSchemaCollection xsc, XmlResolver resolver, SchemaInfo schemaInfo, string ns, ValidationEventHandler validationEventHandler, XmlNameTable nameTable, bool CompileContentModel) { }

	// RVA: 0x14494F0 Offset: 0x1447AF0 VA: 0x1814494F0
	internal void CompileSchemaInSet(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x6BB940 Offset: 0x6B9F40 VA: 0x1806BB940
	public XmlSchemaForm get_AttributeFormDefault() { }

	// RVA: 0xC74910 Offset: 0xC72F10 VA: 0x180C74910
	public void set_AttributeFormDefault(XmlSchemaForm value) { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	public XmlSchemaDerivationMethod get_BlockDefault() { }

	// RVA: 0x684160 Offset: 0x682760 VA: 0x180684160
	public void set_BlockDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x5DE450 Offset: 0x5DCA50 VA: 0x1805DE450
	public XmlSchemaDerivationMethod get_FinalDefault() { }

	// RVA: 0x8C0D00 Offset: 0x8BF300 VA: 0x1808C0D00
	public void set_FinalDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50
	public XmlSchemaForm get_ElementFormDefault() { }

	// RVA: 0x8C1070 Offset: 0x8BF670 VA: 0x1808C1070
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

	// RVA: 0x1050520 Offset: 0x104EB20 VA: 0x181050520
	internal bool get_IsCompiledBySet() { }

	// RVA: 0x10FF150 Offset: 0x10FD750 VA: 0x1810FF150
	internal void set_IsCompiledBySet(bool value) { }

	// RVA: 0x1050570 Offset: 0x104EB70 VA: 0x181050570
	internal bool get_IsPreprocessed() { }

	// RVA: 0x144A4F0 Offset: 0x1448AF0 VA: 0x18144A4F0
	internal void set_IsPreprocessed(bool value) { }

	// RVA: 0x1050560 Offset: 0x104EB60 VA: 0x181050560
	internal bool get_IsRedefined() { }

	// RVA: 0x144A500 Offset: 0x1448B00 VA: 0x18144A500
	internal void set_IsRedefined(bool value) { }

	// RVA: 0x144A140 Offset: 0x1448740 VA: 0x18144A140
	public XmlSchemaObjectTable get_Attributes() { }

	// RVA: 0x144A0C0 Offset: 0x14486C0 VA: 0x18144A0C0
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x144A450 Offset: 0x1448A50 VA: 0x18144A450
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x144A240 Offset: 0x1448840 VA: 0x18144A240
	public XmlSchemaObjectTable get_Elements() { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public string get_Id() { }

	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50
	public void set_Id(string value) { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x952B90 Offset: 0x951190 VA: 0x180952B90
	public XmlSchemaObjectTable get_Notations() { }

	// RVA: 0x9921A0 Offset: 0x9907A0 VA: 0x1809921A0
	internal XmlSchemaObjectTable get_IdentityConstraints() { }

	// RVA: 0xC73A80 Offset: 0xC72080 VA: 0x180C73A80
	internal Uri get_BaseUri() { }

	// RVA: 0xC73BD0 Offset: 0xC721D0 VA: 0x180C73BD0
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x144A3D0 Offset: 0x14489D0 VA: 0x18144A3D0
	internal int get_SchemaId() { }

	// RVA: 0x144A3C0 Offset: 0x14489C0 VA: 0x18144A3C0
	internal bool get_IsChameleon() { }

	// RVA: 0x144A4E0 Offset: 0x1448AE0 VA: 0x18144A4E0
	internal void set_IsChameleon(bool value) { }

	// RVA: 0x4EF3A0 Offset: 0x4ED9A0 VA: 0x1804EF3A0
	internal Hashtable get_Ids() { }

	// RVA: 0x144A1C0 Offset: 0x14487C0 VA: 0x18144A1C0
	internal XmlDocument get_Document() { }

	// RVA: 0x100FF30 Offset: 0x100E530 VA: 0x18100FF30
	internal int get_ErrorCount() { }

	// RVA: 0x144A4D0 Offset: 0x1448AD0 VA: 0x18144A4D0
	internal void set_ErrorCount(int value) { }

	// RVA: 0x1449400 Offset: 0x1447A00 VA: 0x181449400
	internal XmlSchema Clone() { }

	// RVA: 0x1449770 Offset: 0x1447D70 VA: 0x181449770
	internal XmlSchema DeepClone() { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x1449E90 Offset: 0x1448490 VA: 0x181449E90
	internal void SetIsCompiled(bool isCompiled) { }

	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x14493E0 Offset: 0x14479E0 VA: 0x1814493E0 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x144A340 Offset: 0x1448940 VA: 0x18144A340
	internal ArrayList get_ImportedSchemas() { }

	// RVA: 0x144A2C0 Offset: 0x14488C0 VA: 0x18144A2C0
	internal ArrayList get_ImportedNamespaces() { }

	// RVA: 0x1449B10 Offset: 0x1448110 VA: 0x181449B10
	internal void GetExternalSchemasList(IList extList, XmlSchema schema) { }

	// RVA: 0x1449EA0 Offset: 0x14484A0 VA: 0x181449EA0
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

	// RVA: 0x104ACB0 Offset: 0x10492B0 VA: 0x18104ACB0 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x4E8840 Offset: 0x4E6E40 VA: 0x1804E8840 Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x104AC10 Offset: 0x1049210 VA: 0x18104AC10
	public void .ctor() { }

}

public class XmlSchemaAnnotated : XmlSchemaObject // TypeDefIndex: 2308
{	// Fields
	private string id; // 0x38
	private XmlSchemaAnnotation annotation; // 0x40
	private XmlAttribute[] moreAttributes; // 0x48

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8AAD0 Offset: 0x89ED0 VA: 0x18008AAD0
	public string Id { get; set; }
	[XmlElementAttribute] // RVA: 0x8B250 Offset: 0x8A650 VA: 0x18008B250
	public XmlSchemaAnnotation Annotation { get; set; }
	[XmlAnyAttributeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlAttribute[] UnhandledAttributes { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal override string IdAttribute { get; set; }

	// Methods

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_Id() { }

	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
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

	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0 Slot: 8
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
	[XmlAttributeAttribute] // RVA: 0x8AAD0 Offset: 0x89ED0 VA: 0x18008AAD0
	public string Id { get; set; }
	[XmlElementAttribute] // RVA: 0x8C7B0 Offset: 0x8BBB0 VA: 0x18008C7B0
	[XmlElementAttribute] // RVA: 0x8C7B0 Offset: 0x8BBB0 VA: 0x18008C7B0
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal override string IdAttribute { get; set; }

	// Methods

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_Id() { }

	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	public void set_Id(string value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x104ACF0 Offset: 0x10492F0 VA: 0x18104ACF0
	public void .ctor() { }

}

public class XmlSchemaAny : XmlSchemaParticle // TypeDefIndex: 2310
{	// Fields
	private string ns; // 0x78
	private XmlSchemaContentProcessing processContents; // 0x80
	private NamespaceList namespaceList; // 0x88

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8CAB0 Offset: 0x8BEB0 VA: 0x18008CAB0
	public string Namespace { get; set; }
	[DefaultValueAttribute] // RVA: 0x8CB40 Offset: 0x8BF40 VA: 0x18008CB40
	[XmlAttributeAttribute] // RVA: 0x8CB40 Offset: 0x8BF40 VA: 0x18008CB40
	public XmlSchemaContentProcessing ProcessContents { set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal NamespaceList NamespaceList { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal string ResolvedNamespace { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x104B620 Offset: 0x1049C20 VA: 0x18104B620
	internal string get_ResolvedNamespace() { }

	// RVA: 0x104B600 Offset: 0x1049C00 VA: 0x18104B600
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x104B2A0 Offset: 0x10498A0 VA: 0x18104B2A0 Slot: 15
	internal override string get_NameString() { }

	// RVA: 0x104B1A0 Offset: 0x10497A0 VA: 0x18104B1A0
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x104B0F0 Offset: 0x10496F0 VA: 0x18104B0F0
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x104B0B0 Offset: 0x10496B0 VA: 0x18104B0B0
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x104B240 Offset: 0x1049840 VA: 0x18104B240
	public void .ctor() { }

}

public class XmlSchemaAnyAttribute : XmlSchemaAnnotated // TypeDefIndex: 2311
{	// Fields
	private string ns; // 0x50
	private XmlSchemaContentProcessing processContents; // 0x58
	private NamespaceList namespaceList; // 0x60

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8CAB0 Offset: 0x8BEB0 VA: 0x18008CAB0
	public string Namespace { set; }
	[XmlAttributeAttribute] // RVA: 0x8CF50 Offset: 0x8C350 VA: 0x18008CF50
	[DefaultValueAttribute] // RVA: 0x8CF50 Offset: 0x8C350 VA: 0x18008CF50
	public XmlSchemaContentProcessing ProcessContents { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal NamespaceList NamespaceList { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal XmlSchemaContentProcessing ProcessContentsCorrect { get; }

	// Methods

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	public void set_Namespace(string value) { }

	// RVA: 0xAE97E0 Offset: 0xAE7DE0 VA: 0x180AE97E0
	public XmlSchemaContentProcessing get_ProcessContents() { }

	// RVA: 0xD27970 Offset: 0xD25F70 VA: 0x180D27970
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x104B0A0 Offset: 0x10496A0 VA: 0x18104B0A0
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x104AE40 Offset: 0x1049440 VA: 0x18104AE40
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x104ADA0 Offset: 0x10493A0 VA: 0x18104ADA0
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x104AD60 Offset: 0x1049360 VA: 0x18104AD60
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x104AFA0 Offset: 0x10495A0 VA: 0x18104AFA0
	internal static bool IsSubset(XmlSchemaAnyAttribute sub, XmlSchemaAnyAttribute super) { }

	// RVA: 0x104AED0 Offset: 0x10494D0 VA: 0x18104AED0
	internal static XmlSchemaAnyAttribute Intersection(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x104AFD0 Offset: 0x10495D0 VA: 0x18104AFD0
	internal static XmlSchemaAnyAttribute Union(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class XmlSchemaAppInfo : XmlSchemaObject // TypeDefIndex: 2312
{	// Fields
	private string source; // 0x38
	private XmlNode[] markup; // 0x40

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8D300 Offset: 0x8C700 VA: 0x18008D300
	public string Source { set; }
	[XmlTextAttribute] // RVA: 0x8D390 Offset: 0x8C790 VA: 0x18008D390
	[XmlAnyElementAttribute] // RVA: 0x8D390 Offset: 0x8C790 VA: 0x18008D390
	public XmlNode[] Markup { get; set; }

	// Methods

	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
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
	[XmlAttributeAttribute] // RVA: 0x8D500 Offset: 0x8C900 VA: 0x18008D500
	[DefaultValueAttribute] // RVA: 0x8D500 Offset: 0x8C900 VA: 0x18008D500
	public string DefaultValue { get; set; }
	[DefaultValueAttribute] // RVA: 0x8D5B0 Offset: 0x8C9B0 VA: 0x18008D5B0
	[XmlAttributeAttribute] // RVA: 0x8D5B0 Offset: 0x8C9B0 VA: 0x18008D5B0
	public string FixedValue { get; set; }
	[DefaultValueAttribute] // RVA: 0x8D7C0 Offset: 0x8CBC0 VA: 0x18008D7C0
	[XmlAttributeAttribute] // RVA: 0x8D7C0 Offset: 0x8CBC0 VA: 0x18008D7C0
	public XmlSchemaForm Form { get; set; }
	[XmlAttributeAttribute] // RVA: 0x8D960 Offset: 0x8CD60 VA: 0x18008D960
	public string Name { get; set; }
	[XmlAttributeAttribute] // RVA: 0x8DAD0 Offset: 0x8CED0 VA: 0x18008DAD0
	public XmlQualifiedName RefName { get; set; }
	[XmlAttributeAttribute] // RVA: 0x8DB60 Offset: 0x8CF60 VA: 0x18008DB60
	public XmlQualifiedName SchemaTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x8DCF0 Offset: 0x8D0F0 VA: 0x18008DCF0
	public XmlSchemaSimpleType SchemaType { get; set; }
	[XmlAttributeAttribute] // RVA: 0x8DDE0 Offset: 0x8D1E0 VA: 0x18008DDE0
	[DefaultValueAttribute] // RVA: 0x8DDE0 Offset: 0x8D1E0 VA: 0x18008DDE0
	public XmlSchemaUse Use { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaSimpleType AttributeSchemaType { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal XmlSchemaDatatype Datatype { get; }
	internal SchemaAttDef AttDef { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x803A80 Offset: 0x802080 VA: 0x180803A80
	public XmlSchemaForm get_Form() { }

	// RVA: 0x803AB0 Offset: 0x8020B0 VA: 0x180803AB0
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public string get_Name() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	public void set_Name(string value) { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x104BBD0 Offset: 0x104A1D0 VA: 0x18104BBD0
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x104BC90 Offset: 0x104A290 VA: 0x18104BC90
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public XmlSchemaSimpleType get_SchemaType() { }

	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	public void set_SchemaType(XmlSchemaSimpleType value) { }

	// RVA: 0x803A60 Offset: 0x802060 VA: 0x180803A60
	public XmlSchemaUse get_Use() { }

	// RVA: 0x803A90 Offset: 0x802090 VA: 0x180803A90
	public void set_Use(XmlSchemaUse value) { }

	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050
	public XmlSchemaSimpleType get_AttributeSchemaType() { }

	// RVA: 0x104BBB0 Offset: 0x104A1B0 VA: 0x18104BBB0
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

	// RVA: 0x104B9F0 Offset: 0x1049FF0 VA: 0x18104B9F0 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x104BAF0 Offset: 0x104A0F0 VA: 0x18104BAF0
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
	[XmlAttributeAttribute] // RVA: 0x8D960 Offset: 0x8CD60 VA: 0x18008D960
	public string Name { get; set; }
	[XmlElementAttribute] // RVA: 0x8E390 Offset: 0x8D790 VA: 0x18008E390
	[XmlElementAttribute] // RVA: 0x8E390 Offset: 0x8D790 VA: 0x18008E390
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] // RVA: 0x8E600 Offset: 0x8DA00 VA: 0x18008E600
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal XmlSchemaObjectTable AttributeUses { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal XmlSchemaAnyAttribute AttributeWildcard { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaAttributeGroup RedefinedAttributeGroup { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal XmlSchemaAttributeGroup Redefined { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal int SelfReferenceCount { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x104B980 Offset: 0x1049F80 VA: 0x18104B980
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

	// RVA: 0xF8C000 Offset: 0xF8A600 VA: 0x180F8C000
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x104B7A0 Offset: 0x1049DA0 VA: 0x18104B7A0 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x104B8D0 Offset: 0x1049ED0 VA: 0x18104B8D0
	public void .ctor() { }

}

public class XmlSchemaAttributeGroupRef : XmlSchemaAnnotated // TypeDefIndex: 2315
{	// Fields
	private XmlQualifiedName refName; // 0x50

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8DAD0 Offset: 0x8CED0 VA: 0x18008DAD0
	public XmlQualifiedName RefName { get; set; }

	// Methods

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x104B6E0 Offset: 0x1049CE0 VA: 0x18104B6E0
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x104B660 Offset: 0x1049C60 VA: 0x18104B660
	public void .ctor() { }

}

public class XmlSchemaChoice : XmlSchemaGroupBase // TypeDefIndex: 2316
{	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Properties
	[XmlElementAttribute] // RVA: 0x8E9E0 Offset: 0x8DDE0 VA: 0x18008E9E0
	[XmlElementAttribute] // RVA: 0x8E9E0 Offset: 0x8DDE0 VA: 0x18008E9E0
	[XmlElementAttribute] // RVA: 0x8E9E0 Offset: 0x8DDE0 VA: 0x18008E9E0
	[XmlElementAttribute] // RVA: 0x8E9E0 Offset: 0x8DDE0 VA: 0x18008E9E0
	[XmlElementAttribute] // RVA: 0x8E9E0 Offset: 0x8DDE0 VA: 0x18008E9E0
	public override XmlSchemaObjectCollection Items { get; }
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x104BDF0 Offset: 0x104A3F0 VA: 0x18104BDF0 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x4E8840 Offset: 0x4E6E40 VA: 0x1804E8840 Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x104BD50 Offset: 0x104A350 VA: 0x18104BD50
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

	// RVA: 0x104C910 Offset: 0x104AF10 VA: 0x18104C910
	public void .ctor(XmlNameTable nametable) { }

	// RVA: 0x104C850 Offset: 0x104AE50 VA: 0x18104C850
	public int get_Count() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public XmlNameTable get_NameTable() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x104CA20 Offset: 0x104B020 VA: 0x18104CA20
	public XmlSchema get_Item(string ns) { }

	// RVA: 0x104C880 Offset: 0x104AE80 VA: 0x18104C880 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x104C490 Offset: 0x104AA90 VA: 0x18104C490
	public XmlSchemaCollectionEnumerator GetEnumerator() { }

	// RVA: 0x104C670 Offset: 0x104AC70 VA: 0x18104C670 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x104C850 Offset: 0x104AE50 VA: 0x18104C850 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x104C520 Offset: 0x104AB20 VA: 0x18104C520
	internal SchemaInfo GetSchemaInfo(string ns) { }

	// RVA: 0x104C5C0 Offset: 0x104ABC0 VA: 0x18104C5C0
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x104C040 Offset: 0x104A640 VA: 0x18104C040
	internal XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile) { }

	// RVA: 0x104C310 Offset: 0x104A910 VA: 0x18104C310
	private XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile, XmlResolver resolver) { }

	// RVA: 0x104C1C0 Offset: 0x104A7C0 VA: 0x18104C1C0
	private void Add(string ns, XmlSchemaCollectionNode node) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	internal ValidationEventHandler get_EventHandler() { }

	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
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

	// RVA: 0x104BF00 Offset: 0x104A500 VA: 0x18104BF00
	internal void .ctor(Hashtable collection) { }

	// RVA: 0x104BEA0 Offset: 0x104A4A0 VA: 0x18104BEA0 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x104BE50 Offset: 0x104A450 VA: 0x18104BE50 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x104BE00 Offset: 0x104A400 VA: 0x18104BE00
	public bool MoveNext() { }

	// RVA: 0x104BEF0 Offset: 0x104A4F0 VA: 0x18104BEF0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x104BFC0 Offset: 0x104A5C0 VA: 0x18104BFC0
	public XmlSchema get_Current() { }

	// RVA: 0x104BF50 Offset: 0x104A550 VA: 0x18104BF50
	internal XmlSchemaCollectionNode get_CurrentNode() { }

}

public sealed class XmlSchemaCompilationSettings // TypeDefIndex: 2320
{	// Fields
	private bool enableUpaCheck; // 0x10

	// Properties
	public bool EnableUpaCheck { get; }

	// Methods

	// RVA: 0x104CAC0 Offset: 0x104B0C0 VA: 0x18104CAC0
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
	[XmlAttributeAttribute] // RVA: 0x8EEF0 Offset: 0x8E2F0 VA: 0x18008EEF0
	public bool IsMixed { get; set; }
	[XmlElementAttribute] // RVA: 0x8F160 Offset: 0x8E560 VA: 0x18008F160
	[XmlElementAttribute] // RVA: 0x8F160 Offset: 0x8E560 VA: 0x18008F160
	public override XmlSchemaContent Content { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal bool HasMixedAttribute { get; }

	// Methods

	// RVA: 0x592630 Offset: 0x590C30 VA: 0x180592630
	public bool get_IsMixed() { }

	// RVA: 0x104CDC0 Offset: 0x104B3C0 VA: 0x18104CDC0
	public void set_IsMixed(bool value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 14
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890 Slot: 15
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0xAF5CE0 Offset: 0xAF42E0 VA: 0x180AF5CE0
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
	[XmlAttributeAttribute] // RVA: 0x8F450 Offset: 0x8E850 VA: 0x18008F450
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x8F650 Offset: 0x8EA50 VA: 0x18008F650
	[XmlElementAttribute] // RVA: 0x8F650 Offset: 0x8EA50 VA: 0x18008F650
	[XmlElementAttribute] // RVA: 0x8F650 Offset: 0x8EA50 VA: 0x18008F650
	[XmlElementAttribute] // RVA: 0x8F650 Offset: 0x8EA50 VA: 0x18008F650
	public XmlSchemaParticle Particle { get; set; }
	[XmlElementAttribute] // RVA: 0x8F930 Offset: 0x8ED30 VA: 0x18008F930
	[XmlElementAttribute] // RVA: 0x8F930 Offset: 0x8ED30 VA: 0x18008F930
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] // RVA: 0x8E600 Offset: 0x8DA00 VA: 0x18008E600
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x104CB90 Offset: 0x104B190 VA: 0x18104CB90
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

	// RVA: 0x104CAE0 Offset: 0x104B0E0 VA: 0x18104CAE0
	public void .ctor() { }

}

public class XmlSchemaComplexContentRestriction : XmlSchemaContent // TypeDefIndex: 2323
{	// Fields
	private XmlSchemaParticle particle; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName baseTypeName; // 0x68

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8F450 Offset: 0x8E850 VA: 0x18008F450
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x8FCB0 Offset: 0x8F0B0 VA: 0x18008FCB0
	[XmlElementAttribute] // RVA: 0x8FCB0 Offset: 0x8F0B0 VA: 0x18008FCB0
	[XmlElementAttribute] // RVA: 0x8FCB0 Offset: 0x8F0B0 VA: 0x18008FCB0
	[XmlElementAttribute] // RVA: 0x8FCB0 Offset: 0x8F0B0 VA: 0x18008FCB0
	public XmlSchemaParticle Particle { get; set; }
	[XmlElementAttribute] // RVA: 0x90020 Offset: 0x8F420 VA: 0x180090020
	[XmlElementAttribute] // RVA: 0x90020 Offset: 0x8F420 VA: 0x180090020
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] // RVA: 0x8E600 Offset: 0x8DA00 VA: 0x18008E600
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x104CD00 Offset: 0x104B300 VA: 0x18104CD00
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

	// RVA: 0x104CC50 Offset: 0x104B250 VA: 0x18104CC50
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
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal static XmlSchemaComplexType AnyType { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal static XmlSchemaComplexType UntypedAnyType { get; }
	internal static ContentValidator AnyTypeContentValidator { get; }
	[XmlAttributeAttribute] // RVA: 0x903F0 Offset: 0x8F7F0 VA: 0x1800903F0
	[DefaultValueAttribute] // RVA: 0x903F0 Offset: 0x8F7F0 VA: 0x1800903F0
	public bool IsAbstract { get; set; }
	[XmlAttributeAttribute] // RVA: 0x90540 Offset: 0x8F940 VA: 0x180090540
	[DefaultValueAttribute] // RVA: 0x90540 Offset: 0x8F940 VA: 0x180090540
	public XmlSchemaDerivationMethod Block { get; set; }
	[XmlAttributeAttribute] // RVA: 0x90800 Offset: 0x8FC00 VA: 0x180090800
	[DefaultValueAttribute] // RVA: 0x90800 Offset: 0x8FC00 VA: 0x180090800
	public override bool IsMixed { get; set; }
	[XmlElementAttribute] // RVA: 0x90910 Offset: 0x8FD10 VA: 0x180090910
	[XmlElementAttribute] // RVA: 0x90910 Offset: 0x8FD10 VA: 0x180090910
	public XmlSchemaContentModel ContentModel { get; set; }
	[XmlElementAttribute] // RVA: 0x90CB0 Offset: 0x900B0 VA: 0x180090CB0
	[XmlElementAttribute] // RVA: 0x90CB0 Offset: 0x900B0 VA: 0x180090CB0
	[XmlElementAttribute] // RVA: 0x90CB0 Offset: 0x900B0 VA: 0x180090CB0
	[XmlElementAttribute] // RVA: 0x90CB0 Offset: 0x900B0 VA: 0x180090CB0
	public XmlSchemaParticle Particle { get; set; }
	[XmlElementAttribute] // RVA: 0x910B0 Offset: 0x904B0 VA: 0x1800910B0
	[XmlElementAttribute] // RVA: 0x910B0 Offset: 0x904B0 VA: 0x1800910B0
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] // RVA: 0x8E600 Offset: 0x8DA00 VA: 0x18008E600
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaContentType ContentType { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaParticle ContentTypeParticle { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaDerivationMethod BlockResolved { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaObjectTable AttributeUses { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaAnyAttribute AttributeWildcard { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal XmlSchemaObjectTable LocalElements { get; }
	internal bool HasWildCard { set; }

	// Methods

	// RVA: 0x104EC80 Offset: 0x104D280 VA: 0x18104EC80
	private static void .cctor() { }

	// RVA: 0x104E380 Offset: 0x104C980 VA: 0x18104E380
	private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents) { }

	// RVA: 0x104EF50 Offset: 0x104D550 VA: 0x18104EF50
	public void .ctor() { }

	// RVA: 0x104F050 Offset: 0x104D650 VA: 0x18104F050
	internal static XmlSchemaComplexType get_AnyType() { }

	// RVA: 0x104F260 Offset: 0x104D860 VA: 0x18104F260
	internal static XmlSchemaComplexType get_UntypedAnyType() { }

	// RVA: 0x104EFD0 Offset: 0x104D5D0 VA: 0x18104EFD0
	internal static ContentValidator get_AnyTypeContentValidator() { }

	// RVA: 0x104F1C0 Offset: 0x104D7C0 VA: 0x18104F1C0
	public bool get_IsAbstract() { }

	// RVA: 0x104F300 Offset: 0x104D900 VA: 0x18104F300
	public void set_IsAbstract(bool value) { }

	// RVA: 0xB9B270 Offset: 0xB99870 VA: 0x180B9B270
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x104F2C0 Offset: 0x104D8C0 VA: 0x18104F2C0
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x104F1D0 Offset: 0x104D7D0 VA: 0x18104F1D0 Slot: 14
	public override bool get_IsMixed() { }

	// RVA: 0x104F330 Offset: 0x104D930 VA: 0x18104F330 Slot: 15
	public override void set_IsMixed(bool value) { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public XmlSchemaContentModel get_ContentModel() { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	public void set_ContentModel(XmlSchemaContentModel value) { }

	// RVA: 0x952B90 Offset: 0x951190 VA: 0x180952B90
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0xC73C90 Offset: 0xC72290 VA: 0x180C73C90
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x104F130 Offset: 0x104D730 VA: 0x18104F130
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x7ACF70 Offset: 0x7AB570 VA: 0x1807ACF70
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0xA4D230 Offset: 0xA4B830 VA: 0x180A4D230
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0xD277E0 Offset: 0xD25DE0 VA: 0x180D277E0
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x104F1B0 Offset: 0x104D7B0 VA: 0x18104F1B0
	public XmlSchemaParticle get_ContentTypeParticle() { }

	// RVA: 0xAE2A40 Offset: 0xAE1040 VA: 0x180AE2A40
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x104F0B0 Offset: 0x104D6B0 VA: 0x18104F0B0
	public XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x4EF3A0 Offset: 0x4ED9A0 VA: 0x1804EF3A0
	public XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x104F1E0 Offset: 0x104D7E0 VA: 0x18104F1E0
	internal XmlSchemaObjectTable get_LocalElements() { }

	// RVA: 0xEFAF20 Offset: 0xEF9520 VA: 0x180EFAF20
	internal void SetContentTypeParticle(XmlSchemaParticle value) { }

	// RVA: 0x104EC70 Offset: 0x104D270 VA: 0x18104EC70
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x4EF3B0 Offset: 0x4ED9B0 VA: 0x1804EF3B0
	internal void SetAttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x104F2D0 Offset: 0x104D8D0 VA: 0x18104F2D0
	internal void set_HasWildCard(bool value) { }

	// RVA: 0xA4D220 Offset: 0xA4B820 VA: 0x180A4D220
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x104E150 Offset: 0x104C750 VA: 0x18104E150
	internal bool ContainsIdAttribute(bool findAll) { }

	// RVA: 0x104E140 Offset: 0x104C740 VA: 0x18104E140 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x104D730 Offset: 0x104BD30 VA: 0x18104D730
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x104CDD0 Offset: 0x104B3D0 VA: 0x18104CDD0
	private void ClearCompiledState() { }

	// RVA: 0x104CE90 Offset: 0x104B490 VA: 0x18104CE90
	internal static XmlSchemaObjectCollection CloneAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x104D120 Offset: 0x104B720 VA: 0x18104D120
	private static XmlSchemaObjectCollection CloneGroupBaseParticles(XmlSchemaObjectCollection groupBaseParticles, XmlSchema parentSchema) { }

	// RVA: 0x104D260 Offset: 0x104B860 VA: 0x18104D260
	internal static XmlSchemaParticle CloneParticle(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x104E7C0 Offset: 0x104CDC0 VA: 0x18104E7C0
	private static XmlSchemaForm GetResolvedElementForm(XmlSchema parentSchema, XmlSchemaElement element) { }

	// RVA: 0x104E960 Offset: 0x104CF60 VA: 0x18104E960
	internal static bool HasParticleRef(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x104E7F0 Offset: 0x104CDF0 VA: 0x18104E7F0
	internal static bool HasAttributeQNameRef(XmlSchemaObjectCollection attributes) { }

}

public abstract class XmlSchemaContent : XmlSchemaAnnotated // TypeDefIndex: 2325
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

public abstract class XmlSchemaContentModel : XmlSchemaAnnotated // TypeDefIndex: 2326
{	// Properties
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public const XmlSchemaContentProcessing None = 0;
	[XmlEnumAttribute] // RVA: 0x91720 Offset: 0x90B20 VA: 0x180091720
	public const XmlSchemaContentProcessing Skip = 1;
	[XmlEnumAttribute] // RVA: 0x918A0 Offset: 0x90CA0 VA: 0x1800918A0
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

	// RVA: 0x104FE50 Offset: 0x104E450 VA: 0x18104FE50
	internal string get_TypeCodeString() { }

	// RVA: 0x104F920 Offset: 0x104DF20 VA: 0x18104F920
	internal string TypeCodeToString(XmlTypeCode typeCode) { }

	// RVA: 0x104F360 Offset: 0x104D960 VA: 0x18104F360
	internal static string ConcatenatedToString(object value) { }

	// RVA: 0x104F8D0 Offset: 0x104DED0 VA: 0x18104F8D0
	internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x104F880 Offset: 0x104DE80 VA: 0x18104F880
	internal static XmlSchemaDatatype FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x104F820 Offset: 0x104DE20 VA: 0x18104F820
	internal static XmlSchemaDatatype FromXdrName(string name) { }

	// RVA: 0x104F7B0 Offset: 0x104DDB0 VA: 0x18104F7B0
	internal static XmlSchemaDatatype DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x104FCB0 Offset: 0x104E2B0 VA: 0x18104FCB0
	internal static string XdrCanonizeUri(string uri, XmlNameTable nameTable, SchemaNames schemaNames) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

public enum XmlSchemaDerivationMethod // TypeDefIndex: 2330
{	// Fields
	public int value__; // 0x0
	[XmlEnumAttribute] // RVA: 0x91B60 Offset: 0x90F60 VA: 0x180091B60
	public const XmlSchemaDerivationMethod Empty = 0;
	[XmlEnumAttribute] // RVA: 0x92F40 Offset: 0x92340 VA: 0x180092F40
	public const XmlSchemaDerivationMethod Substitution = 1;
	[XmlEnumAttribute] // RVA: 0x92FD0 Offset: 0x923D0 VA: 0x180092FD0
	public const XmlSchemaDerivationMethod Extension = 2;
	[XmlEnumAttribute] // RVA: 0x93060 Offset: 0x92460 VA: 0x180093060
	public const XmlSchemaDerivationMethod Restriction = 4;
	[XmlEnumAttribute] // RVA: 0x93110 Offset: 0x92510 VA: 0x180093110
	public const XmlSchemaDerivationMethod List = 8;
	[XmlEnumAttribute] // RVA: 0x93220 Offset: 0x92620 VA: 0x180093220
	public const XmlSchemaDerivationMethod Union = 16;
	[XmlEnumAttribute] // RVA: 0x93350 Offset: 0x92750 VA: 0x180093350
	public const XmlSchemaDerivationMethod All = 255;
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public const XmlSchemaDerivationMethod None = 256;

}

public class XmlSchemaDocumentation : XmlSchemaObject // TypeDefIndex: 2331
{	// Fields
	private string source; // 0x38
	private string language; // 0x40
	private XmlNode[] markup; // 0x48
	private static XmlSchemaSimpleType languageType; // 0x0

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8D300 Offset: 0x8C700 VA: 0x18008D300
	public string Source { set; }
	[XmlAttributeAttribute] // RVA: 0x93570 Offset: 0x92970 VA: 0x180093570
	public string Language { set; }
	[XmlAnyElementAttribute] // RVA: 0x93640 Offset: 0x92A40 VA: 0x180093640
	[XmlTextAttribute] // RVA: 0x93640 Offset: 0x92A40 VA: 0x180093640
	public XmlNode[] Markup { set; }

	// Methods

	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	public void set_Source(string value) { }

	// RVA: 0x1050010 Offset: 0x104E610 VA: 0x181050010
	public void set_Language(string value) { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x104FF80 Offset: 0x104E580 VA: 0x18104FF80
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
	[DefaultValueAttribute] // RVA: 0x93810 Offset: 0x92C10 VA: 0x180093810
	[XmlAttributeAttribute] // RVA: 0x93810 Offset: 0x92C10 VA: 0x180093810
	public XmlSchemaDerivationMethod Block { get; set; }
	[XmlAttributeAttribute] // RVA: 0x8D500 Offset: 0x8C900 VA: 0x18008D500
	[DefaultValueAttribute] // RVA: 0x8D500 Offset: 0x8C900 VA: 0x18008D500
	public string DefaultValue { get; set; }
	[DefaultValueAttribute] // RVA: 0x939D0 Offset: 0x92DD0 VA: 0x1800939D0
	[XmlAttributeAttribute] // RVA: 0x939D0 Offset: 0x92DD0 VA: 0x1800939D0
	public XmlSchemaDerivationMethod Final { get; set; }
	[DefaultValueAttribute] // RVA: 0x8D5B0 Offset: 0x8C9B0 VA: 0x18008D5B0
	[XmlAttributeAttribute] // RVA: 0x8D5B0 Offset: 0x8C9B0 VA: 0x18008D5B0
	public string FixedValue { get; set; }
	[DefaultValueAttribute] // RVA: 0x93C00 Offset: 0x93000 VA: 0x180093C00
	[XmlAttributeAttribute] // RVA: 0x93C00 Offset: 0x93000 VA: 0x180093C00
	public XmlSchemaForm Form { get; set; }
	[DefaultValueAttribute] // RVA: 0x93D70 Offset: 0x93170 VA: 0x180093D70
	[XmlAttributeAttribute] // RVA: 0x93D70 Offset: 0x93170 VA: 0x180093D70
	public string Name { get; set; }
	[XmlAttributeAttribute] // RVA: 0x93EA0 Offset: 0x932A0 VA: 0x180093EA0
	[DefaultValueAttribute] // RVA: 0x93EA0 Offset: 0x932A0 VA: 0x180093EA0
	public bool IsNillable { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal bool HasNillableAttribute { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal bool HasAbstractAttribute { get; }
	[XmlAttributeAttribute] // RVA: 0x8DAD0 Offset: 0x8CED0 VA: 0x18008DAD0
	public XmlQualifiedName RefName { get; set; }
	[XmlAttributeAttribute] // RVA: 0x94110 Offset: 0x93510 VA: 0x180094110
	public XmlQualifiedName SubstitutionGroup { get; set; }
	[XmlAttributeAttribute] // RVA: 0x8DB60 Offset: 0x8CF60 VA: 0x18008DB60
	public XmlQualifiedName SchemaTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x94220 Offset: 0x93620 VA: 0x180094220
	[XmlElementAttribute] // RVA: 0x94220 Offset: 0x93620 VA: 0x180094220
	public XmlSchemaType SchemaType { get; set; }
	[XmlElementAttribute] // RVA: 0x94380 Offset: 0x93780 VA: 0x180094380
	[XmlElementAttribute] // RVA: 0x94380 Offset: 0x93780 VA: 0x180094380
	[XmlElementAttribute] // RVA: 0x94380 Offset: 0x93780 VA: 0x180094380
	public XmlSchemaObjectCollection Constraints { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaType ElementSchemaType { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaDerivationMethod BlockResolved { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaDerivationMethod FinalResolved { get; }
	internal bool HasConstraints { get; }
	internal bool IsLocalTypeDerivationChecked { get; set; }
	internal SchemaElementDecl ElementDecl { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal override string NameAttribute { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal override string NameString { get; }

	// Methods

	// RVA: 0x955A00 Offset: 0x954000 VA: 0x180955A00
	public bool get_IsAbstract() { }

	// RVA: 0x10505C0 Offset: 0x104EBC0 VA: 0x1810505C0
	public void set_IsAbstract(bool value) { }

	// RVA: 0x582940 Offset: 0x580F40 VA: 0x180582940
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x582950 Offset: 0x580F50 VA: 0x180582950
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050
	public string get_DefaultValue() { }

	// RVA: 0x4E4060 Offset: 0x4E2660 VA: 0x1804E4060
	public void set_DefaultValue(string value) { }

	// RVA: 0x1050510 Offset: 0x104EB10 VA: 0x181050510
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x10505B0 Offset: 0x104EBB0 VA: 0x1810505B0
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public string get_FixedValue() { }

	// RVA: 0x574410 Offset: 0x572A10 VA: 0x180574410
	public void set_FixedValue(string value) { }

	// RVA: 0x58AC70 Offset: 0x589270 VA: 0x18058AC70
	public XmlSchemaForm get_Form() { }

	// RVA: 0xF8C000 Offset: 0xF8A600 VA: 0x180F8C000
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public string get_Name() { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	public void set_Name(string value) { }

	// RVA: 0x1050570 Offset: 0x104EB70 VA: 0x181050570
	public bool get_IsNillable() { }

	// RVA: 0x10505D0 Offset: 0x104EBD0 VA: 0x1810505D0
	public void set_IsNillable(bool value) { }

	// RVA: 0x1050560 Offset: 0x104EB60 VA: 0x181050560
	internal bool get_HasNillableAttribute() { }

	// RVA: 0x1050520 Offset: 0x104EB20 VA: 0x181050520
	internal bool get_HasAbstractAttribute() { }

	// RVA: 0x952B90 Offset: 0x951190 VA: 0x180952B90
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x10505E0 Offset: 0x104EBE0 VA: 0x1810505E0
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x9921A0 Offset: 0x9907A0 VA: 0x1809921A0
	public XmlQualifiedName get_SubstitutionGroup() { }

	// RVA: 0x1050760 Offset: 0x104ED60 VA: 0x181050760
	public void set_SubstitutionGroup(XmlQualifiedName value) { }

	// RVA: 0x7ACF70 Offset: 0x7AB570 VA: 0x1807ACF70
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x10506A0 Offset: 0x104ECA0 VA: 0x1810506A0
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x104F1B0 Offset: 0x104D7B0 VA: 0x18104F1B0
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0xEFAF20 Offset: 0xEF9520 VA: 0x180EFAF20
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x1050480 Offset: 0x104EA80 VA: 0x181050480
	public XmlSchemaObjectCollection get_Constraints() { }

	// RVA: 0xDA00E0 Offset: 0xD9E6E0 VA: 0x180DA00E0
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0xC73A80 Offset: 0xC72080 VA: 0x180C73A80
	public XmlSchemaType get_ElementSchemaType() { }

	// RVA: 0x1050470 Offset: 0x104EA70 VA: 0x181050470
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x1050500 Offset: 0x104EB00 VA: 0x181050500
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0xDA04C0 Offset: 0xD9EAC0 VA: 0x180DA04C0
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0xC73BD0 Offset: 0xC721D0 VA: 0x180C73BD0
	internal void SetElementType(XmlSchemaType value) { }

	// RVA: 0x1050340 Offset: 0x104E940 VA: 0x181050340
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1050350 Offset: 0x104E950 VA: 0x181050350
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1050530 Offset: 0x104EB30 VA: 0x181050530
	internal bool get_HasConstraints() { }

	// RVA: 0x9660F0 Offset: 0x9646F0 VA: 0x1809660F0
	internal bool get_IsLocalTypeDerivationChecked() { }

	// RVA: 0x966100 Offset: 0x964700 VA: 0x180966100
	internal void set_IsLocalTypeDerivationChecked(bool value) { }

	// RVA: 0x872140 Offset: 0x870740 VA: 0x180872140
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x8721C0 Offset: 0x8707C0 VA: 0x1808721C0
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1050580 Offset: 0x104EB80 VA: 0x181050580 Slot: 15
	internal override string get_NameString() { }

	// RVA: 0x1050330 Offset: 0x104E930 VA: 0x181050330 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10500E0 Offset: 0x104E6E0 VA: 0x1810500E0
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x1050360 Offset: 0x104E960 VA: 0x181050360
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

	// RVA: 0x10511F0 Offset: 0x104F7F0 VA: 0x1810511F0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10508C0 Offset: 0x104EEC0 VA: 0x1810508C0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10515E0 Offset: 0x104FBE0 VA: 0x1810515E0
	public void .ctor() { }

	// RVA: 0x1050C50 Offset: 0x104F250 VA: 0x181050C50
	public void .ctor(string message) { }

	// RVA: 0x10510E0 Offset: 0x104F6E0 VA: 0x1810510E0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1050DA0 Offset: 0x104F3A0 VA: 0x181050DA0
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x1051540 Offset: 0x104FB40 VA: 0x181051540
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x1050B10 Offset: 0x104F110 VA: 0x181050B10
	internal void .ctor(string res, string arg) { }

	// RVA: 0x1050FD0 Offset: 0x104F5D0 VA: 0x181050FD0
	internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1050AD0 Offset: 0x104F0D0 VA: 0x181050AD0
	internal void .ctor(string res, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0xD27B30 Offset: 0xD26130 VA: 0x180D27B30
	internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1050A80 Offset: 0x104F080 VA: 0x181050A80
	internal void .ctor(string res, XmlSchemaObject source) { }

	// RVA: 0x1050EC0 Offset: 0x104F4C0 VA: 0x181050EC0
	internal void .ctor(string res, string arg, XmlSchemaObject source) { }

	// RVA: 0x1050D50 Offset: 0x104F350 VA: 0x181050D50
	internal void .ctor(string res, string[] args, XmlSchemaObject source) { }

	// RVA: 0x10516A0 Offset: 0x104FCA0 VA: 0x1810516A0
	internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source) { }

	// RVA: 0x1050840 Offset: 0x104EE40 VA: 0x181050840
	internal static string CreateMessage(string res, string[] args) { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	internal string get_GetRes() { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050
	internal string[] get_Args() { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public string get_SourceUri() { }

	// RVA: 0x1051760 Offset: 0x104FD60 VA: 0x181051760
	public int get_LineNumber() { }

	// RVA: 0x1051770 Offset: 0x104FD70 VA: 0x181051770
	public int get_LinePosition() { }

	// RVA: 0x952B90 Offset: 0x951190 VA: 0x180952B90
	public XmlSchemaObject get_SourceSchemaObject() { }

	// RVA: 0x10509D0 Offset: 0x104EFD0 VA: 0x1810509D0
	internal void SetSource(string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0xC73C90 Offset: 0xC72290 VA: 0x180C73C90
	internal void SetSchemaObject(XmlSchemaObject source) { }

	// RVA: 0x1050A20 Offset: 0x104F020 VA: 0x181050A20
	internal void SetSource(XmlSchemaObject source) { }

	// RVA: 0x1051780 Offset: 0x104FD80 VA: 0x181051780 Slot: 5
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
	[XmlAttributeAttribute] // RVA: 0x94910 Offset: 0x93D10 VA: 0x180094910
	public string SchemaLocation { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchema Schema { get; set; }
	[XmlAttributeAttribute] // RVA: 0x8AAD0 Offset: 0x89ED0 VA: 0x18008AAD0
	public string Id { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal Uri BaseUri { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal override string IdAttribute { get; set; }
	internal Compositor Compositor { get; set; }

	// Methods

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_SchemaLocation() { }

	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
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
	[XmlAttributeAttribute] // RVA: 0x94CB0 Offset: 0x940B0 VA: 0x180094CB0
	public string Value { get; set; }
	[DefaultValueAttribute] // RVA: 0x94D70 Offset: 0x94170 VA: 0x180094D70
	[XmlAttributeAttribute] // RVA: 0x94D70 Offset: 0x94170 VA: 0x180094D70
	public virtual bool IsFixed { get; set; }
	internal FacetType FacetType { get; set; }

	// Methods

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public string get_Value() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	public void set_Value(string value) { }

	// RVA: 0x592630 Offset: 0x590C30 VA: 0x180592630 Slot: 14
	public virtual bool get_IsFixed() { }

	// RVA: 0x10517A0 Offset: 0x104FDA0 VA: 0x1810517A0 Slot: 15
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

	// RVA: 0x105C700 Offset: 0x105AD00 VA: 0x18105C700
	public void .ctor() { }

}

public class XmlSchemaMinLengthFacet : XmlSchemaNumericFacet // TypeDefIndex: 2339
{	// Methods

	// RVA: 0x105C7C0 Offset: 0x105ADC0 VA: 0x18105C7C0
	public void .ctor() { }

}

public class XmlSchemaMaxLengthFacet : XmlSchemaNumericFacet // TypeDefIndex: 2340
{	// Methods

	// RVA: 0x105C760 Offset: 0x105AD60 VA: 0x18105C760
	public void .ctor() { }

}

public class XmlSchemaPatternFacet : XmlSchemaFacet // TypeDefIndex: 2341
{	// Methods

	// RVA: 0x105E480 Offset: 0x105CA80 VA: 0x18105E480
	public void .ctor() { }

}

public class XmlSchemaEnumerationFacet : XmlSchemaFacet // TypeDefIndex: 2342
{	// Methods

	// RVA: 0x1050820 Offset: 0x104EE20 VA: 0x181050820
	public void .ctor() { }

}

public class XmlSchemaMinExclusiveFacet : XmlSchemaFacet // TypeDefIndex: 2343
{	// Methods

	// RVA: 0x105C780 Offset: 0x105AD80 VA: 0x18105C780
	public void .ctor() { }

}

public class XmlSchemaMinInclusiveFacet : XmlSchemaFacet // TypeDefIndex: 2344
{	// Methods

	// RVA: 0x105C7A0 Offset: 0x105ADA0 VA: 0x18105C7A0
	public void .ctor() { }

}

public class XmlSchemaMaxExclusiveFacet : XmlSchemaFacet // TypeDefIndex: 2345
{	// Methods

	// RVA: 0x105C720 Offset: 0x105AD20 VA: 0x18105C720
	public void .ctor() { }

}

public class XmlSchemaMaxInclusiveFacet : XmlSchemaFacet // TypeDefIndex: 2346
{	// Methods

	// RVA: 0x105C740 Offset: 0x105AD40 VA: 0x18105C740
	public void .ctor() { }

}

public class XmlSchemaTotalDigitsFacet : XmlSchemaNumericFacet // TypeDefIndex: 2347
{	// Methods

	// RVA: 0xD271A0 Offset: 0xD257A0 VA: 0x180D271A0
	public void .ctor() { }

}

public class XmlSchemaFractionDigitsFacet : XmlSchemaNumericFacet // TypeDefIndex: 2348
{	// Methods

	// RVA: 0x1051860 Offset: 0x104FE60 VA: 0x181051860
	public void .ctor() { }

}

public class XmlSchemaWhiteSpaceFacet : XmlSchemaFacet // TypeDefIndex: 2349
{	// Methods

	// RVA: 0xD35080 Offset: 0xD33680 VA: 0x180D35080
	public void .ctor() { }

}

public enum XmlSchemaForm // TypeDefIndex: 2350
{	// Fields
	public int value__; // 0x0
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public const XmlSchemaForm None = 0;
	[XmlEnumAttribute] // RVA: 0x94E90 Offset: 0x94290 VA: 0x180094E90
	public const XmlSchemaForm Qualified = 1;
	[XmlEnumAttribute] // RVA: 0x95000 Offset: 0x94400 VA: 0x180095000
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
	[XmlAttributeAttribute] // RVA: 0x8D960 Offset: 0x8CD60 VA: 0x18008D960
	public string Name { get; set; }
	[XmlElementAttribute] // RVA: 0x95150 Offset: 0x94550 VA: 0x180095150
	[XmlElementAttribute] // RVA: 0x95150 Offset: 0x94550 VA: 0x180095150
	[XmlElementAttribute] // RVA: 0x95150 Offset: 0x94550 VA: 0x180095150
	public XmlSchemaGroupBase Particle { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal XmlSchemaParticle CanonicalParticle { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal XmlSchemaGroup Redefined { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal int SelfReferenceCount { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0xAF5D60 Offset: 0xAF4360 VA: 0x180AF5D60
	internal int get_SelfReferenceCount() { }

	// RVA: 0xB28CD0 Offset: 0xB272D0 VA: 0x180B28CD0
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1051A30 Offset: 0x1050030 VA: 0x181051A30 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1051A40 Offset: 0x1050040 VA: 0x181051A40
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x1051C00 Offset: 0x1050200 VA: 0x181051C00
	public void .ctor() { }

}

public abstract class XmlSchemaGroupBase : XmlSchemaParticle // TypeDefIndex: 2352
{	// Properties
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public abstract XmlSchemaObjectCollection Items { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 16
	public abstract XmlSchemaObjectCollection get_Items();

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract void SetItems(XmlSchemaObjectCollection newItems);

	// RVA: 0x1051880 Offset: 0x104FE80 VA: 0x181051880
	protected void .ctor() { }

}

public class XmlSchemaGroupRef : XmlSchemaParticle // TypeDefIndex: 2353
{	// Fields
	private XmlQualifiedName refName; // 0x78
	private XmlSchemaGroupBase particle; // 0x80
	private XmlSchemaGroup refined; // 0x88

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8DAD0 Offset: 0x8CED0 VA: 0x18008DAD0
	public XmlQualifiedName RefName { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaGroupBase Particle { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal XmlSchemaGroup Redefined { get; set; }

	// Methods

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x1051970 Offset: 0x104FF70 VA: 0x181051970
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x574470 Offset: 0x572A70 VA: 0x180574470
	internal void SetParticle(XmlSchemaGroupBase value) { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x10518E0 Offset: 0x104FEE0 VA: 0x1810518E0
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
	[XmlAttributeAttribute] // RVA: 0x8D960 Offset: 0x8CD60 VA: 0x18008D960
	public string Name { get; set; }
	[XmlElementAttribute] // RVA: 0x959C0 Offset: 0x94DC0 VA: 0x1800959C0
	public XmlSchemaXPath Selector { get; set; }
	[XmlElementAttribute] // RVA: 0x95AA0 Offset: 0x94EA0 VA: 0x180095AA0
	public XmlSchemaObjectCollection Fields { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal CompiledIdentityConstraint CompiledConstraint { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x1051C80 Offset: 0x1050280 VA: 0x181051C80
	public void .ctor() { }

}

public class XmlSchemaXPath : XmlSchemaAnnotated // TypeDefIndex: 2355
{	// Fields
	private string xpath; // 0x50

	// Properties
	[XmlAttributeAttribute] // RVA: 0x95FB0 Offset: 0x953B0 VA: 0x180095FB0
	[DefaultValueAttribute] // RVA: 0x95FB0 Offset: 0x953B0 VA: 0x180095FB0
	public string XPath { get; set; }

	// Methods

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public string get_XPath() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	public void set_XPath(string value) { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

}

public class XmlSchemaUnique : XmlSchemaIdentityConstraint // TypeDefIndex: 2356
{	// Methods

	// RVA: 0xD27980 Offset: 0xD25F80 VA: 0x180D27980
	public void .ctor() { }

}

public class XmlSchemaKey : XmlSchemaIdentityConstraint // TypeDefIndex: 2357
{	// Methods

	// RVA: 0xD27980 Offset: 0xD25F80 VA: 0x180D27980
	public void .ctor() { }

}

public class XmlSchemaKeyref : XmlSchemaIdentityConstraint // TypeDefIndex: 2358
{	// Fields
	private XmlQualifiedName refer; // 0x78

	// Properties
	[XmlAttributeAttribute] // RVA: 0x96120 Offset: 0x95520 VA: 0x180096120
	public XmlQualifiedName Refer { get; set; }

	// Methods

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	public XmlQualifiedName get_Refer() { }

	// RVA: 0x105C640 Offset: 0x105AC40 VA: 0x18105C640
	public void set_Refer(XmlQualifiedName value) { }

	// RVA: 0x105C5C0 Offset: 0x105ABC0 VA: 0x18105C5C0
	public void .ctor() { }

}

public class XmlSchemaImport : XmlSchemaExternal // TypeDefIndex: 2359
{	// Fields
	private string ns; // 0x68
	private XmlSchemaAnnotation annotation; // 0x70

	// Properties
	[XmlAttributeAttribute] // RVA: 0x962C0 Offset: 0x956C0 VA: 0x1800962C0
	public string Namespace { get; set; }

	// Methods

	// RVA: 0x1051D30 Offset: 0x1050330 VA: 0x181051D30
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

	// RVA: 0x1051D50 Offset: 0x1050350 VA: 0x181051D50
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

	// RVA: 0x105C3F0 Offset: 0x105A9F0 VA: 0x18105C3F0
	public void .ctor() { }

	// RVA: 0x105C370 Offset: 0x105A970 VA: 0x18105C370
	internal void .ctor(XmlSchemaValidity validity) { }

	// RVA: 0x6BB940 Offset: 0x6B9F40 VA: 0x1806BB940 Slot: 4
	public XmlSchemaValidity get_Validity() { }

	// RVA: 0xC74910 Offset: 0xC72F10 VA: 0x180C74910
	public void set_Validity(XmlSchemaValidity value) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90 Slot: 5
	public bool get_IsDefault() { }

	// RVA: 0x49AFC0 Offset: 0x4995C0 VA: 0x18049AFC0
	public void set_IsDefault(bool value) { }

	// RVA: 0xF8B3B0 Offset: 0xF899B0 VA: 0x180F8B3B0 Slot: 6
	public bool get_IsNil() { }

	// RVA: 0xF8B3C0 Offset: 0xF899C0 VA: 0x180F8B3C0
	public void set_IsNil(bool value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 7
	public XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	public void set_MemberType(XmlSchemaSimpleType value) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 8
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0x105C570 Offset: 0x105AB70 VA: 0x18105C570
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	public XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x105C530 Offset: 0x105AB30 VA: 0x18105C530
	public void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 10
	public XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x105C4F0 Offset: 0x105AAF0 VA: 0x18105C4F0
	public void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x105C4E0 Offset: 0x105AAE0 VA: 0x18105C4E0
	internal XmlSchemaType get_XmlType() { }

	// RVA: 0x105C460 Offset: 0x105AA60 VA: 0x18105C460
	internal bool get_HasDefaultValue() { }

	// RVA: 0x105C4A0 Offset: 0x105AAA0 VA: 0x18105C4A0
	internal bool get_IsUnionType() { }

	// RVA: 0x105C300 Offset: 0x105A900 VA: 0x18105C300
	internal void Clear() { }

}

public class XmlSchemaNotation : XmlSchemaAnnotated // TypeDefIndex: 2362
{	// Fields
	private string name; // 0x50
	private string publicId; // 0x58
	private string systemId; // 0x60
	private XmlQualifiedName qname; // 0x68

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8D960 Offset: 0x8CD60 VA: 0x18008D960
	public string Name { get; set; }
	[XmlAttributeAttribute] // RVA: 0x96310 Offset: 0x95710 VA: 0x180096310
	public string Public { get; set; }
	[XmlAttributeAttribute] // RVA: 0x96400 Offset: 0x95800 VA: 0x180096400
	public string System { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal XmlQualifiedName QualifiedName { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x105C7E0 Offset: 0x105ADE0 VA: 0x18105C7E0
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
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public int LineNumber { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public int LinePosition { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public string SourceUri { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaObject Parent { get; set; }
	[XmlNamespaceDeclarationsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSerializerNamespaces Namespaces { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal virtual string IdAttribute { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal virtual string NameAttribute { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public XmlSchemaObject get_Parent() { }

	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
	public void set_Parent(XmlSchemaObject value) { }

	// RVA: 0x105D870 Offset: 0x105BE70 VA: 0x18105D870
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

	// RVA: 0x82BC90 Offset: 0x82A290 VA: 0x18082BC90
	internal bool get_IsProcessing() { }

	// RVA: 0x82BCC0 Offset: 0x82A2C0 VA: 0x18082BCC0
	internal void set_IsProcessing(bool value) { }

	// RVA: 0x105D7F0 Offset: 0x105BDF0 VA: 0x18105D7F0 Slot: 13
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

	// RVA: 0x105CC80 Offset: 0x105B280 VA: 0x18105CC80
	public void .ctor() { }

	// RVA: 0x105CC90 Offset: 0x105B290 VA: 0x18105CC90 Slot: 28
	public virtual XmlSchemaObject get_Item(int index) { }

	// RVA: 0x105CDB0 Offset: 0x105B3B0 VA: 0x18105CDB0 Slot: 29
	public virtual void set_Item(int index, XmlSchemaObject value) { }

	// RVA: 0x105C9F0 Offset: 0x105AFF0 VA: 0x18105C9F0
	public XmlSchemaObjectEnumerator GetEnumerator() { }

	// RVA: 0x105C8A0 Offset: 0x105AEA0 VA: 0x18105C8A0
	public int Add(XmlSchemaObject item) { }

	// RVA: 0x105CA80 Offset: 0x105B080 VA: 0x18105CA80
	public void Insert(int index, XmlSchemaObject item) { }

	// RVA: 0x105CBC0 Offset: 0x105B1C0 VA: 0x18105CBC0
	public void Remove(XmlSchemaObject item) { }

	// RVA: 0x105CB20 Offset: 0x105B120 VA: 0x18105CB20 Slot: 20
	protected override void OnInsert(int index, object item) { }

	// RVA: 0x105CB60 Offset: 0x105B160 VA: 0x18105CB60 Slot: 19
	protected override void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x105CB00 Offset: 0x105B100 VA: 0x18105CB00 Slot: 21
	protected override void OnClear() { }

	// RVA: 0x105CB40 Offset: 0x105B140 VA: 0x18105CB40 Slot: 22
	protected override void OnRemove(int index, object item) { }

	// RVA: 0x105C960 Offset: 0x105AF60 VA: 0x18105C960
	internal XmlSchemaObjectCollection Clone() { }

	// RVA: 0x105C860 Offset: 0x105AE60 VA: 0x18105C860
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

	// RVA: 0x105CE30 Offset: 0x105B430 VA: 0x18105CE30
	public bool MoveNext() { }

	// RVA: 0x105CF70 Offset: 0x105B570 VA: 0x18105CF70
	public XmlSchemaObject get_Current() { }

	// RVA: 0x105CED0 Offset: 0x105B4D0 VA: 0x18105CED0 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x105CE80 Offset: 0x105B480 VA: 0x18105CE80 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x105CF20 Offset: 0x105B520 VA: 0x18105CF20 Slot: 5
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

	// RVA: 0x105D5F0 Offset: 0x105BBF0 VA: 0x18105D5F0
	internal void .ctor() { }

	// RVA: 0x105D010 Offset: 0x105B610 VA: 0x18105D010
	internal void Add(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x105D2F0 Offset: 0x105B8F0 VA: 0x18105D2F0
	internal void Insert(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x105D4D0 Offset: 0x105BAD0 VA: 0x18105D4D0
	internal void Replace(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x105D0D0 Offset: 0x105B6D0 VA: 0x18105D0D0
	internal void Clear() { }

	// RVA: 0x105D420 Offset: 0x105BA20 VA: 0x18105D420
	internal void Remove(XmlQualifiedName name) { }

	// RVA: 0x105D190 Offset: 0x105B790 VA: 0x18105D190
	private int FindIndexByValue(XmlSchemaObject xso) { }

	// RVA: 0x105D690 Offset: 0x105BC90 VA: 0x18105D690
	public int get_Count() { }

	// RVA: 0x105D130 Offset: 0x105B730 VA: 0x18105D130
	public bool Contains(XmlQualifiedName name) { }

	// RVA: 0x105D6E0 Offset: 0x105BCE0 VA: 0x18105D6E0
	public XmlSchemaObject get_Item(XmlQualifiedName name) { }

	// RVA: 0x105D760 Offset: 0x105BD60 VA: 0x18105D760
	public ICollection get_Values() { }

	// RVA: 0x105D250 Offset: 0x105B850 VA: 0x18105D250
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

	// RVA: 0xF5AD0 Offset: 0xF4ED0 VA: 0x1800F5AD0
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

	// RVA: 0xAE44B0 Offset: 0xAE2AB0 VA: 0x180AE44B0
	internal void .ctor(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size) { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470 Slot: 5
	public int get_Count() { }

	// RVA: 0x104A3E0 Offset: 0x10489E0 VA: 0x18104A3E0 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x104A230 Offset: 0x1048830 VA: 0x18104A230 Slot: 4
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x104A360 Offset: 0x1048960 VA: 0x18104A360 Slot: 7
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

	// RVA: 0x104A430 Offset: 0x1048A30 VA: 0x18104A430
	internal void .ctor(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, XmlSchemaObjectTable.EnumeratorType enumType) { }

	// RVA: 0x104AA30 Offset: 0x1049030 VA: 0x18104AA30 Slot: 5
	public object get_Current() { }

	// RVA: 0x104A8F0 Offset: 0x1048EF0 VA: 0x18104A8F0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x104A9F0 Offset: 0x1048FF0 VA: 0x18104A9F0 Slot: 6
	public void Reset() { }

}

internal class XmlSchemaObjectTable.XSODictionaryEnumerator : XmlSchemaObjectTable.XSOEnumerator, IDictionaryEnumerator, IEnumerator // TypeDefIndex: 2371
{	// Properties
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x104A430 Offset: 0x1048A30 VA: 0x18104A430
	internal void .ctor(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, XmlSchemaObjectTable.EnumeratorType enumType) { }

	// RVA: 0x104A490 Offset: 0x1048A90 VA: 0x18104A490 Slot: 9
	public DictionaryEntry get_Entry() { }

	// RVA: 0x104A610 Offset: 0x1048C10 VA: 0x18104A610 Slot: 7
	public object get_Key() { }

	// RVA: 0x104A780 Offset: 0x1048D80 VA: 0x18104A780 Slot: 8
	public object get_Value() { }

}

public abstract class XmlSchemaParticle : XmlSchemaAnnotated // TypeDefIndex: 2372
{	// Fields
	private Decimal minOccurs; // 0x50
	private Decimal maxOccurs; // 0x60
	private XmlSchemaParticle.Occurs flags; // 0x70
	internal static readonly XmlSchemaParticle Empty; // 0x0

	// Properties
	[XmlAttributeAttribute] // RVA: 0x96E20 Offset: 0x96220 VA: 0x180096E20
	public string MinOccursString { get; set; }
	[XmlAttributeAttribute] // RVA: 0x96F80 Offset: 0x96380 VA: 0x180096F80
	public string MaxOccursString { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public Decimal MinOccurs { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public Decimal MaxOccurs { get; set; }
	internal virtual bool IsEmpty { get; }
	internal virtual string NameString { get; }

	// Methods

	// RVA: 0x105DD20 Offset: 0x105C320 VA: 0x18105DD20
	public string get_MinOccursString() { }

	// RVA: 0x105E1D0 Offset: 0x105C7D0 VA: 0x18105E1D0
	public void set_MinOccursString(string value) { }

	// RVA: 0x105DC10 Offset: 0x105C210 VA: 0x18105DC10
	public string get_MaxOccursString() { }

	// RVA: 0x105DDF0 Offset: 0x105C3F0 VA: 0x18105DDF0
	public void set_MaxOccursString(string value) { }

	// RVA: 0x105DDA0 Offset: 0x105C3A0 VA: 0x18105DDA0
	public Decimal get_MinOccurs() { }

	// RVA: 0x105E340 Offset: 0x105C940 VA: 0x18105E340
	public void set_MinOccurs(Decimal value) { }

	// RVA: 0xC31E40 Offset: 0xC30440 VA: 0x180C31E40
	public Decimal get_MaxOccurs() { }

	// RVA: 0x105E020 Offset: 0x105C620 VA: 0x18105E020
	public void set_MaxOccurs(Decimal value) { }

	// RVA: 0x105DB80 Offset: 0x105C180 VA: 0x18105DB80 Slot: 14
	internal virtual bool get_IsEmpty() { }

	// RVA: 0x105DDB0 Offset: 0x105C3B0 VA: 0x18105DDB0 Slot: 15
	internal virtual string get_NameString() { }

	// RVA: 0x105D8E0 Offset: 0x105BEE0 VA: 0x18105D8E0
	internal XmlQualifiedName GetQualifiedName() { }

	// RVA: 0x105DB00 Offset: 0x105C100 VA: 0x18105DB00
	protected void .ctor() { }

	// RVA: 0x105DA60 Offset: 0x105C060 VA: 0x18105DA60
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

	// RVA: 0x104A1D0 Offset: 0x10487D0 VA: 0x18104A1D0
	public void .ctor() { }

}

public class XmlSchemaRedefine : XmlSchemaExternal // TypeDefIndex: 2375
{	// Fields
	private XmlSchemaObjectCollection items; // 0x68
	private XmlSchemaObjectTable attributeGroups; // 0x70
	private XmlSchemaObjectTable types; // 0x78
	private XmlSchemaObjectTable groups; // 0x80

	// Properties
	[XmlElementAttribute] // RVA: 0x97460 Offset: 0x96860 VA: 0x180097460
	[XmlElementAttribute] // RVA: 0x97460 Offset: 0x96860 VA: 0x180097460
	[XmlElementAttribute] // RVA: 0x97460 Offset: 0x96860 VA: 0x180097460
	[XmlElementAttribute] // RVA: 0x97460 Offset: 0x96860 VA: 0x180097460
	[XmlElementAttribute] // RVA: 0x97460 Offset: 0x96860 VA: 0x180097460
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaObjectTable AttributeGroups { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaObjectTable SchemaTypes { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaObjectTable Groups { get; }

	// Methods

	// RVA: 0x105E4C0 Offset: 0x105CAC0 VA: 0x18105E4C0
	public void .ctor() { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x105E4A0 Offset: 0x105CAA0 VA: 0x18105E4A0 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

}

public class XmlSchemaSequence : XmlSchemaGroupBase // TypeDefIndex: 2376
{	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Properties
	[XmlElementAttribute] // RVA: 0x97A80 Offset: 0x96E80 VA: 0x180097A80
	[XmlElementAttribute] // RVA: 0x97A80 Offset: 0x96E80 VA: 0x180097A80
	[XmlElementAttribute] // RVA: 0x97A80 Offset: 0x96E80 VA: 0x180097A80
	[XmlElementAttribute] // RVA: 0x97A80 Offset: 0x96E80 VA: 0x180097A80
	[XmlElementAttribute] // RVA: 0x97A80 Offset: 0x96E80 VA: 0x180097A80
	public override XmlSchemaObjectCollection Items { get; }
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x104ACB0 Offset: 0x10492B0 VA: 0x18104ACB0 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x4E8840 Offset: 0x4E6E40 VA: 0x1804E8840 Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x105E5B0 Offset: 0x105CBB0 VA: 0x18105E5B0
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

	// RVA: 0x10673B0 Offset: 0x10659B0 VA: 0x1810673B0
	internal object get_InternalSyncObject() { }

	// RVA: 0x1066E20 Offset: 0x1065420 VA: 0x181066E20
	public void .ctor() { }

	// RVA: 0x1066E80 Offset: 0x1065480 VA: 0x181066E80
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x1067110 Offset: 0x1065710 VA: 0x181067110
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x1067530 Offset: 0x1065B30 VA: 0x181067530
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x8C1040 Offset: 0x8BF640 VA: 0x1808C1040
	public bool get_IsCompiled() { }

	// RVA: 0x10675D0 Offset: 0x1065BD0 VA: 0x1810675D0
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	public XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x4E8840 Offset: 0x4E6E40 VA: 0x1804E8840
	public void set_CompilationSettings(XmlSchemaCompilationSettings value) { }

	// RVA: 0x1067200 Offset: 0x1065800 VA: 0x181067200
	public int get_Count() { }

	// RVA: 0x10672B0 Offset: 0x10658B0 VA: 0x1810672B0
	public XmlSchemaObjectTable get_GlobalElements() { }

	// RVA: 0x1067230 Offset: 0x1065830 VA: 0x181067230
	public XmlSchemaObjectTable get_GlobalAttributes() { }

	// RVA: 0x1067330 Offset: 0x1065930 VA: 0x181067330
	public XmlSchemaObjectTable get_GlobalTypes() { }

	// RVA: 0x1067430 Offset: 0x1065A30 VA: 0x181067430
	internal XmlSchemaObjectTable get_SubstitutionGroups() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal Hashtable get_SchemaLocations() { }

	// RVA: 0x10674B0 Offset: 0x1065AB0 VA: 0x1810674B0
	internal XmlSchemaObjectTable get_TypeExtensions() { }

	// RVA: 0x105EDF0 Offset: 0x105D3F0 VA: 0x18105EDF0
	public void Add(XmlSchemaSet schemas) { }

	// RVA: 0x105F980 Offset: 0x105DF80 VA: 0x18105F980
	public XmlSchema Add(XmlSchema schema) { }

	// RVA: 0x1064580 Offset: 0x1062B80 VA: 0x181064580
	public bool RemoveRecursive(XmlSchema schemaToRemove) { }

	// RVA: 0x1060700 Offset: 0x105ED00 VA: 0x181060700
	public bool Contains(string targetNamespace) { }

	// RVA: 0x10601C0 Offset: 0x105E7C0 VA: 0x1810601C0
	public void Compile() { }

	// RVA: 0x1065F80 Offset: 0x1064580 VA: 0x181065F80
	public XmlSchema Reprocess(XmlSchema schema) { }

	// RVA: 0x10625B0 Offset: 0x1060BB0 VA: 0x1810625B0
	public void CopyTo(XmlSchema[] schemas, int index) { }

	// RVA: 0x1066C10 Offset: 0x1065210 VA: 0x181066C10
	public ICollection Schemas() { }

	// RVA: 0x1066A60 Offset: 0x1065060 VA: 0x181066A60
	public ICollection Schemas(string targetNamespace) { }

	// RVA: 0x105F920 Offset: 0x105DF20 VA: 0x18105F920
	private XmlSchema Add(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x105FB40 Offset: 0x105E140 VA: 0x18105FB40
	internal void Add(string targetNamespace, XmlReader reader, Hashtable validatedNamespaces) { }

	// RVA: 0x1062720 Offset: 0x1060D20 VA: 0x181062720
	internal XmlSchema FindSchemaByNSAndUrl(Uri schemaUri, string ns, DictionaryEntry[] locationsTable) { }

	// RVA: 0x105E650 Offset: 0x105CC50 VA: 0x18105E650
	private void AddSchemaToSet(XmlSchema schema) { }

	// RVA: 0x1063B20 Offset: 0x1062120 VA: 0x181063B20
	private void ProcessNewSubstitutionGroups(XmlSchemaObjectTable substitutionGroupsTable, bool resolve) { }

	// RVA: 0x10666B0 Offset: 0x1064CB0 VA: 0x1810666B0
	private void ResolveSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup, XmlSchemaObjectTable substTable) { }

	// RVA: 0x1065C70 Offset: 0x1064270 VA: 0x181065C70
	internal XmlSchema Remove(XmlSchema schema, bool forceCompile) { }

	// RVA: 0x105FF70 Offset: 0x105E570 VA: 0x18105FF70
	private void ClearTables() { }

	// RVA: 0x10639D0 Offset: 0x1061FD0 VA: 0x1810639D0
	internal bool PreprocessSchema(ref XmlSchema schema, string targetNamespace) { }

	// RVA: 0x10638B0 Offset: 0x1061EB0 VA: 0x1810638B0
	internal XmlSchema ParseSchema(string targetNamespace, XmlReader reader) { }

	// RVA: 0x1060780 Offset: 0x105ED80 VA: 0x181060780
	internal void CopyFromCompiledSet(XmlSchemaSet otherSet) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	internal SchemaInfo get_CompiledInfo() { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	internal XmlReaderSettings get_ReaderSettings() { }

	// RVA: 0x1062A20 Offset: 0x1061020 VA: 0x181062A20
	internal XmlResolver GetResolver() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0x1062BD0 Offset: 0x10611D0 VA: 0x181062BD0
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x1062D30 Offset: 0x1061330 VA: 0x181062D30
	internal bool IsSchemaLoaded(Uri schemaUri, string targetNamespace, out XmlSchema schema) { }

	// RVA: 0x1062A40 Offset: 0x1061040 VA: 0x181062A40
	internal bool GetSchemaByUri(Uri schemaUri, out XmlSchema schema) { }

	// RVA: 0x1062C80 Offset: 0x1061280 VA: 0x181062C80
	internal string GetTargetNamespace(XmlSchema schema) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal SortedList get_SortedSchemas() { }

	// RVA: 0x1064DC0 Offset: 0x10633C0 VA: 0x181064DC0
	private void RemoveSchemaFromCaches(XmlSchema schema) { }

	// RVA: 0x1065220 Offset: 0x1063820 VA: 0x181065220
	private void RemoveSchemaFromGlobalTables(XmlSchema schema) { }

	// RVA: 0x105EA60 Offset: 0x105D060 VA: 0x18105EA60
	private bool AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x1066CF0 Offset: 0x10652F0 VA: 0x181066CF0
	private void VerifyTables() { }

	// RVA: 0x1062CD0 Offset: 0x10612D0 VA: 0x181062CD0
	private void InternalValidationCallback(object sender, ValidationEventArgs e) { }

	// RVA: 0x1066C40 Offset: 0x1065240 VA: 0x181066C40
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

}

public class XmlSchemaSimpleContent : XmlSchemaContentModel // TypeDefIndex: 2378
{	// Fields
	private XmlSchemaContent content; // 0x50

	// Properties
	[XmlElementAttribute] // RVA: 0x97F10 Offset: 0x97310 VA: 0x180097F10
	[XmlElementAttribute] // RVA: 0x97F10 Offset: 0x97310 VA: 0x180097F10
	public override XmlSchemaContent Content { get; set; }

	// Methods

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 14
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890 Slot: 15
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

}

public class XmlSchemaSimpleContentExtension : XmlSchemaContent // TypeDefIndex: 2379
{	// Fields
	private XmlSchemaObjectCollection attributes; // 0x50
	private XmlSchemaAnyAttribute anyAttribute; // 0x58
	private XmlQualifiedName baseTypeName; // 0x60

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8F450 Offset: 0x8E850 VA: 0x18008F450
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x98240 Offset: 0x97640 VA: 0x180098240
	[XmlElementAttribute] // RVA: 0x98240 Offset: 0x97640 VA: 0x180098240
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] // RVA: 0x8E600 Offset: 0x8DA00 VA: 0x18008E600
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0xD26560 Offset: 0xD24B60 VA: 0x180D26560
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0xD264B0 Offset: 0xD24AB0 VA: 0x180D264B0
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
	[XmlAttributeAttribute] // RVA: 0x8F450 Offset: 0x8E850 VA: 0x18008F450
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x98540 Offset: 0x97940 VA: 0x180098540
	public XmlSchemaSimpleType BaseType { get; set; }
	[XmlElementAttribute] // RVA: 0x98660 Offset: 0x97A60 VA: 0x180098660
	[XmlElementAttribute] // RVA: 0x98660 Offset: 0x97A60 VA: 0x180098660
	[XmlElementAttribute] // RVA: 0x98660 Offset: 0x97A60 VA: 0x180098660
	[XmlElementAttribute] // RVA: 0x98660 Offset: 0x97A60 VA: 0x180098660
	[XmlElementAttribute] // RVA: 0x98660 Offset: 0x97A60 VA: 0x180098660
	[XmlElementAttribute] // RVA: 0x98660 Offset: 0x97A60 VA: 0x180098660
	[XmlElementAttribute] // RVA: 0x98660 Offset: 0x97A60 VA: 0x180098660
	[XmlElementAttribute] // RVA: 0x98660 Offset: 0x97A60 VA: 0x180098660
	[XmlElementAttribute] // RVA: 0x98660 Offset: 0x97A60 VA: 0x180098660
	[XmlElementAttribute] // RVA: 0x98660 Offset: 0x97A60 VA: 0x180098660
	[XmlElementAttribute] // RVA: 0x98660 Offset: 0x97A60 VA: 0x180098660
	[XmlElementAttribute] // RVA: 0x98660 Offset: 0x97A60 VA: 0x180098660
	public XmlSchemaObjectCollection Facets { get; }
	[XmlElementAttribute] // RVA: 0x99090 Offset: 0x98490 VA: 0x180099090
	[XmlElementAttribute] // RVA: 0x99090 Offset: 0x98490 VA: 0x180099090
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] // RVA: 0x8E600 Offset: 0x8DA00 VA: 0x18008E600
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0xD266F0 Offset: 0xD24CF0 VA: 0x180D266F0
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

	// RVA: 0xD26620 Offset: 0xD24C20 VA: 0x180D26620
	public void .ctor() { }

}

public class XmlSchemaSimpleType : XmlSchemaType // TypeDefIndex: 2381
{	// Fields
	private XmlSchemaSimpleTypeContent content; // 0x98

	// Properties
	[XmlElementAttribute] // RVA: 0x99600 Offset: 0x98A00 VA: 0x180099600
	[XmlElementAttribute] // RVA: 0x99600 Offset: 0x98A00 VA: 0x180099600
	[XmlElementAttribute] // RVA: 0x99600 Offset: 0x98A00 VA: 0x180099600
	public XmlSchemaSimpleTypeContent Content { get; set; }

	// Methods

	// RVA: 0xD26F70 Offset: 0xD25570 VA: 0x180D26F70
	public void .ctor() { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public XmlSchemaSimpleTypeContent get_Content() { }

	// RVA: 0x574410 Offset: 0x572A10 VA: 0x180574410
	public void set_Content(XmlSchemaSimpleTypeContent value) { }

	// RVA: 0xD26E40 Offset: 0xD25440 VA: 0x180D26E40 Slot: 13
	internal override XmlSchemaObject Clone() { }

}

public abstract class XmlSchemaSimpleTypeContent : XmlSchemaAnnotated // TypeDefIndex: 2382
{	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	protected void .ctor() { }

}

public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent // TypeDefIndex: 2383
{	// Fields
	private XmlQualifiedName itemTypeName; // 0x50
	private XmlSchemaSimpleType itemType; // 0x58
	private XmlSchemaSimpleType baseItemType; // 0x60

	// Properties
	[XmlAttributeAttribute] // RVA: 0x99B70 Offset: 0x98F70 VA: 0x180099B70
	public XmlQualifiedName ItemTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x99D60 Offset: 0x99160 VA: 0x180099D60
	public XmlSchemaSimpleType ItemType { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaSimpleType BaseItemType { get; set; }

	// Methods

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public XmlQualifiedName get_ItemTypeName() { }

	// RVA: 0xD268F0 Offset: 0xD24EF0 VA: 0x180D268F0
	public void set_ItemTypeName(XmlQualifiedName value) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public XmlSchemaSimpleType get_ItemType() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	public void set_ItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public XmlSchemaSimpleType get_BaseItemType() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	public void set_BaseItemType(XmlSchemaSimpleType value) { }

	// RVA: 0xD267B0 Offset: 0xD24DB0 VA: 0x180D267B0 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0xD26870 Offset: 0xD24E70 VA: 0x180D26870
	public void .ctor() { }

}

public class XmlSchemaSimpleTypeRestriction : XmlSchemaSimpleTypeContent // TypeDefIndex: 2384
{	// Fields
	private XmlQualifiedName baseTypeName; // 0x50
	private XmlSchemaSimpleType baseType; // 0x58
	private XmlSchemaObjectCollection facets; // 0x60

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8F450 Offset: 0x8E850 VA: 0x18008F450
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x9A150 Offset: 0x99550 VA: 0x18009A150
	public XmlSchemaSimpleType BaseType { get; set; }
	[XmlElementAttribute] // RVA: 0x9A340 Offset: 0x99740 VA: 0x18009A340
	[XmlElementAttribute] // RVA: 0x9A340 Offset: 0x99740 VA: 0x18009A340
	[XmlElementAttribute] // RVA: 0x9A340 Offset: 0x99740 VA: 0x18009A340
	[XmlElementAttribute] // RVA: 0x9A340 Offset: 0x99740 VA: 0x18009A340
	[XmlElementAttribute] // RVA: 0x9A340 Offset: 0x99740 VA: 0x18009A340
	[XmlElementAttribute] // RVA: 0x9A340 Offset: 0x99740 VA: 0x18009A340
	[XmlElementAttribute] // RVA: 0x9A340 Offset: 0x99740 VA: 0x18009A340
	[XmlElementAttribute] // RVA: 0x9A340 Offset: 0x99740 VA: 0x18009A340
	[XmlElementAttribute] // RVA: 0x9A340 Offset: 0x99740 VA: 0x18009A340
	[XmlElementAttribute] // RVA: 0x9A340 Offset: 0x99740 VA: 0x18009A340
	[XmlElementAttribute] // RVA: 0x9A340 Offset: 0x99740 VA: 0x18009A340
	[XmlElementAttribute] // RVA: 0x9A340 Offset: 0x99740 VA: 0x18009A340
	public XmlSchemaObjectCollection Facets { get; }

	// Methods

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0xD26B20 Offset: 0xD25120 VA: 0x180D26B20
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	public void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0xD269B0 Offset: 0xD24FB0 VA: 0x180D269B0 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0xD26A70 Offset: 0xD25070 VA: 0x180D26A70
	public void .ctor() { }

}

public class XmlSchemaSimpleTypeUnion : XmlSchemaSimpleTypeContent // TypeDefIndex: 2385
{	// Fields
	private XmlSchemaObjectCollection baseTypes; // 0x50
	private XmlQualifiedName[] memberTypes; // 0x58
	private XmlSchemaSimpleType[] baseMemberTypes; // 0x60

	// Properties
	[XmlElementAttribute] // RVA: 0x9AA20 Offset: 0x99E20 VA: 0x18009AA20
	public XmlSchemaObjectCollection BaseTypes { get; }
	[XmlAttributeAttribute] // RVA: 0x9ACB0 Offset: 0x9A0B0 VA: 0x18009ACB0
	public XmlQualifiedName[] MemberTypes { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0xD26BE0 Offset: 0xD251E0 VA: 0x180D26BE0 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0xD26DD0 Offset: 0xD253D0 VA: 0x180D26DD0
	public void .ctor() { }

}

internal class XmlSchemaSubstitutionGroup : XmlSchemaObject // TypeDefIndex: 2386
{	// Fields
	private ArrayList membersList; // 0x38
	private XmlQualifiedName examplar; // 0x40

	// Properties
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal ArrayList Members { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal XmlQualifiedName Examplar { get; set; }

	// Methods

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	internal ArrayList get_Members() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal XmlQualifiedName get_Examplar() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	internal void set_Examplar(XmlQualifiedName value) { }

	// RVA: 0xD270F0 Offset: 0xD256F0 VA: 0x180D270F0
	public void .ctor() { }

}

internal class XmlSchemaSubstitutionGroupV1Compat : XmlSchemaSubstitutionGroup // TypeDefIndex: 2387
{	// Fields
	private XmlSchemaChoice choice; // 0x48

	// Properties
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal XmlSchemaChoice Choice { get; }

	// Methods

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	internal XmlSchemaChoice get_Choice() { }

	// RVA: 0xD27000 Offset: 0xD25600 VA: 0x180D27000
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
	[XmlAttributeAttribute] // RVA: 0x8D960 Offset: 0x8CD60 VA: 0x18008D960
	public string Name { get; set; }
	[XmlAttributeAttribute] // RVA: 0x9B0F0 Offset: 0x9A4F0 VA: 0x18009B0F0
	[DefaultValueAttribute] // RVA: 0x9B0F0 Offset: 0x9A4F0 VA: 0x18009B0F0
	public XmlSchemaDerivationMethod Final { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaDerivationMethod FinalResolved { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaType BaseXmlSchemaType { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaDerivationMethod DerivedBy { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlSchemaDatatype Datatype { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public virtual bool IsMixed { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public XmlTypeCode TypeCode { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal XmlValueConverter ValueConverter { get; }
	internal XmlSchemaContentType SchemaContentType { get; }
	internal SchemaElementDecl ElementDecl { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal XmlSchemaType Redefined { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0xD27410 Offset: 0xD25A10 VA: 0x180D27410
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlQualifiedName qualifiedName) { }

	// RVA: 0xD273C0 Offset: 0xD259C0 VA: 0x180D273C0
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode) { }

	// RVA: 0xD271C0 Offset: 0xD257C0 VA: 0x180D271C0
	public static XmlSchemaComplexType GetBuiltInComplexType(XmlQualifiedName qualifiedName) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public string get_Name() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	public void set_Name(string value) { }

	// RVA: 0xAE97E0 Offset: 0xAE7DE0 VA: 0x180AE97E0
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0xD27970 Offset: 0xD25F70 VA: 0x180D27970
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0xD277C0 Offset: 0xD25DC0 VA: 0x180D277C0
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x803A70 Offset: 0x802070 VA: 0x180803A70
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

	// RVA: 0xD277F0 Offset: 0xD25DF0 VA: 0x180D277F0
	public XmlTypeCode get_TypeCode() { }

	// RVA: 0xD278C0 Offset: 0xD25EC0 VA: 0x180D278C0
	internal XmlValueConverter get_ValueConverter() { }

	// RVA: 0xD277E0 Offset: 0xD25DE0 VA: 0x180D277E0
	internal XmlSchemaContentType get_SchemaContentType() { }

	// RVA: 0xD27760 Offset: 0xD25D60 VA: 0x180D27760
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x803AA0 Offset: 0x8020A0 VA: 0x180803AA0
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	internal void SetBaseSchemaType(XmlSchemaType value) { }

	// RVA: 0x574430 Offset: 0x572A30 VA: 0x180574430
	internal void SetDerivedBy(XmlSchemaDerivationMethod value) { }

	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50
	internal void SetDatatype(XmlSchemaDatatype value) { }

	// RVA: 0xD277A0 Offset: 0xD25DA0 VA: 0x180D277A0
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0xD27940 Offset: 0xD25F40 VA: 0x180D27940
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	internal XmlSchemaType get_Redefined() { }

	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	internal void set_Redefined(XmlSchemaType value) { }

	// RVA: 0xD27750 Offset: 0xD25D50 VA: 0x180D27750
	internal void SetContentType(XmlSchemaContentType value) { }

	// RVA: 0xD275C0 Offset: 0xD25BC0 VA: 0x180D275C0
	public static bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except) { }

	// RVA: 0xD274D0 Offset: 0xD25AD0 VA: 0x180D274D0
	internal static bool IsDerivedFromDatatype(XmlSchemaDatatype derivedDataType, XmlSchemaDatatype baseDataType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0xD26F70 Offset: 0xD25570 VA: 0x180D26F70
	public void .ctor() { }

}

public enum XmlSchemaUse // TypeDefIndex: 2389
{	// Fields
	public int value__; // 0x0
	[XmlIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public const XmlSchemaUse None = 0;
	[XmlEnumAttribute] // RVA: 0x9CF50 Offset: 0x9C350 VA: 0x18009CF50
	public const XmlSchemaUse Optional = 1;
	[XmlEnumAttribute] // RVA: 0x9D080 Offset: 0x9C480 VA: 0x18009D080
	public const XmlSchemaUse Prohibited = 2;
	[XmlEnumAttribute] // RVA: 0x9D270 Offset: 0x9C670 VA: 0x18009D270
	public const XmlSchemaUse Required = 3;

}

public class XmlSchemaValidationException : XmlSchemaException // TypeDefIndex: 2390
{	// Methods

	// RVA: 0xD279F0 Offset: 0xD25FF0 VA: 0x180D279F0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xD27990 Offset: 0xD25F90 VA: 0x180D27990 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xD27A10 Offset: 0xD26010 VA: 0x180D27A10
	public void .ctor() { }

	// RVA: 0xD27A20 Offset: 0xD26020 VA: 0x180D27A20
	internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0xD27B30 Offset: 0xD26130 VA: 0x180D27B30
	internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0xD279B0 Offset: 0xD25FB0 VA: 0x180D279B0
	internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition) { }

}

public sealed class XmlValueGetter : MulticastDelegate // TypeDefIndex: 2391
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xD3D430 Offset: 0xD3BA30 VA: 0x180D3D430 Slot: 12
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

	// RVA: 0xD34B80 Offset: 0xD33180 VA: 0x180D34B80
	public void .ctor(XmlNameTable nameTable, XmlSchemaSet schemas, IXmlNamespaceResolver namespaceResolver, XmlSchemaValidationFlags validationFlags) { }

	// RVA: 0xD2E1D0 Offset: 0xD2C7D0 VA: 0x180D2E1D0
	private void Init() { }

	// RVA: 0xD30D70 Offset: 0xD2F370 VA: 0x180D30D70
	private void Reset() { }

	// RVA: 0xD35070 Offset: 0xD33670 VA: 0x180D35070
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0xD34FF0 Offset: 0xD335F0 VA: 0x180D34FF0
	public void set_LineInfoProvider(IXmlLineInfo value) { }

	// RVA: 0xD35010 Offset: 0xD33610 VA: 0x180D35010
	public void set_SourceUri(Uri value) { }

	// RVA: 0xA4D230 Offset: 0xA4B830 VA: 0x180A4D230
	public void set_ValidationEventSender(object value) { }

	// RVA: 0xD34DD0 Offset: 0xD333D0 VA: 0x180D34DD0
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0xD34F70 Offset: 0xD33570 VA: 0x180D34F70
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0xD280F0 Offset: 0xD266F0 VA: 0x180D280F0
	public void AddSchema(XmlSchema schema) { }

	// RVA: 0xD2E820 Offset: 0xD2CE20 VA: 0x180D2E820
	public void Initialize() { }

	// RVA: 0xD2E550 Offset: 0xD2CB50 VA: 0x180D2E550
	public void Initialize(XmlSchemaObject partialValidationType) { }

	// RVA: 0xD336F0 Offset: 0xD31CF0 VA: 0x180D336F0
	public void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0xD32720 Offset: 0xD30D20 VA: 0x180D32720
	public object ValidateAttribute(string localName, string namespaceUri, XmlValueGetter attributeValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0xD327D0 Offset: 0xD30DD0 VA: 0x180D327D0
	private object ValidateAttribute(string lName, string ns, XmlValueGetter attributeValueGetter, string attributeStringValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0xD33BE0 Offset: 0xD321E0 VA: 0x180D33BE0
	public void ValidateEndOfAttributes(XmlSchemaInfo schemaInfo) { }

	// RVA: 0xD341C0 Offset: 0xD327C0 VA: 0x180D341C0
	public void ValidateText(XmlValueGetter elementValue) { }

	// RVA: 0xD33D20 Offset: 0xD32320 VA: 0x180D33D20
	private void ValidateText(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0xD344A0 Offset: 0xD32AA0 VA: 0x180D344A0
	public void ValidateWhitespace(XmlValueGetter elementValue) { }

	// RVA: 0xD34240 Offset: 0xD32840 VA: 0x180D34240
	private void ValidateWhitespace(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0xD33BD0 Offset: 0xD321D0 VA: 0x180D33BD0
	public object ValidateEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0xD31A70 Offset: 0xD30070 VA: 0x180D31A70
	public void SkipToEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0xD2CC60 Offset: 0xD2B260 VA: 0x180D2CC60
	public void EndValidation() { }

	// RVA: 0xD2DB70 Offset: 0xD2C170 VA: 0x180D2DB70
	internal void GetUnspecifiedDefaultAttributes(ArrayList defaultAttributes, bool createNodeData) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal XmlSchemaSet get_SchemaSet() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	internal XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0xD34E50 Offset: 0xD33450 VA: 0x180D34E50
	internal XmlSchemaContentType get_CurrentContentType() { }

	// RVA: 0xD31A50 Offset: 0xD30050 VA: 0x180D31A50
	internal void SetDtdSchemaInfo(IDtdInfo dtdSchemaInfo) { }

	// RVA: 0xD34F30 Offset: 0xD33530 VA: 0x180D34F30
	private bool get_StrictlyAssessed() { }

	// RVA: 0xD34EB0 Offset: 0xD334B0 VA: 0x180D34EB0
	private bool get_HasSchema() { }

	// RVA: 0xD2D3E0 Offset: 0xD2B9E0 VA: 0x180D2D3E0
	internal string GetConcatenatedValue() { }

	// RVA: 0xD2E9A0 Offset: 0xD2CFA0 VA: 0x180D2E9A0
	private object InternalValidateEndElement(XmlSchemaInfo schemaInfo, object typedValue) { }

	// RVA: 0xD303C0 Offset: 0xD2E9C0 VA: 0x180D303C0
	private void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0xD33220 Offset: 0xD31820 VA: 0x180D33220
	private object ValidateElementContext(XmlQualifiedName elementName, out bool invalidElementInContext) { }

	// RVA: 0xD2D7E0 Offset: 0xD2BDE0 VA: 0x180D2D7E0
	private XmlSchemaElement GetSubstitutionGroupHead(XmlQualifiedName member) { }

	// RVA: 0xD31EE0 Offset: 0xD304E0 VA: 0x180D31EE0
	private object ValidateAtomicValue(string stringValue, out XmlSchemaSimpleType memberType) { }

	// RVA: 0xD32230 Offset: 0xD30830 VA: 0x180D32230
	private object ValidateAtomicValue(object parsedValue, out XmlSchemaSimpleType memberType) { }

	// RVA: 0xD2DB00 Offset: 0xD2C100 VA: 0x180D2DB00
	private string GetTypeName(SchemaDeclBase decl) { }

	// RVA: 0xD30E20 Offset: 0xD2F420 VA: 0x180D30E20
	private void SaveTextValue(object value) { }

	// RVA: 0xD30A80 Offset: 0xD2F080 VA: 0x180D30A80
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0xD2F4D0 Offset: 0xD2DAD0 VA: 0x180D2F4D0
	private void Pop() { }

	// RVA: 0xD2D080 Offset: 0xD2B680 VA: 0x180D2D080
	private SchemaElementDecl FastGetElementDecl(XmlQualifiedName elementName, object particle) { }

	// RVA: 0xD29D00 Offset: 0xD28300 VA: 0x180D29D00
	private SchemaElementDecl CheckXsiTypeAndNil(SchemaElementDecl elementDecl, string xsiType, string xsiNil, ref bool declFound) { }

	// RVA: 0xD31CA0 Offset: 0xD302A0 VA: 0x180D31CA0
	private void ThrowDeclNotFoundWarningOrError(bool declFound) { }

	// RVA: 0xD28EE0 Offset: 0xD274E0 VA: 0x180D28EE0
	private void CheckElementProperties() { }

	// RVA: 0xD33CC0 Offset: 0xD322C0 VA: 0x180D33CC0
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0xD294E0 Offset: 0xD27AE0 VA: 0x180D294E0
	private SchemaAttDef CheckIsXmlAttribute(XmlQualifiedName attQName) { }

	// RVA: 0xD28560 Offset: 0xD26B60 VA: 0x180D28560
	private void AddXmlNamespaceSchema() { }

	// RVA: 0xD29620 Offset: 0xD27C20 VA: 0x180D29620
	internal object CheckMixedValueConstraint(string elementValue) { }

	// RVA: 0xD2EFC0 Offset: 0xD2D5C0 VA: 0x180D2EFC0
	private void LoadSchema(string uri, string url) { }

	// RVA: 0xD30CD0 Offset: 0xD2F2D0 VA: 0x180D30CD0
	internal void RecompileSchemaSet() { }

	// RVA: 0xD307B0 Offset: 0xD2EDB0 VA: 0x180D307B0
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name, bool attrValue) { }

	// RVA: 0xD28B50 Offset: 0xD27150 VA: 0x180D28B50
	private object CheckAttributeValue(object value, SchemaAttDef attdef) { }

	// RVA: 0xD28FC0 Offset: 0xD275C0 VA: 0x180D28FC0
	private object CheckElementValue(string stringValue) { }

	// RVA: 0xD29B80 Offset: 0xD28180 VA: 0x180D29B80
	private void CheckTokenizedTypes(XmlSchemaDatatype dtype, object typedValue, bool attrValue) { }

	// RVA: 0xD2D3C0 Offset: 0xD2B9C0 VA: 0x180D2D3C0
	private object FindId(string name) { }

	// RVA: 0xD293C0 Offset: 0xD279C0 VA: 0x180D293C0
	private void CheckForwardRefs() { }

	// RVA: 0xD34E90 Offset: 0xD33490 VA: 0x180D34E90
	private bool get_HasIdentityConstraints() { }

	// RVA: 0xD34F00 Offset: 0xD33500 VA: 0x180D34F00
	internal bool get_ProcessIdentityConstraints() { }

	// RVA: 0xD34F20 Offset: 0xD33520 VA: 0x180D34F20
	internal bool get_ReportValidationWarnings() { }

	// RVA: 0xD34F10 Offset: 0xD33510 VA: 0x180D34F10
	internal bool get_ProcessSchemaHints() { }

	// RVA: 0xD298D0 Offset: 0xD27ED0 VA: 0x180D298D0
	private void CheckStateTransition(ValidatorState toState, string methodName) { }

	// RVA: 0xD2A510 Offset: 0xD28B10 VA: 0x180D2A510
	private void ClearPSVI() { }

	// RVA: 0xD29720 Offset: 0xD27D20 VA: 0x180D29720
	private void CheckRequiredAttributes(SchemaElementDecl currentElementDecl) { }

	// RVA: 0xD2D680 Offset: 0xD2BC80 VA: 0x180D2D680
	private XmlSchemaElement GetSchemaElement() { }

	// RVA: 0xD2D410 Offset: 0xD2BA10 VA: 0x180D2D410
	internal string GetDefaultAttributePrefix(string attributeNS) { }

	// RVA: 0xD27B70 Offset: 0xD26170 VA: 0x180D27B70
	private void AddIdentityConstraints() { }

	// RVA: 0xD2AD10 Offset: 0xD29310 VA: 0x180D2AD10
	private void ElementIdentityConstraints() { }

	// RVA: 0xD28600 Offset: 0xD26C00 VA: 0x180D28600
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, XmlSchemaDatatype datatype) { }

	// RVA: 0xD2BDE0 Offset: 0xD2A3E0 VA: 0x180D2BDE0
	private void EndElementIdentityConstraints(object typedValue, string stringValue, XmlSchemaDatatype datatype) { }

	// RVA: 0xD2B0C0 Offset: 0xD296C0 VA: 0x180D2B0C0
	internal static void ElementValidationError(XmlQualifiedName name, ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0xD2A570 Offset: 0xD28B70 VA: 0x180D2A570
	internal static void CompleteValidationError(ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0xD2F610 Offset: 0xD2DC10 VA: 0x180D2F610
	internal static string PrintExpectedElements(ArrayList expected, bool getParticles) { }

	// RVA: 0xD30140 Offset: 0xD2E740 VA: 0x180D30140
	private static string PrintNames(ArrayList expected) { }

	// RVA: 0xD2FB60 Offset: 0xD2E160 VA: 0x180D2FB60
	private static void PrintNamesWithNS(ArrayList expected, StringBuilder builder) { }

	// RVA: 0xD2CE70 Offset: 0xD2B470 VA: 0x180D2CE70
	private static void EnumerateAny(StringBuilder builder, string namespaces) { }

	// RVA: 0xD30C60 Offset: 0xD2F260 VA: 0x180D30C60
	internal static string QNameString(string localName, string ns) { }

	// RVA: 0xD28930 Offset: 0xD26F30 VA: 0x180D28930
	internal static string BuildElementName(XmlQualifiedName qname) { }

	// RVA: 0xD289B0 Offset: 0xD26FB0 VA: 0x180D289B0
	internal static string BuildElementName(string localName, string ns) { }

	// RVA: 0xD302B0 Offset: 0xD2E8B0 VA: 0x180D302B0
	private void ProcessEntity(string name) { }

	// RVA: 0xD31590 Offset: 0xD2FB90 VA: 0x180D31590
	private void SendValidationEvent(string code) { }

	// RVA: 0xD31770 Offset: 0xD2FD70 VA: 0x180D31770
	private void SendValidationEvent(string code, string[] args) { }

	// RVA: 0xD31340 Offset: 0xD2F940 VA: 0x180D31340
	private void SendValidationEvent(string code, string arg) { }

	// RVA: 0xD31880 Offset: 0xD2FE80 VA: 0x180D31880
	private void SendValidationEvent(string code, string arg1, string arg2) { }

	// RVA: 0xD31100 Offset: 0xD2F700 VA: 0x180D31100
	private void SendValidationEvent(string code, string[] args, Exception innerException, XmlSeverityType severity) { }

	// RVA: 0xD315F0 Offset: 0xD2FBF0 VA: 0x180D315F0
	private void SendValidationEvent(string code, string[] args, Exception innerException) { }

	// RVA: 0xD31040 Offset: 0xD2F640 VA: 0x180D31040
	private void SendValidationEvent(XmlSchemaValidationException e) { }

	// RVA: 0xD31430 Offset: 0xD2FA30 VA: 0x180D31430
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0xD30E70 Offset: 0xD2F470 VA: 0x180D30E70
	private void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0xD31240 Offset: 0xD2F840 VA: 0x180D31240
	private void SendValidationEvent(XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0xD30F90 Offset: 0xD2F590 VA: 0x180D30F90
	internal static void SendValidationEvent(ValidationEventHandler eventHandler, object sender, XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0xD34520 Offset: 0xD32B20 VA: 0x180D34520
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

	// RVA: 0x1439000 Offset: 0x1437600 VA: 0x181439000
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1439110 Offset: 0x1437710 VA: 0x181439110
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x1438F90 Offset: 0x1437590 VA: 0x181438F90
	protected void .ctor(XmlBaseConverter converterAtomic) { }

	// RVA: 0x1438F30 Offset: 0x1437530 VA: 0x181438F30
	protected void .ctor(XmlBaseConverter converterAtomic, Type clrTypeDefault) { }

	// RVA: 0x1436440 Offset: 0x1434A40 VA: 0x181436440 Slot: 7
	public override bool ToBoolean(DateTime value) { }

	// RVA: 0x1436280 Offset: 0x1434880 VA: 0x181436280 Slot: 6
	public override bool ToBoolean(double value) { }

	// RVA: 0x1436360 Offset: 0x1434960 VA: 0x181436360 Slot: 5
	public override bool ToBoolean(int value) { }

	// RVA: 0x14361A0 Offset: 0x14347A0 VA: 0x1814361A0 Slot: 4
	public override bool ToBoolean(long value) { }

	// RVA: 0x14360E0 Offset: 0x14346E0 VA: 0x1814360E0 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x1436520 Offset: 0x1434B20 VA: 0x181436520 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x1436D90 Offset: 0x1435390 VA: 0x181436D90 Slot: 33
	public override DateTime ToDateTime(bool value) { }

	// RVA: 0x1436BD0 Offset: 0x14351D0 VA: 0x181436BD0 Slot: 37
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x1436CB0 Offset: 0x14352B0 VA: 0x181436CB0 Slot: 36
	public override DateTime ToDateTime(double value) { }

	// RVA: 0x1436890 Offset: 0x1434E90 VA: 0x181436890 Slot: 34
	public override DateTime ToDateTime(int value) { }

	// RVA: 0x1436A30 Offset: 0x1435030 VA: 0x181436A30 Slot: 35
	public override DateTime ToDateTime(long value) { }

	// RVA: 0x1436B10 Offset: 0x1435110 VA: 0x181436B10 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x1436970 Offset: 0x1434F70 VA: 0x181436970 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x14365E0 Offset: 0x1434BE0 VA: 0x1814365E0 Slot: 40
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x14366D0 Offset: 0x1434CD0 VA: 0x1814366D0 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x14367B0 Offset: 0x1434DB0 VA: 0x1814367B0 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x1436F40 Offset: 0x1435540 VA: 0x181436F40 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x1436E70 Offset: 0x1435470 VA: 0x181436E70 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x1437290 Offset: 0x1435890 VA: 0x181437290 Slot: 24
	public override double ToDouble(bool value) { }

	// RVA: 0x1437430 Offset: 0x1435A30 VA: 0x181437430 Slot: 27
	public override double ToDouble(DateTime value) { }

	// RVA: 0x14370F0 Offset: 0x14356F0 VA: 0x1814370F0 Slot: 25
	public override double ToDouble(int value) { }

	// RVA: 0x1437010 Offset: 0x1435610 VA: 0x181437010 Slot: 26
	public override double ToDouble(long value) { }

	// RVA: 0x14371D0 Offset: 0x14357D0 VA: 0x1814371D0 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x1437370 Offset: 0x1435970 VA: 0x181437370 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x14376B0 Offset: 0x1435CB0 VA: 0x1814376B0 Slot: 10
	public override int ToInt32(bool value) { }

	// RVA: 0x1437780 Offset: 0x1435D80 VA: 0x181437780 Slot: 13
	public override int ToInt32(DateTime value) { }

	// RVA: 0x14375D0 Offset: 0x1435BD0 VA: 0x1814375D0 Slot: 12
	public override int ToInt32(double value) { }

	// RVA: 0x1437850 Offset: 0x1435E50 VA: 0x181437850 Slot: 11
	public override int ToInt32(long value) { }

	// RVA: 0x1437510 Offset: 0x1435B10 VA: 0x181437510 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x1437920 Offset: 0x1435F20 VA: 0x181437920 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x1437C30 Offset: 0x1436230 VA: 0x181437C30 Slot: 16
	public override long ToInt64(bool value) { }

	// RVA: 0x1437DE0 Offset: 0x14363E0 VA: 0x181437DE0 Slot: 19
	public override long ToInt64(DateTime value) { }

	// RVA: 0x1437D00 Offset: 0x1436300 VA: 0x181437D00 Slot: 18
	public override long ToInt64(double value) { }

	// RVA: 0x1437B60 Offset: 0x1436160 VA: 0x181437B60 Slot: 17
	public override long ToInt64(int value) { }

	// RVA: 0x1437AA0 Offset: 0x14360A0 VA: 0x181437AA0 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x14379E0 Offset: 0x1435FE0 VA: 0x1814379E0 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x1437F80 Offset: 0x1436580 VA: 0x181437F80 Slot: 30
	public override float ToSingle(double value) { }

	// RVA: 0x1437EC0 Offset: 0x14364C0 VA: 0x181437EC0 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x1438060 Offset: 0x1436660 VA: 0x181438060 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x1438120 Offset: 0x1436720 VA: 0x181438120 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x14382A0 Offset: 0x14368A0 VA: 0x1814382A0 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x1438440 Offset: 0x1436A40 VA: 0x181438440 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x1438370 Offset: 0x1436970 VA: 0x181438370 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x1438790 Offset: 0x1436D90 VA: 0x181438790 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x14385E0 Offset: 0x1436BE0 VA: 0x1814385E0 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x1438510 Offset: 0x1436B10 VA: 0x181438510 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x14386A0 Offset: 0x1436CA0 VA: 0x1814386A0 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x14381E0 Offset: 0x14367E0 VA: 0x1814381E0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1438770 Offset: 0x1436D70 VA: 0x181438770 Slot: 51
	public override string ToString(object value) { }

	// RVA: 0x1433970 Offset: 0x1431F70 VA: 0x181433970 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x14337D0 Offset: 0x1431DD0 VA: 0x1814337D0 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x1433A20 Offset: 0x1432020 VA: 0x181433A20 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x14338D0 Offset: 0x1431ED0 VA: 0x1814338D0 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x1433750 Offset: 0x1431D50 VA: 0x181433750 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x1433850 Offset: 0x1431E50 VA: 0x181433850 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x1433950 Offset: 0x1431F50 VA: 0x181433950 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x14339F0 Offset: 0x1431FF0 VA: 0x1814339F0 Slot: 60
	public override object ChangeType(object value, Type destinationType) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	protected XmlSchemaType get_SchemaType() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	protected XmlTypeCode get_TypeCode() { }

	// RVA: 0x1439210 Offset: 0x1437810 VA: 0x181439210
	protected string get_XmlTypeName() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	protected Type get_DefaultClrType() { }

	// RVA: 0x1434F20 Offset: 0x1433520 VA: 0x181434F20
	protected static bool IsDerivedFrom(Type derivedType, Type baseType) { }

	// RVA: 0x1433AA0 Offset: 0x14320A0 VA: 0x181433AA0
	protected Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

	// RVA: 0x1435180 Offset: 0x1433780 VA: 0x181435180
	protected static string QNameToString(XmlQualifiedName name) { }

	// RVA: 0x14336E0 Offset: 0x1431CE0 VA: 0x1814336E0 Slot: 62
	protected virtual object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1435260 Offset: 0x1433860 VA: 0x181435260
	protected static byte[] StringToBase64Binary(string value) { }

	// RVA: 0x14354A0 Offset: 0x1433AA0 VA: 0x1814354A0
	protected static DateTime StringToDate(string value) { }

	// RVA: 0x1435420 Offset: 0x1433A20 VA: 0x181435420
	protected static DateTime StringToDateTime(string value) { }

	// RVA: 0x1435520 Offset: 0x1433B20 VA: 0x181435520
	protected static TimeSpan StringToDayTimeDuration(string value) { }

	// RVA: 0x1435580 Offset: 0x1433B80 VA: 0x181435580
	protected static TimeSpan StringToDuration(string value) { }

	// RVA: 0x1435680 Offset: 0x1433C80 VA: 0x181435680
	protected static DateTime StringToGDay(string value) { }

	// RVA: 0x14358C0 Offset: 0x1433EC0 VA: 0x1814358C0
	protected static DateTime StringToGMonth(string value) { }

	// RVA: 0x14357A0 Offset: 0x1433DA0 VA: 0x1814357A0
	protected static DateTime StringToGMonthDay(string value) { }

	// RVA: 0x1435B00 Offset: 0x1434100 VA: 0x181435B00
	protected static DateTime StringToGYear(string value) { }

	// RVA: 0x14359E0 Offset: 0x1433FE0 VA: 0x1814359E0
	protected static DateTime StringToGYearMonth(string value) { }

	// RVA: 0x14352E0 Offset: 0x14338E0 VA: 0x1814352E0
	protected static DateTimeOffset StringToDateOffset(string value) { }

	// RVA: 0x1435380 Offset: 0x1433980 VA: 0x181435380
	protected static DateTimeOffset StringToDateTimeOffset(string value) { }

	// RVA: 0x14355E0 Offset: 0x1433BE0 VA: 0x1814355E0
	protected static DateTimeOffset StringToGDayOffset(string value) { }

	// RVA: 0x1435820 Offset: 0x1433E20 VA: 0x181435820
	protected static DateTimeOffset StringToGMonthOffset(string value) { }

	// RVA: 0x1435700 Offset: 0x1433D00 VA: 0x181435700
	protected static DateTimeOffset StringToGMonthDayOffset(string value) { }

	// RVA: 0x1435A60 Offset: 0x1434060 VA: 0x181435A60
	protected static DateTimeOffset StringToGYearOffset(string value) { }

	// RVA: 0x1435940 Offset: 0x1433F40 VA: 0x181435940
	protected static DateTimeOffset StringToGYearMonthOffset(string value) { }

	// RVA: 0x1435B80 Offset: 0x1434180 VA: 0x181435B80
	protected static byte[] StringToHexBinary(string value) { }

	// RVA: 0x1435C50 Offset: 0x1434250 VA: 0x181435C50
	protected static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1435F70 Offset: 0x1434570 VA: 0x181435F70
	protected static DateTime StringToTime(string value) { }

	// RVA: 0x1435ED0 Offset: 0x14344D0 VA: 0x181435ED0
	protected static DateTimeOffset StringToTimeOffset(string value) { }

	// RVA: 0x1435FF0 Offset: 0x14345F0 VA: 0x181435FF0
	protected static TimeSpan StringToYearMonthDuration(string value) { }

	// RVA: 0x1433660 Offset: 0x1431C60 VA: 0x181433660
	protected static string AnyUriToString(Uri value) { }

	// RVA: 0x1433680 Offset: 0x1431C80 VA: 0x181433680
	protected static string Base64BinaryToString(byte[] value) { }

	// RVA: 0x1433EC0 Offset: 0x14324C0 VA: 0x181433EC0
	protected static string DateToString(DateTime value) { }

	// RVA: 0x1433E80 Offset: 0x1432480 VA: 0x181433E80
	protected static string DateTimeToString(DateTime value) { }

	// RVA: 0x1433F00 Offset: 0x1432500 VA: 0x181433F00
	protected static string DayTimeDurationToString(TimeSpan value) { }

	// RVA: 0x1434580 Offset: 0x1432B80 VA: 0x181434580
	protected static string DurationToString(TimeSpan value) { }

	// RVA: 0x1434630 Offset: 0x1432C30 VA: 0x181434630
	protected static string GDayToString(DateTime value) { }

	// RVA: 0x1434750 Offset: 0x1432D50 VA: 0x181434750
	protected static string GMonthToString(DateTime value) { }

	// RVA: 0x14346C0 Offset: 0x1432CC0 VA: 0x1814346C0
	protected static string GMonthDayToString(DateTime value) { }

	// RVA: 0x1434870 Offset: 0x1432E70 VA: 0x181434870
	protected static string GYearToString(DateTime value) { }

	// RVA: 0x14347E0 Offset: 0x1432DE0 VA: 0x1814347E0
	protected static string GYearMonthToString(DateTime value) { }

	// RVA: 0x1433DD0 Offset: 0x14323D0 VA: 0x181433DD0
	protected static string DateOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1433E30 Offset: 0x1432430 VA: 0x181433E30
	protected static string DateTimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x14345E0 Offset: 0x1432BE0 VA: 0x1814345E0
	protected static string GDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1434700 Offset: 0x1432D00 VA: 0x181434700
	protected static string GMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1434670 Offset: 0x1432C70 VA: 0x181434670
	protected static string GMonthDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1434820 Offset: 0x1432E20 VA: 0x181434820
	protected static string GYearOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1434790 Offset: 0x1432D90 VA: 0x181434790
	protected static string GYearMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1434FF0 Offset: 0x14335F0 VA: 0x181434FF0
	protected static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x14360A0 Offset: 0x14346A0 VA: 0x1814360A0
	protected static string TimeToString(DateTime value) { }

	// RVA: 0x1436050 Offset: 0x1434650 VA: 0x181436050
	protected static string TimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1438980 Offset: 0x1436F80 VA: 0x181438980
	protected static string YearMonthDurationToString(TimeSpan value) { }

	// RVA: 0x1433E20 Offset: 0x1432420 VA: 0x181433E20
	internal static DateTime DateTimeOffsetToDateTime(DateTimeOffset value) { }

	// RVA: 0x1433F60 Offset: 0x1432560 VA: 0x181433F60
	internal static int DecimalToInt32(Decimal value) { }

	// RVA: 0x1434170 Offset: 0x1432770 VA: 0x181434170
	protected static long DecimalToInt64(Decimal value) { }

	// RVA: 0x1434380 Offset: 0x1432980 VA: 0x181434380
	protected static ulong DecimalToUInt64(Decimal value) { }

	// RVA: 0x14348B0 Offset: 0x1432EB0 VA: 0x1814348B0
	protected static byte Int32ToByte(int value) { }

	// RVA: 0x14349C0 Offset: 0x1432FC0 VA: 0x1814349C0
	protected static short Int32ToInt16(int value) { }

	// RVA: 0x1434AD0 Offset: 0x14330D0 VA: 0x181434AD0
	protected static sbyte Int32ToSByte(int value) { }

	// RVA: 0x1434BE0 Offset: 0x14331E0 VA: 0x181434BE0
	protected static ushort Int32ToUInt16(int value) { }

	// RVA: 0x1434CF0 Offset: 0x14332F0 VA: 0x181434CF0
	protected static int Int64ToInt32(long value) { }

	// RVA: 0x1434E10 Offset: 0x1433410 VA: 0x181434E10
	protected static uint Int64ToUInt32(long value) { }

	// RVA: 0x1438900 Offset: 0x1436F00 VA: 0x181438900
	protected static DateTime UntypedAtomicToDateTime(string value) { }

	// RVA: 0x1438860 Offset: 0x1436E60 VA: 0x181438860
	protected static DateTimeOffset UntypedAtomicToDateTimeOffset(string value) { }

	// RVA: 0x14389E0 Offset: 0x1436FE0 VA: 0x1814389E0
	private static void .cctor() { }

}

internal class XmlNumeric10Converter : XmlBaseConverter // TypeDefIndex: 2401
{	// Methods

	// RVA: 0x1446F50 Offset: 0x1445550 VA: 0x181446F50
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x14457F0 Offset: 0x1443DF0 VA: 0x1814457F0
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1445880 Offset: 0x1443E80 VA: 0x181445880 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x1445960 Offset: 0x1443F60 VA: 0x181445960 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x1445E30 Offset: 0x1444430 VA: 0x181445E30 Slot: 11
	public override int ToInt32(long value) { }

	// RVA: 0x14462F0 Offset: 0x14448F0 VA: 0x1814462F0 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x1445E90 Offset: 0x1444490 VA: 0x181445E90 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x1446400 Offset: 0x1444A00 VA: 0x181446400 Slot: 17
	public override long ToInt64(int value) { }

	// RVA: 0x1446840 Offset: 0x1444E40 VA: 0x181446840 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x1446410 Offset: 0x1444A10 VA: 0x181446410 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x1446E10 Offset: 0x1445410 VA: 0x181446E10 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x1446F00 Offset: 0x1445500 VA: 0x181446F00 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x1446950 Offset: 0x1444F50 VA: 0x181446950 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x14469B0 Offset: 0x1444FB0 VA: 0x1814469B0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1442B00 Offset: 0x1441100 VA: 0x181442B00 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x14452A0 Offset: 0x14438A0 VA: 0x1814452A0 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x1443120 Offset: 0x1441720 VA: 0x181443120 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x14436A0 Offset: 0x1441CA0 VA: 0x1814436A0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1443C10 Offset: 0x1442210 VA: 0x181443C10 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1442170 Offset: 0x1440770 VA: 0x181442170
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x14425F0 Offset: 0x1440BF0 VA: 0x1814425F0
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlNumeric2Converter : XmlBaseConverter // TypeDefIndex: 2402
{	// Methods

	// RVA: 0x1449370 Offset: 0x1447970 VA: 0x181449370
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x14484E0 Offset: 0x1446AE0 VA: 0x1814484E0
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1448570 Offset: 0x1446B70 VA: 0x181448570 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x1448640 Offset: 0x1446C40 VA: 0x181448640 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x1448DB0 Offset: 0x14473B0 VA: 0x181448DB0 Slot: 30
	public override float ToSingle(double value) { }

	// RVA: 0x1448DC0 Offset: 0x14473C0 VA: 0x181448DC0 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x14489D0 Offset: 0x1446FD0 VA: 0x1814489D0 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x1449220 Offset: 0x1447820 VA: 0x181449220 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x14492D0 Offset: 0x14478D0 VA: 0x1814492D0 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x1448E90 Offset: 0x1447490 VA: 0x181448E90 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1447B40 Offset: 0x1446140 VA: 0x181447B40 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x1447FF0 Offset: 0x14465F0 VA: 0x181447FF0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1446FC0 Offset: 0x14455C0 VA: 0x181446FC0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlDateTimeConverter : XmlBaseConverter // TypeDefIndex: 2403
{	// Methods

	// RVA: 0x143DA30 Offset: 0x143C030 VA: 0x18143DA30
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x143C380 Offset: 0x143A980 VA: 0x18143C380
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x143D220 Offset: 0x143B820 VA: 0x18143D220 Slot: 37
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x143CF00 Offset: 0x143B500 VA: 0x18143CF00 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x143CB60 Offset: 0x143B160 VA: 0x18143CB60 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x143C410 Offset: 0x143AA10 VA: 0x18143C410 Slot: 40
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x143C820 Offset: 0x143AE20 VA: 0x18143C820 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x143C440 Offset: 0x143AA40 VA: 0x18143C440 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x143D620 Offset: 0x143BC20 VA: 0x18143D620 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x143D810 Offset: 0x143BE10 VA: 0x18143D810 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x143D280 Offset: 0x143B880 VA: 0x18143D280 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143AD50 Offset: 0x1439350 VA: 0x18143AD50 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x143B220 Offset: 0x1439820 VA: 0x18143B220 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143B710 Offset: 0x1439D10 VA: 0x18143B710 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlBooleanConverter : XmlBaseConverter // TypeDefIndex: 2404
{	// Methods

	// RVA: 0x143ACE0 Offset: 0x14392E0 VA: 0x18143ACE0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x143A570 Offset: 0x1438B70 VA: 0x18143A570
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x143A8F0 Offset: 0x1438EF0 VA: 0x18143A8F0 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x143A600 Offset: 0x1438C00 VA: 0x18143A600 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x143AC80 Offset: 0x1439280 VA: 0x18143AC80 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x143A980 Offset: 0x1438F80 VA: 0x18143A980 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1439CC0 Offset: 0x14382C0 VA: 0x181439CC0 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x143A100 Offset: 0x1438700 VA: 0x18143A100 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x14393D0 Offset: 0x14379D0 VA: 0x1814393D0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlMiscConverter : XmlBaseConverter // TypeDefIndex: 2405
{	// Methods

	// RVA: 0x1442100 Offset: 0x1440700 VA: 0x181442100
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1441860 Offset: 0x143FE60 VA: 0x181441860
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x14418F0 Offset: 0x143FEF0 VA: 0x1814418F0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1441190 Offset: 0x143F790 VA: 0x181441190 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143FD40 Offset: 0x143E340 VA: 0x18143FD40 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143FA70 Offset: 0x143E070 VA: 0x18143FA70
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143FBB0 Offset: 0x143E1B0 VA: 0x18143FBB0
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlStringConverter : XmlBaseConverter // TypeDefIndex: 2406
{	// Methods

	// RVA: 0xD35BB0 Offset: 0xD341B0 VA: 0x180D35BB0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0xD358E0 Offset: 0xD33EE0 VA: 0x180D358E0
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0xD35970 Offset: 0xD33F70 VA: 0x180D35970 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD350A0 Offset: 0xD336A0 VA: 0x180D350A0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD35390 Offset: 0xD33990 VA: 0x180D35390 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlUntypedConverter : XmlListConverter // TypeDefIndex: 2407
{	// Fields
	private bool allowListToList; // 0x30
	public static readonly XmlValueConverter Untyped; // 0x0
	public static readonly XmlValueConverter UntypedList; // 0x8

	// Methods

	// RVA: 0xD3D380 Offset: 0xD3B980 VA: 0x180D3D380
	protected void .ctor() { }

	// RVA: 0xD3D2B0 Offset: 0xD3B8B0 VA: 0x180D3D2B0
	protected void .ctor(XmlUntypedConverter atomicConverter, bool allowListToList) { }

	// RVA: 0xD3ACC0 Offset: 0xD392C0 VA: 0x180D3ACC0 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0xD3AAF0 Offset: 0xD390F0 VA: 0x180D3AAF0 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0xD3B1B0 Offset: 0xD397B0 VA: 0x180D3B1B0 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0xD3AFE0 Offset: 0xD395E0 VA: 0x180D3AFE0 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0xD3AD50 Offset: 0xD39350 VA: 0x180D3AD50 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0xD3AE00 Offset: 0xD39400 VA: 0x180D3AE00 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0xD3B420 Offset: 0xD39A20 VA: 0x180D3B420 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0xD3B240 Offset: 0xD39840 VA: 0x180D3B240 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0xD3B4D0 Offset: 0xD39AD0 VA: 0x180D3B4D0 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0xD3B560 Offset: 0xD39B60 VA: 0x180D3B560 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0xD3B8F0 Offset: 0xD39EF0 VA: 0x180D3B8F0 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0xD3B730 Offset: 0xD39D30 VA: 0x180D3B730 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0xD3BB50 Offset: 0xD3A150 VA: 0x180D3BB50 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0xD3B980 Offset: 0xD39F80 VA: 0x180D3B980 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0xD3BBE0 Offset: 0xD3A1E0 VA: 0x180D3BBE0 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0xD3BC70 Offset: 0xD3A270 VA: 0x180D3BC70 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0xD3D0C0 Offset: 0xD3B6C0 VA: 0x180D3D0C0 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0xD3BE40 Offset: 0xD3A440 VA: 0x180D3BE40 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0xD3CFA0 Offset: 0xD3B5A0 VA: 0x180D3CFA0 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0xD3CF40 Offset: 0xD3B540 VA: 0x180D3CF40 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0xD3D060 Offset: 0xD3B660 VA: 0x180D3D060 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0xD3BEA0 Offset: 0xD3A4A0 VA: 0x180D3BEA0 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0xD3D000 Offset: 0xD3B600 VA: 0x180D3D000 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0xD3BEF0 Offset: 0xD3A4F0 VA: 0x180D3BEF0 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0xD3BF50 Offset: 0xD3A550 VA: 0x180D3BF50 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD39F70 Offset: 0xD38570 VA: 0x180D39F70 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0xD3A160 Offset: 0xD38760 VA: 0x180D3A160 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0xD36EF0 Offset: 0xD354F0 VA: 0x180D36EF0 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0xD36D00 Offset: 0xD35300 VA: 0x180D36D00 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0xD370F0 Offset: 0xD356F0 VA: 0x180D370F0 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0xD36B10 Offset: 0xD35110 VA: 0x180D36B10 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0xD372D0 Offset: 0xD358D0 VA: 0x180D372D0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD38250 Offset: 0xD36850 VA: 0x180D38250 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD36840 Offset: 0xD34E40 VA: 0x180D36840
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD36980 Offset: 0xD34F80 VA: 0x180D36980
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD36510 Offset: 0xD34B10 VA: 0x180D36510 Slot: 62
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD3A350 Offset: 0xD38950 VA: 0x180D3A350
	private bool SupportsType(Type clrType) { }

	// RVA: 0xD3D120 Offset: 0xD3B720 VA: 0x180D3D120
	private static void .cctor() { }

}

internal class XmlAnyConverter : XmlBaseConverter // TypeDefIndex: 2408
{	// Fields
	public static readonly XmlValueConverter Item; // 0x0
	public static readonly XmlValueConverter AnyAtomic; // 0x8

	// Methods

	// RVA: 0x1431CE0 Offset: 0x14302E0 VA: 0x181431CE0
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x1430B90 Offset: 0x142F190 VA: 0x181430B90 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x1430F60 Offset: 0x142F560 VA: 0x181430F60 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x1430D40 Offset: 0x142F340 VA: 0x181430D40 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x1431110 Offset: 0x142F710 VA: 0x181431110 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x1431330 Offset: 0x142F930 VA: 0x181431330 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x14314E0 Offset: 0x142FAE0 VA: 0x1814314E0 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x1431690 Offset: 0x142FC90 VA: 0x181431690 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x1431900 Offset: 0x142FF00 VA: 0x181431900 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x142D8A0 Offset: 0x142BEA0 VA: 0x18142D8A0 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x1430230 Offset: 0x142E830 VA: 0x181430230 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x142DAF0 Offset: 0x142C0F0 VA: 0x18142DAF0 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x142D650 Offset: 0x142BC50 VA: 0x18142D650 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x14306D0 Offset: 0x142ECD0 VA: 0x1814306D0 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x1430480 Offset: 0x142EA80 VA: 0x181430480 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x1430910 Offset: 0x142EF10 VA: 0x181430910 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x142DDA0 Offset: 0x142C3A0 VA: 0x18142DDA0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x142D380 Offset: 0x142B980 VA: 0x18142D380
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x142D4C0 Offset: 0x142BAC0 VA: 0x18142D4C0
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1431840 Offset: 0x142FE40 VA: 0x181431840
	private XPathNavigator ToNavigator(XPathNavigator nav) { }

	// RVA: 0x1431B10 Offset: 0x1430110 VA: 0x181431B10
	private static void .cctor() { }

}

internal class XmlAnyListConverter : XmlListConverter // TypeDefIndex: 2409
{	// Fields
	public static readonly XmlValueConverter ItemList; // 0x0
	public static readonly XmlValueConverter AnyAtomicList; // 0x8

	// Methods

	// RVA: 0x1432240 Offset: 0x1430840 VA: 0x181432240
	protected void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x1431E20 Offset: 0x1430420 VA: 0x181431E20 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x14320B0 Offset: 0x14306B0 VA: 0x1814320B0
	private static void .cctor() { }

}

internal class XmlListConverter : XmlBaseConverter // TypeDefIndex: 2410
{	// Fields
	protected XmlValueConverter atomicConverter; // 0x28

	// Methods

	// RVA: 0x143F9B0 Offset: 0x143DFB0 VA: 0x18143F9B0
	protected void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x143F900 Offset: 0x143DF00 VA: 0x18143F900
	protected void .ctor(XmlBaseConverter atomicConverter, Type clrTypeDefault) { }

	// RVA: 0x143F890 Offset: 0x143DE90 VA: 0x18143F890
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x143EE80 Offset: 0x143D480 VA: 0x18143EE80
	public static XmlValueConverter Create(XmlValueConverter atomicConverter) { }

	// RVA: 0x143EA40 Offset: 0x143D040 VA: 0x18143EA40 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143DAA0 Offset: 0x143C0A0 VA: 0x18143DAA0 Slot: 62
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143F060 Offset: 0x143D660 VA: 0x18143F060
	private bool IsListType(Type type) { }

	// RVA: -1 Offset: -1
	private T[] ToArray<T>(object list, IXmlNamespaceResolver nsResolver) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3BC70 Offset: 0x1A3A270 VA: 0x181A3BC70
	|-XmlListConverter.ToArray<bool>
	|
	|-RVA: 0x1A3C0B0 Offset: 0x1A3A6B0 VA: 0x181A3C0B0
	|-XmlListConverter.ToArray<byte>
	|
	|-RVA: 0x1A3E2B0 Offset: 0x1A3C8B0 VA: 0x181A3E2B0
	|-XmlListConverter.ToArray<byte[]>
	|-XmlListConverter.ToArray<object>
	|-XmlListConverter.ToArray<string>
	|-XmlListConverter.ToArray<Uri>
	|-XmlListConverter.ToArray<XmlAtomicValue>
	|-XmlListConverter.ToArray<XPathItem>
	|-XmlListConverter.ToArray<XPathNavigator>
	|-XmlListConverter.ToArray<XmlQualifiedName>
	|
	|-RVA: 0x1A3C930 Offset: 0x1A3AF30 VA: 0x181A3C930
	|-XmlListConverter.ToArray<DateTime>
	|
	|-RVA: 0x1A3C4F0 Offset: 0x1A3AAF0 VA: 0x181A3C4F0
	|-XmlListConverter.ToArray<DateTimeOffset>
	|
	|-RVA: 0x1A3CD70 Offset: 0x1A3B370 VA: 0x181A3CD70
	|-XmlListConverter.ToArray<Decimal>
	|
	|-RVA: 0x1A3D1B0 Offset: 0x1A3B7B0 VA: 0x181A3D1B0
	|-XmlListConverter.ToArray<double>
	|
	|-RVA: 0x1A3D5F0 Offset: 0x1A3BBF0 VA: 0x181A3D5F0
	|-XmlListConverter.ToArray<short>
	|
	|-RVA: 0x1A3DA30 Offset: 0x1A3C030 VA: 0x181A3DA30
	|-XmlListConverter.ToArray<int>
	|
	|-RVA: 0x1A3DE70 Offset: 0x1A3C470 VA: 0x181A3DE70
	|-XmlListConverter.ToArray<long>
	|
	|-RVA: 0x1A3E6D0 Offset: 0x1A3CCD0 VA: 0x181A3E6D0
	|-XmlListConverter.ToArray<sbyte>
	|
	|-RVA: 0x1A3EB10 Offset: 0x1A3D110 VA: 0x181A3EB10
	|-XmlListConverter.ToArray<float>
	|
	|-RVA: 0x1A3EF50 Offset: 0x1A3D550 VA: 0x181A3EF50
	|-XmlListConverter.ToArray<TimeSpan>
	|
	|-RVA: 0x1A3F390 Offset: 0x1A3D990 VA: 0x181A3F390
	|-XmlListConverter.ToArray<ushort>
	|
	|-RVA: 0x1A3F7D0 Offset: 0x1A3DDD0 VA: 0x181A3F7D0
	|-XmlListConverter.ToArray<uint>
	|
	|-RVA: 0x1A3FC10 Offset: 0x1A3E210 VA: 0x181A3FC10
	|-XmlListConverter.ToArray<ulong>
	*/

	// RVA: 0x143F540 Offset: 0x143DB40 VA: 0x18143F540
	private IList ToList(object list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143F4B0 Offset: 0x143DAB0 VA: 0x18143F4B0
	private List<string> StringAsList(string value) { }

	// RVA: 0x143F250 Offset: 0x143D850 VA: 0x18143F250
	private string ListAsString(IEnumerable list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143EB50 Offset: 0x143D150 VA: 0x18143EB50
	private Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

}

internal class XmlUnionConverter : XmlBaseConverter // TypeDefIndex: 2411
{	// Fields
	private XmlValueConverter[] converters; // 0x28
	private bool hasAtomicMember; // 0x30
	private bool hasListMember; // 0x31

	// Methods

	// RVA: 0xD36160 Offset: 0xD34760 VA: 0x180D36160
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0xD36100 Offset: 0xD34700 VA: 0x180D36100
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0xD35C20 Offset: 0xD34220 VA: 0x180D35C20 Slot: 61
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

	// RVA: 0xD4CC40 Offset: 0xD4B240 VA: 0x180D4CC40
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, XmlSchema schema, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0xD434C0 Offset: 0xD41AC0 VA: 0x180D434C0 Slot: 4
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0xD42F80 Offset: 0xD41580 VA: 0x180D42F80 Slot: 5
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0xD42900 Offset: 0xD40F00 VA: 0x180D42900 Slot: 6
	internal override bool IsContentParsed() { }

	// RVA: 0xD43690 Offset: 0xD41C90 VA: 0x180D43690 Slot: 7
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0xD43470 Offset: 0xD41A70 VA: 0x180D43470 Slot: 8
	internal override void ProcessCData(string value) { }

	// RVA: 0xD44FA0 Offset: 0xD435A0 VA: 0x180D44FA0 Slot: 9
	internal override void StartChildren() { }

	// RVA: 0xD3FA60 Offset: 0xD3E060 VA: 0x180D3FA60 Slot: 10
	internal override void EndChildren() { }

	// RVA: 0xD436A0 Offset: 0xD41CA0 VA: 0x180D436A0
	private void Push() { }

	// RVA: 0xD42EC0 Offset: 0xD414C0 VA: 0x180D42EC0
	private void Pop() { }

	// RVA: 0xD4CE70 Offset: 0xD4B470 VA: 0x180D4CE70
	private SchemaNames.Token get_CurrentElement() { }

	// RVA: 0xD4CF30 Offset: 0xD4B530 VA: 0x180D4CF30
	private SchemaNames.Token get_ParentElement() { }

	// RVA: 0xD4CE90 Offset: 0xD4B490 VA: 0x180D4CE90
	private XmlSchemaObject get_ParentContainer() { }

	// RVA: 0xD3FBA0 Offset: 0xD3E1A0 VA: 0x180D3FBA0
	private XmlSchemaObject GetContainer(XsdBuilder.State state) { }

	// RVA: 0xD44030 Offset: 0xD42630 VA: 0x180D44030
	private void SetContainer(XsdBuilder.State state, object container) { }

	// RVA: 0xD3DCA0 Offset: 0xD3C2A0 VA: 0x180D3DCA0
	private static void BuildAnnotated_Id(XsdBuilder builder, string value) { }

	// RVA: 0xD3F200 Offset: 0xD3D800 VA: 0x180D3F200
	private static void BuildSchema_AttributeFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0xD3F320 Offset: 0xD3D920 VA: 0x180D3F320
	private static void BuildSchema_ElementFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0xD3F440 Offset: 0xD3DA40 VA: 0x180D3F440
	private static void BuildSchema_TargetNamespace(XsdBuilder builder, string value) { }

	// RVA: 0xD3F470 Offset: 0xD3DA70 VA: 0x180D3F470
	private static void BuildSchema_Version(XsdBuilder builder, string value) { }

	// RVA: 0xD3F3D0 Offset: 0xD3D9D0 VA: 0x180D3F3D0
	private static void BuildSchema_FinalDefault(XsdBuilder builder, string value) { }

	// RVA: 0xD3F2B0 Offset: 0xD3D8B0 VA: 0x180D3F2B0
	private static void BuildSchema_BlockDefault(XsdBuilder builder, string value) { }

	// RVA: 0xD41B20 Offset: 0xD40120 VA: 0x180D41B20
	private static void InitSchema(XsdBuilder builder, string value) { }

	// RVA: 0xD418D0 Offset: 0xD3FED0 VA: 0x180D418D0
	private static void InitInclude(XsdBuilder builder, string value) { }

	// RVA: 0xD3F0B0 Offset: 0xD3D6B0 VA: 0x180D3F0B0
	private static void BuildInclude_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0xD41800 Offset: 0xD3FE00 VA: 0x180D41800
	private static void InitImport(XsdBuilder builder, string value) { }

	// RVA: 0xD3F050 Offset: 0xD3D650 VA: 0x180D3F050
	private static void BuildImport_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0xD3F080 Offset: 0xD3D680 VA: 0x180D3F080
	private static void BuildImport_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0xD41A50 Offset: 0xD40050 VA: 0x180D41A50
	private static void InitRedefine(XsdBuilder builder, string value) { }

	// RVA: 0xD3F1D0 Offset: 0xD3D7D0 VA: 0x180D3F1D0
	private static void BuildRedefine_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0xD3FB80 Offset: 0xD3E180 VA: 0x180D3FB80
	private static void EndRedefine(XsdBuilder builder) { }

	// RVA: 0xD40810 Offset: 0xD3EE10 VA: 0x180D40810
	private static void InitAttribute(XsdBuilder builder, string value) { }

	// RVA: 0xD3DFC0 Offset: 0xD3C5C0 VA: 0x180D3DFC0
	private static void BuildAttribute_Default(XsdBuilder builder, string value) { }

	// RVA: 0xD3DFF0 Offset: 0xD3C5F0 VA: 0x180D3DFF0
	private static void BuildAttribute_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0xD3E020 Offset: 0xD3C620 VA: 0x180D3E020
	private static void BuildAttribute_Form(XsdBuilder builder, string value) { }

	// RVA: 0xD3E200 Offset: 0xD3C800 VA: 0x180D3E200
	private static void BuildAttribute_Use(XsdBuilder builder, string value) { }

	// RVA: 0xD3E100 Offset: 0xD3C700 VA: 0x180D3E100
	private static void BuildAttribute_Ref(XsdBuilder builder, string value) { }

	// RVA: 0xD3E0D0 Offset: 0xD3C6D0 VA: 0x180D3E0D0
	private static void BuildAttribute_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD3E180 Offset: 0xD3C780 VA: 0x180D3E180
	private static void BuildAttribute_Type(XsdBuilder builder, string value) { }

	// RVA: 0xD40F60 Offset: 0xD3F560 VA: 0x180D40F60
	private static void InitElement(XsdBuilder builder, string value) { }

	// RVA: 0xD3E810 Offset: 0xD3CE10 VA: 0x180D3E810
	private static void BuildElement_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0xD3E890 Offset: 0xD3CE90 VA: 0x180D3E890
	private static void BuildElement_Block(XsdBuilder builder, string value) { }

	// RVA: 0xD3E900 Offset: 0xD3CF00 VA: 0x180D3E900
	private static void BuildElement_Default(XsdBuilder builder, string value) { }

	// RVA: 0xD3E9D0 Offset: 0xD3CFD0 VA: 0x180D3E9D0
	private static void BuildElement_Form(XsdBuilder builder, string value) { }

	// RVA: 0xD3EC10 Offset: 0xD3D210 VA: 0x180D3EC10
	private static void BuildElement_SubstitutionGroup(XsdBuilder builder, string value) { }

	// RVA: 0xD3E930 Offset: 0xD3CF30 VA: 0x180D3E930
	private static void BuildElement_Final(XsdBuilder builder, string value) { }

	// RVA: 0xD3E9A0 Offset: 0xD3CFA0 VA: 0x180D3E9A0
	private static void BuildElement_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0xD3EA80 Offset: 0xD3D080 VA: 0x180D3EA80
	private static void BuildElement_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0xD3EAB0 Offset: 0xD3D0B0 VA: 0x180D3EAB0
	private static void BuildElement_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0xD3EAE0 Offset: 0xD3D0E0 VA: 0x180D3EAE0
	private static void BuildElement_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD3EB10 Offset: 0xD3D110 VA: 0x180D3EB10
	private static void BuildElement_Nillable(XsdBuilder builder, string value) { }

	// RVA: 0xD3EB90 Offset: 0xD3D190 VA: 0x180D3EB90
	private static void BuildElement_Ref(XsdBuilder builder, string value) { }

	// RVA: 0xD3EC90 Offset: 0xD3D290 VA: 0x180D3EC90
	private static void BuildElement_Type(XsdBuilder builder, string value) { }

	// RVA: 0xD424D0 Offset: 0xD40AD0 VA: 0x180D424D0
	private static void InitSimpleType(XsdBuilder builder, string value) { }

	// RVA: 0xD3F9F0 Offset: 0xD3DFF0 VA: 0x180D3F9F0
	private static void BuildSimpleType_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD3F980 Offset: 0xD3DF80 VA: 0x180D3F980
	private static void BuildSimpleType_Final(XsdBuilder builder, string value) { }

	// RVA: 0xD423B0 Offset: 0xD409B0 VA: 0x180D423B0
	private static void InitSimpleTypeUnion(XsdBuilder builder, string value) { }

	// RVA: 0xD3F7C0 Offset: 0xD3DDC0 VA: 0x180D3F7C0
	private static void BuildSimpleTypeUnion_MemberTypes(XsdBuilder builder, string value) { }

	// RVA: 0xD42110 Offset: 0xD40710 VA: 0x180D42110
	private static void InitSimpleTypeList(XsdBuilder builder, string value) { }

	// RVA: 0xD3F6C0 Offset: 0xD3DCC0 VA: 0x180D3F6C0
	private static void BuildSimpleTypeList_ItemType(XsdBuilder builder, string value) { }

	// RVA: 0xD42250 Offset: 0xD40850 VA: 0x180D42250
	private static void InitSimpleTypeRestriction(XsdBuilder builder, string value) { }

	// RVA: 0xD3F740 Offset: 0xD3DD40 VA: 0x180D3F740
	private static void BuildSimpleTypeRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0xD40CB0 Offset: 0xD3F2B0 VA: 0x180D40CB0
	private static void InitComplexType(XsdBuilder builder, string value) { }

	// RVA: 0xD3E430 Offset: 0xD3CA30 VA: 0x180D3E430
	private static void BuildComplexType_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0xD3E4B0 Offset: 0xD3CAB0 VA: 0x180D3E4B0
	private static void BuildComplexType_Block(XsdBuilder builder, string value) { }

	// RVA: 0xD3E530 Offset: 0xD3CB30 VA: 0x180D3E530
	private static void BuildComplexType_Final(XsdBuilder builder, string value) { }

	// RVA: 0xD3E5A0 Offset: 0xD3CBA0 VA: 0x180D3E5A0
	private static void BuildComplexType_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0xD3E630 Offset: 0xD3CC30 VA: 0x180D3E630
	private static void BuildComplexType_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD40B80 Offset: 0xD3F180 VA: 0x180D40B80
	private static void InitComplexContent(XsdBuilder builder, string value) { }

	// RVA: 0xD3E3B0 Offset: 0xD3C9B0 VA: 0x180D3E3B0
	private static void BuildComplexContent_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0xD409E0 Offset: 0xD3EFE0 VA: 0x180D409E0
	private static void InitComplexContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0xD3E2B0 Offset: 0xD3C8B0 VA: 0x180D3E2B0
	private static void BuildComplexContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0xD40AD0 Offset: 0xD3F0D0 VA: 0x180D40AD0
	private static void InitComplexContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0xD3E330 Offset: 0xD3C930 VA: 0x180D3E330
	private static void BuildComplexContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0xD41FE0 Offset: 0xD405E0 VA: 0x180D41FE0
	private static void InitSimpleContent(XsdBuilder builder, string value) { }

	// RVA: 0xD41CD0 Offset: 0xD402D0 VA: 0x180D41CD0
	private static void InitSimpleContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0xD3F4A0 Offset: 0xD3DAA0 VA: 0x180D3F4A0
	private static void BuildSimpleContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0xD41E40 Offset: 0xD40440 VA: 0x180D41E40
	private static void InitSimpleContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0xD3F5B0 Offset: 0xD3DBB0 VA: 0x180D3F5B0
	private static void BuildSimpleContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0xD406E0 Offset: 0xD3ECE0 VA: 0x180D406E0
	private static void InitAttributeGroup(XsdBuilder builder, string value) { }

	// RVA: 0xD3DF90 Offset: 0xD3C590 VA: 0x180D3DF90
	private static void BuildAttributeGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD40640 Offset: 0xD3EC40 VA: 0x180D40640
	private static void InitAttributeGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0xD3DF10 Offset: 0xD3C510 VA: 0x180D3DF10
	private static void BuildAttributeGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0xD401B0 Offset: 0xD3E7B0 VA: 0x180D401B0
	private static void InitAnyAttribute(XsdBuilder builder, string value) { }

	// RVA: 0xD3DCD0 Offset: 0xD3C2D0 VA: 0x180D3DCD0
	private static void BuildAnyAttribute_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0xD3DD00 Offset: 0xD3C300 VA: 0x180D3DD00
	private static void BuildAnyAttribute_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0xD41590 Offset: 0xD3FB90 VA: 0x180D41590
	private static void InitGroup(XsdBuilder builder, string value) { }

	// RVA: 0xD3EE80 Offset: 0xD3D480 VA: 0x180D3EE80
	private static void BuildGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD414E0 Offset: 0xD3FAE0 VA: 0x180D414E0
	private static void InitGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0xD3F170 Offset: 0xD3D770 VA: 0x180D3F170
	private static void BuildParticle_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0xD3F1A0 Offset: 0xD3D7A0 VA: 0x180D3F1A0
	private static void BuildParticle_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0xD3EE00 Offset: 0xD3D400 VA: 0x180D3EE00
	private static void BuildGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0xD40010 Offset: 0xD3E610 VA: 0x180D40010
	private static void InitAll(XsdBuilder builder, string value) { }

	// RVA: 0xD40930 Offset: 0xD3EF30 VA: 0x180D40930
	private static void InitChoice(XsdBuilder builder, string value) { }

	// RVA: 0xD41C20 Offset: 0xD40220 VA: 0x180D41C20
	private static void InitSequence(XsdBuilder builder, string value) { }

	// RVA: 0xD404C0 Offset: 0xD3EAC0 VA: 0x180D404C0
	private static void InitAny(XsdBuilder builder, string value) { }

	// RVA: 0xD3DDB0 Offset: 0xD3C3B0 VA: 0x180D3DDB0
	private static void BuildAny_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0xD3DDE0 Offset: 0xD3C3E0 VA: 0x180D3DDE0
	private static void BuildAny_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0xD419A0 Offset: 0xD3FFA0 VA: 0x180D419A0
	private static void InitNotation(XsdBuilder builder, string value) { }

	// RVA: 0xD3F0E0 Offset: 0xD3D6E0 VA: 0x180D3F0E0
	private static void BuildNotation_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD3F110 Offset: 0xD3D710 VA: 0x180D3F110
	private static void BuildNotation_Public(XsdBuilder builder, string value) { }

	// RVA: 0xD3F140 Offset: 0xD3D740 VA: 0x180D3F140
	private static void BuildNotation_System(XsdBuilder builder, string value) { }

	// RVA: 0xD410C0 Offset: 0xD3F6C0 VA: 0x180D410C0
	private static void InitFacet(XsdBuilder builder, string value) { }

	// RVA: 0xD3ED10 Offset: 0xD3D310 VA: 0x180D3ED10
	private static void BuildFacet_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0xD3EDA0 Offset: 0xD3D3A0 VA: 0x180D3EDA0
	private static void BuildFacet_Value(XsdBuilder builder, string value) { }

	// RVA: 0xD416C0 Offset: 0xD3FCC0 VA: 0x180D416C0
	private static void InitIdentityConstraint(XsdBuilder builder, string value) { }

	// RVA: 0xD3EEB0 Offset: 0xD3D4B0 VA: 0x180D3EEB0
	private static void BuildIdentityConstraint_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD3EEE0 Offset: 0xD3D4E0 VA: 0x180D3EEE0
	private static void BuildIdentityConstraint_Refer(XsdBuilder builder, string value) { }

	// RVA: 0xD41B50 Offset: 0xD40150 VA: 0x180D41B50
	private static void InitSelector(XsdBuilder builder, string value) { }

	// RVA: 0xD3EDD0 Offset: 0xD3D3D0 VA: 0x180D3EDD0
	private static void BuildSelector_XPath(XsdBuilder builder, string value) { }

	// RVA: 0xD41400 Offset: 0xD3FA00 VA: 0x180D41400
	private static void InitField(XsdBuilder builder, string value) { }

	// RVA: 0xD3EDD0 Offset: 0xD3D3D0 VA: 0x180D3EDD0
	private static void BuildField_XPath(XsdBuilder builder, string value) { }

	// RVA: 0xD400C0 Offset: 0xD3E6C0 VA: 0x180D400C0
	private static void InitAnnotation(XsdBuilder builder, string value) { }

	// RVA: 0xD40570 Offset: 0xD3EB70 VA: 0x180D40570
	private static void InitAppinfo(XsdBuilder builder, string value) { }

	// RVA: 0xD3DE90 Offset: 0xD3C490 VA: 0x180D3DE90
	private static void BuildAppinfo_Source(XsdBuilder builder, string value) { }

	// RVA: 0xD3FA20 Offset: 0xD3E020 VA: 0x180D3FA20
	private static void EndAppinfo(XsdBuilder builder) { }

	// RVA: 0xD40E90 Offset: 0xD3F490 VA: 0x180D40E90
	private static void InitDocumentation(XsdBuilder builder, string value) { }

	// RVA: 0xD3E660 Offset: 0xD3CC60 VA: 0x180D3E660
	private static void BuildDocumentation_Source(XsdBuilder builder, string value) { }

	// RVA: 0xD3E6E0 Offset: 0xD3CCE0 VA: 0x180D3E6E0
	private static void BuildDocumentation_XmlLang(XsdBuilder builder, string value) { }

	// RVA: 0xD3FB40 Offset: 0xD3E140 VA: 0x180D3FB40
	private static void EndDocumentation(XsdBuilder builder) { }

	// RVA: 0xD3D630 Offset: 0xD3BC30 VA: 0x180D3D630
	private void AddAttribute(XmlSchemaObject value) { }

	// RVA: 0xD3D8E0 Offset: 0xD3BEE0 VA: 0x180D3D8E0
	private void AddParticle(XmlSchemaParticle particle) { }

	// RVA: 0xD3FDF0 Offset: 0xD3E3F0 VA: 0x180D3FDF0
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0xD42920 Offset: 0xD40F20 VA: 0x180D42920
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0xD44F10 Offset: 0xD43510 VA: 0x180D44F10
	private void SetMinOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0xD44E80 Offset: 0xD43480 VA: 0x180D44E80
	private void SetMaxOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0xD42C30 Offset: 0xD41230 VA: 0x180D42C30
	private bool ParseBoolean(string value, string attributeName) { }

	// RVA: 0xD42CD0 Offset: 0xD412D0 VA: 0x180D42CD0
	private int ParseEnum(string value, string attributeName, string[] values) { }

	// RVA: 0xD42DC0 Offset: 0xD413C0 VA: 0x180D42DC0
	private XmlQualifiedName ParseQName(string value, string attributeName) { }

	// RVA: 0xD42950 Offset: 0xD40F50 VA: 0x180D42950
	private int ParseBlockFinalEnum(string value, string attributeName) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	private static string ParseUriReference(string s) { }

	// RVA: 0xD43D00 Offset: 0xD42300 VA: 0x180D43D00
	private void SendValidationEvent(string code, string arg0, string arg1, string arg2) { }

	// RVA: 0xD43F30 Offset: 0xD42530 VA: 0x180D43F30
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0xD43B10 Offset: 0xD42110 VA: 0x180D43B10
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0xD43C30 Offset: 0xD42230 VA: 0x180D43C30
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0xD43A50 Offset: 0xD42050 VA: 0x180D43A50
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0xD43980 Offset: 0xD41F80 VA: 0x180D43980
	private void RecordPosition() { }

	// RVA: 0xD45150 Offset: 0xD43750 VA: 0x180D45150
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

	// RVA: 0x1111140 Offset: 0x110F740 VA: 0x181111140 Slot: 12
	public virtual void Invoke(XsdBuilder builder, string value) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
	public virtual IAsyncResult BeginInvoke(XsdBuilder builder, string value, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XsdBuilder.XsdInitFunction : MulticastDelegate // TypeDefIndex: 2415
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1111140 Offset: 0x110F740 VA: 0x181111140 Slot: 12
	public virtual void Invoke(XsdBuilder builder, string value) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
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

	// RVA: 0xC650C0 Offset: 0xC636C0 VA: 0x180C650C0
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

	// RVA: 0x11153B0 Offset: 0x11139B0 VA: 0x1811153B0
	public void .ctor(SchemaNames.Token n, XsdBuilder.State state, XsdBuilder.State[] nextStates, XsdBuilder.XsdAttributeEntry[] attributes, XsdBuilder.XsdInitFunction init, XsdBuilder.XsdEndChildFunction end, bool parseContent) { }

}

private class XsdBuilder.BuilderNamespaceManager : XmlNamespaceManager // TypeDefIndex: 2419
{	// Fields
	private XmlNamespaceManager nsMgr; // 0x50
	private XmlReader reader; // 0x58

	// Methods

	// RVA: 0x10FDDB0 Offset: 0x10FC3B0 VA: 0x1810FDDB0
	public void .ctor(XmlNamespaceManager nsMgr, XmlReader reader) { }

	// RVA: 0x10FDD50 Offset: 0x10FC350 VA: 0x1810FDD50 Slot: 16
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

	// RVA: 0x1AE030 Offset: 0x1AD430 VA: 0x1801AE030
	public void .ctor(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x1ADF90 Offset: 0x1AD390 VA: 0x1801ADF90
	private void .ctor(XsdDateTime.Parser parser) { }

	// RVA: 0x1ADE10 Offset: 0x1AD210 VA: 0x1801ADE10
	private void InitiateXsdDateTime(XsdDateTime.Parser parser) { }

	// RVA: 0x1112690 Offset: 0x1110C90 VA: 0x181112690
	internal static bool TryParse(string text, XsdDateTimeFlags kinds, out XsdDateTime result) { }

	// RVA: 0x1AE1C0 Offset: 0x1AD5C0 VA: 0x1801AE1C0
	public void .ctor(DateTime dateTime, XsdDateTimeFlags kinds) { }

	// RVA: 0x1ADFE0 Offset: 0x1AD3E0 VA: 0x1801ADFE0
	public void .ctor(DateTimeOffset dateTimeOffset) { }

	// RVA: 0x1AE010 Offset: 0x1AD410 VA: 0x1801AE010
	public void .ctor(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds) { }

	// RVA: 0x1AE320 Offset: 0x1AD720 VA: 0x1801AE320
	private XsdDateTime.DateTimeTypeCode get_InternalTypeCode() { }

	// RVA: 0x1AE310 Offset: 0x1AD710 VA: 0x1801AE310
	private XsdDateTime.XsdDateTimeKind get_InternalKind() { }

	// RVA: 0x1AE360 Offset: 0x1AD760 VA: 0x1801AE360
	public int get_Year() { }

	// RVA: 0x1AE340 Offset: 0x1AD740 VA: 0x1801AE340
	public int get_Month() { }

	// RVA: 0x1AE2E0 Offset: 0x1AD6E0 VA: 0x1801AE2E0
	public int get_Day() { }

	// RVA: 0x1AE300 Offset: 0x1AD700 VA: 0x1801AE300
	public int get_Hour() { }

	// RVA: 0x1AE330 Offset: 0x1AD730 VA: 0x1801AE330
	public int get_Minute() { }

	// RVA: 0x1AE350 Offset: 0x1AD750 VA: 0x1801AE350
	public int get_Second() { }

	// RVA: 0x1AE2F0 Offset: 0x1AD6F0 VA: 0x1801AE2F0
	public int get_Fraction() { }

	// RVA: 0x1AE370 Offset: 0x1AD770 VA: 0x1801AE370
	public int get_ZoneHour() { }

	// RVA: 0x14B850 Offset: 0x14AC50 VA: 0x18014B850
	public int get_ZoneMinute() { }

	// RVA: 0x11131F0 Offset: 0x11117F0 VA: 0x1811131F0
	public static DateTime op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x1112FA0 Offset: 0x11115A0 VA: 0x181112FA0
	public static DateTimeOffset op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x1ADF80 Offset: 0x1AD380 VA: 0x1801ADF80 Slot: 3
	public override string ToString() { }

	// RVA: 0x1ADED0 Offset: 0x1AD2D0 VA: 0x1801ADED0
	private void PrintDate(StringBuilder sb) { }

	// RVA: 0x1ADEE0 Offset: 0x1AD2E0 VA: 0x1801ADEE0
	private void PrintTime(StringBuilder sb) { }

	// RVA: 0x1ADEF0 Offset: 0x1AD2F0 VA: 0x1801ADEF0
	private void PrintZone(StringBuilder sb) { }

	// RVA: 0x1ADE50 Offset: 0x1AD250 VA: 0x1801ADE50
	private void IntToCharArray(char[] text, int start, int value, int digits) { }

	// RVA: 0x1ADF00 Offset: 0x1AD300 VA: 0x1801ADF00
	private void ShortToCharArray(char[] text, int start, int value) { }

	// RVA: 0x1112740 Offset: 0x1110D40 VA: 0x181112740
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

	// RVA: 0x1ADCF0 Offset: 0x1AD0F0 VA: 0x1801ADCF0
	public bool Parse(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x1ADC30 Offset: 0x1AD030 VA: 0x1801ADC30
	private bool ParseDate(int start) { }

	// RVA: 0x1ADC80 Offset: 0x1AD080 VA: 0x1801ADC80
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0x1ADC40 Offset: 0x1AD040 VA: 0x1801ADC40
	private bool ParseTimeAndWhitespace(int start) { }

	// RVA: 0x1ADCD0 Offset: 0x1AD0D0 VA: 0x1801ADCD0
	private bool ParseTime(ref int start) { }

	// RVA: 0x1ADCE0 Offset: 0x1AD0E0 VA: 0x1801ADCE0
	private bool ParseZoneAndWhitespace(int start) { }

	// RVA: 0x1ADBE0 Offset: 0x1ACFE0 VA: 0x1801ADBE0
	private bool Parse4Dig(int start, ref int num) { }

	// RVA: 0x1ADBD0 Offset: 0x1ACFD0 VA: 0x1801ADBD0
	private bool Parse2Dig(int start, ref int num) { }

	// RVA: 0x1ADBF0 Offset: 0x1ACFF0 VA: 0x1801ADBF0
	private bool ParseChar(int start, char ch) { }

	// RVA: 0x1103350 Offset: 0x1101950 VA: 0x181103350
	private static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right) { }

	// RVA: 0x1103360 Offset: 0x1101960 VA: 0x181103360
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

	// RVA: 0x1AE490 Offset: 0x1AD890 VA: 0x1801AE490
	public void .ctor(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds) { }

	// RVA: 0x1AE480 Offset: 0x1AD880 VA: 0x1801AE480
	public void .ctor(TimeSpan timeSpan) { }

	// RVA: 0x1AE460 Offset: 0x1AD860 VA: 0x1801AE460
	public void .ctor(TimeSpan timeSpan, XsdDuration.DurationType durationType) { }

	// RVA: 0x1AE470 Offset: 0x1AD870 VA: 0x1801AE470
	public void .ctor(string s) { }

	// RVA: 0x1AE4A0 Offset: 0x1AD8A0 VA: 0x1801AE4A0
	public void .ctor(string s, XsdDuration.DurationType durationType) { }

	// RVA: 0x1AE4C0 Offset: 0x1AD8C0 VA: 0x1801AE4C0
	public bool get_IsNegative() { }

	// RVA: 0xF37A0 Offset: 0xF2BA0 VA: 0x1800F37A0
	public int get_Years() { }

	// RVA: 0x14B860 Offset: 0x14AC60 VA: 0x18014B860
	public int get_Months() { }

	// RVA: 0x122E90 Offset: 0x122290 VA: 0x180122E90
	public int get_Days() { }

	// RVA: 0x1AE4B0 Offset: 0x1AD8B0 VA: 0x1801AE4B0
	public int get_Hours() { }

	// RVA: 0xF3F30 Offset: 0xF3330 VA: 0x1800F3F30
	public int get_Minutes() { }

	// RVA: 0x1AE4E0 Offset: 0x1AD8E0 VA: 0x1801AE4E0
	public int get_Seconds() { }

	// RVA: 0x1AE4D0 Offset: 0x1AD8D0 VA: 0x1801AE4D0
	public int get_Nanoseconds() { }

	// RVA: 0x1AE3D0 Offset: 0x1AD7D0 VA: 0x1801AE3D0
	public TimeSpan ToTimeSpan() { }

	// RVA: 0x1AE3C0 Offset: 0x1AD7C0 VA: 0x1801AE3C0
	public TimeSpan ToTimeSpan(XsdDuration.DurationType durationType) { }

	// RVA: 0x1AE430 Offset: 0x1AD830 VA: 0x1801AE430
	internal Exception TryToTimeSpan(out TimeSpan result) { }

	// RVA: 0x1AE450 Offset: 0x1AD850 VA: 0x1801AE450
	internal Exception TryToTimeSpan(XsdDuration.DurationType durationType, out TimeSpan result) { }

	// RVA: 0x1AE3B0 Offset: 0x1AD7B0 VA: 0x1801AE3B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AE3A0 Offset: 0x1AD7A0 VA: 0x1801AE3A0
	internal string ToString(XsdDuration.DurationType durationType) { }

	// RVA: 0x1114910 Offset: 0x1112F10 VA: 0x181114910
	internal static Exception TryParse(string s, out XsdDuration result) { }

	// RVA: 0x1113CD0 Offset: 0x11122D0 VA: 0x181113CD0
	internal static Exception TryParse(string s, XsdDuration.DurationType durationType, out XsdDuration result) { }

	// RVA: 0x1113B60 Offset: 0x1112160 VA: 0x181113B60
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

	// RVA: 0x111B1F0 Offset: 0x11197F0 VA: 0x18111B1F0
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x111B220 Offset: 0x1119820 VA: 0x18111B220
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x11177A0 Offset: 0x1115DA0 VA: 0x1811177A0
	private void Init() { }

	// RVA: 0x111B060 Offset: 0x1119660 VA: 0x18111B060 Slot: 5
	public override void Validate() { }

	// RVA: 0x1115DE0 Offset: 0x11143E0 VA: 0x181115DE0 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x111B280 Offset: 0x1119880 VA: 0x18111B280
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x1118B40 Offset: 0x1117140 VA: 0x181118B40
	private void ProcessInlineSchema() { }

	// RVA: 0x111A0C0 Offset: 0x11186C0 VA: 0x18111A0C0
	private void ValidateElement() { }

	// RVA: 0x1119E70 Offset: 0x1118470 VA: 0x181119E70
	private object ValidateChildElement() { }

	// RVA: 0x11183B0 Offset: 0x11169B0 VA: 0x1811183B0
	private void ProcessElement(object particle) { }

	// RVA: 0x1119080 Offset: 0x1117680 VA: 0x181119080
	private void ProcessXsiAttributes(out XmlQualifiedName xsiType, out string xsiNil) { }

	// RVA: 0x111A2A0 Offset: 0x11188A0 VA: 0x18111A2A0
	private void ValidateEndElement() { }

	// RVA: 0x1117680 Offset: 0x1115C80 VA: 0x181117680
	private SchemaElementDecl FastGetElementDecl(object particle) { }

	// RVA: 0x11199B0 Offset: 0x1117FB0 VA: 0x1811199B0
	private SchemaElementDecl ThoroughGetElementDecl(SchemaElementDecl elementDecl, XmlQualifiedName xsiType, string xsiNil) { }

	// RVA: 0x111AA20 Offset: 0x1119020 VA: 0x18111AA20
	private void ValidateStartElement() { }

	// RVA: 0x111A5A0 Offset: 0x1118BA0 VA: 0x18111A5A0
	private void ValidateEndStartElement() { }

	// RVA: 0x1117B60 Offset: 0x1116160 VA: 0x181117B60
	private void LoadSchemaFromLocation(string uri, string url) { }

	// RVA: 0x1118130 Offset: 0x1116730 VA: 0x181118130
	private void LoadSchema(string uri, string url) { }

	// RVA: 0x111B260 Offset: 0x1119860 VA: 0x18111B260
	private bool get_HasSchema() { }

	// RVA: 0x111B290 Offset: 0x1119890 VA: 0x18111B290 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x1118E00 Offset: 0x1117400 VA: 0x181118E00
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x1115F20 Offset: 0x1114520 VA: 0x181115F20
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x1115440 Offset: 0x1113A40 VA: 0x181115440
	internal void AddID(string name, object node) { }

	// RVA: 0x1117780 Offset: 0x1115D80 VA: 0x181117780 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x1117B10 Offset: 0x1116110 VA: 0x181117B10
	public bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x1119830 Offset: 0x1117E30 VA: 0x181119830
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x11182F0 Offset: 0x11168F0 VA: 0x1811182F0
	private void Pop() { }

	// RVA: 0x1115DE0 Offset: 0x11143E0 VA: 0x181115DE0
	private void CheckForwardRefs() { }

	// RVA: 0x111A9D0 Offset: 0x1118FD0 VA: 0x18111A9D0
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x111B250 Offset: 0x1119850 VA: 0x18111B250
	private bool get_HasIdentityConstraints() { }

	// RVA: 0x11154F0 Offset: 0x1113AF0 VA: 0x1811154F0
	private void AddIdentityConstraints() { }

	// RVA: 0x1116340 Offset: 0x1114940 VA: 0x181116340
	private void ElementIdentityConstraints() { }

	// RVA: 0x1115A90 Offset: 0x1114090 VA: 0x181115A90
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, SchemaAttDef attdef) { }

	// RVA: 0x1119DF0 Offset: 0x11183F0 VA: 0x181119DF0
	private object UnWrapUnion(object typedValue) { }

	// RVA: 0x1116750 Offset: 0x1114D50 VA: 0x181116750
	private void EndElementIdentityConstraints() { }

	// RVA: 0x111B130 Offset: 0x1119730 VA: 0x18111B130
	private static void .cctor() { }

}

public sealed class XmlReaderSection // TypeDefIndex: 2429
{	// Properties
	internal static bool ProhibitDefaultUrlResolver { get; }
	internal static bool CollapseWhiteSpaceIntoEmptyString { get; }

	// Methods

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	internal static bool get_ProhibitDefaultUrlResolver() { }

	// RVA: 0xE66950 Offset: 0xE64F50 VA: 0x180E66950
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

	// RVA: 0x23EC80 Offset: 0x23E080 VA: 0x18023EC80
	public void set_uniqueID(ulong value) { }

	// RVA: 0xF38D0 Offset: 0xF2CD0 VA: 0x1800F38D0
	public void set_nodeType(XRNode value) { }

	// RVA: 0x23EC70 Offset: 0x23E070 VA: 0x18023EC70
	public void set_tracked(bool value) { }

}

public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor> // TypeDefIndex: 4150
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private static Action<bool> displayFocusChanged; // 0x1351B

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22FBA30 Offset: 0x22FA030 VA: 0x1822FBA30
	private static void InvokeDisplayFocusChanged(bool focus) { }

	// RVA: 0x22FBA90 Offset: 0x22FA090 VA: 0x1822FBA90
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

	// RVA: 0x22FB9F0 Offset: 0x22F9FF0 VA: 0x1822FB9F0
	public void .ctor() { }

}

public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor> // TypeDefIndex: 4154
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private Action<XRInputSubsystem> trackingOriginUpdated; // 0x20
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private Action<XRInputSubsystem> boundaryChanged; // 0x28

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x97860 Offset: 0x96C60 VA: 0x180097860
	// RVA: 0x22FBBC0 Offset: 0x22FA1C0 VA: 0x1822FBBC0
	private static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x97860 Offset: 0x96C60 VA: 0x180097860
	// RVA: 0x22FBB10 Offset: 0x22FA110 VA: 0x1822FBB10
	private static void InvokeBoundaryChangedEvent(IntPtr internalPtr) { }

	// RVA: 0x22FBC70 Offset: 0x22FA270 VA: 0x1822FBC70
	public void .ctor() { }

}

public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor<XRInputSubsystem> // TypeDefIndex: 4155
{	// Methods

	// RVA: 0x22FBAD0 Offset: 0x22FA0D0 VA: 0x1822FBAD0
	public void .ctor() { }

}

public class XRMeshSubsystem : IntegratedSubsystem<XRMeshSubsystemDescriptor> // TypeDefIndex: 4161
{	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22FBCF0 Offset: 0x22FA2F0 VA: 0x1822FBCF0
	private void InvokeMeshReadyDelegate(MeshGenerationResult result, Action<MeshGenerationResult> onMeshGenerationComplete) { }

	// RVA: 0x22FBD60 Offset: 0x22FA360 VA: 0x1822FBD60
	public void .ctor() { }

}

public class XRMeshSubsystemDescriptor : IntegratedSubsystemDescriptor<XRMeshSubsystem> // TypeDefIndex: 4162
{	// Methods

	// RVA: 0x22FBCB0 Offset: 0x22FA2B0 VA: 0x1822FBCB0
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

	// RVA: 0xCD37D0 Offset: 0xCD1DD0 VA: 0x180CD37D0
	internal void .ctor(DataSet ds, bool fInline) { }

	// RVA: 0xCD0F50 Offset: 0xCCF550 VA: 0x180CD0F50
	internal void LoadSchema(XmlElement schemaRoot, DataSet ds) { }

	// RVA: 0xCCECA0 Offset: 0xCCD2A0 VA: 0x180CCECA0
	internal XmlElement FindTypeNode(XmlElement node) { }

	// RVA: 0xCD0B10 Offset: 0xCCF110 VA: 0x180CD0B10
	internal bool IsTextOnlyContent(XmlElement node) { }

	// RVA: 0xCD0C60 Offset: 0xCCF260 VA: 0x180CD0C60
	internal bool IsXDRField(XmlElement node, XmlElement typeNode) { }

	// RVA: 0xCCFFD0 Offset: 0xCCE5D0 VA: 0x180CCFFD0
	internal DataTable HandleTable(XmlElement node) { }

	// RVA: 0xCCEBB0 Offset: 0xCCD1B0 VA: 0x180CCEBB0
	private static XDRSchema.NameType FindNameType(string name) { }

	// RVA: 0xCD1EA0 Offset: 0xCD04A0 VA: 0x180CD1EA0
	private Type ParseDataType(string dt, string dtValues) { }

	// RVA: 0xCCF160 Offset: 0xCCD760 VA: 0x180CCF160
	internal string GetInstanceName(XmlElement node) { }

	// RVA: 0xCCF650 Offset: 0xCCDC50 VA: 0x180CCF650
	internal void HandleColumn(XmlElement node, DataTable table) { }

	// RVA: 0xCCF620 Offset: 0xCCDC20 VA: 0x180CCF620
	internal void GetMinMax(XmlElement elNode, ref int minOccurs, ref int maxOccurs) { }

	// RVA: 0xCCF300 Offset: 0xCCD900 VA: 0x180CCF300
	internal void GetMinMax(XmlElement elNode, bool isAttribute, ref int minOccurs, ref int maxOccurs) { }

	// RVA: 0xCD0160 Offset: 0xCCE760 VA: 0x180CD0160
	internal void HandleTypeNode(XmlElement typeNode, DataTable table, ArrayList tableChildren) { }

	// RVA: 0xCD05B0 Offset: 0xCCEBB0 VA: 0x180CD05B0
	internal DataTable InstantiateTable(DataSet dataSet, XmlElement node, XmlElement typeNode) { }

	// RVA: 0xCD0370 Offset: 0xCCE970 VA: 0x180CD0370
	internal DataTable InstantiateSimpleTable(DataSet dataSet, XmlElement node) { }

	// RVA: 0xCD1FD0 Offset: 0xCD05D0 VA: 0x180CD1FD0
	private static void .cctor() { }

}

private sealed class XDRSchema.NameType : IComparable // TypeDefIndex: 4314
{	// Fields
	public string name; // 0x10
	public Type type; // 0x18

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	public void .ctor(string n, Type t) { }

	// RVA: 0xCBFCE0 Offset: 0xCBE2E0 VA: 0x180CBFCE0 Slot: 4
	public int CompareTo(object obj) { }

}

internal sealed class XMLDiffLoader // TypeDefIndex: 4315
{	// Fields
	private ArrayList _tables; // 0x10
	private DataSet _dataSet; // 0x18
	private DataTable _dataTable; // 0x20

	// Methods

	// RVA: 0xCD3F30 Offset: 0xCD2530 VA: 0x180CD3F30
	internal void LoadDiffGram(DataSet ds, XmlReader dataTextReader) { }

	// RVA: 0xCD3870 Offset: 0xCD1E70 VA: 0x180CD3870
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0xCD3D50 Offset: 0xCD2350 VA: 0x180CD3D50
	internal void LoadDiffGram(DataTable dt, XmlReader dataTextReader) { }

	// RVA: 0xCD43B0 Offset: 0xCD29B0 VA: 0x180CD43B0
	internal void ProcessDiffs(DataSet ds, XmlReader ssync) { }

	// RVA: 0xCD40A0 Offset: 0xCD26A0 VA: 0x180CD40A0
	internal void ProcessDiffs(ArrayList tableList, XmlReader ssync) { }

	// RVA: 0xCD4C40 Offset: 0xCD3240 VA: 0x180CD4C40
	internal void ProcessErrors(DataSet ds, XmlReader ssync) { }

	// RVA: 0xCD4710 Offset: 0xCD2D10 VA: 0x180CD4710
	internal void ProcessErrors(ArrayList dt, XmlReader ssync) { }

	// RVA: 0xCD3B30 Offset: 0xCD2130 VA: 0x180CD3B30
	private DataTable GetTable(string tableName, string ns) { }

	// RVA: 0xCD5010 Offset: 0xCD3610 VA: 0x180CD5010
	private int ReadOldRowData(DataSet ds, ref DataTable table, ref int pos, XmlReader row) { }

	// RVA: 0xCD5D20 Offset: 0xCD4320 VA: 0x180CD5D20
	internal void SkipWhitespaces(XmlReader reader) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal class XMLSchema // TypeDefIndex: 4316
{	// Methods

	// RVA: 0xCD6060 Offset: 0xCD4660 VA: 0x180CD6060
	internal static TypeConverter GetConverter(Type type) { }

	// RVA: 0xCD60C0 Offset: 0xCD46C0 VA: 0x180CD60C0
	internal static void SetProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0xCD5D90 Offset: 0xCD4390 VA: 0x180CD5D90
	internal static bool FEqualIdentity(XmlNode node, string name, string ns) { }

	// RVA: 0xCD5F50 Offset: 0xCD4550 VA: 0x180CD5F50
	internal static bool GetBooleanAttribute(XmlElement element, string attrName, string attrNS, bool defVal) { }

	// RVA: 0xCD5E20 Offset: 0xCD4420 VA: 0x180CD5E20
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

	// RVA: 0xC2B7E0 Offset: 0xC29DE0 VA: 0x180C2B7E0
	internal bool get_FromInference() { }

	// RVA: 0xC2BCC0 Offset: 0xC2A2C0 VA: 0x180C2BCC0
	internal void set_FromInference(bool value) { }

	// RVA: 0xCD7180 Offset: 0xCD5780 VA: 0x180CD7180
	private void CollectElementsAnnotations(XmlSchema schema) { }

	// RVA: 0xCD6820 Offset: 0xCD4E20 VA: 0x180CD6820
	private void CollectElementsAnnotations(XmlSchema schema, ArrayList schemaList) { }

	// RVA: 0xCE7DD0 Offset: 0xCE63D0 VA: 0x180CE7DD0
	internal static string QualifiedName(string name) { }

	// RVA: 0xCE8430 Offset: 0xCE6A30 VA: 0x180CE8430
	internal static void SetProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xCE8080 Offset: 0xCE6680 VA: 0x180CE8080
	private static void SetExtProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xCDA520 Offset: 0xCD8B20 VA: 0x180CDA520
	private void HandleColumnExpression(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xCD8300 Offset: 0xCD6900 VA: 0x180CD8300
	internal static string GetMsdataAttribute(XmlSchemaAnnotated node, string ln) { }

	// RVA: 0xCE7E40 Offset: 0xCE6440 VA: 0x180CE7E40
	private static void SetExtProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0xCDF2D0 Offset: 0xCDD8D0 VA: 0x180CDF2D0
	internal void HandleRefTableProperties(ArrayList RefTables, XmlSchemaElement element) { }

	// RVA: 0xCDF3D0 Offset: 0xCDD9D0 VA: 0x180CDF3D0
	internal void HandleRelation(XmlElement node, bool fNested) { }

	// RVA: 0xCE1240 Offset: 0xCDF840 VA: 0x180CE1240
	private bool HasAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0xCE47B0 Offset: 0xCE2DB0 VA: 0x180CE47B0
	private bool IsDatasetParticle(XmlSchemaParticle pt) { }

	// RVA: 0xCD7210 Offset: 0xCD5810 VA: 0x180CD7210
	private int DatasetElementCount(XmlSchemaObjectCollection elements) { }

	// RVA: 0xCD73B0 Offset: 0xCD59B0 VA: 0x180CD73B0
	private XmlSchemaElement FindDatasetElement(XmlSchemaObjectCollection elements) { }

	// RVA: 0xCE7AD0 Offset: 0xCE60D0 VA: 0x180CE7AD0
	public void LoadSchema(XmlSchemaSet schemaSet, DataTable dt) { }

	// RVA: 0xCE52F0 Offset: 0xCE38F0 VA: 0x180CE52F0
	public void LoadSchema(XmlSchemaSet schemaSet, DataSet ds) { }

	// RVA: 0xCDFCA0 Offset: 0xCDE2A0 VA: 0x180CDFCA0
	private void HandleRelations(XmlSchemaAnnotation ann, bool fNested) { }

	// RVA: 0xCD8730 Offset: 0xCD6D30 VA: 0x180CD8730
	internal XmlSchemaObjectCollection GetParticleItems(XmlSchemaParticle pt) { }

	// RVA: 0xCDE390 Offset: 0xCDC990 VA: 0x180CDE390
	internal void HandleParticle(XmlSchemaParticle pt, DataTable table, ArrayList tableChildren, bool isBase) { }

	// RVA: 0xCDA270 Offset: 0xCD8870 VA: 0x180CDA270
	internal void HandleAttributes(XmlSchemaObjectCollection attributes, DataTable table, bool isBase) { }

	// RVA: 0xCD9ED0 Offset: 0xCD84D0 VA: 0x180CD9ED0
	private void HandleAttributeGroup(XmlSchemaAttributeGroup attributeGroup, DataTable table, bool isBase) { }

	// RVA: 0xCDA740 Offset: 0xCD8D40 VA: 0x180CDA740
	internal void HandleComplexType(XmlSchemaComplexType ct, DataTable table, ArrayList tableChildren, bool isNillable) { }

	// RVA: 0xCD8B70 Offset: 0xCD7170 VA: 0x180CD8B70
	internal XmlSchemaParticle GetParticle(XmlSchemaComplexType ct) { }

	// RVA: 0xCD7960 Offset: 0xCD5F60 VA: 0x180CD7960
	internal DataColumn FindField(DataTable table, string field) { }

	// RVA: 0xCD65F0 Offset: 0xCD4BF0 VA: 0x180CD65F0
	internal DataColumn[] BuildKey(XmlSchemaIdentityConstraint keyNode, DataTable table) { }

	// RVA: 0xCD8080 Offset: 0xCD6680 VA: 0x180CD8080
	internal bool GetBooleanAttribute(XmlSchemaAnnotated element, string attrName, bool defVal) { }

	// RVA: 0xCD90C0 Offset: 0xCD76C0 VA: 0x180CD90C0
	internal string GetStringAttribute(XmlSchemaAnnotated element, string attrName, string defVal) { }

	// RVA: 0xCE8910 Offset: 0xCE6F10 VA: 0x180CE8910
	internal static AcceptRejectRule TranslateAcceptRejectRule(string strRule) { }

	// RVA: 0xCE8970 Offset: 0xCE6F70 VA: 0x180CE8970
	internal static Rule TranslateRule(string strRule) { }

	// RVA: 0xCDDAA0 Offset: 0xCDC0A0 VA: 0x180CDDAA0
	internal void HandleKeyref(XmlSchemaKeyref keyref) { }

	// RVA: 0xCDB040 Offset: 0xCD9640 VA: 0x180CDB040
	internal void HandleConstraint(XmlSchemaIdentityConstraint keyNode) { }

	// RVA: 0xCE1480 Offset: 0xCDFA80 VA: 0x180CE1480
	internal DataTable InstantiateSimpleTable(XmlSchemaElement node) { }

	// RVA: 0xCD81A0 Offset: 0xCD67A0 VA: 0x180CD81A0
	internal string GetInstanceName(XmlSchemaAnnotated node) { }

	// RVA: 0xCE2400 Offset: 0xCE0A00 VA: 0x180CE2400
	internal DataTable InstantiateTable(XmlSchemaElement node, XmlSchemaComplexType typeNode, bool isRef) { }

	// RVA: 0xCE8A20 Offset: 0xCE7020 VA: 0x180CE8A20
	public static Type XsdtoClr(string xsdTypeName) { }

	// RVA: 0xCD7B40 Offset: 0xCD6140 VA: 0x180CD7B40
	private static XSDSchema.NameType FindNameType(string name) { }

	// RVA: 0xCE7B00 Offset: 0xCE6100 VA: 0x180CE7B00
	private Type ParseDataType(string dt) { }

	// RVA: 0xCE5280 Offset: 0xCE3880 VA: 0x180CE5280
	internal static bool IsXsdType(string name) { }

	// RVA: 0xCD7C30 Offset: 0xCD6230 VA: 0x180CD7C30
	internal XmlSchemaAnnotated FindTypeNode(XmlSchemaAnnotated node) { }

	// RVA: 0xCE06F0 Offset: 0xCDECF0 VA: 0x180CE06F0
	internal void HandleSimpleTypeSimpleContentColumn(XmlSchemaSimpleType typeNode, string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0xCDFF90 Offset: 0xCDE590 VA: 0x180CDFF90
	internal void HandleSimpleContentColumn(string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0xCD9440 Offset: 0xCD7A40 VA: 0x180CD9440
	internal void HandleAttributeColumn(XmlSchemaAttribute attrib, DataTable table, bool isBase) { }

	// RVA: 0xCDCA50 Offset: 0xCDB050 VA: 0x180CDCA50
	internal void HandleElementColumn(XmlSchemaElement elem, DataTable table, bool isBase) { }

	// RVA: 0xCDB520 Offset: 0xCD9B20 VA: 0x180CDB520
	internal void HandleDataSet(XmlSchemaElement node, bool isNewDataSet) { }

	// RVA: 0xCD6480 Offset: 0xCD4A80 VA: 0x180CD6480
	private void AddTablesToList(List<DataTable> tableList, DataTable dt) { }

	// RVA: 0xCD8DF0 Offset: 0xCD73F0 VA: 0x180CD8DF0
	private string GetPrefix(string ns) { }

	// RVA: 0xCD8450 Offset: 0xCD6A50 VA: 0x180CD8450
	private string GetNamespaceFromPrefix(string prefix) { }

	// RVA: 0xCD9280 Offset: 0xCD7880 VA: 0x180CD9280
	private string GetTableNamespace(XmlSchemaIdentityConstraint key) { }

	// RVA: 0xCD9140 Offset: 0xCD7740 VA: 0x180CD9140
	private string GetTableName(XmlSchemaIdentityConstraint key) { }

	// RVA: 0xCE4F60 Offset: 0xCE3560 VA: 0x180CE4F60
	internal bool IsTable(XmlSchemaElement node) { }

	// RVA: 0xCE1080 Offset: 0xCDF680 VA: 0x180CE1080
	internal DataTable HandleTable(XmlSchemaElement node) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xCE8B20 Offset: 0xCE7120 VA: 0x180CE8B20
	private static void .cctor() { }

}

private sealed class XSDSchema.NameType : IComparable // TypeDefIndex: 4319
{	// Fields
	public readonly string name; // 0x10
	public readonly Type type; // 0x18

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	public void .ctor(string n, Type t) { }

	// RVA: 0x1AC68E0 Offset: 0x1AC4EE0 VA: 0x181AC68E0 Slot: 4
	public int CompareTo(object obj) { }

}

internal sealed class XmlIgnoreNamespaceReader : XmlNodeReader // TypeDefIndex: 4320
{	// Fields
	private List<string> _namespacesToIgnore; // 0x30

	// Methods

	// RVA: 0x1AD07F0 Offset: 0x1ACEDF0 VA: 0x181AD07F0
	internal void .ctor(XmlDocument xdoc, string[] namespacesToIgnore) { }

	// RVA: 0x1AD0600 Offset: 0x1ACEC00 VA: 0x181AD0600 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1AD0700 Offset: 0x1ACED00 VA: 0x181AD0700 Slot: 28
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

	// RVA: 0x1ACD460 Offset: 0x1ACBA60 VA: 0x181ACD460
	internal void .ctor(DataSet dataset, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0x1ACD5C0 Offset: 0x1ACBBC0 VA: 0x181ACD5C0
	internal void .ctor(DataSet dataset, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0x1ACD500 Offset: 0x1ACBB00 VA: 0x181ACD500
	internal void .ctor(DataTable datatable, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0x1ACD370 Offset: 0x1ACB970 VA: 0x181ACD370
	internal void .ctor(DataTable datatable, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0xAF5CE0 Offset: 0xAF42E0 VA: 0x180AF5CE0
	internal bool get_FromInference() { }

	// RVA: 0xFFF7E0 Offset: 0xFFDDE0 VA: 0x180FFF7E0
	internal void set_FromInference(bool value) { }

	// RVA: 0x1AC6A00 Offset: 0x1AC5000 VA: 0x181AC6A00
	private void AttachRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0x1AC6B80 Offset: 0x1AC5180 VA: 0x181AC6B80
	private int CountNonNSAttributes(XmlNode node) { }

	// RVA: 0x1AC7660 Offset: 0x1AC5C60 VA: 0x181AC7660
	private string GetValueForTextOnlyColums(XmlNode n) { }

	// RVA: 0x1AC71F0 Offset: 0x1AC57F0 VA: 0x181AC71F0
	private string GetInitialTextFromNodes(ref XmlNode n) { }

	// RVA: 0x1AC75B0 Offset: 0x1AC5BB0 VA: 0x181AC75B0
	private DataColumn GetTextOnlyColumn(DataRow row) { }

	// RVA: 0x1AC7500 Offset: 0x1AC5B00 VA: 0x181AC7500
	internal DataRow GetRowFromElement(XmlElement e) { }

	// RVA: 0x1AC6D10 Offset: 0x1AC5310 VA: 0x181AC6D10
	internal bool FColumnElement(XmlElement e) { }

	// RVA: 0x1AC6F70 Offset: 0x1AC5570 VA: 0x181AC6F70
	private bool FExcludedNamespace(string ns) { }

	// RVA: 0x1AC7090 Offset: 0x1AC5690 VA: 0x181AC7090
	private bool FIgnoreNamespace(XmlNode node) { }

	// RVA: 0x1AC7000 Offset: 0x1AC5600 VA: 0x181AC7000
	private bool FIgnoreNamespace(XmlReader node) { }

	// RVA: 0x1AC7BD0 Offset: 0x1AC61D0 VA: 0x181AC7BD0
	internal bool IsTextLikeNode(XmlNodeType n) { }

	// RVA: 0x1AC7C30 Offset: 0x1AC6230 VA: 0x181AC7C30
	internal bool IsTextOnly(DataColumn c) { }

	// RVA: 0x1AC8680 Offset: 0x1AC6C80 VA: 0x181AC8680
	internal void LoadData(XmlDocument xdoc) { }

	// RVA: 0x1AC8D40 Offset: 0x1AC7340 VA: 0x181AC8D40
	private void LoadRowData(DataRow row, XmlElement rowElement) { }

	// RVA: 0x1ACA4E0 Offset: 0x1AC8AE0 VA: 0x181ACA4E0
	private void LoadRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0x1ACD320 Offset: 0x1ACB920 VA: 0x181ACD320
	private void SetRowValueFromXmlText(DataRow row, DataColumn col, string xmlText) { }

	// RVA: 0x1AC7960 Offset: 0x1AC5F60 VA: 0x181AC7960
	private void InitNameTable() { }

	// RVA: 0x1AC8960 Offset: 0x1AC6F60 VA: 0x181AC8960
	internal void LoadData(XmlReader reader) { }

	// RVA: 0x1ACC260 Offset: 0x1ACA860 VA: 0x181ACC260
	private void LoadTopMostTable(DataTable table) { }

	// RVA: 0x1ACB400 Offset: 0x1AC9A00 VA: 0x181ACB400
	private void LoadTable(DataTable table, bool isNested) { }

	// RVA: 0x1AC7C60 Offset: 0x1AC6260 VA: 0x181AC7C60
	private void LoadColumn(DataColumn column, object[] foundColumns) { }

	// RVA: 0x1ACD0D0 Offset: 0x1ACB6D0 VA: 0x181ACD0D0
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

	// RVA: 0x1AD4310 Offset: 0x1AD2910 VA: 0x181AD4310
	public void .ctor(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0x1AD4250 Offset: 0x1AD2850 VA: 0x181AD4250
	public void .ctor(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0x1AD42D0 Offset: 0x1AD28D0 VA: 0x181AD42D0
	public void .ctor(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0x1AD4290 Offset: 0x1AD2890 VA: 0x181AD4290
	public void .ctor(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0x1AD4220 Offset: 0x1AD2820 VA: 0x181AD4220
	internal static bool IsMappedColumn(DataColumn c) { }

	// RVA: 0x1AD1140 Offset: 0x1ACF740 VA: 0x181AD1140
	private XmlToDatasetMap.TableSchemaInfo AddTableSchema(DataTable table, XmlNameTable nameTable) { }

	// RVA: 0x1AD0F90 Offset: 0x1ACF590 VA: 0x181AD0F90
	private XmlToDatasetMap.TableSchemaInfo AddTableSchema(XmlNameTable nameTable, DataTable table) { }

	// RVA: 0x1AD0C40 Offset: 0x1ACF240 VA: 0x181AD0C40
	private bool AddColumnSchema(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

	// RVA: 0x1AD0DA0 Offset: 0x1ACF3A0 VA: 0x181AD0DA0
	private bool AddColumnSchema(XmlNameTable nameTable, DataColumn col, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

	// RVA: 0x1AD1280 Offset: 0x1ACF880 VA: 0x181AD1280
	private void BuildIdentityMap(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0x1AD2600 Offset: 0x1AD0C00 VA: 0x181AD2600
	private void BuildIdentityMap(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0x1AD3220 Offset: 0x1AD1820 VA: 0x181AD3220
	private void BuildIdentityMap(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0x1AD1A10 Offset: 0x1AD0010 VA: 0x181AD1A10
	private void BuildIdentityMap(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0x1AD3C70 Offset: 0x1AD2270 VA: 0x181AD3C70
	private ArrayList GetSelfAndDescendants(DataTable dt) { }

	// RVA: 0x1AD3880 Offset: 0x1AD1E80 VA: 0x181AD3880
	public object GetColumnSchema(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0x1AD36D0 Offset: 0x1AD1CD0 VA: 0x181AD36D0
	public object GetColumnSchema(DataTable table, XmlReader dataReader, bool fIgnoreNamespace) { }

	// RVA: 0x1AD3B70 Offset: 0x1AD2170 VA: 0x181AD3B70
	public object GetSchemaForNode(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0x1AD3FB0 Offset: 0x1AD25B0 VA: 0x181AD3FB0
	public DataTable GetTableForNode(XmlReader node, bool fIgnoreNamespace) { }

	// RVA: 0x1AD40A0 Offset: 0x1AD26A0 VA: 0x181AD40A0
	private void HandleSpecialColumn(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

}

private sealed class XmlToDatasetMap.XmlNodeIdentety // TypeDefIndex: 4324
{	// Fields
	public string LocalName; // 0x10
	public string NamespaceURI; // 0x18

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	public void .ctor(string localName, string namespaceURI) { }

	// RVA: 0xDE1FA0 Offset: 0xDE05A0 VA: 0x180DE1FA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AD0B90 Offset: 0x1ACF190 VA: 0x181AD0B90 Slot: 0
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

	// RVA: 0x1AD0870 Offset: 0x1ACEE70 VA: 0x181AD0870
	public void .ctor(int capacity) { }

	// RVA: 0x1AD0A50 Offset: 0x1ACF050 VA: 0x181AD0A50
	public object get_Item(XmlNode node) { }

	// RVA: 0x1AD0AF0 Offset: 0x1ACF0F0 VA: 0x181AD0AF0
	public object get_Item(XmlReader dataReader) { }

	// RVA: 0x1AD09C0 Offset: 0x1ACEFC0 VA: 0x181AD09C0
	public object get_Item(DataTable table) { }

	// RVA: 0x1AD0920 Offset: 0x1ACEF20 VA: 0x181AD0920
	public object get_Item(string name) { }

}

private sealed class XmlToDatasetMap.TableSchemaInfo // TypeDefIndex: 4326
{	// Fields
	public DataTable TableSchema; // 0x10
	public XmlToDatasetMap.XmlNodeIdHashtable ColumnsSchemaMap; // 0x18

	// Methods

	// RVA: 0x1AC6950 Offset: 0x1AC4F50 VA: 0x181AC6950
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

	// RVA: 0x1AE10B0 Offset: 0x1ADF6B0 VA: 0x181AE10B0
	internal void .ctor(SchemaFormat format) { }

	// RVA: 0x1AD4900 Offset: 0x1AD2F00 VA: 0x181AD4900
	internal static void AddExtendedProperties(PropertyCollection props, XmlElement node) { }

	// RVA: 0x1AD4910 Offset: 0x1AD2F10 VA: 0x181AD4910
	internal static void AddExtendedProperties(PropertyCollection props, XmlElement node, Type type) { }

	// RVA: 0x1AD4E40 Offset: 0x1AD3440 VA: 0x181AD4E40
	internal void AddXdoProperties(object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0x1AD5010 Offset: 0x1AD3610 VA: 0x181AD5010
	internal void AddXdoProperty(PropertyDescriptor pd, object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0x1AE0490 Offset: 0x1ADEA90 VA: 0x181AE0490
	internal static string XmlDataTypeName(Type type) { }

	// RVA: 0x1AD7730 Offset: 0x1AD5D30 VA: 0x181AD7730
	private void GenerateConstraintNames(DataTable table, bool fromTable) { }

	// RVA: 0x1AD7430 Offset: 0x1AD5A30 VA: 0x181AD7430
	private void GenerateConstraintNames(ArrayList tables) { }

	// RVA: 0x1AD7530 Offset: 0x1AD5B30 VA: 0x181AD7530
	private void GenerateConstraintNames(DataSet ds) { }

	// RVA: 0x1AE1080 Offset: 0x1ADF680 VA: 0x181AE1080
	private static bool _PropsNotEmpty(PropertyCollection props) { }

	// RVA: 0x1ADBCD0 Offset: 0x1ADA2D0 VA: 0x181ADBCD0
	private bool HaveExtendedProperties(DataSet ds) { }

	// RVA: 0x1AE0300 Offset: 0x1ADE900 VA: 0x181AE0300
	internal void WriteSchemaRoot(XmlDocument xd, XmlElement rootSchema, string targetNamespace) { }

	// RVA: 0x1AE0290 Offset: 0x1ADE890 VA: 0x181AE0290
	internal static void ValidateColumnMapping(Type columnType) { }

	// RVA: 0x1ADF210 Offset: 0x1ADD810 VA: 0x181ADF210
	internal void SetupAutoGenerated(DataSet ds) { }

	// RVA: 0x1ADF410 Offset: 0x1ADDA10 VA: 0x181ADF410
	internal void SetupAutoGenerated(ArrayList dt) { }

	// RVA: 0x1ADF510 Offset: 0x1ADDB10 VA: 0x181ADF510
	internal void SetupAutoGenerated(DataTable dt) { }

	// RVA: 0x1AD6460 Offset: 0x1AD4A60 VA: 0x181AD6460
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0x1AD61E0 Offset: 0x1AD47E0 VA: 0x181AD61E0
	private void CreateRelations(DataTable dt) { }

	// RVA: 0x1AD6720 Offset: 0x1AD4D20 VA: 0x181AD6720
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0x1ADC6F0 Offset: 0x1ADACF0 VA: 0x181ADC6F0
	internal void SchemaTree(XmlDocument xd, XmlWriter xmlWriter, DataSet ds, DataTable dt, bool writeHierarchy) { }

	// RVA: 0x1ADC250 Offset: 0x1ADA850 VA: 0x181ADC250
	internal XmlElement SchemaTree(XmlDocument xd, DataTable dt) { }

	// RVA: 0x1AD69E0 Offset: 0x1AD4FE0 VA: 0x181AD69E0
	internal XmlElement FillDataSetElement(XmlDocument xd, DataSet ds, DataTable dt) { }

	// RVA: 0x1ADF020 Offset: 0x1ADD620 VA: 0x181ADF020
	internal void SetPath(XmlWriter xw) { }

	// RVA: 0x1ADBED0 Offset: 0x1ADA4D0 VA: 0x181ADBED0
	internal void Save(DataSet ds, XmlWriter xw) { }

	// RVA: 0x1ADC050 Offset: 0x1ADA650 VA: 0x181ADC050
	internal void Save(DataTable dt, XmlWriter xw) { }

	// RVA: 0x1ADBF00 Offset: 0x1ADA500 VA: 0x181ADBF00
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw) { }

	// RVA: 0x1ADBF20 Offset: 0x1ADA520 VA: 0x181ADBF20
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy) { }

	// RVA: 0x1ADC120 Offset: 0x1ADA720 VA: 0x181ADC120
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy, Converter<Type, string> multipleTargetConverter) { }

	// RVA: 0x1AD8C40 Offset: 0x1AD7240 VA: 0x181AD8C40
	internal XmlElement HandleRelation(DataRelation rel, XmlDocument dc) { }

	// RVA: 0x1AD6FE0 Offset: 0x1AD55E0 VA: 0x181AD6FE0
	private static XmlElement FindSimpleType(XmlElement schema, string name) { }

	// RVA: 0x1AD7B70 Offset: 0x1AD6170 VA: 0x181AD7B70
	internal XmlElement GetSchema(string NamespaceURI) { }

	// RVA: 0x1AD7DD0 Offset: 0x1AD63D0 VA: 0x181AD7DD0
	internal void HandleColumnType(DataColumn col, XmlDocument dc, XmlElement root, XmlElement schema) { }

	// RVA: 0x1AD4350 Offset: 0x1AD2950 VA: 0x181AD4350
	internal void AddColumnProperties(DataColumn col, XmlElement root) { }

	// RVA: 0x1AD7130 Offset: 0x1AD5730 VA: 0x181AD7130
	private string FindTargetNamespace(DataTable table) { }

	// RVA: 0x1AD8240 Offset: 0x1AD6840 VA: 0x181AD8240
	internal XmlElement HandleColumn(DataColumn col, XmlDocument dc, XmlElement schema, bool fWriteOrdinal) { }

	// RVA: 0x1AE01C0 Offset: 0x1ADE7C0 VA: 0x181AE01C0
	internal static string TranslateAcceptRejectRule(AcceptRejectRule rule) { }

	// RVA: 0x1AE0210 Offset: 0x1ADE810 VA: 0x181AE0210
	internal static string TranslateRule(Rule rule) { }

	// RVA: 0x1AD58F0 Offset: 0x1AD3EF0 VA: 0x181AD58F0
	internal void AppendChildWithoutRef(XmlElement node, string Namespace, XmlElement el, string refString) { }

	// RVA: 0x1AD7260 Offset: 0x1AD5860 VA: 0x181AD7260
	internal XmlElement FindTypeNode(XmlElement node, string strType) { }

	// RVA: 0x1AD91E0 Offset: 0x1AD77E0 VA: 0x181AD91E0
	internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema) { }

	// RVA: 0x1ADBA70 Offset: 0x1ADA070 VA: 0x181ADBA70
	private bool HasMixedColumns(DataTable table) { }

	// RVA: 0x1AD5CC0 Offset: 0x1AD42C0 VA: 0x181AD5CC0
	internal static bool AutoGenerated(DataColumn col) { }

	// RVA: 0x1AD60D0 Offset: 0x1AD46D0 VA: 0x181AD60D0
	internal static bool AutoGenerated(DataRelation rel) { }

	// RVA: 0x1AD59A0 Offset: 0x1AD3FA0 VA: 0x181AD59A0
	internal static bool AutoGenerated(UniqueConstraint unique) { }

	// RVA: 0x1AD60C0 Offset: 0x1AD46C0 VA: 0x181AD60C0
	private bool AutoGenerated(ForeignKeyConstraint fk) { }

	// RVA: 0x1AD5A80 Offset: 0x1AD4080 VA: 0x181AD5A80
	internal static bool AutoGenerated(ForeignKeyConstraint fk, bool checkRelation) { }

	// RVA: 0x1ADBE90 Offset: 0x1ADA490 VA: 0x181ADBE90
	private bool IsAutoGenerated(object o) { }

	// RVA: 0x1AD9200 Offset: 0x1AD7800 VA: 0x181AD9200
	internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema, bool genNested) { }

	// RVA: 0x1ADEE70 Offset: 0x1ADD470 VA: 0x181ADEE70
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

	// RVA: 0x1AD0170 Offset: 0x1ACE770 VA: 0x181AD0170
	internal void .ctor(DataSet ds) { }

	// RVA: 0x1AD03F0 Offset: 0x1ACE9F0 VA: 0x181AD03F0
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0x1ACD960 Offset: 0x1ACBF60 VA: 0x181ACD960
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0x1ACD6A0 Offset: 0x1ACBCA0 VA: 0x181ACD6A0
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0x1ACDF40 Offset: 0x1ACC540 VA: 0x181ACDF40
	internal static bool RowHasErrors(DataRow row) { }

	// RVA: 0x1ACE020 Offset: 0x1ACC620 VA: 0x181ACE020
	internal void SaveDiffgramData(XmlWriter xw, Hashtable rowsOrder) { }

	// RVA: 0x1ACE5B0 Offset: 0x1ACCBB0 VA: 0x181ACE5B0
	internal void Save(XmlWriter xw, bool writeSchema) { }

	// RVA: 0x1ACDC20 Offset: 0x1ACC220 VA: 0x181ACDC20
	private ArrayList GetNestedChildRelations(DataRow row) { }

	// RVA: 0x1ACEE30 Offset: 0x1ACD430 VA: 0x181ACEE30
	internal void XmlDataRowWriter(DataRow row, string encodedTableName) { }

	// RVA: 0x1ACDE90 Offset: 0x1ACC490 VA: 0x181ACDE90
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

	// RVA: 0xCCC520 Offset: 0xCCAB20 VA: 0x180CCC520
	public void .ctor() { }

	// RVA: 0xCCBC00 Offset: 0xCCA200 VA: 0x180CCBC00
	public XmlReader CreateReader() { }

	// RVA: 0xCCBE80 Offset: 0xCCA480 VA: 0x180CCBE80
	internal static XmlReader CreateSqlXmlReader(Stream stream, bool closeInput = False, bool throwTargetInvocationExceptions = False) { }

	// RVA: 0xCCBDB0 Offset: 0xCCA3B0 VA: 0x180CCBDB0
	private static Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> CreateSqlReaderDelegate() { }

	// RVA: 0xCCC550 Offset: 0xCCAB50 VA: 0x180CCC550
	private static MethodInfo get_CreateSqlReaderMethodInfo() { }

	// RVA: 0xCCA770 Offset: 0xCC8D70 VA: 0x180CCA770 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0xCCC070 Offset: 0xCCA670 VA: 0x180CCC070
	private void SetNull() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xCCC0A0 Offset: 0xCCA6A0 VA: 0x180CCC0A0 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0xCCC260 Offset: 0xCCA860 VA: 0x180CCC260 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xCCC010 Offset: 0xCCA610 VA: 0x180CCC010
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCCC370 Offset: 0xCCA970 VA: 0x180CCC370
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

	// RVA: 0xCCB900 Offset: 0xCC9F00 VA: 0x180CCB900
	internal void .ctor(Stream stream) { }

	// RVA: 0xCCB980 Offset: 0xCC9F80 VA: 0x180CCB980 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0xCCB9D0 Offset: 0xCC9FD0 VA: 0x180CCB9D0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0xCCBA20 Offset: 0xCCA020 VA: 0x180CCBA20 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0xCCBA70 Offset: 0xCCA070 VA: 0x180CCBA70 Slot: 10
	public override long get_Length() { }

	// RVA: 0xCCBAE0 Offset: 0xCCA0E0 VA: 0x180CCBAE0 Slot: 11
	public override long get_Position() { }

	// RVA: 0xCCBB40 Offset: 0xCCA140 VA: 0x180CCBB40 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0xCCB150 Offset: 0xCC9750 VA: 0x180CCB150 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xCCAF70 Offset: 0xCC9570 VA: 0x180CCAF70 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0xCCB730 Offset: 0xCC9D30 VA: 0x180CCB730 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0xCCAE40 Offset: 0xCC9440 VA: 0x180CCAE40 Slot: 28
	public override int ReadByte() { }

	// RVA: 0xCCB650 Offset: 0xCC9C50 VA: 0x180CCB650 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0xCCB360 Offset: 0xCC9960 VA: 0x180CCB360 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0xCCADA0 Offset: 0xCC93A0 VA: 0x180CCADA0 Slot: 18
	public override void Flush() { }

	// RVA: 0xCCAD30 Offset: 0xCC9330 VA: 0x180CCAD30 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0xCCB490 Offset: 0xCC9A90 VA: 0x180CCB490
	private void ThrowIfStreamCannotSeek(string method) { }

	// RVA: 0xCCB3F0 Offset: 0xCC99F0 VA: 0x180CCB3F0
	private void ThrowIfStreamCannotRead(string method) { }

	// RVA: 0xCCB530 Offset: 0xCC9B30 VA: 0x180CCB530
	private void ThrowIfStreamCannotWrite(string method) { }

	// RVA: 0xCCB5D0 Offset: 0xCC9BD0 VA: 0x180CCB5D0
	private void ThrowIfStreamClosed(string method) { }

	// RVA: 0xCCADC0 Offset: 0xCC93C0 VA: 0x180CCADC0
	private bool IsStreamClosed() { }

}

public static class XRDevice // TypeDefIndex: 4768
{
// Namespace: 
internal class <Module> // TypeDefIndex: 4767

// Namespace: UnityEngine.XR
[NativeConditionalAttribute] // RVA: 0xC1B60 Offset: 0xC0F60 VA: 0x1800C1B60
public static class XRDevice // TypeDefIndex: 4768
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private static Action<string> deviceLoaded; // 0x1365D

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2322820 Offset: 0x2320E20 VA: 0x182322820
	private static void InvokeDeviceLoaded(string loadedDeviceName) { }

	// RVA: 0x23228D0 Offset: 0x2320ED0 VA: 0x1823228D0
	private static void .cctor() { }

}

public sealed class XName : IEquatable<XName>, ISerializable // TypeDefIndex: 5815
{
// Namespace: 
internal class <Module> // TypeDefIndex: 5814

// Namespace: System.Xml.Linq
[KnownTypeAttribute] // RVA: 0xE0DD0 Offset: 0xE01D0 VA: 0x1800E0DD0
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

	// RVA: 0x221EA00 Offset: 0x221D000 VA: 0x18221EA00
	internal void .ctor(XNamespace ns, string localName) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_LocalName() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public XNamespace get_Namespace() { }

	// RVA: 0xB28B30 Offset: 0xB27130 VA: 0x180B28B30
	public string get_NamespaceName() { }

	// RVA: 0x221E980 Offset: 0x221CF80 VA: 0x18221E980 Slot: 3
	public override string ToString() { }

	// RVA: 0x221E580 Offset: 0x221CB80 VA: 0x18221E580
	public static XName Get(string expandedName) { }

	// RVA: 0x221E7B0 Offset: 0x221CDB0 VA: 0x18221E7B0
	public static XName Get(string localName, string namespaceName) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x221EB10 Offset: 0x221D110 VA: 0x18221EB10
	public static XName op_Implicit(string expandedName) { }

	// RVA: 0xAE59E0 Offset: 0xAE3FE0 VA: 0x180AE59E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xAE59E0 Offset: 0xAE3FE0 VA: 0x180AE59E0
	public static bool op_Equality(XName left, XName right) { }

	// RVA: 0xAE59E0 Offset: 0xAE3FE0 VA: 0x180AE59E0 Slot: 4
	private bool System.IEquatable<System.Xml.Linq.XName>.Equals(XName other) { }

	// RVA: 0x221E8B0 Offset: 0x221CEB0 VA: 0x18221E8B0 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x221EAE0 Offset: 0x221D0E0 VA: 0x18221EAE0
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

	// RVA: 0x221F260 Offset: 0x221D860 VA: 0x18221F260
	internal void .ctor(string namespaceName) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_NamespaceName() { }

	// RVA: 0x221EE10 Offset: 0x221D410 VA: 0x18221EE10
	public XName GetName(string localName) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x221F340 Offset: 0x221D940 VA: 0x18221F340
	public static XNamespace get_None() { }

	// RVA: 0x221F390 Offset: 0x221D990 VA: 0x18221F390
	public static XNamespace get_Xml() { }

	// RVA: 0x221F3E0 Offset: 0x221D9E0 VA: 0x18221F3E0
	public static XNamespace get_Xmlns() { }

	// RVA: 0x221EEA0 Offset: 0x221D4A0 VA: 0x18221EEA0
	public static XNamespace Get(string namespaceName) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x221F430 Offset: 0x221DA30 VA: 0x18221F430
	public static XNamespace op_Implicit(string namespaceName) { }

	// RVA: 0xAE59E0 Offset: 0xAE3FE0 VA: 0x180AE59E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xAE59E0 Offset: 0xAE3FE0 VA: 0x180AE59E0
	public static bool op_Equality(XNamespace left, XNamespace right) { }

	// RVA: 0x12A4190 Offset: 0x12A2790 VA: 0x1812A4190
	public static bool op_Inequality(XNamespace left, XNamespace right) { }

	// RVA: 0x221EC90 Offset: 0x221D290 VA: 0x18221EC90
	internal XName GetName(string localName, int index, int count) { }

	// RVA: 0x221EF10 Offset: 0x221D510 VA: 0x18221EF10
	internal static XNamespace Get(string namespaceName, int index, int count) { }

	// RVA: 0x14B7D60 Offset: 0x14B6360 VA: 0x1814B7D60
	private static string ExtractLocalName(XName n) { }

	// RVA: 0x221EC10 Offset: 0x221D210 VA: 0x18221EC10
	private static string ExtractNamespace(WeakReference r) { }

	// RVA: 0x221EB20 Offset: 0x221D120 VA: 0x18221EB20
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

	// RVA: 0x2220470 Offset: 0x221EA70 VA: 0x182220470
	public string get_BaseUri() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x2220530 Offset: 0x221EB30 VA: 0x182220530
	public XElement get_Parent() { }

	// RVA: 0x221FA90 Offset: 0x221E090 VA: 0x18221FA90
	public void AddAnnotation(object annotation) { }

	// RVA: 0x221FD60 Offset: 0x221E360 VA: 0x18221FD60
	public object Annotation(Type type) { }

	// RVA: -1 Offset: -1
	public T Annotation<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE07E0 Offset: 0xBDEDE0 VA: 0x180BE07E0
	|-XObject.Annotation<object>
	|-XObject.Annotation<BaseUriAnnotation>
	|-XObject.Annotation<LineInfoAnnotation>
	|-XObject.Annotation<XObjectChangeAnnotation>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xE0FA0 Offset: 0xE03A0 VA: 0x1800E0FA0
	// RVA: -1 Offset: -1
	public IEnumerable<T> Annotations<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B4920 Offset: 0x4B2F20 VA: 0x1804B4920
	|-XObject.Annotations<object>
	|-XObject.Annotations<XObjectChangeAnnotation>
	*/

	// RVA: 0x2220390 Offset: 0x221E990 VA: 0x182220390 Slot: 4
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x22203D0 Offset: 0x221E9D0 VA: 0x1822203D0 Slot: 5
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x2220420 Offset: 0x221EA20 VA: 0x182220420 Slot: 6
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x22204F0 Offset: 0x221EAF0 VA: 0x1822204F0
	internal bool get_HasBaseUri() { }

	// RVA: 0x22200D0 Offset: 0x221E6D0 VA: 0x1822200D0
	internal bool NotifyChanged(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x2220180 Offset: 0x221E780 VA: 0x182220180
	internal bool NotifyChanging(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x2220230 Offset: 0x221E830 VA: 0x182220230
	internal void SetBaseUri(string baseUri) { }

	// RVA: 0x22202B0 Offset: 0x221E8B0 VA: 0x1822202B0
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x2220330 Offset: 0x221E930 VA: 0x182220330
	internal bool SkipNotify() { }

	// RVA: 0x221FEC0 Offset: 0x221E4C0 VA: 0x18221FEC0
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B840 Offset: 0x1449E40 VA: 0x18144B840
	|-XObject.<Annotations>d__16<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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
	|-RVA: 0x1A5FD20 Offset: 0x1A5E320 VA: 0x181A5FD20
	|-XObject.<Annotations>d__16<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-XObject.<Annotations>d__16<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A60030 Offset: 0x1A5E630 VA: 0x181A60030
	|-XObject.<Annotations>d__16<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-XObject.<Annotations>d__16<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A5FF70 Offset: 0x1A5E570 VA: 0x181A5FF70
	|-XObject.<Annotations>d__16<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1760E40 Offset: 0x175F440 VA: 0x181760E40
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

	// RVA: 0x221FA30 Offset: 0x221E030 VA: 0x18221FA30
	public void .ctor(XObjectChange objectChange) { }

	// RVA: 0x221F830 Offset: 0x221DE30 VA: 0x18221F830
	private static void .cctor() { }

}

public abstract class XNode : XObject // TypeDefIndex: 5830
{	// Fields
	internal XNode next; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x221F770 Offset: 0x221DD70 VA: 0x18221F770
	public void Remove() { }

	// RVA: 0x221F800 Offset: 0x221DE00 VA: 0x18221F800 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void WriteTo(XmlWriter writer);

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	internal virtual void AppendText(StringBuilder sb) { }

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract XNode CloneNode();

	// RVA: 0x221F480 Offset: 0x221DA80 VA: 0x18221F480
	private string GetXmlString(SaveOptions o) { }

}

public class XText : XNode // TypeDefIndex: 5831
{	// Fields
	internal string text; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x2217890 Offset: 0x2215E90 VA: 0x182217890
	public void .ctor(string value) { }

	// RVA: 0x2217800 Offset: 0x2215E00 VA: 0x182217800
	public void .ctor(XText other) { }

	// RVA: 0xAC1DA0 Offset: 0xAC03A0 VA: 0x180AC1DA0 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public string get_Value() { }

	// RVA: 0x2220BE0 Offset: 0x221F1E0 VA: 0x182220BE0
	public void set_Value(string value) { }

	// RVA: 0x2220AF0 Offset: 0x221F0F0 VA: 0x182220AF0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x2220A10 Offset: 0x221F010 VA: 0x182220A10 Slot: 9
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x2220A40 Offset: 0x221F040 VA: 0x182220A40 Slot: 10
	internal override XNode CloneNode() { }

}

public class XCData : XText // TypeDefIndex: 5832
{	// Properties
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0x2217890 Offset: 0x2215E90 VA: 0x182217890
	public void .ctor(string value) { }

	// RVA: 0x2217800 Offset: 0x2215E00 VA: 0x182217800
	public void .ctor(XCData other) { }

	// RVA: 0xE37E50 Offset: 0xE36450 VA: 0x180E37E50 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x2217770 Offset: 0x2215D70 VA: 0x182217770 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x22176C0 Offset: 0x2215CC0 VA: 0x1822176C0 Slot: 10
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

	// RVA: 0x221B800 Offset: 0x2219E00 VA: 0x18221B800
	internal void .ctor(XContainer other) { }

	// RVA: 0x221B940 Offset: 0x2219F40 VA: 0x18221B940
	public XNode get_LastNode() { }

	// RVA: 0x2218A50 Offset: 0x2217050 VA: 0x182218A50
	public void Add(object content) { }

	[IteratorStateMachineAttribute] // RVA: 0xE1860 Offset: 0xE0C60 VA: 0x1800E1860
	// RVA: 0x22197E0 Offset: 0x2217DE0 VA: 0x1822197E0
	public IEnumerable<XNode> Nodes() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 11
	internal virtual void AddAttribute(XAttribute a) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	internal virtual void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x2217B80 Offset: 0x2216180 VA: 0x182217B80
	internal void AddContentSkipNotify(object content) { }

	// RVA: 0x2218400 Offset: 0x2216A00 VA: 0x182218400
	internal void AddNode(XNode n) { }

	// RVA: 0x2218360 Offset: 0x2216960 VA: 0x182218360
	internal void AddNodeSkipNotify(XNode n) { }

	// RVA: 0x2218670 Offset: 0x2216C70 VA: 0x182218670
	internal void AddString(string s) { }

	// RVA: 0x22184A0 Offset: 0x2216AA0 VA: 0x1822184A0
	internal void AddStringSkipNotify(string s) { }

	// RVA: 0x2218FA0 Offset: 0x22175A0 VA: 0x182218FA0
	internal void AppendNode(XNode n) { }

	// RVA: 0x2218EA0 Offset: 0x22174A0 VA: 0x182218EA0
	internal void AppendNodeSkipNotify(XNode n) { }

	// RVA: 0x22190D0 Offset: 0x22176D0 VA: 0x1822190D0 Slot: 9
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x22191D0 Offset: 0x22177D0 VA: 0x1822191D0
	internal void ConvertTextToNode() { }

	// RVA: 0x22192C0 Offset: 0x22178C0 VA: 0x1822192C0
	internal static string GetDateTimeString(DateTime value) { }

	// RVA: 0x2219320 Offset: 0x2217920 VA: 0x182219320
	internal static string GetStringValue(object value) { }

	// RVA: 0x221A800 Offset: 0x2218E00 VA: 0x18221A800
	internal void ReadContentFrom(XmlReader r) { }

	// RVA: 0x2219850 Offset: 0x2217E50 VA: 0x182219850
	internal void ReadContentFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x221B450 Offset: 0x2219A50 VA: 0x18221B450
	internal void RemoveNode(XNode n) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 13
	internal virtual void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 14
	internal virtual void ValidateString(string s) { }

	// RVA: 0x221B660 Offset: 0x2219C60 VA: 0x18221B660
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xD87490 Offset: 0xD85A90 VA: 0x180D87490
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2216930 Offset: 0x2214F30 VA: 0x182216930 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2216BF0 Offset: 0x22151F0 VA: 0x182216BF0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2216B50 Offset: 0x2215150 VA: 0x182216B50 Slot: 4
	private IEnumerator<XNode> System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2216B50 Offset: 0x2215150 VA: 0x182216B50 Slot: 5
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

	// RVA: 0x221E380 Offset: 0x221C980 VA: 0x18221E380
	public void .ctor(XName name) { }

	// RVA: 0x221E200 Offset: 0x221C800 VA: 0x18221E200
	public void .ctor(XElement other) { }

	// RVA: 0x221E410 Offset: 0x221CA10 VA: 0x18221E410
	public void .ctor(XStreamingElement other) { }

	// RVA: 0x221E4B0 Offset: 0x221CAB0 VA: 0x18221E4B0
	public bool get_IsEmpty() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public XName get_Name() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x221E4C0 Offset: 0x221CAC0 VA: 0x18221E4C0
	public string get_Value() { }

	// RVA: 0x221CFE0 Offset: 0x221B5E0 VA: 0x18221CFE0
	public XAttribute Attribute(XName name) { }

	// RVA: 0x221D020 Offset: 0x221B620 VA: 0x18221D020
	public IEnumerable<XAttribute> Attributes() { }

	// RVA: 0x221D410 Offset: 0x221BA10 VA: 0x18221D410
	public string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x221E130 Offset: 0x221C730 VA: 0x18221E130 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 15
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x221DD60 Offset: 0x221C360 VA: 0x18221DD60 Slot: 16
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xE59160 Offset: 0xE57760 VA: 0x180E59160 Slot: 17
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x221CB70 Offset: 0x221B170 VA: 0x18221CB70 Slot: 11
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x221C9F0 Offset: 0x221AFF0 VA: 0x18221C9F0 Slot: 12
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x221CE60 Offset: 0x221B460 VA: 0x18221CE60
	internal void AppendAttribute(XAttribute a) { }

	// RVA: 0x221CDE0 Offset: 0x221B3E0 VA: 0x18221CDE0
	internal void AppendAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x221D0B0 Offset: 0x221B6B0 VA: 0x18221D0B0 Slot: 10
	internal override XNode CloneNode() { }

	[IteratorStateMachineAttribute] // RVA: 0xE5E90 Offset: 0xE5290 VA: 0x1800E5E90
	// RVA: 0x221D260 Offset: 0x221B860 VA: 0x18221D260
	private IEnumerable<XAttribute> GetAttributes(XName name) { }

	// RVA: 0x221D2F0 Offset: 0x221B8F0 VA: 0x18221D2F0
	private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope) { }

	// RVA: 0x221D660 Offset: 0x221BC60 VA: 0x18221D660
	private void ReadElementFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x221DCE0 Offset: 0x221C2E0 VA: 0x18221DCE0
	internal void SetEndElementLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x221DF50 Offset: 0x221C550 VA: 0x18221DF50 Slot: 13
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xD87490 Offset: 0xD85A90 VA: 0x180D87490
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2216750 Offset: 0x2214D50 VA: 0x182216750 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22168E0 Offset: 0x2214EE0 VA: 0x1822168E0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2216830 Offset: 0x2214E30 VA: 0x182216830 Slot: 4
	private IEnumerator<XAttribute> System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2216830 Offset: 0x2214E30 VA: 0x182216830 Slot: 5
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

	// RVA: 0x221C8D0 Offset: 0x221AED0 VA: 0x18221C8D0
	public void .ctor(XDocument other) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public XDeclaration get_Declaration() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	public void set_Declaration(XDeclaration value) { }

	// RVA: 0xE665F0 Offset: 0xE64BF0 VA: 0x180E665F0 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x221C9B0 Offset: 0x221AFB0 VA: 0x18221C9B0
	public XElement get_Root() { }

	// RVA: 0x221C7B0 Offset: 0x221ADB0 VA: 0x18221C7B0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x221C130 Offset: 0x221A730 VA: 0x18221C130 Slot: 11
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x221C0C0 Offset: 0x221A6C0 VA: 0x18221C0C0 Slot: 12
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x221C1A0 Offset: 0x221A7A0 VA: 0x18221C1A0 Slot: 10
	internal override XNode CloneNode() { }

	// RVA: -1 Offset: -1
	private T GetFirstNode<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE06F0 Offset: 0xBDECF0 VA: 0x180BE06F0
	|-XDocument.GetFirstNode<object>
	|-XDocument.GetFirstNode<XElement>
	*/

	// RVA: 0x221C2B0 Offset: 0x221A8B0 VA: 0x18221C2B0
	internal static bool IsWhitespace(string s) { }

	// RVA: 0x221C460 Offset: 0x221AA60 VA: 0x18221C460 Slot: 13
	internal override void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x221C330 Offset: 0x221A930 VA: 0x18221C330
	private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter) { }

	// RVA: 0x221C6F0 Offset: 0x221ACF0 VA: 0x18221C6F0 Slot: 14
	internal override void ValidateString(string s) { }

}

public class XComment : XNode // TypeDefIndex: 5844
{	// Fields
	internal string value; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x2217AF0 Offset: 0x22160F0 VA: 0x182217AF0
	public void .ctor(string value) { }

	// RVA: 0x2217A60 Offset: 0x2216060 VA: 0x182217A60
	public void .ctor(XComment other) { }

	// RVA: 0x8C0CF0 Offset: 0x8BF2F0 VA: 0x1808C0CF0 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public string get_Value() { }

	// RVA: 0x22179D0 Offset: 0x2215FD0 VA: 0x1822179D0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x2217920 Offset: 0x2215F20 VA: 0x182217920 Slot: 10
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

	// RVA: 0x22207F0 Offset: 0x221EDF0 VA: 0x1822207F0
	public void .ctor(string target, string data) { }

	// RVA: 0x2220970 Offset: 0x221EF70 VA: 0x182220970
	public void .ctor(XProcessingInstruction other) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_Data() { }

	// RVA: 0xB9F990 Offset: 0xB9DF90 VA: 0x180B9F990 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public string get_Target() { }

	// RVA: 0x2220760 Offset: 0x221ED60 VA: 0x182220760 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x22205B0 Offset: 0x221EBB0 VA: 0x1822205B0 Slot: 10
	internal override XNode CloneNode() { }

	// RVA: 0x2220670 Offset: 0x221EC70 VA: 0x182220670
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

	// RVA: 0x1473D10 Offset: 0x1472310 VA: 0x181473D10
	public void .ctor(string version, string encoding, string standalone) { }

	// RVA: 0x221BC20 Offset: 0x221A220 VA: 0x18221BC20
	public void .ctor(XDeclaration other) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Encoding() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Standalone() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Version() { }

	// RVA: 0x221BAD0 Offset: 0x221A0D0 VA: 0x18221BAD0 Slot: 3
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

	// RVA: 0x221C000 Offset: 0x221A600 VA: 0x18221C000
	public void .ctor(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x221BE60 Offset: 0x221A460 VA: 0x18221BE60
	public void .ctor(XDocumentType other) { }

	// RVA: 0x221BF30 Offset: 0x221A530 VA: 0x18221BF30
	internal void .ctor(string name, string publicId, string systemId, string internalSubset, IDtdInfo dtdInfo) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public string get_InternalSubset() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public string get_Name() { }

	// RVA: 0x4A6090 Offset: 0x4A4690 VA: 0x1804A6090 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_PublicId() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_SystemId() { }

	// RVA: 0x221BDC0 Offset: 0x221A3C0 VA: 0x18221BDC0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x221BCD0 Offset: 0x221A2D0 VA: 0x18221BCD0 Slot: 10
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

	// RVA: 0x22174A0 Offset: 0x2215AA0 VA: 0x1822174A0
	public void .ctor(XName name, object value) { }

	// RVA: 0x22175A0 Offset: 0x2215BA0 VA: 0x1822175A0
	public void .ctor(XAttribute other) { }

	// RVA: 0x2217640 Offset: 0x2215C40 VA: 0x182217640
	public bool get_IsNamespaceDeclaration() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public XName get_Name() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_Value() { }

	// RVA: 0x2216D90 Offset: 0x2215390 VA: 0x182216D90 Slot: 3
	public override string ToString() { }

	// RVA: 0x2216C40 Offset: 0x2215240 VA: 0x182216C40
	internal string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x2217130 Offset: 0x2215730 VA: 0x182217130
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

	// RVA: 0xFA0BB0 Offset: 0xF9F1B0 VA: 0x180FA0BB0
	public void .ctor(XmlDocument document) { }

	// RVA: 0xFA0EE0 Offset: 0xF9F4E0 VA: 0x180FA0EE0 Slot: 15
	public IXmlNode CreateComment(string data) { }

	// RVA: 0xFA11D0 Offset: 0xF9F7D0 VA: 0x180FA11D0 Slot: 16
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0xFA0E50 Offset: 0xF9F450 VA: 0x180FA0E50 Slot: 17
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0xFA1260 Offset: 0xF9F860 VA: 0x180FA1260 Slot: 18
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0xFA1140 Offset: 0xF9F740 VA: 0x180FA1140 Slot: 19
	public IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0xFA12F0 Offset: 0xF9F8F0 VA: 0x180FA12F0 Slot: 20
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0xFA13B0 Offset: 0xF9F9B0 VA: 0x180FA13B0 Slot: 21
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0xFA10A0 Offset: 0xF9F6A0 VA: 0x180FA10A0 Slot: 22
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0xFA1010 Offset: 0xF9F610 VA: 0x180FA1010 Slot: 23
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0xFA0F70 Offset: 0xF9F570 VA: 0x180FA0F70 Slot: 24
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0xFA0CD0 Offset: 0xF9F2D0 VA: 0x180FA0CD0 Slot: 25
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0xFA0D90 Offset: 0xF9F390 VA: 0x180FA0D90 Slot: 26
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	// RVA: 0xFA1480 Offset: 0xF9FA80 VA: 0x180FA1480 Slot: 27
	public IXmlElement get_DocumentElement() { }

}

internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement, IXmlNode // TypeDefIndex: 6112
{	// Fields
	private readonly XmlElement _element; // 0x28

	// Properties
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0xFA0BB0 Offset: 0xF9F1B0 VA: 0x180FA0BB0
	public void .ctor(XmlElement element) { }

	// RVA: 0xFA1560 Offset: 0xF9FB60 VA: 0x180FA1560 Slot: 15
	public void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0xFA1530 Offset: 0xF9FB30 VA: 0x180FA1530 Slot: 16
	public string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0xFA1660 Offset: 0xF9FC60 VA: 0x180FA1660 Slot: 17
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

	// RVA: 0xFA0BB0 Offset: 0xF9F1B0 VA: 0x180FA0BB0
	public void .ctor(XmlDeclaration declaration) { }

	// RVA: 0xFA0C30 Offset: 0xF9F230 VA: 0x180FA0C30 Slot: 15
	public string get_Version() { }

	// RVA: 0xFA0BF0 Offset: 0xF9F1F0 VA: 0x180FA0BF0 Slot: 16
	public string get_Encoding() { }

	// RVA: 0xFA0C10 Offset: 0xF9F210 VA: 0x180FA0C10 Slot: 17
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

	// RVA: 0xFA0BB0 Offset: 0xF9F1B0 VA: 0x180FA0BB0
	public void .ctor(XmlDocumentType documentType) { }

	// RVA: 0xFA0CA0 Offset: 0xF9F2A0 VA: 0x180FA0CA0 Slot: 15
	public string get_Name() { }

	// RVA: 0xFA0C10 Offset: 0xF9F210 VA: 0x180FA0C10 Slot: 16
	public string get_System() { }

	// RVA: 0xFA0BF0 Offset: 0xF9F1F0 VA: 0x180FA0BF0 Slot: 17
	public string get_Public() { }

	// RVA: 0xFA0C50 Offset: 0xF9F250 VA: 0x180FA0C50 Slot: 18
	public string get_InternalSubset() { }

	// RVA: 0xFA0C70 Offset: 0xF9F270 VA: 0x180FA0C70 Slot: 13
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

	// RVA: 0xBC8B50 Offset: 0xBC7150 VA: 0x180BC8B50 Slot: 4
	public XmlNodeType get_NodeType() { }

	// RVA: 0xBC8AC0 Offset: 0xBC70C0 VA: 0x180BC8AC0 Slot: 13
	public virtual string get_LocalName() { }

	// RVA: 0xFA7910 Offset: 0xFA5F10 VA: 0x180FA7910 Slot: 6
	public List<IXmlNode> get_ChildNodes() { }

	// RVA: 0xFA7280 Offset: 0xFA5880 VA: 0x180FA7280
	internal static IXmlNode WrapNode(XmlNode node) { }

	// RVA: 0xFA7470 Offset: 0xFA5A70 VA: 0x180FA7470 Slot: 7
	public List<IXmlNode> get_Attributes() { }

	// RVA: 0xFA7D80 Offset: 0xFA6380 VA: 0x180FA7D80 Slot: 8
	public IXmlNode get_ParentNode() { }

	// RVA: 0xBC8AF0 Offset: 0xBC70F0 VA: 0x180BC8AF0 Slot: 9
	public string get_Value() { }

	// RVA: 0xFA7EC0 Offset: 0xFA64C0 VA: 0x180FA7EC0 Slot: 14
	public void set_Value(string value) { }

	// RVA: 0xFA71B0 Offset: 0xFA57B0 VA: 0x180FA71B0 Slot: 10
	public IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0xB9EE40 Offset: 0xB9D440 VA: 0x180B9EE40 Slot: 11
	public string get_NamespaceUri() { }

}

internal class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration, IXmlNode // TypeDefIndex: 6121
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private XDeclaration <Declaration>k__BackingField; // 0x18

	// Properties
	internal XDeclaration Declaration { get; set; }
	public override XmlNodeType NodeType { get; }
	public string Version { get; }
	public string Encoding { get; }
	public string Standalone { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal XDeclaration get_Declaration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_Declaration(XDeclaration value) { }

	// RVA: 0xF9F2E0 Offset: 0xF9D8E0 VA: 0x180F9F2E0
	public void .ctor(XDeclaration declaration) { }

	// RVA: 0xE61B60 Offset: 0xE60160 VA: 0x180E61B60 Slot: 13
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xE570D0 Offset: 0xE556D0 VA: 0x180E570D0 Slot: 21
	public string get_Version() { }

	// RVA: 0x855180 Offset: 0x853780 VA: 0x180855180 Slot: 22
	public string get_Encoding() { }

	// RVA: 0xE57010 Offset: 0xE55610 VA: 0x180E57010 Slot: 23
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

	// RVA: 0xF9F360 Offset: 0xF9D960 VA: 0x180F9F360
	public void .ctor(XDocumentType documentType) { }

	// RVA: 0xF9F430 Offset: 0xF9DA30 VA: 0x180F9F430 Slot: 21
	public string get_Name() { }

	// RVA: 0xE57030 Offset: 0xE55630 VA: 0x180E57030 Slot: 22
	public string get_System() { }

	// RVA: 0x855160 Offset: 0x853760 VA: 0x180855160 Slot: 23
	public string get_Public() { }

	// RVA: 0xF9F3E0 Offset: 0xF9D9E0 VA: 0x180F9F3E0 Slot: 24
	public string get_InternalSubset() { }

	// RVA: 0xF9F400 Offset: 0xF9DA00 VA: 0x180F9F400 Slot: 14
	public override string get_LocalName() { }

}

internal class XDocumentWrapper : XContainerWrapper, IXmlDocument, IXmlNode // TypeDefIndex: 6123
{	// Properties
	private XDocument Document { get; }
	public override List<IXmlNode> ChildNodes { get; }
	public IXmlElement DocumentElement { get; }

	// Methods

	// RVA: 0xF9FF20 Offset: 0xF9E520 VA: 0x180F9FF20
	private XDocument get_Document() { }

	// RVA: 0xF9EF80 Offset: 0xF9D580 VA: 0x180F9EF80
	public void .ctor(XDocument document) { }

	// RVA: 0xF9FD90 Offset: 0xF9E390 VA: 0x180F9FD90 Slot: 15
	public override List<IXmlNode> get_ChildNodes() { }

	// RVA: 0xF9F7D0 Offset: 0xF9DDD0 VA: 0x180F9F7D0 Slot: 21
	public IXmlNode CreateComment(string text) { }

	// RVA: 0xF9FB50 Offset: 0xF9E150 VA: 0x180F9FB50 Slot: 22
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0xF9F750 Offset: 0xF9DD50 VA: 0x180F9F750 Slot: 23
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0xF9FBD0 Offset: 0xF9E1D0 VA: 0x180F9FBD0 Slot: 24
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0xF9FAD0 Offset: 0xF9E0D0 VA: 0x180F9FAD0 Slot: 25
	public IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0xF9FC50 Offset: 0xF9E250 VA: 0x180F9FC50 Slot: 26
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0xF9FCF0 Offset: 0xF9E2F0 VA: 0x180F9FCF0 Slot: 27
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0xF9FA00 Offset: 0xF9E000 VA: 0x180F9FA00 Slot: 28
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0xF9F930 Offset: 0xF9DF30 VA: 0x180F9F930 Slot: 29
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0xF9F850 Offset: 0xF9DE50 VA: 0x180F9F850 Slot: 30
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0xF9F670 Offset: 0xF9DC70 VA: 0x180F9F670 Slot: 31
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0xF9F580 Offset: 0xF9DB80 VA: 0x180F9F580 Slot: 32
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	// RVA: 0xF9FE80 Offset: 0xF9E480 VA: 0x180F9FE80 Slot: 33
	public IXmlElement get_DocumentElement() { }

	// RVA: 0xF9F450 Offset: 0xF9DA50 VA: 0x180F9F450 Slot: 19
	public override IXmlNode AppendChild(IXmlNode newChild) { }

}

internal class XTextWrapper : XObjectWrapper // TypeDefIndex: 6124
{	// Properties
	private XText Text { get; }
	public override string Value { get; }
	public override IXmlNode ParentNode { get; }

	// Methods

	// RVA: 0xFA0B10 Offset: 0xF9F110 VA: 0x180FA0B10
	private XText get_Text() { }

	// RVA: 0xFA0A40 Offset: 0xF9F040 VA: 0x180FA0A40
	public void .ctor(XText text) { }

	// RVA: 0xFA0B90 Offset: 0xF9F190 VA: 0x180FA0B90 Slot: 18
	public override string get_Value() { }

	// RVA: 0xFA0AB0 Offset: 0xF9F0B0 VA: 0x180FA0AB0 Slot: 17
	public override IXmlNode get_ParentNode() { }

}

internal class XCommentWrapper : XObjectWrapper // TypeDefIndex: 6125
{	// Properties
	private XComment Text { get; }
	public override string Value { get; }
	public override IXmlNode ParentNode { get; }

	// Methods

	// RVA: 0xF9E790 Offset: 0xF9CD90 VA: 0x180F9E790
	private XComment get_Text() { }

	// RVA: 0xF9E6C0 Offset: 0xF9CCC0 VA: 0x180F9E6C0
	public void .ctor(XComment text) { }

	// RVA: 0xF9E810 Offset: 0xF9CE10 VA: 0x180F9E810 Slot: 18
	public override string get_Value() { }

	// RVA: 0xF9E730 Offset: 0xF9CD30 VA: 0x180F9E730 Slot: 17
	public override IXmlNode get_ParentNode() { }

}

internal class XProcessingInstructionWrapper : XObjectWrapper // TypeDefIndex: 6126
{	// Properties
	private XProcessingInstruction ProcessingInstruction { get; }
	public override string LocalName { get; }
	public override string Value { get; }

	// Methods

	// RVA: 0xFA09A0 Offset: 0xF9EFA0 VA: 0x180FA09A0
	private XProcessingInstruction get_ProcessingInstruction() { }

	// RVA: 0xFA0910 Offset: 0xF9EF10 VA: 0x180FA0910
	public void .ctor(XProcessingInstruction processingInstruction) { }

	// RVA: 0xFA0980 Offset: 0xF9EF80 VA: 0x180FA0980 Slot: 14
	public override string get_LocalName() { }

	// RVA: 0xFA0A20 Offset: 0xF9F020 VA: 0x180FA0A20 Slot: 18
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

	// RVA: 0xF9F200 Offset: 0xF9D800 VA: 0x180F9F200
	private XContainer get_Container() { }

	// RVA: 0xF9EF80 Offset: 0xF9D580 VA: 0x180F9EF80
	public void .ctor(XContainer container) { }

	// RVA: 0xF9EFF0 Offset: 0xF9D5F0 VA: 0x180F9EFF0 Slot: 15
	public override List<IXmlNode> get_ChildNodes() { }

	// RVA: 0xF9F280 Offset: 0xF9D880 VA: 0x180F9F280 Slot: 17
	public override IXmlNode get_ParentNode() { }

	// RVA: 0xF9E8D0 Offset: 0xF9CED0 VA: 0x180F9E8D0
	internal static IXmlNode WrapNode(XObject node) { }

	// RVA: 0xF9E830 Offset: 0xF9CE30 VA: 0x180F9E830 Slot: 19
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

	// RVA: 0xBC8AF0 Offset: 0xBC70F0 VA: 0x180BC8AF0 Slot: 13
	public virtual XmlNodeType get_NodeType() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 14
	public virtual string get_LocalName() { }

	// RVA: 0xFA08B0 Offset: 0xF9EEB0 VA: 0x180FA08B0 Slot: 15
	public virtual List<IXmlNode> get_ChildNodes() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 16
	public virtual List<IXmlNode> get_Attributes() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 17
	public virtual IXmlNode get_ParentNode() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 18
	public virtual string get_Value() { }

	// RVA: 0xFA0800 Offset: 0xF9EE00 VA: 0x180FA0800 Slot: 19
	public virtual IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 20
	public virtual string get_NamespaceUri() { }

	// RVA: 0xFA0850 Offset: 0xF9EE50 VA: 0x180FA0850
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

	// RVA: 0xF9E560 Offset: 0xF9CB60 VA: 0x180F9E560
	private XAttribute get_Attribute() { }

	// RVA: 0xF9E4F0 Offset: 0xF9CAF0 VA: 0x180F9E4F0
	public void .ctor(XAttribute attribute) { }

	// RVA: 0xF9E6A0 Offset: 0xF9CCA0 VA: 0x180F9E6A0 Slot: 18
	public override string get_Value() { }

	// RVA: 0xF9E5E0 Offset: 0xF9CBE0 VA: 0x180F9E5E0 Slot: 14
	public override string get_LocalName() { }

	// RVA: 0xF9E610 Offset: 0xF9CC10 VA: 0x180F9E610 Slot: 20
	public override string get_NamespaceUri() { }

	// RVA: 0xF9E640 Offset: 0xF9CC40 VA: 0x180F9E640 Slot: 17
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

	// RVA: 0xFA06C0 Offset: 0xF9ECC0 VA: 0x180FA06C0
	private XElement get_Element() { }

	// RVA: 0xF9EF80 Offset: 0xF9D580 VA: 0x180F9EF80
	public void .ctor(XElement element) { }

	// RVA: 0xFA0090 Offset: 0xF9E690 VA: 0x180FA0090 Slot: 21
	public void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0xFA0160 Offset: 0xF9E760 VA: 0x180FA0160 Slot: 16
	public override List<IXmlNode> get_Attributes() { }

	// RVA: 0xF9FFA0 Offset: 0xF9E5A0 VA: 0x180F9FFA0 Slot: 19
	public override IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0xFA07D0 Offset: 0xF9EDD0 VA: 0x180FA07D0 Slot: 18
	public override string get_Value() { }

	// RVA: 0xFA0770 Offset: 0xF9ED70 VA: 0x180FA0770 Slot: 14
	public override string get_LocalName() { }

	// RVA: 0xFA07A0 Offset: 0xF9EDA0 VA: 0x180FA07A0 Slot: 20
	public override string get_NamespaceUri() { }

	// RVA: 0xFA0040 Offset: 0xF9E640 VA: 0x180FA0040 Slot: 22
	public string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0xFA0740 Offset: 0xF9ED40 VA: 0x180FA0740 Slot: 23
	public bool get_IsEmpty() { }

}

public class XmlNodeConverter : JsonConverter // TypeDefIndex: 6131
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <DeserializeRootElementName>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <WriteArrayAttribute>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <OmitRootObject>k__BackingField; // 0x19

	// Properties
	public string DeserializeRootElementName { get; }
	public bool WriteArrayAttribute { get; }
	public bool OmitRootObject { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_DeserializeRootElementName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0
	public bool get_WriteArrayAttribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xFA71A0 Offset: 0xFA57A0 VA: 0x180FA71A0
	public bool get_OmitRootObject() { }

	// RVA: 0xFA7080 Offset: 0xFA5680 VA: 0x180FA7080 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xFA6F10 Offset: 0xFA5510 VA: 0x180FA6F10
	private IXmlNode WrapXml(object value) { }

	// RVA: 0xFA4720 Offset: 0xFA2D20 VA: 0x180FA4720
	private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xFA5BC0 Offset: 0xFA41C0 VA: 0x180FA5BC0
	private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xFA4170 Offset: 0xFA2770 VA: 0x180FA4170
	private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xFA4430 Offset: 0xFA2A30 VA: 0x180FA4430
	private bool IsArray(IXmlNode node) { }

	// RVA: 0xFA5D50 Offset: 0xFA4350 VA: 0x180FA5D50
	private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0xFA6180 Offset: 0xFA4780 VA: 0x180FA6180
	private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0xFA19D0 Offset: 0xF9FFD0 VA: 0x180FA19D0
	private static bool AllSameName(IXmlNode node) { }

	// RVA: 0xFA56D0 Offset: 0xFA3CD0 VA: 0x180FA56D0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xFA3E60 Offset: 0xFA2460 VA: 0x180FA3E60
	private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode) { }

	// RVA: 0xFA5440 Offset: 0xFA3A40 VA: 0x180FA5440
	private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager) { }

	// RVA: 0xFA2770 Offset: 0xFA0D70 VA: 0x180FA2770
	private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, Dictionary<string, string> attributeNameValues) { }

	// RVA: 0xFA1680 Offset: 0xF9FC80 VA: 0x180FA1680
	private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string attributeName, XmlNamespaceManager manager, string attributePrefix) { }

	// RVA: 0xFA1C70 Offset: 0xFA0270 VA: 0x180FA1C70
	private string ConvertTokenToXmlValue(JsonReader reader) { }

	// RVA: 0xFA4BA0 Offset: 0xFA31A0 VA: 0x180FA4BA0
	private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager) { }

	// RVA: 0xFA1820 Offset: 0xF9FE20 VA: 0x180FA1820
	private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document) { }

	// RVA: 0xFA4E40 Offset: 0xFA3440 VA: 0x180FA4E40
	private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager) { }

	// RVA: 0xFA2BF0 Offset: 0xFA11F0 VA: 0x180FA2BF0
	private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName) { }

	// RVA: 0xFA2300 Offset: 0xFA0900 VA: 0x180FA2300
	private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode) { }

	// RVA: 0xFA2660 Offset: 0xFA0C60 VA: 0x180FA2660
	private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager) { }

	// RVA: 0xFA2F20 Offset: 0xFA1520 VA: 0x180FA2F20
	private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode) { }

	// RVA: 0xFA4640 Offset: 0xFA2C40 VA: 0x180FA4640
	private bool IsNamespaceAttribute(string attributeName, out string prefix) { }

	// RVA: 0xFA6DA0 Offset: 0xFA53A0 VA: 0x180FA6DA0
	private bool ValueAttributes(List<IXmlNode> c) { }

	// RVA: 0xFA1B80 Offset: 0xFA0180 VA: 0x180FA1B80 Slot: 6
	public override bool CanConvert(Type valueType) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class XORSwitch : IOEntity // TypeDefIndex: 9806
{	// Fields
	private int input1Amount; // 0x288
	private int input2Amount; // 0x28C

	// Methods

	// RVA: 0x1AA2060 Offset: 0x1AA0660 VA: 0x181AA2060
	public void .ctor() { }

}

