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

	// RVA: 0x172ADE0 Offset: 0x17293E0 VA: 0x18172ADE0
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x172ADC0 Offset: 0x17293C0 VA: 0x18172ADC0
	internal void .ctor(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits) { }

	// RVA: 0x172AE00 Offset: 0x1729400 VA: 0x18172AE00
	internal void .ctor(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip) { }

	// RVA: 0x172A430 Offset: 0x1728A30 VA: 0x18172A430 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x172A840 Offset: 0x1728E40 VA: 0x18172A840
	private int ReadInternal(byte[] array, int offset, int count) { }

	// RVA: 0x172A890 Offset: 0x1728E90 VA: 0x18172A890 Slot: 27
	public override int Read(byte[] array, int offset, int count) { }

	// RVA: 0x172AB50 Offset: 0x1729150 VA: 0x18172AB50
	private void WriteInternal(byte[] array, int offset, int count) { }

	// RVA: 0x172ABA0 Offset: 0x17291A0 VA: 0x18172ABA0 Slot: 29
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x172A780 Offset: 0x1728D80 VA: 0x18172A780 Slot: 18
	public override void Flush() { }

	// RVA: 0x1729F90 Offset: 0x1728590 VA: 0x181729F90 Slot: 19
	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x172A1E0 Offset: 0x17287E0 VA: 0x18172A1E0 Slot: 22
	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x172A4C0 Offset: 0x1728AC0 VA: 0x18172A4C0 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x172A620 Offset: 0x1728C20 VA: 0x18172A620 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x172AAB0 Offset: 0x17290B0 VA: 0x18172AAB0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x172AB00 Offset: 0x1729100 VA: 0x18172AB00 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x172AF60 Offset: 0x1729560 VA: 0x18172AF60 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x172AFA0 Offset: 0x17295A0 VA: 0x18172AFA0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x172AFE0 Offset: 0x17295E0 VA: 0x18172AFE0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x172B030 Offset: 0x1729630 VA: 0x18172B030 Slot: 11
	public override long get_Position() { }

	// RVA: 0x172B080 Offset: 0x1729680 VA: 0x18172B080 Slot: 12
	public override void set_Position(long value) { }

}

private sealed class DeflateStream.ReadMethod : MulticastDelegate // TypeDefIndex: 2863
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1348EE0 Offset: 0x13474E0 VA: 0x181348EE0 Slot: 12
	public virtual int Invoke(byte[] array, int offset, int count) { }

	// RVA: 0x1536AA0 Offset: 0x15350A0 VA: 0x181536AA0 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0xB9A710 Offset: 0xB98D10 VA: 0x180B9A710 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

private sealed class DeflateStream.WriteMethod : MulticastDelegate // TypeDefIndex: 2864
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1349BF0 Offset: 0x13481F0 VA: 0x181349BF0 Slot: 12
	public virtual void Invoke(byte[] array, int offset, int count) { }

	// RVA: 0x1537A10 Offset: 0x1536010 VA: 0x181537A10 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

