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

	// RVA: 0xB19550 Offset: 0xB17B50 VA: 0x180B19550
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0xB194D0 Offset: 0xB17AD0 VA: 0x180B194D0
	public void .ctor(XmlSchemaContentType contentType, bool enableUpaCheck) { }

	// RVA: 0xB19300 Offset: 0xB17900 VA: 0x180B19300 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0xB19480 Offset: 0xB17A80 VA: 0x180B19480 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0xB188A0 Offset: 0xB16EA0 VA: 0x180B188A0 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0xB19380 Offset: 0xB17980 VA: 0x180B19380
	public void Start() { }

	// RVA: 0xB19350 Offset: 0xB17950 VA: 0x180B19350
	public void OpenGroup() { }

	// RVA: 0xB18540 Offset: 0xB16B40 VA: 0x180B18540
	public void CloseGroup() { }

	// RVA: 0xB188F0 Offset: 0xB16EF0 VA: 0x180B188F0
	public bool Exists(XmlQualifiedName name) { }

	// RVA: 0xB172C0 Offset: 0xB158C0 VA: 0x180B172C0
	public void AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0xB17370 Offset: 0xB15970 VA: 0x180B17370
	public void AddNamespaceList(NamespaceList namespaceList, object particle) { }

	// RVA: 0xB170D0 Offset: 0xB156D0 VA: 0x180B170D0
	private void AddLeafNode(SyntaxTreeNode node) { }

	// RVA: 0xB16FD0 Offset: 0xB155D0 VA: 0x180B16FD0
	public void AddChoice() { }

	// RVA: 0xB174F0 Offset: 0xB15AF0 VA: 0x180B174F0
	public void AddSequence() { }

	// RVA: 0xB175F0 Offset: 0xB15BF0 VA: 0x180B175F0
	public void AddStar() { }

	// RVA: 0xB17430 Offset: 0xB15A30 VA: 0x180B17430
	public void AddPlus() { }

	// RVA: 0xB17490 Offset: 0xB15A90 VA: 0x180B17490
	public void AddQMark() { }

	// RVA: 0xB171E0 Offset: 0xB157E0 VA: 0x180B171E0
	public void AddLeafRange(Decimal min, Decimal max) { }

	// RVA: 0xB186E0 Offset: 0xB16CE0 VA: 0x180B186E0
	private void Closure(InteriorNode node) { }

	// RVA: 0xB18920 Offset: 0xB16F20 VA: 0x180B18920
	public ContentValidator Finish(bool useDFA) { }

	// RVA: 0xB17C10 Offset: 0xB16210 VA: 0x180B17C10
	private BitSet[] CalculateTotalFollowposForRangeNodes(BitSet firstpos, BitSet[] followpos, out BitSet posWithRangeTerminals) { }

	// RVA: 0xB17FD0 Offset: 0xB165D0 VA: 0x180B17FD0
	private void CheckCMUPAWithLeafRangeNodes(BitSet curpos) { }

	// RVA: 0xB19100 Offset: 0xB17700 VA: 0x180B19100
	private BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, BitSet[] minmaxFollowPos) { }

	// RVA: 0xB18490 Offset: 0xB16A90 VA: 0x180B18490
	private void CheckUniqueParticleAttribution(BitSet firstpos, BitSet[] followpos) { }

	// RVA: 0xB181F0 Offset: 0xB167F0 VA: 0x180B181F0
	private void CheckUniqueParticleAttribution(BitSet curpos) { }

	// RVA: 0xB17650 Offset: 0xB15C50 VA: 0x180B17650
	private int[][] BuildTransitionTable(BitSet firstpos, BitSet[] followpos, int endMarkerPos) { }

}

