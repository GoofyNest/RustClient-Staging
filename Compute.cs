public enum Compute_DistanceTransform_EventTypes // TypeDefIndex: 6785
{
	public int value__; 
	public const Compute_DistanceTransform_EventTypes Processing = 0;
	public const Compute_DistanceTransform_EventTypes Completed = 1;

}

public class Compute_DT_EventArgs // TypeDefIndex: 6787
{
	public Compute_DistanceTransform_EventTypes EventType; 
	public float ProgressPercentage; 
	public Color[] Colors; 


	public void .ctor(Compute_DistanceTransform_EventTypes type, float progress) { }

	public void .ctor(Compute_DistanceTransform_EventTypes type, Color[] colors) { }

}

