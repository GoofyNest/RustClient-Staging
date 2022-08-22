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

	// RVA: 0x22620B0 Offset: 0x22606B0 VA: 0x1822620B0
	public void .ctor(Stream innerStream, LZ4StreamMode compressionMode, LZ4StreamFlags compressionFlags = 0, int blockSize = 1048576) { }

	// RVA: 0x2261840 Offset: 0x225FE40 VA: 0x182261840
	private static NotSupportedException NotSupported(string operationName) { }

	// RVA: 0x2261550 Offset: 0x225FB50 VA: 0x182261550
	private static EndOfStreamException EndOfStream() { }

	// RVA: 0x2261C90 Offset: 0x2260290 VA: 0x182261C90
	private bool TryReadVarInt(out ulong result) { }

	// RVA: 0x2261A70 Offset: 0x2260070 VA: 0x182261A70
	private ulong ReadVarInt() { }

	// RVA: 0x2261920 Offset: 0x225FF20 VA: 0x182261920
	private int ReadBlock(byte[] buffer, int offset, int length) { }

	// RVA: 0x2261E90 Offset: 0x2260490 VA: 0x182261E90
	private void WriteVarInt(ulong value) { }

	// RVA: 0x22615A0 Offset: 0x225FBA0 VA: 0x1822615A0
	private void FlushCurrentChunk() { }

	// RVA: 0x22611A0 Offset: 0x225F7A0 VA: 0x1822611A0
	private bool AcquireNextChunk() { }

	// RVA: 0x132C3A0 Offset: 0x132A9A0 VA: 0x18132C3A0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x5DE2C0 Offset: 0x5DC8C0 VA: 0x1805DE2C0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x2261800 Offset: 0x225FE00 VA: 0x182261800 Slot: 18
	public override void Flush() { }

	// RVA: 0xEACD90 Offset: 0xEAB390 VA: 0x180EACD90 Slot: 10
	public override long get_Length() { }

	// RVA: 0xEACD90 Offset: 0xEAB390 VA: 0x180EACD90 Slot: 11
	public override long get_Position() { }

	// RVA: 0x2262190 Offset: 0x2260790 VA: 0x182262190 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x22619B0 Offset: 0x225FFB0 VA: 0x1822619B0 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x2261AE0 Offset: 0x22600E0 VA: 0x182261AE0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2261C10 Offset: 0x2260210 VA: 0x182261C10 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2261C50 Offset: 0x2260250 VA: 0x182261C50 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x2261D90 Offset: 0x2260390 VA: 0x182261D90 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x2261F60 Offset: 0x2260560 VA: 0x182261F60 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x22614F0 Offset: 0x225FAF0 VA: 0x1822614F0 Slot: 17
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

