public class ConvarComponent : MonoBehaviour // TypeDefIndex: 12994
{
	public bool runOnServer; 
	public bool runOnClient; 
	public List<ConvarComponent.ConvarEvent> List; 


	protected void OnEnable() { }

	protected void OnDisable() { }

	private bool ShouldRun() { }

	public void .ctor() { }

}

public class ConvarComponent.ConvarEvent // TypeDefIndex: 12995
{
	public string convar; 
	public string on; 
	public MonoBehaviour component; 
	internal ConsoleSystem.Command cmd; 


	public void OnEnable() { }

	private void cmd_OnValueChanged(ConsoleSystem.Command obj) { }

	public void OnDisable() { }

	public void .ctor() { }

}

