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

	// RVA: 0x11874B0 Offset: 0x1185AB0 VA: 0x1811874B0
	public void .ctor(WebConnection cnc, WebConnectionData data) { }

	// RVA: 0x1187320 Offset: 0x1185920 VA: 0x181187320
	public void .ctor(WebConnection cnc, HttpWebRequest request) { }

	// RVA: 0x1185310 Offset: 0x1183910 VA: 0x181185310
	private bool CheckAuthHeader(string headerName) { }

	// RVA: 0x1185EC0 Offset: 0x11844C0 VA: 0x181185EC0
	private bool IsNtlmAuth() { }

	// RVA: 0x11853E0 Offset: 0x11839E0 VA: 0x1811853E0
	internal void CheckResponseInBuffer() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	internal WebConnection get_Connection() { }

	// RVA: 0x107AB80 Offset: 0x1079180 VA: 0x18107AB80 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0x107AB70 Offset: 0x1079170 VA: 0x18107AB70 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0x11877F0 Offset: 0x1185DF0 VA: 0x1811877F0
	internal bool get_CompleteRequestWritten() { }

	// RVA: 0xEC25E0 Offset: 0xEC0BE0 VA: 0x180EC25E0
	internal void set_SendChunked(bool value) { }

	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	internal void set_ReadBuffer(byte[] value) { }

	// RVA: 0x5983C0 Offset: 0x5969C0 VA: 0x1805983C0
	internal void set_ReadBufferOffset(int value) { }

	// RVA: 0x59A080 Offset: 0x598680 VA: 0x18059A080
	internal void set_ReadBufferSize(int value) { }

	// RVA: 0x1187900 Offset: 0x1185F00 VA: 0x181187900
	internal byte[] get_WriteBuffer() { }

	// RVA: 0x11878D0 Offset: 0x1185ED0 VA: 0x1811878D0
	internal int get_WriteBufferLength() { }

	// RVA: 0x1185E70 Offset: 0x1184470 VA: 0x181185E70
	internal void ForceCompletion() { }

	// RVA: 0x11853A0 Offset: 0x11839A0 VA: 0x1811853A0
	internal void CheckComplete() { }

	// RVA: 0x1185FB0 Offset: 0x11845B0 VA: 0x181185FB0
	internal void ReadAll() { }

	// RVA: 0x1186D00 Offset: 0x1185300 VA: 0x181186D00
	private void WriteCallbackWrapper(IAsyncResult r) { }

	// RVA: 0x1186390 Offset: 0x1184990 VA: 0x181186390
	private void ReadCallbackWrapper(IAsyncResult r) { }

	// RVA: 0x11864B0 Offset: 0x1184AB0 VA: 0x1811864B0 Slot: 27
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x11847D0 Offset: 0x1182DD0 VA: 0x1811847D0 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x11858A0 Offset: 0x1183EA0 VA: 0x1811858A0 Slot: 20
	public override int EndRead(IAsyncResult r) { }

	// RVA: 0x1186AB0 Offset: 0x11850B0 VA: 0x181186AB0
	private void WriteAsyncCB(IAsyncResult r) { }

	// RVA: 0x1184B90 Offset: 0x1183190 VA: 0x181184B90 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1185430 Offset: 0x1183A30 VA: 0x181185430
	private void CheckWriteOverflow(long contentLength, long totalWritten, long size) { }

	// RVA: 0x1185C00 Offset: 0x1184200 VA: 0x181185C00 Slot: 23
	public override void EndWrite(IAsyncResult r) { }

	// RVA: 0x11870F0 Offset: 0x11856F0 VA: 0x1811870F0 Slot: 29
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0x11866A0 Offset: 0x1184CA0 VA: 0x1811866A0
	internal void SetHeadersAsync(bool setInternalLength, SimpleAsyncCallback callback) { }

	// RVA: 0x1186760 Offset: 0x1184D60 VA: 0x181186760
	private bool SetHeadersAsync(SimpleAsyncResult result, bool setInternalLength) { }

	// RVA: 0x11878C0 Offset: 0x1185EC0 VA: 0x1811878C0
	internal bool get_RequestWritten() { }

	// RVA: 0x1186E70 Offset: 0x1185470 VA: 0x181186E70
	internal bool WriteRequestAsync(SimpleAsyncResult result) { }

	// RVA: 0x963470 Offset: 0x961A70 VA: 0x180963470
	internal void InternalClose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1187800 Offset: 0x1185E00 VA: 0x181187800
	internal bool get_GetResponseOnClose() { }

	// RVA: 0x1185500 Offset: 0x1183B00 VA: 0x181185500 Slot: 16
	public override void Close() { }

	// RVA: 0x1185F90 Offset: 0x1184590 VA: 0x181185F90
	internal void KillBuffer() { }

	// RVA: 0x1186650 Offset: 0x1184C50 VA: 0x181186650 Slot: 25
	public override long Seek(long a, SeekOrigin b) { }

	// RVA: 0x1186A60 Offset: 0x1185060 VA: 0x181186A60 Slot: 26
	public override void SetLength(long a) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x11877B0 Offset: 0x1185DB0 VA: 0x1811877B0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x11877D0 Offset: 0x1185DD0 VA: 0x1811877D0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x1187810 Offset: 0x1185E10 VA: 0x181187810 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1187870 Offset: 0x1185E70 VA: 0x181187870 Slot: 11
	public override long get_Position() { }

	// RVA: 0x1187930 Offset: 0x1185F30 VA: 0x181187930 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x1187290 Offset: 0x1185890 VA: 0x181187290
	private static void .cctor() { }

}

private sealed class WebConnectionStream.<>c__DisplayClass75_0 // TypeDefIndex: 3034
{	// Fields
	public WebConnectionStream <>4__this; // 0x10
	public bool setInternalLength; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1182790 Offset: 0x1180D90 VA: 0x181182790
	internal bool <SetHeadersAsync>b__0(SimpleAsyncResult r) { }

}

private sealed class WebConnectionStream.<>c__DisplayClass76_0 // TypeDefIndex: 3035
{	// Fields
	public WebConnectionStream <>4__this; // 0x10
	public SimpleAsyncResult result; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x11827C0 Offset: 0x1180DC0 VA: 0x1811827C0
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

	// RVA: 0x1182E00 Offset: 0x1181400 VA: 0x181182E00
	internal void <WriteRequestAsync>b__0(SimpleAsyncResult inner) { }

	// RVA: 0x1182FC0 Offset: 0x11815C0 VA: 0x181182FC0
	internal void <WriteRequestAsync>b__1(IAsyncResult r) { }

}

