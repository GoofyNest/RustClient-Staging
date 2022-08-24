public class UnityWebRequest : IDisposable // TypeDefIndex: 4128
{	internal IntPtr m_Ptr; // 0x10
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
	[CompilerGeneratedAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	[DebuggerBrowsableAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	private bool <disposeCertificateHandlerOnDispose>k__BackingField; // 0x38
	[DebuggerBrowsableAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	[CompilerGeneratedAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	private bool <disposeDownloadHandlerOnDispose>k__BackingField; // 0x39
	[DebuggerBrowsableAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	[CompilerGeneratedAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	private bool <disposeUploadHandlerOnDispose>k__BackingField; // 0x3A

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
	[ObsoleteAttribute] // RVA: 0x912C0 Offset: 0x906C0 VA: 0x1800912C0
	public bool chunkedTransfer { set; }
	public UploadHandler uploadHandler { get; set; }
	public DownloadHandler downloadHandler { get; set; }
	public CertificateHandler certificateHandler { get; set; }
	public int timeout { set; }


	[NativeMethodAttribute] // RVA: 0x8FDE0 Offset: 0x8F1E0 VA: 0x18008FDE0
	[NativeConditionalAttribute] // RVA: 0x8FDE0 Offset: 0x8F1E0 VA: 0x18008FDE0
	private static string GetWebErrorString(UnityWebRequest.UnityWebRequestError err) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static string GetHTTPStatusString(long responseCode) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool get_disposeCertificateHandlerOnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool get_disposeDownloadHandlerOnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool get_disposeUploadHandlerOnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	internal static IntPtr Create() { }

	[NativeMethodAttribute] // RVA: 0x90660 Offset: 0x8FA60 VA: 0x180090660
	private void Release() { }

	internal void InternalDestroy() { }

	private void InternalSetDefaults() { }

	public void .ctor(string url) { }

	public void .ctor(string url, string method) { }

	public void .ctor(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	protected override void Finalize() { }

	public void Dispose() { }

	private void DisposeHandlers() { }

	[NativeThrowsAttribute] // RVA: 0x80B20 Offset: 0x7FF20 VA: 0x180080B20
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	[ObsoleteAttribute] // RVA: 0x90850 Offset: 0x8FC50 VA: 0x180090850
	public AsyncOperation Send() { }

	public UnityWebRequestAsyncOperation SendWebRequest() { }

	[NativeMethodAttribute] // RVA: 0x90660 Offset: 0x8FA60 VA: 0x180090660
	public void Abort() { }

	private UnityWebRequest.UnityWebRequestError SetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	internal void InternalSetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	private UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName) { }

	internal void InternalSetCustomMethod(string customMethodName) { }

	public void set_method(string value) { }

	private UnityWebRequest.UnityWebRequestError GetError() { }

	public string get_error() { }

	public string get_url() { }

	public void set_url(string value) { }

	private string GetUrl() { }

	private UnityWebRequest.UnityWebRequestError SetUrl(string url) { }

	private void InternalSetUrl(string url) { }

	public long get_responseCode() { }

	private bool IsExecuting() { }

	[NativeMethodAttribute] // RVA: 0x90AE0 Offset: 0x8FEE0 VA: 0x180090AE0
	public bool get_isModifiable() { }

	[NativeMethodAttribute] // RVA: 0x90C70 Offset: 0x90070 VA: 0x180090C70
	public bool get_isDone() { }

	[NativeMethodAttribute] // RVA: 0x90E40 Offset: 0x90240 VA: 0x180090E40
	public bool get_isNetworkError() { }

	[NativeMethodAttribute] // RVA: 0x90F40 Offset: 0x90340 VA: 0x180090F40
	public bool get_isHttpError() { }

	private float GetDownloadProgress() { }

	public float get_downloadProgress() { }

	private UnityWebRequest.UnityWebRequestError SetChunked(bool chunked) { }

	public void set_chunkedTransfer(bool value) { }

	[NativeMethodAttribute] // RVA: 0x91090 Offset: 0x90490 VA: 0x180091090
	internal UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(string name, string value) { }

	public void SetRequestHeader(string name, string value) { }

	private UnityWebRequest.UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	public UploadHandler get_uploadHandler() { }

	public void set_uploadHandler(UploadHandler value) { }

	private UnityWebRequest.UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	public DownloadHandler get_downloadHandler() { }

	public void set_downloadHandler(DownloadHandler value) { }

	private UnityWebRequest.UnityWebRequestError SetCertificateHandler(CertificateHandler ch) { }

	public CertificateHandler get_certificateHandler() { }

	public void set_certificateHandler(CertificateHandler value) { }

	private UnityWebRequest.UnityWebRequestError SetTimeoutMsec(int timeout) { }

	public void set_timeout(int value) { }

	public static UnityWebRequest Get(string uri) { }

	public static UnityWebRequest Post(string uri, WWWForm formData) { }

	private static void SetupPost(UnityWebRequest request, WWWForm formData) { }

	public static string EscapeURL(string s) { }

	public static string EscapeURL(string s, Encoding e) { }

	public static string UnEscapeURL(string s, Encoding e) { }

}

internal enum UnityWebRequest.UnityWebRequestMethod // TypeDefIndex: 4129
{	public int value__; // 0x0
	public const UnityWebRequest.UnityWebRequestMethod Get = 0;
	public const UnityWebRequest.UnityWebRequestMethod Post = 1;
	public const UnityWebRequest.UnityWebRequestMethod Put = 2;
	public const UnityWebRequest.UnityWebRequestMethod Head = 3;
	public const UnityWebRequest.UnityWebRequestMethod Custom = 4;

}

internal enum UnityWebRequest.UnityWebRequestError // TypeDefIndex: 4130
{	public int value__; // 0x0
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

