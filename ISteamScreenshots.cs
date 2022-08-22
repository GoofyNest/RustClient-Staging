internal class ISteamScreenshots : SteamInterface // TypeDefIndex: 5129
{	// Methods

	// RVA: 0xDD91B0 Offset: 0xDD77B0 VA: 0x180DD91B0
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDD93A0 Offset: 0xDD79A0 VA: 0x180DD93A0
	internal static extern IntPtr SteamAPI_SteamScreenshots_v003() { }

	// RVA: 0xDD93A0 Offset: 0xDD79A0 VA: 0x180DD93A0 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0xDD9490 Offset: 0xDD7A90 VA: 0x180DD9490
	private static extern void _TriggerScreenshot(IntPtr self) { }

	// RVA: 0xDD9410 Offset: 0xDD7A10 VA: 0x180DD9410
	internal void TriggerScreenshot() { }

}

