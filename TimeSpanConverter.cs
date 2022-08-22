public class TimeSpanConverter : TypeConverter // TypeDefIndex: 2750
{	// Methods

	// RVA: 0x17332D0 Offset: 0x17318D0 VA: 0x1817332D0 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1733380 Offset: 0x1731980 VA: 0x181733380 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1733460 Offset: 0x1731A60 VA: 0x181733460 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1733670 Offset: 0x1731C70 VA: 0x181733670 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1733970 Offset: 0x1731F70 VA: 0x181733970
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
	|-RVA: 0x15BA530 Offset: 0x15B8B30 VA: 0x1815BA530
	|-TimeSpanConverter.ConvertTo<object>
	*/

	// RVA: 0x2202FD0 Offset: 0x22015D0 VA: 0x182202FD0
	public static ITimeSpan ConvertTo(ITimeSpan timeSpan, Type timeSpanType, long time, TempoMap tempoMap) { }

	// RVA: 0x2202EA0 Offset: 0x22014A0 VA: 0x182202EA0
	public static long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap) { }

	// RVA: -1 Offset: -1
	private static ITimeSpanConverter GetConverter<TTimeSpan>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125FAC0 Offset: 0x125E0C0 VA: 0x18125FAC0
	|-TimeSpanConverter.GetConverter<object>
	*/

	// RVA: 0x2203160 Offset: 0x2201760 VA: 0x182203160
	private static ITimeSpanConverter GetConverter(Type timeSpanType) { }

	// RVA: 0x2203240 Offset: 0x2201840 VA: 0x182203240
	private static void .cctor() { }

}

