internal class Axis : AstNode // TypeDefIndex: 1789
{	// Fields
	private Axis.AxisType axisType; // 0x10
	private AstNode input; // 0x18
	private string prefix; // 0x20
	private string name; // 0x28
	private XPathNodeType nodeType; // 0x30
	protected bool abbrAxis; // 0x34
	private string urn; // 0x38

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }
	public AstNode Input { get; set; }
	public string Prefix { get; }
	public string Name { get; }
	public XPathNodeType NodeType { get; }
	public Axis.AxisType TypeOfAxis { get; }
	public bool AbbrAxis { get; }
	public string Urn { get; set; }

	// Methods

	// RVA: 0x12DD890 Offset: 0x12DBE90 VA: 0x1812DD890
	public void .ctor(Axis.AxisType axisType, AstNode input, string prefix, string name, XPathNodeType nodetype) { }

	// RVA: 0x12DD940 Offset: 0x12DBF40 VA: 0x1812DD940
	public void .ctor(Axis.AxisType axisType, AstNode input) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0xAC2060 Offset: 0xAC0660 VA: 0x180AC2060 Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public AstNode get_Input() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_Input(AstNode value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Prefix() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public string get_Name() { }

	// RVA: 0xA38FA0 Offset: 0xA375A0 VA: 0x180A38FA0
	public XPathNodeType get_NodeType() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public Axis.AxisType get_TypeOfAxis() { }

	// RVA: 0xBA1D40 Offset: 0xBA0340 VA: 0x180BA1D40
	public bool get_AbbrAxis() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_Urn() { }

	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	public void set_Urn(string value) { }

}

public enum Axis.AxisType // TypeDefIndex: 1790
{	// Fields
	public int value__; // 0x0
	public const Axis.AxisType Ancestor = 0;
	public const Axis.AxisType AncestorOrSelf = 1;
	public const Axis.AxisType Attribute = 2;
	public const Axis.AxisType Child = 3;
	public const Axis.AxisType Descendant = 4;
	public const Axis.AxisType DescendantOrSelf = 5;
	public const Axis.AxisType Following = 6;
	public const Axis.AxisType FollowingSibling = 7;
	public const Axis.AxisType Namespace = 8;
	public const Axis.AxisType Parent = 9;
	public const Axis.AxisType Preceding = 10;
	public const Axis.AxisType PrecedingSibling = 11;
	public const Axis.AxisType Self = 12;
	public const Axis.AxisType None = 13;

}

