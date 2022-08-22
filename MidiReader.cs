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

	// RVA: 0x13A2E50 Offset: 0x13A1450 VA: 0x1813A2E50
	public void .ctor(Stream stream, ReaderSettings settings) { }

	// RVA: 0x13A3220 Offset: 0x13A1820 VA: 0x1813A3220
	public long get_Position() { }

	// RVA: 0x13A3260 Offset: 0x13A1860 VA: 0x1813A3260
	public void set_Position(long value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public long get_Length() { }

	// RVA: 0x13A3130 Offset: 0x13A1730 VA: 0x1813A3130
	public bool get_EndReached() { }

	// RVA: 0x13A2210 Offset: 0x13A0810 VA: 0x1813A2210
	public byte ReadByte() { }

	// RVA: 0x13A2C10 Offset: 0x13A1210 VA: 0x1813A2C10
	public sbyte ReadSByte() { }

	// RVA: 0x13A2820 Offset: 0x13A0E20 VA: 0x1813A2820
	public byte[] ReadBytes(int count) { }

	// RVA: 0x13A2D20 Offset: 0x13A1320 VA: 0x1813A2D20
	public ushort ReadWord() { }

	// RVA: 0x13A2A10 Offset: 0x13A1010 VA: 0x1813A2A10
	public uint ReadDword() { }

	// RVA: 0x13A2B30 Offset: 0x13A1130 VA: 0x1813A2B30
	public short ReadInt16() { }

	// RVA: 0x13A2C20 Offset: 0x13A1220 VA: 0x1813A2C20
	public string ReadString(int count) { }

	// RVA: 0x13A2D10 Offset: 0x13A1310 VA: 0x1813A2D10
	public int ReadVlqNumber() { }

	// RVA: 0x13A2C60 Offset: 0x13A1260 VA: 0x1813A2C60
	public long ReadVlqLongNumber() { }

	// RVA: 0x13A2110 Offset: 0x13A0710 VA: 0x1813A2110
	public uint Read3ByteDword() { }

	// RVA: 0x13A2430 Offset: 0x13A0A30 VA: 0x1813A2430
	private byte[] ReadBytesInternal(int count) { }

	// RVA: 0x13A25A0 Offset: 0x13A0BA0 VA: 0x1813A25A0
	private byte[] ReadBytesWithBuffering(int count) { }

	// RVA: 0x13A2350 Offset: 0x13A0950 VA: 0x1813A2350
	private byte[] ReadBytesFromBuffer(int count) { }

	// RVA: 0x13A2740 Offset: 0x13A0D40 VA: 0x1813A2740
	private byte[] ReadBytesWithoutBuffering(int count) { }

	// RVA: 0x13A1D90 Offset: 0x13A0390 VA: 0x1813A1D90
	private bool EnsureBufferIsReadyForReading() { }

	// RVA: 0x13A1ED0 Offset: 0x13A04D0 VA: 0x1813A1ED0
	private void PrepareBuffer() { }

	// RVA: 0x13A1D80 Offset: 0x13A0380 VA: 0x1813A1D80 Slot: 4
	public void Dispose() { }

	// RVA: 0x13A1D80 Offset: 0x13A0380 VA: 0x1813A1D80
	private void Dispose(bool disposing) { }

	// RVA: 0x13A2E00 Offset: 0x13A1400 VA: 0x1813A2E00
	private static void .cctor() { }

}

private sealed class MidiReader.<>c // TypeDefIndex: 7588
{	// Fields
	public static readonly MidiReader.<>c <>9; // 0x0
	public static Func<byte[], IEnumerable<byte>> <>9__22_0; // 0x8

	// Methods

	// RVA: 0x13AAE50 Offset: 0x13A9450 VA: 0x1813AAE50
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7B4F90 Offset: 0x7B3590 VA: 0x1807B4F90
	internal IEnumerable<byte> <ReadBytes>b__22_0(byte[] bytes) { }

}

