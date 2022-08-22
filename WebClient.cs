public class WebClient : Component // TypeDefIndex: 2953
{	// Fields
	private Uri m_baseAddress; // 0x28
	private ICredentials m_credentials; // 0x30
	private WebHeaderCollection m_headers; // 0x38
	private NameValueCollection m_requestParameters; // 0x40
	private WebResponse m_WebResponse; // 0x48
	private WebRequest m_WebRequest; // 0x50
	private Encoding m_Encoding; // 0x58
	private string m_Method; // 0x60
	private long m_ContentLength; // 0x68
	private bool m_InitWebClientAsync; // 0x70
	private bool m_Cancelled; // 0x71
	private WebClient.ProgressData m_Progress; // 0x78
	private IWebProxy m_Proxy; // 0x80
	private bool m_ProxySet; // 0x88
	private RequestCachePolicy m_CachePolicy; // 0x90
	private int m_CallNesting; // 0x98
	private AsyncOperation m_AsyncOp; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private OpenReadCompletedEventHandler OpenReadCompleted; // 0xA8
	private SendOrPostCallback openReadOperationCompleted; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private OpenWriteCompletedEventHandler OpenWriteCompleted; // 0xB8
	private SendOrPostCallback openWriteOperationCompleted; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private DownloadStringCompletedEventHandler DownloadStringCompleted; // 0xC8
	private SendOrPostCallback downloadStringOperationCompleted; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private DownloadDataCompletedEventHandler DownloadDataCompleted; // 0xD8
	private SendOrPostCallback downloadDataOperationCompleted; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AsyncCompletedEventHandler DownloadFileCompleted; // 0xE8
	private SendOrPostCallback downloadFileOperationCompleted; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private UploadStringCompletedEventHandler UploadStringCompleted; // 0xF8
	private SendOrPostCallback uploadStringOperationCompleted; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private UploadDataCompletedEventHandler UploadDataCompleted; // 0x108
	private SendOrPostCallback uploadDataOperationCompleted; // 0x110
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private UploadFileCompletedEventHandler UploadFileCompleted; // 0x118
	private SendOrPostCallback uploadFileOperationCompleted; // 0x120
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private UploadValuesCompletedEventHandler UploadValuesCompleted; // 0x128
	private SendOrPostCallback uploadValuesOperationCompleted; // 0x130
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private DownloadProgressChangedEventHandler DownloadProgressChanged; // 0x138
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private UploadProgressChangedEventHandler UploadProgressChanged; // 0x140
	private SendOrPostCallback reportDownloadProgressChanged; // 0x148
	private SendOrPostCallback reportUploadProgressChanged; // 0x150

	// Properties
	public Encoding Encoding { get; set; }
	public ICredentials Credentials { get; }

	// Methods

	// RVA: 0x1015160 Offset: 0x1013760 VA: 0x181015160
	public void .ctor() { }

	// RVA: 0x1012A00 Offset: 0x1011000 VA: 0x181012A00
	private void InitWebClientAsync() { }

	// RVA: 0x10100B0 Offset: 0x100E6B0 VA: 0x1810100B0
	private void ClearWebClientState() { }

	// RVA: 0x1010190 Offset: 0x100E790 VA: 0x181010190
	private void CompleteWebClientState() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public Encoding get_Encoding() { }

	// RVA: 0x10154E0 Offset: 0x1013AE0 VA: 0x1810154E0
	public void set_Encoding(Encoding value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public ICredentials get_Credentials() { }

	// RVA: 0x1012810 Offset: 0x1010E10 VA: 0x181012810 Slot: 12
	protected virtual WebRequest GetWebRequest(Uri address) { }

	// RVA: 0x10129B0 Offset: 0x1010FB0 VA: 0x1810129B0 Slot: 13
	protected virtual WebResponse GetWebResponse(WebRequest request) { }

	// RVA: 0x1012950 Offset: 0x1010F50 VA: 0x181012950 Slot: 14
	protected virtual WebResponse GetWebResponse(WebRequest request, IAsyncResult result) { }

	// RVA: 0x1011160 Offset: 0x100F760 VA: 0x181011160
	private byte[] DownloadDataInternal(Uri address, out WebRequest request) { }

	// RVA: 0x10148D0 Offset: 0x1012ED0 VA: 0x1810148D0
	private byte[] UploadValuesInternal(NameValueCollection data) { }

	// RVA: 0x1011B10 Offset: 0x1010110 VA: 0x181011B10
	public string DownloadString(string address) { }

	// RVA: 0x10119B0 Offset: 0x100FFB0 VA: 0x1810119B0
	public string DownloadString(Uri address) { }

	// RVA: 0x100FF40 Offset: 0x100E540 VA: 0x18100FF40
	private static void AbortRequest(WebRequest request) { }

	// RVA: 0x10101A0 Offset: 0x100E7A0 VA: 0x1810101A0
	private void CopyHeadersTo(WebRequest request) { }

	// RVA: 0x10120A0 Offset: 0x10106A0 VA: 0x1810120A0
	private Uri GetUri(string path) { }

	// RVA: 0x10124E0 Offset: 0x1010AE0 VA: 0x1810124E0
	private Uri GetUri(Uri address) { }

	// RVA: 0x1010CA0 Offset: 0x100F2A0 VA: 0x181010CA0
	private static void DownloadBitsResponseCallback(IAsyncResult result) { }

	// RVA: 0x1010BF0 Offset: 0x100F1F0 VA: 0x181010BF0
	private static void DownloadBitsReadCallback(IAsyncResult result) { }

	// RVA: 0x10108C0 Offset: 0x100EEC0 VA: 0x1810108C0
	private static void DownloadBitsReadCallbackState(WebClient.DownloadBitsState state, IAsyncResult result) { }

	// RVA: 0x1010FF0 Offset: 0x100F5F0 VA: 0x181010FF0
	private byte[] DownloadBits(WebRequest request, Stream writeStream, CompletionDelegate completionDelegate, AsyncOperation asyncOp) { }

	// RVA: 0x1013680 Offset: 0x1011C80 VA: 0x181013680
	private static void UploadBitsRequestCallback(IAsyncResult result) { }

	// RVA: 0x10139A0 Offset: 0x1011FA0 VA: 0x1810139A0
	private static void UploadBitsWriteCallback(IAsyncResult result) { }

	// RVA: 0x1013CE0 Offset: 0x10122E0 VA: 0x181013CE0
	private void UploadBits(WebRequest request, Stream readStream, byte[] buffer, int chunkSize, byte[] header, byte[] footer, CompletionDelegate uploadCompletionDelegate, CompletionDelegate downloadCompletionDelegate, AsyncOperation asyncOp) { }

	// RVA: 0x1010030 Offset: 0x100E630 VA: 0x181010030
	private bool ByteArrayHasPrefix(byte[] prefix, byte[] byteArray) { }

	// RVA: 0x1011BA0 Offset: 0x10101A0 VA: 0x181011BA0
	private string GetStringUsingEncoding(WebRequest request, byte[] data) { }

	// RVA: 0x1012DC0 Offset: 0x10113C0 VA: 0x181012DC0
	private string MapToDefaultMethod(Uri address) { }

	// RVA: 0x10150B0 Offset: 0x10136B0 VA: 0x1810150B0
	private static string UrlEncode(string str) { }

	// RVA: 0x1015010 Offset: 0x1013610 VA: 0x181015010
	private static string UrlEncode(string str, Encoding e) { }

	// RVA: 0x1014FB0 Offset: 0x10135B0 VA: 0x181014FB0
	private static byte[] UrlEncodeToBytes(string str, Encoding e) { }

	// RVA: 0x1014D00 Offset: 0x1013300 VA: 0x181014D00
	private static byte[] UrlEncodeBytesToBytesInternal(byte[] bytes, int offset, int count, bool alwaysCreateReturnValue) { }

	// RVA: 0x1012CC0 Offset: 0x10112C0 VA: 0x181012CC0
	private static char IntToHex(int n) { }

	// RVA: 0x1012D50 Offset: 0x1011350 VA: 0x181012D50
	private static bool IsSafe(char ch) { }

	// RVA: 0x1012CD0 Offset: 0x10112D0 VA: 0x181012CD0
	private void InvokeOperationCompleted(AsyncOperation asyncOp, SendOrPostCallback callback, AsyncCompletedEventArgs eventArgs) { }

	// RVA: 0x1010020 Offset: 0x100E620 VA: 0x181010020
	private bool AnotherCallInProgress(int callNesting) { }

	// RVA: 0xAEEB80 Offset: 0xAED180 VA: 0x180AEEB80 Slot: 15
	protected virtual void OnOpenReadCompleted(OpenReadCompletedEventArgs e) { }

	// RVA: 0x1013030 Offset: 0x1011630 VA: 0x181013030
	private void OpenReadOperationCompleted(object arg) { }

	// RVA: 0x1012F70 Offset: 0x1011570 VA: 0x181012F70 Slot: 16
	protected virtual void OnOpenWriteCompleted(OpenWriteCompletedEventArgs e) { }

	// RVA: 0x10130D0 Offset: 0x10116D0 VA: 0x1810130D0
	private void OpenWriteOperationCompleted(object arg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1015260 Offset: 0x1013860 VA: 0x181015260
	public void add_DownloadStringCompleted(DownloadStringCompletedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10153A0 Offset: 0x10139A0 VA: 0x1810153A0
	public void remove_DownloadStringCompleted(DownloadStringCompletedEventHandler value) { }

	// RVA: 0x1012F50 Offset: 0x1011550 VA: 0x181012F50 Slot: 17
	protected virtual void OnDownloadStringCompleted(DownloadStringCompletedEventArgs e) { }

	// RVA: 0x1011910 Offset: 0x100FF10 VA: 0x181011910
	private void DownloadStringOperationCompleted(object arg) { }

	// RVA: 0x1011470 Offset: 0x100FA70 VA: 0x181011470
	private void DownloadStringAsyncCallback(byte[] returnBytes, Exception exception, object state) { }

	// RVA: 0x1011640 Offset: 0x100FC40 VA: 0x181011640
	public void DownloadStringAsync(Uri address) { }

	// RVA: 0x1011650 Offset: 0x100FC50 VA: 0x181011650
	public void DownloadStringAsync(Uri address, object userToken) { }

	// RVA: 0x1012EF0 Offset: 0x10114F0 VA: 0x181012EF0 Slot: 18
	protected virtual void OnDownloadDataCompleted(DownloadDataCompletedEventArgs e) { }

	// RVA: 0x1011330 Offset: 0x100F930 VA: 0x181011330
	private void DownloadDataOperationCompleted(object arg) { }

	// RVA: 0x1012F10 Offset: 0x1011510 VA: 0x181012F10 Slot: 19
	protected virtual void OnDownloadFileCompleted(AsyncCompletedEventArgs e) { }

	// RVA: 0x10113D0 Offset: 0x100F9D0 VA: 0x1810113D0
	private void DownloadFileOperationCompleted(object arg) { }

	// RVA: 0x1012FF0 Offset: 0x10115F0 VA: 0x181012FF0 Slot: 20
	protected virtual void OnUploadStringCompleted(UploadStringCompletedEventArgs e) { }

	// RVA: 0x1014030 Offset: 0x1012630 VA: 0x181014030
	private void UploadStringOperationCompleted(object arg) { }

	// RVA: 0x1013490 Offset: 0x1011A90 VA: 0x181013490
	private void StartDownloadAsync(WebClient.UploadBitsState state) { }

	// RVA: 0x1012F90 Offset: 0x1011590 VA: 0x181012F90 Slot: 21
	protected virtual void OnUploadDataCompleted(UploadDataCompletedEventArgs e) { }

	// RVA: 0x1013EF0 Offset: 0x10124F0 VA: 0x181013EF0
	private void UploadDataOperationCompleted(object arg) { }

	// RVA: 0x1012FB0 Offset: 0x10115B0 VA: 0x181012FB0 Slot: 22
	protected virtual void OnUploadFileCompleted(UploadFileCompletedEventArgs e) { }

	// RVA: 0x1013F90 Offset: 0x1012590 VA: 0x181013F90
	private void UploadFileOperationCompleted(object arg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1015300 Offset: 0x1013900 VA: 0x181015300
	public void add_UploadValuesCompleted(UploadValuesCompletedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1015440 Offset: 0x1013A40 VA: 0x181015440
	public void remove_UploadValuesCompleted(UploadValuesCompletedEventHandler value) { }

	// RVA: 0x1013010 Offset: 0x1011610 VA: 0x181013010 Slot: 23
	protected virtual void OnUploadValuesCompleted(UploadValuesCompletedEventArgs e) { }

	// RVA: 0x1014C60 Offset: 0x1013260 VA: 0x181014C60
	private void UploadValuesOperationCompleted(object arg) { }

	// RVA: 0x10141F0 Offset: 0x10127F0 VA: 0x1810141F0
	private void UploadValuesAsyncWriteCallback(byte[] returnBytes, Exception exception, object state) { }

	// RVA: 0x10140D0 Offset: 0x10126D0 VA: 0x1810140D0
	private void UploadValuesAsyncReadCallback(byte[] returnBytes, Exception exception, object state) { }

	// RVA: 0x1014360 Offset: 0x1012960 VA: 0x181014360
	public void UploadValuesAsync(Uri address, string method, NameValueCollection data) { }

	// RVA: 0x1014380 Offset: 0x1012980 VA: 0x181014380
	public void UploadValuesAsync(Uri address, string method, NameValueCollection data, object userToken) { }

	// RVA: 0x1012F30 Offset: 0x1011530 VA: 0x181012F30 Slot: 24
	protected virtual void OnDownloadProgressChanged(DownloadProgressChangedEventArgs e) { }

	// RVA: 0x1012FD0 Offset: 0x10115D0 VA: 0x181012FD0 Slot: 25
	protected virtual void OnUploadProgressChanged(UploadProgressChangedEventArgs e) { }

	// RVA: 0x1013350 Offset: 0x1011950 VA: 0x181013350
	private void ReportDownloadProgressChanged(object arg) { }

	// RVA: 0x10133F0 Offset: 0x10119F0 VA: 0x1810133F0
	private void ReportUploadProgressChanged(object arg) { }

	// RVA: 0x1013170 Offset: 0x1011770 VA: 0x181013170
	private void PostProgressChanged(AsyncOperation asyncOp, WebClient.ProgressData progress) { }

}

private class WebClient.ProgressData // TypeDefIndex: 2954
{	// Fields
	internal long BytesSent; // 0x10
	internal long TotalBytesToSend; // 0x18
	internal long BytesReceived; // 0x20
	internal long TotalBytesToReceive; // 0x28
	internal bool HasUploadPhase; // 0x30

	// Methods

	// RVA: 0x117C980 Offset: 0x117AF80 VA: 0x18117C980
	internal void Reset() { }

	// RVA: 0x117C9A0 Offset: 0x117AFA0 VA: 0x18117C9A0
	public void .ctor() { }

}

private class WebClient.DownloadBitsState // TypeDefIndex: 2955
{	// Fields
	internal WebClient WebClient; // 0x10
	internal Stream WriteStream; // 0x18
	internal byte[] InnerBuffer; // 0x20
	internal AsyncOperation AsyncOp; // 0x28
	internal WebRequest Request; // 0x30
	internal CompletionDelegate CompletionDelegate; // 0x38
	internal Stream ReadStream; // 0x40
	internal ScatterGatherBuffers SgBuffers; // 0x48
	internal long ContentLength; // 0x50
	internal long Length; // 0x58
	internal WebClient.ProgressData Progress; // 0x60

	// Properties
	internal bool Async { get; }

	// Methods

	// RVA: 0x117BF10 Offset: 0x117A510 VA: 0x18117BF10
	internal void .ctor(WebRequest request, Stream writeStream, CompletionDelegate completionDelegate, AsyncOperation asyncOp, WebClient.ProgressData progress, WebClient webClient) { }

	// RVA: 0x117BFB0 Offset: 0x117A5B0 VA: 0x18117BFB0
	internal bool get_Async() { }

	// RVA: 0x117BC30 Offset: 0x117A230 VA: 0x18117BC30
	internal int SetResponse(WebResponse response) { }

	// RVA: 0x117B960 Offset: 0x1179F60 VA: 0x18117B960
	internal bool RetrieveBytes(ref int bytesRetrieved) { }

	// RVA: 0x117B910 Offset: 0x1179F10 VA: 0x18117B910
	internal void Close() { }

}

private class WebClient.UploadBitsState // TypeDefIndex: 2956
{	// Fields
	private int m_ChunkSize; // 0x10
	private int m_BufferWritePosition; // 0x14
	internal WebClient WebClient; // 0x18
	internal Stream WriteStream; // 0x20
	internal byte[] InnerBuffer; // 0x28
	internal byte[] Header; // 0x30
	internal byte[] Footer; // 0x38
	internal AsyncOperation AsyncOp; // 0x40
	internal WebRequest Request; // 0x48
	internal CompletionDelegate UploadCompletionDelegate; // 0x50
	internal CompletionDelegate DownloadCompletionDelegate; // 0x58
	internal Stream ReadStream; // 0x60
	internal WebClient.ProgressData Progress; // 0x68

	// Properties
	internal bool FileUpload { get; }
	internal bool Async { get; }

	// Methods

	// RVA: 0x117E840 Offset: 0x117CE40 VA: 0x18117E840
	internal void .ctor(WebRequest request, Stream readStream, byte[] buffer, int chunkSize, byte[] header, byte[] footer, CompletionDelegate uploadCompletionDelegate, CompletionDelegate downloadCompletionDelegate, AsyncOperation asyncOp, WebClient.ProgressData progress, WebClient webClient) { }

	// RVA: 0x117E9B0 Offset: 0x117CFB0 VA: 0x18117E9B0
	internal bool get_FileUpload() { }

	// RVA: 0x117E9A0 Offset: 0x117CFA0 VA: 0x18117E9A0
	internal bool get_Async() { }

	// RVA: 0x117E500 Offset: 0x117CB00 VA: 0x18117E500
	internal void SetRequestStream(Stream writeStream) { }

	// RVA: 0x117E640 Offset: 0x117CC40 VA: 0x18117E640
	internal bool WriteBytes() { }

	// RVA: 0x117E4B0 Offset: 0x117CAB0 VA: 0x18117E4B0
	internal void Close() { }

}

