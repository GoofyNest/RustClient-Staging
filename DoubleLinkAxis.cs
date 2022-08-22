internal class DoubleLinkAxis : Axis // TypeDefIndex: 2135
{	// Fields
	internal Axis next; // 0x40

	// Properties
	internal Axis Next { get; set; }

	// Methods

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal Axis get_Next() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	internal void set_Next(Axis value) { }

	// RVA: 0x15170B0 Offset: 0x15156B0 VA: 0x1815170B0
	internal void .ctor(Axis axis, DoubleLinkAxis inputaxis) { }

	// RVA: 0x1516F80 Offset: 0x1515580 VA: 0x181516F80
	internal static DoubleLinkAxis ConvertTree(Axis axis) { }

}

