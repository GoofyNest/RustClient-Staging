internal class Uri // TypeDefIndex: 52
{	// Fields
	private bool isUnixFilePath; // 0x10
	private string source; // 0x18
	private string scheme; // 0x20
	private string host; // 0x28
	private int port; // 0x30
	private string path; // 0x38
	private string query; // 0x40
	private string fragment; // 0x48
	private string userinfo; // 0x50
	private bool isUnc; // 0x58
	private bool isOpaquePart; // 0x59
	private bool userEscaped; // 0x5A
	private string cachedToString; // 0x60
	private string cachedLocalPath; // 0x68
	private int cachedHashCode; // 0x70
	private bool reduce; // 0x74
	private static readonly string hexUpperChars; // 0x0
	public static readonly string SchemeDelimiter; // 0x8
	public static readonly string UriSchemeFile; // 0x10
	public static readonly string UriSchemeFtp; // 0x18
	public static readonly string UriSchemeGopher; // 0x20
	public static readonly string UriSchemeHttp; // 0x28
	public static readonly string UriSchemeHttps; // 0x30
	public static readonly string UriSchemeMailto; // 0x38
	public static readonly string UriSchemeNews; // 0x40
	public static readonly string UriSchemeNntp; // 0x48
	private static Uri.UriScheme[] schemes; // 0x50

	// Properties
	public string AbsolutePath { get; }
	public bool IsFile { get; }
	public bool IsUnc { get; }
	public string LocalPath { get; }

	// Methods

	// RVA: 0x175A0B0 Offset: 0x17586B0 VA: 0x18175A0B0
	public void .ctor(string uriString) { }

	// RVA: 0x1759F80 Offset: 0x1758580 VA: 0x181759F80
	public void .ctor(string uriString, bool dontEscape) { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public string get_AbsolutePath() { }

	// RVA: 0x175A1D0 Offset: 0x17587D0 VA: 0x18175A1D0
	public bool get_IsFile() { }

	// RVA: 0x5925C0 Offset: 0x590BC0 VA: 0x1805925C0
	public bool get_IsUnc() { }

	// RVA: 0x175A240 Offset: 0x1758840 VA: 0x18175A240
	public string get_LocalPath() { }

	// RVA: 0x1756300 Offset: 0x1754900 VA: 0x181756300 Slot: 0
	public override bool Equals(object comparant) { }

	// RVA: 0x1756DE0 Offset: 0x17553E0 VA: 0x181756DE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1756ED0 Offset: 0x17554D0 VA: 0x181756ED0
	public string GetLeftPart(UriPartial part) { }

	// RVA: 0x1756BE0 Offset: 0x17551E0 VA: 0x181756BE0
	public static int FromHex(char digit) { }

	// RVA: 0x17576C0 Offset: 0x1755CC0 VA: 0x1817576C0
	public static string HexEscape(char character) { }

	// RVA: 0x17577F0 Offset: 0x1755DF0 VA: 0x1817577F0
	public static char HexUnescape(string pattern, ref int index) { }

	// RVA: 0x1757AE0 Offset: 0x17560E0 VA: 0x181757AE0
	public static bool IsHexDigit(char digit) { }

	// RVA: 0x1757B10 Offset: 0x1756110 VA: 0x181757B10
	public static bool IsHexEncoding(string pattern, int index) { }

	// RVA: 0x1759750 Offset: 0x1757D50 VA: 0x181759750 Slot: 3
	public override string ToString() { }

	// RVA: 0x1756900 Offset: 0x1754F00 VA: 0x181756900
	protected static string EscapeString(string str) { }

	// RVA: 0x1756620 Offset: 0x1754C20 VA: 0x181756620
	internal static string EscapeString(string str, bool escapeReserved, bool escapeHex, bool escapeBrackets) { }

	// RVA: 0x1758210 Offset: 0x1756810 VA: 0x181758210
	protected void Parse() { }

	// RVA: 0x1759860 Offset: 0x1757E60 VA: 0x181759860
	protected string Unescape(string str) { }

	// RVA: 0x1759870 Offset: 0x1757E70 VA: 0x181759870
	internal string Unescape(string str, bool excludeSharp) { }

	// RVA: 0x1758030 Offset: 0x1756630 VA: 0x181758030
	private void ParseAsWindowsUNC(string uriString) { }

	// RVA: 0x1757EC0 Offset: 0x17564C0 VA: 0x181757EC0
	private void ParseAsWindowsAbsoluteFilePath(string uriString) { }

	// RVA: 0x1757D30 Offset: 0x1756330 VA: 0x181757D30
	private void ParseAsUnixAbsoluteFilePath(string uriString) { }

	// RVA: 0x1758530 Offset: 0x1756B30 VA: 0x181758530
	private void Parse(string uriString) { }

	// RVA: 0x17594E0 Offset: 0x1757AE0 VA: 0x1817594E0
	private static string Reduce(string path) { }

	// RVA: 0x1757530 Offset: 0x1755B30 VA: 0x181757530
	internal static string GetSchemeDelimiter(string scheme) { }

	// RVA: 0x1756C70 Offset: 0x1755270 VA: 0x181756C70
	internal static int GetDefaultPort(string scheme) { }

	// RVA: 0x1757330 Offset: 0x1755930 VA: 0x181757330
	private string GetOpaqueWiseSchemeDelimiter() { }

	// RVA: 0x1757C40 Offset: 0x1756240 VA: 0x181757C40
	private static bool IsPredefinedScheme(string scheme) { }

	// RVA: 0x17599E0 Offset: 0x1757FE0 VA: 0x1817599E0
	private static void .cctor() { }

}

private struct Uri.UriScheme // TypeDefIndex: 53
{	// Fields
	public string scheme; // 0x0
	public string delimiter; // 0x8
	public int defaultPort; // 0x10

	// Methods

	// RVA: 0x1DBA50 Offset: 0x1DAE50 VA: 0x1801DBA50
	public void .ctor(string s, string d, int p) { }

}

public class Uri : ISerializable // TypeDefIndex: 2568
{	// Fields
	public static readonly string UriSchemeFile; // 0x0
	public static readonly string UriSchemeFtp; // 0x8
	public static readonly string UriSchemeGopher; // 0x10
	public static readonly string UriSchemeHttp; // 0x18
	public static readonly string UriSchemeHttps; // 0x20
	internal static readonly string UriSchemeWs; // 0x28
	internal static readonly string UriSchemeWss; // 0x30
	public static readonly string UriSchemeMailto; // 0x38
	public static readonly string UriSchemeNews; // 0x40
	public static readonly string UriSchemeNntp; // 0x48
	public static readonly string UriSchemeNetTcp; // 0x50
	public static readonly string UriSchemeNetPipe; // 0x58
	public static readonly string SchemeDelimiter; // 0x60
	private const int c_Max16BitUtf8SequenceLength = 12;
	internal const int c_MaxUriBufferSize = 65520;
	private const int c_MaxUriSchemeName = 1024;
	private string m_String; // 0x10
	private string m_originalUnicodeString; // 0x18
	private UriParser m_Syntax; // 0x20
	private string m_DnsSafeHost; // 0x28
	private Uri.Flags m_Flags; // 0x30
	private Uri.UriInfo m_Info; // 0x38
	private bool m_iriParsing; // 0x40
	private static bool s_ConfigInitialized; // 0x68
	private static bool s_ConfigInitializing; // 0x69
	private static UriIdnScope s_IdnScope; // 0x6C
	private static bool s_IriParsing; // 0x70
	private static bool useDotNetRelativeOrAbsolute; // 0x71
	private const UriKind DotNetRelativeOrAbsolute = 300;
	internal static readonly bool IsWindowsFileSystem; // 0x72
	private static object s_initLock; // 0x78
	private const UriFormat V1ToStringUnescape = 32767;
	internal const char c_DummyChar = '\xffff';
	internal const char c_EOL = '\xfffe';
	internal static readonly char[] HexLowerChars; // 0x80
	private static readonly char[] _WSchars; // 0x88

	// Properties
	private bool IsImplicitFile { get; }
	private bool IsUncOrDosPath { get; }
	private bool IsDosPath { get; }
	private bool IsUncPath { get; }
	private Uri.Flags HostType { get; }
	private UriParser Syntax { get; }
	private bool IsNotAbsoluteUri { get; }
	private bool AllowIdn { get; }
	internal bool UserDrivenParsing { get; }
	private ushort SecuredPathIndex { get; }
	public string AbsolutePath { get; }
	private string PrivateAbsolutePath { get; }
	public string AbsoluteUri { get; }
	public string LocalPath { get; }
	public string Authority { get; }
	public UriHostNameType HostNameType { get; }
	public bool IsDefaultPort { get; }
	public bool IsFile { get; }
	public bool IsLoopback { get; }
	public string PathAndQuery { get; }
	public bool IsUnc { get; }
	public string Host { get; }
	private static object InitializeLock { get; }
	public int Port { get; }
	public string Query { get; }
	public string Fragment { get; }
	public string Scheme { get; }
	private bool OriginalStringSwitched { get; }
	public string OriginalString { get; }
	public string DnsSafeHost { get; }
	public bool IsAbsoluteUri { get; }
	public bool UserEscaped { get; }
	public string UserInfo { get; }
	internal bool HasAuthority { get; }

	// Methods

	// RVA: 0x16C80E0 Offset: 0x16C66E0 VA: 0x1816C80E0
	private bool get_IsImplicitFile() { }

	// RVA: 0x16C81C0 Offset: 0x16C67C0 VA: 0x1816C81C0
	private bool get_IsUncOrDosPath() { }

	// RVA: 0x16C8010 Offset: 0x16C6610 VA: 0x1816C8010
	private bool get_IsDosPath() { }

	// RVA: 0x16C81D0 Offset: 0x16C67D0 VA: 0x1816C81D0
	private bool get_IsUncPath() { }

	// RVA: 0x16C7D80 Offset: 0x16C6380 VA: 0x1816C7D80
	private Uri.Flags get_HostType() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	private UriParser get_Syntax() { }

	// RVA: 0x16C81B0 Offset: 0x16C67B0 VA: 0x1816C81B0
	private bool get_IsNotAbsoluteUri() { }

	// RVA: 0x16C22E0 Offset: 0x16C08E0 VA: 0x1816C22E0
	internal static bool IriParsingStatic(UriParser syntax) { }

	// RVA: 0x16C7680 Offset: 0x16C5C80 VA: 0x1816C7680
	private bool get_AllowIdn() { }

	// RVA: 0x16B8900 Offset: 0x16B6F00 VA: 0x1816B8900
	private bool AllowIdnStatic(UriParser syntax, Uri.Flags flags) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private bool IsIntranet(string schemeHost) { }

	// RVA: 0x16C8880 Offset: 0x16C6E80 VA: 0x1816C8880
	internal bool get_UserDrivenParsing() { }

	// RVA: 0x16C5B30 Offset: 0x16C4130 VA: 0x1816C5B30
	private void SetUserDrivenParsing() { }

	// RVA: 0x16C8820 Offset: 0x16C6E20 VA: 0x1816C8820
	private ushort get_SecuredPathIndex() { }

	// RVA: 0x16C26E0 Offset: 0x16C0CE0 VA: 0x1816C26E0
	private bool NotAny(Uri.Flags flags) { }

	// RVA: 0x16C1200 Offset: 0x16BF800 VA: 0x1816C1200
	private bool InFact(Uri.Flags flags) { }

	// RVA: 0x16C5B80 Offset: 0x16C4180 VA: 0x1816C5B80
	private static bool StaticNotAny(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x16C5B50 Offset: 0x16C4150 VA: 0x1816C5B50
	private static bool StaticInFact(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x16BDAF0 Offset: 0x16BC0F0 VA: 0x1816BDAF0
	private Uri.UriInfo EnsureUriInfo() { }

	// RVA: 0x16BDAD0 Offset: 0x16BC0D0 VA: 0x1816BDAD0
	private void EnsureParseRemaining() { }

	// RVA: 0x16BDA70 Offset: 0x16BC070 VA: 0x1816BDA70
	private void EnsureHostString(bool allowDnsOptimization) { }

	// RVA: 0x16C7290 Offset: 0x16C5890 VA: 0x1816C7290
	public void .ctor(string uriString) { }

	// RVA: 0x16C71F0 Offset: 0x16C57F0 VA: 0x1816C71F0
	public void .ctor(string uriString, UriKind uriKind) { }

	// RVA: 0x16C6E70 Offset: 0x16C5470 VA: 0x1816C6E70
	public void .ctor(Uri baseUri, string relativeUri) { }

	// RVA: 0x16BD730 Offset: 0x16BBD30 VA: 0x1816BD730
	private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape) { }

	// RVA: 0x16C6F50 Offset: 0x16C5550 VA: 0x1816C6F50
	public void .ctor(Uri baseUri, Uri relativeUri) { }

	// RVA: 0x16BED00 Offset: 0x16BD300 VA: 0x1816BED00
	private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result) { }

	// RVA: 0x16BF520 Offset: 0x16BDB20 VA: 0x1816BF520
	private static UriFormatException GetException(ParsingError err) { }

	// RVA: 0x16C6C30 Offset: 0x16C5230 VA: 0x1816C6C30
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x16C04F0 Offset: 0x16BEAF0 VA: 0x1816C04F0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x16C04F0 Offset: 0x16BEAF0 VA: 0x1816C04F0
	protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x16C73D0 Offset: 0x16C59D0 VA: 0x1816C73D0
	public string get_AbsolutePath() { }

	// RVA: 0x16C8590 Offset: 0x16C6B90 VA: 0x1816C8590
	private string get_PrivateAbsolutePath() { }

	// RVA: 0x16C7550 Offset: 0x16C5B50 VA: 0x1816C7550
	public string get_AbsoluteUri() { }

	// RVA: 0x16C8270 Offset: 0x16C6870 VA: 0x1816C8270
	public string get_LocalPath() { }

	// RVA: 0x16C7780 Offset: 0x16C5D80 VA: 0x1816C7780
	public string get_Authority() { }

	// RVA: 0x16C7C40 Offset: 0x16C6240 VA: 0x1816C7C40
	public UriHostNameType get_HostNameType() { }

	// RVA: 0x16C7F20 Offset: 0x16C6520 VA: 0x1816C7F20
	public bool get_IsDefaultPort() { }

	// RVA: 0x16C8020 Offset: 0x16C6620 VA: 0x1816C8020
	public bool get_IsFile() { }

	// RVA: 0x16C80F0 Offset: 0x16C66F0 VA: 0x1816C80F0
	public bool get_IsLoopback() { }

	// RVA: 0x16C83C0 Offset: 0x16C69C0 VA: 0x1816C83C0
	public string get_PathAndQuery() { }

	// RVA: 0x16C81E0 Offset: 0x16C67E0 VA: 0x1816C81E0
	public bool get_IsUnc() { }

	// RVA: 0x16C7D90 Offset: 0x16C6390 VA: 0x1816C7D90
	public string get_Host() { }

	// RVA: 0x16C5B60 Offset: 0x16C4160 VA: 0x1816C5B60
	private static bool StaticIsFile(UriParser syntax) { }

	// RVA: 0x16C7E20 Offset: 0x16C6420 VA: 0x1816C7E20
	private static object get_InitializeLock() { }

	// RVA: 0x16C1210 Offset: 0x16BF810 VA: 0x1816C1210
	private static void InitializeUriConfig() { }

	// RVA: 0x16BFC90 Offset: 0x16BE290 VA: 0x1816BFC90
	private string GetLocalPath() { }

	// RVA: 0x16C8490 Offset: 0x16C6A90 VA: 0x1816C8490
	public int get_Port() { }

	// RVA: 0x16C8670 Offset: 0x16C6C70 VA: 0x1816C8670
	public string get_Query() { }

	// RVA: 0x16C7B00 Offset: 0x16C6100 VA: 0x1816C7B00
	public string get_Fragment() { }

	// RVA: 0x16C87A0 Offset: 0x16C6DA0 VA: 0x1816C87A0
	public string get_Scheme() { }

	// RVA: 0x16C82F0 Offset: 0x16C68F0 VA: 0x1816C82F0
	private bool get_OriginalStringSwitched() { }

	// RVA: 0x16C8360 Offset: 0x16C6960 VA: 0x1816C8360
	public string get_OriginalString() { }

	// RVA: 0x16C7810 Offset: 0x16C5E10 VA: 0x1816C7810
	public string get_DnsSafeHost() { }

	// RVA: 0x1235F40 Offset: 0x1234540 VA: 0x181235F40
	public bool get_IsAbsoluteUri() { }

	// RVA: 0x16C8890 Offset: 0x16C6E90 VA: 0x1816C8890
	public bool get_UserEscaped() { }

	// RVA: 0x16C88A0 Offset: 0x16C6EA0 VA: 0x1816C88A0
	public string get_UserInfo() { }

	// RVA: 0x16C2470 Offset: 0x16C0A70 VA: 0x1816C2470
	internal static bool IsGenDelim(char ch) { }

	// RVA: 0x16BB120 Offset: 0x16B9720 VA: 0x1816BB120
	public static bool CheckSchemeName(string schemeName) { }

	// RVA: 0x16C24A0 Offset: 0x16C0AA0 VA: 0x1816C24A0
	public static bool IsHexDigit(char character) { }

	// RVA: 0x16BE480 Offset: 0x16BCA80 VA: 0x1816BE480
	public static int FromHex(char digit) { }

	// RVA: 0x16BF640 Offset: 0x16BDC40 VA: 0x1816BF640 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x16C5D00 Offset: 0x16C4300 VA: 0x1816C5D00 Slot: 3
	public override string ToString() { }

	// RVA: 0x16C8930 Offset: 0x16C6F30 VA: 0x1816C8930
	public static bool op_Equality(Uri uri1, Uri uri2) { }

	// RVA: 0x16C8960 Offset: 0x16C6F60 VA: 0x1816C8960
	public static bool op_Inequality(Uri uri1, Uri uri2) { }

	// RVA: 0x16BDB20 Offset: 0x16BC120 VA: 0x1816BDB20 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x16BA720 Offset: 0x16B8D20 VA: 0x1816BA720
	private static bool CheckForColonInFirstPathSegment(string uriString) { }

	// RVA: 0x16C1CA0 Offset: 0x16C02A0 VA: 0x1816C1CA0
	internal static string InternalEscapeString(string rawString) { }

	// RVA: 0x16C3A10 Offset: 0x16C2010 VA: 0x1816C3A10
	private static ParsingError ParseScheme(string uriString, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x16C26F0 Offset: 0x16C0CF0 VA: 0x1816C26F0
	internal UriFormatException ParseMinimal() { }

	// RVA: 0x16C3C20 Offset: 0x16C2220 VA: 0x1816C3C20
	private ParsingError PrivateParseMinimal() { }

	// RVA: 0x16C3B00 Offset: 0x16C2100 VA: 0x1816C3B00
	private void PrivateParseMinimalIri(string newHost, ushort idx) { }

	// RVA: 0x16BD140 Offset: 0x16BB740 VA: 0x1816BD140
	private void CreateUriInfo(Uri.Flags cF) { }

	// RVA: 0x16BC930 Offset: 0x16BAF30 VA: 0x1816BC930
	private void CreateHostString() { }

	// RVA: 0x16BC760 Offset: 0x16BAD60 VA: 0x1816BC760
	private static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Uri.Flags flags, ref string scopeId) { }

	// RVA: 0x16BF7F0 Offset: 0x16BDDF0 VA: 0x1816BF7F0
	private void GetHostViaCustomSyntax() { }

	// RVA: 0x16BF240 Offset: 0x16BD840 VA: 0x1816BF240
	internal string GetParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x16BF400 Offset: 0x16BDA00 VA: 0x1816BF400
	private string GetEscapedParts(UriComponents uriParts) { }

	// RVA: 0x16C0940 Offset: 0x16BEF40 VA: 0x1816C0940
	private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x16C4450 Offset: 0x16C2A50 VA: 0x1816C4450
	private string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs) { }

	// RVA: 0x16C0A30 Offset: 0x16BF030 VA: 0x1816C0A30
	private string GetUriPartsFromUserString(UriComponents uriParts) { }

	// RVA: 0x16C2770 Offset: 0x16C0D70 VA: 0x1816C2770
	private void ParseRemaining() { }

	// RVA: 0x16C3510 Offset: 0x16C1B10 VA: 0x1816C3510
	private static ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref ParsingError err, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x16BAB70 Offset: 0x16B9170 VA: 0x1816BAB70
	private static bool CheckKnownSchemes(long* lptr, ushort nChars, ref UriParser syntax) { }

	// RVA: 0x16BB260 Offset: 0x16B9860 VA: 0x1816BB260
	private static ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref UriParser syntax) { }

	// RVA: 0x16B9310 Offset: 0x16B7910 VA: 0x1816B9310
	private ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref ParsingError err, ref Uri.Flags flags, UriParser syntax, ref string newHost) { }

	// RVA: 0x16B8DB0 Offset: 0x16B73B0 VA: 0x1816B8DB0
	private void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Uri.Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err) { }

	// RVA: 0x16B8AD0 Offset: 0x16B70D0 VA: 0x1816B8AD0
	private void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Uri.Flags flags, ref string newHost, ref ParsingError err) { }

	// RVA: 0x16BE3D0 Offset: 0x16BC9D0 VA: 0x1816BE3D0
	private void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x16BE330 Offset: 0x16BC930 VA: 0x1816BE330
	private void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x16BA360 Offset: 0x16B8960 VA: 0x1816BA360
	private Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x16BE520 Offset: 0x16BCB20 VA: 0x1816BE520
	private char[] GetCanonicalPath(char[] dest, ref int pos, UriFormat formatAs) { }

	// RVA: 0x16C6590 Offset: 0x16C4B90 VA: 0x1816C6590
	private static void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3) { }

	// RVA: 0x16BBFC0 Offset: 0x16BA5C0 VA: 0x1816BBFC0
	private static char[] Compress(char[] dest, ushort start, ref int destLength, UriParser syntax) { }

	// RVA: 0x16B8A10 Offset: 0x16B7010 VA: 0x1816B8A10
	internal static int CalculateCaseInsensitiveHashCode(string text) { }

	// RVA: 0x16BB390 Offset: 0x16B9990 VA: 0x1816BB390
	private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat) { }

	// RVA: 0x16C7C30 Offset: 0x16C6230 VA: 0x1816C7C30
	internal bool get_HasAuthority() { }

	// RVA: 0x16C24D0 Offset: 0x16C0AD0 VA: 0x1816C24D0
	private static bool IsLWS(char ch) { }

	// RVA: 0x16C2410 Offset: 0x16C0A10 VA: 0x1816C2410
	private static bool IsAsciiLetter(char character) { }

	// RVA: 0x16C2390 Offset: 0x16C0990 VA: 0x1816C2390
	internal static bool IsAsciiLetterOrDigit(char character) { }

	// RVA: 0x16C2430 Offset: 0x16C0A30 VA: 0x1816C2430
	internal static bool IsBidiControlCharacter(char ch) { }

	// RVA: 0x16C5B90 Offset: 0x16C4190 VA: 0x1816C5B90
	internal static string StripBidiControlCharacter(char* strToClean, int start, int length) { }

	// RVA: 0x16BCF90 Offset: 0x16BB590 VA: 0x1816BCF90
	private void CreateThis(string uri, bool dontEscape, UriKind uriKind) { }

	// RVA: 0x16C14D0 Offset: 0x16BFAD0 VA: 0x1816C14D0
	private void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e) { }

	// RVA: 0x16BA7C0 Offset: 0x16B8DC0 VA: 0x1816BA7C0
	private bool CheckForConfigLoad(string data) { }

	// RVA: 0x16BAA30 Offset: 0x16B9030 VA: 0x1816BAA30
	private bool CheckForUnicode(string data) { }

	// RVA: 0x16BA870 Offset: 0x16B8E70 VA: 0x1816BA870
	private bool CheckForEscapedUnreserved(string data) { }

	// RVA: 0x16C6310 Offset: 0x16C4910 VA: 0x1816C6310
	public static bool TryCreate(string uriString, UriKind uriKind, out Uri result) { }

	// RVA: 0x16C5E20 Offset: 0x16C4420 VA: 0x1816C5E20
	public static bool TryCreate(Uri baseUri, string relativeUri, out Uri result) { }

	// RVA: 0x16C6140 Offset: 0x16C4740 VA: 0x1816C6140
	public static bool TryCreate(Uri baseUri, Uri relativeUri, out Uri result) { }

	// RVA: 0x16BF240 Offset: 0x16BD840 VA: 0x1816BF240
	public string GetComponents(UriComponents components, UriFormat format) { }

	// RVA: 0x16C2500 Offset: 0x16C0B00 VA: 0x1816C2500
	public bool IsWellFormedOriginalString() { }

	// RVA: 0x16C2550 Offset: 0x16C0B50 VA: 0x1816C2550
	public static bool IsWellFormedUriString(string uriString, UriKind uriKind) { }

	// RVA: 0x16C1D90 Offset: 0x16C0390 VA: 0x1816C1D90
	internal bool InternalIsWellFormedOriginalString() { }

	// RVA: 0x16C6400 Offset: 0x16C4A00 VA: 0x1816C6400
	public static string UnescapeDataString(string stringToUnescape) { }

	// RVA: 0x16BE2D0 Offset: 0x16BC8D0 VA: 0x1816BE2D0
	internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component) { }

	// RVA: 0x16C7190 Offset: 0x16C5790 VA: 0x1816C7190
	private void .ctor(Uri.Flags flags, UriParser uriParser, string uri) { }

	// RVA: 0x16BC4B0 Offset: 0x16BAAB0 VA: 0x1816BC4B0
	internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e) { }

	// RVA: 0x16C55D0 Offset: 0x16C3BD0 VA: 0x1816C55D0
	internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e) { }

	// RVA: 0x16C05C0 Offset: 0x16BEBC0 VA: 0x1816C05C0
	private string GetRelativeSerializationString(UriFormat format) { }

	// RVA: 0x16BEF20 Offset: 0x16BD520 VA: 0x1816BEF20
	internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0x16BCDE0 Offset: 0x16BB3E0 VA: 0x1816BCDE0
	private void CreateThisFromUri(Uri otherUri) { }

	// RVA: 0x16C67B0 Offset: 0x16C4DB0 VA: 0x1816C67B0
	private static void .cctor() { }

}

private enum Uri.Flags // TypeDefIndex: 2569
{	// Fields
	public ulong value__; // 0x0
	public const Uri.Flags Zero = 0;
	public const Uri.Flags SchemeNotCanonical = 1;
	public const Uri.Flags UserNotCanonical = 2;
	public const Uri.Flags HostNotCanonical = 4;
	public const Uri.Flags PortNotCanonical = 8;
	public const Uri.Flags PathNotCanonical = 16;
	public const Uri.Flags QueryNotCanonical = 32;
	public const Uri.Flags FragmentNotCanonical = 64;
	public const Uri.Flags CannotDisplayCanonical = 127;
	public const Uri.Flags E_UserNotCanonical = 128;
	public const Uri.Flags E_HostNotCanonical = 256;
	public const Uri.Flags E_PortNotCanonical = 512;
	public const Uri.Flags E_PathNotCanonical = 1024;
	public const Uri.Flags E_QueryNotCanonical = 2048;
	public const Uri.Flags E_FragmentNotCanonical = 4096;
	public const Uri.Flags E_CannotDisplayCanonical = 8064;
	public const Uri.Flags ShouldBeCompressed = 8192;
	public const Uri.Flags FirstSlashAbsent = 16384;
	public const Uri.Flags BackslashInPath = 32768;
	public const Uri.Flags IndexMask = 65535;
	public const Uri.Flags HostTypeMask = 458752;
	public const Uri.Flags HostNotParsed = 0;
	public const Uri.Flags IPv6HostType = 65536;
	public const Uri.Flags IPv4HostType = 131072;
	public const Uri.Flags DnsHostType = 196608;
	public const Uri.Flags UncHostType = 262144;
	public const Uri.Flags BasicHostType = 327680;
	public const Uri.Flags UnusedHostType = 393216;
	public const Uri.Flags UnknownHostType = 458752;
	public const Uri.Flags UserEscaped = 524288;
	public const Uri.Flags AuthorityFound = 1048576;
	public const Uri.Flags HasUserInfo = 2097152;
	public const Uri.Flags LoopbackHost = 4194304;
	public const Uri.Flags NotDefaultPort = 8388608;
	public const Uri.Flags UserDrivenParsing = 16777216;
	public const Uri.Flags CanonicalDnsHost = 33554432;
	public const Uri.Flags ErrorOrParsingRecursion = 67108864;
	public const Uri.Flags DosPath = 134217728;
	public const Uri.Flags UncPath = 268435456;
	public const Uri.Flags ImplicitFile = 536870912;
	public const Uri.Flags MinimalUriInfoSet = 1073741824;
	public const Uri.Flags AllUriInfoSet = 2147483648;
	public const Uri.Flags IdnHost = 4294967296;
	public const Uri.Flags HasUnicode = 8589934592;
	public const Uri.Flags HostUnicodeNormalized = 17179869184;
	public const Uri.Flags RestUnicodeNormalized = 34359738368;
	public const Uri.Flags UnicodeHost = 68719476736;
	public const Uri.Flags IntranetUri = 137438953472;
	public const Uri.Flags UseOrigUncdStrOffset = 274877906944;
	public const Uri.Flags UserIriCanonical = 549755813888;
	public const Uri.Flags PathIriCanonical = 1099511627776;
	public const Uri.Flags QueryIriCanonical = 2199023255552;
	public const Uri.Flags FragmentIriCanonical = 4398046511104;
	public const Uri.Flags IriCanonical = 8246337208320;
	public const Uri.Flags CompressedSlashes = 17592186044416;

}

private class Uri.UriInfo // TypeDefIndex: 2570
{	// Fields
	public string Host; // 0x10
	public string ScopeId; // 0x18
	public string String; // 0x20
	public Uri.Offset Offset; // 0x28
	public string DnsSafeHost; // 0x38
	public Uri.MoreInfo MoreInfo; // 0x40

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private struct Uri.Offset // TypeDefIndex: 2571
{	// Fields
	public ushort Scheme; // 0x0
	public ushort User; // 0x2
	public ushort Host; // 0x4
	public ushort PortValue; // 0x6
	public ushort Path; // 0x8
	public ushort Query; // 0xA
	public ushort Fragment; // 0xC
	public ushort End; // 0xE

}

private class Uri.MoreInfo // TypeDefIndex: 2572
{	// Fields
	public string Path; // 0x10
	public string Query; // 0x18
	public string Fragment; // 0x20
	public string AbsoluteUri; // 0x28
	public int Hash; // 0x30
	public string RemoteUrl; // 0x38

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private enum Uri.Check // TypeDefIndex: 2573
{	// Fields
	public int value__; // 0x0
	public const Uri.Check None = 0;
	public const Uri.Check EscapedCanonical = 1;
	public const Uri.Check DisplayCanonical = 2;
	public const Uri.Check DotSlashAttn = 4;
	public const Uri.Check DotSlashEscaped = 128;
	public const Uri.Check BackslashInPath = 16;
	public const Uri.Check ReservedFound = 32;
	public const Uri.Check NotIriCanonical = 64;
	public const Uri.Check FoundNonAscii = 8;

}

