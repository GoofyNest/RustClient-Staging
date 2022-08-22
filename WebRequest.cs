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

	// RVA: 0x11937B0 Offset: 0x1191DB0 VA: 0x1811937B0
	private static object get_InternalSyncObject() { }

	// RVA: 0x1192610 Offset: 0x1190C10 VA: 0x181192610
	private static WebRequest Create(Uri requestUri, bool useUriBase) { }

	// RVA: 0x1192490 Offset: 0x1190A90 VA: 0x181192490
	public static WebRequest Create(string requestUriString) { }

	// RVA: 0x1192550 Offset: 0x1190B50 VA: 0x181192550
	public static WebRequest Create(Uri requestUri) { }

	// RVA: 0x11938F0 Offset: 0x1191EF0 VA: 0x1811938F0
	internal static ArrayList get_PrefixList() { }

	// RVA: 0x1192ED0 Offset: 0x11914D0 VA: 0x181192ED0
	private static ArrayList PopulatePrefixList() { }

	// RVA: 0x1193410 Offset: 0x1191A10 VA: 0x181193410
	protected void .ctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1193130 Offset: 0x1191730 VA: 0x181193130 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1192E00 Offset: 0x1191400 VA: 0x181192E00 Slot: 8
	public virtual void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x1192E00 Offset: 0x1191400 VA: 0x181192E00
	private void InternalSetCachePolicy(RequestCachePolicy policy) { }

	// RVA: 0x11938B0 Offset: 0x1191EB0 VA: 0x1811938B0 Slot: 9
	public virtual string get_Method() { }

	// RVA: 0x1193D10 Offset: 0x1192310 VA: 0x181193D10 Slot: 10
	public virtual void set_Method(string value) { }

	// RVA: 0x1193B10 Offset: 0x1192110 VA: 0x181193B10 Slot: 11
	public virtual Uri get_RequestUri() { }

	// RVA: 0x1193BD0 Offset: 0x11921D0 VA: 0x181193BD0 Slot: 12
	public virtual void set_ConnectionGroupName(string value) { }

	// RVA: 0x1193550 Offset: 0x1191B50 VA: 0x181193550 Slot: 13
	public virtual WebHeaderCollection get_Headers() { }

	// RVA: 0x1193CD0 Offset: 0x11922D0 VA: 0x181193CD0 Slot: 14
	public virtual void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x1193440 Offset: 0x1191A40 VA: 0x181193440 Slot: 15
	public virtual long get_ContentLength() { }

	// RVA: 0x1193C10 Offset: 0x1192210 VA: 0x181193C10 Slot: 16
	public virtual void set_ContentLength(long value) { }

	// RVA: 0x1193480 Offset: 0x1191A80 VA: 0x181193480 Slot: 17
	public virtual string get_ContentType() { }

	// RVA: 0x1193C50 Offset: 0x1192250 VA: 0x181193C50 Slot: 18
	public virtual void set_ContentType(string value) { }

	// RVA: 0x11934C0 Offset: 0x1191AC0 VA: 0x1811934C0 Slot: 19
	public virtual ICredentials get_Credentials() { }

	// RVA: 0x1193C90 Offset: 0x1192290 VA: 0x181193C90 Slot: 20
	public virtual void set_Credentials(ICredentials value) { }

	// RVA: 0x1193B90 Offset: 0x1192190 VA: 0x181193B90 Slot: 21
	public virtual bool get_UseDefaultCredentials() { }

	// RVA: 0x1193DD0 Offset: 0x11923D0 VA: 0x181193DD0 Slot: 22
	public virtual void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x1193AD0 Offset: 0x11920D0 VA: 0x181193AD0 Slot: 23
	public virtual IWebProxy get_Proxy() { }

	// RVA: 0x1193D90 Offset: 0x1192390 VA: 0x181193D90 Slot: 24
	public virtual void set_Proxy(IWebProxy value) { }

	// RVA: 0x1193D50 Offset: 0x1192350 VA: 0x181193D50 Slot: 25
	public virtual void set_PreAuthenticate(bool value) { }

	// RVA: 0x1193B50 Offset: 0x1192150 VA: 0x181193B50 Slot: 26
	public virtual int get_Timeout() { }

	// RVA: 0x1192B40 Offset: 0x1191140 VA: 0x181192B40 Slot: 27
	public virtual Stream GetRequestStream() { }

	// RVA: 0x1192DC0 Offset: 0x11913C0 VA: 0x181192DC0 Slot: 28
	public virtual WebResponse GetResponse() { }

	// RVA: 0x1192450 Offset: 0x1190A50 VA: 0x181192450 Slot: 29
	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x11928C0 Offset: 0x1190EC0 VA: 0x1811928C0 Slot: 30
	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1192410 Offset: 0x1190A10 VA: 0x181192410 Slot: 31
	public virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x1192880 Offset: 0x1190E80 VA: 0x181192880 Slot: 32
	public virtual Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x1192900 Offset: 0x1190F00 VA: 0x181192900 Slot: 33
	public virtual Task<Stream> GetRequestStreamAsync() { }

	// RVA: 0x1192B80 Offset: 0x1191180 VA: 0x181192B80 Slot: 34
	public virtual Task<WebResponse> GetResponseAsync() { }

	// RVA: 0x11930E0 Offset: 0x11916E0 VA: 0x1811930E0
	private WindowsIdentity SafeCaptureIdenity() { }

	// RVA: 0x11923D0 Offset: 0x11909D0 VA: 0x1811923D0 Slot: 35
	public virtual void Abort() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	internal RequestCacheProtocol get_CacheProtocol() { }

	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	internal void set_CacheProtocol(RequestCacheProtocol value) { }

	// RVA: 0x1193590 Offset: 0x1191B90 VA: 0x181193590
	internal static IWebProxy get_InternalDefaultWebProxy() { }

	// RVA: 0x1193500 Offset: 0x1191B00 VA: 0x181193500
	public static IWebProxy get_DefaultWebProxy() { }

	// RVA: 0x1193360 Offset: 0x1191960 VA: 0x181193360
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1193160 Offset: 0x1191760 VA: 0x181193160
	private Task<Stream> <GetRequestStreamAsync>b__78_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1193260 Offset: 0x1191860 VA: 0x181193260
	private Task<WebResponse> <GetResponseAsync>b__79_0() { }

}

internal class WebRequest.DesignerWebRequestCreate : IWebRequestCreate // TypeDefIndex: 2906
{	// Methods

	// RVA: 0x1180400 Offset: 0x117EA00 VA: 0x181180400 Slot: 4
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

	// RVA: 0x1190880 Offset: 0x118EE80 VA: 0x181190880 Slot: 4
	public Uri GetProxy(Uri destination) { }

	// RVA: 0x11908A0 Offset: 0x118EEA0 VA: 0x1811908A0 Slot: 5
	public bool IsBypassed(Uri host) { }

	// RVA: 0x6C8170 Offset: 0x6C6770 VA: 0x1806C8170 Slot: 6
	public ICredentials get_Credentials() { }

}

internal class WebRequest.WebProxyWrapper : WebRequest.WebProxyWrapperOpaque // TypeDefIndex: 2908
{	// Properties
	internal WebProxy WebProxy { get; }

	// Methods

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal WebProxy get_WebProxy() { }

}

private sealed class WebRequest.<>c__DisplayClass78_0 // TypeDefIndex: 2909
{	// Fields
	public WindowsIdentity currentUser; // 0x10
	public WebRequest <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x11829A0 Offset: 0x1180FA0 VA: 0x1811829A0
	internal Task<Stream> <GetRequestStreamAsync>b__1() { }

}

private sealed class WebRequest.<>c__DisplayClass79_0 // TypeDefIndex: 2910
{	// Fields
	public WindowsIdentity currentUser; // 0x10
	public WebRequest <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1182BD0 Offset: 0x11811D0 VA: 0x181182BD0
	internal Task<WebResponse> <GetResponseAsync>b__1() { }

}

