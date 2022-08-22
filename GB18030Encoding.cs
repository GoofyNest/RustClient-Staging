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

	// RVA: 0x224BBC0 Offset: 0x224A1C0 VA: 0x18224BBC0
	public void .ctor() { }

	// RVA: 0x2250620 Offset: 0x224EC20 VA: 0x182250620 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x2250650 Offset: 0x224EC50 VA: 0x182250650 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x22505F0 Offset: 0x224EBF0 VA: 0x1822505F0 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x2250680 Offset: 0x224EC80 VA: 0x182250680 Slot: 10
	public override string get_WebName() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 15
	public override bool get_IsMailNewsSave() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0x22505E0 Offset: 0x224EBE0 VA: 0x1822505E0 Slot: 40
	public override int GetMaxByteCount(int len) { }

	// RVA: 0x79A140 Offset: 0x798740 VA: 0x18079A140 Slot: 41
	public override int GetMaxCharCount(int len) { }

	// RVA: 0x2250270 Offset: 0x224E870 VA: 0x182250270 Slot: 19
	public override int GetByteCount(char[] chars, int index, int length) { }

	// RVA: 0x22501D0 Offset: 0x224E7D0 VA: 0x1822501D0 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x2250320 Offset: 0x224E920 VA: 0x182250320 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x22503E0 Offset: 0x224E9E0 VA: 0x1822503E0 Slot: 29
	public override int GetCharCount(byte[] bytes, int start, int len) { }

	// RVA: 0x2250480 Offset: 0x224EA80 VA: 0x182250480 Slot: 33
	public override int GetChars(byte[] bytes, int byteIdx, int srclen, char[] chars, int charIdx) { }

	// RVA: 0x2250580 Offset: 0x224EB80 VA: 0x182250580 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x2250520 Offset: 0x224EB20 VA: 0x182250520 Slot: 38
	public override Decoder GetDecoder() { }

}

