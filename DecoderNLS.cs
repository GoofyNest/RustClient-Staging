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

	// RVA: 0x18AD130 Offset: 0x18AB730 VA: 0x1818AD130
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18ACFB0 Offset: 0x18AB5B0 VA: 0x1818ACFB0 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18AD080 Offset: 0x18AB680 VA: 0x1818AD080
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x18AD0F0 Offset: 0x18AB6F0 VA: 0x1818AD0F0
	internal void .ctor() { }

	// RVA: 0x18ACF90 Offset: 0x18AB590 VA: 0x1818ACF90 Slot: 4
	public override void Reset() { }

	// RVA: 0xE4D900 Offset: 0xE4BF00 VA: 0x180E4D900 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x18AC9D0 Offset: 0x18AAFD0 VA: 0x1818AC9D0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x18AC8B0 Offset: 0x18AAEB0 VA: 0x1818AC8B0 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x18ACF50 Offset: 0x18AB550 VA: 0x1818ACF50 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x18ACB80 Offset: 0x18AB180 VA: 0x1818ACB80 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x18ACE00 Offset: 0x18AB400 VA: 0x1818ACE00 Slot: 10
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	// RVA: 0x18AC5A0 Offset: 0x18AABA0 VA: 0x1818AC5A0 Slot: 11
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x18AC3D0 Offset: 0x18AA9D0 VA: 0x1818AC3D0 Slot: 12
	public override void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x9975F0 Offset: 0x995BF0 VA: 0x1809975F0
	public bool get_MustFlush() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 14
	internal virtual bool get_HasState() { }

	// RVA: 0x18AC3C0 Offset: 0x18AA9C0 VA: 0x1818AC3C0
	internal void ClearMustFlush() { }

}

