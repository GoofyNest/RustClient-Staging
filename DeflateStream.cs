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

	// RVA: 0x172B0A0 Offset: 0x17296A0 VA: 0x18172B0A0
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x172B080 Offset: 0x1729680 VA: 0x18172B080
	internal void .ctor(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits) { }

	// RVA: 0x172B0C0 Offset: 0x17296C0 VA: 0x18172B0C0
	internal void .ctor(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip) { }

	// RVA: 0x172A6F0 Offset: 0x1728CF0 VA: 0x18172A6F0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x172AB00 Offset: 0x1729100 VA: 0x18172AB00
	private int ReadInternal(byte[] array, int offset, int count) { }

	// RVA: 0x172AB50 Offset: 0x1729150 VA: 0x18172AB50 Slot: 27
	public override int Read(byte[] array, int offset, int count) { }

	// RVA: 0x172AE10 Offset: 0x1729410 VA: 0x18172AE10
	private void WriteInternal(byte[] array, int offset, int count) { }

	// RVA: 0x172AE60 Offset: 0x1729460 VA: 0x18172AE60 Slot: 29
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x172AA40 Offset: 0x1729040 VA: 0x18172AA40 Slot: 18
	public override void Flush() { }

	// RVA: 0x172A250 Offset: 0x1728850 VA: 0x18172A250 Slot: 19
	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x172A4A0 Offset: 0x1728AA0 VA: 0x18172A4A0 Slot: 22
	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x172A780 Offset: 0x1728D80 VA: 0x18172A780 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x172A8E0 Offset: 0x1728EE0 VA: 0x18172A8E0 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x172AD70 Offset: 0x1729370 VA: 0x18172AD70 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x172ADC0 Offset: 0x17293C0 VA: 0x18172ADC0 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x172B220 Offset: 0x1729820 VA: 0x18172B220 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x172B260 Offset: 0x1729860 VA: 0x18172B260 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x172B2A0 Offset: 0x17298A0 VA: 0x18172B2A0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x172B2F0 Offset: 0x17298F0 VA: 0x18172B2F0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x172B340 Offset: 0x1729940 VA: 0x18172B340 Slot: 12
	public override void set_Position(long value) { }

}

private sealed class DeflateStream.ReadMethod : MulticastDelegate // TypeDefIndex: 2863
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13491A0 Offset: 0x13477A0 VA: 0x1813491A0 Slot: 12
	public virtual int Invoke(byte[] array, int offset, int count) { }

	// RVA: 0x1536D60 Offset: 0x1535360 VA: 0x181536D60 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0xB9A9D0 Offset: 0xB98FD0 VA: 0x180B9A9D0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

private sealed class DeflateStream.WriteMethod : MulticastDelegate // TypeDefIndex: 2864
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1349EB0 Offset: 0x13484B0 VA: 0x181349EB0 Slot: 12
	public virtual void Invoke(byte[] array, int offset, int count) { }

	// RVA: 0x1537CD0 Offset: 0x15362D0 VA: 0x181537CD0 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

