public class CollectionChangeEventArgs : EventArgs // TypeDefIndex: 2674
{	// Fields
	private CollectionChangeAction action; // 0x10
	private object element; // 0x18

	// Properties
	public virtual CollectionChangeAction Action { get; }
	public virtual object Element { get; }

	// Methods

	// RVA: 0x15BF050 Offset: 0x15BD650 VA: 0x1815BF050
	public void .ctor(CollectionChangeAction action, object element) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 4
	public virtual CollectionChangeAction get_Action() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 5
	public virtual object get_Element() { }

}

