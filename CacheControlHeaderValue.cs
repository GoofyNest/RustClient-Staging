public class CacheControlHeaderValue : ICloneable // TypeDefIndex: 5759
{	// Fields
	private List<NameValueHeaderValue> extensions; // 0x10
	private List<string> no_cache_headers; // 0x18
	private List<string> private_headers; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<TimeSpan> <MaxAge>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <MaxStale>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<TimeSpan> <MaxStaleLimit>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<TimeSpan> <MinFresh>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <MustRevalidate>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <NoCache>k__BackingField; // 0x61
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <NoStore>k__BackingField; // 0x62
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <NoTransform>k__BackingField; // 0x63
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <OnlyIfCached>k__BackingField; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <Private>k__BackingField; // 0x65
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <ProxyRevalidate>k__BackingField; // 0x66
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <Public>k__BackingField; // 0x67
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<TimeSpan> <SharedMaxAge>k__BackingField; // 0x68

	// Properties
	public ICollection<NameValueHeaderValue> Extensions { get; }
	public Nullable<TimeSpan> MaxAge { get; set; }
	public bool MaxStale { get; set; }
	public Nullable<TimeSpan> MaxStaleLimit { get; set; }
	public Nullable<TimeSpan> MinFresh { get; set; }
	public bool MustRevalidate { get; set; }
	public bool NoCache { get; set; }
	public ICollection<string> NoCacheHeaders { get; }
	public bool NoStore { get; set; }
	public bool NoTransform { get; set; }
	public bool OnlyIfCached { get; set; }
	public bool Private { get; set; }
	public ICollection<string> PrivateHeaders { get; }
	public bool ProxyRevalidate { get; set; }
	public bool Public { get; set; }
	public Nullable<TimeSpan> SharedMaxAge { get; set; }

	// Methods

	// RVA: 0x10866C0 Offset: 0x1084CC0 VA: 0x1810866C0
	public ICollection<NameValueHeaderValue> get_Extensions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB114E0 Offset: 0xB0FAE0 VA: 0x180B114E0
	public Nullable<TimeSpan> get_MaxAge() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1086880 Offset: 0x1084E80 VA: 0x181086880
	public void set_MaxAge(Nullable<TimeSpan> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1150 Offset: 0x8BF750 VA: 0x1808C1150
	public bool get_MaxStale() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x78E280 Offset: 0x78C880 VA: 0x18078E280
	public void set_MaxStale(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1086730 Offset: 0x1084D30 VA: 0x181086730
	public Nullable<TimeSpan> get_MaxStaleLimit() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1086890 Offset: 0x1084E90 VA: 0x181086890
	public void set_MaxStaleLimit(Nullable<TimeSpan> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x105E060 Offset: 0x105C660 VA: 0x18105E060
	public Nullable<TimeSpan> get_MinFresh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10868A0 Offset: 0x1084EA0 VA: 0x1810868A0
	public void set_MinFresh(Nullable<TimeSpan> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4F2B0 Offset: 0xA4D8B0 VA: 0x180A4F2B0
	public bool get_MustRevalidate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6F1930 Offset: 0x6EFF30 VA: 0x1806F1930
	public void set_MustRevalidate(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10867B0 Offset: 0x1084DB0 VA: 0x1810867B0
	public bool get_NoCache() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10868B0 Offset: 0x1084EB0 VA: 0x1810868B0
	public void set_NoCache(bool value) { }

	// RVA: 0x1086740 Offset: 0x1084D40 VA: 0x181086740
	public ICollection<string> get_NoCacheHeaders() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10867C0 Offset: 0x1084DC0 VA: 0x1810867C0
	public bool get_NoStore() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10868C0 Offset: 0x1084EC0 VA: 0x1810868C0
	public void set_NoStore(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10867D0 Offset: 0x1084DD0 VA: 0x1810867D0
	public bool get_NoTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10868D0 Offset: 0x1084ED0 VA: 0x1810868D0
	public void set_NoTransform(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7AE610 Offset: 0x7ACC10 VA: 0x1807AE610
	public bool get_OnlyIfCached() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10868E0 Offset: 0x1084EE0 VA: 0x1810868E0
	public void set_OnlyIfCached(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7AE600 Offset: 0x7ACC00 VA: 0x1807AE600
	public bool get_Private() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10868F0 Offset: 0x1084EF0 VA: 0x1810868F0
	public void set_Private(bool value) { }

	// RVA: 0x10867E0 Offset: 0x1084DE0 VA: 0x1810867E0
	public ICollection<string> get_PrivateHeaders() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1086850 Offset: 0x1084E50 VA: 0x181086850
	public bool get_ProxyRevalidate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1086900 Offset: 0x1084F00 VA: 0x181086900
	public void set_ProxyRevalidate(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1086860 Offset: 0x1084E60 VA: 0x181086860
	public bool get_Public() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1086910 Offset: 0x1084F10 VA: 0x181086910
	public void set_Public(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1086870 Offset: 0x1084E70 VA: 0x181086870
	public Nullable<TimeSpan> get_SharedMaxAge() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1086920 Offset: 0x1084F20 VA: 0x181086920
	public void set_SharedMaxAge(Nullable<TimeSpan> value) { }

	// RVA: 0x1085140 Offset: 0x1083740 VA: 0x181085140 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1084C10 Offset: 0x1083210 VA: 0x181084C10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1084F10 Offset: 0x1083510 VA: 0x181084F10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1085BE0 Offset: 0x10841E0 VA: 0x181085BE0
	public static bool TryParse(string input, out CacheControlHeaderValue parsedValue) { }

	// RVA: 0x10855D0 Offset: 0x1083BD0 VA: 0x1810855D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

