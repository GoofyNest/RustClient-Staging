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

	// RVA: 0x22615D0 Offset: 0x225FBD0 VA: 0x1822615D0
	public void .ctor(Stream innerStream, LZ4StreamMode compressionMode, LZ4StreamFlags compressionFlags = 0, int blockSize = 1048576) { }

	// RVA: 0x2260D60 Offset: 0x225F360 VA: 0x182260D60
	private static NotSupportedException NotSupported(string operationName) { }

	// RVA: 0x2260A70 Offset: 0x225F070 VA: 0x182260A70
	private static EndOfStreamException EndOfStream() { }

	// RVA: 0x22611B0 Offset: 0x225F7B0 VA: 0x1822611B0
	private bool TryReadVarInt(out ulong result) { }

	// RVA: 0x2260F90 Offset: 0x225F590 VA: 0x182260F90
	private ulong ReadVarInt() { }

	// RVA: 0x2260E40 Offset: 0x225F440 VA: 0x182260E40
	private int ReadBlock(byte[] buffer, int offset, int length) { }

	// RVA: 0x22613B0 Offset: 0x225F9B0 VA: 0x1822613B0
	private void WriteVarInt(ulong value) { }

	// RVA: 0x2260AC0 Offset: 0x225F0C0 VA: 0x182260AC0
	private void FlushCurrentChunk() { }

	// RVA: 0x22606C0 Offset: 0x225ECC0 VA: 0x1822606C0
	private bool AcquireNextChunk() { }

	// RVA: 0x132CFE0 Offset: 0x132B5E0 VA: 0x18132CFE0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x5DE330 Offset: 0x5DC930 VA: 0x1805DE330 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x2260D20 Offset: 0x225F320 VA: 0x182260D20 Slot: 18
	public override void Flush() { }

	// RVA: 0xEAC020 Offset: 0xEAA620 VA: 0x180EAC020 Slot: 10
	public override long get_Length() { }

	// RVA: 0xEAC020 Offset: 0xEAA620 VA: 0x180EAC020 Slot: 11
	public override long get_Position() { }

	// RVA: 0x22616B0 Offset: 0x225FCB0 VA: 0x1822616B0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x2260ED0 Offset: 0x225F4D0 VA: 0x182260ED0 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x2261000 Offset: 0x225F600 VA: 0x182261000 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2261130 Offset: 0x225F730 VA: 0x182261130 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2261170 Offset: 0x225F770 VA: 0x182261170 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x22612B0 Offset: 0x225F8B0 VA: 0x1822612B0 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x2261480 Offset: 0x225FA80 VA: 0x182261480 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2260A10 Offset: 0x225F010 VA: 0x182260A10 Slot: 17
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

