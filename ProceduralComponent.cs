public abstract class ProceduralComponent : MonoBehaviour // TypeDefIndex: 10449
{	[InspectorFlagsAttribute] // RVA: 0x70D50 Offset: 0x70150 VA: 0x180070D50
	public ProceduralComponent.Realm Mode; // 0x18
	public string Description; // 0x20

	public virtual bool RunOnCache { get; }


	public virtual bool get_RunOnCache() { }

	public bool ShouldRun() { }

	public abstract void Process(uint seed);

	protected void .ctor() { }

}

public enum ProceduralComponent.Realm // TypeDefIndex: 10450
{	public int value__; // 0x0
	public const ProceduralComponent.Realm Client = 1;
	public const ProceduralComponent.Realm Server = 2;

}

