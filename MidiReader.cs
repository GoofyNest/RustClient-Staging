public sealed class MidiReader : IDisposable // TypeDefIndex: 7587
{	// Fields
	private static readonly byte[] EmptyByteArray; // 0x0
	private readonly ReaderSettings _settings; // 0x10
	private readonly Stream _stream; // 0x18
	private readonly bool _isStreamWrapped; // 0x20
	private readonly bool _useBuffering; // 0x21
	private byte[] _buffer; // 0x28
	private int _bufferSize; // 0x30
	private int _bufferPosition; // 0x34
	private long _bufferStart; // 0x38
	private long _position; // 0x40
	private bool _disposed; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly long <Length>k__BackingField; // 0x50

	// Properties
	public long Position { get; set; }
	public long Length { get; }
	public bool EndReached { get; }

	// Methods

	// RVA: 0x13A1F50 Offset: 0x13A0550 VA: 0x1813A1F50
	public void .ctor(Stream stream, ReaderSettings settings) { }

	// RVA: 0x13A2320 Offset: 0x13A0920 VA: 0x1813A2320
	public long get_Position() { }

	// RVA: 0x13A2360 Offset: 0x13A0960 VA: 0x1813A2360
	public void set_Position(long value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public long get_Length() { }

	// RVA: 0x13A2230 Offset: 0x13A0830 VA: 0x1813A2230
	public bool get_EndReached() { }

	// RVA: 0x13A1310 Offset: 0x139F910 VA: 0x1813A1310
	public byte ReadByte() { }

	// RVA: 0x13A1D10 Offset: 0x13A0310 VA: 0x1813A1D10
	public sbyte ReadSByte() { }

	// RVA: 0x13A1920 Offset: 0x139FF20 VA: 0x1813A1920
	public byte[] ReadBytes(int count) { }

	// RVA: 0x13A1E20 Offset: 0x13A0420 VA: 0x1813A1E20
	public ushort ReadWord() { }

	// RVA: 0x13A1B10 Offset: 0x13A0110 VA: 0x1813A1B10
	public uint ReadDword() { }

	// RVA: 0x13A1C30 Offset: 0x13A0230 VA: 0x1813A1C30
	public short ReadInt16() { }

	// RVA: 0x13A1D20 Offset: 0x13A0320 VA: 0x1813A1D20
	public string ReadString(int count) { }

	// RVA: 0x13A1E10 Offset: 0x13A0410 VA: 0x1813A1E10
	public int ReadVlqNumber() { }

	// RVA: 0x13A1D60 Offset: 0x13A0360 VA: 0x1813A1D60
	public long ReadVlqLongNumber() { }

	// RVA: 0x13A1210 Offset: 0x139F810 VA: 0x1813A1210
	public uint Read3ByteDword() { }

	// RVA: 0x13A1530 Offset: 0x139FB30 VA: 0x1813A1530
	private byte[] ReadBytesInternal(int count) { }

	// RVA: 0x13A16A0 Offset: 0x139FCA0 VA: 0x1813A16A0
	private byte[] ReadBytesWithBuffering(int count) { }

	// RVA: 0x13A1450 Offset: 0x139FA50 VA: 0x1813A1450
	private byte[] ReadBytesFromBuffer(int count) { }

	// RVA: 0x13A1840 Offset: 0x139FE40 VA: 0x1813A1840
	private byte[] ReadBytesWithoutBuffering(int count) { }

	// RVA: 0x13A0E90 Offset: 0x139F490 VA: 0x1813A0E90
	private bool EnsureBufferIsReadyForReading() { }

	// RVA: 0x13A0FD0 Offset: 0x139F5D0 VA: 0x1813A0FD0
	private void PrepareBuffer() { }

	// RVA: 0x13A0E80 Offset: 0x139F480 VA: 0x1813A0E80 Slot: 4
	public void Dispose() { }

	// RVA: 0x13A0E80 Offset: 0x139F480 VA: 0x1813A0E80
	private void Dispose(bool disposing) { }

	// RVA: 0x13A1F00 Offset: 0x13A0500 VA: 0x1813A1F00
	private static void .cctor() { }

}

private sealed class MidiReader.<>c // TypeDefIndex: 7588
{	// Fields
	public static readonly MidiReader.<>c <>9; // 0x0
	public static Func<byte[], IEnumerable<byte>> <>9__22_0; // 0x8

	// Methods

	// RVA: 0x13A9F50 Offset: 0x13A8550 VA: 0x1813A9F50
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380
	internal IEnumerable<byte> <ReadBytes>b__22_0(byte[] bytes) { }

}

