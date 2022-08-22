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

	// RVA: 0x14CE780 Offset: 0x14CCD80 VA: 0x1814CE780
	protected void .ctor() { }

	// RVA: 0x14CDEF0 Offset: 0x14CC4F0 VA: 0x1814CDEF0
	public void .ctor(string pattern) { }

	// RVA: 0x14CE590 Offset: 0x14CCB90 VA: 0x1814CE590
	public void .ctor(string pattern, RegexOptions options) { }

	// RVA: 0x14CDF80 Offset: 0x14CC580 VA: 0x1814CDF80
	private void .ctor(string pattern, RegexOptions options, TimeSpan matchTimeout, bool useCache) { }

	// RVA: 0x14CE630 Offset: 0x14CCC30 VA: 0x1814CE630
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14CDB80 Offset: 0x14CC180 VA: 0x1814CDB80 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x14CDC50 Offset: 0x14CC250 VA: 0x1814CDC50
	protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

	// RVA: 0x14CC1A0 Offset: 0x14CA7A0 VA: 0x1814CC1A0
	private static TimeSpan InitDefaultMatchTimeout() { }

	// RVA: 0x14CBE80 Offset: 0x14CA480 VA: 0x1814CBE80
	public static string Escape(string str) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public RegexOptions get_Options() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public TimeSpan get_MatchTimeout() { }

	// RVA: 0x14CDC40 Offset: 0x14CC240 VA: 0x1814CDC40
	public bool get_RightToLeft() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x14CBF10 Offset: 0x14CA510 VA: 0x1814CBF10
	public string GroupNameFromNumber(int i) { }

	// RVA: 0x14CC080 Offset: 0x14CA680 VA: 0x1814CC080
	public int GroupNumberFromName(string name) { }

	// RVA: 0x14CC540 Offset: 0x14CAB40 VA: 0x1814CC540
	public static bool IsMatch(string input, string pattern) { }

	// RVA: 0x14CC7A0 Offset: 0x14CADA0 VA: 0x1814CC7A0
	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x14CC6C0 Offset: 0x14CACC0 VA: 0x1814CC6C0
	public bool IsMatch(string input) { }

	// RVA: 0x14CC490 Offset: 0x14CAA90 VA: 0x1814CC490
	public bool IsMatch(string input, int startat) { }

	// RVA: 0x14CCC60 Offset: 0x14CB260 VA: 0x1814CCC60
	public static Match Match(string input, string pattern) { }

	// RVA: 0x14CCB30 Offset: 0x14CB130 VA: 0x1814CCB30
	public static Match Match(string input, string pattern, RegexOptions options) { }

	// RVA: 0x14CCDC0 Offset: 0x14CB3C0 VA: 0x1814CCDC0
	public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x14CCCF0 Offset: 0x14CB2F0 VA: 0x1814CCCF0
	public Match Match(string input) { }

	// RVA: 0x14CCBC0 Offset: 0x14CB1C0 VA: 0x1814CCBC0
	public Match Match(string input, int startat) { }

	// RVA: 0x14CD0B0 Offset: 0x14CB6B0 VA: 0x1814CD0B0
	public static MatchCollection Matches(string input, string pattern) { }

	// RVA: 0x14CD140 Offset: 0x14CB740 VA: 0x1814CD140
	public static MatchCollection Matches(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x14CCF00 Offset: 0x14CB500 VA: 0x1814CCF00
	public MatchCollection Matches(string input) { }

	// RVA: 0x14CD350 Offset: 0x14CB950 VA: 0x1814CD350
	public MatchCollection Matches(string input, int startat) { }

	// RVA: 0x14CD4E0 Offset: 0x14CBAE0 VA: 0x1814CD4E0
	public string Replace(string input, string replacement) { }

	// RVA: 0x14CD590 Offset: 0x14CBB90 VA: 0x1814CD590
	public string Replace(string input, string replacement, int count, int startat) { }

	// RVA: 0x14CC3C0 Offset: 0x14CA9C0 VA: 0x1814CC3C0
	protected void InitializeReferences() { }

	// RVA: 0x14CD750 Offset: 0x14CBD50 VA: 0x1814CD750
	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	// RVA: 0x14CC8F0 Offset: 0x14CAEF0 VA: 0x1814CC8F0
	private static CachedCodeEntry LookupCachedAndUpdate(string key) { }

	// RVA: 0x14CBA60 Offset: 0x14CA060 VA: 0x1814CBA60
	private CachedCodeEntry CacheCode(string key) { }

	// RVA: 0x14CDC40 Offset: 0x14CC240 VA: 0x1814CDC40
	protected bool UseOptionR() { }

	// RVA: 0x14CDC30 Offset: 0x14CC230 VA: 0x1814CDC30
	internal bool UseOptionInvariant() { }

	// RVA: 0x14CDDC0 Offset: 0x14CC3C0 VA: 0x1814CDDC0
	private static void .cctor() { }

}

