internal class ISteamUser : SteamInterface // TypeDefIndex: 5131
{	// Methods

	// RVA: 0xDD8440 Offset: 0xDD6A40 VA: 0x180DD8440
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDDEA40 Offset: 0xDDD040 VA: 0x180DDEA40
	internal static extern IntPtr SteamAPI_SteamUser_v021() { }

	// RVA: 0xDDEA40 Offset: 0xDDD040 VA: 0x180DDEA40 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0xDDEEB0 Offset: 0xDDD4B0 VA: 0x180DDEEB0
	private static extern bool _BLoggedOn(IntPtr self) { }

	// RVA: 0xDDE5D0 Offset: 0xDDCBD0 VA: 0x180DDE5D0
	internal bool BLoggedOn() { }

	// RVA: 0xDDF2A0 Offset: 0xDDD8A0 VA: 0x180DDF2A0
	private static extern SteamId _GetSteamID(IntPtr self) { }

	// RVA: 0xDDE9C0 Offset: 0xDDCFC0 VA: 0x180DDE9C0
	internal SteamId GetSteamID() { }

	// RVA: 0xDDF540 Offset: 0xDDDB40 VA: 0x180DDF540
	private static extern void _StartVoiceRecording(IntPtr self) { }

	// RVA: 0xDDED30 Offset: 0xDDD330 VA: 0x180DDED30
	internal void StartVoiceRecording() { }

	// RVA: 0xDDF5C0 Offset: 0xDDDBC0 VA: 0x180DDF5C0
	private static extern void _StopVoiceRecording(IntPtr self) { }

	// RVA: 0xDDEDB0 Offset: 0xDDD3B0 VA: 0x180DDEDB0
	internal void StopVoiceRecording() { }

	// RVA: 0xDDF140 Offset: 0xDDD740 VA: 0x180DDF140
	private static extern VoiceResult _GetAvailableVoice(IntPtr self, ref uint pcbCompressed, ref uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	// RVA: 0xDDE860 Offset: 0xDDCE60 VA: 0x180DDE860
	internal VoiceResult GetAvailableVoice(ref uint pcbCompressed, ref uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	// RVA: 0xDDF3A0 Offset: 0xDDD9A0 VA: 0x180DDF3A0
	private static extern VoiceResult _GetVoice(IntPtr self, bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, ref uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	// RVA: 0xDDEB30 Offset: 0xDDD130 VA: 0x180DDEB30
	internal VoiceResult GetVoice(bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, ref uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	// RVA: 0xDDEFC0 Offset: 0xDDD5C0 VA: 0x180DDEFC0
	private static extern VoiceResult _DecompressVoice(IntPtr self, IntPtr pCompressed, uint cbCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, uint nDesiredSampleRate) { }

	// RVA: 0xDDE6E0 Offset: 0xDDCCE0 VA: 0x180DDE6E0
	internal VoiceResult DecompressVoice(IntPtr pCompressed, uint cbCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, uint nDesiredSampleRate) { }

	// RVA: 0xDDF320 Offset: 0xDDD920 VA: 0x180DDF320
	private static extern uint _GetVoiceOptimalSampleRate(IntPtr self) { }

	// RVA: 0xDDEAB0 Offset: 0xDDD0B0 VA: 0x180DDEAB0
	internal uint GetVoiceOptimalSampleRate() { }

	// RVA: 0xDDF090 Offset: 0xDDD690 VA: 0x180DDF090
	private static extern HAuthTicket _GetAuthSessionTicket(IntPtr self, IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket) { }

	// RVA: 0xDDE7B0 Offset: 0xDDCDB0 VA: 0x180DDE7B0
	internal HAuthTicket GetAuthSessionTicket(IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket) { }

	// RVA: 0xDDEF30 Offset: 0xDDD530 VA: 0x180DDEF30
	private static extern void _CancelAuthTicket(IntPtr self, HAuthTicket hAuthTicket) { }

	// RVA: 0xDDE650 Offset: 0xDDCC50 VA: 0x180DDE650
	internal void CancelAuthTicket(HAuthTicket hAuthTicket) { }

	// RVA: 0xDDF4A0 Offset: 0xDDDAA0 VA: 0x180DDF4A0
	private static extern SteamAPICall_t _RequestEncryptedAppTicket(IntPtr self, IntPtr pDataToInclude, int cbDataToInclude) { }

	// RVA: 0xDDEC30 Offset: 0xDDD230 VA: 0x180DDEC30
	internal CallResult<EncryptedAppTicketResponse_t> RequestEncryptedAppTicket(IntPtr pDataToInclude, int cbDataToInclude) { }

	// RVA: 0xDDF1F0 Offset: 0xDDD7F0 VA: 0x180DDF1F0
	private static extern bool _GetEncryptedAppTicket(IntPtr self, IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket) { }

	// RVA: 0xDDE910 Offset: 0xDDCF10 VA: 0x180DDE910
	internal bool GetEncryptedAppTicket(IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket) { }

	// RVA: 0xDDEE30 Offset: 0xDDD430 VA: 0x180DDEE30
	private static extern bool _BIsTwoFactorEnabled(IntPtr self) { }

	// RVA: 0xDDE550 Offset: 0xDDCB50 VA: 0x180DDE550
	internal bool BIsTwoFactorEnabled() { }

}

