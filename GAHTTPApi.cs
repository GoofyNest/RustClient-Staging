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

	// RVA: 0x13B8310 Offset: 0x13B6910 VA: 0x1813B8310
	private static string getBaseUrl() { }

	// RVA: 0x13B8590 Offset: 0x13B6B90 VA: 0x1813B8590
	public static GAHTTPApi get_Instance() { }

	// RVA: 0x13B8280 Offset: 0x13B6880 VA: 0x1813B8280
	private void .ctor() { }

	// RVA: 0x13B5DE0 Offset: 0x13B43E0 VA: 0x1813B5DE0
	private bool MyRemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

	// RVA: 0x13B63E0 Offset: 0x13B49E0 VA: 0x1813B63E0
	public KeyValuePair<EGAHTTPApiResponse, JSONObject> RequestInitReturningDict() { }

	// RVA: 0x13B7290 Offset: 0x13B5890 VA: 0x1813B7290
	public KeyValuePair<EGAHTTPApiResponse, JSONNode> SendEventsInArray(List<JSONNode> eventArray) { }

	// RVA: 0x13B57B0 Offset: 0x13B3DB0 VA: 0x1813B57B0
	private byte[] CreatePayloadData(string payload, bool gzip) { }

	// RVA: 0x13B5B60 Offset: 0x13B4160 VA: 0x1813B5B60
	private HttpWebRequest CreateRequest(string url, byte[] payloadData, bool gzip) { }

	// RVA: 0x13B5FE0 Offset: 0x13B45E0 VA: 0x1813B5FE0
	private EGAHTTPApiResponse ProcessRequestResponse(HttpStatusCode responseCode, string responseMessage, string body, string requestId) { }

	// RVA: 0x13B80E0 Offset: 0x13B66E0 VA: 0x1813B80E0
	private static void .cctor() { }

}

