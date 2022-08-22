internal sealed class ParticleContentValidator : ContentValidator // TypeDefIndex: 2168
{	// Fields
	private SymbolsDictionary symbols; // 0x18
	private Positions positions; // 0x20
	private Stack stack; // 0x28
	private SyntaxTreeNode contentNode; // 0x30
	private bool isPartial; // 0x38
	private int minMaxNodesCount; // 0x3C
	private bool enableUpaCheck; // 0x40

	// Methods

	// RVA: 0xB19080 Offset: 0xB17680 VA: 0x180B19080
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0xB19000 Offset: 0xB17600 VA: 0x180B19000
	public void .ctor(XmlSchemaContentType contentType, bool enableUpaCheck) { }

	// RVA: 0xB18E30 Offset: 0xB17430 VA: 0x180B18E30 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0xB18FB0 Offset: 0xB175B0 VA: 0x180B18FB0 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0xB183D0 Offset: 0xB169D0 VA: 0x180B183D0 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0xB18EB0 Offset: 0xB174B0 VA: 0x180B18EB0
	public void Start() { }

	// RVA: 0xB18E80 Offset: 0xB17480 VA: 0x180B18E80
	public void OpenGroup() { }

	// RVA: 0xB18070 Offset: 0xB16670 VA: 0x180B18070
	public void CloseGroup() { }

	// RVA: 0xB18420 Offset: 0xB16A20 VA: 0x180B18420
	public bool Exists(XmlQualifiedName name) { }

	// RVA: 0xB16DF0 Offset: 0xB153F0 VA: 0x180B16DF0
	public void AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0xB16EA0 Offset: 0xB154A0 VA: 0x180B16EA0
	public void AddNamespaceList(NamespaceList namespaceList, object particle) { }

	// RVA: 0xB16C00 Offset: 0xB15200 VA: 0x180B16C00
	private void AddLeafNode(SyntaxTreeNode node) { }

	// RVA: 0xB16B00 Offset: 0xB15100 VA: 0x180B16B00
	public void AddChoice() { }

	// RVA: 0xB17020 Offset: 0xB15620 VA: 0x180B17020
	public void AddSequence() { }

	// RVA: 0xB17120 Offset: 0xB15720 VA: 0x180B17120
	public void AddStar() { }

	// RVA: 0xB16F60 Offset: 0xB15560 VA: 0x180B16F60
	public void AddPlus() { }

	// RVA: 0xB16FC0 Offset: 0xB155C0 VA: 0x180B16FC0
	public void AddQMark() { }

	// RVA: 0xB16D10 Offset: 0xB15310 VA: 0x180B16D10
	public void AddLeafRange(Decimal min, Decimal max) { }

	// RVA: 0xB18210 Offset: 0xB16810 VA: 0x180B18210
	private void Closure(InteriorNode node) { }

	// RVA: 0xB18450 Offset: 0xB16A50 VA: 0x180B18450
	public ContentValidator Finish(bool useDFA) { }

	// RVA: 0xB17740 Offset: 0xB15D40 VA: 0x180B17740
	private BitSet[] CalculateTotalFollowposForRangeNodes(BitSet firstpos, BitSet[] followpos, out BitSet posWithRangeTerminals) { }

	// RVA: 0xB17B00 Offset: 0xB16100 VA: 0x180B17B00
	private void CheckCMUPAWithLeafRangeNodes(BitSet curpos) { }

	// RVA: 0xB18C30 Offset: 0xB17230 VA: 0x180B18C30
	private BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, BitSet[] minmaxFollowPos) { }

	// RVA: 0xB17FC0 Offset: 0xB165C0 VA: 0x180B17FC0
	private void CheckUniqueParticleAttribution(BitSet firstpos, BitSet[] followpos) { }

	// RVA: 0xB17D20 Offset: 0xB16320 VA: 0x180B17D20
	private void CheckUniqueParticleAttribution(BitSet curpos) { }

	// RVA: 0xB17180 Offset: 0xB15780 VA: 0x180B17180
	private int[][] BuildTransitionTable(BitSet firstpos, BitSet[] followpos, int endMarkerPos) { }

}

