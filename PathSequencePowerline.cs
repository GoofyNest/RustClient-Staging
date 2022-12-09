public class PathSequencePowerline : PathSequence // TypeDefIndex: 12134
{
	public PathSequencePowerline.SequenceRule Rule;
	private const int RegularPowerlineSpacing = 2;


	public override void ApplySequenceReplacement(List<Prefab> sequence, ref Prefab replacement, Prefab[] possibleReplacements, int pathLength, int pathIndex) { }

	private Prefab GetPrefabOfType(Prefab[] options, PathSequencePowerline.SequenceRule ruleToFind) { }

	private int GetIndexCountToRule(List<Prefab> sequence, PathSequencePowerline.SequenceRule rule) { }

	public void .ctor() { }

}

public enum PathSequencePowerline.SequenceRule // TypeDefIndex: 12135
{
	public int value__;
	public const PathSequencePowerline.SequenceRule PowerlinePlatform = 0;
	public const PathSequencePowerline.SequenceRule Powerline = 1;

}

