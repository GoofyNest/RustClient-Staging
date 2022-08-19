public class WorldAnchor : Component // TypeDefIndex: 4769
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private WorldAnchor.OnTrackingChangedDelegate OnTrackingChanged; // 0x18

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2322790 Offset: 0x2320D90 VA: 0x182322790
	private static void Internal_TriggerEventOnTrackingLost(WorldAnchor worldAnchor, bool located) { }

}

public sealed class WorldAnchor.OnTrackingChangedDelegate : MulticastDelegate // TypeDefIndex: 4770
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x161D440 Offset: 0x161BA40 VA: 0x18161D440 Slot: 12
	public virtual void Invoke(WorldAnchor worldAnchor, bool located) { }

	// RVA: 0x2322700 Offset: 0x2320D00 VA: 0x182322700 Slot: 13
	public virtual IAsyncResult BeginInvoke(WorldAnchor worldAnchor, bool located, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

