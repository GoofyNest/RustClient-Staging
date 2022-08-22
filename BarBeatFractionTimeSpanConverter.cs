internal sealed class BarBeatFractionTimeSpanConverter : ITimeSpanConverter // TypeDefIndex: 7466
{	// Methods

	// RVA: 0x1392840 Offset: 0x1390E40 VA: 0x181392840 Slot: 4
	public ITimeSpan ConvertTo(long timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x13920E0 Offset: 0x13906E0 VA: 0x1813920E0 Slot: 5
	public long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x1391F80 Offset: 0x1390580 VA: 0x181391F80
	private static void CalculateComponents(long totalTicks, TimeSignature timeSignature, short ticksPerQuarterNote, out long bars, out long beats, out double fraction) { }

	// RVA: 0x1392070 Offset: 0x1390670 VA: 0x181392070
	private static long ConvertFractionToTicks(double fraction, long beatLength) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class BarBeatFractionTimeSpanConverter.<>c__DisplayClass1_0 // TypeDefIndex: 7467
{	// Fields
	public long time; // 0x10
	public long endTime; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13AA9B0 Offset: 0x13A8FB0 VA: 0x1813AA9B0
	internal bool <ConvertTo>b__0(ValueChange<TimeSignature> v) { }

}

private sealed class BarBeatFractionTimeSpanConverter.<>c__DisplayClass2_0 // TypeDefIndex: 7468
{	// Fields
	public long time; // 0x10
	public long totalTicks; // 0x18
	public long lastTime; // 0x20
	public Func<ValueChange<TimeSignature>, bool> <>9__1; // 0x28

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13AAB20 Offset: 0x13A9120 VA: 0x1813AAB20
	internal bool <ConvertFrom>b__0(ValueChange<TimeSignature> v) { }

	// RVA: 0x13AAB90 Offset: 0x13A9190 VA: 0x1813AAB90
	internal bool <ConvertFrom>b__1(ValueChange<TimeSignature> v) { }

}

