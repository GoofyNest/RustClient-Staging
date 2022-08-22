internal class GAHTTPApi // TypeDefIndex: 5673
{	// Fields
	private static readonly GAHTTPApi _instance; // 0x0
	private static string protocol; // 0x8
	private static string hostName; // 0x10
	private static string version; // 0x18
	private static string baseUrl; // 0x20
	private static string initializeUrlPath; // 0x28
	private static string eventsUrlPath; // 0x30
	private bool useGzip; // 0x10

	// Properties
	public static GAHTTPApi Instance { get; }

	// Methods

	// RVA: 0x13B7410 Offset: 0x13B5A10 VA: 0x1813B7410
	private static string getBaseUrl() { }

	// RVA: 0x13B7690 Offset: 0x13B5C90 VA: 0x1813B7690
	public static GAHTTPApi get_Instance() { }

	// RVA: 0x13B7380 Offset: 0x13B5980 VA: 0x1813B7380
	private void .ctor() { }

	// RVA: 0x13B4EE0 Offset: 0x13B34E0 VA: 0x1813B4EE0
	private bool MyRemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

	// RVA: 0x13B54E0 Offset: 0x13B3AE0 VA: 0x1813B54E0
	public KeyValuePair<EGAHTTPApiResponse, JSONObject> RequestInitReturningDict() { }

	// RVA: 0x13B6390 Offset: 0x13B4990 VA: 0x1813B6390
	public KeyValuePair<EGAHTTPApiResponse, JSONNode> SendEventsInArray(List<JSONNode> eventArray) { }

	// RVA: 0x13B48B0 Offset: 0x13B2EB0 VA: 0x1813B48B0
	private byte[] CreatePayloadData(string payload, bool gzip) { }

	// RVA: 0x13B4C60 Offset: 0x13B3260 VA: 0x1813B4C60
	private HttpWebRequest CreateRequest(string url, byte[] payloadData, bool gzip) { }

	// RVA: 0x13B50E0 Offset: 0x13B36E0 VA: 0x1813B50E0
	private EGAHTTPApiResponse ProcessRequestResponse(HttpStatusCode responseCode, string responseMessage, string body, string requestId) { }

	// RVA: 0x13B71E0 Offset: 0x13B57E0 VA: 0x1813B71E0
	private static void .cctor() { }

}

