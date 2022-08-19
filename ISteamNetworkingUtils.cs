internal class ISteamNetworkingUtils : SteamInterface // TypeDefIndex: 5124
{	// Methods

	// RVA: 0xDD8440 Offset: 0xDD6A40 VA: 0x180DD8440
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDD7C10 Offset: 0xDD6210 VA: 0x180DD7C10
	internal static extern IntPtr SteamAPI_SteamNetworkingUtils_SteamAPI_v004() { }

	// RVA: 0xDD7C10 Offset: 0xDD6210 VA: 0x180DD7C10 Slot: 6
	public override IntPtr GetGlobalInterfacePointer() { }

	// RVA: 0xDD8050 Offset: 0xDD6650 VA: 0x180DD8050
	private static extern NetMsg* _AllocateMessage(IntPtr self, int cbAllocateBuffer) { }

	// RVA: 0xDD7AB0 Offset: 0xDD60B0 VA: 0x180DD7AB0
	internal NetMsg* AllocateMessage(int cbAllocateBuffer) { }

	// RVA: 0xDD81B0 Offset: 0xDD67B0 VA: 0x180DD81B0
	private static extern void _InitRelayNetworkAccess(IntPtr self) { }

	// RVA: 0xDD7C80 Offset: 0xDD6280 VA: 0x180DD7C80
	internal void InitRelayNetworkAccess() { }

	// RVA: 0xDD82F0 Offset: 0xDD68F0 VA: 0x180DD82F0
	private static extern void _SetDebugOutputFunction(IntPtr self, NetDebugOutput eDetailLevel, NetDebugFunc pfnFunc) { }

	// RVA: 0xDD7DD0 Offset: 0xDD63D0 VA: 0x180DD7DD0
	internal void SetDebugOutputFunction(NetDebugOutput eDetailLevel, NetDebugFunc pfnFunc) { }

	// RVA: 0xDD8230 Offset: 0xDD6830 VA: 0x180DD8230
	private static extern bool _SetConfigValue(IntPtr self, NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, NetConfigType eDataType, IntPtr pArg) { }

	// RVA: 0xDD7D00 Offset: 0xDD6300 VA: 0x180DD7D00
	internal bool SetConfigValue(NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, NetConfigType eDataType, IntPtr pArg) { }

	// RVA: 0xDD80E0 Offset: 0xDD66E0 VA: 0x180DD80E0
	private static extern NetConfigResult _GetConfigValue(IntPtr self, NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, ref NetConfigType pOutDataType, IntPtr pResult, ref UIntPtr cbResult) { }

	// RVA: 0xDD7B40 Offset: 0xDD6140 VA: 0x180DD7B40
	internal NetConfigResult GetConfigValue(NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, ref NetConfigType pOutDataType, IntPtr pResult, ref UIntPtr cbResult) { }

	// RVA: 0xDD8390 Offset: 0xDD6990 VA: 0x180DD8390
	private static extern void _SteamNetworkingIdentity_ToString(IntPtr self, ref NetIdentity identity, IntPtr buf, uint cbBuf) { }

	// RVA: 0xDD7E70 Offset: 0xDD6470 VA: 0x180DD7E70
	internal void SteamNetworkingIdentity_ToString(ref NetIdentity identity, out string buf) { }

}

