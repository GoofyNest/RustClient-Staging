public static class ChallengeResponse2 // TypeDefIndex: 1726
{	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8

	// Methods

	// RVA: 0x1AB1700 Offset: 0x1AAFD00 VA: 0x181AB1700
	private static byte[] Compute_LM(string password, byte[] challenge) { }

	// RVA: 0x1AB19F0 Offset: 0x1AAFFF0 VA: 0x181AB19F0
	private static byte[] Compute_NTLM_Password(string password) { }

	// RVA: 0x1AB1B00 Offset: 0x1AB0100 VA: 0x181AB1B00
	private static byte[] Compute_NTLM(string password, byte[] challenge) { }

	// RVA: 0x1AB1B70 Offset: 0x1AB0170 VA: 0x181AB1B70
	private static void Compute_NTLMv2_Session(string password, byte[] challenge, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x1AB1DA0 Offset: 0x1AB03A0 VA: 0x181AB1DA0
	private static byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain) { }

	// RVA: 0x1AB2220 Offset: 0x1AB0820 VA: 0x181AB2220
	public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x1AB2450 Offset: 0x1AB0A50 VA: 0x181AB2450
	private static byte[] GetResponse(byte[] challenge, byte[] pwd) { }

	// RVA: 0x1AB27F0 Offset: 0x1AB0DF0 VA: 0x181AB27F0
	private static byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x1AB2680 Offset: 0x1AB0C80 VA: 0x181AB2680
	private static byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x1AB2B70 Offset: 0x1AB1170 VA: 0x181AB2B70
	private static void .cctor() { }

}

