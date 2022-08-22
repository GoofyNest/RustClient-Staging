public class RangeConditionHeaderValue : ICloneable // TypeDefIndex: 5803
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<DateTimeOffset> <Date>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EntityTagHeaderValue <EntityTag>k__BackingField; // 0x28

	// Properties
	public Nullable<DateTimeOffset> Date { get; set; }
	public EntityTagHeaderValue EntityTag { get; set; }

	// Methods

	// RVA: 0x1095E10 Offset: 0x1094410 VA: 0x181095E10
	public void .ctor(DateTimeOffset date) { }

	// RVA: 0x1095EA0 Offset: 0x10944A0 VA: 0x181095EA0
	public void .ctor(EntityTagHeaderValue entityTag) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1095F30 Offset: 0x1094530 VA: 0x181095F30
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1095F50 Offset: 0x1094550 VA: 0x181095F50
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public EntityTagHeaderValue get_EntityTag() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	private void set_EntityTag(EntityTagHeaderValue value) { }

	// RVA: 0xD71D90 Offset: 0xD70390 VA: 0x180D71D90 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1095820 Offset: 0x1093E20 VA: 0x181095820 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1095970 Offset: 0x1093F70 VA: 0x181095970 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1095AA0 Offset: 0x10940A0 VA: 0x181095AA0
	public static bool TryParse(string input, out RangeConditionHeaderValue parsedValue) { }

	// RVA: 0x10959E0 Offset: 0x1093FE0 VA: 0x1810959E0 Slot: 3
	public override string ToString() { }

}

