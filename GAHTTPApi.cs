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

	// RVA: 0x13B8050 Offset: 0x13B6650 VA: 0x1813B8050
	private static string getBaseUrl() { }

	// RVA: 0x13B82D0 Offset: 0x13B68D0 VA: 0x1813B82D0
	public static GAHTTPApi get_Instance() { }

	// RVA: 0x13B7FC0 Offset: 0x13B65C0 VA: 0x1813B7FC0
	private void .ctor() { }

	// RVA: 0x13B5B20 Offset: 0x13B4120 VA: 0x1813B5B20
	private bool MyRemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

	// RVA: 0x13B6120 Offset: 0x13B4720 VA: 0x1813B6120
	public KeyValuePair<EGAHTTPApiResponse, JSONObject> RequestInitReturningDict() { }

	// RVA: 0x13B6FD0 Offset: 0x13B55D0 VA: 0x1813B6FD0
	public KeyValuePair<EGAHTTPApiResponse, JSONNode> SendEventsInArray(List<JSONNode> eventArray) { }

	// RVA: 0x13B54F0 Offset: 0x13B3AF0 VA: 0x1813B54F0
	private byte[] CreatePayloadData(string payload, bool gzip) { }

	// RVA: 0x13B58A0 Offset: 0x13B3EA0 VA: 0x1813B58A0
	private HttpWebRequest CreateRequest(string url, byte[] payloadData, bool gzip) { }

	// RVA: 0x13B5D20 Offset: 0x13B4320 VA: 0x1813B5D20
	private EGAHTTPApiResponse ProcessRequestResponse(HttpStatusCode responseCode, string responseMessage, string body, string requestId) { }

	// RVA: 0x13B7E20 Offset: 0x13B6420 VA: 0x1813B7E20
	private static void .cctor() { }

}

