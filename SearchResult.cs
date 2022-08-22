internal sealed class SearchResult // TypeDefIndex: 631
{	// Fields
	private string fullPath; // 0x10
	private string userPath; // 0x18
	private Win32Native.WIN32_FIND_DATA findData; // 0x20

	// Properties
	internal string UserPath { get; }
	internal Win32Native.WIN32_FIND_DATA FindData { get; }

	// Methods

	// RVA: 0x14730A0 Offset: 0x14716A0 VA: 0x1814730A0
	internal void .ctor(string fullPath, string userPath, Win32Native.WIN32_FIND_DATA findData) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal string get_UserPath() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal Win32Native.WIN32_FIND_DATA get_FindData() { }

}

