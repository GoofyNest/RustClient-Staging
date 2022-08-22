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

	// RVA: 0x11828D0 Offset: 0x1180ED0 VA: 0x1811828D0
	public void .ctor(WebConnection cnc, WebConnectionData data) { }

	// RVA: 0x1182740 Offset: 0x1180D40 VA: 0x181182740
	public void .ctor(WebConnection cnc, HttpWebRequest request) { }

	// RVA: 0x1180730 Offset: 0x117ED30 VA: 0x181180730
	private bool CheckAuthHeader(string headerName) { }

	// RVA: 0x11812E0 Offset: 0x117F8E0 VA: 0x1811812E0
	private bool IsNtlmAuth() { }

	// RVA: 0x1180800 Offset: 0x117EE00 VA: 0x181180800
	internal void CheckResponseInBuffer() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	internal WebConnection get_Connection() { }

	// RVA: 0x1079E50 Offset: 0x1078450 VA: 0x181079E50 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0x1079E40 Offset: 0x1078440 VA: 0x181079E40 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0x1182C10 Offset: 0x1181210 VA: 0x181182C10
	internal bool get_CompleteRequestWritten() { }

	// RVA: 0xEC1870 Offset: 0xEBFE70 VA: 0x180EC1870
	internal void set_SendChunked(bool value) { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	internal void set_ReadBuffer(byte[] value) { }

	// RVA: 0x598430 Offset: 0x596A30 VA: 0x180598430
	internal void set_ReadBufferOffset(int value) { }

	// RVA: 0x59A0F0 Offset: 0x5986F0 VA: 0x18059A0F0
	internal void set_ReadBufferSize(int value) { }

	// RVA: 0x1182D20 Offset: 0x1181320 VA: 0x181182D20
	internal byte[] get_WriteBuffer() { }

	// RVA: 0x1182CF0 Offset: 0x11812F0 VA: 0x181182CF0
	internal int get_WriteBufferLength() { }

	// RVA: 0x1181290 Offset: 0x117F890 VA: 0x181181290
	internal void ForceCompletion() { }

	// RVA: 0x11807C0 Offset: 0x117EDC0 VA: 0x1811807C0
	internal void CheckComplete() { }

	// RVA: 0x11813D0 Offset: 0x117F9D0 VA: 0x1811813D0
	internal void ReadAll() { }

	// RVA: 0x1182120 Offset: 0x1180720 VA: 0x181182120
	private void WriteCallbackWrapper(IAsyncResult r) { }

	// RVA: 0x11817B0 Offset: 0x117FDB0 VA: 0x1811817B0
	private void ReadCallbackWrapper(IAsyncResult r) { }

	// RVA: 0x11818D0 Offset: 0x117FED0 VA: 0x1811818D0 Slot: 27
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x117FBF0 Offset: 0x117E1F0 VA: 0x18117FBF0 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1180CC0 Offset: 0x117F2C0 VA: 0x181180CC0 Slot: 20
	public override int EndRead(IAsyncResult r) { }

	// RVA: 0x1181ED0 Offset: 0x11804D0 VA: 0x181181ED0
	private void WriteAsyncCB(IAsyncResult r) { }

	// RVA: 0x117FFB0 Offset: 0x117E5B0 VA: 0x18117FFB0 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1180850 Offset: 0x117EE50 VA: 0x181180850
	private void CheckWriteOverflow(long contentLength, long totalWritten, long size) { }

	// RVA: 0x1181020 Offset: 0x117F620 VA: 0x181181020 Slot: 23
	public override void EndWrite(IAsyncResult r) { }

	// RVA: 0x1182510 Offset: 0x1180B10 VA: 0x181182510 Slot: 29
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0x1181AC0 Offset: 0x11800C0 VA: 0x181181AC0
	internal void SetHeadersAsync(bool setInternalLength, SimpleAsyncCallback callback) { }

	// RVA: 0x1181B80 Offset: 0x1180180 VA: 0x181181B80
	private bool SetHeadersAsync(SimpleAsyncResult result, bool setInternalLength) { }

	// RVA: 0x1182CE0 Offset: 0x11812E0 VA: 0x181182CE0
	internal bool get_RequestWritten() { }

	// RVA: 0x1182290 Offset: 0x1180890 VA: 0x181182290
	internal bool WriteRequestAsync(SimpleAsyncResult result) { }

	// RVA: 0x962E60 Offset: 0x961460 VA: 0x180962E60
	internal void InternalClose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1182C20 Offset: 0x1181220 VA: 0x181182C20
	internal bool get_GetResponseOnClose() { }

	// RVA: 0x1180920 Offset: 0x117EF20 VA: 0x181180920 Slot: 16
	public override void Close() { }

	// RVA: 0x11813B0 Offset: 0x117F9B0 VA: 0x1811813B0
	internal void KillBuffer() { }

	// RVA: 0x1181A70 Offset: 0x1180070 VA: 0x181181A70 Slot: 25
	public override long Seek(long a, SeekOrigin b) { }

	// RVA: 0x1181E80 Offset: 0x1180480 VA: 0x181181E80 Slot: 26
	public override void SetLength(long a) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1182BD0 Offset: 0x11811D0 VA: 0x181182BD0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1182BF0 Offset: 0x11811F0 VA: 0x181182BF0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x1182C30 Offset: 0x1181230 VA: 0x181182C30 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1182C90 Offset: 0x1181290 VA: 0x181182C90 Slot: 11
	public override long get_Position() { }

	// RVA: 0x1182D50 Offset: 0x1181350 VA: 0x181182D50 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x11826B0 Offset: 0x1180CB0 VA: 0x1811826B0
	private static void .cctor() { }

}

private sealed class WebConnectionStream.<>c__DisplayClass75_0 // TypeDefIndex: 3034
{	// Fields
	public WebConnectionStream <>4__this; // 0x10
	public bool setInternalLength; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x117DBB0 Offset: 0x117C1B0 VA: 0x18117DBB0
	internal bool <SetHeadersAsync>b__0(SimpleAsyncResult r) { }

}

private sealed class WebConnectionStream.<>c__DisplayClass76_0 // TypeDefIndex: 3035
{	// Fields
	public WebConnectionStream <>4__this; // 0x10
	public SimpleAsyncResult result; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x117DBE0 Offset: 0x117C1E0 VA: 0x18117DBE0
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

	// RVA: 0x117E220 Offset: 0x117C820 VA: 0x18117E220
	internal void <WriteRequestAsync>b__0(SimpleAsyncResult inner) { }

	// RVA: 0x117E3E0 Offset: 0x117C9E0 VA: 0x18117E3E0
	internal void <WriteRequestAsync>b__1(IAsyncResult r) { }

}

