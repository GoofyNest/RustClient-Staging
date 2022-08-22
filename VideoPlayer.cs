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

	// RVA: 0x231D9B0 Offset: 0x231BFB0 VA: 0x18231D9B0
	public void set_url(string value) { }

	// RVA: 0x231D890 Offset: 0x231BE90 VA: 0x18231D890
	public Texture get_texture() { }

	[NativeNameAttribute] // RVA: 0xCD490 Offset: 0xCC890 VA: 0x1800CD490
	// RVA: 0x231D850 Offset: 0x231BE50 VA: 0x18231D850
	public bool get_isPrepared() { }

	// RVA: 0x231D6B0 Offset: 0x231BCB0 VA: 0x18231D6B0
	public void Play() { }

	// RVA: 0x231D6F0 Offset: 0x231BCF0 VA: 0x18231D6F0
	public void Stop() { }

	// RVA: 0x231D7D0 Offset: 0x231BDD0 VA: 0x18231D7D0
	public long get_frame() { }

	// RVA: 0x231D8D0 Offset: 0x231BED0 VA: 0x18231D8D0
	public uint get_width() { }

	// RVA: 0x231D810 Offset: 0x231BE10 VA: 0x18231D810
	public uint get_height() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231D730 Offset: 0x231BD30 VA: 0x18231D730
	public void add_errorReceived(VideoPlayer.ErrorEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231D910 Offset: 0x231BF10 VA: 0x18231D910
	public void remove_errorReceived(VideoPlayer.ErrorEventHandler value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231D620 Offset: 0x231BC20 VA: 0x18231D620
	private static void InvokePrepareCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231D5B0 Offset: 0x231BBB0 VA: 0x18231D5B0
	private static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231D5F0 Offset: 0x231BBF0 VA: 0x18231D5F0
	private static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231D680 Offset: 0x231BC80 VA: 0x18231D680
	private static void InvokeStartedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231D580 Offset: 0x231BB80 VA: 0x18231D580
	private static void InvokeFrameDroppedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231D540 Offset: 0x231BB40 VA: 0x18231D540
	private static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231D650 Offset: 0x231BC50 VA: 0x18231D650
	private static void InvokeSeekCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231D500 Offset: 0x231BB00 VA: 0x18231D500
	private static void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, double seconds) { }

}

public sealed class VideoPlayer.EventHandler : MulticastDelegate // TypeDefIndex: 4784
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12E9640 Offset: 0x12E7C40 VA: 0x1812E9640 Slot: 12
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

	// RVA: 0xAE4D50 Offset: 0xAE3350 VA: 0x180AE4D50 Slot: 12
	public virtual void Invoke(VideoPlayer source, string message) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, string message, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoPlayer.FrameReadyEventHandler : MulticastDelegate // TypeDefIndex: 4786
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x231CA10 Offset: 0x231B010 VA: 0x18231CA10 Slot: 12
	public virtual void Invoke(VideoPlayer source, long frameIdx) { }

	// RVA: 0x231C980 Offset: 0x231AF80 VA: 0x18231C980 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, long frameIdx, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoPlayer.TimeEventHandler : MulticastDelegate // TypeDefIndex: 4787
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x231CFF0 Offset: 0x231B5F0 VA: 0x18231CFF0 Slot: 12
	public virtual void Invoke(VideoPlayer source, double seconds) { }

	// RVA: 0x231CF60 Offset: 0x231B560 VA: 0x18231CF60 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, double seconds, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

