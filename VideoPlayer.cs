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

	// RVA: 0x231D190 Offset: 0x231B790 VA: 0x18231D190
	public void set_url(string value) { }

	// RVA: 0x231D070 Offset: 0x231B670 VA: 0x18231D070
	public Texture get_texture() { }

	[NativeNameAttribute] // RVA: 0xCD490 Offset: 0xCC890 VA: 0x1800CD490
	// RVA: 0x231D030 Offset: 0x231B630 VA: 0x18231D030
	public bool get_isPrepared() { }

	// RVA: 0x231CE90 Offset: 0x231B490 VA: 0x18231CE90
	public void Play() { }

	// RVA: 0x231CED0 Offset: 0x231B4D0 VA: 0x18231CED0
	public void Stop() { }

	// RVA: 0x231CFB0 Offset: 0x231B5B0 VA: 0x18231CFB0
	public long get_frame() { }

	// RVA: 0x231D0B0 Offset: 0x231B6B0 VA: 0x18231D0B0
	public uint get_width() { }

	// RVA: 0x231CFF0 Offset: 0x231B5F0 VA: 0x18231CFF0
	public uint get_height() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231CF10 Offset: 0x231B510 VA: 0x18231CF10
	public void add_errorReceived(VideoPlayer.ErrorEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231D0F0 Offset: 0x231B6F0 VA: 0x18231D0F0
	public void remove_errorReceived(VideoPlayer.ErrorEventHandler value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231CE00 Offset: 0x231B400 VA: 0x18231CE00
	private static void InvokePrepareCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231CD90 Offset: 0x231B390 VA: 0x18231CD90
	private static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231CDD0 Offset: 0x231B3D0 VA: 0x18231CDD0
	private static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231CE60 Offset: 0x231B460 VA: 0x18231CE60
	private static void InvokeStartedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231CD60 Offset: 0x231B360 VA: 0x18231CD60
	private static void InvokeFrameDroppedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231CD20 Offset: 0x231B320 VA: 0x18231CD20
	private static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231CE30 Offset: 0x231B430 VA: 0x18231CE30
	private static void InvokeSeekCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231CCE0 Offset: 0x231B2E0 VA: 0x18231CCE0
	private static void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, double seconds) { }

}

public sealed class VideoPlayer.EventHandler : MulticastDelegate // TypeDefIndex: 4784
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12E3190 Offset: 0x12E1790 VA: 0x1812E3190 Slot: 12
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

	// RVA: 0xAE4880 Offset: 0xAE2E80 VA: 0x180AE4880 Slot: 12
	public virtual void Invoke(VideoPlayer source, string message) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, string message, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoPlayer.FrameReadyEventHandler : MulticastDelegate // TypeDefIndex: 4786
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x231C1F0 Offset: 0x231A7F0 VA: 0x18231C1F0 Slot: 12
	public virtual void Invoke(VideoPlayer source, long frameIdx) { }

	// RVA: 0x231C160 Offset: 0x231A760 VA: 0x18231C160 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, long frameIdx, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoPlayer.TimeEventHandler : MulticastDelegate // TypeDefIndex: 4787
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x231C7D0 Offset: 0x231ADD0 VA: 0x18231C7D0 Slot: 12
	public virtual void Invoke(VideoPlayer source, double seconds) { }

	// RVA: 0x231C740 Offset: 0x231AD40 VA: 0x18231C740 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, double seconds, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

