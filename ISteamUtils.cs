internal class ISteamUtils : SteamInterface // TypeDefIndex: 5133
{	// Methods

	// RVA: 0xDD8440 Offset: 0xDD6A40 VA: 0x180DD8440
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDDFB80 Offset: 0xDDE180 VA: 0x180DDFB80
	internal static extern IntPtr SteamAPI_SteamUtils_v010() { }

	// RVA: 0xDDFB80 Offset: 0xDDE180 VA: 0x180DDFB80 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0xDDFB10 Offset: 0xDDE110 VA: 0x180DDFB10
	internal static extern IntPtr SteamAPI_SteamGameServerUtils_v010() { }

	// RVA: 0xDDFB10 Offset: 0xDDE110 VA: 0x180DDFB10 Slot: 5
	public override IntPtr GetServerInterfacePointer() { }

	// RVA: 0xDDFF50 Offset: 0xDDE550 VA: 0x180DDFF50
	private static extern Utf8StringPointer _GetIPCountry(IntPtr self) { }

	// RVA: 0xDDF920 Offset: 0xDDDF20 VA: 0x180DDF920
	internal string GetIPCountry() { }

	// RVA: 0xDE0080 Offset: 0xDDE680 VA: 0x180DE0080
	private static extern bool _GetImageSize(IntPtr self, int iImage, ref uint pnWidth, ref uint pnHeight) { }

	// RVA: 0xDDFA60 Offset: 0xDDE060 VA: 0x180DDFA60
	internal bool GetImageSize(int iImage, ref uint pnWidth, ref uint pnHeight) { }

	// RVA: 0xDDFFD0 Offset: 0xDDE5D0 VA: 0x180DDFFD0
	private static extern bool _GetImageRGBA(IntPtr self, int iImage, [In] [Out] byte[] pubDest, int nDestBufferSize) { }

	// RVA: 0xDDF9B0 Offset: 0xDDDFB0 VA: 0x180DDF9B0
	internal bool GetImageRGBA(int iImage, [In] [Out] byte[] pubDest, int nDestBufferSize) { }

	// RVA: 0xDE01C0 Offset: 0xDDE7C0 VA: 0x180DE01C0
	private static extern bool _IsAPICallCompleted(IntPtr self, SteamAPICall_t hSteamAPICall, ref bool pbFailed) { }

	// RVA: 0xDDFC80 Offset: 0xDDE280 VA: 0x180DDFC80
	internal bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, ref bool pbFailed) { }

	// RVA: 0xDDFE80 Offset: 0xDDE480 VA: 0x180DDFE80
	private static extern bool _GetAPICallResult(IntPtr self, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed) { }

	// RVA: 0xDDF850 Offset: 0xDDDE50 VA: 0x180DDF850
	internal bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed) { }

	// RVA: 0xDE0260 Offset: 0xDDE860 VA: 0x180DE0260
	private static extern bool _IsOverlayEnabled(IntPtr self) { }

	// RVA: 0xDDFD20 Offset: 0xDDE320 VA: 0x180DDFD20
	internal bool IsOverlayEnabled() { }

	// RVA: 0xDE0130 Offset: 0xDDE730 VA: 0x180DE0130
	private static extern bool _InitFilterText(IntPtr self, uint unFilterOptions) { }

	// RVA: 0xDDFBF0 Offset: 0xDDE1F0 VA: 0x180DDFBF0
	internal bool InitFilterText(uint unFilterOptions) { }

	// RVA: 0xDDFDA0 Offset: 0xDDE3A0 VA: 0x180DDFDA0
	private static extern int _FilterText(IntPtr self, TextFilteringContext eContext, SteamId sourceSteamID, string pchInputMessage, IntPtr pchOutFilteredText, uint nByteSizeOutFilteredText) { }

	// RVA: 0xDDF640 Offset: 0xDDDC40 VA: 0x180DDF640
	internal int FilterText(TextFilteringContext eContext, SteamId sourceSteamID, string pchInputMessage, out string pchOutFilteredText) { }

}

