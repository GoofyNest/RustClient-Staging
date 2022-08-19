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

	// RVA: 0xB18DC0 Offset: 0xB173C0 VA: 0x180B18DC0
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0xB18D40 Offset: 0xB17340 VA: 0x180B18D40
	public void .ctor(XmlSchemaContentType contentType, bool enableUpaCheck) { }

	// RVA: 0xB18B70 Offset: 0xB17170 VA: 0x180B18B70 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0xB18CF0 Offset: 0xB172F0 VA: 0x180B18CF0 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0xB18110 Offset: 0xB16710 VA: 0x180B18110 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0xB18BF0 Offset: 0xB171F0 VA: 0x180B18BF0
	public void Start() { }

	// RVA: 0xB18BC0 Offset: 0xB171C0 VA: 0x180B18BC0
	public void OpenGroup() { }

	// RVA: 0xB17DB0 Offset: 0xB163B0 VA: 0x180B17DB0
	public void CloseGroup() { }

	// RVA: 0xB18160 Offset: 0xB16760 VA: 0x180B18160
	public bool Exists(XmlQualifiedName name) { }

	// RVA: 0xB16B30 Offset: 0xB15130 VA: 0x180B16B30
	public void AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0xB16BE0 Offset: 0xB151E0 VA: 0x180B16BE0
	public void AddNamespaceList(NamespaceList namespaceList, object particle) { }

	// RVA: 0xB16940 Offset: 0xB14F40 VA: 0x180B16940
	private void AddLeafNode(SyntaxTreeNode node) { }

	// RVA: 0xB16840 Offset: 0xB14E40 VA: 0x180B16840
	public void AddChoice() { }

	// RVA: 0xB16D60 Offset: 0xB15360 VA: 0x180B16D60
	public void AddSequence() { }

	// RVA: 0xB16E60 Offset: 0xB15460 VA: 0x180B16E60
	public void AddStar() { }

	// RVA: 0xB16CA0 Offset: 0xB152A0 VA: 0x180B16CA0
	public void AddPlus() { }

	// RVA: 0xB16D00 Offset: 0xB15300 VA: 0x180B16D00
	public void AddQMark() { }

	// RVA: 0xB16A50 Offset: 0xB15050 VA: 0x180B16A50
	public void AddLeafRange(Decimal min, Decimal max) { }

	// RVA: 0xB17F50 Offset: 0xB16550 VA: 0x180B17F50
	private void Closure(InteriorNode node) { }

	// RVA: 0xB18190 Offset: 0xB16790 VA: 0x180B18190
	public ContentValidator Finish(bool useDFA) { }

	// RVA: 0xB17480 Offset: 0xB15A80 VA: 0x180B17480
	private BitSet[] CalculateTotalFollowposForRangeNodes(BitSet firstpos, BitSet[] followpos, out BitSet posWithRangeTerminals) { }

	// RVA: 0xB17840 Offset: 0xB15E40 VA: 0x180B17840
	private void CheckCMUPAWithLeafRangeNodes(BitSet curpos) { }

	// RVA: 0xB18970 Offset: 0xB16F70 VA: 0x180B18970
	private BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, BitSet[] minmaxFollowPos) { }

	// RVA: 0xB17D00 Offset: 0xB16300 VA: 0x180B17D00
	private void CheckUniqueParticleAttribution(BitSet firstpos, BitSet[] followpos) { }

	// RVA: 0xB17A60 Offset: 0xB16060 VA: 0x180B17A60
	private void CheckUniqueParticleAttribution(BitSet curpos) { }

	// RVA: 0xB16EC0 Offset: 0xB154C0 VA: 0x180B16EC0
	private int[][] BuildTransitionTable(BitSet firstpos, BitSet[] followpos, int endMarkerPos) { }

}

