public sealed class FtpWebRequest : WebRequest // TypeDefIndex: 3002
{	// Fields
	private Uri requestUri; // 0x38
	private string file_name; // 0x40
	private ServicePoint servicePoint; // 0x48
	private Stream origDataStream; // 0x50
	private Stream dataStream; // 0x58
	private Stream controlStream; // 0x60
	private StreamReader controlReader; // 0x68
	private NetworkCredential credentials; // 0x70
	private IPHostEntry hostEntry; // 0x78
	private IPEndPoint localEndPoint; // 0x80
	private IPEndPoint remoteEndPoint; // 0x88
	private IWebProxy proxy; // 0x90
	private int timeout; // 0x98
	private int rwTimeout; // 0x9C
	private long offset; // 0xA0
	private bool binary; // 0xA8
	private bool enableSsl; // 0xA9
	private bool usePassive; // 0xAA
	private bool keepAlive; // 0xAB
	private string method; // 0xB0
	private string renameTo; // 0xB8
	private object locker; // 0xC0
	private FtpWebRequest.RequestState requestState; // 0xC8
	private FtpAsyncResult asyncResult; // 0xD0
	private FtpWebResponse ftpResponse; // 0xD8
	private Stream requestStream; // 0xE0
	private string initial_path; // 0xE8
	private static readonly string[] supportedCommands; // 0x0
	private Encoding dataEncoding; // 0xF0

	// Properties
	[MonoTODOAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public override string ConnectionGroupName { set; }
	public override string ContentType { get; set; }
	public override long ContentLength { get; set; }
	public override ICredentials Credentials { get; set; }
	public bool EnableSsl { get; }
	[MonoTODOAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public override WebHeaderCollection Headers { get; set; }
	public override string Method { get; set; }
	public override bool PreAuthenticate { set; }
	public override IWebProxy Proxy { get; set; }
	public int ReadWriteTimeout { get; }
	public override Uri RequestUri { get; }
	public ServicePoint ServicePoint { get; }
	[MonoTODOAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public override bool UseDefaultCredentials { get; set; }
	public override int Timeout { get; }
	private string DataType { get; }
	private FtpWebRequest.RequestState State { get; set; }

	// Methods

	// RVA: 0x1336E60 Offset: 0x1335460 VA: 0x181336E60
	internal void .ctor(Uri uri) { }

	// RVA: 0x1333470 Offset: 0x1331A70 VA: 0x181333470
	private static Exception GetMustImplement() { }

	// RVA: 0x1337240 Offset: 0x1335840 VA: 0x181337240 Slot: 12
	public override void set_ConnectionGroupName(string value) { }

	// RVA: 0x1337020 Offset: 0x1335620 VA: 0x181337020 Slot: 17
	public override string get_ContentType() { }

	// RVA: 0x13372A0 Offset: 0x13358A0 VA: 0x1813372A0 Slot: 18
	public override void set_ContentType(string value) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 15
	public override long get_ContentLength() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 16
	public override void set_ContentLength(long value) { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360 Slot: 19
	public override ICredentials get_Credentials() { }

	// RVA: 0x13372F0 Offset: 0x13358F0 VA: 0x1813372F0 Slot: 20
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0xC24290 Offset: 0xC22890 VA: 0x180C24290
	public bool get_EnableSsl() { }

	// RVA: 0x13370B0 Offset: 0x13356B0 VA: 0x1813370B0 Slot: 13
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1337460 Offset: 0x1335A60 VA: 0x181337460 Slot: 14
	public override void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x79BDB0 Offset: 0x79A3B0 VA: 0x18079BDB0 Slot: 9
	public override string get_Method() { }

	// RVA: 0x13374C0 Offset: 0x1335AC0 VA: 0x1813374C0 Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x1337630 Offset: 0x1335C30 VA: 0x181337630 Slot: 25
	public override void set_PreAuthenticate(bool value) { }

	// RVA: 0x4E3FE0 Offset: 0x4E25E0 VA: 0x1804E3FE0 Slot: 23
	public override IWebProxy get_Proxy() { }

	// RVA: 0x1337680 Offset: 0x1335C80 VA: 0x181337680 Slot: 24
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0xB9BA10 Offset: 0xB9A010 VA: 0x180B9BA10
	public int get_ReadWriteTimeout() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x1337110 Offset: 0x1335710 VA: 0x181337110
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x13371E0 Offset: 0x13357E0 VA: 0x1813371E0 Slot: 21
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x13378A0 Offset: 0x1335EA0 VA: 0x1813378A0 Slot: 22
	public override void set_UseDefaultCredentials(bool value) { }

	// RVA: 0xB9BA00 Offset: 0xB9A000 VA: 0x180B9BA00 Slot: 26
	public override int get_Timeout() { }

	// RVA: 0x1337070 Offset: 0x1335670 VA: 0x181337070
	private string get_DataType() { }

	// RVA: 0x1337120 Offset: 0x1335720 VA: 0x181337120
	private FtpWebRequest.RequestState get_State() { }

	// RVA: 0x1337710 Offset: 0x1335D10 VA: 0x181337710
	private void set_State(FtpWebRequest.RequestState value) { }

	// RVA: 0x1331660 Offset: 0x132FC60 VA: 0x181331660 Slot: 35
	public override void Abort() { }

	// RVA: 0x13320F0 Offset: 0x13306F0 VA: 0x1813320F0 Slot: 29
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1332EA0 Offset: 0x13314A0 VA: 0x181332EA0 Slot: 30
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1333D10 Offset: 0x1332310 VA: 0x181333D10 Slot: 28
	public override WebResponse GetResponse() { }

	// RVA: 0x1331E20 Offset: 0x1330420 VA: 0x181331E20 Slot: 31
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x1332C60 Offset: 0x1331260 VA: 0x181332C60 Slot: 32
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x1333AD0 Offset: 0x13320D0 VA: 0x181333AD0 Slot: 27
	public override Stream GetRequestStream() { }

	// RVA: 0x1333D50 Offset: 0x1332350 VA: 0x181333D50
	private ServicePoint GetServicePoint() { }

	// RVA: 0x1335FF0 Offset: 0x13345F0 VA: 0x181335FF0
	private void ResolveHost() { }

	// RVA: 0x13356C0 Offset: 0x1333CC0 VA: 0x1813356C0
	private void ProcessRequest() { }

	// RVA: 0x13364A0 Offset: 0x1334AA0 VA: 0x1813364A0
	private void SetType() { }

	// RVA: 0x1333920 Offset: 0x1331F20 VA: 0x181333920
	private string GetRemoteFolderPath(Uri uri) { }

	// RVA: 0x1332370 Offset: 0x1330970 VA: 0x181332370
	private void CWDAndSetFileName(Uri uri) { }

	// RVA: 0x1334DA0 Offset: 0x13333A0 VA: 0x181334DA0
	private void ProcessMethod() { }

	// RVA: 0x1332970 Offset: 0x1330F70 VA: 0x181332970
	private void CloseControlConnection() { }

	// RVA: 0x1332A10 Offset: 0x1331010 VA: 0x181332A10
	internal void CloseDataConnection() { }

	// RVA: 0x13328A0 Offset: 0x1330EA0 VA: 0x1813328A0
	private void CloseConnection() { }

	// RVA: 0x13359A0 Offset: 0x1333FA0 VA: 0x1813359A0
	private void ProcessSimpleMethod() { }

	// RVA: 0x13367C0 Offset: 0x1334DC0 VA: 0x1813367C0
	private void UploadData() { }

	// RVA: 0x1332B50 Offset: 0x1331150 VA: 0x181332B50
	private void DownloadData() { }

	// RVA: 0x1332830 Offset: 0x1330E30 VA: 0x181332830
	private void CheckRequestStarted() { }

	// RVA: 0x1334500 Offset: 0x1332B00 VA: 0x181334500
	private void OpenControlConnection() { }

	// RVA: 0x13332B0 Offset: 0x13318B0 VA: 0x1813332B0
	private static string GetInitialPath(FtpStatus status) { }

	// RVA: 0x13365E0 Offset: 0x1334BE0 VA: 0x1813365E0
	private Socket SetupPassiveConnection(string statusDescription, bool ipv6) { }

	// RVA: 0x13334C0 Offset: 0x1331AC0 VA: 0x1813334C0
	private int GetPortV4(string responseString) { }

	// RVA: 0x1333700 Offset: 0x1331D00 VA: 0x181333700
	private int GetPortV6(string responseString) { }

	// RVA: 0x1333170 Offset: 0x1331770 VA: 0x181333170
	private string FormatAddress(IPAddress address, int Port) { }

	// RVA: 0x1333070 Offset: 0x1331670 VA: 0x181333070
	private string FormatAddressV6(IPAddress address, int port) { }

	// RVA: 0x1332A50 Offset: 0x1331050 VA: 0x181332A50
	private Exception CreateExceptionFromResponse(FtpStatus status) { }

	// RVA: 0x1336400 Offset: 0x1334A00 VA: 0x181336400
	internal void SetTransferCompleted() { }

	// RVA: 0x1334D80 Offset: 0x1333380 VA: 0x181334D80
	internal void OperationCompleted() { }

	// RVA: 0x13363D0 Offset: 0x13349D0 VA: 0x1813363D0
	private void SetCompleteWithError(Exception exc) { }

	// RVA: 0x1333E80 Offset: 0x1332480 VA: 0x181333E80
	private Socket InitDataConnection() { }

	// RVA: 0x13349D0 Offset: 0x1332FD0 VA: 0x1813349D0
	private void OpenDataConnection() { }

	// RVA: 0x1331800 Offset: 0x132FE00 VA: 0x181331800
	private void Authenticate() { }

	// RVA: 0x1336330 Offset: 0x1334930 VA: 0x181336330
	private FtpStatus SendCommand(string command, string[] parameters) { }

	// RVA: 0x1336190 Offset: 0x1334790 VA: 0x181336190
	private FtpStatus SendCommand(bool waitResponse, string command, string[] parameters) { }

	// RVA: 0x1336350 Offset: 0x1334950 VA: 0x181336350
	internal static FtpStatus ServiceNotAvailable() { }

	// RVA: 0x1333B10 Offset: 0x1332110 VA: 0x181333B10
	internal FtpStatus GetResponseStatus() { }

	// RVA: 0x13343F0 Offset: 0x13329F0 VA: 0x1813343F0
	private void InitiateSecureConnection(ref Stream stream) { }

	// RVA: 0x1332530 Offset: 0x1330B30 VA: 0x181332530
	internal bool ChangeToSSLSocket(ref Stream stream) { }

	// RVA: 0x1333DE0 Offset: 0x13323E0 VA: 0x181333DE0
	private bool InFinalState() { }

	// RVA: 0x1333E30 Offset: 0x1332430 VA: 0x181333E30
	private bool InProgress() { }

	// RVA: 0x13327C0 Offset: 0x1330DC0 VA: 0x1813327C0
	internal void CheckIfAborted() { }

	// RVA: 0x1332730 Offset: 0x1330D30 VA: 0x181332730
	private void CheckFinalState() { }

	// RVA: 0x13368E0 Offset: 0x1334EE0 VA: 0x1813368E0
	private static void .cctor() { }

}

private enum FtpWebRequest.RequestState // TypeDefIndex: 3003
{	// Fields
	public int value__; // 0x0
	public const FtpWebRequest.RequestState Before = 0;
	public const FtpWebRequest.RequestState Scheduled = 1;
	public const FtpWebRequest.RequestState Connecting = 2;
	public const FtpWebRequest.RequestState Authenticating = 3;
	public const FtpWebRequest.RequestState OpeningData = 4;
	public const FtpWebRequest.RequestState TransferInProgress = 5;
	public const FtpWebRequest.RequestState Finished = 6;
	public const FtpWebRequest.RequestState Aborted = 7;
	public const FtpWebRequest.RequestState Error = 8;

}

