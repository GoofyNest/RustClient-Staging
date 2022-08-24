public sealed class VideoPlayer : Behaviour // TypeDefIndex: 4783
{	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private VideoPlayer.EventHandler prepareCompleted; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private VideoPlayer.EventHandler loopPointReached; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	[DebuggerBrowsableAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	private VideoPlayer.EventHandler started; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	[DebuggerBrowsableAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	private VideoPlayer.EventHandler frameDropped; // 0x30
	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private VideoPlayer.ErrorEventHandler errorReceived; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	[DebuggerBrowsableAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	private VideoPlayer.EventHandler seekCompleted; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	[DebuggerBrowsableAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	private VideoPlayer.TimeEventHandler clockResyncOccurred; // 0x48
	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private VideoPlayer.FrameReadyEventHandler frameReady; // 0x50

	[NativeNameAttribute] // RVA: 0xCDF30 Offset: 0xCD330 VA: 0x1800CDF30
	public string url { set; }
	[NativeHeaderAttribute] // RVA: 0xCE1A0 Offset: 0xCD5A0 VA: 0x1800CE1A0
	public Texture texture { get; }
	public bool isPrepared { get; }
	[NativeNameAttribute] // RVA: 0xCE220 Offset: 0xCD620 VA: 0x1800CE220
	public long frame { get; }
	public uint width { get; }
	public uint height { get; }


	public void set_url(string value) { }

	public Texture get_texture() { }

	[NativeNameAttribute] // RVA: 0xCD520 Offset: 0xCC920 VA: 0x1800CD520
	public bool get_isPrepared() { }

	public void Play() { }

	public void Stop() { }

	public long get_frame() { }

	public uint get_width() { }

	public uint get_height() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void add_errorReceived(VideoPlayer.ErrorEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void remove_errorReceived(VideoPlayer.ErrorEventHandler value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void InvokePrepareCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void InvokeStartedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void InvokeFrameDroppedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void InvokeSeekCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, double seconds) { }

}

public sealed class VideoPlayer.EventHandler : MulticastDelegate // TypeDefIndex: 4784
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(VideoPlayer source) { }

	public virtual IAsyncResult BeginInvoke(VideoPlayer source, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoPlayer.ErrorEventHandler : MulticastDelegate // TypeDefIndex: 4785
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(VideoPlayer source, string message) { }

	public virtual IAsyncResult BeginInvoke(VideoPlayer source, string message, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoPlayer.FrameReadyEventHandler : MulticastDelegate // TypeDefIndex: 4786
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(VideoPlayer source, long frameIdx) { }

	public virtual IAsyncResult BeginInvoke(VideoPlayer source, long frameIdx, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoPlayer.TimeEventHandler : MulticastDelegate // TypeDefIndex: 4787
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(VideoPlayer source, double seconds) { }

	public virtual IAsyncResult BeginInvoke(VideoPlayer source, double seconds, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

