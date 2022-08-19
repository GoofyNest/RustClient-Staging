internal class ISteamParentalSettings : SteamInterface // TypeDefIndex: 5125
{	// Methods

	// RVA: 0xDD8440 Offset: 0xDD6A40 VA: 0x180DD8440
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDD8470 Offset: 0xDD6A70 VA: 0x180DD8470
	internal static extern IntPtr SteamAPI_SteamParentalSettings_v001() { }

	// RVA: 0xDD8470 Offset: 0xDD6A70 VA: 0x180DD8470 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

}

