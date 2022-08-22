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

	// RVA: 0x1524DB0 Offset: 0x15233B0 VA: 0x181524DB0
	public void .ctor() { }

	// RVA: 0x1521AA0 Offset: 0x15200A0 VA: 0x181521AA0
	private void AddRemoveDomain(string key, PathList value) { }

	// RVA: 0x1521BE0 Offset: 0x15201E0 VA: 0x181521BE0
	internal void Add(Cookie cookie, bool throwOnError) { }

	// RVA: 0x1522310 Offset: 0x1520910 VA: 0x181522310
	private bool AgeCookies(string domain) { }

	// RVA: 0x1523F50 Offset: 0x1522550 VA: 0x181523F50
	private int ExpireCollection(CookieCollection cc) { }

	// RVA: 0x15247B0 Offset: 0x1522DB0 VA: 0x1815247B0
	internal bool IsLocalDomain(string host) { }

	// RVA: 0x15238B0 Offset: 0x1521EB0 VA: 0x1815238B0
	internal CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow) { }

	// RVA: 0x15244A0 Offset: 0x1522AA0 VA: 0x1815244A0
	internal CookieCollection InternalGetCookies(Uri uri) { }

	// RVA: 0x1523160 Offset: 0x1521760 VA: 0x181523160
	private void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, List<string> domainAttribute, bool matchOnlyPlainCookie) { }

	// RVA: 0x1524AB0 Offset: 0x15230B0 VA: 0x181524AB0
	private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly) { }

	// RVA: 0x15240C0 Offset: 0x15226C0 VA: 0x1815240C0
	public string GetCookieHeader(Uri uri) { }

	// RVA: 0x1524180 Offset: 0x1522780 VA: 0x181524180
	internal string GetCookieHeader(Uri uri, out string optCookie2) { }

	// RVA: 0x1524CB0 Offset: 0x15232B0 VA: 0x181524CB0
	private static void .cctor() { }

}

