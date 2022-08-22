public class TimeSpanConverter : TypeConverter // TypeDefIndex: 2750
{	// Methods

	// RVA: 0x1735450 Offset: 0x1733A50 VA: 0x181735450 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1735500 Offset: 0x1733B00 VA: 0x181735500 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x17355E0 Offset: 0x1733BE0 VA: 0x1817355E0 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x17357F0 Offset: 0x1733DF0 VA: 0x1817357F0 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1735AF0 Offset: 0x17340F0 VA: 0x181735AF0
	public void .ctor() { }

}

internal static class TimeSpanConverter // TypeDefIndex: 7481
{	// Fields
	private static readonly Dictionary<TimeSpanType, Type> TimeSpansTypes; // 0x0
	private static readonly Dictionary<Type, ITimeSpanConverter> Converters; // 0x8

	// Methods

	// RVA: -1 Offset: -1
	public static TTimeSpan ConvertTo<TTimeSpan>(long timeSpan, long time, TempoMap tempoMap) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BB1A0 Offset: 0x15B97A0 VA: 0x1815BB1A0
	|-TimeSpanConverter.ConvertTo<object>
	*/

	// RVA: 0x22024F0 Offset: 0x2200AF0 VA: 0x1822024F0
	public static ITimeSpan ConvertTo(ITimeSpan timeSpan, Type timeSpanType, long time, TempoMap tempoMap) { }

	// RVA: 0x22023C0 Offset: 0x22009C0 VA: 0x1822023C0
	public static long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap) { }

	// RVA: -1 Offset: -1
	private static ITimeSpanConverter GetConverter<TTimeSpan>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125F160 Offset: 0x125D760 VA: 0x18125F160
	|-TimeSpanConverter.GetConverter<object>
	*/

	// RVA: 0x2202680 Offset: 0x2200C80 VA: 0x182202680
	private static ITimeSpanConverter GetConverter(Type timeSpanType) { }

	// RVA: 0x2202760 Offset: 0x2200D60 VA: 0x182202760
	private static void .cctor() { }

}

