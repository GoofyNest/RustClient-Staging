public class GB18030Encoding : MonoEncoding // TypeDefIndex: 7830
{	// Properties
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override string BodyName { get; }
	public override string WebName { get; }
	public override bool IsMailNewsDisplay { get; }
	public override bool IsMailNewsSave { get; }
	public override bool IsBrowserDisplay { get; }
	public override bool IsBrowserSave { get; }

	// Methods

	// RVA: 0x224B2A0 Offset: 0x22498A0 VA: 0x18224B2A0
	public void .ctor() { }

	// RVA: 0x224FD00 Offset: 0x224E300 VA: 0x18224FD00 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224FD30 Offset: 0x224E330 VA: 0x18224FD30 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x224FCD0 Offset: 0x224E2D0 VA: 0x18224FCD0 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224FD60 Offset: 0x224E360 VA: 0x18224FD60 Slot: 10
	public override string get_WebName() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 15
	public override bool get_IsMailNewsSave() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0x224FCC0 Offset: 0x224E2C0 VA: 0x18224FCC0 Slot: 40
	public override int GetMaxByteCount(int len) { }

	// RVA: 0x79A120 Offset: 0x798720 VA: 0x18079A120 Slot: 41
	public override int GetMaxCharCount(int len) { }

	// RVA: 0x224F950 Offset: 0x224DF50 VA: 0x18224F950 Slot: 19
	public override int GetByteCount(char[] chars, int index, int length) { }

	// RVA: 0x224F8B0 Offset: 0x224DEB0 VA: 0x18224F8B0 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x224FA00 Offset: 0x224E000 VA: 0x18224FA00 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x224FAC0 Offset: 0x224E0C0 VA: 0x18224FAC0 Slot: 29
	public override int GetCharCount(byte[] bytes, int start, int len) { }

	// RVA: 0x224FB60 Offset: 0x224E160 VA: 0x18224FB60 Slot: 33
	public override int GetChars(byte[] bytes, int byteIdx, int srclen, char[] chars, int charIdx) { }

	// RVA: 0x224FC60 Offset: 0x224E260 VA: 0x18224FC60 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x224FC00 Offset: 0x224E200 VA: 0x18224FC00 Slot: 38
	public override Decoder GetDecoder() { }

}

