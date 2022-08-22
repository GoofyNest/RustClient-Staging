public static class ChallengeResponse2 // TypeDefIndex: 1726
{	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8

	// Methods

	// RVA: 0x1AB1540 Offset: 0x1AAFB40 VA: 0x181AB1540
	private static byte[] Compute_LM(string password, byte[] challenge) { }

	// RVA: 0x1AB1830 Offset: 0x1AAFE30 VA: 0x181AB1830
	private static byte[] Compute_NTLM_Password(string password) { }

	// RVA: 0x1AB1940 Offset: 0x1AAFF40 VA: 0x181AB1940
	private static byte[] Compute_NTLM(string password, byte[] challenge) { }

	// RVA: 0x1AB19B0 Offset: 0x1AAFFB0 VA: 0x181AB19B0
	private static void Compute_NTLMv2_Session(string password, byte[] challenge, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x1AB1BE0 Offset: 0x1AB01E0 VA: 0x181AB1BE0
	private static byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain) { }

	// RVA: 0x1AB2060 Offset: 0x1AB0660 VA: 0x181AB2060
	public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x1AB2290 Offset: 0x1AB0890 VA: 0x181AB2290
	private static byte[] GetResponse(byte[] challenge, byte[] pwd) { }

	// RVA: 0x1AB2630 Offset: 0x1AB0C30 VA: 0x181AB2630
	private static byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x1AB24C0 Offset: 0x1AB0AC0 VA: 0x181AB24C0
	private static byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x1AB29B0 Offset: 0x1AB0FB0 VA: 0x181AB29B0
	private static void .cctor() { }

}

