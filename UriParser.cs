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

	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0
	internal int get_DefaultPort() { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 4
	protected virtual UriParser OnNewUri() { }

	// RVA: 0x22B9F70 Offset: 0x22B8570 VA: 0x1822B9F70 Slot: 5
	protected virtual void InitializeAndValidate(Uri uri, out UriFormatException parsingError) { }

	// RVA: 0x22BA1A0 Offset: 0x22B87A0 VA: 0x1822BA1A0 Slot: 6
	protected virtual string Resolve(Uri baseUri, Uri relativeUri, out UriFormatException parsingError) { }

	// RVA: 0x22B9C10 Offset: 0x22B8210 VA: 0x1822B9C10 Slot: 7
	protected virtual string GetComponents(Uri uri, UriComponents components, UriFormat format) { }

	// RVA: 0x22BA120 Offset: 0x22B8720 VA: 0x1822BA120 Slot: 8
	protected virtual bool IsWellFormedOriginalString(Uri uri) { }

	// RVA: 0x22BAED0 Offset: 0x22B94D0 VA: 0x1822BAED0
	internal static bool get_ShouldUseLegacyV2Quirks() { }

	// RVA: 0x22BA3A0 Offset: 0x22B89A0 VA: 0x1822BA3A0
	private static void .cctor() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	internal UriSyntaxFlags get_Flags() { }

	// RVA: 0x22BA140 Offset: 0x22B8740 VA: 0x1822BA140
	internal bool NotAny(UriSyntaxFlags flags) { }

	// RVA: 0x22B9F10 Offset: 0x22B8510 VA: 0x1822B9F10
	internal bool InFact(UriSyntaxFlags flags) { }

	// RVA: 0x22BA050 Offset: 0x22B8650 VA: 0x1822BA050
	internal bool IsAllSet(UriSyntaxFlags flags) { }

	// RVA: 0x22BA0B0 Offset: 0x22B86B0 VA: 0x1822BA0B0
	private bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected) { }

	// RVA: 0x22BAE60 Offset: 0x22B9460 VA: 0x1822BAE60
	internal void .ctor(UriSyntaxFlags flags) { }

	// RVA: 0x22B9910 Offset: 0x22B7F10 VA: 0x1822B9910
	internal static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme) { }

	// RVA: 0x22B9E30 Offset: 0x22B8430 VA: 0x1822B9E30
	internal static UriParser GetSyntax(string lwrCaseScheme) { }

	// RVA: 0x22BAEC0 Offset: 0x22B94C0 VA: 0x1822BAEC0
	internal bool get_IsSimple() { }

	// RVA: 0x22B9FD0 Offset: 0x22B85D0 VA: 0x1822B9FD0
	internal UriParser InternalOnNewUri() { }

	// RVA: 0x22BA030 Offset: 0x22B8630 VA: 0x1822BA030
	internal void InternalValidate(Uri thisUri, out UriFormatException parsingError) { }

	// RVA: 0x139B240 Offset: 0x1399840 VA: 0x18139B240
	internal string InternalResolve(Uri thisBaseUri, Uri uriLink, out UriFormatException parsingError) { }

	// RVA: 0x22B9FB0 Offset: 0x22B85B0 VA: 0x1822B9FB0
	internal string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0xE59ED0 Offset: 0xE584D0 VA: 0x180E59ED0
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

	// RVA: 0x22B6870 Offset: 0x22B4E70 VA: 0x1822B6870
	internal void .ctor(string lwrCaseScheme, int defaultPort, UriSyntaxFlags syntaxFlags) { }

}

