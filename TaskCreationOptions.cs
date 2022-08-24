public enum TaskCreationOptions // TypeDefIndex: 862
{
[FlagsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
[Serializable]
public enum TaskCreationOptions // TypeDefIndex: 862
	public int value__; // 0x0
	public const TaskCreationOptions None = 0;
	public const TaskCreationOptions PreferFairness = 1;
	public const TaskCreationOptions LongRunning = 2;
	public const TaskCreationOptions AttachedToParent = 4;
	public const TaskCreationOptions DenyChildAttach = 8;
	public const TaskCreationOptions HideScheduler = 16;
	public const TaskCreationOptions RunContinuationsAsynchronously = 64;

}

