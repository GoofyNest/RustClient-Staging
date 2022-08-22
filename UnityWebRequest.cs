public class UnityWebRequest : IDisposable // TypeDefIndex: 4128
{	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal DownloadHandler m_DownloadHandler; // 0x18
	internal UploadHandler m_UploadHandler; // 0x20
	internal CertificateHandler m_CertificateHandler; // 0x28
	internal Uri m_Uri; // 0x30
	public const string kHttpVerbGET = "GET";
	public const string kHttpVerbHEAD = "HEAD";
	public const string kHttpVerbPOST = "POST";
	public const string kHttpVerbPUT = "PUT";
	public const string kHttpVerbCREATE = "CREATE";
	public const string kHttpVerbDELETE = "DELETE";
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private bool <disposeCertificateHandlerOnDispose>k__BackingField; // 0x38
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private bool <disposeDownloadHandlerOnDispose>k__BackingField; // 0x39
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private bool <disposeUploadHandlerOnDispose>k__BackingField; // 0x3A

	// Properties
	public bool disposeCertificateHandlerOnDispose { get; set; }
	public bool disposeDownloadHandlerOnDispose { get; set; }
	public bool disposeUploadHandlerOnDispose { get; set; }
	public string method { set; }
	public string error { get; }
	public string url { get; set; }
	public long responseCode { get; }
	public bool isModifiable { get; }
	public bool isDone { get; }
	public bool isNetworkError { get; }
	public bool isHttpError { get; }
	public float downloadProgress { get; }
	[ObsoleteAttribute] // RVA: 0x911E0 Offset: 0x905E0 VA: 0x1800911E0
	public bool chunkedTransfer { set; }
	public UploadHandler uploadHandler { get; set; }
	public DownloadHandler downloadHandler { get; set; }
	public CertificateHandler certificateHandler { get; set; }
	public int timeout { set; }

	// Methods

	[NativeMethodAttribute] // RVA: 0x8FDF0 Offset: 0x8F1F0 VA: 0x18008FDF0
	[NativeConditionalAttribute] // RVA: 0x8FDF0 Offset: 0x8F1F0 VA: 0x18008FDF0
	// RVA: 0x22A07C0 Offset: 0x229EDC0 VA: 0x1822A07C0
	private static string GetWebErrorString(UnityWebRequest.UnityWebRequestError err) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22A0740 Offset: 0x229ED40 VA: 0x1822A0740
	internal static string GetHTTPStatusString(long responseCode) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1660 Offset: 0x8BFC60 VA: 0x1808C1660
	public bool get_disposeCertificateHandlerOnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x78E190 Offset: 0x78C790 VA: 0x18078E190
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1670 Offset: 0x8BFC70 VA: 0x1808C1670
	public bool get_disposeDownloadHandlerOnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1680 Offset: 0x8BFC80 VA: 0x1808C1680
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1161060 Offset: 0x115F660 VA: 0x181161060
	public bool get_disposeUploadHandlerOnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1161470 Offset: 0x115FA70 VA: 0x181161470
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	// RVA: 0x22A0220 Offset: 0x229E820 VA: 0x1822A0220
	internal static IntPtr Create() { }

	[NativeMethodAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x22A0E30 Offset: 0x229F430 VA: 0x1822A0E30
	private void Release() { }

	// RVA: 0x22A0920 Offset: 0x229EF20 VA: 0x1822A0920
	internal void InternalDestroy() { }

	// RVA: 0x22A0AB0 Offset: 0x229F0B0 VA: 0x1822A0AB0
	private void InternalSetDefaults() { }

	// RVA: 0x22A1960 Offset: 0x229FF60 VA: 0x1822A1960
	public void .ctor(string url) { }

	// RVA: 0x22A18E0 Offset: 0x229FEE0 VA: 0x1822A18E0
	public void .ctor(string url, string method) { }

	// RVA: 0x22A1830 Offset: 0x229FE30 VA: 0x1822A1830
	public void .ctor(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	// RVA: 0x22A05F0 Offset: 0x229EBF0 VA: 0x1822A05F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x22A02B0 Offset: 0x229E8B0 VA: 0x1822A02B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x22A0250 Offset: 0x229E850 VA: 0x1822A0250
	private void DisposeHandlers() { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x22A01E0 Offset: 0x229E7E0 VA: 0x1822A01E0
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	[ObsoleteAttribute] // RVA: 0x907C0 Offset: 0x8FBC0 VA: 0x1800907C0
	// RVA: 0x22A0E70 Offset: 0x229F470 VA: 0x1822A0E70
	public AsyncOperation Send() { }

	// RVA: 0x22A0E70 Offset: 0x229F470 VA: 0x1822A0E70
	public UnityWebRequestAsyncOperation SendWebRequest() { }

	[NativeMethodAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x22A01A0 Offset: 0x229E7A0 VA: 0x1822A01A0
	public void Abort() { }

	// RVA: 0x22A1010 Offset: 0x229F610 VA: 0x1822A1010
	private UnityWebRequest.UnityWebRequestError SetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x22A0AC0 Offset: 0x229F0C0 VA: 0x1822A0AC0
	internal void InternalSetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x22A0F70 Offset: 0x229F570 VA: 0x1822A0F70
	private UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName) { }

	// RVA: 0x22A09B0 Offset: 0x229EFB0 VA: 0x1822A09B0
	internal void InternalSetCustomMethod(string customMethodName) { }

	// RVA: 0x22A2060 Offset: 0x22A0660 VA: 0x1822A2060
	public void set_method(string value) { }

	// RVA: 0x22A0700 Offset: 0x229ED00 VA: 0x1822A0700
	private UnityWebRequest.UnityWebRequestError GetError() { }

	// RVA: 0x22A1A60 Offset: 0x22A0060 VA: 0x1822A1A60
	public string get_error() { }

	// RVA: 0x22A0780 Offset: 0x229ED80 VA: 0x1822A0780
	public string get_url() { }

	// RVA: 0x22A24B0 Offset: 0x22A0AB0 VA: 0x1822A24B0
	public void set_url(string value) { }

	// RVA: 0x22A0780 Offset: 0x229ED80 VA: 0x1822A0780
	private string GetUrl() { }

	// RVA: 0x22A1260 Offset: 0x229F860 VA: 0x1822A1260
	private UnityWebRequest.UnityWebRequestError SetUrl(string url) { }

	// RVA: 0x22A0C20 Offset: 0x229F220 VA: 0x1822A0C20
	private void InternalSetUrl(string url) { }

	// RVA: 0x22A1D00 Offset: 0x22A0300 VA: 0x1822A1D00
	public long get_responseCode() { }

	// RVA: 0x22A0D20 Offset: 0x229F320 VA: 0x1822A0D20
	private bool IsExecuting() { }

	[NativeMethodAttribute] // RVA: 0x90A10 Offset: 0x8FE10 VA: 0x180090A10
	// RVA: 0x22A1C80 Offset: 0x22A0280 VA: 0x1822A1C80
	public bool get_isModifiable() { }

	[NativeMethodAttribute] // RVA: 0x90BC0 Offset: 0x8FFC0 VA: 0x180090BC0
	// RVA: 0x22A1C00 Offset: 0x22A0200 VA: 0x1822A1C00
	public bool get_isDone() { }

	[NativeMethodAttribute] // RVA: 0x90D60 Offset: 0x90160 VA: 0x180090D60
	// RVA: 0x22A1CC0 Offset: 0x22A02C0 VA: 0x1822A1CC0
	public bool get_isNetworkError() { }

	[NativeMethodAttribute] // RVA: 0x90E70 Offset: 0x90270 VA: 0x180090E70
	// RVA: 0x22A1C40 Offset: 0x22A0240 VA: 0x1822A1C40
	public bool get_isHttpError() { }

	// RVA: 0x22A06C0 Offset: 0x229ECC0 VA: 0x1822A06C0
	private float GetDownloadProgress() { }

	// RVA: 0x22A19C0 Offset: 0x229FFC0 VA: 0x1822A19C0
	public float get_downloadProgress() { }

	// RVA: 0x22A0F20 Offset: 0x229F520 VA: 0x1822A0F20
	private UnityWebRequest.UnityWebRequestError SetChunked(bool chunked) { }

	// RVA: 0x22A1E50 Offset: 0x22A0450 VA: 0x1822A1E50
	public void set_chunkedTransfer(bool value) { }

	[NativeMethodAttribute] // RVA: 0x90FB0 Offset: 0x903B0 VA: 0x180090FB0
	// RVA: 0x22A0BC0 Offset: 0x229F1C0 VA: 0x1822A0BC0
	internal UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(string name, string value) { }

	// RVA: 0x22A1050 Offset: 0x229F650 VA: 0x1822A1050
	public void SetRequestHeader(string name, string value) { }

	// RVA: 0x22A1210 Offset: 0x229F810 VA: 0x1822A1210
	private UnityWebRequest.UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	// RVA: 0x1A58ED0 Offset: 0x1A574D0 VA: 0x181A58ED0
	public UploadHandler get_uploadHandler() { }

	// RVA: 0x22A23A0 Offset: 0x22A09A0 VA: 0x1822A23A0
	public void set_uploadHandler(UploadHandler value) { }

	// RVA: 0x22A0FC0 Offset: 0x229F5C0 VA: 0x1822A0FC0
	private UnityWebRequest.UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	// RVA: 0x180B0E0 Offset: 0x18096E0 VA: 0x18180B0E0
	public DownloadHandler get_downloadHandler() { }

	// RVA: 0x22A1F50 Offset: 0x22A0550 VA: 0x1822A1F50
	public void set_downloadHandler(DownloadHandler value) { }

	// RVA: 0x22A0ED0 Offset: 0x229F4D0 VA: 0x1822A0ED0
	private UnityWebRequest.UnityWebRequestError SetCertificateHandler(CertificateHandler ch) { }

	// RVA: 0x180B0D0 Offset: 0x18096D0 VA: 0x18180B0D0
	public CertificateHandler get_certificateHandler() { }

	// RVA: 0x22A1D40 Offset: 0x22A0340 VA: 0x1822A1D40
	public void set_certificateHandler(CertificateHandler value) { }

	// RVA: 0x22A11D0 Offset: 0x229F7D0 VA: 0x1822A11D0
	private UnityWebRequest.UnityWebRequestError SetTimeoutMsec(int timeout) { }

	// RVA: 0x22A2270 Offset: 0x22A0870 VA: 0x1822A2270
	public void set_timeout(int value) { }

	// RVA: 0x22A0800 Offset: 0x229EE00 VA: 0x1822A0800
	public static UnityWebRequest Get(string uri) { }

	// RVA: 0x22A0D60 Offset: 0x229F360 VA: 0x1822A0D60
	public static UnityWebRequest Post(string uri, WWWForm formData) { }

	// RVA: 0x22A12B0 Offset: 0x229F8B0 VA: 0x1822A12B0
	private static void SetupPost(UnityWebRequest request, WWWForm formData) { }

	// RVA: 0x22A04A0 Offset: 0x229EAA0 VA: 0x1822A04A0
	public static string EscapeURL(string s) { }

	// RVA: 0x22A0350 Offset: 0x229E950 VA: 0x1822A0350
	public static string EscapeURL(string s, Encoding e) { }

	// RVA: 0x22A1750 Offset: 0x229FD50 VA: 0x1822A1750
	public static string UnEscapeURL(string s, Encoding e) { }

}

internal enum UnityWebRequest.UnityWebRequestMethod // TypeDefIndex: 4129
{	// Fields
	public int value__; // 0x0
	public const UnityWebRequest.UnityWebRequestMethod Get = 0;
	public const UnityWebRequest.UnityWebRequestMethod Post = 1;
	public const UnityWebRequest.UnityWebRequestMethod Put = 2;
	public const UnityWebRequest.UnityWebRequestMethod Head = 3;
	public const UnityWebRequest.UnityWebRequestMethod Custom = 4;

}

internal enum UnityWebRequest.UnityWebRequestError // TypeDefIndex: 4130
{	// Fields
	public int value__; // 0x0
	public const UnityWebRequest.UnityWebRequestError OK = 0;
	public const UnityWebRequest.UnityWebRequestError Unknown = 1;
	public const UnityWebRequest.UnityWebRequestError SDKError = 2;
	public const UnityWebRequest.UnityWebRequestError UnsupportedProtocol = 3;
	public const UnityWebRequest.UnityWebRequestError MalformattedUrl = 4;
	public const UnityWebRequest.UnityWebRequestError CannotResolveProxy = 5;
	public const UnityWebRequest.UnityWebRequestError CannotResolveHost = 6;
	public const UnityWebRequest.UnityWebRequestError CannotConnectToHost = 7;
	public const UnityWebRequest.UnityWebRequestError AccessDenied = 8;
	public const UnityWebRequest.UnityWebRequestError GenericHttpError = 9;
	public const UnityWebRequest.UnityWebRequestError WriteError = 10;
	public const UnityWebRequest.UnityWebRequestError ReadError = 11;
	public const UnityWebRequest.UnityWebRequestError OutOfMemory = 12;
	public const UnityWebRequest.UnityWebRequestError Timeout = 13;
	public const UnityWebRequest.UnityWebRequestError HTTPPostError = 14;
	public const UnityWebRequest.UnityWebRequestError SSLCannotConnect = 15;
	public const UnityWebRequest.UnityWebRequestError Aborted = 16;
	public const UnityWebRequest.UnityWebRequestError TooManyRedirects = 17;
	public const UnityWebRequest.UnityWebRequestError ReceivedNoData = 18;
	public const UnityWebRequest.UnityWebRequestError SSLNotSupported = 19;
	public const UnityWebRequest.UnityWebRequestError FailedToSendData = 20;
	public const UnityWebRequest.UnityWebRequestError FailedToReceiveData = 21;
	public const UnityWebRequest.UnityWebRequestError SSLCertificateError = 22;
	public const UnityWebRequest.UnityWebRequestError SSLCipherNotAvailable = 23;
	public const UnityWebRequest.UnityWebRequestError SSLCACertError = 24;
	public const UnityWebRequest.UnityWebRequestError UnrecognizedContentEncoding = 25;
	public const UnityWebRequest.UnityWebRequestError LoginFailed = 26;
	public const UnityWebRequest.UnityWebRequestError SSLShutdownFailed = 27;
	public const UnityWebRequest.UnityWebRequestError NoInternetConnection = 28;

}

