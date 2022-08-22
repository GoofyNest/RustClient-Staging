internal sealed class BarBeatTicksTimeSpanConverter : ITimeSpanConverter // TypeDefIndex: 7469
{	// Methods

	// RVA: 0x13938F0 Offset: 0x1391EF0 VA: 0x1813938F0 Slot: 4
	public ITimeSpan ConvertTo(long timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x13932C0 Offset: 0x13918C0 VA: 0x1813932C0 Slot: 5
	public long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x13931E0 Offset: 0x13917E0 VA: 0x1813931E0
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

	// RVA: 0x13A9990 Offset: 0x13A7F90 VA: 0x1813A9990
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

	// RVA: 0x13A99F0 Offset: 0x13A7FF0 VA: 0x1813A99F0
	internal bool <ConvertFrom>b__0(ValueChange<TimeSignature> v) { }

	// RVA: 0x13A9A60 Offset: 0x13A8060 VA: 0x1813A9A60
	internal bool <ConvertFrom>b__1(ValueChange<TimeSignature> v) { }

}

