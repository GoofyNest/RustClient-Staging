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
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <ThrowOnError>k__BackingField; // 0x1B0
	private bool unsafe_auth_blah; // 0x1B1
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	// RVA: 0x1340A30 Offset: 0x133F030 VA: 0x181340A30
	private static void .cctor() { }

	// RVA: 0x1340AA0 Offset: 0x133F0A0 VA: 0x181340AA0
	public void .ctor(Uri uri) { }

	[ObsoleteAttribute] // RVA: 0xB6F50 Offset: 0xB6350 VA: 0x1800B6F50
	// RVA: 0x1340C80 Offset: 0x133F280 VA: 0x181340C80
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x133F5B0 Offset: 0x133DBB0 VA: 0x18133F5B0
	private void ResetAuthorization() { }

	// RVA: 0x13401E0 Offset: 0x133E7E0 VA: 0x1813401E0
	private void SetSpecialHeaders(string HeaderName, string value) { }

	// RVA: 0x1341600 Offset: 0x133FC00 VA: 0x181341600
	public void set_Accept(string value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public Uri get_Address() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	internal void set_Address(Uri value) { }

	// RVA: 0x82D900 Offset: 0x82BF00 VA: 0x18082D900 Slot: 36
	public virtual void set_AllowAutoRedirect(bool value) { }

	// RVA: 0xBA1D50 Offset: 0xBA0350 VA: 0x180BA1D50 Slot: 37
	public virtual bool get_AllowWriteStreamBuffering() { }

	// RVA: 0x1238AA0 Offset: 0x12370A0 VA: 0x181238AA0 Slot: 38
	public virtual void set_AllowWriteStreamBuffering(bool value) { }

	// RVA: 0x871DF0 Offset: 0x8703F0 VA: 0x180871DF0
	public DecompressionMethods get_AutomaticDecompression() { }

	// RVA: 0x13416A0 Offset: 0x133FCA0 VA: 0x1813416A0
	public void set_AutomaticDecompression(DecompressionMethods value) { }

	// RVA: 0x1341400 Offset: 0x133FA00 VA: 0x181341400
	internal bool get_InternalAllowBuffering() { }

	// RVA: 0x1341410 Offset: 0x133FA10 VA: 0x181341410
	private bool get_MethodWithBuffer() { }

	// RVA: 0xA3C9B0 Offset: 0xA3AFB0 VA: 0x180A3C9B0
	internal MonoTlsProvider get_TlsProvider() { }

	// RVA: 0x900120 Offset: 0x8FE720 VA: 0x180900120
	internal MonoTlsSettings get_TlsSettings() { }

	// RVA: 0x13412F0 Offset: 0x133F8F0 VA: 0x1813412F0
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x1341720 Offset: 0x133FD20 VA: 0x181341720
	public void set_Connection(string value) { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880 Slot: 12
	public override void set_ConnectionGroupName(string value) { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50 Slot: 15
	public override long get_ContentLength() { }

	// RVA: 0x13418D0 Offset: 0x133FED0 VA: 0x1813418D0 Slot: 16
	public override void set_ContentLength(long value) { }

	// RVA: 0x1341F30 Offset: 0x1340530 VA: 0x181341F30
	internal void set_InternalContentLength(long value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC83140 Offset: 0xC81740 VA: 0x180C83140
	internal bool get_ThrowOnError() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13424D0 Offset: 0x1340AD0 VA: 0x1813424D0
	internal void set_ThrowOnError(bool value) { }

	// RVA: 0x1341360 Offset: 0x133F960 VA: 0x181341360 Slot: 17
	public override string get_ContentType() { }

	// RVA: 0x13419A0 Offset: 0x133FFA0 VA: 0x1813419A0 Slot: 18
	public override void set_ContentType(string value) { }

	// RVA: 0x4E8840 Offset: 0x4E6E40 VA: 0x1804E8840 Slot: 39
	public virtual void set_CookieContainer(CookieContainer value) { }

	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0 Slot: 19
	public override ICredentials get_Credentials() { }

	// RVA: 0x574470 Offset: 0x572A70 VA: 0x180574470 Slot: 20
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x1341A00 Offset: 0x1340000 VA: 0x181341A00
	public void set_Expect(string value) { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050 Slot: 13
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1341B70 Offset: 0x1340170 VA: 0x181341B70 Slot: 14
	public override void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x13413D0 Offset: 0x133F9D0 VA: 0x1813413D0
	public string get_Host() { }

	// RVA: 0x1341CF0 Offset: 0x13402F0 VA: 0x181341CF0
	public void set_Host(string value) { }

	// RVA: 0x133D760 Offset: 0x133BD60 VA: 0x18133D760
	private static bool CheckValidHost(string scheme, string val) { }

	// RVA: 0x1182FA0 Offset: 0x11815A0 VA: 0x181182FA0
	public bool get_KeepAlive() { }

	// RVA: 0x1341F40 Offset: 0x1340540 VA: 0x181341F40
	public void set_KeepAlive(bool value) { }

	// RVA: 0x1341F50 Offset: 0x1340550 VA: 0x181341F50
	public void set_MaximumAutomaticRedirections(int value) { }

	// RVA: 0x13414F0 Offset: 0x133FAF0 VA: 0x1813414F0
	public int get_ReadWriteTimeout() { }

	// RVA: 0x952CA0 Offset: 0x9512A0 VA: 0x180952CA0 Slot: 9
	public override string get_Method() { }

	// RVA: 0x1341FD0 Offset: 0x13405D0 VA: 0x181341FD0 Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x12DADE0 Offset: 0x12D93E0 VA: 0x1812DADE0 Slot: 25
	public override void set_PreAuthenticate(bool value) { }

	// RVA: 0x104F470 Offset: 0x104DA70 VA: 0x18104F470
	public Version get_ProtocolVersion() { }

	// RVA: 0x1342150 Offset: 0x1340750 VA: 0x181342150
	public void set_ProtocolVersion(Version value) { }

	// RVA: 0xD9F730 Offset: 0xD9DD30 VA: 0x180D9F730 Slot: 23
	public override IWebProxy get_Proxy() { }

	// RVA: 0x13422A0 Offset: 0x13408A0 VA: 0x1813422A0 Slot: 24
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x1342340 Offset: 0x1340940 VA: 0x181342340
	public void set_Referer(string value) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x10C7F90 Offset: 0x10C6590 VA: 0x1810C7F90
	public bool get_SendChunked() { }

	// RVA: 0x1342450 Offset: 0x1340A50 VA: 0x181342450
	public void set_SendChunked(bool value) { }

	// RVA: 0x1341510 Offset: 0x133FB10 VA: 0x181341510
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x872250 Offset: 0x870850 VA: 0x180872250
	internal ServicePoint get_ServicePointNoLock() { }

	// RVA: 0x107A090 Offset: 0x1078690 VA: 0x18107A090 Slot: 26
	public override int get_Timeout() { }

	// RVA: 0x1341520 Offset: 0x133FB20 VA: 0x181341520
	public string get_TransferEncoding() { }

	// RVA: 0x1341580 Offset: 0x133FB80 VA: 0x181341580 Slot: 21
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x13424E0 Offset: 0x1340AE0 VA: 0x1813424E0 Slot: 22
	public override void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x1342570 Offset: 0x1340B70 VA: 0x181342570
	public void set_UserAgent(string value) { }

	// RVA: 0x1341570 Offset: 0x133FB70 VA: 0x181341570
	public bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x13413B0 Offset: 0x133F9B0 VA: 0x1813413B0
	internal bool get_ExpectContinue() { }

	// RVA: 0x13419F0 Offset: 0x133FFF0 VA: 0x1813419F0
	internal void set_ExpectContinue(bool value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal Uri get_AuthUri() { }

	// RVA: 0x13414C0 Offset: 0x133FAC0 VA: 0x1813414C0
	internal bool get_ProxyQuery() { }

	// RVA: 0xC83450 Offset: 0xC81A50 VA: 0x180C83450
	internal ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x133EDE0 Offset: 0x133D3E0 VA: 0x18133EDE0
	internal ServicePoint GetServicePoint() { }

	// RVA: 0x133C550 Offset: 0x133AB50 VA: 0x18133C550 Slot: 31
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x133DA50 Offset: 0x133C050 VA: 0x18133DA50 Slot: 32
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x133EBA0 Offset: 0x133D1A0 VA: 0x18133EBA0 Slot: 27
	public override Stream GetRequestStream() { }

	// RVA: 0x133D460 Offset: 0x133BA60 VA: 0x18133D460
	private bool CheckIfForceWrite(SimpleAsyncResult result) { }

	// RVA: 0x133C9D0 Offset: 0x133AFD0 VA: 0x18133C9D0 Slot: 29
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x133DB70 Offset: 0x133C170 VA: 0x18133DB70 Slot: 30
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x133ED30 Offset: 0x133D330 VA: 0x18133ED30 Slot: 28
	public override WebResponse GetResponse() { }

	// RVA: 0x13413C0 Offset: 0x133F9C0 VA: 0x1813413C0
	internal bool get_FinishedReading() { }

	// RVA: 0x1341B60 Offset: 0x1340160 VA: 0x181341B60
	internal void set_FinishedReading(bool value) { }

	// RVA: 0x13412C0 Offset: 0x133F8C0 VA: 0x1813412C0
	internal bool get_Aborted() { }

	// RVA: 0x133C2C0 Offset: 0x133A8C0 VA: 0x18133C2C0 Slot: 35
	public override void Abort() { }

	// RVA: 0x118E810 Offset: 0x118CE10 VA: 0x18118E810 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x133E450 Offset: 0x133CA50 VA: 0x18133E450 Slot: 7
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x133D5B0 Offset: 0x133BBB0 VA: 0x18133D5B0
	private void CheckRequestStarted() { }

	// RVA: 0x133D8D0 Offset: 0x133BED0 VA: 0x18133D8D0
	internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers) { }

	// RVA: 0x133F640 Offset: 0x133DC40 VA: 0x18133F640
	private void RewriteRedirectToGet() { }

	// RVA: 0x133F190 Offset: 0x133D790 VA: 0x18133F190
	private bool Redirect(WebAsyncResult result, HttpStatusCode code, WebResponse response) { }

	// RVA: 0x133DCF0 Offset: 0x133C2F0 VA: 0x18133DCF0
	private string GetHeaders() { }

	// RVA: 0x133D8F0 Offset: 0x133BEF0 VA: 0x18133D8F0
	private void DoPreAuthenticate() { }

	// RVA: 0x1340340 Offset: 0x133E940 VA: 0x181340340
	internal void SetWriteStreamError(WebExceptionStatus status, Exception exc) { }

	// RVA: 0x133E740 Offset: 0x133CD40 VA: 0x18133E740
	internal byte[] GetRequestHeaders() { }

	// RVA: 0x1340570 Offset: 0x133EB70 VA: 0x181340570
	internal void SetWriteStream(WebConnectionStream stream) { }

	// RVA: 0x13404F0 Offset: 0x133EAF0 VA: 0x1813404F0
	private void SetWriteStreamInner(SimpleAsyncCallback callback) { }

	// RVA: 0x13402A0 Offset: 0x133E8A0 VA: 0x1813402A0
	private void SetWriteStreamError(Exception exc) { }

	// RVA: 0x133FF40 Offset: 0x133E540 VA: 0x18133FF40
	internal void SetResponseError(WebExceptionStatus status, Exception e, string where) { }

	// RVA: 0x133D620 Offset: 0x133BC20 VA: 0x18133D620
	private void CheckSendError(WebConnectionData data) { }

	// RVA: 0x133EF20 Offset: 0x133D520 VA: 0x18133EF20
	private bool HandleNtlmAuth(WebAsyncResult r) { }

	// RVA: 0x133F6B0 Offset: 0x133DCB0 VA: 0x18133F6B0
	internal void SetResponseData(WebConnectionData data) { }

	// RVA: 0x133CCD0 Offset: 0x133B2D0 VA: 0x18133CCD0
	private bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x133CD00 Offset: 0x133B300 VA: 0x18133CD00
	private bool CheckFinalStatus(WebAsyncResult result) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1341500 Offset: 0x133FB00 VA: 0x181341500
	internal bool get_ReuseConnection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1342440 Offset: 0x1340A40 VA: 0x181342440
	internal void set_ReuseConnection(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1340770 Offset: 0x133ED70 VA: 0x181340770
	private void <SetWriteStream>b__258_0(SimpleAsyncResult result) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13408F0 Offset: 0x133EEF0 VA: 0x1813408F0
	private void <SetWriteStream>b__258_1(SimpleAsyncResult inner) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1340670 Offset: 0x133EC70 VA: 0x181340670
	private bool <SetWriteStreamInner>b__259_0(SimpleAsyncResult result) { }

	[EditorBrowsableAttribute] // RVA: 0xB87E0 Offset: 0xB7BE0 VA: 0x1800B87E0
	[ObsoleteAttribute] // RVA: 0xB87E0 Offset: 0xB7BE0 VA: 0x1800B87E0
	// RVA: 0x1340A70 Offset: 0x133F070 VA: 0x181340A70
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

	// RVA: 0x1AE2F0 Offset: 0x1AD6F0 VA: 0x1801AE2F0
	public bool get_IsCompleted() { }

	// RVA: 0x1AE430 Offset: 0x1AD830 VA: 0x1801AE430
	public HttpWebRequest.NtlmAuthState get_NtlmAuthState() { }

	// RVA: 0x1E1550 Offset: 0x1E0950 VA: 0x1801E1550
	public bool get_IsNtlmAuthenticated() { }

	// RVA: 0x1E1510 Offset: 0x1E0910 VA: 0x1801E1510
	public void .ctor(HttpWebRequest request, bool isProxy) { }

	// RVA: 0x1E1440 Offset: 0x1E0840 VA: 0x1801E1440
	public bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x1E1450 Offset: 0x1E0850 VA: 0x1801E1450
	public void Reset() { }

	// RVA: 0x1E1460 Offset: 0x1E0860 VA: 0x1801E1460 Slot: 3
	public override string ToString() { }

}

private sealed class HttpWebRequest.<>c__DisplayClass238_0 // TypeDefIndex: 3009
{	// Fields
	public WebAsyncResult aread; // 0x10
	public HttpWebRequest <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1349730 Offset: 0x1347D30 VA: 0x181349730
	internal void <BeginGetResponse>b__0(SimpleAsyncResult inner) { }

}

