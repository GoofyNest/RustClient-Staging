public class ConvarComponent : MonoBehaviour // TypeDefIndex: 11302
{	// Fields
	public bool runOnServer; // 0x18
	public bool runOnClient; // 0x19
	public List<ConvarComponent.ConvarEvent> List; // 0x20

	// Methods

	// RVA: 0x6BA2B0 Offset: 0x6B88B0 VA: 0x1806BA2B0
	protected void OnEnable() { }

	// RVA: 0x6BA0B0 Offset: 0x6B86B0 VA: 0x1806BA0B0
	protected void OnDisable() { }

	// RVA: 0x6BA3D0 Offset: 0x6B89D0 VA: 0x1806BA3D0
	private bool ShouldRun() { }

	// RVA: 0x6BA3E0 Offset: 0x6B89E0 VA: 0x1806BA3E0
	public void .ctor() { }

}

public class ConvarComponent.ConvarEvent // TypeDefIndex: 11303
{	// Fields
	public string convar; // 0x10
	public string on; // 0x18
	public MonoBehaviour component; // 0x20
	internal ConsoleSystem.Command cmd; // 0x28

	// Methods

	// RVA: 0x6BA520 Offset: 0x6B8B20 VA: 0x1806BA520
	public void OnEnable() { }

	// RVA: 0x6BA6D0 Offset: 0x6B8CD0 VA: 0x1806BA6D0
	private void cmd_OnValueChanged(ConsoleSystem.Command obj) { }

	// RVA: 0x6BA460 Offset: 0x6B8A60 VA: 0x1806BA460
	public void OnDisable() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

