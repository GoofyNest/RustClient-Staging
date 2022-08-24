public static class AnalyticsSessionInfo // TypeDefIndex: 4748
{	[DebuggerBrowsableAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	[CompilerGeneratedAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	private static AnalyticsSessionInfo.SessionStateChanged sessionStateChanged; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	[DebuggerBrowsableAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	private static AnalyticsSessionInfo.IdentityTokenChanged identityTokenChanged; // 0x8


	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static void CallSessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static void CallIdentityTokenChanged(string token) { }

}

public sealed class AnalyticsSessionInfo.SessionStateChanged : MulticastDelegate // TypeDefIndex: 4749
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) { }

	public virtual IAsyncResult BeginInvoke(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AnalyticsSessionInfo.IdentityTokenChanged : MulticastDelegate // TypeDefIndex: 4750
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(string token) { }

	public virtual IAsyncResult BeginInvoke(string token, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

