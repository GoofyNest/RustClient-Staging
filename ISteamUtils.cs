internal class ISteamUtils : SteamInterface // TypeDefIndex: 5133
{	// Methods

	// RVA: 0xDD8700 Offset: 0xDD6D00 VA: 0x180DD8700
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDDFE40 Offset: 0xDDE440 VA: 0x180DDFE40
	internal static extern IntPtr SteamAPI_SteamUtils_v010() { }

	// RVA: 0xDDFE40 Offset: 0xDDE440 VA: 0x180DDFE40 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0xDDFDD0 Offset: 0xDDE3D0 VA: 0x180DDFDD0
	internal static extern IntPtr SteamAPI_SteamGameServerUtils_v010() { }

	// RVA: 0xDDFDD0 Offset: 0xDDE3D0 VA: 0x180DDFDD0 Slot: 5
	public override IntPtr GetServerInterfacePointer() { }

	// RVA: 0xDE0210 Offset: 0xDDE810 VA: 0x180DE0210
	private static extern Utf8StringPointer _GetIPCountry(IntPtr self) { }

	// RVA: 0xDDFBE0 Offset: 0xDDE1E0 VA: 0x180DDFBE0
	internal string GetIPCountry() { }

	// RVA: 0xDE0340 Offset: 0xDDE940 VA: 0x180DE0340
	private static extern bool _GetImageSize(IntPtr self, int iImage, ref uint pnWidth, ref uint pnHeight) { }

	// RVA: 0xDDFD20 Offset: 0xDDE320 VA: 0x180DDFD20
	internal bool GetImageSize(int iImage, ref uint pnWidth, ref uint pnHeight) { }

	// RVA: 0xDE0290 Offset: 0xDDE890 VA: 0x180DE0290
	private static extern bool _GetImageRGBA(IntPtr self, int iImage, [In] [Out] byte[] pubDest, int nDestBufferSize) { }

	// RVA: 0xDDFC70 Offset: 0xDDE270 VA: 0x180DDFC70
	internal bool GetImageRGBA(int iImage, [In] [Out] byte[] pubDest, int nDestBufferSize) { }

	// RVA: 0xDE0480 Offset: 0xDDEA80 VA: 0x180DE0480
	private static extern bool _IsAPICallCompleted(IntPtr self, SteamAPICall_t hSteamAPICall, ref bool pbFailed) { }

	// RVA: 0xDDFF40 Offset: 0xDDE540 VA: 0x180DDFF40
	internal bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, ref bool pbFailed) { }

	// RVA: 0xDE0140 Offset: 0xDDE740 VA: 0x180DE0140
	private static extern bool _GetAPICallResult(IntPtr self, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed) { }

	// RVA: 0xDDFB10 Offset: 0xDDE110 VA: 0x180DDFB10
	internal bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed) { }

	// RVA: 0xDE0520 Offset: 0xDDEB20 VA: 0x180DE0520
	private static extern bool _IsOverlayEnabled(IntPtr self) { }

	// RVA: 0xDDFFE0 Offset: 0xDDE5E0 VA: 0x180DDFFE0
	internal bool IsOverlayEnabled() { }

	// RVA: 0xDE03F0 Offset: 0xDDE9F0 VA: 0x180DE03F0
	private static extern bool _InitFilterText(IntPtr self, uint unFilterOptions) { }

	// RVA: 0xDDFEB0 Offset: 0xDDE4B0 VA: 0x180DDFEB0
	internal bool InitFilterText(uint unFilterOptions) { }

	// RVA: 0xDE0060 Offset: 0xDDE660 VA: 0x180DE0060
	private static extern int _FilterText(IntPtr self, TextFilteringContext eContext, SteamId sourceSteamID, string pchInputMessage, IntPtr pchOutFilteredText, uint nByteSizeOutFilteredText) { }

	// RVA: 0xDDF900 Offset: 0xDDDF00 VA: 0x180DDF900
	internal int FilterText(TextFilteringContext eContext, SteamId sourceSteamID, string pchInputMessage, out string pchOutFilteredText) { }

}

