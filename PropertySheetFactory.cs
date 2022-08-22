public sealed class PropertySheetFactory // TypeDefIndex: 11866
{	// Fields
	private readonly Dictionary<Shader, PropertySheet> m_Sheets; // 0x10

	// Methods

	// RVA: 0x11D7600 Offset: 0x11D5C00 VA: 0x1811D7600
	public void .ctor() { }

	[ObsoleteAttribute] // RVA: 0x7DD70 Offset: 0x7D170 VA: 0x18007DD70
	// RVA: 0x11D7320 Offset: 0x11D5920 VA: 0x1811D7320
	public PropertySheet Get(string shaderName) { }

	// RVA: 0x11D7150 Offset: 0x11D5750 VA: 0x1811D7150
	public PropertySheet Get(Shader shader) { }

	// RVA: 0x11D73F0 Offset: 0x11D59F0 VA: 0x1811D73F0
	public void Release() { }

}

