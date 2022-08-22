public static class ChallengeResponse2 // TypeDefIndex: 1726
{	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8

	// Methods

	// RVA: 0x1AB1800 Offset: 0x1AAFE00 VA: 0x181AB1800
	private static byte[] Compute_LM(string password, byte[] challenge) { }

	// RVA: 0x1AB1AF0 Offset: 0x1AB00F0 VA: 0x181AB1AF0
	private static byte[] Compute_NTLM_Password(string password) { }

	// RVA: 0x1AB1C00 Offset: 0x1AB0200 VA: 0x181AB1C00
	private static byte[] Compute_NTLM(string password, byte[] challenge) { }

	// RVA: 0x1AB1C70 Offset: 0x1AB0270 VA: 0x181AB1C70
	private static void Compute_NTLMv2_Session(string password, byte[] challenge, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x1AB1EA0 Offset: 0x1AB04A0 VA: 0x181AB1EA0
	private static byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain) { }

	// RVA: 0x1AB2320 Offset: 0x1AB0920 VA: 0x181AB2320
	public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x1AB2550 Offset: 0x1AB0B50 VA: 0x181AB2550
	private static byte[] GetResponse(byte[] challenge, byte[] pwd) { }

	// RVA: 0x1AB28F0 Offset: 0x1AB0EF0 VA: 0x181AB28F0
	private static byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x1AB2780 Offset: 0x1AB0D80 VA: 0x181AB2780
	private static byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x1AB2C70 Offset: 0x1AB1270 VA: 0x181AB2C70
	private static void .cctor() { }

}

