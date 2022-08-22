internal sealed class BarBeatFractionTimeSpanConverter : ITimeSpanConverter // TypeDefIndex: 7466
{	// Methods

	// RVA: 0x1391940 Offset: 0x138FF40 VA: 0x181391940 Slot: 4
	public ITimeSpan ConvertTo(long timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x13911E0 Offset: 0x138F7E0 VA: 0x1813911E0 Slot: 5
	public long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap) { }

	// RVA: 0x1391080 Offset: 0x138F680 VA: 0x181391080
	private static void CalculateComponents(long totalTicks, TimeSignature timeSignature, short ticksPerQuarterNote, out long bars, out long beats, out double fraction) { }

	// RVA: 0x1391170 Offset: 0x138F770 VA: 0x181391170
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

	// RVA: 0x13A9AB0 Offset: 0x13A80B0 VA: 0x1813A9AB0
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

	// RVA: 0x13A9C20 Offset: 0x13A8220 VA: 0x1813A9C20
	internal bool <ConvertFrom>b__0(ValueChange<TimeSignature> v) { }

	// RVA: 0x13A9C90 Offset: 0x13A8290 VA: 0x1813A9C90
	internal bool <ConvertFrom>b__1(ValueChange<TimeSignature> v) { }

}

