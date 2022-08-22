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

	// RVA: 0x224B0E0 Offset: 0x22496E0 VA: 0x18224B0E0
	public void .ctor() { }

	// RVA: 0x224FB40 Offset: 0x224E140 VA: 0x18224FB40 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224FB70 Offset: 0x224E170 VA: 0x18224FB70 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x224FB10 Offset: 0x224E110 VA: 0x18224FB10 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224FBA0 Offset: 0x224E1A0 VA: 0x18224FBA0 Slot: 10
	public override string get_WebName() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 15
	public override bool get_IsMailNewsSave() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0x224FB00 Offset: 0x224E100 VA: 0x18224FB00 Slot: 40
	public override int GetMaxByteCount(int len) { }

	// RVA: 0x79A120 Offset: 0x798720 VA: 0x18079A120 Slot: 41
	public override int GetMaxCharCount(int len) { }

	// RVA: 0x224F790 Offset: 0x224DD90 VA: 0x18224F790 Slot: 19
	public override int GetByteCount(char[] chars, int index, int length) { }

	// RVA: 0x224F6F0 Offset: 0x224DCF0 VA: 0x18224F6F0 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x224F840 Offset: 0x224DE40 VA: 0x18224F840 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x224F900 Offset: 0x224DF00 VA: 0x18224F900 Slot: 29
	public override int GetCharCount(byte[] bytes, int start, int len) { }

	// RVA: 0x224F9A0 Offset: 0x224DFA0 VA: 0x18224F9A0 Slot: 33
	public override int GetChars(byte[] bytes, int byteIdx, int srclen, char[] chars, int charIdx) { }

	// RVA: 0x224FAA0 Offset: 0x224E0A0 VA: 0x18224FAA0 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x224FA40 Offset: 0x224E040 VA: 0x18224FA40 Slot: 38
	public override Decoder GetDecoder() { }

}

