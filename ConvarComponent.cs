public class ConvarComponent : MonoBehaviour // TypeDefIndex: 11302
{	// Fields
	public bool runOnServer; // 0x18
	public bool runOnClient; // 0x19
	public List<ConvarComponent.ConvarEvent> List; // 0x20

	// Methods

	// RVA: 0x6BA3C0 Offset: 0x6B89C0 VA: 0x1806BA3C0
	protected void OnEnable() { }

	// RVA: 0x6BA1C0 Offset: 0x6B87C0 VA: 0x1806BA1C0
	protected void OnDisable() { }

	// RVA: 0x6BA4E0 Offset: 0x6B8AE0 VA: 0x1806BA4E0
	private bool ShouldRun() { }

	// RVA: 0x6BA4F0 Offset: 0x6B8AF0 VA: 0x1806BA4F0
	public void .ctor() { }

}

public class ConvarComponent.ConvarEvent // TypeDefIndex: 11303
{	// Fields
	public string convar; // 0x10
	public string on; // 0x18
	public MonoBehaviour component; // 0x20
	internal ConsoleSystem.Command cmd; // 0x28

	// Methods

	// RVA: 0x6BA630 Offset: 0x6B8C30 VA: 0x1806BA630
	public void OnEnable() { }

	// RVA: 0x6BA7E0 Offset: 0x6B8DE0 VA: 0x1806BA7E0
	private void cmd_OnValueChanged(ConsoleSystem.Command obj) { }

	// RVA: 0x6BA570 Offset: 0x6B8B70 VA: 0x1806BA570
	public void OnDisable() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

