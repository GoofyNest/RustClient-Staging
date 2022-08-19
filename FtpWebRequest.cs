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
	[MonoTODOAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public override string ConnectionGroupName { set; }
	public override string ContentType { get; set; }
	public override long ContentLength { get; set; }
	public override ICredentials Credentials { get; set; }
	public bool EnableSsl { get; }
	[MonoTODOAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public override WebHeaderCollection Headers { get; set; }
	public override string Method { get; set; }
	public override bool PreAuthenticate { set; }
	public override IWebProxy Proxy { get; set; }
	public int ReadWriteTimeout { get; }
	public override Uri RequestUri { get; }
	public ServicePoint ServicePoint { get; }
	[MonoTODOAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public override bool UseDefaultCredentials { get; set; }
	public override int Timeout { get; }
	private string DataType { get; }
	private FtpWebRequest.RequestState State { get; set; }

	// Methods

	// RVA: 0x1337AA0 Offset: 0x13360A0 VA: 0x181337AA0
	internal void .ctor(Uri uri) { }

	// RVA: 0x13340B0 Offset: 0x13326B0 VA: 0x1813340B0
	private static Exception GetMustImplement() { }

	// RVA: 0x1337E80 Offset: 0x1336480 VA: 0x181337E80 Slot: 12
	public override void set_ConnectionGroupName(string value) { }

	// RVA: 0x1337C60 Offset: 0x1336260 VA: 0x181337C60 Slot: 17
	public override string get_ContentType() { }

	// RVA: 0x1337EE0 Offset: 0x13364E0 VA: 0x181337EE0 Slot: 18
	public override void set_ContentType(string value) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 15
	public override long get_ContentLength() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 16
	public override void set_ContentLength(long value) { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0 Slot: 19
	public override ICredentials get_Credentials() { }

	// RVA: 0x1337F30 Offset: 0x1336530 VA: 0x181337F30 Slot: 20
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0xC23B00 Offset: 0xC22100 VA: 0x180C23B00
	public bool get_EnableSsl() { }

	// RVA: 0x1337CF0 Offset: 0x13362F0 VA: 0x181337CF0 Slot: 13
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x13380A0 Offset: 0x13366A0 VA: 0x1813380A0 Slot: 14
	public override void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x9921A0 Offset: 0x9907A0 VA: 0x1809921A0 Slot: 9
	public override string get_Method() { }

	// RVA: 0x1338100 Offset: 0x1336700 VA: 0x181338100 Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x1338270 Offset: 0x1336870 VA: 0x181338270 Slot: 25
	public override void set_PreAuthenticate(bool value) { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050 Slot: 23
	public override IWebProxy get_Proxy() { }

	// RVA: 0x13382C0 Offset: 0x13368C0 VA: 0x1813382C0 Slot: 24
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0xB9B280 Offset: 0xB99880 VA: 0x180B9B280
	public int get_ReadWriteTimeout() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x1337D50 Offset: 0x1336350 VA: 0x181337D50
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x1337E20 Offset: 0x1336420 VA: 0x181337E20 Slot: 21
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x13384E0 Offset: 0x1336AE0 VA: 0x1813384E0 Slot: 22
	public override void set_UseDefaultCredentials(bool value) { }

	// RVA: 0xB9B270 Offset: 0xB99870 VA: 0x180B9B270 Slot: 26
	public override int get_Timeout() { }

	// RVA: 0x1337CB0 Offset: 0x13362B0 VA: 0x181337CB0
	private string get_DataType() { }

	// RVA: 0x1337D60 Offset: 0x1336360 VA: 0x181337D60
	private FtpWebRequest.RequestState get_State() { }

	// RVA: 0x1338350 Offset: 0x1336950 VA: 0x181338350
	private void set_State(FtpWebRequest.RequestState value) { }

	// RVA: 0x13322A0 Offset: 0x13308A0 VA: 0x1813322A0 Slot: 35
	public override void Abort() { }

	// RVA: 0x1332D30 Offset: 0x1331330 VA: 0x181332D30 Slot: 29
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1333AE0 Offset: 0x13320E0 VA: 0x181333AE0 Slot: 30
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1334950 Offset: 0x1332F50 VA: 0x181334950 Slot: 28
	public override WebResponse GetResponse() { }

	// RVA: 0x1332A60 Offset: 0x1331060 VA: 0x181332A60 Slot: 31
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x13338A0 Offset: 0x1331EA0 VA: 0x1813338A0 Slot: 32
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x1334710 Offset: 0x1332D10 VA: 0x181334710 Slot: 27
	public override Stream GetRequestStream() { }

	// RVA: 0x1334990 Offset: 0x1332F90 VA: 0x181334990
	private ServicePoint GetServicePoint() { }

	// RVA: 0x1336C30 Offset: 0x1335230 VA: 0x181336C30
	private void ResolveHost() { }

	// RVA: 0x1336300 Offset: 0x1334900 VA: 0x181336300
	private void ProcessRequest() { }

	// RVA: 0x13370E0 Offset: 0x13356E0 VA: 0x1813370E0
	private void SetType() { }

	// RVA: 0x1334560 Offset: 0x1332B60 VA: 0x181334560
	private string GetRemoteFolderPath(Uri uri) { }

	// RVA: 0x1332FB0 Offset: 0x13315B0 VA: 0x181332FB0
	private void CWDAndSetFileName(Uri uri) { }

	// RVA: 0x13359E0 Offset: 0x1333FE0 VA: 0x1813359E0
	private void ProcessMethod() { }

	// RVA: 0x13335B0 Offset: 0x1331BB0 VA: 0x1813335B0
	private void CloseControlConnection() { }

	// RVA: 0x1333650 Offset: 0x1331C50 VA: 0x181333650
	internal void CloseDataConnection() { }

	// RVA: 0x13334E0 Offset: 0x1331AE0 VA: 0x1813334E0
	private void CloseConnection() { }

	// RVA: 0x13365E0 Offset: 0x1334BE0 VA: 0x1813365E0
	private void ProcessSimpleMethod() { }

	// RVA: 0x1337400 Offset: 0x1335A00 VA: 0x181337400
	private void UploadData() { }

	// RVA: 0x1333790 Offset: 0x1331D90 VA: 0x181333790
	private void DownloadData() { }

	// RVA: 0x1333470 Offset: 0x1331A70 VA: 0x181333470
	private void CheckRequestStarted() { }

	// RVA: 0x1335140 Offset: 0x1333740 VA: 0x181335140
	private void OpenControlConnection() { }

	// RVA: 0x1333EF0 Offset: 0x13324F0 VA: 0x181333EF0
	private static string GetInitialPath(FtpStatus status) { }

	// RVA: 0x1337220 Offset: 0x1335820 VA: 0x181337220
	private Socket SetupPassiveConnection(string statusDescription, bool ipv6) { }

	// RVA: 0x1334100 Offset: 0x1332700 VA: 0x181334100
	private int GetPortV4(string responseString) { }

	// RVA: 0x1334340 Offset: 0x1332940 VA: 0x181334340
	private int GetPortV6(string responseString) { }

	// RVA: 0x1333DB0 Offset: 0x13323B0 VA: 0x181333DB0
	private string FormatAddress(IPAddress address, int Port) { }

	// RVA: 0x1333CB0 Offset: 0x13322B0 VA: 0x181333CB0
	private string FormatAddressV6(IPAddress address, int port) { }

	// RVA: 0x1333690 Offset: 0x1331C90 VA: 0x181333690
	private Exception CreateExceptionFromResponse(FtpStatus status) { }

	// RVA: 0x1337040 Offset: 0x1335640 VA: 0x181337040
	internal void SetTransferCompleted() { }

	// RVA: 0x13359C0 Offset: 0x1333FC0 VA: 0x1813359C0
	internal void OperationCompleted() { }

	// RVA: 0x1337010 Offset: 0x1335610 VA: 0x181337010
	private void SetCompleteWithError(Exception exc) { }

	// RVA: 0x1334AC0 Offset: 0x13330C0 VA: 0x181334AC0
	private Socket InitDataConnection() { }

	// RVA: 0x1335610 Offset: 0x1333C10 VA: 0x181335610
	private void OpenDataConnection() { }

	// RVA: 0x1332440 Offset: 0x1330A40 VA: 0x181332440
	private void Authenticate() { }

	// RVA: 0x1336F70 Offset: 0x1335570 VA: 0x181336F70
	private FtpStatus SendCommand(string command, string[] parameters) { }

	// RVA: 0x1336DD0 Offset: 0x13353D0 VA: 0x181336DD0
	private FtpStatus SendCommand(bool waitResponse, string command, string[] parameters) { }

	// RVA: 0x1336F90 Offset: 0x1335590 VA: 0x181336F90
	internal static FtpStatus ServiceNotAvailable() { }

	// RVA: 0x1334750 Offset: 0x1332D50 VA: 0x181334750
	internal FtpStatus GetResponseStatus() { }

	// RVA: 0x1335030 Offset: 0x1333630 VA: 0x181335030
	private void InitiateSecureConnection(ref Stream stream) { }

	// RVA: 0x1333170 Offset: 0x1331770 VA: 0x181333170
	internal bool ChangeToSSLSocket(ref Stream stream) { }

	// RVA: 0x1334A20 Offset: 0x1333020 VA: 0x181334A20
	private bool InFinalState() { }

	// RVA: 0x1334A70 Offset: 0x1333070 VA: 0x181334A70
	private bool InProgress() { }

	// RVA: 0x1333400 Offset: 0x1331A00 VA: 0x181333400
	internal void CheckIfAborted() { }

	// RVA: 0x1333370 Offset: 0x1331970 VA: 0x181333370
	private void CheckFinalState() { }

	// RVA: 0x1337520 Offset: 0x1335B20 VA: 0x181337520
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

