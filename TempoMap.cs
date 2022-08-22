public sealed class TempoMap // TypeDefIndex: 7452
{	// Fields
	public static readonly TempoMap Default; // 0x0
	private ValueLine<TimeSignature> _timeSignatureLine; // 0x10
	private ValueLine<Tempo> _tempoLine; // 0x18
	private readonly List<ITempoMapValuesCache> _valuesCaches; // 0x20
	private bool _isTempoMapReady; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TimeDivision <TimeDivision>k__BackingField; // 0x30

	// Properties
	public TimeDivision TimeDivision { get; set; }
	internal ValueLine<TimeSignature> TimeSignatureLine { get; set; }
	internal ValueLine<Tempo> TempoLine { get; set; }
	internal bool IsTempoMapReady { get; }

	// Methods

	// RVA: 0x2201830 Offset: 0x21FFE30 VA: 0x182201830
	internal void .ctor(TimeDivision timeDivision) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public TimeDivision get_TimeDivision() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	internal void set_TimeDivision(TimeDivision value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal ValueLine<TimeSignature> get_TimeSignatureLine() { }

	// RVA: 0x2201A80 Offset: 0x2200080 VA: 0x182201A80
	internal void set_TimeSignatureLine(ValueLine<TimeSignature> value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal ValueLine<Tempo> get_TempoLine() { }

	// RVA: 0x2201990 Offset: 0x21FFF90 VA: 0x182201990
	internal void set_TempoLine(ValueLine<Tempo> value) { }

	// RVA: 0x9974E0 Offset: 0x995AE0 VA: 0x1809974E0
	internal bool get_IsTempoMapReady() { }

	// RVA: 0x2201420 Offset: 0x21FFA20 VA: 0x182201420
	internal TempoMap Flip(long centerTime) { }

	// RVA: -1 Offset: -1
	internal TCache GetValuesCache<TCache>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BAFD0 Offset: 0x15B95D0 VA: 0x1815BAFD0
	|-TempoMap.GetValuesCache<MetricTempoMapValuesCache>
	|-TempoMap.GetValuesCache<object>
	*/

	// RVA: 0x22014F0 Offset: 0x21FFAF0 VA: 0x1822014F0
	private void InvalidateCaches(TempoMapLine tempoMapLine) { }

	// RVA: 0x22017A0 Offset: 0x21FFDA0 VA: 0x1822017A0
	private void OnTimeSignatureChanged(object sender, EventArgs args) { }

	// RVA: 0x2201790 Offset: 0x21FFD90 VA: 0x182201790
	private void OnTempoChanged(object sender, EventArgs args) { }

	// RVA: 0x22017B0 Offset: 0x21FFDB0 VA: 0x1822017B0
	private static void .cctor() { }

}

private sealed class TempoMap.<>c__DisplayClass35_0 // TypeDefIndex: 7453
{	// Fields
	public TempoMapLine tempoMapLine; // 0x10
	public Func<ITempoMapValuesCache, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2205180 Offset: 0x2203780 VA: 0x182205180
	internal bool <InvalidateCaches>b__0(ITempoMapValuesCache c) { }

}

