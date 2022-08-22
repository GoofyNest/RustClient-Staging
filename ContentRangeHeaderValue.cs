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

	// RVA: 0x1087B20 Offset: 0x1086120 VA: 0x181087B20
	private void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB11230 Offset: 0xB0F830 VA: 0x180B11230
	public Nullable<long> get_From() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1087B70 Offset: 0x1086170 VA: 0x181087B70
	private void set_From(Nullable<long> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB11220 Offset: 0xB0F820 VA: 0x180B11220
	public Nullable<long> get_Length() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10865C0 Offset: 0x1084BC0 VA: 0x1810865C0
	private void set_Length(Nullable<long> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6FC1B0 Offset: 0x6FA7B0 VA: 0x1806FC1B0
	public Nullable<long> get_To() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1087B80 Offset: 0x1086180 VA: 0x181087B80
	private void set_To(Nullable<long> value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Unit() { }

	// RVA: 0xD71020 Offset: 0xD6F620 VA: 0x180D71020 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1087050 Offset: 0x1085650 VA: 0x181087050 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x10871A0 Offset: 0x10857A0 VA: 0x1810871A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10874B0 Offset: 0x1085AB0 VA: 0x1810874B0
	public static bool TryParse(string input, out ContentRangeHeaderValue parsedValue) { }

	// RVA: 0x10872A0 Offset: 0x10858A0 VA: 0x1810872A0 Slot: 3
	public override string ToString() { }

}

