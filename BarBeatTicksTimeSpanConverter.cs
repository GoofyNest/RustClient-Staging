internal sealed class BarBeatTicksTimeSpanConverter : ITimeSpanConverter // TypeDefIndex: 7469
{	// Methods

	// RVA: 0x13947F0 Offset: 0x1392DF0 VA: 0x1813947F0 Slot: 4
	public ITimeSpan ConvertTo(long timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x13941C0 Offset: 0x13927C0 VA: 0x1813941C0 Slot: 5
	public long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x13940E0 Offset: 0x13926E0 VA: 0x1813940E0
	private static void CalculateComponents(long totalTicks, TimeSignature timeSignature, short ticksPerQuarterNote, out long bars, out long beats, out long ticks) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class BarBeatTicksTimeSpanConverter.<>c__DisplayClass0_0 // TypeDefIndex: 7470
{	// Fields
	public long time; // 0x10
	public long endTime; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13AA890 Offset: 0x13A8E90 VA: 0x1813AA890
	internal bool <ConvertTo>b__0(ValueChange<TimeSignature> v) { }

}

private sealed class BarBeatTicksTimeSpanConverter.<>c__DisplayClass1_0 // TypeDefIndex: 7471
{	// Fields
	public long time; // 0x10
	public long totalTicks; // 0x18
	public long lastTime; // 0x20
	public Func<ValueChange<TimeSignature>, bool> <>9__1; // 0x28

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13AA8F0 Offset: 0x13A8EF0 VA: 0x1813AA8F0
	internal bool <ConvertFrom>b__0(ValueChange<TimeSignature> v) { }

	// RVA: 0x13AA960 Offset: 0x13A8F60 VA: 0x1813AA960
	internal bool <ConvertFrom>b__1(ValueChange<TimeSignature> v) { }

}

