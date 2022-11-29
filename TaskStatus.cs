public enum TaskStatus // TypeDefIndex: 852
{
public int value__;
	public const TaskStatus Created = 0;
	public const TaskStatus WaitingForActivation = 1;
	public const TaskStatus WaitingToRun = 2;
	public const TaskStatus Running = 3;
	public const TaskStatus WaitingForChildrenToComplete = 4;
	public const TaskStatus RanToCompletion = 5;
	public const TaskStatus Canceled = 6;
	public const TaskStatus Faulted = 7;

}

