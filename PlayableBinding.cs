public struct PlayableBinding // TypeDefIndex: 3867
{	// Fields
	private string m_StreamName; // 0x0
	private Object m_SourceObject; // 0x8
	private Type m_SourceBindingType; // 0x10
	private PlayableBinding.CreateOutputMethod m_CreateOutputMethod; // 0x18
	public static readonly PlayableBinding[] None; // 0x0
	public static readonly double DefaultDuration; // 0x8

	// Methods

	// RVA: 0x18FA450 Offset: 0x18F8A50 VA: 0x1818FA450
	private static void .cctor() { }

}

internal sealed class PlayableBinding.CreateOutputMethod : MulticastDelegate // TypeDefIndex: 3868
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18E93D0 Offset: 0x18E79D0 VA: 0x1818E93D0 Slot: 12
	public virtual PlayableOutput Invoke(PlayableGraph graph, string name) { }

	// RVA: 0x18E9340 Offset: 0x18E7940 VA: 0x1818E9340 Slot: 13
	public virtual IAsyncResult BeginInvoke(PlayableGraph graph, string name, AsyncCallback callback, object object) { }

	// RVA: 0x1220A80 Offset: 0x121F080 VA: 0x181220A80 Slot: 14
	public virtual PlayableOutput EndInvoke(IAsyncResult result) { }

}

