internal sealed class SmpteData // TypeDefIndex: 7618
{	// Fields
	private static readonly Dictionary<SmpteFormat, byte> MaxFrames; // 0x0
	private static readonly SmpteFormat[] Formats; // 0x8
	private SmpteFormat _format; // 0x10
	private byte _hours; // 0x11
	private byte _minutes; // 0x12
	private byte _seconds; // 0x13
	private byte _frames; // 0x14
	private byte _subFrames; // 0x15

	// Properties
	public SmpteFormat Format { get; set; }
	public byte Hours { get; set; }
	public byte Minutes { get; set; }
	public byte Seconds { get; set; }
	public byte Frames { get; set; }
	public byte SubFrames { get; set; }

	// Methods

	// RVA: 0x13A64C0 Offset: 0x13A4AC0 VA: 0x1813A64C0
	public void .ctor() { }

	// RVA: 0x13A63F0 Offset: 0x13A49F0 VA: 0x1813A63F0
	public void .ctor(SmpteFormat format, byte hours, byte minutes, byte seconds, byte frames, byte subFrames) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public SmpteFormat get_Format() { }

	// RVA: 0x13A64E0 Offset: 0x13A4AE0 VA: 0x1813A64E0
	public void set_Format(SmpteFormat value) { }

	// RVA: 0xF8B3B0 Offset: 0xF899B0 VA: 0x180F8B3B0
	public byte get_Hours() { }

	// RVA: 0x13A6610 Offset: 0x13A4C10 VA: 0x1813A6610
	public void set_Hours(byte value) { }

	// RVA: 0xF9E160 Offset: 0xF9C760 VA: 0x180F9E160
	public byte get_Minutes() { }

	// RVA: 0x13A66A0 Offset: 0x13A4CA0 VA: 0x1813A66A0
	public void set_Minutes(byte value) { }

	// RVA: 0x13A64D0 Offset: 0x13A4AD0 VA: 0x1813A64D0
	public byte get_Seconds() { }

	// RVA: 0x13A6730 Offset: 0x13A4D30 VA: 0x1813A6730
	public void set_Seconds(byte value) { }

	// RVA: 0xA10E00 Offset: 0xA0F400 VA: 0x180A10E00
	public byte get_Frames() { }

	// RVA: 0x13A6530 Offset: 0x13A4B30 VA: 0x1813A6530
	public void set_Frames(byte value) { }

	// RVA: 0x13A53D0 Offset: 0x13A39D0 VA: 0x1813A53D0
	public byte get_SubFrames() { }

	// RVA: 0x13A67C0 Offset: 0x13A4DC0 VA: 0x1813A67C0
	public void set_SubFrames(byte value) { }

	// RVA: 0x13A5FF0 Offset: 0x13A45F0 VA: 0x1813A5FF0
	public static SmpteData Read(Func<byte> byteReader, Func<byte, string, byte, byte> valueProcessor) { }

	// RVA: 0x13A5F50 Offset: 0x13A4550 VA: 0x1813A5F50
	internal static SmpteFormat GetFormat(byte formatAndHours) { }

	// RVA: 0x13A5FE0 Offset: 0x13A45E0 VA: 0x1813A5FE0
	internal static byte GetHours(byte formatAndHours) { }

	// RVA: 0x13A62F0 Offset: 0x13A48F0 VA: 0x1813A62F0
	private static void .cctor() { }

}

