internal class DoubleLinkAxis : Axis // TypeDefIndex: 2135
{	// Fields
	internal Axis next; // 0x40

	// Properties
	internal Axis Next { get; set; }

	// Methods

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	internal Axis get_Next() { }

	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	internal void set_Next(Axis value) { }

	// RVA: 0x1516180 Offset: 0x1514780 VA: 0x181516180
	internal void .ctor(Axis axis, DoubleLinkAxis inputaxis) { }

	// RVA: 0x1516050 Offset: 0x1514650 VA: 0x181516050
	internal static DoubleLinkAxis ConvertTree(Axis axis) { }

}

