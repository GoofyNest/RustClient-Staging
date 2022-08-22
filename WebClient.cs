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

	// RVA: 0x1015420 Offset: 0x1013A20 VA: 0x181015420
	public void .ctor() { }

	// RVA: 0x1012CC0 Offset: 0x10112C0 VA: 0x181012CC0
	private void InitWebClientAsync() { }

	// RVA: 0x1010370 Offset: 0x100E970 VA: 0x181010370
	private void ClearWebClientState() { }

	// RVA: 0x1010450 Offset: 0x100EA50 VA: 0x181010450
	private void CompleteWebClientState() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public Encoding get_Encoding() { }

	// RVA: 0x10157A0 Offset: 0x1013DA0 VA: 0x1810157A0
	public void set_Encoding(Encoding value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public ICredentials get_Credentials() { }

	// RVA: 0x1012AD0 Offset: 0x10110D0 VA: 0x181012AD0 Slot: 12
	protected virtual WebRequest GetWebRequest(Uri address) { }

	// RVA: 0x1012C70 Offset: 0x1011270 VA: 0x181012C70 Slot: 13
	protected virtual WebResponse GetWebResponse(WebRequest request) { }

	// RVA: 0x1012C10 Offset: 0x1011210 VA: 0x181012C10 Slot: 14
	protected virtual WebResponse GetWebResponse(WebRequest request, IAsyncResult result) { }

	// RVA: 0x1011420 Offset: 0x100FA20 VA: 0x181011420
	private byte[] DownloadDataInternal(Uri address, out WebRequest request) { }

	// RVA: 0x1014B90 Offset: 0x1013190 VA: 0x181014B90
	private byte[] UploadValuesInternal(NameValueCollection data) { }

	// RVA: 0x1011DD0 Offset: 0x10103D0 VA: 0x181011DD0
	public string DownloadString(string address) { }

	// RVA: 0x1011C70 Offset: 0x1010270 VA: 0x181011C70
	public string DownloadString(Uri address) { }

	// RVA: 0x1010200 Offset: 0x100E800 VA: 0x181010200
	private static void AbortRequest(WebRequest request) { }

	// RVA: 0x1010460 Offset: 0x100EA60 VA: 0x181010460
	private void CopyHeadersTo(WebRequest request) { }

	// RVA: 0x1012360 Offset: 0x1010960 VA: 0x181012360
	private Uri GetUri(string path) { }

	// RVA: 0x10127A0 Offset: 0x1010DA0 VA: 0x1810127A0
	private Uri GetUri(Uri address) { }

	// RVA: 0x1010F60 Offset: 0x100F560 VA: 0x181010F60
	private static void DownloadBitsResponseCallback(IAsyncResult result) { }

	// RVA: 0x1010EB0 Offset: 0x100F4B0 VA: 0x181010EB0
	private static void DownloadBitsReadCallback(IAsyncResult result) { }

	// RVA: 0x1010B80 Offset: 0x100F180 VA: 0x181010B80
	private static void DownloadBitsReadCallbackState(WebClient.DownloadBitsState state, IAsyncResult result) { }

	// RVA: 0x10112B0 Offset: 0x100F8B0 VA: 0x1810112B0
	private byte[] DownloadBits(WebRequest request, Stream writeStream, CompletionDelegate completionDelegate, AsyncOperation asyncOp) { }

	// RVA: 0x1013940 Offset: 0x1011F40 VA: 0x181013940
	private static void UploadBitsRequestCallback(IAsyncResult result) { }

	// RVA: 0x1013C60 Offset: 0x1012260 VA: 0x181013C60
	private static void UploadBitsWriteCallback(IAsyncResult result) { }

	// RVA: 0x1013FA0 Offset: 0x10125A0 VA: 0x181013FA0
	private void UploadBits(WebRequest request, Stream readStream, byte[] buffer, int chunkSize, byte[] header, byte[] footer, CompletionDelegate uploadCompletionDelegate, CompletionDelegate downloadCompletionDelegate, AsyncOperation asyncOp) { }

	// RVA: 0x10102F0 Offset: 0x100E8F0 VA: 0x1810102F0
	private bool ByteArrayHasPrefix(byte[] prefix, byte[] byteArray) { }

	// RVA: 0x1011E60 Offset: 0x1010460 VA: 0x181011E60
	private string GetStringUsingEncoding(WebRequest request, byte[] data) { }

	// RVA: 0x1013080 Offset: 0x1011680 VA: 0x181013080
	private string MapToDefaultMethod(Uri address) { }

	// RVA: 0x1015370 Offset: 0x1013970 VA: 0x181015370
	private static string UrlEncode(string str) { }

	// RVA: 0x10152D0 Offset: 0x10138D0 VA: 0x1810152D0
	private static string UrlEncode(string str, Encoding e) { }

	// RVA: 0x1015270 Offset: 0x1013870 VA: 0x181015270
	private static byte[] UrlEncodeToBytes(string str, Encoding e) { }

	// RVA: 0x1014FC0 Offset: 0x10135C0 VA: 0x181014FC0
	private static byte[] UrlEncodeBytesToBytesInternal(byte[] bytes, int offset, int count, bool alwaysCreateReturnValue) { }

	// RVA: 0x1012F80 Offset: 0x1011580 VA: 0x181012F80
	private static char IntToHex(int n) { }

	// RVA: 0x1013010 Offset: 0x1011610 VA: 0x181013010
	private static bool IsSafe(char ch) { }

	// RVA: 0x1012F90 Offset: 0x1011590 VA: 0x181012F90
	private void InvokeOperationCompleted(AsyncOperation asyncOp, SendOrPostCallback callback, AsyncCompletedEventArgs eventArgs) { }

	// RVA: 0x10102E0 Offset: 0x100E8E0 VA: 0x1810102E0
	private bool AnotherCallInProgress(int callNesting) { }

	// RVA: 0xAEEE40 Offset: 0xAED440 VA: 0x180AEEE40 Slot: 15
	protected virtual void OnOpenReadCompleted(OpenReadCompletedEventArgs e) { }

	// RVA: 0x10132F0 Offset: 0x10118F0 VA: 0x1810132F0
	private void OpenReadOperationCompleted(object arg) { }

	// RVA: 0x1013230 Offset: 0x1011830 VA: 0x181013230 Slot: 16
	protected virtual void OnOpenWriteCompleted(OpenWriteCompletedEventArgs e) { }

	// RVA: 0x1013390 Offset: 0x1011990 VA: 0x181013390
	private void OpenWriteOperationCompleted(object arg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1015520 Offset: 0x1013B20 VA: 0x181015520
	public void add_DownloadStringCompleted(DownloadStringCompletedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1015660 Offset: 0x1013C60 VA: 0x181015660
	public void remove_DownloadStringCompleted(DownloadStringCompletedEventHandler value) { }

	// RVA: 0x1013210 Offset: 0x1011810 VA: 0x181013210 Slot: 17
	protected virtual void OnDownloadStringCompleted(DownloadStringCompletedEventArgs e) { }

	// RVA: 0x1011BD0 Offset: 0x10101D0 VA: 0x181011BD0
	private void DownloadStringOperationCompleted(object arg) { }

	// RVA: 0x1011730 Offset: 0x100FD30 VA: 0x181011730
	private void DownloadStringAsyncCallback(byte[] returnBytes, Exception exception, object state) { }

	// RVA: 0x1011900 Offset: 0x100FF00 VA: 0x181011900
	public void DownloadStringAsync(Uri address) { }

	// RVA: 0x1011910 Offset: 0x100FF10 VA: 0x181011910
	public void DownloadStringAsync(Uri address, object userToken) { }

	// RVA: 0x10131B0 Offset: 0x10117B0 VA: 0x1810131B0 Slot: 18
	protected virtual void OnDownloadDataCompleted(DownloadDataCompletedEventArgs e) { }

	// RVA: 0x10115F0 Offset: 0x100FBF0 VA: 0x1810115F0
	private void DownloadDataOperationCompleted(object arg) { }

	// RVA: 0x10131D0 Offset: 0x10117D0 VA: 0x1810131D0 Slot: 19
	protected virtual void OnDownloadFileCompleted(AsyncCompletedEventArgs e) { }

	// RVA: 0x1011690 Offset: 0x100FC90 VA: 0x181011690
	private void DownloadFileOperationCompleted(object arg) { }

	// RVA: 0x10132B0 Offset: 0x10118B0 VA: 0x1810132B0 Slot: 20
	protected virtual void OnUploadStringCompleted(UploadStringCompletedEventArgs e) { }

	// RVA: 0x10142F0 Offset: 0x10128F0 VA: 0x1810142F0
	private void UploadStringOperationCompleted(object arg) { }

	// RVA: 0x1013750 Offset: 0x1011D50 VA: 0x181013750
	private void StartDownloadAsync(WebClient.UploadBitsState state) { }

	// RVA: 0x1013250 Offset: 0x1011850 VA: 0x181013250 Slot: 21
	protected virtual void OnUploadDataCompleted(UploadDataCompletedEventArgs e) { }

	// RVA: 0x10141B0 Offset: 0x10127B0 VA: 0x1810141B0
	private void UploadDataOperationCompleted(object arg) { }

	// RVA: 0x1013270 Offset: 0x1011870 VA: 0x181013270 Slot: 22
	protected virtual void OnUploadFileCompleted(UploadFileCompletedEventArgs e) { }

	// RVA: 0x1014250 Offset: 0x1012850 VA: 0x181014250
	private void UploadFileOperationCompleted(object arg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10155C0 Offset: 0x1013BC0 VA: 0x1810155C0
	public void add_UploadValuesCompleted(UploadValuesCompletedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1015700 Offset: 0x1013D00 VA: 0x181015700
	public void remove_UploadValuesCompleted(UploadValuesCompletedEventHandler value) { }

	// RVA: 0x10132D0 Offset: 0x10118D0 VA: 0x1810132D0 Slot: 23
	protected virtual void OnUploadValuesCompleted(UploadValuesCompletedEventArgs e) { }

	// RVA: 0x1014F20 Offset: 0x1013520 VA: 0x181014F20
	private void UploadValuesOperationCompleted(object arg) { }

	// RVA: 0x10144B0 Offset: 0x1012AB0 VA: 0x1810144B0
	private void UploadValuesAsyncWriteCallback(byte[] returnBytes, Exception exception, object state) { }

	// RVA: 0x1014390 Offset: 0x1012990 VA: 0x181014390
	private void UploadValuesAsyncReadCallback(byte[] returnBytes, Exception exception, object state) { }

	// RVA: 0x1014620 Offset: 0x1012C20 VA: 0x181014620
	public void UploadValuesAsync(Uri address, string method, NameValueCollection data) { }

	// RVA: 0x1014640 Offset: 0x1012C40 VA: 0x181014640
	public void UploadValuesAsync(Uri address, string method, NameValueCollection data, object userToken) { }

	// RVA: 0x10131F0 Offset: 0x10117F0 VA: 0x1810131F0 Slot: 24
	protected virtual void OnDownloadProgressChanged(DownloadProgressChangedEventArgs e) { }

	// RVA: 0x1013290 Offset: 0x1011890 VA: 0x181013290 Slot: 25
	protected virtual void OnUploadProgressChanged(UploadProgressChangedEventArgs e) { }

	// RVA: 0x1013610 Offset: 0x1011C10 VA: 0x181013610
	private void ReportDownloadProgressChanged(object arg) { }

	// RVA: 0x10136B0 Offset: 0x1011CB0 VA: 0x1810136B0
	private void ReportUploadProgressChanged(object arg) { }

	// RVA: 0x1013430 Offset: 0x1011A30 VA: 0x181013430
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

	// RVA: 0x117CC40 Offset: 0x117B240 VA: 0x18117CC40
	internal void Reset() { }

	// RVA: 0x117CC60 Offset: 0x117B260 VA: 0x18117CC60
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

	// RVA: 0x117C1D0 Offset: 0x117A7D0 VA: 0x18117C1D0
	internal void .ctor(WebRequest request, Stream writeStream, CompletionDelegate completionDelegate, AsyncOperation asyncOp, WebClient.ProgressData progress, WebClient webClient) { }

	// RVA: 0x117C270 Offset: 0x117A870 VA: 0x18117C270
	internal bool get_Async() { }

	// RVA: 0x117BEF0 Offset: 0x117A4F0 VA: 0x18117BEF0
	internal int SetResponse(WebResponse response) { }

	// RVA: 0x117BC20 Offset: 0x117A220 VA: 0x18117BC20
	internal bool RetrieveBytes(ref int bytesRetrieved) { }

	// RVA: 0x117BBD0 Offset: 0x117A1D0 VA: 0x18117BBD0
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

	// RVA: 0x117EB00 Offset: 0x117D100 VA: 0x18117EB00
	internal void .ctor(WebRequest request, Stream readStream, byte[] buffer, int chunkSize, byte[] header, byte[] footer, CompletionDelegate uploadCompletionDelegate, CompletionDelegate downloadCompletionDelegate, AsyncOperation asyncOp, WebClient.ProgressData progress, WebClient webClient) { }

	// RVA: 0x117EC70 Offset: 0x117D270 VA: 0x18117EC70
	internal bool get_FileUpload() { }

	// RVA: 0x117EC60 Offset: 0x117D260 VA: 0x18117EC60
	internal bool get_Async() { }

	// RVA: 0x117E7C0 Offset: 0x117CDC0 VA: 0x18117E7C0
	internal void SetRequestStream(Stream writeStream) { }

	// RVA: 0x117E900 Offset: 0x117CF00 VA: 0x18117E900
	internal bool WriteBytes() { }

	// RVA: 0x117E770 Offset: 0x117CD70 VA: 0x18117E770
	internal void Close() { }

}

