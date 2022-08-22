public class ClipperRegistry // TypeDefIndex: 4912
{	// Fields
	private static ClipperRegistry s_Instance; // 0x0
	private readonly IndexedSet<IClipper> m_Clippers; // 0x10

	// Properties
	public static ClipperRegistry instance { get; }

	// Methods

	// RVA: 0x10BA4D0 Offset: 0x10B8AD0 VA: 0x1810BA4D0
	protected void .ctor() { }

	// RVA: 0x10BA540 Offset: 0x10B8B40 VA: 0x1810BA540
	public static ClipperRegistry get_instance() { }

	// RVA: 0x10BA2F0 Offset: 0x10B88F0 VA: 0x1810BA2F0
	public void Cull() { }

	// RVA: 0x10BA410 Offset: 0x10B8A10 VA: 0x1810BA410
	public static void Register(IClipper c) { }

	// RVA: 0x10BA470 Offset: 0x10B8A70 VA: 0x1810BA470
	public static void Unregister(IClipper c) { }

}

