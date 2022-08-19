internal sealed class BarBeatFractionTimeSpanConverter : ITimeSpanConverter // TypeDefIndex: 7466
{	// Methods

	// RVA: 0x1392580 Offset: 0x1390B80 VA: 0x181392580 Slot: 4
	public ITimeSpan ConvertTo(long timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x1391E20 Offset: 0x1390420 VA: 0x181391E20 Slot: 5
	public long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x1391CC0 Offset: 0x13902C0 VA: 0x181391CC0
	private static void CalculateComponents(long totalTicks, TimeSignature timeSignature, short ticksPerQuarterNote, out long bars, out long beats, out double fraction) { }

	// RVA: 0x1391DB0 Offset: 0x13903B0 VA: 0x181391DB0
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

	// RVA: 0x13AA6F0 Offset: 0x13A8CF0 VA: 0x1813AA6F0
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

	// RVA: 0x13AA860 Offset: 0x13A8E60 VA: 0x1813AA860
	internal bool <ConvertFrom>b__0(ValueChange<TimeSignature> v) { }

	// RVA: 0x13AA8D0 Offset: 0x13A8ED0 VA: 0x1813AA8D0
	internal bool <ConvertFrom>b__1(ValueChange<TimeSignature> v) { }

}

