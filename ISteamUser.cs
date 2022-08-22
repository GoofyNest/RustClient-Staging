internal class ISteamUser : SteamInterface // TypeDefIndex: 5131
{	// Methods

	// RVA: 0xDD91B0 Offset: 0xDD77B0 VA: 0x180DD91B0
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDDF7B0 Offset: 0xDDDDB0 VA: 0x180DDF7B0
	internal static extern IntPtr SteamAPI_SteamUser_v021() { }

	// RVA: 0xDDF7B0 Offset: 0xDDDDB0 VA: 0x180DDF7B0 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0xDDFC20 Offset: 0xDDE220 VA: 0x180DDFC20
	private static extern bool _BLoggedOn(IntPtr self) { }

	// RVA: 0xDDF340 Offset: 0xDDD940 VA: 0x180DDF340
	internal bool BLoggedOn() { }

	// RVA: 0xDE0010 Offset: 0xDDE610 VA: 0x180DE0010
	private static extern SteamId _GetSteamID(IntPtr self) { }

	// RVA: 0xDDF730 Offset: 0xDDDD30 VA: 0x180DDF730
	internal SteamId GetSteamID() { }

	// RVA: 0xDE02B0 Offset: 0xDDE8B0 VA: 0x180DE02B0
	private static extern void _StartVoiceRecording(IntPtr self) { }

	// RVA: 0xDDFAA0 Offset: 0xDDE0A0 VA: 0x180DDFAA0
	internal void StartVoiceRecording() { }

	// RVA: 0xDE0330 Offset: 0xDDE930 VA: 0x180DE0330
	private static extern void _StopVoiceRecording(IntPtr self) { }

	// RVA: 0xDDFB20 Offset: 0xDDE120 VA: 0x180DDFB20
	internal void StopVoiceRecording() { }

	// RVA: 0xDDFEB0 Offset: 0xDDE4B0 VA: 0x180DDFEB0
	private static extern VoiceResult _GetAvailableVoice(IntPtr self, ref uint pcbCompressed, ref uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	// RVA: 0xDDF5D0 Offset: 0xDDDBD0 VA: 0x180DDF5D0
	internal VoiceResult GetAvailableVoice(ref uint pcbCompressed, ref uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	// RVA: 0xDE0110 Offset: 0xDDE710 VA: 0x180DE0110
	private static extern VoiceResult _GetVoice(IntPtr self, bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, ref uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	// RVA: 0xDDF8A0 Offset: 0xDDDEA0 VA: 0x180DDF8A0
	internal VoiceResult GetVoice(bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, ref uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	// RVA: 0xDDFD30 Offset: 0xDDE330 VA: 0x180DDFD30
	private static extern VoiceResult _DecompressVoice(IntPtr self, IntPtr pCompressed, uint cbCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, uint nDesiredSampleRate) { }

	// RVA: 0xDDF450 Offset: 0xDDDA50 VA: 0x180DDF450
	internal VoiceResult DecompressVoice(IntPtr pCompressed, uint cbCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, uint nDesiredSampleRate) { }

	// RVA: 0xDE0090 Offset: 0xDDE690 VA: 0x180DE0090
	private static extern uint _GetVoiceOptimalSampleRate(IntPtr self) { }

	// RVA: 0xDDF820 Offset: 0xDDDE20 VA: 0x180DDF820
	internal uint GetVoiceOptimalSampleRate() { }

	// RVA: 0xDDFE00 Offset: 0xDDE400 VA: 0x180DDFE00
	private static extern HAuthTicket _GetAuthSessionTicket(IntPtr self, IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket) { }

	// RVA: 0xDDF520 Offset: 0xDDDB20 VA: 0x180DDF520
	internal HAuthTicket GetAuthSessionTicket(IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket) { }

	// RVA: 0xDDFCA0 Offset: 0xDDE2A0 VA: 0x180DDFCA0
	private static extern void _CancelAuthTicket(IntPtr self, HAuthTicket hAuthTicket) { }

	// RVA: 0xDDF3C0 Offset: 0xDDD9C0 VA: 0x180DDF3C0
	internal void CancelAuthTicket(HAuthTicket hAuthTicket) { }

	// RVA: 0xDE0210 Offset: 0xDDE810 VA: 0x180DE0210
	private static extern SteamAPICall_t _RequestEncryptedAppTicket(IntPtr self, IntPtr pDataToInclude, int cbDataToInclude) { }

	// RVA: 0xDDF9A0 Offset: 0xDDDFA0 VA: 0x180DDF9A0
	internal CallResult<EncryptedAppTicketResponse_t> RequestEncryptedAppTicket(IntPtr pDataToInclude, int cbDataToInclude) { }

	// RVA: 0xDDFF60 Offset: 0xDDE560 VA: 0x180DDFF60
	private static extern bool _GetEncryptedAppTicket(IntPtr self, IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket) { }

	// RVA: 0xDDF680 Offset: 0xDDDC80 VA: 0x180DDF680
	internal bool GetEncryptedAppTicket(IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket) { }

	// RVA: 0xDDFBA0 Offset: 0xDDE1A0 VA: 0x180DDFBA0
	private static extern bool _BIsTwoFactorEnabled(IntPtr self) { }

	// RVA: 0xDDF2C0 Offset: 0xDDD8C0 VA: 0x180DDF2C0
	internal bool BIsTwoFactorEnabled() { }

}

