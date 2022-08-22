public sealed class ZlibCodec // TypeDefIndex: 6966
{	// Fields
	public byte[] InputBuffer; // 0x10
	public int NextIn; // 0x18
	public int AvailableBytesIn; // 0x1C
	public long TotalBytesIn; // 0x20
	public byte[] OutputBuffer; // 0x28
	public int NextOut; // 0x30
	public int AvailableBytesOut; // 0x34
	public long TotalBytesOut; // 0x38
	public string Message; // 0x40
	internal DeflateManager dstate; // 0x48
	internal InflateManager istate; // 0x50
	internal uint _Adler32; // 0x58
	public CompressionLevel CompressLevel; // 0x5C
	public int WindowBits; // 0x60
	public CompressionStrategy Strategy; // 0x64

	// Methods

	// RVA: 0x21D8AD0 Offset: 0x21D70D0 VA: 0x1821D8AD0
	public void .ctor() { }

	// RVA: 0x21D87B0 Offset: 0x21D6DB0 VA: 0x1821D87B0
	public int InitializeInflate(bool expectRfc1950Header) { }

	// RVA: 0x21D8890 Offset: 0x21D6E90 VA: 0x1821D8890
	public int InitializeInflate(int windowBits, bool expectRfc1950Header) { }

	// RVA: 0x21D85D0 Offset: 0x21D6BD0 VA: 0x1821D85D0
	public int Inflate(FlushType flush) { }

	// RVA: 0x21D84F0 Offset: 0x21D6AF0 VA: 0x1821D84F0
	public int EndInflate() { }

	// RVA: 0x21D8650 Offset: 0x21D6C50 VA: 0x1821D8650
	public int InitializeDeflate(CompressionLevel level, bool wantRfc1950Header) { }

	// RVA: 0x21D8970 Offset: 0x21D6F70 VA: 0x1821D8970
	private int _InternalInitializeDeflate(bool wantRfc1950Header) { }

	// RVA: 0x21D83F0 Offset: 0x21D69F0 VA: 0x1821D83F0
	public int Deflate(FlushType flush) { }

	// RVA: 0x21D8470 Offset: 0x21D6A70 VA: 0x1821D8470
	public int EndDeflate() { }

	// RVA: 0x21D8AF0 Offset: 0x21D70F0 VA: 0x1821D8AF0
	internal void flush_pending() { }

	// RVA: 0x21D8CA0 Offset: 0x21D72A0 VA: 0x1821D8CA0
	internal int read_buf(byte[] buf, int start, int size) { }

}

