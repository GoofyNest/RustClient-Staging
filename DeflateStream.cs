public class DeflateStream : Stream // TypeDefIndex: 2862
{	// Fields
	private Stream base_stream; // 0x28
	private CompressionMode mode; // 0x30
	private bool leaveOpen; // 0x34
	private bool disposed; // 0x35
	private DeflateStreamNative native; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1728C60 Offset: 0x1727260 VA: 0x181728C60
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x1728C40 Offset: 0x1727240 VA: 0x181728C40
	internal void .ctor(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits) { }

	// RVA: 0x1728C80 Offset: 0x1727280 VA: 0x181728C80
	internal void .ctor(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip) { }

	// RVA: 0x17282B0 Offset: 0x17268B0 VA: 0x1817282B0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x17286C0 Offset: 0x1726CC0 VA: 0x1817286C0
	private int ReadInternal(byte[] array, int offset, int count) { }

	// RVA: 0x1728710 Offset: 0x1726D10 VA: 0x181728710 Slot: 27
	public override int Read(byte[] array, int offset, int count) { }

	// RVA: 0x17289D0 Offset: 0x1726FD0 VA: 0x1817289D0
	private void WriteInternal(byte[] array, int offset, int count) { }

	// RVA: 0x1728A20 Offset: 0x1727020 VA: 0x181728A20 Slot: 29
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x1728600 Offset: 0x1726C00 VA: 0x181728600 Slot: 18
	public override void Flush() { }

	// RVA: 0x1727E10 Offset: 0x1726410 VA: 0x181727E10 Slot: 19
	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1728060 Offset: 0x1726660 VA: 0x181728060 Slot: 22
	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1728340 Offset: 0x1726940 VA: 0x181728340 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x17284A0 Offset: 0x1726AA0 VA: 0x1817284A0 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1728930 Offset: 0x1726F30 VA: 0x181728930 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1728980 Offset: 0x1726F80 VA: 0x181728980 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x1728DE0 Offset: 0x17273E0 VA: 0x181728DE0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1728E20 Offset: 0x1727420 VA: 0x181728E20 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x1728E60 Offset: 0x1727460 VA: 0x181728E60 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1728EB0 Offset: 0x17274B0 VA: 0x181728EB0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x1728F00 Offset: 0x1727500 VA: 0x181728F00 Slot: 12
	public override void set_Position(long value) { }

}

private sealed class DeflateStream.ReadMethod : MulticastDelegate // TypeDefIndex: 2863
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13482A0 Offset: 0x13468A0 VA: 0x1813482A0 Slot: 12
	public virtual int Invoke(byte[] array, int offset, int count) { }

	// RVA: 0x1535E30 Offset: 0x1534430 VA: 0x181535E30 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0xB9AEA0 Offset: 0xB994A0 VA: 0x180B9AEA0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

private sealed class DeflateStream.WriteMethod : MulticastDelegate // TypeDefIndex: 2864
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1348FB0 Offset: 0x13475B0 VA: 0x181348FB0 Slot: 12
	public virtual void Invoke(byte[] array, int offset, int count) { }

	// RVA: 0x1536DA0 Offset: 0x15353A0 VA: 0x181536DA0 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

