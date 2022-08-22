internal static class Win32Native // TypeDefIndex: 111
{	// Methods

	// RVA: 0x1652730 Offset: 0x1650D30 VA: 0x181652730
	public static string GetMessage(int hr) { }

	// RVA: 0x1652780 Offset: 0x1650D80 VA: 0x181652780
	public static int MakeHRFromErrorCode(int errorCode) { }

	// RVA: 0x16526B0 Offset: 0x1650CB0 VA: 0x1816526B0
	internal static extern uint GetCurrentProcessId() { }

}

internal class Win32Native.WIN32_FIND_DATA // TypeDefIndex: 112
{	// Fields
	internal int dwFileAttributes; // 0x10
	internal string cFileName; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

