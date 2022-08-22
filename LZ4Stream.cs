public class LZ4Stream : Stream // TypeDefIndex: 6990
{	// Fields
	private readonly Stream _innerStream; // 0x28
	private readonly LZ4StreamMode _compressionMode; // 0x30
	private readonly bool _highCompression; // 0x34
	private readonly bool _interactiveRead; // 0x35
	private readonly bool _isolateInnerStream; // 0x36
	private readonly int _blockSize; // 0x38
	private byte[] _buffer; // 0x40
	private int _bufferLength; // 0x48
	private int _bufferOffset; // 0x4C

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x2261890 Offset: 0x225FE90 VA: 0x182261890
	public void .ctor(Stream innerStream, LZ4StreamMode compressionMode, LZ4StreamFlags compressionFlags = 0, int blockSize = 1048576) { }

	// RVA: 0x2261020 Offset: 0x225F620 VA: 0x182261020
	private static NotSupportedException NotSupported(string operationName) { }

	// RVA: 0x2260D30 Offset: 0x225F330 VA: 0x182260D30
	private static EndOfStreamException EndOfStream() { }

	// RVA: 0x2261470 Offset: 0x225FA70 VA: 0x182261470
	private bool TryReadVarInt(out ulong result) { }

	// RVA: 0x2261250 Offset: 0x225F850 VA: 0x182261250
	private ulong ReadVarInt() { }

	// RVA: 0x2261100 Offset: 0x225F700 VA: 0x182261100
	private int ReadBlock(byte[] buffer, int offset, int length) { }

	// RVA: 0x2261670 Offset: 0x225FC70 VA: 0x182261670
	private void WriteVarInt(ulong value) { }

	// RVA: 0x2260D80 Offset: 0x225F380 VA: 0x182260D80
	private void FlushCurrentChunk() { }

	// RVA: 0x2260980 Offset: 0x225EF80 VA: 0x182260980
	private bool AcquireNextChunk() { }

	// RVA: 0x132D2A0 Offset: 0x132B8A0 VA: 0x18132D2A0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x5DE330 Offset: 0x5DC930 VA: 0x1805DE330 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x2260FE0 Offset: 0x225F5E0 VA: 0x182260FE0 Slot: 18
	public override void Flush() { }

	// RVA: 0xEAC2E0 Offset: 0xEAA8E0 VA: 0x180EAC2E0 Slot: 10
	public override long get_Length() { }

	// RVA: 0xEAC2E0 Offset: 0xEAA8E0 VA: 0x180EAC2E0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x2261970 Offset: 0x225FF70 VA: 0x182261970 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x2261190 Offset: 0x225F790 VA: 0x182261190 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x22612C0 Offset: 0x225F8C0 VA: 0x1822612C0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x22613F0 Offset: 0x225F9F0 VA: 0x1822613F0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2261430 Offset: 0x225FA30 VA: 0x182261430 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x2261570 Offset: 0x225FB70 VA: 0x182261570 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x2261740 Offset: 0x225FD40 VA: 0x182261740 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2260CD0 Offset: 0x225F2D0 VA: 0x182260CD0 Slot: 17
	protected override void Dispose(bool disposing) { }

}

public enum LZ4Stream.ChunkFlags // TypeDefIndex: 6991
{	// Fields
	public int value__; // 0x0
	public const LZ4Stream.ChunkFlags None = 0;
	public const LZ4Stream.ChunkFlags Compressed = 1;
	public const LZ4Stream.ChunkFlags HighCompression = 2;
	public const LZ4Stream.ChunkFlags Passes = 28;

}

