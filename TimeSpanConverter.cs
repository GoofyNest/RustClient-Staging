public class TimeSpanConverter : TypeConverter // TypeDefIndex: 2750
{	// Methods

	// RVA: 0x1735710 Offset: 0x1733D10 VA: 0x181735710 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x17357C0 Offset: 0x1733DC0 VA: 0x1817357C0 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x17358A0 Offset: 0x1733EA0 VA: 0x1817358A0 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1735AB0 Offset: 0x17340B0 VA: 0x181735AB0 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1735DB0 Offset: 0x17343B0 VA: 0x181735DB0
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
	|-RVA: 0x15BB460 Offset: 0x15B9A60 VA: 0x1815BB460
	|-TimeSpanConverter.ConvertTo<object>
	*/

	// RVA: 0x22027B0 Offset: 0x2200DB0 VA: 0x1822027B0
	public static ITimeSpan ConvertTo(ITimeSpan timeSpan, Type timeSpanType, long time, TempoMap tempoMap) { }

	// RVA: 0x2202680 Offset: 0x2200C80 VA: 0x182202680
	public static long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap) { }

	// RVA: -1 Offset: -1
	private static ITimeSpanConverter GetConverter<TTimeSpan>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125F420 Offset: 0x125DA20 VA: 0x18125F420
	|-TimeSpanConverter.GetConverter<object>
	*/

	// RVA: 0x2202940 Offset: 0x2200F40 VA: 0x182202940
	private static ITimeSpanConverter GetConverter(Type timeSpanType) { }

	// RVA: 0x2202A20 Offset: 0x2201020 VA: 0x182202A20
	private static void .cctor() { }

}

