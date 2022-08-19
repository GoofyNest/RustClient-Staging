internal class ISteamNetworking : SteamInterface // TypeDefIndex: 5122
{	// Methods

	// RVA: 0x1285ED0 Offset: 0x12844D0 VA: 0x181285ED0
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x128D340 Offset: 0x128B940 VA: 0x18128D340
	internal static extern IntPtr SteamAPI_SteamNetworking_v006() { }

	// RVA: 0x128D340 Offset: 0x128B940 VA: 0x18128D340 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x128D2D0 Offset: 0x128B8D0 VA: 0x18128D2D0
	internal static extern IntPtr SteamAPI_SteamGameServerNetworking_v006() { }

	// RVA: 0x128D2D0 Offset: 0x128B8D0 VA: 0x18128D2D0 Slot: 5
	public override IntPtr GetServerInterfacePointer() { }

}

