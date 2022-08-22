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

	// RVA: 0x175C230 Offset: 0x175A830 VA: 0x18175C230
	public void .ctor(string uriString) { }

	// RVA: 0x175C100 Offset: 0x175A700 VA: 0x18175C100
	public void .ctor(string uriString, bool dontEscape) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_AbsolutePath() { }

	// RVA: 0x175C350 Offset: 0x175A950 VA: 0x18175C350
	public bool get_IsFile() { }

	// RVA: 0x592630 Offset: 0x590C30 VA: 0x180592630
	public bool get_IsUnc() { }

	// RVA: 0x175C3C0 Offset: 0x175A9C0 VA: 0x18175C3C0
	public string get_LocalPath() { }

	// RVA: 0x1758480 Offset: 0x1756A80 VA: 0x181758480 Slot: 0
	public override bool Equals(object comparant) { }

	// RVA: 0x1758F60 Offset: 0x1757560 VA: 0x181758F60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1759050 Offset: 0x1757650 VA: 0x181759050
	public string GetLeftPart(UriPartial part) { }

	// RVA: 0x1758D60 Offset: 0x1757360 VA: 0x181758D60
	public static int FromHex(char digit) { }

	// RVA: 0x1759840 Offset: 0x1757E40 VA: 0x181759840
	public static string HexEscape(char character) { }

	// RVA: 0x1759970 Offset: 0x1757F70 VA: 0x181759970
	public static char HexUnescape(string pattern, ref int index) { }

	// RVA: 0x1759C60 Offset: 0x1758260 VA: 0x181759C60
	public static bool IsHexDigit(char digit) { }

	// RVA: 0x1759C90 Offset: 0x1758290 VA: 0x181759C90
	public static bool IsHexEncoding(string pattern, int index) { }

	// RVA: 0x175B8D0 Offset: 0x1759ED0 VA: 0x18175B8D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1758A80 Offset: 0x1757080 VA: 0x181758A80
	protected static string EscapeString(string str) { }

	// RVA: 0x17587A0 Offset: 0x1756DA0 VA: 0x1817587A0
	internal static string EscapeString(string str, bool escapeReserved, bool escapeHex, bool escapeBrackets) { }

	// RVA: 0x175A390 Offset: 0x1758990 VA: 0x18175A390
	protected void Parse() { }

	// RVA: 0x175B9E0 Offset: 0x1759FE0 VA: 0x18175B9E0
	protected string Unescape(string str) { }

	// RVA: 0x175B9F0 Offset: 0x1759FF0 VA: 0x18175B9F0
	internal string Unescape(string str, bool excludeSharp) { }

	// RVA: 0x175A1B0 Offset: 0x17587B0 VA: 0x18175A1B0
	private void ParseAsWindowsUNC(string uriString) { }

	// RVA: 0x175A040 Offset: 0x1758640 VA: 0x18175A040
	private void ParseAsWindowsAbsoluteFilePath(string uriString) { }

	// RVA: 0x1759EB0 Offset: 0x17584B0 VA: 0x181759EB0
	private void ParseAsUnixAbsoluteFilePath(string uriString) { }

	// RVA: 0x175A6B0 Offset: 0x1758CB0 VA: 0x18175A6B0
	private void Parse(string uriString) { }

	// RVA: 0x175B660 Offset: 0x1759C60 VA: 0x18175B660
	private static string Reduce(string path) { }

	// RVA: 0x17596B0 Offset: 0x1757CB0 VA: 0x1817596B0
	internal static string GetSchemeDelimiter(string scheme) { }

	// RVA: 0x1758DF0 Offset: 0x17573F0 VA: 0x181758DF0
	internal static int GetDefaultPort(string scheme) { }

	// RVA: 0x17594B0 Offset: 0x1757AB0 VA: 0x1817594B0
	private string GetOpaqueWiseSchemeDelimiter() { }

	// RVA: 0x1759DC0 Offset: 0x17583C0 VA: 0x181759DC0
	private static bool IsPredefinedScheme(string scheme) { }

	// RVA: 0x175BB60 Offset: 0x175A160 VA: 0x18175BB60
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

	// RVA: 0x16CA230 Offset: 0x16C8830 VA: 0x1816CA230
	private bool get_IsImplicitFile() { }

	// RVA: 0x16CA310 Offset: 0x16C8910 VA: 0x1816CA310
	private bool get_IsUncOrDosPath() { }

	// RVA: 0x16CA160 Offset: 0x16C8760 VA: 0x1816CA160
	private bool get_IsDosPath() { }

	// RVA: 0x16CA320 Offset: 0x16C8920 VA: 0x1816CA320
	private bool get_IsUncPath() { }

	// RVA: 0x16C9ED0 Offset: 0x16C84D0 VA: 0x1816C9ED0
	private Uri.Flags get_HostType() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	private UriParser get_Syntax() { }

	// RVA: 0x16CA300 Offset: 0x16C8900 VA: 0x1816CA300
	private bool get_IsNotAbsoluteUri() { }

	// RVA: 0x16C4430 Offset: 0x16C2A30 VA: 0x1816C4430
	internal static bool IriParsingStatic(UriParser syntax) { }

	// RVA: 0x16C97D0 Offset: 0x16C7DD0 VA: 0x1816C97D0
	private bool get_AllowIdn() { }

	// RVA: 0x16BAA50 Offset: 0x16B9050 VA: 0x1816BAA50
	private bool AllowIdnStatic(UriParser syntax, Uri.Flags flags) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private bool IsIntranet(string schemeHost) { }

	// RVA: 0x16CA9D0 Offset: 0x16C8FD0 VA: 0x1816CA9D0
	internal bool get_UserDrivenParsing() { }

	// RVA: 0x16C7C80 Offset: 0x16C6280 VA: 0x1816C7C80
	private void SetUserDrivenParsing() { }

	// RVA: 0x16CA970 Offset: 0x16C8F70 VA: 0x1816CA970
	private ushort get_SecuredPathIndex() { }

	// RVA: 0x16C4830 Offset: 0x16C2E30 VA: 0x1816C4830
	private bool NotAny(Uri.Flags flags) { }

	// RVA: 0x16C3350 Offset: 0x16C1950 VA: 0x1816C3350
	private bool InFact(Uri.Flags flags) { }

	// RVA: 0x16C7CD0 Offset: 0x16C62D0 VA: 0x1816C7CD0
	private static bool StaticNotAny(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x16C7CA0 Offset: 0x16C62A0 VA: 0x1816C7CA0
	private static bool StaticInFact(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x16BFC40 Offset: 0x16BE240 VA: 0x1816BFC40
	private Uri.UriInfo EnsureUriInfo() { }

	// RVA: 0x16BFC20 Offset: 0x16BE220 VA: 0x1816BFC20
	private void EnsureParseRemaining() { }

	// RVA: 0x16BFBC0 Offset: 0x16BE1C0 VA: 0x1816BFBC0
	private void EnsureHostString(bool allowDnsOptimization) { }

	// RVA: 0x16C93E0 Offset: 0x16C79E0 VA: 0x1816C93E0
	public void .ctor(string uriString) { }

	// RVA: 0x16C9340 Offset: 0x16C7940 VA: 0x1816C9340
	public void .ctor(string uriString, UriKind uriKind) { }

	// RVA: 0x16C8FC0 Offset: 0x16C75C0 VA: 0x1816C8FC0
	public void .ctor(Uri baseUri, string relativeUri) { }

	// RVA: 0x16BF880 Offset: 0x16BDE80 VA: 0x1816BF880
	private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape) { }

	// RVA: 0x16C90A0 Offset: 0x16C76A0 VA: 0x1816C90A0
	public void .ctor(Uri baseUri, Uri relativeUri) { }

	// RVA: 0x16C0E50 Offset: 0x16BF450 VA: 0x1816C0E50
	private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result) { }

	// RVA: 0x16C1670 Offset: 0x16BFC70 VA: 0x1816C1670
	private static UriFormatException GetException(ParsingError err) { }

	// RVA: 0x16C8D80 Offset: 0x16C7380 VA: 0x1816C8D80
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x16C2640 Offset: 0x16C0C40 VA: 0x1816C2640 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x16C2640 Offset: 0x16C0C40 VA: 0x1816C2640
	protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x16C9520 Offset: 0x16C7B20 VA: 0x1816C9520
	public string get_AbsolutePath() { }

	// RVA: 0x16CA6E0 Offset: 0x16C8CE0 VA: 0x1816CA6E0
	private string get_PrivateAbsolutePath() { }

	// RVA: 0x16C96A0 Offset: 0x16C7CA0 VA: 0x1816C96A0
	public string get_AbsoluteUri() { }

	// RVA: 0x16CA3C0 Offset: 0x16C89C0 VA: 0x1816CA3C0
	public string get_LocalPath() { }

	// RVA: 0x16C98D0 Offset: 0x16C7ED0 VA: 0x1816C98D0
	public string get_Authority() { }

	// RVA: 0x16C9D90 Offset: 0x16C8390 VA: 0x1816C9D90
	public UriHostNameType get_HostNameType() { }

	// RVA: 0x16CA070 Offset: 0x16C8670 VA: 0x1816CA070
	public bool get_IsDefaultPort() { }

	// RVA: 0x16CA170 Offset: 0x16C8770 VA: 0x1816CA170
	public bool get_IsFile() { }

	// RVA: 0x16CA240 Offset: 0x16C8840 VA: 0x1816CA240
	public bool get_IsLoopback() { }

	// RVA: 0x16CA510 Offset: 0x16C8B10 VA: 0x1816CA510
	public string get_PathAndQuery() { }

	// RVA: 0x16CA330 Offset: 0x16C8930 VA: 0x1816CA330
	public bool get_IsUnc() { }

	// RVA: 0x16C9EE0 Offset: 0x16C84E0 VA: 0x1816C9EE0
	public string get_Host() { }

	// RVA: 0x16C7CB0 Offset: 0x16C62B0 VA: 0x1816C7CB0
	private static bool StaticIsFile(UriParser syntax) { }

	// RVA: 0x16C9F70 Offset: 0x16C8570 VA: 0x1816C9F70
	private static object get_InitializeLock() { }

	// RVA: 0x16C3360 Offset: 0x16C1960 VA: 0x1816C3360
	private static void InitializeUriConfig() { }

	// RVA: 0x16C1DE0 Offset: 0x16C03E0 VA: 0x1816C1DE0
	private string GetLocalPath() { }

	// RVA: 0x16CA5E0 Offset: 0x16C8BE0 VA: 0x1816CA5E0
	public int get_Port() { }

	// RVA: 0x16CA7C0 Offset: 0x16C8DC0 VA: 0x1816CA7C0
	public string get_Query() { }

	// RVA: 0x16C9C50 Offset: 0x16C8250 VA: 0x1816C9C50
	public string get_Fragment() { }

	// RVA: 0x16CA8F0 Offset: 0x16C8EF0 VA: 0x1816CA8F0
	public string get_Scheme() { }

	// RVA: 0x16CA440 Offset: 0x16C8A40 VA: 0x1816CA440
	private bool get_OriginalStringSwitched() { }

	// RVA: 0x16CA4B0 Offset: 0x16C8AB0 VA: 0x1816CA4B0
	public string get_OriginalString() { }

	// RVA: 0x16C9960 Offset: 0x16C7F60 VA: 0x1816C9960
	public string get_DnsSafeHost() { }

	// RVA: 0x12355E0 Offset: 0x1233BE0 VA: 0x1812355E0
	public bool get_IsAbsoluteUri() { }

	// RVA: 0x16CA9E0 Offset: 0x16C8FE0 VA: 0x1816CA9E0
	public bool get_UserEscaped() { }

	// RVA: 0x16CA9F0 Offset: 0x16C8FF0 VA: 0x1816CA9F0
	public string get_UserInfo() { }

	// RVA: 0x16C45C0 Offset: 0x16C2BC0 VA: 0x1816C45C0
	internal static bool IsGenDelim(char ch) { }

	// RVA: 0x16BD270 Offset: 0x16BB870 VA: 0x1816BD270
	public static bool CheckSchemeName(string schemeName) { }

	// RVA: 0x16C45F0 Offset: 0x16C2BF0 VA: 0x1816C45F0
	public static bool IsHexDigit(char character) { }

	// RVA: 0x16C05D0 Offset: 0x16BEBD0 VA: 0x1816C05D0
	public static int FromHex(char digit) { }

	// RVA: 0x16C1790 Offset: 0x16BFD90 VA: 0x1816C1790 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x16C7E50 Offset: 0x16C6450 VA: 0x1816C7E50 Slot: 3
	public override string ToString() { }

	// RVA: 0x16CAA80 Offset: 0x16C9080 VA: 0x1816CAA80
	public static bool op_Equality(Uri uri1, Uri uri2) { }

	// RVA: 0x16CAAB0 Offset: 0x16C90B0 VA: 0x1816CAAB0
	public static bool op_Inequality(Uri uri1, Uri uri2) { }

	// RVA: 0x16BFC70 Offset: 0x16BE270 VA: 0x1816BFC70 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x16BC870 Offset: 0x16BAE70 VA: 0x1816BC870
	private static bool CheckForColonInFirstPathSegment(string uriString) { }

	// RVA: 0x16C3DF0 Offset: 0x16C23F0 VA: 0x1816C3DF0
	internal static string InternalEscapeString(string rawString) { }

	// RVA: 0x16C5B60 Offset: 0x16C4160 VA: 0x1816C5B60
	private static ParsingError ParseScheme(string uriString, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x16C4840 Offset: 0x16C2E40 VA: 0x1816C4840
	internal UriFormatException ParseMinimal() { }

	// RVA: 0x16C5D70 Offset: 0x16C4370 VA: 0x1816C5D70
	private ParsingError PrivateParseMinimal() { }

	// RVA: 0x16C5C50 Offset: 0x16C4250 VA: 0x1816C5C50
	private void PrivateParseMinimalIri(string newHost, ushort idx) { }

	// RVA: 0x16BF290 Offset: 0x16BD890 VA: 0x1816BF290
	private void CreateUriInfo(Uri.Flags cF) { }

	// RVA: 0x16BEA80 Offset: 0x16BD080 VA: 0x1816BEA80
	private void CreateHostString() { }

	// RVA: 0x16BE8B0 Offset: 0x16BCEB0 VA: 0x1816BE8B0
	private static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Uri.Flags flags, ref string scopeId) { }

	// RVA: 0x16C1940 Offset: 0x16BFF40 VA: 0x1816C1940
	private void GetHostViaCustomSyntax() { }

	// RVA: 0x16C1390 Offset: 0x16BF990 VA: 0x1816C1390
	internal string GetParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x16C1550 Offset: 0x16BFB50 VA: 0x1816C1550
	private string GetEscapedParts(UriComponents uriParts) { }

	// RVA: 0x16C2A90 Offset: 0x16C1090 VA: 0x1816C2A90
	private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x16C65A0 Offset: 0x16C4BA0 VA: 0x1816C65A0
	private string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs) { }

	// RVA: 0x16C2B80 Offset: 0x16C1180 VA: 0x1816C2B80
	private string GetUriPartsFromUserString(UriComponents uriParts) { }

	// RVA: 0x16C48C0 Offset: 0x16C2EC0 VA: 0x1816C48C0
	private void ParseRemaining() { }

	// RVA: 0x16C5660 Offset: 0x16C3C60 VA: 0x1816C5660
	private static ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref ParsingError err, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x16BCCC0 Offset: 0x16BB2C0 VA: 0x1816BCCC0
	private static bool CheckKnownSchemes(long* lptr, ushort nChars, ref UriParser syntax) { }

	// RVA: 0x16BD3B0 Offset: 0x16BB9B0 VA: 0x1816BD3B0
	private static ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref UriParser syntax) { }

	// RVA: 0x16BB460 Offset: 0x16B9A60 VA: 0x1816BB460
	private ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref ParsingError err, ref Uri.Flags flags, UriParser syntax, ref string newHost) { }

	// RVA: 0x16BAF00 Offset: 0x16B9500 VA: 0x1816BAF00
	private void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Uri.Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err) { }

	// RVA: 0x16BAC20 Offset: 0x16B9220 VA: 0x1816BAC20
	private void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Uri.Flags flags, ref string newHost, ref ParsingError err) { }

	// RVA: 0x16C0520 Offset: 0x16BEB20 VA: 0x1816C0520
	private void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x16C0480 Offset: 0x16BEA80 VA: 0x1816C0480
	private void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x16BC4B0 Offset: 0x16BAAB0 VA: 0x1816BC4B0
	private Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x16C0670 Offset: 0x16BEC70 VA: 0x1816C0670
	private char[] GetCanonicalPath(char[] dest, ref int pos, UriFormat formatAs) { }

	// RVA: 0x16C86E0 Offset: 0x16C6CE0 VA: 0x1816C86E0
	private static void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3) { }

	// RVA: 0x16BE110 Offset: 0x16BC710 VA: 0x1816BE110
	private static char[] Compress(char[] dest, ushort start, ref int destLength, UriParser syntax) { }

	// RVA: 0x16BAB60 Offset: 0x16B9160 VA: 0x1816BAB60
	internal static int CalculateCaseInsensitiveHashCode(string text) { }

	// RVA: 0x16BD4E0 Offset: 0x16BBAE0 VA: 0x1816BD4E0
	private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat) { }

	// RVA: 0x16C9D80 Offset: 0x16C8380 VA: 0x1816C9D80
	internal bool get_HasAuthority() { }

	// RVA: 0x16C4620 Offset: 0x16C2C20 VA: 0x1816C4620
	private static bool IsLWS(char ch) { }

	// RVA: 0x16C4560 Offset: 0x16C2B60 VA: 0x1816C4560
	private static bool IsAsciiLetter(char character) { }

	// RVA: 0x16C44E0 Offset: 0x16C2AE0 VA: 0x1816C44E0
	internal static bool IsAsciiLetterOrDigit(char character) { }

	// RVA: 0x16C4580 Offset: 0x16C2B80 VA: 0x1816C4580
	internal static bool IsBidiControlCharacter(char ch) { }

	// RVA: 0x16C7CE0 Offset: 0x16C62E0 VA: 0x1816C7CE0
	internal static string StripBidiControlCharacter(char* strToClean, int start, int length) { }

	// RVA: 0x16BF0E0 Offset: 0x16BD6E0 VA: 0x1816BF0E0
	private void CreateThis(string uri, bool dontEscape, UriKind uriKind) { }

	// RVA: 0x16C3620 Offset: 0x16C1C20 VA: 0x1816C3620
	private void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e) { }

	// RVA: 0x16BC910 Offset: 0x16BAF10 VA: 0x1816BC910
	private bool CheckForConfigLoad(string data) { }

	// RVA: 0x16BCB80 Offset: 0x16BB180 VA: 0x1816BCB80
	private bool CheckForUnicode(string data) { }

	// RVA: 0x16BC9C0 Offset: 0x16BAFC0 VA: 0x1816BC9C0
	private bool CheckForEscapedUnreserved(string data) { }

	// RVA: 0x16C8460 Offset: 0x16C6A60 VA: 0x1816C8460
	public static bool TryCreate(string uriString, UriKind uriKind, out Uri result) { }

	// RVA: 0x16C7F70 Offset: 0x16C6570 VA: 0x1816C7F70
	public static bool TryCreate(Uri baseUri, string relativeUri, out Uri result) { }

	// RVA: 0x16C8290 Offset: 0x16C6890 VA: 0x1816C8290
	public static bool TryCreate(Uri baseUri, Uri relativeUri, out Uri result) { }

	// RVA: 0x16C1390 Offset: 0x16BF990 VA: 0x1816C1390
	public string GetComponents(UriComponents components, UriFormat format) { }

	// RVA: 0x16C4650 Offset: 0x16C2C50 VA: 0x1816C4650
	public bool IsWellFormedOriginalString() { }

	// RVA: 0x16C46A0 Offset: 0x16C2CA0 VA: 0x1816C46A0
	public static bool IsWellFormedUriString(string uriString, UriKind uriKind) { }

	// RVA: 0x16C3EE0 Offset: 0x16C24E0 VA: 0x1816C3EE0
	internal bool InternalIsWellFormedOriginalString() { }

	// RVA: 0x16C8550 Offset: 0x16C6B50 VA: 0x1816C8550
	public static string UnescapeDataString(string stringToUnescape) { }

	// RVA: 0x16C0420 Offset: 0x16BEA20 VA: 0x1816C0420
	internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component) { }

	// RVA: 0x16C92E0 Offset: 0x16C78E0 VA: 0x1816C92E0
	private void .ctor(Uri.Flags flags, UriParser uriParser, string uri) { }

	// RVA: 0x16BE600 Offset: 0x16BCC00 VA: 0x1816BE600
	internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e) { }

	// RVA: 0x16C7720 Offset: 0x16C5D20 VA: 0x1816C7720
	internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e) { }

	// RVA: 0x16C2710 Offset: 0x16C0D10 VA: 0x1816C2710
	private string GetRelativeSerializationString(UriFormat format) { }

	// RVA: 0x16C1070 Offset: 0x16BF670 VA: 0x1816C1070
	internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0x16BEF30 Offset: 0x16BD530 VA: 0x1816BEF30
	private void CreateThisFromUri(Uri otherUri) { }

	// RVA: 0x16C8900 Offset: 0x16C6F00 VA: 0x1816C8900
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

