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

	// RVA: 0x1523E80 Offset: 0x1522480 VA: 0x181523E80
	public void .ctor() { }

	// RVA: 0x1520B70 Offset: 0x151F170 VA: 0x181520B70
	private void AddRemoveDomain(string key, PathList value) { }

	// RVA: 0x1520CB0 Offset: 0x151F2B0 VA: 0x181520CB0
	internal void Add(Cookie cookie, bool throwOnError) { }

	// RVA: 0x15213E0 Offset: 0x151F9E0 VA: 0x1815213E0
	private bool AgeCookies(string domain) { }

	// RVA: 0x1523020 Offset: 0x1521620 VA: 0x181523020
	private int ExpireCollection(CookieCollection cc) { }

	// RVA: 0x1523880 Offset: 0x1521E80 VA: 0x181523880
	internal bool IsLocalDomain(string host) { }

	// RVA: 0x1522980 Offset: 0x1520F80 VA: 0x181522980
	internal CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow) { }

	// RVA: 0x1523570 Offset: 0x1521B70 VA: 0x181523570
	internal CookieCollection InternalGetCookies(Uri uri) { }

	// RVA: 0x1522230 Offset: 0x1520830 VA: 0x181522230
	private void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, List<string> domainAttribute, bool matchOnlyPlainCookie) { }

	// RVA: 0x1523B80 Offset: 0x1522180 VA: 0x181523B80
	private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly) { }

	// RVA: 0x1523190 Offset: 0x1521790 VA: 0x181523190
	public string GetCookieHeader(Uri uri) { }

	// RVA: 0x1523250 Offset: 0x1521850 VA: 0x181523250
	internal string GetCookieHeader(Uri uri, out string optCookie2) { }

	// RVA: 0x1523D80 Offset: 0x1522380 VA: 0x181523D80
	private static void .cctor() { }

}

