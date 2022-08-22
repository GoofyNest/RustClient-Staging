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

	// RVA: 0x1331420 Offset: 0x132FA20 VA: 0x181331420
	internal void .ctor(FtpWebRequest request, Stream stream, bool isRead) { }

	// RVA: 0x8C1670 Offset: 0x8BFC70 VA: 0x1808C1670 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1331500 Offset: 0x132FB00 VA: 0x181331500 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1331510 Offset: 0x132FB10 VA: 0x181331510 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1331560 Offset: 0x132FB60 VA: 0x181331560 Slot: 11
	public override long get_Position() { }

	// RVA: 0x13315B0 Offset: 0x132FBB0 VA: 0x1813315B0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x1330930 Offset: 0x132EF30 VA: 0x181330930 Slot: 16
	public override void Close() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0x1331030 Offset: 0x132F630 VA: 0x181331030 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1331080 Offset: 0x132F680 VA: 0x181331080 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x1330CD0 Offset: 0x132F2D0 VA: 0x181330CD0
	private int ReadInternal(byte[] buffer, int offset, int size) { }

	// RVA: 0x13304A0 Offset: 0x132EAA0 VA: 0x1813304A0 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1330A10 Offset: 0x132F010 VA: 0x181330A10 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1330E80 Offset: 0x132F480 VA: 0x181330E80 Slot: 27
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1331140 Offset: 0x132F740 VA: 0x181331140
	private void WriteInternal(byte[] buffer, int offset, int size) { }

	// RVA: 0x13306A0 Offset: 0x132ECA0 VA: 0x1813306A0 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1330B80 Offset: 0x132F180 VA: 0x181330B80 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1331270 Offset: 0x132F870 VA: 0x181331270 Slot: 29
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0xFFB430 Offset: 0xFF9A30 VA: 0x180FFB430 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x13310D0 Offset: 0x132F6D0 VA: 0x1813310D0 Slot: 6
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1330950 Offset: 0x132EF50 VA: 0x181330950 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x13308A0 Offset: 0x132EEA0 VA: 0x1813308A0
	private void CheckDisposed() { }

}

private sealed class FtpDataStream.WriteDelegate : MulticastDelegate // TypeDefIndex: 2998
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1348FB0 Offset: 0x13475B0 VA: 0x181348FB0 Slot: 12
	public virtual void Invoke(byte[] buffer, int offset, int size) { }

	// RVA: 0x1348F10 Offset: 0x1347510 VA: 0x181348F10 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int size, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class FtpDataStream.ReadDelegate : MulticastDelegate // TypeDefIndex: 2999
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13482A0 Offset: 0x13468A0 VA: 0x1813482A0 Slot: 12
	public virtual int Invoke(byte[] buffer, int offset, int size) { }

	// RVA: 0x1348200 Offset: 0x1346800 VA: 0x181348200 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int size, AsyncCallback callback, object object) { }

	// RVA: 0xB9AEA0 Offset: 0xB994A0 VA: 0x180B9AEA0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

