public class PathSequencePowerline : PathSequence // TypeDefIndex: 10366
{	// Fields
	public PathSequencePowerline.SequenceRule Rule; // 0x98
	private const int RegularPowerlineSpacing = 2;

	// Methods

	// RVA: 0x869E60 Offset: 0x868460 VA: 0x180869E60 Slot: 8
	public override void ApplySequenceReplacement(List<Prefab> sequence, ref Prefab replacement, Prefab[] possibleReplacements, int pathLength, int pathIndex) { }

	// RVA: 0x86A210 Offset: 0x868810 VA: 0x18086A210
	private Prefab GetPrefabOfType(Prefab[] options, PathSequencePowerline.SequenceRule ruleToFind) { }

	// RVA: 0x86A0A0 Offset: 0x8686A0 VA: 0x18086A0A0
	private int GetIndexCountToRule(List<Prefab> sequence, PathSequencePowerline.SequenceRule rule) { }

	// RVA: 0x86A380 Offset: 0x868980 VA: 0x18086A380
	public void .ctor() { }

}

public enum PathSequencePowerline.SequenceRule // TypeDefIndex: 10367
{	// Fields
	public int value__; // 0x0
	public const PathSequencePowerline.SequenceRule PowerlinePlatform = 0;
	public const PathSequencePowerline.SequenceRule Powerline = 1;

}

