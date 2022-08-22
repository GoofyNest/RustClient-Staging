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
	// RVA: 0x229FCE0 Offset: 0x229E2E0 VA: 0x18229FCE0
	private static string GetWebErrorString(UnityWebRequest.UnityWebRequestError err) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x229FC60 Offset: 0x229E260 VA: 0x18229FC60
	internal static string GetHTTPStatusString(long responseCode) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1040 Offset: 0x8BF640 VA: 0x1808C1040
	public bool get_disposeCertificateHandlerOnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x78E170 Offset: 0x78C770 VA: 0x18078E170
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1050 Offset: 0x8BF650 VA: 0x1808C1050
	public bool get_disposeDownloadHandlerOnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1060 Offset: 0x8BF660 VA: 0x1808C1060
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1160330 Offset: 0x115E930 VA: 0x181160330
	public bool get_disposeUploadHandlerOnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1160740 Offset: 0x115ED40 VA: 0x181160740
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	// RVA: 0x229F740 Offset: 0x229DD40 VA: 0x18229F740
	internal static IntPtr Create() { }

	[NativeMethodAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x22A0350 Offset: 0x229E950 VA: 0x1822A0350
	private void Release() { }

	// RVA: 0x229FE40 Offset: 0x229E440 VA: 0x18229FE40
	internal void InternalDestroy() { }

	// RVA: 0x229FFD0 Offset: 0x229E5D0 VA: 0x18229FFD0
	private void InternalSetDefaults() { }

	// RVA: 0x22A0E80 Offset: 0x229F480 VA: 0x1822A0E80
	public void .ctor(string url) { }

	// RVA: 0x22A0E00 Offset: 0x229F400 VA: 0x1822A0E00
	public void .ctor(string url, string method) { }

	// RVA: 0x22A0D50 Offset: 0x229F350 VA: 0x1822A0D50
	public void .ctor(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	// RVA: 0x229FB10 Offset: 0x229E110 VA: 0x18229FB10 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x229F7D0 Offset: 0x229DDD0 VA: 0x18229F7D0 Slot: 4
	public void Dispose() { }

	// RVA: 0x229F770 Offset: 0x229DD70 VA: 0x18229F770
	private void DisposeHandlers() { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x229F700 Offset: 0x229DD00 VA: 0x18229F700
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	[ObsoleteAttribute] // RVA: 0x907C0 Offset: 0x8FBC0 VA: 0x1800907C0
	// RVA: 0x22A0390 Offset: 0x229E990 VA: 0x1822A0390
	public AsyncOperation Send() { }

	// RVA: 0x22A0390 Offset: 0x229E990 VA: 0x1822A0390
	public UnityWebRequestAsyncOperation SendWebRequest() { }

	[NativeMethodAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x229F6C0 Offset: 0x229DCC0 VA: 0x18229F6C0
	public void Abort() { }

	// RVA: 0x22A0530 Offset: 0x229EB30 VA: 0x1822A0530
	private UnityWebRequest.UnityWebRequestError SetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x229FFE0 Offset: 0x229E5E0 VA: 0x18229FFE0
	internal void InternalSetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x22A0490 Offset: 0x229EA90 VA: 0x1822A0490
	private UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName) { }

	// RVA: 0x229FED0 Offset: 0x229E4D0 VA: 0x18229FED0
	internal void InternalSetCustomMethod(string customMethodName) { }

	// RVA: 0x22A1580 Offset: 0x229FB80 VA: 0x1822A1580
	public void set_method(string value) { }

	// RVA: 0x229FC20 Offset: 0x229E220 VA: 0x18229FC20
	private UnityWebRequest.UnityWebRequestError GetError() { }

	// RVA: 0x22A0F80 Offset: 0x229F580 VA: 0x1822A0F80
	public string get_error() { }

	// RVA: 0x229FCA0 Offset: 0x229E2A0 VA: 0x18229FCA0
	public string get_url() { }

	// RVA: 0x22A19D0 Offset: 0x229FFD0 VA: 0x1822A19D0
	public void set_url(string value) { }

	// RVA: 0x229FCA0 Offset: 0x229E2A0 VA: 0x18229FCA0
	private string GetUrl() { }

	// RVA: 0x22A0780 Offset: 0x229ED80 VA: 0x1822A0780
	private UnityWebRequest.UnityWebRequestError SetUrl(string url) { }

	// RVA: 0x22A0140 Offset: 0x229E740 VA: 0x1822A0140
	private void InternalSetUrl(string url) { }

	// RVA: 0x22A1220 Offset: 0x229F820 VA: 0x1822A1220
	public long get_responseCode() { }

	// RVA: 0x22A0240 Offset: 0x229E840 VA: 0x1822A0240
	private bool IsExecuting() { }

	[NativeMethodAttribute] // RVA: 0x90A10 Offset: 0x8FE10 VA: 0x180090A10
	// RVA: 0x22A11A0 Offset: 0x229F7A0 VA: 0x1822A11A0
	public bool get_isModifiable() { }

	[NativeMethodAttribute] // RVA: 0x90BC0 Offset: 0x8FFC0 VA: 0x180090BC0
	// RVA: 0x22A1120 Offset: 0x229F720 VA: 0x1822A1120
	public bool get_isDone() { }

	[NativeMethodAttribute] // RVA: 0x90D60 Offset: 0x90160 VA: 0x180090D60
	// RVA: 0x22A11E0 Offset: 0x229F7E0 VA: 0x1822A11E0
	public bool get_isNetworkError() { }

	[NativeMethodAttribute] // RVA: 0x90E70 Offset: 0x90270 VA: 0x180090E70
	// RVA: 0x22A1160 Offset: 0x229F760 VA: 0x1822A1160
	public bool get_isHttpError() { }

	// RVA: 0x229FBE0 Offset: 0x229E1E0 VA: 0x18229FBE0
	private float GetDownloadProgress() { }

	// RVA: 0x22A0EE0 Offset: 0x229F4E0 VA: 0x1822A0EE0
	public float get_downloadProgress() { }

	// RVA: 0x22A0440 Offset: 0x229EA40 VA: 0x1822A0440
	private UnityWebRequest.UnityWebRequestError SetChunked(bool chunked) { }

	// RVA: 0x22A1370 Offset: 0x229F970 VA: 0x1822A1370
	public void set_chunkedTransfer(bool value) { }

	[NativeMethodAttribute] // RVA: 0x90FB0 Offset: 0x903B0 VA: 0x180090FB0
	// RVA: 0x22A00E0 Offset: 0x229E6E0 VA: 0x1822A00E0
	internal UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(string name, string value) { }

	// RVA: 0x22A0570 Offset: 0x229EB70 VA: 0x1822A0570
	public void SetRequestHeader(string name, string value) { }

	// RVA: 0x22A0730 Offset: 0x229ED30 VA: 0x1822A0730
	private UnityWebRequest.UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	// RVA: 0x1A6C6E0 Offset: 0x1A6ACE0 VA: 0x181A6C6E0
	public UploadHandler get_uploadHandler() { }

	// RVA: 0x22A18C0 Offset: 0x229FEC0 VA: 0x1822A18C0
	public void set_uploadHandler(UploadHandler value) { }

	// RVA: 0x22A04E0 Offset: 0x229EAE0 VA: 0x1822A04E0
	private UnityWebRequest.UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	// RVA: 0x181D9E0 Offset: 0x181BFE0 VA: 0x18181D9E0
	public DownloadHandler get_downloadHandler() { }

	// RVA: 0x22A1470 Offset: 0x229FA70 VA: 0x1822A1470
	public void set_downloadHandler(DownloadHandler value) { }

	// RVA: 0x22A03F0 Offset: 0x229E9F0 VA: 0x1822A03F0
	private UnityWebRequest.UnityWebRequestError SetCertificateHandler(CertificateHandler ch) { }

	// RVA: 0x181D9D0 Offset: 0x181BFD0 VA: 0x18181D9D0
	public CertificateHandler get_certificateHandler() { }

	// RVA: 0x22A1260 Offset: 0x229F860 VA: 0x1822A1260
	public void set_certificateHandler(CertificateHandler value) { }

	// RVA: 0x22A06F0 Offset: 0x229ECF0 VA: 0x1822A06F0
	private UnityWebRequest.UnityWebRequestError SetTimeoutMsec(int timeout) { }

	// RVA: 0x22A1790 Offset: 0x229FD90 VA: 0x1822A1790
	public void set_timeout(int value) { }

	// RVA: 0x229FD20 Offset: 0x229E320 VA: 0x18229FD20
	public static UnityWebRequest Get(string uri) { }

	// RVA: 0x22A0280 Offset: 0x229E880 VA: 0x1822A0280
	public static UnityWebRequest Post(string uri, WWWForm formData) { }

	// RVA: 0x22A07D0 Offset: 0x229EDD0 VA: 0x1822A07D0
	private static void SetupPost(UnityWebRequest request, WWWForm formData) { }

	// RVA: 0x229F9C0 Offset: 0x229DFC0 VA: 0x18229F9C0
	public static string EscapeURL(string s) { }

	// RVA: 0x229F870 Offset: 0x229DE70 VA: 0x18229F870
	public static string EscapeURL(string s, Encoding e) { }

	// RVA: 0x22A0C70 Offset: 0x229F270 VA: 0x1822A0C70
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

