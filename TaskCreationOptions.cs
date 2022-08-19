public enum TaskCreationOptions // TypeDefIndex: 862
{
// Namespace: System.Threading.Tasks
[FlagsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
[Serializable]
public enum TaskCreationOptions // TypeDefIndex: 862
	// Fields
	public int value__; // 0x0
	public const TaskCreationOptions None = 0;
	public const TaskCreationOptions PreferFairness = 1;
	public const TaskCreationOptions LongRunning = 2;
	public const TaskCreationOptions AttachedToParent = 4;
	public const TaskCreationOptions DenyChildAttach = 8;
	public const TaskCreationOptions HideScheduler = 16;
	public const TaskCreationOptions RunContinuationsAsynchronously = 64;

}

