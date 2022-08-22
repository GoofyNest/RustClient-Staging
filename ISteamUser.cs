internal class ISteamUser : SteamInterface // TypeDefIndex: 5131
{	// Methods

	// RVA: 0xDD8700 Offset: 0xDD6D00 VA: 0x180DD8700
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDDED00 Offset: 0xDDD300 VA: 0x180DDED00
	internal static extern IntPtr SteamAPI_SteamUser_v021() { }

	// RVA: 0xDDED00 Offset: 0xDDD300 VA: 0x180DDED00 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0xDDF170 Offset: 0xDDD770 VA: 0x180DDF170
	private static extern bool _BLoggedOn(IntPtr self) { }

	// RVA: 0xDDE890 Offset: 0xDDCE90 VA: 0x180DDE890
	internal bool BLoggedOn() { }

	// RVA: 0xDDF560 Offset: 0xDDDB60 VA: 0x180DDF560
	private static extern SteamId _GetSteamID(IntPtr self) { }

	// RVA: 0xDDEC80 Offset: 0xDDD280 VA: 0x180DDEC80
	internal SteamId GetSteamID() { }

	// RVA: 0xDDF800 Offset: 0xDDDE00 VA: 0x180DDF800
	private static extern void _StartVoiceRecording(IntPtr self) { }

	// RVA: 0xDDEFF0 Offset: 0xDDD5F0 VA: 0x180DDEFF0
	internal void StartVoiceRecording() { }

	// RVA: 0xDDF880 Offset: 0xDDDE80 VA: 0x180DDF880
	private static extern void _StopVoiceRecording(IntPtr self) { }

	// RVA: 0xDDF070 Offset: 0xDDD670 VA: 0x180DDF070
	internal void StopVoiceRecording() { }

	// RVA: 0xDDF400 Offset: 0xDDDA00 VA: 0x180DDF400
	private static extern VoiceResult _GetAvailableVoice(IntPtr self, ref uint pcbCompressed, ref uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	// RVA: 0xDDEB20 Offset: 0xDDD120 VA: 0x180DDEB20
	internal VoiceResult GetAvailableVoice(ref uint pcbCompressed, ref uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	// RVA: 0xDDF660 Offset: 0xDDDC60 VA: 0x180DDF660
	private static extern VoiceResult _GetVoice(IntPtr self, bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, ref uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	// RVA: 0xDDEDF0 Offset: 0xDDD3F0 VA: 0x180DDEDF0
	internal VoiceResult GetVoice(bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, ref uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	// RVA: 0xDDF280 Offset: 0xDDD880 VA: 0x180DDF280
	private static extern VoiceResult _DecompressVoice(IntPtr self, IntPtr pCompressed, uint cbCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, uint nDesiredSampleRate) { }

	// RVA: 0xDDE9A0 Offset: 0xDDCFA0 VA: 0x180DDE9A0
	internal VoiceResult DecompressVoice(IntPtr pCompressed, uint cbCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, uint nDesiredSampleRate) { }

	// RVA: 0xDDF5E0 Offset: 0xDDDBE0 VA: 0x180DDF5E0
	private static extern uint _GetVoiceOptimalSampleRate(IntPtr self) { }

	// RVA: 0xDDED70 Offset: 0xDDD370 VA: 0x180DDED70
	internal uint GetVoiceOptimalSampleRate() { }

	// RVA: 0xDDF350 Offset: 0xDDD950 VA: 0x180DDF350
	private static extern HAuthTicket _GetAuthSessionTicket(IntPtr self, IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket) { }

	// RVA: 0xDDEA70 Offset: 0xDDD070 VA: 0x180DDEA70
	internal HAuthTicket GetAuthSessionTicket(IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket) { }

	// RVA: 0xDDF1F0 Offset: 0xDDD7F0 VA: 0x180DDF1F0
	private static extern void _CancelAuthTicket(IntPtr self, HAuthTicket hAuthTicket) { }

	// RVA: 0xDDE910 Offset: 0xDDCF10 VA: 0x180DDE910
	internal void CancelAuthTicket(HAuthTicket hAuthTicket) { }

	// RVA: 0xDDF760 Offset: 0xDDDD60 VA: 0x180DDF760
	private static extern SteamAPICall_t _RequestEncryptedAppTicket(IntPtr self, IntPtr pDataToInclude, int cbDataToInclude) { }

	// RVA: 0xDDEEF0 Offset: 0xDDD4F0 VA: 0x180DDEEF0
	internal CallResult<EncryptedAppTicketResponse_t> RequestEncryptedAppTicket(IntPtr pDataToInclude, int cbDataToInclude) { }

	// RVA: 0xDDF4B0 Offset: 0xDDDAB0 VA: 0x180DDF4B0
	private static extern bool _GetEncryptedAppTicket(IntPtr self, IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket) { }

	// RVA: 0xDDEBD0 Offset: 0xDDD1D0 VA: 0x180DDEBD0
	internal bool GetEncryptedAppTicket(IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket) { }

	// RVA: 0xDDF0F0 Offset: 0xDDD6F0 VA: 0x180DDF0F0
	private static extern bool _BIsTwoFactorEnabled(IntPtr self) { }

	// RVA: 0xDDE810 Offset: 0xDDCE10 VA: 0x180DDE810
	internal bool BIsTwoFactorEnabled() { }

}

