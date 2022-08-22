internal class WebConnectionStream : Stream // TypeDefIndex: 3033
{	// Fields
	private static byte[] crlf; // 0x0
	private bool isRead; // 0x28
	private WebConnection cnc; // 0x30
	private HttpWebRequest request; // 0x38
	private byte[] readBuffer; // 0x40
	private int readBufferOffset; // 0x48
	private int readBufferSize; // 0x4C
	private int stream_length; // 0x50
	private long contentLength; // 0x58
	private long totalRead; // 0x60
	internal long totalWritten; // 0x68
	private bool nextReadCalled; // 0x70
	private int pendingReads; // 0x74
	private int pendingWrites; // 0x78
	private ManualResetEvent pending; // 0x80
	private bool allowBuffering; // 0x88
	private bool sendChunked; // 0x89
	private MemoryStream writeBuffer; // 0x90
	private bool requestWritten; // 0x98
	private byte[] headers; // 0xA0
	private bool disposed; // 0xA8
	private bool headersSent; // 0xA9
	private object locker; // 0xB0
	private bool initRead; // 0xB8
	private bool read_eof; // 0xB9
	private bool complete_request_written; // 0xBA
	private int read_timeout; // 0xBC
	private int write_timeout; // 0xC0
	private AsyncCallback cb_wrapper; // 0xC8
	internal bool IgnoreIOErrors; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <GetResponseOnClose>k__BackingField; // 0xD1

	// Properties
	internal WebConnection Connection { get; }
	public override int ReadTimeout { get; }
	public override int WriteTimeout { get; }
	internal bool CompleteRequestWritten { get; }
	internal bool SendChunked { set; }
	internal byte[] ReadBuffer { set; }
	internal int ReadBufferOffset { set; }
	internal int ReadBufferSize { set; }
	internal byte[] WriteBuffer { get; }
	internal int WriteBufferLength { get; }
	internal bool RequestWritten { get; }
	internal bool GetResponseOnClose { get; }
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1182B90 Offset: 0x1181190 VA: 0x181182B90
	public void .ctor(WebConnection cnc, WebConnectionData data) { }

	// RVA: 0x1182A00 Offset: 0x1181000 VA: 0x181182A00
	public void .ctor(WebConnection cnc, HttpWebRequest request) { }

	// RVA: 0x11809F0 Offset: 0x117EFF0 VA: 0x1811809F0
	private bool CheckAuthHeader(string headerName) { }

	// RVA: 0x11815A0 Offset: 0x117FBA0 VA: 0x1811815A0
	private bool IsNtlmAuth() { }

	// RVA: 0x1180AC0 Offset: 0x117F0C0 VA: 0x181180AC0
	internal void CheckResponseInBuffer() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	internal WebConnection get_Connection() { }

	// RVA: 0x107A110 Offset: 0x1078710 VA: 0x18107A110 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0x107A100 Offset: 0x1078700 VA: 0x18107A100 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0x1182ED0 Offset: 0x11814D0 VA: 0x181182ED0
	internal bool get_CompleteRequestWritten() { }

	// RVA: 0xEC1B30 Offset: 0xEC0130 VA: 0x180EC1B30
	internal void set_SendChunked(bool value) { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	internal void set_ReadBuffer(byte[] value) { }

	// RVA: 0x598430 Offset: 0x596A30 VA: 0x180598430
	internal void set_ReadBufferOffset(int value) { }

	// RVA: 0x59A0F0 Offset: 0x5986F0 VA: 0x18059A0F0
	internal void set_ReadBufferSize(int value) { }

	// RVA: 0x1182FE0 Offset: 0x11815E0 VA: 0x181182FE0
	internal byte[] get_WriteBuffer() { }

	// RVA: 0x1182FB0 Offset: 0x11815B0 VA: 0x181182FB0
	internal int get_WriteBufferLength() { }

	// RVA: 0x1181550 Offset: 0x117FB50 VA: 0x181181550
	internal void ForceCompletion() { }

	// RVA: 0x1180A80 Offset: 0x117F080 VA: 0x181180A80
	internal void CheckComplete() { }

	// RVA: 0x1181690 Offset: 0x117FC90 VA: 0x181181690
	internal void ReadAll() { }

	// RVA: 0x11823E0 Offset: 0x11809E0 VA: 0x1811823E0
	private void WriteCallbackWrapper(IAsyncResult r) { }

	// RVA: 0x1181A70 Offset: 0x1180070 VA: 0x181181A70
	private void ReadCallbackWrapper(IAsyncResult r) { }

	// RVA: 0x1181B90 Offset: 0x1180190 VA: 0x181181B90 Slot: 27
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x117FEB0 Offset: 0x117E4B0 VA: 0x18117FEB0 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1180F80 Offset: 0x117F580 VA: 0x181180F80 Slot: 20
	public override int EndRead(IAsyncResult r) { }

	// RVA: 0x1182190 Offset: 0x1180790 VA: 0x181182190
	private void WriteAsyncCB(IAsyncResult r) { }

	// RVA: 0x1180270 Offset: 0x117E870 VA: 0x181180270 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1180B10 Offset: 0x117F110 VA: 0x181180B10
	private void CheckWriteOverflow(long contentLength, long totalWritten, long size) { }

	// RVA: 0x11812E0 Offset: 0x117F8E0 VA: 0x1811812E0 Slot: 23
	public override void EndWrite(IAsyncResult r) { }

	// RVA: 0x11827D0 Offset: 0x1180DD0 VA: 0x1811827D0 Slot: 29
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0x1181D80 Offset: 0x1180380 VA: 0x181181D80
	internal void SetHeadersAsync(bool setInternalLength, SimpleAsyncCallback callback) { }

	// RVA: 0x1181E40 Offset: 0x1180440 VA: 0x181181E40
	private bool SetHeadersAsync(SimpleAsyncResult result, bool setInternalLength) { }

	// RVA: 0x1182FA0 Offset: 0x11815A0 VA: 0x181182FA0
	internal bool get_RequestWritten() { }

	// RVA: 0x1182550 Offset: 0x1180B50 VA: 0x181182550
	internal bool WriteRequestAsync(SimpleAsyncResult result) { }

	// RVA: 0x962F70 Offset: 0x961570 VA: 0x180962F70
	internal void InternalClose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1182EE0 Offset: 0x11814E0 VA: 0x181182EE0
	internal bool get_GetResponseOnClose() { }

	// RVA: 0x1180BE0 Offset: 0x117F1E0 VA: 0x181180BE0 Slot: 16
	public override void Close() { }

	// RVA: 0x1181670 Offset: 0x117FC70 VA: 0x181181670
	internal void KillBuffer() { }

	// RVA: 0x1181D30 Offset: 0x1180330 VA: 0x181181D30 Slot: 25
	public override long Seek(long a, SeekOrigin b) { }

	// RVA: 0x1182140 Offset: 0x1180740 VA: 0x181182140 Slot: 26
	public override void SetLength(long a) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1182E90 Offset: 0x1181490 VA: 0x181182E90 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1182EB0 Offset: 0x11814B0 VA: 0x181182EB0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x1182EF0 Offset: 0x11814F0 VA: 0x181182EF0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1182F50 Offset: 0x1181550 VA: 0x181182F50 Slot: 11
	public override long get_Position() { }

	// RVA: 0x1183010 Offset: 0x1181610 VA: 0x181183010 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x1182970 Offset: 0x1180F70 VA: 0x181182970
	private static void .cctor() { }

}

private sealed class WebConnectionStream.<>c__DisplayClass75_0 // TypeDefIndex: 3034
{	// Fields
	public WebConnectionStream <>4__this; // 0x10
	public bool setInternalLength; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x117DE70 Offset: 0x117C470 VA: 0x18117DE70
	internal bool <SetHeadersAsync>b__0(SimpleAsyncResult r) { }

}

private sealed class WebConnectionStream.<>c__DisplayClass76_0 // TypeDefIndex: 3035
{	// Fields
	public WebConnectionStream <>4__this; // 0x10
	public SimpleAsyncResult result; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x117DEA0 Offset: 0x117C4A0 VA: 0x18117DEA0
	internal void <SetHeadersAsync>b__0(IAsyncResult r) { }

}

private sealed class WebConnectionStream.<>c__DisplayClass80_0 // TypeDefIndex: 3036
{	// Fields
	public SimpleAsyncResult result; // 0x10
	public WebConnectionStream <>4__this; // 0x18
	public int length; // 0x20
	public byte[] bytes; // 0x28
	public AsyncCallback <>9__1; // 0x30

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x117E4E0 Offset: 0x117CAE0 VA: 0x18117E4E0
	internal void <WriteRequestAsync>b__0(SimpleAsyncResult inner) { }

	// RVA: 0x117E6A0 Offset: 0x117CCA0 VA: 0x18117E6A0
	internal void <WriteRequestAsync>b__1(IAsyncResult r) { }

}

