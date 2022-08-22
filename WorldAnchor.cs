public class WorldAnchor : Component // TypeDefIndex: 4769
{	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private WorldAnchor.OnTrackingChangedDelegate OnTrackingChanged; // 0x18


	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void Internal_TriggerEventOnTrackingLost(WorldAnchor worldAnchor, bool located) { }

}

public sealed class WorldAnchor.OnTrackingChangedDelegate : MulticastDelegate // TypeDefIndex: 4770
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(WorldAnchor worldAnchor, bool located) { }

	public virtual IAsyncResult BeginInvoke(WorldAnchor worldAnchor, bool located, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

