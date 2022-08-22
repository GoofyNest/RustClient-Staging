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

	// RVA: 0x18C31B0 Offset: 0x18C17B0 VA: 0x1818C31B0
	internal void .ctor() { }

	// RVA: 0x18C2C10 Offset: 0x18C1210 VA: 0x1818C2C10
	internal void AddToken(short token) { }

	// RVA: 0x18C2A90 Offset: 0x18C1090 VA: 0x1818C2A90
	internal void AddString(string str) { }

	// RVA: 0x18C3050 Offset: 0x18C1650 VA: 0x1818C3050
	internal void Reset() { }

	// RVA: 0x18C2D50 Offset: 0x18C1350 VA: 0x1818C2D50
	internal short GetNextFullToken() { }

	// RVA: 0x18C2E80 Offset: 0x18C1480 VA: 0x1818C2E80
	internal short GetNextToken() { }

	// RVA: 0x18C2DF0 Offset: 0x18C13F0 VA: 0x1818C2DF0
	internal string GetNextString() { }

	// RVA: 0x18C3130 Offset: 0x18C1730 VA: 0x1818C3130
	internal void ThrowAwayNextString() { }

	// RVA: 0x18C30A0 Offset: 0x18C16A0 VA: 0x1818C30A0
	internal void TagLastToken(short tag) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	internal int GetTokenCount() { }

	// RVA: 0x18C2F30 Offset: 0x18C1530 VA: 0x1818C2F30
	internal void GoToPosition(int position) { }

}

