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

	// RVA: 0x138FD0 Offset: 0x1383D0 VA: 0x180138FD0
	private void .ctor(bool fNull) { }

	// RVA: 0x138FF0 Offset: 0x1383F0 VA: 0x180138FF0
	public void .ctor(DateTime value) { }

	// RVA: 0x138FE0 Offset: 0x1383E0 VA: 0x180138FE0
	public void .ctor(int dayTicks, int timeTicks) { }

	// RVA: 0x118150 Offset: 0x117550 VA: 0x180118150 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0xE9F900 Offset: 0xE9DF00 VA: 0x180E9F900
	private static TimeSpan ToTimeSpan(SqlDateTime value) { }

	// RVA: 0xE9F7F0 Offset: 0xE9DDF0 VA: 0x180E9F7F0
	private static DateTime ToDateTime(SqlDateTime value) { }

	// RVA: 0xE9F250 Offset: 0xE9D850 VA: 0x180E9F250
	private static SqlDateTime FromTimeSpan(TimeSpan value) { }

	// RVA: 0xE9F120 Offset: 0xE9D720 VA: 0x180E9F120
	private static SqlDateTime FromDateTime(DateTime value) { }

	// RVA: 0x1390C0 Offset: 0x1384C0 VA: 0x1801390C0
	public DateTime get_Value() { }

	// RVA: 0x139000 Offset: 0x138400 VA: 0x180139000
	public int get_DayTicks() { }

	// RVA: 0x139060 Offset: 0x138460 VA: 0x180139060
	public int get_TimeTicks() { }

	// RVA: 0xEA0540 Offset: 0xE9EB40 VA: 0x180EA0540
	public static SqlDateTime op_Implicit(DateTime value) { }

	// RVA: 0x138F10 Offset: 0x138310 VA: 0x180138F10 Slot: 3
	public override string ToString() { }

	// RVA: 0xEA0360 Offset: 0xE9E960 VA: 0x180EA0360
	public static SqlBoolean op_Equality(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xEA0570 Offset: 0xE9EB70 VA: 0x180EA0570
	public static SqlBoolean op_LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xEA0430 Offset: 0xE9EA30 VA: 0x180EA0430
	public static SqlBoolean op_GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xE9F550 Offset: 0xE9DB50 VA: 0x180E9F550
	public static SqlBoolean LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xE9F4C0 Offset: 0xE9DAC0 VA: 0x180E9F4C0
	public static SqlBoolean GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x138BB0 Offset: 0x137FB0 VA: 0x180138BB0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x138CD0 Offset: 0x1380D0 VA: 0x180138CD0
	public int CompareTo(SqlDateTime value) { }

	// RVA: 0x138D00 Offset: 0x138100 VA: 0x180138D00 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x138D10 Offset: 0x138110 VA: 0x180138D10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117D80 Offset: 0x117180 VA: 0x180117D80 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x138DE0 Offset: 0x1381E0 VA: 0x180138DE0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x138DF0 Offset: 0x1381F0 VA: 0x180138DF0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xE9F460 Offset: 0xE9DA60 VA: 0x180E9F460
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xE9F9A0 Offset: 0xE9DFA0 VA: 0x180E9F9A0
	private static void .cctor() { }

}

