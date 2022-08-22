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

	// RVA: 0x175C4F0 Offset: 0x175AAF0 VA: 0x18175C4F0
	public void .ctor(string uriString) { }

	// RVA: 0x175C3C0 Offset: 0x175A9C0 VA: 0x18175C3C0
	public void .ctor(string uriString, bool dontEscape) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_AbsolutePath() { }

	// RVA: 0x175C610 Offset: 0x175AC10 VA: 0x18175C610
	public bool get_IsFile() { }

	// RVA: 0x592630 Offset: 0x590C30 VA: 0x180592630
	public bool get_IsUnc() { }

	// RVA: 0x175C680 Offset: 0x175AC80 VA: 0x18175C680
	public string get_LocalPath() { }

	// RVA: 0x1758740 Offset: 0x1756D40 VA: 0x181758740 Slot: 0
	public override bool Equals(object comparant) { }

	// RVA: 0x1759220 Offset: 0x1757820 VA: 0x181759220 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1759310 Offset: 0x1757910 VA: 0x181759310
	public string GetLeftPart(UriPartial part) { }

	// RVA: 0x1759020 Offset: 0x1757620 VA: 0x181759020
	public static int FromHex(char digit) { }

	// RVA: 0x1759B00 Offset: 0x1758100 VA: 0x181759B00
	public static string HexEscape(char character) { }

	// RVA: 0x1759C30 Offset: 0x1758230 VA: 0x181759C30
	public static char HexUnescape(string pattern, ref int index) { }

	// RVA: 0x1759F20 Offset: 0x1758520 VA: 0x181759F20
	public static bool IsHexDigit(char digit) { }

	// RVA: 0x1759F50 Offset: 0x1758550 VA: 0x181759F50
	public static bool IsHexEncoding(string pattern, int index) { }

	// RVA: 0x175BB90 Offset: 0x175A190 VA: 0x18175BB90 Slot: 3
	public override string ToString() { }

	// RVA: 0x1758D40 Offset: 0x1757340 VA: 0x181758D40
	protected static string EscapeString(string str) { }

	// RVA: 0x1758A60 Offset: 0x1757060 VA: 0x181758A60
	internal static string EscapeString(string str, bool escapeReserved, bool escapeHex, bool escapeBrackets) { }

	// RVA: 0x175A650 Offset: 0x1758C50 VA: 0x18175A650
	protected void Parse() { }

	// RVA: 0x175BCA0 Offset: 0x175A2A0 VA: 0x18175BCA0
	protected string Unescape(string str) { }

	// RVA: 0x175BCB0 Offset: 0x175A2B0 VA: 0x18175BCB0
	internal string Unescape(string str, bool excludeSharp) { }

	// RVA: 0x175A470 Offset: 0x1758A70 VA: 0x18175A470
	private void ParseAsWindowsUNC(string uriString) { }

	// RVA: 0x175A300 Offset: 0x1758900 VA: 0x18175A300
	private void ParseAsWindowsAbsoluteFilePath(string uriString) { }

	// RVA: 0x175A170 Offset: 0x1758770 VA: 0x18175A170
	private void ParseAsUnixAbsoluteFilePath(string uriString) { }

	// RVA: 0x175A970 Offset: 0x1758F70 VA: 0x18175A970
	private void Parse(string uriString) { }

	// RVA: 0x175B920 Offset: 0x1759F20 VA: 0x18175B920
	private static string Reduce(string path) { }

	// RVA: 0x1759970 Offset: 0x1757F70 VA: 0x181759970
	internal static string GetSchemeDelimiter(string scheme) { }

	// RVA: 0x17590B0 Offset: 0x17576B0 VA: 0x1817590B0
	internal static int GetDefaultPort(string scheme) { }

	// RVA: 0x1759770 Offset: 0x1757D70 VA: 0x181759770
	private string GetOpaqueWiseSchemeDelimiter() { }

	// RVA: 0x175A080 Offset: 0x1758680 VA: 0x18175A080
	private static bool IsPredefinedScheme(string scheme) { }

	// RVA: 0x175BE20 Offset: 0x175A420 VA: 0x18175BE20
	private static void .cctor() { }

}

private struct Uri.UriScheme // TypeDefIndex: 53
{	// Fields
	public string scheme; // 0x0
	public string delimiter; // 0x8
	public int defaultPort; // 0x10

	// Methods

	// RVA: 0x1DB3E0 Offset: 0x1DA7E0 VA: 0x1801DB3E0
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

	// RVA: 0x16CA4F0 Offset: 0x16C8AF0 VA: 0x1816CA4F0
	private bool get_IsImplicitFile() { }

	// RVA: 0x16CA5D0 Offset: 0x16C8BD0 VA: 0x1816CA5D0
	private bool get_IsUncOrDosPath() { }

	// RVA: 0x16CA420 Offset: 0x16C8A20 VA: 0x1816CA420
	private bool get_IsDosPath() { }

	// RVA: 0x16CA5E0 Offset: 0x16C8BE0 VA: 0x1816CA5E0
	private bool get_IsUncPath() { }

	// RVA: 0x16CA190 Offset: 0x16C8790 VA: 0x1816CA190
	private Uri.Flags get_HostType() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	private UriParser get_Syntax() { }

	// RVA: 0x16CA5C0 Offset: 0x16C8BC0 VA: 0x1816CA5C0
	private bool get_IsNotAbsoluteUri() { }

	// RVA: 0x16C46F0 Offset: 0x16C2CF0 VA: 0x1816C46F0
	internal static bool IriParsingStatic(UriParser syntax) { }

	// RVA: 0x16C9A90 Offset: 0x16C8090 VA: 0x1816C9A90
	private bool get_AllowIdn() { }

	// RVA: 0x16BAD10 Offset: 0x16B9310 VA: 0x1816BAD10
	private bool AllowIdnStatic(UriParser syntax, Uri.Flags flags) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private bool IsIntranet(string schemeHost) { }

	// RVA: 0x16CAC90 Offset: 0x16C9290 VA: 0x1816CAC90
	internal bool get_UserDrivenParsing() { }

	// RVA: 0x16C7F40 Offset: 0x16C6540 VA: 0x1816C7F40
	private void SetUserDrivenParsing() { }

	// RVA: 0x16CAC30 Offset: 0x16C9230 VA: 0x1816CAC30
	private ushort get_SecuredPathIndex() { }

	// RVA: 0x16C4AF0 Offset: 0x16C30F0 VA: 0x1816C4AF0
	private bool NotAny(Uri.Flags flags) { }

	// RVA: 0x16C3610 Offset: 0x16C1C10 VA: 0x1816C3610
	private bool InFact(Uri.Flags flags) { }

	// RVA: 0x16C7F90 Offset: 0x16C6590 VA: 0x1816C7F90
	private static bool StaticNotAny(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x16C7F60 Offset: 0x16C6560 VA: 0x1816C7F60
	private static bool StaticInFact(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x16BFF00 Offset: 0x16BE500 VA: 0x1816BFF00
	private Uri.UriInfo EnsureUriInfo() { }

	// RVA: 0x16BFEE0 Offset: 0x16BE4E0 VA: 0x1816BFEE0
	private void EnsureParseRemaining() { }

	// RVA: 0x16BFE80 Offset: 0x16BE480 VA: 0x1816BFE80
	private void EnsureHostString(bool allowDnsOptimization) { }

	// RVA: 0x16C96A0 Offset: 0x16C7CA0 VA: 0x1816C96A0
	public void .ctor(string uriString) { }

	// RVA: 0x16C9600 Offset: 0x16C7C00 VA: 0x1816C9600
	public void .ctor(string uriString, UriKind uriKind) { }

	// RVA: 0x16C9280 Offset: 0x16C7880 VA: 0x1816C9280
	public void .ctor(Uri baseUri, string relativeUri) { }

	// RVA: 0x16BFB40 Offset: 0x16BE140 VA: 0x1816BFB40
	private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape) { }

	// RVA: 0x16C9360 Offset: 0x16C7960 VA: 0x1816C9360
	public void .ctor(Uri baseUri, Uri relativeUri) { }

	// RVA: 0x16C1110 Offset: 0x16BF710 VA: 0x1816C1110
	private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result) { }

	// RVA: 0x16C1930 Offset: 0x16BFF30 VA: 0x1816C1930
	private static UriFormatException GetException(ParsingError err) { }

	// RVA: 0x16C9040 Offset: 0x16C7640 VA: 0x1816C9040
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x16C2900 Offset: 0x16C0F00 VA: 0x1816C2900 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x16C2900 Offset: 0x16C0F00 VA: 0x1816C2900
	protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x16C97E0 Offset: 0x16C7DE0 VA: 0x1816C97E0
	public string get_AbsolutePath() { }

	// RVA: 0x16CA9A0 Offset: 0x16C8FA0 VA: 0x1816CA9A0
	private string get_PrivateAbsolutePath() { }

	// RVA: 0x16C9960 Offset: 0x16C7F60 VA: 0x1816C9960
	public string get_AbsoluteUri() { }

	// RVA: 0x16CA680 Offset: 0x16C8C80 VA: 0x1816CA680
	public string get_LocalPath() { }

	// RVA: 0x16C9B90 Offset: 0x16C8190 VA: 0x1816C9B90
	public string get_Authority() { }

	// RVA: 0x16CA050 Offset: 0x16C8650 VA: 0x1816CA050
	public UriHostNameType get_HostNameType() { }

	// RVA: 0x16CA330 Offset: 0x16C8930 VA: 0x1816CA330
	public bool get_IsDefaultPort() { }

	// RVA: 0x16CA430 Offset: 0x16C8A30 VA: 0x1816CA430
	public bool get_IsFile() { }

	// RVA: 0x16CA500 Offset: 0x16C8B00 VA: 0x1816CA500
	public bool get_IsLoopback() { }

	// RVA: 0x16CA7D0 Offset: 0x16C8DD0 VA: 0x1816CA7D0
	public string get_PathAndQuery() { }

	// RVA: 0x16CA5F0 Offset: 0x16C8BF0 VA: 0x1816CA5F0
	public bool get_IsUnc() { }

	// RVA: 0x16CA1A0 Offset: 0x16C87A0 VA: 0x1816CA1A0
	public string get_Host() { }

	// RVA: 0x16C7F70 Offset: 0x16C6570 VA: 0x1816C7F70
	private static bool StaticIsFile(UriParser syntax) { }

	// RVA: 0x16CA230 Offset: 0x16C8830 VA: 0x1816CA230
	private static object get_InitializeLock() { }

	// RVA: 0x16C3620 Offset: 0x16C1C20 VA: 0x1816C3620
	private static void InitializeUriConfig() { }

	// RVA: 0x16C20A0 Offset: 0x16C06A0 VA: 0x1816C20A0
	private string GetLocalPath() { }

	// RVA: 0x16CA8A0 Offset: 0x16C8EA0 VA: 0x1816CA8A0
	public int get_Port() { }

	// RVA: 0x16CAA80 Offset: 0x16C9080 VA: 0x1816CAA80
	public string get_Query() { }

	// RVA: 0x16C9F10 Offset: 0x16C8510 VA: 0x1816C9F10
	public string get_Fragment() { }

	// RVA: 0x16CABB0 Offset: 0x16C91B0 VA: 0x1816CABB0
	public string get_Scheme() { }

	// RVA: 0x16CA700 Offset: 0x16C8D00 VA: 0x1816CA700
	private bool get_OriginalStringSwitched() { }

	// RVA: 0x16CA770 Offset: 0x16C8D70 VA: 0x1816CA770
	public string get_OriginalString() { }

	// RVA: 0x16C9C20 Offset: 0x16C8220 VA: 0x1816C9C20
	public string get_DnsSafeHost() { }

	// RVA: 0x12358A0 Offset: 0x1233EA0 VA: 0x1812358A0
	public bool get_IsAbsoluteUri() { }

	// RVA: 0x16CACA0 Offset: 0x16C92A0 VA: 0x1816CACA0
	public bool get_UserEscaped() { }

	// RVA: 0x16CACB0 Offset: 0x16C92B0 VA: 0x1816CACB0
	public string get_UserInfo() { }

	// RVA: 0x16C4880 Offset: 0x16C2E80 VA: 0x1816C4880
	internal static bool IsGenDelim(char ch) { }

	// RVA: 0x16BD530 Offset: 0x16BBB30 VA: 0x1816BD530
	public static bool CheckSchemeName(string schemeName) { }

	// RVA: 0x16C48B0 Offset: 0x16C2EB0 VA: 0x1816C48B0
	public static bool IsHexDigit(char character) { }

	// RVA: 0x16C0890 Offset: 0x16BEE90 VA: 0x1816C0890
	public static int FromHex(char digit) { }

	// RVA: 0x16C1A50 Offset: 0x16C0050 VA: 0x1816C1A50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x16C8110 Offset: 0x16C6710 VA: 0x1816C8110 Slot: 3
	public override string ToString() { }

	// RVA: 0x16CAD40 Offset: 0x16C9340 VA: 0x1816CAD40
	public static bool op_Equality(Uri uri1, Uri uri2) { }

	// RVA: 0x16CAD70 Offset: 0x16C9370 VA: 0x1816CAD70
	public static bool op_Inequality(Uri uri1, Uri uri2) { }

	// RVA: 0x16BFF30 Offset: 0x16BE530 VA: 0x1816BFF30 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x16BCB30 Offset: 0x16BB130 VA: 0x1816BCB30
	private static bool CheckForColonInFirstPathSegment(string uriString) { }

	// RVA: 0x16C40B0 Offset: 0x16C26B0 VA: 0x1816C40B0
	internal static string InternalEscapeString(string rawString) { }

	// RVA: 0x16C5E20 Offset: 0x16C4420 VA: 0x1816C5E20
	private static ParsingError ParseScheme(string uriString, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x16C4B00 Offset: 0x16C3100 VA: 0x1816C4B00
	internal UriFormatException ParseMinimal() { }

	// RVA: 0x16C6030 Offset: 0x16C4630 VA: 0x1816C6030
	private ParsingError PrivateParseMinimal() { }

	// RVA: 0x16C5F10 Offset: 0x16C4510 VA: 0x1816C5F10
	private void PrivateParseMinimalIri(string newHost, ushort idx) { }

	// RVA: 0x16BF550 Offset: 0x16BDB50 VA: 0x1816BF550
	private void CreateUriInfo(Uri.Flags cF) { }

	// RVA: 0x16BED40 Offset: 0x16BD340 VA: 0x1816BED40
	private void CreateHostString() { }

	// RVA: 0x16BEB70 Offset: 0x16BD170 VA: 0x1816BEB70
	private static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Uri.Flags flags, ref string scopeId) { }

	// RVA: 0x16C1C00 Offset: 0x16C0200 VA: 0x1816C1C00
	private void GetHostViaCustomSyntax() { }

	// RVA: 0x16C1650 Offset: 0x16BFC50 VA: 0x1816C1650
	internal string GetParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x16C1810 Offset: 0x16BFE10 VA: 0x1816C1810
	private string GetEscapedParts(UriComponents uriParts) { }

	// RVA: 0x16C2D50 Offset: 0x16C1350 VA: 0x1816C2D50
	private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x16C6860 Offset: 0x16C4E60 VA: 0x1816C6860
	private string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs) { }

	// RVA: 0x16C2E40 Offset: 0x16C1440 VA: 0x1816C2E40
	private string GetUriPartsFromUserString(UriComponents uriParts) { }

	// RVA: 0x16C4B80 Offset: 0x16C3180 VA: 0x1816C4B80
	private void ParseRemaining() { }

	// RVA: 0x16C5920 Offset: 0x16C3F20 VA: 0x1816C5920
	private static ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref ParsingError err, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x16BCF80 Offset: 0x16BB580 VA: 0x1816BCF80
	private static bool CheckKnownSchemes(long* lptr, ushort nChars, ref UriParser syntax) { }

	// RVA: 0x16BD670 Offset: 0x16BBC70 VA: 0x1816BD670
	private static ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref UriParser syntax) { }

	// RVA: 0x16BB720 Offset: 0x16B9D20 VA: 0x1816BB720
	private ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref ParsingError err, ref Uri.Flags flags, UriParser syntax, ref string newHost) { }

	// RVA: 0x16BB1C0 Offset: 0x16B97C0 VA: 0x1816BB1C0
	private void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Uri.Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err) { }

	// RVA: 0x16BAEE0 Offset: 0x16B94E0 VA: 0x1816BAEE0
	private void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Uri.Flags flags, ref string newHost, ref ParsingError err) { }

	// RVA: 0x16C07E0 Offset: 0x16BEDE0 VA: 0x1816C07E0
	private void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x16C0740 Offset: 0x16BED40 VA: 0x1816C0740
	private void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x16BC770 Offset: 0x16BAD70 VA: 0x1816BC770
	private Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x16C0930 Offset: 0x16BEF30 VA: 0x1816C0930
	private char[] GetCanonicalPath(char[] dest, ref int pos, UriFormat formatAs) { }

	// RVA: 0x16C89A0 Offset: 0x16C6FA0 VA: 0x1816C89A0
	private static void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3) { }

	// RVA: 0x16BE3D0 Offset: 0x16BC9D0 VA: 0x1816BE3D0
	private static char[] Compress(char[] dest, ushort start, ref int destLength, UriParser syntax) { }

	// RVA: 0x16BAE20 Offset: 0x16B9420 VA: 0x1816BAE20
	internal static int CalculateCaseInsensitiveHashCode(string text) { }

	// RVA: 0x16BD7A0 Offset: 0x16BBDA0 VA: 0x1816BD7A0
	private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat) { }

	// RVA: 0x16CA040 Offset: 0x16C8640 VA: 0x1816CA040
	internal bool get_HasAuthority() { }

	// RVA: 0x16C48E0 Offset: 0x16C2EE0 VA: 0x1816C48E0
	private static bool IsLWS(char ch) { }

	// RVA: 0x16C4820 Offset: 0x16C2E20 VA: 0x1816C4820
	private static bool IsAsciiLetter(char character) { }

	// RVA: 0x16C47A0 Offset: 0x16C2DA0 VA: 0x1816C47A0
	internal static bool IsAsciiLetterOrDigit(char character) { }

	// RVA: 0x16C4840 Offset: 0x16C2E40 VA: 0x1816C4840
	internal static bool IsBidiControlCharacter(char ch) { }

	// RVA: 0x16C7FA0 Offset: 0x16C65A0 VA: 0x1816C7FA0
	internal static string StripBidiControlCharacter(char* strToClean, int start, int length) { }

	// RVA: 0x16BF3A0 Offset: 0x16BD9A0 VA: 0x1816BF3A0
	private void CreateThis(string uri, bool dontEscape, UriKind uriKind) { }

	// RVA: 0x16C38E0 Offset: 0x16C1EE0 VA: 0x1816C38E0
	private void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e) { }

	// RVA: 0x16BCBD0 Offset: 0x16BB1D0 VA: 0x1816BCBD0
	private bool CheckForConfigLoad(string data) { }

	// RVA: 0x16BCE40 Offset: 0x16BB440 VA: 0x1816BCE40
	private bool CheckForUnicode(string data) { }

	// RVA: 0x16BCC80 Offset: 0x16BB280 VA: 0x1816BCC80
	private bool CheckForEscapedUnreserved(string data) { }

	// RVA: 0x16C8720 Offset: 0x16C6D20 VA: 0x1816C8720
	public static bool TryCreate(string uriString, UriKind uriKind, out Uri result) { }

	// RVA: 0x16C8230 Offset: 0x16C6830 VA: 0x1816C8230
	public static bool TryCreate(Uri baseUri, string relativeUri, out Uri result) { }

	// RVA: 0x16C8550 Offset: 0x16C6B50 VA: 0x1816C8550
	public static bool TryCreate(Uri baseUri, Uri relativeUri, out Uri result) { }

	// RVA: 0x16C1650 Offset: 0x16BFC50 VA: 0x1816C1650
	public string GetComponents(UriComponents components, UriFormat format) { }

	// RVA: 0x16C4910 Offset: 0x16C2F10 VA: 0x1816C4910
	public bool IsWellFormedOriginalString() { }

	// RVA: 0x16C4960 Offset: 0x16C2F60 VA: 0x1816C4960
	public static bool IsWellFormedUriString(string uriString, UriKind uriKind) { }

	// RVA: 0x16C41A0 Offset: 0x16C27A0 VA: 0x1816C41A0
	internal bool InternalIsWellFormedOriginalString() { }

	// RVA: 0x16C8810 Offset: 0x16C6E10 VA: 0x1816C8810
	public static string UnescapeDataString(string stringToUnescape) { }

	// RVA: 0x16C06E0 Offset: 0x16BECE0 VA: 0x1816C06E0
	internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component) { }

	// RVA: 0x16C95A0 Offset: 0x16C7BA0 VA: 0x1816C95A0
	private void .ctor(Uri.Flags flags, UriParser uriParser, string uri) { }

	// RVA: 0x16BE8C0 Offset: 0x16BCEC0 VA: 0x1816BE8C0
	internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e) { }

	// RVA: 0x16C79E0 Offset: 0x16C5FE0 VA: 0x1816C79E0
	internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e) { }

	// RVA: 0x16C29D0 Offset: 0x16C0FD0 VA: 0x1816C29D0
	private string GetRelativeSerializationString(UriFormat format) { }

	// RVA: 0x16C1330 Offset: 0x16BF930 VA: 0x1816C1330
	internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0x16BF1F0 Offset: 0x16BD7F0 VA: 0x1816BF1F0
	private void CreateThisFromUri(Uri otherUri) { }

	// RVA: 0x16C8BC0 Offset: 0x16C71C0 VA: 0x1816C8BC0
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

