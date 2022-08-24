public static class RemoteSettings // TypeDefIndex: 4741
{
[NativeHeaderAttribute] // RVA: 0xAA6F0 Offset: 0xA9AF0 VA: 0x1800AA6F0
[NativeHeaderAttribute] // RVA: 0xAA6F0 Offset: 0xA9AF0 VA: 0x1800AA6F0
public static class RemoteSettings // TypeDefIndex: 4741
	[DebuggerBrowsableAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	[CompilerGeneratedAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	private static RemoteSettings.UpdatedEventHandler Updated; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	[CompilerGeneratedAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	private static Action BeforeFetchFromServer; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	[DebuggerBrowsableAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	private static Action<bool, bool, int> Completed; // 0x10


	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static void RemoteSettingsUpdated(bool wasLastUpdatedFromServer) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static void RemoteSettingsBeforeFetchFromServer() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response) { }

}

public sealed class RemoteSettings.UpdatedEventHandler : MulticastDelegate // TypeDefIndex: 4742
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

