internal class ISteamNetworking : SteamInterface // TypeDefIndex: 5122
{	// Methods

	// RVA: 0x1286190 Offset: 0x1284790 VA: 0x181286190
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x128D600 Offset: 0x128BC00 VA: 0x18128D600
	internal static extern IntPtr SteamAPI_SteamNetworking_v006() { }

	// RVA: 0x128D600 Offset: 0x128BC00 VA: 0x18128D600 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x128D590 Offset: 0x128BB90 VA: 0x18128D590
	internal static extern IntPtr SteamAPI_SteamGameServerNetworking_v006() { }

	// RVA: 0x128D590 Offset: 0x128BB90 VA: 0x18128D590 Slot: 5
	public override IntPtr GetServerInterfacePointer() { }

}

