public static class Os // TypeDefIndex: 5607
{
	public static void OpenFolder(string folder) { }

	public static bool StartProcess(string executable, string arguments) { }

	private static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, ref Os.SECURITY_ATTRIBUTES lpProcessAttributes, ref Os.SECURITY_ATTRIBUTES lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, in Os.STARTUPINFO lpStartupInfo, out Os.PROCESS_INFORMATION lpProcessInformation) { }

}

internal struct Os.PROCESS_INFORMATION // TypeDefIndex: 5608
{	public IntPtr hProcess; // 0x0
	public IntPtr hThread; // 0x8
	public int dwProcessId; // 0x10
	public int dwThreadId; // 0x14

}

private struct Os.STARTUPINFO // TypeDefIndex: 5609
{	public int cb; // 0x0
	public IntPtr lpReserved; // 0x8
	public IntPtr lpDesktop; // 0x10
	public IntPtr lpTitle; // 0x18
	public int dwX; // 0x20
	public int dwY; // 0x24
	public int dwXSize; // 0x28
	public int dwYSize; // 0x2C
	public int dwXCountChars; // 0x30
	public int dwYCountChars; // 0x34
	public int dwFillAttribute; // 0x38
	public int dwFlags; // 0x3C
	public short wShowWindow; // 0x40
	public short cbReserved2; // 0x42
	public IntPtr lpReserved2; // 0x48
	public IntPtr hStdInput; // 0x50
	public IntPtr hStdOutput; // 0x58
	public IntPtr hStdError; // 0x60

}

public struct Os.SECURITY_ATTRIBUTES // TypeDefIndex: 5610
{	public int nLength; // 0x0
	public IntPtr lpSecurityDescriptor; // 0x8
	public int bInheritHandle; // 0x10

}

