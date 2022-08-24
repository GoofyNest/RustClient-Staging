public class RangeConditionHeaderValue : ICloneable // TypeDefIndex: 5803
{	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Nullable<DateTimeOffset> <Date>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private EntityTagHeaderValue <EntityTag>k__BackingField; // 0x28

	public Nullable<DateTimeOffset> Date { get; set; }
	public EntityTagHeaderValue EntityTag { get; set; }


	public void .ctor(DateTimeOffset date) { }

	public void .ctor(EntityTagHeaderValue entityTag) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public EntityTagHeaderValue get_EntityTag() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_EntityTag(EntityTagHeaderValue value) { }

	private object System.ICloneable.Clone() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public static bool TryParse(string input, out RangeConditionHeaderValue parsedValue) { }

	public override string ToString() { }

}

