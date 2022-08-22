internal sealed class MathTimeSpanConverter : ITimeSpanConverter // TypeDefIndex: 7474
{	// Fields
	private static readonly Dictionary<TimeSpanMode, Func<MathTimeSpan, long, TempoMap, long>> Converters; // 0x2B10388

	// Methods

	// RVA: 0x139A900 Offset: 0x1398F00 VA: 0x18139A900 Slot: 4
	public ITimeSpan ConvertTo(long timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x139A780 Offset: 0x1398D80 VA: 0x18139A780 Slot: 5
	public long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x1399FD0 Offset: 0x13985D0 VA: 0x181399FD0
	private static long ConvertFromLengthLength(MathTimeSpan mathTimeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x139A2C0 Offset: 0x13988C0 VA: 0x18139A2C0
	private static long ConvertFromTimeLength(MathTimeSpan mathTimeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x139A500 Offset: 0x1398B00 VA: 0x18139A500
	private static long ConvertFromTimeTime(MathTimeSpan mathTimeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x139A960 Offset: 0x1398F60 VA: 0x18139A960
	private static void .cctor() { }

}

