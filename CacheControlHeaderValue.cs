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

	// RVA: 0x1086400 Offset: 0x1084A00 VA: 0x181086400
	public ICollection<NameValueHeaderValue> get_Extensions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB11220 Offset: 0xB0F820 VA: 0x180B11220
	public Nullable<TimeSpan> get_MaxAge() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10865C0 Offset: 0x1084BC0 VA: 0x1810865C0
	public void set_MaxAge(Nullable<TimeSpan> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1040 Offset: 0x8BF640 VA: 0x1808C1040
	public bool get_MaxStale() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x78E170 Offset: 0x78C770 VA: 0x18078E170
	public void set_MaxStale(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1086470 Offset: 0x1084A70 VA: 0x181086470
	public Nullable<TimeSpan> get_MaxStaleLimit() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10865D0 Offset: 0x1084BD0 VA: 0x1810865D0
	public void set_MaxStaleLimit(Nullable<TimeSpan> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x105DDA0 Offset: 0x105C3A0 VA: 0x18105DDA0
	public Nullable<TimeSpan> get_MinFresh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10865E0 Offset: 0x1084BE0 VA: 0x1810865E0
	public void set_MinFresh(Nullable<TimeSpan> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4EFF0 Offset: 0xA4D5F0 VA: 0x180A4EFF0
	public bool get_MustRevalidate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6F1820 Offset: 0x6EFE20 VA: 0x1806F1820
	public void set_MustRevalidate(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10864F0 Offset: 0x1084AF0 VA: 0x1810864F0
	public bool get_NoCache() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10865F0 Offset: 0x1084BF0 VA: 0x1810865F0
	public void set_NoCache(bool value) { }

	// RVA: 0x1086480 Offset: 0x1084A80 VA: 0x181086480
	public ICollection<string> get_NoCacheHeaders() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1086500 Offset: 0x1084B00 VA: 0x181086500
	public bool get_NoStore() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1086600 Offset: 0x1084C00 VA: 0x181086600
	public void set_NoStore(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1086510 Offset: 0x1084B10 VA: 0x181086510
	public bool get_NoTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1086610 Offset: 0x1084C10 VA: 0x181086610
	public void set_NoTransform(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7AE500 Offset: 0x7ACB00 VA: 0x1807AE500
	public bool get_OnlyIfCached() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1086620 Offset: 0x1084C20 VA: 0x181086620
	public void set_OnlyIfCached(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7AE4F0 Offset: 0x7ACAF0 VA: 0x1807AE4F0
	public bool get_Private() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1086630 Offset: 0x1084C30 VA: 0x181086630
	public void set_Private(bool value) { }

	// RVA: 0x1086520 Offset: 0x1084B20 VA: 0x181086520
	public ICollection<string> get_PrivateHeaders() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1086590 Offset: 0x1084B90 VA: 0x181086590
	public bool get_ProxyRevalidate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1086640 Offset: 0x1084C40 VA: 0x181086640
	public void set_ProxyRevalidate(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10865A0 Offset: 0x1084BA0 VA: 0x1810865A0
	public bool get_Public() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1086650 Offset: 0x1084C50 VA: 0x181086650
	public void set_Public(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10865B0 Offset: 0x1084BB0 VA: 0x1810865B0
	public Nullable<TimeSpan> get_SharedMaxAge() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1086660 Offset: 0x1084C60 VA: 0x181086660
	public void set_SharedMaxAge(Nullable<TimeSpan> value) { }

	// RVA: 0x1084E80 Offset: 0x1083480 VA: 0x181084E80 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1084950 Offset: 0x1082F50 VA: 0x181084950 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1084C50 Offset: 0x1083250 VA: 0x181084C50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1085920 Offset: 0x1083F20 VA: 0x181085920
	public static bool TryParse(string input, out CacheControlHeaderValue parsedValue) { }

	// RVA: 0x1085310 Offset: 0x1083910 VA: 0x181085310 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

