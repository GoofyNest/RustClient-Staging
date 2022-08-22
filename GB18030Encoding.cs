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

	// RVA: 0x224B3A0 Offset: 0x22499A0 VA: 0x18224B3A0
	public void .ctor() { }

	// RVA: 0x224FE00 Offset: 0x224E400 VA: 0x18224FE00 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224FE30 Offset: 0x224E430 VA: 0x18224FE30 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x224FDD0 Offset: 0x224E3D0 VA: 0x18224FDD0 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224FE60 Offset: 0x224E460 VA: 0x18224FE60 Slot: 10
	public override string get_WebName() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 15
	public override bool get_IsMailNewsSave() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0x224FDC0 Offset: 0x224E3C0 VA: 0x18224FDC0 Slot: 40
	public override int GetMaxByteCount(int len) { }

	// RVA: 0x79A230 Offset: 0x798830 VA: 0x18079A230 Slot: 41
	public override int GetMaxCharCount(int len) { }

	// RVA: 0x224FA50 Offset: 0x224E050 VA: 0x18224FA50 Slot: 19
	public override int GetByteCount(char[] chars, int index, int length) { }

	// RVA: 0x224F9B0 Offset: 0x224DFB0 VA: 0x18224F9B0 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x224FB00 Offset: 0x224E100 VA: 0x18224FB00 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x224FBC0 Offset: 0x224E1C0 VA: 0x18224FBC0 Slot: 29
	public override int GetCharCount(byte[] bytes, int start, int len) { }

	// RVA: 0x224FC60 Offset: 0x224E260 VA: 0x18224FC60 Slot: 33
	public override int GetChars(byte[] bytes, int byteIdx, int srclen, char[] chars, int charIdx) { }

	// RVA: 0x224FD60 Offset: 0x224E360 VA: 0x18224FD60 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x224FD00 Offset: 0x224E300 VA: 0x18224FD00 Slot: 38
	public override Decoder GetDecoder() { }

}

