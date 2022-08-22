public static class RemoteSettings // TypeDefIndex: 4741
{
// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0xAA4F0 Offset: 0xA98F0 VA: 0x1800AA4F0
[NativeHeaderAttribute] // RVA: 0xAA4F0 Offset: 0xA98F0 VA: 0x1800AA4F0
public static class RemoteSettings // TypeDefIndex: 4741
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static RemoteSettings.UpdatedEventHandler Updated; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static Action BeforeFetchFromServer; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static Action<bool, bool, int> Completed; // 0x10

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2321A90 Offset: 0x2320090 VA: 0x182321A90
	internal static void RemoteSettingsUpdated(bool wasLastUpdatedFromServer) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23219C0 Offset: 0x231FFC0 VA: 0x1823219C0
	internal static void RemoteSettingsBeforeFetchFromServer() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2321A10 Offset: 0x2320010 VA: 0x182321A10
	internal static void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response) { }

}

public sealed class RemoteSettings.UpdatedEventHandler : MulticastDelegate // TypeDefIndex: 4742
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x49A1D0 Offset: 0x4987D0 VA: 0x18049A1D0 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

