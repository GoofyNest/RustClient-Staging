internal sealed class TokenizerStream // TypeDefIndex: 927
{	// Fields
	private int m_countTokens; // 0x10
	private TokenizerShortBlock m_headTokens; // 0x18
	private TokenizerShortBlock m_lastTokens; // 0x20
	private TokenizerShortBlock m_currentTokens; // 0x28
	private int m_indexTokens; // 0x30
	private TokenizerStringBlock m_headStrings; // 0x38
	private TokenizerStringBlock m_currentStrings; // 0x40
	private int m_indexStrings; // 0x48

	// Methods

	// RVA: 0x18C2B90 Offset: 0x18C1190 VA: 0x1818C2B90
	internal void .ctor() { }

	// RVA: 0x18C25F0 Offset: 0x18C0BF0 VA: 0x1818C25F0
	internal void AddToken(short token) { }

	// RVA: 0x18C2470 Offset: 0x18C0A70 VA: 0x1818C2470
	internal void AddString(string str) { }

	// RVA: 0x18C2A30 Offset: 0x18C1030 VA: 0x1818C2A30
	internal void Reset() { }

	// RVA: 0x18C2730 Offset: 0x18C0D30 VA: 0x1818C2730
	internal short GetNextFullToken() { }

	// RVA: 0x18C2860 Offset: 0x18C0E60 VA: 0x1818C2860
	internal short GetNextToken() { }

	// RVA: 0x18C27D0 Offset: 0x18C0DD0 VA: 0x1818C27D0
	internal string GetNextString() { }

	// RVA: 0x18C2B10 Offset: 0x18C1110 VA: 0x1818C2B10
	internal void ThrowAwayNextString() { }

	// RVA: 0x18C2A80 Offset: 0x18C1080 VA: 0x1818C2A80
	internal void TagLastToken(short tag) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	internal int GetTokenCount() { }

	// RVA: 0x18C2910 Offset: 0x18C0F10 VA: 0x1818C2910
	internal void GoToPosition(int position) { }

}

