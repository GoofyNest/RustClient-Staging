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

	// RVA: 0x1188420 Offset: 0x1186A20 VA: 0x181188420
	public void .ctor(IWebConnectionState wcs, ServicePoint sPoint) { }

	// RVA: 0x11838E0 Offset: 0x1181EE0 VA: 0x1811838E0
	private bool CanReuse() { }

	// RVA: 0x1183CE0 Offset: 0x11822E0 VA: 0x181183CE0
	private void Connect(HttpWebRequest request) { }

	// RVA: 0x11844F0 Offset: 0x1182AF0 VA: 0x1811844F0
	private bool CreateTunnel(HttpWebRequest request, Uri connectUri, Stream stream, out byte[] buffer) { }

	// RVA: 0x1187230 Offset: 0x1185830 VA: 0x181187230
	private WebHeaderCollection ReadHeaders(Stream stream, out byte[] retBuffer, out int status) { }

	// RVA: 0x1185A00 Offset: 0x1184000 VA: 0x181185A00
	private void FlushContents(Stream stream, int contentLength) { }

	// RVA: 0x11842D0 Offset: 0x11828D0 VA: 0x1811842D0
	private bool CreateStream(HttpWebRequest request) { }

	// RVA: 0x1186230 Offset: 0x1184830 VA: 0x181186230
	private void HandleError(WebExceptionStatus st, Exception e, string where) { }

	// RVA: 0x1186CB0 Offset: 0x11852B0 VA: 0x181186CB0
	private void ReadDone(IAsyncResult result) { }

	// RVA: 0x1185980 Offset: 0x1183F80 VA: 0x181185980
	private static bool ExpectContent(int statusCode, string method) { }

	// RVA: 0x1186820 Offset: 0x1184E20 VA: 0x181186820
	internal void InitRead() { }

	// RVA: 0x1185A80 Offset: 0x1184080 VA: 0x181185A80
	private static int GetResponse(WebConnectionData data, ServicePoint sPoint, byte[] buffer, int max) { }

	// RVA: 0x1186400 Offset: 0x1184A00 VA: 0x181186400
	private void InitConnection(HttpWebRequest request) { }

	// RVA: 0x1187F00 Offset: 0x1186500 VA: 0x181187F00
	internal EventHandler SendRequest(HttpWebRequest request) { }

	// RVA: 0x1187D90 Offset: 0x1186390 VA: 0x181187D90
	private void SendNext() { }

	// RVA: 0x1186930 Offset: 0x1184F30 VA: 0x181186930
	internal void NextRead() { }

	// RVA: 0x11877C0 Offset: 0x1185DC0 VA: 0x1811877C0
	private static bool ReadLine(byte[] buffer, ref int start, int max, ref string output) { }

	// RVA: 0x1183220 Offset: 0x1181820 VA: 0x181183220
	internal IAsyncResult BeginRead(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1184ED0 Offset: 0x11834D0 VA: 0x181184ED0
	internal int EndRead(HttpWebRequest request, IAsyncResult result) { }

	// RVA: 0x1185820 Offset: 0x1183E20 VA: 0x181185820
	private int EnsureRead(byte[] buffer, int offset, int size) { }

	// RVA: 0x1183C30 Offset: 0x1182230 VA: 0x181183C30
	private bool CompleteChunkedRead() { }

	// RVA: 0x1183540 Offset: 0x1181B40 VA: 0x181183540
	internal IAsyncResult BeginWrite(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1185550 Offset: 0x1183B50 VA: 0x181185550
	internal bool EndWrite(HttpWebRequest request, bool throwOnError, IAsyncResult result) { }

	// RVA: 0x11879C0 Offset: 0x1185FC0 VA: 0x1811879C0
	internal int Read(HttpWebRequest request, byte[] buffer, int offset, int size) { }

	// RVA: 0x11881B0 Offset: 0x11867B0 VA: 0x1811881B0
	internal bool Write(HttpWebRequest request, byte[] buffer, int offset, int size, ref string err_msg) { }

	// RVA: 0x1183910 Offset: 0x1181F10 VA: 0x181183910
	internal void Close(bool sendNext) { }

	// RVA: 0x1182DA0 Offset: 0x11813A0 VA: 0x181182DA0
	private void Abort(object sender, EventArgs args) { }

	// RVA: 0x1187D50 Offset: 0x1186350 VA: 0x181187D50
	internal void ResetNtlm() { }

	// RVA: 0x574470 Offset: 0x572A70 VA: 0x180574470
	internal void set_PriorityRequest(HttpWebRequest value) { }

	// RVA: 0x1188620 Offset: 0x1186C20 VA: 0x181188620
	internal bool get_NtlmAuthenticated() { }

	// RVA: 0x1188640 Offset: 0x1186C40 VA: 0x181188640
	internal void set_NtlmAuthenticated(bool value) { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	internal NetworkCredential get_NtlmCredential() { }

	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	internal void set_NtlmCredential(NetworkCredential value) { }

	// RVA: 0x1188630 Offset: 0x1186C30 VA: 0x181188630
	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x1188650 Offset: 0x1186C50 VA: 0x181188650
	internal void set_UnsafeAuthenticatedConnectionSharing(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1188100 Offset: 0x1186700 VA: 0x181188100
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

	// RVA: 0x11793F0 Offset: 0x11779F0 VA: 0x1811793F0
	public void Abort(object sender, EventArgs args) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

