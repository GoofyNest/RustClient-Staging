public class MarshalByValueComponent : IComponent, IDisposable, IServiceProvider // TypeDefIndex: 2728
{	// Fields
	private static readonly object EventDisposed; // 0x0
	private ISite site; // 0x10
	private EventHandlerList events; // 0x18

	// Properties
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E850 Offset: 0x9DC50 VA: 0x18009E850
	[BrowsableAttribute] // RVA: 0x9E850 Offset: 0x9DC50 VA: 0x18009E850
	public virtual ISite Site { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x15C9680 Offset: 0x15C7C80 VA: 0x1815C9680 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 7
	public virtual ISite get_Site() { }

	// RVA: 0x15C9430 Offset: 0x15C7A30 VA: 0x1815C9430 Slot: 5
	public void Dispose() { }

	// RVA: 0x15C94A0 Offset: 0x15C7AA0 VA: 0x1815C94A0 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x15C9720 Offset: 0x15C7D20 VA: 0x1815C9720 Slot: 9
	public virtual object GetService(Type service) { }

	// RVA: 0x15C9780 Offset: 0x15C7D80 VA: 0x1815C9780 Slot: 3
	public override string ToString() { }

	// RVA: 0x15C9850 Offset: 0x15C7E50 VA: 0x1815C9850
	private static void .cctor() { }

}

