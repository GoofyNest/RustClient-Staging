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

	// RVA: 0x18C3470 Offset: 0x18C1A70 VA: 0x1818C3470
	internal void .ctor() { }

	// RVA: 0x18C2ED0 Offset: 0x18C14D0 VA: 0x1818C2ED0
	internal void AddToken(short token) { }

	// RVA: 0x18C2D50 Offset: 0x18C1350 VA: 0x1818C2D50
	internal void AddString(string str) { }

	// RVA: 0x18C3310 Offset: 0x18C1910 VA: 0x1818C3310
	internal void Reset() { }

	// RVA: 0x18C3010 Offset: 0x18C1610 VA: 0x1818C3010
	internal short GetNextFullToken() { }

	// RVA: 0x18C3140 Offset: 0x18C1740 VA: 0x1818C3140
	internal short GetNextToken() { }

	// RVA: 0x18C30B0 Offset: 0x18C16B0 VA: 0x1818C30B0
	internal string GetNextString() { }

	// RVA: 0x18C33F0 Offset: 0x18C19F0 VA: 0x1818C33F0
	internal void ThrowAwayNextString() { }

	// RVA: 0x18C3360 Offset: 0x18C1960 VA: 0x1818C3360
	internal void TagLastToken(short tag) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	internal int GetTokenCount() { }

	// RVA: 0x18C31F0 Offset: 0x18C17F0 VA: 0x1818C31F0
	internal void GoToPosition(int position) { }

}

