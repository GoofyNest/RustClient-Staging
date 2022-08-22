internal class WebConnection // TypeDefIndex: 3027
{	// Fields
	private ServicePoint sPoint; // 0x10
	private Stream nstream; // 0x18
	internal Socket socket; // 0x20
	private object socketLock; // 0x28
	private IWebConnectionState state; // 0x30
	private WebExceptionStatus status; // 0x38
	private bool keepAlive; // 0x3C
	private byte[] buffer; // 0x40
	private EventHandler abortHandler; // 0x48
	private WebConnection.AbortHelper abortHelper; // 0x50
	internal WebConnectionData Data; // 0x58
	private bool chunkedRead; // 0x60
	private MonoChunkStream chunkStream; // 0x68
	private Queue queue; // 0x70
	private bool reused; // 0x78
	private int position; // 0x7C
	private HttpWebRequest priority_request; // 0x80
	private NetworkCredential ntlm_credentials; // 0x88
	private bool ntlm_authenticated; // 0x90
	private bool unsafe_sharing; // 0x91
	private WebConnection.NtlmAuthState connect_ntlm_auth_state; // 0x94
	private HttpWebRequest connect_request; // 0x98
	private Exception connect_exception; // 0xA0
	private MonoTlsStream tlsStream; // 0xA8

	// Properties
	internal HttpWebRequest PriorityRequest { set; }
	internal bool NtlmAuthenticated { get; set; }
	internal NetworkCredential NtlmCredential { get; set; }
	internal bool UnsafeAuthenticatedConnectionSharing { get; set; }

	// Methods

	// RVA: 0x11886E0 Offset: 0x1186CE0 VA: 0x1811886E0
	public void .ctor(IWebConnectionState wcs, ServicePoint sPoint) { }

	// RVA: 0x1183BA0 Offset: 0x11821A0 VA: 0x181183BA0
	private bool CanReuse() { }

	// RVA: 0x1183FA0 Offset: 0x11825A0 VA: 0x181183FA0
	private void Connect(HttpWebRequest request) { }

	// RVA: 0x11847B0 Offset: 0x1182DB0 VA: 0x1811847B0
	private bool CreateTunnel(HttpWebRequest request, Uri connectUri, Stream stream, out byte[] buffer) { }

	// RVA: 0x11874F0 Offset: 0x1185AF0 VA: 0x1811874F0
	private WebHeaderCollection ReadHeaders(Stream stream, out byte[] retBuffer, out int status) { }

	// RVA: 0x1185CC0 Offset: 0x11842C0 VA: 0x181185CC0
	private void FlushContents(Stream stream, int contentLength) { }

	// RVA: 0x1184590 Offset: 0x1182B90 VA: 0x181184590
	private bool CreateStream(HttpWebRequest request) { }

	// RVA: 0x11864F0 Offset: 0x1184AF0 VA: 0x1811864F0
	private void HandleError(WebExceptionStatus st, Exception e, string where) { }

	// RVA: 0x1186F70 Offset: 0x1185570 VA: 0x181186F70
	private void ReadDone(IAsyncResult result) { }

	// RVA: 0x1185C40 Offset: 0x1184240 VA: 0x181185C40
	private static bool ExpectContent(int statusCode, string method) { }

	// RVA: 0x1186AE0 Offset: 0x11850E0 VA: 0x181186AE0
	internal void InitRead() { }

	// RVA: 0x1185D40 Offset: 0x1184340 VA: 0x181185D40
	private static int GetResponse(WebConnectionData data, ServicePoint sPoint, byte[] buffer, int max) { }

	// RVA: 0x11866C0 Offset: 0x1184CC0 VA: 0x1811866C0
	private void InitConnection(HttpWebRequest request) { }

	// RVA: 0x11881C0 Offset: 0x11867C0 VA: 0x1811881C0
	internal EventHandler SendRequest(HttpWebRequest request) { }

	// RVA: 0x1188050 Offset: 0x1186650 VA: 0x181188050
	private void SendNext() { }

	// RVA: 0x1186BF0 Offset: 0x11851F0 VA: 0x181186BF0
	internal void NextRead() { }

	// RVA: 0x1187A80 Offset: 0x1186080 VA: 0x181187A80
	private static bool ReadLine(byte[] buffer, ref int start, int max, ref string output) { }

	// RVA: 0x11834E0 Offset: 0x1181AE0 VA: 0x1811834E0
	internal IAsyncResult BeginRead(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1185190 Offset: 0x1183790 VA: 0x181185190
	internal int EndRead(HttpWebRequest request, IAsyncResult result) { }

	// RVA: 0x1185AE0 Offset: 0x11840E0 VA: 0x181185AE0
	private int EnsureRead(byte[] buffer, int offset, int size) { }

	// RVA: 0x1183EF0 Offset: 0x11824F0 VA: 0x181183EF0
	private bool CompleteChunkedRead() { }

	// RVA: 0x1183800 Offset: 0x1181E00 VA: 0x181183800
	internal IAsyncResult BeginWrite(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1185810 Offset: 0x1183E10 VA: 0x181185810
	internal bool EndWrite(HttpWebRequest request, bool throwOnError, IAsyncResult result) { }

	// RVA: 0x1187C80 Offset: 0x1186280 VA: 0x181187C80
	internal int Read(HttpWebRequest request, byte[] buffer, int offset, int size) { }

	// RVA: 0x1188470 Offset: 0x1186A70 VA: 0x181188470
	internal bool Write(HttpWebRequest request, byte[] buffer, int offset, int size, ref string err_msg) { }

	// RVA: 0x1183BD0 Offset: 0x11821D0 VA: 0x181183BD0
	internal void Close(bool sendNext) { }

	// RVA: 0x1183060 Offset: 0x1181660 VA: 0x181183060
	private void Abort(object sender, EventArgs args) { }

	// RVA: 0x1188010 Offset: 0x1186610 VA: 0x181188010
	internal void ResetNtlm() { }

	// RVA: 0x574470 Offset: 0x572A70 VA: 0x180574470
	internal void set_PriorityRequest(HttpWebRequest value) { }

	// RVA: 0x11888E0 Offset: 0x1186EE0 VA: 0x1811888E0
	internal bool get_NtlmAuthenticated() { }

	// RVA: 0x1188900 Offset: 0x1186F00 VA: 0x181188900
	internal void set_NtlmAuthenticated(bool value) { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	internal NetworkCredential get_NtlmCredential() { }

	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	internal void set_NtlmCredential(NetworkCredential value) { }

	// RVA: 0x11888F0 Offset: 0x1186EF0 VA: 0x1811888F0
	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x1188910 Offset: 0x1186F10 VA: 0x181188910
	internal void set_UnsafeAuthenticatedConnectionSharing(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11883C0 Offset: 0x11869C0 VA: 0x1811883C0
	private void <SendRequest>b__41_0(object o) { }

}

private enum WebConnection.NtlmAuthState // TypeDefIndex: 3028
{	// Fields
	public int value__; // 0x0
	public const WebConnection.NtlmAuthState None = 0;
	public const WebConnection.NtlmAuthState Challenge = 1;
	public const WebConnection.NtlmAuthState Response = 2;

}

private class WebConnection.AbortHelper // TypeDefIndex: 3029
{	// Fields
	public WebConnection Connection; // 0x10

	// Methods

	// RVA: 0x11796B0 Offset: 0x1177CB0 VA: 0x1811796B0
	public void Abort(object sender, EventArgs args) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

