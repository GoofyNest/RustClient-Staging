public class RottingFlies : MonoBehaviour, IClientComponent // TypeDefIndex: 9359
{	public GameObjectRef effect; // 0x18
	public SoundDefinition soundDef; // 0x20
	public Transform rootBone; // 0x28
	[ClientVar] // RVA: 0xE7C50 Offset: 0xE7050 VA: 0x1800E7C50
	public static bool Hide; // 0x0
	private GameObject particleInstance; // 0x30
	private Sound sound; // 0x38
	private const float maxDistSq = 10000;


	private void OnEnable() { }

	private void Update() { }

	private void OnDisable() { }

	public void .ctor() { }

	private static void .cctor() { }

}

