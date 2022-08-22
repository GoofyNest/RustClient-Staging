public abstract class ProceduralComponent : MonoBehaviour // TypeDefIndex: 10445
{	// Fields
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public ProceduralComponent.Realm Mode; // 0x18
	public string Description; // 0x20

	// Properties
	public virtual bool RunOnCache { get; }

	// Methods

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 4
	public virtual bool get_RunOnCache() { }

	// RVA: 0x9A88A0 Offset: 0x9A6EA0 VA: 0x1809A88A0
	public bool ShouldRun() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Process(uint seed);

	// RVA: 0x9A8910 Offset: 0x9A6F10 VA: 0x1809A8910
	protected void .ctor() { }

}

public enum ProceduralComponent.Realm // TypeDefIndex: 10446
{	// Fields
	public int value__; // 0x0
	public const ProceduralComponent.Realm Client = 1;
	public const ProceduralComponent.Realm Server = 2;

}

