public class PathSequencePowerline : PathSequence // TypeDefIndex: 10366
{	// Fields
	public PathSequencePowerline.SequenceRule Rule; // 0x98
	private const int RegularPowerlineSpacing = 2;

	// Methods

	// RVA: 0x8855C0 Offset: 0x883BC0 VA: 0x1808855C0 Slot: 8
	public override void ApplySequenceReplacement(List<Prefab> sequence, ref Prefab replacement, Prefab[] possibleReplacements, int pathLength, int pathIndex) { }

	// RVA: 0x885970 Offset: 0x883F70 VA: 0x180885970
	private Prefab GetPrefabOfType(Prefab[] options, PathSequencePowerline.SequenceRule ruleToFind) { }

	// RVA: 0x885800 Offset: 0x883E00 VA: 0x180885800
	private int GetIndexCountToRule(List<Prefab> sequence, PathSequencePowerline.SequenceRule rule) { }

	// RVA: 0x885AE0 Offset: 0x8840E0 VA: 0x180885AE0
	public void .ctor() { }

}

public enum PathSequencePowerline.SequenceRule // TypeDefIndex: 10367
{	// Fields
	public int value__; // 0x0
	public const PathSequencePowerline.SequenceRule PowerlinePlatform = 0;
	public const PathSequencePowerline.SequenceRule Powerline = 1;

}

