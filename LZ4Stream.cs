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

	// RVA: 0x2261790 Offset: 0x225FD90 VA: 0x182261790
	public void .ctor(Stream innerStream, LZ4StreamMode compressionMode, LZ4StreamFlags compressionFlags = 0, int blockSize = 1048576) { }

	// RVA: 0x2260F20 Offset: 0x225F520 VA: 0x182260F20
	private static NotSupportedException NotSupported(string operationName) { }

	// RVA: 0x2260C30 Offset: 0x225F230 VA: 0x182260C30
	private static EndOfStreamException EndOfStream() { }

	// RVA: 0x2261370 Offset: 0x225F970 VA: 0x182261370
	private bool TryReadVarInt(out ulong result) { }

	// RVA: 0x2261150 Offset: 0x225F750 VA: 0x182261150
	private ulong ReadVarInt() { }

	// RVA: 0x2261000 Offset: 0x225F600 VA: 0x182261000
	private int ReadBlock(byte[] buffer, int offset, int length) { }

	// RVA: 0x2261570 Offset: 0x225FB70 VA: 0x182261570
	private void WriteVarInt(ulong value) { }

	// RVA: 0x2260C80 Offset: 0x225F280 VA: 0x182260C80
	private void FlushCurrentChunk() { }

	// RVA: 0x2260880 Offset: 0x225EE80 VA: 0x182260880
	private bool AcquireNextChunk() { }

	// RVA: 0x132CFE0 Offset: 0x132B5E0 VA: 0x18132CFE0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x5DE330 Offset: 0x5DC930 VA: 0x1805DE330 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x2260EE0 Offset: 0x225F4E0 VA: 0x182260EE0 Slot: 18
	public override void Flush() { }

	// RVA: 0xEAC020 Offset: 0xEAA620 VA: 0x180EAC020 Slot: 10
	public override long get_Length() { }

	// RVA: 0xEAC020 Offset: 0xEAA620 VA: 0x180EAC020 Slot: 11
	public override long get_Position() { }

	// RVA: 0x2261870 Offset: 0x225FE70 VA: 0x182261870 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x2261090 Offset: 0x225F690 VA: 0x182261090 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x22611C0 Offset: 0x225F7C0 VA: 0x1822611C0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x22612F0 Offset: 0x225F8F0 VA: 0x1822612F0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2261330 Offset: 0x225F930 VA: 0x182261330 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x2261470 Offset: 0x225FA70 VA: 0x182261470 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x2261640 Offset: 0x225FC40 VA: 0x182261640 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2260BD0 Offset: 0x225F1D0 VA: 0x182260BD0 Slot: 17
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

