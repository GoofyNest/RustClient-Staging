public class TimeSpanConverter : TypeConverter // TypeDefIndex: 2750
{
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	public void .ctor() { }

}

internal static class TimeSpanConverter // TypeDefIndex: 7481
{	private static readonly Dictionary<TimeSpanType, Type> TimeSpansTypes; // 0x0
	private static readonly Dictionary<Type, ITimeSpanConverter> Converters; // 0x8


	public static TTimeSpan ConvertTo<TTimeSpan>(long timeSpan, long time, TempoMap tempoMap) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BA670 Offset: 0x15B8C70 VA: 0x1815BA670
	|-TimeSpanConverter.ConvertTo<object>
	*/

	public static ITimeSpan ConvertTo(ITimeSpan timeSpan, Type timeSpanType, long time, TempoMap tempoMap) { }

	public static long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap) { }

	private static ITimeSpanConverter GetConverter<TTimeSpan>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125FC00 Offset: 0x125E200 VA: 0x18125FC00
	|-TimeSpanConverter.GetConverter<object>
	*/

	private static ITimeSpanConverter GetConverter(Type timeSpanType) { }

	private static void .cctor() { }

}

