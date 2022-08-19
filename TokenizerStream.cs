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

	// RVA: 0x18C31F0 Offset: 0x18C17F0 VA: 0x1818C31F0
	internal void .ctor() { }

	// RVA: 0x18C2C50 Offset: 0x18C1250 VA: 0x1818C2C50
	internal void AddToken(short token) { }

	// RVA: 0x18C2AD0 Offset: 0x18C10D0 VA: 0x1818C2AD0
	internal void AddString(string str) { }

	// RVA: 0x18C3090 Offset: 0x18C1690 VA: 0x1818C3090
	internal void Reset() { }

	// RVA: 0x18C2D90 Offset: 0x18C1390 VA: 0x1818C2D90
	internal short GetNextFullToken() { }

	// RVA: 0x18C2EC0 Offset: 0x18C14C0 VA: 0x1818C2EC0
	internal short GetNextToken() { }

	// RVA: 0x18C2E30 Offset: 0x18C1430 VA: 0x1818C2E30
	internal string GetNextString() { }

	// RVA: 0x18C3170 Offset: 0x18C1770 VA: 0x1818C3170
	internal void ThrowAwayNextString() { }

	// RVA: 0x18C30E0 Offset: 0x18C16E0 VA: 0x1818C30E0
	internal void TagLastToken(short tag) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	internal int GetTokenCount() { }

	// RVA: 0x18C2F70 Offset: 0x18C1570 VA: 0x1818C2F70
	internal void GoToPosition(int position) { }

}

