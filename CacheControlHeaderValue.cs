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

	// RVA: 0x1087130 Offset: 0x1085730 VA: 0x181087130
	public ICollection<NameValueHeaderValue> get_Extensions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB119B0 Offset: 0xB0FFB0 VA: 0x180B119B0
	public Nullable<TimeSpan> get_MaxAge() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10872F0 Offset: 0x10858F0 VA: 0x1810872F0
	public void set_MaxAge(Nullable<TimeSpan> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1660 Offset: 0x8BFC60 VA: 0x1808C1660
	public bool get_MaxStale() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x78E190 Offset: 0x78C790 VA: 0x18078E190
	public void set_MaxStale(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10871A0 Offset: 0x10857A0 VA: 0x1810871A0
	public Nullable<TimeSpan> get_MaxStaleLimit() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1087300 Offset: 0x1085900 VA: 0x181087300
	public void set_MaxStaleLimit(Nullable<TimeSpan> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x105EAD0 Offset: 0x105D0D0 VA: 0x18105EAD0
	public Nullable<TimeSpan> get_MinFresh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1087310 Offset: 0x1085910 VA: 0x181087310
	public void set_MinFresh(Nullable<TimeSpan> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4F780 Offset: 0xA4DD80 VA: 0x180A4F780
	public bool get_MustRevalidate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6F18C0 Offset: 0x6EFEC0 VA: 0x1806F18C0
	public void set_MustRevalidate(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1087220 Offset: 0x1085820 VA: 0x181087220
	public bool get_NoCache() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1087320 Offset: 0x1085920 VA: 0x181087320
	public void set_NoCache(bool value) { }

	// RVA: 0x10871B0 Offset: 0x10857B0 VA: 0x1810871B0
	public ICollection<string> get_NoCacheHeaders() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1087230 Offset: 0x1085830 VA: 0x181087230
	public bool get_NoStore() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1087330 Offset: 0x1085930 VA: 0x181087330
	public void set_NoStore(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1087240 Offset: 0x1085840 VA: 0x181087240
	public bool get_NoTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1087340 Offset: 0x1085940 VA: 0x181087340
	public void set_NoTransform(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7CCA00 Offset: 0x7CB000 VA: 0x1807CCA00
	public bool get_OnlyIfCached() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1087350 Offset: 0x1085950 VA: 0x181087350
	public void set_OnlyIfCached(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7CC9F0 Offset: 0x7CAFF0 VA: 0x1807CC9F0
	public bool get_Private() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1087360 Offset: 0x1085960 VA: 0x181087360
	public void set_Private(bool value) { }

	// RVA: 0x1087250 Offset: 0x1085850 VA: 0x181087250
	public ICollection<string> get_PrivateHeaders() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10872C0 Offset: 0x10858C0 VA: 0x1810872C0
	public bool get_ProxyRevalidate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1087370 Offset: 0x1085970 VA: 0x181087370
	public void set_ProxyRevalidate(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10872D0 Offset: 0x10858D0 VA: 0x1810872D0
	public bool get_Public() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1087380 Offset: 0x1085980 VA: 0x181087380
	public void set_Public(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10872E0 Offset: 0x10858E0 VA: 0x1810872E0
	public Nullable<TimeSpan> get_SharedMaxAge() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1087390 Offset: 0x1085990 VA: 0x181087390
	public void set_SharedMaxAge(Nullable<TimeSpan> value) { }

	// RVA: 0x1085BB0 Offset: 0x10841B0 VA: 0x181085BB0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1085680 Offset: 0x1083C80 VA: 0x181085680 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1085980 Offset: 0x1083F80 VA: 0x181085980 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1086650 Offset: 0x1084C50 VA: 0x181086650
	public static bool TryParse(string input, out CacheControlHeaderValue parsedValue) { }

	// RVA: 0x1086040 Offset: 0x1084640 VA: 0x181086040 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

