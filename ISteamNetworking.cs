internal class ISteamNetworking : SteamInterface // TypeDefIndex: 5122
{	// Methods

	// RVA: 0x1286830 Offset: 0x1284E30 VA: 0x181286830
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x128DCA0 Offset: 0x128C2A0 VA: 0x18128DCA0
	internal static extern IntPtr SteamAPI_SteamNetworking_v006() { }

	// RVA: 0x128DCA0 Offset: 0x128C2A0 VA: 0x18128DCA0 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x128DC30 Offset: 0x128C230 VA: 0x18128DC30
	internal static extern IntPtr SteamAPI_SteamGameServerNetworking_v006() { }

	// RVA: 0x128DC30 Offset: 0x128C230 VA: 0x18128DC30 Slot: 5
	public override IntPtr GetServerInterfacePointer() { }

}

