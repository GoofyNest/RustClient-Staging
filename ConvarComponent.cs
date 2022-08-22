public class ConvarComponent : MonoBehaviour // TypeDefIndex: 11302
{	// Fields
	public bool runOnServer; // 0x18
	public bool runOnClient; // 0x19
	public List<ConvarComponent.ConvarEvent> List; // 0x20

	// Methods

	// RVA: 0x6BA350 Offset: 0x6B8950 VA: 0x1806BA350
	protected void OnEnable() { }

	// RVA: 0x6BA150 Offset: 0x6B8750 VA: 0x1806BA150
	protected void OnDisable() { }

	// RVA: 0x6BA470 Offset: 0x6B8A70 VA: 0x1806BA470
	private bool ShouldRun() { }

	// RVA: 0x6BA480 Offset: 0x6B8A80 VA: 0x1806BA480
	public void .ctor() { }

}

public class ConvarComponent.ConvarEvent // TypeDefIndex: 11303
{	// Fields
	public string convar; // 0x10
	public string on; // 0x18
	public MonoBehaviour component; // 0x20
	internal ConsoleSystem.Command cmd; // 0x28

	// Methods

	// RVA: 0x6BA5C0 Offset: 0x6B8BC0 VA: 0x1806BA5C0
	public void OnEnable() { }

	// RVA: 0x6BA770 Offset: 0x6B8D70 VA: 0x1806BA770
	private void cmd_OnValueChanged(ConsoleSystem.Command obj) { }

	// RVA: 0x6BA500 Offset: 0x6B8B00 VA: 0x1806BA500
	public void OnDisable() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

