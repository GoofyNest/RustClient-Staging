public class ClipperRegistry // TypeDefIndex: 4912
{	// Fields
	private static ClipperRegistry s_Instance; // 0x0
	private readonly IndexedSet<IClipper> m_Clippers; // 0x10

	// Properties
	public static ClipperRegistry instance { get; }

	// Methods

	// RVA: 0x10B97A0 Offset: 0x10B7DA0 VA: 0x1810B97A0
	protected void .ctor() { }

	// RVA: 0x10B9810 Offset: 0x10B7E10 VA: 0x1810B9810
	public static ClipperRegistry get_instance() { }

	// RVA: 0x10B95C0 Offset: 0x10B7BC0 VA: 0x1810B95C0
	public void Cull() { }

	// RVA: 0x10B96E0 Offset: 0x10B7CE0 VA: 0x1810B96E0
	public static void Register(IClipper c) { }

	// RVA: 0x10B9740 Offset: 0x10B7D40 VA: 0x1810B9740
	public static void Unregister(IClipper c) { }

}

