public sealed class RNGCryptoServiceProvider : RandomNumberGenerator // TypeDefIndex: 1008
{	// Fields
	private static object _lock; // 0x0
	private IntPtr _handle; // 0x10

	// Methods

	// RVA: 0x1709590 Offset: 0x1707B90 VA: 0x181709590
	private static void .cctor() { }

	// RVA: 0x1709610 Offset: 0x1707C10 VA: 0x181709610
	public void .ctor() { }

	// RVA: 0x1709220 Offset: 0x1707820 VA: 0x181709220
	private void Check() { }

	// RVA: 0x14530D0 Offset: 0x14516D0 VA: 0x1814530D0
	private static bool RngOpen() { }

	// RVA: 0x1709580 Offset: 0x1707B80 VA: 0x181709580
	private static IntPtr RngInitialize(byte[] seed) { }

	// RVA: 0x1709570 Offset: 0x1707B70 VA: 0x181709570
	private static IntPtr RngGetBytes(IntPtr handle, byte[] data) { }

	// RVA: 0x1709560 Offset: 0x1707B60 VA: 0x181709560
	private static void RngClose(IntPtr handle) { }

	// RVA: 0x1709390 Offset: 0x1707990 VA: 0x181709390 Slot: 6
	public override void GetBytes(byte[] data) { }

	// RVA: 0x17092B0 Offset: 0x17078B0 VA: 0x1817092B0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x889980 Offset: 0x887F80 VA: 0x180889980 Slot: 5
	protected override void Dispose(bool disposing) { }

}

