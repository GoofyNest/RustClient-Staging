public sealed class SmpteOffsetEvent : MetaEvent // TypeDefIndex: 7547
{	// Fields
	private SmpteData _smpteData; // 0x20

	// Properties
	public SmpteFormat Format { get; set; }
	public byte Hours { get; set; }
	public byte Minutes { get; set; }
	public byte Seconds { get; set; }
	public byte Frames { get; set; }
	public byte SubFrames { get; set; }

	// Methods

	// RVA: 0x13A7240 Offset: 0x13A5840 VA: 0x1813A7240
	public void .ctor() { }

	// RVA: 0x13A72B0 Offset: 0x13A58B0 VA: 0x1813A72B0
	public void .ctor(SmpteFormat format, byte hours, byte minutes, byte seconds, byte frames, byte subFrames) { }

	// RVA: 0x13A7400 Offset: 0x13A5A00 VA: 0x1813A7400
	public SmpteFormat get_Format() { }

	// RVA: 0x13A74C0 Offset: 0x13A5AC0 VA: 0x1813A74C0
	public void set_Format(SmpteFormat value) { }

	// RVA: 0x13A7440 Offset: 0x13A5A40 VA: 0x1813A7440
	public byte get_Hours() { }

	// RVA: 0x13A7540 Offset: 0x13A5B40 VA: 0x1813A7540
	public void set_Hours(byte value) { }

	// RVA: 0x13A7460 Offset: 0x13A5A60 VA: 0x1813A7460
	public byte get_Minutes() { }

	// RVA: 0x13A7560 Offset: 0x13A5B60 VA: 0x1813A7560
	public void set_Minutes(byte value) { }

	// RVA: 0x13A7480 Offset: 0x13A5A80 VA: 0x1813A7480
	public byte get_Seconds() { }

	// RVA: 0x13A7580 Offset: 0x13A5B80 VA: 0x1813A7580
	public void set_Seconds(byte value) { }

	// RVA: 0x13A7420 Offset: 0x13A5A20 VA: 0x1813A7420
	public byte get_Frames() { }

	// RVA: 0x13A7520 Offset: 0x13A5B20 VA: 0x1813A7520
	public void set_Frames(byte value) { }

	// RVA: 0x13A74A0 Offset: 0x13A5AA0 VA: 0x1813A74A0
	public byte get_SubFrames() { }

	// RVA: 0x13A75A0 Offset: 0x13A5BA0 VA: 0x1813A75A0
	public void set_SubFrames(byte value) { }

	// RVA: 0x13A6CD0 Offset: 0x13A52D0 VA: 0x1813A6CD0
	private byte ProcessValue(byte value, string property, byte max, InvalidMetaEventParameterValuePolicy policy) { }

	// RVA: 0x13A6DB0 Offset: 0x13A53B0 VA: 0x1813A6DB0 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A6B10 Offset: 0x13A5110 VA: 0x1813A6B10 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A6ED0 Offset: 0x13A54D0 VA: 0x1813A6ED0 Slot: 3
	public override string ToString() { }

}

private sealed class SmpteOffsetEvent.<>c__DisplayClass22_0 // TypeDefIndex: 7548
{	// Fields
	public SmpteOffsetEvent <>4__this; // 0x10
	public ReadingSettings settings; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13AAA10 Offset: 0x13A9010 VA: 0x1813AAA10
	internal byte <ReadContent>b__0(byte value, string propertyName, byte max) { }

}

