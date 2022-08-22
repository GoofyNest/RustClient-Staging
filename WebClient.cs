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

	// RVA: 0x1015EC0 Offset: 0x10144C0 VA: 0x181015EC0
	public void .ctor() { }

	// RVA: 0x1013760 Offset: 0x1011D60 VA: 0x181013760
	private void InitWebClientAsync() { }

	// RVA: 0x1010E10 Offset: 0x100F410 VA: 0x181010E10
	private void ClearWebClientState() { }

	// RVA: 0x1010EF0 Offset: 0x100F4F0 VA: 0x181010EF0
	private void CompleteWebClientState() { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public Encoding get_Encoding() { }

	// RVA: 0x1016240 Offset: 0x1014840 VA: 0x181016240
	public void set_Encoding(Encoding value) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public ICredentials get_Credentials() { }

	// RVA: 0x1013570 Offset: 0x1011B70 VA: 0x181013570 Slot: 12
	protected virtual WebRequest GetWebRequest(Uri address) { }

	// RVA: 0x1013710 Offset: 0x1011D10 VA: 0x181013710 Slot: 13
	protected virtual WebResponse GetWebResponse(WebRequest request) { }

	// RVA: 0x10136B0 Offset: 0x1011CB0 VA: 0x1810136B0 Slot: 14
	protected virtual WebResponse GetWebResponse(WebRequest request, IAsyncResult result) { }

	// RVA: 0x1011EC0 Offset: 0x10104C0 VA: 0x181011EC0
	private byte[] DownloadDataInternal(Uri address, out WebRequest request) { }

	// RVA: 0x1015630 Offset: 0x1013C30 VA: 0x181015630
	private byte[] UploadValuesInternal(NameValueCollection data) { }

	// RVA: 0x1012870 Offset: 0x1010E70 VA: 0x181012870
	public string DownloadString(string address) { }

	// RVA: 0x1012710 Offset: 0x1010D10 VA: 0x181012710
	public string DownloadString(Uri address) { }

	// RVA: 0x1010CA0 Offset: 0x100F2A0 VA: 0x181010CA0
	private static void AbortRequest(WebRequest request) { }

	// RVA: 0x1010F00 Offset: 0x100F500 VA: 0x181010F00
	private void CopyHeadersTo(WebRequest request) { }

	// RVA: 0x1012E00 Offset: 0x1011400 VA: 0x181012E00
	private Uri GetUri(string path) { }

	// RVA: 0x1013240 Offset: 0x1011840 VA: 0x181013240
	private Uri GetUri(Uri address) { }

	// RVA: 0x1011A00 Offset: 0x1010000 VA: 0x181011A00
	private static void DownloadBitsResponseCallback(IAsyncResult result) { }

	// RVA: 0x1011950 Offset: 0x100FF50 VA: 0x181011950
	private static void DownloadBitsReadCallback(IAsyncResult result) { }

	// RVA: 0x1011620 Offset: 0x100FC20 VA: 0x181011620
	private static void DownloadBitsReadCallbackState(WebClient.DownloadBitsState state, IAsyncResult result) { }

	// RVA: 0x1011D50 Offset: 0x1010350 VA: 0x181011D50
	private byte[] DownloadBits(WebRequest request, Stream writeStream, CompletionDelegate completionDelegate, AsyncOperation asyncOp) { }

	// RVA: 0x10143E0 Offset: 0x10129E0 VA: 0x1810143E0
	private static void UploadBitsRequestCallback(IAsyncResult result) { }

	// RVA: 0x1014700 Offset: 0x1012D00 VA: 0x181014700
	private static void UploadBitsWriteCallback(IAsyncResult result) { }

	// RVA: 0x1014A40 Offset: 0x1013040 VA: 0x181014A40
	private void UploadBits(WebRequest request, Stream readStream, byte[] buffer, int chunkSize, byte[] header, byte[] footer, CompletionDelegate uploadCompletionDelegate, CompletionDelegate downloadCompletionDelegate, AsyncOperation asyncOp) { }

	// RVA: 0x1010D90 Offset: 0x100F390 VA: 0x181010D90
	private bool ByteArrayHasPrefix(byte[] prefix, byte[] byteArray) { }

	// RVA: 0x1012900 Offset: 0x1010F00 VA: 0x181012900
	private string GetStringUsingEncoding(WebRequest request, byte[] data) { }

	// RVA: 0x1013B20 Offset: 0x1012120 VA: 0x181013B20
	private string MapToDefaultMethod(Uri address) { }

	// RVA: 0x1015E10 Offset: 0x1014410 VA: 0x181015E10
	private static string UrlEncode(string str) { }

	// RVA: 0x1015D70 Offset: 0x1014370 VA: 0x181015D70
	private static string UrlEncode(string str, Encoding e) { }

	// RVA: 0x1015D10 Offset: 0x1014310 VA: 0x181015D10
	private static byte[] UrlEncodeToBytes(string str, Encoding e) { }

	// RVA: 0x1015A60 Offset: 0x1014060 VA: 0x181015A60
	private static byte[] UrlEncodeBytesToBytesInternal(byte[] bytes, int offset, int count, bool alwaysCreateReturnValue) { }

	// RVA: 0x1013A20 Offset: 0x1012020 VA: 0x181013A20
	private static char IntToHex(int n) { }

	// RVA: 0x1013AB0 Offset: 0x10120B0 VA: 0x181013AB0
	private static bool IsSafe(char ch) { }

	// RVA: 0x1013A30 Offset: 0x1012030 VA: 0x181013A30
	private void InvokeOperationCompleted(AsyncOperation asyncOp, SendOrPostCallback callback, AsyncCompletedEventArgs eventArgs) { }

	// RVA: 0x1010D80 Offset: 0x100F380 VA: 0x181010D80
	private bool AnotherCallInProgress(int callNesting) { }

	// RVA: 0xAEF310 Offset: 0xAED910 VA: 0x180AEF310 Slot: 15
	protected virtual void OnOpenReadCompleted(OpenReadCompletedEventArgs e) { }

	// RVA: 0x1013D90 Offset: 0x1012390 VA: 0x181013D90
	private void OpenReadOperationCompleted(object arg) { }

	// RVA: 0x1013CD0 Offset: 0x10122D0 VA: 0x181013CD0 Slot: 16
	protected virtual void OnOpenWriteCompleted(OpenWriteCompletedEventArgs e) { }

	// RVA: 0x1013E30 Offset: 0x1012430 VA: 0x181013E30
	private void OpenWriteOperationCompleted(object arg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1015FC0 Offset: 0x10145C0 VA: 0x181015FC0
	public void add_DownloadStringCompleted(DownloadStringCompletedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1016100 Offset: 0x1014700 VA: 0x181016100
	public void remove_DownloadStringCompleted(DownloadStringCompletedEventHandler value) { }

	// RVA: 0x1013CB0 Offset: 0x10122B0 VA: 0x181013CB0 Slot: 17
	protected virtual void OnDownloadStringCompleted(DownloadStringCompletedEventArgs e) { }

	// RVA: 0x1012670 Offset: 0x1010C70 VA: 0x181012670
	private void DownloadStringOperationCompleted(object arg) { }

	// RVA: 0x10121D0 Offset: 0x10107D0 VA: 0x1810121D0
	private void DownloadStringAsyncCallback(byte[] returnBytes, Exception exception, object state) { }

	// RVA: 0x10123A0 Offset: 0x10109A0 VA: 0x1810123A0
	public void DownloadStringAsync(Uri address) { }

	// RVA: 0x10123B0 Offset: 0x10109B0 VA: 0x1810123B0
	public void DownloadStringAsync(Uri address, object userToken) { }

	// RVA: 0x1013C50 Offset: 0x1012250 VA: 0x181013C50 Slot: 18
	protected virtual void OnDownloadDataCompleted(DownloadDataCompletedEventArgs e) { }

	// RVA: 0x1012090 Offset: 0x1010690 VA: 0x181012090
	private void DownloadDataOperationCompleted(object arg) { }

	// RVA: 0x1013C70 Offset: 0x1012270 VA: 0x181013C70 Slot: 19
	protected virtual void OnDownloadFileCompleted(AsyncCompletedEventArgs e) { }

	// RVA: 0x1012130 Offset: 0x1010730 VA: 0x181012130
	private void DownloadFileOperationCompleted(object arg) { }

	// RVA: 0x1013D50 Offset: 0x1012350 VA: 0x181013D50 Slot: 20
	protected virtual void OnUploadStringCompleted(UploadStringCompletedEventArgs e) { }

	// RVA: 0x1014D90 Offset: 0x1013390 VA: 0x181014D90
	private void UploadStringOperationCompleted(object arg) { }

	// RVA: 0x10141F0 Offset: 0x10127F0 VA: 0x1810141F0
	private void StartDownloadAsync(WebClient.UploadBitsState state) { }

	// RVA: 0x1013CF0 Offset: 0x10122F0 VA: 0x181013CF0 Slot: 21
	protected virtual void OnUploadDataCompleted(UploadDataCompletedEventArgs e) { }

	// RVA: 0x1014C50 Offset: 0x1013250 VA: 0x181014C50
	private void UploadDataOperationCompleted(object arg) { }

	// RVA: 0x1013D10 Offset: 0x1012310 VA: 0x181013D10 Slot: 22
	protected virtual void OnUploadFileCompleted(UploadFileCompletedEventArgs e) { }

	// RVA: 0x1014CF0 Offset: 0x10132F0 VA: 0x181014CF0
	private void UploadFileOperationCompleted(object arg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1016060 Offset: 0x1014660 VA: 0x181016060
	public void add_UploadValuesCompleted(UploadValuesCompletedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10161A0 Offset: 0x10147A0 VA: 0x1810161A0
	public void remove_UploadValuesCompleted(UploadValuesCompletedEventHandler value) { }

	// RVA: 0x1013D70 Offset: 0x1012370 VA: 0x181013D70 Slot: 23
	protected virtual void OnUploadValuesCompleted(UploadValuesCompletedEventArgs e) { }

	// RVA: 0x10159C0 Offset: 0x1013FC0 VA: 0x1810159C0
	private void UploadValuesOperationCompleted(object arg) { }

	// RVA: 0x1014F50 Offset: 0x1013550 VA: 0x181014F50
	private void UploadValuesAsyncWriteCallback(byte[] returnBytes, Exception exception, object state) { }

	// RVA: 0x1014E30 Offset: 0x1013430 VA: 0x181014E30
	private void UploadValuesAsyncReadCallback(byte[] returnBytes, Exception exception, object state) { }

	// RVA: 0x10150C0 Offset: 0x10136C0 VA: 0x1810150C0
	public void UploadValuesAsync(Uri address, string method, NameValueCollection data) { }

	// RVA: 0x10150E0 Offset: 0x10136E0 VA: 0x1810150E0
	public void UploadValuesAsync(Uri address, string method, NameValueCollection data, object userToken) { }

	// RVA: 0x1013C90 Offset: 0x1012290 VA: 0x181013C90 Slot: 24
	protected virtual void OnDownloadProgressChanged(DownloadProgressChangedEventArgs e) { }

	// RVA: 0x1013D30 Offset: 0x1012330 VA: 0x181013D30 Slot: 25
	protected virtual void OnUploadProgressChanged(UploadProgressChangedEventArgs e) { }

	// RVA: 0x10140B0 Offset: 0x10126B0 VA: 0x1810140B0
	private void ReportDownloadProgressChanged(object arg) { }

	// RVA: 0x1014150 Offset: 0x1012750 VA: 0x181014150
	private void ReportUploadProgressChanged(object arg) { }

	// RVA: 0x1013ED0 Offset: 0x10124D0 VA: 0x181013ED0
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

	// RVA: 0x1181560 Offset: 0x117FB60 VA: 0x181181560
	internal void Reset() { }

	// RVA: 0x1181580 Offset: 0x117FB80 VA: 0x181181580
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

	// RVA: 0x1180AF0 Offset: 0x117F0F0 VA: 0x181180AF0
	internal void .ctor(WebRequest request, Stream writeStream, CompletionDelegate completionDelegate, AsyncOperation asyncOp, WebClient.ProgressData progress, WebClient webClient) { }

	// RVA: 0x1180B90 Offset: 0x117F190 VA: 0x181180B90
	internal bool get_Async() { }

	// RVA: 0x1180810 Offset: 0x117EE10 VA: 0x181180810
	internal int SetResponse(WebResponse response) { }

	// RVA: 0x1180540 Offset: 0x117EB40 VA: 0x181180540
	internal bool RetrieveBytes(ref int bytesRetrieved) { }

	// RVA: 0x11804F0 Offset: 0x117EAF0 VA: 0x1811804F0
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

	// RVA: 0x1183420 Offset: 0x1181A20 VA: 0x181183420
	internal void .ctor(WebRequest request, Stream readStream, byte[] buffer, int chunkSize, byte[] header, byte[] footer, CompletionDelegate uploadCompletionDelegate, CompletionDelegate downloadCompletionDelegate, AsyncOperation asyncOp, WebClient.ProgressData progress, WebClient webClient) { }

	// RVA: 0x1183590 Offset: 0x1181B90 VA: 0x181183590
	internal bool get_FileUpload() { }

	// RVA: 0x1183580 Offset: 0x1181B80 VA: 0x181183580
	internal bool get_Async() { }

	// RVA: 0x11830E0 Offset: 0x11816E0 VA: 0x1811830E0
	internal void SetRequestStream(Stream writeStream) { }

	// RVA: 0x1183220 Offset: 0x1181820 VA: 0x181183220
	internal bool WriteBytes() { }

	// RVA: 0x1183090 Offset: 0x1181690 VA: 0x181183090
	internal void Close() { }

}

