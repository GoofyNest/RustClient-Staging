public class WorldAnchor : Component // TypeDefIndex: 4769
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private WorldAnchor.OnTrackingChangedDelegate OnTrackingChanged; // 0x18

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23230B0 Offset: 0x23216B0 VA: 0x1823230B0
	private static void Internal_TriggerEventOnTrackingLost(WorldAnchor worldAnchor, bool located) { }

}

public sealed class WorldAnchor.OnTrackingChangedDelegate : MulticastDelegate // TypeDefIndex: 4770
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x160AA20 Offset: 0x1609020 VA: 0x18160AA20 Slot: 12
	public virtual void Invoke(WorldAnchor worldAnchor, bool located) { }

	// RVA: 0x2323020 Offset: 0x2321620 VA: 0x182323020 Slot: 13
	public virtual IAsyncResult BeginInvoke(WorldAnchor worldAnchor, bool located, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

