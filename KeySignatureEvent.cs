public sealed class KeySignatureEvent : MetaEvent // TypeDefIndex: 7538
{	// Fields
	private sbyte _key; // 0x20
	private byte _scale; // 0x21

	// Properties
	public sbyte Key { get; set; }
	public byte Scale { get; set; }

	// Methods

	// RVA: 0x1399D90 Offset: 0x1398390 VA: 0x181399D90
	public void .ctor() { }

	// RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0
	public sbyte get_Key() { }

	// RVA: 0x1399DB0 Offset: 0x13983B0 VA: 0x181399DB0
	public void set_Key(sbyte value) { }

	// RVA: 0xB106C0 Offset: 0xB0ECC0 VA: 0x180B106C0
	public byte get_Scale() { }

	// RVA: 0x1399E60 Offset: 0x1398460 VA: 0x181399E60
	public void set_Scale(byte value) { }

	// RVA: 0x1399A10 Offset: 0x1398010 VA: 0x181399A10
	private int ProcessValue(int value, string property, int min, int max, InvalidMetaEventParameterValuePolicy policy) { }

	// RVA: 0x1399B10 Offset: 0x1398110 VA: 0x181399B10 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13999A0 Offset: 0x1397FA0 VA: 0x1813999A0 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x1399D10 Offset: 0x1398310 VA: 0x181399D10 Slot: 3
	public override string ToString() { }

}

