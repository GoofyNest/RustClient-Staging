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

	// RVA: 0x118D000 Offset: 0x118B600 VA: 0x18118D000
	public void .ctor(IWebConnectionState wcs, ServicePoint sPoint) { }

	// RVA: 0x11884C0 Offset: 0x1186AC0 VA: 0x1811884C0
	private bool CanReuse() { }

	// RVA: 0x11888C0 Offset: 0x1186EC0 VA: 0x1811888C0
	private void Connect(HttpWebRequest request) { }

	// RVA: 0x11890D0 Offset: 0x11876D0 VA: 0x1811890D0
	private bool CreateTunnel(HttpWebRequest request, Uri connectUri, Stream stream, out byte[] buffer) { }

	// RVA: 0x118BE10 Offset: 0x118A410 VA: 0x18118BE10
	private WebHeaderCollection ReadHeaders(Stream stream, out byte[] retBuffer, out int status) { }

	// RVA: 0x118A5E0 Offset: 0x1188BE0 VA: 0x18118A5E0
	private void FlushContents(Stream stream, int contentLength) { }

	// RVA: 0x1188EB0 Offset: 0x11874B0 VA: 0x181188EB0
	private bool CreateStream(HttpWebRequest request) { }

	// RVA: 0x118AE10 Offset: 0x1189410 VA: 0x18118AE10
	private void HandleError(WebExceptionStatus st, Exception e, string where) { }

	// RVA: 0x118B890 Offset: 0x1189E90 VA: 0x18118B890
	private void ReadDone(IAsyncResult result) { }

	// RVA: 0x118A560 Offset: 0x1188B60 VA: 0x18118A560
	private static bool ExpectContent(int statusCode, string method) { }

	// RVA: 0x118B400 Offset: 0x1189A00 VA: 0x18118B400
	internal void InitRead() { }

	// RVA: 0x118A660 Offset: 0x1188C60 VA: 0x18118A660
	private static int GetResponse(WebConnectionData data, ServicePoint sPoint, byte[] buffer, int max) { }

	// RVA: 0x118AFE0 Offset: 0x11895E0 VA: 0x18118AFE0
	private void InitConnection(HttpWebRequest request) { }

	// RVA: 0x118CAE0 Offset: 0x118B0E0 VA: 0x18118CAE0
	internal EventHandler SendRequest(HttpWebRequest request) { }

	// RVA: 0x118C970 Offset: 0x118AF70 VA: 0x18118C970
	private void SendNext() { }

	// RVA: 0x118B510 Offset: 0x1189B10 VA: 0x18118B510
	internal void NextRead() { }

	// RVA: 0x118C3A0 Offset: 0x118A9A0 VA: 0x18118C3A0
	private static bool ReadLine(byte[] buffer, ref int start, int max, ref string output) { }

	// RVA: 0x1187E00 Offset: 0x1186400 VA: 0x181187E00
	internal IAsyncResult BeginRead(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1189AB0 Offset: 0x11880B0 VA: 0x181189AB0
	internal int EndRead(HttpWebRequest request, IAsyncResult result) { }

	// RVA: 0x118A400 Offset: 0x1188A00 VA: 0x18118A400
	private int EnsureRead(byte[] buffer, int offset, int size) { }

	// RVA: 0x1188810 Offset: 0x1186E10 VA: 0x181188810
	private bool CompleteChunkedRead() { }

	// RVA: 0x1188120 Offset: 0x1186720 VA: 0x181188120
	internal IAsyncResult BeginWrite(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x118A130 Offset: 0x1188730 VA: 0x18118A130
	internal bool EndWrite(HttpWebRequest request, bool throwOnError, IAsyncResult result) { }

	// RVA: 0x118C5A0 Offset: 0x118ABA0 VA: 0x18118C5A0
	internal int Read(HttpWebRequest request, byte[] buffer, int offset, int size) { }

	// RVA: 0x118CD90 Offset: 0x118B390 VA: 0x18118CD90
	internal bool Write(HttpWebRequest request, byte[] buffer, int offset, int size, ref string err_msg) { }

	// RVA: 0x11884F0 Offset: 0x1186AF0 VA: 0x1811884F0
	internal void Close(bool sendNext) { }

	// RVA: 0x1187980 Offset: 0x1185F80 VA: 0x181187980
	private void Abort(object sender, EventArgs args) { }

	// RVA: 0x118C930 Offset: 0x118AF30 VA: 0x18118C930
	internal void ResetNtlm() { }

	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	internal void set_PriorityRequest(HttpWebRequest value) { }

	// RVA: 0x118D200 Offset: 0x118B800 VA: 0x18118D200
	internal bool get_NtlmAuthenticated() { }

	// RVA: 0x118D220 Offset: 0x118B820 VA: 0x18118D220
	internal void set_NtlmAuthenticated(bool value) { }

	// RVA: 0x574300 Offset: 0x572900 VA: 0x180574300
	internal NetworkCredential get_NtlmCredential() { }

	// RVA: 0x574390 Offset: 0x572990 VA: 0x180574390
	internal void set_NtlmCredential(NetworkCredential value) { }

	// RVA: 0x118D210 Offset: 0x118B810 VA: 0x18118D210
	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x118D230 Offset: 0x118B830 VA: 0x18118D230
	internal void set_UnsafeAuthenticatedConnectionSharing(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x118CCE0 Offset: 0x118B2E0 VA: 0x18118CCE0
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

	// RVA: 0x117DFD0 Offset: 0x117C5D0 VA: 0x18117DFD0
	public void Abort(object sender, EventArgs args) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

