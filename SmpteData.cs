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

	// RVA: 0x13A6780 Offset: 0x13A4D80 VA: 0x1813A6780
	public void .ctor() { }

	// RVA: 0x13A66B0 Offset: 0x13A4CB0 VA: 0x1813A66B0
	public void .ctor(SmpteFormat format, byte hours, byte minutes, byte seconds, byte frames, byte subFrames) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public SmpteFormat get_Format() { }

	// RVA: 0x13A67A0 Offset: 0x13A4DA0 VA: 0x1813A67A0
	public void set_Format(SmpteFormat value) { }

	// RVA: 0xF8B670 Offset: 0xF89C70 VA: 0x180F8B670
	public byte get_Hours() { }

	// RVA: 0x13A68D0 Offset: 0x13A4ED0 VA: 0x1813A68D0
	public void set_Hours(byte value) { }

	// RVA: 0xF9E420 Offset: 0xF9CA20 VA: 0x180F9E420
	public byte get_Minutes() { }

	// RVA: 0x13A6960 Offset: 0x13A4F60 VA: 0x1813A6960
	public void set_Minutes(byte value) { }

	// RVA: 0x13A6790 Offset: 0x13A4D90 VA: 0x1813A6790
	public byte get_Seconds() { }

	// RVA: 0x13A69F0 Offset: 0x13A4FF0 VA: 0x1813A69F0
	public void set_Seconds(byte value) { }

	// RVA: 0xA110C0 Offset: 0xA0F6C0 VA: 0x180A110C0
	public byte get_Frames() { }

	// RVA: 0x13A67F0 Offset: 0x13A4DF0 VA: 0x1813A67F0
	public void set_Frames(byte value) { }

	// RVA: 0x13A5690 Offset: 0x13A3C90 VA: 0x1813A5690
	public byte get_SubFrames() { }

	// RVA: 0x13A6A80 Offset: 0x13A5080 VA: 0x1813A6A80
	public void set_SubFrames(byte value) { }

	// RVA: 0x13A62B0 Offset: 0x13A48B0 VA: 0x1813A62B0
	public static SmpteData Read(Func<byte> byteReader, Func<byte, string, byte, byte> valueProcessor) { }

	// RVA: 0x13A6210 Offset: 0x13A4810 VA: 0x1813A6210
	internal static SmpteFormat GetFormat(byte formatAndHours) { }

	// RVA: 0x13A62A0 Offset: 0x13A48A0 VA: 0x1813A62A0
	internal static byte GetHours(byte formatAndHours) { }

	// RVA: 0x13A65B0 Offset: 0x13A4BB0 VA: 0x1813A65B0
	private static void .cctor() { }

}

