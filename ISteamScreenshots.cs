internal class ISteamScreenshots : SteamInterface // TypeDefIndex: 5129
{	// Methods

	// RVA: 0xDD8700 Offset: 0xDD6D00 VA: 0x180DD8700
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDD88F0 Offset: 0xDD6EF0 VA: 0x180DD88F0
	internal static extern IntPtr SteamAPI_SteamScreenshots_v003() { }

	// RVA: 0xDD88F0 Offset: 0xDD6EF0 VA: 0x180DD88F0 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0xDD89E0 Offset: 0xDD6FE0 VA: 0x180DD89E0
	private static extern void _TriggerScreenshot(IntPtr self) { }

	// RVA: 0xDD8960 Offset: 0xDD6F60 VA: 0x180DD8960
	internal void TriggerScreenshot() { }

}

