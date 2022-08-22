internal class ISteamNetworkingUtils : SteamInterface // TypeDefIndex: 5124
{	// Methods

	// RVA: 0xDD91B0 Offset: 0xDD77B0 VA: 0x180DD91B0
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDD8980 Offset: 0xDD6F80 VA: 0x180DD8980
	internal static extern IntPtr SteamAPI_SteamNetworkingUtils_SteamAPI_v004() { }

	// RVA: 0xDD8980 Offset: 0xDD6F80 VA: 0x180DD8980 Slot: 6
	public override IntPtr GetGlobalInterfacePointer() { }

	// RVA: 0xDD8DC0 Offset: 0xDD73C0 VA: 0x180DD8DC0
	private static extern NetMsg* _AllocateMessage(IntPtr self, int cbAllocateBuffer) { }

	// RVA: 0xDD8820 Offset: 0xDD6E20 VA: 0x180DD8820
	internal NetMsg* AllocateMessage(int cbAllocateBuffer) { }

	// RVA: 0xDD8F20 Offset: 0xDD7520 VA: 0x180DD8F20
	private static extern void _InitRelayNetworkAccess(IntPtr self) { }

	// RVA: 0xDD89F0 Offset: 0xDD6FF0 VA: 0x180DD89F0
	internal void InitRelayNetworkAccess() { }

	// RVA: 0xDD9060 Offset: 0xDD7660 VA: 0x180DD9060
	private static extern void _SetDebugOutputFunction(IntPtr self, NetDebugOutput eDetailLevel, NetDebugFunc pfnFunc) { }

	// RVA: 0xDD8B40 Offset: 0xDD7140 VA: 0x180DD8B40
	internal void SetDebugOutputFunction(NetDebugOutput eDetailLevel, NetDebugFunc pfnFunc) { }

	// RVA: 0xDD8FA0 Offset: 0xDD75A0 VA: 0x180DD8FA0
	private static extern bool _SetConfigValue(IntPtr self, NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, NetConfigType eDataType, IntPtr pArg) { }

	// RVA: 0xDD8A70 Offset: 0xDD7070 VA: 0x180DD8A70
	internal bool SetConfigValue(NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, NetConfigType eDataType, IntPtr pArg) { }

	// RVA: 0xDD8E50 Offset: 0xDD7450 VA: 0x180DD8E50
	private static extern NetConfigResult _GetConfigValue(IntPtr self, NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, ref NetConfigType pOutDataType, IntPtr pResult, ref UIntPtr cbResult) { }

	// RVA: 0xDD88B0 Offset: 0xDD6EB0 VA: 0x180DD88B0
	internal NetConfigResult GetConfigValue(NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, ref NetConfigType pOutDataType, IntPtr pResult, ref UIntPtr cbResult) { }

	// RVA: 0xDD9100 Offset: 0xDD7700 VA: 0x180DD9100
	private static extern void _SteamNetworkingIdentity_ToString(IntPtr self, ref NetIdentity identity, IntPtr buf, uint cbBuf) { }

	// RVA: 0xDD8BE0 Offset: 0xDD71E0 VA: 0x180DD8BE0
	internal void SteamNetworkingIdentity_ToString(ref NetIdentity identity, out string buf) { }

}

