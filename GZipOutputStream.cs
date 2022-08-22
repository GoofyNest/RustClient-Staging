internal class GZipOutputStream : DeflaterOutputStream // TypeDefIndex: 5655
{	// Fields
	protected Crc32 crc; // 0x50

	// Methods

	// RVA: 0x2303D80 Offset: 0x2302380 VA: 0x182303D80
	public void .ctor(Stream baseOutputStream) { }

	// RVA: 0x2303B50 Offset: 0x2302150 VA: 0x182303B50
	public void .ctor(Stream baseOutputStream, int size) { }

	// RVA: 0x2303880 Offset: 0x2301E80 VA: 0x182303880
	private void WriteHeader() { }

	// RVA: 0x2303AD0 Offset: 0x23020D0 VA: 0x182303AD0 Slot: 29
	public override void Write(byte[] buf, int off, int len) { }

	// RVA: 0x2303660 Offset: 0x2301C60 VA: 0x182303660 Slot: 16
	public override void Close() { }

	// RVA: 0x23036B0 Offset: 0x2301CB0 VA: 0x1823036B0 Slot: 31
	public override void Finish() { }

}

