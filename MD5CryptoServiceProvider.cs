public sealed class MD5CryptoServiceProvider : MD5 // TypeDefIndex: 1006
{	// Fields
	private uint[] _H; // 0x28
	private uint[] buff; // 0x30
	private ulong count; // 0x38
	private byte[] _ProcessingBuffer; // 0x40
	private int _ProcessingBufferCount; // 0x48
	private static readonly uint[] K; // 0x0

	// Methods

	// RVA: 0x1704C50 Offset: 0x1703250 VA: 0x181704C50
	public void .ctor() { }

	// RVA: 0x17032F0 Offset: 0x17018F0 VA: 0x1817032F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1703250 Offset: 0x1701850 VA: 0x181703250 Slot: 15
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1703390 Offset: 0x1701990 VA: 0x181703390 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x17034B0 Offset: 0x1701AB0 VA: 0x1817034B0 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x17035B0 Offset: 0x1701BB0 VA: 0x1817035B0 Slot: 16
	public override void Initialize() { }

	// RVA: 0x1703660 Offset: 0x1701C60 VA: 0x181703660
	private void ProcessBlock(byte[] inputBuffer, int inputOffset) { }

	// RVA: 0x1704A40 Offset: 0x1703040 VA: 0x181704A40
	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x17030E0 Offset: 0x17016E0 VA: 0x1817030E0
	internal void AddLength(ulong length, byte[] buffer, int position) { }

	// RVA: 0x1704BE0 Offset: 0x17031E0 VA: 0x181704BE0
	private static void .cctor() { }

}

