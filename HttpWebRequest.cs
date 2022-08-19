public class HttpWebRequest : WebRequest, ISerializable // TypeDefIndex: 3006
{	// Fields
	private Uri requestUri; // 0x38
	private Uri actualUri; // 0x40
	private bool hostChanged; // 0x48
	private bool allowAutoRedirect; // 0x49
	private bool allowBuffering; // 0x4A
	private X509CertificateCollection certificates; // 0x50
	private string connectionGroup; // 0x58
	private bool haveContentLength; // 0x60
	private long contentLength; // 0x68
	private HttpContinueDelegate continueDelegate; // 0x70
	private CookieContainer cookieContainer; // 0x78
	private ICredentials credentials; // 0x80
	private bool haveResponse; // 0x88
	private bool haveRequest; // 0x89
	private bool requestSent; // 0x8A
	private WebHeaderCollection webHeaders; // 0x90
	private bool keepAlive; // 0x98
	private int maxAutoRedirect; // 0x9C
	private string mediaType; // 0xA0
	private string method; // 0xA8
	private string initialMethod; // 0xB0
	private bool pipelined; // 0xB8
	private bool preAuthenticate; // 0xB9
	private bool usedPreAuth; // 0xBA
	private Version version; // 0xC0
	private bool force_version; // 0xC8
	private Version actualVersion; // 0xD0
	private IWebProxy proxy; // 0xD8
	private bool sendChunked; // 0xE0
	private ServicePoint servicePoint; // 0xE8
	private int timeout; // 0xF0
	private WebConnectionStream writeStream; // 0xF8
	private HttpWebResponse webResponse; // 0x100
	private WebAsyncResult asyncWrite; // 0x108
	private WebAsyncResult asyncRead; // 0x110
	private EventHandler abortHandler; // 0x118
	private int aborted; // 0x120
	private bool gotRequestStream; // 0x124
	private int redirects; // 0x128
	private bool expectContinue; // 0x12C
	private byte[] bodyBuffer; // 0x130
	private int bodyBufferLength; // 0x138
	private bool getResponseCalled; // 0x13C
	private Exception saved_exc; // 0x140
	private object locker; // 0x148
	private bool finished_reading; // 0x150
	internal WebConnection WebConnection; // 0x158
	private DecompressionMethods auto_decomp; // 0x160
	private static int defaultMaxResponseHeadersLength; // 0x0
	private int readWriteTimeout; // 0x164
	private MonoTlsProvider tlsProvider; // 0x168
	private MonoTlsSettings tlsSettings; // 0x170
	private ServerCertValidationCallback certValidationCallback; // 0x178
	private HttpWebRequest.AuthorizationState auth_state; // 0x180
	private HttpWebRequest.AuthorizationState proxy_auth_state; // 0x190
	private string host; // 0x1A0
	internal Action<Stream> ResendContentFactory; // 0x1A8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <ThrowOnError>k__BackingField; // 0x1B0
	private bool unsafe_auth_blah; // 0x1B1
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <ReuseConnection>k__BackingField; // 0x1B2
	internal WebConnection StoredConnection; // 0x1B8

	// Properties
	public string Accept { set; }
	public Uri Address { get; set; }
	public virtual bool AllowAutoRedirect { set; }
	public virtual bool AllowWriteStreamBuffering { get; set; }
	public DecompressionMethods AutomaticDecompression { get; set; }
	internal bool InternalAllowBuffering { get; }
	private bool MethodWithBuffer { get; }
	internal MonoTlsProvider TlsProvider { get; }
	internal MonoTlsSettings TlsSettings { get; }
	public X509CertificateCollection ClientCertificates { get; }
	public string Connection { set; }
	public override string ConnectionGroupName { set; }
	public override long ContentLength { get; set; }
	internal long InternalContentLength { set; }
	internal bool ThrowOnError { get; set; }
	public override string ContentType { get; set; }
	public virtual CookieContainer CookieContainer { set; }
	public override ICredentials Credentials { get; set; }
	public string Expect { set; }
	public override WebHeaderCollection Headers { get; set; }
	public string Host { get; set; }
	public bool KeepAlive { get; set; }
	public int MaximumAutomaticRedirections { set; }
	public int ReadWriteTimeout { get; }
	public override string Method { get; set; }
	public override bool PreAuthenticate { set; }
	public Version ProtocolVersion { get; set; }
	public override IWebProxy Proxy { get; set; }
	public string Referer { set; }
	public override Uri RequestUri { get; }
	public bool SendChunked { get; set; }
	public ServicePoint ServicePoint { get; }
	internal ServicePoint ServicePointNoLock { get; }
	public override int Timeout { get; }
	public string TransferEncoding { get; }
	public override bool UseDefaultCredentials { get; set; }
	public string UserAgent { set; }
	public bool UnsafeAuthenticatedConnectionSharing { get; }
	internal bool ExpectContinue { get; set; }
	internal Uri AuthUri { get; }
	internal bool ProxyQuery { get; }
	internal ServerCertValidationCallback ServerCertValidationCallback { get; }
	internal bool FinishedReading { get; set; }
	internal bool Aborted { get; }
	internal bool ReuseConnection { get; set; }

	// Methods

	// RVA: 0x1340770 Offset: 0x133ED70 VA: 0x181340770
	private static void .cctor() { }

	// RVA: 0x13407E0 Offset: 0x133EDE0 VA: 0x1813407E0
	public void .ctor(Uri uri) { }

	[ObsoleteAttribute] // RVA: 0xB6F60 Offset: 0xB6360 VA: 0x1800B6F60
	// RVA: 0x13409C0 Offset: 0x133EFC0 VA: 0x1813409C0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x133F2F0 Offset: 0x133D8F0 VA: 0x18133F2F0
	private void ResetAuthorization() { }

	// RVA: 0x133FF20 Offset: 0x133E520 VA: 0x18133FF20
	private void SetSpecialHeaders(string HeaderName, string value) { }

	// RVA: 0x1341340 Offset: 0x133F940 VA: 0x181341340
	public void set_Accept(string value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public Uri get_Address() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	internal void set_Address(Uri value) { }

	// RVA: 0x82D7F0 Offset: 0x82BDF0 VA: 0x18082D7F0 Slot: 36
	public virtual void set_AllowAutoRedirect(bool value) { }

	// RVA: 0xBA1A90 Offset: 0xBA0090 VA: 0x180BA1A90 Slot: 37
	public virtual bool get_AllowWriteStreamBuffering() { }

	// RVA: 0x12387E0 Offset: 0x1236DE0 VA: 0x1812387E0 Slot: 38
	public virtual void set_AllowWriteStreamBuffering(bool value) { }

	// RVA: 0x871CE0 Offset: 0x8702E0 VA: 0x180871CE0
	public DecompressionMethods get_AutomaticDecompression() { }

	// RVA: 0x13413E0 Offset: 0x133F9E0 VA: 0x1813413E0
	public void set_AutomaticDecompression(DecompressionMethods value) { }

	// RVA: 0x1341140 Offset: 0x133F740 VA: 0x181341140
	internal bool get_InternalAllowBuffering() { }

	// RVA: 0x1341150 Offset: 0x133F750 VA: 0x181341150
	private bool get_MethodWithBuffer() { }

	// RVA: 0xA3C6F0 Offset: 0xA3ACF0 VA: 0x180A3C6F0
	internal MonoTlsProvider get_TlsProvider() { }

	// RVA: 0x900010 Offset: 0x8FE610 VA: 0x180900010
	internal MonoTlsSettings get_TlsSettings() { }

	// RVA: 0x1341030 Offset: 0x133F630 VA: 0x181341030
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x1341460 Offset: 0x133FA60 VA: 0x181341460
	public void set_Connection(string value) { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880 Slot: 12
	public override void set_ConnectionGroupName(string value) { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50 Slot: 15
	public override long get_ContentLength() { }

	// RVA: 0x1341610 Offset: 0x133FC10 VA: 0x181341610 Slot: 16
	public override void set_ContentLength(long value) { }

	// RVA: 0x1341C70 Offset: 0x1340270 VA: 0x181341C70
	internal void set_InternalContentLength(long value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC82E80 Offset: 0xC81480 VA: 0x180C82E80
	internal bool get_ThrowOnError() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1342210 Offset: 0x1340810 VA: 0x181342210
	internal void set_ThrowOnError(bool value) { }

	// RVA: 0x13410A0 Offset: 0x133F6A0 VA: 0x1813410A0 Slot: 17
	public override string get_ContentType() { }

	// RVA: 0x13416E0 Offset: 0x133FCE0 VA: 0x1813416E0 Slot: 18
	public override void set_ContentType(string value) { }

	// RVA: 0x4E8840 Offset: 0x4E6E40 VA: 0x1804E8840 Slot: 39
	public virtual void set_CookieContainer(CookieContainer value) { }

	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0 Slot: 19
	public override ICredentials get_Credentials() { }

	// RVA: 0x574470 Offset: 0x572A70 VA: 0x180574470 Slot: 20
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x1341740 Offset: 0x133FD40 VA: 0x181341740
	public void set_Expect(string value) { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050 Slot: 13
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x13418B0 Offset: 0x133FEB0 VA: 0x1813418B0 Slot: 14
	public override void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x1341110 Offset: 0x133F710 VA: 0x181341110
	public string get_Host() { }

	// RVA: 0x1341A30 Offset: 0x1340030 VA: 0x181341A30
	public void set_Host(string value) { }

	// RVA: 0x133D4A0 Offset: 0x133BAA0 VA: 0x18133D4A0
	private static bool CheckValidHost(string scheme, string val) { }

	// RVA: 0x1182CE0 Offset: 0x11812E0 VA: 0x181182CE0
	public bool get_KeepAlive() { }

	// RVA: 0x1341C80 Offset: 0x1340280 VA: 0x181341C80
	public void set_KeepAlive(bool value) { }

	// RVA: 0x1341C90 Offset: 0x1340290 VA: 0x181341C90
	public void set_MaximumAutomaticRedirections(int value) { }

	// RVA: 0x1341230 Offset: 0x133F830 VA: 0x181341230
	public int get_ReadWriteTimeout() { }

	// RVA: 0x952B90 Offset: 0x951190 VA: 0x180952B90 Slot: 9
	public override string get_Method() { }

	// RVA: 0x1341D10 Offset: 0x1340310 VA: 0x181341D10 Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x12DAB20 Offset: 0x12D9120 VA: 0x1812DAB20 Slot: 25
	public override void set_PreAuthenticate(bool value) { }

	// RVA: 0x104F1B0 Offset: 0x104D7B0 VA: 0x18104F1B0
	public Version get_ProtocolVersion() { }

	// RVA: 0x1341E90 Offset: 0x1340490 VA: 0x181341E90
	public void set_ProtocolVersion(Version value) { }

	// RVA: 0xD9F470 Offset: 0xD9DA70 VA: 0x180D9F470 Slot: 23
	public override IWebProxy get_Proxy() { }

	// RVA: 0x1341FE0 Offset: 0x13405E0 VA: 0x181341FE0 Slot: 24
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x1342080 Offset: 0x1340680 VA: 0x181342080
	public void set_Referer(string value) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x10C7CD0 Offset: 0x10C62D0 VA: 0x1810C7CD0
	public bool get_SendChunked() { }

	// RVA: 0x1342190 Offset: 0x1340790 VA: 0x181342190
	public void set_SendChunked(bool value) { }

	// RVA: 0x1341250 Offset: 0x133F850 VA: 0x181341250
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x872140 Offset: 0x870740 VA: 0x180872140
	internal ServicePoint get_ServicePointNoLock() { }

	// RVA: 0x1079DD0 Offset: 0x10783D0 VA: 0x181079DD0 Slot: 26
	public override int get_Timeout() { }

	// RVA: 0x1341260 Offset: 0x133F860 VA: 0x181341260
	public string get_TransferEncoding() { }

	// RVA: 0x13412C0 Offset: 0x133F8C0 VA: 0x1813412C0 Slot: 21
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x1342220 Offset: 0x1340820 VA: 0x181342220 Slot: 22
	public override void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x13422B0 Offset: 0x13408B0 VA: 0x1813422B0
	public void set_UserAgent(string value) { }

	// RVA: 0x13412B0 Offset: 0x133F8B0 VA: 0x1813412B0
	public bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x13410F0 Offset: 0x133F6F0 VA: 0x1813410F0
	internal bool get_ExpectContinue() { }

	// RVA: 0x1341730 Offset: 0x133FD30 VA: 0x181341730
	internal void set_ExpectContinue(bool value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal Uri get_AuthUri() { }

	// RVA: 0x1341200 Offset: 0x133F800 VA: 0x181341200
	internal bool get_ProxyQuery() { }

	// RVA: 0xC83190 Offset: 0xC81790 VA: 0x180C83190
	internal ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x133EB20 Offset: 0x133D120 VA: 0x18133EB20
	internal ServicePoint GetServicePoint() { }

	// RVA: 0x133C290 Offset: 0x133A890 VA: 0x18133C290 Slot: 31
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x133D790 Offset: 0x133BD90 VA: 0x18133D790 Slot: 32
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x133E8E0 Offset: 0x133CEE0 VA: 0x18133E8E0 Slot: 27
	public override Stream GetRequestStream() { }

	// RVA: 0x133D1A0 Offset: 0x133B7A0 VA: 0x18133D1A0
	private bool CheckIfForceWrite(SimpleAsyncResult result) { }

	// RVA: 0x133C710 Offset: 0x133AD10 VA: 0x18133C710 Slot: 29
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x133D8B0 Offset: 0x133BEB0 VA: 0x18133D8B0 Slot: 30
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x133EA70 Offset: 0x133D070 VA: 0x18133EA70 Slot: 28
	public override WebResponse GetResponse() { }

	// RVA: 0x1341100 Offset: 0x133F700 VA: 0x181341100
	internal bool get_FinishedReading() { }

	// RVA: 0x13418A0 Offset: 0x133FEA0 VA: 0x1813418A0
	internal void set_FinishedReading(bool value) { }

	// RVA: 0x1341000 Offset: 0x133F600 VA: 0x181341000
	internal bool get_Aborted() { }

	// RVA: 0x133C000 Offset: 0x133A600 VA: 0x18133C000 Slot: 35
	public override void Abort() { }

	// RVA: 0x118E550 Offset: 0x118CB50 VA: 0x18118E550 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x133E190 Offset: 0x133C790 VA: 0x18133E190 Slot: 7
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x133D2F0 Offset: 0x133B8F0 VA: 0x18133D2F0
	private void CheckRequestStarted() { }

	// RVA: 0x133D610 Offset: 0x133BC10 VA: 0x18133D610
	internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers) { }

	// RVA: 0x133F380 Offset: 0x133D980 VA: 0x18133F380
	private void RewriteRedirectToGet() { }

	// RVA: 0x133EED0 Offset: 0x133D4D0 VA: 0x18133EED0
	private bool Redirect(WebAsyncResult result, HttpStatusCode code, WebResponse response) { }

	// RVA: 0x133DA30 Offset: 0x133C030 VA: 0x18133DA30
	private string GetHeaders() { }

	// RVA: 0x133D630 Offset: 0x133BC30 VA: 0x18133D630
	private void DoPreAuthenticate() { }

	// RVA: 0x1340080 Offset: 0x133E680 VA: 0x181340080
	internal void SetWriteStreamError(WebExceptionStatus status, Exception exc) { }

	// RVA: 0x133E480 Offset: 0x133CA80 VA: 0x18133E480
	internal byte[] GetRequestHeaders() { }

	// RVA: 0x13402B0 Offset: 0x133E8B0 VA: 0x1813402B0
	internal void SetWriteStream(WebConnectionStream stream) { }

	// RVA: 0x1340230 Offset: 0x133E830 VA: 0x181340230
	private void SetWriteStreamInner(SimpleAsyncCallback callback) { }

	// RVA: 0x133FFE0 Offset: 0x133E5E0 VA: 0x18133FFE0
	private void SetWriteStreamError(Exception exc) { }

	// RVA: 0x133FC80 Offset: 0x133E280 VA: 0x18133FC80
	internal void SetResponseError(WebExceptionStatus status, Exception e, string where) { }

	// RVA: 0x133D360 Offset: 0x133B960 VA: 0x18133D360
	private void CheckSendError(WebConnectionData data) { }

	// RVA: 0x133EC60 Offset: 0x133D260 VA: 0x18133EC60
	private bool HandleNtlmAuth(WebAsyncResult r) { }

	// RVA: 0x133F3F0 Offset: 0x133D9F0 VA: 0x18133F3F0
	internal void SetResponseData(WebConnectionData data) { }

	// RVA: 0x133CA10 Offset: 0x133B010 VA: 0x18133CA10
	private bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x133CA40 Offset: 0x133B040 VA: 0x18133CA40
	private bool CheckFinalStatus(WebAsyncResult result) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1341240 Offset: 0x133F840 VA: 0x181341240
	internal bool get_ReuseConnection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1342180 Offset: 0x1340780 VA: 0x181342180
	internal void set_ReuseConnection(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x13404B0 Offset: 0x133EAB0 VA: 0x1813404B0
	private void <SetWriteStream>b__258_0(SimpleAsyncResult result) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1340630 Offset: 0x133EC30 VA: 0x181340630
	private void <SetWriteStream>b__258_1(SimpleAsyncResult inner) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x13403B0 Offset: 0x133E9B0 VA: 0x1813403B0
	private bool <SetWriteStreamInner>b__259_0(SimpleAsyncResult result) { }

	[EditorBrowsableAttribute] // RVA: 0xB87E0 Offset: 0xB7BE0 VA: 0x1800B87E0
	[ObsoleteAttribute] // RVA: 0xB87E0 Offset: 0xB7BE0 VA: 0x1800B87E0
	// RVA: 0x13407B0 Offset: 0x133EDB0 VA: 0x1813407B0
	public void .ctor() { }

}

private enum HttpWebRequest.NtlmAuthState // TypeDefIndex: 3007
{	// Fields
	public int value__; // 0x0
	public const HttpWebRequest.NtlmAuthState None = 0;
	public const HttpWebRequest.NtlmAuthState Challenge = 1;
	public const HttpWebRequest.NtlmAuthState Response = 2;

}

private struct HttpWebRequest.AuthorizationState // TypeDefIndex: 3008
{	// Fields
	private readonly HttpWebRequest request; // 0x0
	private readonly bool isProxy; // 0x8
	private bool isCompleted; // 0x9
	private HttpWebRequest.NtlmAuthState ntlm_auth_state; // 0xC

	// Properties
	public bool IsCompleted { get; }
	public HttpWebRequest.NtlmAuthState NtlmAuthState { get; }
	public bool IsNtlmAuthenticated { get; }

	// Methods

	// RVA: 0x1AE370 Offset: 0x1AD770 VA: 0x1801AE370
	public bool get_IsCompleted() { }

	// RVA: 0x1AE4B0 Offset: 0x1AD8B0 VA: 0x1801AE4B0
	public HttpWebRequest.NtlmAuthState get_NtlmAuthState() { }

	// RVA: 0x1E15D0 Offset: 0x1E09D0 VA: 0x1801E15D0
	public bool get_IsNtlmAuthenticated() { }

	// RVA: 0x1E1590 Offset: 0x1E0990 VA: 0x1801E1590
	public void .ctor(HttpWebRequest request, bool isProxy) { }

	// RVA: 0x1E14C0 Offset: 0x1E08C0 VA: 0x1801E14C0
	public bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x1E14D0 Offset: 0x1E08D0 VA: 0x1801E14D0
	public void Reset() { }

	// RVA: 0x1E14E0 Offset: 0x1E08E0 VA: 0x1801E14E0 Slot: 3
	public override string ToString() { }

}

private sealed class HttpWebRequest.<>c__DisplayClass238_0 // TypeDefIndex: 3009
{	// Fields
	public WebAsyncResult aread; // 0x10
	public HttpWebRequest <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1349470 Offset: 0x1347A70 VA: 0x181349470
	internal void <BeginGetResponse>b__0(SimpleAsyncResult inner) { }

}

