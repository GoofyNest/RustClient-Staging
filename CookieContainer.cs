public class CookieContainer // TypeDefIndex: 2944
{	// Fields
	private static readonly HeaderVariantInfo[] HeaderInfo; // 0x0
	private Hashtable m_domainTable; // 0x10
	private int m_maxCookieSize; // 0x18
	private int m_maxCookies; // 0x1C
	private int m_maxCookiesPerDomain; // 0x20
	private int m_count; // 0x24
	private string m_fqdnMyDomain; // 0x28

	// Methods

	// RVA: 0x1524AF0 Offset: 0x15230F0 VA: 0x181524AF0
	public void .ctor() { }

	// RVA: 0x15217E0 Offset: 0x151FDE0 VA: 0x1815217E0
	private void AddRemoveDomain(string key, PathList value) { }

	// RVA: 0x1521920 Offset: 0x151FF20 VA: 0x181521920
	internal void Add(Cookie cookie, bool throwOnError) { }

	// RVA: 0x1522050 Offset: 0x1520650 VA: 0x181522050
	private bool AgeCookies(string domain) { }

	// RVA: 0x1523C90 Offset: 0x1522290 VA: 0x181523C90
	private int ExpireCollection(CookieCollection cc) { }

	// RVA: 0x15244F0 Offset: 0x1522AF0 VA: 0x1815244F0
	internal bool IsLocalDomain(string host) { }

	// RVA: 0x15235F0 Offset: 0x1521BF0 VA: 0x1815235F0
	internal CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow) { }

	// RVA: 0x15241E0 Offset: 0x15227E0 VA: 0x1815241E0
	internal CookieCollection InternalGetCookies(Uri uri) { }

	// RVA: 0x1522EA0 Offset: 0x15214A0 VA: 0x181522EA0
	private void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, List<string> domainAttribute, bool matchOnlyPlainCookie) { }

	// RVA: 0x15247F0 Offset: 0x1522DF0 VA: 0x1815247F0
	private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly) { }

	// RVA: 0x1523E00 Offset: 0x1522400 VA: 0x181523E00
	public string GetCookieHeader(Uri uri) { }

	// RVA: 0x1523EC0 Offset: 0x15224C0 VA: 0x181523EC0
	internal string GetCookieHeader(Uri uri, out string optCookie2) { }

	// RVA: 0x15249F0 Offset: 0x1522FF0 VA: 0x1815249F0
	private static void .cctor() { }

}

