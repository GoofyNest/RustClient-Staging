public abstract class WebRequest : MarshalByRefObject, ISerializable // TypeDefIndex: 2905
{	// Fields
	private static ArrayList s_PrefixList; // 0x0
	private static object s_InternalSyncObject; // 0x8
	private static TimerThread.Queue s_DefaultTimerQueue; // 0x10
	private AuthenticationLevel m_AuthenticationLevel; // 0x18
	private TokenImpersonationLevel m_ImpersonationLevel; // 0x1C
	private RequestCachePolicy m_CachePolicy; // 0x20
	private RequestCacheProtocol m_CacheProtocol; // 0x28
	private RequestCacheBinding m_CacheBinding; // 0x30
	private static WebRequest.DesignerWebRequestCreate webRequestCreate; // 0x18
	private static IWebProxy s_DefaultWebProxy; // 0x20
	private static bool s_DefaultWebProxyInitialized; // 0x28

	// Properties
	private static object InternalSyncObject { get; }
	internal static ArrayList PrefixList { get; }
	public virtual RequestCachePolicy CachePolicy { set; }
	public virtual string Method { get; set; }
	public virtual Uri RequestUri { get; }
	public virtual string ConnectionGroupName { set; }
	public virtual WebHeaderCollection Headers { get; set; }
	public virtual long ContentLength { get; set; }
	public virtual string ContentType { get; set; }
	public virtual ICredentials Credentials { get; set; }
	public virtual bool UseDefaultCredentials { get; set; }
	public virtual IWebProxy Proxy { get; set; }
	public virtual bool PreAuthenticate { set; }
	public virtual int Timeout { get; }
	internal RequestCacheProtocol CacheProtocol { get; set; }
	internal static IWebProxy InternalDefaultWebProxy { get; }
	public static IWebProxy DefaultWebProxy { get; }

	// Methods

	// RVA: 0x118EBD0 Offset: 0x118D1D0 VA: 0x18118EBD0
	private static object get_InternalSyncObject() { }

	// RVA: 0x118DA30 Offset: 0x118C030 VA: 0x18118DA30
	private static WebRequest Create(Uri requestUri, bool useUriBase) { }

	// RVA: 0x118D8B0 Offset: 0x118BEB0 VA: 0x18118D8B0
	public static WebRequest Create(string requestUriString) { }

	// RVA: 0x118D970 Offset: 0x118BF70 VA: 0x18118D970
	public static WebRequest Create(Uri requestUri) { }

	// RVA: 0x118ED10 Offset: 0x118D310 VA: 0x18118ED10
	internal static ArrayList get_PrefixList() { }

	// RVA: 0x118E2F0 Offset: 0x118C8F0 VA: 0x18118E2F0
	private static ArrayList PopulatePrefixList() { }

	// RVA: 0x118E830 Offset: 0x118CE30 VA: 0x18118E830
	protected void .ctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x118E550 Offset: 0x118CB50 VA: 0x18118E550 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x118E220 Offset: 0x118C820 VA: 0x18118E220 Slot: 8
	public virtual void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x118E220 Offset: 0x118C820 VA: 0x18118E220
	private void InternalSetCachePolicy(RequestCachePolicy policy) { }

	// RVA: 0x118ECD0 Offset: 0x118D2D0 VA: 0x18118ECD0 Slot: 9
	public virtual string get_Method() { }

	// RVA: 0x118F130 Offset: 0x118D730 VA: 0x18118F130 Slot: 10
	public virtual void set_Method(string value) { }

	// RVA: 0x118EF30 Offset: 0x118D530 VA: 0x18118EF30 Slot: 11
	public virtual Uri get_RequestUri() { }

	// RVA: 0x118EFF0 Offset: 0x118D5F0 VA: 0x18118EFF0 Slot: 12
	public virtual void set_ConnectionGroupName(string value) { }

	// RVA: 0x118E970 Offset: 0x118CF70 VA: 0x18118E970 Slot: 13
	public virtual WebHeaderCollection get_Headers() { }

	// RVA: 0x118F0F0 Offset: 0x118D6F0 VA: 0x18118F0F0 Slot: 14
	public virtual void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x118E860 Offset: 0x118CE60 VA: 0x18118E860 Slot: 15
	public virtual long get_ContentLength() { }

	// RVA: 0x118F030 Offset: 0x118D630 VA: 0x18118F030 Slot: 16
	public virtual void set_ContentLength(long value) { }

	// RVA: 0x118E8A0 Offset: 0x118CEA0 VA: 0x18118E8A0 Slot: 17
	public virtual string get_ContentType() { }

	// RVA: 0x118F070 Offset: 0x118D670 VA: 0x18118F070 Slot: 18
	public virtual void set_ContentType(string value) { }

	// RVA: 0x118E8E0 Offset: 0x118CEE0 VA: 0x18118E8E0 Slot: 19
	public virtual ICredentials get_Credentials() { }

	// RVA: 0x118F0B0 Offset: 0x118D6B0 VA: 0x18118F0B0 Slot: 20
	public virtual void set_Credentials(ICredentials value) { }

	// RVA: 0x118EFB0 Offset: 0x118D5B0 VA: 0x18118EFB0 Slot: 21
	public virtual bool get_UseDefaultCredentials() { }

	// RVA: 0x118F1F0 Offset: 0x118D7F0 VA: 0x18118F1F0 Slot: 22
	public virtual void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x118EEF0 Offset: 0x118D4F0 VA: 0x18118EEF0 Slot: 23
	public virtual IWebProxy get_Proxy() { }

	// RVA: 0x118F1B0 Offset: 0x118D7B0 VA: 0x18118F1B0 Slot: 24
	public virtual void set_Proxy(IWebProxy value) { }

	// RVA: 0x118F170 Offset: 0x118D770 VA: 0x18118F170 Slot: 25
	public virtual void set_PreAuthenticate(bool value) { }

	// RVA: 0x118EF70 Offset: 0x118D570 VA: 0x18118EF70 Slot: 26
	public virtual int get_Timeout() { }

	// RVA: 0x118DF60 Offset: 0x118C560 VA: 0x18118DF60 Slot: 27
	public virtual Stream GetRequestStream() { }

	// RVA: 0x118E1E0 Offset: 0x118C7E0 VA: 0x18118E1E0 Slot: 28
	public virtual WebResponse GetResponse() { }

	// RVA: 0x118D870 Offset: 0x118BE70 VA: 0x18118D870 Slot: 29
	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x118DCE0 Offset: 0x118C2E0 VA: 0x18118DCE0 Slot: 30
	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x118D830 Offset: 0x118BE30 VA: 0x18118D830 Slot: 31
	public virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x118DCA0 Offset: 0x118C2A0 VA: 0x18118DCA0 Slot: 32
	public virtual Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x118DD20 Offset: 0x118C320 VA: 0x18118DD20 Slot: 33
	public virtual Task<Stream> GetRequestStreamAsync() { }

	// RVA: 0x118DFA0 Offset: 0x118C5A0 VA: 0x18118DFA0 Slot: 34
	public virtual Task<WebResponse> GetResponseAsync() { }

	// RVA: 0x118E500 Offset: 0x118CB00 VA: 0x18118E500
	private WindowsIdentity SafeCaptureIdenity() { }

	// RVA: 0x118D7F0 Offset: 0x118BDF0 VA: 0x18118D7F0 Slot: 35
	public virtual void Abort() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	internal RequestCacheProtocol get_CacheProtocol() { }

	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
	internal void set_CacheProtocol(RequestCacheProtocol value) { }

	// RVA: 0x118E9B0 Offset: 0x118CFB0 VA: 0x18118E9B0
	internal static IWebProxy get_InternalDefaultWebProxy() { }

	// RVA: 0x118E920 Offset: 0x118CF20 VA: 0x18118E920
	public static IWebProxy get_DefaultWebProxy() { }

	// RVA: 0x118E780 Offset: 0x118CD80 VA: 0x18118E780
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x118E580 Offset: 0x118CB80 VA: 0x18118E580
	private Task<Stream> <GetRequestStreamAsync>b__78_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x118E680 Offset: 0x118CC80 VA: 0x18118E680
	private Task<WebResponse> <GetResponseAsync>b__79_0() { }

}

internal class WebRequest.DesignerWebRequestCreate : IWebRequestCreate // TypeDefIndex: 2906
{	// Methods

	// RVA: 0x117B820 Offset: 0x1179E20 VA: 0x18117B820 Slot: 4
	public WebRequest Create(Uri uri) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal class WebRequest.WebProxyWrapperOpaque : IWebProxy // TypeDefIndex: 2907
{	// Fields
	protected readonly WebProxy webProxy; // 0x10

	// Properties
	public ICredentials Credentials { get; }

	// Methods

	// RVA: 0x118BCA0 Offset: 0x118A2A0 VA: 0x18118BCA0 Slot: 4
	public Uri GetProxy(Uri destination) { }

	// RVA: 0x118BCC0 Offset: 0x118A2C0 VA: 0x18118BCC0 Slot: 5
	public bool IsBypassed(Uri host) { }

	// RVA: 0x6C80D0 Offset: 0x6C66D0 VA: 0x1806C80D0 Slot: 6
	public ICredentials get_Credentials() { }

}

internal class WebRequest.WebProxyWrapper : WebRequest.WebProxyWrapperOpaque // TypeDefIndex: 2908
{	// Properties
	internal WebProxy WebProxy { get; }

	// Methods

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal WebProxy get_WebProxy() { }

}

private sealed class WebRequest.<>c__DisplayClass78_0 // TypeDefIndex: 2909
{	// Fields
	public WindowsIdentity currentUser; // 0x10
	public WebRequest <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x117DDC0 Offset: 0x117C3C0 VA: 0x18117DDC0
	internal Task<Stream> <GetRequestStreamAsync>b__1() { }

}

private sealed class WebRequest.<>c__DisplayClass79_0 // TypeDefIndex: 2910
{	// Fields
	public WindowsIdentity currentUser; // 0x10
	public WebRequest <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x117DFF0 Offset: 0x117C5F0 VA: 0x18117DFF0
	internal Task<WebResponse> <GetResponseAsync>b__1() { }

}

