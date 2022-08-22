internal class ISteamParentalSettings : SteamInterface // TypeDefIndex: 5125
{	// Methods

	// RVA: 0xDD8700 Offset: 0xDD6D00 VA: 0x180DD8700
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDD8730 Offset: 0xDD6D30 VA: 0x180DD8730
	internal static extern IntPtr SteamAPI_SteamParentalSettings_v001() { }

	// RVA: 0xDD8730 Offset: 0xDD6D30 VA: 0x180DD8730 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

}

