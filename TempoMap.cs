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

	// RVA: 0x2202310 Offset: 0x2200910 VA: 0x182202310
	internal void .ctor(TimeDivision timeDivision) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public TimeDivision get_TimeDivision() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	internal void set_TimeDivision(TimeDivision value) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal ValueLine<TimeSignature> get_TimeSignatureLine() { }

	// RVA: 0x2202560 Offset: 0x2200B60 VA: 0x182202560
	internal void set_TimeSignatureLine(ValueLine<TimeSignature> value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal ValueLine<Tempo> get_TempoLine() { }

	// RVA: 0x2202470 Offset: 0x2200A70 VA: 0x182202470
	internal void set_TempoLine(ValueLine<Tempo> value) { }

	// RVA: 0x997AE0 Offset: 0x9960E0 VA: 0x180997AE0
	internal bool get_IsTempoMapReady() { }

	// RVA: 0x2201F00 Offset: 0x2200500 VA: 0x182201F00
	internal TempoMap Flip(long centerTime) { }

	// RVA: -1 Offset: -1
	internal TCache GetValuesCache<TCache>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BA360 Offset: 0x15B8960 VA: 0x1815BA360
	|-TempoMap.GetValuesCache<MetricTempoMapValuesCache>
	|-TempoMap.GetValuesCache<object>
	*/

	// RVA: 0x2201FD0 Offset: 0x22005D0 VA: 0x182201FD0
	private void InvalidateCaches(TempoMapLine tempoMapLine) { }

	// RVA: 0x2202280 Offset: 0x2200880 VA: 0x182202280
	private void OnTimeSignatureChanged(object sender, EventArgs args) { }

	// RVA: 0x2202270 Offset: 0x2200870 VA: 0x182202270
	private void OnTempoChanged(object sender, EventArgs args) { }

	// RVA: 0x2202290 Offset: 0x2200890 VA: 0x182202290
	private static void .cctor() { }

}

private sealed class TempoMap.<>c__DisplayClass35_0 // TypeDefIndex: 7453
{	// Fields
	public TempoMapLine tempoMapLine; // 0x10
	public Func<ITempoMapValuesCache, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2205C60 Offset: 0x2204260 VA: 0x182205C60
	internal bool <InvalidateCaches>b__0(ITempoMapValuesCache c) { }

}

