internal class DecoderNLS : Decoder, ISerializable // TypeDefIndex: 441
{	// Fields
	protected Encoding m_encoding; // 0x20
	protected bool m_mustFlush; // 0x28
	internal bool m_throwOnOverflow; // 0x29
	internal int m_bytesUsed; // 0x2C

	// Properties
	public bool MustFlush { get; }
	internal virtual bool HasState { get; }

	// Methods

	// RVA: 0x18ACEB0 Offset: 0x18AB4B0 VA: 0x1818ACEB0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18ACD30 Offset: 0x18AB330 VA: 0x1818ACD30 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18ACE00 Offset: 0x18AB400 VA: 0x1818ACE00
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x18ACE70 Offset: 0x18AB470 VA: 0x1818ACE70
	internal void .ctor() { }

	// RVA: 0x18ACD10 Offset: 0x18AB310 VA: 0x1818ACD10 Slot: 4
	public override void Reset() { }

	// RVA: 0xE4D640 Offset: 0xE4BC40 VA: 0x180E4D640 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x18AC750 Offset: 0x18AAD50 VA: 0x1818AC750 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x18AC630 Offset: 0x18AAC30 VA: 0x1818AC630 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x18ACCD0 Offset: 0x18AB2D0 VA: 0x1818ACCD0 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x18AC900 Offset: 0x18AAF00 VA: 0x1818AC900 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x18ACB80 Offset: 0x18AB180 VA: 0x1818ACB80 Slot: 10
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	// RVA: 0x18AC320 Offset: 0x18AA920 VA: 0x1818AC320 Slot: 11
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x18AC150 Offset: 0x18AA750 VA: 0x1818AC150 Slot: 12
	public override void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x9974E0 Offset: 0x995AE0 VA: 0x1809974E0
	public bool get_MustFlush() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 14
	internal virtual bool get_HasState() { }

	// RVA: 0x18AC140 Offset: 0x18AA740 VA: 0x1818AC140
	internal void ClearMustFlush() { }

}

