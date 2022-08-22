public static class ChallengeResponse2 // TypeDefIndex: 1726
{	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8

	// Methods

	// RVA: 0x1AB1FF0 Offset: 0x1AB05F0 VA: 0x181AB1FF0
	private static byte[] Compute_LM(string password, byte[] challenge) { }

	// RVA: 0x1AB22E0 Offset: 0x1AB08E0 VA: 0x181AB22E0
	private static byte[] Compute_NTLM_Password(string password) { }

	// RVA: 0x1AB23F0 Offset: 0x1AB09F0 VA: 0x181AB23F0
	private static byte[] Compute_NTLM(string password, byte[] challenge) { }

	// RVA: 0x1AB2460 Offset: 0x1AB0A60 VA: 0x181AB2460
	private static void Compute_NTLMv2_Session(string password, byte[] challenge, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x1AB2690 Offset: 0x1AB0C90 VA: 0x181AB2690
	private static byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain) { }

	// RVA: 0x1AB2B10 Offset: 0x1AB1110 VA: 0x181AB2B10
	public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x1AB2D40 Offset: 0x1AB1340 VA: 0x181AB2D40
	private static byte[] GetResponse(byte[] challenge, byte[] pwd) { }

	// RVA: 0x1AB30E0 Offset: 0x1AB16E0 VA: 0x181AB30E0
	private static byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x1AB2F70 Offset: 0x1AB1570 VA: 0x181AB2F70
	private static byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x1AB3460 Offset: 0x1AB1A60 VA: 0x181AB3460
	private static void .cctor() { }

}

