public sealed class RNGCryptoServiceProvider : RandomNumberGenerator // TypeDefIndex: 1008
{	// Fields
	private static object _lock; // 0x0
	private IntPtr _handle; // 0x10

	// Methods

	// RVA: 0x1709850 Offset: 0x1707E50 VA: 0x181709850
	private static void .cctor() { }

	// RVA: 0x17098D0 Offset: 0x1707ED0 VA: 0x1817098D0
	public void .ctor() { }

	// RVA: 0x17094E0 Offset: 0x1707AE0 VA: 0x1817094E0
	private void Check() { }

	// RVA: 0x1453390 Offset: 0x1451990 VA: 0x181453390
	private static bool RngOpen() { }

	// RVA: 0x1709840 Offset: 0x1707E40 VA: 0x181709840
	private static IntPtr RngInitialize(byte[] seed) { }

	// RVA: 0x1709830 Offset: 0x1707E30 VA: 0x181709830
	private static IntPtr RngGetBytes(IntPtr handle, byte[] data) { }

	// RVA: 0x1709820 Offset: 0x1707E20 VA: 0x181709820
	private static void RngClose(IntPtr handle) { }

	// RVA: 0x1709650 Offset: 0x1707C50 VA: 0x181709650 Slot: 6
	public override void GetBytes(byte[] data) { }

	// RVA: 0x1709570 Offset: 0x1707B70 VA: 0x181709570 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x889A90 Offset: 0x888090 VA: 0x180889A90 Slot: 5
	protected override void Dispose(bool disposing) { }

}

