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

	// RVA: 0x18ACE70 Offset: 0x18AB470 VA: 0x1818ACE70
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18ACCF0 Offset: 0x18AB2F0 VA: 0x1818ACCF0 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18ACDC0 Offset: 0x18AB3C0 VA: 0x1818ACDC0
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x18ACE30 Offset: 0x18AB430 VA: 0x1818ACE30
	internal void .ctor() { }

	// RVA: 0x18ACCD0 Offset: 0x18AB2D0 VA: 0x1818ACCD0 Slot: 4
	public override void Reset() { }

	// RVA: 0xE4D640 Offset: 0xE4BC40 VA: 0x180E4D640 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x18AC710 Offset: 0x18AAD10 VA: 0x1818AC710 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x18AC5F0 Offset: 0x18AABF0 VA: 0x1818AC5F0 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x18ACC90 Offset: 0x18AB290 VA: 0x1818ACC90 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x18AC8C0 Offset: 0x18AAEC0 VA: 0x1818AC8C0 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x18ACB40 Offset: 0x18AB140 VA: 0x1818ACB40 Slot: 10
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	// RVA: 0x18AC2E0 Offset: 0x18AA8E0 VA: 0x1818AC2E0 Slot: 11
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x18AC110 Offset: 0x18AA710 VA: 0x1818AC110 Slot: 12
	public override void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x9974E0 Offset: 0x995AE0 VA: 0x1809974E0
	public bool get_MustFlush() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 14
	internal virtual bool get_HasState() { }

	// RVA: 0x18AC100 Offset: 0x18AA700 VA: 0x1818AC100
	internal void ClearMustFlush() { }

}

