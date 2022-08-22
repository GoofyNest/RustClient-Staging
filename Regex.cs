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

	// RVA: 0x14CDB10 Offset: 0x14CC110 VA: 0x1814CDB10
	protected void .ctor() { }

	// RVA: 0x14CD280 Offset: 0x14CB880 VA: 0x1814CD280
	public void .ctor(string pattern) { }

	// RVA: 0x14CD920 Offset: 0x14CBF20 VA: 0x1814CD920
	public void .ctor(string pattern, RegexOptions options) { }

	// RVA: 0x14CD310 Offset: 0x14CB910 VA: 0x1814CD310
	private void .ctor(string pattern, RegexOptions options, TimeSpan matchTimeout, bool useCache) { }

	// RVA: 0x14CD9C0 Offset: 0x14CBFC0 VA: 0x1814CD9C0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14CCF10 Offset: 0x14CB510 VA: 0x1814CCF10 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x14CCFE0 Offset: 0x14CB5E0 VA: 0x1814CCFE0
	protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

	// RVA: 0x14CB530 Offset: 0x14C9B30 VA: 0x1814CB530
	private static TimeSpan InitDefaultMatchTimeout() { }

	// RVA: 0x14CB210 Offset: 0x14C9810 VA: 0x1814CB210
	public static string Escape(string str) { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public RegexOptions get_Options() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public TimeSpan get_MatchTimeout() { }

	// RVA: 0x14CCFD0 Offset: 0x14CB5D0 VA: 0x1814CCFD0
	public bool get_RightToLeft() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 3
	public override string ToString() { }

	// RVA: 0x14CB2A0 Offset: 0x14C98A0 VA: 0x1814CB2A0
	public string GroupNameFromNumber(int i) { }

	// RVA: 0x14CB410 Offset: 0x14C9A10 VA: 0x1814CB410
	public int GroupNumberFromName(string name) { }

	// RVA: 0x14CB8D0 Offset: 0x14C9ED0 VA: 0x1814CB8D0
	public static bool IsMatch(string input, string pattern) { }

	// RVA: 0x14CBB30 Offset: 0x14CA130 VA: 0x1814CBB30
	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x14CBA50 Offset: 0x14CA050 VA: 0x1814CBA50
	public bool IsMatch(string input) { }

	// RVA: 0x14CB820 Offset: 0x14C9E20 VA: 0x1814CB820
	public bool IsMatch(string input, int startat) { }

	// RVA: 0x14CBFF0 Offset: 0x14CA5F0 VA: 0x1814CBFF0
	public static Match Match(string input, string pattern) { }

	// RVA: 0x14CBEC0 Offset: 0x14CA4C0 VA: 0x1814CBEC0
	public static Match Match(string input, string pattern, RegexOptions options) { }

	// RVA: 0x14CC150 Offset: 0x14CA750 VA: 0x1814CC150
	public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x14CC080 Offset: 0x14CA680 VA: 0x1814CC080
	public Match Match(string input) { }

	// RVA: 0x14CBF50 Offset: 0x14CA550 VA: 0x1814CBF50
	public Match Match(string input, int startat) { }

	// RVA: 0x14CC440 Offset: 0x14CAA40 VA: 0x1814CC440
	public static MatchCollection Matches(string input, string pattern) { }

	// RVA: 0x14CC4D0 Offset: 0x14CAAD0 VA: 0x1814CC4D0
	public static MatchCollection Matches(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x14CC290 Offset: 0x14CA890 VA: 0x1814CC290
	public MatchCollection Matches(string input) { }

	// RVA: 0x14CC6E0 Offset: 0x14CACE0 VA: 0x1814CC6E0
	public MatchCollection Matches(string input, int startat) { }

	// RVA: 0x14CC870 Offset: 0x14CAE70 VA: 0x1814CC870
	public string Replace(string input, string replacement) { }

	// RVA: 0x14CC920 Offset: 0x14CAF20 VA: 0x1814CC920
	public string Replace(string input, string replacement, int count, int startat) { }

	// RVA: 0x14CB750 Offset: 0x14C9D50 VA: 0x1814CB750
	protected void InitializeReferences() { }

	// RVA: 0x14CCAE0 Offset: 0x14CB0E0 VA: 0x1814CCAE0
	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	// RVA: 0x14CBC80 Offset: 0x14CA280 VA: 0x1814CBC80
	private static CachedCodeEntry LookupCachedAndUpdate(string key) { }

	// RVA: 0x14CADF0 Offset: 0x14C93F0 VA: 0x1814CADF0
	private CachedCodeEntry CacheCode(string key) { }

	// RVA: 0x14CCFD0 Offset: 0x14CB5D0 VA: 0x1814CCFD0
	protected bool UseOptionR() { }

	// RVA: 0x14CCFC0 Offset: 0x14CB5C0 VA: 0x1814CCFC0
	internal bool UseOptionInvariant() { }

	// RVA: 0x14CD150 Offset: 0x14CB750 VA: 0x1814CD150
	private static void .cctor() { }

}

