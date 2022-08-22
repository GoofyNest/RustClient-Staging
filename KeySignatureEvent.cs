public sealed class KeySignatureEvent : MetaEvent // TypeDefIndex: 7538
{	// Fields
	private sbyte _key; // 0x20
	private byte _scale; // 0x21

	// Properties
	public sbyte Key { get; set; }
	public byte Scale { get; set; }

	// Methods

	// RVA: 0x1398E90 Offset: 0x1397490 VA: 0x181398E90
	public void .ctor() { }

	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80
	public sbyte get_Key() { }

	// RVA: 0x1398EB0 Offset: 0x13974B0 VA: 0x181398EB0
	public void set_Key(sbyte value) { }

	// RVA: 0xB10B90 Offset: 0xB0F190 VA: 0x180B10B90
	public byte get_Scale() { }

	// RVA: 0x1398F60 Offset: 0x1397560 VA: 0x181398F60
	public void set_Scale(byte value) { }

	// RVA: 0x1398B10 Offset: 0x1397110 VA: 0x181398B10
	private int ProcessValue(int value, string property, int min, int max, InvalidMetaEventParameterValuePolicy policy) { }

	// RVA: 0x1398C10 Offset: 0x1397210 VA: 0x181398C10 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x1398AA0 Offset: 0x13970A0 VA: 0x181398AA0 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x1398E10 Offset: 0x1397410 VA: 0x181398E10 Slot: 3
	public override string ToString() { }

}

