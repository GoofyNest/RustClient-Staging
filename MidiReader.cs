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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly long <Length>k__BackingField; // 0x50

	// Properties
	public long Position { get; set; }
	public long Length { get; }
	public bool EndReached { get; }

	// Methods

	// RVA: 0x13A2B90 Offset: 0x13A1190 VA: 0x1813A2B90
	public void .ctor(Stream stream, ReaderSettings settings) { }

	// RVA: 0x13A2F60 Offset: 0x13A1560 VA: 0x1813A2F60
	public long get_Position() { }

	// RVA: 0x13A2FA0 Offset: 0x13A15A0 VA: 0x1813A2FA0
	public void set_Position(long value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public long get_Length() { }

	// RVA: 0x13A2E70 Offset: 0x13A1470 VA: 0x1813A2E70
	public bool get_EndReached() { }

	// RVA: 0x13A1F50 Offset: 0x13A0550 VA: 0x1813A1F50
	public byte ReadByte() { }

	// RVA: 0x13A2950 Offset: 0x13A0F50 VA: 0x1813A2950
	public sbyte ReadSByte() { }

	// RVA: 0x13A2560 Offset: 0x13A0B60 VA: 0x1813A2560
	public byte[] ReadBytes(int count) { }

	// RVA: 0x13A2A60 Offset: 0x13A1060 VA: 0x1813A2A60
	public ushort ReadWord() { }

	// RVA: 0x13A2750 Offset: 0x13A0D50 VA: 0x1813A2750
	public uint ReadDword() { }

	// RVA: 0x13A2870 Offset: 0x13A0E70 VA: 0x1813A2870
	public short ReadInt16() { }

	// RVA: 0x13A2960 Offset: 0x13A0F60 VA: 0x1813A2960
	public string ReadString(int count) { }

	// RVA: 0x13A2A50 Offset: 0x13A1050 VA: 0x1813A2A50
	public int ReadVlqNumber() { }

	// RVA: 0x13A29A0 Offset: 0x13A0FA0 VA: 0x1813A29A0
	public long ReadVlqLongNumber() { }

	// RVA: 0x13A1E50 Offset: 0x13A0450 VA: 0x1813A1E50
	public uint Read3ByteDword() { }

	// RVA: 0x13A2170 Offset: 0x13A0770 VA: 0x1813A2170
	private byte[] ReadBytesInternal(int count) { }

	// RVA: 0x13A22E0 Offset: 0x13A08E0 VA: 0x1813A22E0
	private byte[] ReadBytesWithBuffering(int count) { }

	// RVA: 0x13A2090 Offset: 0x13A0690 VA: 0x1813A2090
	private byte[] ReadBytesFromBuffer(int count) { }

	// RVA: 0x13A2480 Offset: 0x13A0A80 VA: 0x1813A2480
	private byte[] ReadBytesWithoutBuffering(int count) { }

	// RVA: 0x13A1AD0 Offset: 0x13A00D0 VA: 0x1813A1AD0
	private bool EnsureBufferIsReadyForReading() { }

	// RVA: 0x13A1C10 Offset: 0x13A0210 VA: 0x1813A1C10
	private void PrepareBuffer() { }

	// RVA: 0x13A1AC0 Offset: 0x13A00C0 VA: 0x1813A1AC0 Slot: 4
	public void Dispose() { }

	// RVA: 0x13A1AC0 Offset: 0x13A00C0 VA: 0x1813A1AC0
	private void Dispose(bool disposing) { }

	// RVA: 0x13A2B40 Offset: 0x13A1140 VA: 0x1813A2B40
	private static void .cctor() { }

}

private sealed class MidiReader.<>c // TypeDefIndex: 7588
{	// Fields
	public static readonly MidiReader.<>c <>9; // 0x0
	public static Func<byte[], IEnumerable<byte>> <>9__22_0; // 0x8

	// Methods

	// RVA: 0x13AAB90 Offset: 0x13A9190 VA: 0x1813AAB90
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7B4E80 Offset: 0x7B3480 VA: 0x1807B4E80
	internal IEnumerable<byte> <ReadBytes>b__22_0(byte[] bytes) { }

}

