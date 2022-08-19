internal class ISteamScreenshots : SteamInterface // TypeDefIndex: 5129
{	// Methods

	// RVA: 0xDD8440 Offset: 0xDD6A40 VA: 0x180DD8440
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDD8630 Offset: 0xDD6C30 VA: 0x180DD8630
	internal static extern IntPtr SteamAPI_SteamScreenshots_v003() { }

	// RVA: 0xDD8630 Offset: 0xDD6C30 VA: 0x180DD8630 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0xDD8720 Offset: 0xDD6D20 VA: 0x180DD8720
	private static extern void _TriggerScreenshot(IntPtr self) { }

	// RVA: 0xDD86A0 Offset: 0xDD6CA0 VA: 0x180DD86A0
	internal void TriggerScreenshot() { }

}

