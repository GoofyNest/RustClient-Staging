internal class ISteamNetworkingUtils : SteamInterface // TypeDefIndex: 5124
{	// Methods

	// RVA: 0xDD8700 Offset: 0xDD6D00 VA: 0x180DD8700
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDD7ED0 Offset: 0xDD64D0 VA: 0x180DD7ED0
	internal static extern IntPtr SteamAPI_SteamNetworkingUtils_SteamAPI_v004() { }

	// RVA: 0xDD7ED0 Offset: 0xDD64D0 VA: 0x180DD7ED0 Slot: 6
	public override IntPtr GetGlobalInterfacePointer() { }

	// RVA: 0xDD8310 Offset: 0xDD6910 VA: 0x180DD8310
	private static extern NetMsg* _AllocateMessage(IntPtr self, int cbAllocateBuffer) { }

	// RVA: 0xDD7D70 Offset: 0xDD6370 VA: 0x180DD7D70
	internal NetMsg* AllocateMessage(int cbAllocateBuffer) { }

	// RVA: 0xDD8470 Offset: 0xDD6A70 VA: 0x180DD8470
	private static extern void _InitRelayNetworkAccess(IntPtr self) { }

	// RVA: 0xDD7F40 Offset: 0xDD6540 VA: 0x180DD7F40
	internal void InitRelayNetworkAccess() { }

	// RVA: 0xDD85B0 Offset: 0xDD6BB0 VA: 0x180DD85B0
	private static extern void _SetDebugOutputFunction(IntPtr self, NetDebugOutput eDetailLevel, NetDebugFunc pfnFunc) { }

	// RVA: 0xDD8090 Offset: 0xDD6690 VA: 0x180DD8090
	internal void SetDebugOutputFunction(NetDebugOutput eDetailLevel, NetDebugFunc pfnFunc) { }

	// RVA: 0xDD84F0 Offset: 0xDD6AF0 VA: 0x180DD84F0
	private static extern bool _SetConfigValue(IntPtr self, NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, NetConfigType eDataType, IntPtr pArg) { }

	// RVA: 0xDD7FC0 Offset: 0xDD65C0 VA: 0x180DD7FC0
	internal bool SetConfigValue(NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, NetConfigType eDataType, IntPtr pArg) { }

	// RVA: 0xDD83A0 Offset: 0xDD69A0 VA: 0x180DD83A0
	private static extern NetConfigResult _GetConfigValue(IntPtr self, NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, ref NetConfigType pOutDataType, IntPtr pResult, ref UIntPtr cbResult) { }

	// RVA: 0xDD7E00 Offset: 0xDD6400 VA: 0x180DD7E00
	internal NetConfigResult GetConfigValue(NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, ref NetConfigType pOutDataType, IntPtr pResult, ref UIntPtr cbResult) { }

	// RVA: 0xDD8650 Offset: 0xDD6C50 VA: 0x180DD8650
	private static extern void _SteamNetworkingIdentity_ToString(IntPtr self, ref NetIdentity identity, IntPtr buf, uint cbBuf) { }

	// RVA: 0xDD8130 Offset: 0xDD6730 VA: 0x180DD8130
	internal void SteamNetworkingIdentity_ToString(ref NetIdentity identity, out string buf) { }

}

