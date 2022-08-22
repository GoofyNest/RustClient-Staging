public class Regex : ISerializable // TypeDefIndex: 2600
{	// Fields
	protected internal string pattern; // 0x10
	protected internal RegexRunnerFactory factory; // 0x18
	protected internal RegexOptions roptions; // 0x20
	private static readonly TimeSpan MaximumMatchTimeout; // 0x0
	public static readonly TimeSpan InfiniteMatchTimeout; // 0x8
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	protected internal TimeSpan internalMatchTimeout; // 0x28
	private const string DefaultMatchTimeout_ConfigKeyName = "REGEX_DEFAULT_MATCH_TIMEOUT";
	internal static readonly TimeSpan FallbackDefaultMatchTimeout; // 0x10
	internal static readonly TimeSpan DefaultMatchTimeout; // 0x18
	protected internal Hashtable caps; // 0x30
	protected internal Hashtable capnames; // 0x38
	protected internal string[] capslist; // 0x40
	protected internal int capsize; // 0x48
	internal ExclusiveReference runnerref; // 0x50
	internal SharedReference replref; // 0x58
	internal RegexCode code; // 0x60
	internal bool refsInitialized; // 0x68
	internal static LinkedList<CachedCodeEntry> livecode; // 0x20
	internal static int cacheSize; // 0x28
	internal const int MaxOptionShift = 10;

	// Properties
	public RegexOptions Options { get; }
	public TimeSpan MatchTimeout { get; }
	public bool RightToLeft { get; }

	// Methods

	// RVA: 0x14CEA40 Offset: 0x14CD040 VA: 0x1814CEA40
	protected void .ctor() { }

	// RVA: 0x14CE1B0 Offset: 0x14CC7B0 VA: 0x1814CE1B0
	public void .ctor(string pattern) { }

	// RVA: 0x14CE850 Offset: 0x14CCE50 VA: 0x1814CE850
	public void .ctor(string pattern, RegexOptions options) { }

	// RVA: 0x14CE240 Offset: 0x14CC840 VA: 0x1814CE240
	private void .ctor(string pattern, RegexOptions options, TimeSpan matchTimeout, bool useCache) { }

	// RVA: 0x14CE8F0 Offset: 0x14CCEF0 VA: 0x1814CE8F0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14CDE40 Offset: 0x14CC440 VA: 0x1814CDE40 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x14CDF10 Offset: 0x14CC510 VA: 0x1814CDF10
	protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

	// RVA: 0x14CC460 Offset: 0x14CAA60 VA: 0x1814CC460
	private static TimeSpan InitDefaultMatchTimeout() { }

	// RVA: 0x14CC140 Offset: 0x14CA740 VA: 0x1814CC140
	public static string Escape(string str) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public RegexOptions get_Options() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public TimeSpan get_MatchTimeout() { }

	// RVA: 0x14CDF00 Offset: 0x14CC500 VA: 0x1814CDF00
	public bool get_RightToLeft() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x14CC1D0 Offset: 0x14CA7D0 VA: 0x1814CC1D0
	public string GroupNameFromNumber(int i) { }

	// RVA: 0x14CC340 Offset: 0x14CA940 VA: 0x1814CC340
	public int GroupNumberFromName(string name) { }

	// RVA: 0x14CC800 Offset: 0x14CAE00 VA: 0x1814CC800
	public static bool IsMatch(string input, string pattern) { }

	// RVA: 0x14CCA60 Offset: 0x14CB060 VA: 0x1814CCA60
	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x14CC980 Offset: 0x14CAF80 VA: 0x1814CC980
	public bool IsMatch(string input) { }

	// RVA: 0x14CC750 Offset: 0x14CAD50 VA: 0x1814CC750
	public bool IsMatch(string input, int startat) { }

	// RVA: 0x14CCF20 Offset: 0x14CB520 VA: 0x1814CCF20
	public static Match Match(string input, string pattern) { }

	// RVA: 0x14CCDF0 Offset: 0x14CB3F0 VA: 0x1814CCDF0
	public static Match Match(string input, string pattern, RegexOptions options) { }

	// RVA: 0x14CD080 Offset: 0x14CB680 VA: 0x1814CD080
	public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x14CCFB0 Offset: 0x14CB5B0 VA: 0x1814CCFB0
	public Match Match(string input) { }

	// RVA: 0x14CCE80 Offset: 0x14CB480 VA: 0x1814CCE80
	public Match Match(string input, int startat) { }

	// RVA: 0x14CD370 Offset: 0x14CB970 VA: 0x1814CD370
	public static MatchCollection Matches(string input, string pattern) { }

	// RVA: 0x14CD400 Offset: 0x14CBA00 VA: 0x1814CD400
	public static MatchCollection Matches(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x14CD1C0 Offset: 0x14CB7C0 VA: 0x1814CD1C0
	public MatchCollection Matches(string input) { }

	// RVA: 0x14CD610 Offset: 0x14CBC10 VA: 0x1814CD610
	public MatchCollection Matches(string input, int startat) { }

	// RVA: 0x14CD7A0 Offset: 0x14CBDA0 VA: 0x1814CD7A0
	public string Replace(string input, string replacement) { }

	// RVA: 0x14CD850 Offset: 0x14CBE50 VA: 0x1814CD850
	public string Replace(string input, string replacement, int count, int startat) { }

	// RVA: 0x14CC680 Offset: 0x14CAC80 VA: 0x1814CC680
	protected void InitializeReferences() { }

	// RVA: 0x14CDA10 Offset: 0x14CC010 VA: 0x1814CDA10
	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	// RVA: 0x14CCBB0 Offset: 0x14CB1B0 VA: 0x1814CCBB0
	private static CachedCodeEntry LookupCachedAndUpdate(string key) { }

	// RVA: 0x14CBD20 Offset: 0x14CA320 VA: 0x1814CBD20
	private CachedCodeEntry CacheCode(string key) { }

	// RVA: 0x14CDF00 Offset: 0x14CC500 VA: 0x1814CDF00
	protected bool UseOptionR() { }

	// RVA: 0x14CDEF0 Offset: 0x14CC4F0 VA: 0x1814CDEF0
	internal bool UseOptionInvariant() { }

	// RVA: 0x14CE080 Offset: 0x14CC680 VA: 0x1814CE080
	private static void .cctor() { }

}

