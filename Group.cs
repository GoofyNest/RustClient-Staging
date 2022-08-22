internal class Group : AstNode // TypeDefIndex: 1794
{	// Fields
	private AstNode groupNode; // 0x10

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(AstNode groupNode) { }

	// RVA: 0x6F3610 Offset: 0x6F1C10 VA: 0x1806F3610 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0xAC2060 Offset: 0xAC0660 VA: 0x180AC2060 Slot: 5
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

	// RVA: 0x14C02B0 Offset: 0x14BE8B0 VA: 0x1814C02B0
	internal void .ctor(string text, int[] caps, int capcount, string name) { }

	// RVA: 0x14C0450 Offset: 0x14BEA50 VA: 0x1814C0450
	public bool get_Success() { }

	// RVA: 0x14C03A0 Offset: 0x14BE9A0 VA: 0x1814C03A0
	public CaptureCollection get_Captures() { }

	// RVA: 0x14C0190 Offset: 0x14BE790 VA: 0x1814C0190
	private static void .cctor() { }

	// RVA: 0x14C0280 Offset: 0x14BE880 VA: 0x1814C0280
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

	// RVA: 0x14CB010 Offset: 0x14C9610 VA: 0x1814CB010
	public bool get_isGlobal() { }

	// RVA: 0x220F3F0 Offset: 0x220D9F0 VA: 0x18220F3F0
	public void .ctor(Manager m, uint id) { }

	// RVA: 0x220F150 Offset: 0x220D750 VA: 0x18220F150 Slot: 5
	public virtual void Dispose() { }

	// RVA: 0x220F1E0 Offset: 0x220D7E0 VA: 0x18220F1E0
	public void Join(Networkable nw) { }

	// RVA: 0x220F290 Offset: 0x220D890 VA: 0x18220F290
	public void Leave(Networkable nw) { }

	// RVA: 0x220F0F0 Offset: 0x220D6F0 VA: 0x18220F0F0
	public void AddSubscriber(Connection cn) { }

	// RVA: 0x220F340 Offset: 0x220D940 VA: 0x18220F340
	public void RemoveSubscriber(Connection cn) { }

	// RVA: 0x220F1A0 Offset: 0x220D7A0 VA: 0x18220F1A0
	public bool HasSubscribers() { }

	// RVA: 0x220F390 Offset: 0x220D990 VA: 0x18220F390 Slot: 3
	public override string ToString() { }

}

