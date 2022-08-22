public class ContentRangeHeaderValue : ICloneable // TypeDefIndex: 5764
{	// Fields
	private string unit; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<long> <From>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<long> <Length>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<long> <To>k__BackingField; // 0x38

	// Properties
	public Nullable<long> From { get; set; }
	public Nullable<long> Length { get; set; }
	public Nullable<long> To { get; set; }
	public string Unit { get; }

	// Methods

	// RVA: 0x1087DE0 Offset: 0x10863E0 VA: 0x181087DE0
	private void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB114F0 Offset: 0xB0FAF0 VA: 0x180B114F0
	public Nullable<long> get_From() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1087E30 Offset: 0x1086430 VA: 0x181087E30
	private void set_From(Nullable<long> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB114E0 Offset: 0xB0FAE0 VA: 0x180B114E0
	public Nullable<long> get_Length() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1086880 Offset: 0x1084E80 VA: 0x181086880
	private void set_Length(Nullable<long> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6FC2C0 Offset: 0x6FA8C0 VA: 0x1806FC2C0
	public Nullable<long> get_To() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1087E40 Offset: 0x1086440 VA: 0x181087E40
	private void set_To(Nullable<long> value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Unit() { }

	// RVA: 0xD712E0 Offset: 0xD6F8E0 VA: 0x180D712E0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1087310 Offset: 0x1085910 VA: 0x181087310 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1087460 Offset: 0x1085A60 VA: 0x181087460 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1087770 Offset: 0x1085D70 VA: 0x181087770
	public static bool TryParse(string input, out ContentRangeHeaderValue parsedValue) { }

	// RVA: 0x1087560 Offset: 0x1085B60 VA: 0x181087560 Slot: 3
	public override string ToString() { }

}

