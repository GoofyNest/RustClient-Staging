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

	// RVA: 0x21D8C90 Offset: 0x21D7290 VA: 0x1821D8C90
	public void .ctor() { }

	// RVA: 0x21D8970 Offset: 0x21D6F70 VA: 0x1821D8970
	public int InitializeInflate(bool expectRfc1950Header) { }

	// RVA: 0x21D8A50 Offset: 0x21D7050 VA: 0x1821D8A50
	public int InitializeInflate(int windowBits, bool expectRfc1950Header) { }

	// RVA: 0x21D8790 Offset: 0x21D6D90 VA: 0x1821D8790
	public int Inflate(FlushType flush) { }

	// RVA: 0x21D86B0 Offset: 0x21D6CB0 VA: 0x1821D86B0
	public int EndInflate() { }

	// RVA: 0x21D8810 Offset: 0x21D6E10 VA: 0x1821D8810
	public int InitializeDeflate(CompressionLevel level, bool wantRfc1950Header) { }

	// RVA: 0x21D8B30 Offset: 0x21D7130 VA: 0x1821D8B30
	private int _InternalInitializeDeflate(bool wantRfc1950Header) { }

	// RVA: 0x21D85B0 Offset: 0x21D6BB0 VA: 0x1821D85B0
	public int Deflate(FlushType flush) { }

	// RVA: 0x21D8630 Offset: 0x21D6C30 VA: 0x1821D8630
	public int EndDeflate() { }

	// RVA: 0x21D8CB0 Offset: 0x21D72B0 VA: 0x1821D8CB0
	internal void flush_pending() { }

	// RVA: 0x21D8E60 Offset: 0x21D7460 VA: 0x1821D8E60
	internal int read_buf(byte[] buf, int start, int size) { }

}

