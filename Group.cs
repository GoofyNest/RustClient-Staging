internal class Group : AstNode // TypeDefIndex: 1794
{	// Fields
	private AstNode groupNode; // 0x10

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	public void .ctor(AstNode groupNode) { }

	// RVA: 0x6F35A0 Offset: 0x6F1BA0 VA: 0x1806F35A0 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0xAC2530 Offset: 0xAC0B30 VA: 0x180AC2530 Slot: 5
	public override XPathResultType get_ReturnType() { }

}

public class Group : Capture // TypeDefIndex: 2616
{	// Fields
	internal static Group _emptygroup; // 0x0
	internal int[] _caps; // 0x20
	internal int _capcount; // 0x28
	internal CaptureCollection _capcoll; // 0x30
	[OptionalFieldAttribute] // RVA: 0x7B570 Offset: 0x7A970 VA: 0x18007B570
	internal string _name; // 0x38

	// Properties
	public bool Success { get; }
	public CaptureCollection Captures { get; }

	// Methods

	// RVA: 0x14BF380 Offset: 0x14BD980 VA: 0x1814BF380
	internal void .ctor(string text, int[] caps, int capcount, string name) { }

	// RVA: 0x14BF520 Offset: 0x14BDB20 VA: 0x1814BF520
	public bool get_Success() { }

	// RVA: 0x14BF470 Offset: 0x14BDA70 VA: 0x1814BF470
	public CaptureCollection get_Captures() { }

	// RVA: 0x14BF260 Offset: 0x14BD860 VA: 0x1814BF260
	private static void .cctor() { }

	// RVA: 0x14BF350 Offset: 0x14BD950 VA: 0x1814BF350
	internal void .ctor() { }

}

public class Group : IDisposable // TypeDefIndex: 6708
{	// Fields
	protected Manager manager; // 0x10
	public uint ID; // 0x18
	public Bounds bounds; // 0x1C
	public ListHashSet<Networkable> networkables; // 0x38
	public List<Connection> subscribers; // 0x40

	// Properties
	public bool isGlobal { get; }

	// Methods

	// RVA: 0x14CA0E0 Offset: 0x14C86E0 VA: 0x1814CA0E0
	public bool get_isGlobal() { }

	// RVA: 0x220FC10 Offset: 0x220E210 VA: 0x18220FC10
	public void .ctor(Manager m, uint id) { }

	// RVA: 0x220F970 Offset: 0x220DF70 VA: 0x18220F970 Slot: 5
	public virtual void Dispose() { }

	// RVA: 0x220FA00 Offset: 0x220E000 VA: 0x18220FA00
	public void Join(Networkable nw) { }

	// RVA: 0x220FAB0 Offset: 0x220E0B0 VA: 0x18220FAB0
	public void Leave(Networkable nw) { }

	// RVA: 0x220F910 Offset: 0x220DF10 VA: 0x18220F910
	public void AddSubscriber(Connection cn) { }

	// RVA: 0x220FB60 Offset: 0x220E160 VA: 0x18220FB60
	public void RemoveSubscriber(Connection cn) { }

	// RVA: 0x220F9C0 Offset: 0x220DFC0 VA: 0x18220F9C0
	public bool HasSubscribers() { }

	// RVA: 0x220FBB0 Offset: 0x220E1B0 VA: 0x18220FBB0 Slot: 3
	public override string ToString() { }

}

