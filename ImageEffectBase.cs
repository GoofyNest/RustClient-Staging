public class ImageEffectBase : MonoBehaviour // TypeDefIndex: 8191
{	// Fields
	public Shader shader; // 0x18
	private Material m_Material; // 0x20

	// Properties
	protected Material material { get; }

	// Methods

	// RVA: 0x21E0DC0 Offset: 0x21DF3C0 VA: 0x1821E0DC0 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x21E0E60 Offset: 0x21DF460 VA: 0x1821E0E60
	protected Material get_material() { }

	// RVA: 0x21E0D30 Offset: 0x21DF330 VA: 0x1821E0D30 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

