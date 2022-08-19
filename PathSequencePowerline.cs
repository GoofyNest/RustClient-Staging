public class PathSequencePowerline : PathSequence // TypeDefIndex: 10366
{	// Fields
	public PathSequencePowerline.SequenceRule Rule; // 0x98
	private const int RegularPowerlineSpacing = 2;

	// Methods

	// RVA: 0x869D50 Offset: 0x868350 VA: 0x180869D50 Slot: 8
	public override void ApplySequenceReplacement(List<Prefab> sequence, ref Prefab replacement, Prefab[] possibleReplacements, int pathLength, int pathIndex) { }

	// RVA: 0x86A100 Offset: 0x868700 VA: 0x18086A100
	private Prefab GetPrefabOfType(Prefab[] options, PathSequencePowerline.SequenceRule ruleToFind) { }

	// RVA: 0x869F90 Offset: 0x868590 VA: 0x180869F90
	private int GetIndexCountToRule(List<Prefab> sequence, PathSequencePowerline.SequenceRule rule) { }

	// RVA: 0x86A270 Offset: 0x868870 VA: 0x18086A270
	public void .ctor() { }

}

public enum PathSequencePowerline.SequenceRule // TypeDefIndex: 10367
{	// Fields
	public int value__; // 0x0
	public const PathSequencePowerline.SequenceRule PowerlinePlatform = 0;
	public const PathSequencePowerline.SequenceRule Powerline = 1;

}

