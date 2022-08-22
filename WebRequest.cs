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

	// RVA: 0x118EE90 Offset: 0x118D490 VA: 0x18118EE90
	private static object get_InternalSyncObject() { }

	// RVA: 0x118DCF0 Offset: 0x118C2F0 VA: 0x18118DCF0
	private static WebRequest Create(Uri requestUri, bool useUriBase) { }

	// RVA: 0x118DB70 Offset: 0x118C170 VA: 0x18118DB70
	public static WebRequest Create(string requestUriString) { }

	// RVA: 0x118DC30 Offset: 0x118C230 VA: 0x18118DC30
	public static WebRequest Create(Uri requestUri) { }

	// RVA: 0x118EFD0 Offset: 0x118D5D0 VA: 0x18118EFD0
	internal static ArrayList get_PrefixList() { }

	// RVA: 0x118E5B0 Offset: 0x118CBB0 VA: 0x18118E5B0
	private static ArrayList PopulatePrefixList() { }

	// RVA: 0x118EAF0 Offset: 0x118D0F0 VA: 0x18118EAF0
	protected void .ctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x118E810 Offset: 0x118CE10 VA: 0x18118E810 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x118E4E0 Offset: 0x118CAE0 VA: 0x18118E4E0 Slot: 8
	public virtual void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x118E4E0 Offset: 0x118CAE0 VA: 0x18118E4E0
	private void InternalSetCachePolicy(RequestCachePolicy policy) { }

	// RVA: 0x118EF90 Offset: 0x118D590 VA: 0x18118EF90 Slot: 9
	public virtual string get_Method() { }

	// RVA: 0x118F3F0 Offset: 0x118D9F0 VA: 0x18118F3F0 Slot: 10
	public virtual void set_Method(string value) { }

	// RVA: 0x118F1F0 Offset: 0x118D7F0 VA: 0x18118F1F0 Slot: 11
	public virtual Uri get_RequestUri() { }

	// RVA: 0x118F2B0 Offset: 0x118D8B0 VA: 0x18118F2B0 Slot: 12
	public virtual void set_ConnectionGroupName(string value) { }

	// RVA: 0x118EC30 Offset: 0x118D230 VA: 0x18118EC30 Slot: 13
	public virtual WebHeaderCollection get_Headers() { }

	// RVA: 0x118F3B0 Offset: 0x118D9B0 VA: 0x18118F3B0 Slot: 14
	public virtual void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x118EB20 Offset: 0x118D120 VA: 0x18118EB20 Slot: 15
	public virtual long get_ContentLength() { }

	// RVA: 0x118F2F0 Offset: 0x118D8F0 VA: 0x18118F2F0 Slot: 16
	public virtual void set_ContentLength(long value) { }

	// RVA: 0x118EB60 Offset: 0x118D160 VA: 0x18118EB60 Slot: 17
	public virtual string get_ContentType() { }

	// RVA: 0x118F330 Offset: 0x118D930 VA: 0x18118F330 Slot: 18
	public virtual void set_ContentType(string value) { }

	// RVA: 0x118EBA0 Offset: 0x118D1A0 VA: 0x18118EBA0 Slot: 19
	public virtual ICredentials get_Credentials() { }

	// RVA: 0x118F370 Offset: 0x118D970 VA: 0x18118F370 Slot: 20
	public virtual void set_Credentials(ICredentials value) { }

	// RVA: 0x118F270 Offset: 0x118D870 VA: 0x18118F270 Slot: 21
	public virtual bool get_UseDefaultCredentials() { }

	// RVA: 0x118F4B0 Offset: 0x118DAB0 VA: 0x18118F4B0 Slot: 22
	public virtual void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x118F1B0 Offset: 0x118D7B0 VA: 0x18118F1B0 Slot: 23
	public virtual IWebProxy get_Proxy() { }

	// RVA: 0x118F470 Offset: 0x118DA70 VA: 0x18118F470 Slot: 24
	public virtual void set_Proxy(IWebProxy value) { }

	// RVA: 0x118F430 Offset: 0x118DA30 VA: 0x18118F430 Slot: 25
	public virtual void set_PreAuthenticate(bool value) { }

	// RVA: 0x118F230 Offset: 0x118D830 VA: 0x18118F230 Slot: 26
	public virtual int get_Timeout() { }

	// RVA: 0x118E220 Offset: 0x118C820 VA: 0x18118E220 Slot: 27
	public virtual Stream GetRequestStream() { }

	// RVA: 0x118E4A0 Offset: 0x118CAA0 VA: 0x18118E4A0 Slot: 28
	public virtual WebResponse GetResponse() { }

	// RVA: 0x118DB30 Offset: 0x118C130 VA: 0x18118DB30 Slot: 29
	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x118DFA0 Offset: 0x118C5A0 VA: 0x18118DFA0 Slot: 30
	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x118DAF0 Offset: 0x118C0F0 VA: 0x18118DAF0 Slot: 31
	public virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x118DF60 Offset: 0x118C560 VA: 0x18118DF60 Slot: 32
	public virtual Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x118DFE0 Offset: 0x118C5E0 VA: 0x18118DFE0 Slot: 33
	public virtual Task<Stream> GetRequestStreamAsync() { }

	// RVA: 0x118E260 Offset: 0x118C860 VA: 0x18118E260 Slot: 34
	public virtual Task<WebResponse> GetResponseAsync() { }

	// RVA: 0x118E7C0 Offset: 0x118CDC0 VA: 0x18118E7C0
	private WindowsIdentity SafeCaptureIdenity() { }

	// RVA: 0x118DAB0 Offset: 0x118C0B0 VA: 0x18118DAB0 Slot: 35
	public virtual void Abort() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	internal RequestCacheProtocol get_CacheProtocol() { }

	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	internal void set_CacheProtocol(RequestCacheProtocol value) { }

	// RVA: 0x118EC70 Offset: 0x118D270 VA: 0x18118EC70
	internal static IWebProxy get_InternalDefaultWebProxy() { }

	// RVA: 0x118EBE0 Offset: 0x118D1E0 VA: 0x18118EBE0
	public static IWebProxy get_DefaultWebProxy() { }

	// RVA: 0x118EA40 Offset: 0x118D040 VA: 0x18118EA40
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x118E840 Offset: 0x118CE40 VA: 0x18118E840
	private Task<Stream> <GetRequestStreamAsync>b__78_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x118E940 Offset: 0x118CF40 VA: 0x18118E940
	private Task<WebResponse> <GetResponseAsync>b__79_0() { }

}

internal class WebRequest.DesignerWebRequestCreate : IWebRequestCreate // TypeDefIndex: 2906
{	// Methods

	// RVA: 0x117BAE0 Offset: 0x117A0E0 VA: 0x18117BAE0 Slot: 4
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

	// RVA: 0x118BF60 Offset: 0x118A560 VA: 0x18118BF60 Slot: 4
	public Uri GetProxy(Uri destination) { }

	// RVA: 0x118BF80 Offset: 0x118A580 VA: 0x18118BF80 Slot: 5
	public bool IsBypassed(Uri host) { }

	// RVA: 0x6C81E0 Offset: 0x6C67E0 VA: 0x1806C81E0 Slot: 6
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

	// RVA: 0x117E080 Offset: 0x117C680 VA: 0x18117E080
	internal Task<Stream> <GetRequestStreamAsync>b__1() { }

}

private sealed class WebRequest.<>c__DisplayClass79_0 // TypeDefIndex: 2910
{	// Fields
	public WindowsIdentity currentUser; // 0x10
	public WebRequest <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x117E2B0 Offset: 0x117C8B0 VA: 0x18117E2B0
	internal Task<WebResponse> <GetResponseAsync>b__1() { }

}

