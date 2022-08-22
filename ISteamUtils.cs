internal class ISteamUtils : SteamInterface // TypeDefIndex: 5133
{	// Methods

	// RVA: 0xDD91B0 Offset: 0xDD77B0 VA: 0x180DD91B0
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDE08F0 Offset: 0xDDEEF0 VA: 0x180DE08F0
	internal static extern IntPtr SteamAPI_SteamUtils_v010() { }

	// RVA: 0xDE08F0 Offset: 0xDDEEF0 VA: 0x180DE08F0 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0xDE0880 Offset: 0xDDEE80 VA: 0x180DE0880
	internal static extern IntPtr SteamAPI_SteamGameServerUtils_v010() { }

	// RVA: 0xDE0880 Offset: 0xDDEE80 VA: 0x180DE0880 Slot: 5
	public override IntPtr GetServerInterfacePointer() { }

	// RVA: 0xDE0CC0 Offset: 0xDDF2C0 VA: 0x180DE0CC0
	private static extern Utf8StringPointer _GetIPCountry(IntPtr self) { }

	// RVA: 0xDE0690 Offset: 0xDDEC90 VA: 0x180DE0690
	internal string GetIPCountry() { }

	// RVA: 0xDE0DF0 Offset: 0xDDF3F0 VA: 0x180DE0DF0
	private static extern bool _GetImageSize(IntPtr self, int iImage, ref uint pnWidth, ref uint pnHeight) { }

	// RVA: 0xDE07D0 Offset: 0xDDEDD0 VA: 0x180DE07D0
	internal bool GetImageSize(int iImage, ref uint pnWidth, ref uint pnHeight) { }

	// RVA: 0xDE0D40 Offset: 0xDDF340 VA: 0x180DE0D40
	private static extern bool _GetImageRGBA(IntPtr self, int iImage, [In] [Out] byte[] pubDest, int nDestBufferSize) { }

	// RVA: 0xDE0720 Offset: 0xDDED20 VA: 0x180DE0720
	internal bool GetImageRGBA(int iImage, [In] [Out] byte[] pubDest, int nDestBufferSize) { }

	// RVA: 0xDE0F30 Offset: 0xDDF530 VA: 0x180DE0F30
	private static extern bool _IsAPICallCompleted(IntPtr self, SteamAPICall_t hSteamAPICall, ref bool pbFailed) { }

	// RVA: 0xDE09F0 Offset: 0xDDEFF0 VA: 0x180DE09F0
	internal bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, ref bool pbFailed) { }

	// RVA: 0xDE0BF0 Offset: 0xDDF1F0 VA: 0x180DE0BF0
	private static extern bool _GetAPICallResult(IntPtr self, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed) { }

	// RVA: 0xDE05C0 Offset: 0xDDEBC0 VA: 0x180DE05C0
	internal bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed) { }

	// RVA: 0xDE0FD0 Offset: 0xDDF5D0 VA: 0x180DE0FD0
	private static extern bool _IsOverlayEnabled(IntPtr self) { }

	// RVA: 0xDE0A90 Offset: 0xDDF090 VA: 0x180DE0A90
	internal bool IsOverlayEnabled() { }

	// RVA: 0xDE0EA0 Offset: 0xDDF4A0 VA: 0x180DE0EA0
	private static extern bool _InitFilterText(IntPtr self, uint unFilterOptions) { }

	// RVA: 0xDE0960 Offset: 0xDDEF60 VA: 0x180DE0960
	internal bool InitFilterText(uint unFilterOptions) { }

	// RVA: 0xDE0B10 Offset: 0xDDF110 VA: 0x180DE0B10
	private static extern int _FilterText(IntPtr self, TextFilteringContext eContext, SteamId sourceSteamID, string pchInputMessage, IntPtr pchOutFilteredText, uint nByteSizeOutFilteredText) { }

	// RVA: 0xDE03B0 Offset: 0xDDE9B0 VA: 0x180DE03B0
	internal int FilterText(TextFilteringContext eContext, SteamId sourceSteamID, string pchInputMessage, out string pchOutFilteredText) { }

}

