internal class FtpDataStream : Stream, IDisposable // TypeDefIndex: 2997
{	// Fields
	private FtpWebRequest request; // 0x28
	private Stream networkStream; // 0x30
	private bool disposed; // 0x38
	private bool isRead; // 0x39
	private int totalRead; // 0x3C

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1332320 Offset: 0x1330920 VA: 0x181332320
	internal void .ctor(FtpWebRequest request, Stream stream, bool isRead) { }

	// RVA: 0x8C1160 Offset: 0x8BF760 VA: 0x1808C1160 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1332400 Offset: 0x1330A00 VA: 0x181332400 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1332410 Offset: 0x1330A10 VA: 0x181332410 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1332460 Offset: 0x1330A60 VA: 0x181332460 Slot: 11
	public override long get_Position() { }

	// RVA: 0x13324B0 Offset: 0x1330AB0 VA: 0x1813324B0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x1331830 Offset: 0x132FE30 VA: 0x181331830 Slot: 16
	public override void Close() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0x1331F30 Offset: 0x1330530 VA: 0x181331F30 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1331F80 Offset: 0x1330580 VA: 0x181331F80 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x1331BD0 Offset: 0x13301D0 VA: 0x181331BD0
	private int ReadInternal(byte[] buffer, int offset, int size) { }

	// RVA: 0x13313A0 Offset: 0x132F9A0 VA: 0x1813313A0 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1331910 Offset: 0x132FF10 VA: 0x181331910 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1331D80 Offset: 0x1330380 VA: 0x181331D80 Slot: 27
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1332040 Offset: 0x1330640 VA: 0x181332040
	private void WriteInternal(byte[] buffer, int offset, int size) { }

	// RVA: 0x13315A0 Offset: 0x132FBA0 VA: 0x1813315A0 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1331A80 Offset: 0x1330080 VA: 0x181331A80 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1332170 Offset: 0x1330770 VA: 0x181332170 Slot: 29
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0xFFA990 Offset: 0xFF8F90 VA: 0x180FFA990 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1331FD0 Offset: 0x13305D0 VA: 0x181331FD0 Slot: 6
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1331850 Offset: 0x132FE50 VA: 0x181331850 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x13317A0 Offset: 0x132FDA0 VA: 0x1813317A0
	private void CheckDisposed() { }

}

private sealed class FtpDataStream.WriteDelegate : MulticastDelegate // TypeDefIndex: 2998
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1349EB0 Offset: 0x13484B0 VA: 0x181349EB0 Slot: 12
	public virtual void Invoke(byte[] buffer, int offset, int size) { }

	// RVA: 0x1349E10 Offset: 0x1348410 VA: 0x181349E10 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int size, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class FtpDataStream.ReadDelegate : MulticastDelegate // TypeDefIndex: 2999
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13491A0 Offset: 0x13477A0 VA: 0x1813491A0 Slot: 12
	public virtual int Invoke(byte[] buffer, int offset, int size) { }

	// RVA: 0x1349100 Offset: 0x1347700 VA: 0x181349100 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int size, AsyncCallback callback, object object) { }

	// RVA: 0xB9A9D0 Offset: 0xB98FD0 VA: 0x180B9A9D0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

