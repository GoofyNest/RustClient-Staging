internal abstract class AutoIncrementValue // TypeDefIndex: 4182
{	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private bool <Auto>k__BackingField; // 0x10

	internal bool Auto { get; set; }
	internal abstract object Current { get; set; }
	internal abstract long Seed { get; set; }
	internal abstract long Step { get; set; }
	internal abstract Type DataType { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal bool get_Auto() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal void set_Auto(bool value) { }

	internal abstract object get_Current();

	internal abstract void set_Current(object value);

	internal abstract long get_Seed();

	internal abstract void set_Seed(long value);

	internal abstract long get_Step();

	internal abstract void set_Step(long value);

	internal abstract Type get_DataType();

	internal abstract void SetCurrent(object value, IFormatProvider formatProvider);

	internal abstract void SetCurrentAndIncrement(object value);

	internal abstract void MoveAfter();

	internal AutoIncrementValue Clone() { }

	protected void .ctor() { }

}

