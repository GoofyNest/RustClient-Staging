public sealed class VideoPlayer : Behaviour // TypeDefIndex: 4783
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private VideoPlayer.EventHandler prepareCompleted; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private VideoPlayer.EventHandler loopPointReached; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private VideoPlayer.EventHandler started; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private VideoPlayer.EventHandler frameDropped; // 0x30
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private VideoPlayer.ErrorEventHandler errorReceived; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private VideoPlayer.EventHandler seekCompleted; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private VideoPlayer.TimeEventHandler clockResyncOccurred; // 0x48
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private VideoPlayer.FrameReadyEventHandler frameReady; // 0x50

	// Properties
	[NativeNameAttribute] // RVA: 0xCDEE0 Offset: 0xCD2E0 VA: 0x1800CDEE0
	public string url { set; }
	[NativeHeaderAttribute] // RVA: 0xCE110 Offset: 0xCD510 VA: 0x1800CE110
	public Texture texture { get; }
	public bool isPrepared { get; }
	[NativeNameAttribute] // RVA: 0xCE180 Offset: 0xCD580 VA: 0x1800CE180
	public long frame { get; }
	public uint width { get; }
	public uint height { get; }

	// Methods

	// RVA: 0x231CED0 Offset: 0x231B4D0 VA: 0x18231CED0
	public void set_url(string value) { }

	// RVA: 0x231CDB0 Offset: 0x231B3B0 VA: 0x18231CDB0
	public Texture get_texture() { }

	[NativeNameAttribute] // RVA: 0xCD490 Offset: 0xCC890 VA: 0x1800CD490
	// RVA: 0x231CD70 Offset: 0x231B370 VA: 0x18231CD70
	public bool get_isPrepared() { }

	// RVA: 0x231CBD0 Offset: 0x231B1D0 VA: 0x18231CBD0
	public void Play() { }

	// RVA: 0x231CC10 Offset: 0x231B210 VA: 0x18231CC10
	public void Stop() { }

	// RVA: 0x231CCF0 Offset: 0x231B2F0 VA: 0x18231CCF0
	public long get_frame() { }

	// RVA: 0x231CDF0 Offset: 0x231B3F0 VA: 0x18231CDF0
	public uint get_width() { }

	// RVA: 0x231CD30 Offset: 0x231B330 VA: 0x18231CD30
	public uint get_height() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231CC50 Offset: 0x231B250 VA: 0x18231CC50
	public void add_errorReceived(VideoPlayer.ErrorEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231CE30 Offset: 0x231B430 VA: 0x18231CE30
	public void remove_errorReceived(VideoPlayer.ErrorEventHandler value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231CB40 Offset: 0x231B140 VA: 0x18231CB40
	private static void InvokePrepareCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231CAD0 Offset: 0x231B0D0 VA: 0x18231CAD0
	private static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231CB10 Offset: 0x231B110 VA: 0x18231CB10
	private static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231CBA0 Offset: 0x231B1A0 VA: 0x18231CBA0
	private static void InvokeStartedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231CAA0 Offset: 0x231B0A0 VA: 0x18231CAA0
	private static void InvokeFrameDroppedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231CA60 Offset: 0x231B060 VA: 0x18231CA60
	private static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231CB70 Offset: 0x231B170 VA: 0x18231CB70
	private static void InvokeSeekCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231CA20 Offset: 0x231B020 VA: 0x18231CA20
	private static void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, double seconds) { }

}

public sealed class VideoPlayer.EventHandler : MulticastDelegate // TypeDefIndex: 4784
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12E2ED0 Offset: 0x12E14D0 VA: 0x1812E2ED0 Slot: 12
	public virtual void Invoke(VideoPlayer source) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoPlayer.ErrorEventHandler : MulticastDelegate // TypeDefIndex: 4785
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE45C0 Offset: 0xAE2BC0 VA: 0x180AE45C0 Slot: 12
	public virtual void Invoke(VideoPlayer source, string message) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, string message, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoPlayer.FrameReadyEventHandler : MulticastDelegate // TypeDefIndex: 4786
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x231BF30 Offset: 0x231A530 VA: 0x18231BF30 Slot: 12
	public virtual void Invoke(VideoPlayer source, long frameIdx) { }

	// RVA: 0x231BEA0 Offset: 0x231A4A0 VA: 0x18231BEA0 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, long frameIdx, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoPlayer.TimeEventHandler : MulticastDelegate // TypeDefIndex: 4787
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x231C510 Offset: 0x231AB10 VA: 0x18231C510 Slot: 12
	public virtual void Invoke(VideoPlayer source, double seconds) { }

	// RVA: 0x231C480 Offset: 0x231AA80 VA: 0x18231C480 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, double seconds, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

