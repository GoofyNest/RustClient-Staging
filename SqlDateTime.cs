public struct SqlDateTime : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4343
{	// Fields
	private bool m_fNotNull; // 0x0
	private int m_day; // 0x4
	private int m_time; // 0x8
	private static readonly double s_SQLTicksPerMillisecond; // 0x0
	public static readonly int SQLTicksPerSecond; // 0x8
	public static readonly int SQLTicksPerMinute; // 0xC
	public static readonly int SQLTicksPerHour; // 0x10
	private static readonly int s_SQLTicksPerDay; // 0x14
	private static readonly long s_ticksPerSecond; // 0x18
	private static readonly DateTime s_SQLBaseDate; // 0x20
	private static readonly long s_SQLBaseDateTicks; // 0x28
	private static readonly int s_minYear; // 0x30
	private static readonly int s_maxYear; // 0x34
	private static readonly int s_minDay; // 0x38
	private static readonly int s_maxDay; // 0x3C
	private static readonly int s_minTime; // 0x40
	private static readonly int s_maxTime; // 0x44
	private static readonly int s_dayBase; // 0x48
	private static readonly int[] s_daysToMonth365; // 0x50
	private static readonly int[] s_daysToMonth366; // 0x58
	private static readonly DateTime s_minDateTime; // 0x60
	private static readonly DateTime s_maxDateTime; // 0x68
	private static readonly TimeSpan s_minTimeSpan; // 0x70
	private static readonly TimeSpan s_maxTimeSpan; // 0x78
	private static readonly string s_ISO8601_DateTimeFormat; // 0x80
	private static readonly string[] s_dateTimeFormats; // 0x88
	public static readonly SqlDateTime MinValue; // 0x90
	public static readonly SqlDateTime MaxValue; // 0x9C
	public static readonly SqlDateTime Null; // 0xA8

	// Properties
	public bool IsNull { get; }
	public DateTime Value { get; }
	public int DayTicks { get; }
	public int TimeTicks { get; }

	// Methods

	// RVA: 0x138DF0 Offset: 0x1381F0 VA: 0x180138DF0
	private void .ctor(bool fNull) { }

	// RVA: 0x138E10 Offset: 0x138210 VA: 0x180138E10
	public void .ctor(DateTime value) { }

	// RVA: 0x138E00 Offset: 0x138200 VA: 0x180138E00
	public void .ctor(int dayTicks, int timeTicks) { }

	// RVA: 0x118150 Offset: 0x117550 VA: 0x180118150 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0xEA0670 Offset: 0xE9EC70 VA: 0x180EA0670
	private static TimeSpan ToTimeSpan(SqlDateTime value) { }

	// RVA: 0xEA0560 Offset: 0xE9EB60 VA: 0x180EA0560
	private static DateTime ToDateTime(SqlDateTime value) { }

	// RVA: 0xE9FFC0 Offset: 0xE9E5C0 VA: 0x180E9FFC0
	private static SqlDateTime FromTimeSpan(TimeSpan value) { }

	// RVA: 0xE9FE90 Offset: 0xE9E490 VA: 0x180E9FE90
	private static SqlDateTime FromDateTime(DateTime value) { }

	// RVA: 0x138EE0 Offset: 0x1382E0 VA: 0x180138EE0
	public DateTime get_Value() { }

	// RVA: 0x138E20 Offset: 0x138220 VA: 0x180138E20
	public int get_DayTicks() { }

	// RVA: 0x138E80 Offset: 0x138280 VA: 0x180138E80
	public int get_TimeTicks() { }

	// RVA: 0xEA12B0 Offset: 0xE9F8B0 VA: 0x180EA12B0
	public static SqlDateTime op_Implicit(DateTime value) { }

	// RVA: 0x138D30 Offset: 0x138130 VA: 0x180138D30 Slot: 3
	public override string ToString() { }

	// RVA: 0xEA10D0 Offset: 0xE9F6D0 VA: 0x180EA10D0
	public static SqlBoolean op_Equality(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xEA12E0 Offset: 0xE9F8E0 VA: 0x180EA12E0
	public static SqlBoolean op_LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xEA11A0 Offset: 0xE9F7A0 VA: 0x180EA11A0
	public static SqlBoolean op_GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xEA02C0 Offset: 0xE9E8C0 VA: 0x180EA02C0
	public static SqlBoolean LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xEA0230 Offset: 0xE9E830 VA: 0x180EA0230
	public static SqlBoolean GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x1389D0 Offset: 0x137DD0 VA: 0x1801389D0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x138AF0 Offset: 0x137EF0 VA: 0x180138AF0
	public int CompareTo(SqlDateTime value) { }

	// RVA: 0x138B20 Offset: 0x137F20 VA: 0x180138B20 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x138B30 Offset: 0x137F30 VA: 0x180138B30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117D80 Offset: 0x117180 VA: 0x180117D80 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x138C00 Offset: 0x138000 VA: 0x180138C00 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x138C10 Offset: 0x138010 VA: 0x180138C10 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xEA01D0 Offset: 0xE9E7D0 VA: 0x180EA01D0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xEA0710 Offset: 0xE9ED10 VA: 0x180EA0710
	private static void .cctor() { }

}

