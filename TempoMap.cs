public sealed class TempoMap // TypeDefIndex: 7452
{	// Fields
	public static readonly TempoMap Default; // 0x0
	private ValueLine<TimeSignature> _timeSignatureLine; // 0x10
	private ValueLine<Tempo> _tempoLine; // 0x18
	private readonly List<ITempoMapValuesCache> _valuesCaches; // 0x20
	private bool _isTempoMapReady; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TimeDivision <TimeDivision>k__BackingField; // 0x30

	// Properties
	public TimeDivision TimeDivision { get; set; }
	internal ValueLine<TimeSignature> TimeSignatureLine { get; set; }
	internal ValueLine<Tempo> TempoLine { get; set; }
	internal bool IsTempoMapReady { get; }

	// Methods

	// RVA: 0x22019F0 Offset: 0x21FFFF0 VA: 0x1822019F0
	internal void .ctor(TimeDivision timeDivision) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public TimeDivision get_TimeDivision() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	internal void set_TimeDivision(TimeDivision value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal ValueLine<TimeSignature> get_TimeSignatureLine() { }

	// RVA: 0x2201C40 Offset: 0x2200240 VA: 0x182201C40
	internal void set_TimeSignatureLine(ValueLine<TimeSignature> value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal ValueLine<Tempo> get_TempoLine() { }

	// RVA: 0x2201B50 Offset: 0x2200150 VA: 0x182201B50
	internal void set_TempoLine(ValueLine<Tempo> value) { }

	// RVA: 0x9974E0 Offset: 0x995AE0 VA: 0x1809974E0
	internal bool get_IsTempoMapReady() { }

	// RVA: 0x22015E0 Offset: 0x21FFBE0 VA: 0x1822015E0
	internal TempoMap Flip(long centerTime) { }

	// RVA: -1 Offset: -1
	internal TCache GetValuesCache<TCache>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BAFD0 Offset: 0x15B95D0 VA: 0x1815BAFD0
	|-TempoMap.GetValuesCache<MetricTempoMapValuesCache>
	|-TempoMap.GetValuesCache<object>
	*/

	// RVA: 0x22016B0 Offset: 0x21FFCB0 VA: 0x1822016B0
	private void InvalidateCaches(TempoMapLine tempoMapLine) { }

	// RVA: 0x2201960 Offset: 0x21FFF60 VA: 0x182201960
	private void OnTimeSignatureChanged(object sender, EventArgs args) { }

	// RVA: 0x2201950 Offset: 0x21FFF50 VA: 0x182201950
	private void OnTempoChanged(object sender, EventArgs args) { }

	// RVA: 0x2201970 Offset: 0x21FFF70 VA: 0x182201970
	private static void .cctor() { }

}

private sealed class TempoMap.<>c__DisplayClass35_0 // TypeDefIndex: 7453
{	// Fields
	public TempoMapLine tempoMapLine; // 0x10
	public Func<ITempoMapValuesCache, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2205340 Offset: 0x2203940 VA: 0x182205340
	internal bool <InvalidateCaches>b__0(ITempoMapValuesCache c) { }

}

