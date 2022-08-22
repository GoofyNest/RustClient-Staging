public sealed class MD5CryptoServiceProvider : MD5 // TypeDefIndex: 1006
{	// Fields
	private uint[] _H; // 0x28
	private uint[] buff; // 0x30
	private ulong count; // 0x38
	private byte[] _ProcessingBuffer; // 0x40
	private int _ProcessingBufferCount; // 0x48
	private static readonly uint[] K; // 0x0

	// Methods

	// RVA: 0x1704F10 Offset: 0x1703510 VA: 0x181704F10
	public void .ctor() { }

	// RVA: 0x17035B0 Offset: 0x1701BB0 VA: 0x1817035B0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1703510 Offset: 0x1701B10 VA: 0x181703510 Slot: 15
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1703650 Offset: 0x1701C50 VA: 0x181703650 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x1703770 Offset: 0x1701D70 VA: 0x181703770 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x1703870 Offset: 0x1701E70 VA: 0x181703870 Slot: 16
	public override void Initialize() { }

	// RVA: 0x1703920 Offset: 0x1701F20 VA: 0x181703920
	private void ProcessBlock(byte[] inputBuffer, int inputOffset) { }

	// RVA: 0x1704D00 Offset: 0x1703300 VA: 0x181704D00
	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x17033A0 Offset: 0x17019A0 VA: 0x1817033A0
	internal void AddLength(ulong length, byte[] buffer, int position) { }

	// RVA: 0x1704EA0 Offset: 0x17034A0 VA: 0x181704EA0
	private static void .cctor() { }

}

