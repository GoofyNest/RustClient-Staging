public class ImageEffectBase : MonoBehaviour // TypeDefIndex: 8191
{	// Fields
	public Shader shader; // 0x18
	private Material m_Material; // 0x20

	// Properties
	protected Material material { get; }

	// Methods

	// RVA: 0x21E0EC0 Offset: 0x21DF4C0 VA: 0x1821E0EC0 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x21E0F60 Offset: 0x21DF560 VA: 0x1821E0F60
	protected Material get_material() { }

	// RVA: 0x21E0E30 Offset: 0x21DF430 VA: 0x1821E0E30 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

