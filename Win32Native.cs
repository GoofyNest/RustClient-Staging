internal static class Win32Native // TypeDefIndex: 111
{	// Methods

	// RVA: 0x163FA50 Offset: 0x163E050 VA: 0x18163FA50
	public static string GetMessage(int hr) { }

	// RVA: 0x163FAA0 Offset: 0x163E0A0 VA: 0x18163FAA0
	public static int MakeHRFromErrorCode(int errorCode) { }

	// RVA: 0x163F9D0 Offset: 0x163DFD0 VA: 0x18163F9D0
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

