public class WorldAnchor : Component // TypeDefIndex: 4769
{	[CompilerGeneratedAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	[DebuggerBrowsableAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	private WorldAnchor.OnTrackingChangedDelegate OnTrackingChanged; // 0x18


	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void Internal_TriggerEventOnTrackingLost(WorldAnchor worldAnchor, bool located) { }

}

public sealed class WorldAnchor.OnTrackingChangedDelegate : MulticastDelegate // TypeDefIndex: 4770
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(WorldAnchor worldAnchor, bool located) { }

	public virtual IAsyncResult BeginInvoke(WorldAnchor worldAnchor, bool located, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

