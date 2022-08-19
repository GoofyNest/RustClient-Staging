internal class Win32NetworkInterface // TypeDefIndex: 3082
{	// Fields
	private static Win32_FIXED_INFO fixedInfo; // 0x0
	private static bool initialized; // 0x58

	// Properties
	public static Win32_FIXED_INFO FixedInfo { get; }

	// Methods

	// RVA: 0x13498A0 Offset: 0x1347EA0 VA: 0x1813498A0
	private static extern int GetNetworkParams(IntPtr ptr, ref int size) { }

	// RVA: 0x1349930 Offset: 0x1347F30 VA: 0x181349930
	public static Win32_FIXED_INFO get_FixedInfo() { }

}

