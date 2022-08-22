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

	// RVA: 0x15C8A10 Offset: 0x15C7010 VA: 0x1815C8A10 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 7
	public virtual ISite get_Site() { }

	// RVA: 0x15C87C0 Offset: 0x15C6DC0 VA: 0x1815C87C0 Slot: 5
	public void Dispose() { }

	// RVA: 0x15C8830 Offset: 0x15C6E30 VA: 0x1815C8830 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x15C8AB0 Offset: 0x15C70B0 VA: 0x1815C8AB0 Slot: 9
	public virtual object GetService(Type service) { }

	// RVA: 0x15C8B10 Offset: 0x15C7110 VA: 0x1815C8B10 Slot: 3
	public override string ToString() { }

	// RVA: 0x15C8BE0 Offset: 0x15C71E0 VA: 0x1815C8BE0
	private static void .cctor() { }

}

