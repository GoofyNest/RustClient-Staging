public abstract class UriParser // TypeDefIndex: 2583
{	// Fields
	private const UriSyntaxFlags SchemeOnlyFlags = 16;
	private static readonly Dictionary<string, UriParser> m_Table; // 0x0
	private static Dictionary<string, UriParser> m_TempTable; // 0x8
	private UriSyntaxFlags m_Flags; // 0x10
	private UriSyntaxFlags m_UpdatableFlags; // 0x14
	private bool m_UpdatableFlagsUsed; // 0x18
	private const UriSyntaxFlags c_UpdatableFlags = 33554432;
	private int m_Port; // 0x1C
	private string m_Scheme; // 0x20
	internal const int NoDefaultPort = -1;
	private const int c_InitialTableSize = 25;
	internal static UriParser HttpUri; // 0x10
	internal static UriParser HttpsUri; // 0x18
	internal static UriParser WsUri; // 0x20
	internal static UriParser WssUri; // 0x28
	internal static UriParser FtpUri; // 0x30
	internal static UriParser FileUri; // 0x38
	internal static UriParser GopherUri; // 0x40
	internal static UriParser NntpUri; // 0x48
	internal static UriParser NewsUri; // 0x50
	internal static UriParser MailToUri; // 0x58
	internal static UriParser UuidUri; // 0x60
	internal static UriParser TelnetUri; // 0x68
	internal static UriParser LdapUri; // 0x70
	internal static UriParser NetTcpUri; // 0x78
	internal static UriParser NetPipeUri; // 0x80
	internal static UriParser VsMacrosUri; // 0x88
	private static readonly UriParser.UriQuirksVersion s_QuirksVersion; // 0x90
	private const int c_MaxCapacity = 512;
	private const UriSyntaxFlags UnknownV1SyntaxFlags = 351342590;
	private static readonly UriSyntaxFlags HttpSyntaxFlags; // 0x94
	private const UriSyntaxFlags FtpSyntaxFlags = 367005533;
	private static readonly UriSyntaxFlags FileSyntaxFlags; // 0x98
	private const UriSyntaxFlags VsmacrosSyntaxFlags = 399519697;
	private const UriSyntaxFlags GopherSyntaxFlags = 337645405;
	private const UriSyntaxFlags NewsSyntaxFlags = 268435536;
	private const UriSyntaxFlags NntpSyntaxFlags = 337645405;
	private const UriSyntaxFlags TelnetSyntaxFlags = 337645405;
	private const UriSyntaxFlags LdapSyntaxFlags = 337645565;
	private const UriSyntaxFlags MailtoSyntaxFlags = 335564796;
	private const UriSyntaxFlags NetPipeSyntaxFlags = 400559729;
	private const UriSyntaxFlags NetTcpSyntaxFlags = 400559737;

	// Properties
	internal string SchemeName { get; }
	internal int DefaultPort { get; }
	internal static bool ShouldUseLegacyV2Quirks { get; }
	internal UriSyntaxFlags Flags { get; }
	internal bool IsSimple { get; }

	// Methods

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal string get_SchemeName() { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	internal int get_DefaultPort() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 4
	protected virtual UriParser OnNewUri() { }

	// RVA: 0x22B9750 Offset: 0x22B7D50 VA: 0x1822B9750 Slot: 5
	protected virtual void InitializeAndValidate(Uri uri, out UriFormatException parsingError) { }

	// RVA: 0x22B9980 Offset: 0x22B7F80 VA: 0x1822B9980 Slot: 6
	protected virtual string Resolve(Uri baseUri, Uri relativeUri, out UriFormatException parsingError) { }

	// RVA: 0x22B93F0 Offset: 0x22B79F0 VA: 0x1822B93F0 Slot: 7
	protected virtual string GetComponents(Uri uri, UriComponents components, UriFormat format) { }

	// RVA: 0x22B9900 Offset: 0x22B7F00 VA: 0x1822B9900 Slot: 8
	protected virtual bool IsWellFormedOriginalString(Uri uri) { }

	// RVA: 0x22BA6B0 Offset: 0x22B8CB0 VA: 0x1822BA6B0
	internal static bool get_ShouldUseLegacyV2Quirks() { }

	// RVA: 0x22B9B80 Offset: 0x22B8180 VA: 0x1822B9B80
	private static void .cctor() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	internal UriSyntaxFlags get_Flags() { }

	// RVA: 0x22B9920 Offset: 0x22B7F20 VA: 0x1822B9920
	internal bool NotAny(UriSyntaxFlags flags) { }

	// RVA: 0x22B96F0 Offset: 0x22B7CF0 VA: 0x1822B96F0
	internal bool InFact(UriSyntaxFlags flags) { }

	// RVA: 0x22B9830 Offset: 0x22B7E30 VA: 0x1822B9830
	internal bool IsAllSet(UriSyntaxFlags flags) { }

	// RVA: 0x22B9890 Offset: 0x22B7E90 VA: 0x1822B9890
	private bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected) { }

	// RVA: 0x22BA640 Offset: 0x22B8C40 VA: 0x1822BA640
	internal void .ctor(UriSyntaxFlags flags) { }

	// RVA: 0x22B90F0 Offset: 0x22B76F0 VA: 0x1822B90F0
	internal static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme) { }

	// RVA: 0x22B9610 Offset: 0x22B7C10 VA: 0x1822B9610
	internal static UriParser GetSyntax(string lwrCaseScheme) { }

	// RVA: 0x22BA6A0 Offset: 0x22B8CA0 VA: 0x1822BA6A0
	internal bool get_IsSimple() { }

	// RVA: 0x22B97B0 Offset: 0x22B7DB0 VA: 0x1822B97B0
	internal UriParser InternalOnNewUri() { }

	// RVA: 0x22B9810 Offset: 0x22B7E10 VA: 0x1822B9810
	internal void InternalValidate(Uri thisUri, out UriFormatException parsingError) { }

	// RVA: 0x139C140 Offset: 0x139A740 VA: 0x18139C140
	internal string InternalResolve(Uri thisBaseUri, Uri uriLink, out UriFormatException parsingError) { }

	// RVA: 0x22B9790 Offset: 0x22B7D90 VA: 0x1822B9790
	internal string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0xE59420 Offset: 0xE57A20 VA: 0x180E59420
	internal bool InternalIsWellFormedOriginalString(Uri thisUri) { }

}

private enum UriParser.UriQuirksVersion // TypeDefIndex: 2584
{	// Fields
	public int value__; // 0x0
	public const UriParser.UriQuirksVersion V2 = 2;
	public const UriParser.UriQuirksVersion V3 = 3;

}

private class UriParser.BuiltInUriParser : UriParser // TypeDefIndex: 2585
{	// Methods

	// RVA: 0x22B6050 Offset: 0x22B4650 VA: 0x1822B6050
	internal void .ctor(string lwrCaseScheme, int defaultPort, UriSyntaxFlags syntaxFlags) { }

}

