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

	// RVA: 0x21D8D90 Offset: 0x21D7390 VA: 0x1821D8D90
	public void .ctor() { }

	// RVA: 0x21D8A70 Offset: 0x21D7070 VA: 0x1821D8A70
	public int InitializeInflate(bool expectRfc1950Header) { }

	// RVA: 0x21D8B50 Offset: 0x21D7150 VA: 0x1821D8B50
	public int InitializeInflate(int windowBits, bool expectRfc1950Header) { }

	// RVA: 0x21D8890 Offset: 0x21D6E90 VA: 0x1821D8890
	public int Inflate(FlushType flush) { }

	// RVA: 0x21D87B0 Offset: 0x21D6DB0 VA: 0x1821D87B0
	public int EndInflate() { }

	// RVA: 0x21D8910 Offset: 0x21D6F10 VA: 0x1821D8910
	public int InitializeDeflate(CompressionLevel level, bool wantRfc1950Header) { }

	// RVA: 0x21D8C30 Offset: 0x21D7230 VA: 0x1821D8C30
	private int _InternalInitializeDeflate(bool wantRfc1950Header) { }

	// RVA: 0x21D86B0 Offset: 0x21D6CB0 VA: 0x1821D86B0
	public int Deflate(FlushType flush) { }

	// RVA: 0x21D8730 Offset: 0x21D6D30 VA: 0x1821D8730
	public int EndDeflate() { }

	// RVA: 0x21D8DB0 Offset: 0x21D73B0 VA: 0x1821D8DB0
	internal void flush_pending() { }

	// RVA: 0x21D8F60 Offset: 0x21D7560 VA: 0x1821D8F60
	internal int read_buf(byte[] buf, int start, int size) { }

}

