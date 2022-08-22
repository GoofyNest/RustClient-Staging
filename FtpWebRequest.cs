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

	// RVA: 0x1337D60 Offset: 0x1336360 VA: 0x181337D60
	internal void .ctor(Uri uri) { }

	// RVA: 0x1334370 Offset: 0x1332970 VA: 0x181334370
	private static Exception GetMustImplement() { }

	// RVA: 0x1338140 Offset: 0x1336740 VA: 0x181338140 Slot: 12
	public override void set_ConnectionGroupName(string value) { }

	// RVA: 0x1337F20 Offset: 0x1336520 VA: 0x181337F20 Slot: 17
	public override string get_ContentType() { }

	// RVA: 0x13381A0 Offset: 0x13367A0 VA: 0x1813381A0 Slot: 18
	public override void set_ContentType(string value) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 15
	public override long get_ContentLength() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 16
	public override void set_ContentLength(long value) { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0 Slot: 19
	public override ICredentials get_Credentials() { }

	// RVA: 0x13381F0 Offset: 0x13367F0 VA: 0x1813381F0 Slot: 20
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0xC23DC0 Offset: 0xC223C0 VA: 0x180C23DC0
	public bool get_EnableSsl() { }

	// RVA: 0x1337FB0 Offset: 0x13365B0 VA: 0x181337FB0 Slot: 13
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1338360 Offset: 0x1336960 VA: 0x181338360 Slot: 14
	public override void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x9922B0 Offset: 0x9908B0 VA: 0x1809922B0 Slot: 9
	public override string get_Method() { }

	// RVA: 0x13383C0 Offset: 0x13369C0 VA: 0x1813383C0 Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x1338530 Offset: 0x1336B30 VA: 0x181338530 Slot: 25
	public override void set_PreAuthenticate(bool value) { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050 Slot: 23
	public override IWebProxy get_Proxy() { }

	// RVA: 0x1338580 Offset: 0x1336B80 VA: 0x181338580 Slot: 24
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0xB9B540 Offset: 0xB99B40 VA: 0x180B9B540
	public int get_ReadWriteTimeout() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x1338010 Offset: 0x1336610 VA: 0x181338010
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x13380E0 Offset: 0x13366E0 VA: 0x1813380E0 Slot: 21
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x13387A0 Offset: 0x1336DA0 VA: 0x1813387A0 Slot: 22
	public override void set_UseDefaultCredentials(bool value) { }

	// RVA: 0xB9B530 Offset: 0xB99B30 VA: 0x180B9B530 Slot: 26
	public override int get_Timeout() { }

	// RVA: 0x1337F70 Offset: 0x1336570 VA: 0x181337F70
	private string get_DataType() { }

	// RVA: 0x1338020 Offset: 0x1336620 VA: 0x181338020
	private FtpWebRequest.RequestState get_State() { }

	// RVA: 0x1338610 Offset: 0x1336C10 VA: 0x181338610
	private void set_State(FtpWebRequest.RequestState value) { }

	// RVA: 0x1332560 Offset: 0x1330B60 VA: 0x181332560 Slot: 35
	public override void Abort() { }

	// RVA: 0x1332FF0 Offset: 0x13315F0 VA: 0x181332FF0 Slot: 29
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1333DA0 Offset: 0x13323A0 VA: 0x181333DA0 Slot: 30
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1334C10 Offset: 0x1333210 VA: 0x181334C10 Slot: 28
	public override WebResponse GetResponse() { }

	// RVA: 0x1332D20 Offset: 0x1331320 VA: 0x181332D20 Slot: 31
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x1333B60 Offset: 0x1332160 VA: 0x181333B60 Slot: 32
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x13349D0 Offset: 0x1332FD0 VA: 0x1813349D0 Slot: 27
	public override Stream GetRequestStream() { }

	// RVA: 0x1334C50 Offset: 0x1333250 VA: 0x181334C50
	private ServicePoint GetServicePoint() { }

	// RVA: 0x1336EF0 Offset: 0x13354F0 VA: 0x181336EF0
	private void ResolveHost() { }

	// RVA: 0x13365C0 Offset: 0x1334BC0 VA: 0x1813365C0
	private void ProcessRequest() { }

	// RVA: 0x13373A0 Offset: 0x13359A0 VA: 0x1813373A0
	private void SetType() { }

	// RVA: 0x1334820 Offset: 0x1332E20 VA: 0x181334820
	private string GetRemoteFolderPath(Uri uri) { }

	// RVA: 0x1333270 Offset: 0x1331870 VA: 0x181333270
	private void CWDAndSetFileName(Uri uri) { }

	// RVA: 0x1335CA0 Offset: 0x13342A0 VA: 0x181335CA0
	private void ProcessMethod() { }

	// RVA: 0x1333870 Offset: 0x1331E70 VA: 0x181333870
	private void CloseControlConnection() { }

	// RVA: 0x1333910 Offset: 0x1331F10 VA: 0x181333910
	internal void CloseDataConnection() { }

	// RVA: 0x13337A0 Offset: 0x1331DA0 VA: 0x1813337A0
	private void CloseConnection() { }

	// RVA: 0x13368A0 Offset: 0x1334EA0 VA: 0x1813368A0
	private void ProcessSimpleMethod() { }

	// RVA: 0x13376C0 Offset: 0x1335CC0 VA: 0x1813376C0
	private void UploadData() { }

	// RVA: 0x1333A50 Offset: 0x1332050 VA: 0x181333A50
	private void DownloadData() { }

	// RVA: 0x1333730 Offset: 0x1331D30 VA: 0x181333730
	private void CheckRequestStarted() { }

	// RVA: 0x1335400 Offset: 0x1333A00 VA: 0x181335400
	private void OpenControlConnection() { }

	// RVA: 0x13341B0 Offset: 0x13327B0 VA: 0x1813341B0
	private static string GetInitialPath(FtpStatus status) { }

	// RVA: 0x13374E0 Offset: 0x1335AE0 VA: 0x1813374E0
	private Socket SetupPassiveConnection(string statusDescription, bool ipv6) { }

	// RVA: 0x13343C0 Offset: 0x13329C0 VA: 0x1813343C0
	private int GetPortV4(string responseString) { }

	// RVA: 0x1334600 Offset: 0x1332C00 VA: 0x181334600
	private int GetPortV6(string responseString) { }

	// RVA: 0x1334070 Offset: 0x1332670 VA: 0x181334070
	private string FormatAddress(IPAddress address, int Port) { }

	// RVA: 0x1333F70 Offset: 0x1332570 VA: 0x181333F70
	private string FormatAddressV6(IPAddress address, int port) { }

	// RVA: 0x1333950 Offset: 0x1331F50 VA: 0x181333950
	private Exception CreateExceptionFromResponse(FtpStatus status) { }

	// RVA: 0x1337300 Offset: 0x1335900 VA: 0x181337300
	internal void SetTransferCompleted() { }

	// RVA: 0x1335C80 Offset: 0x1334280 VA: 0x181335C80
	internal void OperationCompleted() { }

	// RVA: 0x13372D0 Offset: 0x13358D0 VA: 0x1813372D0
	private void SetCompleteWithError(Exception exc) { }

	// RVA: 0x1334D80 Offset: 0x1333380 VA: 0x181334D80
	private Socket InitDataConnection() { }

	// RVA: 0x13358D0 Offset: 0x1333ED0 VA: 0x1813358D0
	private void OpenDataConnection() { }

	// RVA: 0x1332700 Offset: 0x1330D00 VA: 0x181332700
	private void Authenticate() { }

	// RVA: 0x1337230 Offset: 0x1335830 VA: 0x181337230
	private FtpStatus SendCommand(string command, string[] parameters) { }

	// RVA: 0x1337090 Offset: 0x1335690 VA: 0x181337090
	private FtpStatus SendCommand(bool waitResponse, string command, string[] parameters) { }

	// RVA: 0x1337250 Offset: 0x1335850 VA: 0x181337250
	internal static FtpStatus ServiceNotAvailable() { }

	// RVA: 0x1334A10 Offset: 0x1333010 VA: 0x181334A10
	internal FtpStatus GetResponseStatus() { }

	// RVA: 0x13352F0 Offset: 0x13338F0 VA: 0x1813352F0
	private void InitiateSecureConnection(ref Stream stream) { }

	// RVA: 0x1333430 Offset: 0x1331A30 VA: 0x181333430
	internal bool ChangeToSSLSocket(ref Stream stream) { }

	// RVA: 0x1334CE0 Offset: 0x13332E0 VA: 0x181334CE0
	private bool InFinalState() { }

	// RVA: 0x1334D30 Offset: 0x1333330 VA: 0x181334D30
	private bool InProgress() { }

	// RVA: 0x13336C0 Offset: 0x1331CC0 VA: 0x1813336C0
	internal void CheckIfAborted() { }

	// RVA: 0x1333630 Offset: 0x1331C30 VA: 0x181333630
	private void CheckFinalState() { }

	// RVA: 0x13377E0 Offset: 0x1335DE0 VA: 0x1813377E0
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

