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

	// RVA: 0x18AC850 Offset: 0x18AAE50 VA: 0x1818AC850
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18AC6D0 Offset: 0x18AACD0 VA: 0x1818AC6D0 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18AC7A0 Offset: 0x18AADA0 VA: 0x1818AC7A0
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x18AC810 Offset: 0x18AAE10 VA: 0x1818AC810
	internal void .ctor() { }

	// RVA: 0x18AC6B0 Offset: 0x18AACB0 VA: 0x1818AC6B0 Slot: 4
	public override void Reset() { }

	// RVA: 0xE4E3B0 Offset: 0xE4C9B0 VA: 0x180E4E3B0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x18AC0F0 Offset: 0x18AA6F0 VA: 0x1818AC0F0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x18ABFD0 Offset: 0x18AA5D0 VA: 0x1818ABFD0 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x18AC670 Offset: 0x18AAC70 VA: 0x1818AC670 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x18AC2A0 Offset: 0x18AA8A0 VA: 0x1818AC2A0 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x18AC520 Offset: 0x18AAB20 VA: 0x1818AC520 Slot: 10
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	// RVA: 0x18ABCC0 Offset: 0x18AA2C0 VA: 0x1818ABCC0 Slot: 11
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x18ABAF0 Offset: 0x18AA0F0 VA: 0x1818ABAF0 Slot: 12
	public override void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x997AE0 Offset: 0x9960E0 VA: 0x180997AE0
	public bool get_MustFlush() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 14
	internal virtual bool get_HasState() { }

	// RVA: 0x18ABAE0 Offset: 0x18AA0E0 VA: 0x1818ABAE0
	internal void ClearMustFlush() { }

}

