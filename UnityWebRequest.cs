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
	// RVA: 0x229FFA0 Offset: 0x229E5A0 VA: 0x18229FFA0
	private static string GetWebErrorString(UnityWebRequest.UnityWebRequestError err) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229FF20 Offset: 0x229E520 VA: 0x18229FF20
	internal static string GetHTTPStatusString(long responseCode) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1150 Offset: 0x8BF750 VA: 0x1808C1150
	public bool get_disposeCertificateHandlerOnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x78E280 Offset: 0x78C880 VA: 0x18078E280
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1160 Offset: 0x8BF760 VA: 0x1808C1160
	public bool get_disposeDownloadHandlerOnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1170 Offset: 0x8BF770 VA: 0x1808C1170
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11605F0 Offset: 0x115EBF0 VA: 0x1811605F0
	public bool get_disposeUploadHandlerOnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1160A00 Offset: 0x115F000 VA: 0x181160A00
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	// RVA: 0x229FA00 Offset: 0x229E000 VA: 0x18229FA00
	internal static IntPtr Create() { }

	[NativeMethodAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x22A0610 Offset: 0x229EC10 VA: 0x1822A0610
	private void Release() { }

	// RVA: 0x22A0100 Offset: 0x229E700 VA: 0x1822A0100
	internal void InternalDestroy() { }

	// RVA: 0x22A0290 Offset: 0x229E890 VA: 0x1822A0290
	private void InternalSetDefaults() { }

	// RVA: 0x22A1140 Offset: 0x229F740 VA: 0x1822A1140
	public void .ctor(string url) { }

	// RVA: 0x22A10C0 Offset: 0x229F6C0 VA: 0x1822A10C0
	public void .ctor(string url, string method) { }

	// RVA: 0x22A1010 Offset: 0x229F610 VA: 0x1822A1010
	public void .ctor(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	// RVA: 0x229FDD0 Offset: 0x229E3D0 VA: 0x18229FDD0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x229FA90 Offset: 0x229E090 VA: 0x18229FA90 Slot: 4
	public void Dispose() { }

	// RVA: 0x229FA30 Offset: 0x229E030 VA: 0x18229FA30
	private void DisposeHandlers() { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x229F9C0 Offset: 0x229DFC0 VA: 0x18229F9C0
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	[ObsoleteAttribute] // RVA: 0x907C0 Offset: 0x8FBC0 VA: 0x1800907C0
	// RVA: 0x22A0650 Offset: 0x229EC50 VA: 0x1822A0650
	public AsyncOperation Send() { }

	// RVA: 0x22A0650 Offset: 0x229EC50 VA: 0x1822A0650
	public UnityWebRequestAsyncOperation SendWebRequest() { }

	[NativeMethodAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x229F980 Offset: 0x229DF80 VA: 0x18229F980
	public void Abort() { }

	// RVA: 0x22A07F0 Offset: 0x229EDF0 VA: 0x1822A07F0
	private UnityWebRequest.UnityWebRequestError SetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x22A02A0 Offset: 0x229E8A0 VA: 0x1822A02A0
	internal void InternalSetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x22A0750 Offset: 0x229ED50 VA: 0x1822A0750
	private UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName) { }

	// RVA: 0x22A0190 Offset: 0x229E790 VA: 0x1822A0190
	internal void InternalSetCustomMethod(string customMethodName) { }

	// RVA: 0x22A1840 Offset: 0x229FE40 VA: 0x1822A1840
	public void set_method(string value) { }

	// RVA: 0x229FEE0 Offset: 0x229E4E0 VA: 0x18229FEE0
	private UnityWebRequest.UnityWebRequestError GetError() { }

	// RVA: 0x22A1240 Offset: 0x229F840 VA: 0x1822A1240
	public string get_error() { }

	// RVA: 0x229FF60 Offset: 0x229E560 VA: 0x18229FF60
	public string get_url() { }

	// RVA: 0x22A1C90 Offset: 0x22A0290 VA: 0x1822A1C90
	public void set_url(string value) { }

	// RVA: 0x229FF60 Offset: 0x229E560 VA: 0x18229FF60
	private string GetUrl() { }

	// RVA: 0x22A0A40 Offset: 0x229F040 VA: 0x1822A0A40
	private UnityWebRequest.UnityWebRequestError SetUrl(string url) { }

	// RVA: 0x22A0400 Offset: 0x229EA00 VA: 0x1822A0400
	private void InternalSetUrl(string url) { }

	// RVA: 0x22A14E0 Offset: 0x229FAE0 VA: 0x1822A14E0
	public long get_responseCode() { }

	// RVA: 0x22A0500 Offset: 0x229EB00 VA: 0x1822A0500
	private bool IsExecuting() { }

	[NativeMethodAttribute] // RVA: 0x90A10 Offset: 0x8FE10 VA: 0x180090A10
	// RVA: 0x22A1460 Offset: 0x229FA60 VA: 0x1822A1460
	public bool get_isModifiable() { }

	[NativeMethodAttribute] // RVA: 0x90BC0 Offset: 0x8FFC0 VA: 0x180090BC0
	// RVA: 0x22A13E0 Offset: 0x229F9E0 VA: 0x1822A13E0
	public bool get_isDone() { }

	[NativeMethodAttribute] // RVA: 0x90D60 Offset: 0x90160 VA: 0x180090D60
	// RVA: 0x22A14A0 Offset: 0x229FAA0 VA: 0x1822A14A0
	public bool get_isNetworkError() { }

	[NativeMethodAttribute] // RVA: 0x90E70 Offset: 0x90270 VA: 0x180090E70
	// RVA: 0x22A1420 Offset: 0x229FA20 VA: 0x1822A1420
	public bool get_isHttpError() { }

	// RVA: 0x229FEA0 Offset: 0x229E4A0 VA: 0x18229FEA0
	private float GetDownloadProgress() { }

	// RVA: 0x22A11A0 Offset: 0x229F7A0 VA: 0x1822A11A0
	public float get_downloadProgress() { }

	// RVA: 0x22A0700 Offset: 0x229ED00 VA: 0x1822A0700
	private UnityWebRequest.UnityWebRequestError SetChunked(bool chunked) { }

	// RVA: 0x22A1630 Offset: 0x229FC30 VA: 0x1822A1630
	public void set_chunkedTransfer(bool value) { }

	[NativeMethodAttribute] // RVA: 0x90FB0 Offset: 0x903B0 VA: 0x180090FB0
	// RVA: 0x22A03A0 Offset: 0x229E9A0 VA: 0x1822A03A0
	internal UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(string name, string value) { }

	// RVA: 0x22A0830 Offset: 0x229EE30 VA: 0x1822A0830
	public void SetRequestHeader(string name, string value) { }

	// RVA: 0x22A09F0 Offset: 0x229EFF0 VA: 0x1822A09F0
	private UnityWebRequest.UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	// RVA: 0x1A6C9A0 Offset: 0x1A6AFA0 VA: 0x181A6C9A0
	public UploadHandler get_uploadHandler() { }

	// RVA: 0x22A1B80 Offset: 0x22A0180 VA: 0x1822A1B80
	public void set_uploadHandler(UploadHandler value) { }

	// RVA: 0x22A07A0 Offset: 0x229EDA0 VA: 0x1822A07A0
	private UnityWebRequest.UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	// RVA: 0x181DCA0 Offset: 0x181C2A0 VA: 0x18181DCA0
	public DownloadHandler get_downloadHandler() { }

	// RVA: 0x22A1730 Offset: 0x229FD30 VA: 0x1822A1730
	public void set_downloadHandler(DownloadHandler value) { }

	// RVA: 0x22A06B0 Offset: 0x229ECB0 VA: 0x1822A06B0
	private UnityWebRequest.UnityWebRequestError SetCertificateHandler(CertificateHandler ch) { }

	// RVA: 0x181DC90 Offset: 0x181C290 VA: 0x18181DC90
	public CertificateHandler get_certificateHandler() { }

	// RVA: 0x22A1520 Offset: 0x229FB20 VA: 0x1822A1520
	public void set_certificateHandler(CertificateHandler value) { }

	// RVA: 0x22A09B0 Offset: 0x229EFB0 VA: 0x1822A09B0
	private UnityWebRequest.UnityWebRequestError SetTimeoutMsec(int timeout) { }

	// RVA: 0x22A1A50 Offset: 0x22A0050 VA: 0x1822A1A50
	public void set_timeout(int value) { }

	// RVA: 0x229FFE0 Offset: 0x229E5E0 VA: 0x18229FFE0
	public static UnityWebRequest Get(string uri) { }

	// RVA: 0x22A0540 Offset: 0x229EB40 VA: 0x1822A0540
	public static UnityWebRequest Post(string uri, WWWForm formData) { }

	// RVA: 0x22A0A90 Offset: 0x229F090 VA: 0x1822A0A90
	private static void SetupPost(UnityWebRequest request, WWWForm formData) { }

	// RVA: 0x229FC80 Offset: 0x229E280 VA: 0x18229FC80
	public static string EscapeURL(string s) { }

	// RVA: 0x229FB30 Offset: 0x229E130 VA: 0x18229FB30
	public static string EscapeURL(string s, Encoding e) { }

	// RVA: 0x22A0F30 Offset: 0x229F530 VA: 0x1822A0F30
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

