internal class Group : AstNode // TypeDefIndex: 1794
{	// Fields
	private AstNode groupNode; // 0x10

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(AstNode groupNode) { }

	// RVA: 0x6F3500 Offset: 0x6F1B00 VA: 0x1806F3500 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0xAC1DA0 Offset: 0xAC03A0 VA: 0x180AC1DA0 Slot: 5
	public override XPathResultType get_ReturnType() { }

}

public class Group : Capture // TypeDefIndex: 2616
{	// Fields
	internal static Group _emptygroup; // 0x0
	internal int[] _caps; // 0x20
	internal int _capcount; // 0x28
	internal CaptureCollection _capcoll; // 0x30
	[OptionalFieldAttribute] // RVA: 0x7B620 Offset: 0x7AA20 VA: 0x18007B620
	internal string _name; // 0x38

	// Properties
	public bool Success { get; }
	public CaptureCollection Captures { get; }

	// Methods

	// RVA: 0x14BFFF0 Offset: 0x14BE5F0 VA: 0x1814BFFF0
	internal void .ctor(string text, int[] caps, int capcount, string name) { }

	// RVA: 0x14C0190 Offset: 0x14BE790 VA: 0x1814C0190
	public bool get_Success() { }

	// RVA: 0x14C00E0 Offset: 0x14BE6E0 VA: 0x1814C00E0
	public CaptureCollection get_Captures() { }

	// RVA: 0x14BFED0 Offset: 0x14BE4D0 VA: 0x1814BFED0
	private static void .cctor() { }

	// RVA: 0x14BFFC0 Offset: 0x14BE5C0 VA: 0x1814BFFC0
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

	// RVA: 0x14CAD50 Offset: 0x14C9350 VA: 0x1814CAD50
	public bool get_isGlobal() { }

	// RVA: 0x220F2F0 Offset: 0x220D8F0 VA: 0x18220F2F0
	public void .ctor(Manager m, uint id) { }

	// RVA: 0x220F050 Offset: 0x220D650 VA: 0x18220F050 Slot: 5
	public virtual void Dispose() { }

	// RVA: 0x220F0E0 Offset: 0x220D6E0 VA: 0x18220F0E0
	public void Join(Networkable nw) { }

	// RVA: 0x220F190 Offset: 0x220D790 VA: 0x18220F190
	public void Leave(Networkable nw) { }

	// RVA: 0x220EFF0 Offset: 0x220D5F0 VA: 0x18220EFF0
	public void AddSubscriber(Connection cn) { }

	// RVA: 0x220F240 Offset: 0x220D840 VA: 0x18220F240
	public void RemoveSubscriber(Connection cn) { }

	// RVA: 0x220F0A0 Offset: 0x220D6A0 VA: 0x18220F0A0
	public bool HasSubscribers() { }

	// RVA: 0x220F290 Offset: 0x220D890 VA: 0x18220F290 Slot: 3
	public override string ToString() { }

}

