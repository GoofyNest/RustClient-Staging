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

	// RVA: 0x21D95B0 Offset: 0x21D7BB0 VA: 0x1821D95B0
	public void .ctor() { }

	// RVA: 0x21D9290 Offset: 0x21D7890 VA: 0x1821D9290
	public int InitializeInflate(bool expectRfc1950Header) { }

	// RVA: 0x21D9370 Offset: 0x21D7970 VA: 0x1821D9370
	public int InitializeInflate(int windowBits, bool expectRfc1950Header) { }

	// RVA: 0x21D90B0 Offset: 0x21D76B0 VA: 0x1821D90B0
	public int Inflate(FlushType flush) { }

	// RVA: 0x21D8FD0 Offset: 0x21D75D0 VA: 0x1821D8FD0
	public int EndInflate() { }

	// RVA: 0x21D9130 Offset: 0x21D7730 VA: 0x1821D9130
	public int InitializeDeflate(CompressionLevel level, bool wantRfc1950Header) { }

	// RVA: 0x21D9450 Offset: 0x21D7A50 VA: 0x1821D9450
	private int _InternalInitializeDeflate(bool wantRfc1950Header) { }

	// RVA: 0x21D8ED0 Offset: 0x21D74D0 VA: 0x1821D8ED0
	public int Deflate(FlushType flush) { }

	// RVA: 0x21D8F50 Offset: 0x21D7550 VA: 0x1821D8F50
	public int EndDeflate() { }

	// RVA: 0x21D95D0 Offset: 0x21D7BD0 VA: 0x1821D95D0
	internal void flush_pending() { }

	// RVA: 0x21D9780 Offset: 0x21D7D80 VA: 0x1821D9780
	internal int read_buf(byte[] buf, int start, int size) { }

}

