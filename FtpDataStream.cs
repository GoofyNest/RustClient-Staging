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

	// RVA: 0x1332060 Offset: 0x1330660 VA: 0x181332060
	internal void .ctor(FtpWebRequest request, Stream stream, bool isRead) { }

	// RVA: 0x8C1050 Offset: 0x8BF650 VA: 0x1808C1050 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1332140 Offset: 0x1330740 VA: 0x181332140 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1332150 Offset: 0x1330750 VA: 0x181332150 Slot: 10
	public override long get_Length() { }

	// RVA: 0x13321A0 Offset: 0x13307A0 VA: 0x1813321A0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x13321F0 Offset: 0x13307F0 VA: 0x1813321F0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x1331570 Offset: 0x132FB70 VA: 0x181331570 Slot: 16
	public override void Close() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0x1331C70 Offset: 0x1330270 VA: 0x181331C70 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1331CC0 Offset: 0x13302C0 VA: 0x181331CC0 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x1331910 Offset: 0x132FF10 VA: 0x181331910
	private int ReadInternal(byte[] buffer, int offset, int size) { }

	// RVA: 0x13310E0 Offset: 0x132F6E0 VA: 0x1813310E0 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1331650 Offset: 0x132FC50 VA: 0x181331650 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1331AC0 Offset: 0x13300C0 VA: 0x181331AC0 Slot: 27
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1331D80 Offset: 0x1330380 VA: 0x181331D80
	private void WriteInternal(byte[] buffer, int offset, int size) { }

	// RVA: 0x13312E0 Offset: 0x132F8E0 VA: 0x1813312E0 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x13317C0 Offset: 0x132FDC0 VA: 0x1813317C0 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1331EB0 Offset: 0x13304B0 VA: 0x181331EB0 Slot: 29
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0xFFA6D0 Offset: 0xFF8CD0 VA: 0x180FFA6D0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1331D10 Offset: 0x1330310 VA: 0x181331D10 Slot: 6
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1331590 Offset: 0x132FB90 VA: 0x181331590 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x13314E0 Offset: 0x132FAE0 VA: 0x1813314E0
	private void CheckDisposed() { }

}

private sealed class FtpDataStream.WriteDelegate : MulticastDelegate // TypeDefIndex: 2998
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1349BF0 Offset: 0x13481F0 VA: 0x181349BF0 Slot: 12
	public virtual void Invoke(byte[] buffer, int offset, int size) { }

	// RVA: 0x1349B50 Offset: 0x1348150 VA: 0x181349B50 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int size, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class FtpDataStream.ReadDelegate : MulticastDelegate // TypeDefIndex: 2999
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1348EE0 Offset: 0x13474E0 VA: 0x181348EE0 Slot: 12
	public virtual int Invoke(byte[] buffer, int offset, int size) { }

	// RVA: 0x1348E40 Offset: 0x1347440 VA: 0x181348E40 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int size, AsyncCallback callback, object object) { }

	// RVA: 0xB9A710 Offset: 0xB98D10 VA: 0x180B9A710 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

