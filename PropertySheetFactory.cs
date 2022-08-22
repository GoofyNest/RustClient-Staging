public sealed class PropertySheetFactory // TypeDefIndex: 11866
{	// Fields
	private readonly Dictionary<Shader, PropertySheet> m_Sheets; // 0x10

	// Methods

	// RVA: 0x11D6CA0 Offset: 0x11D52A0 VA: 0x1811D6CA0
	public void .ctor() { }

	[ObsoleteAttribute] // RVA: 0x7DD70 Offset: 0x7D170 VA: 0x18007DD70
	// RVA: 0x11D69C0 Offset: 0x11D4FC0 VA: 0x1811D69C0
	public PropertySheet Get(string shaderName) { }

	// RVA: 0x11D67F0 Offset: 0x11D4DF0 VA: 0x1811D67F0
	public PropertySheet Get(Shader shader) { }

	// RVA: 0x11D6A90 Offset: 0x11D5090 VA: 0x1811D6A90
	public void Release() { }

}

