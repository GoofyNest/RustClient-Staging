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
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private bool <disposeCertificateHandlerOnDispose>k__BackingField; // 0x38
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private bool <disposeDownloadHandlerOnDispose>k__BackingField; // 0x39
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
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
	[ObsoleteAttribute] // RVA: 0x91160 Offset: 0x90560 VA: 0x180091160
	public bool chunkedTransfer { set; }
	public UploadHandler uploadHandler { get; set; }
	public DownloadHandler downloadHandler { get; set; }
	public CertificateHandler certificateHandler { get; set; }
	public int timeout { set; }

	// Methods

	[NativeMethodAttribute] // RVA: 0x8FC60 Offset: 0x8F060 VA: 0x18008FC60
	[NativeConditionalAttribute] // RVA: 0x8FC60 Offset: 0x8F060 VA: 0x18008FC60
	// RVA: 0x229FEA0 Offset: 0x229E4A0 VA: 0x18229FEA0
	private static string GetWebErrorString(UnityWebRequest.UnityWebRequestError err) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x229FE20 Offset: 0x229E420 VA: 0x18229FE20
	internal static string GetHTTPStatusString(long responseCode) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8C1040 Offset: 0x8BF640 VA: 0x1808C1040
	public bool get_disposeCertificateHandlerOnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x78E170 Offset: 0x78C770 VA: 0x18078E170
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8C1050 Offset: 0x8BF650 VA: 0x1808C1050
	public bool get_disposeDownloadHandlerOnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8C1060 Offset: 0x8BF660 VA: 0x1808C1060
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1160330 Offset: 0x115E930 VA: 0x181160330
	public bool get_disposeUploadHandlerOnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1160740 Offset: 0x115ED40 VA: 0x181160740
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	// RVA: 0x229F900 Offset: 0x229DF00 VA: 0x18229F900
	internal static IntPtr Create() { }

	[NativeMethodAttribute] // RVA: 0x90510 Offset: 0x8F910 VA: 0x180090510
	// RVA: 0x22A0510 Offset: 0x229EB10 VA: 0x1822A0510
	private void Release() { }

	// RVA: 0x22A0000 Offset: 0x229E600 VA: 0x1822A0000
	internal void InternalDestroy() { }

	// RVA: 0x22A0190 Offset: 0x229E790 VA: 0x1822A0190
	private void InternalSetDefaults() { }

	// RVA: 0x22A1040 Offset: 0x229F640 VA: 0x1822A1040
	public void .ctor(string url) { }

	// RVA: 0x22A0FC0 Offset: 0x229F5C0 VA: 0x1822A0FC0
	public void .ctor(string url, string method) { }

	// RVA: 0x22A0F10 Offset: 0x229F510 VA: 0x1822A0F10
	public void .ctor(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	// RVA: 0x229FCD0 Offset: 0x229E2D0 VA: 0x18229FCD0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x229F990 Offset: 0x229DF90 VA: 0x18229F990 Slot: 4
	public void Dispose() { }

	// RVA: 0x229F930 Offset: 0x229DF30 VA: 0x18229F930
	private void DisposeHandlers() { }

	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	// RVA: 0x229F8C0 Offset: 0x229DEC0 VA: 0x18229F8C0
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	[ObsoleteAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x22A0550 Offset: 0x229EB50 VA: 0x1822A0550
	public AsyncOperation Send() { }

	// RVA: 0x22A0550 Offset: 0x229EB50 VA: 0x1822A0550
	public UnityWebRequestAsyncOperation SendWebRequest() { }

	[NativeMethodAttribute] // RVA: 0x90510 Offset: 0x8F910 VA: 0x180090510
	// RVA: 0x229F880 Offset: 0x229DE80 VA: 0x18229F880
	public void Abort() { }

	// RVA: 0x22A06F0 Offset: 0x229ECF0 VA: 0x1822A06F0
	private UnityWebRequest.UnityWebRequestError SetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x22A01A0 Offset: 0x229E7A0 VA: 0x1822A01A0
	internal void InternalSetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x22A0650 Offset: 0x229EC50 VA: 0x1822A0650
	private UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName) { }

	// RVA: 0x22A0090 Offset: 0x229E690 VA: 0x1822A0090
	internal void InternalSetCustomMethod(string customMethodName) { }

	// RVA: 0x22A1740 Offset: 0x229FD40 VA: 0x1822A1740
	public void set_method(string value) { }

	// RVA: 0x229FDE0 Offset: 0x229E3E0 VA: 0x18229FDE0
	private UnityWebRequest.UnityWebRequestError GetError() { }

	// RVA: 0x22A1140 Offset: 0x229F740 VA: 0x1822A1140
	public string get_error() { }

	// RVA: 0x229FE60 Offset: 0x229E460 VA: 0x18229FE60
	public string get_url() { }

	// RVA: 0x22A1B90 Offset: 0x22A0190 VA: 0x1822A1B90
	public void set_url(string value) { }

	// RVA: 0x229FE60 Offset: 0x229E460 VA: 0x18229FE60
	private string GetUrl() { }

	// RVA: 0x22A0940 Offset: 0x229EF40 VA: 0x1822A0940
	private UnityWebRequest.UnityWebRequestError SetUrl(string url) { }

	// RVA: 0x22A0300 Offset: 0x229E900 VA: 0x1822A0300
	private void InternalSetUrl(string url) { }

	// RVA: 0x22A13E0 Offset: 0x229F9E0 VA: 0x1822A13E0
	public long get_responseCode() { }

	// RVA: 0x22A0400 Offset: 0x229EA00 VA: 0x1822A0400
	private bool IsExecuting() { }

	[NativeMethodAttribute] // RVA: 0x908E0 Offset: 0x8FCE0 VA: 0x1800908E0
	// RVA: 0x22A1360 Offset: 0x229F960 VA: 0x1822A1360
	public bool get_isModifiable() { }

	[NativeMethodAttribute] // RVA: 0x90B40 Offset: 0x8FF40 VA: 0x180090B40
	// RVA: 0x22A12E0 Offset: 0x229F8E0 VA: 0x1822A12E0
	public bool get_isDone() { }

	[NativeMethodAttribute] // RVA: 0x90C20 Offset: 0x90020 VA: 0x180090C20
	// RVA: 0x22A13A0 Offset: 0x229F9A0 VA: 0x1822A13A0
	public bool get_isNetworkError() { }

	[NativeMethodAttribute] // RVA: 0x90DF0 Offset: 0x901F0 VA: 0x180090DF0
	// RVA: 0x22A1320 Offset: 0x229F920 VA: 0x1822A1320
	public bool get_isHttpError() { }

	// RVA: 0x229FDA0 Offset: 0x229E3A0 VA: 0x18229FDA0
	private float GetDownloadProgress() { }

	// RVA: 0x22A10A0 Offset: 0x229F6A0 VA: 0x1822A10A0
	public float get_downloadProgress() { }

	// RVA: 0x22A0600 Offset: 0x229EC00 VA: 0x1822A0600
	private UnityWebRequest.UnityWebRequestError SetChunked(bool chunked) { }

	// RVA: 0x22A1530 Offset: 0x229FB30 VA: 0x1822A1530
	public void set_chunkedTransfer(bool value) { }

	[NativeMethodAttribute] // RVA: 0x90F30 Offset: 0x90330 VA: 0x180090F30
	// RVA: 0x22A02A0 Offset: 0x229E8A0 VA: 0x1822A02A0
	internal UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(string name, string value) { }

	// RVA: 0x22A0730 Offset: 0x229ED30 VA: 0x1822A0730
	public void SetRequestHeader(string name, string value) { }

	// RVA: 0x22A08F0 Offset: 0x229EEF0 VA: 0x1822A08F0
	private UnityWebRequest.UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	// RVA: 0x1A6C720 Offset: 0x1A6AD20 VA: 0x181A6C720
	public UploadHandler get_uploadHandler() { }

	// RVA: 0x22A1A80 Offset: 0x22A0080 VA: 0x1822A1A80
	public void set_uploadHandler(UploadHandler value) { }

	// RVA: 0x22A06A0 Offset: 0x229ECA0 VA: 0x1822A06A0
	private UnityWebRequest.UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	// RVA: 0x181D9E0 Offset: 0x181BFE0 VA: 0x18181D9E0
	public DownloadHandler get_downloadHandler() { }

	// RVA: 0x22A1630 Offset: 0x229FC30 VA: 0x1822A1630
	public void set_downloadHandler(DownloadHandler value) { }

	// RVA: 0x22A05B0 Offset: 0x229EBB0 VA: 0x1822A05B0
	private UnityWebRequest.UnityWebRequestError SetCertificateHandler(CertificateHandler ch) { }

	// RVA: 0x181D9D0 Offset: 0x181BFD0 VA: 0x18181D9D0
	public CertificateHandler get_certificateHandler() { }

	// RVA: 0x22A1420 Offset: 0x229FA20 VA: 0x1822A1420
	public void set_certificateHandler(CertificateHandler value) { }

	// RVA: 0x22A08B0 Offset: 0x229EEB0 VA: 0x1822A08B0
	private UnityWebRequest.UnityWebRequestError SetTimeoutMsec(int timeout) { }

	// RVA: 0x22A1950 Offset: 0x229FF50 VA: 0x1822A1950
	public void set_timeout(int value) { }

	// RVA: 0x229FEE0 Offset: 0x229E4E0 VA: 0x18229FEE0
	public static UnityWebRequest Get(string uri) { }

	// RVA: 0x22A0440 Offset: 0x229EA40 VA: 0x1822A0440
	public static UnityWebRequest Post(string uri, WWWForm formData) { }

	// RVA: 0x22A0990 Offset: 0x229EF90 VA: 0x1822A0990
	private static void SetupPost(UnityWebRequest request, WWWForm formData) { }

	// RVA: 0x229FB80 Offset: 0x229E180 VA: 0x18229FB80
	public static string EscapeURL(string s) { }

	// RVA: 0x229FA30 Offset: 0x229E030 VA: 0x18229FA30
	public static string EscapeURL(string s, Encoding e) { }

	// RVA: 0x22A0E30 Offset: 0x229F430 VA: 0x1822A0E30
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

