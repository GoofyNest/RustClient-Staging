internal class Win32NetworkInterface // TypeDefIndex: 3082
{	// Fields
	private static Win32_FIXED_INFO fixedInfo; // 0x0
	private static bool initialized; // 0x58

	// Properties
	public static Win32_FIXED_INFO FixedInfo { get; }

	// Methods

	// RVA: 0x1349B60 Offset: 0x1348160 VA: 0x181349B60
	private static extern int GetNetworkParams(IntPtr ptr, ref int size) { }

	// RVA: 0x1349BF0 Offset: 0x13481F0 VA: 0x181349BF0
	public static Win32_FIXED_INFO get_FixedInfo() { }

}

