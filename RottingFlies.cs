public class RottingFlies : MonoBehaviour, IClientComponent // TypeDefIndex: 9359
{	// Fields
	public GameObjectRef effect; // 0x18
	public SoundDefinition soundDef; // 0x20
	public Transform rootBone; // 0x28
	[ClientVar] // RVA: 0xE7C50 Offset: 0xE7050 VA: 0x1800E7C50
	public static bool Hide; // 0x0
	private GameObject particleInstance; // 0x30
	private Sound sound; // 0x38
	private const float maxDistSq = 10000;

	// Methods

	// RVA: 0x4C8460 Offset: 0x4C6A60 VA: 0x1804C8460
	private void OnEnable() { }

	// RVA: 0x4C86F0 Offset: 0x4C6CF0 VA: 0x1804C86F0
	private void Update() { }

	// RVA: 0x4C82F0 Offset: 0x4C68F0 VA: 0x1804C82F0
	private void OnDisable() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

