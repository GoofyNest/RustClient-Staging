public sealed class MD5CryptoServiceProvider : MD5 // TypeDefIndex: 1006
{	// Fields
	private uint[] _H; // 0x28
	private uint[] buff; // 0x30
	private ulong count; // 0x38
	private byte[] _ProcessingBuffer; // 0x40
	private int _ProcessingBufferCount; // 0x48
	private static readonly uint[] K; // 0x0

	// Methods

	// RVA: 0x1702B00 Offset: 0x1701100 VA: 0x181702B00
	public void .ctor() { }

	// RVA: 0x17011A0 Offset: 0x16FF7A0 VA: 0x1817011A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1701100 Offset: 0x16FF700 VA: 0x181701100 Slot: 15
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1701240 Offset: 0x16FF840 VA: 0x181701240 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x1701360 Offset: 0x16FF960 VA: 0x181701360 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x1701460 Offset: 0x16FFA60 VA: 0x181701460 Slot: 16
	public override void Initialize() { }

	// RVA: 0x1701510 Offset: 0x16FFB10 VA: 0x181701510
	private void ProcessBlock(byte[] inputBuffer, int inputOffset) { }

	// RVA: 0x17028F0 Offset: 0x1700EF0 VA: 0x1817028F0
	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1700F90 Offset: 0x16FF590 VA: 0x181700F90
	internal void AddLength(ulong length, byte[] buffer, int position) { }

	// RVA: 0x1702A90 Offset: 0x1701090 VA: 0x181702A90
	private static void .cctor() { }

}

