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

	// RVA: 0x133FB30 Offset: 0x133E130 VA: 0x18133FB30
	private static void .cctor() { }

	// RVA: 0x133FBA0 Offset: 0x133E1A0 VA: 0x18133FBA0
	public void .ctor(Uri uri) { }

	[ObsoleteAttribute] // RVA: 0xB6F50 Offset: 0xB6350 VA: 0x1800B6F50
	// RVA: 0x133FD80 Offset: 0x133E380 VA: 0x18133FD80
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x133E6B0 Offset: 0x133CCB0 VA: 0x18133E6B0
	private void ResetAuthorization() { }

	// RVA: 0x133F2E0 Offset: 0x133D8E0 VA: 0x18133F2E0
	private void SetSpecialHeaders(string HeaderName, string value) { }

	// RVA: 0x1340700 Offset: 0x133ED00 VA: 0x181340700
	public void set_Accept(string value) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public Uri get_Address() { }

	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	internal void set_Address(Uri value) { }

	// RVA: 0x82DE50 Offset: 0x82C450 VA: 0x18082DE50 Slot: 36
	public virtual void set_AllowAutoRedirect(bool value) { }

	// RVA: 0xBA2220 Offset: 0xBA0820 VA: 0x180BA2220 Slot: 37
	public virtual bool get_AllowWriteStreamBuffering() { }

	// RVA: 0x1239140 Offset: 0x1237740 VA: 0x181239140 Slot: 38
	public virtual void set_AllowWriteStreamBuffering(bool value) { }

	// RVA: 0x88D510 Offset: 0x88BB10 VA: 0x18088D510
	public DecompressionMethods get_AutomaticDecompression() { }

	// RVA: 0x13407A0 Offset: 0x133EDA0 VA: 0x1813407A0
	public void set_AutomaticDecompression(DecompressionMethods value) { }

	// RVA: 0x1340500 Offset: 0x133EB00 VA: 0x181340500
	internal bool get_InternalAllowBuffering() { }

	// RVA: 0x1340510 Offset: 0x133EB10 VA: 0x181340510
	private bool get_MethodWithBuffer() { }

	// RVA: 0xA3CEA0 Offset: 0xA3B4A0 VA: 0x180A3CEA0
	internal MonoTlsProvider get_TlsProvider() { }

	// RVA: 0x900630 Offset: 0x8FEC30 VA: 0x180900630
	internal MonoTlsSettings get_TlsSettings() { }

	// RVA: 0x13403F0 Offset: 0x133E9F0 VA: 0x1813403F0
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x1340820 Offset: 0x133EE20 VA: 0x181340820
	public void set_Connection(string value) { }

	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810 Slot: 12
	public override void set_ConnectionGroupName(string value) { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0 Slot: 15
	public override long get_ContentLength() { }

	// RVA: 0x13409D0 Offset: 0x133EFD0 VA: 0x1813409D0 Slot: 16
	public override void set_ContentLength(long value) { }

	// RVA: 0x1341030 Offset: 0x133F630 VA: 0x181341030
	internal void set_InternalContentLength(long value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC835E0 Offset: 0xC81BE0 VA: 0x180C835E0
	internal bool get_ThrowOnError() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13415D0 Offset: 0x133FBD0 VA: 0x1813415D0
	internal void set_ThrowOnError(bool value) { }

	// RVA: 0x1340460 Offset: 0x133EA60 VA: 0x181340460 Slot: 17
	public override string get_ContentType() { }

	// RVA: 0x1340AA0 Offset: 0x133F0A0 VA: 0x181340AA0 Slot: 18
	public override void set_ContentType(string value) { }

	// RVA: 0x4E87D0 Offset: 0x4E6DD0 VA: 0x1804E87D0 Slot: 39
	public virtual void set_CookieContainer(CookieContainer value) { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370 Slot: 19
	public override ICredentials get_Credentials() { }

	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400 Slot: 20
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x1340B00 Offset: 0x133F100 VA: 0x181340B00
	public void set_Expect(string value) { }

	// RVA: 0x4E3FE0 Offset: 0x4E25E0 VA: 0x1804E3FE0 Slot: 13
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1340C70 Offset: 0x133F270 VA: 0x181340C70 Slot: 14
	public override void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x13404D0 Offset: 0x133EAD0 VA: 0x1813404D0
	public string get_Host() { }

	// RVA: 0x1340DF0 Offset: 0x133F3F0 VA: 0x181340DF0
	public void set_Host(string value) { }

	// RVA: 0x133C860 Offset: 0x133AE60 VA: 0x18133C860
	private static bool CheckValidHost(string scheme, string val) { }

	// RVA: 0x11878C0 Offset: 0x1185EC0 VA: 0x1811878C0
	public bool get_KeepAlive() { }

	// RVA: 0x1341040 Offset: 0x133F640 VA: 0x181341040
	public void set_KeepAlive(bool value) { }

	// RVA: 0x1341050 Offset: 0x133F650 VA: 0x181341050
	public void set_MaximumAutomaticRedirections(int value) { }

	// RVA: 0x13405F0 Offset: 0x133EBF0 VA: 0x1813405F0
	public int get_ReadWriteTimeout() { }

	// RVA: 0x79BDE0 Offset: 0x79A3E0 VA: 0x18079BDE0 Slot: 9
	public override string get_Method() { }

	// RVA: 0x13410D0 Offset: 0x133F6D0 VA: 0x1813410D0 Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x12E1290 Offset: 0x12DF890 VA: 0x1812E1290 Slot: 25
	public override void set_PreAuthenticate(bool value) { }

	// RVA: 0x79BE20 Offset: 0x79A420 VA: 0x18079BE20
	public Version get_ProtocolVersion() { }

	// RVA: 0x1341250 Offset: 0x133F850 VA: 0x181341250
	public void set_ProtocolVersion(Version value) { }

	// RVA: 0xDA01E0 Offset: 0xD9E7E0 VA: 0x180DA01E0 Slot: 23
	public override IWebProxy get_Proxy() { }

	// RVA: 0x13413A0 Offset: 0x133F9A0 VA: 0x1813413A0 Slot: 24
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x1341440 Offset: 0x133FA40 VA: 0x181341440
	public void set_Referer(string value) { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x10C8A00 Offset: 0x10C7000 VA: 0x1810C8A00
	public bool get_SendChunked() { }

	// RVA: 0x1341550 Offset: 0x133FB50 VA: 0x181341550
	public void set_SendChunked(bool value) { }

	// RVA: 0x1340610 Offset: 0x133EC10 VA: 0x181340610
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x88D970 Offset: 0x88BF70 VA: 0x18088D970
	internal ServicePoint get_ServicePointNoLock() { }

	// RVA: 0x107AB00 Offset: 0x1079100 VA: 0x18107AB00 Slot: 26
	public override int get_Timeout() { }

	// RVA: 0x1340620 Offset: 0x133EC20 VA: 0x181340620
	public string get_TransferEncoding() { }

	// RVA: 0x1340680 Offset: 0x133EC80 VA: 0x181340680 Slot: 21
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x13415E0 Offset: 0x133FBE0 VA: 0x1813415E0 Slot: 22
	public override void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x1341670 Offset: 0x133FC70 VA: 0x181341670
	public void set_UserAgent(string value) { }

	// RVA: 0x1340670 Offset: 0x133EC70 VA: 0x181340670
	public bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x13404B0 Offset: 0x133EAB0 VA: 0x1813404B0
	internal bool get_ExpectContinue() { }

	// RVA: 0x1340AF0 Offset: 0x133F0F0 VA: 0x181340AF0
	internal void set_ExpectContinue(bool value) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	internal Uri get_AuthUri() { }

	// RVA: 0x13405C0 Offset: 0x133EBC0 VA: 0x1813405C0
	internal bool get_ProxyQuery() { }

	// RVA: 0xC838F0 Offset: 0xC81EF0 VA: 0x180C838F0
	internal ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x133DEE0 Offset: 0x133C4E0 VA: 0x18133DEE0
	internal ServicePoint GetServicePoint() { }

	// RVA: 0x133B650 Offset: 0x1339C50 VA: 0x18133B650 Slot: 31
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x133CB50 Offset: 0x133B150 VA: 0x18133CB50 Slot: 32
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x133DCA0 Offset: 0x133C2A0 VA: 0x18133DCA0 Slot: 27
	public override Stream GetRequestStream() { }

	// RVA: 0x133C560 Offset: 0x133AB60 VA: 0x18133C560
	private bool CheckIfForceWrite(SimpleAsyncResult result) { }

	// RVA: 0x133BAD0 Offset: 0x133A0D0 VA: 0x18133BAD0 Slot: 29
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x133CC70 Offset: 0x133B270 VA: 0x18133CC70 Slot: 30
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x133DE30 Offset: 0x133C430 VA: 0x18133DE30 Slot: 28
	public override WebResponse GetResponse() { }

	// RVA: 0x13404C0 Offset: 0x133EAC0 VA: 0x1813404C0
	internal bool get_FinishedReading() { }

	// RVA: 0x1340C60 Offset: 0x133F260 VA: 0x181340C60
	internal void set_FinishedReading(bool value) { }

	// RVA: 0x13403C0 Offset: 0x133E9C0 VA: 0x1813403C0
	internal bool get_Aborted() { }

	// RVA: 0x133B3C0 Offset: 0x13399C0 VA: 0x18133B3C0 Slot: 35
	public override void Abort() { }

	// RVA: 0x1193130 Offset: 0x1191730 VA: 0x181193130 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x133D550 Offset: 0x133BB50 VA: 0x18133D550 Slot: 7
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x133C6B0 Offset: 0x133ACB0 VA: 0x18133C6B0
	private void CheckRequestStarted() { }

	// RVA: 0x133C9D0 Offset: 0x133AFD0 VA: 0x18133C9D0
	internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers) { }

	// RVA: 0x133E740 Offset: 0x133CD40 VA: 0x18133E740
	private void RewriteRedirectToGet() { }

	// RVA: 0x133E290 Offset: 0x133C890 VA: 0x18133E290
	private bool Redirect(WebAsyncResult result, HttpStatusCode code, WebResponse response) { }

	// RVA: 0x133CDF0 Offset: 0x133B3F0 VA: 0x18133CDF0
	private string GetHeaders() { }

	// RVA: 0x133C9F0 Offset: 0x133AFF0 VA: 0x18133C9F0
	private void DoPreAuthenticate() { }

	// RVA: 0x133F440 Offset: 0x133DA40 VA: 0x18133F440
	internal void SetWriteStreamError(WebExceptionStatus status, Exception exc) { }

	// RVA: 0x133D840 Offset: 0x133BE40 VA: 0x18133D840
	internal byte[] GetRequestHeaders() { }

	// RVA: 0x133F670 Offset: 0x133DC70 VA: 0x18133F670
	internal void SetWriteStream(WebConnectionStream stream) { }

	// RVA: 0x133F5F0 Offset: 0x133DBF0 VA: 0x18133F5F0
	private void SetWriteStreamInner(SimpleAsyncCallback callback) { }

	// RVA: 0x133F3A0 Offset: 0x133D9A0 VA: 0x18133F3A0
	private void SetWriteStreamError(Exception exc) { }

	// RVA: 0x133F040 Offset: 0x133D640 VA: 0x18133F040
	internal void SetResponseError(WebExceptionStatus status, Exception e, string where) { }

	// RVA: 0x133C720 Offset: 0x133AD20 VA: 0x18133C720
	private void CheckSendError(WebConnectionData data) { }

	// RVA: 0x133E020 Offset: 0x133C620 VA: 0x18133E020
	private bool HandleNtlmAuth(WebAsyncResult r) { }

	// RVA: 0x133E7B0 Offset: 0x133CDB0 VA: 0x18133E7B0
	internal void SetResponseData(WebConnectionData data) { }

	// RVA: 0x133BDD0 Offset: 0x133A3D0 VA: 0x18133BDD0
	private bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x133BE00 Offset: 0x133A400 VA: 0x18133BE00
	private bool CheckFinalStatus(WebAsyncResult result) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1340600 Offset: 0x133EC00 VA: 0x181340600
	internal bool get_ReuseConnection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1341540 Offset: 0x133FB40 VA: 0x181341540
	internal void set_ReuseConnection(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x133F870 Offset: 0x133DE70 VA: 0x18133F870
	private void <SetWriteStream>b__258_0(SimpleAsyncResult result) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x133F9F0 Offset: 0x133DFF0 VA: 0x18133F9F0
	private void <SetWriteStream>b__258_1(SimpleAsyncResult inner) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x133F770 Offset: 0x133DD70 VA: 0x18133F770
	private bool <SetWriteStreamInner>b__259_0(SimpleAsyncResult result) { }

	[EditorBrowsableAttribute] // RVA: 0xB87E0 Offset: 0xB7BE0 VA: 0x1800B87E0
	[ObsoleteAttribute] // RVA: 0xB87E0 Offset: 0xB7BE0 VA: 0x1800B87E0
	// RVA: 0x133FB70 Offset: 0x133E170 VA: 0x18133FB70
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

	// RVA: 0x1ADFF0 Offset: 0x1AD3F0 VA: 0x1801ADFF0
	public bool get_IsCompleted() { }

	// RVA: 0x1AE130 Offset: 0x1AD530 VA: 0x1801AE130
	public HttpWebRequest.NtlmAuthState get_NtlmAuthState() { }

	// RVA: 0x1E1970 Offset: 0x1E0D70 VA: 0x1801E1970
	public bool get_IsNtlmAuthenticated() { }

	// RVA: 0x1E1930 Offset: 0x1E0D30 VA: 0x1801E1930
	public void .ctor(HttpWebRequest request, bool isProxy) { }

	// RVA: 0x1E1860 Offset: 0x1E0C60 VA: 0x1801E1860
	public bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x1E1870 Offset: 0x1E0C70 VA: 0x1801E1870
	public void Reset() { }

	// RVA: 0x1E1880 Offset: 0x1E0C80 VA: 0x1801E1880 Slot: 3
	public override string ToString() { }

}

private sealed class HttpWebRequest.<>c__DisplayClass238_0 // TypeDefIndex: 3009
{	// Fields
	public WebAsyncResult aread; // 0x10
	public HttpWebRequest <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1348830 Offset: 0x1346E30 VA: 0x181348830
	internal void <BeginGetResponse>b__0(SimpleAsyncResult inner) { }

}

