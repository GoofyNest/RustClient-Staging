public sealed class RNGCryptoServiceProvider : RandomNumberGenerator // TypeDefIndex: 1008
{	// Fields
	private static object _lock; // 0x0
	private IntPtr _handle; // 0x10

	// Methods

	// RVA: 0x1707440 Offset: 0x1705A40 VA: 0x181707440
	private static void .cctor() { }

	// RVA: 0x17074C0 Offset: 0x1705AC0 VA: 0x1817074C0
	public void .ctor() { }

	// RVA: 0x17070D0 Offset: 0x17056D0 VA: 0x1817070D0
	private void Check() { }

	// RVA: 0x1452460 Offset: 0x1450A60 VA: 0x181452460
	private static bool RngOpen() { }

	// RVA: 0x1707430 Offset: 0x1705A30 VA: 0x181707430
	private static IntPtr RngInitialize(byte[] seed) { }

	// RVA: 0x1707420 Offset: 0x1705A20 VA: 0x181707420
	private static IntPtr RngGetBytes(IntPtr handle, byte[] data) { }

	// RVA: 0x1707410 Offset: 0x1705A10 VA: 0x181707410
	private static void RngClose(IntPtr handle) { }

	// RVA: 0x1707240 Offset: 0x1705840 VA: 0x181707240 Slot: 6
	public override void GetBytes(byte[] data) { }

	// RVA: 0x1707160 Offset: 0x1705760 VA: 0x181707160 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x86CDD0 Offset: 0x86B3D0 VA: 0x18086CDD0 Slot: 5
	protected override void Dispose(bool disposing) { }

}

