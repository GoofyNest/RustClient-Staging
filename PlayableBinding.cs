public struct PlayableBinding // TypeDefIndex: 3867
{	// Fields
	private string m_StreamName; // 0x0
	private Object m_SourceObject; // 0x8
	private Type m_SourceBindingType; // 0x10
	private PlayableBinding.CreateOutputMethod m_CreateOutputMethod; // 0x18
	public static readonly PlayableBinding[] None; // 0x0
	public static readonly double DefaultDuration; // 0x8

	// Methods

	// RVA: 0x18FA710 Offset: 0x18F8D10 VA: 0x1818FA710
	private static void .cctor() { }

}

internal sealed class PlayableBinding.CreateOutputMethod : MulticastDelegate // TypeDefIndex: 3868
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18E9690 Offset: 0x18E7C90 VA: 0x1818E9690 Slot: 12
	public virtual PlayableOutput Invoke(PlayableGraph graph, string name) { }

	// RVA: 0x18E9600 Offset: 0x18E7C00 VA: 0x1818E9600 Slot: 13
	public virtual IAsyncResult BeginInvoke(PlayableGraph graph, string name, AsyncCallback callback, object object) { }

	// RVA: 0x1220D40 Offset: 0x121F340 VA: 0x181220D40 Slot: 14
	public virtual PlayableOutput EndInvoke(IAsyncResult result) { }

}

