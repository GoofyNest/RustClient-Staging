internal static class Win32Native // TypeDefIndex: 111
{	// Methods

	// RVA: 0x1652470 Offset: 0x1650A70 VA: 0x181652470
	public static string GetMessage(int hr) { }

	// RVA: 0x16524C0 Offset: 0x1650AC0 VA: 0x1816524C0
	public static int MakeHRFromErrorCode(int errorCode) { }

	// RVA: 0x16523F0 Offset: 0x16509F0 VA: 0x1816523F0
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

